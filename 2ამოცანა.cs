/*
    გვაქვს 1,5,10,20 და 50 თეთრიანი მონეტები. 
    დაწერეთ ფუნქცია, 
    რომელსაც გადაეცემა თანხა (თეთრებში) და აბრუნებს მონეტების მინიმალურ რაოდენობას, 
    რომლითაც შეგვიძლია ეს თანხა დავახურდაოთ.
*/

using System;
using System.Collections.Generic;

public class Program {
    public static void Main() {
        var x = MinSplit(156);

        for (int i = 0; i < x.Count; i++) {
            Console.WriteLine(x[i]);
        }
    }

    static List < int > MinSplit(int amount) {
        int[] cents = {
            50,
            20,
            10,
            5,
            1
        };
        var list = new List < int > ();

        for (int i = 0; i < 5; i++) {
            int x = amount / cents[i];
            int y = amount % cents[i];

            list.Add(x);
            if (y == 0) {
                return list;
            }

            amount = y;
        }

        return list;
    }

}
