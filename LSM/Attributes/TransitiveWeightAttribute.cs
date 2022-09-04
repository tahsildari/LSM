namespace LSM.Attributes
{
    public class TransitiveWeightAttribute : Attribute, IWeighable
    {
        public int Weight { get; set; }

        public TransitiveWeightAttribute(int weight)
        {
            Weight = weight;
        }
    }
}
