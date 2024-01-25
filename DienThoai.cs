using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace luyentap2
{
    public class DienThoai
    {
        public int MaDT { get; set; }
        public string TenDT { get; set; }
        public string ThuongHieu { get; set; }
    }

    public class DienThoaiChiTiet : DienThoai {
        public int MaDT { get; set; }
        public int DungLuong { get; set; }
        public string MauSac { get; set; }
        public int SoLuong { get; set; }
        public double GiaTien { get; set; }
        public bool TrangThai { get; set; }
    }
}
