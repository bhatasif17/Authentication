using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    [DataContract]
   public class Student
    {
        [DataMember]
        public int ID { get; set; }

        [DataMember]
        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [DataMember]
        [Required]
        [StringLength(100)]
        public string Address { get; set; }

        [DataMember]
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [DataMember]
        public string AddedBy { get; set; }
    }
}
