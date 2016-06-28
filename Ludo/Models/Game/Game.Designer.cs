using Ludo.Extensions;
using System.Drawing;

namespace Ludo.Models.Game
{
    partial class Game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.redPawn0 = new System.Windows.Forms.Button();
            this.redPawn1 = new System.Windows.Forms.Button();
            this.redPawn2 = new System.Windows.Forms.Button();
            this.redPawn3 = new System.Windows.Forms.Button();
            this.greenPawn3 = new System.Windows.Forms.Button();
            this.greenPawn1 = new System.Windows.Forms.Button();
            this.greenPawn0 = new System.Windows.Forms.Button();
            this.greenPawn2 = new System.Windows.Forms.Button();
            this.yellowPawn3 = new System.Windows.Forms.Button();
            this.yellowPawn1 = new System.Windows.Forms.Button();
            this.yellowPawn0 = new System.Windows.Forms.Button();
            this.yellowPawn2 = new System.Windows.Forms.Button();
            this.bluePawn3 = new System.Windows.Forms.Button();
            this.bluePawn1 = new System.Windows.Forms.Button();
            this.bluePawn0 = new System.Windows.Forms.Button();
            this.bluePawn2 = new System.Windows.Forms.Button();
            this.wheel = new System.Windows.Forms.Button();
            this.diceNine = new System.Windows.Forms.Button();
            this.diceCatapult = new System.Windows.Forms.Button();
            this.diceMama = new System.Windows.Forms.Button();
            this.diceStandart = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnTurn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // redPawn0
            // 
            this.redPawn0.BackColor = System.Drawing.Color.DarkRed;
            this.redPawn0.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.redPawn0.FlatAppearance.BorderSize = 0;
            this.redPawn0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.redPawn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.redPawn0.Location = new System.Drawing.Point(567, 31);
            this.redPawn0.Name = "redPawn0";
            this.redPawn0.Size = new System.Drawing.Size(25, 25);
            this.redPawn0.TabIndex = 1;
            this.redPawn0.Text = "O";
            this.redPawn0.UseVisualStyleBackColor = false;
            this.redPawn0.Click += new System.EventHandler(this.HandlePawnClick);
            // 
            // redPawn1
            // 
            this.redPawn1.BackColor = System.Drawing.Color.DarkRed;
            this.redPawn1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.redPawn1.FlatAppearance.BorderSize = 0;
            this.redPawn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.redPawn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.redPawn1.Location = new System.Drawing.Point(567, 0);
            this.redPawn1.Name = "redPawn1";
            this.redPawn1.Size = new System.Drawing.Size(25, 25);
            this.redPawn1.TabIndex = 2;
            this.redPawn1.Text = "O";
            this.redPawn1.UseVisualStyleBackColor = false;
            this.redPawn1.Click += new System.EventHandler(this.HandlePawnClick);
            // 
            // redPawn2
            // 
            this.redPawn2.BackColor = System.Drawing.Color.DarkRed;
            this.redPawn2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.redPawn2.FlatAppearance.BorderSize = 0;
            this.redPawn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.redPawn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.redPawn2.Location = new System.Drawing.Point(598, 0);
            this.redPawn2.Name = "redPawn2";
            this.redPawn2.Size = new System.Drawing.Size(25, 25);
            this.redPawn2.TabIndex = 3;
            this.redPawn2.Text = "O";
            this.redPawn2.UseVisualStyleBackColor = false;
            this.redPawn2.Click += new System.EventHandler(this.HandlePawnClick);
            // 
            // redPawn3
            // 
            this.redPawn3.BackColor = System.Drawing.Color.DarkRed;
            this.redPawn3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.redPawn3.FlatAppearance.BorderSize = 0;
            this.redPawn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.redPawn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.redPawn3.Location = new System.Drawing.Point(598, 31);
            this.redPawn3.Name = "redPawn3";
            this.redPawn3.Size = new System.Drawing.Size(25, 25);
            this.redPawn3.TabIndex = 4;
            this.redPawn3.Text = "O";
            this.redPawn3.UseVisualStyleBackColor = false;
            this.redPawn3.Click += new System.EventHandler(this.HandlePawnClick);
            // 
            // greenPawn3
            // 
            this.greenPawn3.BackColor = System.Drawing.Color.DarkGreen;
            this.greenPawn3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.greenPawn3.FlatAppearance.BorderSize = 0;
            this.greenPawn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.greenPawn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.greenPawn3.Location = new System.Drawing.Point(154, 31);
            this.greenPawn3.Name = "greenPawn3";
            this.greenPawn3.Size = new System.Drawing.Size(25, 25);
            this.greenPawn3.TabIndex = 9;
            this.greenPawn3.Text = "O";
            this.greenPawn3.UseVisualStyleBackColor = false;
            this.greenPawn3.Click += new System.EventHandler(this.HandlePawnClick);
            // 
            // greenPawn1
            // 
            this.greenPawn1.BackColor = System.Drawing.Color.DarkGreen;
            this.greenPawn1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.greenPawn1.FlatAppearance.BorderSize = 0;
            this.greenPawn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.greenPawn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.greenPawn1.Location = new System.Drawing.Point(154, 0);
            this.greenPawn1.Name = "greenPawn1";
            this.greenPawn1.Size = new System.Drawing.Size(25, 25);
            this.greenPawn1.TabIndex = 8;
            this.greenPawn1.Text = "O";
            this.greenPawn1.UseVisualStyleBackColor = false;
            this.greenPawn1.Click += new System.EventHandler(this.HandlePawnClick);
            // 
            // greenPawn0
            // 
            this.greenPawn0.BackColor = System.Drawing.Color.DarkGreen;
            this.greenPawn0.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.greenPawn0.FlatAppearance.BorderSize = 0;
            this.greenPawn0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.greenPawn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.greenPawn0.Location = new System.Drawing.Point(123, 0);
            this.greenPawn0.Name = "greenPawn0";
            this.greenPawn0.Size = new System.Drawing.Size(25, 25);
            this.greenPawn0.TabIndex = 7;
            this.greenPawn0.Text = "O";
            this.greenPawn0.UseVisualStyleBackColor = false;
            this.greenPawn0.Click += new System.EventHandler(this.HandlePawnClick);
            // 
            // greenPawn2
            // 
            this.greenPawn2.BackColor = System.Drawing.Color.DarkGreen;
            this.greenPawn2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.greenPawn2.FlatAppearance.BorderSize = 0;
            this.greenPawn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.greenPawn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.greenPawn2.Location = new System.Drawing.Point(123, 31);
            this.greenPawn2.Name = "greenPawn2";
            this.greenPawn2.Size = new System.Drawing.Size(25, 25);
            this.greenPawn2.TabIndex = 6;
            this.greenPawn2.Text = "O";
            this.greenPawn2.UseVisualStyleBackColor = false;
            this.greenPawn2.Click += new System.EventHandler(this.HandlePawnClick);
            // 
            // yellowPawn3
            // 
            this.yellowPawn3.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.yellowPawn3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.yellowPawn3.FlatAppearance.BorderSize = 0;
            this.yellowPawn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yellowPawn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yellowPawn3.Location = new System.Drawing.Point(154, 475);
            this.yellowPawn3.Name = "yellowPawn3";
            this.yellowPawn3.Size = new System.Drawing.Size(25, 25);
            this.yellowPawn3.TabIndex = 13;
            this.yellowPawn3.Text = "O";
            this.yellowPawn3.UseVisualStyleBackColor = false;
            this.yellowPawn3.Click += new System.EventHandler(this.HandlePawnClick);
            // 
            // yellowPawn1
            // 
            this.yellowPawn1.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.yellowPawn1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.yellowPawn1.FlatAppearance.BorderSize = 0;
            this.yellowPawn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yellowPawn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yellowPawn1.Location = new System.Drawing.Point(154, 444);
            this.yellowPawn1.Name = "yellowPawn1";
            this.yellowPawn1.Size = new System.Drawing.Size(25, 25);
            this.yellowPawn1.TabIndex = 12;
            this.yellowPawn1.Text = "O";
            this.yellowPawn1.UseVisualStyleBackColor = false;
            this.yellowPawn1.Click += new System.EventHandler(this.HandlePawnClick);
            // 
            // yellowPawn0
            // 
            this.yellowPawn0.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.yellowPawn0.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.yellowPawn0.FlatAppearance.BorderSize = 0;
            this.yellowPawn0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yellowPawn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yellowPawn0.Location = new System.Drawing.Point(123, 444);
            this.yellowPawn0.Name = "yellowPawn0";
            this.yellowPawn0.Size = new System.Drawing.Size(25, 25);
            this.yellowPawn0.TabIndex = 11;
            this.yellowPawn0.Text = "O";
            this.yellowPawn0.UseVisualStyleBackColor = false;
            this.yellowPawn0.Click += new System.EventHandler(this.HandlePawnClick);
            // 
            // yellowPawn2
            // 
            this.yellowPawn2.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.yellowPawn2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.yellowPawn2.FlatAppearance.BorderSize = 0;
            this.yellowPawn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yellowPawn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yellowPawn2.Location = new System.Drawing.Point(123, 475);
            this.yellowPawn2.Name = "yellowPawn2";
            this.yellowPawn2.Size = new System.Drawing.Size(25, 25);
            this.yellowPawn2.TabIndex = 10;
            this.yellowPawn2.Text = "O";
            this.yellowPawn2.UseVisualStyleBackColor = false;
            this.yellowPawn2.Click += new System.EventHandler(this.HandlePawnClick);
            // 
            // bluePawn3
            // 
            this.bluePawn3.BackColor = System.Drawing.Color.DarkSlateGray;
            this.bluePawn3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bluePawn3.FlatAppearance.BorderSize = 0;
            this.bluePawn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bluePawn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bluePawn3.Location = new System.Drawing.Point(598, 475);
            this.bluePawn3.Name = "bluePawn3";
            this.bluePawn3.Size = new System.Drawing.Size(25, 25);
            this.bluePawn3.TabIndex = 17;
            this.bluePawn3.Text = "O";
            this.bluePawn3.UseVisualStyleBackColor = false;
            this.bluePawn3.Click += new System.EventHandler(this.HandlePawnClick);
            // 
            // bluePawn1
            // 
            this.bluePawn1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.bluePawn1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bluePawn1.FlatAppearance.BorderSize = 0;
            this.bluePawn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bluePawn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bluePawn1.Location = new System.Drawing.Point(598, 444);
            this.bluePawn1.Name = "bluePawn1";
            this.bluePawn1.Size = new System.Drawing.Size(25, 25);
            this.bluePawn1.TabIndex = 16;
            this.bluePawn1.Text = "O";
            this.bluePawn1.UseVisualStyleBackColor = false;
            this.bluePawn1.Click += new System.EventHandler(this.HandlePawnClick);
            // 
            // bluePawn0
            // 
            this.bluePawn0.BackColor = System.Drawing.Color.DarkSlateGray;
            this.bluePawn0.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bluePawn0.FlatAppearance.BorderSize = 0;
            this.bluePawn0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bluePawn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bluePawn0.Location = new System.Drawing.Point(567, 444);
            this.bluePawn0.Name = "bluePawn0";
            this.bluePawn0.Size = new System.Drawing.Size(25, 25);
            this.bluePawn0.TabIndex = 15;
            this.bluePawn0.Text = "O";
            this.bluePawn0.UseVisualStyleBackColor = false;
            this.bluePawn0.Click += new System.EventHandler(this.HandlePawnClick);
            // 
            // bluePawn2
            // 
            this.bluePawn2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.bluePawn2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bluePawn2.FlatAppearance.BorderSize = 0;
            this.bluePawn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bluePawn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bluePawn2.Location = new System.Drawing.Point(567, 475);
            this.bluePawn2.Name = "bluePawn2";
            this.bluePawn2.Size = new System.Drawing.Size(25, 25);
            this.bluePawn2.TabIndex = 14;
            this.bluePawn2.Text = "O";
            this.bluePawn2.UseVisualStyleBackColor = false;
            this.bluePawn2.Click += new System.EventHandler(this.HandlePawnClick);
            // 
            // wheel
            // 
            this.wheel.BackgroundImage = global::Ludo.Properties.Resources.Wheel;
            this.wheel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.wheel.FlatAppearance.BorderSize = 0;
            this.wheel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.wheel.Location = new System.Drawing.Point(12, 380);
            this.wheel.Name = "wheel";
            this.wheel.Size = new System.Drawing.Size(100, 100);
            this.wheel.TabIndex = 24;
            this.wheel.UseVisualStyleBackColor = true;
            // 
            // diceNine
            // 
            this.diceNine.BackgroundImage = global::Ludo.Properties.Resources.Nine;
            this.diceNine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.diceNine.FlatAppearance.BorderSize = 0;
            this.diceNine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.diceNine.Location = new System.Drawing.Point(23, 290);
            this.diceNine.Name = "diceNine";
            this.diceNine.Size = new System.Drawing.Size(70, 70);
            this.diceNine.TabIndex = 23;
            this.diceNine.UseVisualStyleBackColor = true;
            // 
            // diceCatapult
            // 
            this.diceCatapult.BackgroundImage = global::Ludo.Properties.Resources.Catapult;
            this.diceCatapult.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.diceCatapult.FlatAppearance.BorderSize = 0;
            this.diceCatapult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.diceCatapult.Location = new System.Drawing.Point(23, 214);
            this.diceCatapult.Name = "diceCatapult";
            this.diceCatapult.Size = new System.Drawing.Size(70, 70);
            this.diceCatapult.TabIndex = 22;
            this.diceCatapult.UseVisualStyleBackColor = true;
            // 
            // diceMama
            // 
            this.diceMama.BackgroundImage = global::Ludo.Properties.Resources.BigMama;
            this.diceMama.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.diceMama.FlatAppearance.BorderSize = 0;
            this.diceMama.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.diceMama.Location = new System.Drawing.Point(23, 129);
            this.diceMama.Name = "diceMama";
            this.diceMama.Size = new System.Drawing.Size(70, 70);
            this.diceMama.TabIndex = 21;
            this.diceMama.UseVisualStyleBackColor = true;
            this.diceMama.EnabledChanged += new System.EventHandler(this.DiceEnabledChanged);
            // 
            // diceStandart
            // 
            this.diceStandart.BackgroundImage = global::Ludo.Properties.Resources.Standart;
            this.diceStandart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.diceStandart.FlatAppearance.BorderSize = 0;
            this.diceStandart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.diceStandart.Location = new System.Drawing.Point(23, 53);
            this.diceStandart.Name = "diceStandart";
            this.diceStandart.Size = new System.Drawing.Size(70, 70);
            this.diceStandart.TabIndex = 20;
            this.diceStandart.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Ludo.Properties.Resources.PlayGround;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(123, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 500);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnTurn
            // 
            this.btnTurn.Enabled = false;
            this.btnTurn.FlatAppearance.BorderSize = 0;
            this.btnTurn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnTurn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnTurn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTurn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTurn.ForeColor = System.Drawing.Color.White;
            this.btnTurn.Location = new System.Drawing.Point(0, 0);
            this.btnTurn.Name = "btnTurn";
            this.btnTurn.Size = new System.Drawing.Size(122, 30);
            this.btnTurn.TabIndex = 25;
            this.btnTurn.Text = "button1";
            this.btnTurn.UseVisualStyleBackColor = true;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(622, 500);
            this.Controls.Add(this.btnTurn);
            this.Controls.Add(this.wheel);
            this.Controls.Add(this.diceNine);
            this.Controls.Add(this.diceCatapult);
            this.Controls.Add(this.diceMama);
            this.Controls.Add(this.diceStandart);
            this.Controls.Add(this.bluePawn3);
            this.Controls.Add(this.bluePawn1);
            this.Controls.Add(this.bluePawn0);
            this.Controls.Add(this.bluePawn2);
            this.Controls.Add(this.yellowPawn3);
            this.Controls.Add(this.yellowPawn1);
            this.Controls.Add(this.yellowPawn0);
            this.Controls.Add(this.yellowPawn2);
            this.Controls.Add(this.greenPawn3);
            this.Controls.Add(this.greenPawn1);
            this.Controls.Add(this.greenPawn0);
            this.Controls.Add(this.greenPawn2);
            this.Controls.Add(this.redPawn3);
            this.Controls.Add(this.redPawn2);
            this.Controls.Add(this.redPawn1);
            this.Controls.Add(this.redPawn0);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Game";
            this.Text = "Ludo";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button redPawn0;
        private System.Windows.Forms.Button redPawn1;
        private System.Windows.Forms.Button redPawn2;
        private System.Windows.Forms.Button redPawn3;
        private System.Windows.Forms.Button greenPawn3;
        private System.Windows.Forms.Button greenPawn1;
        private System.Windows.Forms.Button greenPawn0;
        private System.Windows.Forms.Button greenPawn2;
        private System.Windows.Forms.Button yellowPawn3;
        private System.Windows.Forms.Button yellowPawn1;
        private System.Windows.Forms.Button yellowPawn0;
        private System.Windows.Forms.Button yellowPawn2;
        private System.Windows.Forms.Button bluePawn3;
        private System.Windows.Forms.Button bluePawn1;
        private System.Windows.Forms.Button bluePawn0;
        private System.Windows.Forms.Button bluePawn2;
        private System.Windows.Forms.Button diceStandart;
        private System.Windows.Forms.Button diceMama;
        private System.Windows.Forms.Button diceCatapult;
        private System.Windows.Forms.Button diceNine;
        private System.Windows.Forms.Button wheel;
        private System.Windows.Forms.Button btnTurn;
    }
}