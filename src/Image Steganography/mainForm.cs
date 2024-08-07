using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.IO;
using System.Diagnostics;

namespace IMG_Stego
{
    public partial class FormStego : Form
    {
        public FormStego()
        {
            InitializeComponent();

            buttonSave1.Enabled = false;
            buttonApply1.Enabled = false;
            groupBoxPlainFile.Hide();
            groupBoxRecodedFile.Hide();
            buttonEmbed.Enabled = false;
            buttonSaveAsEmbed.Enabled = false;
            buttonDeText.Enabled = false;
            buttonExtractAndSave.Enabled = false;
            textBox2.Hide();
        }

        #region global_variables

        byte[] data;
        Bitmap mainImage;
        Bitmap EncryptedImage;
        OpenFileDialog ofd = new OpenFileDialog();
        string[] type = new string[3];

        #endregion

        private byte getByte(byte[] bits)
        {
            String bitString = "";
            for (int i = 0; i < 8; i++)
                bitString += bits[i];
            byte newpix = Convert.ToByte(bitString, 2);
            int dePix = (int)newpix;
            return (byte)dePix;
        }

        private byte[] getStringBits(string data)
        {
            byte[] text = System.Text.ASCIIEncoding.ASCII.GetBytes(data);
            BitArray bits = new BitArray(text);
            bool[] boolarray = new bool[bits.Count];
            bits.CopyTo(boolarray, 0);
            byte[] bitsArray = boolarray.Select(bit => (byte)(bit ? 1 : 0)).ToArray();
            Array.Reverse(bitsArray);
            return bitsArray;
        }

        private byte[] getBits(byte simplepixel)
        {
            int pixel = 0;
            pixel = (int)simplepixel;
            BitArray bits = new BitArray(new byte[] { (byte)pixel });
            bool[] boolarray = new bool[bits.Count];
            bits.CopyTo(boolarray, 0);
            byte[] bitsArray = boolarray.Select(bit => (byte)(bit ? 1 : 0)).ToArray();
            Array.Reverse(bitsArray);
            return bitsArray;
        }

        public void binRead()
        {
            DialogResult orb = openFileDialog1.ShowDialog();

            if (orb == DialogResult.OK)
            {
                string path = openFileDialog1.FileName;

                try
                {
                    using (FileStream fs = File.Open(path, FileMode.Open))
                    {
                        data = new BinaryReader(fs).ReadBytes((int)fs.Length);
                    }
                }
                catch (IOException ioe)
                {
                    MessageBox.Show("Error while opening file!" + ioe.Message);
                }
            }
        }

        /*This method is used to embed data into pixels*/
        public Color embed(Color pixel, byte[] bits)
        {

            byte[] RedBits = getBits((byte)pixel.R);
            byte[] GreenBits = getBits((byte)pixel.G);
            byte[] BlueBits = getBits((byte)pixel.B);

            /*LSB substition of RGB values is done as following:
            Red: Last 3 bits, Green: Last 3 bits, Blue: Last 2 bits
            This process lets us embed 1 byte in each pixel*/

            #region BitChange
            RedBits[5] = bits[0];
            GreenBits[5] = bits[1];
            RedBits[6] = bits[2];
            RedBits[7] = bits[3];
            GreenBits[6] = bits[4];
            GreenBits[7] = bits[5];
            BlueBits[6] = bits[6];
            BlueBits[7] = bits[7];

            byte newRed = getByte(RedBits);
            byte newGreen = getByte(GreenBits);
            byte newBlue = getByte(BlueBits);

            return Color.FromArgb(newRed, newGreen, newBlue);
            #endregion

        }

