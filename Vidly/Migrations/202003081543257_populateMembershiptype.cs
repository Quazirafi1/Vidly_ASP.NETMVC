namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class populateMembershiptype : DbMigration
    {
        public override void Up()
        {
            Sql("insert into MembershipTypes (Id, SignUpFee, DurationInMonths,DiscountRate,Name) values(1,0,0,0,'Pay As You Go')");
            Sql("insert into MembershipTypes (Id, SignUpFee, DurationInMonths,DiscountRate,Name) values(2,30,1,10,'Monthly')");
            Sql("insert into MembershipTypes (Id, SignUpFee, DurationInMonths,DiscountRate,Name) values(3,90,3,15,'Quaterly')");
            Sql("insert into MembershipTypes (Id, SignUpFee, DurationInMonths,DiscountRate,Name) values(4,300,12,20,'Yearly')");
        }
        
        public override void Down()
        {
        }
    }
}
