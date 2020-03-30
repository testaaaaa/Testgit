using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testgit
{
    class Program
    {
        static void Main(string[] args)
        {
            var newClass = new NewClass
            {
                Name = "Class", Id = 1,
            };
            Console.WriteLine($"{newClass.Name} {newClass.Id}");

        }
    }
}
