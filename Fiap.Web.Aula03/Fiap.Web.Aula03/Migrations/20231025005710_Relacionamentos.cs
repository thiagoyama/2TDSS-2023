using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Fiap.Web.Aula03.Migrations
{
    /// <inheritdoc />
    public partial class Relacionamentos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EnderecoId",
                table: "Tbl_Paciente",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Medicos",
                columns: table => new
                {
                    MedicoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Crm = table.Column<int>(type: "int", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Salario = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Especialidade = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medicos", x => x.MedicoId);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Endereco",
                columns: table => new
                {
                    EnderecoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Logradouro = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cep = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Endereco", x => x.EnderecoId);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Exame",
                columns: table => new
                {
                    ExameId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Preparo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Data = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PacienteId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Exame", x => x.ExameId);
                    table.ForeignKey(
                        name: "FK_Tbl_Exame_Tbl_Paciente_PacienteId",
                        column: x => x.PacienteId,
                        principalTable: "Tbl_Paciente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Medicamento",
                columns: table => new
                {
                    MedicamentoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Validade = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Laboratorio = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Medicamento", x => x.MedicamentoId);
                });

            migrationBuilder.CreateTable(
                name: "PacientesMedicamentos",
                columns: table => new
                {
                    PacienteId = table.Column<int>(type: "int", nullable: false),
                    MedicamentoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PacientesMedicamentos", x => new { x.PacienteId, x.MedicamentoId });
                    table.ForeignKey(
                        name: "FK_PacientesMedicamentos_Tbl_Medicamento_MedicamentoId",
                        column: x => x.MedicamentoId,
                        principalTable: "Tbl_Medicamento",
                        principalColumn: "MedicamentoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PacientesMedicamentos_Tbl_Paciente_PacienteId",
                        column: x => x.PacienteId,
                        principalTable: "Tbl_Paciente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Paciente_EnderecoId",
                table: "Tbl_Paciente",
                column: "EnderecoId");

            migrationBuilder.CreateIndex(
                name: "IX_PacientesMedicamentos_MedicamentoId",
                table: "PacientesMedicamentos",
                column: "MedicamentoId");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Exame_PacienteId",
                table: "Tbl_Exame",
                column: "PacienteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tbl_Paciente_Tbl_Endereco_EnderecoId",
                table: "Tbl_Paciente",
                column: "EnderecoId",
                principalTable: "Tbl_Endereco",
                principalColumn: "EnderecoId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tbl_Paciente_Tbl_Endereco_EnderecoId",
                table: "Tbl_Paciente");

            migrationBuilder.DropTable(
                name: "Medicos");

            migrationBuilder.DropTable(
                name: "PacientesMedicamentos");

            migrationBuilder.DropTable(
                name: "Tbl_Endereco");

            migrationBuilder.DropTable(
                name: "Tbl_Exame");

            migrationBuilder.DropTable(
                name: "Tbl_Medicamento");

            migrationBuilder.DropIndex(
                name: "IX_Tbl_Paciente_EnderecoId",
                table: "Tbl_Paciente");

            migrationBuilder.DropColumn(
                name: "EnderecoId",
                table: "Tbl_Paciente");
        }
    }
}
