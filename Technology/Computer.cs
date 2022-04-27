using System;
using System.Collections.Generic;
using System.Text;


namespace Technology
{
    public class Computer
    {
            public string OS { get; set; }
            public string Processor { get; set; }
            public int YearMade { get; set; }
            public bool IsOn { get; set; } = false;
        
        public Computer(string oS, string processor, int yearMade)
        {
            OS = oS;
            Processor = processor;
            YearMade = yearMade;
        }
        
        public string ShowSpecs()
        {
            return $"{OS} : {Processor} : {YearMade}";
        }

        public void SwitchPower()
        {
            IsOn = !IsOn;
        }
    }
}

