---
layout: default
title: Caesar Cipher
parent: Lesson 6 - Arrays (Practice)
has_children: false
nav_order: 1
---

# Caesar Cipher

For a given string `text` consisting of lowercase english letters and integer `shift` print the encoded string using the [Ceasar Cipher](https://en.wikipedia.org/wiki/Caesar_cipher). I.e. replace each plaintext letter with the one that is `shift` number of places down the alphabet.

E.g. for the following inputs:

``` csharp
var text = "attackatonce";
var shift = 3;
```

The program should ouput `xqqxzhxqlkzb`