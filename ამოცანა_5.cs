/*
  გვაქვს n სართულიანი კიბე, 
  ერთ მოქმედებაში შეგვიძლია ავიდეთ 1 ან 2 საფეხურით. 
  დაწერეთ ფუნქცია 
  რომელიც დაითვლის n სართულზე ასვლის ვარიანტების რაოდენობას.
*/

using System;

public class Program 
{
    public static void Main() 
    {
        Console.WriteLine(Steps.CountVariants(0));
    }
}


public static class Steps 
{
    static long PiNotation(int firstFactor, int lastFactor) 
    {
        /*
          როცა firstFactor=1 და lasFactor=n მაშინ PiNotation=n!
        */

        long piNotation = 1;
        for (int f = firstFactor; f <= lastFactor; f++) 
        {
            piNotation *= f;
        }

        return piNotation;
    }

  
    static long Combination(int n, int k) 
    {
        /*
          C(n,k)=n!/k!*(n-k)!
          შევკვეცოთ მნიშვნელის თანამამრავლიდან უდიდესზე
          ამით დროს მოვიგებთ.
          მივიღებთ: C(n,k)=[(n-k+1)*(n-k+2)*...*n]/k!
        */
        int min = Math.Min(n - k, k);
        int max = Math.Max(n - k, k);

        return PiNotation(max + 1, n) / PiNotation(1, min);
    }

  
    public static long CountVariants(int steps) 
    {
        long variants = 1;

        if (steps <= 0) 
        {
            throw new IndexOutOfRangeException("საფეხურები რაოდენობა მეტი უნდა იყოს 0-ზე");
        } 
        else 
        {
            for (int r = 1; r <= steps / 2; r++) 
            {
                variants += Combination(steps - r, r);
            }
        }

        return variants;
    }

}
