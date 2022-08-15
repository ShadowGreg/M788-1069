using CsvHelper;
using CsvHelper.Configuration;
using CsvHelper.Configuration.Attributes;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime;
using System.Text;

namespace M788_1069.Model;

public class DataField
{
    [Index(0)]
    public int Index { get; set; }
    [Index(1)]
    public string? DivisionName { get; set; }
    [Index(2)]
    public string? IndustryName { get; set; }
    [Index(3)]
    public string? FactoryName { get; set; }
    [Index(4)]
    public string? SectionName { get; set; }
    [Index(5)]
    public string? SubtypeName { get; set; }
    [Index(6)]
    public string? Type { get; set; }
    [Index(7)]
    public string? FirstCoefficient { get; set; }
    [Index(8)]
    public string? SecondCoefficient { get; set; }

   

    public List<DataField> MakeLine(string path)
    {
        var config = new CsvConfiguration(CultureInfo.InvariantCulture)
        {
            Delimiter = ";",
            HasHeaderRecord = false,
            Encoding = Encoding.UTF8,
        };
        //@"C:\repository\Lern\M788-1069\Data\Data.csv"
        using var reader = new StreamReader(path);
        using var csv = new CsvReader(reader, config);
        var tempCVS = csv.GetRecords<DataField>().ToList();
        int index=0;
        foreach (var VARIABLE in tempCVS)
        {
            VARIABLE.Index  = index;
            index++;        }

        return tempCVS;
    }
    
}

