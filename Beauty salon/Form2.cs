using Beauty_salon.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Beauty_salon
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            using (var context = new DataContext())
            {
                var clients = context.Clients.ToList();
                dataGridView1.DataSource = clients;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            LoadData();  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            if (form7.ShowDialog() == DialogResult.OK)
            {
                LoadData(); 
            }
        }
    }
}
