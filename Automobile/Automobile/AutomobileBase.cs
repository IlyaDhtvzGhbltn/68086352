using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automobile
{
    public abstract class AutomobileBase<TC>
    {
        protected TC Passport { get; private set; }
        protected decimal AverageFuelConsumptionInHour { get; private set; }
        protected decimal FuelVolume { get; private set; }
        protected decimal SpeedKmH { get; private set; }

        public AutomobileBase(TC passport, decimal averageFuelConsumption, decimal fuelVolume, decimal speed)
        {
            Passport = passport;
            AverageFuelConsumptionInHour = averageFuelConsumption;
            FuelVolume = fuelVolume;
            SpeedKmH = speed;
        }

        protected abstract void ShowInfo();

        public virtual decimal GetRemainingDistance() 
        {
            decimal time = getRemainingTime();
            decimal distance = time * SpeedKmH;
            return distance;
        }

        public virtual decimal GetRemainingTime() 
        {
            return getRemainingTime();
        }


        private decimal getRemainingTime() 
        {
            return FuelVolume / AverageFuelConsumptionInHour;
        }

    }
}
