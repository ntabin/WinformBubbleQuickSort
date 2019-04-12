/*
 * Created by SharpDevelop.
 * User: PC-USER
 * Date: 3/26/2019
 * Time: 8:47 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Windows.Forms;
namespace SortingProgram
{
	/// <summary>
	/// Description of SortController.
	/// </summary>
	public class SortController
	{
		public SortController()
		{
		}
		
		public static void MainSortingProgramView() {
			Application.Run(new MainForm());
		}
		
		public static string sortTextByStrategy(SortModel sortModel) {
			return sortModel.sort();
		}
	}
}
