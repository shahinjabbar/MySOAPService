using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace MySOAPService.Models
{
    [DataContract]
    public class MyCustomModel
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string UserName { get; set; }

        [DataMember]
        public string EmailAdress { get; set; }
    }
}
