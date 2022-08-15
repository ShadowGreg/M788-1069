using M788_1069.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;

namespace M788_1069.ViewModel;

public class ViewModel : ObservableObject
{
    #region Pole
    private string divisionName;
    private List<Industry> divisions;
    ////запрашиваемый текст
    //private string _typeChar;
    ////переменная с поисковым контентом
    //private List<DataField> _searchRequestFields;
    //public List<DataField> ShadowDataFields;
    ////переменная куда заношу строки
    //private List<DataField> _maceDataFields;
    ////итоговая коллекция куда сгружается лист для отображения
    //private ObservableCollection<DataField> _searchRequest;
    ////две базовые структуры из которых беру основную часть. 
    //private static DataDesignPowerFactor designPowerFactor = new DataDesignPowerFactor();
    //private static DemandPowerFactorData demandPowerFactor = new DemandPowerFactorData();
    //private List<DataField> designPowerFactorData = designPowerFactor.GetList();
    //private List<DataField> demandPowerFactorData = demandPowerFactor.GetList();
    #endregion Pole

    public ViewModel()
    {
       
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
    public ViewModel ConvertToDivision(DataField dataField)
    {
        return new ViewModel(dataField);
    }
    //public string TypeChar
    //{
    //    get => _typeChar;
    //    set
    //    {
    //        _typeChar = value;
    //        OnPropertyChanged("TypeChar");
    //    }
    //}

    //public ViewModel()
    //{
    //    if (TypeChar != null) _searchRequestFields = GetItemsByTypeName(designPowerFactorData, TypeChar);

    //}

    //private List<DataField> getFirstHeaderList(string typeChar)
    //{
    //}
    private List<DataField> GetItemsByTypeName(List<DataField> _dataFieldList, string typeChar)
    {
        var tempDataList = _dataFieldList.FindAll(x =>
        {
            Debug.Assert(x.Type != null, "x.Type != null");
            return x.Type.Contains(typeChar);
        });
        return tempDataList;
    }

    private DataField GetAerialDivision(List<DataField> _dataFieldList, int start, int end)
    {
        var tempData = new DataField();
        var tempDataList = _dataFieldList.GetRange(start, end);
        foreach (var itemField in tempDataList.Where(itemField => itemField.DivisionName != ""))
        {
            tempData = itemField;
        }

        return tempData;
    }

    private DataField GetAerialIndustry(List<DataField> _dataFieldList, int start, int end)
    {
        var tempData = new DataField();
        var tempDataList = _dataFieldList.GetRange(start, end);
        foreach (var itemField in tempDataList.Where(itemField => itemField.IndustryName != ""))
        {
            tempData = itemField;
        }
        return tempData;

    }

    private DataField GetAerialFactory(List<DataField> _dataFieldList, int start, int end)
    {
        var tempData = new DataField();
        var tempDataList = _dataFieldList.GetRange(start, end);
        foreach (var itemField in tempDataList.Where(itemField => itemField.FactoryName != ""))
        {
            tempData = itemField;
        }
        return tempData;
    }

    private DataField GetAerialSection(List<DataField> _dataFieldList, int start, int end)
    {
        var tempData = new DataField();
        var tempDataList = _dataFieldList.GetRange(start, end);
        foreach (var itemField in tempDataList.Where(itemField => itemField.SectionName != ""))
        {
            tempData = itemField;
        }
        return tempData;
    }

    private DataField GetAerialSubtype(List<DataField> _dataFieldList, int start, int end)
    {
        var tempData = new DataField();
        var tempDataList = _dataFieldList.GetRange(start, end);
        foreach (var itemField in tempDataList.Where(itemField => itemField.SubtypeName != ""))
        {
            tempData = itemField;
        }
        return tempData;
    }

    //public void UpdateOBSCollection(List<DataField> tempList)
    //{
    //     _searchRequest = new ObservableCollection<DataField>(tempList);
    //}
}


