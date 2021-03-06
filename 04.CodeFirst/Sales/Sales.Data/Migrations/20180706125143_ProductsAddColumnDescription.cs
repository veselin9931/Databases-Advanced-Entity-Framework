﻿namespace P03_SalesDatabase.Data.Migrations
{
    using Microsoft.EntityFrameworkCore.Migrations;

    public partial class ProductsAddColumnDescription : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                "Description",
                "Products",
                maxLength: 250,
                nullable: false,
                defaultValue: "No description");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                "Description",
                "Products");
        }
    }
}