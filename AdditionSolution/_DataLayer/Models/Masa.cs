using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace _DataLayer.Models
{
    [DataContract]
    public class Masa
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string MasaAdi { get; set; }
    }
}
