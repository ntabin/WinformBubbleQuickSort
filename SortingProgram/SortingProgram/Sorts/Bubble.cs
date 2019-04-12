/*
 * Created by SharpDevelop.
 * User: HP
 * Date: 26/03/2019
 * Time: 4:19 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace SortingProgram.Sorts
{
	public class Bubble : ISort
	{
		public string Sort(string stringToSort) {
			char[] charactersToSort = stringToSort.ToCharArray();
			for (int i = 0; i < charactersToSort.Length - 1; i++) {
				for (int j = 0; j < charactersToSort.Length - i - 1; j++) {
					if (charactersToSort[j] > charactersToSort[j + 1]) 
                	{ 
                    	char temp = charactersToSort[j]; 
                    	charactersToSort[j] = charactersToSort[j + 1]; 
                    	charactersToSort[j + 1] = temp; 
                	} 
				}
			}
			return new string(charactersToSort);
		}
	}
}
