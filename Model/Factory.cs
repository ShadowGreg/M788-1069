using System.Collections.Generic;
using System.Windows.Documents;

namespace M788_1069.Model;

public class Factory : ObservableObject
{
    private string factoryName;
    private List<Section> sections;
    private Factory(DataField dataField)
    {
        factoryName = dataField.FactoryName;
    }
    public string FactoryName
    {
        get => factoryName;
        set
        {
            factoryName = value;
            OnPropertyChanged("FactoryName");
        }
    }

    public List<Section> Sections
    {
        get => sections;
        set
        {
            sections = value;
            OnPropertyChanged("Sections");
        }
    }

    public Factory ConvertToFactory(DataField dataField)
    {
        return new Factory(dataField);
    }
}