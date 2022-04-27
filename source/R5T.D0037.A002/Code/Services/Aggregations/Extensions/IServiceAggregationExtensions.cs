using System;

using R5T.D0037.A002;


namespace System
{
    public static class IServiceAggregationExtensions
    {
        public static T FillFrom<T>(this T aggregation,
            IServiceAggregation other)
            where T : IServiceAggregation
        {
            (aggregation as R5T.D0038.A002.IServiceAggregation).FillFrom(other);

            (aggregation as R5T.D0037.D0038.IServiceAggregationIncrement).FillFrom(other);

            return aggregation;
        }
    }
}
