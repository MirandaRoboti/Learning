using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Rock_Paper_Scissors.Test
{
    [TestClass]
    public class ComputerPlayerTest
    {
        [TestMethod]
        public void Should_return_random_option_choice()
        {
            for (int i = 0; i < 10; i++)
            {
                var value = RandomEnumValue<System.Enum>();
                Console.WriteLine(value.ToString());
            }

        }
    }
}
