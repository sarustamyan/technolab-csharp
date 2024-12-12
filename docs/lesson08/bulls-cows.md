---
layout: default
title: Bulls and Cows
parent: Lesson 8 - Methods (Practice)
has_children: false
nav_order: 3
---

# Bulls and Cows

Create a game of [Bulls and Cows](https://en.wikipedia.org/wiki/Bulls_and_cows). The program should pick a 4-digit number (assume no duplicates) which the user should try to guess. Here are the steps:

1. Using the `Random` class generate a 4-digit number, i.e. implement a method having the following signature

    ``` csharp
    int[] PickSecret()
    {
        ...
    }
    ```

1. Write a method that for the given secret number and a guess returns the number of bulls and cows. I.e. the method should look like this:

    ``` csharp
    (int Bulls, int Cows) Guess(int[] secret, int[] guess)
    {
        ...
    }
    ```

1. Implement the game flow in a console application. I.e. the program should ask the user for the guesses until the secret is guessed correctly.

\*\* **Bonus Points:** Think about how you'd implement an algorithm for guessing the secret number and try to implement it. 
