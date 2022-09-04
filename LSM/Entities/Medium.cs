using LSM.Attributes;
using LSM.Entities.Enums;

namespace LSM.Entities
{
    public class Medium
    {
        public int Id { get; set; }
        public int GroupId { get; set; }

        [Weight(3)]
        public MediumType Type { get; set; }

        [Weight(10)]
        public string Owner { get; set; }

        [Weight(8)]
        public string SerialNumber { get; set; }

        [Weight(6)]
        public string Description { get; set; }

    }
}
