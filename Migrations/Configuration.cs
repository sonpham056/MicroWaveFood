namespace MicroWaveFood.Migrations
{
    using MicroWaveFood.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

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
               new ProductType{Name="Whipping",GroupType="Nguyên liệu làm bánh",Image = "/Images/Image_producttype/Whiping_producttype.jpeg" },
               new ProductType{Name="Cheese",GroupType="Nguyên liệu làm bánh",Image = "/Images/Image_producttype/Cheese_producttype.jpeg" },
               new ProductType{Name="Hạt,quả khô",GroupType="Nguyên liệu làm bánh",Image = "/Images/Image_producttype/Hatquakho_producttype.jpeg" },
               new ProductType{Name="Bơ",GroupType="Nguyên liệu làm bánh",Image = "/Images/Image_producttype/Bodp_producttype.jpeg" },
               new ProductType{Name="Sữa",GroupType="Nguyên liệu làm bánh",Image = "/Images/Image_producttype/Botsua_producttype.jpeg" },
               new ProductType{Name="Đường",GroupType="Nguyên liệu làm bánh",Image = "/Images/Image_producttype/Duong_producttype.jpeg" },
               new ProductType{Name="Topping",GroupType="Nguyên liệu làm bánh",Image = "/Images/Image_producttype/ToppingKembeo_producttype.jpeg" },
               new ProductType{Name="Bột mì",GroupType="Nguyên liệu làm bánh",Image = "/Images/Image_producttype/Botmi_producttype.jpeg" },
               new ProductType{Name="Bột trộn sẵn",GroupType="Nguyên liệu làm bánh",Image = "/Images/Image_producttype/BottronsanBotbanhbao_producttype.jpeg" },
               new ProductType{Name="Gelatin",GroupType="Nguyên liệu làm bánh",Image = "/Images/Image_producttype/Gelatin_producttype.jpeg" },
               new ProductType{Name="Rau câu",GroupType="Nguyên liệu làm bánh",Image = "/Images/Image_producttype/Raucau_producttype.jpeg" },
               new ProductType{Name="Chocochip",GroupType="Nguyên liệu làm bánh",Image = "/Images/Image_producttype/Chocochip_producttype.jpeg" },
               new ProductType{Name="Socola",GroupType="Nguyên liệu làm bánh",Image = "/Images/Image_producttype/Socola_producttype.jpeg" },
               new ProductType{Name="Men",GroupType="Nguyên liệu làm bánh",Image = "/Images/Image_producttype/MenBotno_producttype.jpeg" },
               new ProductType{Name="Sữa",GroupType="Nguyên liệu làm bánh",Image = "/Images/Image_producttype/Botsua_producttype.jpeg" },
               new ProductType{Name="Tinh dầu",GroupType="Nguyên liệu làm bánh",Image = "/Images/Image_producttype/TinhdauVani_producttype.jpeg" },
               new ProductType{Name="Màu thực phẩm",GroupType="Nguyên liệu làm bánh",Image = "/Images/Image_producttype/Mauvangdong_producttype.jpeg" },
               new ProductType{Name="Màu tự nhiên",GroupType="Nguyên liệu làm bánh",Image = "/Images/Image_producttype/Botlanep_producttype.jpeg" },
               new ProductType{Name="Nguyên liệu trang trí",GroupType="Nguyên liệu làm bánh",Image = "/Images/Image_producttype/AFC_producttype.jpeg" },
            };
            producttypes.ForEach(s => context.productTypes.Add(s));
            context.SaveChanges();

            //dungcu
            var producttypes_dungcu = new List<ProductType>
            {
                new ProductType{Name="Dụng cụ cơ bản",GroupType="Dụng cụ làm bánh",Image = "/Images/Image_producttype_dungcu/banxoaykinh_producttype.jpeg" },
                new ProductType{Name="Dụng cụ đong",GroupType="Dụng cụ làm bánh",Image = "/Images/Image_producttype_dungcu/dungcudong_producttype.jpeg" },
                new ProductType{Name="Cân điện tử",GroupType="Dụng cụ làm bánh",Image = "/Images/Image_producttype_dungcu/candientu_producttype.jpeg" },
                new ProductType{Name="Nhiệt kế ",GroupType="Dụng cụ làm bánh",Image = "/Images/Image_producttyp_dungcu/nhietke_producttype.jpeg" },
                new ProductType{Name="Dụng cụ đánh trứng",GroupType="Dụng cụ làm bánh",Image = "/Images/Image_producttype_dungcu/maydanhtrung_producttype.jpeg" },
                new ProductType{Name="Dụng cụ bát trộn",GroupType="Dụng cụ làm bánh",Image = "/Images/Image_producttype_dungcu/battron_producttype.jpeg" },
                new ProductType{Name="Dụng cụ cán ép",GroupType="Dụng cụ làm bánh",Image = "/Images/Image_producttype_dungcu/Canep_producttype.jpeg" },
                new ProductType{Name="Dụng cụ cây cán bột",GroupType="Dụng cụ làm bánh",Image = "/Images/Image_producttype_dungcu/caycanbot_producttype.jpeg" },
                new ProductType{Name="Dụng cụ rây bột",GroupType="Dụng cụ làm bánh",Image = "/Images/Image_producttype_dungcu/raybot_producttype.jpeg" },
                new ProductType{Name="Dụng cụ làm fondant",GroupType="Dụng cụ làm bánh",Image = "/Images/Image_producttype_dungcu/Fondant_producttype.jpeg" },
                new ProductType{Name="Dụng cụ đui bắt kem",GroupType="Dụng cụ làm bánh",Image = "/Images/Image_producttype_dungcu/Duibatkem_producttype.jpeg" },
                new ProductType{Name="Kim thạch rau câu 3D",GroupType="Dụng cụ làm bánh",Image = "/Images/Image_producttype_dungcu/Kimraucau3d_producttype.jpeg" },
            };
            producttypes_dungcu.ForEach(s => context.productTypes.Add(s));
            context.SaveChanges();

            //khuonkhay
            var producttypes_khonkhay = new List<ProductType>
            {
                new ProductType{Name="Khuôn gato",GroupType="Khuôn khay làm bánh",Image = "/Images/Image_producttype_khuonkhay/khuongatoVuong_producttype.jpeg" },
                new ProductType{Name="Khay nướng",GroupType="Khuôn khay làm bánh",Image = "/Images/Image_producttype_khuonkhay/khaynuong_producttype.jpeg" },
                new ProductType{Name="Khuôn cupcake",GroupType="Khuôn khay làm bánh",Image = "/Images/Image_producttype_khuonkhay/Cupcake_producttype.jpeg" },
                new ProductType{Name="Khuôn bánh mỳ",GroupType="Khuôn khay làm bánh",Image = "/Images/Image_producttype_khuonkhay/khaynuongbanhmy_producttype.jpeg" },
                new ProductType{Name="Pizza",GroupType="Khuôn khay làm bánh",Image = "/Images/Image_producttype_khuonkhay/khuonpizza_producttype.jpeg" },
                new ProductType{Name="Khuôn thạch",GroupType="Khuôn khay làm bánh",Image = "/Images/Image_producttype_khuonkhay/khuonthach_producttype.jpeg" },
                new ProductType{Name="Khuôn kem",GroupType="Khuôn khay làm bánh",Image = "/Images/Image_producttype_khuonkhay/khuonkem_producttype.jpeg" },
                new ProductType{Name="Khuôn mousse",GroupType="Khuôn khay làm bánh",Image = "/Images/Image_producttype_khuonkhay/khuonMousse_producttype.jpeg" },
                new ProductType{Name="Khuôn tart",GroupType="Khuôn khay làm bánh",Image = "/Images/Image_producttype_khuonkhay/khuonTart_producttype.jpeg" },

            };
            producttypes_khonkhay.ForEach(s => context.productTypes.Add(s));
            context.SaveChanges();

            //tui-hop-coc-lo
            var producttypes_tuihopcoclo = new List<ProductType>
            {
                new ProductType{Name="Túi giấy",GroupType="Túi,hộp,cốc,lọ",Image = "/Images/Image_producttype_lycoclo/tuigiay_producttype.jpeg" },
                new ProductType{Name="Cup giấy",GroupType="Túi,hộp,cốc,lọ",Image = "/Images/Image_producttype_lycoclo/cupgiay_producttype.jpeg" },
                new ProductType{Name="Túi đựng socola",GroupType="Túi,hộp,cốc,lọ",Image = "/Images/Image_producttype_lycoclo/cupdungsocola_producttype.jpeg" },
                new ProductType{Name="Đế bánh",GroupType="Túi,hộp,cốc,lọ",Image = "/Images/Image_producttype_lycoclo/debanhchunhat_producttype.jpeg" },
                new ProductType{Name="Hộp giấy",GroupType="Túi,hộp,cốc,lọ",Image = "/Images/Image_producttype_lycoclo/hopdung_producttype.jpeg" },
                new ProductType{Name="Hộp nhựa",GroupType="Túi,hộp,cốc,lọ",Image = "/Images/Image_producttype_lycoclo/hopnhua_producttype.jpeg" },
                new ProductType{Name="Hộp thiếc",GroupType="Túi,hộp,cốc,lọ",Image = "/Images/Image_producttype_lycoclo/hopthiec_producttype.jpeg" },
                new ProductType{Name="Túi Zip đáy đứng",GroupType="Túi,hộp,cốc,lọ",Image = "/Images/Image_producttype_lycoclo/tuiZipdaydung_producttype.jpeg" },
                new ProductType{Name="Nến sinh nhật",GroupType="Túi,hộp,cốc,lọ",Image = "/Images/Image_producttype_lycoclo/nenphaobong_producttype.jpeg" },
                new ProductType{Name="Đồ tổ chức party",GroupType="Túi,hộp,cốc,lọ",Image = "/Images/Image_producttype_lycoclo/Icon_producttype.jpeg" },
                new ProductType{Name="Hình dán",GroupType="Túi,hộp,cốc,lọ",Image = "/Images/Image_producttype_lycoclo/hinhdan_producttype.jpeg" },
                new ProductType{Name="Dây buộc",GroupType="Túi,hộp,cốc,lọ",Image = "/Images/Image_producttype_lycoclo/daybuoc_producttype.jpeg" },
            };
            producttypes_tuihopcoclo.ForEach(s => context.productTypes.Add(s));
            context.SaveChanges();
            //Mon Á
            var producttypes_monA = new List<ProductType>
            {
                new ProductType{Name="Bột chiên",GroupType="Món Á",Image = "/Images/Image_producttype_monA/botchien_producttype.jpeg" },
                new ProductType{Name="Bột phô mai lắc",GroupType="Món Á",Image = "/Images/Image_producttype_monA/phomailac_producttype.jpeg" },
                new ProductType{Name="Nguyên liệu Hàn Nhật",GroupType="Món Á",Image = "/Images/Image_producttype_monA/banhgao_producttype.jpeg" },
                new ProductType{Name="Nguyên liệu Thái",GroupType="Món Á",Image = "/Images/Image_producttype_monA/lauthai_producttype.jpeg" },
                new ProductType{Name="Trứng",GroupType="Món Á",Image = "/Images/Image_producttype_monA/trung_producttype.jpeg" },
                new ProductType{Name="Gia vị truyền thống",GroupType="Món Á",Image = "/Images/Image_producttype_monA/botcari_producttype.jpeg" },
                new ProductType{Name="Dầu mè, hắc xì dầu",GroupType="Món Á",Image = "/Images/Image_producttype_monA/dauhao_producttype.jpeg" },
            };
            producttypes_monA.ForEach(s => context.productTypes.Add(s));
            context.SaveChanges();
            //Mon Âu
            var producttypes_monAu = new List<ProductType>
            {
                new ProductType{Name="Chesse(phô mai)",GroupType="Món Âu",Image = "/Images/Image_producttype_monAu/botphomai_producttype.jpeg" },
                new ProductType{Name="Đồ làm mì Ý",GroupType="Món Âu",Image = "/Images/Image_producttype_monAu/myY_producttype.jpeg" },
                new ProductType{Name="Đồ làm Pizza",GroupType="Món Âu",Image = "/Images/Image_producttype_monAu/dePizza_producttype.jpeg" },
                new ProductType{Name="Tương ớt",GroupType="Món Âu",Image = "/Images/Image_producttype_monAu/tuongot_producttype.jpeg" },
                new ProductType{Name="Tương cà",GroupType="Món Âu",Image = "/Images/Image_producttype_monAu/tuongca_producttype.jpeg" },
                new ProductType{Name="Mật ong",GroupType="Món Âu",Image = "/Images/Image_producttype_monAu/matong_producttype.jpeg" },
            };
            producttypes_monAu.ForEach(s => context.productTypes.Add(s));
            context.SaveChanges();
            //Dụng cụ nấu ăn
            var producttypes_dungcuNauan = new List<ProductType>
            {
                new ProductType{Name="Đồ làm pento",GroupType="Dụng cụ nấu ăn",Image = "/Images/Image_producttype_DCnauan/khuonnhua_producttype.jpeg" },
                new ProductType{Name="Mành cuộn cơm",GroupType="Dụng cụ nấu ăn",Image = "/Images/Image_producttype_DCnauan/manhcuon_producttype.jpeg" },
                new ProductType{Name="Chảo rán",GroupType="Dụng cụ nấu ăn",Image = "/Images/Image_producttype_DCnauan/KhuonNuong_producttype.jpeg" },
            };
            producttypes_dungcuNauan.ForEach(s => context.productTypes.Add(s));
            context.SaveChanges();
            //Nguyên liệu lẩu nướng
            var producttypes_lauNuong = new List<ProductType>
            {
                new ProductType{Name="Viên thả lẩu",GroupType="Nguyên liệu lẩu nướng",Image = "/Images/Image_producttype_launuong/Vienthalau_producttype.jpeg" },
                new ProductType{Name="Thịt nhập khẩu",GroupType="Nguyên liệu lẩu nướng",Image = "/Images/Image_producttype_launuong/thit_producttype.jpeg" },
                new ProductType{Name="Thịt nguội",GroupType="Nguyên liệu lẩu nướng",Image = "/Images/Image_producttype_launuong/thitnguoi_producttype.jpeg" },
                new ProductType{Name="Gia vị lẩu nướng",GroupType="Nguyên liệu lẩu nướng",Image = "/Images/Image_producttype_launuong/giavi_producttype.jpeg" },
                new ProductType{Name="Mì sợi",GroupType="Nguyên liệu lẩu nướng",Image = "/Images/Image_producttype_launuong/misoi_producttype.jpeg" },
            };
            producttypes_lauNuong.ForEach(s => context.productTypes.Add(s));
            context.SaveChanges();
            //Nguyên liệu pha chế
            var producttypes_NLphache = new List<ProductType>
            {
                new ProductType{Name="Trà",GroupType="Nguyên liệu pha chế",Image = "/Images/Image_producttype_NLphache/tra_producttype.jpeg" },
                new ProductType{Name="Sữa pha chế",GroupType="Nguyên liệu pha chế",Image = "/Images/Image_producttype_NLphache/botsua_producttype.jpeg" },
                new ProductType{Name="Siro",GroupType="Nguyên liệu pha chế",Image = "/Images/Image_producttype_NLphache/siro_producttype.jpeg" },
                new ProductType{Name="Sinh tố",GroupType="Nguyên liệu pha chế",Image = "/Images/Image_producttype_NLphache/sinhto_producttype.jpeg" },
                new ProductType{Name="Pudding",GroupType="Nguyên liệu pha chế",Image = "/Images/Image_producttype_NLphache/pudding_producttype.jpeg" },
                new ProductType{Name="Trân châu",GroupType="Nguyên liệu pha chế",Image = "/Images/Image_producttype_NLphache/tranchau_producttype.jpeg" },
                new ProductType{Name="Nước cốt dừa",GroupType="Nguyên liệu pha chế",Image = "/Images/Image_producttype_NLphache/nuoccotdua_producttype.jpeg" },
            };
            producttypes_NLphache.ForEach(s => context.productTypes.Add(s));
            context.SaveChanges();
            //Dụng cụ pha chế
            var producttypes_DCphache = new List<ProductType>
            {
                 new ProductType{Name="Bình lắc",GroupType="Dụng cụ pha chế ",Image = "/Images/Image_producttype_DCphache/binhlac_producttype.jpeg" },
                 new ProductType{Name="Ly đong",GroupType="Dụng cụ pha chế ",Image = "/Images/Image_producttype_DCphache/lydong_producttype.jpeg" },
                 new ProductType{Name="Muỗng khuấy",GroupType="Dụng cụ pha chế ",Image = "/Images/Image_producttype_DCphache/muongkhuay_producttype.jpeg" },
                 new ProductType{Name="Rây lọc pha chế",GroupType="Dụng cụ pha chế ",Image = "/Images/Image_producttype_DCphache/rayloc_producttype.jpeg" },
                 new ProductType{Name="Cốc nhựa",GroupType="Dụng cụ pha chế ",Image = "/Images/Image_producttype_DCphache/cocnhua_producttype.jpeg" },
                 new ProductType{Name="Ống hút ",GroupType="Dụng cụ pha chế ",Image = "/Images/Image_producttype_DCphache/onghut_producttype.jpeg" },

            };
            producttypes_DCphache.ForEach(s => context.productTypes.Add(s));
            context.SaveChanges();
            //Đường pha chế
            var producttypes_duongphache = new List<ProductType>
            {
                new ProductType{Name="Đường nâu ",GroupType="Đường pha chế ",Image = "/Images/Image_producttype_duongphache/duongnau_producttype.jpeg" },
                new ProductType{Name="Đường nước ",GroupType="Đường pha chế ",Image = "/Images/Image_producttype_duongphache/duongNuoc_producttype.jpeg" },
            };
            producttypes_duongphache.ForEach(s => context.productTypes.Add(s));
            context.SaveChanges();
        }

    }
}

