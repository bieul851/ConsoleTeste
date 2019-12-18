using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class Ramais
    {
        public int Id  { get; set; }
        public String Nome { get; set; } = string.Empty;
        public int Ramal { get; set; }
        public Ramais()
        {

        }
        public Ramais(int id, string nome, int ramal)
        {
            Id = id;
            Nome = nome;
            Ramal = ramal;
        }

        

        
    }
}
