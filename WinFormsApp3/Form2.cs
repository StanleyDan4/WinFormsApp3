using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp3
{
    public partial class Form2 : Form
    {
        private AppDbContext context;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            User user;
            using (var context = new AppDbContext())
            {
                var email = textBox1.Text;
                var password = textBox2.Text;

#pragma warning disable CS8600 // Преобразование литерала, допускающего значение NULL или возможного значения NULL в тип, не допускающий значение NULL.
                user = context.Users.FirstOrDefault(u => u.Email == email && u.Password == password);
#pragma warning restore CS8600 // Преобразование литерала, допускающего значение NULL или возможного значения NULL в тип, не допускающий значение NULL.
            }


            if (user != null)
            {
                MessageBox.Show("Вы успешно авторизовались!", "Авторизация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form3 mainForm = new Form3(new AppDbContext(), user);
                Hide();
                mainForm.ShowDialog();

                DialogResult dialogResult = MessageBox.Show("Закрыть программу?", "Думай", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                    Close();
                else if (dialogResult == DialogResult.No)
                    Show();
            }
            else
            {
                MessageBox.Show("Неправильный email или пароль", "Ошибка авторизации", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
