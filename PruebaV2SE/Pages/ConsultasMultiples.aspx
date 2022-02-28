<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ConsultasMultiples.aspx.cs" Inherits="PruebaV2SE.Pages.ConsultasMultiples" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="contenedor-full">
        <div class="row">
            <div class="col-sm-6">
                <label>Tipo de consulta</label>
                <asp:DropDownList ID="ddlTipoConsulta" aria-label="Default select example" CssClass="form-select" Style="width: 50%" runat="server">
                    <asp:ListItem Value="1">Autores</asp:ListItem>
                    <asp:ListItem Value="2">Libros</asp:ListItem>
                </asp:DropDownList>
            </div>
        </div>
        <br />
        <div class="row">
            <div class="col-sm-6">
                <div id="dvAutor" runat="server">
                    <label>Nombres (Separar por comas)</label>
                    <asp:TextBox CssClass="form-control" ID="txtNombre" runat="server"></asp:TextBox>
                </div>
                <br />
            </div>
        </div>
        <div class="row">
            <div class="col">
                <div class="pull-left">
                    <div class="row" visible="false" style="color: red">
                        <asp:Label Text="" Visible="false" ID="lblConsult" runat="server" />
                    </div>
                    <br />
                    <div class="btn-group" role="group" aria-label="Basic outlined example">
                        <asp:Button ID="btnHome" CssClass="btn btn-outline-primary" runat="server" OnClick="btnHome_Click" Style="height: 30px; width: 100px; font-size: 12px; display: inline-block;" Text="Home" />
                        <asp:Button ID="btnConsultar" CssClass="btn btn-outline-primary" runat="server" OnClick="btnConsultar_Click" Style="height: 30px; width: 100px; font-size: 12px; display: inline-block;" Text="Consultar" />
                    </div>
                </div>
            </div>
        </div>
    </div>
    <br />
    <div class="row">
        <div>
            <asp:UpdatePanel runat="server">
                <ContentTemplate>
                    <asp:GridView ID="gvwLibro" runat="server" CssClass="table table-dark table-hover" AllowPaging="True" AutoGenerateColumns="false" OnPageIndexChanging="gvwLibro_PageIndexChanging">
                        <Columns>
                            <asp:BoundField DataField="title" HeaderText="Title" SortExpression="title" />
                            <asp:BoundField DataField="publishDate" HeaderText="PublishDate" SortExpression="publishDate" HeaderStyle-Wrap="true" />
                            <asp:BoundField DataField="pageCount" HeaderText="PageCount" SortExpression="pageCount" HeaderStyle-Wrap="true" />
                            <asp:BoundField DataField="excerpt" HeaderText="Excerpt" SortExpression="excerpt" />
                            <asp:BoundField DataField="Author" HeaderText="Author" SortExpression="Author" />
                            <asp:BoundField DataField="description" HeaderText="Description" SortExpression="description" />
                        </Columns>
                    </asp:GridView>
                </ContentTemplate>
            </asp:UpdatePanel>
        </div>
    </div>
</asp:Content>
