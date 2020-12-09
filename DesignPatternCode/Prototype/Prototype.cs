using System;
using System.Collections.Generic;

namespace DoFactory.GangOfFour.Prototype.RealWorld
{
    //The intent behind the usage of a Prototype pattern is for creation of an object clone; 
    //in other words it allows us to create a new instance by copying existing instances.
    public class Developer : ICloneable
    {
        public string FirstName { get; set; }
        public string Lastname { get; set; }
        public List<string> Skills { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}