using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; 

namespace NaviGUI
{
    public partial class NAVI : Form
    {
        public NAVI()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.StartPosition = FormStartPosition.CenterScreen;
            
           
        }

        private void ButtonAddImage_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.bmp;*.jpg;*.jpeg,*.png)|*.bmp;*.jpg;*.jpeg;*.png";

            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string imagePath = openFileDialog.FileName;
                Image newImage = Image.FromFile(imagePath);
                Sce
                
                
                // Use the imagePath string to load the image
            }
        }
    }
}
