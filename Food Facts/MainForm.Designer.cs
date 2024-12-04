namespace Food_Facts
{
    partial class MainForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bananaRadioButton = new System.Windows.Forms.RadioButton();
            this.popcornRadioButton = new System.Windows.Forms.RadioButton();
            this.muffinRadioButton = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bananaRadioButton);
            this.groupBox1.Controls.Add(this.popcornRadioButton);
            this.groupBox1.Controls.Add(this.muffinRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(47, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select A Food";
            // 
            // bananaRadioButton
            // 
            this.bananaRadioButton.AutoSize = true;
            this.bananaRadioButton.Location = new System.Drawing.Point(6, 20);
            this.bananaRadioButton.Name = "bananaRadioButton";
            this.bananaRadioButton.Size = new System.Drawing.Size(70, 17);
            this.bananaRadioButton.TabIndex = 1;
            this.bananaRadioButton.TabStop = true;
            this.bananaRadioButton.Text = "1 banana";
            this.bananaRadioButton.UseVisualStyleBackColor = true;
            // 
            // popcornRadioButton
            // 
            this.popcornRadioButton.AutoSize = true;
            this.popcornRadioButton.Location = new System.Drawing.Point(6, 43);
            this.popcornRadioButton.Name = "popcornRadioButton";
            this.popcornRadioButton.Size = new System.Drawing.Size(145, 17);
            this.popcornRadioButton.TabIndex = 2;
            this.popcornRadioButton.TabStop = true;
            this.popcornRadioButton.Text = "1 cup of popped popcorn";
            this.popcornRadioButton.UseVisualStyleBackColor = true;
            // 
            // muffinRadioButton
            // 
            this.muffinRadioButton.AutoSize = true;
            this.muffinRadioButton.Location = new System.Drawing.Point(6, 66);
            this.muffinRadioButton.Name = "muffinRadioButton";
            this.muffinRadioButton.Size = new System.Drawing.Size(134, 17);
            this.muffinRadioButton.TabIndex = 3;
            this.muffinRadioButton.TabStop = true;
            this.muffinRadioButton.Text = "1 large blueberry muffin";
            this.muffinRadioButton.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(54, 134);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 46);
            this.button1.TabIndex = 4;
            this.button1.Text = "Display Food Facts";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(154, 134);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 46);
            this.button2.TabIndex = 5;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 288);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton bananaRadioButton;
        private System.Windows.Forms.RadioButton popcornRadioButton;
        private System.Windows.Forms.RadioButton muffinRadioButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

