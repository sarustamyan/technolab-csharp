---
layout: default
title: Collatz Conjecture
parent: Lesson 3 - Loops
has_children: false
nav_order: 4
---

# Collatz Conjecture

Consider the following operation on an arbitrary positive integer:

* If the number is even, divide it by two.
* If the number is odd, triple it and add one.

Keep applying the same operation on the result. The [Collatz conjecture](https://en.wikipedia.org/wiki/Collatz_conjecture) is: ***This process will eventually reach the number 1, regardless of which positive integer is chosen initially***. (A nice video with more details: [https://www.youtube.com/watch?v=094y1Z2wpJg](https://www.youtube.com/watch?v=094y1Z2wpJg))

Now, the task is to print the Collatz sequence for a given number `n`.

**Example:** For `n = 12` and the sequence will be **6**, **3**, **10**, **5**, **16**, **8**, **4**, **2**, **1**.

<details class="text-grey-dk-000"> 
  <summary><strong>Hint 1:</strong></summary>
  Since the number of steps is not known upfront, the <code class="language-plaintext highlighter-rouge">while</code> loop is better suited for the task.
</details>
