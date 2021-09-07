using System;

using R5T.Dacia;


namespace R5T.D0037.D0038
{
    public interface IServiceAggregationIncrement
    {
        IServiceAction<IGitOperator> GitOperatorAction { get; set; }
    }
}
