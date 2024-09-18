using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
 
    public class AdapterToCamel : IMove //адаптер
    {
        Camel camel=new Camel(); //вызов объекта класса с описанием верблюда
        public AdapterToCamel(Camel camel)
        {
            this.camel = camel; 
        }
        public void Move()
        {
            camel.Move(); //интерфейс IMove реализовал логику интерфейса IMoveAnimal
        }
    }

}
