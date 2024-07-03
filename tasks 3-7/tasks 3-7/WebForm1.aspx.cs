using System;
using System.Web.UI;

namespace WebApplication2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string name = TextBox1.Text;
            string email = TextBox2.Text;
            string id = TextBox3.Text;
            string gender = RadioButton1.Checked ? "Female" : (RadioButton2.Checked ? "Male" : string.Empty);
            string courses = string.Empty;
            if (CheckBox1.Checked)
            {
                courses += "C ";
            }
            if (CheckBox2.Checked)
            {
                courses += "C++ ";
            }
            if (CheckBox3.Checked)
            {
                courses += "C# ";
            }
            Label2.Text = name;
            Label7.Text = email;
            Label9.Text = id;
            Label12.Text = gender;
            Label15.Text = courses;
        }
    }
}
