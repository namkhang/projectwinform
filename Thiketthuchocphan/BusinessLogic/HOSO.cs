using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataAccess;

namespace BusinessLogic
{
    public class HOSO
    {
        Xuly xl = new Xuly();
        public DataTable Showhoso()
        {
            string sql = "SELECT manhanvien , hoten ,ngaysinh , gioitinh , maphongban FROM HOSO";
            DataTable dt = new DataTable();
            dt = xl.Gettable(sql);
            return dt;
        }
        public void Themhoso(string mnv, string hoten, string ngaysinh, string gioitinh , string mpb, string anv )
        {
            string sql = "INSERT HOSO VALUES (N'" + mnv + "',N'" + hoten + "',N'" + ngaysinh + "',N'" + gioitinh +"', N'" + mpb + "','" + anv + "')";
            xl.ExcuteNonQuery(sql);
        }
        public void Updatehoso(string mnv, string hoten, string ngaysinh, string gioitinh, string mpb, string anv)
        {
            string sql = "UPDATE HOSO SET  hoten = N'" + hoten + "',ngaysinh = N'" + ngaysinh + "', gioitinh = N'" + gioitinh + "', maphongban = '" + mpb + "', anhnhanvien = '" + anv + "' WHERE manhanvien = '" + mnv + "' ";
            xl.ExcuteNonQuery(sql);
        }
        public void Xoahoso(string mnv)
        {
            string sql = "DELETE HOSO WHERE manhanvien = '" + mnv + "' ";
            xl.ExcuteNonQuery(sql);
        }

    }
}
