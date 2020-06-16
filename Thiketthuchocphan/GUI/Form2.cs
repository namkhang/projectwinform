using System;
using System.Collections.Generic;
using System.IO;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic;
using DataAccess;

namespace GUI
{
    public partial class Form2 : Form
    {
        PHONGBAN pb = new PHONGBAN();
        HOSO hs = new HOSO();
        string  path_image;
        string nam = "Nam";
        string nu = "Nữ";

        public Form2()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = hs.Showhoso();
            dataGridView1.DataSource = dt;
            DataTable da = new DataTable();
            da = pb.Shownphongban();
            cmbphongban.DataSource = da;
            cmbphongban.DisplayMember = "maphongban";


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmanhanvien.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
            txttennhanvien.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();
            int mm = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[2].Value.ToString().Substring(0, 2));
            int dd = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[2].Value.ToString().Substring(3, 2));
            int yyyy = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[2].Value.ToString().Substring(6, 4));
            dateTimePicker1.Value = new DateTime(yyyy, mm, dd);
            cmbphongban.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[4].Value.ToString();

        }

        private void button5_Click(object sender, EventArgs e)
        {
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                string m = dateTimePicker1.Value.ToString();
            try
            {
                if (checkBox1.Checked) {
                    hs.Themhoso(txtmanhanvien.Text, txttennhanvien.Text, m, nam, cmbphongban.Text, path_image);
                    Form2_Load(sender, e);
                }
                else
                {
                    hs.Themhoso(txtmanhanvien.Text, txttennhanvien.Text, m, nu, cmbphongban.Text, path_image);
                    Form2_Load(sender, e);
                }
            }
            catch (Exception) { MessageBox.Show("Khóa đang trùng hoặc rỗng !!!", "Thông báo", MessageBoxButtons.OK); }
            

        }
       
        private void button2_Click(object sender, EventArgs e)
        {
            
            string m = dateTimePicker1.Value.ToString();
            if (checkBox1.Checked)
            {
                hs.Updatehoso(txtmanhanvien.Text, txttennhanvien.Text, m, nam, cmbphongban.Text, path_image);
                Form2_Load(sender, e);
            }
            else
            {
                hs.Updatehoso(txtmanhanvien.Text, txttennhanvien.Text, m, nu, cmbphongban.Text, path_image);
                Form2_Load(sender, e);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            hs.Xoahoso(txtmanhanvien.Text);
            Form2_Load(sender, e);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.ShowDialog();
            path_image = this.openFileDialog1.FileName;
            if (path_image != "openFileDialog1")
                this.pictureBox1.Image = Image.FromFile(path_image);
        }
    }
}
