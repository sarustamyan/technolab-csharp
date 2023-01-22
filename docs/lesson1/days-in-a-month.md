---
layout: default
title: Days in a Month
parent: Lesson 1 - Types, Variables & Conditions
has_children: false
nav_order: 2
---

# Days in a Month

Consider the code for printing the number of days in a given month for a given year: [https://github.com/sarustamyan/technolab-csharp-sources/blob/master/Lesson1/Homework/DaysInAMonth/Program.cs](https://github.com/sarustamyan/technolab-csharp-sources/blob/master/Lesson1/Homework/DaysInAMonth/Program.cs)

Is it going to work correctly for any month/year combination? Find the bug in the code and fix it.

**Bonus Points:** Clone the repository the code is in using Git instead of copy-pasting.

<details class="text-grey-dk-000"> 
  <summary><strong>Hint 1:</strong></summary>
  The <code class="language-plaintext highlighter-rouge">year</code> variable is declared but not used. Coincidence? 
</details>

<p/>

<details class="text-grey-dk-000"> 
  <summary><strong>Hint 2:</strong></summary>
  You'll need to find a way to figure out if a given number is divisible by another number. You'll need the <a href="https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/arithmetic-operators#remainder-operator-">remainder operator</a> for that.
</details>

<p/>

<details class="text-grey-dk-000"> 
  <summary><strong>Hint 3:</strong></summary>
  Are you sure we considered all the use cases? Note that it takes Earth 365.2422 days to circle around the sun. 
</details>