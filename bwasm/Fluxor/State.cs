using common.ViewModel;
using Fluxor;

namespace bwasm.Fluxor;

[FeatureState]
public record class CounterState
{
    public ResultResponseViewModel? response { get; set; }
    public CounterState()
    {
        response = new ResultResponseViewModel();
    }

}
