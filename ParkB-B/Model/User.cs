using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParkB_B.Model
{
    public class User
    {
        private string _firstName;
        private string _lastName;
        private string _matriculation;
        private List<Contract> _contracts;
        private string _parkingID;

        public User(string fn, string ln, string matriculation, string parkingID)
        {
            this.FirstName = fn;
            this.LastName = ln;
            this.Matriculation = matriculation;
            this.ParkingID = parkingID;
        }

        public User(string fn, string ln, string matriculation)
        {
            this.FirstName = fn;
            this.LastName = ln;
            this.Matriculation = matriculation;
        }

        public User()
        {
        }

        public string FirstName
        {
            get { return _firstName; }
            set
            {
                if (this._firstName != value)
                    this._firstName = value;
            }
        }

        public string LastName
        {
            get { return _lastName; }
            set
            {
                if (this._lastName != value)
                    this._lastName = value;
            }
        }

        public string Matriculation
        {
            get { return _matriculation; }
            set
            {
                if (this._matriculation != value)
                    this._matriculation = value;
            }
        }

        public string ParkingID
        {
            get { return _parkingID; }
            set
            {
                if (this._parkingID != value)
                    this._parkingID = value;
            }
        }

        public List<Contract> Contracts
        {
            get { return _contracts; }
            set
            {
                if (this._contracts != value)
                    this._contracts = value;
            }
        }
    }
}
