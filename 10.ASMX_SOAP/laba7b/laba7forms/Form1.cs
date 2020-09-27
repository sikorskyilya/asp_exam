using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba7forms
{
    public partial class Form1 : Form
    {
        WS.WebServiceSoapClient client; //прокси класс

        public Form1()
        {
            InitializeComponent();

            this.client = new WS.WebServiceSoapClient();
        }

        private void Get_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Text = Convert.ToString(this.client.GetAll());
        }

        private void Post_Click(object sender, EventArgs e)
        {
            if (!this.name.Text.Equals("") && !this.num.Text.Equals(""))
            {
                try
                {
                    string name = this.name.Text;
                    int number = Convert.ToInt32(this.num.Text);
                    if (this.client.AddDict(name, number) == "OK")
                        MessageBox.Show("Success add");
                    else
                        MessageBox.Show("Error during insert");
                }
                catch
                {
                    MessageBox.Show("Enter number in field for number");
                }
            }
            else
            {
                MessageBox.Show("Enter values in field name and number");
            }
        }

        private void Put_Click(object sender, EventArgs e)
        {
            if (!this.idUpd.Text.Equals("") && !this.nameUpd.Text.Equals("") && !this.numUpd.Text.Equals(""))
            {
                try
                {
                    string name = this.nameUpd.Text;
                    int number = Convert.ToInt32(this.numUpd.Text);
                    int id = Convert.ToInt32(this.idUpd.Text);
                    if (this.client.UpdDict(id, name, number) == "OK")
                        MessageBox.Show("Success update");
                    else
                        MessageBox.Show("Error during update");
                }
                catch
                {
                    MessageBox.Show("Enter number in fields number and id");
                }
            }
            else
            {
                MessageBox.Show("Enter values in field id, name and number");
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(this.id.Text);
                if (this.client.DelDict(id) == "OK")
                    MessageBox.Show("Success delete");
                else
                    MessageBox.Show("Error during delet");
            }
            catch
            {
                MessageBox.Show("Enter correct value in field id");
            }
        }
    }
}
