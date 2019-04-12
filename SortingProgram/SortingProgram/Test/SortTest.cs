/*
 * Created by SharpDevelop.
 * User: HP
 * Date: 27/03/2019
 * Time: 5:08 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using NUnit.Framework;
using SortingProgram.Sorts;
namespace SortingProgram
{
	[TestFixture]
	public class SortTest
	{
		[Test]
		public void BubbleSortTest()
		{
			string inputText = "befdac";
			ISort sortingStrat = new Bubble();
			string outputText = sortingStrat.Sort(inputText);
			Assert.IsTrue(outputText == "abcdef");
		}
		
		[Test]
		public void QuickSortTest()
		{
			string inputText = "befdac";
			ISort sortingStrat = new Quick();
			string outputText = sortingStrat.Sort(inputText);
			Assert.IsTrue(outputText == "abcdef");
		}
		
	}
}
