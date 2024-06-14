
using assembly.Fluxor;
using Fluxor;
using Microsoft.AspNetCore.Components;

namespace assembly.Pages
{
    public partial class Counter
    {
        public int currentCount = 0;
        [Inject] private IState<CounterState>? CounterState { get; set; } = default!;
        public void IncrementCount()
        {
            currentCount++;
        }
        private async Task Btn_Execute(IDispatcher dispatcher)
        {
            
            if (currentCount>0)
            {
                dispatcher.Dispatch(new ActionInput(currentCount.CompareTo(1)));
               //await
            }
        }

    }
}

