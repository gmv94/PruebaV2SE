﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PruebaV2SE.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class DBPruebaSEEntities : DbContext
    {
        public DBPruebaSEEntities()
            : base("name=DBPruebaSEEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
    
        public virtual int SpAuthor(Nullable<int> id, Nullable<int> idBook, string firstName, string lastName)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            var idBookParameter = idBook.HasValue ?
                new ObjectParameter("idBook", idBook) :
                new ObjectParameter("idBook", typeof(int));
    
            var firstNameParameter = firstName != null ?
                new ObjectParameter("firstName", firstName) :
                new ObjectParameter("firstName", typeof(string));
    
            var lastNameParameter = lastName != null ?
                new ObjectParameter("lastName", lastName) :
                new ObjectParameter("lastName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SpAuthor", idParameter, idBookParameter, firstNameParameter, lastNameParameter);
        }
    
        public virtual ObjectResult<SpConsultaPorAutor_Result> SpConsultaPorAutor(string firstName, string lastName)
        {
            var firstNameParameter = firstName != null ?
                new ObjectParameter("firstName", firstName) :
                new ObjectParameter("firstName", typeof(string));
    
            var lastNameParameter = lastName != null ?
                new ObjectParameter("lastName", lastName) :
                new ObjectParameter("lastName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SpConsultaPorAutor_Result>("SpConsultaPorAutor", firstNameParameter, lastNameParameter);
        }
    
        public virtual ObjectResult<SpConsultaPorAutores_Result> SpConsultaPorAutores(string author)
        {
            var authorParameter = author != null ?
                new ObjectParameter("Author", author) :
                new ObjectParameter("Author", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SpConsultaPorAutores_Result>("SpConsultaPorAutores", authorParameter);
        }
    
        public virtual ObjectResult<SpConsultaPorLibro_Result> SpConsultaPorLibro(string title)
        {
            var titleParameter = title != null ?
                new ObjectParameter("title", title) :
                new ObjectParameter("title", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SpConsultaPorLibro_Result>("SpConsultaPorLibro", titleParameter);
        }
    
        public virtual ObjectResult<SpConsultaPorLibros_Result> SpConsultaPorLibros(string book)
        {
            var bookParameter = book != null ?
                new ObjectParameter("Book", book) :
                new ObjectParameter("Book", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SpConsultaPorLibros_Result>("SpConsultaPorLibros", bookParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> SpConsultarUsuario()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("SpConsultarUsuario");
        }
    
        public virtual int SpInsertarActivity(Nullable<int> id, string title, string dueDate, Nullable<bool> completed)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            var titleParameter = title != null ?
                new ObjectParameter("title", title) :
                new ObjectParameter("title", typeof(string));
    
            var dueDateParameter = dueDate != null ?
                new ObjectParameter("dueDate", dueDate) :
                new ObjectParameter("dueDate", typeof(string));
    
            var completedParameter = completed.HasValue ?
                new ObjectParameter("completed", completed) :
                new ObjectParameter("completed", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SpInsertarActivity", idParameter, titleParameter, dueDateParameter, completedParameter);
        }
    
        public virtual int SpInsertarBook(Nullable<int> id, string title, string description, Nullable<int> pageCount, string excerpt, string publishDate)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            var titleParameter = title != null ?
                new ObjectParameter("title", title) :
                new ObjectParameter("title", typeof(string));
    
            var descriptionParameter = description != null ?
                new ObjectParameter("description", description) :
                new ObjectParameter("description", typeof(string));
    
            var pageCountParameter = pageCount.HasValue ?
                new ObjectParameter("pageCount", pageCount) :
                new ObjectParameter("pageCount", typeof(int));
    
            var excerptParameter = excerpt != null ?
                new ObjectParameter("excerpt", excerpt) :
                new ObjectParameter("excerpt", typeof(string));
    
            var publishDateParameter = publishDate != null ?
                new ObjectParameter("publishDate", publishDate) :
                new ObjectParameter("publishDate", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SpInsertarBook", idParameter, titleParameter, descriptionParameter, pageCountParameter, excerptParameter, publishDateParameter);
        }
    
        public virtual int SpInsertarCoverPhoto(Nullable<int> id, Nullable<int> idBook, string url)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            var idBookParameter = idBook.HasValue ?
                new ObjectParameter("idBook", idBook) :
                new ObjectParameter("idBook", typeof(int));
    
            var urlParameter = url != null ?
                new ObjectParameter("url", url) :
                new ObjectParameter("url", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SpInsertarCoverPhoto", idParameter, idBookParameter, urlParameter);
        }
    
        public virtual int SpInsertarUser(Nullable<int> id, string nameUser, string password)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            var nameUserParameter = nameUser != null ?
                new ObjectParameter("nameUser", nameUser) :
                new ObjectParameter("nameUser", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("password", password) :
                new ObjectParameter("password", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SpInsertarUser", idParameter, nameUserParameter, passwordParameter);
        }
    
        public virtual ObjectResult<SpOrdenarFechaAutorAscendente_Result> SpOrdenarFechaAutorAscendente(string firstName, string lastName)
        {
            var firstNameParameter = firstName != null ?
                new ObjectParameter("firstName", firstName) :
                new ObjectParameter("firstName", typeof(string));
    
            var lastNameParameter = lastName != null ?
                new ObjectParameter("lastName", lastName) :
                new ObjectParameter("lastName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SpOrdenarFechaAutorAscendente_Result>("SpOrdenarFechaAutorAscendente", firstNameParameter, lastNameParameter);
        }
    
        public virtual ObjectResult<SpOrdenarFechaAutorDescendente_Result> SpOrdenarFechaAutorDescendente(string firstName, string lastName)
        {
            var firstNameParameter = firstName != null ?
                new ObjectParameter("firstName", firstName) :
                new ObjectParameter("firstName", typeof(string));
    
            var lastNameParameter = lastName != null ?
                new ObjectParameter("lastName", lastName) :
                new ObjectParameter("lastName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SpOrdenarFechaAutorDescendente_Result>("SpOrdenarFechaAutorDescendente", firstNameParameter, lastNameParameter);
        }
    
        public virtual ObjectResult<SpOrdenarFechaLibroAscendente_Result> SpOrdenarFechaLibroAscendente(string title)
        {
            var titleParameter = title != null ?
                new ObjectParameter("title", title) :
                new ObjectParameter("title", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SpOrdenarFechaLibroAscendente_Result>("SpOrdenarFechaLibroAscendente", titleParameter);
        }
    
        public virtual ObjectResult<SpOrdenarFechaLibroDescendente_Result> SpOrdenarFechaLibroDescendente(string title)
        {
            var titleParameter = title != null ?
                new ObjectParameter("title", title) :
                new ObjectParameter("title", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SpOrdenarFechaLibroDescendente_Result>("SpOrdenarFechaLibroDescendente", titleParameter);
        }
    
        public virtual ObjectResult<SpOrdenarPaginasAutorAscendente_Result> SpOrdenarPaginasAutorAscendente(string firstName, string lastName)
        {
            var firstNameParameter = firstName != null ?
                new ObjectParameter("firstName", firstName) :
                new ObjectParameter("firstName", typeof(string));
    
            var lastNameParameter = lastName != null ?
                new ObjectParameter("lastName", lastName) :
                new ObjectParameter("lastName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SpOrdenarPaginasAutorAscendente_Result>("SpOrdenarPaginasAutorAscendente", firstNameParameter, lastNameParameter);
        }
    
        public virtual ObjectResult<SpOrdenarPaginasAutorDescendente_Result> SpOrdenarPaginasAutorDescendente(string firstName, string lastName)
        {
            var firstNameParameter = firstName != null ?
                new ObjectParameter("firstName", firstName) :
                new ObjectParameter("firstName", typeof(string));
    
            var lastNameParameter = lastName != null ?
                new ObjectParameter("lastName", lastName) :
                new ObjectParameter("lastName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SpOrdenarPaginasAutorDescendente_Result>("SpOrdenarPaginasAutorDescendente", firstNameParameter, lastNameParameter);
        }
    
        public virtual ObjectResult<SpOrdenarPaginasLibroAscendente_Result> SpOrdenarPaginasLibroAscendente(string title)
        {
            var titleParameter = title != null ?
                new ObjectParameter("title", title) :
                new ObjectParameter("title", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SpOrdenarPaginasLibroAscendente_Result>("SpOrdenarPaginasLibroAscendente", titleParameter);
        }
    
        public virtual ObjectResult<SpOrdenarPaginasLibroDescendente_Result> SpOrdenarPaginasLibroDescendente(string title)
        {
            var titleParameter = title != null ?
                new ObjectParameter("title", title) :
                new ObjectParameter("title", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SpOrdenarPaginasLibroDescendente_Result>("SpOrdenarPaginasLibroDescendente", titleParameter);
        }
    
        public virtual ObjectResult<SpOrdenarTituloAutorAscendente_Result> SpOrdenarTituloAutorAscendente(string firstName, string lastName)
        {
            var firstNameParameter = firstName != null ?
                new ObjectParameter("firstName", firstName) :
                new ObjectParameter("firstName", typeof(string));
    
            var lastNameParameter = lastName != null ?
                new ObjectParameter("lastName", lastName) :
                new ObjectParameter("lastName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SpOrdenarTituloAutorAscendente_Result>("SpOrdenarTituloAutorAscendente", firstNameParameter, lastNameParameter);
        }
    
        public virtual ObjectResult<SpOrdenarTituloAutorDescendente_Result> SpOrdenarTituloAutorDescendente(string firstName, string lastName)
        {
            var firstNameParameter = firstName != null ?
                new ObjectParameter("firstName", firstName) :
                new ObjectParameter("firstName", typeof(string));
    
            var lastNameParameter = lastName != null ?
                new ObjectParameter("lastName", lastName) :
                new ObjectParameter("lastName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SpOrdenarTituloAutorDescendente_Result>("SpOrdenarTituloAutorDescendente", firstNameParameter, lastNameParameter);
        }
    
        public virtual ObjectResult<SpOrdenarTituloLibroAscendente_Result> SpOrdenarTituloLibroAscendente(string title)
        {
            var titleParameter = title != null ?
                new ObjectParameter("title", title) :
                new ObjectParameter("title", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SpOrdenarTituloLibroAscendente_Result>("SpOrdenarTituloLibroAscendente", titleParameter);
        }
    
        public virtual ObjectResult<SpOrdenarTituloLibroDescendente_Result> SpOrdenarTituloLibroDescendente(string title)
        {
            var titleParameter = title != null ?
                new ObjectParameter("title", title) :
                new ObjectParameter("title", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SpOrdenarTituloLibroDescendente_Result>("SpOrdenarTituloLibroDescendente", titleParameter);
        }
    }
}
