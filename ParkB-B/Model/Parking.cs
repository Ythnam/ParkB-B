using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParkB_B.Model
{
    public class Parking
    {
        private string _address;
        private int _numberOfPlaces;
        private int _numberOfPlacesAvailable;
        private string _name;
        private List<User> _users;

        public Parking(string address, int nrPlace, int nrPlaceAvail, string name)
        {
            this.Address = address;
            this.NumberOfPlaces = nrPlace;
            this.NumberOfPlacesAvailable = nrPlaceAvail;
            this.Name = name;
            this.Users = new List<User>();
        }

        public Parking()
        {
        }

        public void AddUser(User user)
        {
            this.Users.Add(user);
        }


        public string Address
        {
            get { return _address; }
            set
            {
                if (this._address != value)
                    this._address = value;
            }
        }

        public int NumberOfPlaces
        {
            get { return _numberOfPlaces; }
            set
            {
                if (this._numberOfPlaces != value)
                    this._numberOfPlaces = value;
            }
        }

        public int NumberOfPlacesAvailable
        {
            get { return _numberOfPlacesAvailable; }
            set
            {
                if (this._numberOfPlacesAvailable != value)
                    this._numberOfPlacesAvailable = value;
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

        public List<User> Users
        {
            get { return _users; }
            set
            {
                if (this._users != value)
                    this._users = value;
            }
        }

    }
}
