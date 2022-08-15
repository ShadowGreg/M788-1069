using System.Collections.Generic;
using System.Windows.Documents;

namespace M788_1069.Model;

public class Section : ObservableObject
{
    private string sectionName;
    private List<Subtype> subtypes;

    private Section(DataField dataField)
    {
        sectionName = dataField.SectionName;
    }
    public string SectionName
    {
        get => sectionName;
        set
        {
            sectionName = value;
            OnPropertyChanged("SectionName");
        }
    }

    public List<Subtype> Subtypes
    {
        get => subtypes;
        set
        {
            subtypes = value;
            OnPropertyChanged("Subtypes");
        }
    }

    public Section ConvertToSection(DataField dataField)
    {
        return new Section(dataField);
    }
}