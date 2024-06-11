using System.Text.Json;

namespace common.ViewModel;

public class ViewModelBase
{
    #region Attributes & Accessors
    #endregion

    #region Constructors
    #endregion

    #region Methods
    public string ToStringJson()
    {
        return JsonSerializer.Serialize(this);
    }
    #endregion
}