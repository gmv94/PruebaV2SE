<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Consultas.aspx.cs" Inherits="PruebaV2SE.Pages.Consultas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="contenedor-full">
        <div class="row">
            <div class="col-sm-6">
                <asp:UpdatePanel runat="server">
                    <ContentTemplate>
                        <label>Tipo de consulta</label>
                        <asp:DropDownList ID="ddlTipoConsulta" AutoPostBack="true" aria-label="Default select example" CssClass="form-select" OnSelectedIndexChanged="ddlTipoConsulta_SelectedIndexChanged" Style="width: 50%" runat="server">
                            <asp:ListItem Value="1">Autor</asp:ListItem>
                            <asp:ListItem Value="2">Libro</asp:ListItem>
                        </asp:DropDownList>
                    </ContentTemplate>
                </asp:UpdatePanel>
            </div>
        </div>
        <br />
        <div class="row">
            <div class="col-sm-6">
                <asp:UpdatePanel runat="server">
                    <ContentTemplate>
                        <div id="dvAutor" runat="server">
                            <label>Nombre Autor</label>
                            <asp:TextBox CssClass="form-control" ID="txtNombre" runat="server"></asp:TextBox>
                            <label>Apellido Autor</label>
                            <asp:TextBox CssClass="form-control" ID="txtApellido" runat="server"></asp:TextBox>
                        </div>
                        <div id="dvLibro" runat="server" visible="false">
                            <label>Nombre Libro</label>
                            <asp:TextBox CssClass="form-control" ID="txtLibro" runat="server"></asp:TextBox>
                        </div>
                        <br />
                    </ContentTemplate>
                </asp:UpdatePanel> 
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
                        <asp:Button ID="btnConsultaMultiple" CssClass="btn btn-outline-primary" runat="server" OnClick="btnConsultaMultiple_Click" Style="height: 30px; width: 100px; font-size: 12px; display: inline-block;" Text="Autores/Libros" />
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
                    <h3>Ordenamiento:</h3>
                    <asp:DropDownList ID="ddlOrdenamiento" AutoPostBack="true" aria-label="Default select example" CssClass="form-select" OnSelectedIndexChanged="ddlOrdenamiento_SelectedIndexChanged" Style="width: 50%" runat="server">
                            <asp:ListItem Value="1">Title Asc</asp:ListItem>
                            <asp:ListItem Value="2">Title Desc</asp:ListItem>
                            <asp:ListItem Value="3">PublishDate Asc</asp:ListItem>
                            <asp:ListItem Value="4">PublishDate Desc</asp:ListItem>
                            <asp:ListItem Value="5">PageCount Asc</asp:ListItem>
                            <asp:ListItem Value="6">PageCount Desc</asp:ListItem>
                        </asp:DropDownList>
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