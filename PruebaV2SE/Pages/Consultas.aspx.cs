using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PruebaV2SE.Models;
using PruebaV2SE.Entities;
using PruebaV2SE.Business;
using System.Data;

namespace PruebaV2SE.Pages
{
    public partial class Consultas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private bool validarFormulario()
        {
            if (ddlTipoConsulta.SelectedValue == "1")
            {
                return !string.IsNullOrEmpty(txtNombre.Text.Trim()) && !string.IsNullOrEmpty(txtApellido.Text.Trim());
            }
            else
            {
                return !string.IsNullOrEmpty(txtLibro.Text.Trim());
            }
        }

        /// <summary>
        /// Consultar libros por nombre del libro
        /// </summary>
        private void ConsultarLibros2()
        {
            try
            {
                DBPruebaSEEntities oDBPruebaSE = new DBPruebaSEEntities();
                var ListData = oDBPruebaSE.SpConsultaPorLibro(txtLibro.Text);

                List<ConsultaLibroEntities> oListLibroGrid = new List<ConsultaLibroEntities>();
                ConsultaLibroEntities oListData;

                foreach (var item in ListData)
                {
                    oListData = new ConsultaLibroEntities();

                    oListData.title = item.title;
                    oListData.publishDate = item.publishDate;
                    oListData.pageCount = item.pageCount.ToString();
                    oListData.excerpt = item.excerpt;
                    oListData.Author = item.Author;
                    oListData.description = item.description;

                    oListLibroGrid.Add(oListData);
                }
                if (oListLibroGrid.Count > 0)
                {
                    gvwLibro.DataSource = oListLibroGrid;
                    gvwLibro.DataBind();
                }
                else
                {
                    lblConsult.Text = "No se encontraron registros";
                    gvwLibro.Columns.Clear();
                    lblConsult.Visible = true;
                }
            }
            catch (Exception ex)
            {
                lblConsult.Text = ex.Message;
                lblConsult.Visible = true;
            }
        }

        /// <summary>
        /// Consultar libros por Autor
        /// </summary>
        private void ConsultarLibros1()
        {
            try
            {
                DBPruebaSEEntities oDBPruebaSE = new DBPruebaSEEntities();
                var ListData = oDBPruebaSE.SpConsultaPorAutor(txtNombre.Text, txtApellido.Text);

                List<ConsultaLibroEntities> oListAutorGrid = new List<ConsultaLibroEntities>();
                ConsultaLibroEntities oListData;

                foreach (var item in ListData)
                {
                    oListData = new ConsultaLibroEntities();

                    oListData.title = item.title;
                    oListData.publishDate = item.publishDate;
                    oListData.pageCount = item.pageCount.ToString();
                    oListData.excerpt = item.excerpt;
                    oListData.Author = item.Author;
                    oListData.description = item.description;

                    oListAutorGrid.Add(oListData);
                }
                if (oListAutorGrid.Count > 0)
                {
                    gvwLibro.DataSource = oListAutorGrid;
                    gvwLibro.DataBind();
                }
                else
                {
                    lblConsult.Text = "No se encontraron registros";
                    gvwLibro.Columns.Clear();
                    lblConsult.Visible = true;
                }
            }
            catch (Exception ex)
            {
                lblConsult.Text = ex.Message;
                lblConsult.Visible = true;
            }
        }

