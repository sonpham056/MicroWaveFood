using MicroWaveFood.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MicroWaveFood.DAL
{
    public class Product_type_Initiazer: System.Data.Entity.
        DropCreateDatabaseIfModelChanges<Product_type_context>
    {
        protected override void Seed(Product_type_context context)
        {
            ////nguyenlieu
            //var producttypes = new List<ProductType>
            //{
            //   new ProductType{Name="Whipping",GroupType="Nguyên liệu làm bánh",Image = "/Images/Image_producttype/Whiping_producttype.jpeg" },
            //   new ProductType{Name="Cheese",GroupType="Nguyên liệu làm bánh",Image = "/Images/Image_producttype/Cheese_producttype.jpeg" },
            //   new ProductType{Name="Hạt,quả khô",GroupType="Nguyên liệu làm bánh",Image = "/Images/Image_producttype/Hatquakho_producttype.jpeg" },
            //   new ProductType{Name="Bơ",GroupType="Nguyên liệu làm bánh",Image = "/Images/Image_producttype/Bodp_producttype.jpeg" },
            //   new ProductType{Name="Sữa",GroupType="Nguyên liệu làm bánh",Image = "/Images/Image_producttype/Botsua_producttype.jpeg" },
            //   new ProductType{Name="Đường",GroupType="Nguyên liệu làm bánh",Image = "/Images/Image_producttype/Duong_producttype.jpeg" },
            //   new ProductType{Name="Topping",GroupType="Nguyên liệu làm bánh",Image = "/Images/Image_producttype/ToppingKembeo_producttype.jpeg" },
            //   new ProductType{Name="Bột mì",GroupType="Nguyên liệu làm bánh",Image = "/Images/Image_producttype/Botmi_producttype.jpeg" },
            //   new ProductType{Name="Bột trộn sẵn",GroupType="Nguyên liệu làm bánh",Image = "/Images/Image_producttype/BottronsanBotbanhbao_producttype.jpeg" },
            //   new ProductType{Name="Gelatin",GroupType="Nguyên liệu làm bánh",Image = "/Images/Image_producttype/Gelatin_producttype.jpeg" },
            //   new ProductType{Name="Rau câu",GroupType="Nguyên liệu làm bánh",Image = "/Images/Image_producttype/Raucau_producttype.jpeg" },
            //   new ProductType{Name="Chocochip",GroupType="Nguyên liệu làm bánh",Image = "/Images/Image_producttype/Chocochip_producttype.jpeg" },
            //   new ProductType{Name="Socola",GroupType="Nguyên liệu làm bánh",Image = "/Images/Image_producttype/Socola_producttype.jpeg" },
            //   new ProductType{Name="Men",GroupType="Nguyên liệu làm bánh",Image = "/Images/Image_producttype/MenBotno_producttype.jpeg" },
            //   new ProductType{Name="Sữa",GroupType="Nguyên liệu làm bánh",Image = "/Images/Image_producttype/Botsua_producttype.jpeg" },
            //   new ProductType{Name="Tinh dầu",GroupType="Nguyên liệu làm bánh",Image = "/Images/Image_producttype/TinhdauVani_producttype.jpeg" },
            //   new ProductType{Name="Màu thực phẩm",GroupType="Nguyên liệu làm bánh",Image = "/Images/Image_producttype/Mauvangdong_producttype.jpeg" },
            //   new ProductType{Name="Màu tự nhiên",GroupType="Nguyên liệu làm bánh",Image = "/Images/Image_producttype/Botlanep_producttype.jpeg" },
            //   new ProductType{Name="Nguyên liệu trang trí",GroupType="Nguyên liệu làm bánh",Image = "/Images/Image_producttype/AFC_producttype.jpeg" },
            //};
            //producttypes.ForEach(s => context.productTypes.Add(s)); 
            //context.SaveChanges();

            ////dungcu
            //var producttypes_dungcu = new List<ProductType>
            //{
            //    new ProductType{Name="Dụng cụ cơ bản",GroupType="Dụng cụ làm bánh",Image = "/Images/Image_producttype/banxoaykinh_producttype.jpeg" },
            //    new ProductType{Name="Dụng cụ đong",GroupType="Dụng cụ làm bánh",Image = "/Images/Image_producttype/dungcudong_producttype.jpeg" },
            //    new ProductType{Name="Cân điện tử",GroupType="Dụng cụ làm bánh",Image = "/Images/Image_producttype/candientu_producttype.jpeg" },
            //    new ProductType{Name="Nhiệt kế ",GroupType="Dụng cụ làm bánh",Image = "/Images/Image_producttyp/nhietke_producttype.jpeg" },
            //    new ProductType{Name="Dụng cụ đánh trứng",GroupType="Dụng cụ làm bánh",Image = "/Images/Image_producttype/maydanhtrung_producttype.jpeg" },
            //    new ProductType{Name="Dụng cụ bát trộn",GroupType="Dụng cụ làm bánh",Image = "/Images/Image_producttype/battron_producttype.jpeg" },
            //    new ProductType{Name="Dụng cụ cán ép",GroupType="Dụng cụ làm bánh",Image = "/Images/Image_producttype/Canep_producttype.jpeg" },
            //    new ProductType{Name="Dụng cụ cây cán bột",GroupType="Dụng cụ làm bánh",Image = "/Images/Image_producttype/caycanbot_producttype.jpeg" },
            //    new ProductType{Name="Dụng cụ rây bột",GroupType="Dụng cụ làm bánh",Image = "/Images/Image_producttype/raybot_producttype.jpeg" },
            //    new ProductType{Name="Dụng cụ làm fondant",GroupType="Dụng cụ làm bánh",Image = "/Images/Image_producttype/Fondant_producttype.jpeg" },
            //    new ProductType{Name="Dụng cụ đui bắt kem",GroupType="Dụng cụ làm bánh",Image = "/Images/Image_producttype/Duibatkem_producttype.jpeg" },
            //    new ProductType{Name="Kim thạch rau câu 3D",GroupType="Dụng cụ làm bánh",Image = "/Images/Image_producttype/Kimraucau3d_producttype.jpeg" },
            //};
            // producttypes_dungcu.ForEach(s => context.productTypes.Add(s));
            // context.SaveChanges();

            ////khuonkhay
            //var producttypes_khonkhay = new List<ProductType>
            //{
            //    new ProductType{Name="Khuôn gato",GroupType="Khuôn khay làm bánh",Image = "/Images/Image_producttype/khuongatoVuong_producttype.jpeg" },
            //    new ProductType{Name="Khay nướng",GroupType="Khuôn khay làm bánh",Image = "/Images/Image_producttype/khaynuong_producttype.jpeg" },
            //    new ProductType{Name="Khuôn cupcake",GroupType="Khuôn khay làm bánh",Image = "/Images/Image_producttype/Cupcake_producttype.jpeg" },
            //    new ProductType{Name="Khuôn bánh mỳ",GroupType="Khuôn khay làm bánh",Image = "/Images/Image_producttype/khaynuongbanhmy_producttype.jpeg" },
            //    new ProductType{Name="Pizza",GroupType="Khuôn khay làm bánh",Image = "/Images/Image_producttype/khuonpizza_producttype.jpeg" },
            //    new ProductType{Name="Khuôn thạch",GroupType="Khuôn khay làm bánh",Image = "/Images/Image_producttype/khuonthach_producttype.jpeg" },
            //    new ProductType{Name="Khuôn kem",GroupType="Khuôn khay làm bánh",Image = "/Images/Image_producttype/khuonkem_producttype.jpeg" },
            //    new ProductType{Name="Khuôn mousse",GroupType="Khuôn khay làm bánh",Image = "/Images/Image_producttype/khuonMousse_producttype.jpeg" },
            //    new ProductType{Name="Khuôn tart",GroupType="Khuôn khay làm bánh",Image = "/Images/Image_producttype/khuonTart_producttype.jpeg" },
              
            //};
            //producttypes_khonkhay.ForEach(s => context.productTypes.Add(s));
            //context.SaveChanges();

            ////tui-hop-coc-lo
            //var producttypes_tuihopcoclo = new List<ProductType>
            //{
            //    new ProductType{Name="Túi giấy",GroupType="Túi,hộp,cốc,lọ",Image = "/Images/Image_producttype/tuigiay_producttype.jpeg" },
            //    new ProductType{Name="Cup giấy",GroupType="Túi,hộp,cốc,lọ",Image = "/Images/Image_producttype/cupgiay_producttype.jpeg" },
            //    new ProductType{Name="Túi đựng socola",GroupType="Túi,hộp,cốc,lọ",Image = "/Images/Image_producttype/cupdungsocola_producttype.jpeg" },
            //    new ProductType{Name="Đế bánh",GroupType="Túi,hộp,cốc,lọ",Image = "/Images/Image_producttype/debanhchunhat_producttype.jpeg" },
            //    new ProductType{Name="Hộp giấy",GroupType="Túi,hộp,cốc,lọ",Image = "/Images/Image_producttype/hopdung_producttype.jpeg" },
            //    new ProductType{Name="Hộp nhựa",GroupType="Túi,hộp,cốc,lọ",Image = "/Images/Image_producttype/hopnhua_producttype.jpeg" },
            //    new ProductType{Name="Hộp thiếc",GroupType="Túi,hộp,cốc,lọ",Image = "/Images/Image_producttype/hopthiec_producttype.jpeg" },
            //    new ProductType{Name="Túi Zip đáy đứng",GroupType="Túi,hộp,cốc,lọ",Image = "/Images/Image_producttype/tuiZipdaydung_producttype.jpeg" },
            //    new ProductType{Name="Nến sinh nhật",GroupType="Túi,hộp,cốc,lọ",Image = "/Images/Image_producttype/nenphaobong_producttype.jpeg" },
            //    new ProductType{Name="Đồ tổ chức party",GroupType="Túi,hộp,cốc,lọ",Image = "/Images/Image_producttype/Icon_producttype.jpeg" },
            //    new ProductType{Name="Hình dán",GroupType="Túi,hộp,cốc,lọ",Image = "/Images/Image_producttype/hinhdan_producttype.jpeg" },
            //    new ProductType{Name="Dây buộc",GroupType="Túi,hộp,cốc,lọ",Image = "/Images/Image_producttype/daybuoc_producttype.jpeg" },
            //};
            //producttypes_tuihopcoclo.ForEach(s => context.productTypes.Add(s));
            //context.SaveChanges();
        }
    }
}