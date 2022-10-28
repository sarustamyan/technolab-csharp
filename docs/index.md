# Welcome to the Techolab C# course!

## Contacts

+374 93 573219

Samvel Arustamyan (samvel.arustamyan"shnik"gmail.com)

## Participants

* Baghdasaryan Ani
* Ghazaryan Jora

## Resources 

* [C# Programming for Absolute Beginners](https://www.goodreads.com/book/show/58230269-c-programming-for-absolute-beginners) by Radek Vystavěl
* [Illustrated C# 7](https://www.goodreads.com/book/show/36902257-illustrated-c-7) by Daniel Solis
* [Microsoft Courses](https://dotnet.microsoft.com/en-us/learn/csharp)

## Prerequisites

1. Development environment

   1. Install Visual Studio Community Edition (with .NET desktop development option): [https://visualstudio.microsoft.com/vs/community/](https://visualstudio.microsoft.com/vs/community/)
   2. Use [https://dotnetfiddle.net/](https://dotnetfiddle.net/) whenever VS is not available
   
## Lesson 0 - Introduction

### In Class

1. Console.WriteLine()
2. Arithmetic and string operations
3. ASCII characters

### Home Assignments

1. Create a Console Application project and print "Hello World" to the output.
2. Print double-backslashes, i.e. "\\\\" 
3. Create a spinner animation using the following characters: \|,/,-,\ (use `Thread.Sleep()` to slow it down)
4. Learn about Git

## Lesson 1 - Types, Variables & Conditions

### In Class

1. Basic types, strings 
2  Variables and scopes
3. Boolean operators (&&, \|\|, !)
4. Conditional Statements

### Home Assignments

**Coding**

1. Fix the "days of month" riddle

**Git**

1. Install git: [https://git-scm.com/download](https://git-scm.com/download)
2. Create a GitHub account: [https://github.com/join](https://github.com/join)
3. Add an ssh key to the GitHub account: [https://docs.github.com/en/authentication/connecting-to-github-with-ssh](https://docs.github.com/en/authentication/connecting-to-github-with-ssh).
4. Create a repository for class projects and push to github: [https://docs.github.com/en/get-started/importing-your-projects-to-github/importing-source-code-to-github/adding-locally-hosted-code-to-github](https://docs.github.com/en/get-started/importing-your-projects-to-github/importing-source-code-to-github/adding-locally-hosted-code-to-github). NOTE: use the SSH instead of HTTPS for remote URL.

## Lesson 2 - Loops

### In Class

1. `while` loops
  * Enhance the command line spinner
  * Print all the numbers from 1 to 20
2. `for` loops
  * Calculate the sum of all the numbers from 1 to 100
  
### Home Assignments

**Coding**

1. Calculate the sum of all the numbers from 1 to 100 that are a multiple of 3
2. For the given number of iterations `n` calculate approximation of pi using the Leibniz formula: [https://en.wikipedia.org/wiki/Leibniz_formula_for_%CF%80)](https://en.wikipedia.org/wiki/Leibniz_formula_for_%CF%80). *Side quest: watch a video on Newton's formula for pi: [https://www.youtube.com/watch?v=gMlf1ELvRzc](https://www.youtube.com/watch?v=gMlf1ELvRzc) *
3. Print `true` if the given nubmer is a prime number
4. Calculate the sum of all the prime numbers between 2 and 100 

**Git**

1. Fork the repository [https://github.com/sarustamyan/technolab-csharp](https://github.com/sarustamyan/technolab-scharp) (see [https://docs.github.com/en/get-started/quickstart/fork-a-repo](https://docs.github.com/en/get-started/quickstart/fork-a-repo) for help)
2. Checkout the branch `master`
3. Edit `docs/index.md` to add yourself to the list of participants under the section "Participants".
4. Commit and push your changes to the forked repository ([https://www.earthdatascience.org/workshops/intro-version-control-git/basic-git-commands/](https://www.earthdatascience.org/workshops/intro-version-control-git/basic-git-commands/))
5. Create a pull request with the changes ([https://docs.github.com/en/pull-requests/collaborating-with-pull-requests/proposing-changes-to-your-work-with-pull-requests/creating-a-pull-request-from-a-fork](https://docs.github.com/en/pull-requests/collaborating-with-pull-requests/proposing-changes-to-your-work-with-pull-requests/creating-a-pull-request-from-a-fork))

## Lesson 3 - Loop Practice

### Home Assignments

1. Print the biggest number from the range 1 to 1000 which is devisible by 16 **and** whose last digit is 4
2. Print all the numbers from the range 10 to 99 whose sum of the digits is greater than 14. I.e. 69 (6 + 9 > 14), 78, 79, 87 etc.
3. Print all the numbers from the range 10 to 99 which are divisible by all their digits (beware of divisions by 0). I.e. 11 (11 % 1 = 0), 12 (12 % 1 = 0, 12 % 2 == 0), 15 (15 % 1 == 0, 15 % 5 == 0), 22, 24, etc. Note that 13 and 14 should be skipped as 13 % 3 != 0 and 14 % 4 != 0 and so on. 
4. Print all the numbers from the range 1 to 1000 that are perfect squares, i.e. 1, 4, 9, 16, etc. 
5. Print the sum of all the numbers from Task No.4.
6. Print the factorial of a given number ([https://en.wikipedia.org/wiki/Factorial](https://en.wikipedia.org/wiki/Factorial))
7. For a given odd integer number `n` draw an arrowhead on-screen using the `Console.WriteLine()` function like it's shown on the image:

![arrows](https://i.imgur.com/pNQT2Xp.png)

The number `n` represents the number of asterisks in the bottom level of the arrowhead. Your arrowhead will have one asterisk character at the top level, three at the 2nd to top level, five at the 3rd level, and so on, until it reaches the bottom level. After the bottom level you should have three lines with a single asterisk to represent the trunk. Note that your arrowhead is NOT centered on the screen. The left hand side of the base of the tree will line up with the left hand side of the console window.


## Lesson 4 - Arrays

### In Class

1. Arrays, high-level overview.
2. String representations. ASCII vs Unicode.

**Coding**

1. Find the max item of the array
2. Convert a string to lowercase

### Home Assignments

1. Print "True" if the given string is a palindrome (i.e. if it reads the same both left-to-right and right-to-left), "False" otherwise. I.e. for "car" the program should print "False", whereas for "racecar" it should print "True".
2. For a given string, find the number of words in it. I.e. for the string "There are only 10 types of people in the world: those who understand binary and those who don't." the answer should be 18. 
3. Find the second smallest item of the array. You can assume there are no duplicates.
4. For the given arrays `a1` and `a2`, find all the items that belong to both `a1` and `a2`.
