using GrafProjekt.Service;

namespace GrafProjekt
{
    public partial class MainForm : Form
    {
        private ServiceChart serviceChart;
        public MainForm()
        {
            InitializeComponent();
            serviceChart = new ServiceChart();
        }

        private void ChartPictureBox_Paint(object sender, PaintEventArgs e)
        {
            serviceChart.Print(e.Graphics);
        }

        private void Btn_Refresh_Click(object sender, EventArgs e)
        {
            UpdateRecords();
        }

        private void UpdateRecords()
        {
            var from = this.DateTimePicker_From.Value;
            var to = this.DateTimePicker_To.Value;

            serviceChart.UpdateRecords(from, to);

            this.ChartPictureBox.Refresh();
        }

        private void ChartPictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            serviceChart.UpdateSelectedRecord(e);

            this.ChartPictureBox.Refresh();
        }

        private void ChartPictureBox_MouseLeave(object sender, EventArgs e)
        {
            serviceChart.DeleteSelectedRecord();
        }

        private void Button_Change_File_Click(object sender, EventArgs e)
        {
            this.label_file_name.Text = serviceChart.ChangeSourceFile();
        }

        private void trackBar_accuracy_ValueChanged(object sender, EventArgs e)
        {
            int v = this.trackBar_accuracy.Value;
            int r = v == 1 ?
                20 : v == 2 ?
                10 : v == 3 ?
                5 : v == 4 ?
                4 :
                2;

            ProgramSettings.ChartDisplayRecordsCount = ProgramSettings.ChartWidth / r;

            UpdateRecords();
        }

        private void trackBar_line_width_ValueChanged(object sender, EventArgs e)
        {
            int v = this.trackBar_line_width.Value;

            ProgramSettings.ChartLineWidth = v * 0.1f;

            this.ChartPictureBox.Refresh();
        }

        private void DateTimePicker_From_ValueChanged(object sender, EventArgs e)
        {
            var fromValue = this.DateTimePicker_From.Value;
            var toValue = this.DateTimePicker_To.Value;

            if (toValue.Subtract(fromValue) < TimeSpan.FromDays(90) || toValue < fromValue || fromValue > DateTime.Now.AddMonths(-3))
            {
                this.DateTimePicker_From.Value = toValue.AddMonths(-3).AddDays(-1);
                MessageBox.Show("Hodnoty datumù se musí lišit o více než 3 mìsíce a zárovìò hodnota datumu od musí být menší než do");
            }
        }

        private void DateTimePicker_To_ValueChanged(object sender, EventArgs e)
        {
            var fromValue = this.DateTimePicker_From.Value;
            var toValue = this.DateTimePicker_To.Value;

            if (toValue.Subtract(fromValue) < TimeSpan.FromDays(90) || toValue < fromValue || fromValue > DateTime.Now.AddMonths(-3))
            {
                this.DateTimePicker_To.Value = DateTime.Now;
                MessageBox.Show("Hodnoty datumù se musí lišit o více než 3 mìsíce a zárovìò hodnota datumu od musí být menší než do");
            }
        }
    }
}