using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp3
{
    public class Sob
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Opisanie { get; set; }
        public string Start { get; set; }
        public string End { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
