using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace LN_Editor
{
    public partial class form_start : Form
    {
        private string currentFilePath;

        public form_start()
        {
            InitializeComponent();
        }

        private void btn_menue_laden_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                currentFilePath = openFileDialog.FileName;
                textBox1.Text = File.ReadAllText(currentFilePath);
            }
        }

        private void btn_menue_speichern_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(currentFilePath))
            {
                SpeichernUnter();
            }
            else
            {
                File.WriteAllText(currentFilePath, textBox1.Text);
            }
        }

        private void btn_menue_speichern_unter_Click(object sender, EventArgs e)
        {
            SpeichernUnter();
        }

        private void SpeichernUnter()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                currentFilePath = saveFileDialog.FileName;
                File.WriteAllText(currentFilePath, textBox1.Text);
            }
        }

        private void btn_menue_beenden_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_menue_suchen_Click(object sender, EventArgs e)
        {
            var result = Prompt.ShowDialog("Suchtext eingeben:", "Suchen");
            string searchText = result.searchText;
            bool matchCase = result.matchCase;

            if (!string.IsNullOrEmpty(searchText))
            {
                StringComparison comparisonType = matchCase ? StringComparison.Ordinal : StringComparison.OrdinalIgnoreCase;
                int index = textBox1.Text.IndexOf(searchText, comparisonType);
                if (index != -1)
                {
                    textBox1.Select(index, searchText.Length);
                    textBox1.ScrollToCaret();
                    MessageBox.Show("Text gefunden.");
                }
                else
                {
                    MessageBox.Show("Text nicht gefunden.");
                }
            }
        }

        public static class Prompt
        {
            public static (string searchText, bool matchCase) ShowDialog(string text, string caption)
            {
                Form prompt = new Form();
                prompt.Width = 500;
                prompt.Height = 200;
                prompt.Text = caption;

                Label textLabel = new Label() { Left = 50, Top = 20, Text = text };
                TextBox textBox = new TextBox() { Left = 50, Top = 50, Width = 400 };
                CheckBox matchCaseCheckBox = new CheckBox() { Left = 50, Top = 80, Text = "Groß-/Kleinschreibung beachten" };
                Button confirmation = new Button() { Text = "Ok", Left = 350, Width = 100, Top = 110 };

                confirmation.Click += (sender, e) => { prompt.Close(); };

                prompt.Controls.Add(textLabel);
                prompt.Controls.Add(textBox);
                prompt.Controls.Add(matchCaseCheckBox);
                prompt.Controls.Add(confirmation);
                prompt.ShowDialog();

                return (textBox.Text, matchCaseCheckBox.Checked);
            }
        }
    }
}
