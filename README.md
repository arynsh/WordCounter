# Word Counter

#### A program that counts the number of times the user inputted word appears in a (user) given sentence.

#### By Sharon Lee

## Description

This program will take two inputs from the user: a single word and a sentence. The program will count how many times the word appears in the sentence. It will not count partial matches (cat must appear as "cat" and not "catharsis").

## Setup/Installation Requirements

* To install, clone the project using Git and open it in your choice of Integrated Development Environment (IDE). Navagate into the project directory (WordCounter.Solution) and type 'dotnet run".

## Known Bugs

There should be no known bugs as of now.

## Support and contact details

Please do not hesitate to contact me for whatever reason! I can be reached at sharonlee714@gmail.com !

## Technologies Used

The program was created using C# and tested using MSTest.

### License

Copyright (c) 2019 Sharon Lee

## Specs

1. The program will take in the user inputted word and sentence and turn the string into lowercase letters.

  Inputted word: I 
  Inputted Sentence: I am

  Lowercase word: i
  Lowercase sentence: i am

  "I" and "I am" was chosen as inputs due to to fact that they are rather short words (one and two letters long).

2. The program will take in the user inputted word and sentence and if the word does not appear in the sentence, it will return 0.

  Inputted word: I
  Inputted Sentence: I'm hungry
  Output: 0

These inputs were chosen because "I" does appear in "I'm" hungry, but the program should know to handle "I" and "I'm" differently.

3. The program will take in the user inputted word and sentence and count how many times the word appears in the sentence.

  Inputted word: Green
  Inputted Sentence: Look at the green birds hiding in the green leaves on that greenery
  Output: 2

  Inputted word: Mango
  Inputted Sentence: what kinds of fruits do you like to eat
  Output: 0

  The first set of inputs were chosen because "Greenery" contains the word "green", but the program should not count greenery in the total result. The second set was chosen because mango does not appear in the sentence.

4. Program will not count if the word appears as part of another word.
   Inputted word: I
   Inputted sentence: ponch really likes sweet potatoes
   Output: 0

   The set of input was chosen because "I" is a common and simple word and the program should know not to count it, even if it appears in a word.
