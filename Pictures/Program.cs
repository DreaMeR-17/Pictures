using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pictures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int picturesInRow = 3;
            int allPictures = 52;

            int allFullRow = (allPictures / picturesInRow);
            int lostPictures = (allPictures % picturesInRow);

            Console.WriteLine("Картинок в одном ряду: " + picturesInRow);
            Console.WriteLine("Всего картинок: " + allPictures);
            Console.WriteLine("Всего полных рядов: " + allFullRow);
            Console.WriteLine("Не вошедшие в полный ряд картинки: " + lostPictures);
        }
    }
}
