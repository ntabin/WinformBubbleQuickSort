/*
 * Created by SharpDevelop.
 * User: PC-USER
 * Date: 3/26/2019
 * Time: 8:47 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using SortingProgram.Sorts;
using System.Collections.Generic;
namespace SortingProgram
{
	/// <summary>
	/// Description of SortModel.
	/// </summary>
	public class SortModel
	{
		public string inputText;
		public MainForm.SortStrategy sortStrategy;
		public string sort() {
			Sorts.ISort sortingStrat;
			if(sortStrategy == MainForm.SortStrategy.Bubble) 
			{
				sortingStrat = new Bubble();
			} else 
			{
				sortingStrat = new Quick();
			}
			return sortingStrat.Sort(inputText);
		}
		
		public List<string> validate() {
			List<string> errors = new List<string>();
			if(string.IsNullOrWhiteSpace(inputText))
			{
				errors.Add("Input text cannot be empty");
			   	
			}
			return errors;
		}
	}
}
