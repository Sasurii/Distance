using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Distance;
using FluentAssertions;
using Xunit;

namespace Distance.Tests
{
    public class DistanceTest
    {
        [Fact]
        ///<summary>
        ///
        /// </summary>

        void Distance_Test()
        {
            //Arrange
            int zahl1 = 10;
            int zahl2 = 5;

            //Act
            int ergebnis = Distance.distance(zahl1, zahl2);
            
            //assert
            ergebnis.Should().Be(5);
            Assert.Equal(5, ergebnis);
        }
    }
}
