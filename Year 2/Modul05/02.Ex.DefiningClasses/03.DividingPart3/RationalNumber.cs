using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class RationalNumber
{
    private int numerator;
    private int denumerator;

    public RationalNumber(int numerator, int denumerator)
    {
        int nod = BiggestDivider(numerator, denumerator);
        Numerator = numerator / nod;
        Denumerator = denumerator / nod;
        if (Denumerator < 0)
        {
            Denumerator *= -1;
            Numerator *= -1;
        }

    }

    public int Numerator
    {
        get { return numerator; }
        set { numerator = value; }
    }
    public int Denumerator
    {
        get { return denumerator; }
        set { denumerator = value; }
    }

    private int BiggestDivider(int a, int b)
    {
        int r;
        while(b!=0)
        {
            r = a % b;
            a = b;
            b = r;
        }
        return a;
    }
    public int CompareTo(object obj)
    {
        RationalNumber x = (RationalNumber)obj;
        if (Numerator * x.denumerator < Denumerator * x.numerator)
        {
            return -1;
        }
        else if (Numerator * x.denumerator > Denumerator * x.numerator)
        {
            return 1;
        }
        else
        {
            return 0;
        }
    }

    public override string ToString()
    {
        return $"{Numerator}/{Denumerator};";
    }
}
