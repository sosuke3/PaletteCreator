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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.exportYYPalette = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.importSPRfromROM = new System.Windows.Forms.Button();
            this.ImportROMopenDialog = new System.Windows.Forms.OpenFileDialog();
            this.ImportSPRopenDialog = new System.Windows.Forms.OpenFileDialog();
            this.ExportYYPalettesaveDialog = new System.Windows.Forms.SaveFileDialog();
            this.importYYPalette = new System.Windows.Forms.Button();
            this.exportSPR = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.ExportSPRsaveDialog = new System.Windows.Forms.SaveFileDialog();
            this.ExportROMsaveDialog = new System.Windows.Forms.SaveFileDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.exportGalePalette = new System.Windows.Forms.Button();
            this.importGalePalette = new System.Windows.Forms.Button();
            this.ImportGalePaletteopenDialog = new System.Windows.Forms.OpenFileDialog();
            this.ImportYYPaletteopenDialog = new System.Windows.Forms.OpenFileDialog();
            this.ExportGalePalettesaveDialog = new System.Windows.Forms.SaveFileDialog();
            this.importSPR = new System.Windows.Forms.Button();
            this.openFileDialog5 = new System.Windows.Forms.OpenFileDialog();
            this.exportPNG = new System.Windows.Forms.Button();
            this.ExportPNGsaveDialog = new System.Windows.Forms.SaveFileDialog();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.importPNG = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.injectROM = new System.Windows.Forms.Button();
            this.InjectSPRopenDialog = new System.Windows.Forms.OpenFileDialog();
            this.InjectROMsaveDialog = new System.Windows.Forms.SaveFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
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
            this.pictureBox2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseMove);
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
            // exportYYPalette
            // 
            this.exportYYPalette.Location = new System.Drawing.Point(617, 476);
            this.exportYYPalette.Name = "exportYYPalette";
            this.exportYYPalette.Size = new System.Drawing.Size(90, 35);
            this.exportYYPalette.TabIndex = 5;
            this.exportYYPalette.Text = "Export YY-CHR Pal";
            this.exportYYPalette.UseVisualStyleBackColor = true;
            this.exportYYPalette.Click += new System.EventHandler(this.exportYYPalette_Click);
            // 
            // importSPRfromROM
            // 
            this.importSPRfromROM.Location = new System.Drawing.Point(522, 316);
            this.importSPRfromROM.Name = "importSPRfromROM";
            this.importSPRfromROM.Size = new System.Drawing.Size(90, 35);
            this.importSPRfromROM.TabIndex = 7;
            this.importSPRfromROM.Text = "Import ROM";
            this.importSPRfromROM.UseVisualStyleBackColor = true;
            this.importSPRfromROM.Click += new System.EventHandler(this.importSPRfromROM_Click);
            // 
            // ImportROMopenDialog
            // 
            this.ImportROMopenDialog.Filter = "SNES ROMs|*.sfc|All Files|*.*";
            this.ImportROMopenDialog.RestoreDirectory = true;
            this.ImportROMopenDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.ImportROMopenDialog_FileOk);
            // 
            // ImportSPRopenDialog
            // 
            this.ImportSPRopenDialog.Filter = "ALttP Sprites|*.spr";
            this.ImportSPRopenDialog.RestoreDirectory = true;
            this.ImportSPRopenDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.ImportSPRopenDialog_FileOk);
            // 
            // ExportYYPalettesaveDialog
            // 
            this.ExportYYPalettesaveDialog.Filter = "YY-CHR Palettes|*.pal";
            this.ExportYYPalettesaveDialog.RestoreDirectory = true;
            this.ExportYYPalettesaveDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.ExportYYPalettesaveDialog_FileOk);
            // 
            // importYYPalette
            // 
            this.importYYPalette.Location = new System.Drawing.Point(522, 476);
            this.importYYPalette.Name = "importYYPalette";
            this.importYYPalette.Size = new System.Drawing.Size(90, 35);
            this.importYYPalette.TabIndex = 8;
            this.importYYPalette.Text = "Import YY-CHR Pal";
            this.importYYPalette.UseVisualStyleBackColor = true;
            this.importYYPalette.Click += new System.EventHandler(this.importYYPalette_Click);
            // 
            // exportSPR
            // 
            this.exportSPR.Location = new System.Drawing.Point(617, 356);
            this.exportSPR.Name = "exportSPR";
            this.exportSPR.Size = new System.Drawing.Size(90, 35);
            this.exportSPR.TabIndex = 9;
            this.exportSPR.Text = "Export SPR";
            this.exportSPR.UseVisualStyleBackColor = true;
            this.exportSPR.Click += new System.EventHandler(this.exportSPR_Click_1);
            // 
            // button6
            // 
            this.button6.Enabled = false;
            this.button6.Location = new System.Drawing.Point(617, 316);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(90, 35);
            this.button6.TabIndex = 10;
            this.button6.Text = "Export ROM";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.ExportROM_Click);
            // 
            // ExportSPRsaveDialog
            // 
            this.ExportSPRsaveDialog.Filter = "ALttP Sprites|*.spr";
            this.ExportSPRsaveDialog.RestoreDirectory = true;
            this.ExportSPRsaveDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.ExportSPRsaveDialog_FileOk);
            // 
            // ExportROMsaveDialog
            // 
            this.ExportROMsaveDialog.Filter = "SNES ROMs|*.sfc";
            this.ExportROMsaveDialog.RestoreDirectory = true;
            this.ExportROMsaveDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.ExportROMsaveDialog_FileOk);
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
            // exportGalePalette
            // 
            this.exportGalePalette.Location = new System.Drawing.Point(617, 436);
            this.exportGalePalette.Name = "exportGalePalette";
            this.exportGalePalette.Size = new System.Drawing.Size(90, 35);
            this.exportGalePalette.TabIndex = 12;
            this.exportGalePalette.Text = "Export Graphics Gale Pal";
            this.exportGalePalette.UseVisualStyleBackColor = true;
            this.exportGalePalette.Click += new System.EventHandler(this.exportGalePalette_Click);
            // 
            // importGalePalette
            // 
            this.importGalePalette.Location = new System.Drawing.Point(522, 436);
            this.importGalePalette.Name = "importGalePalette";
            this.importGalePalette.Size = new System.Drawing.Size(90, 35);
            this.importGalePalette.TabIndex = 13;
            this.importGalePalette.Text = "Import Graphics Gale Pal";
            this.importGalePalette.UseVisualStyleBackColor = true;
            this.importGalePalette.Click += new System.EventHandler(this.importGalePalette_Click);
            // 
            // ImportGalePaletteopenDialog
            // 
            this.ImportGalePaletteopenDialog.Filter = "Graphics Gale Palettes|*.pal";
            this.ImportGalePaletteopenDialog.RestoreDirectory = true;
            this.ImportGalePaletteopenDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.ImportGalePaletteopenDialog_FileOk);
            // 
            // ImportYYPaletteopenDialog
            // 
            this.ImportYYPaletteopenDialog.Filter = "YY-CHR Palettes|*.pal";
            this.ImportYYPaletteopenDialog.RestoreDirectory = true;
            this.ImportYYPaletteopenDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.ImportYYPaletteopenDialog_FileOk);
            // 
            // ExportGalePalettesaveDialog
            // 
            this.ExportGalePalettesaveDialog.Filter = "Graphics Gale Palettes|*.pal";
            this.ExportGalePalettesaveDialog.RestoreDirectory = true;
            this.ExportGalePalettesaveDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.ExportGalePalettesaveDialog_FileOk);
            // 
            // importSPR
            // 
            this.importSPR.Location = new System.Drawing.Point(522, 356);
            this.importSPR.Name = "importSPR";
            this.importSPR.Size = new System.Drawing.Size(90, 35);
            this.importSPR.TabIndex = 14;
            this.importSPR.Text = "Import SPR";
            this.importSPR.UseVisualStyleBackColor = true;
            this.importSPR.Click += new System.EventHandler(this.importSPR_Click_1);
            // 
            // openFileDialog5
            // 
            this.openFileDialog5.Filter = "SNES ROMs|*.sfc|All Files|*.*";
            this.openFileDialog5.RestoreDirectory = true;
            this.openFileDialog5.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog5_FileOk);
            // 
            // exportPNG
            // 
            this.exportPNG.Location = new System.Drawing.Point(617, 396);
            this.exportPNG.Name = "exportPNG";
            this.exportPNG.Size = new System.Drawing.Size(90, 35);
            this.exportPNG.TabIndex = 15;
            this.exportPNG.Text = "Export PNG";
            this.exportPNG.UseVisualStyleBackColor = true;
            this.exportPNG.Click += new System.EventHandler(this.exportPNG_Click);
            // 
            // ExportPNGsaveDialog
            // 
            this.ExportPNGsaveDialog.DefaultExt = "png";
            this.ExportPNGsaveDialog.Filter = "PNGs|*.png";
            this.ExportPNGsaveDialog.RestoreDirectory = true;
            this.ExportPNGsaveDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.ExportPNGsaveDialog_FileOk);
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
            // importPNG
            // 
            this.importPNG.Enabled = false;
            this.importPNG.Location = new System.Drawing.Point(522, 396);
            this.importPNG.Name = "importPNG";
            this.importPNG.Size = new System.Drawing.Size(90, 35);
            this.importPNG.TabIndex = 18;
            this.importPNG.Text = "Import PNG";
            this.importPNG.UseVisualStyleBackColor = true;
            this.importPNG.Click += new System.EventHandler(this.importPNG_Click);
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
            // injectROM
            // 
            this.injectROM.Location = new System.Drawing.Point(522, 260);
            this.injectROM.Name = "injectROM";
            this.injectROM.Size = new System.Drawing.Size(185, 50);
            this.injectROM.TabIndex = 71;
            this.injectROM.Text = "Import SPR && Export to ROM";
            this.injectROM.UseVisualStyleBackColor = true;
            this.injectROM.Click += new System.EventHandler(this.injectROM_Click);
            // 
            // InjectSPRopenDialog
            // 
            this.InjectSPRopenDialog.Filter = "ALttP Sprites|*.spr";
            this.InjectSPRopenDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.InjectSPRopenDialog_FileOk);
            // 
            // InjectROMsaveDialog
            // 
            this.InjectROMsaveDialog.Filter = "SNES ROMs|*.sfc";
            this.InjectROMsaveDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.InjectROMsaveDialog_FileOk);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 616);
            this.Controls.Add(this.injectROM);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.importPNG);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.exportPNG);
            this.Controls.Add(this.importSPR);
            this.Controls.Add(this.importGalePalette);
            this.Controls.Add(this.exportGalePalette);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.exportSPR);
            this.Controls.Add(this.importYYPalette);
            this.Controls.Add(this.importSPRfromROM);
            this.Controls.Add(this.exportYYPalette);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "PaletteCreator " + PaletteCreator.Properties.Resources.Version;
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
        private System.Windows.Forms.Button exportYYPalette;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button importSPRfromROM;
        private System.Windows.Forms.OpenFileDialog ImportROMopenDialog;
        private System.Windows.Forms.OpenFileDialog ImportSPRopenDialog;
        private System.Windows.Forms.SaveFileDialog ExportYYPalettesaveDialog;
        private System.Windows.Forms.Button importYYPalette;
        private System.Windows.Forms.Button exportSPR;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.SaveFileDialog ExportSPRsaveDialog;
        private System.Windows.Forms.SaveFileDialog ExportROMsaveDialog;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button exportGalePalette;
        private System.Windows.Forms.Button importGalePalette;
        private System.Windows.Forms.OpenFileDialog ImportGalePaletteopenDialog;
        private System.Windows.Forms.OpenFileDialog ImportYYPaletteopenDialog;
        private System.Windows.Forms.SaveFileDialog ExportGalePalettesaveDialog;
        private System.Windows.Forms.Button importSPR;
        private System.Windows.Forms.OpenFileDialog openFileDialog5;
        private System.Windows.Forms.Button exportPNG;
        private System.Windows.Forms.SaveFileDialog ExportPNGsaveDialog;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button importPNG;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
/*
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
*/
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button injectROM;
        private System.Windows.Forms.OpenFileDialog InjectSPRopenDialog;
        private System.Windows.Forms.SaveFileDialog InjectROMsaveDialog;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

