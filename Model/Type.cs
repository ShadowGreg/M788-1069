using System.Collections.Generic;

namespace M788_1069.Model;

public class Type: ObservableObject
{
    private string type;
    private List<Coefficient> coefficients;

    public Type()
    {
        
    }
    public Type(DataField dataField)
    {
        type= dataField.Type;
    }

    public string TypeName
    {
        get => type;
        set
        {
            type = value;
            OnPropertyChanged("TypeName");
        }
    }
    public List<Coefficient> Coefficients
    {
        get => coefficients;
        set
        {
            coefficients = value;
            OnPropertyChanged("Coefficients");
        }
    }
    // jast set the stribg text in value
    public Type ConvertToType(DataField dataField)
    {
        return new Type(dataField);
    }
}