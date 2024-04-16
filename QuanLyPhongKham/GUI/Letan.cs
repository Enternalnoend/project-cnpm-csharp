using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyPhongKham.GUI
{
    public partial class Letan : Form
    {
        public Letan()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void Letan_Load(object sender, EventArgs e)
        {
            panel12.Size = panel12.MinimumSize;
        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button31_Click(object sender, EventArgs e)
        {
            panel12.Size = panel12.MinimumSize;
        }

        private void button31_MouseHover(object sender, EventArgs e)
        {
            panel12.Size = panel12.MaximumSize;
        }

        private void button35_Click(object sender, EventArgs e)
        {
            Lichkham lichkham = new Lichkham();
            lichkham.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thembenhnhan thembenhnhan = new Thembenhnhan();
            thembenhnhan.Show();
        }
    }
}
