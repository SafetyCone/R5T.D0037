using System;


namespace R5T.D0037.A001
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
