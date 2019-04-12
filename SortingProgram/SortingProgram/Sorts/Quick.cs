/*
 * Created by SharpDevelop.
 * User: HP
 * Date: 26/03/2019
 * Time: 4:20 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace SortingProgram.Sorts
{
	/// <summary>
	/// Description of Quick.
	/// </summary>
	public class Quick: ISort
	{
		public string Sort(string stringToSort) {
			char[] charactersToSort = stringToSort.ToCharArray();
			int low = 0;
			int high = charactersToSort.Length - 1;
			quickSort(charactersToSort, low, high); 
			return new string(charactersToSort);
		}
		
		static int partition(char []arr, int low, int high) 
    	{ 
        	int pivot = arr[high];  
          
        	// index of smaller element 
        	int i = (low - 1);  
        	for (int j = low; j < high; j++) 
        	{ 
            	// If current element is smaller  
            	// than or equal to pivot 
            	if (arr[j] <= pivot) 
            	{ 
                	i++; 
  
                	// swap arr[i] and arr[j] 
                	char temp = arr[i]; 
                	arr[i] = arr[j]; 
                	arr[j] = temp; 
            	} 
        	} 
  
        	// swap arr[i+1] and arr[high] (or pivot) 
        	char temp1 = arr[i+1]; 
        	arr[i+1] = arr[high]; 
        	arr[high] = temp1; 
  
        	return i+1; 
    	} 
		
		static void quickSort(char []arr, int low, int high) 
    	{ 
        	if (low < high) 
        	{ 
            	/* pi is partitioning index, arr[pi] is  
            	now at right place */
            	int pi = partition(arr, low, high); 
  
            	// Recursively sort elements before 
            	// partition and after partition 
            	quickSort(arr, low, pi-1); 
            	quickSort(arr, pi+1, high); 
        	} 
    	} 
		
		
		
		
		
		
		
		
		
	}
}
