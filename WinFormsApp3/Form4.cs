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
    public partial class Form4 : Form
    {
        private readonly AppDbContext _context;
        private readonly User _user;

        public Sob Sob { get; private set; }

        public Form4(AppDbContext context, User user)
        {
            InitializeComponent();

            _context = context;
            _user = user;

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var sob = new Sob
            {
                Name = textBox1.Text,
                Opisanie = textBox2.Text,
                Start = textBox3.Text,
                End = textBox4.Text,
                Id = _user.Id
            };

            _context.Sobs.Add(sob);
            _context.SaveChanges();

            Sob = sob;
            DialogResult = DialogResult.OK;

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
