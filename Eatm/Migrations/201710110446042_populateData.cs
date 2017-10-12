namespace Eatm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class populateData : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Bankacs (CardNo, PIN, Balance) VALUES(111, 101, 10000) ");
            Sql("INSERT INTO Bankacs (CardNo, PIN, Balance) VALUES(222, 202, 10000) ");
            Sql("INSERT INTO Bankacs (CardNo, PIN, Balance) VALUES(333, 303, 10000) ");
            Sql("INSERT INTO Bankacs (CardNo, PIN, Balance) VALUES(444, 404, 10000) ");
            Sql("INSERT INTO Bankacs (CardNo, PIN, Balance) VALUES(555, 505, 10000) ");
        }
        
        public override void Down()
        {
        }
    }
}
