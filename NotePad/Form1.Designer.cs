namespace NotePad
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            fILEToolStripMenuItem = new ToolStripMenuItem();
            lOADToolStripMenuItem = new ToolStripMenuItem();
            sAVEToolStripMenuItem = new ToolStripMenuItem();
            nEWToolStripMenuItem = new ToolStripMenuItem();
            eXITToolStripMenuItem = new ToolStripMenuItem();
            fONTToolStripMenuItem = new ToolStripMenuItem();
            cOLORToolStripMenuItem = new ToolStripMenuItem();
            bACKCOLORToolStripMenuItem = new ToolStripMenuItem();
            aBOUTToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            uNDOToolStripMenuItem = new ToolStripMenuItem();
            rEDOToolStripMenuItem = new ToolStripMenuItem();
            richTextBox1 = new RichTextBox();
            saveFileDialog1 = new SaveFileDialog();
            openFileDialog1 = new OpenFileDialog();
            fontDialog1 = new FontDialog();
            colorDialog1 = new ColorDialog();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fILEToolStripMenuItem, fONTToolStripMenuItem, cOLORToolStripMenuItem, bACKCOLORToolStripMenuItem, aBOUTToolStripMenuItem, editToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 32);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fILEToolStripMenuItem
            // 
            fILEToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { lOADToolStripMenuItem, sAVEToolStripMenuItem, nEWToolStripMenuItem, eXITToolStripMenuItem });
            fILEToolStripMenuItem.Font = new Font("Stencil", 12F, FontStyle.Bold, GraphicsUnit.Point);
            fILEToolStripMenuItem.Name = "fILEToolStripMenuItem";
            fILEToolStripMenuItem.Size = new Size(70, 28);
            fILEToolStripMenuItem.Text = "FILE";
            // 
            // lOADToolStripMenuItem
            // 
            lOADToolStripMenuItem.Name = "lOADToolStripMenuItem";
            lOADToolStripMenuItem.Size = new Size(147, 28);
            lOADToolStripMenuItem.Text = "LOAD";
            lOADToolStripMenuItem.Click += lOADToolStripMenuItem_Click;
            // 
            // sAVEToolStripMenuItem
            // 
            sAVEToolStripMenuItem.Name = "sAVEToolStripMenuItem";
            sAVEToolStripMenuItem.Size = new Size(147, 28);
            sAVEToolStripMenuItem.Text = "SAVE";
            sAVEToolStripMenuItem.Click += sAVEToolStripMenuItem_Click;
            // 
            // nEWToolStripMenuItem
            // 
            nEWToolStripMenuItem.Name = "nEWToolStripMenuItem";
            nEWToolStripMenuItem.Size = new Size(147, 28);
            nEWToolStripMenuItem.Text = "NEW";
            nEWToolStripMenuItem.Click += nEWToolStripMenuItem_Click;
            // 
            // eXITToolStripMenuItem
            // 
            eXITToolStripMenuItem.Name = "eXITToolStripMenuItem";
            eXITToolStripMenuItem.Size = new Size(147, 28);
            eXITToolStripMenuItem.Text = "EXIT";
            eXITToolStripMenuItem.Click += eXITToolStripMenuItem_Click;
            // 
            // fONTToolStripMenuItem
            // 
            fONTToolStripMenuItem.Font = new Font("Stencil", 12F, FontStyle.Bold, GraphicsUnit.Point);
            fONTToolStripMenuItem.Name = "fONTToolStripMenuItem";
            fONTToolStripMenuItem.Size = new Size(77, 28);
            fONTToolStripMenuItem.Text = "FONT";
            fONTToolStripMenuItem.Click += fONTToolStripMenuItem_Click;
            // 
            // cOLORToolStripMenuItem
            // 
            cOLORToolStripMenuItem.Font = new Font("Stencil", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cOLORToolStripMenuItem.Name = "cOLORToolStripMenuItem";
            cOLORToolStripMenuItem.Size = new Size(154, 28);
            cOLORToolStripMenuItem.Text = "BACK COLOR";
            cOLORToolStripMenuItem.Click += cOLORToolStripMenuItem_Click;
            // 
            // bACKCOLORToolStripMenuItem
            // 
            bACKCOLORToolStripMenuItem.Font = new Font("Stencil", 12F, FontStyle.Bold, GraphicsUnit.Point);
            bACKCOLORToolStripMenuItem.Name = "bACKCOLORToolStripMenuItem";
            bACKCOLORToolStripMenuItem.Size = new Size(152, 28);
            bACKCOLORToolStripMenuItem.Text = "FORE COLOR";
            bACKCOLORToolStripMenuItem.Click += bACKCOLORToolStripMenuItem_Click;
            // 
            // aBOUTToolStripMenuItem
            // 
            aBOUTToolStripMenuItem.Font = new Font("Stencil", 12F, FontStyle.Bold, GraphicsUnit.Point);
            aBOUTToolStripMenuItem.Name = "aBOUTToolStripMenuItem";
            aBOUTToolStripMenuItem.Size = new Size(93, 28);
            aBOUTToolStripMenuItem.Text = "ABOUT";
            aBOUTToolStripMenuItem.Click += aBOUTToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { uNDOToolStripMenuItem, rEDOToolStripMenuItem });
            editToolStripMenuItem.Font = new Font("Stencil", 12F, FontStyle.Bold, GraphicsUnit.Point);
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(73, 28);
            editToolStripMenuItem.Text = "edit";
            // 
            // uNDOToolStripMenuItem
            // 
            uNDOToolStripMenuItem.Name = "uNDOToolStripMenuItem";
            uNDOToolStripMenuItem.Size = new Size(224, 28);
            uNDOToolStripMenuItem.Text = "UNDO";
            uNDOToolStripMenuItem.Click += uNDOToolStripMenuItem_Click;
            // 
            // rEDOToolStripMenuItem
            // 
            rEDOToolStripMenuItem.Name = "rEDOToolStripMenuItem";
            rEDOToolStripMenuItem.Size = new Size(224, 28);
            rEDOToolStripMenuItem.Text = "REDO";
            rEDOToolStripMenuItem.Click += rEDOToolStripMenuItem_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(0, 49);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(800, 400);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(richTextBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fILEToolStripMenuItem;
        private ToolStripMenuItem lOADToolStripMenuItem;
        private ToolStripMenuItem sAVEToolStripMenuItem;
        private ToolStripMenuItem nEWToolStripMenuItem;
        private ToolStripMenuItem eXITToolStripMenuItem;
        private ToolStripMenuItem fONTToolStripMenuItem;
        private ToolStripMenuItem cOLORToolStripMenuItem;
        private RichTextBox richTextBox1;
        private SaveFileDialog saveFileDialog1;
        private OpenFileDialog openFileDialog1;
        private FontDialog fontDialog1;
        private ColorDialog colorDialog1;
        private ToolStripMenuItem bACKCOLORToolStripMenuItem;
        private ToolStripMenuItem aBOUTToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem uNDOToolStripMenuItem;
        private ToolStripMenuItem rEDOToolStripMenuItem;
    }
}