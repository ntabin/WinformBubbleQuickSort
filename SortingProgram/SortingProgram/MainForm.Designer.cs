/*
 * Created by SharpDevelop.
 * User: HP
 * Date: 26/03/2019
 * Time: 4:16 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace SortingProgram
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button btnSort;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox tbInput;
		private System.Windows.Forms.TextBox tbOutput;
		private System.Windows.Forms.ComboBox cmbStrategy;
		private System.Windows.Forms.Label label4;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnSort = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.tbInput = new System.Windows.Forms.TextBox();
			this.tbOutput = new System.Windows.Forms.TextBox();
			this.cmbStrategy = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnSort
			// 
			this.btnSort.Location = new System.Drawing.Point(245, 98);
			this.btnSort.Name = "btnSort";
			this.btnSort.Size = new System.Drawing.Size(167, 23);
			this.btnSort.TabIndex = 0;
			this.btnSort.Text = "Sort Text";
			this.btnSort.UseVisualStyleBackColor = true;
			this.btnSort.Click += new System.EventHandler(this.BtnSortClick);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(13, 42);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "Input Text";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(13, 69);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "Strategy";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(13, 122);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 3;
			this.label3.Text = "Sorted Text";
			// 
			// tbInput
			// 
			this.tbInput.Location = new System.Drawing.Point(98, 42);
			this.tbInput.Name = "tbInput";
			this.tbInput.Size = new System.Drawing.Size(314, 22);
			this.tbInput.TabIndex = 4;
			this.tbInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbInputKeyPress);
			// 
			// tbOutput
			// 
			this.tbOutput.Location = new System.Drawing.Point(98, 123);
			this.tbOutput.Name = "tbOutput";
			this.tbOutput.Size = new System.Drawing.Size(319, 22);
			this.tbOutput.TabIndex = 5;
			// 
			// cmbStrategy
			// 
			this.cmbStrategy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbStrategy.FormattingEnabled = true;
			this.cmbStrategy.Location = new System.Drawing.Point(98, 68);
			this.cmbStrategy.Name = "cmbStrategy";
			this.cmbStrategy.Size = new System.Drawing.Size(314, 24);
			this.cmbStrategy.TabIndex = 6;
			this.cmbStrategy.SelectedIndexChanged += new System.EventHandler(this.CmbStrategySelectedIndexChanged);
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
			this.label4.Location = new System.Drawing.Point(13, 16);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(249, 23);
			this.label4.TabIndex = 7;
			this.label4.Text = "Input in text to sort string";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(424, 171);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.cmbStrategy);
			this.Controls.Add(this.tbOutput);
			this.Controls.Add(this.tbInput);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnSort);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "SortingProgram";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
