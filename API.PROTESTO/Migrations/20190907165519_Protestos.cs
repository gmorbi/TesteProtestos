using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace API.PROTESTO.Migrations
{
    public partial class Protestos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Protestos",
                columns: table => new
                {
                    ProtestoID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CodigoBanco = table.Column<string>(nullable: true),
                    CodigoInterno = table.Column<string>(nullable: true),
                    NomeCredor = table.Column<string>(nullable: true),
                    NumeroTitulo = table.Column<string>(nullable: true),
                    Parcela = table.Column<string>(nullable: true),
                    NomeDevedor = table.Column<string>(nullable: true),
                    CPF_CNPJ_Devedor = table.Column<string>(nullable: true),
                    Endereco_Devedor = table.Column<string>(nullable: true),
                    Bairro_Devedor = table.Column<string>(nullable: true),
                    Cidade_Devedor = table.Column<string>(nullable: true),
                    CEP_Devedor = table.Column<string>(nullable: true),
                    UF_Devedor = table.Column<string>(nullable: true),
                    Cidade_Praca_Pagamento = table.Column<string>(nullable: true),
                    UF_Praca_Pagamento = table.Column<string>(nullable: true),
                    ValorTitulo = table.Column<string>(nullable: true),
                    ValorProtestar = table.Column<string>(nullable: true),
                    DataEmissao = table.Column<string>(nullable: true),
                    DataVencimento = table.Column<string>(nullable: true),
                    TipoDocumento = table.Column<string>(nullable: true),
                    Operacao = table.Column<string>(nullable: true),
                    Valor1aParcela = table.Column<string>(nullable: true),
                    QtdeParcelaContrato = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Protestos", x => x.ProtestoID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Protestos");
        }
    }
}