        /// <summary>
        /// Ordenar por título ascendente en la consulta por libro
        /// </summary>
        private void OrdenarTituloLibroAscendente()
        {
            try
            {
                DBPruebaSEEntities oDBPruebaSE = new DBPruebaSEEntities();
                var ListData = oDBPruebaSE.SpOrdenarTituloLibroAscendente(txtLibro.Text.Trim());
                List<ConsultaLibroEntities> oListAutorGrid = new List<ConsultaLibroEntities>();
                ConsultaLibroEntities oListData;

                foreach (var item in ListData)
                {
                    oListData = new ConsultaLibroEntities();

                    oListData.title = item.title;
                    oListData.publishDate = item.publishDate;
                    oListData.pageCount = item.pageCount.ToString();
                    oListData.excerpt = item.excerpt;
                    oListData.Author = item.Author;
                    oListData.description = item.description;

                    oListAutorGrid.Add(oListData);
                }
                if (oListAutorGrid.Count > 0)
                {
                    gvwLibro.DataSource = oListAutorGrid;
                    gvwLibro.DataBind();
                }
                else
                {
                    lblConsult.Text = "No se encontraron registros";
                    lblConsult.Visible = true;
                }
            }
            catch (Exception ex)
            {
                lblConsult.Text = ex.Message;
                lblConsult.Visible = true;
            }
        }

        /// <summary>
        /// Ordenar por Título descendente en la consulta por libro
        /// </summary>
        private void OrdenarTituloLibroDescendente()
        {
            try
            {
                DBPruebaSEEntities oDBPruebaSE = new DBPruebaSEEntities();
                var ListData = oDBPruebaSE.SpOrdenarTituloLibroDescendente(txtLibro.Text.Trim());
                List<ConsultaLibroEntities> oListAutorGrid = new List<ConsultaLibroEntities>();
                ConsultaLibroEntities oListData;

                foreach (var item in ListData)
                {
                    oListData = new ConsultaLibroEntities();

                    oListData.title = item.title;
                    oListData.publishDate = item.publishDate;
                    oListData.pageCount = item.pageCount.ToString();
                    oListData.excerpt = item.excerpt;
                    oListData.Author = item.Author;
                    oListData.description = item.description;

                    oListAutorGrid.Add(oListData);
                }
                if (oListAutorGrid.Count > 0)
                {
                    gvwLibro.DataSource = oListAutorGrid;
                    gvwLibro.DataBind();
                }
                else
                {
                    lblConsult.Text = "No se encontraron registros";
                    lblConsult.Visible = true;
                }
            }
            catch (Exception ex)
            {
                lblConsult.Text = ex.Message;
                lblConsult.Visible = true;
            }
        }


        /// <summary>
        /// Ordenar por Título ascendente en la consulta por Autor
        /// </summary>
        private void OrdenarTituloAutorAscendente()
        {
            try
            {
                DBPruebaSEEntities oDBPruebaSE = new DBPruebaSEEntities();
                var ListData = oDBPruebaSE.SpOrdenarTituloAutorAscendente(txtNombre.Text.Trim(), txtApellido.Text.Trim());
                List<ConsultaLibroEntities> oListAutorGrid = new List<ConsultaLibroEntities>();
                ConsultaLibroEntities oListData;

                foreach (var item in ListData)
                {
                    oListData = new ConsultaLibroEntities();

                    oListData.title = item.title;
                    oListData.publishDate = item.publishDate;
                    oListData.pageCount = item.pageCount.ToString();
                    oListData.excerpt = item.excerpt;
                    oListData.Author = item.Author;
                    oListData.description = item.description;

                    oListAutorGrid.Add(oListData);
                }
                if (oListAutorGrid.Count > 0)
                {
                    gvwLibro.DataSource = oListAutorGrid;
                    gvwLibro.DataBind();
                }
                else
                {
                    lblConsult.Text = "No se encontraron registros";
                    lblConsult.Visible = true;
                }
            }
            catch (Exception ex)
            {
                lblConsult.Text = ex.Message;
                lblConsult.Visible = true;
            }
        }

