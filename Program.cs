using System;

namespace Aula16MetódoConstrutor
{
    class Program
    {
        static void Main(string[] args)
        {
         Personagem ichigo =new Personagem();

         Personagem rangiko = new Personagem("Matsumoto");
         System.Console.WriteLine(rangiko.Nome);


         System.Console.WriteLine();

         Personagem soiFong = new Personagem("Soi Fong", "Suzumebachi","Jakuhō Raikōben",13,6500);
         System.Console.WriteLine(soiFong.Nome);
         System.Console.WriteLine(soiFong.Shikai);
         System.Console.WriteLine(soiFong.Bankai);
         System.Console.WriteLine(soiFong.Esquadrao);
         System.Console.WriteLine(soiFong.Poder);
        }

       
    }
}
