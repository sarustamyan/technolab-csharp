---
layout: default
title: Rabbits And Foxes
parent: Lesson 4 - Loops (Practice)
has_children: false
nav_order: 2
---

# Rabbits & Foxes

The task is to calculate the populations of foxes and rabbits who live within a certain area of land, as that number changes from year to year. The rabbit and fox populations are controlled by the following formulas:

`rabbitsNext = rabbitsPrev + (int)Math.Round(rabbitsPrev * rabbitBirthRate) - (int)Math.Round(rabbitsPrev * foxesPrev * foxKillRate)`

`foxesNext = foxesPrev + (int)Math.Round(foxesPrev * rabbitsPrev * foxBirthRate) - (int)Math.Round(foxesPrev * foxDeathRate)`

where

* *`rabbitsNext` is the rabbit population for the next year*
* *`rabbitsPrev` is the rabbit population of the previous year*
* *`rabbitBirthRate` is the birth rate of rabbits*
* *`foxKillRate` is the death rate of rabbits, dependent on # of foxes*
* *`foxesNext` is the fox population for the next year*
* *`foxesPrev` is the fox population of the previous year*
* *`foxBirthRate` is the birth rate of foxes, dependent on # of rabbits*
* *`foxDeathRate` death rate of foxes, caused naturally*

The task is for the given initial populations and growth parameters and number of years, calculate the year-by-year changes. 

**Note:** Since the fox and rabbit populations should be integers, so you will have convert the result of the calculation to `int`.

Example: for the following input values:

``` csharp
int rabbits = 100;
double rabbitBirthRate = 0.2;
double foxKillRate = 0.005;
int foxes = 10;
double foxBirthRate = 0.001;
double foxDeathRate = 0.2;
```

the output should look like this:

```
Year 0. Rabbits: 100, Foxes: 10
Year 1. Rabbits: 115, Foxes: 9
Year 2. Rabbits: 133, Foxes: 8
Year 3. Rabbits: 155, Foxes: 7
Year 4. Rabbits: 181, Foxes: 7
Year 5. Rabbits: 211, Foxes: 7
Year 6. Rabbits: 246, Foxes: 7
Year 7. Rabbits: 286, Foxes: 8
Year 8. Rabbits: 332, Foxes: 8
Year 9. Rabbits: 385, Foxes: 9
Year 10. Rabbits: 445, Foxes: 10
```

What happens when you increase the number of years?

<details class="text-grey-dk-000"> 
  <summary><strong>Hint 1:</strong></summary>
  Be sure that your program doesn’t allow for negative populations. If you start with 1 rabbit and 1000 foxes, the next year there should be 0 rabbits instead of -3 rabbits.
</details>
