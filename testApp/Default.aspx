<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">

        <div class="form-inline">
            <div class="form-group">
                <asp:TextBox ID="txtSearch"
                    runat="server"
                    placeholder="Enter search here..."
                    CssClass="form-control"></asp:TextBox>
            </div>
            <asp:Button ID="btnSearch"
                runat="server"
                Text="Search"
                CssClass="btn btn-primary"
                OnClick="btnSearch_Click" />
        </div>
        <br />

        <asp:GridView ID="gvSample"
            CssClass="table table-responsive"
            ShowHeaderWhenEmpty="true"
            AllowPaging="true"
            AllowSorting="true"
            EmptyDataText="No Record(s) found"
            AutoGenerateColumns="false"
            OnSorting="gvSample_Sorting"
            runat="server">
            <SortedAscendingHeaderStyle CssClass="sortasc" />
            <SortedDescendingHeaderStyle CssClass="sortdesc" />
            <Columns>
                <asp:BoundField DataField="FirstName" HeaderText="First Name" SortExpression="FirstName"/>
                <asp:BoundField DataField="MiddleName" HeaderText="Middle Name" SortExpression="MiddleName" />
                <asp:BoundField DataField="LastName" HeaderText="Last Name" SortExpression="LastName" />
            </Columns>
        </asp:GridView>

        <asp:LinqDataSource ID="EmployeeDataSource" runat="server" OnSelecting="EmployeeDataSource_Selecting"></asp:LinqDataSource>
    </div>
</asp:Content>
