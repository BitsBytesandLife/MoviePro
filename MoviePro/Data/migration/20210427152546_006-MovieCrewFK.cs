using Microsoft.EntityFrameworkCore.Migrations;

namespace MoviePro.data.migration
{
    public partial class _006MovieCrewFK : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Crew_MovieId",
                table: "Crew",
                column: "MovieId");

            migrationBuilder.AddForeignKey(
                name: "FK_Crew_Movie_MovieId",
                table: "Crew",
                column: "MovieId",
                principalTable: "Movie",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Crew_Movie_MovieId",
                table: "Crew");

            migrationBuilder.DropIndex(
                name: "IX_Crew_MovieId",
                table: "Crew");
        }
    }
}
