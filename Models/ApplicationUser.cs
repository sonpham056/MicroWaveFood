using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace MicroWaveFood.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        [Display(Name = "Tên người dùng")]
        [StringLength(255, ErrorMessage = "Tên không được quá 255 ký tự!")]
        public string Name { get; set; }
        [Display(Name = "Tỉnh / TP")]
        public string Province { get; set; }
        [Display(Name = "Quận / huyện")]
        public string District { get; set; }
        [Display(Name = "Phường / xã")]
        [StringLength(255, ErrorMessage = "Phường/xã quá dài")]
        public string Guild { get; set; }
        [Display(Name = "Địa chỉ")]
        [StringLength(255, ErrorMessage = "Địa chỉ quá dài!")]
        public string Address { get; set; }
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    
}