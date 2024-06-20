# AssortedProblems
C# console and libraries for problems asked in a live coding interview or a technical assessment.
## AssortedProblemsConsole
Run the solution and a console will appear. Enter a command according to menu to run the corresponding problem.
## AssortedProblemsTests
An xUnit Test Project for testing libraries in AssortedProblem Solution. A good test suite can help us refactor quicker and in a less stressful manner. TDD (Test Driven Development) can help and force us to design well factored software iteratively, backed by tests to help future work as it arrives.
## CoderbyteConsoleApp
Console app for coderbyte technical assessment or similar.
## Contents
- [FizzBuzz](#fizzbuzz)
- [Palindrome](#palindrome)
- [Palindrome Level](#palindrome-level)
- [Anagram](#anagram)
- [Tree Dictionary: Existance](#tree-dictionary-existance)
- [Tree Dictionary: Print](#tree-dictionary-print)
- [Codeland](#codeland)
- [Find Intersection](#find-intersection)
- [Questions Marks](#questions-marks)
- [Coderbyte](#coderbyte)
  - [First Factorial](#first-factorial)
  - [Longest Word](#longest-word)
  - [Min Window Substring](#min-window-substring)
  - [Tree Constructor](#tree-constructor)
  - [Bracket Matcher](#bracket-matcher)
  - [Bracket Combinations](#bracket-combinations)
  - [Plus Minus](#plus-minus)
  - [Mini-Max Sum](#mini-max-sum)
  - [Time Conversion](#time-conversion)
  - [Lonely Integer](#lonely-integer)
  - [Diagonal Difference](#diagonal-difference)
  - [Counting Sort 1](#counting-sort-1)
  - [Zig Zag Sequence](#zig-zag-sequence)
## FizzBuzz
### Problem
https://www.hackerrank.com/challenges/fizzbuzz/problem</br>
Print each number from 1 to 100 on a new line.</br>
For each multiple of 3, print "Fizz" instead of the number.</br>
For each multiple of 5, print "Buzz" instead of the number.</br>
For numbers which are multiples of both 3 and 5, print "FizzBuzz" instead of the number. </br>
### Solution
Implemented in FizzBuzz library and is called by the console app.
### Testing
Tested by FizzBuzzUnitTest in the xUnit Test Project.
## Palindrome
A word, verse, or sentence (such as "Able was I ere I saw Elba") or a number (such as 1881) that reads the same backward or forward (Merriam-Webster). It ignores spaces and punctuation marks. Empty string is a palindrome.
### Problem
Determine whether the input is a palindrome or not. Implement both case sensitive and case insensitive. Assume there is no punctuation mark from the input.
### Solution
Implemented in Palindrome library and is called by the console app.
### Testing
Tested by PalindromeUnitTest in the xUnit Test Project.
## Palindrome Level
### Problem
Calculate the palindrome level of the input (case insensitive).</br>
1. Example "dam madam mad":
  - dammadammad: a palindrome, count 1
  - dammad: a palindrome, count 2
  - dam: not a palindrome
  - Thus, "dam madam mad" is palindrome level 2.
2. Second Example "tattattattat":
  - tattattattat: a palindrome, count 1
  - tattat: a palindrome, count 2
  - tat: a palindrome, count 3
  - ta: not a palindrome
  - Thus, "tattattattat" is palindrome level 3.
3. Third Example "ab":
  - ab: not a palindrome
  - Thus, "ab" is palindrome level 0.</br>
4. Notes:
- No need to check the next ones if the current one is not a palindrome
- If the number of characters is odd but not one, the next one checked is the first half + 1
- If the number of characters is even, the next one checked is the first half
- If the number of character is one, the next one checked is empty string
### Solution
Implemented in Palindrome library and is called by the console app.
### Testing
Tested by PalindromeUnitTest in the xUnit Test Project.
## Anagram
An anagram is a word or phrase formed by rearranging the letters of a different word or phrase. (Wikipedia)
### Problem
Determine whether the two inputs are anagrams (case sensitive).
### Solution
Implemented in Anagram library and is called by the console app.
### Testing
Tested by AnagramUnitTest in the xUnit Test Project.
## Tree Dictionary: Existance
Tree dictionary stores collection of words in a form of tree.
1. First Example</br>
This tree dictionary stores words "add", "all", and "aztec" in a form of tree.
```
a - d - d
    |
    l - l
    |
    z - t - e - c
```
2. Second Example</br>
This tree dictionary stores words "add", "ally", "alter", "code", "debug", and "decode" in a form of tree.
```
a - d - d
|   |
|   l - l - y
|       |
|       t - e - r
|
c - o - d - e
|
d - e - b - u - g
        |
        c - o - d - e
```
Notice that by adding "ally" to dictionary tree, the word "all" is automatically included. This is also true for substrings of those 6 words starting with index 0.</br>
Also notice that the word "ac" is not included in the tree dictionary.
### Problem
Create a function to find whether a string exists in a tree dictionary. Assume there would be at least one character in tree dictionary. Assume only lowercase characters are used.
### Solution
Implemented in TreeDictionary library.
### Testing
Tested by TreeDictionaryUnitTest in the xUnit Test Project.
## Tree Dictionary: Print
### Problem
Make a function to return the string of a tree dictionary like shown in Tree Dictionary: Existance problem. It is recommended to use string builder.
### Solution
Implemented in TreeDictionary library.
### Testing
Tested by TreeDictionaryUnitTest in the xUnit Test Project.
## Codeland
https://coderbyte.com/editor/Codeland%20Username%20Validation:Csharp
### Problem
Create username validation according to the following rules:
1. The username is between 4 and 25 characters.
2. It must start with a letter.
3. It can only contain letters, numbers, and the underscore character.
4. It cannot end with an underscore character.
### Solution
Implemented in Codeland library.
### Testing
Tested by CodelandUnitTest in the xUnit Test Project.
## Find Intersection
https://coderbyte.com/information/Find%20Intersection
### Problem
Find intersection within an array of number strings. Open coderbyte page for details.
### Solution
Implemented in Intersection library.
### Testing
Tested by IntersectionUnitTest in the xUnit Test Project.
## Questions Marks
https://coderbyte.com/editor/Questions%20Marks:Csharp
### Solution
Implemented in QuestionsMarks library.
### Testing
Tested by QuestionsMarksUnitTest in the xUnit Test Project.
## Coderbyte
Use `git checkout {commit hash}` to open related challenge. Code is located in CoderbyteConsoleApp/Program.cs Use `git checkout master` to return.
### First Factorial
https://coderbyte.com/information/First%20Factorial

`git checkout a4e1f39ebc323681af7ea4d7853485dbe6d79c9f`
### Longest Word
https://coderbyte.com/information/Longest%20Word

`git checkout b214b1602fd713377793178f0d1f834c18d7c852`
### Min Window Substring
https://coderbyte.com/information/Min%20Window%20Substring

`git checkout 3c14c6068f63a1f3358e430a5901c0e98f2148a6`
### Tree Constructor
https://coderbyte.com/information/Tree%20Constructor

`git checkout a459715d113e3d412a680e9b405b8583cb7edffe`
### Bracket Matcher
https://coderbyte.com/information/Bracket%20Matcher

`git checkout 0eabd0c37a557498fde47e89a95fb0858f1a7e2c`
### Bracket Combinations
https://coderbyte.com/information/Bracket%20Combinations

`git checkout f77e26f79dcb62a6ca31a8e985b8e5ba4840e24a`
### Plus Minus
https://www.hackerrank.com/challenges/one-week-preparation-kit-plus-minus/problem

`git checkout e382716943a5c7b8e64446b9b644e0c6913ea7d7`
### Mini-Max Sum
https://www.hackerrank.com/challenges/one-week-preparation-kit-mini-max-sum/problem

`git checkout 375c53ed96ab4c1d2b3e12ae5afa861cc767a320`
### Time Conversion
https://www.hackerrank.com/challenges/one-week-preparation-kit-time-conversion/problem

`git checkout 4b9a7c01ac922942f8a8310ea20e660c2359fc32`
### Lonely Integer
https://www.hackerrank.com/challenges/one-week-preparation-kit-lonely-integer/problem

`git checkout 61ae226403864cdf018bff2ca792ea4fae8fee77`
### Diagonal Difference
https://www.hackerrank.com/challenges/one-week-preparation-kit-diagonal-difference/problem

`git checkout 20ff199efff9a4d61a8447bf2e93c05db161620c`
### Counting Sort 1
https://www.hackerrank.com/challenges/one-week-preparation-kit-countingsort1/problem

`git checkout 3ebaa1536fc419bcf08423278c4a3b0d90726fc4`
### Zig Zag Sequence
https://www.hackerrank.com/challenges/one-week-preparation-kit-zig-zag-sequence/problem

`git checkout 5a6c531c5c01d37dd92b483a132d15c47438b3e9`