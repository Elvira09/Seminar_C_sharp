// Написать программу вычисления функции Аккермана


double funcAkkerman(double m, double n)
{
    if(m==0)
    {
        return n+1;
    }
    else if(n==0)
        {
            return funcAkkerman(m-1,1);
        }
        else 
        {   
            return funcAkkerman(m-1,funcAkkerman(m,n-1));
        }
}

Console.WriteLine(funcAkkerman(3,5));
