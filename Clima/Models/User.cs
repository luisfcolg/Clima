using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clima.Models
{
    public class User
    {
        public string  Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Cities { get; set; }
        public int Passtype { get; set; }

        public User()
        {

        }
    }
}