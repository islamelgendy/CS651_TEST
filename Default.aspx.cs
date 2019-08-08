using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS651_TEST
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                inputTextBox.Visible = false;
                Label1.Visible = false;
                outputListBox.Visible = true;
                submitButton.Visible = false;
                Label2.Visible = true;
                Label3.Visible = true;
                rangeTextBox.Visible = true;
                int num = Int32.Parse(inputTextBox.Text);
                generateNums(num);
            }
        }
        private void generateNums(int num)
        {
            int[] arr = new int[num];
            Random number = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = number.Next(1, 100);
                outputListBox.Items.Add(arr[i].ToString());
            }
            int min = arr[0];
            int max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            rangeTextBox.Text = min + " - " + max;
        }

    }
}