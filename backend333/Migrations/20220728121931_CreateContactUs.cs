﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace backend333.Migrations
{
    public partial class CreateContactUs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "artist",
                table: "ContactUs",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "producer",
                table: "ContactUs",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "artist",
                table: "ContactUs");

            migrationBuilder.DropColumn(
                name: "producer",
                table: "ContactUs");
        }
    }
}
