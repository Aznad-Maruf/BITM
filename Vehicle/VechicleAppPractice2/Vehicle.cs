using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VechicleAppPractice2
{
    public class Vehicle
    {
        private string VehicleName { get; }
        private string RegNo { get; }
        public double MinSpeed { get; private set; }
        public double MaxSpeed { get; private set; }
        public double AvgSpeed { get; private set; }
        private double _sumOfSpeed;
        private double _totalEntry;
        private double NewSpeed;

        public Vehicle()
        {
            this.MinSpeed = double.MaxValue;
            this.MaxSpeed = double.MinValue;
            this.AvgSpeed = 0;
            this._sumOfSpeed = 0;
            this._totalEntry = 0;
        }

        public Vehicle(string vehicleName, string regNo):this()
        {
            this.VehicleName = vehicleName;
            this.RegNo = regNo;
        }

        /*
        public double NewSpeed
        {
            set
            {
                this.NewSpeed = value;
                _sumOfSpeed += NewSpeed;
                _totalEntry++;
                MinSpeed = Math.Min(MinSpeed, NewSpeed);
                MaxSpeed = Math.Max(MaxSpeed, NewSpeed);
                _sumOfSpeed += NewSpeed;
                _totalEntry++;
                AvgSpeed = _sumOfSpeed / _totalEntry;

            }
            get { return NewSpeed; }
        }
        */

        public void setNewSpeed(double newSpeed)
        {
            this.NewSpeed = newSpeed;
            _sumOfSpeed += NewSpeed;
            _totalEntry++;
            MinSpeed = Math.Min(MinSpeed, NewSpeed);
            MaxSpeed = Math.Max(MaxSpeed, NewSpeed);
            _sumOfSpeed += NewSpeed;
            _totalEntry++;
            AvgSpeed = _sumOfSpeed / _totalEntry;
        }
        

    }
}
