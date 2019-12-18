using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class RamaisService
    {
        public  List<Ramais> RamalList(int id, string nome, int ramal)
        {


            var listaRamais = new List<Ramais>();
            listaRamais.AddRange(new[] {
                new Ramais(id,nome,ramal),
            });

            return listaRamais;
        }
        
    }
}
