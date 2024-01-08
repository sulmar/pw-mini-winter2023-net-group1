using Domain.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Infrastructure;

public interface IFileReader
{
    string ReadAllText(string fileName);
}

public class RealFileReader : IFileReader
{
    public string ReadAllText(string fileName)
    {
        return File.ReadAllText(fileName);
    }
}


public class TrackingService
{
    private IFileReader fileReader;

    public TrackingService()
        : this(new RealFileReader())
    {
        
    }

    public TrackingService(IFileReader fileReader)
    {
        this.fileReader = fileReader;
    }

    public Location GetLocation()
    {
        string json = fileReader.ReadAllText("tracking.json");

        if (string.IsNullOrEmpty(json))
            throw new Exception();

        try
        {
            Location location = JsonConvert.DeserializeObject<Location>(json);

            return location;
        }
        catch (Exception ex)
        {
            throw new Exception();
        }
    }
}
