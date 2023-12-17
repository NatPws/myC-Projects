/* int Factorial (int n)
{

    if (n == 1) return 1;
    else return n + Factorial(n-1);
}
Console.WriteLine(Factorial(3)); // 1*2*3 = 6
 */

double Factorial (int n)
{
    if (n == 1) return 1;
    else return n * Factorial(n - 1);
}
for (int i = 1; i < 18; i++)
{
    Console.WriteLine($"{i!} = {Factorial(i)}"); 
}