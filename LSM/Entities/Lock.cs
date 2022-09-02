using LSM.Entities.Enums;

namespace LSM.Entities
{
    public class Lock
    {
        public int Id { get; set; }
        public int BuildingId { get; set; }
        public LockType Type { get; set; }
        public string Name { get; set; }
        public string SerialNumber { get; set; }
        public string Floor { get; set; }
        public string RoomNumber { get; set; }
        public string Description { get; set; }

    }
}
