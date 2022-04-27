using System;

using R5T.D0037.A002;


namespace System
{
    public static class IServiceActionAggregationIncrementExtensions
    {
        public static T FillFrom<T>(this T aggregation,
            IServiceActionAggregationIncrement other)
            where T : IServiceActionAggregationIncrement
        {
            aggregation.GitOperatorAction = other.GitOperatorAction;

            return aggregation;
        }
    }
}
