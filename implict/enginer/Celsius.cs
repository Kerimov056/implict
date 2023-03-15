namespace implict.enginer;

public class Celsius
{
    public double Degree { get; set; }

    public static implicit operator Celsius(Kelvin kelvin1)
    {
        return new Celsius { Degree = kelvin1.Degree - 273.15 };
    }
}
