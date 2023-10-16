using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Academico.Migrations
{
    public partial class cursosdisciplinascursosDisciplinasalunosalunosDisciplinas2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AlunoDisciplina_Alunos_AlunoId",
                table: "AlunoDisciplina");

            migrationBuilder.DropForeignKey(
                name: "FK_AlunoDisciplina_Disciplinas_DisciplinaId",
                table: "AlunoDisciplina");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AlunoDisciplina",
                table: "AlunoDisciplina");

            migrationBuilder.RenameTable(
                name: "AlunoDisciplina",
                newName: "AlunosDisciplinas");

            migrationBuilder.RenameIndex(
                name: "IX_AlunoDisciplina_DisciplinaId",
                table: "AlunosDisciplinas",
                newName: "IX_AlunosDisciplinas_DisciplinaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AlunosDisciplinas",
                table: "AlunosDisciplinas",
                columns: new[] { "AlunoId", "DisciplinaId" });

            migrationBuilder.AddForeignKey(
                name: "FK_AlunosDisciplinas_Alunos_AlunoId",
                table: "AlunosDisciplinas",
                column: "AlunoId",
                principalTable: "Alunos",
                principalColumn: "AlunoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AlunosDisciplinas_Disciplinas_DisciplinaId",
                table: "AlunosDisciplinas",
                column: "DisciplinaId",
                principalTable: "Disciplinas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AlunosDisciplinas_Alunos_AlunoId",
                table: "AlunosDisciplinas");

            migrationBuilder.DropForeignKey(
                name: "FK_AlunosDisciplinas_Disciplinas_DisciplinaId",
                table: "AlunosDisciplinas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AlunosDisciplinas",
                table: "AlunosDisciplinas");

            migrationBuilder.RenameTable(
                name: "AlunosDisciplinas",
                newName: "AlunoDisciplina");

            migrationBuilder.RenameIndex(
                name: "IX_AlunosDisciplinas_DisciplinaId",
                table: "AlunoDisciplina",
                newName: "IX_AlunoDisciplina_DisciplinaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AlunoDisciplina",
                table: "AlunoDisciplina",
                columns: new[] { "AlunoId", "DisciplinaId" });

            migrationBuilder.AddForeignKey(
                name: "FK_AlunoDisciplina_Alunos_AlunoId",
                table: "AlunoDisciplina",
                column: "AlunoId",
                principalTable: "Alunos",
                principalColumn: "AlunoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AlunoDisciplina_Disciplinas_DisciplinaId",
                table: "AlunoDisciplina",
                column: "DisciplinaId",
                principalTable: "Disciplinas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
