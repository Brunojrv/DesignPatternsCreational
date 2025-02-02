using DesignPatternsCreational.Domain.Abstractions;
using DesignPatternsCreational.Domain.Enum.Plan;

namespace DesignPatternsCreational.Domain.Entities.Plans
{
    public class PlanTwo : GenericPlan
    {
        public PlanTwo(double valuePlan, string namePlan, EnumTypePlan typePlan)
        {
            ValuePlan = valuePlan;
            NamePlan = namePlan;
            TypePlan = typePlan;
        }
    }
}
