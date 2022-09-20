using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CuidadoEquino.App.Persistencia.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "IndicadoresdeSalud");

            migrationBuilder.DropColumn(
                name: "IdCaballo",
                table: "IndicadoresdeSalud");

            migrationBuilder.RenameColumn(
                name: "Teléfono",
                table: "Propietarios",
                newName: "Telefono");

            migrationBuilder.RenameColumn(
                name: "Dirección",
                table: "Propietarios",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "Correo",
                table: "Propietarios",
                newName: "Direccion");

            migrationBuilder.RenameColumn(
                name: "Id_veterinario",
                table: "IndicadoresdeSalud",
                newName: "Id_Caballo_Veterinario");

            migrationBuilder.RenameColumn(
                name: "IdCaballo",
                table: "Caballos",
                newName: "Id");

            migrationBuilder.CreateTable(
                name: "AdminVeterinarias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdminVeterinarias", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Caballos_Veterinarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id_Veteinario = table.Column<int>(type: "int", nullable: false),
                    Fecha_asignado = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Id_Caballo = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Caballos_Veterinarios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HistoriasClinicas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdIndicadoresdeSalud = table.Column<int>(type: "int", nullable: false),
                    FechaApertura = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Id_Caballo = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistoriasClinicas", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdminVeterinarias");

            migrationBuilder.DropTable(
                name: "Caballos_Veterinarios");

            migrationBuilder.DropTable(
                name: "HistoriasClinicas");

            migrationBuilder.RenameColumn(
                name: "Telefono",
                table: "Propietarios",
                newName: "Teléfono");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Propietarios",
                newName: "Dirección");

            migrationBuilder.RenameColumn(
                name: "Direccion",
                table: "Propietarios",
                newName: "Correo");

            migrationBuilder.RenameColumn(
                name: "Id_Caballo_Veterinario",
                table: "IndicadoresdeSalud",
                newName: "Id_veterinario");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Caballos",
                newName: "IdCaballo");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "IndicadoresdeSalud",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "IdCaballo",
                table: "IndicadoresdeSalud",
                type: "int",
                nullable: true);
        }
    }
}
