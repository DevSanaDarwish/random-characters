namespace RandomCharacters
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnOptions = new System.Windows.Forms.Button();
            this.gbOptions = new System.Windows.Forms.GroupBox();
            this.chkSymbols = new System.Windows.Forms.CheckBox();
            this.chkMix = new System.Windows.Forms.CheckBox();
            this.chkNumbers = new System.Windows.Forms.CheckBox();
            this.chkLetters = new System.Windows.Forms.CheckBox();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.lblNumberOfDigits = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lblCopy = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.gbOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btnExit.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btnExit.Location = new System.Drawing.Point(696, 31);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(92, 39);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btnReset.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btnReset.Location = new System.Drawing.Point(696, 389);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(92, 39);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnGenerate.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.ForeColor = System.Drawing.Color.DarkMagenta;
            this.btnGenerate.Location = new System.Drawing.Point(396, 358);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(106, 54);
            this.btnGenerate.TabIndex = 3;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnOptions
            // 
            this.btnOptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnOptions.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOptions.ForeColor = System.Drawing.Color.DarkMagenta;
            this.btnOptions.Location = new System.Drawing.Point(145, 195);
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.Size = new System.Drawing.Size(106, 35);
            this.btnOptions.TabIndex = 4;
            this.btnOptions.Text = "Options";
            this.btnOptions.UseVisualStyleBackColor = false;
            this.btnOptions.Click += new System.EventHandler(this.btnOptions_Click);
            // 
            // gbOptions
            // 
            this.gbOptions.Controls.Add(this.chkSymbols);
            this.gbOptions.Controls.Add(this.chkMix);
            this.gbOptions.Controls.Add(this.chkNumbers);
            this.gbOptions.Controls.Add(this.chkLetters);
            this.gbOptions.Controls.Add(this.txtInput);
            this.gbOptions.Controls.Add(this.lblNumberOfDigits);
            this.gbOptions.Location = new System.Drawing.Point(52, 249);
            this.gbOptions.Name = "gbOptions";
            this.gbOptions.Size = new System.Drawing.Size(294, 189);
            this.gbOptions.TabIndex = 11;
            this.gbOptions.TabStop = false;
            // 
            // chkSymbols
            // 
            this.chkSymbols.AutoSize = true;
            this.chkSymbols.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSymbols.Location = new System.Drawing.Point(21, 150);
            this.chkSymbols.Name = "chkSymbols";
            this.chkSymbols.Size = new System.Drawing.Size(93, 22);
            this.chkSymbols.TabIndex = 16;
            this.chkSymbols.Text = "Symbols";
            this.chkSymbols.UseVisualStyleBackColor = true;
            this.chkSymbols.CheckedChanged += new System.EventHandler(this.chkSymbols_CheckedChanged);
            this.chkSymbols.Click += new System.EventHandler(this.chkSymbols_Click);
            // 
            // chkMix
            // 
            this.chkMix.AutoSize = true;
            this.chkMix.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMix.Location = new System.Drawing.Point(151, 150);
            this.chkMix.Name = "chkMix";
            this.chkMix.Size = new System.Drawing.Size(57, 22);
            this.chkMix.TabIndex = 15;
            this.chkMix.Text = "Mix";
            this.chkMix.UseVisualStyleBackColor = true;
            this.chkMix.CheckedChanged += new System.EventHandler(this.chkMix_CheckedChanged);
            this.chkMix.Click += new System.EventHandler(this.chkMix_Click);
            // 
            // chkNumbers
            // 
            this.chkNumbers.AutoSize = true;
            this.chkNumbers.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkNumbers.Location = new System.Drawing.Point(151, 98);
            this.chkNumbers.Name = "chkNumbers";
            this.chkNumbers.Size = new System.Drawing.Size(97, 22);
            this.chkNumbers.TabIndex = 14;
            this.chkNumbers.Text = "Numbers";
            this.chkNumbers.UseVisualStyleBackColor = true;
            this.chkNumbers.CheckedChanged += new System.EventHandler(this.chkNumbers_CheckedChanged);
            this.chkNumbers.Click += new System.EventHandler(this.chkNumbers_Click);
            // 
            // chkLetters
            // 
            this.chkLetters.AutoSize = true;
            this.chkLetters.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkLetters.Location = new System.Drawing.Point(21, 98);
            this.chkLetters.Name = "chkLetters";
            this.chkLetters.Size = new System.Drawing.Size(84, 22);
            this.chkLetters.TabIndex = 13;
            this.chkLetters.Text = "Letters";
            this.chkLetters.UseVisualStyleBackColor = true;
            this.chkLetters.CheckedChanged += new System.EventHandler(this.chkLetters_CheckedChanged);
            this.chkLetters.Click += new System.EventHandler(this.chkLetters_Click);
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(218, 23);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(56, 24);
            this.txtInput.TabIndex = 12;
            this.txtInput.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblNumberOfDigits
            // 
            this.lblNumberOfDigits.AutoSize = true;
            this.lblNumberOfDigits.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfDigits.Location = new System.Drawing.Point(16, 21);
            this.lblNumberOfDigits.Name = "lblNumberOfDigits";
            this.lblNumberOfDigits.Size = new System.Drawing.Size(206, 28);
            this.lblNumberOfDigits.TabIndex = 12;
            this.lblNumberOfDigits.Text = "Number Of Digits: ";
            // 
            // lblCopy
            // 
            this.lblCopy.AutoSize = true;
            this.lblCopy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCopy.Font = new System.Drawing.Font("Tahoma", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCopy.ForeColor = System.Drawing.Color.Purple;
            this.lblCopy.Location = new System.Drawing.Point(413, 145);
            this.lblCopy.Name = "lblCopy";
            this.lblCopy.Size = new System.Drawing.Size(45, 18);
            this.lblCopy.TabIndex = 6;
            this.lblCopy.Text = "Copy";
            this.lblCopy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCopy.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lblCopy_MouseClick);
            // 
            // txtResult
            // 
            this.txtResult.BackColor = System.Drawing.Color.MediumPurple;
            this.txtResult.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult.ForeColor = System.Drawing.Color.Black;
            this.txtResult.Location = new System.Drawing.Point(12, 12);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(497, 151);
            this.txtResult.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblCopy);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.gbOptions);
            this.Controls.Add(this.btnOptions);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnExit);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbOptions.ResumeLayout(false);
            this.gbOptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnOptions;
        private System.Windows.Forms.GroupBox gbOptions;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lblNumberOfDigits;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.CheckBox chkSymbols;
        private System.Windows.Forms.CheckBox chkMix;
        private System.Windows.Forms.CheckBox chkNumbers;
        private System.Windows.Forms.CheckBox chkLetters;
        private System.Windows.Forms.Label lblCopy;
        private System.Windows.Forms.TextBox txtResult;
    }
}

