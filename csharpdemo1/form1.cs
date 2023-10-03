namespace csharpdemo1
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }

        private void btn_New_Click(object sender, EventArgs e)
        {
            //String str = "server = GWT; database = winformtest; UID=sa;password=glob@l123";

            statusform Sform = new statusform();
            Sform.ShowDialog();
                

           
        }

        private void form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}