using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Camel:IMoveAnimal //класс который реализует интерфейс с движением животного
    {
        public void Move()
        {
            Console.WriteLine("Сажусь на верблюда и еду");
        }

    }
}
