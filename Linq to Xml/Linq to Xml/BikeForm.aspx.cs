using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.Xml.Linq;

namespace Linq_to_Xml
{
    public partial class BikeForm : System.Web.UI.Page
    {
        XDocument xDoc;
        protected void Page_Load(object sender, EventArgs e)
        {
            xDoc = XDocument.Load(Server.MapPath("Bike.xml"));
            //LoadGridView();
        }
        private void LoadGridView()
        {
            DataSet ds = new DataSet();
            ds.ReadXml(Server.MapPath("Bike.xml"));
            if(ds.Tables.Count>0)
            {
                GridView1.DataSource = ds;
                GridView1.DataBind();
            }
        }

        protected void txt_save_Click(object sender, EventArgs e)
        {
            xDoc.Element("Bikes").Add(new XElement("Bike",
                new XAttribute("Reg_No", txt_regno.Text),
                new XAttribute("Name", txt_name.Text),
                new XAttribute("Eng_No", txt_eng.Text),
                new XAttribute("Chasis", txt_chasis.Text),
                new XAttribute("Owner", txt_owner.Text),
                new XAttribute("Company", txt_comp.Text),
                new XAttribute("SCenter", txt_scenter.Text)));
            xDoc.Save(Server.MapPath("Bike.xml"));
            LoadGridView();
        }

        protected void btn_srch_Click(object sender, EventArgs e)
        {
            XElement bk = xDoc.Descendants("Bike").SingleOrDefault(x => x.Attribute("Reg_No").Value == txt_regno.Text);
            txt_name.Text = bk.Element("Name").Value;
            txt_eng.Text = bk.Element("Eng_No").Value;
            txt_chasis.Text = bk.Element("Chasis").Value;
            txt_owner.Text = bk.Element("Owner").Value;
            txt_comp.Text = bk.Element("Company").Value;
            txt_scenter.Text = bk.Element("SCenter").Value;
        }

        protected void btn_del_Click(object sender, EventArgs e)
        {
            XElement bk = xDoc.Descendants("Bike").SingleOrDefault(x => x.Attribute("Reg_No").Value==txt_regno.Text);
            bk.Remove();
            xDoc.Save(Server.MapPath("Bike.xml"));
            LoadGridView();
        }

        protected void btn_update_Click(object sender, EventArgs e)
        {
            XElement bk = xDoc.Descendants("Bike").SingleOrDefault(x => x.Attribute("Reg_No").Value == txt_regno.Text);
            bk.Element("Name").Value = txt_name.Text;
            bk.Element("Eng_No").Value = txt_eng.Text;
            bk.Element("Chasis").Value = txt_chasis.Text;
            bk.Element("Owner").Value = txt_owner.Text;
            bk.Element("Company").Value = txt_comp.Text;
            bk.Element("SCenter").Value = txt_scenter.Text;
            xDoc.Save(Server.MapPath("Bike.xml"));
            LoadGridView();
        }

        protected void btn_all_Click(object sender, EventArgs e)
        {
            LoadGridView();
        }

        protected void btn_reset_Click(object sender, EventArgs e)
        {
            txt_regno.Text = "";
            txt_name.Text = "";
            txt_eng.Text = "";
            txt_chasis.Text = "";
            txt_owner.Text = "";
            txt_comp.Text = "";
            txt_scenter.Text = "";
        }
    }
}