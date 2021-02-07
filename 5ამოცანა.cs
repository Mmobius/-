/*
  გვაქვს n სართულიანი კიბე, 
  ერთ მოქმედებაში შეგვიძლია ავიდეთ 1 ან 2 საფეხურით. 
  დაწერეთ ფუნქცია 
  რომელიც დაითვლის n სართულზე ასვლის ვარიანტების რაოდენობას.
*/


using System;

public class Program {
    public static void Main() {
        long x = CountVariants(5);
        Console.WriteLine(x);
    }

    static long CountVariants(int stearsCount) {
        long countVariants = 0;
        int length = stearsCount / 2;

        for (int s = 0; s <= length; s++) {
            countVariants = countVariants + Combination(stearsCount - s, s);
        }

        return countVariants;
    }

    static long Combination(int n, int k) {
        if (k > n) {
            int c = n;
            n = k;
            k = c;
        }

        if (k == 0) {
            return 1;
        }

        int v = Math.Min(k, n - k);
        int u = Math.Max(k, n - k);

        return PiNotation(u + 1, n) / PiNotation(1, v);
    }

    static long PiNotation(int firstFactor, int lastFactor) {
        if (firstFactor > lastFactor) {
            int c = firstFactor;
            firstFactor = lastFactor;
            lastFactor = c;
        }

        if (firstFactor == 0 && lastFactor == 0) {
            return 1;
        }

        long piNotation = 1;
        for (int factor = firstFactor; factor <= lastFactor; factor++) {
            piNotation = piNotation * factor;
        }

        return piNotation;
    }

}
