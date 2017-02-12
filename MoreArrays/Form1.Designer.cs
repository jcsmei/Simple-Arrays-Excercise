namespace MoreArrays
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
            this.btnTwoDimensionalArray = new System.Windows.Forms.Button();
            this.btnJaggedArray = new System.Windows.Forms.Button();
            this.rtbDisplay = new System.Windows.Forms.RichTextBox();
            this.btnPractice = new System.Windows.Forms.Button();
            this.btnDisplayArray = new System.Windows.Forms.Button();
            this.lblDisplay = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnTwoDimensionalArray
            // 
            this.btnTwoDimensionalArray.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTwoDimensionalArray.Location = new System.Drawing.Point(12, 24);
            this.btnTwoDimensionalArray.Name = "btnTwoDimensionalArray";
            this.btnTwoDimensionalArray.Size = new System.Drawing.Size(214, 70);
            this.btnTwoDimensionalArray.TabIndex = 0;
            this.btnTwoDimensionalArray.Text = "Two-Dimensional Array";
            this.btnTwoDimensionalArray.UseVisualStyleBackColor = true;
            this.btnTwoDimensionalArray.Click += new System.EventHandler(this.btnTwoDimensionalArray_Click);
            // 
            // btnJaggedArray
            // 
            this.btnJaggedArray.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJaggedArray.Location = new System.Drawing.Point(255, 24);
            this.btnJaggedArray.Name = "btnJaggedArray";
            this.btnJaggedArray.Size = new System.Drawing.Size(200, 70);
            this.btnJaggedArray.TabIndex = 1;
            this.btnJaggedArray.Text = "Jagged Array";
            this.btnJaggedArray.UseVisualStyleBackColor = true;
            this.btnJaggedArray.Click += new System.EventHandler(this.btnJaggedArray_Click);
            // 
            // rtbDisplay
            // 
            this.rtbDisplay.Location = new System.Drawing.Point(12, 100);
            this.rtbDisplay.Name = "rtbDisplay";
            this.rtbDisplay.Size = new System.Drawing.Size(443, 332);
            this.rtbDisplay.TabIndex = 2;
            this.rtbDisplay.Text = "";
            // 
            // btnPractice
            // 
            this.btnPractice.Location = new System.Drawing.Point(12, 448);
            this.btnPractice.Name = "btnPractice";
            this.btnPractice.Size = new System.Drawing.Size(75, 23);
            this.btnPractice.TabIndex = 3;
            this.btnPractice.Text = "Pratice";
            this.btnPractice.UseVisualStyleBackColor = true;
            this.btnPractice.Click += new System.EventHandler(this.btnPractice_Click);
            // 
            // btnDisplayArray
            // 
            this.btnDisplayArray.Location = new System.Drawing.Point(338, 448);
            this.btnDisplayArray.Name = "btnDisplayArray";
            this.btnDisplayArray.Size = new System.Drawing.Size(117, 23);
            this.btnDisplayArray.TabIndex = 4;
            this.btnDisplayArray.Text = "Practice_Loop";
            this.btnDisplayArray.UseVisualStyleBackColor = true;
            this.btnDisplayArray.Click += new System.EventHandler(this.btnDisplayArray_Click);
            // 
            // lblDisplay
            // 
            this.lblDisplay.BackColor = System.Drawing.Color.White;
            this.lblDisplay.Location = new System.Drawing.Point(107, 435);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(191, 36);
            this.lblDisplay.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 499);
            this.Controls.Add(this.lblDisplay);
            this.Controls.Add(this.btnDisplayArray);
            this.Controls.Add(this.btnPractice);
            this.Controls.Add(this.rtbDisplay);
            this.Controls.Add(this.btnJaggedArray);
            this.Controls.Add(this.btnTwoDimensionalArray);
            this.Name = "Form1";
            this.Text = "Two-Dimensional arrays and jagged arrays";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTwoDimensionalArray;
        private System.Windows.Forms.Button btnJaggedArray;
        private System.Windows.Forms.RichTextBox rtbDisplay;
        private System.Windows.Forms.Button btnPractice;
        private System.Windows.Forms.Button btnDisplayArray;
        private System.Windows.Forms.Label lblDisplay;
    }
}

