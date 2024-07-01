using common.ViewModel;
using Fluxor;

namespace assembly.Fluxor;

[FeatureState]
public record class CounterState
{
    public ResultResponseViewModel? response { get; set; }
    public string data { get; private set; }

    public CounterState()
    {
        response = new ResultResponseViewModel(data);
    }

}

