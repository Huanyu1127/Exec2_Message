﻿namespace Q2
{
	partial class Form1
	{
		/// <summary>
		/// 設計工具所需的變數。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清除任何使用中的資源。
		/// </summary>
		/// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 設計工具產生的程式碼

		/// <summary>
		/// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
		/// 這個方法的內容。
		/// </summary>
		private void InitializeComponent()
		{
			this.resultbtn = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// resultbtn
			// 
			this.resultbtn.Location = new System.Drawing.Point(93, 75);
			this.resultbtn.Name = "resultbtn";
			this.resultbtn.Size = new System.Drawing.Size(75, 23);
			this.resultbtn.TabIndex = 0;
			this.resultbtn.Text = "目前時間";
			this.resultbtn.UseVisualStyleBackColor = true;
			this.resultbtn.Click += new System.EventHandler(this.resultbtn_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(269, 184);
			this.Controls.Add(this.resultbtn);
			this.MinimumSize = new System.Drawing.Size(285, 223);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button resultbtn;
	}
}
