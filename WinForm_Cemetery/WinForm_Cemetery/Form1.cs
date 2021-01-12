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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testDataSet.positions". При необходимости она может быть перемещена или удалена.
            this.positionsTableAdapter.Fill(this.testDataSet.positions);

        }

        private void button3_Click(object sender, EventArgs e)
        {

            positionsTableAdapter.Update(testDataSet);
        }

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure to delete this position", "Deleting",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }





        private void button3_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                positionsTableAdapter.Update(testDataSet);

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 af = new Form2();
            af.Owner = this;
            af.Show();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            positionsTableAdapter.Update(testDataSet);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            positionsTableAdapter.Update(testDataSet);
        }

        private void RefreshBTN_Click(object sender, EventArgs e)
        {
            dataGridView1.Refresh();
        }

        private void SearchBTN_Click(object sender, EventArgs e)
        {
            Form3 searchform = new Form3();
            searchform.Owner = this;
            searchform.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            positionsTableAdapter.Update(testDataSet);

            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
          
        }

        private void button4_Click(object sender, EventArgs e)
        {



        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=dQw4w9WgXcQ");
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Form7 statform = new Form7();
            statform.Owner = this;
            statform.Show();
        }
    }
}
