using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolPro.Infra.Migrations
{
    /// <inheritdoc />
    public partial class Update_Fields16 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_School_Calendar_Room_RoomId",
                table: "School_Calendar");

            migrationBuilder.RenameColumn(
                name: "RoomId",
                table: "School_Calendar",
                newName: "room_id");

            migrationBuilder.RenameIndex(
                name: "IX_School_Calendar_RoomId",
                table: "School_Calendar",
                newName: "IX_School_Calendar_room_id");

            migrationBuilder.AddForeignKey(
                name: "FK_School_Calendar_Room_room_id",
                table: "School_Calendar",
                column: "room_id",
                principalTable: "Room",
                principalColumn: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_School_Calendar_Room_room_id",
                table: "School_Calendar");

            migrationBuilder.RenameColumn(
                name: "room_id",
                table: "School_Calendar",
                newName: "RoomId");

            migrationBuilder.RenameIndex(
                name: "IX_School_Calendar_room_id",
                table: "School_Calendar",
                newName: "IX_School_Calendar_RoomId");

            migrationBuilder.AddForeignKey(
                name: "FK_School_Calendar_Room_RoomId",
                table: "School_Calendar",
                column: "RoomId",
                principalTable: "Room",
                principalColumn: "id");
        }
    }
}
