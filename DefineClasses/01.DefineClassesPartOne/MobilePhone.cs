using System;
using System.Collections.Generic;

namespace MobilePhone
{
    class MobilePhone
    {
        static void Main()
        {
            Call callOne = new Call(new DateTime(1882,4,2,22,5,40), "Emanuil", 446.25);

            Console.WriteLine(callOne.Contact);

            
            

        }
    }
}
