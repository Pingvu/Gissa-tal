using System;

namespace gissa_tal
{
    class Program
    {
        static void Main(string[] args)
        {
        Random slump= new Random();
        int randy = slump.Next(100);
        int nt= 0;
        Console.WriteLine("Gissa ett tal");
        int tal= int.Parse(Console.ReadLine());
       while (tal != randy){
           if (tal < randy){
               Console.WriteLine("talet är för lågt");
           }
           if (tal > randy){
               Console.WriteLine("talet är för högt");
           }
           nt +=1;
       }
            Console.WriteLine("det är rätt tal");
            Console.WriteLine("här är antalet försök" + nt);
            
        }
    }
}
