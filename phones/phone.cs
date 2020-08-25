using System;
using System.Collections.Generic;
namespace phone_assignment
{
    public abstract class phone : IRingable
    {
        private string _versionNumber;
        public string model
        {
            get{ return _versionNumber;  }
            set{ _versionNumber = value; }
        }
        private int _batteryPercentage;
        public int remaingBattery
        {
            get{ return _batteryPercentage; }
            set{ _batteryPercentage = value; }
        }
        private string _carrier;
        public string serviceProvider
        {
            get{ return _carrier; }
            set{ _carrier = value; }
        }
        private string _ringTone;
        public string phoneSound
        {
            get{ return _ringTone; }
            set{ _ringTone = value; }
        }
        public phone(string versionNumber, int batteryPercentage, string carrier, string ringTone)
        {
            _versionNumber = versionNumber;
            _batteryPercentage = batteryPercentage;
            _carrier = carrier;
            _ringTone = ringTone;           

        }

        public abstract void DisplayInfo();
    }
}