using Microsoft.EntityFrameworkCore.Migrations;

namespace I4GUI_Assigment_2.Migrations
{
    public partial class snapshot1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "RoomNumber", "NumberOfAdults", "NumberOfChildren" },
                values: new object[] { 101, 3, 4 });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "RoomNumber", "NumberOfAdults", "NumberOfChildren" },
                values: new object[] { 202, 1, 1 });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "RoomNumber", "NumberOfAdults", "NumberOfChildren" },
                values: new object[] { 303, 2, 2 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomNumber",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomNumber",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomNumber",
                keyValue: 303);
        }
    }
}
