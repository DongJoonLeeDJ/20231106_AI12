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
            zoo.Add(new Animal());
            zoo.Add(new Dog());
            zoo.Add(new Cat());
            //다형성이란 무엇인가?
            //'다'양한 '형'태로 변할 가능'성'
            //A is B, 스마트폰 is 전화기 O
            //전화기 is 스마트폰 (X)

            //Cat is Animal (O)
            //Dog is Animal (O)
            //Animal is Cat(X)
            //Animal is Dog(X)

            //B temp = new A();

            //조상클래스 temp = new 자손클래스();

            Animal aaa = new Cat();
            Animal bbb = new Dog();
            Object o = new Animal(); //참고:Object는 모든 클래스의 조상
            //Object= object
            object oo = new Animal();

            //aaa.meow
            ((Cat)(aaa)).Meow();
            //((Cat)(bbb)).Meow(); //에러 코드임
            if(aaa is Cat) //new Cat인지 여부 체크
            {
                ((Cat)(aaa)).Meow(); ; //강제 형변환
                (aaa as Cat).Meow(); //강제 형변환
            }
            var tempCat = aaa as Cat;
            if(tempCat!=null) //null = new Cat이 아니란 거
                tempCat.Meow();
            var tempAnimal = bbb as Cat;
            if(tempAnimal==null)
                Console.WriteLine("이거 고양이 아님");

            foreach(var item in zoo)
            {
                item.Sleep(); //공통 기능
                item.LivingWorld();
                if(item is Cat)
                {
                    (item as Cat).Meow();
                }
                if(item is Dog)
                {
                    (item as Dog).Bark();
                }
            }

            Animal a1 = new Animal();
            a1.name = "짹짹이";
            Cat c1 = new Cat();
            c1.name = "냥냥이";
            Dog d1 = new Dog();
            d1.name = "컹컹이";
            Animal.zooName = "경북동물원";
            Console.WriteLine(Animal.zooName);
            Console.WriteLine(Cat.zooName);
            Console.WriteLine(Dog.zooName);
            Console.WriteLine(a1.name);
            Console.WriteLine(c1.name);
            Console.WriteLine(d1.name);
            Console.WriteLine("------------------");
            Animal ani1 = new Animal();
            Cat cat1 = new Cat();
            Dog dog1 = new Dog();
            Animal cat2 = new Cat();
            Animal dog2 = new Dog();

            //eat=하이딩(묵시) charm=오버라이딩 cry=하이딩(명시)
            ani1.Eat();//Animal ani1 = new Animal();
            ani1.Charm();
            ani1.cry();
            Console.WriteLine("~~~~~~~~~~~");
            cat1.Eat();//Cat cat1 = new Cat();
            cat1.Charm();
            cat1.cry();
            Console.WriteLine("~~~~~~~~~~~");
            dog1.Eat(); //Dog dog1 = new Dog();
            dog1.Charm();
            dog1.cry();
            Console.WriteLine("~~~~~~~~~~~");
            cat2.Eat(); //Animal cat2 = new Cat();
            cat2.Charm();
            cat2.cry();
            Console.WriteLine("~~~~~~~~~~~");
            dog2.Eat(); //Animal dog2 = new Dog();
            dog2.Charm();
            dog2.cry();
            Console.WriteLine("~~~~~~~~~~~");

            List<Animal> animals = new List<Animal>();
            animals.Add(ani1);
            animals.Add(dog1);
            animals.Add(cat1);
            animals.Add(dog2);
            animals.Add(cat2);
            foreach(Animal animal in animals)
            {
                Console.WriteLine("@@@@@@@");
                animal.Eat();
                animal.Charm(); //오버라이딩은 해당 클래스의 메서드가 무조건 나옴
                animal.cry();
            }

            Console.WriteLine("음식~~~~~");
            //Food f = new Food();
            Food f1 = new Gimbab();
            Food f2 = new Nahn();
            Gimbab g1 = new Gimbab();
            Nahn n1 = new Nahn();

            f1.taste();
            f2.taste();
            g1.taste();
            n1.taste();


        }
    }
}