        /*This method is used to extract data from pixels*/
        public byte extract(Color pixel)
        {
            byte[] RedBits = getBits((byte)pixel.R);
            byte[] GreenBits = getBits((byte)pixel.G);
            byte[] BlueBits = getBits((byte)pixel.B);
            byte[] BitsToDecrypt = new byte[8];

            BitsToDecrypt[0] = RedBits[5];
            BitsToDecrypt[1] = GreenBits[5];
            BitsToDecrypt[2] = RedBits[6];
            BitsToDecrypt[3] = RedBits[7];
            BitsToDecrypt[4] = GreenBits[6];
            BitsToDecrypt[5] = GreenBits[7];
            BitsToDecrypt[6] = BlueBits[6];
            BitsToDecrypt[7] = BlueBits[7];

            return getByte(BitsToDecrypt);
        }

        private void buttonBrowse1_Click(object sender, EventArgs e)
        {
            ofd = new OpenFileDialog();
            //ofd.Filter = "All picture files|*.bmp; *.dib;*.jpg;*.jpeg;*.jpe;*.jfif;*.tif;*.tiff;*.gif;*.png|Bitmap files (*.bmp,*.dib)|*.bmp;*.dib|JPEG (*.jpg,*.jpeg,*.jpe,*.jfif)|*.jpg;*.jpeg;*.jpe;*.jfif|TIFF (*.tif,*.tiff)|*.tif;*.tiff|GIF (*.gif)|*.gif|PNG (*.png)|*.png";
            ofd.Filter = "Bitmap files (*.bmp,*.dib)|*.bmp;*.dib|PNG (*.png)|*.png";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBoxCoverImage.ImageLocation = ofd.FileName;
                textBoxBrowseMessage.Text = ofd.FileName;
                Bitmap img = new Bitmap(ofd.FileName);
                labelImageSize.Text = "Image size: " + Convert.ToString(img.Width) + " x " + Convert.ToString(img.Height);

                if (string.IsNullOrEmpty(richTextPlain.Text) == false)
                {
                    buttonApply1.Enabled = true;
                }
                if (string.IsNullOrEmpty(textBoxFileMessage.Text) == false)
                {
                    buttonEmbed.Enabled = true;
                }  
            }
           
        }

