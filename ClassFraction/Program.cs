using static System.Console;
Fraction frac= new Fraction(1,2);
Fraction frac1= new Fraction(3,4);
Fraction frac2= Fraction.Sum(frac,frac1);
frac2.Print();
frac.Print();
frac1.Print();
frac2 = Fraction.Pow(frac1);
frac2.Print();
frac2 = Fraction.GetReduceFraction(frac1);
frac2.Print();

class Fraction
{
    int numerator;
    int denominator;

    public Fraction(int numerator=0, int denominator=1)
    {
        this.numerator = numerator;
        if (denominator == 0)
            WriteLine("Знаменатель не может быть равен нулю");
        else
            this.denominator = denominator;
    }
    public static Fraction Sum(Fraction left, Fraction right)
    {
        Fraction buf = new Fraction();
       buf.numerator =left.numerator* right.denominator+right.numerator*left.denominator;
        buf.denominator=left.denominator*right.denominator;
        return buf;
    }
    public static Fraction Sum(Fraction f,int chislo)
    {
        Fraction buf = new Fraction();
        buf.numerator=f.numerator+ chislo*f.denominator;
        buf.denominator = f.denominator;
        return buf;
    } 
    public static Fraction Sum(int chislo,Fraction f)
    {
        Fraction buf = new Fraction();
        buf.numerator = f.numerator + chislo * f.denominator;
        buf.denominator = f.denominator;
        return buf;
    }
    public static Fraction Sub(Fraction left, Fraction right)
    {
        Fraction buf = new Fraction();
        buf.numerator = left.numerator * right.denominator - right.numerator * left.denominator;
        buf.denominator = left.denominator * right.denominator;
        return buf;

    }
    public static Fraction Sub(Fraction f, int chislo)
    {
        Fraction buf = new Fraction();
        buf.numerator = f.numerator - chislo * f.denominator;
        buf.denominator = f.denominator;
        return buf;
    }
    public static Fraction Sub(int chislo, Fraction f)
    {
        Fraction buf = new Fraction();
        buf.numerator =   chislo * f.denominator-f.numerator;
        buf.denominator = f.denominator;
        return buf;
    }
    public static Fraction Mult(Fraction left, Fraction right) 
    {
        Fraction buf = new Fraction();
        buf.numerator = left.numerator * right.numerator;
        buf.denominator= left.denominator*right.denominator;
        return buf;
    }
    public static Fraction Mult(Fraction f, int chislo)
    {
        Fraction buf = new Fraction();
        buf.numerator = f.numerator * chislo;
        buf.denominator = f.denominator;
        return buf;
    }
    public static Fraction Mult( int chislo,Fraction f)
    {
        Fraction buf = new Fraction();
        buf.numerator = f.numerator * chislo;
        buf.denominator = f.denominator;
        return buf;
    }
    public static Fraction Div(Fraction left, Fraction right)
    {
        Fraction buf = new Fraction();
        buf.numerator = left.numerator * right.denominator;
        buf.denominator = left.denominator * right.numerator;
        return buf;
    }
    public static Fraction Div(Fraction f, int chislo)
    {
        Fraction buf=new Fraction();
        buf.numerator= f.numerator ;
        buf.denominator= f.denominator*chislo ;
        return buf;
    }
    public static Fraction Div(int chislo,Fraction f )
    {
        Fraction buf=new Fraction();
        buf.numerator= chislo*f.denominator ;
        buf.denominator= f.numerator ;
        return buf;
    }
    public static Fraction GetReduceFraction(Fraction f )
    {
        Fraction buf= new Fraction();
        buf.numerator= f.numerator;
        buf.denominator= f.denominator;
        if (f.numerator>=f.denominator)
        { 
            if (f.numerator% f.denominator==0)
            {
                buf.numerator/=buf.denominator;
                buf.denominator = 1;
            }
        }
        else
            {
                int temp=f.numerator;
                while(temp>0) 
                { 
                    if(f.denominator%temp==0&&f.numerator==0)
                {
                    buf.numerator=f.numerator/temp;
                    buf.denominator=f.denominator/temp;
                }
                temp--;}
            }
        
        return buf;
    }
    public static Fraction Pow(Fraction f)
    {
        Fraction buf = new Fraction();
        buf = Fraction.Mult(f, f);
        return buf;
    }
    /*public static Fraction SQRT(Fraction f)
    {
        Fraction buf = new Fraction();
        return buf
    }*/

    public void Print()
    {
        WriteLine($"{numerator}/{denominator}");
    }
   
}

 class FractionException : Exception
    {

    }
