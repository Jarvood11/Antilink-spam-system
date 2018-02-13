namespace SpamFilterSample
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.txtOut = new System.Windows.Forms.RichTextBox();
			this.btnLoad = new System.Windows.Forms.Button();
			this.btnTest1 = new System.Windows.Forms.Button();
			this.btnTest2 = new System.Windows.Forms.Button();
			this.btnTest3 = new System.Windows.Forms.Button();
			this.btnTestBox = new System.Windows.Forms.Button();
			this.btnToFile = new System.Windows.Forms.Button();
			this.btnFromFile = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txtOut
			// 
			this.txtOut.Location = new System.Drawing.Point(12, 12);
			this.txtOut.Name = "txtOut";
			this.txtOut.Size = new System.Drawing.Size(501, 497);
			this.txtOut.TabIndex = 0;
			this.txtOut.Text = "";
			// 
			// btnLoad
			// 
			this.btnLoad.Location = new System.Drawing.Point(519, 10);
			this.btnLoad.Name = "btnLoad";
			this.btnLoad.Size = new System.Drawing.Size(93, 23);
			this.btnLoad.TabIndex = 1;
			this.btnLoad.Text = "Load TestData";
			this.btnLoad.UseVisualStyleBackColor = true;
			this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
			// 
			// btnTest1
			// 
			this.btnTest1.Location = new System.Drawing.Point(520, 40);
			this.btnTest1.Name = "btnTest1";
			this.btnTest1.Size = new System.Drawing.Size(93, 23);
			this.btnTest1.TabIndex = 2;
			this.btnTest1.Text = "Test msg1";
			this.btnTest1.UseVisualStyleBackColor = true;
			this.btnTest1.Click += new System.EventHandler(this.btnTest1_Click);
			// 
			// btnTest2
			// 
			this.btnTest2.Location = new System.Drawing.Point(520, 69);
			this.btnTest2.Name = "btnTest2";
			this.btnTest2.Size = new System.Drawing.Size(93, 23);
			this.btnTest2.TabIndex = 3;
			this.btnTest2.Text = "Test msg2";
			this.btnTest2.UseVisualStyleBackColor = true;
			this.btnTest2.Click += new System.EventHandler(this.btnTest2_Click);
			// 
			// btnTest3
			// 
			this.btnTest3.Location = new System.Drawing.Point(520, 99);
			this.btnTest3.Name = "btnTest3";
			this.btnTest3.Size = new System.Drawing.Size(93, 23);
			this.btnTest3.TabIndex = 4;
			this.btnTest3.Text = "Test msg3";
			this.btnTest3.UseVisualStyleBackColor = true;
			this.btnTest3.Click += new System.EventHandler(this.btnTest3_Click);
			// 
			// btnTestBox
			// 
			this.btnTestBox.Location = new System.Drawing.Point(520, 129);
			this.btnTestBox.Name = "btnTestBox";
			this.btnTestBox.Size = new System.Drawing.Size(93, 23);
			this.btnTestBox.TabIndex = 5;
			this.btnTestBox.Text = "Test Box Text";
			this.btnTestBox.UseVisualStyleBackColor = true;
			this.btnTestBox.Click += new System.EventHandler(this.btnTestBox_Click);
			// 
			// btnToFile
			// 
			this.btnToFile.Location = new System.Drawing.Point(519, 171);
			this.btnToFile.Name = "btnToFile";
			this.btnToFile.Size = new System.Drawing.Size(93, 23);
			this.btnToFile.TabIndex = 6;
			this.btnToFile.Text = ".ToFile()";
			this.btnToFile.UseVisualStyleBackColor = true;
			this.btnToFile.Click += new System.EventHandler(this.btnToFile_Click);
			// 
			// btnFromFile
			// 
			this.btnFromFile.Location = new System.Drawing.Point(520, 201);
			this.btnFromFile.Name = "btnFromFile";
			this.btnFromFile.Size = new System.Drawing.Size(93, 23);
			this.btnFromFile.TabIndex = 7;
			this.btnFromFile.Text = ".FromFile()";
			this.btnFromFile.UseVisualStyleBackColor = true;
			this.btnFromFile.Click += new System.EventHandler(this.btnFromFile_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(624, 521);
			this.Controls.Add(this.btnFromFile);
			this.Controls.Add(this.btnToFile);
			this.Controls.Add(this.btnTestBox);
			this.Controls.Add(this.btnTest3);
			this.Controls.Add(this.btnTest2);
			this.Controls.Add(this.btnTest1);
			this.Controls.Add(this.btnLoad);
			this.Controls.Add(this.txtOut);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.RichTextBox txtOut;
		private System.Windows.Forms.Button btnLoad;
		private System.Windows.Forms.Button btnTest1;
		private System.Windows.Forms.Button btnTest2;
		private System.Windows.Forms.Button btnTest3;
		private System.Windows.Forms.Button btnTestBox;
		private System.Windows.Forms.Button btnToFile;
		private System.Windows.Forms.Button btnFromFile;
	}
}

