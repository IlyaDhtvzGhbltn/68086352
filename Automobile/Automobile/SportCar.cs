using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automobile
{
    public class SportCar<TC> : AutomobileBase<TC>
    {

        public SportCar(TC passport, decimal averageFuelConsumption, decimal fuelVolume, decimal speed)
            : base(passport, averageFuelConsumption, fuelVolume, speed)
        { }

        protected override void ShowInfo()
        {
            Console.WriteLine(GetRemainingDistance());
        }
    }
}