        /// <summary>
        /// Ordenar por Título Descendente en la consulta por Autor
        /// </summary>
        private void OrdenarTituloAutorDescendente()
        {
            try
            {
                DBPruebaSEEntities oDBPruebaSE = new DBPruebaSEEntities();
                var ListData = oDBPruebaSE.SpOrdenarTituloAutorDescendente(txtNombre.Text.Trim(), txtApellido.Text.Trim());
                List<ConsultaLibroEntities> oListAutorGrid = new List<ConsultaLibroEntities>();
                ConsultaLibroEntities oListData;

                foreach (var item in ListData)
                {
                    oListData = new ConsultaLibroEntities();

                    oListData.title = item.title;
                    oListData.publishDate = item.publishDate;
                    oListData.pageCount = item.pageCount.ToString();
                    oListData.excerpt = item.excerpt;
                    oListData.Author = item.Author;
                    oListData.description = item.description;

                    oListAutorGrid.Add(oListData);
                }
                if (oListAutorGrid.Count > 0)
                {
                    gvwLibro.DataSource = oListAutorGrid;
                    gvwLibro.DataBind();
                }
                else
                {
                    lblConsult.Text = "No se encontraron registros";
                    lblConsult.Visible = true;
                }
            }
            catch (Exception ex)
            {
                lblConsult.Text = ex.Message;
                lblConsult.Visible = true;
            }
        }

        /// <summary>
        /// Ordenar por fecha ascendente en la consulta por libro
        /// </summary>
        private void OrdenarFechaLibroAscendente()
        {
            try
            {
                DBPruebaSEEntities oDBPruebaSE = new DBPruebaSEEntities();
                var ListData = oDBPruebaSE.SpOrdenarFechaLibroAscendente(txtLibro.Text.Trim());
                List<ConsultaLibroEntities> oListAutorGrid = new List<ConsultaLibroEntities>();
                ConsultaLibroEntities oListData;

                foreach (var item in ListData)
                {
                    oListData = new ConsultaLibroEntities();

                    oListData.title = item.title;
                    oListData.publishDate = item.publishDate;
                    oListData.pageCount = item.pageCount.ToString();
                    oListData.excerpt = item.excerpt;
                    oListData.Author = item.Author;
                    oListData.description = item.description;

                    oListAutorGrid.Add(oListData);
                }
                if (oListAutorGrid.Count > 0)
                {
                    gvwLibro.DataSource = oListAutorGrid;
                    gvwLibro.DataBind();
                }
                else
                {
                    lblConsult.Text = "No se encontraron registros";
                    lblConsult.Visible = true;
                }
            }
            catch (Exception ex)
            {
                lblConsult.Text = ex.Message;
                lblConsult.Visible = true;
            }
        }

        /// <summary>
        /// Ordenar por fecha descendente en la consulta por libro
        /// </summary>
        private void OrdenarFechaLibroDescendente()
        {
            try
            {
                DBPruebaSEEntities oDBPruebaSE = new DBPruebaSEEntities();
                var ListData = oDBPruebaSE.SpOrdenarFechaLibroDescendente(txtLibro.Text.Trim());
                List<ConsultaLibroEntities> oListAutorGrid = new List<ConsultaLibroEntities>();
                ConsultaLibroEntities oListData;

                foreach (var item in ListData)
                {
                    oListData = new ConsultaLibroEntities();

                    oListData.title = item.title;
                    oListData.publishDate = item.publishDate;
                    oListData.pageCount = item.pageCount.ToString();
                    oListData.excerpt = item.excerpt;
                    oListData.Author = item.Author;
                    oListData.description = item.description;

                    oListAutorGrid.Add(oListData);
                }
                if (oListAutorGrid.Count > 0)
                {
                    gvwLibro.DataSource = oListAutorGrid;
                    gvwLibro.DataBind();
                }
                else
                {
                    lblConsult.Text = "No se encontraron registros";
                    lblConsult.Visible = true;
                }
            }
            catch (Exception ex)
            {
                lblConsult.Text = ex.Message;
                lblConsult.Visible = true;
            }
        }

