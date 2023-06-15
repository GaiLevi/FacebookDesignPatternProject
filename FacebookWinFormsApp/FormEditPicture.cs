using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public partial class FormEditPicture : Form
    {
        private Graphics m_GraphicPanel;
        private Graphics m_GraphicImage;
        private Bitmap m_BitMap;
        private Color m_Color;
        private readonly Image r_Image;
        public bool m_IsDrawing { get; set; }
        public event FormClosingEventHandler FormEditPictureClosing;
        private readonly Rectangle r_PanelLocation;


        public FormEditPicture(Image i_Image)
        {
            InitializeComponent();
            m_IsDrawing = false;
            m_Color = Color.Black;
            r_Image = i_Image;
            FormClosing += OnFormEditPictureClosing;
            panelEditPicture.BackgroundImage = r_Image;
            panelEditPicture.BackgroundImageLayout = ImageLayout.Stretch;
            r_PanelLocation = new Rectangle(0, 0, panelEditPicture.Width, panelEditPicture.Height);
        }

        private void formEditPicture_Load(object sender, EventArgs e)
        {
            m_GraphicPanel = panelEditPicture.CreateGraphics();
            m_BitMap = new Bitmap(panelEditPicture.Width, panelEditPicture.Height);
            m_GraphicImage = Graphics.FromImage(m_BitMap);
            Bitmap chosenPictureBitmap = new Bitmap(r_Image);
            m_GraphicImage.DrawImage(chosenPictureBitmap, r_PanelLocation);
            m_GraphicPanel.DrawImage(m_BitMap, r_PanelLocation);
        }

        private void panelEditPicture_MouseDown(object sender, MouseEventArgs e)
        {
            m_IsDrawing = true;
        }

        private void panelEditPicture_MouseUp(object sender, MouseEventArgs e)
        {
            m_IsDrawing = false;
        }

        private void buttonColor_Click(object sender, EventArgs e)
        {
            ColorDialog chooseColorDialog = new ColorDialog();
            chooseColorDialog.ShowDialog();
            m_Color = chooseColorDialog.Color;
        }

        private void panelEditPicture_MouseMove(object sender, MouseEventArgs e)
        {
            if (m_IsDrawing)
            {
                Rectangle mouseRect = new Rectangle(e.X - (trackBar1.Value / 2), e.Y - (trackBar1.Value / 2), (trackBar1.Value), (trackBar1.Value));
                m_GraphicImage.FillRectangle(new SolidBrush(m_Color), mouseRect);
                m_GraphicPanel.DrawImage(m_BitMap, r_PanelLocation);
            }
        }

        private void buttonSavePicture_Click(object sender, EventArgs e)
        {
            SaveFileDialog savePictureDialog = new SaveFileDialog();
            savePictureDialog.Filter = "JPEG files (*.jpg)|*.jpg|PNG files (*.png)|*.png|GIF files (*.gif)|*.gif|All files (*.*)|*.*";
            savePictureDialog.FilterIndex = 1;
            savePictureDialog.RestoreDirectory = true;
            if (savePictureDialog.ShowDialog() == DialogResult.OK)
            {
                m_BitMap.Save(savePictureDialog.FileName, System.Drawing.Imaging.ImageFormat.Bmp);
            }
        }

        protected virtual void OnFormEditPictureClosing(object sender, FormClosingEventArgs e)
        {
            if (FormEditPictureClosing != null)
            {
                FormEditPictureClosing.Invoke(sender, e);
            }
        }
    }
}
