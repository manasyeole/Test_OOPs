using System;
using ExtensionMethods;

public interface Living_things
{
    public void needfood();
}

public abstract class Climate_Earth
{
    public abstract void need_Climate();
    
    public abstract void need_Climate(int k);
    public void need_Earth()
    {
        Console.WriteLine("All need Earth");
    }
}
public class Animal : Climate_Earth ,Living_things
{
    public int k;
    public string name
    {
        get; set;
    }
    public void eat() { Console.WriteLine("Eating..."); }

    public override void need_Climate()
    {
        Console.WriteLine("All Animal need Good Climate to live");
    }
    public void  needfood( )
    {
        Console.WriteLine(" Need food to survive") ;

    }

    public virtual void needWater()
    {
        Console.WriteLine("need water also to survive");
    }
}
public class Dog : Animal
{
    public string cateo
    {
        get; set;
    }

    public void bark() {
        Console.WriteLine(base.name);
        Console.WriteLine("Barking..."); }

    public new void needfood()
    {
        Console.WriteLine("Need food to survive. but only bones");
    }

    public  override void needWater()
    {
        Console.WriteLine("need water also to survive but with good qquality");
    }
}
public class BabyDog : Dog
{
    public void weep() {
        Console.WriteLine(base.cateo + " cateop is");
        Console.WriteLine(base.name);
        Console.WriteLine("Weeping..."); }

    public new void needfood(int a,int b)
    {
        Console.WriteLine("Need food to survive. but only small BONES"+ a+ b);
    }

    public int bath(int a)
    {
        return a + 10;
    }

    public string bath(string a)
    {
        return "hello";
    }
}
class TestInheritance2
{
    public static void Main(string[] args)
    {
        BabyDog d1 = new BabyDog();
        d1.name = "labo";
        d1.cateo = "nak i laio";
        d1.eat();
        d1.bark();
        d1.weep();
        //d1.needfood();
        ////Dog d2 = new Dog();
        ////d2.needfood();
        ////d2.needWater();
        //d1.need_Climate();
        //d1.need_Earth();

        //Console.WriteLine(d1.name);
        Console.WriteLine(d1.bath("heoo"));
        int i = "heloo".WordCount();
        int age = 30;

        try
        {
            if ( age == 30)
            {
                throw new ArithmeticException("Why is ahge 30");
            }
            int[] mynumbers = { 1, 2, 3 };
            Console.WriteLine(mynumbers[10]);
        }
        catch(IndexOutOfRangeException)
        {
            Console.WriteLine("Index out of bouind");
        }
        catch (ArithmeticException)
        {
            Console.WriteLine("ahge odd ");
        }
        catch (FormatException)
        {
            Console.WriteLine("Servisdg ");
        }
        //catch (OverflowException)
        //{
        //    Console.WriteLine("Over flow is occdsk");
        //}
        finally
        {
            Console.WriteLine("Cghal nikal abhguii");
        }
        d1.needfood(10,20);
    }
}