using Microsoft.EntityFrameworkCore.Migrations;

namespace Mission06_murdodav.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "movieinfo",
                columns: table => new
                {
                    MovieID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Category = table.Column<string>(nullable: false),
                    Title = table.Column<string>(nullable: false),
                    Year = table.Column<int>(nullable: false),
                    Director = table.Column<string>(nullable: false),
                    Rating = table.Column<string>(nullable: false),
                    Edited = table.Column<bool>(nullable: false),
                    LentTo = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_movieinfo", x => x.MovieID);
                });

            migrationBuilder.InsertData(
                table: "movieinfo",
                columns: new[] { "MovieID", "Category", "Director", "Edited", "LentTo", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 1, "Action/Adventure", "George Lucas", false, null, "This is the unedited v.", "PG", "Star Wars: A New Hope", 1977 });

            migrationBuilder.InsertData(
                table: "movieinfo",
                columns: new[] { "MovieID", "Category", "Director", "Edited", "LentTo", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 2, "Family", "Chris McKay", false, null, "Lots of fun!", "PG", "LEGO Batman", 2017 });

            migrationBuilder.InsertData(
                table: "movieinfo",
                columns: new[] { "MovieID", "Category", "Director", "Edited", "LentTo", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 3, "Comedy", "Andy Fickman", false, null, "This is a good one!", "PG-13", "She's the Man", 2006 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "movieinfo");
        }
    }
}
