using LSM.Dto;
using LSM.Entities.Enums;
using System.Text.Json.Serialization;

namespace LSM.Dto
{
    public class LockDto : IWeighted
    {

        [JsonIgnore]
        public string BuildingId { get; set; }
        public LockType Type { get; set; }
        public string Name { get; set; }
        public string SerialNumber { get; set; }
        public string Floor { get; set; }
        public string RoomNumber { get; set; }
        public string Description { get; set; }

        public int SearchWeight { get; set; }

        public BuildingDto Building { get; set; }

    }
}
