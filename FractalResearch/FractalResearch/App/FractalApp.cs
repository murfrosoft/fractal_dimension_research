using FractalResearch.Filters;

namespace FractalResearch
{
    public partial class FractalApp : Form
    {
        private string _filename;
        private Bitmap _activeImage;
        private Bitmap _filteredImage;

        public FractalApp()
        {
            InitializeComponent();
        }

        private void btnChooseImage_Click(object sender, EventArgs e)
        {
            _filename = "";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                _filename = openFileDialog1.FileName;
                lblImageName.Text = _filename;
            }

            if (!string.IsNullOrEmpty(_filename))
            {
                _activeImage = new Bitmap(_filename);
                pbImage.Image = _activeImage;
            }
        }

        private void btnUpdateFilter_Click(object sender, EventArgs e)
        {
            if(cbBoxFilter.SelectedItem.ToString() == "Threshold")
            {
                if (!string.IsNullOrEmpty(_filename) && _activeImage != null)
                {
                    _filteredImage = ImageThresholdFilter.Filter(_activeImage, (byte)nudThreshold.Value);
                    pbImage.Image = _filteredImage;
                }
            }
        }

        private void btnUpdateNoise_Click(object sender, EventArgs e)
        {

        }

        private void btnFdGo_Click(object sender, EventArgs e)
        {

        }
    }
}