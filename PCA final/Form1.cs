namespace PCA_final
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonEntrar_Click(object sender, EventArgs e)
        {
            buttonEntrar.Visible = false;   
            Form2 form2 = new Form2();  
            form2.Show();   

        }
    }



}
    


