using common.ViewModel;

namespace assembly.Fluxor;

public class ActionOutput
{
    public ResultResponseViewModel? ResponseServer;
    public CounterViewModel? Content { get; }

    public ActionOutput(ResultResponseViewModel responseServer)
    {
        ResponseServer = responseServer;
    }
    public ActionOutput(CounterViewModel content)
    {
        Content = content;
    }
}

public class ActionInput
{
    public int Counter { get; set; }

    public ActionInput(int counter)
    {
        Counter = counter;
    }
}


