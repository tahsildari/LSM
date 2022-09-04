using LSM.Entities.Enums;

namespace LSM.Entities
{
    public class Medium
    {
        public int Id { get; set; }
        public int GroupId { get; set; }
        public MediumType Type { get; set; }
        public string Owner { get; set; }
        public string SerialNumber { get; set; }
        public string Description { get; set; }

    }
}
