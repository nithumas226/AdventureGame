
namespace AdventureGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.outputLabel = new System.Windows.Forms.Label();
            this.imageLabel = new System.Windows.Forms.Label();
            this.option1Button = new System.Windows.Forms.Button();
            this.option2Button = new System.Windows.Forms.Button();
            this.option3Button = new System.Windows.Forms.Button();
            this.button1Label = new System.Windows.Forms.Label();
            this.button2Label = new System.Windows.Forms.Label();
            this.button3Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // outputLabel
            // 
            this.outputLabel.Font = new System.Drawing.Font("Garamond", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.ForeColor = System.Drawing.Color.White;
            this.outputLabel.Location = new System.Drawing.Point(40, 36);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(597, 90);
            this.outputLabel.TabIndex = 0;
            // 
            // imageLabel
            // 
            this.imageLabel.Location = new System.Drawing.Point(37, 126);
            this.imageLabel.Name = "imageLabel";
            this.imageLabel.Size = new System.Drawing.Size(600, 155);
            this.imageLabel.TabIndex = 1;
            this.imageLabel.Text = "label1";
            // 
            // option1Button
            // 
            this.option1Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.option1Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.option1Button.Location = new System.Drawing.Point(40, 316);
            this.option1Button.Name = "option1Button";
            this.option1Button.Size = new System.Drawing.Size(75, 23);
            this.option1Button.TabIndex = 2;
            this.option1Button.UseVisualStyleBackColor = true;
            this.option1Button.Click += new System.EventHandler(this.option1Button_Click);
            // 
            // option2Button
            // 
            this.option2Button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("option2Button.BackgroundImage")));
            this.option2Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.option2Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.option2Button.Location = new System.Drawing.Point(40, 369);
            this.option2Button.Name = "option2Button";
            this.option2Button.Size = new System.Drawing.Size(75, 23);
            this.option2Button.TabIndex = 3;
            this.option2Button.UseVisualStyleBackColor = true;
            this.option2Button.Click += new System.EventHandler(this.option2Button_Click);
            // 
            // option3Button
            // 
            this.option3Button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("option3Button.BackgroundImage")));
            this.option3Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.option3Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.option3Button.Location = new System.Drawing.Point(40, 418);
            this.option3Button.Name = "option3Button";
            this.option3Button.Size = new System.Drawing.Size(75, 23);
            this.option3Button.TabIndex = 4;
            this.option3Button.UseVisualStyleBackColor = true;
            this.option3Button.Visible = false;
            this.option3Button.Click += new System.EventHandler(this.option3Button_Click);
            // 
            // button1Label
            // 
            this.button1Label.Location = new System.Drawing.Point(134, 316);
            this.button1Label.Name = "button1Label";
            this.button1Label.Size = new System.Drawing.Size(503, 23);
            this.button1Label.TabIndex = 5;
            this.button1Label.Text = "label1";
            // 
            // button2Label
            // 
            this.button2Label.Location = new System.Drawing.Point(134, 369);
            this.button2Label.Name = "button2Label";
            this.button2Label.Size = new System.Drawing.Size(503, 23);
            this.button2Label.TabIndex = 6;
            this.button2Label.Text = "label1";
            // 
            // button3Label
            // 
            this.button3Label.Location = new System.Drawing.Point(134, 418);
            this.button3Label.Name = "button3Label";
            this.button3Label.Size = new System.Drawing.Size(503, 23);
            this.button3Label.TabIndex = 7;
            this.button3Label.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(666, 459);
            this.Controls.Add(this.button3Label);
            this.Controls.Add(this.button2Label);
            this.Controls.Add(this.button1Label);
            this.Controls.Add(this.option3Button);
            this.Controls.Add(this.option2Button);
            this.Controls.Add(this.option1Button);
            this.Controls.Add(this.imageLabel);
            this.Controls.Add(this.outputLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Choose Your Own Adventure Game";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Label imageLabel;
        private System.Windows.Forms.Button option1Button;
        private System.Windows.Forms.Button option2Button;
        private System.Windows.Forms.Button option3Button;
        private System.Windows.Forms.Label button1Label;
        private System.Windows.Forms.Label button2Label;
        private System.Windows.Forms.Label button3Label;
    }
}

