using System.ComponentModel;
using System.ComponentModel.Design;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace prvocislo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> Cisla = new List<int>();
            List<int> Prvocisla = new List<int>();
            int nula = 0;
           while(true) {
                int n = Convert.ToInt32(Console.ReadLine());
                Cisla[nula] = n;
                nula++;
                if (n == 0) {
                    break;
                }


            }

            for (int i = 0; i< Cisla.Count;i++) {
                if JePrvocislo(Cisla[i]) = 0;
                Prvocisla.Add(Cisla[i]);
            }

            Console.WriteLine(Prvocisla);

            if Prvocisla.Count == 0 {
                Console.WriteLine("V teto posloupnosti neni žádné prvočíslo");
            }
        }
    }

    }
        
        public class JePrvocislo
        {
            public JePrvocislo(int n )
            {
              for (int i = 2; i < n; i++) {
                       int zbytek = n % i;
                    if (zbytek == 0) {
                        return zbytek;
                    }
                }
            }
}

