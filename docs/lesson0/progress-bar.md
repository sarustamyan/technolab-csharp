---
layout: default
title: Progress Bar
parent: Lesson 0 - Introduction
has_children: false
nav_order: 2
---

# Progress Bar

Simulate a progress bar for a hypothetical task consisting of 20 steps. Take the following code as a starting point: 

``` csharp
Console.CursorVisible = false;
Console.WriteLine("Task in progress...");
Console.BackgroundColor = ConsoleColor.White;
Console.Write(" ");
Thread.Sleep(200);
Console.Write(" ");
```

and make the program output look like this:

![screenshot]({{ site.baseurl }}/assets/lesson0/progress-bar.gif)

<details class="text-grey-dk-000"> 
  <summary><strong>Hint 1:</strong></summary>
  Each step can be represented by a space (" ") character printed in the console with a white background. So you need to print 20 spaces. The line <code class="language-plaintext highlighter-rouge">Console.BackgroundColor = ConsoleColor.White;</code> changes the background  to white. Notice that it doesn't affect the text printed prior to that statement.
</details>

<p/>

<details class="text-grey-dk-000"> 
  <summary><strong>Hint 2:</strong></summary>
  Notice the <code class="language-plaintext highlighter-rouge">Thread.Sleep(200);</code> line above. This is needed to slow down the animation. The <code class="language-plaintext highlighter-rouge">200</code> represents the number of miliseconds to wait until proceeding to the next statement. You can experiment with that number (or remove the line completly) to see how it affects the output.
</details>