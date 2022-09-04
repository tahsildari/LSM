namespace LSM.Attributes
{
    public class WeightAttribute : Attribute, IWeighable
    {
        public int Weight { get; set; }

        public WeightAttribute(int weight)
        {
            Weight = weight;
        }
    }
}
