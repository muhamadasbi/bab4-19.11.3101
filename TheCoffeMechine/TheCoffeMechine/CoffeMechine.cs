using System;
using System.Collections.Generic;
using System.Text;

namespace TheCoffeMechine
{
    class CoffeMechine
    {
        private CoffePowder coffePowder;
        private WaterGalon waterGalon;
        private Milk milk;

        public CoffeMechine(CoffePowder powder, WaterGalon galon)
        {
            this.waterGalon = galon;
            this.coffePowder = powder;
            
        }


        public CoffeMechine(CoffePowder powder, WaterGalon galon, Milk milk)
        {
            this.waterGalon = galon;
            this.coffePowder = powder;
            this.milk =milk;
        }

        public string makeEsspresso()
        {
            if (!this.waterGalon.isAvailable())
            {
                return "sorry, the water is empty";
            }
            if (!this.coffePowder.isAvailable())
            {
                return "sorry, the water is empty";
            }
            if (!this.milk.isAvailable())
            {
                return "sorry, the water is empty";
            }
            this.waterGalon.makeOneCup();
            this.coffePowder.makeOneCup();
            this.milk.makeOneCup();
            return "yey! your coffe is ready";
        }
        public string checkAvailability()
        {
            return $"the water :{this.waterGalon.getVolume()} and the coffe powder : {this.coffePowder.getNetto()}";
        }
    }
}
