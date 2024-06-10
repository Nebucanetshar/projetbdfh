using bwasm.Fluxor;
using Fluxor;
using Microsoft.AspNetCore.Components;

namespace bwasm.Pages;

public partial class Counter
{
    public int currentCount = 0;
    public void IncrementCount()
    {
        currentCount++;
    }
}
    //    [Inject] private IState<CounterState>?CounterState { get; set; }
    //    private async Task btnExcute_Click(IDispatcher dispatcher)
    //    {
    //        try
    //        {
    //            var requestResult = string.Empty;

    //            if (!string.IsNullOrEmpty(requestResult))
                
    //                dispatcher.Dispatch(new ActionInput(requestResult));

    //            requestResult = CounterState.Value.response.Data;
                

    //            catch(Exception arg)
    //            {
    //                await ManageExceptionAsync(arg);
    //            }
    //        }
    //    }
    //}


    


