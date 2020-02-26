using System;

namespace Test1
{
    public class Program1
    {
      protected internal int test = 5;
        
    }

    class Program2:Program1
    {
      public void print(){
        System.Console.WriteLine(test);
      }
      
    }

    class Test
    {
      static void Main(string[] args)
      {
        Program1 p = new Program1();
        //p.print();
        System.Console.WriteLine(p.test);
      }
    }
}
