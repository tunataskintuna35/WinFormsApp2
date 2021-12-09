using System.IO;



namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //TopMost = true;
        }

       
        

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)


            {
                string dosyayolu = fbd.SelectedPath;

                string[] filePaths = Directory.GetFiles(dosyayolu, "*.xlsx", SearchOption.TopDirectoryOnly);

                System.Windows.Forms.MessageBox.Show("Dosya Say�s�: " + filePaths.Length.ToString(), "d�r.");

                progressBar1.Value = 33;
            }
            
            
                
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            
        }
    }
}