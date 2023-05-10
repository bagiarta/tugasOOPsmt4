using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class persegi
    {
        public int sisi;
        public int keliling;
        public int luas;
        public void hitungkeliling()
        {
            keliling = 4 * sisi;
            Console.WriteLine("sebuah persegi dengan panjang sisi {0} cm maka akan memiliki keliling {1}", this.sisi,this.keliling);
        }

        public void hitungluas()

        {
            luas = sisi * sisi;
            Console.WriteLine("sebuah persegi dengan sisi panjang {0} cm maka akan memiliki luas {1}",this.sisi,this.luas);

        }

    }
}
class program
{
    static void Main(string[] args)
    {
        persegi persegi1 = new persegi();
        persegi1.sisi = 20;
        persegi1.hitungkeliling();
        persegi1.hitungluas();

        Console.ReadKey(true);


    }
    
}


        
    

