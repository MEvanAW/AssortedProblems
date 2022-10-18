# AssortedProblems
C# Console and Libraries for Problems That Are Commonly Asked in a Live Coding Interview
## AssortedProblemsConsole
Run the solution and a console will appear. Enter a command according to menu to run the corresponding problem.
## AssortedProblemsTests
An xUnit Test Project for testing libraries in AssortedProblem Solution. A good test suite can help us refactor quicker and in a less stressful manner. TDD (Test Driven Development) can help and force us to design well factored software iteratively, backed by tests to help future work as it arrives.
## Contents
- [FizzBuzz](#fizzbuzz)
- [Palindrome](#palindrome)
- [Anagram](#anagram)
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
A word, verse, or sentence (such as "Able was I ere I saw Elba") or a number (such as 1881) that reads the same backward or forward. (Merriam-Webster)
### Problem
Determine whether the input is a palindrome or not. Implement both case sensitive and case insensitive.
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
