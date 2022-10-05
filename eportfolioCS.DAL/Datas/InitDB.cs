using eportfolioCS.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eportfolioCS.DAL.Datas
{
    public class InitDB
    {
        public static void LoadData(ModelBuilder builder)
        {
            /*Texte*/

            /*Catégories*/
            builder.Entity<CategorieEntity>()
                .HasData(new CategorieEntity { 
                    ID = 1, 
                    Nom = "Expériences professionnelles" });
            builder.Entity<CategorieEntity>()
                .HasData(new CategorieEntity { 
                    ID = 2, 
                    Nom = "Études et formations" });
            builder.Entity<CategorieEntity>()
                .HasData(new CategorieEntity { 
                    ID = 3, 
                    Nom = "Stages", 
                    ParentID = 1 });
            builder.Entity<CategorieEntity>()
                .HasData(new CategorieEntity { 
                    ID = 4, 
                    Nom = "Études", 
                    ParentID = 2 });
            builder.Entity<CategorieEntity>()
                .HasData(new CategorieEntity { 
                    ID = 5, 
                    Nom = "Formations", 
                    ParentID = 2 });
            /*Etablissements*/
            builder.Entity<EtablissementEntity>()
                .HasData(new EtablissementEntity { 
                    ID = 1, 
                    Nom="TechnofuturTIC", 
                    Pays="Belgique", 
                    Province="Hainaut", 
                    CodePostal=6041, 
                    Ville="Gosselies", 
                    Adresse="Avenue Jean Mermoz 18", 
                    Description="Centre de compétences", 
                    SiteWeb="www.technofuturtic.be"});
            builder.Entity<EtablissementEntity>()
                .HasData(new EtablissementEntity
                {
                    ID = 2,
                    Nom = "HELMo",
                    Description = "Haute École Libre Mosane",
                    Pays = "Belgique",
                    Province = "Liège",
                    CodePostal = 4000,
                    Ville = "Liège",
                    SiteWeb = "www.helmo.be"
                });
            /*Expériences*/
            builder.Entity<ExperienceEntity>()
                .HasData(new ExperienceEntity { 
                    ID = 1,
                    CategorieID = 5,
                    FirmeID = 1,
                    Titre = "Développeur Web orienté Data Analysis",
                    DateDebut = new DateTime(2022,9,6)
                });
            builder.Entity<ExperienceEntity>()
                .HasData(new ExperienceEntity
                {
                    ID = 2,
                    CategorieID = 5,
                    FirmeID = 1,
                    Titre = "Développeur .NET, BI & Sharepoint",
                    DateDebut = new DateTime(2021, 3, 22),
                    DateFin = new DateTime(2021, 9, 7)
                });
            builder.Entity<ExperienceEntity>()
                .HasData(new ExperienceEntity
                {
                    ID = 3,
                    CategorieID = 4,
                    FirmeID = 2,
                    Titre = "Bachelier en informatique de gestion",
                    DateDebut = new DateTime(2016, 9, 15),
                    DateFin = new DateTime(2019, 9, 14)
                });
            builder.Entity<ExperienceEntity>()
                .HasData(new ExperienceEntity
                {
                    ID = 4,
                    CategorieID = 4,
                    FirmeID = 2,
                    Titre = "Bachelier en informatique de gestion",
                    DateDebut = new DateTime(2008, 9, 15),
                    DateFin = new DateTime(2011, 1, 7)
                });

            /*Type Projet*/
            builder.Entity<TypeProjetEntity>()
                .HasData(new TypeProjetEntity { 
                    ID = 1,
                    Nom = "Logiciel Desktop"
                });
            builder.Entity<TypeProjetEntity>()
                .HasData(new TypeProjetEntity
                {
                    ID = 2,
                    Nom = "Site Web"
                });
            builder.Entity<TypeProjetEntity>()
                .HasData(new TypeProjetEntity
                {
                    ID = 3,
                    Nom = "API Web"
                });
            builder.Entity<TypeProjetEntity>()
                .HasData(new TypeProjetEntity
                {
                    ID = 4,
                    Nom = "App Mobile"
                });
            /*IDE*/
            builder.Entity<IdeEntity>()
                .HasData(new IdeEntity { 
                    ID = 1,
                    Nom = "Visual Studio"
                });
            /*SGBD*/
            builder.Entity<SgbdEntity>()
                .HasData(new SgbdEntity { 
                    ID = 1,
                    Nom = "SQL Server"
                });
            builder.Entity<SgbdEntity>()
                .HasData(new SgbdEntity
                {
                    ID = 2,
                    Nom = "Oracle"
                });
            builder.Entity<SgbdEntity>()
                .HasData(new SgbdEntity
                {
                    ID = 3,
                    Nom = "MySQL"
                });
            /*Langage*/
            builder.Entity<LangageEntity>()
                .HasData(new LangageEntity { 
                    ID = 1,
                    Nom = "C#",
                    AnneeCreation = new DateTime(2001)
                });
            builder.Entity<LangageEntity>()
                .HasData(new LangageEntity
                {
                    ID = 2,
                    Nom = "HTML",
                    AnneeCreation = new DateTime(1991)
                });
            builder.Entity<LangageEntity>()
                .HasData(new LangageEntity
                {
                    ID = 3,
                    Nom = "Java",
                    AnneeCreation = new DateTime(1996)
                });
            builder.Entity<LangageEntity>()
                .HasData(new LangageEntity
                {
                    ID = 4,
                    Nom = "JavaScript",
                    AnneeCreation = new DateTime(1995)
                });
            builder.Entity<LangageEntity>()
                .HasData(new LangageEntity
                {
                    ID = 5,
                    Nom = "SQL",
                    AnneeCreation = new DateTime(1986)
                });
            builder.Entity<LangageEntity>()
                .HasData(new LangageEntity
                {
                    ID = 6,
                    Nom = "PHP",
                    AnneeCreation = new DateTime(1994)
                });
            builder.Entity<LangageEntity>()
                .HasData(new LangageEntity
                {
                    ID = 7,
                    Nom = "CSS",
                    AnneeCreation = new DateTime(1994)
                });
            /*Framework*/
            builder.Entity<FrameworkEntity>()
                .HasData(new FrameworkEntity
                {
                    ID = 1,
                    Nom = "Pas de Framework",
                    LangageID = 1
                });
            builder.Entity<FrameworkEntity>()
                .HasData(new FrameworkEntity
                {
                    ID = 2,
                    Nom = "Pas de Framework",
                    LangageID = 2
                });
            builder.Entity<FrameworkEntity>()
                .HasData(new FrameworkEntity
                {
                    ID = 3,
                    Nom = "Pas de Framework",
                    LangageID = 3
                });
            builder.Entity<FrameworkEntity>()
                .HasData(new FrameworkEntity
                {
                    ID = 4,
                    Nom = "Pas de Framework",
                    LangageID = 4
                });
            builder.Entity<FrameworkEntity>()
                .HasData(new FrameworkEntity
                {
                    ID = 5,
                    Nom = "Pas de Framework",
                    LangageID = 5
                });
            builder.Entity<FrameworkEntity>()
                .HasData(new FrameworkEntity
                {
                    ID = 6,
                    Nom = "Pas de Framework",
                    LangageID = 6
                });
            builder.Entity<FrameworkEntity>()
                .HasData(new FrameworkEntity
                {
                    ID = 7,
                    Nom = "Pas de Framework",
                    LangageID = 7
                });
            builder.Entity<FrameworkEntity>()
                .HasData(new FrameworkEntity
                {
                    ID = 8,
                    Nom = "ASP.NET",
                    LangageID = 1
                });
            builder.Entity<FrameworkEntity>()
                .HasData(new FrameworkEntity
                {
                    ID = 9,
                    Nom = "API Web",
                    LangageID = 1
                });
            /*Projet*/
            /*Framework - Projet*/
        }
    }
}
