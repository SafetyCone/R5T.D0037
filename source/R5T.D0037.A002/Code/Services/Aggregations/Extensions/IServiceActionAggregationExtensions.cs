using System;

using R5T.D0037.A002;


namespace System
{
    public static class IServiceActionAggregationExtensions
    {
        public static T FillFrom<T>(this T aggregation,
            IServiceActionAggregation other)
            where T : IServiceActionAggregation
        {
            (aggregation as R5T.D0038.A002.IServiceActionAggregation).FillFrom(other);

            (aggregation as IServiceActionAggregationIncrement).FillFrom(other);

            return aggregation;
        }
    }
}
