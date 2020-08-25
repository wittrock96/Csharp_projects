using System;
using System.Collections.Generic;

namespace phone_assignment
{
    public interface IRingable
    {

        string model {get;set;}
        int remainingBattery {get;set;}
        string serviceProvider {get;set;}
        string phoneSound {get;set;}






        

        string ring();

        string unlock();
    

    
        // string DisplayInfo(){}
    }




}