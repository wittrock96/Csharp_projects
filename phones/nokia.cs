using System;
using System.Collections.Generic;


namespace phone_assignment
{
    public class Nokia : phone, IRingable 
    {
        public Nokia(string versionNumber, int batteryPercentage, string carrier, string ringTone) 
            : base(versionNumber, batteryPercentage, carrier, ringTone) 
        {
            

        }
        public string Ring() 
        {
            // your code here
        }
        public string Unlock() 
        {
            // your code here
        }
        public override void DisplayInfo() 
        {
            // your code here            
        }
    }
       
}