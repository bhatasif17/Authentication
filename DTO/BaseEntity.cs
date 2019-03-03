using System.Runtime.Serialization;

namespace DTO
{
    [DataContract]
    public abstract class BaseEntity
    {
        [DataMember]
        public int Id { get; set; }
    }
}
