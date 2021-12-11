using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _212054_atvtotaldias
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                double valor_cmp, percentutal;
                Console.Write("imforme o valor da compra: ");
                valor_cmp = double.Parse(Console.ReadLine());

                Console.Write("imforme o percentual de lucro: ");
                percentutal = double.Parse(Console.ReadLine());

                valor_cmp += valor_cmp * (percentutal / 100);

                Console.Write("o valor de venda sera:" + valor_cmp.ToString("c"));

               //codico do rennylson
            }

            catch(FormatException)
            {
                Console.WriteLine("valor digitado invalido");
            }
            catch (Exception erro)
            {
                Console.WriteLine(erro.Message);
           
            
            }
            Console.ReadKey();
        }    
    }
}
