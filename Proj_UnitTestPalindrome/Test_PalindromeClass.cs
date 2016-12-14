using NUnit.Framework;
using System;
namespace Palindrome_Anagram
{
	[TestFixture()]
	public class Test_PalindromeClass
	{
		[TestCase("anna", Result=true)]
		[TestCase("aaaaaaaa", Result = true)]
		[TestCase("aaaaaaaab", Result = false)]
		[TestCase("caaaaaaaab", Result = false)]
		[TestCase("donotbobtonod", Result = true)]
		[TestCase("owefhijpfwai", Result = false)]
		[TestCase("igdedgide", Result = false)]
		public bool is_PalindromeTest(String s)
		{
			PalindromeClass cls_palindrome = new PalindromeClass();
			return cls_palindrome.is_palindrome(s);
		}

		[TestCase("anna", Result = true)]
		[TestCase("aaaaaaaa", Result = true)]
		[TestCase("aaaaaaaab", Result = true)]
		[TestCase("caaaaaaaab", Result = false)]
		[TestCase("donotbobtonod", Result = true)]
		[TestCase("owefhijpfwai", Result = false)]
		[TestCase("igdedgide", Result = true)]
		public bool is_AnagramTest(String s)
		{
			PalindromeClass cls_palindrome = new PalindromeClass();
			return cls_palindrome.is_anagram(s);
		}

		[TestCase("anna", Result = true)]
		[TestCase("aaaaaaaa", Result = true)]
		[TestCase("aaaaaaaab", Result = true)]
		[TestCase("caaaaaaaab", Result = false)]
		[TestCase("donotbobtonod", Result = true)]
		[TestCase("owefhijpfwai", Result = false)]
		[TestCase("igdedgide", Result = true)]
		public bool is_Palindrom_or_AnagramTest(String s)
		{
			PalindromeClass cls_palindrome = new PalindromeClass();
			return cls_palindrome.is_palindrome(s) || cls_palindrome.is_anagram(s);
		}

		[TestCase("anna", Result = true)]
		[TestCase("aaaaaaaa", Result = true)]
		[TestCase("aaaaaaaab", Result = false)]
		[TestCase("caaaaaaaab", Result = false)]
		[TestCase("donotbobtonod", Result = true)]
		[TestCase("owefhijpfwai", Result = false)]
		[TestCase("igdedgide", Result = false)]
		public bool is_Palindrom_and_AnagramTest(String s)
		{
			PalindromeClass cls_palindrome = new PalindromeClass();
			return cls_palindrome.is_palindrome(s) && cls_palindrome.is_anagram(s);
		}
	}
}