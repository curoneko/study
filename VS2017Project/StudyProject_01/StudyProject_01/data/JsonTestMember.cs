using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace StudyProject_01.data
{
    [DataContract]
    public class JsonTestData
    {
        [DataMember(Name = "id")]
        public long id { get; set; }

        [DataMember(Name = "name")]
        public string name { get; set; }

        [DataMember(Name = "age")]
        public short age { get; set; }

        [DataMember(Name = "height")]
        public double height { get; set; }

        [DataMember(Name = "whight")]
        public double whight { get; set; }
    }
}
