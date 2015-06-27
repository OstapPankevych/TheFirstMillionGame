<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" Theme="GameResults" CodeBehind="GameResult.aspx.cs" Inherits="MillionaireGame.GameResult" %>
<asp:Content ID="Content1" ContentPlaceHolderID="titleContent" runat="server">
    Результати
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="headContent" runat="server">
    <link href="App_Themes/GameResults/gameResults.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="bodyContent" runat="server">
    <span id="result">
        <% Response.Write((string) Session["userName"]); %> , дякуємо за гру! <br/> <br/>
        Ваш виграш становить: <% Response.Write(Session["money"].ToString());%>  $
    </span>
</asp:Content>
