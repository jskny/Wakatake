namespace WakatakeManager
{
	partial class Form1
	{
		/// <summary>
		/// 必要なデザイナー変数です。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 使用中のリソースをすべてクリーンアップします。
		/// </summary>
		/// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows フォーム デザイナーで生成されたコード

		/// <summary>
		/// デザイナー サポートに必要なメソッドです。このメソッドの内容を
		/// コード エディターで変更しないでください。
		/// </summary>
		private void InitializeComponent()
		{
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.loadLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutAToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.textBoxQText = new System.Windows.Forms.TextBox();
			this.textBoxQAns = new System.Windows.Forms.TextBox();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.buttonQAdd = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.textBoxOutputXML = new System.Windows.Forms.TextBox();
			this.menuStrip1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileFToolStripMenuItem,
            this.aboutAToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(784, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileFToolStripMenuItem
			// 
			this.fileFToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadLToolStripMenuItem,
            this.saveSToolStripMenuItem,
            this.exitEToolStripMenuItem});
			this.fileFToolStripMenuItem.Name = "fileFToolStripMenuItem";
			this.fileFToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
			this.fileFToolStripMenuItem.Text = "File(&F)";
			// 
			// loadLToolStripMenuItem
			// 
			this.loadLToolStripMenuItem.Name = "loadLToolStripMenuItem";
			this.loadLToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.loadLToolStripMenuItem.Text = "Load(&L)";
			this.loadLToolStripMenuItem.Click += new System.EventHandler(this.loadLToolStripMenuItem_Click);
			// 
			// saveSToolStripMenuItem
			// 
			this.saveSToolStripMenuItem.Name = "saveSToolStripMenuItem";
			this.saveSToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.saveSToolStripMenuItem.Text = "Save(&S)";
			this.saveSToolStripMenuItem.Click += new System.EventHandler(this.saveSToolStripMenuItem_Click);
			// 
			// exitEToolStripMenuItem
			// 
			this.exitEToolStripMenuItem.Name = "exitEToolStripMenuItem";
			this.exitEToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
			this.exitEToolStripMenuItem.Text = "Exit(&E)";
			this.exitEToolStripMenuItem.Click += new System.EventHandler(this.exitEToolStripMenuItem_Click);
			// 
			// aboutAToolStripMenuItem
			// 
			this.aboutAToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutAToolStripMenuItem1});
			this.aboutAToolStripMenuItem.Name = "aboutAToolStripMenuItem";
			this.aboutAToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
			this.aboutAToolStripMenuItem.Text = "Help(&H)";
			// 
			// aboutAToolStripMenuItem1
			// 
			this.aboutAToolStripMenuItem1.Name = "aboutAToolStripMenuItem1";
			this.aboutAToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
			this.aboutAToolStripMenuItem1.Text = "About(&A)";
			this.aboutAToolStripMenuItem1.Click += new System.EventHandler(this.aboutAToolStripMenuItem1_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.buttonQAdd);
			this.groupBox1.Controls.Add(this.checkBox1);
			this.groupBox1.Controls.Add(this.textBoxQAns);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.textBoxQText);
			this.groupBox1.Location = new System.Drawing.Point(13, 28);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(759, 149);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Input Form";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(7, 56);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(29, 12);
			this.label2.TabIndex = 2;
			this.label2.Text = "理由";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(7, 19);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(41, 12);
			this.label1.TabIndex = 1;
			this.label1.Text = "問題文";
			// 
			// textBoxQText
			// 
			this.textBoxQText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBoxQText.Location = new System.Drawing.Point(6, 34);
			this.textBoxQText.Name = "textBoxQText";
			this.textBoxQText.Size = new System.Drawing.Size(746, 19);
			this.textBoxQText.TabIndex = 0;
			// 
			// textBoxQAns
			// 
			this.textBoxQAns.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBoxQAns.Location = new System.Drawing.Point(6, 72);
			this.textBoxQAns.Name = "textBoxQAns";
			this.textBoxQAns.Size = new System.Drawing.Size(746, 19);
			this.textBoxQAns.TabIndex = 3;
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.Checked = true;
			this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox1.Location = new System.Drawing.Point(6, 97);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(48, 16);
			this.checkBox1.TabIndex = 4;
			this.checkBox1.Text = "正肢";
			this.checkBox1.UseVisualStyleBackColor = true;
			// 
			// buttonQAdd
			// 
			this.buttonQAdd.Location = new System.Drawing.Point(6, 117);
			this.buttonQAdd.Name = "buttonQAdd";
			this.buttonQAdd.Size = new System.Drawing.Size(746, 23);
			this.buttonQAdd.TabIndex = 5;
			this.buttonQAdd.Text = "Add";
			this.buttonQAdd.UseVisualStyleBackColor = true;
			this.buttonQAdd.Click += new System.EventHandler(this.buttonQAdd_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.textBoxOutputXML);
			this.groupBox2.Location = new System.Drawing.Point(13, 184);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(759, 365);
			this.groupBox2.TabIndex = 2;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Output";
			// 
			// textBoxOutputXML
			// 
			this.textBoxOutputXML.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBoxOutputXML.Location = new System.Drawing.Point(9, 15);
			this.textBoxOutputXML.MaxLength = 60000;
			this.textBoxOutputXML.Multiline = true;
			this.textBoxOutputXML.Name = "textBoxOutputXML";
			this.textBoxOutputXML.ReadOnly = true;
			this.textBoxOutputXML.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBoxOutputXML.Size = new System.Drawing.Size(743, 344);
			this.textBoxOutputXML.TabIndex = 0;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(784, 561);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.menuStrip1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Wakatake";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileFToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem loadLToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveSToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitEToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutAToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutAToolStripMenuItem1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBoxQText;
		private System.Windows.Forms.TextBox textBoxQAns;
		private System.Windows.Forms.Button buttonQAdd;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TextBox textBoxOutputXML;
	}
}

