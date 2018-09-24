namespace RestauChoice.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateDatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Comments",
                c => new
                    {
                        CommentId = c.Int(nullable: false, identity: true),
                        DateComment = c.DateTime(nullable: false),
                        Commentaire = c.String(),
                        Evenement_EvenementId = c.Int(),
                        TheUser_VisitorId = c.Int(),
                    })
                .PrimaryKey(t => t.CommentId)
                .ForeignKey("dbo.Evenements", t => t.Evenement_EvenementId)
                .ForeignKey("dbo.Visitors", t => t.TheUser_VisitorId)
                .Index(t => t.Evenement_EvenementId)
                .Index(t => t.TheUser_VisitorId);
            
            CreateTable(
                "dbo.Evenements",
                c => new
                    {
                        EvenementId = c.Int(nullable: false, identity: true),
                        Nom = c.String(),
                        Description = c.String(),
                        TheUser_VisitorId = c.Int(),
                    })
                .PrimaryKey(t => t.EvenementId)
                .ForeignKey("dbo.Visitors", t => t.TheUser_VisitorId)
                .Index(t => t.TheUser_VisitorId);
            
            CreateTable(
                "dbo.Restaurants",
                c => new
                    {
                        RestaurantId = c.Int(nullable: false, identity: true),
                        Nom = c.String(),
                        Adresse = c.String(),
                        Type_TypeId = c.Int(),
                    })
                .PrimaryKey(t => t.RestaurantId)
                .ForeignKey("dbo.Types", t => t.Type_TypeId)
                .Index(t => t.Type_TypeId);
            
            CreateTable(
                "dbo.Types",
                c => new
                    {
                        TypeId = c.Int(nullable: false, identity: true),
                        Nom = c.String(),
                    })
                .PrimaryKey(t => t.TypeId);
            
            CreateTable(
                "dbo.Votes",
                c => new
                    {
                        VoteId = c.Int(nullable: false, identity: true),
                        VoteDate = c.DateTime(nullable: false),
                        Voix = c.Int(nullable: false),
                        Evenement_EvenementId = c.Int(),
                        Restaurant_RestaurantId = c.Int(),
                        TheUser_VisitorId = c.Int(),
                    })
                .PrimaryKey(t => t.VoteId)
                .ForeignKey("dbo.Evenements", t => t.Evenement_EvenementId)
                .ForeignKey("dbo.Restaurants", t => t.Restaurant_RestaurantId)
                .ForeignKey("dbo.Visitors", t => t.TheUser_VisitorId)
                .Index(t => t.Evenement_EvenementId)
                .Index(t => t.Restaurant_RestaurantId)
                .Index(t => t.TheUser_VisitorId);
            
            CreateTable(
                "dbo.Visitors",
                c => new
                    {
                        VisitorId = c.Int(nullable: false, identity: true),
                        Login = c.String(),
                        Mdp = c.String(),
                        TheUserId = c.Int(),
                        Nom = c.String(),
                        Prenom = c.String(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.VisitorId);
            
            CreateTable(
                "dbo.RestaurantEvenements",
                c => new
                    {
                        Restaurant_RestaurantId = c.Int(nullable: false),
                        Evenement_EvenementId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Restaurant_RestaurantId, t.Evenement_EvenementId })
                .ForeignKey("dbo.Restaurants", t => t.Restaurant_RestaurantId, cascadeDelete: true)
                .ForeignKey("dbo.Evenements", t => t.Evenement_EvenementId, cascadeDelete: true)
                .Index(t => t.Restaurant_RestaurantId)
                .Index(t => t.Evenement_EvenementId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Votes", "TheUser_VisitorId", "dbo.Visitors");
            DropForeignKey("dbo.Evenements", "TheUser_VisitorId", "dbo.Visitors");
            DropForeignKey("dbo.Comments", "TheUser_VisitorId", "dbo.Visitors");
            DropForeignKey("dbo.Votes", "Restaurant_RestaurantId", "dbo.Restaurants");
            DropForeignKey("dbo.Votes", "Evenement_EvenementId", "dbo.Evenements");
            DropForeignKey("dbo.Restaurants", "Type_TypeId", "dbo.Types");
            DropForeignKey("dbo.RestaurantEvenements", "Evenement_EvenementId", "dbo.Evenements");
            DropForeignKey("dbo.RestaurantEvenements", "Restaurant_RestaurantId", "dbo.Restaurants");
            DropForeignKey("dbo.Comments", "Evenement_EvenementId", "dbo.Evenements");
            DropIndex("dbo.RestaurantEvenements", new[] { "Evenement_EvenementId" });
            DropIndex("dbo.RestaurantEvenements", new[] { "Restaurant_RestaurantId" });
            DropIndex("dbo.Votes", new[] { "TheUser_VisitorId" });
            DropIndex("dbo.Votes", new[] { "Restaurant_RestaurantId" });
            DropIndex("dbo.Votes", new[] { "Evenement_EvenementId" });
            DropIndex("dbo.Restaurants", new[] { "Type_TypeId" });
            DropIndex("dbo.Evenements", new[] { "TheUser_VisitorId" });
            DropIndex("dbo.Comments", new[] { "TheUser_VisitorId" });
            DropIndex("dbo.Comments", new[] { "Evenement_EvenementId" });
            DropTable("dbo.RestaurantEvenements");
            DropTable("dbo.Visitors");
            DropTable("dbo.Votes");
            DropTable("dbo.Types");
            DropTable("dbo.Restaurants");
            DropTable("dbo.Evenements");
            DropTable("dbo.Comments");
        }
    }
}
