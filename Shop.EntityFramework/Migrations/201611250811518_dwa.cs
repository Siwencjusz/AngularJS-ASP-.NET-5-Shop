namespace Shop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dwa : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Books", "AuthorId", "dbo.Authors");
            DropForeignKey("dbo.Books", "BookTypeId", "dbo.BookTypes");
            DropForeignKey("dbo.Books", "PublisherId", "dbo.Publishers");
            DropIndex("dbo.Books", new[] { "BookTypeId" });
            DropIndex("dbo.Books", new[] { "AuthorId" });
            DropIndex("dbo.Books", new[] { "PublisherId" });
            RenameColumn(table: "dbo.Books", name: "AuthorId", newName: "Author_Id");
            RenameColumn(table: "dbo.Books", name: "BookTypeId", newName: "BookType_Id");
            RenameColumn(table: "dbo.Books", name: "PublisherId", newName: "Publisher_Id");
            AlterColumn("dbo.Books", "BookType_Id", c => c.Int());
            AlterColumn("dbo.Books", "Author_Id", c => c.Int());
            AlterColumn("dbo.Books", "Publisher_Id", c => c.Int());
            CreateIndex("dbo.Books", "Author_Id");
            CreateIndex("dbo.Books", "BookType_Id");
            CreateIndex("dbo.Books", "Publisher_Id");
            AddForeignKey("dbo.Books", "Author_Id", "dbo.Authors", "Id");
            AddForeignKey("dbo.Books", "BookType_Id", "dbo.BookTypes", "Id");
            AddForeignKey("dbo.Books", "Publisher_Id", "dbo.Publishers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Books", "Publisher_Id", "dbo.Publishers");
            DropForeignKey("dbo.Books", "BookType_Id", "dbo.BookTypes");
            DropForeignKey("dbo.Books", "Author_Id", "dbo.Authors");
            DropIndex("dbo.Books", new[] { "Publisher_Id" });
            DropIndex("dbo.Books", new[] { "BookType_Id" });
            DropIndex("dbo.Books", new[] { "Author_Id" });
            AlterColumn("dbo.Books", "Publisher_Id", c => c.Int(nullable: false));
            AlterColumn("dbo.Books", "Author_Id", c => c.Int(nullable: false));
            AlterColumn("dbo.Books", "BookType_Id", c => c.Int(nullable: false));
            RenameColumn(table: "dbo.Books", name: "Publisher_Id", newName: "PublisherId");
            RenameColumn(table: "dbo.Books", name: "BookType_Id", newName: "BookTypeId");
            RenameColumn(table: "dbo.Books", name: "Author_Id", newName: "AuthorId");
            CreateIndex("dbo.Books", "PublisherId");
            CreateIndex("dbo.Books", "AuthorId");
            CreateIndex("dbo.Books", "BookTypeId");
            AddForeignKey("dbo.Books", "PublisherId", "dbo.Publishers", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Books", "BookTypeId", "dbo.BookTypes", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Books", "AuthorId", "dbo.Authors", "Id", cascadeDelete: true);
        }
    }
}
