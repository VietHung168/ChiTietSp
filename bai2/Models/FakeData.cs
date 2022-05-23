using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bai2.Models
{
    public  class FakeData
    {
        public  Md_LoaiSanPham ListSanPhamHienThi = new Md_LoaiSanPham();
        public int idSP;
        public FakeData()
        {
            initDATA();
          //  ListSanPhamHienThi.list_SP.
        }
        void initDATA()
        {
            idSP = 258922;
            ListSanPhamHienThi.IDloaiSP ="dochoi";
            ListSanPhamHienThi.TenLoaiSanPham = "Đồ Chơi";
            ListSanPhamHienThi.img = "//cdn.tgdd.vn/Products/Images/10421/258922/do-choi-tram-canh-sat-tuan-tra-cuu-hoa-bien-lego-city-60308-6.jpg";
            ListSanPhamHienThi.link = "/";
            ListSanPhamHienThi.list_SP = new List<Md_SanPham>();
            Md_SanPham sp = new Md_SanPham();
            sp.Id_SanPham = 258922;
            sp.Thuonghieu = "Đan Mạch";
            sp.Ten_SanPham = "Đồ chơi trạm cảnh sát tuần tra và cứu hỏa biển Lego City 60308 (297 chi tiết)";
            sp.giaban = 1689000;
            sp.ds_KhuyenMai = new List<KhuyenMai>();
            KhuyenMai km = new KhuyenMai();
            km.NgayBatDau = new DateTime();
            km.NgayketThuc = new DateTime();
            km.giagiam = 100000;
            km.PhanTramGiam = 10;
            sp.ds_KhuyenMai.Add(km);
            sp.ds_loaiSp = new List<string>();
            sp.ds_loaiSp.Add("Đồ chơi bé trai");
            sp.ds_loaiSp.Add("Đồ chơi lắp ráp");

            

            sp.Dotuoi = 10;
            sp.ChatLieu = "Nhựa";
            KichThuoc kt = new KichThuoc();
            kt.ChieuCao = 10;
            kt.ChieuRong = 10;
            kt.ChieuDai = 10;
            kt.donvi = "cm";
            sp.kichThuocSP =kt ;
            sp.KhoiluongSP = 1000;
            sp.LuuYSuDSuDung = "Có các chi tiết nhỏ, không dùng cho trẻ dưới 3 tuổi, tránh nguy cơ tiềm ẩn khi trẻ sử dụng sai";
            sp.NoiSX = "Trung Quốc";
            sp.DacDiemSP = new List<string>();
            sp.DacDiemSP.Add("Đồ chơi trạm cảnh sát tuần tra và cứu hỏa biển Lego City 60308 bao gồm 297 chi tiết.");
            sp.DacDiemSP.Add("Bé có thể sáng tạo và tưởng tượng câu chuyện của mình.");
            sp.DacDiemSP.Add("Đồ chơi lắp ráp giúp rèn luyện tính rỉ mỉ, sáng tạo của bé khi lắp ráp.");
            sp.DacDiemSP.Add("Đồ chơi Lego City không có góc nhọn, thành phần độc hại nên an toàn cho bé.");
            sp.HDSD_SP = new List<string>();
            sp.HDSD_SP.Add("Đồ chơi không dùng pin.");
            sp.HDSD_SP.Add("Lắp ráp các khớp nối với nhau theo hình trên bao bì.");
            sp.HDSD_SP.Add("Có thể sáng tạo theo trí tưởng tượng của bé.");
            sp.List_imgSP = new List<string>();
            sp.List_imgSP.Add("//cdn.tgdd.vn/Products/Images/10421/258922/do-choi-tram-canh-sat-tuan-tra-cuu-hoa-bien-lego-city-60308-6.jpg");
            sp.List_imgSP.Add("//cdn.tgdd.vn/Products/Images/10421/258922/do-choi-tram-canh-sat-tuan-tra-cuu-hoa-bien-lego-city-60308-2.jpg");
            sp.List_imgSP.Add("//cdn.tgdd.vn/Products/Images/10421/258922/do-choi-tram-canh-sat-tuan-tra-cuu-hoa-bien-lego-city-60308-3.jpg");
            sp.List_imgSP.Add("//cdn.tgdd.vn/Products/Images/10421/258922/do-choi-tram-canh-sat-tuan-tra-cuu-hoa-bien-lego-city-60308-4.jpg");
            sp.List_imgSP.Add("//cdn.tgdd.vn/Products/Images/10421/258922/do-choi-tram-canh-sat-tuan-tra-cuu-hoa-bien-lego-city-60308-5.jpg");
            sp.List_imgSP.Add("//cdn.tgdd.vn/Products/Images/10421/258922/do-choi-tram-canh-sat-tuan-tra-cuu-hoa-bien-lego-city-60308-9.jpg");
            ListSanPhamHienThi.list_SP.Add(sp);
            ListSanPhamHienThi.list_SP.Add(sp);
            ListSanPhamHienThi.list_SP.Add(sp);
            ListSanPhamHienThi.list_SP.Add(sp);
            ListSanPhamHienThi.list_SP.Add(sp);
            ListSanPhamHienThi.list_SP.Add(sp);
            ListSanPhamHienThi.list_SP.Add(sp);
        }

    }
}
