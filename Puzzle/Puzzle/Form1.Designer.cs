
namespace Puzzle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gbpb1 = new System.Windows.Forms.GroupBox();
            this.lbMoves = new System.Windows.Forms.Label();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.gbOriginal = new System.Windows.Forms.GroupBox();
            this.gbChooseImage = new System.Windows.Forms.GroupBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.tbImgPath = new System.Windows.Forms.TextBox();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gbChooseImage.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbpb1
            // 
            this.gbpb1.Location = new System.Drawing.Point(12, 88);
            this.gbpb1.Name = "gbpb1";
            this.gbpb1.Size = new System.Drawing.Size(494, 410);
            this.gbpb1.TabIndex = 0;
            this.gbpb1.TabStop = false;
            this.gbpb1.Text = "Puzzle Box";
            // 
            // lbMoves
            // 
            this.lbMoves.AutoSize = true;
            this.lbMoves.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMoves.ForeColor = System.Drawing.Color.Red;
            this.lbMoves.Location = new System.Drawing.Point(23, 595);
            this.lbMoves.Name = "lbMoves";
            this.lbMoves.Size = new System.Drawing.Size(143, 25);
            this.lbMoves.TabIndex = 8;
            this.lbMoves.Text = "Moves Made:";
            // 
            // btnPause
            // 
            this.btnPause.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnPause.Enabled = false;
            this.btnPause.Font = new System.Drawing.Font("Bauhaus 93", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPause.Location = new System.Drawing.Point(530, 562);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(126, 58);
            this.btnPause.TabIndex = 12;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.PauseOrResume);
            // 
            // btnQuit
            // 
            this.btnQuit.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnQuit.Font = new System.Drawing.Font("Bauhaus 93", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.Location = new System.Drawing.Point(869, 562);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(126, 58);
            this.btnQuit.TabIndex = 13;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = false;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Bernard MT Condensed", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(663, 439);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(244, 72);
            this.lblTime.TabIndex = 14;
            this.lblTime.Text = "00:00:00";
            this.lblTime.Click += new System.EventHandler(this.lblTime_Click);
            // 
            // gbOriginal
            // 
            this.gbOriginal.Location = new System.Drawing.Point(518, 88);
            this.gbOriginal.Name = "gbOriginal";
            this.gbOriginal.Size = new System.Drawing.Size(528, 348);
            this.gbOriginal.TabIndex = 15;
            this.gbOriginal.TabStop = false;
            this.gbOriginal.Text = "Original";
            // 
            // gbChooseImage
            // 
            this.gbChooseImage.Controls.Add(this.btnBrowse);
            this.gbChooseImage.Controls.Add(this.tbImgPath);
            this.gbChooseImage.Location = new System.Drawing.Point(12, 16);
            this.gbChooseImage.Name = "gbChooseImage";
            this.gbChooseImage.Size = new System.Drawing.Size(715, 66);
            this.gbChooseImage.TabIndex = 16;
            this.gbChooseImage.TabStop = false;
            this.gbChooseImage.Text = "Choose Image";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Font = new System.Drawing.Font("Bauhaus 93", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.Location = new System.Drawing.Point(518, 14);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(94, 35);
            this.btnBrowse.TabIndex = 1;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // tbImgPath
            // 
            this.tbImgPath.Location = new System.Drawing.Point(6, 21);
            this.tbImgPath.Name = "tbImgPath";
            this.tbImgPath.Size = new System.Drawing.Size(488, 22);
            this.tbImgPath.TabIndex = 0;
            this.tbImgPath.TextChanged += new System.EventHandler(this.tbImgPath_TextChanged);
            // 
            // btnNewGame
            // 
            this.btnNewGame.Font = new System.Drawing.Font("Bauhaus 93", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewGame.Location = new System.Drawing.Point(750, 30);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(125, 40);
            this.btnNewGame.TabIndex = 17;
            this.btnNewGame.Text = "Start";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 900;
            this.timer1.Tick += new System.EventHandler(this.UpdateTimeElapsed);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1128, 655);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.gbChooseImage);
            this.Controls.Add(this.gbOriginal);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.lbMoves);
            this.Controls.Add(this.gbpb1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Puzzle Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbChooseImage.ResumeLayout(false);
            this.gbChooseImage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbpb1;
        private System.Windows.Forms.Label lbMoves;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.GroupBox gbOriginal;
        private System.Windows.Forms.GroupBox gbChooseImage;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox tbImgPath;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Timer timer1;
    }
}

