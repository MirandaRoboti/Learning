using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoops
{
    public static class StringManipulation
    {
        public static string ToCsv(this List<Thing> thingList) =>
            string.Join(",", thingList.Select(x => x.ToString()));

        public static List<Thing> OrderByValueAsc(this List<Thing> thingList)
        {
            return thingList.OrderBy(thing => thing.Value).ToList();
        }

        public static List<Thing> Flattern(this Thing thing)
        {
            return Flattern(thing, new List<Thing>());
        }

        private static List<Thing> Flattern(Thing thing, List<Thing> things)
        {
            things.Add(thing);

            if (thing.ChildThing == null)
            {
                return things;
            }

            return Flattern(thing.ChildThing, things);
        }


        public static List<Thing> FlatternForChildThings(this List<Thing> things)
        {
            return FlatternForChildThings(things, new List<Thing>());
        }

        private static List<Thing> FlatternForChildThings(List<Thing> things, List<Thing> flattenThings)
        {
            foreach (var thing in things)
            {
                //return FlatternForChildThings(thing.Flattern(), flattenThings);
                if (thing.ChildThings != null)
                {
                    return FlatternForChildThings(thing.ChildThings, flattenThings);
                }
            }

            return FlatternForChildThings(flattenThings);
           
        }



        //public static List<Thing> GetTestThing
        //{
        //    get
        //    {
        //        return new List<Thing>
        //        {
        //            new Thing("Egg", 4),
        //            new Thing("Cheese", 1)
        //            {
        //               ChildThings = new List<Thing>
        //                    {
        //                       new Thing("Beans", 200),
        //                       new Thing("Toast", 100),
        //                       new Thing("Sofa", 999)
        //                    }
        //            },
        //            new Thing("Doobell", 87)
        //            {
        //                ChildThings = new List<Thing>
        //                {
        //                    new Thing("Miranda", 55),
        //                    new Thing("Chair", 12)
        //                {
        //                    ChildThings =new List<Thing>
        //                    {
        //                        new Thing("Henry", 6)
        //                    }
        //                }
        //           }
        //        }
        //    };
        //    }
        //}
    }
}


