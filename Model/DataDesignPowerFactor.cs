using System;
using System.Collections.Generic;

namespace M788_1069.Model;

public class DataDesignPowerFactor : DataField
{
    private readonly string path = @"C:\repository\Lern\M788-1069\Data\DataDesignPowerFactor.csv";
    public List<DataField> GetList()
    {
        List<DataField> dataList = new DataField().MakeLine(path) ?? throw new ArgumentNullException("new DataField().MakeLine(path)");
        return dataList;
    }
}