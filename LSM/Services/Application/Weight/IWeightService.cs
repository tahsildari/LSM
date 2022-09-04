using LSM.Dto;

namespace LSM.Services.Weight
{
    public interface IWeightService
    {
        List<TResult> Calculate<TEntity, TRelation, TResult>
            (List<TEntity> entities, string relation, string text) where TResult : IWeighted;
    }
}
