﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebTP.Migrations
{
    /// <inheritdoc />
    public partial class AddImageUrlToLivre : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Livres",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Livres");
        }
    }
}
