using System;


namespace R5T.D0037.A001
{
    public static class IServiceAggregationExtensions
    {
        public static T FillFrom<T>(this T aggregation,
            IServiceAggregation other)
            where T : IServiceAggregation
        {
            (aggregation as R5T.D0038.A001.IServiceAggregation).FillFrom(other);

            aggregation.GitOperatorAction = other.GitOperatorAction;

            return aggregation;
        }
    }
}
