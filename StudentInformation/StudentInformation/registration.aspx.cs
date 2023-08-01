using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StudentInformation
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        DataAccess da = new DataAccess();
        public String program = "";
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            this.program = "OUG";
        }

        protected void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            this.program = "Grad";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var sql = @"INSERT INTO [dbo].[studentinfo] ([ID],[Name],[Dept],[Dob],[Program]) VALUES ('" + int.Parse(this.txtId.Text) + "','" + this.txtName.Text + "','" + this.DropDownList1.Text + "','" + this.txtbod.Text + "','" + this.program + "')";
            var ds = da.ExecuteUpdateQuery(sql);
            Response.Write("Successfully added the user");


        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var id = GridView1.SelectedRow.Cells[1].Text;
            var query = "select *from studentinfo where ID='" + id + "'";
            DataSet ds = this.da.ExecuteQuery(query);
            this.txtId.Text = ds.Tables[0].Rows[0][0].ToString();
            this.txtName.Text = ds.Tables[0].Rows[0][1].ToString();
            this.DropDownList1.Text = ds.Tables[0].Rows[0][2].ToString();
            this.txtbod.Text = ds.Tables[0].Rows[0][3].ToString();
            this.program = ds.Tables[0].Rows[0][4].ToString();

        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            var sql = "select *from studentinfo";
            DataSet ds = this.da.ExecuteQuery(sql);
            GridView1.DataSource = ds.Tables[0];
            GridView1.DataBind();
        }

        protected void dptsrch_Click(object sender, EventArgs e)
        {
            var sql = "select * from studentinfo where Dept='"+ DropDownList2.SelectedValue+ "'";
            DataSet ds = this.da.ExecuteQuery(sql);
            GridView1.DataSource = ds.Tables[0];
            GridView1.DataBind();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            var sql = "delete  from studentinfo where ID='" +this.txtremove.Text+ "'";
            var ds = da.ExecuteUpdateQuery(sql);
            Response.Write("Successfully Remove the user");

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            var sql = @"UPDATE studentinfo SET Name='" + txtName.Text + "', Dept='" + this.DropDownList1.Text + "', Dob='" + txtbod.Text + "', Program='" + this.program + "' WHERE ID='"+int.Parse(txtId.Text)+"' ";

            var ds = da.ExecuteUpdateQuery(sql);
            Response.Write("Successfully Updater the user");


            var sql1 = "select *from studentinfo";
            DataSet ds1 = this.da.ExecuteQuery(sql1);
            GridView1.DataSource = ds1.Tables[0];
            GridView1.DataBind();

        }
    }
}