namespace DiscordCacheViewer
{
    public partial class frm_main : Form
    {
        public frm_main()
        {
            InitializeComponent();
            
            txt_cachePath.Text = @"C:\Users\" + Environment.UserName + @"\AppData\Roaming\discord\Cache";
            txt_savePath.Text = @"C:\Users\" + Environment.UserName + @"\Desktop";

            LoadCachedImages();
        }

        private void LoadCachedImages()
        {
            if (Directory.Exists(txt_cachePath.Text))
            {
                lvw_thumbnails.Clear();
                ImageList imageList = new ImageList();
                imageList.ImageSize = new System.Drawing.Size(128, 128);
                imageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth16Bit;
                lvw_thumbnails.LargeImageList = imageList;

                foreach (string file in Directory.GetFiles(txt_cachePath.Text))
                {
                    string filename = Path.GetFileName(file);
                    if (filename[0] == 'f')
                    {
                        try
                        {
                            imageList.Images.Add(Image.FromFile(file));
                            lvw_thumbnails.Items.Add(new ListViewItem(filename, imageList.Images.Count - 1));
                        }
                        catch (OutOfMemoryException ex)
                        { }
                    }
                }
                if(imageList.Images.Count == 0)
                {
                    lbl_noImagesFound.Visible = true;
                } else
                {
                    lbl_noImagesFound.Visible = false;
                }
            }
        }

        private void btn_restore_Click(object sender, EventArgs e)
        {
            foreach(ListViewItem i in lvw_thumbnails.SelectedItems)
            {
                string originalPath = txt_cachePath.Text + "\\" + i.Text;
                File.Copy(originalPath, txt_savePath.Text + "\\" + i.Text + "." + Image.FromFile(originalPath).RawFormat.ToString().ToLower(), true);
            }
        }

        private void btn_browseCachePath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                txt_cachePath.Text = folderBrowserDialog.SelectedPath;
                LoadCachedImages();
            }
        }

        private void btn_browseSavePath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                txt_savePath.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}