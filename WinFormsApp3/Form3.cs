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
    public partial class Form3 : Form
    {
        private readonly AppDbContext _context;
        private readonly User _user;

        public Form3(AppDbContext context, User user)
        {
            InitializeComponent();

            _context = context;
            _user = user;

            _user.Sobs = _context.Sobs.Where(b => b.Id == _user.Id).ToList();


            Text = $"Библиотека пользователя {_user.Name}";

            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = _user.Sobs;


        }

        private void button1_Click(object sender, EventArgs e)
        {
             var sobForm = new Form4(_context, _user);
        
            if (sobForm.ShowDialog() == DialogResult.OK)
            {
                _user.Sobs.Add(sobForm.Sob);
                _context.SaveChanges();

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = _user.Sobs;
              
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var selectedRow = dataGridView1.SelectedRows[0];
            var sob = (Sob)selectedRow.DataBoundItem;
            _user.Sobs.Remove(sob);
            _context.SaveChanges();

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = _user.Sobs;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
