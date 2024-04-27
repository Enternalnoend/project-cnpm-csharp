using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongKham.DAO
{
    internal class testDAO
    {
        public void getData()
        {
            DataTable table = DataProvider.Instance.ExecuteQuery("selec * from ");
            foreach (DataRow dr in table.Rows) { }
        }
    }
}
