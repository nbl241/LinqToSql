namespace EFCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cours",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nom = c.String(),
                        NumeroSalle = c.String(),
                        EtudiantId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Etudiants", t => t.EtudiantId, cascadeDelete: true)
                .Index(t => t.EtudiantId);
            
            CreateTable(
                "dbo.Etudiants",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CoursID = c.Int(nullable: false),
                        Nom = c.String(),
                        DateNaissance = c.DateTime(nullable: false),
                        Adresse = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Modules",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nom = c.String(),
                        ProfesseurId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Professeurs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ModuleID = c.Int(nullable: false),
                        Nom = c.String(),
                        DateNaissance = c.DateTime(nullable: false),
                        Adresse = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Modules", t => t.Id)
                .Index(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Professeurs", "Id", "dbo.Modules");
            DropForeignKey("dbo.Cours", "EtudiantId", "dbo.Etudiants");
            DropIndex("dbo.Professeurs", new[] { "Id" });
            DropIndex("dbo.Cours", new[] { "EtudiantId" });
            DropTable("dbo.Professeurs");
            DropTable("dbo.Modules");
            DropTable("dbo.Etudiants");
            DropTable("dbo.Cours");
        }
    }
}
