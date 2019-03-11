using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace _DataLayer.Models
{
    [DataContract]
    public class Garson
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Ad { get; set; }
        [DataMember]
        public string Soyad { get; set; }
    }
}
