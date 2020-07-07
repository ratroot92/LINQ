using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Customer1 : System.Web.UI.Page
    {
        public List<Customer> GetCustomersData()
        {
            return new List<Customer>
            {
                new Customer
                {
                    CustID = "001",
                    CustName = "Kamran",
                    CustAddress = "Karachi",
                    CustPhone = "0331"
                },
                new Customer
                {
                    CustID = "002",
                    CustName="Hassan",
                    CustAddress = "Faisalabad",
                    CustPhone= "0335"
                },
                new Customer
                {
                    CustID = txt_id.Text,
                    CustName = txt_name.Text,
                    CustAddress = txt_adres.Text,
                    CustPhone  = txt_phone.Text
                }

            };
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            var customer = GetCustomersData();
            this.GridView1.DataSource = customer;
            this.GridView1.DataBind();
        }

        protected void btn_save_Click(object sender, EventArgs e)
        {
            Customer cust = new Customer()
            {
                CustID = txt_id.Text,
                CustName = txt_name.Text,
                CustAddress = txt_adres.Text,
                CustPhone = txt_phone.Text
            };
            var obj = GetCustomersData();
            obj.Add(cust);
            this.GridView1.DataSource = obj;
            this.GridView1.DataBind();
        }

        protected void btn_update_Click(object sender, EventArgs e)
        {
            var obj = GetCustomersData();
            var NewObj = obj.SingleOrDefault(x => x.CustID == txt_id.Text);
            NewObj.CustName = txt_name.Text;
            NewObj.CustAddress = txt_adres.Text;
            NewObj.CustPhone = txt_phone.Text;
            this.GridView1.DataSource = obj;
            this.GridView1.DataBind();
        }

        protected void btn_del_Click(object sender, EventArgs e)
        {
            var obj = GetCustomersData();
            var NewObj = obj.SingleOrDefault(x => x.CustID == txt_id.Text);
            obj.Remove(NewObj);
            this.GridView1.DataSource = obj;
            this.GridView1.DataBind();
        }

        protected void btn_reset_Click(object sender, EventArgs e)
        {
            txt_id.Text = "";
            txt_name.Text = "";
            txt_adres.Text = "";
            txt_phone.Text = "";
        }

        //protected void btn_byID_Click(object sender, EventArgs e)
        //{
        //    var obj = GetCustomersData();
        //    var NewObj = obj.SingleOrDefault(x => x.CustID == txt_id.Text);
        //    txt_name.Text = NewObj.CustName;
        //    txt_adres.Text = NewObj.CustAddress;
        //    txt_phone.Text = NewObj.CustPhone;
        //    this.GridView1.DataSource = obj;
        //    this.GridView1.DataBind();
        //}
    }
}