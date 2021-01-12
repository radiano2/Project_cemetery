using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm_Cemetery
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();

            Form1 main = this.Owner as Form1;

            
            List<string> list = new List<string>();
            

            

            foreach (DataGridViewRow item in main.dataGridView1.Rows)
            {
                list.Add(item.Cells[5].Value.ToString());
            }

            var groups = list.GroupBy(x => x);


            foreach (var item in groups)
            {
                chart1.Series["s1"].Points.AddXY(item.Key, item.Count());
            }





        }
    }
}
