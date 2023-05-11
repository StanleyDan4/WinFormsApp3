using System.Data.Sql;
using Microsoft.EntityFrameworkCore;

namespace WinFormsApp3
{

    


    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public List<Sob> Sobs { get; set; }
        public User()
        {
            Sobs = new List<Sob>();
        }
    }
    public class Sob
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Opisanie { get; set; }
        public string Start { get; set; }
        public string End { get; set; }
        public User User { get; set; }
    }


    public partial class Form1 : Form
    {
        private readonly AppDbContext _context;
        public Form1(AppDbContext context)
        {
            InitializeComponent();
            _context = context;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var user = new User
            {
                Name = textBox1.Text,
                Email = textBox2.Text,
                Password = textBox3.Text
            };

            _context.Users.Add(user);
            _context.SaveChanges();

            MessageBox.Show("Вы успешно зарегистрировались!", "Регистрация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }



    }
}
