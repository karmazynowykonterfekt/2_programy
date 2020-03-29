using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_programy
{
    class Program
    {
        static void Main(string[] args)
        {
            //WYŚWIETL W KONSOLI PROSTOKĄT O SZEROKOŚCI X ORAZ WYSOKOŚCI Y
            //X ORAZ Y PODAJE UŻYTKOWNIK, PROSTOKĄT ZBUDOWANY JEST Z *
            Console.Write("Podaj wymiar X: ");
            string sX = Console.ReadLine();
           
            Console.Write("Podaj wymiar Y: ");
            string sY = Console.ReadLine();

            int[,] wym = new int[Convert.ToInt32(sX), Convert.ToInt32(sY)];

            for (int i = 0; i < wymX.Length; i++)
                for (int j = 0; j < wymX.Length; j++)
                Console.Write(wym[i,j].ToString());
            Console.WriteLine();        
           
            Console.ReadKey();


        }
    }
}
