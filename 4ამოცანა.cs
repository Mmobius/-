/*
    მოცემულია String რომელიც შედგება „(„ და „)“ ელემენტებისგან. 
    დაწერეთ ფუნქცია 
    რომელიც აბრუნებს ფრჩხილები არის თუ არა მათემატიკურად სწორად დასმული.
    
      მაგ: (()()) სწორი მიმდევრობაა,  ())() არასწორია
*/
using System;
using System.Collections.Generic;

public class Program {
    public static void Main() {
        bool text = IsProperly("())()");
        Console.WriteLine(text);

    }

    static bool IsProperly(string text) {
        char openBracket = '(';
        char closeBracket = ')';

        var stack = new Stack < char > ();

        foreach(char item in text) {
            if (item == openBracket) {
                stack.Push(item);
            } else if (item == closeBracket) {
                if (stack.Count > 0 && stack.Peek() == openBracket) {
                    stack.Pop();
                } else {
                    return false;
                }
            }
        }

        if (stack.Count == 0) {
            return true;
        }

        return false;
    }

}
