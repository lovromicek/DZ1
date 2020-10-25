using ClassLibrary1;
using System;

namespace DZ1
{
    class Program
    {
        static void Main(string[] args)
        {
			/* Metoda GenerateRandomScore() nalazi se u main-u jer ako ju stavim u klasu Episode, VS izbacuje pogrešku 
		    "The name GenerateRandomScore does not exist in the current context" što nisam siguran zašto radi i kako to ispraviti.
			Program napisan ovako ispisuje ispravno rješenje. */
			double GenerateRandomScore()
			{
				double rnd;
				Random random = new Random();
				rnd = random.NextDouble() * 10;
				return rnd;
			}
			Episode ep1, ep2;
			ep1 = new Episode();
			ep2 = new Episode(10, 64.39, 8.7);
			int viewers = 10;
			for (int i = 0; i < viewers; i++)
			{
				ep1.AddView(GenerateRandomScore());
				Console.WriteLine(ep1.GetMaxScore());
			}
			if (ep1.GetAverageScore() > ep2.GetAverageScore())
			{
				Console.WriteLine($"Viewers: {ep1.GetViewerCount()}");
			}
			else
			{
				Console.WriteLine($"Viewers: {ep2.GetViewerCount()}");
			}
		}
    }
}
