namespace SecondHandGames
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
            this.labelCurrentGame = new System.Windows.Forms.Label();
            this.TextBoxGames = new System.Windows.Forms.RichTextBox();
            this.buttonPrevious = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonDeleteGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelCurrentGame
            // 
            this.labelCurrentGame.AutoSize = true;
            this.labelCurrentGame.Location = new System.Drawing.Point(144, 48);
            this.labelCurrentGame.Name = "labelCurrentGame";
            this.labelCurrentGame.Size = new System.Drawing.Size(35, 13);
            this.labelCurrentGame.TabIndex = 0;
            this.labelCurrentGame.Text = "label1";
            // 
            // TextBoxGames
            // 
            this.TextBoxGames.Location = new System.Drawing.Point(40, 64);
            this.TextBoxGames.Name = "TextBoxGames";
            this.TextBoxGames.Size = new System.Drawing.Size(255, 278);
            this.TextBoxGames.TabIndex = 1;
            this.TextBoxGames.Text = "";
            // 
            // buttonPrevious
            // 
            this.buttonPrevious.Location = new System.Drawing.Point(89, 357);
            this.buttonPrevious.Name = "buttonPrevious";
            this.buttonPrevious.Size = new System.Drawing.Size(75, 23);
            this.buttonPrevious.TabIndex = 2;
            this.buttonPrevious.Text = "Previous";
            this.buttonPrevious.UseVisualStyleBackColor = true;
            this.buttonPrevious.Click += new System.EventHandler(this.buttonPrevious_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(170, 357);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(75, 23);
            this.buttonNext.TabIndex = 3;
            this.buttonNext.Text = "Next";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonDeleteGame
            // 
            this.buttonDeleteGame.Location = new System.Drawing.Point(128, 386);
            this.buttonDeleteGame.Name = "buttonDeleteGame";
            this.buttonDeleteGame.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteGame.TabIndex = 4;
            this.buttonDeleteGame.Text = "Delete Game";
            this.buttonDeleteGame.UseVisualStyleBackColor = true;
            this.buttonDeleteGame.Click += new System.EventHandler(this.buttonDeleteGame_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 450);
            this.Controls.Add(this.buttonDeleteGame);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonPrevious);
            this.Controls.Add(this.TextBoxGames);
            this.Controls.Add(this.labelCurrentGame);
            this.Name = "Form1";
            this.Text = "Second Hand Games";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCurrentGame;
        private System.Windows.Forms.RichTextBox TextBoxGames;
        private System.Windows.Forms.Button buttonPrevious;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonDeleteGame;
    }
}

