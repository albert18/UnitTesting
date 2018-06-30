using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class MathTests
    {


        private MathSample _math;
        //Setup
        //TearDown
        [SetUp]
        public void Setup()
        {
            _math = new MathSample();
        }

        [Test]
        //[Ignore("Because the Tutorial want me to")]
        public void Add_WhenCalled_ReturnTheSumOfArguments()
        {
            //Arrage
            //var math = new MathSample();

            //Act
            var result = _math.Add(1, 2);

            //Assert
            Assert.That(result, Is.EqualTo(3));


            //////////////////////////////////////////////// TRUST WORTHY TEST
            //Assert.That(_math, Is.Not.Null);
            //////////////////////////////////////////////// TRUST WORTHY TEST
        }

        [Test]
        [TestCase(2, 1, 2)]
        [TestCase(1, 2, 2)]
        [TestCase(1, 1, 1)]
        public void Max_WhenCalled_ReturnTheFirstArguments(int a, int b, int expectedNumber)
        {
            //Arrage
            //var math = new MathSample();

            //Act
            var result = _math.Max(a, b);

            //Assert
            Assert.That(result, Is.EqualTo(expectedNumber));
        }

        //[Test]
        //public void Max_WhenCalled_ReturnTheSecondArguments()
        //{
        //    //Arrage
        //    //var math = new MathSample();

        //    //Act
        //    var result = _math.Max(1, 2);

        //    //Assert
        //    Assert.That(result, Is.EqualTo(2));
        //}

        //[Test]
        //public void Max_ArgumentsAreEqual_ReturnTheSameArguments()
        //{
        //    //Arrage
        //    //var math = new MathSample();

        //    //Act
        //    var result = _math.Max(5, 5);

        //    //Assert
        //    Assert.That(result, Is.EqualTo(5));
        //}


        [Test]
        public void GetOddNumbers_LimitIsGreaterThanZero_ReturnOddNumberUpToLimit()
        {
            var result = _math.GetOddNumbers(5);

            //Assert.That(result, Is.Not.Empty);

            //Assert.That(result.Count(), Is.EqualTo(3));
            //Assert.That(result, Does.Contain(1));
            //Assert.That(result, Does.Contain(3));
            //Assert.That(result, Does.Contain(5));

            Assert.That(result, Is.EquivalentTo(new[] { 1, 3, 5 }));

            //Assert.That(result, Is.Ordered);
            //Assert.That(result, Is.Unique);

        }



    }
}
