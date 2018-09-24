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

           if (thing.ChildThings?.FirstOrDefault() == null)
           {
               return things;
           }

           return Flattern(thing.ChildThings?.FirstOrDefault(), things);
            
        }

        public static List<Thing> Flattern(this List<Thing> thingList)
        {
            foreach (var child in thingList)
            {
                if (child.ChildThings?.Count() > 0)
                {
                    foreach (var childOfChild in child.ChildThings)
                    {
                        Flattern(childOfChild, thingList);
                    }
                }
                return thingList;
            }
            return Flattern(thingList);

        }
    }
}


