string test = "abcabc";
string[] codes = new[]
{
    ".-",
    "-...",
    "-.-.",
};

foreach (char symbol in test)
{
    int index = (int)symbol - (int)'a';
    Console.Write(codes[index]);
    Console.Write('|');
}

