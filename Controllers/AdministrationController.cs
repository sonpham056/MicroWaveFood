using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using MicroWaveFood.Models;
using MicroWaveFood.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace MicroWaveFood.Controllers
{
    [Authorize(Roles = "admin")]
    public class AdministrationController : Controller
    {
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly UserManager<ApplicationUser> userManager;
        private readonly ApplicationDbContext _dbContext;

        public AdministrationController()
        {
            _dbContext = new ApplicationDbContext();
            roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(_dbContext));
            userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(_dbContext));
        }
        // GET: Administration
        public ActionResult Index()
        {
            return RedirectToAction("ListRoles");
        }

        [HttpGet]
        public ActionResult CreateRole()
        {
            return View();
        }
        [HttpPost]
        public async Task<ActionResult> CreateRole(CreateRoleViewModel model)
        {
            if (ModelState.IsValid)
            {
                IdentityRole identity = new IdentityRole
                {
                    Name = model.RoleName
                };

                IdentityResult result = await roleManager.CreateAsync(identity);
                if (result.Succeeded)
                {
                    return RedirectToAction("ListRoles", "Administration");
                }

                foreach (string error in result.Errors)
                {
                    ModelState.AddModelError("", error);
                }
            }
            return View(model);
        }
        [AllowAnonymous]
        public async Task<ActionResult> CreateRoleAdmin()
        {

            IdentityRole identity = new IdentityRole
            {
                Name = "admin"
            };

            IdentityResult result = await roleManager.CreateAsync(identity);
            if (result.Succeeded)
            {
                return RedirectToAction("ListRoles", "Administration");
            }

            foreach (string error in result.Errors)
            {
                ModelState.AddModelError("", error);
            }
            //if u got this far, its mean admin has already exist
            ViewBag.Message = "admin role has already exist";
            return View("Error");
        }

        [HttpGet]
        public ActionResult ListRoles()
        {
            var roles = roleManager.Roles;
            return View(roles);
        }

        [HttpGet]
        public async Task<ActionResult> Edit(string id)
        {
            var role = await roleManager.FindByIdAsync(id);
            if (role == null)
            {
                return View("Error");
            }

            var roleView = new EditRoleViewModel
            {
                Id = id,
                Name = role.Name,
            };

            foreach (var user in userManager.Users.ToList())
            {
                if (await userManager.IsInRoleAsync(user.Id, roleView.Name))
                {
                    roleView.Users.Add(user.Email);
                }
            }
            return View(roleView);
        }

        [HttpPost]
        public async Task<ActionResult> Edit(EditRoleViewModel model)
        {
            var role = await roleManager.FindByIdAsync(model.Id);
            if (role == null)
            {
                return View("Error");
            }

            role.Name = model.Name;
            await roleManager.UpdateAsync(role);
            return RedirectToAction("ListRoles");
        }

        [HttpGet]
        public async Task<ActionResult> ManageRole(string id)
        {
            ViewBag.roleId = id;
            var role = await roleManager.FindByIdAsync(id);
            if (role == null)
            {
                return View("Error");
            }
            var list = new List<UserRoleViewModel>();
            foreach (var item in userManager.Users.ToList())
            {
                var userRole = new UserRoleViewModel
                {
                    RoleId = role.Id,
                    UserId = item.Id,
                    UserName = item.UserName
                };

                if (await userManager.IsInRoleAsync(userRole.UserId, role.Name))
                {
                    userRole.IsSelected = true;
                }
                else
                {
                    userRole.IsSelected = false;
                }
                list.Add(userRole);
            }
            return View(list);
        }

        [HttpPost]
        public async Task<ActionResult> ManageRole(List<UserRoleViewModel> list, string id)
        {
            var role = await roleManager.FindByIdAsync(id);
            if (role == null)
            {
                return View("Error");
            }
            foreach (var user in list)
            {
                if (user.IsSelected == true && !(await userManager.IsInRoleAsync(user.UserId, role.Name)))
                {
                    var update = await userManager.FindByIdAsync(user.UserId);
                    try
                    {
                        await userManager.AddToRoleAsync(update.Id, role.Name);
                    }
                    catch (DbEntityValidationException dbEx)
                    {
                        foreach (var validationErrors in dbEx.EntityValidationErrors)
                        {
                            foreach (var validationError in validationErrors.ValidationErrors)
                            {
                                Debug.WriteLine("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                            }
                        }
                    }

                }
                else if (user.IsSelected != true && (await userManager.IsInRoleAsync(user.UserId, role.Name)))
                {
                    var update = await userManager.FindByIdAsync(user.UserId);
                    await userManager.RemoveFromRoleAsync(update.Id, role.Name);
                }
                else
                {
                    continue;
                }
            }
            return RedirectToAction("Edit", "Administration", new { id = id });
        }
        [AllowAnonymous]
        public async Task<ActionResult> AddRoleToAdmin()
        {
            var role = await roleManager.FindByNameAsync("admin");
            if (role == null)
            {
                return View("Error");
            }
            var update = await userManager.FindByEmailAsync("microwaveadmin@gmail.com");
            try
            {
                await userManager.AddToRoleAsync(update.Id, role.Name);
            }
            catch (DbEntityValidationException dbEx)
            {
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        Debug.WriteLine("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                    }
                }
            }
            return RedirectToAction("Edit", "Administration", new { id = role.Id });
        }
    }
}