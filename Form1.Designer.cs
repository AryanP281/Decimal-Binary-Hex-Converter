namespace Decimal_to_binary_to_hex_converter
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
            this.boxInput = new System.Windows.Forms.TextBox();
            this.decimalN = new System.Windows.Forms.RadioButton();
            this.binaryN = new System.Windows.Forms.RadioButton();
            this.hexaN = new System.Windows.Forms.RadioButton();
            this.convertButton = new System.Windows.Forms.Button();
            this.binaryDisplay = new System.Windows.Forms.Label();
            this.hexDisplay = new System.Windows.Forms.Label();
            this.decimalDisplay = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // boxInput
            // 
            this.boxInput.Font = new System.Drawing.Font("Pericles", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxInput.Location = new System.Drawing.Point(496, 70);
            this.boxInput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.boxInput.Name = "boxInput";
            this.boxInput.Size = new System.Drawing.Size(408, 42);
            this.boxInput.TabIndex = 0;
            // 
            // decimalN
            // 
            this.decimalN.AutoSize = true;
            this.decimalN.Checked = true;
            this.decimalN.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decimalN.Location = new System.Drawing.Point(496, 30);
            this.decimalN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.decimalN.Name = "decimalN";
            this.decimalN.Size = new System.Drawing.Size(130, 35);
            this.decimalN.TabIndex = 1;
            this.decimalN.TabStop = true;
            this.decimalN.Text = "Decimal";
            this.decimalN.UseVisualStyleBackColor = true;
            // 
            // binaryN
            // 
            this.binaryN.AutoSize = true;
            this.binaryN.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.binaryN.Location = new System.Drawing.Point(644, 30);
            this.binaryN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.binaryN.Name = "binaryN";
            this.binaryN.Size = new System.Drawing.Size(109, 35);
            this.binaryN.TabIndex = 2;
            this.binaryN.Text = "Binary";
            this.binaryN.UseVisualStyleBackColor = true;
            // 
            // hexaN
            // 
            this.hexaN.AutoSize = true;
            this.hexaN.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hexaN.Location = new System.Drawing.Point(758, 30);
            this.hexaN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.hexaN.Name = "hexaN";
            this.hexaN.Size = new System.Drawing.Size(188, 35);
            this.hexaN.TabIndex = 3;
            this.hexaN.Text = "Hexadecimal";
            this.hexaN.UseVisualStyleBackColor = true;
            // 
            // convertButton
            // 
            this.convertButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.convertButton.Font = new System.Drawing.Font("Microsoft Himalaya", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convertButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.convertButton.Location = new System.Drawing.Point(549, 118);
            this.convertButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(262, 48);
            this.convertButton.TabIndex = 4;
            this.convertButton.Text = "Convert";
            this.convertButton.UseVisualStyleBackColor = false;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // binaryDisplay
            // 
            this.binaryDisplay.AutoSize = true;
            this.binaryDisplay.Font = new System.Drawing.Font("Microsoft Himalaya", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.binaryDisplay.Location = new System.Drawing.Point(488, 203);
            this.binaryDisplay.Name = "binaryDisplay";
            this.binaryDisplay.Size = new System.Drawing.Size(52, 47);
            this.binaryDisplay.TabIndex = 5;
            this.binaryDisplay.Text = "0b";
            // 
            // hexDisplay
            // 
            this.hexDisplay.AutoSize = true;
            this.hexDisplay.Font = new System.Drawing.Font("Microsoft Himalaya", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hexDisplay.Location = new System.Drawing.Point(488, 273);
            this.hexDisplay.Name = "hexDisplay";
            this.hexDisplay.Size = new System.Drawing.Size(52, 47);
            this.hexDisplay.TabIndex = 6;
            this.hexDisplay.Text = "0x";
            // 
            // decimalDisplay
            // 
            this.decimalDisplay.AutoSize = true;
            this.decimalDisplay.Font = new System.Drawing.Font("Microsoft Himalaya", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decimalDisplay.Location = new System.Drawing.Point(488, 342);
            this.decimalDisplay.Name = "decimalDisplay";
            this.decimalDisplay.Size = new System.Drawing.Size(154, 47);
            this.decimalDisplay.TabIndex = 7;
            this.decimalDisplay.Text = "Decimal:- ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(1197, 560);
            this.Controls.Add(this.decimalDisplay);
            this.Controls.Add(this.hexDisplay);
            this.Controls.Add(this.binaryDisplay);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.hexaN);
            this.Controls.Add(this.binaryN);
            this.Controls.Add(this.decimalN);
            this.Controls.Add(this.boxInput);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Decimal-Binary-Hexadecimal Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox boxInput;
        private System.Windows.Forms.RadioButton decimalN;
        private System.Windows.Forms.RadioButton binaryN;
        private System.Windows.Forms.RadioButton hexaN;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.Label binaryDisplay;
        private System.Windows.Forms.Label hexDisplay;
        private System.Windows.Forms.Label decimalDisplay;
    }
}


