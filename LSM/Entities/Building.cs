using LSM.Attributes;

namespace LSM.Entities
{
    public class Building
    {
        public int Id { get; set; }

        [Weight(7)]
        [TransitiveWeight(5)]
        public string Shortcut { get; set; }

        [Weight(9)]
        [TransitiveWeight(8)]
        public string Name { get; set; }

        [Weight(5)]
        [TransitiveWeight(0)]
        public string Description { get; set; }
    }
}
