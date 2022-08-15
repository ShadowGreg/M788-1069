using System;
using System.Collections.Generic;

namespace M788_1069.Model;

public class DemandPowerFactorData : DataField
{
    private readonly string _path = @"C:\repository\Lern\M788-1069\Data\DataDemandPowerFactor.csv";
    public List<DataField> GetList()
    {
        List<DataField> dataList = new DataField().MakeLine(_path) ?? throw new ArgumentNullException("new DataField().MakeLine(path)");
        return dataList;
    }
}