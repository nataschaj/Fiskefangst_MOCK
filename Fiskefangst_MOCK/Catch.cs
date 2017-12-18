using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Fiskefangst_MOCK
{
    [DataContract]
    public class Catch
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Species { get; set; }

        [DataMember]
        public double Weight { get; set; }

        [DataMember]
        public string Place { get; set; }

        [DataMember]
        public int Week { get; set; }

        public Catch()
        {

        }
        
        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Species: {Species}, Weight: {Weight}, Place: {Place}, Week: {Week}";
        }
    }
}