        /// <summary>
        /// Ordenar por fecha ascendente en la consulta por Autor
        /// </summary> 
        private void OrdenarFechaAutorAscendente()
        {
            try
            {
                DBPruebaSEEntities oDBPruebaSE = new DBPruebaSEEntities();
                var ListData = oDBPruebaSE.SpOrdenarFechaAutorAscendente(txtNombre.Text.Trim(), txtApellido.Text.Trim());
                List<ConsultaLibroEntities> oListAutorGrid = new List<ConsultaLibroEntities>();
                ConsultaLibroEntities oListData;

                foreach (var item in ListData)
                {
                    oListData = new ConsultaLibroEntities();

                    oListData.title = item.title;
                    oListData.publishDate = item.publishDate;
                    oListData.pageCount = item.pageCount.ToString();
                    oListData.excerpt = item.excerpt;
                    oListData.Author = item.Author;
                    oListData.description = item.description;

                    oListAutorGrid.Add(oListData);
                }
                if (oListAutorGrid.Count > 0)
                {
                    gvwLibro.DataSource = oListAutorGrid;
                    gvwLibro.DataBind();
                }
                else
                {
                    lblConsult.Text = "No se encontraron registros";
                    lblConsult.Visible = true;
                }
            }
            catch (Exception ex)
            {
                lblConsult.Text = ex.Message;
                lblConsult.Visible = true;
            }
        }

        /// <summary>
        /// Ordenar por fecha descendente en la consulta por Autor
        /// </summary>
        private void OrdenarFechaAutorDescendente()
        {
            try
            {
                DBPruebaSEEntities oDBPruebaSE = new DBPruebaSEEntities();
                var ListData = oDBPruebaSE.SpOrdenarFechaAutorDescendente(txtNombre.Text.Trim(), txtApellido.Text.Trim());
                List<ConsultaLibroEntities> oListAutorGrid = new List<ConsultaLibroEntities>();
                ConsultaLibroEntities oListData;

                foreach (var item in ListData)
                {
                    oListData = new ConsultaLibroEntities();

                    oListData.title = item.title;
                    oListData.publishDate = item.publishDate;
                    oListData.pageCount = item.pageCount.ToString();
                    oListData.excerpt = item.excerpt;
                    oListData.Author = item.Author;
                    oListData.description = item.description;

                    oListAutorGrid.Add(oListData);
                }
                if (oListAutorGrid.Count > 0)
                {
                    gvwLibro.DataSource = oListAutorGrid;
                    gvwLibro.DataBind();
                }
                else
                {
                    lblConsult.Text = "No se encontraron registros";
                    lblConsult.Visible = true;
                }
            }
            catch (Exception ex)
            {
                lblConsult.Text = ex.Message;
                lblConsult.Visible = true;
            }
        }



        /// <summary>
        /// Ordenar por páginas ascendente en la consulta por libro
        /// </summary>
        private void OrdenarPaginasLibroAscendente()
        {
            try
            {
                DBPruebaSEEntities oDBPruebaSE = new DBPruebaSEEntities();
                var ListData = oDBPruebaSE.SpOrdenarPaginasLibroAscendente(txtLibro.Text.Trim());
                List<ConsultaLibroEntities> oListAutorGrid = new List<ConsultaLibroEntities>();
                ConsultaLibroEntities oListData;

                foreach (var item in ListData)
                {
                    oListData = new ConsultaLibroEntities();

                    oListData.title = item.title;
                    oListData.publishDate = item.publishDate;
                    oListData.pageCount = item.pageCount.ToString();
                    oListData.excerpt = item.excerpt;
                    oListData.Author = item.Author;
                    oListData.description = item.description;

                    oListAutorGrid.Add(oListData);
                }
                if (oListAutorGrid.Count > 0)
                {
                    gvwLibro.DataSource = oListAutorGrid;
                    gvwLibro.DataBind();
                }
                else
                {
                    lblConsult.Text = "No se encontraron registros";
                    lblConsult.Visible = true;
                }
            }
            catch (Exception ex)
            {
                lblConsult.Text = ex.Message;
                lblConsult.Visible = true;
            }
        }

