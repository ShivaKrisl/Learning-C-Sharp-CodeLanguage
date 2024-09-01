using System.Collections.Generic;

namespace LearningCodeLanguage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Console Methods */
            SystemConsoleDemo.ConsoleMethods();

            /* Variables */
            VariablesDemo.Variables();

            /* DataTypes */
            DataTypesDemo.BytesDemo();

            /* Operators */
            OperatorsDemo.ArithmeticOperatorsDemo();

            /* Operators Assignment */
            OperatorsAssignment.CalculateAreaOfCircle();
            OperatorsAssignment.FeetToCentimeterConverter();
            OperatorsAssignment.MoneyRoundOffValue();
            OperatorsAssignment.SecondsConverter();

            /* Conditionals */
            ConditionalsAssignment.HeightCategory();
            ConditionalsAssignment.LargestOfThreeNumbers();
            ConditionalsAssignment.MarksFinder();

            /* Looping */
            LoopingDemo.WhileLoopDemo();
            LoopingDemo.DoWhileLoopDemo();
            LoopingDemo.ForLoopDemo();
            LoopingDemo.ForEachLoopDemo(); 
            LoopingDemo.GotoDemo();
        }
    }
}
