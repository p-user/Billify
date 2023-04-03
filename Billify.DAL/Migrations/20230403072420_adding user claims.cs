﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Billify.DAL.Migrations
{
    /// <inheritdoc />
    public partial class addinguserclaims : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_user_details_UserId",
                        column: x => x.UserId,
                        principalTable: "user_details",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "user_details",
                keyColumn: "Id",
                keyValue: "1",
                column: "SecurityStamp",
                value: "b99fdab1-c816-4be2-8a16-488069f82eb7");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.UpdateData(
                table: "user_details",
                keyColumn: "Id",
                keyValue: "1",
                column: "SecurityStamp",
                value: "efbcb945-7608-46e2-99dd-c8f0dce4ff03");
        }
    }
}
