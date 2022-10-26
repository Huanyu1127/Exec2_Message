namespace Q1
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
			this.timeAndHilbl = new System.Windows.Forms.Label();
			this.resultbtn = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// timeAndHilbl
			// 
			this.timeAndHilbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.timeAndHilbl.Location = new System.Drawing.Point(80, 63);
			this.timeAndHilbl.Name = "timeAndHilbl";
			this.timeAndHilbl.Size = new System.Drawing.Size(210, 80);
			this.timeAndHilbl.TabIndex = 1;
			this.timeAndHilbl.Text = "timeAndHilbl";
			this.timeAndHilbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// resultbtn
			// 
			this.resultbtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.resultbtn.Location = new System.Drawing.Point(146, 37);
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
			this.ClientSize = new System.Drawing.Size(386, 189);
			this.Controls.Add(this.resultbtn);
			this.Controls.Add(this.timeAndHilbl);
			this.MinimumSize = new System.Drawing.Size(402, 228);
			this.Name = "Form1";
			this.Text = "現在時刻";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label timeAndHilbl;
		private System.Windows.Forms.Button resultbtn;
	}
}

