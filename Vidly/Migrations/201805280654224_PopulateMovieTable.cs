namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class PopulateMovieTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberInStock, GenreId)VALUES('Thor: Ragnarok', CONVERT(Date, '11-03-2017'), CONVERT(Date, getdate()), 5, 4); ");
            Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberInStock, GenreId)VALUES('Wonder Woman', CONVERT(Date, '06-02-2017'), CONVERT(Date, getdate()), 10, 4); ");
            Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberInStock, GenreId)VALUES('Guardians of the Galaxy Vol. 2', CONVERT(Date, '05-05-2017'), CONVERT(Date, getdate()), 6, 4); ");
            Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberInStock, GenreId)VALUES('Despicable Me 3', CONVERT(Date, '06-30-2017'), CONVERT(Date, getdate()), 12, 2); ");
            Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberInStock, GenreId)VALUES('Smurfs: The Lost Village', CONVERT(Date, '04-07-2017'), CONVERT(Date, getdate()), 2, 2); ");
            Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberInStock, GenreId)VALUES('xXx: Return of Xander Cage', CONVERT(Date, '01-20-2017'), CONVERT(Date, getdate()), 20, 3); ");
        }

        public override void Down()
        {
        }
    }
}
