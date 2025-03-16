namespace Cwiczenia2.Util;

public class SerialNumber
{
    private static readonly List<SerialNumber> ContainerList = [];
    private const string Format = "KON";

    private readonly ContainerType _containerType;
    private readonly int _containerNumber;
    
    public SerialNumber(ContainerType containerType)
    {
        ContainerList.Add(this);
        _containerType = containerType;
        _containerNumber = ContainerList.Count;
    }

    public string GetSerialNumber()
    {
        return Format + '-' + _containerType + '-' + _containerNumber;
    }
}
