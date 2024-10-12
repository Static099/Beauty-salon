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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string clientIdText = textBox1.Text;
            string fullName = textBox2.Text;
            string email = textBox3.Text;
            string phoneNumber = textBox4.Text;

            if (string.IsNullOrEmpty(clientIdText) || string.IsNullOrEmpty(fullName) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(phoneNumber))
            {
                MessageBox.Show("Все поля должны быть заполнены.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Проверка, что ClientId является числом
            if (!int.TryParse(clientIdText, out int clientId))
            {
                MessageBox.Show("ID клиента должно быть числом.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (var context = new DataContext())
            {
                if (context.Clients.Any(c => c.ClientId == clientId))
                {
                    MessageBox.Show("Клиент с таким ID уже существует. Введите другой ID.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var newClient = new Clients
                {
                    ClientId = clientId,  
                    FullName = fullName,
                    Email = email,
                    PhoneNumber = phoneNumber
                };

                context.Clients.Add(newClient);
                context.SaveChanges();  
            }

            MessageBox.Show("Клиент успешно добавлен!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }  
}

