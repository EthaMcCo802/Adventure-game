﻿
namespace Adventure_game
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
            this.textLabel = new System.Windows.Forms.Label();
            this.choiceALabel = new System.Windows.Forms.Label();
            this.buttonLabel = new System.Windows.Forms.Label();
            this.button2Label = new System.Windows.Forms.Label();
            this.choiceBLabel = new System.Windows.Forms.Label();
            this.button3Label = new System.Windows.Forms.Label();
            this.choiceCLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textLabel
            // 
            this.textLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textLabel.ForeColor = System.Drawing.Color.White;
            this.textLabel.Location = new System.Drawing.Point(-2, 0);
            this.textLabel.Name = "textLabel";
            this.textLabel.Size = new System.Drawing.Size(802, 113);
            this.textLabel.TabIndex = 0;
            this.textLabel.Text = "You wake up to the sound of your alarm, you roll over and check the time, it\'s 7:" +
    "30 in the morning.";
            this.textLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // choiceALabel
            // 
            this.choiceALabel.BackColor = System.Drawing.Color.Blue;
            this.choiceALabel.ForeColor = System.Drawing.Color.Black;
            this.choiceALabel.Location = new System.Drawing.Point(144, 565);
            this.choiceALabel.Name = "choiceALabel";
            this.choiceALabel.Size = new System.Drawing.Size(549, 27);
            this.choiceALabel.TabIndex = 1;
            this.choiceALabel.Text = "Get out of bed";
            // 
            // buttonLabel
            // 
            this.buttonLabel.BackColor = System.Drawing.Color.Blue;
            this.buttonLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLabel.ForeColor = System.Drawing.Color.Black;
            this.buttonLabel.Location = new System.Drawing.Point(81, 565);
            this.buttonLabel.Name = "buttonLabel";
            this.buttonLabel.Size = new System.Drawing.Size(57, 27);
            this.buttonLabel.TabIndex = 2;
            this.buttonLabel.Text = "B";
            this.buttonLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button2Label
            // 
            this.button2Label.BackColor = System.Drawing.Color.Red;
            this.button2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2Label.ForeColor = System.Drawing.Color.Black;
            this.button2Label.Location = new System.Drawing.Point(81, 609);
            this.button2Label.Name = "button2Label";
            this.button2Label.Size = new System.Drawing.Size(57, 27);
            this.button2Label.TabIndex = 4;
            this.button2Label.Text = "M";
            this.button2Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // choiceBLabel
            // 
            this.choiceBLabel.BackColor = System.Drawing.Color.Red;
            this.choiceBLabel.ForeColor = System.Drawing.Color.Black;
            this.choiceBLabel.Location = new System.Drawing.Point(144, 609);
            this.choiceBLabel.Name = "choiceBLabel";
            this.choiceBLabel.Size = new System.Drawing.Size(549, 27);
            this.choiceBLabel.TabIndex = 3;
            this.choiceBLabel.Text = "Go back to sleep";
            // 
            // button3Label
            // 
            this.button3Label.BackColor = System.Drawing.Color.Yellow;
            this.button3Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3Label.ForeColor = System.Drawing.Color.Black;
            this.button3Label.Location = new System.Drawing.Point(81, 653);
            this.button3Label.Name = "button3Label";
            this.button3Label.Size = new System.Drawing.Size(57, 27);
            this.button3Label.TabIndex = 6;
            this.button3Label.Text = "N";
            this.button3Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // choiceCLabel
            // 
            this.choiceCLabel.BackColor = System.Drawing.Color.Yellow;
            this.choiceCLabel.ForeColor = System.Drawing.Color.Black;
            this.choiceCLabel.Location = new System.Drawing.Point(144, 653);
            this.choiceCLabel.Name = "choiceCLabel";
            this.choiceCLabel.Size = new System.Drawing.Size(549, 27);
            this.choiceCLabel.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(801, 684);
            this.Controls.Add(this.button3Label);
            this.Controls.Add(this.choiceCLabel);
            this.Controls.Add(this.button2Label);
            this.Controls.Add(this.choiceBLabel);
            this.Controls.Add(this.buttonLabel);
            this.Controls.Add(this.choiceALabel);
            this.Controls.Add(this.textLabel);
            this.Name = "Form1";
            this.Text = "The Crazy Day";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label textLabel;
        private System.Windows.Forms.Label choiceALabel;
        private System.Windows.Forms.Label buttonLabel;
        private System.Windows.Forms.Label button2Label;
        private System.Windows.Forms.Label choiceBLabel;
        private System.Windows.Forms.Label button3Label;
        private System.Windows.Forms.Label choiceCLabel;
    }
}

