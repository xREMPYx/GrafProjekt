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
    }
}