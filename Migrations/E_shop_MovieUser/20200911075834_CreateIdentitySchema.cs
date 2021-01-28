using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace E_shop_Movie.Migrations.E_shop_MovieUser
{
    public partial class CreateIdentitySchema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");
<DirectedGraph xmlns="http://schemas.microsoft.com/vs/2009/dgml">
  <Nodes>
    <Node Id="(@1 Namespace=E_shop_Movie.Migrations.E_shop_MovieUser Type=CreateIdentitySchema Member=(Name=BuildTargetModel OverloadingParameters=[(@2 Namespace=Microsoft.EntityFrameworkCore Type=ModelBuilder)]))" Category="CodeSchema_Method" CodeSchemaProperty_IsProtected="True" CommonLabel="BuildTargetModel" Icon="Microsoft.VisualStudio.Method.Protected" IsDragSource="True" IsOverloaded="True" Label="BuildTargetModel(ModelBuilder) : void" SourceLocation="(Assembly=&quot;file:///C:/Users/admin/Desktop/.Net/E-shop Movie/Migrations/E_shop_MovieUser/20200911075834_CreateIdentitySchema.Designer.cs&quot; StartLineNumber=15 StartCharacterOffset=32 EndLineNumber=15 EndCharacterOffset=48)" />
    <Node Id="(@1 Namespace=E_shop_Movie.Migrations.E_shop_MovieUser Type=CreateIdentitySchema)" Visibility="Hidden" />
  </Nodes>
  <Links>
    <Link Source="(@1 Namespace=E_shop_Movie.Migrations.E_shop_MovieUser Type=CreateIdentitySchema)" Target="(@1 Namespace=E_shop_Movie.Migrations.E_shop_MovieUser Type=CreateIdentitySchema Member=(Name=BuildTargetModel OverloadingParameters=[(@2 Namespace=Microsoft.EntityFrameworkCore Type=ModelBuilder)]))" Category="Contains" />
  </Links>
  <Categories>
    <Category Id="CodeSchema_Member" Label="Member" Icon="CodeSchema_Field" />
    <Category Id="CodeSchema_Method" Label="Method" BasedOn="CodeSchema_Member" Icon="CodeSchema_Method" />
    <Category Id="Contains" Label="Contains" Description="Whether the source of the link contains the target object" IsContainment="True" />
  </Categories>
  <Properties>
    <Property Id="CodeSchemaProperty_IsProtected" Label="Is Protected" Description="Flag to indicate the scope is Protected" DataType="System.Boolean" />
    <Property Id="CommonLabel" DataType="System.String" />
    <Property Id="Icon" Label="Icon" DataType="System.String" />
    <Property Id="IsContainment" DataType="System.Boolean" />
    <Property Id="IsDragSource" Label="IsDragSource" Description="IsDragSource" DataType="System.Boolean" />
    <Property Id="IsOverloaded" Label="IsOverloaded" Description="IsOverloaded" DataType="System.Boolean" />
    <Property Id="Label" Label="Label" Description="Displayable label of an Annotatable object" DataType="System.String" />
    <Property Id="SourceLocation" Label="Start Line Number" DataType="Microsoft.VisualStudio.GraphModel.CodeSchema.SourceLocation" />
    <Property Id="Visibility" Label="Visibility" Description="Defines whether a node in the graph is visible or not" DataType="System.Windows.Visibility" />
  </Properties>
  <QualifiedNames>
    <Name Id="Assembly" Label="Assembly" ValueType="Uri" />
    <Name Id="Member" Label="Member" ValueType="System.Object" />
    <Name Id="Name" Label="Name" ValueType="System.String" />
    <Name Id="Namespace" Label="Namespace" ValueType="System.String" />
    <Name Id="OverloadingParameters" Label="Parameter" ValueType="Microsoft.VisualStudio.GraphModel.GraphNodeIdCollection" Formatter="NameValueNoEscape" />
    <Name Id="Type" Label="Type" ValueType="System.Object" />
  </QualifiedNames>
  <IdentifierAliases>
    <Alias n="1" Uri="Assembly=$(5689e79a-19b9-444e-a4be-ae34e8d48bea.OutputPathUri)" />
    <Alias n="2" Uri="Assembly=file:///C:/Users/admin/.nuget/packages/microsoft.entityframeworkcore/3.1.8/lib/netstandard2.0/Microsoft.EntityFrameworkCore.dll" />
  </IdentifierAliases>
  <Paths>
    <Path Id="5689e79a-19b9-444e-a4be-ae34e8d48bea.OutputPathUri" Value="file:///C:/Users/admin/Desktop/.Net/E-shop Movie/bin/Debug/netcoreapp3.1/E-shop Movie.dll" />
  </Paths>
</DirectedGraph>
            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
