using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lr_fifteen
{
    public partial class Form1 : Form
    {
        public List<Абитуриенты> sheetAbiturients;
        public ip521_SofronovEntities db;
   

    public Form1()
        {
            InitializeComponent();
            db = new ip521_SofronovEntities();
            sheetAbiturients = db.Абитуриенты.OrderBy(o => o.Код_абитуриента).ToList();




            dataGridView1.DataSource = sheetAbiturients;
            dataGridView1.ReadOnly = true;
            if (dataGridView1.RowCount == 0) label1.Visible = true;
            else label1.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns[0].HeaderText = "№";
            dataGridView1.Columns[0].Width = 30;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                switch (comboBox1.SelectedIndex)
                {
                    case 0:
                        dataGridView1.DataSource = sheetAbiturients.Where(p => p.Код_абитуриента.ToString() == textBox1.Text.ToString());
                        break;
                    case 1:
                        dataGridView1.DataSource = sheetAbiturients.Where(p => p.Фамилия.ToString().Contains(textBox1.Text.ToString())).ToList();
                        break;
                }
            }
            else
            {
                dataGridView1.DataSource = sheetAbiturients;
            }
            dataGridView1.Update();
            if (dataGridView1.RowCount == 0) label1.Visible = true;
            else label1.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.Count == 1)
            {
                FormAddAbiturient addAbit = new FormAddAbiturient();
                addAbit.Owner = this;
                addAbit.Show();
            }
            else
            {
                Application.OpenForms[1].Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count == 1)
            {
                Абитуриенты item = sheetAbiturients.First(w => w.Код_абитуриента.ToString() == dataGridView1
                .SelectedCells[0]
                .OwningRow
                .Cells[0]
                .Value
                .ToString());
            }
            else
            {
                Application.OpenForms[1].Focus();
            }
        }
    }
}
