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

  Inputted word: Hi 
  Inputted Sentence: Hi there

  Lowercase word: hi
  Lowercase sentence: hi there

2 . The program will take in the user inputted sentence and split it into an array of strings.

  Inputted word: How are you doing today
  Inputted Sentence: ["how", "are", "you", "doing", "today"]

3. The program will take in the user inputted word and sentence and check if the word appears in the sentence.

  Inputted word: Hi 
  Inputted Sentence: Hi there
  Output: True

  Inputted word: Hi 
  Inputted Sentence: How are you doing
  Output: False

4. The program will take in the user inputted word and sentence and count how many times the word appears in the sentence.

  Inputted word: Hi 
  Inputted Sentence: Hi there
  Output: 1

  Inputted word: Hi 
  Inputted Sentence: Hi there hi hi
  Output: 3

  Inputted word: Hi 
  Inputted Sentence: How are you doing
  Output: 0

5. Program will not count if the word appears as part of another word.
   Inputted word: hi
   Inputted sentence: we love go hiking
   Output: 0
