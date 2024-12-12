---
layout: default
title: Lesson 2 - Conditions (Practice)
nav_order: 3
has_children: true
has_toc: false
---

## Lesson 2 - Conditions (Practice)

### Objectives

1. Learn how to read and parse user input:

   ``` csharp
   string input = Console.ReadLine();
   int number = int.Parse(input);
   ```

1. Write a [car tax calculator](https://maqsazercum.info/%D5%A3%D5%B8%D6%82%D5%B5%D6%84%D5%A1%D5%B0%D5%A1%D6%80%D5%AF%D5%AB-%D5%B0%D5%A1%D5%B7%D5%BE%D5%AB%D5%B9)

1. Binary arithmetic - [Socratic Method](http://www.garlikov.com/Soc_Meth.html)

1. Some fun with binary arithmetic. What's the output of the statement below?

   ``` csharp
   Console.WriteLine(0.1 + 0.2 == 0.3);
   ```

   ![WAT](https://i.kym-cdn.com/photos/images/original/000/173/576/Wat8.jpg){:width="300px"}   
   
   **Explanation:** [StackOverflow](https://stackoverflow.com/a/618596/1695009)
   
   **\*\*\* Side Quest:** Read about how `double` and `decimal` types are stored in binary: [Binary floating point and .NET](https://csharpindepth.com/Articles/FloatingPoint) and [Decimal floating point in .NET](https://csharpindepth.com/Articles/Decimal)

### Home Assignments

1. [401k Calculator]({% link lesson02/401k-calculator.md %})

1. [Income Tax Calculator]({% link lesson02/income-tax-calculator.md %})

1. \* [Days in a Month]({% link lesson02/days-in-a-month.md %})