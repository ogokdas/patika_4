using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace turDonusumleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 500;
            byte b = 1;
            float c = 500.50F;
            string d = "Merhaba" + a;
            c = a; // float int değerinden kapsamlı olduğu için bilinçli dönüşüm yaptık.
            b = (byte)a; // bilinçsiz dönüşüm
            d = a.ToString(); // stringe çevirdik
        }
    }
}
