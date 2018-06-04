namespace GigHubChMask2011.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class PopulateGenresTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (Id, Name) VALUES (1, 'Jazz')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (2, 'Rock')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (3, 'Country')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (4, 'Blues')");

            //Jazz, Rock, Country, Blues
        }

        public override void Down()
        {
            Sql("DELETE FROM Genres WHERE Id IN (1, 2, 3, 4)");
        }
    }
}
