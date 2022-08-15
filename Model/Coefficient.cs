namespace M788_1069.Model;

public class Coefficient: ObservableObject
{
    private string firstCoefficient;
    private string secondCoefficient;

    public string FirstCoefficient
    {
        get { return firstCoefficient; }
        set
        {
            firstCoefficient = value;
            OnPropertyChanged(nameof(FirstCoefficient));
        }
    }
    public string SecondCoefficient
    {
        get { return secondCoefficient; }
        set
        {
            secondCoefficient = value;
            OnPropertyChanged(nameof(SecondCoefficient));
        }
    }

    public Coefficient(string firstCoef, string secondCoef)
    {
        firstCoefficient = firstCoef;
        secondCoefficient = secondCoef;
    }

    public Coefficient()
    {
        throw new System.NotImplementedException();
    }

    public Coefficient ConvertToCoefficient(DataField dataField)
    {
        return new Coefficient(dataField.FirstCoefficient,dataField.SecondCoefficient);
    }
}