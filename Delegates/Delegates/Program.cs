using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Program
    {
        public delegate void MyDelegate();
        public delegate void MyDelegate2(string text);
        public delegate int MyDelegate3(int number1, int number2);
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            // customerManager.SendMessage();
            //customerManager.ShowAlert();

            //Parametresiz,void
            MyDelegate myDelegate = customerManager.SendMessage; //Elçi,Selam ver
            myDelegate += customerManager.ShowAlert;             //Uyarı
            myDelegate -= customerManager.SendMessage;           //Selam vermeyi bırak
            myDelegate();
          
            //parametreli,void
            MyDelegate2 myDelegate2 = customerManager.SendMessage2; 
            myDelegate2 += customerManager.ShowAlert2;
            myDelegate2("Hello");                                //İkisi içinde hello gönderiyor

            //parametreli,int
            Matematik matematik = new Matematik();
            MyDelegate3 myDelegate3 = matematik.Topla;
            myDelegate3 += matematik.Carp;
            var sonuc=myDelegate3(2, 3);
            Console.WriteLine(sonuc);

            Console.ReadLine();
        }
    }
}
