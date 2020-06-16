using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataAccess;

namespace BusinessLogic
{
   public class PHONGBAN
    {
        Xuly xl = new Xuly();
        public DataTable Shownphongban()
        {
            string sql = "SELECT *FROM PHONGBAN";
            DataTable dt = new DataTable();
            dt = xl.Gettable(sql);
            return dt;
        }
       
    }
}
