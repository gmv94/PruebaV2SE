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
    public partial class ConsultasMultiples : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private bool validarFormulario()
        {
            return !string.IsNullOrEmpty(txtNombre.Text.Trim());
        }

        /// <summary>
        /// Consultar libros por nombre del libro
        /// </summary>
        private void ConsultarLibros2(string[] Libro)
        {
            try
            {
                DBPruebaSEEntities oDBPruebaSE = new DBPruebaSEEntities();
                List<ConsultaLibroEntities> oListLibroGrid = new List<ConsultaLibroEntities>();
                ConsultaLibroEntities oListData;
                foreach (var item1 in Libro)
                {
                    var ListData = oDBPruebaSE.SpConsultaPorLibros(item1.Trim());



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
        private void ConsultarLibros1(string[] Autores)
        {
            try
            {
                DBPruebaSEEntities oDBPruebaSE = new DBPruebaSEEntities();
                List<ConsultaLibroEntities> oListAutorGrid = new List<ConsultaLibroEntities>();
                ConsultaLibroEntities oListData;
                foreach (var item1 in Autores)
                {
                    var ListData = oDBPruebaSE.SpConsultaPorAutores(item1.Trim());

                    

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
                string s = txtNombre.Text.Trim();
                string[] subs = s.Split(',');

                if (ddlTipoConsulta.SelectedValue == "1")
                {
                    ConsultarLibros1(subs);
                }
                else
                {
                    ConsultarLibros2(subs);
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
        /// Paginado para las consultas que soprepasen los 10 registros
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void gvwLibro_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvwLibro.PageIndex = e.NewPageIndex;
            string s = txtNombre.Text.Trim();
            string[] subs = s.Split(',');

            if (ddlTipoConsulta.SelectedValue == "1")
            {
                ConsultarLibros1(subs);
            }
            else
            {
                ConsultarLibros2(subs);
            }
        }

    }
}