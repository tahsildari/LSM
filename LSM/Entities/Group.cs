using LSM.Attributes;

namespace LSM.Entities
{
    public class Group
    {
        public string Id { get; set; }

        [Weight(9)]
        [TransitiveWeight(8)]
        public string Name { get; set; }

        [Weight(5)]

        [TransitiveWeight(0)]
        public string Description { get; set; }
    }
}
