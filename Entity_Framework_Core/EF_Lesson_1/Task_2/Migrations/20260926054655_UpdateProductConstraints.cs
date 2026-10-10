using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Task_2.Migrations
{
    /// <inheritdoc />
    public partial class UpdateProductConstraints : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // 1. Перейменування колонки первинного ключа: Id -> ProductId
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Products",
                newName: "ProductId");

            // 2. Зміна Name: встановлення обмеження довжини nvarchar(100) та NOT NULL
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Products",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            // 3. Зміна Description: встановлення обмеження довжини nvarchar(250) та NOT NULL
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Products",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            // 4. Зміна Cost: перехід з double (float у SQL) на Money (decimal у C#)
            migrationBuilder.AlterColumn<decimal>(
                name: "Cost",
                table: "Products",
                type: "Money",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            {
                // 1. Повернення Cost: з Money назад у float (double)
                migrationBuilder.AlterColumn<double>(
                    name: "Cost",
                    table: "Products",
                    type: "float",
                    nullable: false,
                    oldClrType: typeof(decimal),
                    oldType: "Money");

                // 2. Повернення Description: назад до nvarchar(max)
                migrationBuilder.AlterColumn<string>(
                    name: "Description",
                    table: "Products",
                    type: "nvarchar(max)",
                    nullable: false,
                    oldClrType: typeof(string),
                    oldType: "nvarchar(250)",
                    oldMaxLength: 250);

                // 3. Повернення Name: назад до nvarchar(max)
                migrationBuilder.AlterColumn<string>(
                    name: "Name",
                    table: "Products",
                    type: "nvarchar(max)",
                    nullable: false,
                    oldClrType: typeof(string),
                    oldType: "nvarchar(100)",
                    oldMaxLength: 100);

                // 4. Повернення старої назви первинного ключа: ProductId -> Id
                migrationBuilder.RenameColumn(
                    name: "ProductId",
                    table: "Products",
                    newName: "Id");
            }
        }
    }
}
