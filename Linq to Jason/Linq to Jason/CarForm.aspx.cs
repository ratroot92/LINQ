using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Linq_to_Jason
{
    public partial class CarForm : System.Web.UI.Page
    {
        List<Dictionary<string, object>> rows;
        System.Web.Script.Serialization.JavaScriptSerializer serializer = new System.Web.Script.Serialization.JavaScriptSerializer();
        protected void Page_Load(object sender, EventArgs e)
        {
            StreamReader reader = new StreamReader(Server.MapPath("Car.json"));
            string json = reader.ReadToEnd();
            rows = serializer.Deserialize<List<Dictionary<string, object>>>(json);
            reader.Close();
            if(!IsPostBack)
            {
                txt_main.Text = serializer.Serialize(rows);
            }
        }

        protected void btn_save_Click(object sender, EventArgs e)
        {
            Dictionary<string, object> row = new Dictionary<string, object>();
            row.Add("Car_Reg", txt_rno.Text);
            row.Add("Car_Name",txt_name.Text);
            row.Add("Car_eng",txt_eng.Text);
            row.Add("Car_Chasis",txt_chasis.Text);
            row.Add("Car_Owner",txt_owner.Text);
            row.Add("Car_Comp",txt_comp.Text);
            row.Add("Car_SCenter", txt_sale.Text);
            rows.Add(row);
            txt_main.Text = serializer.Serialize(rows);
        }

        protected void btn_update_Click(object sender, EventArgs e)
        {
            Dictionary<string, object> row = new Dictionary<string, object>();
            row.Add("Car_Reg", txt_rno.Text);

            row = rows.SingleOrDefault(x => row.All(x.Contains));
            row["Car_Name"]= txt_name.Text;
            row["Car_eng"]= txt_eng.Text;
            row["Car_Chasis"]= txt_chasis.Text;
            row["Car_Owner"]= txt_owner.Text;
            row["Car_Comp"]= txt_comp.Text;
            row["Car_SCenter"]= txt_sale.Text;
            txt_main.Text = serializer.Serialize(rows);
        }

        protected void btn_srch_Click(object sender, EventArgs e)
        {
            Dictionary<string, object> row = new Dictionary<string, object>();
            row.Add("Car_Reg", txt_rno.Text);

            row = rows.SingleOrDefault(x => row.All(x.Contains));
            txt_name.Text = row["Car_Name"].ToString();
            txt_chasis.Text = row["Car_eng"].ToString();
            txt_owner.Text = row["Car_Chasis"].ToString();
            txt_comp.Text = row["Car_Comp"].ToString();
            txt_sale.Text = row["Car_SCenter"].ToString();
        }

        protected void btn_file_Click(object sender, EventArgs e)
        {
            System.IO.StreamWriter carFile = new System.IO.StreamWriter(Server.MapPath("Car.json"));
            if(!txt_main.Text.Equals(""))
            {
                carFile.WriteLine(txt_main.Text);
            }
            carFile.Close();
        }

        protected void btn_del_Click(object sender, EventArgs e)
        {
            Dictionary<string, object> row = new Dictionary<string, object>();
            row.Add("Car_Reg", txt_rno.Text);

            row = rows.SingleOrDefault(x => row.All(x.Contains));
            rows.Remove(row);
            txt_main.Text = serializer.Serialize(rows);
        }

        protected void btn_reset_Click(object sender, EventArgs e)
        {
            txt_rno.Text = "";
            txt_name.Text = "";
            txt_eng.Text = "";
            txt_chasis.Text = "";
            txt_comp.Text = "";
            txt_sale.Text = "";
        }
    }
}