using common.Wrapper.Model;
using Fluxor;


namespace bwasm.Fluxor;

public class CounterEffet
{
    private IgRpcCounterServiceClient gRpcCounterServiceClient;

    public CounterEffet(IgRpcCounterServiceClient server)
    {
        gRpcCounterServiceClient = server;
    }
    [EffectMethod]
    public async Task ExecuteEffet(ActionInput action, IDispatcher dispatcher)
    {
        var responseWrapper = await gRpcCounterServiceClient.DoCreate(action.Counter);

        dispatcher.Dispatch(new ActionOutput(responseWrapper.Content));
    }

}
