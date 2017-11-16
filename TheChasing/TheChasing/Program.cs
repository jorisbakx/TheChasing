using System;

namespace TheChasing
{
    class Program
    {
        static void Main(string[] args)
        {
            // make jail
            Jail jail = new Jail();

			// make thief
			Thief thief = new Thief("Dyon Altena");
			// make cop
			Cop cop = new Cop();
			// cop puts thief in jail
			cop.Catch(thief);

            Console.WriteLine(jail);
			Console.WriteLine(cop);
			Console.WriteLine(thief);

			Console.Read();
        }
    }
}
