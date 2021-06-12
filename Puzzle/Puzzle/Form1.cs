using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Puzzle
{
    public partial class Form1 : Form
    {
        int moves = 0;
        System.Diagnostics.Stopwatch timer = new System.Diagnostics.Stopwatch();

        public Form1()
        {
            InitializeComponent();
            lbMoves.Text += moves;
            lblTime.Text = "00:00:00";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        void Shuffle(ref int[] array)
        {
            int n = array.Length;
            Random r = new Random();
            while (n > 1)
            {
                int i = r.Next(n);
                n--;
                int tmp = array[n];
                array[n] = array[i];
                array[i] = tmp;
            }
        }


        private void AskPermissionBeforeQuite(object sender, FormClosingEventArgs e)
        {
            DialogResult YesOrNO = MessageBox.Show("Are You Sure To Quit ?", "Puzzle Game", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (sender as Button != btnQuit && YesOrNO == DialogResult.No) e.Cancel = true;
            if (sender as Button == btnQuit && YesOrNO == DialogResult.Yes) Environment.Exit(0);
        }

        private void Quit(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            AskPermissionBeforeQuite(sender, e as FormClosingEventArgs);
        }
        

        private void UpdateTimeElapsed(object sender, EventArgs e)
        {
            if (timer.Elapsed.ToString() != "00:00:00")
                lblTime.Text = timer.Elapsed.ToString().Remove(8);
            if (timer.Elapsed.ToString() == "00:00:00")
                btnPause.Enabled = false;
            else
                btnPause.Enabled = true;
            if (timer.Elapsed.Minutes.ToString() == "1")
            {
                timer.Reset();
                lbMoves.Text = "Moves Made : 0";
                lblTime.Text = "00:00:00";
                moves = 0;
                btnPause.Enabled = false;
                MessageBox.Show("Time Is Up\nTry Again", "Puzzle Game");
                Quit(sender, e as FormClosingEventArgs);
            }
        }

        OpenFileDialog openFileDialog = null;
        Image img;
        Image img1;
        PictureBox pictureBox = null;
        PictureBox pictureBox1 = null;
      

        private void tbImgPath_TextChanged(object sender, EventArgs e)
        {

        }


        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (openFileDialog == null)
                openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                tbImgPath.Text = openFileDialog.FileName;
                img = CreateImage(Image.FromFile(openFileDialog.FileName));
                img1 = CreateImage(Image.FromFile(openFileDialog.FileName));
                if (pictureBox == null)
                {
                    ShowSelectedImage();

                }
                
            }
           
           
        }

        int size = 9;
        Image[] images = null;
        PictureBox[] picBoxes = null;

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult YesOrNo = new DialogResult();
            if (lblTime.Text != "00:00:00")
            {
                YesOrNo = MessageBox.Show("Are you sure to start a NEW GAME ?", "Puzzle Game", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }
            if (YesOrNo == DialogResult.Yes || lblTime.Text == "00:00:00")
                Play();
                btnBrowse.Enabled = false;
              
            if (YesOrNo == DialogResult.Yes && lblTime.Text != "00:00:00")
            {
                timer.Reset();
                Play();
                gbpb1.Visible = false;
                lbMoves.Text = "Moves Made : 0";
                lblTime.Text = "00:00:00";
                moves = 0;
                btnPause.Enabled = false;
                tbImgPath.Text="";
                ShowSelectedImage();
                gbpb1.Visible = true;
                
                

            }
        }
       
        private void Play()
        {
            if (pictureBox != null)
            {
                gbpb1.Controls.Remove(pictureBox);
                pictureBox.Dispose();
                pictureBox = null;
            }
            if (pictureBox == null)
            {
                images = new Image[size];
                picBoxes = new PictureBox[size];
            }
            int numRow = (int)Math.Sqrt(size);
            int numCol = numRow;
            int X = gbpb1.Width / numRow;
            int Y = gbpb1.Height / numCol;
            int[] index = new int[size];
            for (int i = 0; i < size; i++)
            {
                index[i] = i;

                if (picBoxes[i] == null)
                {
                    picBoxes[i] = new MyPuzzle();
                    picBoxes[i].Click += new EventHandler(OnClick);
                    
                    picBoxes[i].BorderStyle = BorderStyle.Fixed3D;
                }
                
                picBoxes[i].Width = X;
                picBoxes[i].Height = Y;

                ((MyPuzzle)picBoxes[i]).Index = i;

                CreateImg(img, images, i, numRow, numCol, X, Y);
                picBoxes[i].Location = new Point(X * (i % numCol), Y * (i / numCol));
                if (!gbpb1.Controls.Contains(picBoxes[i]))
                    gbpb1.Controls.Add(picBoxes[i]);
                
            }
            Shuffle(ref index);
            for (int i = 0; i < size; i++)
            {
                picBoxes[i].Image = images[index[i]];
                ((MyPuzzle)picBoxes[i]).ImgIndex = index[i];
                picBoxes[i].Click += new EventHandler(UpdateTimeElapsed);
            }
        }

        MyPuzzle first = null;
        MyPuzzle second = null;
        public void OnClick(object sender, EventArgs e)
        {
            if (first == null)
            {
                first = (MyPuzzle)sender;
                first.BorderStyle = BorderStyle.FixedSingle;
            }
            else if (second == null)
            {
                second = (MyPuzzle)sender;
                first.BorderStyle = BorderStyle.Fixed3D;
                second.BorderStyle = BorderStyle.FixedSingle;
                Switch(first, second);
                first = null;
                second = null;
            }
        }
        private void ShowSelectedImage()
        {
            pictureBox = new PictureBox();
            pictureBox1 = new PictureBox();

            pictureBox.Height = gbpb1.Height;
            pictureBox.Width = gbpb1.Width;


            pictureBox1.Height = gbOriginal.Height;
            pictureBox1.Width = gbOriginal.Width;

            gbpb1.Controls.Add(pictureBox);
            gbOriginal.Controls.Add(pictureBox1);

            pictureBox.Image = img;
            pictureBox1.Image = img1;
        }
        private Bitmap CreateImage(Image image)
        {
            Bitmap objImage = new Bitmap(gbpb1.Width,gbpb1.Height);
            Graphics objGraph = Graphics.FromImage(objImage);
            objGraph.Clear(Color.White);
            objGraph.DrawImage(image, new Rectangle(0,0,gbpb1.Width,gbpb1.Height));
            objGraph.Flush();
            return objImage;
        }

        private void CreateImg(Image image, Image [] images, int index, int NumRow, int numCol, int X, int Y)
        {
            images[index] = new Bitmap(X,Y);
            Graphics objGraph = Graphics.FromImage(images[index]);
            objGraph.Clear(Color.White);
            objGraph.DrawImage(image, 
                new Rectangle(0, 0, X, Y),
                new Rectangle(X * (index % numCol), Y * (index / numCol), X, Y), GraphicsUnit.Pixel);
            objGraph.Flush();
           
        }
        private void Switch(MyPuzzle one, MyPuzzle two)
        {
            if (lblTime.Text == "00:00:00")
                timer.Start();
            int tmp = two.ImgIndex;
            two.Image = images[one.ImgIndex];
            two.ImgIndex = one.ImgIndex;
            one.Image = images[tmp];
            one.ImgIndex = tmp;
            lbMoves.Text = "Moves Made : " + (++moves);
            
            if (Check())
            {
                timer.Stop();
                MessageBox.Show("Congratulations...\nYou did it\nTime Elapsed : " + timer.Elapsed.ToString().Remove(8) + "\nTotal Moves Made : " + moves, "Puzzle Game");
                moves = 0;
                lbMoves.Text = "Moves Made : 0";
                lblTime.Text = "00:00:00";
                timer.Reset();
            }
        }

        private bool Check()
        {
            for (int i = 0; i < size; i++)
            {
                if (((MyPuzzle)picBoxes[i]).ImgIndex != ((MyPuzzle)picBoxes[i]).Index)
                {
                    return false;
                }
            }
            return true;
        }

       

        private void PauseOrResume(object sender, EventArgs e)
           {
              if (btnPause.Text == "Pause")
              {
                   timer.Stop();
                   gbpb1.Visible = false;
                   btnPause.Text = "Resume";
              }
              else
              {
                   timer.Start();
                   gbpb1.Visible = true;
                   btnPause.Text = "Pause";
              }
           }

        private void lblTime_Click(object sender, EventArgs e)
        {

        }
    }
   
 }


    
