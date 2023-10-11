using System.Reflection.Emit;
using System.Windows.Forms;

namespace NotePad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nEWToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            richTextBox1.ForeColor = default(Color);
            richTextBox1.BackColor = default(Color);
        }

        private void sAVEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog1.FileName, richTextBox1.Text);
            }
        }

        private void lOADToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Text File|*.txt";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                var str = File.ReadAllText(openFileDialog1.FileName);

                richTextBox1.Text = str;

            }
        }

        private void fONTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {

                if (richTextBox1.CanSelect == true)
                {
                    richTextBox1.SelectionFont = fontDialog1.Font;
                }

                else
                {
                    richTextBox1.Font = fontDialog1.Font;
                }

            }
        }

        private void cOLORToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.BackColor = colorDialog1.Color;
            }
        }

        private void bACKCOLORToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {

                if (richTextBox1.CanSelect == true)
                {
                    richTextBox1.SelectionColor = colorDialog1.Color;
                }

                else
                {
                    richTextBox1.ForeColor = colorDialog1.Color;

                }

            }
        }

        private void aBOUTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = "Bu proqramin adi Wordpad Killer dir\nBiz bunu yaradan zaman note pada oxsatmaqa calismisiq\nBurda File hissesinde save bassaz isdediyiviz\nfile melumati yaza bilersiz\nLoad vasitesile filedeki texti yaza bilersiz bura\nexit vasitesile cixirsiz.New vasitesile yenisin yaradirsiz\nfontla textse size falana vere bilirsiz\nback colorla arxa fona,fore colorla texte color vere bilirsiz";
            MessageBox.Show(message, "ABOUT", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void uNDOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.CanUndo == true)

            {

                richTextBox1.Undo();

            }
        }

        private void rEDOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.CanRedo == true)

            {

                richTextBox1.Redo();

            }
        }
    }
}