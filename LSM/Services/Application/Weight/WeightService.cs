using AutoMapper;
using LSM.Attributes;
using LSM.Dto;
using LSM.Extensions;

namespace LSM.Services.Weight
{
    public class WeightService : IWeightService
    {
        private IMapper mapper;

        public WeightService(IMapper mapper)
        {
            this.mapper=mapper;
        }
        public List<TResult> Calculate<TEntity, TRelation, TResult>
            (List<TEntity> entities, string relation, string text) where TResult : IWeighted
        {
            var result = new List<TResult>();
            foreach (TEntity @entity in entities)
            {
                var ownWeight = 0;
                ownWeight = CalculateWeight<TEntity, WeightAttribute>(@entity);

                var transitiveWeight = 0;
                var relationObject = (TRelation)typeof(TEntity).GetProperty(relation).GetValue(@entity, null);
                transitiveWeight = CalculateWeight<TRelation, TransitiveWeightAttribute>(relationObject);

                var dto = mapper.Map<TResult>(@entity);

                dto.SearchWeight = ownWeight + transitiveWeight;
                result.Add(dto);
            }
            return result;

            int CalculateWeight<T, TAttirubte>(T item) where TAttirubte : Attribute
            {
                var weight = 0;
                foreach (var prop in typeof(T).GetProperties())
                {
                    var attrs = (TAttirubte[])prop.GetCustomAttributes
                        (typeof(TAttirubte), false);
                    foreach (var attr in attrs)
                    {
                        if (attr != null)
                        {
                            var propertyValue = typeof(T).GetProperty(prop.Name).GetValue(item, null);
                            string value = String.Empty;

                            if (propertyValue == null)
                                continue;

                            value = propertyValue.ToString();
                            if (value.Equals(text))
                                weight += (((IWeighable)attr).Weight * 10); //todo: no magic string
                            else if (value.ContainsIgnoreCase(text))
                                weight += ((IWeighable)attr).Weight;
                        }
                    }
                }
                return weight;
            }
        }
    }
}
