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
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace PaletteCreator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Color[] palette = new Color[17];
        Color[] palette2 = new Color[17];
        Color[] palette3 = new Color[17];
        Color[] palette4 = new Color[17];
        string[] tempFolders = new string[10];
        private void Form1_Load(object sender, EventArgs e)
        {

            /*   if (File.Exists("folderstemp.txt"))
               {
                   tempFolders = File.ReadAllLines("folderstemp.txt");
                   ImportROMopenDialog.InitialDirectory = tempFolders[0];
                   ImportSPRopenDialog.InitialDirectory = tempFolders[1];
                   ImportGalePaletteopenDialog.InitialDirectory = tempFolders[2];
                   ImportYYPaletteopenDialog.InitialDirectory = tempFolders[3];
                   openFileDialog5.InitialDirectory = tempFolders[4];
                   ExportYYPalettesaveDialog.InitialDirectory = tempFolders[5];
                   ExportSPRsaveDialog.InitialDirectory = tempFolders[6];
                   ExportROMsaveDialog.InitialDirectory = tempFolders[7];
                   ExportGalePalettesaveDialog.InitialDirectory = tempFolders[8];
                   ExportPNGsaveDialog.InitialDirectory = tempFolders[9];
               }*/

            for (int i = 0; i < 16; i++)
            {
                palette[i] = Color.FromArgb(i * 15, i * 15, i * 15);
                palette2[i] = Color.FromArgb(i * 15, i * 15, i * 15);
                palette3[i] = Color.FromArgb(i * 15, i * 15, i * 15);
                palette4[i] = Color.FromArgb(i * 15, i * 15, i * 15);
            }
            pictureBox1.Image = new Bitmap(512, 1024);
            data = new byte[0x7000];/*
            FileStream fs = new FileStream("sprites/zelda.spr", FileMode.OpenOrCreate, FileAccess.Read);
            fs.Read(data, 0, 0x7000);
            fs.Close();*/
            
            refreshEverything();

            comboBox1.SelectedIndex = 0;

        }

        public void refreshEverything()
        {
            
            pictureBox2.Image = new Bitmap(512, 32);
            Graphics g = Graphics.FromImage(pictureBox2.Image);
            for (int i = 0; i < 16; i++)
            {
                if (comboBox1.SelectedIndex == 0)
                {
                    g.FillRectangle(new SolidBrush(palette[i]), new Rectangle(i * 32, 0, (i * 32) + 32, 32));
                }
                if (comboBox1.SelectedIndex == 1)
                {
                    g.FillRectangle(new SolidBrush(palette2[i]), new Rectangle(i * 32, 0, (i * 32) + 32, 32));
                }
                if (comboBox1.SelectedIndex == 2)
                {
                    g.FillRectangle(new SolidBrush(palette3[i]), new Rectangle(i * 32, 0, (i * 32) + 32, 32));
                }
                if (comboBox1.SelectedIndex == 3)
                {
                    g.FillRectangle(new SolidBrush(palette4[i]), new Rectangle(i * 32, 0, (i * 32) + 32, 32));
                }
            }

            

            for (int i = 0; i < 14; i++)
            {
                load4bpp(i);
                updateGraphic(i);
            }
            //;
            //updateGraphic(i);

            //Graphics gp = Graphics.FromImage(pictureBox1.Image);
            //gp.Clear(Color.Black);
            

        }

        byte[,] imgdata = new byte[128, 32];

        byte[] data;
        int[] positions = new int[] { 0x80, 0x40, 0x20, 0x10, 0x08, 0x04, 0x02, 0x01 };
        int hexOffset = 0x0;
        public void load4bpp(int pos = 0)
        {

            for (int j = 0; j < 4; j++) //4 par y
            {
                for (int i = 0; i < 16; i++)
                {
                    int offset = (hexOffset + (pos * 0x800)) + ((j * 32) * 16) + (i * 32);
                    for (int x = 0; x < 8; x++)
                    {
                        for (int y = 0; y < 8; y++)
                        {
                            byte tmpbyte = 0;

                            if ((data[offset + (x * 2)] & positions[y]) == positions[y])
                            {
                                tmpbyte += 1;
                            }
                            if ((data[offset + (x * 2) + 1] & positions[y]) == positions[y])
                            {
                                tmpbyte += 2;
                            }

                            if ((data[offset + 16 + (x * 2)] & positions[y]) == positions[y])
                            {
                                tmpbyte += 4;
                            }
                            if ((data[offset + 16 + (x * 2) + 1] & positions[y]) == positions[y])
                            {
                                tmpbyte += 8;
                            }

                            imgdata[y + (i * 8), x + (j * 8)] = tmpbyte;

                        }
                    }
                    // pos++;
                }
            }


        }




       /* public void load4bpp(int pos = 0)
        {

            for (int j = 0; j < 4; j++) //4 par y
            {
                for (int i = 0; i < 16; i++)
                {
                    int offset = (hexOffset + (pos * 0x800)) + ((j * 32) * 16) + (i * 32);
                    for (int x = 0; x < 8; x++)
                    {
                        for (int y = 0; y < 8; y++)
                        {
                            byte tmpbyte = 0;

                            if ((data[offset + (x * 2)] & positions[y]) == positions[y])
                            {
                                tmpbyte += 1;
                            }
                            if ((data[offset + (x * 2) + 1] & positions[y]) == positions[y])
                            {
                                tmpbyte += 2;
                            }

                            if ((data[offset + 16 + (x * 2)] & positions[y]) == positions[y])
                            {
                                tmpbyte += 4;
                            }
                            if ((data[offset + 16 + (x * 2) + 1] & positions[y]) == positions[y])
                            {
                                tmpbyte += 8;
                            }

                            imgdata[y + (i * 8), x + (j * 8)] = tmpbyte;

                        }
                    }
                    // pos++;
                }
            }


        }*/


        Bitmap loadedblocks = new Bitmap(128, 32);
        byte[] bitmap_data = new byte[4096 * 3];
        public void updateGraphic(int pos)
        {
            
            Graphics g = Graphics.FromImage(pictureBox1.Image);
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
            int bitmap_pos = 0;

                for (int y = 0; y < 32; y++)
                {
                for (int x = 0; x < 128; x++)
                {

                    bitmap_data[bitmap_pos] = imgdata[x, y];
                    bitmap_data[bitmap_pos + 1] = imgdata[x, y];
                        bitmap_data[bitmap_pos + 2] = imgdata[x, y];
                        bitmap_pos += 3;
                    
                     /*if (comboBox1.SelectedIndex == 1)
                     {
                        bitmap_data[bitmap_pos] = palette2[imgdata[x, y]].B;
                        bitmap_data[bitmap_pos + 1] = palette2[imgdata[x, y]].G;
                        bitmap_data[bitmap_pos + 2] = palette2[imgdata[x, y]].R;
                        bitmap_pos += 3;
                    }
                     if (comboBox1.SelectedIndex == 2)
                     {
                        bitmap_data[bitmap_pos] = palette3[imgdata[x, y]].B;
                        bitmap_data[bitmap_pos + 1] = palette3[imgdata[x, y]].G;
                        bitmap_data[bitmap_pos + 2] = palette3[imgdata[x, y]].R;
                        bitmap_pos += 3;
                    }
                     if (comboBox1.SelectedIndex == 3)
                     {
                        bitmap_data[bitmap_pos] = palette4[imgdata[x, y]].B;
                        bitmap_data[bitmap_pos + 1] = palette4[imgdata[x, y]].G;
                        bitmap_data[bitmap_pos + 2] = palette4[imgdata[x, y]].R;
                        bitmap_pos += 3;
                    }*/
                }
            }
            //
            Graphics gx = Graphics.FromImage(loadedblocks);
            gx.Clear(Color.Black);
            ProcessUsingLockbits((Bitmap)loadedblocks);
            //g.FillRectangle(Brushes.Fuchsia, new Rectangle(0, pos * 32, 128, 32));
            if (pos >= 7)
            {
                g.DrawImage(loadedblocks, new Rectangle(255, (pos-7) * 63, 256, 64), 0, 0, 128, 32, GraphicsUnit.Pixel);
            }
            else
            {
                g.DrawImage(loadedblocks, new Rectangle(0, pos * 63, 256, 64), 0, 0, 128, 32, GraphicsUnit.Pixel);
            }
            
            
            pictureBox1.Refresh();
        }

        private static String HexConverter(System.Drawing.Color c)
        {
            return "#" + c.R.ToString("X2") + c.G.ToString("X2") + c.B.ToString("X2");
        }

        private static String RGBConverter(System.Drawing.Color c)
        {
            return "RGB(" + c.R.ToString() + "," + c.G.ToString() + "," + c.B.ToString() + ")";
        }

        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            var x = Cursor.Position.X;
            var y = Cursor.Position.Y;

            for (int i = 0; i < 16; i++)
            {
                if (e.X >= i * 32 && e.X <= (i * 32) + 32)
                {
                    Color swatch = palette[i];
                    switch(comboBox1.SelectedIndex)
                    {
                        case 0:
                            swatch = palette[i];
                            break;
                        case 1:
                            swatch = palette2[i];
                            break;
                        case 2:
                            swatch = palette3[i];
                            break;
                        case 3:
                            swatch = palette4[i];
                            break;
                    }
                    string tip = "";
                    tip += "   Index " + i;
                    tip += "\n";
                    tip += "   " + HexConverter(swatch);
                    tip += "\n";
                    tip += "   " + RGBConverter(swatch);
                    toolTip1.Show(tip, pictureBox2);
                }
            }
            refreshEverything();
        }

        private void pictureBox2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < 16; i++)
            {
                if (e.X>=i*32 && e.X <= (i*32)+32)
                {
                    if (comboBox1.SelectedIndex == 0)
                    {
                        colorDialog1.Color = palette[i];
                        colorDialog1.ShowDialog();
                        palette[i] = colorDialog1.Color;
                    }
                    if (comboBox1.SelectedIndex == 1)
                    {
                        colorDialog1.Color = palette2[i];
                        colorDialog1.ShowDialog();
                        palette2[i] = colorDialog1.Color;
                    }
                    if (comboBox1.SelectedIndex == 2)
                    {
                        colorDialog1.Color = palette3[i];
                        colorDialog1.ShowDialog();
                        palette3[i] = colorDialog1.Color;
                    }
                    if (comboBox1.SelectedIndex == 3)
                    {
                        colorDialog1.Color = palette4[i];
                        colorDialog1.ShowDialog();
                        palette4[i] = colorDialog1.Color;
                    }
                }
            }
            refreshEverything();
        }
        
        // IMPORT ROM
        private void importSPRfromROM_Click(object sender, EventArgs e)
        {
            if (tempFolders[0] != null)
            {
                ImportROMopenDialog.InitialDirectory = tempFolders[0];
            }
            
            ImportROMopenDialog.ShowDialog();

        }

        public Color getColor(short c)
        {
            return Color.FromArgb(((c & 0x1F) * 8), ((c & 0x3E0) >> 5)*8, ((c & 0x7C00) >> 10) * 8);
        }
        byte[] ROM_DATA;

        // IMPORT ROM
        private void ImportROMopenDialog_FileOk(object sender, CancelEventArgs e)
        {

            tempFolders[0] = Path.GetDirectoryName(ImportROMopenDialog.FileName);
            FileStream fs = new FileStream(ImportROMopenDialog.FileName, FileMode.Open, FileAccess.Read);
            ROM_DATA = new byte[(int)fs.Length];
            fs.Read(ROM_DATA, 0, (int)fs.Length);
         
            fs.Close();
            data = new byte[0x7000];
            for (int i = 0;i<0x7000;i++)
            {
                data[i] = ROM_DATA[0x80000 + i];
            }

            //palettes[0] = new Palette(0x0DD308, 15);
            //palettes[1] = new Palette(0x0DD326, 15);
            //palettes[2] = new Palette(0x0DD344, 15);
            for (int i = 0;i<15;i++)
            {
                palette[i+1] = getColor((short)((ROM_DATA[0x0DD308 + (i * 2)+1] << 8) + (ROM_DATA[0x0DD308 + (i * 2)])));
                palette2[i + 1] = getColor((short)((ROM_DATA[0x0DD326 + (i * 2) + 1] << 8) + (ROM_DATA[0x0DD326 + (i * 2)])));
                palette3[i + 1] = getColor((short)((ROM_DATA[0x0DD344 + (i * 2) + 1] << 8) + (ROM_DATA[0x0DD344 + (i * 2)])));
                palette4[i + 1] = getColor((short)((ROM_DATA[0x0DD362 + (i * 2) + 1] << 8) + (ROM_DATA[0x0DD362 + (i * 2)])));
            }
            refreshEverything();
            
        }

        // IMPORT SPR
        private void importSPR_Click(object sender, EventArgs e)
        {
            ImportSPRopenDialog.ShowDialog();
        }

        // IMPORT SPR
        private void ImportSPRopenDialog_FileOk(object sender, CancelEventArgs e)
        {
            tempFolders[1] = Path.GetDirectoryName(ImportSPRopenDialog.FileName);
            ROM_DATA = new byte[2097152];
            FileStream fs = new FileStream(ImportSPRopenDialog.FileName, FileMode.Open, FileAccess.Read);
            data = new byte[fs.Length];
            fs.Read(data, 0, (int)fs.Length);

            

            if (fs.Length == 0x7078)
            {
                for(int i = 0;i<0x7000;i++)
                {
                    ROM_DATA[0x80000+i] = data[i];
                }


                for (int i = 0; i < 15; i++)
                {
                    palette[i + 1] = getColor((short)((data[0x7000 + (i * 2) + 1] << 8) + (data[0x7000 + (i * 2)])));
                }
                for (int i = 0; i < 15; i++)
                {
                    palette2[i + 1] = getColor((short)((data[0x7000 + 30 + (i * 2) + 1] << 8) + (data[0x7000 + 30 + (i * 2)])));
                }
                for (int i = 0; i < 15; i++)
                {
                    palette3[i + 1] = getColor((short)((data[0x7000 + 60 + (i * 2) + 1] << 8) + (data[0x7000 + 60 + (i * 2)])));
                }
                for (int i = 0; i < 15; i++)
                {
                    palette4[i + 1] = getColor((short)((data[0x7000 + 90 + (i * 2) + 1] << 8) + (data[0x7000 + 90 + (i * 2)])));
                }
            }
            else
            {
                //not sprite format
                MessageBox.Show("Unknown file format !");
            }


            fs.Close();
            refreshEverything();
        }

        // IMPORT ROM
        private void exportYYPalette_Click(object sender, EventArgs e)
        {
            if (tempFolders[5] != null)
            {
                ExportYYPalettesaveDialog.InitialDirectory = tempFolders[5];
            }
            ExportYYPalettesaveDialog.ShowDialog();
        }

        private void ExportYYPalettesaveDialog_FileOk(object sender, CancelEventArgs e)
        {
            tempFolders[5] = Path.GetDirectoryName(ExportYYPalettesaveDialog.FileName);

            byte[] palette_data = new byte[0x300];
            int palette_data_i = 0;
            for (int i = 0; i < 16; i++)
            {
                palette_data[palette_data_i] = palette[i].R;
                palette_data[palette_data_i + 1] = palette[i].G;
                palette_data[palette_data_i + 2] = palette[i].B;
                palette_data_i += 3;
            }
            for (int i = 0; i < 16; i++)
            {
                palette_data[palette_data_i] = palette2[i].R;
                palette_data[palette_data_i + 1] = palette2[i].G;
                palette_data[palette_data_i + 2] = palette2[i].B;
                palette_data_i += 3;
            }
            for (int i = 0; i < 16; i++)
            {
                palette_data[palette_data_i] = palette3[i].R;
                palette_data[palette_data_i + 1] = palette3[i].G;
                palette_data[palette_data_i + 2] = palette3[i].B;
                palette_data_i += 3;
            }
            for (int i = 0; i < 16; i++)
            {
                palette_data[palette_data_i] = palette4[i].R;
                palette_data[palette_data_i + 1] = palette4[i].G;
                palette_data[palette_data_i + 2] = palette4[i].B;
                palette_data_i += 3;
            }

            FileStream fs = new FileStream(ExportYYPalettesaveDialog.FileName, FileMode.OpenOrCreate, FileAccess.Write);
            fs.Write(palette_data, 0, 0x300);
            fs.Close();
        }

        private void importYYPalette_Click(object sender, EventArgs e)
        {
            if (tempFolders[3] != null)
            {
                ImportYYPaletteopenDialog.InitialDirectory = tempFolders[3];
            }
            ImportYYPaletteopenDialog.ShowDialog();
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }

        private void exportSPR_Click(object sender, EventArgs e)
        {

        }

        // EXPORT SPR
        private void ExportSPRsaveDialog_FileOk(object sender, CancelEventArgs e)
        {
            tempFolders[6] = Path.GetDirectoryName(ExportSPRsaveDialog.FileName);

            if (ROM_DATA != null)
            {
                byte[] palette_data = new byte[0x78];
                int palette_data_i = 0;
                for (int i = 0; i < 15; i++)
                {
                    short s = (short)(((palette[i + 1].B / 8) << 10) | ((palette[i + 1].G / 8) << 5) | ((palette[i + 1].R / 8)));
                    palette_data[palette_data_i] = (byte)(s & 0x00FF);
                    palette_data[palette_data_i + 1] = (byte)((s >> 8) & 0x00FF);
                    palette_data_i += 2;
                }
                for (int i = 0; i < 15; i++)
                {
                    short s = (short)(((palette2[i + 1].B / 8) << 10) | ((palette2[i + 1].G / 8) << 5) | ((palette2[i + 1].R / 8)));
                    palette_data[palette_data_i] = (byte)(s & 0x00FF);
                    palette_data[palette_data_i + 1] = (byte)((s >> 8) & 0x00FF);
                    palette_data_i += 2;
                }
                for (int i = 0; i < 15; i++)
                {
                    short s = (short)(((palette3[i + 1].B / 8) << 10) | ((palette3[i + 1].G / 8) << 5) | ((palette3[i + 1].R / 8)));
                    palette_data[palette_data_i] = (byte)(s & 0x00FF);
                    palette_data[palette_data_i + 1] = (byte)((s >> 8) & 0x00FF);
                    palette_data_i += 2;
                }
                for (int i = 0; i < 15; i++)
                {
                    short s = (short)(((palette4[i + 1].B / 8) << 10) | ((palette4[i + 1].G / 8) << 5) | ((palette4[i + 1].R / 8)));
                    palette_data[palette_data_i] = (byte)(s & 0x00FF);
                    palette_data[palette_data_i + 1] = (byte)((s >> 8) & 0x00FF);
                    palette_data_i += 2;
                }
                data = new byte[0x7000 + 0x78];
                for (int i = 0;i<0x7000;i++)
                {
                    data[i] = ROM_DATA[0x80000 + i];
                }
                for (int i = 0; i < 0x78; i++)
                {
                    data[0x7000+i] =  palette_data[i];
                }

                FileStream fs = new FileStream(ExportSPRsaveDialog.FileName, FileMode.OpenOrCreate, FileAccess.Write);
                fs.Write(data, 0, 0x7000 + 0x78);
                fs.Close();
            }
        }

        private void ExportROMsaveDialog_FileOk(object sender, CancelEventArgs e)
        {
            tempFolders[7] = Path.GetDirectoryName(ExportROMsaveDialog.FileName);
            if (ROM_DATA != null)
            {
                byte[] palette_data = new byte[0x78];
                int palette_data_i = 0;
                for (int i = 0; i < 15; i++)
                {
                    short s = (short)(((palette[i + 1].B / 8) << 10) | ((palette[i + 1].G / 8) << 5) | ((palette[i + 1].R / 8)));
                    palette_data[palette_data_i] = (byte)(s & 0x00FF);
                    palette_data[palette_data_i + 1] = (byte)((s >> 8) & 0x00FF);
                    palette_data_i += 2;
                }
                for (int i = 0; i < 15; i++)
                {
                    short s = (short)(((palette2[i + 1].B / 8) << 10) | ((palette2[i + 1].G / 8) << 5) | ((palette2[i + 1].R / 8)));
                    palette_data[palette_data_i] = (byte)(s & 0x00FF);
                    palette_data[palette_data_i + 1] = (byte)((s >> 8) & 0x00FF);
                    palette_data_i += 2;
                }
                for (int i = 0; i < 15; i++)
                {
                    short s = (short)(((palette3[i + 1].B / 8) << 10) | ((palette3[i + 1].G / 8) << 5) | ((palette3[i + 1].R / 8)));
                    palette_data[palette_data_i] = (byte)(s & 0x00FF);
                    palette_data[palette_data_i + 1] = (byte)((s >> 8) & 0x00FF);
                    palette_data_i += 2;
                }
                for (int i = 0; i < 15; i++)
                {
                    short s = (short)(((palette4[i + 1].B / 8) << 10) | ((palette4[i + 1].G / 8) << 5) | ((palette4[i + 1].R / 8)));
                    palette_data[palette_data_i] = (byte)(s & 0x00FF);
                    palette_data[palette_data_i + 1] = (byte)((s >> 8) & 0x00FF);
                    palette_data_i += 2;
                }
                data = new byte[0x7000 + 0x78];
                for (int i = 0; i < 0x7000; i++)
                {
                    //data[i] = ROM_DATA[0x80000 + i];
                }
                for (int i = 0; i < 120; i++)
                {
                    ROM_DATA[0x0DD308+i] = palette_data[i];
                }

                FileStream fs = new FileStream(ExportROMsaveDialog.FileName, FileMode.OpenOrCreate, FileAccess.Write);
                fs.Write(ROM_DATA, 0, ROM_DATA.Length);
                fs.Close();
            }
        }

        private void exportSPR_Click_1(object sender, EventArgs e)
        {
            if (tempFolders[6] != null)
            {
                ExportSPRsaveDialog.InitialDirectory = tempFolders[6];
            }
            ExportSPRsaveDialog.ShowDialog();
        }

        // EXPORT ROM
        private void ExportROM_Click(object sender, EventArgs e)
        {
            if (tempFolders[7] != null)
            {
               ExportROMsaveDialog.InitialDirectory = tempFolders[7];
            }
            ExportROMsaveDialog.ShowDialog();
        }

        private void importGalePalette_Click(object sender, EventArgs e)
        {
            if (tempFolders[2] != null)
            {
                ImportGalePaletteopenDialog.InitialDirectory = tempFolders[2];
            }
            ImportGalePaletteopenDialog.ShowDialog();
        }

        private void ImportYYPaletteopenDialog_FileOk(object sender, CancelEventArgs e)
        {
            tempFolders[3] = Path.GetDirectoryName(ImportYYPaletteopenDialog.FileName);
            File.WriteAllLines("folderstemp.txt", tempFolders);
            byte[] palette_data = new byte[0x300];
            string[] text = File.ReadAllLines(ImportYYPaletteopenDialog.FileName);
            FileStream fs = new FileStream(ImportYYPaletteopenDialog.FileName, FileMode.OpenOrCreate, FileAccess.Read);
            fs.Read(palette_data, 0, 0x300);
            fs.Close();

            if (text.Length != 1)
            {
                MessageBox.Show("YY-CHR Palette files are binary. The palette file provided doesn't seem to be. Could this be an ASCII Palette file instead?", "Invalid Palette File", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int palette_data_i = 0;
                for (int i = 0; i < 16; i++)
                {
                    palette[i] = Color.FromArgb(((palette_data[palette_data_i] / 8) * 8), ((palette_data[palette_data_i + 1] / 8) * 8), ((palette_data[palette_data_i + 2] / 8) * 8));
                    palette_data_i += 3;
                }
                for (int i = 0; i < 16; i++)
                {
                    palette2[i] = Color.FromArgb(((palette_data[palette_data_i] / 8) * 8), ((palette_data[palette_data_i + 1] / 8) * 8), ((palette_data[palette_data_i + 2] / 8) * 8));
                    palette_data_i += 3;
                }
                for (int i = 0; i < 16; i++)
                {
                    palette3[i] = Color.FromArgb(((palette_data[palette_data_i] / 8) * 8), ((palette_data[palette_data_i + 1] / 8) * 8), ((palette_data[palette_data_i + 2] / 8) * 8));
                    palette_data_i += 3;
                }
                for (int i = 0; i < 16; i++)
                {
                    palette4[i] = Color.FromArgb(((palette_data[palette_data_i] / 8) * 8), ((palette_data[palette_data_i + 1] / 8) * 8), ((palette_data[palette_data_i + 2] / 8) * 8));
                    palette_data_i += 3;
                }
            }

            refreshEverything();

        }

        private void ImportGalePaletteopenDialog_FileOk(object sender, CancelEventArgs e)
        {
            //Graphics Gale Palette load
            tempFolders[2] = Path.GetDirectoryName(ImportGalePaletteopenDialog.FileName);
            string[] text = File.ReadAllLines(ImportGalePaletteopenDialog.FileName);
            if(text.Length == 1) {
                MessageBox.Show("Graphics Gale Palette files are ASCII. The palette file provided doesn't seem to be. Could this be a YY-CHR Palette file instead?", "Invalid Palette File", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                for (int i = 3; i < 19; i++)
                {
                    string[] colorstring = text[i].Split(' ');
                    int R;
                    int G;
                    int B;
                    Int32.TryParse(colorstring[0], out R);
                    Int32.TryParse(colorstring[1], out G);
                    Int32.TryParse(colorstring[2], out B);
                    if (comboBox1.SelectedIndex == 0)
                    {
                        palette[i - 3] = Color.FromArgb(((R / 16) * 16), ((G / 16) * 16), ((B / 16) * 16));
                    }
                    if (comboBox1.SelectedIndex == 1)
                    {
                        palette2[i - 3] = Color.FromArgb(((R / 16) * 16), ((G / 16) * 16), ((B / 16) * 16));
                    }
                    if (comboBox1.SelectedIndex == 2)
                    {
                        palette3[i - 3] = Color.FromArgb(((R / 16) * 16), ((G / 16) * 16), ((B / 16) * 16));
                    }
                    if (comboBox1.SelectedIndex == 3)
                    {
                        palette4[i - 3] = Color.FromArgb(((R / 16) * 16), ((G / 16) * 16), ((B / 16) * 16));
                    }

                }
            }
            refreshEverything();


        }

        private void exportGalePalette_Click(object sender, EventArgs e)
        {
            if (tempFolders[8] != null)
            {
                ExportGalePalettesaveDialog.InitialDirectory = tempFolders[8];
            }
            ExportGalePalettesaveDialog.ShowDialog();
        }

        private void ExportGalePalettesaveDialog_FileOk(object sender, CancelEventArgs e)
        {
            tempFolders[8] = Path.GetDirectoryName(ExportGalePalettesaveDialog.FileName);

            string text = "JASC-PAL\n0100\n16\n";
            
            for (int i = 0; i < 16; i++)
            {
                if (comboBox1.SelectedIndex == 0)
                {
                    text += palette[i].R.ToString() + " " + palette[i].G.ToString() + " " + palette[i].B.ToString() + "\n";
                }
                if (comboBox1.SelectedIndex == 1)
                {
                    text += palette2[i].R.ToString() + " " + palette2[i].G.ToString() + " " + palette2[i].B.ToString() + "\n";
                }
                if (comboBox1.SelectedIndex == 2)
                {
                    text += palette3[i].R.ToString() + " " + palette3[i].G.ToString() + " " + palette3[i].B.ToString() + "\n";
                }
                if (comboBox1.SelectedIndex == 3)
                {
                    text += palette4[i].R.ToString() + " " + palette4[i].G.ToString() + " " + palette4[i].B.ToString() + "\n";
                }

            }
            File.WriteAllText(ExportGalePalettesaveDialog.FileName, text);
        }

        private void importSPR_Click_1(object sender, EventArgs e)
        {
            if (tempFolders[1] != null)
            {
                ImportSPRopenDialog.InitialDirectory = tempFolders[1];
            }
            ImportSPRopenDialog.ShowDialog();

        }

        private void exportPNG_Click(object sender, EventArgs e)
        {
            if (tempFolders[9] != null)
            {
                ExportPNGsaveDialog.InitialDirectory = tempFolders[9];
            }
            ExportPNGsaveDialog.ShowDialog();
        }

        private void ExportPNGsaveDialog_FileOk(object sender, CancelEventArgs e)
        {
            tempFolders[9] = Path.GetDirectoryName(ExportPNGsaveDialog.FileName);
            Bitmap tempBitmap = new Bitmap(128, 448);
            Graphics gg = Graphics.FromImage(tempBitmap);
            for (int i = 0; i < 14; i++)
            {
                load4bpp(i);
                updateGraphic(i);
                gg.DrawImage(loadedblocks, new Rectangle(0, i * 32, 128, 32), 0, 0, 128, 32, GraphicsUnit.Pixel);
            }
            tempBitmap.Save(ExportPNGsaveDialog.FileName, System.Drawing.Imaging.ImageFormat.Png);
        }


        private void ProcessUsingLockbits(Bitmap processedBitmap)
        {
            BitmapData bitmapData = processedBitmap.LockBits(new Rectangle(0, 0, processedBitmap.Width, processedBitmap.Height), ImageLockMode.ReadWrite, processedBitmap.PixelFormat);

            int bytesPerPixel = Bitmap.GetPixelFormatSize(processedBitmap.PixelFormat) / 8;
            int byteCount = bitmapData.Stride * processedBitmap.Height;
            byte[] pixels = new byte[byteCount];
            IntPtr ptrFirstPixel = bitmapData.Scan0;
            Marshal.Copy(ptrFirstPixel, pixels, 0, pixels.Length);
            int heightInPixels = bitmapData.Height;
            int widthInBytes = bitmapData.Width * bytesPerPixel;
            int pix = 0;
            for (int y = 0; y < heightInPixels; y++)
            {
//                byte blue = 0;
                int currentLine = y * bitmapData.Stride;
                for (int x = 0; x < widthInBytes; x = x + bytesPerPixel)
                {
                    // calculate new pixel value
                    if (selected_palette == 0)
                    {
                        pixels[currentLine + x] = palette[bitmap_data[pix]].B;
                        pixels[currentLine + x + 1] = palette[bitmap_data[pix+1]].G;
                        pixels[currentLine + x + 2] = palette[bitmap_data[pix+2]].R;
                    }
                    else if (selected_palette == 1)
                    {
                        pixels[currentLine + x] = palette2[bitmap_data[pix]].B;
                        pixels[currentLine + x + 1] = palette2[bitmap_data[pix + 1]].G;
                        pixels[currentLine + x + 2] = palette2[bitmap_data[pix + 2]].R;
                    }
                    else if (selected_palette == 2)
                    {
                        pixels[currentLine + x] = palette3[bitmap_data[pix]].B;
                        pixels[currentLine + x + 1] = palette3[bitmap_data[pix + 1]].G;
                        pixels[currentLine + x + 2] = palette3[bitmap_data[pix + 2]].R;
                    }
                    else if (selected_palette == 3)
                    {
                        pixels[currentLine + x] = palette4[bitmap_data[pix]].B;
                        pixels[currentLine + x + 1] = palette4[bitmap_data[pix + 1]].G;
                        pixels[currentLine + x + 2] = palette4[bitmap_data[pix + 2]].R;
                    }

                    pix += 3;
                    //Console.Write(currentLine + ",");
                    /*pixels[currentLine + x] = blue;
                    pixels[currentLine + x + 1] = blue;
                     pixels[currentLine + x + 2] = blue;
                    blue++;*/
                }
                
            }

            // copy modified bytes back
            Marshal.Copy(pixels, 0, ptrFirstPixel, pixels.Length);
            processedBitmap.UnlockBits(bitmapData);
        }
        int selected_palette = 0;
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                label4.Text = "Hands   \\";
                selected_palette = 0;
            }
            if (comboBox1.SelectedIndex == 1)
            {
                label4.Text = "Gloves   \\";
                selected_palette = 1;
            }
            if (comboBox1.SelectedIndex == 2)
            {
                label4.Text = "Mitts     \\";
                selected_palette = 2;
            }
            if (comboBox1.SelectedIndex == 3)
            {
                label4.Text = "";
                selected_palette = 3;
            }
            refreshEverything();
        }

        private void openFileDialog5_FileOk(object sender, CancelEventArgs e)
        {
            tempFolders[4] = Path.GetDirectoryName(openFileDialog5.FileName);

        }

        private void importPNG_Click(object sender, EventArgs e)
        {
            ImporterForm form = new ImporterForm();
            form.ShowDialog();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        // INJECT SPR TO ROM
        //  Select SPR
        private void injectROM_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1. Load SPR\n2. Load ROM\n3. Windows will warn you that the ROM exists. This app will NOT overwrite your ROM file.", "Sprite Injection", MessageBoxButtons.OK, MessageBoxIcon.Information);
            InjectSPRopenDialog.ShowDialog();
        }
        byte[] sprite_data = new byte[0x7078];

        // INJECT SPR TO ROM
        //  Select ROM
        private void InjectSPRopenDialog_FileOk(object sender, CancelEventArgs e)
        {
            //filestream open .spr file
            FileStream fs = new FileStream(InjectSPRopenDialog.FileName, FileMode.Open, FileAccess.Read);
            fs.Read(sprite_data,0,0x7078);
            fs.Close();
            InjectROMsaveDialog.ShowDialog();
        }
        byte[] rom_patch;

        // INJECT SPR TO ROM
        //  Write ROM
        private void InjectROMsaveDialog_FileOk(object sender, CancelEventArgs e)
        {
            //filestream save .spr file
            FileStream fs = new FileStream(InjectROMsaveDialog.FileName, FileMode.Open, FileAccess.ReadWrite);
            string spriteFullPath = "";
            string spriteFileName = "MOO";
            spriteFullPath = InjectSPRopenDialog.FileName;
            spriteFileName = Path.GetFileName(spriteFullPath);
            spriteFileName = spriteFileName.Substring(0,spriteFileName.LastIndexOf("."));
            string destFullPath = InjectROMsaveDialog.FileName;
            string destFileName = Path.GetFileName(destFullPath);
            destFullPath = destFullPath.Replace(destFileName, spriteFileName + "-" + destFileName);
            FileStream dest = new FileStream(destFullPath, FileMode.Create, FileAccess.Write);
            rom_patch = new byte[fs.Length];
            fs.Read(rom_patch, 0, (int)fs.Length);
            fs.Position = 0;

            for(int i = 0;i<0x7000;i++)
            {
                rom_patch[0x80000 + i] = sprite_data[i];
            }
            for (int i = 0; i < 0x78; i++)
            {
                rom_patch[0x0DD308 + i] = sprite_data[i+0x7000];
            }

            dest.Write(rom_patch, 0, (int)fs.Length);


            fs.Close();
            dest.Close();
        }

    }
}
