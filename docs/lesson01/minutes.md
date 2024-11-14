---
layout: default
title: Minutes
parent: Lesson 1 - Types, Variables & Conditions
has_children: false
nav_order: 3
---

# Minutes

For a given time of the day and a given number of minutes, add the minutes to the time and print the result

**Example:**

For the given values

``` csharp
int currentHours = 23;
int currentMinutes = 59;
int minutesToAdd = 2;
```

The output should print: `00:01`

**Bonus points:** Try to solve the same problem, but this time consider taking the current time as a string, i.e. 

``` csharp
int currentTime = "23:59";
int minutesToAdd = 2;
```

<details class="text-grey-dk-000"> 
  <summary><strong>Hint 1:</strong></summary>
  Consider converting the current time to number minutes passed since midnight to simplify the calculations.
</details>
