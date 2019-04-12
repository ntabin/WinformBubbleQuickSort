/*
 * Created by SharpDevelop.
 * User: HP
 * Date: 26/03/2019
 * Time: 4:16 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using SortingProgram.Sorts;

namespace SortingProgram
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public enum SortStrategy {
			Bubble, Quick
		}
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			this.PopulateStrategy();
			this.tbOutput.ReadOnly = true;
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
	
		}
		
		void BtnSortClick(object sender, EventArgs e)
		{
			SortModel sortModel = new SortModel();
			sortModel.inputText = tbInput.Text;
			sortModel.sortStrategy = (SortStrategy)this.cmbStrategy.SelectedValue;
			List<string> errors = sortModel.validate();
			if(errors.Count > 0) {
				string errorMessage = "";
				foreach(string err in errors) {
					errorMessage = errorMessage + err + ".";
				}
				MessageBox.Show(errorMessage,"Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			
			tbOutput.Text = SortController.sortTextByStrategy(sortModel);
		
			MessageBox.Show("String Sorted","Message",MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
		void CmbStrategySelectedIndexChanged(object sender, EventArgs e)
		{
			var a = this.cmbStrategy.SelectedValue;
		}
		void TbInputKeyPress(object sender, KeyPressEventArgs e)
		{
			
		}
		private void PopulateStrategy() 
		{
			this.cmbStrategy.DataSource =  Enum.GetValues(typeof(SortStrategy));
		}
	}
}
