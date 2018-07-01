using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class FizzBuzzTests
    {

        public void GetOutput_First()
        {
            //Act
            var result = FizzBuzz.GetOutput(15);
        
            //Assert
            Assert.That(result, Is.EqualTo("FizzBuzz"));
        }

        public void GetOutput_Second()
        {
            //Act
            var result = FizzBuzz.GetOutput(3);

            //Assert
            Assert.That(result, Is.EqualTo("Fizz"));
        }

        public void GetOutput_Third()
        {
            //Act
            var result = FizzBuzz.GetOutput(5);

            //Assert
            Assert.That(result, Is.EqualTo("Buzz"));
        }

        public void GetOutput_Last()
        {
            //Act
            var result = FizzBuzz.GetOutput(1);

            //Assert
            Assert.That(result, Is.EqualTo("1"));
        }
    }
}
