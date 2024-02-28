using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SadafBI.Migrations
{
    public partial class SadafBI : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customergroups",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    customerGroupId = table.Column<int>(type: "int", nullable: false),
                    customerGroupName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customergroups", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CustomerStock",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    bourseAccount = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    bQty = table.Column<int>(type: "int", nullable: false),
                    bFee = table.Column<int>(type: "int", nullable: false),
                    bcBasis = table.Column<long>(type: "bigint", nullable: false),
                    bProfit = table.Column<long>(type: "bigint", nullable: false),
                    bDps = table.Column<int>(type: "int", nullable: false),
                    sumRecapQty = table.Column<int>(type: "int", nullable: false),
                    sumIpoQty = table.Column<int>(type: "int", nullable: false),
                    sumCancelIpoQty = table.Column<int>(type: "int", nullable: false),
                    convertToStock = table.Column<int>(type: "int", nullable: false),
                    convertFromRight = table.Column<int>(type: "int", nullable: false),
                    pQty = table.Column<int>(type: "int", nullable: false),
                    pFee = table.Column<int>(type: "int", nullable: false),
                    pcBasis = table.Column<long>(type: "bigint", nullable: false),
                    sQty = table.Column<int>(type: "int", nullable: false),
                    actualProfit = table.Column<long>(type: "bigint", nullable: false),
                    rQty = table.Column<int>(type: "int", nullable: false),
                    sumSalable = table.Column<int>(type: "int", nullable: false),
                    price = table.Column<int>(type: "int", nullable: false),
                    currentValue = table.Column<long>(type: "bigint", nullable: false),
                    potentialProfitWe = table.Column<long>(type: "bigint", nullable: false),
                    totalProfit = table.Column<long>(type: "bigint", nullable: false),
                    pDps = table.Column<int>(type: "int", nullable: false),
                    twrReturn = table.Column<int>(type: "int", nullable: false),
                    bourseAccountName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    insMaxLCode = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerStock", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Domains",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    domainId = table.Column<int>(type: "int", nullable: false),
                    domainName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Domains", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SeparateTransaction",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    isRight = table.Column<int>(type: "int", nullable: false),
                    customerId = table.Column<int>(type: "int", nullable: false),
                    dbsAccountNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    customerFullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    parentCustomerId = table.Column<int>(type: "int", nullable: true),
                    parentCustomerFullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    transactionDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    isAPurchase = table.Column<int>(type: "int", nullable: true),
                    instrumentBourseAccount = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    insMaxLcode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    quantity = table.Column<int>(type: "int", nullable: true),
                    price = table.Column<int>(type: "int", nullable: true),
                    interest = table.Column<int>(type: "int", nullable: true),
                    development = table.Column<int>(type: "int", nullable: true),
                    bourseCo = table.Column<int>(type: "int", nullable: true),
                    bourseOrg = table.Column<int>(type: "int", nullable: true),
                    depositCo = table.Column<int>(type: "int", nullable: true),
                    itManagement = table.Column<int>(type: "int", nullable: true),
                    facility = table.Column<int>(type: "int", nullable: true),
                    tax = table.Column<long>(type: "bigint", nullable: true),
                    branchId = table.Column<int>(type: "int", nullable: true),
                    branchName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    bourseReference = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    bourseAccountText = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    dlNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    isOtc = table.Column<int>(type: "int", nullable: true),
                    postTradeTime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cbranchId = table.Column<int>(type: "int", nullable: true),
                    cbranchName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SeparateTransaction", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    customerId = table.Column<int>(type: "int", nullable: false),
                    nationalCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    companyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    firstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    lastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    fatherName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    phoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    mobileNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    emailAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    dlNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    credit = table.Column<long>(type: "bigint", nullable: false),
                    comexCredit = table.Column<int>(type: "int", nullable: true),
                    sfCredit = table.Column<int>(type: "int", nullable: true),
                    telegramUsername = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    telegramStatusId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    creationDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    branchId = table.Column<int>(type: "int", nullable: false),
                    branchName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    isCompany = table.Column<int>(type: "int", nullable: false),
                    customerIdentity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    birthDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    birthCertificationNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    postalCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    registerationNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    bourseAccountName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    accountNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    onlineUsername = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    hasOnlineAccount = table.Column<int>(type: "int", nullable: false),
                    modificationDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    isMmtpUser = table.Column<int>(type: "int", nullable: false),
                    mmtpUserStatusId = table.Column<int>(type: "int", nullable: true),
                    isSiteUser = table.Column<int>(type: "int", nullable: false),
                    eorderStatusId = table.Column<int>(type: "int", nullable: false),
                    sexTypeId = table.Column<int>(type: "int", nullable: false),
                    sexTypeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    referredBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    hasSignSample = table.Column<bool>(type: "bit", nullable: false),
                    hasCustomerPhoto = table.Column<bool>(type: "bit", nullable: false),
                    hasBirthCertificate = table.Column<bool>(type: "bit", nullable: false),
                    hasCertificateComments = table.Column<bool>(type: "bit", nullable: false),
                    hasZipFile = table.Column<bool>(type: "bit", nullable: false),
                    hasOfficialGazette = table.Column<bool>(type: "bit", nullable: false),
                    hasOfficialAds = table.Column<bool>(type: "bit", nullable: false),
                    comexVisitorId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    mmtpUserId = table.Column<int>(type: "int", nullable: true),
                    comexEconomyAccount = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    isPortfo = table.Column<int>(type: "int", nullable: false),
                    traderCredit = table.Column<int>(type: "int", nullable: true),
                    provinceCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    provinceName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cityId = table.Column<int>(type: "int", nullable: false),
                    cityCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cityName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    bankAccountId = table.Column<int>(type: "int", nullable: true),
                    bankAccountNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    shabaNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    baTypeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    bankName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    isStockCreditPurchase = table.Column<int>(type: "int", nullable: false),
                    isCollateralStocksCustomer = table.Column<int>(type: "int", nullable: true),
                    isProfessionalTrader = table.Column<int>(type: "int", nullable: false),
                    isOtcProfessionalTrader = table.Column<int>(type: "int", nullable: false),
                    comments = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    domain_Id = table.Column<int>(type: "int", nullable: false),
                    customerGroup_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Customers_Customergroups_customerGroup_Id",
                        column: x => x.customerGroup_Id,
                        principalTable: "Customergroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Customers_Domains_domain_Id",
                        column: x => x.domain_Id,
                        principalTable: "Domains",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Customers_customerGroup_Id",
                table: "Customers",
                column: "customerGroup_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_domain_Id",
                table: "Customers",
                column: "domain_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "CustomerStock");

            migrationBuilder.DropTable(
                name: "SeparateTransaction");

            migrationBuilder.DropTable(
                name: "Customergroups");

            migrationBuilder.DropTable(
                name: "Domains");
        }
    }
}
