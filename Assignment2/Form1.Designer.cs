namespace Assignment2
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
            this.inputData = new System.Windows.Forms.TextBox();
            this.drawButton = new System.Windows.Forms.Button();
            this.graph = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.graph)).BeginInit();
            this.SuspendLayout();
            // 
            // inputData
            // 
            this.inputData.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputData.Location = new System.Drawing.Point(339, 26);
            this.inputData.Name = "inputData";
            this.inputData.Size = new System.Drawing.Size(394, 33);
            this.inputData.TabIndex = 0;
            this.inputData.TextChanged += new System.EventHandler(this.input_TextChanged);
            // 
            // drawButton
            // 
            this.drawButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.drawButton.ForeColor = System.Drawing.Color.White;
            this.drawButton.Location = new System.Drawing.Point(590, 65);
            this.drawButton.Name = "drawButton";
            this.drawButton.Size = new System.Drawing.Size(143, 36);
            this.drawButton.TabIndex = 1;
            this.drawButton.Text = "Draw Graph";
            this.drawButton.UseVisualStyleBackColor = false;
            this.drawButton.Click += new System.EventHandler(this.drawButton_Click);
            // 
            // graph
            // 
            this.graph.Location = new System.Drawing.Point(30, 122);
            this.graph.Name = "graph";
            this.graph.Size = new System.Drawing.Size(758, 288);
            this.graph.TabIndex = 2;
            this.graph.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter Data seperated by commas -";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.graph);
            this.Controls.Add(this.drawButton);
            this.Controls.Add(this.inputData);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.graph)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputData;
        private System.Windows.Forms.Button drawButton;
        private System.Windows.Forms.PictureBox graph;
        private System.Windows.Forms.Label label1;
    }
}

