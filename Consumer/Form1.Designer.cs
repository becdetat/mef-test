namespace Consumer
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
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.label1 = new System.Windows.Forms.Label();
			this.GetNameTextBox = new System.Windows.Forms.TextBox();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.HelloWorld = new System.Windows.Forms.Button();
			this.GoodbyeCruelWorld = new System.Windows.Forms.Button();
			this.tableLayoutPanel1.SuspendLayout();
			this.flowLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.GetNameTextBox, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 1);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(208, 95);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label1.Location = new System.Drawing.Point(3, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(35, 26);
			this.label1.TabIndex = 0;
			this.label1.Text = "Name";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// GetNameTextBox
			// 
			this.GetNameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.GetNameTextBox.Location = new System.Drawing.Point(44, 3);
			this.GetNameTextBox.Name = "GetNameTextBox";
			this.GetNameTextBox.Size = new System.Drawing.Size(161, 20);
			this.GetNameTextBox.TabIndex = 1;
			this.GetNameTextBox.Text = "Batman";
			this.GetNameTextBox.TextChanged += new System.EventHandler(this.GetNameTextBox_TextChanged);
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.AutoSize = true;
			this.flowLayoutPanel1.Controls.Add(this.HelloWorld);
			this.flowLayoutPanel1.Controls.Add(this.GoodbyeCruelWorld);
			this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(44, 29);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.flowLayoutPanel1.Size = new System.Drawing.Size(161, 63);
			this.flowLayoutPanel1.TabIndex = 5;
			// 
			// HelloWorld
			// 
			this.HelloWorld.Location = new System.Drawing.Point(74, 3);
			this.HelloWorld.Name = "HelloWorld";
			this.HelloWorld.Size = new System.Drawing.Size(84, 23);
			this.HelloWorld.TabIndex = 2;
			this.HelloWorld.Text = "Say Hello";
			this.HelloWorld.UseVisualStyleBackColor = true;
			this.HelloWorld.Click += new System.EventHandler(this.HelloWorld_Click);
			// 
			// GoodbyeCruelWorld
			// 
			this.GoodbyeCruelWorld.Location = new System.Drawing.Point(74, 32);
			this.GoodbyeCruelWorld.Name = "GoodbyeCruelWorld";
			this.GoodbyeCruelWorld.Size = new System.Drawing.Size(84, 23);
			this.GoodbyeCruelWorld.TabIndex = 3;
			this.GoodbyeCruelWorld.Text = "Say Goodbye";
			this.GoodbyeCruelWorld.UseVisualStyleBackColor = true;
			this.GoodbyeCruelWorld.Click += new System.EventHandler(this.GoodbyeCruelWorld_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(208, 95);
			this.Controls.Add(this.tableLayoutPanel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form1";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "MEF Plugins";
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.flowLayoutPanel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox GetNameTextBox;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.Button HelloWorld;
		private System.Windows.Forms.Button GoodbyeCruelWorld;
	}
}

