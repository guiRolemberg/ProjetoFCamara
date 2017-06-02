namespace ProjetoFCamara.API.Migrations
{
    using ProjetoFCamara.API.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ProjetoFCamara.API.Models.FilmeDB>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(FilmeDB context)
        {
            //  This method will be called after migrating to the latest version.
            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            context.Filmes.AddOrUpdate(
                  x => x.Titulo,
                  new FilmeModel { Titulo = "Piratas do Caribe", Ano = 2017, Duracao = 138 },
                  new FilmeModel { Titulo = "Velozes e Furiosos 8", Ano = 2017, Duracao = 132 },
                  new FilmeModel { Titulo = "Rei Arthur", Ano = 2017, Duracao = 134 },
                  new FilmeModel { Titulo = "Gardiões da Galaxia", Ano = 2017, Duracao = 141 },
                  new FilmeModel { Titulo = "A Cabana", Ano = 2017, Duracao = 127 }
                );            
        }
    }
}
