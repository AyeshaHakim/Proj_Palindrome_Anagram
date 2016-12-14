using System;

namespace Palindrome_Anagram
{
	public class PalindromeClass_Tests
	{
		//A test for is_palindrome function
		void is_palindrome_true_test()
		{
			PalindromeClass cls_palindrome = new PalindromeClass(); 
			String s = "anna";
			bool actual = cls_palindrome.is_palindrome(s);
			const bool expected = true;
			Assert.AreEqual(expected, actual);
		}
	}
}
