using System.Collections.Generic;

namespace M788_1069.Model;

public class Division: ObservableObject
{
    private string divisionName;
    private List<Industry> divisions;
    private Division(DataField dataField)
    {
        divisionName = dataField.DivisionName;
    }
    public string DivisionName
    {
        get => divisionName;
        set
        {
            divisionName = value;
            OnPropertyChanged("DivisionName");
        }
    }

    public List<Industry> Industryes
    {
        get => divisions;
        set
        {
            divisions = value;
            OnPropertyChanged("Industryes");
        }
    }

    public Division ConvertToDivision(DataField dataField)
    {
        return new Division(dataField);
    }
}