using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GummiBearKingdom.Migrations
{
    public partial class MakePropsCaps : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "name",
                table: "Products",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "countryOfOrigin",
                table: "Products",
                newName: "CountryOfOrigin");

            migrationBuilder.RenameColumn(
                name: "cost",
                table: "Products",
                newName: "Cost");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Products",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "CountryOfOrigin",
                table: "Products",
                newName: "countryOfOrigin");

            migrationBuilder.RenameColumn(
                name: "Cost",
                table: "Products",
                newName: "cost");
        }
    }
}
