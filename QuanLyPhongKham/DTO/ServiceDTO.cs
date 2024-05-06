using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongKham.DTO
{
    public class ServiceDTO
    {
        private int iD;
        private string name;
        private int price;
        private string unit;
        private string type;
        private string technique;
        private string note;

        public int ID { get => iD; set => iD = value; }
        public string Name { get => name; set => name = value; }
        public int Price { get => price; set => price = value; }
        public string Unit { get => unit; set => unit = value; }
        public string Type { get => type; set => type = value; }
        public string Technique { get => technique; set => technique = value; }
        public string Note { get => note; set => note = value; }

        public ServiceDTO(string name, int price, string unit, string type, string technique, string note) 
        {
            this.ID = -1;
            this.Name = name;
            this.Price = price;
            this.Unit = unit;
            this.Type = type;
            this.Technique = technique;
            this.Note = note;
        }
        public ServiceDTO(DataRow row) {
            this.ID = (int)row["ID"];
            this.Name = row["name"].ToString();
            this.Price =  (int)row["price"];
            this.Unit = row["unit"].ToString();
            this.Type = row["type"].ToString();
            this.Technique = row["technique"].ToString();
            this.Note = row["note"].ToString();
        }
    }

}
