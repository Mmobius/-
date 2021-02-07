/*
   დაწერეთ ფუნქცია 
   რომელსაც გადაეცემა ტექსტი  და აბრუნებს პალინდრომია თუ არა. 
   (პალინდრომი არის ტექსტი რომელიც ერთნაირად იკითხება ორივე მხრიდან)
*/
using System;
using System.Collections.Generic;

public class Program {
    public static void Main() {
        
        string firsText = "Red rum, sir, is murder";
        string secondText = "Was it a cat I saw?";

        Console.WriteLine(firsText + "-{0}", IsPalindrome(firsText));
        Console.WriteLine(secondText + "-{0}", IsPalindrome(secondText));
    }

        static bool IsPalindrome(string text) {
        var list = new List < char > ();

        foreach(var item in text) {
            if (Char.IsLetterOrDigit(item)) {
                list.Add(char.ToUpper(item));
            }
        }

        text = string.Join("", list);
        list.Reverse();
        string reverseText = string.Join("", list);

        return text == reverseText;
    }
 
}


                        
