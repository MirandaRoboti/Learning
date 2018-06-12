using ForLoops.Model;
using System;
using System.Collections.Generic;
using Xunit;

    namespace ForLoopsTest
    {
    /*
     * need to test that there is an array of number
     * That this array is not null
     * That it will return the biggest number
    */
    public class TestUserInput
    {
        [Fact]
        public void Should_Return_Largest()
        {
            var numbers = new List<int>() { 1, 3, 2,5,10 };

            UserInput userInput = new UserInput();
            var returnMax = userInput.MaxNumber(numbers);
            Assert.Equal(10, returnMax);
        }
    }

      
    }
