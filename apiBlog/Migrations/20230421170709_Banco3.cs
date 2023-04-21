using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace apiBlog.Migrations
{
    /// <inheritdoc />
    public partial class Banco3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "email",
                table: "Leitor",
                newName: "Email");

            migrationBuilder.AddColumn<string>(
                name: "Senha",
                table: "Leitor",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Senha",
                table: "Leitor");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Leitor",
                newName: "email");
        }
    }
}
