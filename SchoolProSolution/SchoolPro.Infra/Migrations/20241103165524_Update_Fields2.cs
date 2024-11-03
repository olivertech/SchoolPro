using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolPro.Infra.Migrations
{
    /// <inheritdoc />
    public partial class Update_Fields2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Teacher_Contact_address_id",
                table: "Teacher");

            migrationBuilder.RenameColumn(
                name: "address_id",
                table: "Teacher",
                newName: "contact_id");

            migrationBuilder.RenameIndex(
                name: "IX_Teacher_address_id",
                table: "Teacher",
                newName: "IX_Teacher_contact_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Teacher_Contact_contact_id",
                table: "Teacher",
                column: "contact_id",
                principalTable: "Contact",
                principalColumn: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Teacher_Contact_contact_id",
                table: "Teacher");

            migrationBuilder.RenameColumn(
                name: "contact_id",
                table: "Teacher",
                newName: "address_id");

            migrationBuilder.RenameIndex(
                name: "IX_Teacher_contact_id",
                table: "Teacher",
                newName: "IX_Teacher_address_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Teacher_Contact_address_id",
                table: "Teacher",
                column: "address_id",
                principalTable: "Contact",
                principalColumn: "id");
        }
    }
}
