using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public int Opisanie { get; set; }
        public string Start { get; set; }
        public int End { get; set; }
        public User User { get; set; }
    }
    internal class Classes
    {
    }
}
