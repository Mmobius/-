using System;
using System.Collections.Generic;

public class Program {
    public static void Main() {
        int x = NotContains(new int[] {
            -9, -8, -8, 6, 5, 3, 3, 2, 0, 1
        });

        Console.WriteLine(x);

    }

    static int NotContains(int[] array) {
        int notContains = 1;
        var list = ArrayToList(array);

        foreach(int item in list) {
            if (item != notContains) {
                return notContains;
            }
            notContains = notContains + 1;
        }
        return notContains;
    }

    static List < int > ArrayToList(int[] array) {
        var list = new List < int > ();

        int arrayLength = array.Length;
        for (int i = 0; i < arrayLength; i++) {
            if (array[i] > 0) {
                if (!list.Contains(array[i])) {
                    list.Add(array[i]);
                }
            }
        }

        list.Sort();

        return list;
    }

}