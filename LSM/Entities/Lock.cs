using LSM.Attributes;
using LSM.Entities.Enums;

namespace LSM.Entities
{
    public class Lock
    {
        public string Id { get; set; }
        public string BuildingId { get; set; }

        [Weight(3)]
        public LockType Type { get; set; }

        [Weight(10)]
        public string Name { get; set; }

        [Weight(8)]
        public string SerialNumber { get; set; }

        [Weight(6)]
        public string Floor { get; set; }

        [Weight(6)]
        public string RoomNumber { get; set; }

        [Weight(6)]
        public string Description { get; set; }

        public Building Building { get; set; }

    }
}
