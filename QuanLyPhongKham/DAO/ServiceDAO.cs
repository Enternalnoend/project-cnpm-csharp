using QuanLyPhongKham.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongKham.DAO
{
    internal class ServiceDAO
    {
        private static ServiceDAO instance;
        private ServiceDAO() {}
        internal static ServiceDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new ServiceDAO();
                return instance;
            }
            private set => instance = value;
        }
        public  List<ServiceDTO> getallservice() {
            List<ServiceDTO> list = new List<ServiceDTO>();
            DataTable table = DataProvider.Instance.ExecuteQuery("select * from Service");
            foreach (DataRow row in table.Rows)
            {
                list.Add(new ServiceDTO(row));
            }
            return list;
        }
        public List<ServiceDTO> getoneservice( string text)
        {
            List<ServiceDTO> list = new List<ServiceDTO>();
            DataTable table = DataProvider.Instance.ExecuteQuery("select * from Service where Technique = text");
            foreach (DataRow row in table.Rows)
            {
                list.Add(new ServiceDTO(row));
            }
            return list;
        }

    }
}
