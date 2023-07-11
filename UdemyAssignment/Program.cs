class Program
{
    static void Main(string[] args)
    {
        //declaring variable
        int num1;

        //assigning value to variable
        num1 = 13;
        Console.WriteLine(num1);

        //adding the sum of 2 numbers
        int num2 = 23;
        num2 = 100;
        

        //concatination
        Console.WriteLine("num is " + num1);
        int sum = num1 + num2;
        Console.WriteLine("num1: " + num1 + " + num2: " + num2 + " is " + sum);
        


        //declaring multiple variables at once

        int num3, num4, num5;
        Console.WriteLine(sum);
        
        //diving doubles
        double d1 = 3.14;
        double d2 = 5.1;
        double dDive = d1 / d2;
        Console.WriteLine("d1/d2 is " + dDive);

        //diving floats
        float f1 = 3.14f;
        float f2 = 5.1f;
        float fDiv = f1 / f2;
        Console.WriteLine("f1/f2 is " + fDiv);

        //diving different variable
        double DiDiv = d1 / num1;
        Console.WriteLine("d1/num1 is" + DiDiv);


       
       
        Console.Read();
    }
}