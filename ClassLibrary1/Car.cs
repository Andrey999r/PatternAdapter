using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Car : IMove
    {
        public void Move()
        {
            Console.WriteLine("Сажусь в машину и еду!");
        }
    }
}
