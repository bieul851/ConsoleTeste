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
        
        static void Main(string[] args)
        {

            
            try
            {
                
                using (StreamReader streamReader = new StreamReader(@"C:\ArquivoCsv\ListaDeRamais.txt"))
                {
                    while (!streamReader.EndOfStream)
                    {
                        
                        String linha = streamReader.ReadLine();

                        var array = linha.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);

                        
                        RamaisService ramais = new RamaisService();
                        ramais.RamalList(Convert.ToInt32(array[0]), array[1], Convert.ToInt32(array[2]));

                    }
                }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: "+ex);
            }

            Console.ReadKey();
        }
    }
}
