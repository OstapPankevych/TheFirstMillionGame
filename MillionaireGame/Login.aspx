<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" Theme="Index" CodeBehind="Login.aspx.cs" Inherits="MillionaireGame.Login" %>



<asp:Content ID="Content1" ContentPlaceHolderID="titleContent" runat="server">
    Login
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="headContent" runat="server">
    <link href="App_Themes/Login/login.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="bodyContent" runat="server">
    <span id="helloText"> О, Щасливчик! </span>
    <div id="login">
        <asp:TextBox ID="tbName" CssClass="tbName" runat="server">
            введіть сюди своє ім'я
        </asp:TextBox>
                <asp:RegularExpressionValidator ID="revUserName" runat="server"
                    ErrorMessage="Length should not exceed 12"  ControlToValidate="tbName"
                    ValidationExpression="^[0-9a-zA-Zа-яА-Яі]{1,12}$"
                    ForeColor="Red" Display="Dynamic" />

        <asp:Button ID="btnLogin" CssClass="btnLogin" runat="server" Text="увійти" />
    </div>
    <span id="errorMessage"> </span>
</asp:Content>
