using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bai2.Models
{
    public class KichThuoc
    {
        public float ChieuDai { get; set; }
        public float ChieuRong { get; set; }
        public float ChieuCao { get; set; }
        public string donvi { get; set; }
        public string laychuoi()
        {

            return ChieuDai+"x"+ChieuRong+"x"+ChieuCao+" "+donvi;
        }

    }
}
