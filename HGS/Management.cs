using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HGS
{
    internal class Management
    {
        int sum;
        public void CalculateDailyProfit()
        {
            sum = 0;
            foreach (var vehicles in HGS.dailyRegister)
            {
                sum = sum + vehicles.balance;
            }
            Console.WriteLine("\nSum of the daily profit: {0}$\n\n*** Daily Report ***\n", sum);
            foreach (var hgsno in HGS.HGSNo)
            {
                foreach (var dates in hgsno.date) { Console.WriteLine("HGS No:{0} Name:{1} Surname:{2} Vehicle Type:{3} Dates:{4}", hgsno.no, hgsno.name, hgsno.surname, hgsno.vehicleType, dates); }
            }
        }
    }
}
