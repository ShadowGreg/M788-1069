using System.Collections.Generic;

namespace M788_1069.Model;

public class Subtype : ObservableObject
{
    private string subtypeName;
    private List<Type> types;

    private Subtype(DataField dataField)
    {
        subtypeName = dataField.SubtypeName;
    }

    public string SubtypeName
    {
        get => subtypeName;
        set
        {
            subtypeName = value;
            OnPropertyChanged("SubtypeName");
        }
    }

    public List<Type> Types
    {
        get => types;
        set
        {
            types = value;
            OnPropertyChanged("Types");
        }
    }

    public Subtype ConvertToSubtype(DataField dataField)
    {
        return new Subtype(dataField);
    }

}