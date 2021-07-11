using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Insert an Image";
            ofd.InitialDirectory = "D:";
            ofd.Filter = "JPEG Images|*.jpg|GIF Images|*.gif|BITMAPS|*.bmp";
            ofd.ShowDialog();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            string saved_file = "";
            sfd.InitialDirectory = "D:";
            sfd.Title = "Save a File";
            sfd.FileName = "";
            sfd.Filter = "Text Files|*.txt |All Files| *.*";
            if (sfd.ShowDialog() != DialogResult.Cancel)
            {
                saved_file = sfd.FileName;
                RichTextBox rtb = new RichTextBox();
                rtb.SaveFile(saved_file, RichTextBoxStreamType.PlainText);
            }

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectedText != "")
            {
                richTextBox1.Cut();
            }
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionLength > 0)
            {
                richTextBox1.Copy();
            }
            if (richTextBox2.SelectionLength > 0)
            {
                richTextBox2.Copy();
            }
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Clipboard.GetDataObject().GetDataPresent(DataFormats.Text) == true)
            {
                richTextBox2.Paste();

            }
            if (Clipboard.GetDataObject().GetDataPresent(DataFormats.Text) == true)
            {
                richTextBox1.Paste();
            }
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.CanUndo == true) 
            {
                richTextBox1.Undo();
                richTextBox1.ClearUndo();
            }
        }
    }
}