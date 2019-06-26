using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace System.Entities.Migrations
{
    public partial class AddRelationTableUsuarioWithUsuarioToken : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_UsuarioToken_UsuarioId",
                table: "UsuarioToken",
                column: "UsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_UsuarioToken_Usuario_UsuarioId",
                table: "UsuarioToken",
                column: "UsuarioId",
                principalTable: "Usuario",
                principalColumn: "UsuarioId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UsuarioToken_Usuario_UsuarioId",
                table: "UsuarioToken");

            migrationBuilder.DropIndex(
                name: "IX_UsuarioToken_UsuarioId",
                table: "UsuarioToken");
        }
    }
}