        //Enable "Apply" button only after typing some message.
        private void richTextPlain_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxBrowseMessage.Text) == false)
            {
                buttonApply1.Enabled = true;
            }
        }

        //Embed message...
        private void buttonApply1_Click(object sender, EventArgs e)
        {
            string textbox = richTextPlain.Text;
            char[] textarray = richTextPlain.Text.ToArray();

            mainImage = new Bitmap(pictureBoxCoverImage.Image);
            labelProgress.Text = "";
            labelText.Text = "Text length: " + Convert.ToString(textbox.Length) + " characters";

            /* Encoding process */
            #region Encoding

            //Embed type of data into last 3 pixels.
            #region type_embed
            // "tt1" is the code to define hidden data is a text message. (type:text:1)
            string[] type = new string[] { "t", "t", "1" };

            for (int j = 0; j < 3; j++)
            {
                Color pixel = mainImage.GetPixel(mainImage.Width - j - 1, mainImage.Height - 1);
                pixel = embed(pixel, getStringBits(type[j]));
                mainImage.SetPixel(mainImage.Width - j - 1, mainImage.Height - 1, pixel);
            }

            #endregion
            
            // Embed length of message into 13 pixels in reverse [3:15]
            #region length_embed

            string a = Convert.ToString((richTextPlain.Text).Length);
            a = a.PadLeft(13, '0'); //Zero-padding
            char[] b = a.ToArray();

            for (int j = 3; j < 16; j++)
            {
                string aString = Convert.ToString(b[j-3]);
                Color pixel = mainImage.GetPixel(mainImage.Width - j - 1, mainImage.Height - 1);
                pixel = embed(pixel, getStringBits(aString));
                mainImage.SetPixel(mainImage.Width - j - 1, mainImage.Height - 1, pixel);
            }

            #endregion

            int k = 0;
            progressBar1.Minimum = 0;
            progressBar1.Maximum = textbox.Length-1;

            labelProgress.Text = "Processing...";

            for (int i = 0; i < mainImage.Height; i++)
            {
                    for (int j = 0; j < mainImage.Width; j++)
                    {
                        if (k < textbox.Length)
                        {
                            string msg = Convert.ToString(textarray[k]);
                            Color pixel = mainImage.GetPixel(j, i);     
                            pixel = embed(pixel, getStringBits(msg));
                            mainImage.SetPixel(j, i, pixel);
                            progressBar1.Value = k;
                            k++;
                        }
                     
                    } 
            }

            labelProgress.Text = "Completed!";
            #endregion

            buttonSave1.Enabled = true;
            
        }

        //Save stego image...
        private void buttonSave1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveEncoded = new SaveFileDialog();
            saveEncoded.Filter = "Bitmap files (*.bmp)|*.bmp";

            string pathEncoded = "";

            if (saveEncoded.ShowDialog() == DialogResult.OK)
            {
                pathEncoded = saveEncoded.FileName;
            }

            try
            {
                mainImage.Save(pathEncoded);

                MessageBox.Show("Image has been successfully saved in the following path!\n" + pathEncoded);
            }
            catch (IOException ioe)
            {
                MessageBox.Show("Error while writing file!" + ioe.Message);
            }
        }

        //Read file in binary format...
        private void buttonOpen1_Click(object sender, EventArgs e)
        {
            binRead();
            textBoxFileMessage.Text = openFileDialog1.FileName;
            if (pictureBoxCoverImage.Image != null) buttonEmbed.Enabled = true;
        }

        //Embed file into cover image...
        private void buttonFApply1_Click(object sender, EventArgs e)
        {
            string path = openFileDialog1.FileName;
            string name = openFileDialog1.SafeFileName;

            labelProgress.Text = "Processing...";

            using (FileStream fs = File.Open(path, FileMode.Open))
            {
                data = new BinaryReader(fs).ReadBytes((int)fs.Length);
            }

            mainImage = new Bitmap(textBoxBrowseMessage.Text);

            // Embedding binary data
            #region Encoding

            if (data.Length > mainImage.Height * mainImage.Width - 30 ) MessageBox.Show("Data is larger than image size!");
            else
            {

                //Embed data type into 3 pixels.
                #region type_embed

                // "tb1" is the code to define hidden data is a binary file. (type:binary:1)
                string[] type = { "t", "b", "1" };

                for (int j = 0; j < 3; j++)
                {
                    Color pixel = mainImage.GetPixel(mainImage.Width - j - 1, mainImage.Height - 1);
                    pixel = embed(pixel, getStringBits(type[j]));
                    mainImage.SetPixel(mainImage.Width - j - 1, mainImage.Height - 1, pixel);
                }

                #endregion

                /*Embed length of data into last 13 pixels of cover image.
                  Supported maximum image size using 13 pixels = (width x height = 10^13 - 1)*/
                #region dataLength_embed(13 pixels)

                string a = (Convert.ToString(data.Length)).PadLeft(13,'0'); //Zero-padding
                char[] b = a.ToArray();

                for (int j = 3; j < 16; j++)
                {
                    string aString = Convert.ToString(b[j-3]);
                    Color pixel = mainImage.GetPixel(mainImage.Width - j - 1, mainImage.Height - 1);
                    pixel = embed(pixel, getStringBits(aString));
                    mainImage.SetPixel(mainImage.Width - j - 1, mainImage.Height - 1, pixel);
                }
                #endregion

                //Embed file name into cover image.
                #region name_embed(4 + name.Length pixels)

                //Embed length of file name into 4 pixels.
                #region name_length(3 pixels)

                string lname = Convert.ToString(name.Length).PadLeft(4, '0');
                char[] nl = lname.ToArray();

                for (int j = 16; j < 20; j++)
                {
                    string nlString = Convert.ToString(nl[j - 16]);
                    Color pixel = mainImage.GetPixel(mainImage.Width - j - 1, mainImage.Height - 1);
                    pixel = embed(pixel, getStringBits(nlString));
                    mainImage.SetPixel(mainImage.Width - j - 1, mainImage.Height - 1, pixel);
                }

                #endregion

                char[] cname = name.ToArray();

                for (int j = 20; j < 20 + name.Length; j++)
                {
                    string name_array = Convert.ToString(cname[j - 20]);
                    Color pixel = mainImage.GetPixel(mainImage.Width - j - 1, mainImage.Height - 1);
                    pixel = embed(pixel, getStringBits(name_array));
                    mainImage.SetPixel(mainImage.Width - j - 1, mainImage.Height - 1, pixel);
                }

                #endregion

                //Embed binary data into cover image.
                #region data_embed

                int k = 0;
                progressBar1.Minimum = 0;
                progressBar1.Maximum = data.Length - 1;

                for (int i = 0; i < mainImage.Height; i++)
                {
                        for (int j = 0; j < mainImage.Width; j++)
                        {
                            if (k < data.Length)
                            {
                                Color pixel = mainImage.GetPixel(j, i);
                                pixel = embed(pixel, getBits(data[k]));
                                mainImage.SetPixel(j, i, pixel);
                                progressBar1.Value = k;
                                k++;
                            }
                    }
                }

                pictureBoxShow.Image = mainImage;
                labelProgress.Text = "Completed!";
                buttonSaveAsEmbed.Enabled = true;
                #endregion
            #endregion

            }
        }

        //Save stego image...
        private void buttonSaveAs1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveEncoded = new SaveFileDialog();
            saveEncoded.Filter = "Bitmap files (*.bmp)|*.bmp";
            string pathEncoded = "";

            if (saveEncoded.ShowDialog() == DialogResult.OK)
            {
                pathEncoded = saveEncoded.FileName;
            }

            try
            {
                mainImage.Save(pathEncoded);
                MessageBox.Show("Stego image has been saved successfully!\n" + pathEncoded);
            }
            catch (IOException ioe)
            {
                MessageBox.Show("Error while writing file!" + ioe.Message);
            }
        }

        //Text embedding - radioButton
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxPlainFile.Show();
            groupBoxPlainText.Hide();
        }

        //File embedding - radioButton
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxPlainFile.Hide();
            groupBoxPlainText.Show();
        }

        //Open stego image...
        private void buttonBrowse2_Click(object sender, EventArgs e)
        {
            //ofd.Filter = "All picure files|*.bmp; *.dib;*.jpg;*.jpeg;*.jpe;*.jfif;*.tif;*.tiff;*.gif;*.png|Bitmap files (*.bmp,*.dib)|*.bmp;*.dib|JPEG (*.jpg,*.jpeg,*.jpe,*.jfif)|*.jpg;*.jpeg;*.jpe;*.jfif|TIFF (*.tif,*.tiff)|*.tif;*.tiff|GIF (*.gif)|*.gif|PNG (*.png)|*.png";
            ofd.Filter = "Bitmap files (*.bmp,*.dib)|*.bmp;*.dib|PNG (*.png)|*.png";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBoxEncoded2.ImageLocation = ofd.FileName;
                textBoxBrowse2.Text = ofd.FileName;

                #region type_extract

                EncryptedImage = new Bitmap(ofd.FileName);
                textBox2.Show();
                textBox2.Text = "";

                for (int j = 0; j < 3; j++)
                {
                    Color pixelToDecode = EncryptedImage.GetPixel(EncryptedImage.Width - j - 1, EncryptedImage.Height - 1);
                    byte detype = extract(pixelToDecode);
                    type[j] = Encoding.ASCII.GetString(BitConverter.GetBytes(detype));
                    textBox2.Text += type[j];
                }
                char[] typex = (textBox2.Text).ToCharArray();

                #endregion

                if (typex[0] == 't' && typex[1] == 't' && typex[2] == '1')
                {
                    radioButtonExtractText.Enabled = true;
                    radioButtonExtractText.Checked = true;
                    radioButtonExtractFile.Enabled = false;
                    radioButtonExtractFile.Checked = false;
                    groupBoxRecodedText.Show();
                    groupBoxRecodedFile.Hide();
                    buttonDeText.Enabled = true;
                    Bitmap img = new Bitmap(ofd.FileName);
                    labelImageSize2.Text = "Image size: " + Convert.ToString(img.Width) + " x " + Convert.ToString(img.Height);
                }
                else if (typex[0] == 't' && typex[1] == 'b' && typex[2] == '1')
                {
                    radioButtonExtractText.Checked = true;
                    radioButtonExtractText.Enabled = false;
                    radioButtonExtractFile.Enabled = true;
                    radioButtonExtractFile.Checked = true;
                    groupBoxRecodedFile.Show();
                    groupBoxRecodedText.Hide();

                    if (string.IsNullOrEmpty(textBoxBrowse2.Text) == false)
                    {
                        buttonExtractAndSave.Enabled = true;
                    }
                    else
                    {
                        buttonExtractAndSave.Enabled = false;
                    }

                    Bitmap img = new Bitmap(ofd.FileName);
                    labelImageSize2.Text = "Image size: " + Convert.ToString(img.Width) + " x " + Convert.ToString(img.Height);
                }
                else
                {
                    MessageBox.Show("No stego data has been found in selected picture!\nChoose another stego image to continue!","Warning!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                textBox2.Hide();
            }
        }

        //Extract message from stego image...
        private void buttonDeText_Click(object sender, EventArgs e)
        {
            EncryptedImage = new Bitmap(pictureBoxEncoded2.Image);
            richTextBoxDecoded.Text = "";

            /* Decoding process */
            #region Decoding

            int k = 0;
            string tlength = "";

            #region length_extract

            for (int j = 3; j < 16; j++)
            {
                Color pixelToDecode = EncryptedImage.GetPixel(EncryptedImage.Width - j - 1, EncryptedImage.Height - 1);
                byte delength = extract(pixelToDecode);
                tlength += Convert.ToInt32(Encoding.ASCII.GetString(BitConverter.GetBytes(delength)));
            }

            int length = Convert.ToInt32(tlength);
            label_Text2.Text = "Text length: " + Convert.ToString(length)+ " characters";

            #endregion

            k = 0;
            progressBar2.Minimum = 0;
            progressBar2.Maximum = length - 1;

            for (int i = 0; i < EncryptedImage.Height; i++)
            {
                for (int j = 0; j < EncryptedImage.Width; j++)
                {
                    if (k < length)
                    {
                        Color pixelToDecode = EncryptedImage.GetPixel(j, i);
                        byte demsg = extract(pixelToDecode);
                        richTextBoxDecoded.Text += Encoding.ASCII.GetString(BitConverter.GetBytes(demsg));
                        progressBar2.Value = k;
                        k++;
                    }                    
                }
            }

            labelProgress.Text = "Completed!";
            #endregion
        }

        //File extraction...
        private void button1_Click(object sender, EventArgs e)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            richTextBoxInfo.Text = "> Loading...\n";
            labelProgress.Text = "Processing...";
            EncryptedImage = new Bitmap(pictureBoxEncoded2.Image);

            /* Decoding process */
            #region Decoding

            int k = 0;

            //Extract length of file from last 13 pixels [3:15].
            #region data_length

            string flength = "";

            for (int j = 3; j < 16; j++)
            {
                Color pixelToDecode = EncryptedImage.GetPixel(EncryptedImage.Width - j - 1, EncryptedImage.Height - 1);
                byte delength = extract(pixelToDecode);                
                flength += Convert.ToInt32(Encoding.ASCII.GetString(BitConverter.GetBytes(delength)));
            }

            int length = Convert.ToInt32(flength);

            #endregion

            //Extract file name from the picture
            #region name

            //Extract length of file name from 4 pixels in the picture [16:19]
            #region name_length

            string dlength = "";

            for (int j = 16; j < 20; j++)
            {
                Color pixelToDecode = EncryptedImage.GetPixel(EncryptedImage.Width - j - 1, EncryptedImage.Height - 1);
                byte delength = extract(pixelToDecode);
                dlength += Convert.ToInt32(Encoding.ASCII.GetString(BitConverter.GetBytes(delength)));
            }

            int name_length = Convert.ToInt32(dlength);

            #endregion

            textBox1.Text = "";

            for (int j = 20; j < 20 + name_length; j++)
            {
                Color pixelToDecode = EncryptedImage.GetPixel(EncryptedImage.Width - j - 1, EncryptedImage.Height - 1);
                byte delength = extract(pixelToDecode);
                textBox1.Text += Encoding.ASCII.GetString(BitConverter.GetBytes(delength));
            }

            string name = textBox1.Text;

            #endregion

            //Extract binary data from stego image.
            byte[] data = new byte[length];

            for (int i = 0; i < EncryptedImage.Height; i++)
            {

                for (int j = 0; j < EncryptedImage.Width; j++)
                {
                    if (k < length)
                    {
                        Color pixelToDecode = EncryptedImage.GetPixel(j, i);
                        byte demsg = extract(pixelToDecode);
                        data[k] = demsg;
                        k++;
                    }
                }
            }

            labelProgress.Text = "Completed!";
            string pathRecoded = Path.GetDirectoryName(ofd.FileName) + "\\" + name;

            #endregion

            sw.Stop();
            string time = string.Format("{0} mins, {1} secs", sw.Elapsed.Minutes, sw.Elapsed.Seconds);

            richTextBoxInfo.Text += "> It's done!\n";
            richTextBoxInfo.Text += "> Duration: " + time + "\n\n";

            try
            {

                if (File.Exists(pathRecoded))
                {
                    if (MessageBox.Show(name + " already exists!\nOverwrite?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        FileStream write = new FileStream(pathRecoded, FileMode.Create);
                        BinaryWriter writeBinary = new BinaryWriter(write);
                        writeBinary.Write(data);
                        writeBinary.Close();
                        richTextBoxInfo.Text += "> Extracted file : " + name + "\n";
                        richTextBoxInfo.Text += "> Extraction path: " + Path.GetDirectoryName(ofd.FileName) + "\n\n";
                        //Load path
                        Process.Start(Path.GetDirectoryName(ofd.FileName));
                    }
                }
                else
                {
                    FileStream write = new FileStream(pathRecoded, FileMode.Create);
                    BinaryWriter writeBinary = new BinaryWriter(write);
                    writeBinary.Write(data);
                    writeBinary.Close();
                    richTextBoxInfo.Text += "> Extracted file : " + name + "\n";
                    richTextBoxInfo.Text += "> Extraction path: " + Path.GetDirectoryName(ofd.FileName) + "\n\n";
                    // Load path
                    Process.Start(Path.GetDirectoryName(ofd.FileName));
                }
               
            }
            catch (IOException ioe)
            {
                MessageBox.Show("Error while writing file!" + ioe.Message);
            }
        }

        //Extract text - radioButton
        private void radioButtonExtractText_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxRecodedFile.Hide();
            groupBoxRecodedText.Show();
        }

        //Exctact file - radioButton
        private void radioButtonExtractFile_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxRecodedFile.Show();
            groupBoxRecodedText.Hide();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string app = "IMG Stego v1.0";
            string author = "Kadir Tekeli ";
            string year = " 2015 ";
            string email = "kadir.tekeli@outlook.com";

            MessageBox.Show("\t" + app + "\t\n\n\n\t" + author + (char)169 + year + "\n\t" + email + "\t\t", "About", MessageBoxButtons.OK);
        }

    }
}
