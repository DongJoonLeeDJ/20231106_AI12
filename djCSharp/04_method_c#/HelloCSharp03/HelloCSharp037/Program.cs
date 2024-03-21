using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloCSharp037
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal a = new Animal();
            a.name = "뭉치";
            a.age = 10;
            Animal b = new Animal();
            b.name = "루이";
            b.age = 0;
            //Run, Fight는 Program 내에서는 호출 불가능
            a.Sleep();
            a.LivingWorld();
            b.Sleep();
            b.LivingWorld();
            Cat c = new Cat();
            c.name = "네로";
            c.age = 5;
            c.Meow();
            c.Sleep();
            c.LivingWorld();
            Dog d = new Dog();
            d.name = "멍뭉이";
            d.age = 0;
            d.LivingWorld();
            d.Sleep();
            d.Bark();

            //상속에 의해서 그리고 다형성에 의해서 Animal타입의 리스트에
            //Animal, Cat, Dog가 모두 포함될 수 있다.
            List<Animal> zoo = new List<Animal>();
            zoo.Add(a);
            zoo.Add(b);
            zoo.Add(c);
            zoo.Add(d);
        }
    }
}
