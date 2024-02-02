using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c5
{
    internal class Pet
    {
        public string 
            name;
        public float 
            hunger, 
            thirst, 
            sleepiness, 
            happiness;  
        
        public Pet()
        {
            name = "Rex";
            hunger = 0.5f;
            thirst = 0.5f;
            sleepiness = 0.0f;
            happiness = 0.5f;
        }
        public Pet(string name, float hunger, float thirst, float sleepiness, float happiness)
        {
            this.name = name;
            this.hunger = hunger;
            this.thirst = thirst;
            this.sleepiness = sleepiness;
            this.happiness = happiness;
        }

        public void Eat(float foodValue = 0.5f)
        {
            hunger -= foodValue;
            ClampAll01Floats();
        }

        public void RollOver()
        {
            hunger += 0.05f;
            sleepiness += 0.1f;
            happiness += 0.1f;
            ClampAll01Floats();
        }

        public void ClampAll01Floats()
        {
            hunger = Math.Clamp(hunger, 0, 1);
            thirst = Math.Clamp(thirst, 0, 1);
            sleepiness = Math.Clamp(sleepiness, 0, 1);
            happiness = Math.Clamp(happiness, 0, 1);
        }
    }
}
