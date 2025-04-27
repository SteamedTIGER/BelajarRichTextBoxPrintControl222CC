using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//copy punya rtb ke picture box
//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Text;
//using System.Windows.Forms;
//-----------------------------------



namespace BelajarRichTextBoxPrintControl222CC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.printDocument1.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument1_BeginPrint);
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            //this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            this.btnPrintPreview.Click += new System.EventHandler(this.btnPrintPreview_Click);
            this.btnPageSetup.Click += new System.EventHandler(this.btnPageSetup_Click);
        }
        private int checkPrint;
        private void btnPageSetup_Click(object sender, System.EventArgs e)
        {
            pageSetupDialog1.ShowDialog();
        }

        private void btnPrintPreview_Click(object sender, System.EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void btnPrint_Click(object sender, System.EventArgs e)
        {
            if (printDialog1.ShowDialog() == DialogResult.OK)
                printDocument1.Print();
        }

        private void printDocument1_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            
            checkPrint = 0;
   
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // Print the content of RichTextBox. Store the last character printed.
            checkPrint = richTextBoxPrintCtrl1.Print(checkPrint, richTextBoxPrintCtrl1.TextLength, e);

            // Check for more pages
            if (checkPrint < richTextBoxPrintCtrl1.TextLength)
                e.HasMorePages = true;
            else
                e.HasMorePages = false;
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
           // richTextBoxPrintCtrl1.Select(richTextBoxPrintCtrl1.TextLength, 0);
            richTextBoxPrintCtrl1.SelectionFont = new Font("courier new", 10, FontStyle.Italic);
            
            richTextBoxPrintCtrl1.SelectionColor = Color.Red;
            richTextBoxPrintCtrl1.AppendText("AAAAAAAA" + "AAAbbb" + "\n");
            richTextBoxPrintCtrl1.AppendText("AAAAAAAA" + "AAAbbb" + "\n");
            richTextBoxPrintCtrl1.SelectionColor = Color.BlanchedAlmond ;
            richTextBoxPrintCtrl1.SelectionFont = new Font("courier new", 40, FontStyle.Italic);
            richTextBoxPrintCtrl1.AppendText("AAAAAAAA" + "\n");
            richTextBoxPrintCtrl1.AppendText("AAAAAAAA" + "AAAbbb" + "\n");
            richTextBoxPrintCtrl1.AppendText("AAAAAAAA" + "AAAbbb" + "\n");
            richTextBoxPrintCtrl1.SelectionColor = Color.OrangeRed;
            richTextBoxPrintCtrl1.AppendText("bbb" + "AAAbbb" + "\n");
            richTextBoxPrintCtrl1.SelectionFont   = new Font("AR CARTER Medium", 10, FontStyle.Italic);
            richTextBoxPrintCtrl1.SelectionColor = Color.Yellow;
            richTextBoxPrintCtrl1.AppendText("ccc" + "AAAbbb" + "\n");
            richTextBoxPrintCtrl1.SelectionColor = Color.YellowGreen;
            richTextBoxPrintCtrl1.AppendText("ddd" + "AAAbbb" + "\n");
            richTextBoxPrintCtrl1.SelectionColor = Color.Green;
            richTextBoxPrintCtrl1.AppendText("eee" + "AAAbbb" + "\n");
            richTextBoxPrintCtrl1.SelectionColor = Color.Blue;
            richTextBoxPrintCtrl1.AppendText("ffff" + "AAAbbb" + "\n");
            richTextBoxPrintCtrl1.SelectionColor = Color.Purple;
            richTextBoxPrintCtrl1.AppendText("gggg" + "AAAbbb" + "\n");
        }

        private void Button2_Click_1(object sender, EventArgs e)
        {
            //    '////////block dulu rtc nya semua terus setting font, trs tambahkan text
            //richTextBoxPrintCtrl1.Select(richTextBoxPrintCtrl1.TextLength, 0);
            richTextBoxPrintCtrl1.SelectionFont = new Font("Courier New", 15, FontStyle.Bold);
            richTextBoxPrintCtrl1.SelectionColor = Color.Purple;
            richTextBoxPrintCtrl1.AppendText(TextBox1.Text + "\n");
           // richTextBoxPrintCtrl1.Select(richTextBoxPrintCtrl1.TextLength, 0);
            richTextBoxPrintCtrl1.SelectionFont = new Font("Courier New", 5, FontStyle.Strikeout);
            richTextBoxPrintCtrl1.AppendText(TextBox1.Text + "\n");

            richTextBoxPrintCtrl1.SelectionFont = new Font("Courier New", 8, FontStyle.Bold);
            richTextBoxPrintCtrl1.SelectionColor = Color.Purple;
            richTextBoxPrintCtrl1.AppendText(TextBox1.Text + "\n");
            richTextBoxPrintCtrl1.SelectionFont = new Font("Courier New", 42, FontStyle.Bold);
            richTextBoxPrintCtrl1.SelectionColor = Color.Purple;
            richTextBoxPrintCtrl1.AppendText(TextBox1.Text + "\n");
            // richTextBoxPrintCtrl1.Select(richTextBoxPrintCtrl1.TextLength, 0);
            richTextBoxPrintCtrl1.SelectionFont = new Font("Courier New", 5, FontStyle.Strikeout);
            richTextBoxPrintCtrl1.AppendText(TextBox1.Text + "\n");

            richTextBoxPrintCtrl1.SelectionFont = new Font("Courier New", 8, FontStyle.Bold);
            richTextBoxPrintCtrl1.SelectionColor = Color.Purple;
            richTextBoxPrintCtrl1.AppendText(TextBox1.Text + "\n");
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            //'/// ini penting supaya ukuran image bisa diatur keluar di richtexhbox nya
            //'///////////////////////
            Bitmap aws = new Bitmap(PictureBox2.Image, new Size(150, 50));

            Clipboard.SetImage(aws);
            richTextBoxPrintCtrl1.Paste();
            richTextBoxPrintCtrl1.Select(richTextBoxPrintCtrl1.TextLength, 0);

            richTextBoxPrintCtrl1.AppendText("\n");   // '///INI SUPAYA TEXT YANG MUNCUL SELANJUTNYA DIBAWAH IMAGE
            aws.Dispose();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
          
                // '/// ini penting supaya ukuran image bisa diatur keluar di richtexhbox nya
                //'///////////////////////
                Bitmap aws = new Bitmap(PictureBox1.Image, new Size(250, 50));

                Clipboard.SetImage(aws);
                richTextBoxPrintCtrl1.Paste();
                richTextBoxPrintCtrl1.Select(richTextBoxPrintCtrl1.TextLength, 0);

                //'richTextBoxPrintCtrl1.AppendText(vbCrLf) '///INI SUPAYA TEXT YANG MUNCUL SELANJUTNYA DIBAWAH IMAGE
                richTextBoxPrintCtrl1.AppendText("   ");
                aws.Dispose();
            
        }

        private void Button7_Click(object sender, EventArgs e)
        {
           
                //'////////block dulu rtc nya semua terus setting font, trs tambahkan text
                //'???? RTB dis et fontnya disetel courier new dikompbinasiin setting font dibawah(PELAJARI LAGI)

                richTextBoxPrintCtrl1.SelectionColor = Color.Red;
                richTextBoxPrintCtrl1.AppendText("WWWWWAAAAA" + "\t" + "\t" + "\t" + "\t" + "SSS" + "\n");// '//!!!!!! VBTAB jalan
                richTextBoxPrintCtrl1.AppendText("AAaaa....A" + "\t" + "\t" + "\t" + "\t" + "SaaaSS" + "\n");
                richTextBoxPrintCtrl1.AppendText(".........." + "\t" + "\t" + "\t" + "\t" + "S" + "\n");
                richTextBoxPrintCtrl1.AppendText("WWWWWWWWWW" + "\t" + "\t" + "\t" + "\t" + "w" + "\n");
                richTextBoxPrintCtrl1.AppendText("w.w.w.w.w." + "\t" + "\t" + "\t" + "\t" + "WWWWWWW" + "\n");

                richTextBoxPrintCtrl1.SelectionColor = Color.Purple;
                richTextBoxPrintCtrl1.AppendText("WWWWWAAA" + "\t" + "\t" + "\t" + "\t" + "SSS" + "\n");// '//!!!!!! VBTAB jalan
                richTextBoxPrintCtrl1.Select(0, richTextBoxPrintCtrl1.TextLength);///INI HARUS DITERAKHIR ini di BLOCK semua baru di rubah_
                                                                                  /// ke courie new
                richTextBoxPrintCtrl1.SelectionFont = new Font("courier new", 8, FontStyle.Regular);//'FontFamily.GenericMonospace

            
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
       
            printDocument1.Print();Application.Exit();
        }

        private void fontSEBELUM_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

            richTextBoxPrintCtrl1.Select(richTextBoxPrintCtrl1.TextLength, 0);
            richTextBoxPrintCtrl1.SelectionFont = new Font("courier new", 15, FontStyle.Regular);//'FontFamily.GenericMonospace

            
            richTextBoxPrintCtrl1.AppendText("10.");
            richTextBoxPrintCtrl1.Select(richTextBoxPrintCtrl1.TextLength, 0);
            richTextBoxPrintCtrl1.SelectionFont = new Font("courier new", 12, FontStyle.Regular);//'FontFamily.GenericMonospace
            richTextBoxPrintCtrl1.AppendText("500 gr"+"\n");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //You can pass value in parameter as per your requirement.
            pictureBox3.Image = this.ConvertTextToImage(richTextBoxPrintCtrl1 .Text, "Courier New", 8, Color.White , Color.Black , richTextBoxPrintCtrl1 .Width, richTextBoxPrintCtrl1 .Height);
        }


        public Bitmap ConvertTextToImage(string txt, string fontname, int fontsize, Color bgcolor, Color fcolor, int width, int Height)
        {
            Bitmap bmp = new Bitmap(width, Height);
            using (Graphics graphics = Graphics.FromImage(bmp))
            {

                Font font = new Font(fontname, fontsize);
                graphics.FillRectangle(new SolidBrush(bgcolor), 0, 0, bmp.Width, bmp.Height);
                graphics.DrawString(txt, font, new SolidBrush(fcolor), 0, 0);
                graphics.Flush();
                font.Dispose();
                graphics.Dispose();


            }
            return bmp;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            richTextBoxPrintCtrl1.AppendText("10.");
            richTextBoxPrintCtrl1.AppendText("10." + "\n");
            richTextBoxPrintCtrl1.SelectionFont = new Font("courier new", 14, FontStyle.Regular);
            richTextBoxPrintCtrl1.AppendText("10." + "\n");
            richTextBoxPrintCtrl1.AppendText("10." + "\n");
            printDocument1.Print();
        }

        private void PrintVerticalText(string text)
        {
            PrintDocument pd = new PrintDocument();
            pd.DefaultPageSettings.Landscape = true;
            pd.PrintPage += (sender, e) =>
            {
                Graphics g = e.Graphics;
                g.RotateTransform(90);
                g.DrawString(text, this.Font, Brushes.Black, new PointF(0, 0));
            };
            pd.Print();
        }
        private void PrintVerticalRTB()
        {
            PrintDocument pd = new PrintDocument();
            pd.DefaultPageSettings.Landscape = true;
            pd.PrintPage += (sender, e) =>
            {
                Graphics g = e.Graphics;
                g.RotateTransform(90);
                g.DrawString(richTextBoxPrintCtrl1.Text, richTextBoxPrintCtrl1.Font, Brushes.Black, new PointF(0, 0));
            };
            pd.Print();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            PrintVerticalRTB();
        }
    }
}
