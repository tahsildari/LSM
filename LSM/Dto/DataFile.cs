using LSM.Entities;

namespace LSM.Dto
{
    public class DataFile
    {
        public Building[] Buildings { get; set; }
        public Lock[] Locks { get; set; }
        public Group[] Groups { get; set; }
        public Medium[] Media { get; set; }
    }
}