        /// <summary>
        /// Ordenar por páginas descendente en la consulta por libro
        /// </summary>
        private void OrdenarPaginasLibroDescendente()
        {
            try
            {
                DBPruebaSEEntities oDBPruebaSE = new DBPruebaSEEntities();
                var ListData = oDBPruebaSE.SpOrdenarPaginasLibroDescendente(txtLibro.Text.Trim());
                List<ConsultaLibroEntities> oListAutorGrid = new List<ConsultaLibroEntities>();
                ConsultaLibroEntities oListData;

                foreach (var item in ListData)
                {
                    oListData = new ConsultaLibroEntities();

                    oListData.title = item.title;
                    oListData.publishDate = item.publishDate;
                    oListData.pageCount = item.pageCount.ToString();
                    oListData.excerpt = item.excerpt;
                    oListData.Author = item.Author;
                    oListData.description = item.description;

                    oListAutorGrid.Add(oListData);
                }
                if (oListAutorGrid.Count > 0)
                {
                    gvwLibro.DataSource = oListAutorGrid;
                    gvwLibro.DataBind();
                }
                else
                {
                    lblConsult.Text = "No se encontraron registros";
                    lblConsult.Visible = true;
                }
            }
            catch (Exception ex)
            {
                lblConsult.Text = ex.Message;
                lblConsult.Visible = true;
            }
        }

        /// <summary>
        /// Ordenar por páginas ascendente en la consulta por Autor
        /// </summary>
        private void OrdenarPaginasAutorAscendente()
        {
            try
            {
                DBPruebaSEEntities oDBPruebaSE = new DBPruebaSEEntities();
                var ListData = oDBPruebaSE.SpOrdenarPaginasAutorAscendente(txtNombre.Text.Trim(), txtApellido.Text.Trim());
                List<ConsultaLibroEntities> oListAutorGrid = new List<ConsultaLibroEntities>();
                ConsultaLibroEntities oListData;

                foreach (var item in ListData)
                {
                    oListData = new ConsultaLibroEntities();

                    oListData.title = item.title;
                    oListData.publishDate = item.publishDate;
                    oListData.pageCount = item.pageCount.ToString();
                    oListData.excerpt = item.excerpt;
                    oListData.Author = item.Author;
                    oListData.description = item.description;

                    oListAutorGrid.Add(oListData);
                }
                if (oListAutorGrid.Count > 0)
                {
                    gvwLibro.DataSource = oListAutorGrid;
                    gvwLibro.DataBind();
                }
                else
                {
                    lblConsult.Text = "No se encontraron registros";
                    lblConsult.Visible = true;
                }
            }
            catch (Exception ex)
            {
                lblConsult.Text = ex.Message;
                lblConsult.Visible = true;
            }
        }

        /// <summary>
        /// Ordenar por Páginas descendente en la consulta por Autor
        /// </summary>
        private void OrdenarPaginasAutorDescendente()
        {
            try
            {
                DBPruebaSEEntities oDBPruebaSE = new DBPruebaSEEntities();
                var ListData = oDBPruebaSE.SpOrdenarPaginasAutorDescendente(txtNombre.Text.Trim(), txtApellido.Text.Trim());
                List<ConsultaLibroEntities> oListAutorGrid = new List<ConsultaLibroEntities>();
                ConsultaLibroEntities oListData;

                foreach (var item in ListData)
                {
                    oListData = new ConsultaLibroEntities();

                    oListData.title = item.title;
                    oListData.publishDate = item.publishDate;
                    oListData.pageCount = item.pageCount.ToString();
                    oListData.excerpt = item.excerpt;
                    oListData.Author = item.Author;
                    oListData.description = item.description;

                    oListAutorGrid.Add(oListData);
                }
                if (oListAutorGrid.Count > 0)
                {
                    gvwLibro.DataSource = oListAutorGrid;
                    gvwLibro.DataBind();
                }
                else
                {
                    lblConsult.Text = "No se encontraron registros";
                    lblConsult.Visible = true;
                }
            }
            catch (Exception ex)
            {
                lblConsult.Text = ex.Message;
                lblConsult.Visible = true;
            }
        }







