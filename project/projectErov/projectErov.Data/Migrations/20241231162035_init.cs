using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace projectErov.Data.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Place",
                columns: table => new
                {
                    IdInTable = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<int>(type: "int", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    Area = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Place", x => x.IdInTable);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    IdInTable = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id = table.Column<int>(type: "int", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tz = table.Column<string>(type: "nvarchar(9)", maxLength: 9, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Adress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Permission = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.IdInTable);
                });

            migrationBuilder.CreateTable(
                name: "Contribute",
                columns: table => new
                {
                    IdInTable = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sum = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DonorId = table.Column<int>(type: "int", nullable: true),
                    NameForPraying = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumInvoice = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contribute", x => x.IdInTable);
                    table.ForeignKey(
                        name: "FK_Contribute_User_DonorId",
                        column: x => x.DonorId,
                        principalTable: "User",
                        principalColumn: "IdInTable");
                });

            migrationBuilder.CreateTable(
                name: "Erov",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdInTable = table.Column<int>(type: "int", nullable: false),
                    Level = table.Column<int>(type: "int", nullable: true),
                    BorderErov = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    YardErov = table.Column<bool>(type: "bit", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: true),
                    RavId = table.Column<int>(type: "int", nullable: true),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PlaceId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Erov", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Erov_Place_PlaceId",
                        column: x => x.PlaceId,
                        principalTable: "Place",
                        principalColumn: "IdInTable");
                    table.ForeignKey(
                        name: "FK_Erov_User_RavId",
                        column: x => x.RavId,
                        principalTable: "User",
                        principalColumn: "IdInTable");
                });

            migrationBuilder.CreateTable(
                name: "QuestionAnswer",
                columns: table => new
                {
                    IdInTable = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id = table.Column<int>(type: "int", nullable: false),
                    Subject = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Question = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Answer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NameAsker = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AskerId = table.Column<int>(type: "int", nullable: true),
                    RavId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuestionAnswer", x => x.IdInTable);
                    table.ForeignKey(
                        name: "FK_QuestionAnswer_User_AskerId",
                        column: x => x.AskerId,
                        principalTable: "User",
                        principalColumn: "IdInTable");
                    table.ForeignKey(
                        name: "FK_QuestionAnswer_User_RavId",
                        column: x => x.RavId,
                        principalTable: "User",
                        principalColumn: "IdInTable");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Contribute_DonorId",
                table: "Contribute",
                column: "DonorId");

            migrationBuilder.CreateIndex(
                name: "IX_Erov_PlaceId",
                table: "Erov",
                column: "PlaceId");

            migrationBuilder.CreateIndex(
                name: "IX_Erov_RavId",
                table: "Erov",
                column: "RavId");

            migrationBuilder.CreateIndex(
                name: "IX_QuestionAnswer_AskerId",
                table: "QuestionAnswer",
                column: "AskerId");

            migrationBuilder.CreateIndex(
                name: "IX_QuestionAnswer_RavId",
                table: "QuestionAnswer",
                column: "RavId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contribute");

            migrationBuilder.DropTable(
                name: "Erov");

            migrationBuilder.DropTable(
                name: "QuestionAnswer");

            migrationBuilder.DropTable(
                name: "Place");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
