using System.Collections.Generic;

namespace ForLoops
{

    public class Thing
    {
        public Thing(string name, int value)
        {
            Name = name;
            Value = value;
        }

        public string Name { get; }

        public int Value { get; }

        //public Thing ChildThing { get; set; }

        public List<Thing> ChildThings { get; set; }

        public override string ToString() => $"{Name}[{Value}]";

    }
}







