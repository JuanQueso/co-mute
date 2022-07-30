namespace CoMute.Web.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using CoMute.Web.Models.Dto;

    internal sealed class Configuration : DbMigrationsConfiguration<RegistrationRequest>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(RegistrationRequest context)
        {
        }
    }
}
