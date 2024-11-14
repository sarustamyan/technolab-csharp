---
layout: default
title: Morse Code
parent: Lesson 6 - Arrays (Practice)
has_children: false
nav_order: 3
---

# Morse Code

Encode a given string consisting of lowercase letters and spaces into a [Morse code](https://en.wikipedia.org/wiki/Morse_code) using the following convention:

* `.` - dit (short mark)
* `-` - dah (long mark)
* "&nbsp;" (1 space)- short gap (between letters)
* "&nbsp;&nbsp;&nbsp;" (3 spaces) - medium gap (between words)

E.g. for the following input text: `what hath god wrought` the ouput should be: 

".−−&nbsp;....&nbsp;.−&nbsp;−&nbsp;&nbsp;&nbsp;....&nbsp;.−&nbsp;−&nbsp;....&nbsp;&nbsp;&nbsp;−−.&nbsp;−−−&nbsp;−..&nbsp;&nbsp;&nbsp;.−−&nbsp;.−.&nbsp;−−−&nbsp;..−&nbsp;−−.&nbsp;....&nbsp;−&nbsp;"

**\*\* Bonus Points:** Write a program to decode a string in Morse code back to plain text. (Use the [string.Split()](https://www.programiz.com/csharp-programming/library/string/split) method to split the encoded string into chunks). 