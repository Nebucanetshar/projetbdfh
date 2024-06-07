using bwasm.Fluxor;
using Fluxor;

namespace bwasm.Fluxor;

public static class CounterReduceur
{
    [ReducerMethod]
    public static CounterState ExecuteState(CounterState state, ActionOutput action)
    {
        return state with
        {
            response = action.ResponseServer
        };
    }
}
