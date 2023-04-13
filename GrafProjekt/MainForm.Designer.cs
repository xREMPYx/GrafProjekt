namespace GrafProjekt
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ChartPictureBox = new System.Windows.Forms.PictureBox();
            this.DateTimePicker_From = new System.Windows.Forms.DateTimePicker();
            this.DateTimePicker_To = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Btn_Refresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ChartPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ChartPictureBox
            // 
            this.ChartPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.ChartPictureBox.Location = new System.Drawing.Point(5, 5);
            this.ChartPictureBox.Name = "ChartPictureBox";
            this.ChartPictureBox.Size = new System.Drawing.Size(650, 470);
            this.ChartPictureBox.TabIndex = 0;
            this.ChartPictureBox.TabStop = false;
            this.ChartPictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.ChartPictureBox_Paint);
            // 
            // DateTimePicker_From
            // 
            this.DateTimePicker_From.Location = new System.Drawing.Point(661, 27);
            this.DateTimePicker_From.Name = "DateTimePicker_From";
            this.DateTimePicker_From.Size = new System.Drawing.Size(200, 23);
            this.DateTimePicker_From.TabIndex = 1;
            // 
            // DateTimePicker_To
            // 
            this.DateTimePicker_To.Location = new System.Drawing.Point(661, 86);
            this.DateTimePicker_To.Name = "DateTimePicker_To";
            this.DateTimePicker_To.Size = new System.Drawing.Size(200, 23);
            this.DateTimePicker_To.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(661, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Od:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(661, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Do:";
            // 
            // Btn_Refresh
            // 
            this.Btn_Refresh.Location = new System.Drawing.Point(661, 132);
            this.Btn_Refresh.Name = "Btn_Refresh";
            this.Btn_Refresh.Size = new System.Drawing.Size(200, 23);
            this.Btn_Refresh.TabIndex = 5;
            this.Btn_Refresh.Text = "Obnovit";
            this.Btn_Refresh.UseVisualStyleBackColor = true;
            this.Btn_Refresh.Click += new System.EventHandler(this.Btn_Refresh_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 481);
            this.Controls.Add(this.Btn_Refresh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DateTimePicker_To);
            this.Controls.Add(this.DateTimePicker_From);
            this.Controls.Add(this.ChartPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ChartPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox ChartPictureBox;
        private DateTimePicker DateTimePicker_From;
        private DateTimePicker DateTimePicker_To;
        private Label label1;
        private Label label2;
        private Button Btn_Refresh;
    }
}