/* Disclaimer: The examples and comments from this program are from
   C#7 in a Nutshell and are written for learning purposes only. */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If__Else__and_Switch_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            // THE IF STATEMENT
            /* An if statement executes a statment if a bool expression
              is true. For example: */
            if (5 < 2 * 3)
                Console.WriteLine("true");  // true
            // The statement can be a code block:
            if (5 < 2 * 3)
            {
                Console.WriteLine("true");
                Console.WriteLine("Let's move on!");
            }

            // THE ELSE CLAUSE
            // An if statement can optionally feature an else clause:
            if (2 + 2 == 5)
                Console.WriteLine("Does not compute");
            else
                Console.WriteLine("False");
            // Within an else clause, you can nest another if statement:
            if (2 + 2 == 5)
                Console.WriteLine("Does not compute");
            else
                if (2 + 2 == 4)
                Console.WriteLine("Computes");

            // CHANGING THE FLOW OF EXECUTION WITH BRACES
            /* An else clause always applies to the immediately preceding
             if statement in the statement block: For example: */
            if (true)
                if (false)
                    Console.WriteLine();
                else
                    Console.WriteLine("executes");
            // This is semantically identical to:
            if (true)
            {
                if (false)
                    Console.WriteLine();
                else
                    Console.WriteLine("executes");
            }
            // We can change the flow by moving the braces:
            if (true)
            {
                if (false)
                    Console.WriteLine();
            }
            else
                Console.WriteLine("does not execute");
        }

        // ELSE CLAUSE WITHOUT BRACES EXAMPLE
        /* With braces, you explicitly state your intention. This can
          improve readability of nested if statement -- even when not
          required by the compiler. A notable exeception is with the
          following pattern: */
        static void TellMeWhatICanDo(int age)
        {
            if (age >= 35)
                Console.WriteLine("You can be President!");
            else if (age >= 21)
                Console.WriteLine("You can drink!");
            else if (age >= 18)
                Console.WriteLine("You can vote!");
            else
                Console.WriteLine("You can wait!");
        }
        /* Here, we've arranged the if and else statements to mimic
          the "elseif" construct of other languages. Visual studio's
          autoformatting recognizes the pattern and preserves the 
          indentation. Semantically, though, each if statement
          following an else statement is functionally nested within
          the else clause. */

        // SWITCH STATEMENT
        /* Switch statements let you branch program execution 
         based on a selection of possible values that a variable
         may have. Switch statements may result in cleaner code
         than mulitple if statements, since switch statements
         require an expression to be evaluated only once.
         For example: */
        static void ShowCard(int cardNumber)
        {
            switch (cardNumber)
            {
                case 13:
                    Console.WriteLine("King");
                    break;
                case 12:
                    Console.WriteLine("Queen");
                    break;
                case 11:
                    Console.WriteLine("Jack");
                    break;
                case -1:            // Joker is -1
                    goto case 12;   // In this game joker counts as queen.
                default:            // Executes for any other cardNumber
                    Console.WriteLine("cardNumber");
                    break;
            }
        }
        /* This example demonstrates the most common scenario, when is 
         switching on constants. When you specify a constant you're 
         restricted to the built-in integral types, bool, char, enum
         types, and the string type. */
        /* At the end of each case clause, you must say explicitly 
          where execution is to go next, with some kind of jump
          statement (unless your code ends in an infinite loop).

          Here are the options:
          - break (jumps to the end of the switch statement)
          - goto case x (jumps to another case clause)
          - goto default (jumps to the default clause)
          - Any other jump statement-namely, return, throw, continue,
                                             or goto label   */
        /* When more than one value should execute the same code, you
         can list the common cases sequentially: */
         static void showCard(int CardNumber)
        {
            switch(CardNumber)
            {
                case 13:
                case 12:
                case 11:
                    Console.WriteLine("Face card");
                    break;
                default:
                    Console.WriteLine("Plain card");
                    break;
            }
        }
        /* This feature of a swtich statement can be pivotal in terms
         of producing cleaner code than multiple if-else statements. */
    }
}
