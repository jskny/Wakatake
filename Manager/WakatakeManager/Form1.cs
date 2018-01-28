using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;

namespace WakatakeManager
{
	public partial class Form1 : Form
	{
		[XmlRoot("plist")]
		public class PList
		{
			[XmlElement("subject")]
			public string Subject { get; set; }
			[XmlElement("subheading")]
			public string Subheading { get; set; }


			[XmlArray("problems")]
			[XmlArrayItem("problem")]
			public List<Problem> problems { get; set; }
		}

		public class Problem
		{
			[XmlElement("statement")]
			public string Statement { get; set; }

			[XmlElement("commentary")]
			public string Commentary { get; set; }

			[XmlElement("ans")]
			public int Ans { get; set; }
		}


		public PList database = null;


		public Form1()
		{
			InitializeComponent();

			database = new PList();
			database.Subject = "主たる科目名";
			database.Subheading = "副たる科目名";
			database.problems = new List<Problem>();
		}

		private void exitEToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void buttonQAdd_Click(object sender, EventArgs e)
		{
			if (this.textBoxQText.Text.Length <= 0)
			{
				MessageBox.Show("問題文が入力されていません。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			else if (this.textBoxQAns.Text.Length <= 0)
			{
				MessageBox.Show("解説文が入力されていません。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			Problem tmp = new Problem();
			tmp.Statement = this.textBoxQText.Text;
			tmp.Commentary = this.textBoxQAns.Text;
			tmp.Ans = this.checkBox1.Checked ? 1 : 0;

			this.database.problems.Add(tmp);

			// C# でXMLを使う方法
			// http://ohke.hateblo.jp/entry/2017/06/02/220000
			var writer = new StringWriter();
			var serializer = new XmlSerializer(typeof(PList));
			serializer.Serialize(writer, this.database);
			this.textBoxOutputXML.Text = writer.ToString();
			this.textBoxOutputXML.Text = this.textBoxOutputXML.Text.Replace("encoding=\"utf-16\"", "encoding=\"utf-8\"");

			this.textBoxQText.Text = "";
			this.textBoxQAns.Text = "";
			return;
		}

		private void aboutAToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			MessageBox.Show(
				"Wakatake Manager\n" +
				"Version 1\n" +
				"これは若竹で使用する問題の作成を補助するアプリケーションです。\n" +
				"\n" +
				"jskny"
				, "Version info", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void loadLToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MessageBox.Show("いつか実装します。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		private void saveSToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MessageBox.Show("いつか実装します。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}
	}
}
