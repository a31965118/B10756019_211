using System;

class Hero  //封裝
{
    private string name = "Rock";
    private int HP = 100;
    private int MP = 70;

    public void Skill()
    {
        HP = HP + 100;
    }
}
class HeroA : Hero  //繼承
{

}
/*private void MyFunction(ref int a, ref int b)
{
    a = a * a;
    b = b * b;
}*/
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            /*int a = 10;
            int b = 15;
            MyFunction(ref a, ref b);
            Console.WriteLine(a);
            */
        }
    }
}

