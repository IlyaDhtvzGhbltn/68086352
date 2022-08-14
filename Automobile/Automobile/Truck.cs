using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automobile
{
    public class Truck<TC> : AutomobileBase<TC>
    {

        public decimal LoadCapacityKg { get; private set; }
        public const int DecreaseDistancePercentParameter = 4;
        public const int DecreaseDistanceKg = 200;


        public Truck(TC passport, decimal averageFuelConsumption, decimal fuelVolume, decimal speed, decimal loadCapacity)
            :base(passport, averageFuelConsumption, fuelVolume, speed)
        {
            if (loadCapacity >= 5000 || loadCapacity < 0)
            {
                throw new ArgumentException("Wrong load capacity value");
            }
            else 
            {
                LoadCapacityKg = loadCapacity; 
            }
        }

        public override decimal GetRemainingDistance()
        {
            decimal distance = base.GetRemainingDistance();
            decimal decreaseIndex = LoadCapacityKg / DecreaseDistanceKg;
            decimal deceracePercents = decreaseIndex * DecreaseDistancePercentParameter;
            decimal onePercent = distance / 100;
            return distance - (onePercent * deceracePercents);
        }

        protected override void ShowInfo()
        {
            Console.WriteLine(GetRemainingDistance());
        }
    }
}
