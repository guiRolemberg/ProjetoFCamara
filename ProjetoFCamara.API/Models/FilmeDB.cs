using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProjetoFCamara.API.Models
{
    public class FilmeDB : DbContext
    {
        private DbSet<FilmeModel> _filmes;

        public DbSet<FilmeModel> Filmes
        {
            get { return this._filmes; }
            set { this._filmes = value; }
        }
    }
}