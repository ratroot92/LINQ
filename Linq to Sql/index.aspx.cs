using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Linq_to_Sql
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        private void reteriveDetails()
        {
            HalwaDbDataContext dtcontext = new HalwaDbDataContext();
            GridView1.DataSource = dtcontext.Employees;
            GridView1.DataBind();
        }

        protected void btn_save_Click(object sender, EventArgs e)
        {
            using (HalwaDbDataContext dtcontext = new HalwaDbDataContext())
            {
                Employee emp = new Employee
                {
                    Name = txt_name.Text,
                    City = txt_city.Text,
                    Designation = txt_desg.Text,
                    Phone = txt_phone.Text
                };
                dtcontext.Employees.InsertOnSubmit(emp);
                dtcontext.SubmitChanges();
            }
            reteriveDetails();
        }

        protected void btn_update_Click(object sender, EventArgs e)
        {
            using (HalwaDbDataContext dtcontext = new HalwaDbDataContext())
            {
                Employee emp = dtcontext.Employees.SingleOrDefault(x => x.EmpID == Convert.ToInt32(txt_id.Text));
                emp.Name = txt_name.Text;
                emp.City = txt_city.Text;
                emp.Designation = txt_desg.Text;
                emp.Phone = txt_phone.Text;
                dtcontext.SubmitChanges();
            }
            reteriveDetails();
        }

        protected void btn_del_Click(object sender, EventArgs e)
        {
            using (HalwaDbDataContext dtcontext = new HalwaDbDataContext())
            {
                Employee emp = dtcontext.Employees.SingleOrDefault(x => x.EmpID == Convert.ToInt32(txt_id.Text));
                dtcontext.Employees.DeleteOnSubmit(emp);
                dtcontext.SubmitChanges();
            }
        }

        protected void btn_srch_Click(object sender, EventArgs e)
        {
            HalwaDbDataContext dtcontext = new HalwaDbDataContext();
            Employee emp = dtcontext.Employees.SingleOrDefault(x => x.EmpID == Convert.ToInt32(txt_id.Text));
            txt_name.Text = emp.Name;
            txt_city.Text = emp.City;
            txt_desg.Text = emp.Designation;
            txt_phone.Text = emp.Phone;
        }

        protected void btn_all_Click(object sender, EventArgs e)
        {
            reteriveDetails();
        }

        protected void txt_reset_Click(object sender, EventArgs e)
        {
            txt_id.Text = "";
            txt_name.Text = "";
            txt_city.Text = "";
            txt_desg.Text = "";
            txt_phone.Text = "";
        }
    }
}