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
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.label_file_name = new System.Windows.Forms.Label();
            this.trackBar_accuracy = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.trackBar_line_width = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.ChartPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_accuracy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_line_width)).BeginInit();
            this.SuspendLayout();
            // 
            // ChartPictureBox
            // 
            this.ChartPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.ChartPictureBox.Location = new System.Drawing.Point(21, 24);
            this.ChartPictureBox.Name = "ChartPictureBox";
            this.ChartPictureBox.Size = new System.Drawing.Size(639, 460);
            this.ChartPictureBox.TabIndex = 0;
            this.ChartPictureBox.TabStop = false;
            this.ChartPictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.ChartPictureBox_Paint);
            this.ChartPictureBox.MouseLeave += new System.EventHandler(this.ChartPictureBox_MouseLeave);
            this.ChartPictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ChartPictureBox_MouseMove);
            // 
            // DateTimePicker_From
            // 
            this.DateTimePicker_From.Location = new System.Drawing.Point(666, 42);
            this.DateTimePicker_From.Name = "DateTimePicker_From";
            this.DateTimePicker_From.Size = new System.Drawing.Size(200, 23);
            this.DateTimePicker_From.TabIndex = 1;
            this.DateTimePicker_From.Value = new System.DateTime(2010, 1, 1, 23, 59, 0, 0);
            this.DateTimePicker_From.ValueChanged += new System.EventHandler(this.DateTimePicker_From_ValueChanged);
            // 
            // DateTimePicker_To
            // 
            this.DateTimePicker_To.Location = new System.Drawing.Point(666, 101);
            this.DateTimePicker_To.Name = "DateTimePicker_To";
            this.DateTimePicker_To.Size = new System.Drawing.Size(200, 23);
            this.DateTimePicker_To.TabIndex = 2;
            this.DateTimePicker_To.ValueChanged += new System.EventHandler(this.DateTimePicker_To_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(666, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Od:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(666, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Do:";
            // 
            // Btn_Refresh
            // 
            this.Btn_Refresh.Location = new System.Drawing.Point(666, 147);
            this.Btn_Refresh.Name = "Btn_Refresh";
            this.Btn_Refresh.Size = new System.Drawing.Size(200, 23);
            this.Btn_Refresh.TabIndex = 5;
            this.Btn_Refresh.Text = "Obnovit";
            this.Btn_Refresh.UseVisualStyleBackColor = true;
            this.Btn_Refresh.Click += new System.EventHandler(this.Btn_Refresh_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(750, 461);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Zvolit zdroj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button_Change_File_Click);
            // 
            // label_file_name
            // 
            this.label_file_name.AutoSize = true;
            this.label_file_name.Location = new System.Drawing.Point(666, 465);
            this.label_file_name.Name = "label_file_name";
            this.label_file_name.Size = new System.Drawing.Size(53, 15);
            this.label_file_name.TabIndex = 7;
            this.label_file_name.Text = "TSLA.csv";
            // 
            // trackBar_accuracy
            // 
            this.trackBar_accuracy.LargeChange = 1;
            this.trackBar_accuracy.Location = new System.Drawing.Point(666, 212);
            this.trackBar_accuracy.Maximum = 5;
            this.trackBar_accuracy.Minimum = 1;
            this.trackBar_accuracy.Name = "trackBar_accuracy";
            this.trackBar_accuracy.Size = new System.Drawing.Size(200, 45);
            this.trackBar_accuracy.TabIndex = 8;
            this.trackBar_accuracy.Value = 1;
            this.trackBar_accuracy.ValueChanged += new System.EventHandler(this.trackBar_accuracy_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(666, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Přesnost (počet záznamů)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(666, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Šírka čáry grafu";
            // 
            // trackBar_line_width
            // 
            this.trackBar_line_width.LargeChange = 10;
            this.trackBar_line_width.Location = new System.Drawing.Point(666, 274);
            this.trackBar_line_width.Maximum = 40;
            this.trackBar_line_width.Minimum = 10;
            this.trackBar_line_width.Name = "trackBar_line_width";
            this.trackBar_line_width.Size = new System.Drawing.Size(200, 45);
            this.trackBar_line_width.TabIndex = 10;
            this.trackBar_line_width.Value = 10;
            this.trackBar_line_width.ValueChanged += new System.EventHandler(this.trackBar_line_width_ValueChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 503);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.trackBar_line_width);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.trackBar_accuracy);
            this.Controls.Add(this.label_file_name);
            this.Controls.Add(this.button1);
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
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_accuracy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_line_width)).EndInit();
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
        private ColorDialog colorDialog;
        private Button button1;
        private Label label_file_name;
        private TrackBar trackBar_accuracy;
        private Label label4;
        private Label label3;
        private TrackBar trackBar_line_width;
    }
}