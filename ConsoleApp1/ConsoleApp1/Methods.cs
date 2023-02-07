
double a = Math.Pow(2, 6);  //hatvány
double aa = Math.Sqrt(4);   //négyzetgyök

float number = 12.544f;
float b = Math.Abs(number);   //abszolút érték
float e = Math.Sign(number);   //előjelfüggvény

float c = Math.Max(7, 4); //maximumot kiírja
float d = Math.Min(7, 4);// minimumot kiírja

double f = Math.Ceiling(45.05);  //plafon felfelé kerekítés
double g = Math.Floor(467.75);  //padló, lefelé kerekítés
double h = Math.Round(33.6);   // kerekítés a kerekítés szabályai szerint


//------------------------------------


float a1 = Abs(-13.5f);
float a2 = Sign(-55);
float a3 = Max(5, 7);
MyMethod(6);
MyMethod(7);
MyMethod(8);
//------------------------------------

float Abs(float num)
{
    float result = num;
    if (num < 0)
        result = - num;
    return result;
}


float Max(float a, float b)
{
    if (a < b)
    { 
        return b;
    }
    else
    { 
        return a; 
    }
}

float Sign(float a)
    {
    if (a < 0)
        return -1;
    return 1;
}

// Method

void MyMethod(int n)
{
    for (int i = 1; i < n; i++)
        Console.WriteLine(i);
}