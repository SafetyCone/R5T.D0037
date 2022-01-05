using System;

using R5T.T0063;


namespace R5T.D0037.A002
{
    public interface IServiceActionAggregationIncrement
    {
        IServiceAction<IGitOperator> GitOperatorAction { get; set; }
    }
}
