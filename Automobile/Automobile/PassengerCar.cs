using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automobile
{
    public class PassengerCar<TC> : AutomobileBase<TC>
    {
        public const int DecreaseDistancePercentParameter = 6;


        public int Passengers { get; private set; }

        public PassengerCar(TC passport, decimal averageFuelConsumption, decimal fuelVolume, decimal speed, int passengers)
            : base(passport, averageFuelConsumption, fuelVolume, speed)
        {
            if (passengers > 4 || passengers < 1)
            {
                throw new ArgumentException("Wrong number of passengers");
            }
            else
            {
                Passengers = passengers;
            }
        }

        public override decimal GetRemainingDistance()
        {
            decimal distance = base.GetRemainingDistance();
            decimal onePercent = distance / 100;
            return distance - (DecreaseDistancePercentParameter * Passengers * onePercent);
        }

        protected override void ShowInfo()
        {
            Console.WriteLine(GetRemainingDistance());
        }
    }
}
