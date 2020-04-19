using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace I4GUI_Assigment_2.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "BreakfastReservations",
                nullable: false,
                defaultValue: new DateTime(2020, 4, 19, 13, 41, 4, 748, DateTimeKind.Local).AddTicks(6881),
                oldClrType: typeof(DateTime),
                oldType: "datetime2");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "BreakfastReservations",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 4, 19, 13, 41, 4, 748, DateTimeKind.Local).AddTicks(6881));
        }
    }
}
