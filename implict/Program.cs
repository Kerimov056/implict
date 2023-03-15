using implict.enginer;

Celsius celsius1 = new Celsius()
{
    Degree = 1
};
Kelvin kelvin = celsius1;
Console.WriteLine(kelvin.Degree);
Console.WriteLine("------------------");

Kelvin k1 = new Kelvin()
{
    Degree = 300
};
Celsius c1 = k1;
Console.WriteLine(c1.Degree);