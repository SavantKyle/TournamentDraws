using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            var players = new PlayerRepo().Get();
            foreach (var player in players)
            {
                Console.WriteLine($"First Name: {player.FirstName}");
                Console.WriteLine($"Last Name: {player.LastName}");
                Console.WriteLine($"Email: { player.Email}");
                Console.WriteLine($"Phone: {player.Phone}");
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
