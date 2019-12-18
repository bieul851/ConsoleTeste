using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp4
{
    class Program
    {
        static List<Ramais> ramais;
        static void Main(string[] args)
        {

            
            try
            {
                
                using (StreamReader streamReader = new StreamReader(@"C:\Users\lcarv\dev\ConsoleTeste\ConsoleApp4\ArquivoCsv\ListaDeRamais.txt"))
                {
                    
                    while (!streamReader.EndOfStream)
                    {
                        String linha = streamReader.ReadLine();

                        var array = linha.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);                        
                        
                        ramais = new List<Ramais>();
                        ramais.Add(new Ramais(Convert.ToInt32(array[0]), array[1], Convert.ToInt32(array[2])));

                        foreach(Ramais r in ramais)
                        {
                            Console.WriteLine("Nome: " + r.Nome + " | Ramal: " + r.Ramal);
                        }
                    }
                }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: "+ex);
            }

            Console.ReadLine();
        }
    }
}
