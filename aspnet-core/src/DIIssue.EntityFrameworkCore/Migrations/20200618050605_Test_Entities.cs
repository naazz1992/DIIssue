using Microsoft.EntityFrameworkCore.Migrations;

namespace DIIssue.Migrations
{
    public partial class Test_Entities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DIIssueEigthEntity",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DIIssueEigthEntity", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DIIssueFifthEntity",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DIIssueFifthEntity", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DIIssueFourthEntity",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DIIssueFourthEntity", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DIIssueNinthEntity",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DIIssueNinthEntity", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DIIssueSecondEntity",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DIIssueSecondEntity", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DIIssueSeventhEntity",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DIIssueSeventhEntity", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DIIssueSixthEntity",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DIIssueSixthEntity", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DIIssueThirdEntity",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DIIssueThirdEntity", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DIIssueEigthEntity");

            migrationBuilder.DropTable(
                name: "DIIssueFifthEntity");

            migrationBuilder.DropTable(
                name: "DIIssueFourthEntity");

            migrationBuilder.DropTable(
                name: "DIIssueNinthEntity");

            migrationBuilder.DropTable(
                name: "DIIssueSecondEntity");

            migrationBuilder.DropTable(
                name: "DIIssueSeventhEntity");

            migrationBuilder.DropTable(
                name: "DIIssueSixthEntity");

            migrationBuilder.DropTable(
                name: "DIIssueThirdEntity");
        }
    }
}
