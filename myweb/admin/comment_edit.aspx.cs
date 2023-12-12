using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using YF.MsSqlHelper;
using YF;

public partial class admin_comment_edit : System.Web.UI.Page

{
    string connStr = "initial catalog=xiaobai; data source=localhost; integrated security=sspi";
    protected void Page_Load(object sender, EventArgs e)
    {
        gridviewbind();

    }
    private void gridviewbind()
    {
        SqlConnection myConn = new SqlConnection(connStr);
        SqlDataAdapter myDa = new SqlDataAdapter("select * from t_comment where delFlag=0", myConn);
        myConn.Open();
        DataSet myDataSet = new DataSet();
        myDa.Fill(myDataSet);
        GridView1.DataSource = myDataSet.Tables[0];
        GridView1.DataBind();
        myConn.Close();
    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        //Response.Redirect(Request.Url.ToString());
        GridView1.PageIndex = e.NewPageIndex;
        gridviewbind();

    }
    protected void procedure_Click(object sender, EventArgs e)
    {
        string s = Price.Text;
        string sql = "select * from t_comment where bookname like '%" + s + "%' and delFLag=0 ";
        SqlConnection myConn = new SqlConnection(connStr);
        SqlDataAdapter myDa = new SqlDataAdapter(sql, myConn);
        myConn.Open();
        DataSet myDataSet = new DataSet();
        myDa.Fill(myDataSet);
        GridView1.DataSource = myDataSet.Tables[0];
        GridView1.DataBind();
        myConn.Close();

    }


    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        string sqlstr1 = "update  t_comment set delFlag=1 where id='" + GridView1.DataKeys[e.RowIndex].Value.ToString() + "'";

        if (YFMsSqlHelper.ExecuteSql(sqlstr1)>=1)

        {

            JsHelper.AlertAndRedirect("删除成功","comment_edit.aspx");

            gridviewbind();

        }

        else

        {

            JsHelper.Alert("Fail");

        }

    }
}