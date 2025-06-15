using System;

public struct Cor
{
    public byte R { get; set; }
    public byte G { get; set; }
    public byte B { get; set; }

    public Cor(byte r, byte g, byte b)
    {
        R = r;
        G = g;
        B = b;
    }

    public string ParaHexadecimal()
    {
        return $"#{R:X2}{G:X2}{B:X2}";
    }
}
