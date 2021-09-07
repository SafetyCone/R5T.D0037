using System;

using R5T.D0037.D0038;


namespace System
{
    public static class IServiceAggregationIncrementExtensions
    {
        public static T FillFrom<T>(this T aggregation,
            IServiceAggregationIncrement other)
            where T : IServiceAggregationIncrement
        {
            aggregation.GitOperatorAction = other.GitOperatorAction;

            return aggregation;
        }
    }
}
