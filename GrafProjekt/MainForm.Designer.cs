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
            ChartPictureBox = new PictureBox();
            DateTimePicker_From = new DateTimePicker();
            DateTimePicker_To = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            Btn_Refresh = new Button();
            colorDialog = new ColorDialog();
            button1 = new Button();
            label_file_name = new Label();
            trackBar_accuracy = new TrackBar();
            label4 = new Label();
            label3 = new Label();
            trackBar_line_width = new TrackBar();
            ((System.ComponentModel.ISupportInitialize)ChartPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar_accuracy).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar_line_width).BeginInit();
            SuspendLayout();
            // 
            // ChartPictureBox
            // 
            ChartPictureBox.BackColor = Color.Transparent;
            ChartPictureBox.Location = new Point(21, 24);
            ChartPictureBox.Name = "ChartPictureBox";
            ChartPictureBox.Size = new Size(639, 460);
            ChartPictureBox.TabIndex = 0;
            ChartPictureBox.TabStop = false;
            ChartPictureBox.Paint += ChartPictureBox_Paint;
            ChartPictureBox.MouseLeave += ChartPictureBox_MouseLeave;
            ChartPictureBox.MouseMove += ChartPictureBox_MouseMove;
            // 
            // DateTimePicker_From
            // 
            DateTimePicker_From.Location = new Point(666, 42);
            DateTimePicker_From.Name = "DateTimePicker_From";
            DateTimePicker_From.Size = new Size(200, 23);
            DateTimePicker_From.TabIndex = 1;
            DateTimePicker_From.Value = new DateTime(2010, 1, 1, 23, 59, 0, 0);
            DateTimePicker_From.ValueChanged += DateTimePicker_From_ValueChanged;
            // 
            // DateTimePicker_To
            // 
            DateTimePicker_To.Location = new Point(666, 101);
            DateTimePicker_To.Name = "DateTimePicker_To";
            DateTimePicker_To.Size = new Size(200, 23);
            DateTimePicker_To.TabIndex = 2;
            DateTimePicker_To.ValueChanged += DateTimePicker_To_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(666, 24);
            label1.Name = "label1";
            label1.Size = new Size(26, 15);
            label1.TabIndex = 3;
            label1.Text = "Od:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(666, 83);
            label2.Name = "label2";
            label2.Size = new Size(25, 15);
            label2.TabIndex = 4;
            label2.Text = "Do:";
            // 
            // Btn_Refresh
            // 
            Btn_Refresh.Location = new Point(666, 147);
            Btn_Refresh.Name = "Btn_Refresh";
            Btn_Refresh.Size = new Size(200, 23);
            Btn_Refresh.TabIndex = 5;
            Btn_Refresh.Text = "Obnovit";
            Btn_Refresh.UseVisualStyleBackColor = true;
            Btn_Refresh.Click += Btn_Refresh_Click;
            // 
            // button1
            // 
            button1.Location = new Point(750, 461);
            button1.Name = "button1";
            button1.Size = new Size(121, 23);
            button1.TabIndex = 6;
            button1.Text = "Zvolit zdroj";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Button_Change_File_Click;
            // 
            // label_file_name
            // 
            label_file_name.AutoSize = true;
            label_file_name.Location = new Point(666, 465);
            label_file_name.Name = "label_file_name";
            label_file_name.Size = new Size(61, 15);
            label_file_name.TabIndex = 7;
            label_file_name.Text = "BRK-A.csv";
            // 
            // trackBar_accuracy
            // 
            trackBar_accuracy.LargeChange = 1;
            trackBar_accuracy.Location = new Point(666, 212);
            trackBar_accuracy.Maximum = 5;
            trackBar_accuracy.Minimum = 1;
            trackBar_accuracy.Name = "trackBar_accuracy";
            trackBar_accuracy.Size = new Size(200, 45);
            trackBar_accuracy.TabIndex = 8;
            trackBar_accuracy.Value = 1;
            trackBar_accuracy.ValueChanged += trackBar_accuracy_ValueChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(666, 194);
            label4.Name = "label4";
            label4.Size = new Size(143, 15);
            label4.TabIndex = 9;
            label4.Text = "Přesnost (počet záznamů)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(666, 256);
            label3.Name = "label3";
            label3.Size = new Size(88, 15);
            label3.TabIndex = 11;
            label3.Text = "Šírka čáry grafu";
            // 
            // trackBar_line_width
            // 
            trackBar_line_width.LargeChange = 10;
            trackBar_line_width.Location = new Point(666, 274);
            trackBar_line_width.Maximum = 40;
            trackBar_line_width.Minimum = 15;
            trackBar_line_width.Name = "trackBar_line_width";
            trackBar_line_width.Size = new Size(200, 45);
            trackBar_line_width.TabIndex = 10;
            trackBar_line_width.Value = 15;
            trackBar_line_width.ValueChanged += trackBar_line_width_ValueChanged;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(883, 503);
            Controls.Add(label3);
            Controls.Add(trackBar_line_width);
            Controls.Add(label4);
            Controls.Add(trackBar_accuracy);
            Controls.Add(label_file_name);
            Controls.Add(button1);
            Controls.Add(Btn_Refresh);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(DateTimePicker_To);
            Controls.Add(DateTimePicker_From);
            Controls.Add(ChartPictureBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "MainForm";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)ChartPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar_accuracy).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar_line_width).EndInit();
            ResumeLayout(false);
            PerformLayout();
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