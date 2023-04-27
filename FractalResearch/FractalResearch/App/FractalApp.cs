using FractalResearch.Filters;

namespace FractalResearch
{
    public partial class FractalApp : Form
    {
        private string _filename;
        private Bitmap _activeImage;
        private Bitmap _filteredImage;
        private Bitmap _noisedImage;

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
            if (cbBoxFilter.SelectedItem.ToString() == "Threshold")
            {
                if (!string.IsNullOrEmpty(_filename) && _activeImage != null)
                {
                    _filteredImage = ImageFilters.ThresholdFilter(_activeImage, (byte)nudThreshold.Value);
                    pbImage.Image = _filteredImage;
                }
            }
            if (cbBoxFilter.SelectedItem.ToString() == "Edge")
            {
                if (!string.IsNullOrEmpty(_filename) && _activeImage != null)
                {
                    _filteredImage = ImageFilters.EdgeFilter(_activeImage, (byte)nudThreshold.Value);
                    pbImage.Image = _filteredImage;
                }
            }
        }

        private void btnUpdateNoise_Click(object sender, EventArgs e)
        {
            if (cbBoxNoiseType.SelectedItem.ToString() == "Uniform")
            {
                if (!string.IsNullOrEmpty(_filename) && _filteredImage != null)
                {
                    _noisedImage = ImageFilters.UniformNoiseFilter(_filteredImage, (double)nudNoise.Value);
                    pbImage.Image = _noisedImage;
                    int count = ImageUtilities.CountBlackPixels(_noisedImage);
                    rtbOutput.Text = $"Counted {count} black pixels in {_filename}";
                }
            }
            if (cbBoxNoiseType.SelectedItem.ToString() == "Gaussian")
            {
                //if (!string.IsNullOrEmpty(_filename) && _activeImage != null)
                //{
                //    _filteredImage = ImageFilters.EdgeFilter(_activeImage, (byte)nudThreshold.Value);
                //    pbImage.Image = _filteredImage;
                //}
            }
        }

        private void btnFdGo_Click(object sender, EventArgs e)
        {

        }

        private void cbBoxFilter_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbBoxFilter.SelectedItem.ToString() == "Threshold")
            {
                nudThreshold.Value = 50;
                nudThreshold.Increment = 5;
            }
            if (cbBoxFilter.SelectedItem.ToString() == "Edge")
            {
                nudThreshold.Value = 10;
                nudThreshold.Increment = 1;
            }
        }
    }
}