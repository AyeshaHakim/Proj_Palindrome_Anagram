# AYESHA HAKIM - LIC Coding Test Solution Submitted on 14-12-2016

The solution contains two projects: Proj_Palindrome_Anagram and Proj_UnitTestPalindrome

***************************************************************************************************************
The first project "Proj_Palindrome_Anagram" contains two class files: Program.cs and PalindromeClass.cs

Program.cs contains class 'MainClass' and PalindromeClass contains class 'PalindromeClass'.

Main Class is the entry point that invites user to enter a valid string, gives instructions, 
instantiate PalindromeClass and calls its three function taking string as parameter and return a boolean.

is_invalidString: checks whether the entered string is valid based on the given assumptions.

is_palindrome: checks whether the enetered string is a palindrome.

is_anagram: checks whether the enetered string is an anagram of a palindrome.

The function also checks is the string is neither a palindrome, not an anagram and display the message.

All three functions are protected by try catch block to avoid any exception.

The functions are called under a loop continuously asking for input from user unless the key 'n' is pressed.

******************************************************************************************************************

The second project "Proj_UnitTestPalindrome" contains one class file: Test_PalindromeClass.cs

Test_PalindromeClass contains one class Test_PalindromeClass that contains four unit test functions:

is_PalindromeTest: test whether the given string is a palindrome

is_AnagramTest: test whether the given string is a anagram

is_Palindrom_or_AnagramTest: test whether the given string is a palindrome or anagram

is_Palindrom_and_AnagramTest: test whether the given string is both a palindrome and an anagram

The solution also includes screen shots of the result of these automated tests showing that it passed all 28 tests successfully. It means these functions are behaving as expected.
