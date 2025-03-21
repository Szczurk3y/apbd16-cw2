namespace Cwiczenia2.Util;

public class AtmosphereUnit (double pressure, AtmosphereUnitType unit)
{
    private double _pressure = pressure;
    public double GetPressure() => _pressure;
    public AtmosphereUnitType GetUnit() => unit;

    public string GetFullPressureInfo() =>  $"{GetPressure()} {GetUnit()}";

    public void SetCurrentPressure(double pressure)
    {
        _pressure = pressure;
    }
}

// 1 physical atmosphere (atm) = 101325 Pa = 1.01325 bar = 1.0332 at = 760.002 Torr = 7,760.002 mmHg = 14.696 psi.
public enum AtmosphereUnitType { ATM, PA, BAR, AT, TORR, MMHG, PSI }