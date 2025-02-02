using DesignPatternsCreational.Domain.Abstractions;
using DesignPatternsCreational.Domain.Entities.Plans;
using DesignPatternsCreational.Domain.Enum.Plan;

namespace DesignPatternsCreational.Domain.Entities.PlanCreator
{
    public class PlanOneCreator : PlanCreator
    {
        public override GenericPlan CreatePlan(EnumTypePlan typePlan, double valuePlan, string namePlan)
        {
            return new PlanOne(valuePlan, namePlan, typePlan);
        }
    }
}
