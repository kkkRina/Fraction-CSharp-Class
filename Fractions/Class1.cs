using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Fractions
{
    public class Fraction
    {
        public int Whole { get; set; }
        public int Top { get; set; }
        
        private int _Bottom;
        public int Bottom
        {
            set
            {
                if (value ==0)
                    throw new Exception("Incorrect fraction. The denominator must not be 0. ");
                if (value < 0)
                {
                    Top = Top * (-1);
                }
                _Bottom = Math.Abs(value);
                
            }
            get => _Bottom;
        }
        public Fraction(int whole, int top, int bottom)
        {
            
            int topp = whole * bottom + top;
            if (GCD(topp, bottom) != 0)
            {
                Top = topp / GCD(topp, bottom);
                Bottom = bottom/GCD(top, bottom);
            }
            else
            {
                Top = topp;
                Bottom = bottom;
            }
            
        }
        public Fraction(int top, int bottom)
        {
            if (GCD(top, bottom) != 0)
            {
                Top = top / GCD(top, bottom);
                Bottom= bottom / GCD(top, bottom);
            }
            else
            {
                Top = top;
                Bottom=bottom;
            }

        }
        public static implicit operator Fraction(int value)
        {
            return new Fraction(value,1);
        }
        public static implicit operator Fraction(double value)
        {
            
            int whole = (int) value / 1;
            value = value - whole;
            double dr = value;
            int k = 1;
            while (value > 0)
            {
                k++;
                value =  (int)value / 10;
            }
            int top = (int)((dr) * Math.Pow(10, k));
            int bottom = (int)Math.Pow(10, k);
            return new Fraction(whole, top, bottom );
        }

        public Fraction(Fraction f) : this(f.Top, f.Bottom) { }
        
        public static Fraction operator +(Fraction f1,Fraction f2)
        {
            if (f1.Bottom == f2.Bottom)
            {
                return new Fraction(f1.Top + f2.Top, f1.Bottom);
            }
            else
            {
                return new Fraction(f1.Top * f2.Bottom + f1.Bottom * f2.Top, f1.Bottom * f2.Bottom);
            }
        }
        public static Fraction operator -(Fraction f1, Fraction f2)
        {
            if (f1.Bottom == f2.Bottom)
            {
                return new Fraction(f1.Top - f2.Top, f1.Bottom);
            }
            else
            {
                return new Fraction(f1.Top * f2.Bottom - f1.Bottom * f2.Top, f1.Bottom * f2.Bottom);
            }
        }
        public static Fraction operator *(Fraction f1, Fraction f2) => new Fraction(f1.Top*f2.Top,f1.Bottom*f2.Bottom);
        
        public static Fraction operator /(Fraction f1, Fraction f2) => new Fraction(f1.Top*f2.Bottom, f1.Bottom*f2.Top);
        
        public static bool operator ==(Fraction f1, Fraction f2) => (f1.Top * f2.Bottom == f2.Top * f1.Bottom);
        
        public static bool operator !=(Fraction f1, Fraction f2) => !(f1 == f2);

        public static bool operator >(Fraction f1, Fraction f2)=> (f1.Top * f2.Bottom > f2.Top * f1.Bottom);
        
        public static bool operator <(Fraction f1, Fraction f2) =>  (f1.Top * f2.Bottom < f2.Top * f1.Bottom);
        
        public static bool operator >=(Fraction f1, Fraction f2) => (f1.Top * f2.Bottom >= f2.Top * f1.Bottom);
        
        public static bool operator <=(Fraction f1, Fraction f2) => (f1.Top * f2.Bottom <= f2.Top * f1.Bottom);
        
        public static Fraction operator ^(Fraction f1, int value)
        {
            int a = f1.Top;
            int b = f1.Bottom;
            if (value < 0)
            {
                a = f1.Bottom;
                b = f1.Top;
                value = value * (-1);

            }
            
            int atop = 1;
            int bbot = 1;
            while (value > 0)
            {
                atop = atop * a;
                bbot = bbot * b;
                value--;
            }
            return new Fraction(atop, bbot);
        }
        public static implicit operator double(Fraction x)
        {
            return (double)x.Top / x.Bottom;
        }
        private static int GCD(int a, int b)
        {
            while (b != 0)
            {
                var temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
        public override string ToString()
        {
            var sb = new StringBuilder();
            int whole = Top / Bottom;
            int top = Top - whole * Bottom;
            if (whole != 0)
            {
                sb.Append(whole >= 0||top<=0 ? "" : "-");
                sb.Append(whole);
                if (top != 0)
                {
                    sb.Append(" and ");
                }
            }
            if (top != 0)
            {
                if (Bottom != 0)
                {
                    sb.Append(((top < 0 || Bottom <0) && whole>0 ) ? "-" : "");
                    sb.Append(Math.Abs(top));
                    if (Bottom != 1)
                    {
                        sb.Append("/");
                        sb.Append(Math.Abs(Bottom));
                    }
                }
            }
            return sb.ToString();
        }
        

    }
}




