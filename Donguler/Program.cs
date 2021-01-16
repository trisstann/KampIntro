using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici yetiştirme kampı";
            string kurs2 = "Programlamaya başlangıç için temel kurs";
            string kurs3 = "Java";
            string kurs4 = "Python";
            string kurs5 = "C#";


            //array-dizi

            string[] kurslar = new string[] { "Yazılım Geliştirici yetiştirme kampı", 
                "Programlamaya başlangıç için temel kurs","Java", "Python", "C#" };

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("For bitti");
            foreach (string kurs in kurslar) //kursları dolaş-dizilerde uygulanır dizileri tek tek 
                //dolaşmaya yarar
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("Sayfa sonu- footer");
        }
    }
}