        /// <summary>
        /// Dirigir al Login
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Pages/Login.aspx");
        }

        /// <summary>
        /// Botón que dirige al procedimiento almacenado dependiendo del tipo de consulta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnConsultar_Click(object sender, EventArgs e)
        {
            lblConsult.Visible = false;
            if (validarFormulario())
            {
                if (ddlTipoConsulta.SelectedValue == "1")
                {
                    ConsultarLibros1();
                }
                else
                {
                    ConsultarLibros2();
                }
            }
            else
            {
                lblConsult.Text = "Por favor indicar los datos requeridos";
                lblConsult.Visible = true;
                gvwLibro.DataSource = new DataTable();
                gvwLibro.DataBind();
            }

        }

        /// <summary>
        /// Dirige a la página de consultas múltiples
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnConsultaMultiple_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Pages/ConsultasMultiples.aspx");

        }

        /// <summary>
        /// Paginado para las consultas que soprepasen los 10 registros
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void gvwLibro_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvwLibro.PageIndex = e.NewPageIndex;
            if (ddlTipoConsulta.SelectedValue == "1")
            {
                ConsultarLibros1();
            }
            else
            {
                ConsultarLibros2();
            }
        }

        /// <summary>
        /// Habilita campos dependiendo el tipo de consulta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void ddlTipoConsulta_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlTipoConsulta.SelectedValue == "1")
            {

                dvAutor.Visible = true;
                dvLibro.Visible = false;
            }
            else
            {
                dvAutor.Visible = false;
                dvLibro.Visible = true;
            }
        }

        protected void ddlOrdenamiento_SelectedIndexChanged(object sender, EventArgs e)
        {
            int opc = int.Parse(ddlOrdenamiento.SelectedValue);
            if(ddlTipoConsulta.SelectedValue == "1")
            {
                if(string.IsNullOrEmpty(txtLibro.Text.Trim()))
                {

                }
                else
                {
                    lblConsult.Text = "Realice una búsqueda antes de ordenar";
                    lblConsult.Visible = true;
                }
            }
            else
            {
                if(string.IsNullOrEmpty(txtNombre.Text.Trim()) && string.IsNullOrEmpty(txtApellido.Text.Trim()))
                {
                    switch (opc)
                    {
                        case 1:
                            if(ddlTipoConsulta.SelectedValue == "1")
                            {
                                OrdenarTituloAutorAscendente();
                            }
                            else
                            {
                                OrdenarTituloLibroAscendente();
                            }
                            
                            break;
                        case 2:
                            if (ddlTipoConsulta.SelectedValue == "1")
                            {
                                OrdenarTituloAutorDescendente();
                            }
                            else
                            {
                                OrdenarTituloLibroDescendente();
                            }
                            OrdenarTituloLibroDescendente();
                            break;
                        case 3:
                            if (ddlTipoConsulta.SelectedValue == "1")
                            {
                                OrdenarFechaAutorAscendente();
                            }
                            else
                            {
                                OrdenarFechaLibroAscendente();
                            }
                            break;
                        case 4:
                            if (ddlTipoConsulta.SelectedValue == "1")
                            {
                                OrdenarFechaAutorDescendente();
                            }
                            else
                            {
                                OrdenarFechaLibroDescendente();
                            }
                            break;
                        case 5:
                            if (ddlTipoConsulta.SelectedValue == "1")
                            {
                                OrdenarPaginasAutorAscendente();
                            }
                            else
                            {
                                OrdenarPaginasLibroAscendente();
                            }
                            break;
                        case 6:
                            if (ddlTipoConsulta.SelectedValue == "1")
                            {
                                OrdenarPaginasAutorDescendente();
                            }
                            else
                            {
                                OrdenarPaginasLibroDescendente();
                            }
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    lblConsult.Text = "Realice una búsqueda antes de ordenar";
                    lblConsult.Visible = true;
                }
            }
        }
    }

}