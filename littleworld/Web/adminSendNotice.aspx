<%@ Page Title="" Language="C#" MasterPageFile="~/adminMaster.Master" AutoEventWireup="true" CodeBehind="adminSendNotice.aspx.cs" Inherits="littleworld.Web.adminSendNotice" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <style type="text/css">
    .style3
    {
        width: 495px;
    }
        .style6
        {
            height: 55px;
        }
        .style7
        {
            height: 55px;
        }
        .style8
        {
            width: 495px;
            height: 77px;
        }
        .style9
        {
            height: 77px;
        }
    </style>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <table style="width: 100%; height: 282px;" border="1px" bordercolor="#CCFF99">
    <tr>
        <td class="style6" colspan="2">
            <asp:Label ID="fstz" runat="server" Font-Size="XX-Large" Text="发送通知:" 
                Font-Bold="True"></asp:Label>
        </td>
    </tr>
    <tr>
        <td class="style8">
            <asp:Label ID="Label2" runat="server" Font-Size="Medium" Text="标题:"></asp:Label>
            <asp:TextBox ID="txttitle" runat="server" Height="25px" Width="151px" 
                Visible="False"></asp:TextBox>
            <br />
            <asp:Label ID="Label3" runat="server" Font-Size="Medium" Text="内容:"></asp:Label>
            <asp:TextBox ID="bjtztxt" runat="server" Height="25px" Visible="False" 
                Width="441px"></asp:TextBox>
        </td>
        <td class="style9">
            <asp:Button ID="bjtzbtn" runat="server" Height="33px" onclick="bjtzbtn_Click" 
                Text="编辑通知" Width="97px" />
        </td>
    </tr>
    <tr>
        <td class="style3">
            <asp:Label ID="Label1" runat="server" Font-Size="Large" Text="选择单个用户："></asp:Label>
            <asp:DropDownList ID="DropDownListusers" runat="server" 
                DataSourceID="SqlDataSource1" DataTextField="userID" 
                DataValueField="userID" Height="30px" Width="171px">
            </asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                ConnectionString="<%$ ConnectionStrings:RP_littleworldConnectionString %>" 
                SelectCommand="SELECT [userID] FROM [userTb]"></asp:SqlDataSource>
        </td>
        <td>
        <asp:Label ID="successlbl" runat="server" Font-Size="Large" Text="单个发送成功!" 
            Visible="False" ForeColor="Red"></asp:Label>
            <asp:Label ID="lblqf" runat="server" Font-Bold="False" Font-Size="Large" 
                ForeColor="Red" Text="群发成功!" Visible="False"></asp:Label>
        </td>
    </tr>
    <tr><td >
            <asp:Button ID="btnsuresingle" runat="server" Height="33px" Text="确定发送(单个)" 
                Width="101px" onclick="btnsure_Click" />
        </td>
        <td>
            <asp:Button ID="btnsureall" runat="server" Height="27px" Text="确定发送(群发)" 
                Width="101px" onclick="btnsureall_Click" />
        </td>
        </tr>
</table>

</asp:Content>
