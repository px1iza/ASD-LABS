using System;

class Vector
{
    public double X { get; set; }
    public double Y { get; set; }

    public Vector(double x, double y)
    {
        X = x;
        Y = y;
    }

    public double GetAngle()
    {
        return Math.Atan2(Y, X);
    }

    public double Length()
    {
        return Math.Sqrt(X * X + Y * Y);
    }
}