using DesignPatternsCreational.Domain.Abstractions;
using DesignPatternsCreational.Domain.Entities.Plans;
using DesignPatternsCreational.Domain.Enum.Plan;
using System;

namespace DesignPatternsCreational.Creational.Factory.SimpleFactory
{
    public class SimpleFactory
    {
        public GenericPlan SimpleFactoryPlan(EnumTypePlan typePlan, double valuePlan, string namePlan)
        {
            switch (typePlan)
            {
                case EnumTypePlan.PlanOne:
                    return new PlanOne(valuePlan, namePlan, typePlan);
                case EnumTypePlan.PlanTwo:
                    return new PlanTwo(valuePlan, namePlan, typePlan);
                default: throw new Exception("not implement plan type");
            }
        }
    }
}
