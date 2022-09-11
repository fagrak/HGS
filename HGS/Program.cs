using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HGS
{
    public class HGS
    {
        public static List<HGS> dailyRegister = new List<HGS>();
        public static List<HGS> HGSNo = new List<HGS>();
        public List<string> date = new List<string>();
        public int no { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public int vehicleType { get; set; }
        public int balance { get; set; }

        public static void Main()
        {
            Car car = new Car();
            Minibus minibus = new Minibus();
            Bus bus = new Bus();
            Paydesk paydesk = new Paydesk();
            Management management = new Management();

            HGSNo.Add(new HGS()
            {
                no = 123321,
                name = "Billy",
                surname = "Jones",
                vehicleType = Car.type,
                balance = 1000
            });
            HGSNo.Add(new HGS()
            {
                no = 234432,
                name = "Ricky",
                surname = "Gomes",
                vehicleType = Minibus.type,
                balance = 1000
            });
            HGSNo.Add(new HGS()
            {
                no = 345543,
                name = "Gerry",
                surname = "Bones",
                vehicleType = Bus.type,
                balance = 1000
            });

            while (true)
            {
                Console.WriteLine("\n1- List all HGS numbers\n2- Show the daily profit and report\n\nMake Your Choice...");
                int key = Convert.ToInt32(Console.ReadLine()); Console.Clear();

                if (key == 1)
                {
                    Console.WriteLine("\n*** HGS List ***");
                    foreach (var hgsno in HGSNo)
                    {
                        Console.WriteLine("HGS No:{0} Name:{1} Surname:{2} Vehicle Type:{3} Balance:{4}", hgsno.no, hgsno.name, hgsno.surname, hgsno.vehicleType, hgsno.balance);
                    }
                    Console.WriteLine("\nChoose one from above for enter to Pay-desk...\n");
                    key = Convert.ToInt32(Console.ReadLine()) - 1; Console.Clear(); 
                    if(key>=0 && key<HGSNo.Count) paydesk.Control(HGSNo[key].vehicleType, HGSNo[key].balance, key); //Control if the chosen key out of the list
                }
                else if (key == 2) { management.CalculateDailyProfit(); }
            }
        }
    }
}