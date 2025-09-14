using Microsoft.ML;
using Microsoft.ML;
using Microsoft.ML.Data;
using Microsoft.ML.OnnxRuntime.Tensors;
using Microsoft.ML.Transforms.Onnx;
using SixLabors.ImageSharp;
using StableDiffusion.ML.OnnxRuntime;
using Image = System.Drawing.Image;


namespace ArtGalleryMainApp
{
    public partial class Mai : Form
    {
        public Mai()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;

            // Maximize the form to fill the screen
            this.WindowState = FormWindowState.Maximized;

           
        }
        


        private void btnLoadImages_Click_1(object sender, EventArgs e)
        {  // Clear any previously loaded images
            flowLayoutPanelImages.Controls.Clear();

            // Get the folder path from a FolderBrowserDialog or hardcode it
            using (var folderDialog = new FolderBrowserDialog())
            {
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    string folderPath = folderDialog.SelectedPath;
                    DisplayImages(folderPath);
                }
            }
        }

        private void DisplayImages(string folderPath)
        {
            string[] imageFiles = Directory.GetFiles(folderPath, "*.*", SearchOption.TopDirectoryOnly);

            foreach (string filePath in imageFiles)
            {
                // Check for common image extensions
                if (filePath.ToLower().EndsWith(".jpg") || filePath.ToLower().EndsWith(".jpeg") ||
                    filePath.ToLower().EndsWith(".png") || filePath.ToLower().EndsWith(".gif"))
                {
                    try
                    {
                        // Create a PictureBox for each image
                        PictureBox pb = new PictureBox();

                        // Load the image into a MemoryStream to prevent file locking
                        using (var stream = new MemoryStream(File.ReadAllBytes(filePath)))
                        {
                            pb.Image = System.Drawing.Image.FromStream(stream);
                        }

                        // Set the size of the thumbnail
                        pb.Size = new System.Drawing.Size(100, 100);

                        // Set the SizeMode to Zoom to fit the image nicely
                        pb.SizeMode = PictureBoxSizeMode.Zoom;

                        // Add the PictureBox to the FlowLayoutPanel
                        flowLayoutPanelImages.Controls.Add(pb);
                    }
                    catch (Exception ex)
                    {
                        // Handle potential errors (e.g., corrupted image file)
                        Console.WriteLine($"Could not load image: {filePath}. Error: {ex.Message}");
                    }
                }
            }
        }

        private void flowLayoutPanelImages_Paint(object sender, PaintEventArgs e)
        {

        }
        private void DisplayImages1(string folderPath)
        {
            string[] imageFiles = Directory.GetFiles(folderPath, "*.*", SearchOption.TopDirectoryOnly);

            foreach (string filePath in imageFiles)
            {
                // Check for common image extensions
                if (filePath.ToLower().EndsWith(".jpg") || filePath.ToLower().EndsWith(".jpeg") ||
                    filePath.ToLower().EndsWith(".png") || filePath.ToLower().EndsWith(".gif"))
                {
                    try
                    {
                        // Create a PictureBox for each image
                        PictureBox pb = new PictureBox();

                        // Load the image into a MemoryStream to prevent file locking
                        using (var stream = new MemoryStream(File.ReadAllBytes(filePath)))
                        {
                            pb.Image = Image.FromStream(stream);
                        }

                        // Set the size of the thumbnail
                        pb.Size = new System.Drawing.Size(200, 200);

                        // Set the SizeMode to Zoom to fit the image nicely
                        pb.SizeMode = PictureBoxSizeMode.Zoom;

                        // Add the PictureBox to the FlowLayoutPanel
                        flowLayoutPanel1.Controls.Add(pb);
                    }
                    catch (Exception ex)
                    {
                        // Handle potential errors (e.g., corrupted image file)
                        Console.WriteLine($"Could not load image: {filePath}. Error: {ex.Message}");
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Clear any previously loaded images
            flowLayoutPanel1.Controls.Clear();

            // Get the folder path from a FolderBrowserDialog or hardcode it
            using (var folderDialog = new FolderBrowserDialog())
            {
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    string folderPath = folderDialog.SelectedPath;
                    DisplayImages1(folderPath);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();

            //Default args
            var prompt = "a New Tattoo ";
            Console.WriteLine(prompt);

            try
            {
                var config = new StableDiffusionConfig
                {
                    // Number of denoising steps
                    NumInferenceSteps = 15,
                    // Scale for classifier-free guidance
                    GuidanceScale = 7.5,
                    // Set your preferred Execution Provider. Currently DirectML and CPU are supported.
                    ExecutionProviderTarget = StableDiffusionConfig.ExecutionProvider.DirectML,
                    // Set GPU Device ID.
                    DeviceId = 1,
                    // Update paths to your models
                    TextEncoderOnnxPath = @".\models\text_encoder\model.onnx",
                    UnetOnnxPath = @".\models\unet\model.onnx",
                    VaeDecoderOnnxPath = @".\models\vae_decoder\model.onnx",
                    SafetyModelPath = @".\models\safety_checker\model.onnx",
                };

                // Inference Stable Diff
                var image = UNet.Inference(prompt, config);
                image.SaveAsPng(@"c:\Temp\output1.jpg");
            }
            catch (Exception)
            {

               
            }
            DisplayImages1(@"c:\Temp");
            // If image failed or was unsafe it will return null.
            

        }




    }
}
