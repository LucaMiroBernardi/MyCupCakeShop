namespace CupcakeEntity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FillDatabase : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO dbo.CupcakeModels(Name,Price,DateCreated,DateModified) VALUES ('Fruity Tuity',5.99, '1998-09-13','2000-01-01')");
            Sql("INSERT INTO dbo.CupcakeModels(Name,Price,DateCreated,DateModified) VALUES ('Triple Chocolate',4.99, '2006-06-16','2000-01-01')");
            Sql("INSERT INTO dbo.CupcakeModels(Name,Price,DateCreated,DateModified) VALUES ('Peanut Butter',3.99, '2015-07-20','2000-01-01')");
        }
        
        public override void Down()
        {
        }
    }
}
