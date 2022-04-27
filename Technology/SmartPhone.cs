using System;
using System.Collections.Generic;
using System.Text;

namespace Technology
{
    public class SmartPhone : Computer
    {
        public bool HasFlashLight { get; set; } = false;
        public string Orientation { get; set; }

        private readonly string[] array = { "Portrait", "Landscape" };

        private bool binaryIterator = false;

        public SmartPhone(bool hasFlashLight, string orientation, string oS, string processor, int yearMade) : base(oS, processor,yearMade)
        {
            HasFlashLight = hasFlashLight;
            Orientation = orientation;
        }

        public void GyroScope()
        {
            if(binaryIterator)
            {
                Orientation = array[0];
            }
            else
            {
                Orientation=array[1];
            }
            binaryIterator = !binaryIterator;
        }
    }
}
