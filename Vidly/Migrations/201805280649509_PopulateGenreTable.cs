namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenreTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres VALUES ('Horror')");
            Sql("INSERT INTO Genres VALUES ('Comedy')");
            Sql("INSERT INTO Genres VALUES ('Thriller')");
            Sql("INSERT INTO Genres VALUES ('Action')");
            Sql("INSERT INTO Genres VALUES ('Romance')");
            Sql("INSERT INTO Genres VALUES ('Family')");
        }
        
        public override void Down()
        {
        }
    }
}
