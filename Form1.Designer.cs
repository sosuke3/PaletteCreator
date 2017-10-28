namespace PaletteCreator
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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.button3 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.saveFileDialog2 = new System.Windows.Forms.SaveFileDialog();
            this.saveFileDialog3 = new System.Windows.Forms.SaveFileDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.openFileDialog3 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog4 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog4 = new System.Windows.Forms.SaveFileDialog();
            this.button2 = new System.Windows.Forms.Button();
            this.openFileDialog5 = new System.Windows.Forms.OpenFileDialog();
            this.button9 = new System.Windows.Forms.Button();
            this.saveFileDialog5 = new System.Windows.Forms.SaveFileDialog();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button10 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button11 = new System.Windows.Forms.Button();
            this.openFileDialog6 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog6 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(134, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Selected Palette";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(137, 25);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(512, 32);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.DoubleClick += new System.EventHandler(this.pictureBox2_DoubleClick);
            this.pictureBox2.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseDoubleClick);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Green Mail",
            "Blue Mail",
            "Red Mail",
            "Bunny"});
            this.comboBox1.Location = new System.Drawing.Point(15, 25);
            this.comboBox1.MaxDropDownItems = 4;
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Selected Armor : ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(518, 539);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(190, 29);
            this.button1.TabIndex = 5;
            this.button1.Text = "Export All Palettes for YY-CHR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(518, 168);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(190, 53);
            this.button3.TabIndex = 7;
            this.button3.Text = "Load GFX and Palettes from ROM";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "ROM file|*.sfc|All Files|*.*";
            this.openFileDialog1.RestoreDirectory = true;
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            this.openFileDialog2.Filter = "Randomizer Sprite Format|*.spr";
            this.openFileDialog2.RestoreDirectory = true;
            this.openFileDialog2.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog2_FileOk);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileName = "YY-CHR Palette file|*.pal";
            this.saveFileDialog1.Filter = "Palettes Files|*.pal";
            this.saveFileDialog1.RestoreDirectory = true;
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(518, 469);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(190, 29);
            this.button4.TabIndex = 8;
            this.button4.Text = "Import All Palettes from YY-CHR .pal";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(518, 575);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(190, 29);
            this.button5.TabIndex = 9;
            this.button5.Text = "Export As Sprite (for Randomizer)";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(518, 286);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(190, 29);
            this.button6.TabIndex = 10;
            this.button6.Text = "Save full ROM";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // saveFileDialog2
            // 
            this.saveFileDialog2.Filter = "Randomizer Sprite Format|*.spr";
            this.saveFileDialog2.RestoreDirectory = true;
            this.saveFileDialog2.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog2_FileOk);
            // 
            // saveFileDialog3
            // 
            this.saveFileDialog3.Filter = "Snes ROM|*.sfc";
            this.saveFileDialog3.RestoreDirectory = true;
            this.saveFileDialog3.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog3_FileOk);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Preview : ";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(518, 504);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(190, 29);
            this.button7.TabIndex = 12;
            this.button7.Text = "Save Selected Pal for Graphics Gale";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(518, 434);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(190, 29);
            this.button8.TabIndex = 13;
            this.button8.Text = "Load Selected Pal from GG .pal";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // openFileDialog3
            // 
            this.openFileDialog3.FileName = "openFileDialog3";
            this.openFileDialog3.Filter = "Graphics Gale Palette|*.pal";
            this.openFileDialog3.RestoreDirectory = true;
            this.openFileDialog3.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog3_FileOk);
            // 
            // openFileDialog4
            // 
            this.openFileDialog4.FileName = "openFileDialog4";
            this.openFileDialog4.Filter = "YY-CHR Palette file|*.pal";
            this.openFileDialog4.RestoreDirectory = true;
            this.openFileDialog4.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog4_FileOk);
            // 
            // saveFileDialog4
            // 
            this.saveFileDialog4.Filter = "Graphics Gale palette|*.pal";
            this.saveFileDialog4.RestoreDirectory = true;
            this.saveFileDialog4.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog4_FileOk);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(518, 227);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(190, 53);
            this.button2.TabIndex = 14;
            this.button2.Text = "Load GFX and Palettes from .spr";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // openFileDialog5
            // 
            this.openFileDialog5.FileName = "openFileDialog1";
            this.openFileDialog5.Filter = "ROM file|*.sfc|All Files|*.*";
            this.openFileDialog5.RestoreDirectory = true;
            this.openFileDialog5.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog5_FileOk);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(518, 399);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(190, 29);
            this.button9.TabIndex = 15;
            this.button9.Text = "Export as Png";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // saveFileDialog5
            // 
            this.saveFileDialog5.DefaultExt = "png";
            this.saveFileDialog5.Filter = "PNG Images Files|*.png";
            this.saveFileDialog5.RestoreDirectory = true;
            this.saveFileDialog5.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog5_FileOk);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(517, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Hands  \\";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 168);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(512, 448);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(518, 364);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(190, 29);
            this.button10.TabIndex = 18;
            this.button10.Text = "Import Png";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(101, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Red\r\n";
            this.label5.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(101, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Green";
            this.label6.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(101, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Blue";
            this.label7.Visible = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(137, 127);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(75, 17);
            this.checkBox1.TabIndex = 70;
            this.checkBox1.Text = "Hex Value";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.Visible = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(518, 112);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(190, 53);
            this.button11.TabIndex = 71;
            this.button11.Text = "Load a .spr file and Patch it into a ROM";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // openFileDialog6
            // 
            this.openFileDialog6.Filter = "Randomizer Sprite Format|*.spr";
            this.openFileDialog6.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog6_FileOk);
            // 
            // saveFileDialog6
            // 
            this.saveFileDialog6.Filter = "Snes ROM|*.sfc";
            this.saveFileDialog6.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog6_FileOk);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 616);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Palette Creator 3.6";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.SaveFileDialog saveFileDialog2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.OpenFileDialog openFileDialog3;
        private System.Windows.Forms.OpenFileDialog openFileDialog4;
        private System.Windows.Forms.SaveFileDialog saveFileDialog4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.OpenFileDialog openFileDialog5;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.SaveFileDialog saveFileDialog5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox r1;
        private System.Windows.Forms.TextBox g1;
        private System.Windows.Forms.TextBox b1;
        private System.Windows.Forms.TextBox r2;
        private System.Windows.Forms.TextBox g2;
        private System.Windows.Forms.TextBox b2;
        private System.Windows.Forms.TextBox b3;
        private System.Windows.Forms.TextBox g3;
        private System.Windows.Forms.TextBox r3;
        private System.Windows.Forms.TextBox b4;
        private System.Windows.Forms.TextBox g4;
        private System.Windows.Forms.TextBox r4;
        private System.Windows.Forms.TextBox b5;
        private System.Windows.Forms.TextBox g5;
        private System.Windows.Forms.TextBox r5;
        private System.Windows.Forms.TextBox b6;
        private System.Windows.Forms.TextBox g6;
        private System.Windows.Forms.TextBox r6;
        private System.Windows.Forms.TextBox b7;
        private System.Windows.Forms.TextBox g7;
        private System.Windows.Forms.TextBox r7;
        private System.Windows.Forms.TextBox b8;
        private System.Windows.Forms.TextBox g8;
        private System.Windows.Forms.TextBox r8;
        private System.Windows.Forms.TextBox b9;
        private System.Windows.Forms.TextBox g9;
        private System.Windows.Forms.TextBox r9;
        private System.Windows.Forms.TextBox b10;
        private System.Windows.Forms.TextBox g10;
        private System.Windows.Forms.TextBox r10;
        private System.Windows.Forms.TextBox b11;
        private System.Windows.Forms.TextBox g11;
        private System.Windows.Forms.TextBox r11;
        private System.Windows.Forms.TextBox b12;
        private System.Windows.Forms.TextBox g12;
        private System.Windows.Forms.TextBox r12;
        private System.Windows.Forms.TextBox b13;
        private System.Windows.Forms.TextBox g13;
        private System.Windows.Forms.TextBox r13;
        private System.Windows.Forms.TextBox b14;
        private System.Windows.Forms.TextBox g14;
        private System.Windows.Forms.TextBox r14;
        private System.Windows.Forms.TextBox b15;
        private System.Windows.Forms.TextBox g15;
        private System.Windows.Forms.TextBox r15;
        private System.Windows.Forms.TextBox b16;
        private System.Windows.Forms.TextBox g16;
        private System.Windows.Forms.TextBox r16;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.OpenFileDialog openFileDialog6;
        private System.Windows.Forms.SaveFileDialog saveFileDialog6;
    }
}

