using FluentAssertions;
using ForLoops;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace ForLoopsTest
{
    /*
     * need to test that there is an array of number
     * That this array is not null
     * That it will return the biggest number
    */

    //Flattern out all things into a single list
    //order by value asc
    //output the value in this format {Name[value],Name[value],etc}

    //Thing
    //ChildThing


    public class ThingTest
    {
        private IEnumerable<object> result;

        [Fact]
        public void ShouldSerializeAThing_WhenStringifyingAString()
        {
            var thing = new Thing("beans", 2);

            var result = thing.ToString();

            Assert.Equal(result, "beans[2]");
        }

        [Fact]
        public void ShouldSerializeAListOfThings_When()
        {
            var thingList = new List<Thing> {
                new Thing("beans",4),
                new Thing("eggs",1),
                new Thing("cheese",2)
            };

            var result = thingList.ToCsv();

            Assert.Equal(result, "beans[4],eggs[1],cheese[2]");
        }

        [Fact]
        public void ShouldOrderListOfThing()
        {
            var thingList = new List<Thing> {
                new Thing("beans",4),
                new Thing("eggs",1),
                new Thing("cheese",2)
            };

            //dosomething
            var result = thingList.OrderByValueAsc();

            result[0].Name.Should().Be("eggs");
            result[0].Value.Should().Be(1);

            result[1].Name.Should().Be("cheese");
            result[1].Value.Should().Be(2);

            result[2].Name.Should().Be("beans");
            result[2].Value.Should().Be(4);
        }

        [Fact]
        public void ShouldSerializeAListOfThingsInOrder_When()
        {
            var thingList = new List<Thing> {
                new Thing("beans",4),
                new Thing("eggs",1),
                new Thing("cheese",2)
            };

            var result = thingList.OrderByValueAsc().ToCsv();

            Assert.Equal(result, "eggs[1],cheese[2],beans[4]");
        }

        [Fact]
        public void ShouldSerializeChildThing()
        {
            var thingList = new Thing("beans", 4)
            {
                ChildThings = new List<Thing> { new Thing("eggs", 1) }
            };

            var stringArray = thingList.Flattern().Select(x => x.ToString());
            var result = string.Join(",", stringArray);

            Assert.Equal(result, "beans[4],eggs[1]");
        }

        [Fact]
        public void ShouldOnlySerliazePopulatedChild()
        {
            var thingList = new Thing("beans", 4);

            var stringArray = thingList.Flattern().Select(x => x.ToString());
            var result = string.Join(",", stringArray);

            Assert.Equal(result, "beans[4]");
        }

        [Fact]
        public void ShouldSerializeChildThingOfChildThing()
        {
            var thingList = new Thing("beans", 4)
            {
                ChildThings = new List<Thing>{ new Thing("eggs", 1)
                {
                    ChildThings = new List<Thing> { new Thing("Crap", 999999) }
                } }
            };

            var stringArray = thingList.Flattern().Select(x => x.ToString());
            var result = string.Join(",", stringArray);

            Assert.Equal(result, "beans[4],eggs[1],Crap[999999]");
        }

        [Fact]
        public void ShouldFlatternThing()
        {
            var thingList = new Thing("beans", 4)
            {
                ChildThings = new List<Thing>{new Thing("eggs", 1)
                {
                    ChildThings = new List<Thing> { new Thing("Crap", 999999) }
                } }
            };


            var result = StringManipulation.Flattern(thingList);

            result[0].Name.Should().Be("beans");
            result[0].Value.Should().Be(4);
            result[1].Name.Should().Be("eggs");
            result[1].Value.Should().Be(1);
            result[2].Name.Should().Be("Crap");
            result[2].Value.Should().Be(999999);
        }

        [Fact]
        public void ShouldOrderFlatternThing()
        {
            var thingList = new Thing("beans", 4)
            {
                ChildThings = new List<Thing>{new Thing("eggs", 1)
                {
                    ChildThings = new List<Thing>{new Thing("Crap", 999999) }
                } }
            };

            var flat = StringManipulation.Flattern(thingList);
            var result = flat.OrderByValueAsc();

            result[0].Name.Should().Be("eggs");
            result[0].Value.Should().Be(1);
            result[1].Name.Should().Be("beans");
            result[1].Value.Should().Be(4);
            result[2].Name.Should().Be("Crap");
            result[2].Value.Should().Be(999999);
        }

        [Fact]
        public void ShouldOrderFlatternThings()
        {
            var thingList = new List<Thing>{ new Thing("beans", 4)
            {
                ChildThings = new List<Thing>{ new Thing("eggs", 1)
                {
                    ChildThings = new List<Thing>{new Thing("Crap", 999999) }
                } }
            } };


            var flat = StringManipulation.Flattern(thingList);
            var result = flat.OrderByValueAsc();

            result[0].Name.Should().Be("eggs");
            result[0].Value.Should().Be(1);
            result[1].Name.Should().Be("beans");
            result[1].Value.Should().Be(4);
            result[2].Name.Should().Be("Crap");
            result[2].Value.Should().Be(999999);
        }

        [Fact]
        public void ShouldOrderAndFlatternChildren()
        {
            var thingList = new List<Thing>
                {
                    new Thing("Egg", 4),
                    new Thing("Cheese", 1)
                    {
                       ChildThings = new List<Thing>
                           {
                               new Thing("Beans", 200),
                               new Thing("Toast", 100),
                               new Thing("Sofa", 999)
                            }
                    },
                    new Thing("Doobell", 87)
                    {
                        ChildThings = new List<Thing>
                        {
                            new Thing("Miranda", 55),
                            new Thing("Chair", 12)
                        {
                           ChildThings =new List<Thing>
                            {
                                new Thing("Henry", 6)
                            }
                        }
                   }
                }
            };

            var stringArray = thingList.Flattern().Select(x => x.ToString());
            var result = string.Join(",", stringArray);

            Assert.Equal(result, "Cheese[1],Eggs[4],Henry[6],Chair[12],Miranda[55],Doobell[87],Toast[100],Beans[200],Sofa[999]");
        }
    }
}