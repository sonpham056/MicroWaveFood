namespace MicroWaveFood.Migrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using MicroWaveFood.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Diagnostics;
    using System.Linq;
    using System.Web;

    internal sealed class Configuration : DbMigrationsConfiguration<MicroWaveFood.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MicroWaveFood.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            //nguyenlieu
            var producttypes = new List<ProductType>
            {
               new ProductType{Name="Whipping",GroupType="Nguyên liệu làm bánh",Image = "/Images/Image_producttype/Whipping_producttype.jpeg", Status = true },
               new ProductType{Name="Cheese",GroupType="Nguyên liệu làm bánh",Image = "/Images/Image_producttype/Cheese_producttype.jpeg", Status = true },
               new ProductType{Name="Hạt,quả khô",GroupType="Nguyên liệu làm bánh",Image = "/Images/Image_producttype/Hatquakho_producttype.jpeg", Status = true },
               new ProductType{Name="Bơ",GroupType="Nguyên liệu làm bánh",Image = "/Images/Image_producttype/Bodp_producttype.jpeg", Status = true },
               new ProductType{Name="Sữa",GroupType="Nguyên liệu làm bánh",Image = "/Images/Image_producttype/Botsua_producttype.jpeg", Status = true },
               new ProductType{Name="Đường",GroupType="Nguyên liệu làm bánh",Image = "/Images/Image_producttype/Duong_producttype.jpeg", Status = true },
               new ProductType{Name="Topping",GroupType="Nguyên liệu làm bánh",Image = "/Images/Image_producttype/ToppingKembeo_producttype.jpeg", Status = true },
               new ProductType{Name="Bột mì",GroupType="Nguyên liệu làm bánh",Image = "/Images/Image_producttype/Botmi_producttype.jpeg", Status = true },
               new ProductType{Name="Bột trộn sẵn",GroupType="Nguyên liệu làm bánh",Image = "/Images/Image_producttype/BottronsanBotbanhbao_producttype.jpeg", Status = true },
               new ProductType{Name="Gelatin",GroupType="Nguyên liệu làm bánh",Image = "/Images/Image_producttype/Gelatin_producttype.png", Status = true },
               new ProductType{Name="Rau câu",GroupType="Nguyên liệu làm bánh",Image = "/Images/Image_producttype/Raucau_producttype.jpeg", Status = true },
               new ProductType{Name="Chocochip",GroupType="Nguyên liệu làm bánh",Image = "/Images/Image_producttype/Chocochip_producttype.png", Status = true },
               new ProductType{Name="Socola",GroupType="Nguyên liệu làm bánh",Image = "/Images/Image_producttype/Socola_producttype.jpeg", Status = true },
               new ProductType{Name="Men",GroupType="Nguyên liệu làm bánh",Image = "/Images/Image_producttype/MenBotno_producttype.jpeg", Status = true },
               new ProductType{Name="Sữa",GroupType="Nguyên liệu làm bánh",Image = "/Images/Image_producttype/Botsua_producttype.jpeg", Status = true },
               new ProductType{Name="Tinh dầu",GroupType="Nguyên liệu làm bánh",Image = "/Images/Image_producttype/TinhdauVani_producttype.jpeg", Status = true },
               new ProductType{Name="Màu thực phẩm",GroupType="Nguyên liệu làm bánh",Image = "/Images/Image_producttype/Mauvangdong_producttype.jpeg", Status = true },
               new ProductType{Name="Màu tự nhiên",GroupType="Nguyên liệu làm bánh",Image = "/Images/Image_producttype/Botlanep_producttype.jpeg", Status = true },
               new ProductType{Name="Nguyên liệu trang trí",GroupType="Nguyên liệu làm bánh",Image = "/Images/Image_producttype/AFC_producttype.jpeg", Status = true },
            };
            producttypes.ForEach(s => context.productTypes.Add(s));
            context.SaveChanges();

            ////dungcu
            var producttypes_dungcu = new List<ProductType>
            {
                new ProductType{Name="Dụng cụ cơ bản",GroupType="Dụng cụ làm bánh",Image = "/Images/Image_producttype_dungcu/banxoaykinh_producttype.jpeg", Status = true },
                new ProductType{Name="Dụng cụ đong",GroupType="Dụng cụ làm bánh",Image = "/Images/Image_producttype_dungcu/dungcudong_producttype.jpeg", Status = true },
                new ProductType{Name="Cân điện tử",GroupType="Dụng cụ làm bánh",Image = "/Images/Image_producttype_dungcu/candientu_producttype.png", Status = true },
                new ProductType{Name="Nhiệt kế ",GroupType="Dụng cụ làm bánh",Image = "/Images/Image_producttype_dungcu/nhietke_producttype.jpeg", Status = true },
                new ProductType{Name="Dụng cụ đánh trứng",GroupType="Dụng cụ làm bánh",Image = "/Images/Image_producttype_dungcu/maydanhtrung_producttype.jpeg", Status = true },
                new ProductType{Name="Dụng cụ bát trộn",GroupType="Dụng cụ làm bánh",Image = "/Images/Image_producttype_dungcu/battron_producttype.jpeg", Status = true },
                new ProductType{Name="Dụng cụ cán ép",GroupType="Dụng cụ làm bánh",Image = "/Images/Image_producttype_dungcu/Canep_producttype.jpeg", Status = true },
                new ProductType{Name="Dụng cụ cây cán bột",GroupType="Dụng cụ làm bánh",Image = "/Images/Image_producttype_dungcu/caycanbot_producttype.jpeg", Status = true },
                new ProductType{Name="Dụng cụ rây bột",GroupType="Dụng cụ làm bánh",Image = "/Images/Image_producttype_dungcu/raybot_producttype.jpeg", Status = true },
                new ProductType{Name="Dụng cụ làm fondant",GroupType="Dụng cụ làm bánh",Image = "/Images/Image_producttype_dungcu/Fondant_producttype.jpeg", Status = true },
                new ProductType{Name="Dụng cụ đui bắt kem",GroupType="Dụng cụ làm bánh",Image = "/Images/Image_producttype_dungcu/Duibatkem_producttype.jpeg", Status = true },
                new ProductType{Name="Kim thạch rau câu 3D",GroupType="Dụng cụ làm bánh",Image = "/Images/Image_producttype_dungcu/Kimraucau3d_producttype.jpeg", Status = true },
            };
            producttypes_dungcu.ForEach(s => context.productTypes.Add(s));
            context.SaveChanges();

            ////khuonkhay
            var producttypes_khonkhay = new List<ProductType>
            {
                new ProductType{Name="Khuôn gato",GroupType="Khuôn khay làm bánh",Image = "/Images/Image_producttype_khuonkhay/khuongatoVuong_producttype.jpeg", Status = true },
                new ProductType{Name="Khay nướng",GroupType="Khuôn khay làm bánh",Image = "/Images/Image_producttype_khuonkhay/khaynuong_producttype.jpeg", Status = true },
                new ProductType{Name="Khuôn cupcake",GroupType="Khuôn khay làm bánh",Image = "/Images/Image_producttype_khuonkhay/Cupcake_producttype.jpeg", Status = true },
                new ProductType{Name="Khuôn bánh mỳ",GroupType="Khuôn khay làm bánh",Image = "/Images/Image_producttype_khuonkhay/khaynuongbanhmy_producttype.jpeg", Status = true },
                new ProductType{Name="Pizza",GroupType="Khuôn khay làm bánh",Image = "/Images/Image_producttype_khuonkhay/khuonpizza_producttype.jpeg", Status = true },
                new ProductType{Name="Khuôn thạch",GroupType="Khuôn khay làm bánh",Image = "/Images/Image_producttype_khuonkhay/khuonthach_producttype.jpeg", Status = true },
                new ProductType{Name="Khuôn kem",GroupType="Khuôn khay làm bánh",Image = "/Images/Image_producttype_khuonkhay/khuonkem_producttype.jpeg", Status = true },
                new ProductType{Name="Khuôn mousse",GroupType="Khuôn khay làm bánh",Image = "/Images/Image_producttype_khuonkhay/khuonMousse_producttype.jpeg", Status = true },
                new ProductType{Name="Khuôn tart",GroupType="Khuôn khay làm bánh",Image = "/Images/Image_producttype_khuonkhay/khuonTart_producttype.jpeg", Status = true },

            };
            producttypes_khonkhay.ForEach(s => context.productTypes.Add(s));
            context.SaveChanges();

            ////tui - hop - coc - lo
            var producttypes_tuihopcoclo = new List<ProductType>
            {
                new ProductType{Name="Túi giấy",GroupType="Túi,hộp,cốc,lọ",Image = "/Images/Image_producttype_lycoclo/tuigiay_producttype.png", Status = true },
                new ProductType{Name="Cup giấy",GroupType="Túi,hộp,cốc,lọ",Image = "/Images/Image_producttype_lycoclo/cupgiay_producttype.jpeg", Status = true },
                new ProductType{Name="Túi đựng socola",GroupType="Túi,hộp,cốc,lọ",Image = "/Images/Image_producttype_lycoclo/cupdungsocola_producttype.jpeg", Status = true },
                new ProductType{Name="Đế bánh",GroupType="Túi,hộp,cốc,lọ",Image = "/Images/Image_producttype_lycoclo/debanhchunhat_producttype.jpeg", Status = true },
                new ProductType{Name="Hộp giấy",GroupType="Túi,hộp,cốc,lọ",Image = "/Images/Image_producttype_lycoclo/hopdung_producttype.jpeg", Status = true },
                new ProductType{Name="Hộp nhựa",GroupType="Túi,hộp,cốc,lọ",Image = "/Images/Image_producttype_lycoclo/hopnhua_producttype.png", Status = true },
                new ProductType{Name="Hộp thiếc",GroupType="Túi,hộp,cốc,lọ",Image = "/Images/Image_producttype_lycoclo/hopthiec_producttype.jpeg", Status = true },
                new ProductType{Name="Túi Zip đáy đứng",GroupType="Túi,hộp,cốc,lọ",Image = "/Images/Image_producttype_lycoclo/tuiZipdaydung_producttype.jpeg", Status = true },
                new ProductType{Name="Nến sinh nhật",GroupType="Túi,hộp,cốc,lọ",Image = "/Images/Image_producttype_lycoclo/nenphaobong_producttype.jpeg", Status = true },
                new ProductType{Name="Đồ tổ chức party",GroupType="Túi,hộp,cốc,lọ",Image = "/Images/Image_producttype_lycoclo/Icon_producttype.jpeg", Status = true },
                new ProductType{Name="Hình dán",GroupType="Túi,hộp,cốc,lọ",Image = "/Images/Image_producttype_lycoclo/hinhdan_producttype.jpeg", Status = true },
                new ProductType{Name="Dây buộc",GroupType="Túi,hộp,cốc,lọ",Image = "/Images/Image_producttype_lycoclo/daybuoc_producttype.jpeg", Status = true },
            };
            producttypes_tuihopcoclo.ForEach(s => context.productTypes.Add(s));
            context.SaveChanges();
            //// Mon Á
            var producttypes_monA = new List<ProductType>
            {
                new ProductType{Name="Bột chiên",GroupType="Món Á",Image = "/Images/Image_producttype_monA/botchien_producttype.jpeg", Status = true },
                new ProductType{Name="Bột phô mai lắc",GroupType="Món Á",Image = "/Images/Image_producttype_monA/phomailac_producttype.jpeg", Status = true },
                new ProductType{Name="Nguyên liệu Hàn Nhật",GroupType="Món Á",Image = "/Images/Image_producttype_monA/banhgao_producttype.jpeg", Status = true },
                new ProductType{Name="Nguyên liệu Thái",GroupType="Món Á",Image = "/Images/Image_producttype_monA/lauthai_producttype.jpeg", Status = true },
                new ProductType{Name="Trứng",GroupType="Món Á",Image = "/Images/Image_producttype_monA/trung_producttype.jpeg" },
                new ProductType{Name="Gia vị truyền thống",GroupType="Món Á",Image = "/Images/Image_producttype_monA/botcari_producttype.jpeg", Status = true },
                new ProductType{Name="Dầu mè, hắc xì dầu",GroupType="Món Á",Image = "/Images/Image_producttype_monA/dauhao_producttype.jpeg", Status = true },
            };
            producttypes_monA.ForEach(s => context.productTypes.Add(s));
            context.SaveChanges();
            ////Mon Âu
            var producttypes_monAu = new List<ProductType>
            {
                new ProductType{Name="Chesse(phô mai)",GroupType="Món Âu",Image = "/Images/Image_producttype_monAu/botphomai_producttype.jpeg", Status = true },
                new ProductType{Name="Đồ làm mì Ý",GroupType="Món Âu",Image = "/Images/Image_producttype_monAu/myY_producttype.jpeg", Status = true },
                new ProductType{Name="Đồ làm Pizza",GroupType="Món Âu",Image = "/Images/Image_producttype_monAu/dePizza_producttype.png", Status = true },
                new ProductType{Name="Tương ớt",GroupType="Món Âu",Image = "/Images/Image_producttype_monAu/tuongot_producttype.png", Status = true },
                new ProductType{Name="Tương cà",GroupType="Món Âu",Image = "/Images/Image_producttype_monAu/tuongca_producttype.png", Status = true },
                new ProductType{Name="Mật ong",GroupType="Món Âu",Image = "/Images/Image_producttype_monAu/matong_producttype.jpeg", Status = true },
            };
            producttypes_monAu.ForEach(s => context.productTypes.Add(s));
            context.SaveChanges();
            ////Dụng cụ nấu ăn
            var producttypes_dungcuNauan = new List<ProductType>
            {
                new ProductType{Name="Đồ làm pento",GroupType="Dụng cụ nấu ăn",Image = "/Images/Image_producttype_DCnauan/khuonnhua_producttype.jpeg", Status = true },
                new ProductType{Name="Mành cuộn cơm",GroupType="Dụng cụ nấu ăn",Image = "/Images/Image_producttype_DCnauan/manhcuon_producttype.jpeg", Status = true },
                new ProductType{Name="Chảo rán",GroupType="Dụng cụ nấu ăn",Image = "/Images/Image_producttype_DCnauan/KhuonNuong_producttype.jpeg", Status = true },
            };
            producttypes_dungcuNauan.ForEach(s => context.productTypes.Add(s));
            context.SaveChanges();
            ////Nguyên liệu lẩu nướng
            var producttypes_lauNuong = new List<ProductType>
            {
                new ProductType{Name="Viên thả lẩu",GroupType="Nguyên liệu lẩu nướng",Image = "/Images/Image_producttype_launuong/Vienthalau_producttype.png", Status = true },
                new ProductType{Name="Thịt nhập khẩu",GroupType="Nguyên liệu lẩu nướng",Image = "/Images/Image_producttype_launuong/thit_producttype.png", Status = true },
                new ProductType{Name="Thịt nguội",GroupType="Nguyên liệu lẩu nướng",Image = "/Images/Image_producttype_launuong/thitnguoi_producttype.png", Status = true },
                new ProductType{Name="Gia vị lẩu nướng",GroupType="Nguyên liệu lẩu nướng",Image = "/Images/Image_producttype_launuong/giavi_producttype.jpeg", Status = true },
                new ProductType{Name="Mì sợi",GroupType="Nguyên liệu lẩu nướng",Image = "/Images/Image_producttype_launuong/misoi_producttype.png", Status = true },
            };
            producttypes_lauNuong.ForEach(s => context.productTypes.Add(s));
            context.SaveChanges();
            ////Nguyên liệu pha chế
            var producttypes_NLphache = new List<ProductType>
            {
                new ProductType{Name="Trà",GroupType="Nguyên liệu pha chế",Image = "/Images/Image_producttype_NLphache/tra_producttype.jpeg", Status = true },
                new ProductType{Name="Sữa pha chế",GroupType="Nguyên liệu pha chế",Image = "/Images/Image_producttype_NLphache/botsua_producttype.jpeg", Status = true },
                new ProductType{Name="Siro",GroupType="Nguyên liệu pha chế",Image = "/Images/Image_producttype_NLphache/siro_producttype.jpeg", Status = true },
                new ProductType{Name="Sinh tố",GroupType="Nguyên liệu pha chế",Image = "/Images/Image_producttype_NLphache/sinhto_producttype.jpeg", Status = true },
                new ProductType{Name="Pudding",GroupType="Nguyên liệu pha chế",Image = "/Images/Image_producttype_NLphache/pudding_producttype.png", Status = true },
                new ProductType{Name="Trân châu",GroupType="Nguyên liệu pha chế",Image = "/Images/Image_producttype_NLphache/tranchau_producttype.jpeg", Status = true },
                new ProductType{Name="Nước cốt dừa",GroupType="Nguyên liệu pha chế",Image = "/Images/Image_producttype_NLphache/nuoccotdua_producttype.jpeg", Status = true },
            };
            producttypes_NLphache.ForEach(s => context.productTypes.Add(s));
            context.SaveChanges();
            ////Dụng cụ pha chế
            var producttypes_DCphache = new List<ProductType>
            {
                 new ProductType{Name="Bình lắc",GroupType="Dụng cụ pha chế ",Image = "/Images/Image_producttype_DCphache/binhlac_producttype.jpeg", Status = true },
                 new ProductType{Name="Ly đong",GroupType="Dụng cụ pha chế ",Image = "/Images/Image_producttype_DCphache/lydong_producttype.jpeg", Status = true },
                 new ProductType{Name="Muỗng khuấy",GroupType="Dụng cụ pha chế ",Image = "/Images/Image_producttype_DCphache/muongkhuay_producttype.jpeg", Status = true },
                 new ProductType{Name="Rây lọc pha chế",GroupType="Dụng cụ pha chế ",Image = "/Images/Image_producttype_DCphache/rayloc_producttype.jpeg", Status = true },
                 new ProductType{Name="Cốc nhựa",GroupType="Dụng cụ pha chế ",Image = "/Images/Image_producttype_DCphache/cocnhua_producttype.jpeg", Status = true },
                 new ProductType{Name="Ống hút ",GroupType="Dụng cụ pha chế ",Image = "/Images/Image_producttype_DCphache/onghut_producttype.jpeg", Status = true },

            };
            producttypes_DCphache.ForEach(s => context.productTypes.Add(s));
            context.SaveChanges();











            //Producttttttttttt
            var products = new List<Product>
            {
                //nguyen liệu làm bánh
               new Product{ProductTypeId = 1,ProductName="Whipping",Image = "/Images/Image_producttype/Whipping_producttype.jpeg",ProductDescribe = "Sản phẩm này là",Price = 100000,Unit = "Hộp",Date = DateTime.Parse("2021/09/01"),Quantity =10, status = true,Origin="Việt Nam" },
               new Product{ProductTypeId = 2,ProductName="Cheese",Image = "/Images/Image_producttype/Cheese_producttype.jpeg", ProductDescribe = "Sản phẩm này là",Price = 500000,Unit = "Hộp",Date = DateTime.Parse("2021/09/01"),Quantity =10, status = true,Origin="Việt Nam" },
               new Product{ProductTypeId = 3,ProductName="Hạt,quả khô",Image = "/Images/Image_producttype/Hatquakho_producttype.jpeg", ProductDescribe = "Sản phẩm này là",Price = 10000,Unit = "Bịch",Date = DateTime.Parse("2021/09/01"),Quantity =10, status = true,Origin="Việt Nam" },
               new Product{ProductTypeId = 4,ProductName="Bơ",Image = "/Images/Image_producttype/Bodp_producttype.jpeg", ProductDescribe = "Sản phẩm này là",Price = 10000,Unit = "Lọ",Date = DateTime.Parse("2021/09/01"),Quantity =10, status = true,Origin="Việt Nam" },
               new Product{ProductTypeId = 5,ProductName="Sữa",Image = "/Images/Image_producttype/Botsua_producttype.jpeg",ProductDescribe = "Sản phẩm này là",Price = 600000,Unit = "Bịch",Date = DateTime.Parse("2021/09/01"),Quantity =10, status = true,Origin="Việt Nam" },
               new Product{ProductTypeId = 6,ProductName="Đường",Image = "/Images/Image_producttype/Duong_producttype.jpeg", ProductDescribe = "Sản phẩm này là",Price = 100000,Unit = "Bịch",Date = DateTime.Parse("2021/09/01"),Quantity =10, status = true,Origin="Việt Nam" },
               new Product{ProductTypeId = 7,ProductName="Topping",Image = "/Images/Image_producttype/ToppingKembeo_producttype.jpeg", ProductDescribe = "Sản phẩm này là",Price = 130000,Unit = "Hộp",Date = DateTime.Parse("2021/09/01"),Quantity =10, status = true,Origin="Việt Nam" },
               new Product{ProductTypeId = 8,ProductName="Bột mì",Image = "/Images/Image_producttype/Botmi_producttype.jpeg", ProductDescribe = "Sản phẩm này là",Price = 160000,Unit = "Bịch",Date = DateTime.Parse("2021/09/01"),Quantity =10, status = true,Origin="Việt Nam" },
               new Product{ProductTypeId = 9,ProductName="Bột trộn sẵn",Image = "/Images/Image_producttype/BottronsanBotbanhbao_producttype.jpeg", ProductDescribe = "Sản phẩm này là",Price = 180000,Unit = "Bịch",Date = DateTime.Parse("2021/09/01"),Quantity =10, status = true,Origin="Việt Nam" },
               new Product{ProductTypeId = 10,ProductName="Gelatin",Image = "/Images/Image_producttype/Gelatin_producttype.png", ProductDescribe = "Sản phẩm này là",Price = 110000,Unit = "Bịch",Date = DateTime.Parse("2021/09/01"),Quantity =10, status = true,Origin="Việt Nam" },
               new Product{ProductTypeId = 11,ProductName="Rau câu",Image = "/Images/Image_producttype/Raucau_producttype.jpeg", ProductDescribe = "Sản phẩm này là",Price = 190000,Unit = "Bịch",Date = DateTime.Parse("2021/09/01"),Quantity =10, status = true,Origin="Việt Nam" },
               new Product{ProductTypeId = 12,ProductName="Chocochip",Image = "/Images/Image_producttype/Chocochip_producttype.png", ProductDescribe = "Sản phẩm này là",Price = 100000,Unit = "Bịch",Date = DateTime.Parse("2021/09/01"),Quantity =10, status = true,Origin="Việt Nam" },
               new Product{ProductTypeId = 13,ProductName="Socola",Image = "/Images/Image_producttype/Socola_producttype.jpeg",ProductDescribe = "Sản phẩm này là",Price = 103000,Unit = "Hộp",Date = DateTime.Parse("2021/09/01"),Quantity =10, status = true,Origin="Việt Nam" },
               new Product{ProductTypeId = 14,ProductName="Men",Image = "/Images/Image_producttype/MenBotno_producttype.jpeg", ProductDescribe = "Sản phẩm này là",Price = 108000,Unit = "Chai",Date = DateTime.Parse("2021/09/01"),Quantity =10, status = true,Origin="Việt Nam" },
               new Product{ProductTypeId = 15,ProductName="Sữa",Image = "/Images/Image_producttype/Botsua_producttype.jpeg", ProductDescribe = "Sản phẩm này là",Price = 102000,Unit = "Bịch",Date = DateTime.Parse("2021/09/01"),Quantity =10, status = true,Origin="Việt Nam" },
               new Product{ProductTypeId = 16,ProductName="Tinh dầu",Image = "/Images/Image_producttype/TinhdauVani_producttype.jpeg", ProductDescribe = "Sản phẩm này là",Price = 104000,Unit = "Lọ",Date = DateTime.Parse("2021/09/01"),Quantity =10, status = true,Origin="Việt Nam" },
               new Product{ProductTypeId = 17,ProductName="Màu thực phẩm",Image = "/Images/Image_producttype/Mauvangdong_producttype.jpeg", ProductDescribe = "Sản phẩm này là",Price = 150000,Unit = "Lọ",Date = DateTime.Parse("2021/09/01"),Quantity =10, status = true,Origin="Việt Nam" },
               new Product{ProductTypeId = 18,ProductName="Màu tự nhiên",Image = "/Images/Image_producttype/Botlanep_producttype.jpeg", ProductDescribe = "Sản phẩm này là",Price = 1010000,Unit = "Bịch",Date = DateTime.Parse("2021/09/01"),Quantity =10, status = true,Origin="Việt Nam" },
               new Product{ProductTypeId  = 19,ProductName="Nguyên liệu trang trí",Image = "/Images/Image_producttype/AFC_producttype.jpeg", ProductDescribe = "Sản phẩm này là",Price = 150000,Unit = "Hộp",Date = DateTime.Parse("2021/09/01"),Quantity =10, status = true,Origin="Việt Nam" },
                //dụng cụ làm bánh
                new Product{ProductTypeId = 20,ProductName="Dụng cụ cơ bản",Image = "/Images/Image_producttype_dungcu/banxoaykinh_producttype.jpeg", ProductDescribe = "Sản phẩm này là",Price = 1900000,Unit = "Cái",Date = DateTime.Parse("2021/09/01"),Quantity =10, status = true,Origin="Việt Nam" },
                new Product{ProductTypeId = 21,ProductName="Dụng cụ đong",Image = "/Images/Image_producttype_dungcu/dungcudong_producttype.jpeg",ProductDescribe = "Sản phẩm này là",Price = 140000,Unit = "Cái",Date = DateTime.Parse("2021/09/01"),Quantity =10, status = true,Origin="Việt Nam" },
                new Product{ProductTypeId = 22,ProductName="Cân điện tử",Image = "/Images/Image_producttype_dungcu/candientu_producttype.png", ProductDescribe = "Sản phẩm này là",Price = 150000,Unit = "Cái",Date = DateTime.Parse("2021/09/01"),Quantity =10, status = true,Origin="Việt Nam" },
                new Product{ProductTypeId = 22,ProductName="Nhiệt kế ",Image = "/Images/Image_producttype_dungcu/nhietke_producttype.jpeg", ProductDescribe = "Sản phẩm này là",Price = 104000,Unit = "Cái",Date = DateTime.Parse("2021/09/01"),Quantity =10, status = true,Origin="Việt Nam" },
                new Product{ProductTypeId = 23,ProductName="Dụng cụ đánh trứng",Image = "/Images/Image_producttype_dungcu/maydanhtrung_producttype.jpeg", ProductDescribe = "Sản phẩm này là",Price = 200000,Unit = "Cái",Date = DateTime.Parse("2021/09/01"),Quantity =10, status = true,Origin="Việt Nam" },
                new Product{ProductTypeId = 24,ProductName="Dụng cụ bát trộn",Image = "/Images/Image_producttype_dungcu/battron_producttype.jpeg", ProductDescribe = "Sản phẩm này là",Price = 140000,Unit = "Cái",Date = DateTime.Parse("2021/09/01"),Quantity =10, status = true,Origin="Việt Nam" },
                new Product{ProductTypeId = 25,ProductName="Dụng cụ cán ép",Image = "/Images/Image_producttype_dungcu/Canep_producttype.jpeg", ProductDescribe = "Sản phẩm này là",Price = 103000,Unit = "Cái",Date = DateTime.Parse("2021/09/01"),Quantity =10, status = true,Origin="Việt Nam" },
                new Product{ProductTypeId = 26,ProductName="Dụng cụ cây cán bột",Image = "/Images/Image_producttype_dungcu/caycanbot_producttype.jpeg", ProductDescribe = "Sản phẩm này là",Price = 170000,Unit = "Cái",Date = DateTime.Parse("2021/09/01"),Quantity =10, status = true,Origin="Việt Nam" },
                new Product{ProductTypeId = 27,ProductName="Dụng cụ rây bột",Image = "/Images/Image_producttype_dungcu/raybot_producttype.jpeg", ProductDescribe = "Sản phẩm này là",Price = 300000,Unit = "Cái",Date = DateTime.Parse("2021/09/01"),Quantity =10, status = true,Origin="Việt Nam" },
                new Product{ProductTypeId = 28,ProductName="Dụng cụ làm fondant",Image = "/Images/Image_producttype_dungcu/Fondant_producttype.jpeg",ProductDescribe = "Sản phẩm này là",Price = 104000,Unit = "Cái",Date = DateTime.Parse("2021/09/01"),Quantity =10, status = true,Origin="Việt Nam" },
                new Product{ProductTypeId = 29,ProductName="Dụng cụ đui bắt kem",Image = "/Images/Image_producttype_dungcu/Duibatkem_producttype.jpeg",ProductDescribe = "Sản phẩm này là",Price = 102000,Unit = "Cái",Date = DateTime.Parse("2021/09/01"),Quantity =10, status = true,Origin="Việt Nam" },
                new Product{ProductTypeId = 30,ProductName="Kim thạch rau câu 3D",Image = "/Images/Image_producttype_dungcu/Kimraucau3d_producttype.jpeg", ProductDescribe = "Sản phẩm này là",Price = 190000,Unit = "Bịch",Date = DateTime.Parse("2021/09/01"),Quantity =10, status = true,Origin="Việt Nam" },
                //Khuôn khay
                new Product{ProductTypeId = 31,ProductName="Khuôn gato",Image = "/Images/Image_producttype_khuonkhay/khuongatoVuong_producttype.jpeg", ProductDescribe = "Sản phẩm này là",Price = 107000,Unit = "Cái",Date = DateTime.Parse("2021/09/01"),Quantity =10, status = true,Origin="Việt Nam" },
                new Product{ProductTypeId = 32,ProductName="Khay nướng",Image = "/Images/Image_producttype_khuonkhay/khaynuong_producttype.jpeg", ProductDescribe = "Sản phẩm này là",Price = 150000,Unit = "Cái",Date = DateTime.Parse("2021/09/01"),Quantity =10, status = true,Origin="Việt Nam" },
                new Product{ProductTypeId = 33,ProductName="Khuôn cupcake",Image = "/Images/Image_producttype_khuonkhay/Cupcake_producttype.jpeg", ProductDescribe = "Sản phẩm này là",Price = 105000,Unit = "Cái",Date = DateTime.Parse("2021/09/01"),Quantity =10, status = true,Origin="Việt Nam" },
                new Product{ProductTypeId = 33,ProductName="Khuôn bánh mỳ",Image = "/Images/Image_producttype_khuonkhay/khaynuongbanhmy_producttype.jpeg", ProductDescribe = "Sản phẩm này là",Price = 100000,Unit = "Cái",Date = DateTime.Parse("2021/09/01"),Quantity =10, status = true,Origin="Việt Nam" },
                new Product{ProductTypeId = 34,ProductName="Pizza",Image = "/Images/Image_producttype_khuonkhay/khuonpizza_producttype.jpeg", ProductDescribe = "Sản phẩm này là",Price = 110000,Unit = "Cái",Date = DateTime.Parse("2021/09/01"),Quantity =10, status = true,Origin="Việt Nam" },
                new Product{ProductTypeId = 35,ProductName="Khuôn thạch",Image = "/Images/Image_producttype_khuonkhay/khuonthach_producttype.jpeg", ProductDescribe = "Sản phẩm này là",Price = 50000,Unit = "Cái",Date = DateTime.Parse("2021/09/01"),Quantity =10, status = true,Origin="Việt Nam" },
                new Product{ProductTypeId = 36,ProductName="Khuôn kem",Image = "/Images/Image_producttype_khuonkhay/khuonkem_producttype.jpeg", ProductDescribe = "Sản phẩm này là",Price = 10000,Unit = "Cái",Date = DateTime.Parse("2021/09/01"),Quantity =10, status = true,Origin="Việt Nam" },
                new Product{ProductTypeId = 37,ProductName="Khuôn mousse",Image = "/Images/Image_producttype_khuonkhay/khuonMousse_producttype.jpeg", ProductDescribe = "Sản phẩm này là",Price = 120000,Unit = "Cái",Date = DateTime.Parse("2021/09/01"),Quantity =10, status = true,Origin="Việt Nam" },
                new Product{ProductTypeId = 38,ProductName="Khuôn tart",Image = "/Images/Image_producttype_khuonkhay/khuonTart_producttype.jpeg", ProductDescribe = "Sản phẩm này là",Price = 10000,Unit = "Cái",Date = DateTime.Parse("2021/09/01"),Quantity =10, status = true,Origin="Việt Nam" },
                //Món Âu
                new Product{ProductTypeId = 39,ProductName="Chesse(phô mai)",Image = "/Images/Image_producttype_monAu/botphomai_producttype.jpeg", ProductDescribe = "Sản phẩm này là",Price = 100000,Unit = "Bịch",Date = DateTime.Parse("2021/09/01"),Quantity =10, status = true,Origin="Việt Nam" },
                new Product{ProductTypeId = 40,ProductName="Đồ làm mì Ý",Image = "/Images/Image_producttype_monAu/myY_producttype.jpeg", ProductDescribe = "Sản phẩm này là",Price = 100000,Unit = "Hộp",Date = DateTime.Parse("2021/09/01"),Quantity =10, status = true,Origin="Việt Nam" },
                new Product{ProductTypeId = 41,ProductName="Đồ làm Pizza",Image = "/Images/Image_producttype_monAu/dePizza_producttype.png", ProductDescribe = "Sản phẩm này là",Price = 100000,Unit = "Bịch",Date = DateTime.Parse("2021/09/01"),Quantity =10, status = true,Origin="Việt Nam" },
                new Product{ProductTypeId = 42,ProductName="Tương ớt",Image = "/Images/Image_producttype_monAu/tuongot_producttype.png", ProductDescribe = "Sản phẩm này là",Price = 100000,Unit = "Lọ",Date = DateTime.Parse("2021/09/01"),Quantity =10, status = true,Origin="Việt Nam" },
                new Product{ProductTypeId = 43,ProductName="Tương cà",Image = "/Images/Image_producttype_monAu/tuongca_producttype.png", ProductDescribe = "Sản phẩm này là",Price = 100000,Unit = "Lọ",Date = DateTime.Parse("2021/09/01"),Quantity =10, status = true,Origin="Việt Nam" },
                new Product{ProductTypeId = 44,ProductName="Mật ong",Image = "/Images/Image_producttype_monAu/matong_producttype.jpeg", ProductDescribe = "Sản phẩm này là",Price = 100000,Unit = "Chai",Date = DateTime.Parse("2021/09/01"),Quantity =10, status = true,Origin="Việt Nam" },
                // Món Á
                new Product{ProductTypeId = 45,ProductName="Bột chiên",Image = "/Images/Image_producttype_monA/botchien_producttype.jpeg", ProductDescribe = "Sản phẩm này là",Price = 140000,Unit = "Bịch",Date = DateTime.Parse("2021/09/01"),Quantity =10, status = true,Origin="Việt Nam" },
                new Product{ProductTypeId = 46,ProductName="Bột phô mai lắc",Image = "/Images/Image_producttype_monA/phomailac_producttype.jpeg",ProductDescribe = "Sản phẩm này là",Price = 105000,Unit = "Bịch",Date = DateTime.Parse("2021/09/01"),Quantity =10, status = true,Origin="Việt Nam" },
                new Product{ProductTypeId = 47,ProductName="Nguyên liệu Hàn Nhật",Image = "/Images/Image_producttype_monA/banhgao_producttype.jpeg",ProductDescribe = "Sản phẩm này là",Price = 110000,Unit = "Bịch",Date = DateTime.Parse("2021/09/01"),Quantity =10, status = true,Origin="Việt Nam" },
                new Product{ProductTypeId = 48,ProductName="Nguyên liệu Thái",Image = "/Images/Image_producttype_monA/lauthai_producttype.jpeg", ProductDescribe = "Sản phẩm này là",Price = 40000,Unit = "Bịch",Date = DateTime.Parse("2021/09/01"),Quantity =10, status = true,Origin="Việt Nam" },
                new Product{ProductTypeId = 49,ProductName="Trứng",Image = "/Images/Image_producttype_monA/trung_producttype.jpeg",ProductDescribe = "Sản phẩm này là",Price = 30000,Unit = "Hộp",Date = DateTime.Parse("2021/09/01"),Quantity =10, status = true,Origin="Việt Nam" },
                new Product{ProductTypeId = 50 ,ProductName="Gia vị truyền thống",Image = "/Images/Image_producttype_monA/botcari_producttype.jpeg", ProductDescribe = "Sản phẩm này là",Price = 50000,Unit = "Bịch",Date = DateTime.Parse("2021/09/01"),Quantity =10, status = true,Origin="Việt Nam" },
                new Product{ProductTypeId = 51,ProductName="Dầu mè, hắc xì dầu",Image = "/Images/Image_producttype_monA/dauhao_producttype.jpeg", ProductDescribe = "Sản phẩm này là",Price = 30000,Unit = "Chai",Date = DateTime.Parse("2021/09/01"),Quantity =10, status = true,Origin="Việt Nam" },
                //Túi - hộp - cốc - lọ
                
                new Product{ProductTypeId = 52,ProductName="Túi giấy",Image = "/Images/Image_producttype_lycoclo/tuigiay_producttype.png",ProductDescribe = "Sản phẩm này là",Price = 10000,Unit = "Cái",Date = DateTime.Parse("2021/09/01"),Quantity =10, status = true,Origin="Việt Nam" },
                new Product{ProductTypeId = 53,ProductName="Cup giấy",Image = "/Images/Image_producttype_lycoclo/cupgiay_producttype.jpeg", ProductDescribe = "Sản phẩm này là",Price = 10000,Unit = "Cái",Date = DateTime.Parse("2021/09/01"),Quantity =10, status = true,Origin="Việt Nam" },
                new Product{ProductTypeId = 54,ProductName="Túi đựng socola",Image = "/Images/Image_producttype_lycoclo/cupdungsocola_producttype.jpeg", ProductDescribe = "Sản phẩm này là",Price = 10000,Unit = "Cái",Date = DateTime.Parse("2021/09/01"),Quantity =10, status = true,Origin="Việt Nam" },
                new Product{ProductTypeId = 55,ProductName="Đế bánh",Image = "/Images/Image_producttype_lycoclo/debanhchunhat_producttype.jpeg", ProductDescribe = "Sản phẩm này là",Price = 100000,Unit = "Cái",Date = DateTime.Parse("2021/09/01"),Quantity =10, status = true,Origin="Việt Nam" },
                new Product{ProductTypeId = 56,ProductName="Hộp giấy",Image = "/Images/Image_producttype_lycoclo/hopdung_producttype.jpeg",ProductDescribe = "Sản phẩm này là",Price = 100000,Unit = "Hộp",Date = DateTime.Parse("2021/09/01"),Quantity =10, status = true,Origin="Việt Nam" },
                new Product{ProductTypeId = 57,ProductName="Hộp nhựa",Image = "/Images/Image_producttype_lycoclo/hopnhua_producttype.png",ProductDescribe = "Sản phẩm này là",Price = 130000,Unit = "Hộp",Date = DateTime.Parse("2021/09/01"),Quantity =10, status = true,Origin="Việt Nam" },
                new Product{ProductTypeId = 58,ProductName="Hộp thiếc",Image = "/Images/Image_producttype_lycoclo/hopthiec_producttype.jpeg", ProductDescribe = "Sản phẩm này là",Price = 100000,Unit = "Hộp",Date = DateTime.Parse("2021/09/01"),Quantity =10, status = true,Origin="Việt Nam" },
                new Product{ProductTypeId = 59,ProductName="Túi Zip đáy đứng",Image = "/Images/Image_producttype_lycoclo/tuiZipdaydung_producttype.jpeg", ProductDescribe = "Sản phẩm này là",Price = 10000,Unit = "Cái",Date = DateTime.Parse("2021/09/01"),Quantity =10, status = true,Origin="Việt Nam" },
                new Product{ProductTypeId = 60,ProductName="Nến sinh nhật",Image = "/Images/Image_producttype_lycoclo/nenphaobong_producttype.jpeg", ProductDescribe = "Sản phẩm này là",Price = 10000,Unit = "Bịch",Date = DateTime.Parse("2021/09/01"),Quantity =10, status = true,Origin="Việt Nam" },
                new Product{ProductTypeId = 61,ProductName="Đồ tổ chức party",Image = "/Images/Image_producttype_lycoclo/Icon_producttype.jpeg", ProductDescribe = "Sản phẩm này là",Price = 70000,Unit = "Cái",Date = DateTime.Parse("2021/09/01"),Quantity =10, status = true,Origin="Việt Nam" },
                new Product{ProductTypeId = 62,ProductName="Hình dán",Image = "/Images/Image_producttype_lycoclo/hinhdan_producttype.jpeg", ProductDescribe = "Sản phẩm này là",Price = 40000,Unit = "Cái",Date = DateTime.Parse("2021/09/01"),Quantity =10, status = true,Origin="Việt Nam" },
                new Product{ProductTypeId = 63,ProductName="Dây buộc",Image = "/Images/Image_producttype_lycoclo/daybuoc_producttype.jpeg", ProductDescribe = "Sản phẩm này là",Price = 20000,Unit = "Cuộn",Date = DateTime.Parse("2021/09/01"),Quantity =10, status = true,Origin="Việt Nam" },
               
                //Dụng cụ nấu ăn
                new Product{ProductTypeId = 64,ProductName="Đồ làm pento",Image = "/Images/Image_producttype_DCnauan/khuonnhua_producttype.jpeg", ProductDescribe = "Sản phẩm này là",Price = 10000,Unit = "Cái",Date = DateTime.Parse("2021/09/01"),Quantity =10, status = true,Origin="Việt Nam" },
                new Product{ProductTypeId = 65,ProductName="Mành cuộn cơm",Image = "/Images/Image_producttype_DCnauan/manhcuon_producttype.jpeg", ProductDescribe = "Sản phẩm này là",Price = 40000,Unit = "Cái",Date = DateTime.Parse("2021/09/01"),Quantity =10, status = true,Origin="Việt Nam" },
                new Product{ProductTypeId = 66,ProductName="Chảo rán",Image = "/Images/Image_producttype_DCnauan/KhuonNuong_producttype.jpeg", ProductDescribe = "Sản phẩm này là",Price = 200000,Unit = "Cái",Date = DateTime.Parse("2021/09/01"),Quantity =10, status = true,Origin="Việt Nam" },
                
                //Nguyên liệu lẩu nướng
                new Product{ProductTypeId = 67,ProductName="Viên thả lẩu",Image = "/Images/Image_producttype_launuong/Vienthalau_producttype.png", ProductDescribe = "Sản phẩm này là",Price = 100000,Unit = "Bịch",Date = DateTime.Parse("2021/09/01"),Quantity =10, status = true,Origin="Việt Nam" },
                new Product{ProductTypeId = 68,ProductName="Thịt nhập khẩu",Image = "/Images/Image_producttype_launuong/thit_producttype.png", ProductDescribe = "Sản phẩm này là",Price = 200000,Unit = "Bịch",Date = DateTime.Parse("2021/09/01"),Quantity =10, status = true,Origin="Việt Nam" },
                new Product{ProductTypeId = 69,ProductName="Thịt nguội",Image = "/Images/Image_producttype_launuong/thitnguoi_producttype.png",  ProductDescribe = "Sản phẩm này là",Price = 100000,Unit = "Bịch",Date = DateTime.Parse("2021/09/01"),Quantity =10, status = true,Origin="Việt Nam" },
                new Product{ProductTypeId = 70,ProductName="Gia vị lẩu nướng",Image = "/Images/Image_producttype_launuong/giavi_producttype.jpeg", ProductDescribe = "Sản phẩm này là",Price = 10000,Unit = "Bịch",Date = DateTime.Parse("2021/09/01"),Quantity =10, status = true,Origin="Việt Nam" },
                new Product{ProductTypeId = 71,ProductName="Mì sợi",Image = "/Images/Image_producttype_launuong/misoi_producttype.png",  ProductDescribe = "Sản phẩm này là",Price = 5000,Unit = "Bịch",Date = DateTime.Parse("2021/09/01"),Quantity =10, status = true,Origin="Việt Nam" },
                
                //Nguyên liệu pha chế
                new Product{ProductTypeId = 72,ProductName="Trà",Image = "/Images/Image_producttype_NLphache/tra_producttype.jpeg",ProductDescribe = "Sản phẩm này là",Price = 100000,Unit = "Bịch",Date = DateTime.Parse("2021/09/01"),Quantity =10, status = true,Origin="Việt Nam" },
                new Product{ProductTypeId = 73,ProductName="Sữa pha chế",Image = "/Images/Image_producttype_NLphache/botsua_producttype.jpeg", ProductDescribe = "Sản phẩm này là",Price = 120000,Unit = "Bịch",Date = DateTime.Parse("2021/09/01"),Quantity =10, status = true,Origin="Việt Nam" },
                new Product{ProductTypeId = 74,ProductName="Siro",Image = "/Images/Image_producttype_NLphache/siro_producttype.jpeg", ProductDescribe = "Sản phẩm này là",Price = 100000,Unit = "Chai",Date = DateTime.Parse("2021/09/01"),Quantity =10, status = true,Origin="Việt Nam" },
                new Product{ProductTypeId = 75,ProductName="Sinh tố",Image = "/Images/Image_producttype_NLphache/sinhto_producttype.jpeg", ProductDescribe = "Sản phẩm này là",Price = 150000,Unit = "Chai",Date = DateTime.Parse("2021/09/01"),Quantity =10, status = true,Origin="Việt Nam" },
                new Product{ProductTypeId = 76,ProductName="Pudding",Image = "/Images/Image_producttype_NLphache/pudding_producttype.png", ProductDescribe = "Sản phẩm này là",Price = 140000,Unit = "Bịch",Date = DateTime.Parse("2021/09/01"),Quantity =10, status = true,Origin="Việt Nam" },
                new Product{ProductTypeId = 77,ProductName="Nước cốt dừa",Image = "/Images/Image_producttype_NLphache/nuoccotdua_producttype.jpeg",ProductDescribe = "Sản phẩm này là",Price = 40000,Unit = "Lon",Date = DateTime.Parse("2021/09/01"),Quantity =10, status = true,Origin="Việt Nam" },
            
                 //Dụng cụ pha chế
                 new Product{ProductTypeId = 78,ProductName="Bình lắc",Image = "/Images/Image_producttype_DCphache/binhlac_producttype.jpeg", ProductDescribe = "Sản phẩm này là",Price = 104000,Unit = "Cái",Date = DateTime.Parse("2021/09/01"),Quantity =10, status = true,Origin="Việt Nam" },
                 new Product{ProductTypeId = 79,ProductName="Ly đong",Image = "/Images/Image_producttype_DCphache/lydong_producttype.jpeg", ProductDescribe = "Sản phẩm này là",Price = 50000,Unit = "Cái",Date = DateTime.Parse("2021/09/01"),Quantity =10, status = true,Origin="Việt Nam" },
                 new Product{ProductTypeId = 80,ProductName="Muỗng khuấy",Image = "/Images/Image_producttype_DCphache/muongkhuay_producttype.jpeg", ProductDescribe = "Sản phẩm này là",Price = 40000,Unit = "Cái",Date = DateTime.Parse("2021/09/01"),Quantity =10, status = true,Origin="Việt Nam" },
                 new Product{ProductTypeId = 81,ProductName="Rây lọc pha chế",Image = "/Images/Image_producttype_DCphache/rayloc_producttype.jpeg", ProductDescribe = "Sản phẩm này là",Price = 13000,Unit = "Cái",Date = DateTime.Parse("2021/09/01"),Quantity =10, status = true,Origin="Việt Nam" },
                 new Product{ProductTypeId = 82,ProductName="Cốc nhựa",Image = "/Images/Image_producttype_DCphache/cocnhua_producttype.jpeg", ProductDescribe = "Sản phẩm này là",Price = 100000,Unit = "Bịch",Date = DateTime.Parse("2021/09/01"),Quantity =10, status = true,Origin="Việt Nam" },
                 new Product{ProductTypeId = 83,ProductName="Ống hút ",Image = "/Images/Image_producttype_DCphache/onghut_producttype.jpeg", ProductDescribe = "Sản phẩm này là",Price = 100000,Unit = "Bịch",Date = DateTime.Parse("2021/09/01"),Quantity =10, status = true,Origin="Việt Nam" },

                };
            products.ForEach(s => context.Products.Add(s));
            context.SaveChanges();
        }
    }
}