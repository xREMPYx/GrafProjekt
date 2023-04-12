using GrafProjekt.Service;

namespace GrafProjekt
{
    public partial class MainForm : Form
    {
        private ServiceChart serviceChart;
        public MainForm()
        {
            InitializeComponent();
            this.DateTimePicker_From.Value = DateTime.Now.AddMonths(-24);
        }       

        private void ChartPictureBox_Paint(object sender, PaintEventArgs e)
        {
            if(serviceChart is not null)
            {
                serviceChart.Print(e.Graphics);
            }
        }

        private void Btn_Refresh_Click(object sender, EventArgs e)
        {
            serviceChart = new(this.DateTimePicker_From.Value, this.DateTimePicker_To.Value);

            this.ChartPictureBox.Refresh();
        }     
    }
}