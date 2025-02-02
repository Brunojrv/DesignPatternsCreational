using DesignPatternsCreational.Domain.Abstractions;
using DesignPatternsCreational.Domain.Entities.Plans;
using DesignPatternsCreational.Domain.Enum.Plan;

namespace DesignPatternsCreational.Domain.Entities.PlanCreator
{
    public class PlanTwoCreator : PlanCreator
    {
        public override GenericPlan CreatePlan(EnumTypePlan typePlan,double valuePlan, string namePlan)
        {
            return new PlanTwo(valuePlan, namePlan, typePlan);
        }
    }
}
