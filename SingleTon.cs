using System;
using System.Collections.Generic;
using System.Text;
//Anand Jayaraman
namespace SingleTonPattern
{
    public sealed class SingleTon
    {
        private static int counter;
        //private static readonly object obj = new object();
        //Changed the constructor to private to control the instantiation.
        private static SingleTon Instance = new SingleTon();
        //private static readonly Lazy<SingleTon> Instance = new Lazy<SingleTon>(()=>new SingleTon());
        public int SingleTonValue = 0;

        public static SingleTon GetInstance
        {
            get
            {


                //   if (Instance == null)
                //    Instance = new SingleTon();

                //return Instance.Value;
                return Instance;

            }
        }
       
        
    private SingleTon()
        {
            counter++;
            SingleTonValue = 0;
            Console.WriteLine("Shopping Cart Single Instance kicked off " + counter.ToString());
    
        }
        public void Display(string Msg)
        {
            Console.WriteLine(Msg);
        }
    }
}
