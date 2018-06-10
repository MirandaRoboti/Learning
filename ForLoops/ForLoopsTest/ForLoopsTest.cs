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
        public class UserInput
        {
            [Fact]
                public void ShoudlReturnTheLargestNumber_FromTheGivenArray()
            {
                List<string> numbersInput = new List<string>
                {
                    "1,2,3,4,5,6,7,8,9,10"
                };


                Assert.NotNull(numbersInput);


            }
        }

      
    }
