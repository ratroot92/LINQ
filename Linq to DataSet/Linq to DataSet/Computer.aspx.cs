using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.EnterpriseServices;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Linq_to_DataSet
{
    public partial class Computer : System.Web.UI.Page
    {
        private DataTable dt;
        private SqlDataAdapter da;
        private SqlConnection conn;
        protected void Page_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(@"Data Source=DESKTOP-8S20ENO; Initial Catalog=Halwa System; Integrated Security=True");
            conn.Open();
            da = new SqlDataAdapter("Select * from Computer", conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            conn.Close();
            dt = ds.Tables[0];
            GridView1.DataSource = dt;
            GridView1.DataBind();

        }

        protected void btn_save_Click(object sender, EventArgs e)
        {
            DataRow dr = dt.NewRow();
            dr["Compnay"] = txt_comp.Text;
            dr["Processor"] = txt_pros.Text;
            dr["RAM"] = txt_ram.Text;
            dr["Operating Sys"] = txt_os.Text;
            dr["Motherboard"] = txt_mobo.Text;
            dr["GPU"] = txt_gpu.Text;
            dr["Storage"] = txt_store.Text;
            dt.Rows.Add(dr);
            conn.Open();
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            da.UpdateCommand = builder.GetUpdateCommand();
            da.Update(dt);
            conn.Close();
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }

        protected void btn_update_Click(object sender, EventArgs e)
        {
            DataRow drComp = dt.AsEnumerable().SingleOrDefault(x => x.Field<int>("Serial No") == Convert.ToInt32(txt_srno.Text));
            drComp["Compnay"] = txt_comp.Text;
            drComp["Processor"] = txt_pros.Text;
            drComp["RAM"] = txt_ram.Text;
            drComp["Operating Sys"] = txt_os.Text;
            drComp["Motherboard"] = txt_mobo.Text;
            drComp["GPU"] = txt_gpu.Text;
            drComp["Storage"] = txt_store.Text;
            conn.Open();
            SqlCommandBuilder build = new SqlCommandBuilder(da);
            da.UpdateCommand = build.GetUpdateCommand();
            da.Update(dt);
            conn.Close();
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }

        protected void btn_del_Click(object sender, EventArgs e)
        {
            DataRow drComp = dt.AsEnumerable().SingleOrDefault(x => x.Field<int>("Serial No") == Convert.ToInt32(txt_srno.Text));
            drComp.Delete();
            conn.Open();
            SqlCommandBuilder build = new SqlCommandBuilder(da);
            da.UpdateCommand = build.GetUpdateCommand();
            da.Update(dt);
            conn.Close();
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }

        protected void btn_srch_Click(object sender, EventArgs e)
        {
            var comp = from c in dt.AsEnumerable() where c.Field<int>("Serial No") == Convert.ToInt32(txt_srno.Text) select c;
            DataTable dtComp = comp.CopyToDataTable();
            GridView1.DataSource = dtComp;
            GridView1.DataBind();
            txt_srno.Text = dtComp.Rows[0]["Serial No"].ToString();
            txt_comp.Text = dtComp.Rows[0]["Compnay"].ToString();
            txt_pros.Text = dtComp.Rows[0]["Processor"].ToString();
            txt_ram.Text = dtComp.Rows[0]["RAM"].ToString();
            txt_os.Text = dtComp.Rows[0]["Operating Sys"].ToString();
            txt_mobo.Text = dtComp.Rows[0]["Motherboard"].ToString();
            txt_gpu.Text = dtComp.Rows[0]["GPU"].ToString();
            txt_store.Text = dtComp.Rows[0]["Storage"].ToString();
        }

        protected void btn_rset_Click(object sender, EventArgs e)
        {
            txt_srno.Text = "";
            txt_comp.Text = "";
            txt_pros.Text = "";
            txt_ram.Text = "";
            txt_os.Text = "";
            txt_mobo.Text = "";
            txt_gpu.Text = "";
            txt_store.Text = "";
        }
    }
}