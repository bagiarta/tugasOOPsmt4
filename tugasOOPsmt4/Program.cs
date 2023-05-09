using System;

namespace tugasOOPsmt4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== PILIH JENIS OPERASI ===");
            Console.WriteLine("Menghitung Luas Persegi = 1");
            Console.WriteLine("Menghitung Luas Segi Tiga = 2");
            Console.WriteLine("Menghitung Luas Lingkaran = 3");
            Console.Write("\n\n press number to select option :  ");

            string input = Console.ReadLine();

            if (input == "1")
                
            {
                Console.WriteLine("===MENGHITUNG LUAS PERSEGI===");
                Console.WriteLine();
                int panjangsisi, luaspersegi;
                Console.Write("panjang sisi :");
                panjangsisi = int.Parse(Console.ReadLine());
                luaspersegi = panjangsisi * panjangsisi;
                Console.WriteLine("\n===HASIL HITUNG LUAS PERSEGI===");
                Console.WriteLine("Luas persegi adalah : {0}", luaspersegi);
                Console.WriteLine("press any key for details");
                Console.ReadKey(true);
                Console.Write("S = {0}", panjangsisi);
                Console.Write("\n Rumus luas Persegi = S X S ");
                Console.Write("\n Luas Persegi = {0}",(panjangsisi+" X "+panjangsisi));
                Console.WriteLine("\n luas ={0} ", luaspersegi);

            }
            else if (input == "2")
            {
                Console.WriteLine("===MENGHITUNG LUAS SEGI TIGA===");
                Console.WriteLine();
                double panjangalas, tinggi, luassegitiga, konstanta;
                Console.WriteLine("masukan nilai panjang alas");                
                panjangalas = Double.Parse(Console.ReadLine());
                Console.WriteLine("masukan nilai Tinggi");
                tinggi = double.Parse(Console.ReadLine());
                konstanta = 0.5;
                luassegitiga = konstanta * (panjangalas *tinggi);
                Console.WriteLine("\n===HASIL HITUNG LUAS SEGI TIGA===");
                Console.WriteLine("Luas segi tiga  adalah :{0}", luassegitiga);
                Console.WriteLine("press any key for details");
                Console.ReadKey(true);
                Console.Write("\n k = {0}", konstanta);
                Console.Write("\n a = {0}", panjangalas);
                Console.Write("\n t = {0}", tinggi);
                Console.Write("\n Rumus Luas Segi Tiga = 0.5 x a x t");
                Console.Write("\n Luas segitiga = {0}",(konstanta+" X "+panjangalas+" X "+tinggi));
                Console.WriteLine("\n Luas = {0}", luassegitiga);
            }
            else if (input=="3")
            {
                Console.WriteLine("===MENGHITUNG LUAS LINGKARAN===");
                Console.WriteLine();
                double r, luaslingkaran;
                Console.WriteLine("masukan panjang jari-jari");
                r = double.Parse(Console.ReadLine());
                luaslingkaran = Math.PI*r*r;
                Console.WriteLine("\n===HASIL HITUNG LUAS LINGKARAN===");
                Console.WriteLine("Luas lingkaran adalah {0}:", luaslingkaran);
                Console.WriteLine("press any key for details");
                Console.ReadKey(true);              
                Console.Write("\n PI = {0}", Math.PI);
                Console.Write("\n r = {0}", r);
                Console.Write("\n Rumus Luas Lingkaran = PI x r x r");
                Console.Write("\n Luas Lingkaran = {0}", (Math.PI + " x " + r + " x " + r));
                Console.Write("\n Luas = {0} ",luaslingkaran);
            }
            else
            {
                Console.WriteLine("pilihan anda tidak tersedia");
                Console.Write("\n silakan memilih salah satu dari dari opsi yang tersedia!");
                
                Console.ReadKey(true);
                
            }
            
                                   
            Console.WriteLine("\n press any key to continue");
            Console.ReadKey(true);
            
        }
    }
}
