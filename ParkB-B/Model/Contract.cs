using System;

namespace ParkB_B.Model
{
    public class Contract
    {
        private DateTime _arrivedReservedDate;
        private DateTime _departureReservedDate;
        private DateTime _arriveRealDate;
        private DateTime _departureRealDate;
        private double _price;

        public Contract(DateTime arrivedReservedDate, DateTime departureReservedDate, DateTime arriveRealDate, DateTime departureRealDate, double price)
        {
            this.ArrivedReservedDate = arrivedReservedDate;
            this.DepartureReservedDate = departureReservedDate;
            this.ArriveRealDate = arriveRealDate;
            this.DepartureRealDate = departureRealDate;
            this.Price = price;
        }

        public Contract()
        {
        }

        public Contract(DateTime arrivedReservedDate, DateTime departureReservedDate, double price)
        {
            this.ArrivedReservedDate = arrivedReservedDate;
            this.DepartureReservedDate = departureReservedDate;
            this.Price = price;
        }

        public DateTime ArrivedReservedDate
        {
            get { return _arrivedReservedDate; }
            set
            {
                if (this._arrivedReservedDate != value)
                    this._arrivedReservedDate = value;
            }
        }

        public DateTime DepartureReservedDate
        {
            get { return _departureReservedDate; }
            set
            {
                if (this._departureReservedDate != value)
                    this._departureReservedDate = value;
            }
        }

        public DateTime ArriveRealDate
        {
            get { return _arriveRealDate; }
            set
            {
                if (this._arriveRealDate != value)
                    this._arriveRealDate = value;
            }
        }

        public DateTime DepartureRealDate
        {
            get { return _departureRealDate; }
            set
            {
                if (this._departureRealDate != value)
                    this._departureRealDate = value;
            }
        }

        public double Price
        {
            get { return _price; }
            set
            {
                if (this._price != value)
                    this._price = value;
            }
        }
    }
}
