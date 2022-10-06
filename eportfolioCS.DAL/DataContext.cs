using eportfolioCS.DAL.Datas;
using eportfolioCS.DAL.Entities;
using eportfolioCS.DAL.EntityConfigs;
using Microsoft.EntityFrameworkCore;
using System;

namespace eportfolioCS.DAL
{
    public class DataContext : DbContext
    {
        private readonly string _connectToDBString;

        public DataContext()
        {
            _connectToDBString = "Data Source=(localdb)\\MSSQLLocalDB;" +
                "Initial Catalog=eportfolioCSTest;" +
                "Integrated Security=True;" +
                "Connect Timeout=30;Encrypt=False;" +
                "TrustServerCertificate=False;" +
                "ApplicationIntent=ReadWrite;" +
                "MultiSubnetFailover=False";
        }
        public DataContext(string ConnectionString)
        {
            _connectToDBString = ConnectionString;
        }

        /*les ENTITES
         elles seront accessibles par le projet appelant
        le nom de la propriété = nom de la table (sauf indication contraire)
         */
        public DbSet<TexteEntity> Textes { get; set; }
        public DbSet<CategorieEntity> Categories { get; set; }
        public DbSet<LangageEntity> Langages { get; set; }
        public DbSet<FrameworkEntity> Frameworks { get; set; }
        public DbSet<TypeProjetEntity> TypesProjet { get; set; }
        public DbSet<IdeEntity> IDEs { get; set; }
        public DbSet<SgbdEntity> SGBDs { get; set; }
        public DbSet<EtablissementEntity> Etablissements { get; set; }
        public DbSet<ExperienceEntity> Experiences { get; set; }
        public DbSet<ProjetEntity> Projets { get; set; }
        public DbSet<FrameworkProjetEntity> FrameworkProjet { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder) 
        {
            optionBuilder.UseSqlServer(_connectToDBString);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new TexteConfig());
            builder.ApplyConfiguration(new CategorieConfig());
            builder.ApplyConfiguration(new LangageConfig());
            builder.ApplyConfiguration(new FrameworkConfig());
            builder.ApplyConfiguration(new TypeProjetConfig());
            builder.ApplyConfiguration(new IdeConfig());
            builder.ApplyConfiguration(new SgbdConfig());
            builder.ApplyConfiguration(new EtablissementConfig());
            builder.ApplyConfiguration(new ExperienceConfig());
            builder.ApplyConfiguration(new ProjetConfig());
            builder.ApplyConfiguration(new FrameworkProjetConfig());
            InitDB.LoadData(builder);
        }
    }
}
