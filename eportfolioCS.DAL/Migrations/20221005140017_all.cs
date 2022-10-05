using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eportfolioCS.DAL.Migrations
{
    public partial class all : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categorie",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ParentID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorie", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Categorie_Categorie_ParentID",
                        column: x => x.ParentID,
                        principalTable: "Categorie",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Etablissement",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pays = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Province = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ville = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CodePostal = table.Column<int>(type: "int", nullable: false),
                    Adresse = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SiteWeb = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Etablissement", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Texte",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Contenu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Position = table.Column<int>(type: "int", nullable: true),
                    PieceJointe = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TextePrecedentID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Texte", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Texte_Texte_TextePrecedentID",
                        column: x => x.TextePrecedentID,
                        principalTable: "Texte",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Experience",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    date_debut = table.Column<DateTime>(type: "DateTime2", nullable: false),
                    date_fin = table.Column<DateTime>(type: "DateTime2", nullable: true),
                    FirmeID = table.Column<int>(type: "int", nullable: false),
                    CategorieID = table.Column<int>(type: "int", nullable: false),
                    ParentID = table.Column<int>(type: "int", nullable: true),
                    TexteID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Experience", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Experience_Categorie_CategorieID",
                        column: x => x.CategorieID,
                        principalTable: "Categorie",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Experience_Etablissement_FirmeID",
                        column: x => x.FirmeID,
                        principalTable: "Etablissement",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Experience_Experience_ParentID",
                        column: x => x.ParentID,
                        principalTable: "Experience",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Experience_Texte_TexteID",
                        column: x => x.TexteID,
                        principalTable: "Texte",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "IDE",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TexteID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IDE", x => x.ID);
                    table.ForeignKey(
                        name: "FK_IDE_Texte_TexteID",
                        column: x => x.TexteID,
                        principalTable: "Texte",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Langage",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    annee_creation = table.Column<DateTime>(type: "DateTime2", nullable: false),
                    TexteID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Langage", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Langage_Texte_TexteID",
                        column: x => x.TexteID,
                        principalTable: "Texte",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "SGBD",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TexteID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SGBD", x => x.ID);
                    table.ForeignKey(
                        name: "FK_SGBD_Texte_TexteID",
                        column: x => x.TexteID,
                        principalTable: "Texte",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Type_Projet",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TexteID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Type_Projet", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Type_Projet_Texte_TexteID",
                        column: x => x.TexteID,
                        principalTable: "Texte",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Framework",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ParentID = table.Column<int>(type: "int", nullable: true),
                    LangageID = table.Column<int>(type: "int", nullable: true),
                    TexteID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Framework", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Framework_Framework_ParentID",
                        column: x => x.ParentID,
                        principalTable: "Framework",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Framework_Langage_LangageID",
                        column: x => x.LangageID,
                        principalTable: "Langage",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Framework_Texte_TexteID",
                        column: x => x.TexteID,
                        principalTable: "Texte",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Projet",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    date_debut = table.Column<DateTime>(type: "DateTime2", nullable: false),
                    date_fin = table.Column<DateTime>(type: "DateTime2", nullable: true),
                    URL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GitURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TypeProjetID = table.Column<int>(type: "int", nullable: false),
                    ExperienceID = table.Column<int>(type: "int", nullable: true),
                    TexteID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projet", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Projet_Experience_ExperienceID",
                        column: x => x.ExperienceID,
                        principalTable: "Experience",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Projet_Texte_TexteID",
                        column: x => x.TexteID,
                        principalTable: "Texte",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Projet_Type_Projet_TypeProjetID",
                        column: x => x.TypeProjetID,
                        principalTable: "Type_Projet",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "framework_projet",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VersionIDE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VersionFramework = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProjetID = table.Column<int>(type: "int", nullable: false),
                    IdeID = table.Column<int>(type: "int", nullable: false),
                    SgbdID = table.Column<int>(type: "int", nullable: true),
                    FrameworkID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_framework_projet", x => x.ID);
                    table.ForeignKey(
                        name: "FK_framework_projet_Framework_FrameworkID",
                        column: x => x.FrameworkID,
                        principalTable: "Framework",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_framework_projet_IDE_IdeID",
                        column: x => x.IdeID,
                        principalTable: "IDE",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_framework_projet_Projet_ProjetID",
                        column: x => x.ProjetID,
                        principalTable: "Projet",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_framework_projet_SGBD_SgbdID",
                        column: x => x.SgbdID,
                        principalTable: "SGBD",
                        principalColumn: "ID");
                });

            migrationBuilder.InsertData(
                table: "Categorie",
                columns: new[] { "ID", "Nom", "ParentID" },
                values: new object[,]
                {
                    { 1, "Expériences professionnelles", null },
                    { 2, "Études et formations", null },
                    { 4, "Études", null }
                });

            migrationBuilder.InsertData(
                table: "Etablissement",
                columns: new[] { "ID", "Adresse", "CodePostal", "Description", "Nom", "Pays", "Province", "SiteWeb", "Ville" },
                values: new object[,]
                {
                    { 1, "Avenue Jean Mermoz 18", 6041, "Centre de compétences", "TechnofuturTIC", "Belgique", "Hainaut", "www.technofuturtic.be", "Gosselies" },
                    { 2, null, 4000, "Haute École Libre Mosane", "HELMo", "Belgique", "Liège", "www.helmo.be", "Liège" }
                });

            migrationBuilder.InsertData(
                table: "IDE",
                columns: new[] { "ID", "Nom", "TexteID" },
                values: new object[] { 1, "Visual Studio", null });

            migrationBuilder.InsertData(
                table: "Langage",
                columns: new[] { "ID", "annee_creation", "Nom", "TexteID" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(2001), "C#", null },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1991), "HTML", null },
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1996), "Java", null },
                    { 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1995), "JavaScript", null },
                    { 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1986), "SQL", null },
                    { 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1994), "PHP", null },
                    { 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1994), "CSS", null }
                });

            migrationBuilder.InsertData(
                table: "SGBD",
                columns: new[] { "ID", "Nom", "TexteID" },
                values: new object[,]
                {
                    { 1, "SQL Server", null },
                    { 2, "Oracle", null },
                    { 3, "MySQL", null }
                });

            migrationBuilder.InsertData(
                table: "Type_Projet",
                columns: new[] { "ID", "Nom", "TexteID" },
                values: new object[,]
                {
                    { 1, "Logiciel Desktop", null },
                    { 2, "Site Web", null },
                    { 3, "API Web", null },
                    { 4, "App Mobile", null }
                });

            migrationBuilder.InsertData(
                table: "Categorie",
                columns: new[] { "ID", "Nom", "ParentID" },
                values: new object[,]
                {
                    { 3, "Stages", 1 },
                    { 5, "Formations", 2 }
                });

            migrationBuilder.InsertData(
                table: "Experience",
                columns: new[] { "ID", "CategorieID", "date_debut", "date_fin", "FirmeID", "ParentID", "TexteID", "Titre" },
                values: new object[,]
                {
                    { 3, 4, new DateTime(2016, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, null, null, "Bachelier en informatique de gestion" },
                    { 4, 4, new DateTime(2008, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2011, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, null, null, "Bachelier en informatique de gestion" }
                });

            migrationBuilder.InsertData(
                table: "Framework",
                columns: new[] { "ID", "LangageID", "Nom", "ParentID", "TexteID" },
                values: new object[,]
                {
                    { 1, 1, "Pas de Framework", null, null },
                    { 2, 2, "Pas de Framework", null, null },
                    { 3, 3, "Pas de Framework", null, null },
                    { 4, 4, "Pas de Framework", null, null },
                    { 5, 5, "Pas de Framework", null, null },
                    { 6, 6, "Pas de Framework", null, null },
                    { 7, 7, "Pas de Framework", null, null },
                    { 8, 1, "ASP.NET", null, null },
                    { 9, 1, "API Web", null, null }
                });

            migrationBuilder.InsertData(
                table: "Experience",
                columns: new[] { "ID", "CategorieID", "date_debut", "date_fin", "FirmeID", "ParentID", "TexteID", "Titre" },
                values: new object[] { 1, 5, new DateTime(2022, 9, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, null, "Développeur Web orienté Data Analysis" });

            migrationBuilder.InsertData(
                table: "Experience",
                columns: new[] { "ID", "CategorieID", "date_debut", "date_fin", "FirmeID", "ParentID", "TexteID", "Titre" },
                values: new object[] { 2, 5, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, null, "Développeur .NET, BI & Sharepoint" });

            migrationBuilder.CreateIndex(
                name: "IX_Categorie_ParentID",
                table: "Categorie",
                column: "ParentID",
                unique: true,
                filter: "[ParentID] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Experience_CategorieID",
                table: "Experience",
                column: "CategorieID");

            migrationBuilder.CreateIndex(
                name: "IX_Experience_FirmeID",
                table: "Experience",
                column: "FirmeID");

            migrationBuilder.CreateIndex(
                name: "IX_Experience_ParentID",
                table: "Experience",
                column: "ParentID",
                unique: true,
                filter: "[ParentID] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Experience_TexteID",
                table: "Experience",
                column: "TexteID");

            migrationBuilder.CreateIndex(
                name: "IX_Framework_LangageID",
                table: "Framework",
                column: "LangageID");

            migrationBuilder.CreateIndex(
                name: "IX_Framework_ParentID",
                table: "Framework",
                column: "ParentID",
                unique: true,
                filter: "[ParentID] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Framework_TexteID",
                table: "Framework",
                column: "TexteID");

            migrationBuilder.CreateIndex(
                name: "IX_framework_projet_FrameworkID",
                table: "framework_projet",
                column: "FrameworkID");

            migrationBuilder.CreateIndex(
                name: "IX_framework_projet_IdeID",
                table: "framework_projet",
                column: "IdeID");

            migrationBuilder.CreateIndex(
                name: "IX_framework_projet_ProjetID",
                table: "framework_projet",
                column: "ProjetID");

            migrationBuilder.CreateIndex(
                name: "IX_framework_projet_SgbdID",
                table: "framework_projet",
                column: "SgbdID");

            migrationBuilder.CreateIndex(
                name: "IX_IDE_TexteID",
                table: "IDE",
                column: "TexteID");

            migrationBuilder.CreateIndex(
                name: "IX_Langage_TexteID",
                table: "Langage",
                column: "TexteID");

            migrationBuilder.CreateIndex(
                name: "IX_Projet_ExperienceID",
                table: "Projet",
                column: "ExperienceID");

            migrationBuilder.CreateIndex(
                name: "IX_Projet_TexteID",
                table: "Projet",
                column: "TexteID");

            migrationBuilder.CreateIndex(
                name: "IX_Projet_TypeProjetID",
                table: "Projet",
                column: "TypeProjetID");

            migrationBuilder.CreateIndex(
                name: "IX_SGBD_TexteID",
                table: "SGBD",
                column: "TexteID");

            migrationBuilder.CreateIndex(
                name: "IX_Texte_TextePrecedentID",
                table: "Texte",
                column: "TextePrecedentID",
                unique: true,
                filter: "[TextePrecedentID] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Type_Projet_TexteID",
                table: "Type_Projet",
                column: "TexteID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "framework_projet");

            migrationBuilder.DropTable(
                name: "Framework");

            migrationBuilder.DropTable(
                name: "IDE");

            migrationBuilder.DropTable(
                name: "Projet");

            migrationBuilder.DropTable(
                name: "SGBD");

            migrationBuilder.DropTable(
                name: "Langage");

            migrationBuilder.DropTable(
                name: "Experience");

            migrationBuilder.DropTable(
                name: "Type_Projet");

            migrationBuilder.DropTable(
                name: "Categorie");

            migrationBuilder.DropTable(
                name: "Etablissement");

            migrationBuilder.DropTable(
                name: "Texte");
        }
    }
}
