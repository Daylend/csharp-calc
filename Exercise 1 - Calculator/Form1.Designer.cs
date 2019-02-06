namespace Exercise_1___Calculator
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
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.btnBackspace = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnNegative = new System.Windows.Forms.Button();
            this.btnDecBin = new System.Windows.Forms.Button();
            this.btnBinDec = new System.Windows.Forms.Button();
            this.btnShiftL = new System.Windows.Forms.Button();
            this.btnShiftR = new System.Windows.Forms.Button();
            this.btnAND = new System.Windows.Forms.Button();
            this.btnOR = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnDot = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnEqual = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtOutput
            // 
            this.txtOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutput.Location = new System.Drawing.Point(12, 12);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.Size = new System.Drawing.Size(269, 49);
            this.txtOutput.TabIndex = 0;
            this.txtOutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnBackspace
            // 
            this.btnBackspace.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackspace.Location = new System.Drawing.Point(12, 67);
            this.btnBackspace.Name = "btnBackspace";
            this.btnBackspace.Size = new System.Drawing.Size(51, 35);
            this.btnBackspace.TabIndex = 1;
            this.btnBackspace.Text = "←";
            this.btnBackspace.UseVisualStyleBackColor = true;
            this.btnBackspace.Click += new System.EventHandler(this.btnBackspace_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(69, 67);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(51, 35);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnNegative
            // 
            this.btnNegative.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNegative.Location = new System.Drawing.Point(126, 67);
            this.btnNegative.Name = "btnNegative";
            this.btnNegative.Size = new System.Drawing.Size(55, 35);
            this.btnNegative.TabIndex = 2;
            this.btnNegative.Text = "±";
            this.btnNegative.UseVisualStyleBackColor = true;
            this.btnNegative.Click += new System.EventHandler(this.btnNegative_Click);
            // 
            // btnDecBin
            // 
            this.btnDecBin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecBin.Location = new System.Drawing.Point(187, 67);
            this.btnDecBin.Name = "btnDecBin";
            this.btnDecBin.Size = new System.Drawing.Size(94, 35);
            this.btnDecBin.TabIndex = 2;
            this.btnDecBin.Text = "Dec → Bin";
            this.btnDecBin.UseVisualStyleBackColor = true;
            this.btnDecBin.Click += new System.EventHandler(this.btnDecBin_Click);
            // 
            // btnBinDec
            // 
            this.btnBinDec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBinDec.Location = new System.Drawing.Point(187, 108);
            this.btnBinDec.Name = "btnBinDec";
            this.btnBinDec.Size = new System.Drawing.Size(94, 35);
            this.btnBinDec.TabIndex = 2;
            this.btnBinDec.Text = "Bin → Dec";
            this.btnBinDec.UseVisualStyleBackColor = true;
            this.btnBinDec.Click += new System.EventHandler(this.btnBinDec_Click);
            // 
            // btnShiftL
            // 
            this.btnShiftL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShiftL.Location = new System.Drawing.Point(187, 149);
            this.btnShiftL.Name = "btnShiftL";
            this.btnShiftL.Size = new System.Drawing.Size(42, 35);
            this.btnShiftL.TabIndex = 2;
            this.btnShiftL.Text = "<<";
            this.btnShiftL.UseVisualStyleBackColor = true;
            this.btnShiftL.Click += new System.EventHandler(this.btnShiftL_Click);
            // 
            // btnShiftR
            // 
            this.btnShiftR.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShiftR.Location = new System.Drawing.Point(239, 149);
            this.btnShiftR.Name = "btnShiftR";
            this.btnShiftR.Size = new System.Drawing.Size(42, 35);
            this.btnShiftR.TabIndex = 2;
            this.btnShiftR.Text = ">>";
            this.btnShiftR.UseVisualStyleBackColor = true;
            this.btnShiftR.Click += new System.EventHandler(this.btnShiftR_Click);
            // 
            // btnAND
            // 
            this.btnAND.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAND.Location = new System.Drawing.Point(187, 186);
            this.btnAND.Name = "btnAND";
            this.btnAND.Size = new System.Drawing.Size(42, 35);
            this.btnAND.TabIndex = 2;
            this.btnAND.Text = "AND";
            this.btnAND.UseVisualStyleBackColor = true;
            this.btnAND.Click += new System.EventHandler(this.btnAND_Click);
            // 
            // btnOR
            // 
            this.btnOR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOR.Location = new System.Drawing.Point(239, 186);
            this.btnOR.Name = "btnOR";
            this.btnOR.Size = new System.Drawing.Size(42, 35);
            this.btnOR.TabIndex = 2;
            this.btnOR.Text = "OR";
            this.btnOR.UseVisualStyleBackColor = true;
            this.btnOR.Click += new System.EventHandler(this.btnOR_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(12, 108);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(51, 43);
            this.button8.TabIndex = 3;
            this.button8.Text = "7";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(69, 108);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(51, 43);
            this.button9.TabIndex = 3;
            this.button9.Text = "button8";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(126, 108);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(51, 43);
            this.button10.TabIndex = 3;
            this.button10.Text = "button8";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // btn7
            // 
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.Location = new System.Drawing.Point(12, 108);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(51, 43);
            this.btn7.TabIndex = 3;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn8
            // 
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.Location = new System.Drawing.Point(69, 108);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(51, 43);
            this.btn8.TabIndex = 3;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn9
            // 
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.Location = new System.Drawing.Point(126, 108);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(51, 43);
            this.btn9.TabIndex = 3;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 157);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(51, 43);
            this.button2.TabIndex = 3;
            this.button2.Text = "7";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btn4
            // 
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.Location = new System.Drawing.Point(12, 157);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(51, 43);
            this.btn4.TabIndex = 3;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(69, 157);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(51, 43);
            this.button4.TabIndex = 3;
            this.button4.Text = "button8";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // btn5
            // 
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.Location = new System.Drawing.Point(69, 157);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(51, 43);
            this.btn5.TabIndex = 3;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(126, 157);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(51, 43);
            this.button6.TabIndex = 3;
            this.button6.Text = "button8";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // btn6
            // 
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.Location = new System.Drawing.Point(126, 157);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(51, 43);
            this.btn6.TabIndex = 3;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(12, 206);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(51, 43);
            this.button11.TabIndex = 3;
            this.button11.Text = "7";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(12, 206);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(51, 43);
            this.btn1.TabIndex = 3;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(69, 206);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(51, 43);
            this.button13.TabIndex = 3;
            this.button13.Text = "button8";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(69, 206);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(51, 43);
            this.btn2.TabIndex = 3;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn_Click);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(126, 206);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(51, 43);
            this.button15.TabIndex = 3;
            this.button15.Text = "button8";
            this.button15.UseVisualStyleBackColor = true;
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.Location = new System.Drawing.Point(126, 206);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(51, 43);
            this.btn3.TabIndex = 3;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn0
            // 
            this.btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.Location = new System.Drawing.Point(12, 255);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(108, 43);
            this.btn0.TabIndex = 3;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnDot
            // 
            this.btnDot.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDot.Location = new System.Drawing.Point(126, 255);
            this.btnDot.Name = "btnDot";
            this.btnDot.Size = new System.Drawing.Size(51, 43);
            this.btnDot.TabIndex = 3;
            this.btnDot.Text = ".";
            this.btnDot.UseVisualStyleBackColor = true;
            this.btnDot.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivide.Location = new System.Drawing.Point(187, 225);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(42, 35);
            this.btnDivide.TabIndex = 2;
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinus.Location = new System.Drawing.Point(187, 263);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(42, 35);
            this.btnMinus.TabIndex = 2;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnMultiply
            // 
            this.btnMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiply.Location = new System.Drawing.Point(239, 225);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(42, 35);
            this.btnMultiply.TabIndex = 2;
            this.btnMultiply.Text = "*";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.Click += new System.EventHandler(this.btnMultiply_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlus.Location = new System.Drawing.Point(239, 263);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(42, 35);
            this.btnPlus.TabIndex = 2;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnEqual
            // 
            this.btnEqual.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEqual.Location = new System.Drawing.Point(12, 304);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(269, 46);
            this.btnEqual.TabIndex = 4;
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = true;
            this.btnEqual.Click += new System.EventHandler(this.btnEqual_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 357);
            this.Controls.Add(this.btnEqual);
            this.Controls.Add(this.btnDot);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.btnBinDec);
            this.Controls.Add(this.btnDecBin);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btnOR);
            this.Controls.Add(this.btnShiftR);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnAND);
            this.Controls.Add(this.btnShiftL);
            this.Controls.Add(this.btnNegative);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnBackspace);
            this.Controls.Add(this.txtOutput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Calculator by Daylend";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button btnBackspace;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnNegative;
        private System.Windows.Forms.Button btnDecBin;
        private System.Windows.Forms.Button btnBinDec;
        private System.Windows.Forms.Button btnShiftL;
        private System.Windows.Forms.Button btnShiftR;
        private System.Windows.Forms.Button btnAND;
        private System.Windows.Forms.Button btnOR;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnDot;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnEqual;
    }
}

