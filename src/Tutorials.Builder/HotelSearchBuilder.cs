using System;
using CuttingEdge.Conditions;

namespace Tutorials.Builder
{
    public class HotelSearchBuilder
    {
        private string hotelName;
        private string country;
        private string destination;
        private DateTime checkInDate;
        private DateTime checkOutDate;

        public static HotelSearchBuilder Hotel { get{return new HotelSearchBuilder();} }

        public HotelSearchBuilder HotelName(string value)
        {
            this.hotelName = value;
            return this;
        }

        public HotelSearchBuilder Country(string value)
        {
            this.country = value;
            return this;
        }
        public HotelSearchBuilder Destination(string value)
        {
            this.destination = value;
            return this;
        }

        public HotelSearchBuilder Dates(DateTime checkin, DateTime checkout)
        {
            this.checkInDate = checkin;
            this.checkOutDate = checkout;
            return this;
        }
        public HotelCriteria Bulild()
        {
            Validation();
            return new HotelCriteria
            {
                Country = country,
                CheckIn = checkInDate,
                CheckOut = checkOutDate,
                HotelName = hotelName
            };
        }

        private void Validation()
        {
            Condition.Requires(destination).IsNotNullOrEmpty("Destination name is not null or empty!");
            Condition.Requires(checkOutDate)
                .IsGreaterThan(checkInDate, "Return date must be greater than departure date!");
        }
    }
}