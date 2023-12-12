<%@ Page Language="C#" AutoEventWireup="true" CodeFile="comment_edit.aspx.cs" Inherits="admin_comment_edit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            名称<asp:TextBox ID="Price" runat="server"></asp:TextBox>
                    <asp:Button ID="procedure" runat="server" Text="搜索" 
onclick="procedure_Click" />
        </div>
        <div>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
    AllowPaging="True" AllowSorting="True" PageSize="2" OnRowDeleting="GridView1_RowDeleting"
    onpageindexchanging="GridView1_PageIndexChanging" 
    onselectedindexchanged="GridView1_SelectedIndexChanged" style="margin-top: 0px" DataKeyNames="id" CellPadding="4" ForeColor="#333333" GridLines="None">
                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
    <Columns>
        <asp:BoundField DataField="id" HeaderText="书籍编号" Visible="False"  />
        <asp:BoundField DataField="bookname" HeaderText="书籍名称" />
        <asp:BoundField DataField="username" HeaderText="用户名称" />
        <asp:BoundField DataField="comment" HeaderText="评论" />
        <asp:CommandField ShowDeleteButton="True" />
    </Columns>
                <EditRowStyle BackColor="#999999" />
                <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#E9E7E2" />
                <SortedAscendingHeaderStyle BackColor="#506C8C" />
                <SortedDescendingCellStyle BackColor="#FFFDF8" />
                <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
</asp:GridView>
        </div>
    </form>
</body>
</html>
