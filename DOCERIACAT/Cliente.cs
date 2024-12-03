using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOCERIACAT
{
    internal class Cliente
    {
        public int codCliente { get; set; }
        public string User { get; set; }
       
        public float Pass { get; set; }

        public Cliente(int codCliente, string user,
            float pass) : this(user,pass)
        {
            codCliente = codCliente;
        }

        public Cliente(string user, float pass)
        {
            User = user;
            Pass = pass;


        }
    }
}
