using DesignPatternsCreational.Domain.Enum.Plan;

namespace DesignPatternsCreational.Domain.Abstractions
{
    public abstract class GenericPlan
    {
        public double ValuePlan { get; set; }

        public string NamePlan { get; set; }

        public EnumTypePlan TypePlan { get; set; }
    }
}
