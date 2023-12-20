using System.Drawing.Imaging;

namespace Lab8Main
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private bool Check()
        {
            if (keyTextBox.Text == "")
            {
                return false;
            }

            return true;
        }

        private void encodeButton_Click(object sender, EventArgs e)
        {
            if (!Check())
            {
                var errorForm = new ErrorForm("Сначала введите ключ!");
                errorForm.ShowDialog();
                return;
            }

            var decodedText = decodedTextBox.Text;
            var key = keyTextBox.Text;
            var encodedText = GammaEncryptor.Encrypt(decodedText, key);
            encodedTextBox.Text = encodedText;
        }

        private void decodeButton_Click(object sender, EventArgs e)
        {
            if (!Check())
            {
                var errorForm = new ErrorForm("Сначала введите ключ!");
                errorForm.ShowDialog();
                return;
            }

            var encodedText = encodedTextBox.Text;
            var key = keyTextBox.Text;
            var decodedText = GammaEncryptor.Decrypt(encodedText, key);
            decodedTextBox.Text = decodedText;
        }
    }
}
