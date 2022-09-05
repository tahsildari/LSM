namespace LSM.Dto
{
    public class GroupDto : IWeighted
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public int SearchWeight { get; set; }
    }
}
