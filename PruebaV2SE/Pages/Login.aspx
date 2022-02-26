<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="PruebaV2SE.Pages.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <div class="row">
            <div class="mb-3">
                <label for="txtUser" class="form-label">* User</label>
                <input type="text" class="form-control" id="txtUser" runat="server" />
            </div>
            <div class="mb-3">
                <label for="txtPw" class="form-label">* Password</label>
                <input type="password" class="form-control" runat="server" id="txtPw" />
            </div>
            <div class="pull-right">
                <asp:Button ID="btnConsult" CssClass="btn btn-finish btn-fill btn-green btn-wd" runat="server" OnClick="btnConsult_Click" Style="height: 30px; width: 100px; font-size: 12px; display: inline-block;" Text="Consult" />
            </div>
        </div>
        <div class="row" visible="false" style="color: red">
            <asp:Label Text="" Visible="false" ID="lblConsult" runat="server" />
        </div>
    </div>
</asp:Content>
