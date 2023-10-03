using System.Data;
using System.Data.SqlClient;

namespace csharpdemo1
{
    public partial class form1 : Form
    {

        SqlConnection con;
        SqlCommand cmd;
        DataTable table = new DataTable();

        public form1()
        {
            InitializeComponent();
        }

        private void btn_New_Click(object sender, EventArgs e)
        {

            statusform Sform = new statusform();
            Sform.ShowDialog();



        }

        private void form1_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("data source=DESKTOP-8H2MGEO\\SHSQL2014;initial catalog=db_MyNote;integrated security=true");
            cmd = new SqlCommand("select * from tbl_Note", con);
            string selectquery = "select * from tbl_Note";
            SqlDataAdapter adpt = new SqlDataAdapter(selectquery, con);
            DataTable table = new DataTable();
            adpt.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}