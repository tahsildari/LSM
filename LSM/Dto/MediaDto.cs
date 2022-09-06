using LSM.Entities.Enums;

namespace LSM.Dto
{
    public class MediaDto : IWeighted
    {
        public MediumType Type { get; set; }

        public string Owner { get; set; }

        public string SerialNumber { get; set; }

        public string Description { get; set; }

        public MediaGroupDto Group { get; set; }

        public int SearchWeight { get; set; }
    }
}
