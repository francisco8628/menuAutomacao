using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace menuAutomação
{
     public class Usuario
    {
        public int Codigo { get;}
        public string Nome { get; set; }
        public int Idade { get; set; }

        public static int totalUsuarios;

        public Usuario()
        {
            totalUsuarios++;
            Codigo = totalUsuarios;
        }
    }
}
