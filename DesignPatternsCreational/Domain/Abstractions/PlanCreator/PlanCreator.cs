using DesignPatternsCreational.Domain.Abstractions;
using DesignPatternsCreational.Domain.Enum.Plan;

namespace DesignPatternsCreational.Domain.Entities.PlanCreator
{
    public abstract class PlanCreator
    {
        public abstract GenericPlan CreatePlan(EnumTypePlan typePlan ,double valuePlan, string namePlan);
    }
}
