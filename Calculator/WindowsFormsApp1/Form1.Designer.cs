
namespace WindowsFormsApp1
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
            this.button1 = new System.Windows.Forms.Button();
            this.Output = new System.Windows.Forms.TextBox();
            this.Clear = new System.Windows.Forms.Button();
            this.isEqual = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.BackSpace = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(23, 124);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 47);
            this.button1.TabIndex = 0;
            this.button1.Text = "7";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.num_clicked);
            // 
            // Output
            // 
            this.Output.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Output.Location = new System.Drawing.Point(23, 38);
            this.Output.Name = "Output";
            this.Output.ReadOnly = true;
            this.Output.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Output.Size = new System.Drawing.Size(408, 62);
            this.Output.TabIndex = 1;
            this.Output.Text = "0";
            this.Output.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Clear
            // 
            this.Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear.Location = new System.Drawing.Point(367, 124);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(64, 47);
            this.Clear.TabIndex = 2;
            this.Clear.Text = "C";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // isEqual
            // 
            this.isEqual.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isEqual.Location = new System.Drawing.Point(367, 194);
            this.isEqual.Name = "isEqual";
            this.isEqual.Size = new System.Drawing.Size(64, 186);
            this.isEqual.TabIndex = 3;
            this.isEqual.Text = "=";
            this.isEqual.UseVisualStyleBackColor = true;
            this.isEqual.Click += new System.EventHandler(this.isEqual_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(285, 333);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(64, 47);
            this.button4.TabIndex = 4;
            this.button4.Text = "+";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Operation_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(285, 265);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(64, 47);
            this.button5.TabIndex = 5;
            this.button5.Text = "-";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Operation_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(285, 194);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(64, 47);
            this.button6.TabIndex = 6;
            this.button6.Text = "X";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Operation_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(285, 124);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(64, 47);
            this.button7.TabIndex = 7;
            this.button7.Text = "÷";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.Operation_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(203, 333);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(64, 47);
            this.button8.TabIndex = 8;
            this.button8.Text = ".";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // BackSpace
            // 
            this.BackSpace.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackSpace.Location = new System.Drawing.Point(23, 333);
            this.BackSpace.Name = "BackSpace";
            this.BackSpace.Size = new System.Drawing.Size(64, 47);
            this.BackSpace.TabIndex = 9;
            this.BackSpace.Text = "←";
            this.BackSpace.UseVisualStyleBackColor = true;
            this.BackSpace.Click += new System.EventHandler(this.BackSpace_Click);
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Location = new System.Drawing.Point(109, 333);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(64, 47);
            this.button10.TabIndex = 10;
            this.button10.Text = "0";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.num_clicked);
            // 
            // button11
            // 
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.Location = new System.Drawing.Point(203, 265);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(64, 47);
            this.button11.TabIndex = 11;
            this.button11.Text = "3";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.num_clicked);
            // 
            // button12
            // 
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.Location = new System.Drawing.Point(110, 265);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(64, 47);
            this.button12.TabIndex = 12;
            this.button12.Text = "2";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.num_clicked);
            // 
            // button13
            // 
            this.button13.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.Location = new System.Drawing.Point(23, 265);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(64, 47);
            this.button13.TabIndex = 13;
            this.button13.Text = "1";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.num_clicked);
            // 
            // button14
            // 
            this.button14.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.Location = new System.Drawing.Point(203, 194);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(64, 47);
            this.button14.TabIndex = 14;
            this.button14.Text = "6";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.num_clicked);
            // 
            // button15
            // 
            this.button15.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button15.Location = new System.Drawing.Point(109, 194);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(64, 47);
            this.button15.TabIndex = 15;
            this.button15.Text = "5";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.num_clicked);
            // 
            // button16
            // 
            this.button16.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button16.Location = new System.Drawing.Point(23, 194);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(64, 47);
            this.button16.TabIndex = 16;
            this.button16.Text = "4";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.num_clicked);
            // 
            // button17
            // 
            this.button17.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button17.Location = new System.Drawing.Point(203, 124);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(64, 47);
            this.button17.TabIndex = 17;
            this.button17.Text = "9";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.num_clicked);
            // 
            // button18
            // 
            this.button18.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button18.Location = new System.Drawing.Point(110, 124);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(64, 47);
            this.button18.TabIndex = 18;
            this.button18.Text = "8";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.num_clicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Calculator_zero_screen_grey_background;
            this.ClientSize = new System.Drawing.Size(453, 398);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.BackSpace);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.isEqual);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Output;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button isEqual;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button BackSpace;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
    }
}

