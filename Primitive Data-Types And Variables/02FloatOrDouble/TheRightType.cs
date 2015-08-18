namespace FloatOrDouble


{
    using System;

    class TheRightType
    {
        static void Main(string[] args)
        //Which of the following values can be assigned to a variable of type float and which to a variable of type double: 34.567839023, 12.345, 8923.1234857, 3456.091?
        {
            double numberOne = 34.567839023;
            float numberTwo = 12.345f;
            double numberThree = 8923.1234857;
            float numberFour = 3456.091f;
            Console.WriteLine("{0} | {1} | {2} | {3}", numberOne,numberTwo,numberThree,numberFour);
        }
    }
}
