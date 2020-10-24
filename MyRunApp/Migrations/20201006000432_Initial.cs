using Microsoft.EntityFrameworkCore.Migrations;

namespace MyRunApp.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Colors",
                columns: table => new
                {
                    ColorId = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Colors", x => x.ColorId);
                });

            migrationBuilder.CreateTable(
                name: "Shoes",
                columns: table => new
                {
                    ShoeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Brand = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Use = table.Column<string>(nullable: false),
                    Support = table.Column<string>(nullable: false),
                    ColorId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shoes", x => x.ShoeId);
                    table.ForeignKey(
                        name: "FK_Shoes_Colors_ColorId",
                        column: x => x.ColorId,
                        principalTable: "Colors",
                        principalColumn: "ColorId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "ColorId", "Name" },
                values: new object[,]
                {
                    { "B", "Blue" },
                    { "P", "Pink" },
                    { "G", "Green" },
                    { "O", "Orange" },
                    { "Y", "Yellow" },
                    { "M", "Multi" }
                });

            migrationBuilder.InsertData(
                table: "Shoes",
                columns: new[] { "ShoeId", "Brand", "ColorId", "Name", "Support", "Use" },
                values: new object[] { 1, "Brooks", "B", "Ghost 13", "Neutral", "Road Running" });

            migrationBuilder.InsertData(
                table: "Shoes",
                columns: new[] { "ShoeId", "Brand", "ColorId", "Name", "Support", "Use" },
                values: new object[] { 31, "Saucany", "O", "Triumph 17 LE", "Neutral", "Road Running" });

            migrationBuilder.InsertData(
                table: "Shoes",
                columns: new[] { "ShoeId", "Brand", "ColorId", "Name", "Support", "Use" },
                values: new object[] { 2, "Hoka", "M", "Tennine", "Stability", "Trail Running" });

            migrationBuilder.CreateIndex(
                name: "IX_Shoes_ColorId",
                table: "Shoes",
                column: "ColorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Shoes");

            migrationBuilder.DropTable(
                name: "Colors");
        }
    }
}
