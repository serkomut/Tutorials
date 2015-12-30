using System;
using FluentAssertions;
using NUnit.Framework;

namespace Tutorials.Builder
{
    [TestFixture]
    public class HotelSearchBuilderTestFixture
    {
        [Test]
        public void Hotel_Search_Criteria()
        {
            var criteria =
                HotelSearchBuilder.Hotel.HotelName("Rixos")
                    .Country("TR")
                    .Destination("TR")
                    .Dates(new DateTime(2016, 01, 01), new DateTime(2016, 01, 05))
                    .Bulild();
            criteria.HotelName.Should().Be("Rixos");
            criteria.CheckIn.Should().Be(new DateTime(2016, 01, 01));
            criteria.CheckOut.Should().Be(new DateTime(2016, 01, 05));
        }
    }
}
