<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="PruebaV2SE.Pages.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container-fluid">
        <div class="contenedor-middle">
            <span><i class="fa fa-user-circle" style="font-size: 100px; margin-left: 15%; margin-bottom: 10%;" aria-hidden="true"></i></span>

            <div class="col-sm-12">
                <div class="col-sm-6">
                    <div class="input-group mb-3">
                        <span class="input-group-text" id="basic-addon1"><i class="fa fa-user" aria-hidden="true"></i></span>
                        <input type="text" class="form-control" id="txtUser" placeholder="Username" aria-label="Username" aria-describedby="basic-addon1" runat="server">
                    </div>
                </div>
                <div class="col-sm-6">
                    <div class="input-group mb-3">
                        <span class="input-group-text" id="basic-addon2"><i class="fa fa-key" aria-hidden="true"></i></span>
                        <input type="password" class="form-control" id="txtPw" placeholder="Username" aria-label="Username" aria-describedby="basic-addon1" runat="server">
                    </div>
                </div>
            </div>
            <div class="row" visible="false" style="color: red">
                <asp:Label Text="" Visible="false" ID="lblConsult" runat="server" />
            </div>
            <div class="">
                <asp:Button ID="btnConsult" CssClass="btn btn-success" runat="server" OnClick="btnConsult_Click" Style="height: 50%; width: 50%; font-size: 12px; display: inline-block;" Text="Login" /><br />
                <asp:Button ID="btnDatos" CssClass="btn btn-primary" runat="server" OnClick="btnDatos_Click" Style="height: 50%; width: 50%; font-size: 12px; display: inline-block;" Text="Obtener Datos" />
            </div>
        </div>
    </div>

    <script>    
    </script>

</asp:Content>