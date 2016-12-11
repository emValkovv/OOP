using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone
{
    public class GSMTest
    {
        static void Mai()
        {
            GSM[] array = new GSM[5];
            array[0] = new GSM("Galaxy A5", "Samsung", new Battery("BL-40", 230, 4, BatteryTypes.Li_Poly), new Display(5.3, 256000));
            array[1] = new GSM("Fino", "LG", new Battery("BL-50", 230, 4.8, BatteryTypes.NiMH), new Display(5.5, 160000));
            array[2] = new GSM("Lumia 530", "Nokia", new Battery("Mk-40", 275, 4.3, BatteryTypes.Li_Poly), new Display(5.5, 2562000));
            array[3] = new GSM("Z3", "Sony", new Battery("Rs-40", 140, 5.6, BatteryTypes.Li_Poly), new Display(3.5, 56000));
            array[4] = new GSM("Razr", "Motorola", new Battery("tzsr-40", 356, 4, BatteryTypes.NiCd), new Display(5.5, 56000));

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }

            Console.WriteLine(GSM.iPhone4S);
        }
    }
}
