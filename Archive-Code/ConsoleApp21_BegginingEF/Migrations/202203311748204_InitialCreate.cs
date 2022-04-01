namespace ConsoleApp21_BegginingEF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "blogSystem.tblBlog",
                c => new
                    {
                        BlogName = c.String(nullable: false, maxLength: 50),
                        MyBlogIdentity = c.Int(nullable: false, identity: true),
                        Author01_Id = c.Int(),
                    })
                .PrimaryKey(t => t.MyBlogIdentity)
                .ForeignKey("dbo.Authors", t => t.Author01_Id)
                .Index(t => t.Author01_Id);
            
            CreateTable(
                "dbo.Authors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(maxLength: 50),
                        LastName = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Posts",
                c => new
                    {
                        PostId = c.Int(nullable: false, identity: true),
                        Title = c.String(maxLength: 50),
                        Date = c.DateTime(nullable: false),
                        BlogId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PostId)
                .ForeignKey("blogSystem.tblBlog", t => t.BlogId, cascadeDelete: true)
                .Index(t => t.BlogId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Posts", "BlogId", "blogSystem.tblBlog");
            DropForeignKey("blogSystem.tblBlog", "Author01_Id", "dbo.Authors");
            DropIndex("dbo.Posts", new[] { "BlogId" });
            DropIndex("blogSystem.tblBlog", new[] { "Author01_Id" });
            DropTable("dbo.Posts");
            DropTable("dbo.Authors");
            DropTable("blogSystem.tblBlog");
        }
    }
}
