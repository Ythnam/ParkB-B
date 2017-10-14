using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParkB_B.Model
{
    class Company
    {
        private Parking _parking;
        private string _name;
    
        public Company(string name)
        {
            this.Name = name;
        }

        public Company(string name, Parking parking)
        {
            this.Name = name;
            this.Parking = parking;
        }

        public Parking Parking
        {
            get { return _parking; }
            set
            {
                if (this._parking != value)
                    this._parking = value;
            }
        }

        public string Name
        {
            get { return _name; }
            set
            {
                if (this._name != value)
                    this._name = value;
            }
        }
    }
}
