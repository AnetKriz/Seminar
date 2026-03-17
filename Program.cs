namespace test_na_programovani
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pocetMest = Convert.ToInt32(Console.ReadLine());

            int[,] maticeSouvislostiMest = new int[pocetMest, pocetMest];

            for (int i = 0; i < pocetMest; i++)
            {
                int[] dvojiceMest = Convert.ToInt32(Console.ReadLine().Split());

                int x = dvojiceMest[i];
                int y = dvojiceMest[i + 1];
                maticeSouvislostiMest[x, y] = 1;
                maticeSouvislostiMest[y, x] = 1;

            }

            int pocatek = Convert.ToInt32(Console.ReadLine());
            int cil = Convert.ToInt32(Console.ReadLine());

            if  (maticeSouvislostiMest[pocatek, cil] == 1)

            {
                Console.WriteLine($"{pocatek} {cil}");
            }
            Queue<int> cesta = new Queue<int>();
            cesta.Enqueue(pocatek);
            for (int i = 0;i < pocetMest; i++)
            {
                if (maticeSouvislostiMest[pocatek, i] == 1)
                {
                    cesta.Enqueue(i);
                    pocatek = i;
                    i = 0;
                }
                else
                {
                    continue;
                }
            }

            

            
        }
    }
}
