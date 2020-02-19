using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MySchool : Form
    {


        public MySchool()
        {
            InitializeComponent();
            BindCombobox();
        }
        private void BindCombobox()
        {
            DataTable data = new DataTable();

            DataColumn dc1 = new DataColumn("display");
            DataColumn dc2 = new DataColumn("value");
            data.Columns.Add(dc1);
            data.Columns.Add(dc2);

            DataRow dr1 = data.NewRow();
            dr1["display"] = "系统管理员";
            dr1["value"] = "admin";

            DataRow dr2 = data.NewRow();
            dr2["display"] = "学生";
            dr2["value"] = "student";

            data.Rows.Add(dr1);
            data.Rows.Add(dr2);

            comboBox1.ValueMember = "value";
            comboBox1.DisplayMember = "display";
            comboBox1.DataSource = data;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
