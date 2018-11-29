using System;
 class Box
    {
       private double length;   // 长度
       private double breadth;  // 宽度
       private double height;   // 高度
       public void setLength( double len )
       {
            length = len;
       }

       public void setBreadth( double bre )
       {
            breadth = bre;
       }

       public void setHeight( double hei )
       {
            height = hei;
       }
       public double getVolume()
       {
           return length * breadth * height;
       }
    }
namespace MJ
{
    class Program
    {
        enum days{a1,a2,a3,a4,a5,a6,a7}

        static void Main(string[] args)
        {
             int WeekdayStart = (int)days.a1+20;
         int WeekdayEnd = (int)days.a7+200;
         Console.WriteLine("a1: {0}", WeekdayStart);
         Console.WriteLine("a7: {0}", WeekdayEnd);
        Box Box1 = new Box();        // 声明 Box1，类型为 Box
            Box Box2 = new Box();         // 声明 Box2，类型为 Box
            double volume;                 // 体积


            // Box1 详述
            Box1.setLength(6.0);
            Box1.setBreadth(7.0);
            Box1.setHeight(5.0);

            // Box2 详述
            Box2.setLength(12.0);
            Box2.setBreadth(13.0);
            Box2.setHeight(10.0);
       
            // Box1 的体积
            volume = Box1.getVolume();
            Console.WriteLine("Box1 的体积： {0}" ,volume);

            // Box2 的体积
            volume = Box2.getVolume();
            Console.WriteLine("Box2 的体积： {0}", volume);
           
        }
    }
}
