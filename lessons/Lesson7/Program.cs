int Factorial(int number)
{
    if (number == 1)
    {
        return 1;
    }
    return number * Factorial(number - 1);
}

int Fib(int number)
{
    if (number == 0 || number == 1)
    {
        return 1;
    }
    return Fib(number - 1) + Fib(number - 2);
}