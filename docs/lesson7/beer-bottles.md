---
layout: default
title: Beer and Bottles
parent: Lesson 7 - Recursion
has_children: false
nav_order: 2
---

# Beer and Bottles

The price of a bottle of beer is $3. You can return an empty bottle and get $1 in return. Assuming you have $n (n is a positive integer), calculate the total number of bottles you can drink.

Example: for n = 15 the answer is 7 = 5 + 1 + 1, i.e.

1. **Buy 5 bottles** with the initial amount, i.e. 15 / 3 = 5
2. Exchange 5 empty bottles and get $5 back
3. **Buy 1 bottle**, you'll end up having 1 empty bottle + $2 left from step 2
4. Exchange the empty bottle, so now you have 3$
5. **Buy 1 bottle**.