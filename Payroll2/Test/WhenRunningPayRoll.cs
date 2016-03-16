using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Payroll2;


namespace Test
{
    [TestFixture]
    public class WhenRunningPayRoll
    {

        [Test]
        public void When_wage_MoreThanZero_isTrue()
        {
            // prepare
            var expected = true;

            // action
            var actual = Program.UserEnteredWage_morethanzero(60);

            // assert
            Assert.That(expected, Is.EqualTo(actual));
        }
        [Test]
        public void UserEnteredHours_MoreThan168_isFalse()
        {
            // prepare
            var expected = false;

            // action
            var actual = Program.UserEnteredHours(170);

            // assert
            Assert.That(expected, Is.EqualTo(actual));
        }
        [Test]
        public void UserEnteredCommssionrates_Between0and1_istrue()
        {
            // prepare
            var expected = true;

            // action
            var actual = Program.UserEnteredHours(0.5);

            // assert
            Assert.That(expected, Is.EqualTo(actual));
        }
        [Test]
        public void When_wage_lessthanzero_isFalse()
        {
            // prepare
            var expected = false;

            // action
            var actual = Program.UserEnteredWage_morethanzero(-10);

            // assert
            Assert.That(expected, Is.EqualTo(actual));
        }
        [Test]
        public void When_EnternullSSN()

        {
            // prepare
            var expected = false;

            // action
            var actual = Program.EnterSSN(null);

            // assert
            Assert.That(expected, Is.EqualTo(actual));
        }
        [Test]
        public void When_enterspaceSSN()

        {
            // prepare
            var expected = false;

            // action
            var actual = Program.EnterSSN(" ");

            // assert
            Assert.That(expected, Is.EqualTo(actual));
        }

    }
}
