using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HGS
{
    internal class Paydesk
    {
        int spent;
        public void Control(int vehicleType, int balance, int key)
        {
            spent = 0;
            if (vehicleType == Car.type) { balance = balance - Car.cost; spent = Car.cost; }
            else if (vehicleType == Minibus.type) { balance = balance - Minibus.cost; spent = Minibus.cost; }
            else if (vehicleType == Bus.type) { balance = balance - Bus.cost; spent = Bus.cost; }

            HGS.dailyRegister.Add(new HGS()
            {
                no = key,
                balance = spent
            });
            HGS.HGSNo[key].date.Add(DateTime.Now.ToString());
            HGS.HGSNo[key].balance = balance;
            if(balance<0) Console.WriteLine("Attention! The vehicle passed without pay!");
            else Console.WriteLine("Vehicle Passed Succesfully!");
        }
    }
}
