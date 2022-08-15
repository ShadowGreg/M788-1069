using System;
using System.Collections.Generic;
using M788_1069.Model;
using System.Runtime.InteropServices.ComTypes;
using System.Windows.Documents;
using Microsoft.VisualBasic.CompilerServices;
using Type = M788_1069.Model.Type;

namespace M788_1069.ViewModel;

public class Converter
{
    #region BenchmarkData

    private DataDesignPowerFactor DataDesignPowerFactor = new DataDesignPowerFactor();
    private DemandPowerFactorData DemandPowerFactorData = new DemandPowerFactorData();
    private List<DataField> tempDataFields = new List<DataField>();
    #endregion

    #region InsertData
    private List<DataField> localInsertDataFields = new List<DataField>();
    #endregion
    #region CondertData
    private List<List<ObjectType>> tepmList = new List<List<ObjectType>>();
    #endregion

    Converter(List<DataField> insertDataFields)
    {
        localInsertDataFields = insertDataFields;
    }

    public ViewModel DesignPowerConvertToTree()
    {
        tempDataFields = DataDesignPowerFactor.GetList();
        MakeTree();
        return new ViewModel();
    }
    public ViewModel DemandPowerConvertToTree()
    {
        tempDataFields = DemandPowerFactorData.GetList();
        MakeTree();
        return new ViewModel();
    }

    private void MakeTree()
    {
        int start = 0, end = 10;
        
        MakeCoefficientList(start, end);
        
        MakeTypeList();
        MakeSubtypeList();
        MakeFactoryList();
        MakeIndustyList();
    }

    

    private List<Type> MakeTypeList(List<List<Coefficient>> listListCoefficient, List<string> listName)
    {
       
        var tempType = new Type();
        var tempListType = new List<Type>();
        try
        {
            if (listListCoefficient.Count==listName.Count)
            {
                int i=0;
                foreach (var VARIABLE in listName)
                {
                    tempListType[i].TypeName = VARIABLE;
                    tempListType[i].Coefficients = listListCoefficient[i];
                    tempListType.Add(null);
                    i++;
                }
            }
            
        }
        catch (Exception e)
        {
            Console.WriteLine(e + "see MakeTypeList");
            throw;
        }
        return tempListType;
    }

    private List<Coefficient> MakeCoefficientList(int start, int end)
    {
        var tempCoefficient = new Coefficient();
        var tempCoefficientList = new List<Coefficient>();
        for (int i = start; i < end; i++)
        {
            tempCoefficient.FirstCoefficient = tempDataFields[i].FirstCoefficient;
            tempCoefficient.SecondCoefficient = tempDataFields[i].SecondCoefficient;
            tempCoefficientList.Add(tempCoefficient);
        }

        return tempCoefficientList;
    }
}


