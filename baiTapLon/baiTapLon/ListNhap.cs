using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baiTapLon
{
    internal class ListNhap
    {

        List<DanhSach1> dsNhap;

        private static ListNhap vidu;
        public List<DanhSach1> DsNhap { get => dsNhap; set => dsNhap = value; }
        internal static ListNhap Vidu {
            get
            {
                if(vidu == null)
                {
                    vidu = new ListNhap();
                }    
                return vidu;
            }
            set => vidu = value; 
        }

        private ListNhap()
        {
            dsNhap = new List<DanhSach1>();
            dsNhap.Add(new DanhSach1("Nguyễn Phong", "0000000000", "phonga3k54@gmail.com", "Hà Nội"));
            dsNhap.Add(new DanhSach1("Nguyễn Thành", "1111111111", "thanh@gmail.com", "Hà Nội"));
            dsNhap.Add(new DanhSach1("Hoàng Quyết", "2222222222", "quyet@gmail.com", "Hà Nội"));
            dsNhap.Add(new DanhSach1("Nguyễn Phước", "3333333333", "phuoc@gmail.com", "Hà Nội"));
        }
    }
}
