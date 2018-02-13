using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Expat.Bayesian;

namespace SpamFilterSample
{
	public partial class Form1 : Form
	{
		private SpamFilter _filter;

		public Form1()
		{
			InitializeComponent();
		}

		private void TestFile(string file)
		{
			if (_filter == null)
			{
				MessageBox.Show("Load first!");
				return;
			}

			string body = new StreamReader(file).ReadToEnd();
			txtOut.Text = file + Environment.NewLine + "score: " + _filter.Test(body).ToString();
			txtOut.AppendText(Environment.NewLine + Environment.NewLine + body);
		}

		#region clicks
		private void btnLoad_Click(object sender, EventArgs e)
		{
			Corpus bad = new Corpus();
			Corpus good = new Corpus();
			bad.LoadFromFile("../../TestData/spam.txt");
			good.LoadFromFile("../../TestData/good.txt");

			_filter = new SpamFilter();
			_filter.Load(good, bad);


			// Just for grins, we'll dump out some statistics about the data we just loaded.
			txtOut.Text = String.Format(@"{0} {1} {2}{3}"
				, _filter.Good.Tokens.Count
				, _filter.Bad.Tokens.Count
				, _filter.Prob.Count
				, Environment.NewLine);

			// ... and some probabilities for keys
			foreach (string key in _filter.Prob.Keys)
			{
				if (_filter.Prob[key] > 0.02)
				{
					txtOut.AppendText(String.Format("{0},{1}{2}", _filter.Prob[key].ToString(".0000"), key, Environment.NewLine));
				}
			}

		}

		private void btnTest1_Click(object sender, EventArgs e)
		{
			TestFile("../../TestData/definatelyOK.txt");
		}

		private void btnTest2_Click(object sender, EventArgs e)
		{
			TestFile("../../TestData/maybeSpam.txt");
		}

		private void btnTest3_Click(object sender, EventArgs e)
		{
			TestFile("../../TestData/definatelySpam.txt");
		}

		private void btnTestBox_Click(object sender, EventArgs e)
		{
			if (_filter == null)
			{
				MessageBox.Show("Load first!");
				return;
			}

			string body = txtOut.Text;
			txtOut.Text = _filter.Test(body).ToString();
			txtOut.AppendText(Environment.NewLine + body);
		}

		private void btnToFile_Click(object sender, EventArgs e)
		{
			if (_filter == null)
			{
				MessageBox.Show("Load first!");
				return;
			}

			_filter.ToFile("../../TestData/out.txt");
		}

		private void btnFromFile_Click(object sender, EventArgs e)
		{
			_filter = new SpamFilter();
			_filter.FromFile("../../TestData/out.txt");
		}

		#endregion
	}
}