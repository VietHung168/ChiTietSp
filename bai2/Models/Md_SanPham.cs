using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bai2.Models
{
    public class Md_SanPham
    {
        public int Id_SanPham { get; set; }
        public string Ten_SanPham { get; set; }
        public int giaban { get; set; }
        public string Thuonghieu { set; get; }
        public List<KhuyenMai> ds_KhuyenMai{ get; set; }
        public  List<string> ds_loaiSp { get; set; }
        public int Dotuoi { get; set; }
        public string ChatLieu { get; set; }
        public KichThuoc kichThuocSP { get; set; }
        public float KhoiluongSP { get; set; }
        public string LuuYSuDSuDung { get; set; }
        public string NoiSX { get; set; }
        public List<string> DacDiemSP { get; set; }
        public List<string> HDSD_SP { get; set; }
        public List<string> List_imgSP { get; set; }




    }
}
