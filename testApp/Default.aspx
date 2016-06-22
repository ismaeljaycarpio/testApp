<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">

        <div class="form-inline">
            <div class="form-group">
                <asp:TextBox ID="txtSearch" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <asp:Button ID="btnSearch"
                runat="server"
                Text="Search"
                CssClass="btn btn-default"
                OnClick="btnSearch_Click" />
        </div>

        <asp:GridView ID="gvSample"
            CssClass="table table-responsive"
            ShowHeaderWhenEmpty="true"
            EmptyDataText="No Record(s) found"
            runat="server">
        </asp:GridView>
    </div>
</asp:Content>
