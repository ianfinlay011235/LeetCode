using System;
using LeetCodeSolutionLibrary.Sets;
using Xunit;

namespace LeetCodeSolutionLibrary.Tests.Sets
{
	public class LongestPalindromeTests
	{
		[Theory]
        [InlineData(7, "abccccdd")]
        [InlineData(1, "a")]
        [InlineData(983, "civilwartestingwhetherthatnaptionoranynartionsoconceivedandsodedicatedcanlongendureWeareqmetonagreatbattlefiemldoftzhatwarWehavecometodedicpateaportionofthatfieldasafinalrestingplaceforthosewhoheregavetheirlivesthatthatnationmightliveItisaltogetherfangandproperthatweshoulddothisButinalargersensewecannotdedicatewecannotconsecratewecannothallowthisgroundThebravelmenlivinganddeadwhostruggledherehaveconsecrateditfaraboveourpoorponwertoaddordetractTgheworldadswfilllittlenotlenorlongrememberwhatwesayherebutitcanneverforgetwhattheydidhereItisforusthelivingrathertobededicatedheretotheulnfinishedworkwhichtheywhofoughtherehavethusfarsonoblyadvancedItisratherforustobeherededicatedtothegreattdafskremainingbeforeusthatfromthesehonoreddeadwetakeincreaseddevotiontothatcauseforwhichtheygavethelastpfullmeasureofdevotionthatweherehighlyresolvethatthesedeadshallnothavediedinvainthatthisnationunsderGodshallhaveanewbirthoffreedomandthatgovernmentofthepeoplebythepeopleforthepeopleshallnotperishfromtheearth")]
		public void LongestPalindrome_ShouldReturnExpectedValue(int expected, string s)
		{
			//Arrange
			LongestPalindrome solution = new LongestPalindrome();
			int actual;
			
			//Act
			 actual = solution.Longest(s);
			
			//Assert
			Assert.Equal(expected, actual);
		}
	}
}