namespace WinForm1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // message box, can be changed in many ways
        private void Form1_Load(object sender, EventArgs e)
        {
            string message = "Do you want to close window";
            string messagetitle = "Close window";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, messagetitle, buttons);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            else if(result == DialogResult.No)
            {
                // do nothing
            } 
        }
    }
}
