using System;
using System.Collections.Generic;
using System.Text;

namespace Technology
{
    public class Laptop : Computer
    {
        public bool HasTrackPad { get; set; } = false;
        public bool HasDiscDrive { get; set; }  = false;

        public Laptop(bool hasTrackPad, bool hasDiscDrive, string oS, string processor, int yearMade) : base(oS, processor, yearMade)
        {
            HasTrackPad = hasTrackPad;
            HasDiscDrive = hasDiscDrive;
        }
        
        public void RunDiscDrive()
        {
            if(HasDiscDrive)
            {
                Console.WriteLine("Running Disc Drive!");
            }
            else
            {
                Console.WriteLine("Does not have Disc Drive!");
            }
        }
    }
}
