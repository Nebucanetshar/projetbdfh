using common.ViewModel;
using common.Wrapper.Response;

namespace common.Wrapper.Interface;

public interface IgRpcCounterServiceClient
{
    Task<ResponseWrapperViewModel<CounterViewModel>> DoCreate(string arg);
}
