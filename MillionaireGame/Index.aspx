<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="MillionaireGame.Index" %>

<%@ Register Src="~/Controls/Player/ProgressBar.ascx" TagPrefix="uc1" TagName="ProgressBar" %>


<asp:Content ID="Content1" ContentPlaceHolderID="titleContent" runat="server">
    О, Щасливчик!
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="headContent" runat="server">
    <link href="App_Themes/Index/index.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="bodyContent" runat="server">
    <div class="helpers">
                <asp:ImageButton ID="help_50_50" src="images/help_50_50.png" title="50/50" runat="server" CssClass="help"/>
                <asp:ImageButton ID="help_room" src="images/help_room.png" title="допомога залу" runat="server" CssClass="help"/>
                <asp:ImageButton ID="help_call" src="images/help_call.png" title="дзвінок другу" runat="server" CssClass="help"/>
    </div>
    <div class="picture">
            <img id="tv_logo" src="images/tv_logo.jpg">
            </div>
            <uc1:ProgressBar runat="server" id="ProgressBar" />
            <div class="question">
                <img class="question" src="images/question.gif" runat="server"/>
                <asp:Label ID="lblQuestion" CssClass="textQuestion" runat="server">questionText</asp:Label>
            </div>
            <div id="topAnswers">
                <img src="images/ans_line.gif"/>
                <div id="A">
                    <asp:ImageButton ID="imageButtonA" CssClass="imageButtonA" src="images/answer.jpg" runat="server"></asp:ImageButton>
                    <span class="titleAnswerLeft" id="titleAnswerA">A:</span>
                    <asp:Label ID="lblAnswerA" CssClass="lblAnswerLeft" runat="server">someAnswerTextA</asp:Label>
                </div>
                <div id="B">
                    <asp:ImageButton ID="imageButtonB" CssClass="imageButtonB" src="images/answer.jpg" runat="server"></asp:ImageButton>
                    <span class="titleAnswerRight" id="titleAnswerB">B:</span>
                    <asp:Label ID="lblAnswerB" CssClass="lblAnswerRight" runat="server">someAnswerTextB</asp:Label>
                </div>
            </div>
            <div id="bottomAnswers">
                <img src="images/ans_line.gif"/>
                <div id="C">
                    <asp:ImageButton ID="imageButtonC" CssClass="imageButtonC" src="images/answer.jpg" runat="server"></asp:ImageButton>
                    <span class="titleAnswerLeft" id="titleAnswerC">C:</span>
                    <asp:Label ID="lblAnswerC" CssClass="lblAnswerLeft" runat="server">someAnswerTextC</asp:Label>
                </div>
                <div id="D">
                    <asp:ImageButton ID="imageButtonD" CssClass="imageButtonD" src="images/answer.jpg" runat="server"></asp:ImageButton>
                    <span class="titleAnswerRight" id="titleAnswerD">D:</span>
                    <asp:Label ID="lblAnswerD" CssClass="lblAnswerRight" runat="server">someAnswerTextD</asp:Label>
                </div>
            </div>        
</asp:Content>
