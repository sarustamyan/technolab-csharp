---
layout: default
title: Paging
parent: Lesson 5 - Arrays
has_children: false
nav_order: 6
---

# Paging

For a given array of integers, the page size and 1-based page index, print the items of that page.

**Example:**

``` csharp
int[] items = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };
int pageSize = 5;
int pageIndex = 2;
```

The output should print: `6, 7, 8, 9, 10`

<details class="text-grey-dk-000"> 
  <summary><strong>Hint 1:</strong></summary>
  Try to cover all the edge cases. What if in the example above the `pageIndex` was `3`? What if it was `5`?
</details>
