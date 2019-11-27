using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFromGame {
    class Program {
        static void Main(string[] args) {

            int x = 5;
            float y = 4.5f;
            string str = "Ludimatizando";
            bool mybool = false;

            float result;

            result = 5 + 7;
            Console.WriteLine("suma"+result);

            result = 5 - 7;
            Console.WriteLine("resta" + result);

            result = 5 * 7;
            Console.WriteLine("mult" + result);

            result = 5f / 7f;
            Console.WriteLine("div" + result);

            result = 5 % 2;
            Console.WriteLine("res" + result);

            Console.ReadLine();
        }
    }
}
