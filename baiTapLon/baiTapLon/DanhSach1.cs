using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baiTapLon
{
    public class DanhSach1
    {
        private string HoTen;
        private string Sdt;   
        private string Email;
        private string DiaChi;

        public string HoTen1 { get => HoTen; set => HoTen = value; }
        public string Sdt1 { get => Sdt; set => Sdt = value; }     
        public string Email1 { get => Email; set => Email = value; }
        public string DiaChi1 { get => DiaChi; set => DiaChi = value; }

       public DanhSach1(string HoTen, string Sdt, string Email, string DiaChi)
        {
            HoTen1 = HoTen; ;
            Sdt1 = Sdt;
            Email1 = Email;
            DiaChi1 = DiaChi;
        }
    }
}
