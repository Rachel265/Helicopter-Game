namespace Helicopter_Game
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
            this.player = new System.Windows.Forms.PictureBox();
            this.pillar1 = new System.Windows.Forms.PictureBox();
            this.pillar2 = new System.Windows.Forms.PictureBox();
            this.ufo = new System.Windows.Forms.PictureBox();
            this.txtScore = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pillar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pillar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ufo)).BeginInit();
            this.SuspendLayout();
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Transparent;
            this.player.Image = global::Helicopter_Game.Properties.Resources.Halicopter;
            this.player.Location = new System.Drawing.Point(12, 133);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(100, 54);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.player.TabIndex = 0;
            this.player.TabStop = false;
            // 
            // pillar1
            // 
            this.pillar1.Image = global::Helicopter_Game.Properties.Resources.pillar;
            this.pillar1.Location = new System.Drawing.Point(474, -4);
            this.pillar1.Name = "pillar1";
            this.pillar1.Size = new System.Drawing.Size(56, 150);
            this.pillar1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pillar1.TabIndex = 1;
            this.pillar1.TabStop = false;
            this.pillar1.Tag = "pillar";
            // 
            // pillar2
            // 
            this.pillar2.Image = global::Helicopter_Game.Properties.Resources.pillar;
            this.pillar2.Location = new System.Drawing.Point(166, 226);
            this.pillar2.Name = "pillar2";
            this.pillar2.Size = new System.Drawing.Size(56, 146);
            this.pillar2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pillar2.TabIndex = 2;
            this.pillar2.TabStop = false;
            this.pillar2.Tag = "pillar";
            // 
            // ufo
            // 
            this.ufo.BackColor = System.Drawing.Color.Transparent;
            this.ufo.Image = global::Helicopter_Game.Properties.Resources.alien1;
            this.ufo.Location = new System.Drawing.Point(671, 115);
            this.ufo.Name = "ufo";
            this.ufo.Size = new System.Drawing.Size(68, 72);
            this.ufo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ufo.TabIndex = 3;
            this.ufo.TabStop = false;
            // 
            // txtScore
            // 
            this.txtScore.AutoSize = true;
            this.txtScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScore.Location = new System.Drawing.Point(13, 10);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(30, 24);
            this.txtScore.TabIndex = 4;
            this.txtScore.Text = "00";
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gametick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(797, 372);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.ufo);
            this.Controls.Add(this.pillar2);
            this.Controls.Add(this.pillar1);
            this.Controls.Add(this.player);
            this.Name = "Form1";
            this.Text = "Helicopter Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyisup);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pillar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pillar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ufo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox pillar1;
        private System.Windows.Forms.PictureBox pillar2;
        private System.Windows.Forms.PictureBox ufo;
        private System.Windows.Forms.Label txtScore;
        private System.Windows.Forms.Timer gameTimer;
    }
}

