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
            builder.Entity<TexteEntity>()
                .HasData(new TexteEntity { 
                    ID = 1, 
                    Contenu = "Site en construction"
                });
            builder.Entity<TexteEntity>()
                .HasData(new TexteEntity
                {
                    ID = 2,
                    Contenu = "C# est un langage de programmation orientée objet, fortement typé, dérivé de C et de C++, ressemblant au langage Java3. " +
                    "Il est utilisé pour développer des applications web, ainsi que des applications de bureau, des services web, des commandes, des widgets ou des bibliothèques de classes. " +
                    "En C#, une application est un lot de classes où une des classes comporte une méthode Main, comme cela se fait en Java." +
                    "C# est destiné à développer sur la plateforme .NET, une pile technologique créée par Microsoft pour succéder à COM." +
                    "Les exécutables en C# sont subdivisés en assemblies, en namespaces, en classes et en membres de classe. " +
                    "Un assembly est la forme compilée, qui peut être un programme (un exécutable) ou une bibliothèque de classes (une dll). " +
                    "Un assembly contient le code exécutable en MSIL, ainsi que les symboles. " +
                    "Le code MSIL est traduit en langage machine au moment de l'exécution par la fonction just-in-time de la plateforme .NET. " +
                    "(Source: Wikipédia)"
                });
            builder.Entity<TexteEntity>()
                .HasData(new TexteEntity
                {
                    ID = 3,
                    Contenu = "Le HyperText Markup Language, généralement abrégé HTML ou, dans sa dernière version, HTML5, est le langage de balisage conçu pour représenter les pages web. " +
                    "Ce langage permet d’écrire de l’hypertexte (d’où son nom), de structurer sémantiquement une page web, de mettre en forme du contenu, de créer des formulaires de saisie ou encore d’inclure des ressources multimédias dont des images, des vidéos, et des programmes informatiques. " +
                    "L'HTML offre également la possibilité de créer des documents interopérables avec des équipements très variés et conformément aux exigences de l’accessibilité du web. " +
                    "Il est souvent utilisé conjointement avec le langage de programmation JavaScript et des feuilles de style en cascade (CSS). " +
                    "HTML est inspiré du Standard Generalized Markup Language (SGML). " +
                    "Il s'agit d'un format ouvert." +
                    "(Source: Wikipédia)"
                });
            builder.Entity<TexteEntity>()
                .HasData(new TexteEntity
                {
                    ID = 4,
                    Contenu = "Java est un langage de programmation orienté objet créé par James Gosling et Patrick Naughton, employés de Sun Microsystems, avec le soutien de Bill Joy (cofondateur de Sun Microsystems en 1982), présenté officiellement le 23 mai 1995 au .SunWorld." +
                    "La société Sun a été ensuite rachetée en 2009 par la société Oracle qui détient et maintient désormais Java. " +
                    "Une particularité de Java est que les logiciels écrits dans ce langage sont compilés vers une représentation binaire intermédiaire qui peut être exécutée dans une machine virtuelle Java (JVM) en faisant abstraction du système d'exploitation. " +
                    "(Source: Wikipédia)"
                });
            builder.Entity<TexteEntity>()
                .HasData(new TexteEntity
                {
                    ID = 5,
                    Contenu = "JavaScript est un langage de programmation de scripts principalement employé dans les pages web interactives et à ce titre est une partie essentielle des applications web. " +
                    "Avec les langages HTML et CSS, JavaScript est au cœur des langages utilisés par les développeurs web. " +
                    "Une grande majorité des sites web l'utilisent, et la majorité des navigateurs web disposent d'un moteur JavaScript pour l'interpréter. " +
                    "JavaScript est aussi employé pour les serveurs Web avec l'utilisation (par exemple) de Node.js ou de Deno. " +
                    "JavaScript a été créé en 1995 par Brendan Eich et intégré au navigateur web Netscape Navigator 2.0. " +
                    "L'implémentation concurrente de JavaScript par Microsoft dans Internet Explorer jusqu'à sa version 9 se nommait JScript, tandis que celle d'Adobe Systems se nommait ActionScript. " +
                    "JavaScript a été standardisé sous le nom d'ECMAScript en juin 1997 par Ecma International dans le standard ECMA-262. " +
                    "La version en vigueur de ce standard depuis juin 2022 est la 13e édition. " +
                    "C'est un langage orienté objet à prototype : les bases du langage et ses principales interfaces sont fournies par des objets. " +
                    "Cependant, à la différence d'un langage orienté objets, les objets de base ne sont pas des instances de classes. " +
                    "En outre, les fonctions sont des objets de première classe. " +
                    "Le langage supporte le paradigme objet, impératif et fonctionnel. " +
                    "JavaScript est le langage possédant le plus large écosystème grâce à son gestionnaire de dépendances npm, avec environ 500 000 paquets en août 2017. " +
                    "(Source : Wikipédia)"
                });
            builder.Entity<TexteEntity>()
                .HasData(new TexteEntity
                {
                    ID = 6,
                    Contenu = "SQL (sigle de Structured Query Language, en français langage de requête structurée) est un langage informatique normalisé servant à exploiter des bases de données relationnelles. " +
                    "La partie langage de manipulation des données de SQL permet de rechercher, d'ajouter, de modifier ou de supprimer des données dans les bases de données relationnelles." +
                    "Outre le langage de manipulation des données : " +
                    "- le langage de définition des données permet de créer et de modifier l'organisation des données dans la base de données," +
                    "- le langage de contrôle de transaction permet de commencer et de terminer des transactions," +
                    "- le langage de contrôle des données permet d'autoriser ou d'interdire l'accès à certaines données à certaines personnes. " +
                    "Créé en 1974, normalisé depuis 1986, le langage est reconnu par la grande majorité des systèmes de gestion de bases de données relationnelles (abrégé SGBDR) du marché. " +
                    "SQL fait partie de la même famille que les langages ALPHA (dont il est le descendant), SQUARE, QUEL (intégré à Ingres) ou QBE (Zloof). " +
                    "Il a été appelé SEQUEL à sa naissance, mais ce nom a été changé en SQL du fait que SEQUEL était une marque déposée de l'avionneur Hawker-Siddeley. " +
                    "(Source: Wikipédia)"
                });
            builder.Entity<TexteEntity>()
                .HasData(new TexteEntity
                {
                    ID = 7,
                    Contenu = "PHP: Hypertext Preprocessor, plus connu sous son sigle PHP (sigle auto-référentiel), est un langage de programmation libre, principalement utilisé pour produire des pages Web dynamiques via un serveur HTTP, mais pouvant également fonctionner comme n'importe quel langage interprété de façon locale. " +
                    "PHP est un langage impératif orienté objet. " +
                    "PHP a permis de créer un grand nombre de sites web célèbres, comme Facebook et Wikipédia. " +
                    "Il est considéré comme une des bases de la création de sites web dits dynamiques mais également des applications web. " +
                    "(Source: Wikipédia)"
                });
            builder.Entity<TexteEntity>()
                .HasData(new TexteEntity
                {
                    ID = 8,
                    Contenu = "Les feuilles de style en cascade, généralement appelées CSS de l'anglais Cascading Style Sheets, forment un langage informatique qui décrit la présentation des documents HTML et XML. " +
                    "Les standards définissant CSS sont publiés par le World Wide Web Consortium (W3C). " +
                    "Introduit au milieu des années 1990, CSS devient couramment utilisé dans la conception de sites web et bien pris en charge par les navigateurs web dans les années 2000. " +
                    "(Source: Wikipédia)"
                });

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
                    DateDebut = new DateTime(2022,9,6),
                    TexteID = 1
                });
            builder.Entity<ExperienceEntity>()
                .HasData(new ExperienceEntity
                {
                    ID = 2,
                    CategorieID = 5,
                    FirmeID = 1,
                    Titre = "Développeur .NET, BI & Sharepoint",
                    DateDebut = new DateTime(2021, 3, 22),
                    DateFin = new DateTime(2021, 9, 7),
                    TexteID = 1
                });
            builder.Entity<ExperienceEntity>()
                .HasData(new ExperienceEntity
                {
                    ID = 3,
                    CategorieID = 4,
                    FirmeID = 2,
                    Titre = "Bachelier en informatique de gestion",
                    DateDebut = new DateTime(2016, 9, 15),
                    DateFin = new DateTime(2019, 9, 14),
                    TexteID = 1
                });
            builder.Entity<ExperienceEntity>()
                .HasData(new ExperienceEntity
                {
                    ID = 4,
                    CategorieID = 4,
                    FirmeID = 2,
                    Titre = "Bachelier en informatique de gestion",
                    DateDebut = new DateTime(2008, 9, 15),
                    DateFin = new DateTime(2011, 1, 7),
                    TexteID = 1
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
                    AnneeCreation = new DateTime(2001),
                    TexteID = 2, 
                    ImageUrl = "https://cdn.icon-icons.com/icons2/2415/PNG/512/csharp_original_logo_icon_146578.png"
                });
            builder.Entity<LangageEntity>()
                .HasData(new LangageEntity
                {
                    ID = 2,
                    Nom = "HTML",
                    AnneeCreation = new DateTime(1991),
                    TexteID = 3, 
                    ImageUrl = "https://cdn.icon-icons.com/icons2/2415/PNG/512/html_original_wordmark_logo_icon_146478.png"
                });
            builder.Entity<LangageEntity>()
                .HasData(new LangageEntity
                {
                    ID = 3,
                    Nom = "Java",
                    AnneeCreation = new DateTime(1996), 
                    TexteID = 4, 
                    ImageUrl = "https://cdn.icon-icons.com/icons2/2415/PNG/512/java_original_wordmark_logo_icon_146459.png"
                });
            builder.Entity<LangageEntity>()
                .HasData(new LangageEntity
                {
                    ID = 4,
                    Nom = "JavaScript",
                    AnneeCreation = new DateTime(1995), 
                    TexteID = 5, 
                    ImageUrl = "https://cdn.icon-icons.com/icons2/2415/PNG/512/javascript_original_logo_icon_146455.png"
                });
            builder.Entity<LangageEntity>()
                .HasData(new LangageEntity
                {
                    ID = 5,
                    Nom = "SQL",
                    AnneeCreation = new DateTime(1986), 
                    TexteID = 6
                });
            builder.Entity<LangageEntity>()
                .HasData(new LangageEntity
                {
                    ID = 6,
                    Nom = "PHP",
                    AnneeCreation = new DateTime(1994), 
                    TexteID = 7,
                    ImageUrl = "https://cdn.icon-icons.com/icons2/2415/PNG/512/php_plain_logo_icon_146397.png"
                });
            builder.Entity<LangageEntity>()
                .HasData(new LangageEntity
                {
                    ID = 7,
                    Nom = "CSS",
                    AnneeCreation = new DateTime(1994), 
                    TexteID = 8, 
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/d/d5/CSS3_logo_and_wordmark.svg/1200px-CSS3_logo_and_wordmark.svg.png"
                });
            /*Framework*/
            builder.Entity<FrameworkEntity>()
                .HasData(new FrameworkEntity
                {
                    ID = 1,
                    Nom = "Pas de Framework",
                    LangageID = 1, 
                    ImageURL = "https://external-preview.redd.it/SbIe2vXwIG0o2Psj4xdCtTiPE2X9L4YGr5gRRrV2EaQ.jpg?auto=webp&s=d79f489b605f7586a14882ee59667f81474a1319"
                });
            builder.Entity<FrameworkEntity>()
                .HasData(new FrameworkEntity
                {
                    ID = 2,
                    Nom = "Pas de Framework",
                    LangageID = 2,
                    ImageURL = "https://external-preview.redd.it/SbIe2vXwIG0o2Psj4xdCtTiPE2X9L4YGr5gRRrV2EaQ.jpg?auto=webp&s=d79f489b605f7586a14882ee59667f81474a1319"
                });
            builder.Entity<FrameworkEntity>()
                .HasData(new FrameworkEntity
                {
                    ID = 3,
                    Nom = "Pas de Framework",
                    LangageID = 3,
                    ImageURL = "https://external-preview.redd.it/SbIe2vXwIG0o2Psj4xdCtTiPE2X9L4YGr5gRRrV2EaQ.jpg?auto=webp&s=d79f489b605f7586a14882ee59667f81474a1319"
                });
            builder.Entity<FrameworkEntity>()
                .HasData(new FrameworkEntity
                {
                    ID = 4,
                    Nom = "Pas de Framework",
                    LangageID = 4,
                    ImageURL = "https://external-preview.redd.it/SbIe2vXwIG0o2Psj4xdCtTiPE2X9L4YGr5gRRrV2EaQ.jpg?auto=webp&s=d79f489b605f7586a14882ee59667f81474a1319"
                });
            builder.Entity<FrameworkEntity>()
                .HasData(new FrameworkEntity
                {
                    ID = 5,
                    Nom = "Pas de Framework",
                    LangageID = 5,
                    ImageURL = "https://external-preview.redd.it/SbIe2vXwIG0o2Psj4xdCtTiPE2X9L4YGr5gRRrV2EaQ.jpg?auto=webp&s=d79f489b605f7586a14882ee59667f81474a1319"
                });
            builder.Entity<FrameworkEntity>()
                .HasData(new FrameworkEntity
                {
                    ID = 6,
                    Nom = "Pas de Framework",
                    LangageID = 6,
                    ImageURL = "https://external-preview.redd.it/SbIe2vXwIG0o2Psj4xdCtTiPE2X9L4YGr5gRRrV2EaQ.jpg?auto=webp&s=d79f489b605f7586a14882ee59667f81474a1319"
                });
            builder.Entity<FrameworkEntity>()
                .HasData(new FrameworkEntity
                {
                    ID = 7,
                    Nom = "Pas de Framework",
                    LangageID = 7,
                    ImageURL = "https://external-preview.redd.it/SbIe2vXwIG0o2Psj4xdCtTiPE2X9L4YGr5gRRrV2EaQ.jpg?auto=webp&s=d79f489b605f7586a14882ee59667f81474a1319"
                });
            builder.Entity<FrameworkEntity>()
                .HasData(new FrameworkEntity
                {
                    ID = 8,
                    Nom = "ASP.NET",
                    LangageID = 1, 
                    ImageURL = "https://blog.soat.fr/wp-content/uploads/2015/11/asp.net_.jpg"
                });
            builder.Entity<FrameworkEntity>()
                .HasData(new FrameworkEntity
                {
                    ID = 9,
                    Nom = "API Web",
                    LangageID = 1, 
                    ImageURL = "https://www.hbbh.co.uk/Content/assets/development/webapi.png"
                });
            builder.Entity<FrameworkEntity>()
                .HasData(new FrameworkEntity
                {
                    ID = 10,
                    Nom = "ASP.NET MVC",
                    LangageID = 1, 
                    ParentID = 8,
                    ImageURL = "https://blog.tech-fellow.net/content/images/2019/04/asp-net-mvc-1-.jpg"
                });
            /*Projet*/
            /*Framework - Projet*/
        }
    }
}
