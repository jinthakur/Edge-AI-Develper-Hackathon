

namespace ArtGalleryMainApp
{
    partial class Mai
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mai));
            btnLoadImages = new Button();
            flowLayoutPanelImages = new FlowLayoutPanel();
            button1 = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnLoadImages
            // 
            btnLoadImages.Location = new Point(374, 745);
            btnLoadImages.Name = "btnLoadImages";
            btnLoadImages.Size = new Size(236, 29);
            btnLoadImages.TabIndex = 0;
            btnLoadImages.Text = "Press for Pictures";
            btnLoadImages.UseVisualStyleBackColor = true;
            btnLoadImages.Click += btnLoadImages_Click_1;
            // 
            // flowLayoutPanelImages
            // 
            flowLayoutPanelImages.Location = new Point(834, 128);
            flowLayoutPanelImages.Name = "flowLayoutPanelImages";
            flowLayoutPanelImages.Size = new Size(785, 593);
            flowLayoutPanelImages.TabIndex = 1;
            flowLayoutPanelImages.Paint += flowLayoutPanelImages_Paint;
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.Location = new Point(24, 745);
            button1.Name = "button1";
            button1.Size = new Size(236, 30);
            button1.TabIndex = 2;
            button1.Text = "Press for Your Body part";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(3, 275);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(794, 446);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // button2
            // 
            button2.Location = new Point(648, 745);
            button2.Name = "button2";
            button2.Size = new Size(236, 29);
            button2.TabIndex = 3;
            button2.Text = "Press for Suggestions";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(422, 245);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // Mai
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1651, 795);
            Controls.Add(pictureBox1);
            Controls.Add(button2);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(button1);
            Controls.Add(flowLayoutPanelImages);
            Controls.Add(btnLoadImages);
            Name = "Mai";
            Text = "Main";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnLoadImages;
        private FlowLayoutPanel flowLayoutPanelImages;
        private Button button1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button button2;
        private PictureBox pictureBox1;
    }
}
