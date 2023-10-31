using System.Net.Http.Headers;

public static class Game
{
    public static void Main()
    {
        //进化及对战未完成,基本功能已实现
        Animal animal = new Animal("动物", 0);
        Animal fish = new Fish("鱼", 0);
        Animal bird = new Bird("鸟", 0);
        Animal shark = new Shark("鲨鱼", 0);
        Animal eagle = new Eagle("老鹰", 0);
        animal.OnShow();
        fish.OnShow();
        bird.OnShow();
        shark.OnShow();
        eagle.OnShow();
    }

    public class Animal
    {
        //定义动物类作为基类,定义属性名字和年龄
        private string name;
        private int age;
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        protected string Name
        {
            get { return name; }
            set
            {
                name = value;
            }
        }

        public Animal(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        //定义一个介绍自己的方法
        public void Intruduce()
        {
            //介绍自己的种类,名字和年龄
            Console.WriteLine($"我的名字叫{this.Name},我今年{this.Age}岁了");
        }

        //定义一个展示自己的虚方法,在子类中重写
        public virtual void Show()
        {
        }

        //定义一个实现多态的函数充当接口
        public void OnShow()
        {
            this.Intruduce();
            this.Show();
        }
    }


    public class Fish : Animal
    {
        //子类鱼,继承父类动物
        public Fish(string name, int age) : base(name, age)
        {
        }

        public override void Show()
        {
            Console.WriteLine($"{this.Name}吐出了一串气泡");
        }
    }

    public class Bird : Animal
    {
        public Bird(string name, int age) : base(name, age)
        {
        }

        public override void Show()
        {
            Console.WriteLine($"{this.Name}轻轻拍打翅膀");
        }
    }

    public class Shark : Fish
    {
        public Shark(string name, int age) : base(name, age)
        {
        }

        public override void Show()
        {
            Console.WriteLine($"{this.Name}张口露尖牙");
        }
    }

    public class Eagle : Bird
    {
        public Eagle(string name, int age) : base(name, age)
        { }

        public override void Show()
        {
            Console.WriteLine($"{this.Name}展翅盘旋");
        }
    }
}