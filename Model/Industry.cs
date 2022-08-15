using System.Collections.Generic;

namespace M788_1069.Model;

public class Industry : ObservableObject
{
    private string industryName;
    private List<Factory> factoryes;
    private Industry(DataField dataField)
    {
        industryName = dataField.IndustryName;
    }
    public string IndustryName
    {
        get => industryName;
        set
        {
            industryName = value;
            OnPropertyChanged("IndustryName");
        }
    }

    public List<Factory> Factoryes
    {
        get => factoryes;
        set
        {
            factoryes = value;
            OnPropertyChanged("Factoryes");
        }
    }

    public Industry ConvertToFactory(DataField dataField)
    {
        return new Industry(dataField);
    }
}