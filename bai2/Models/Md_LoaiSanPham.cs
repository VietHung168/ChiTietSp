using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bai2.Models
{
    public class Md_LoaiSanPham
    {
        public  string IDloaiSP { get; set; }
        public string TenLoaiSanPham { get; set; }
        public string img { get; set; }
        public string link { get; set; }
        public List<Md_SanPham> list_SP { get; set; }


    }
}
