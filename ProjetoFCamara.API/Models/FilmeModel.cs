using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ProjetoFCamara.API.Models
{
    [Table("Filme")]
    public class FilmeModel
    {
        private int _filmeId;
        private string _titulo;
        private int _ano;
        private int _duracao;

        [Key]
        public int FilmeID
        {
            get { return this._filmeId; }
            set { this._filmeId = value; }
        }

        public string Titulo
        {
            get { return this._titulo; }
            set { this._titulo = value;  }
        }

        public int Ano
        {
            get { return this._ano; }
            set { this._ano = value; }
        }
        public int Duracao
        {
            get { return this._duracao; }
            set { this._duracao = value; }
        }
    }
}