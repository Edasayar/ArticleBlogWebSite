using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ArticleBlogSiteDAL.Migrations
{
    public partial class first : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppWriters",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppWriters", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(35)", maxLength: 35, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false)
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
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
                    UserId = table.Column<int>(type: "int", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
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

            migrationBuilder.CreateTable(
                name: "Article",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ViewCount = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Article", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Article_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Comment",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    ArticleId = table.Column<int>(type: "int", nullable: false),
                    AppUserId = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comment", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Comment_Article_ArticleId",
                        column: x => x.ArticleId,
                        principalTable: "Article",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Comment_AspNetUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Rating",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ArticleId = table.Column<int>(type: "int", nullable: false),
                    RatingId = table.Column<int>(type: "int", nullable: false),
                    RatingValue = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AppUserId = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rating", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Rating_Article_ArticleId",
                        column: x => x.ArticleId,
                        principalTable: "Article",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Rating_AspNetUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName", "Role" },
                values: new object[,]
                {
                    { -4, null, null, null, "Visitor" },
                    { -3, null, null, null, "Reader" },
                    { -2, "38ed729f-48fc-4e61-bc0e-fbb973c1079d", null, null, "Writer" },
                    { -1, "8dc86583-a2eb-4cd0-b773-9ceeafbe3331", null, null, "Admin" }
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "ID", "CategoryType", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "Description", "IsDeleted", "ModifiedBy", "ModifiedDate" },
                values: new object[,]
                {
                    { 1, "Psikoloji", "Admin", new DateTime(2023, 8, 29, 22, 26, 17, 314, DateTimeKind.Local).AddTicks(2766), null, null, "fgbdcfb", false, null, null },
                    { 2, "Felsefe", "Admin", new DateTime(2023, 8, 29, 22, 26, 17, 314, DateTimeKind.Local).AddTicks(2769), null, null, "cfvbf", false, null, null },
                    { 3, "Tarih", "Admin", new DateTime(2023, 8, 29, 22, 26, 17, 314, DateTimeKind.Local).AddTicks(2805), null, null, "fsdbf", false, null, null },
                    { 4, "Teknoloji", "Admin", new DateTime(2023, 8, 29, 22, 26, 17, 314, DateTimeKind.Local).AddTicks(2807), null, null, "fsdbf", false, null, null }
                });

            migrationBuilder.InsertData(
                table: "Article",
                columns: new[] { "ID", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "Image", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "UserId", "ViewCount" },
                values: new object[,]
                {
                    { 1, 1, "Crysel (2014), sosyal yaşamda çeşitli talihsiz olaylar karşısında başkasının üzüntüsüne sevinme duygusunun bir kişilik özelliği olarak ele alınabileceğini ileri sürmüştür. Bu doğrultuda, iyicil ve kötücül başkasının üzüntüsüne sevinme olmak üzere iki faktöre sahip ve toplam 12 maddeden oluşan bir ölçek geliştirmiştir. Bu çalışmanın amacı Crysel (2014) tarafından Amerikan örnekleminde geliştirilen Başkasının Üzüntüsüne Sevinme Ölçeği’ni Türkçeye uyarlamak ve psikometrik özelliklerini incelemektir. Bu çalışmanın örneklemini 379 üniversite öğrencisi (183 erkek, 196 kadın, Ort.yaş = 20.6, SS = 2.48) oluşturmaktadır. Başkasının Üzüntüsüne Sevinme Ölçeği’ne ek olarak katılımcılara geçerlik sınamaları kapsamında Toronto Empati Ölçeği ve BeMaS- Haset ve Gıpta Ölçeği de verilmiştir. Psikometrik sınamalar kapsamında madde analizi, doğrulayıcı faktör analizi, diğer yapılarla ilişkiler ve güvenirlik için tutarlık analizi uygulanmıştır. Madde analizi, ölçek maddelerinin madde toplam korelasyon katsayılarının uygun değerlere sahip olduğunu göstermektedir (.27- .46). Doğrulayıcı faktör analizleri sonucunda toplam beş model sınanmış ve elde edilen bulgular ölçeğin Türkçe formunun yeterli uyum değerlerine sahip olduğunu ve orijinal ölçek ile benzer faktör yapısına sahip olduğunu göstermiştir. ", "admin", new DateTime(2023, 8, 29, 22, 26, 17, 314, DateTimeKind.Local).AddTicks(2396), null, null, "\\images\\dalga-geçmek.jpg", false, null, null, "Başkasının Üzüntüsüne Sevinme", -1, 20 },
                    { 2, 1, "COVID-19 pandemisi nedeniyle birçok kayıp yaşanmış ve artan ölüm sayıları nedeniyle pandemiyi kontrol edebilmek için çeşitli kısıtlamalar ve karantinalar ilan edilmiştir. Bu kısıtlamalar ve karantinalar nedeniyle bireyler günlük ve sosyal yaşamlarında birçok değişiklikle karşılaşırken yaşadıkları kayıp sonrasında gerçekleştirdikleri dini ve kültürel ritüelleri de yerine getirememişlerdir. Alan-yazında kişilerin yaşadıkları kaybın ardından gerçekleştirmek istedikleri dini ve kültürel ritüelleri gerçekleştirmelerinin, kişilerin yas sürecinde olumlu bir etkiye sahip olduğu ele alınmıştır. Bu bağlamda bu araştırma, COVID-19 pandemisi sürecinde Türk toplumunda COVID-19 nedeniyle kayıp yaşayan ancak kısıtlamalar nedeniyle dini ve kültürel ritüelleri yerine getiremeyen bireylerin bu süreci nasıl deneyimlediklerini araştırmaktadır. Bu amaçla bireylerin öznel deneyimlerinin anlaşılabilmesi için 45-65 yaş arasında, son bir yıl içerisinde COVID-19 nedeniyle bir yakınını kaybetmiş dört katılımcı ile yarı yapılandırılmış görüşmeler yapılmış ve bu görüşmeler Yorumlayıcı Fenomenolojik Analiz yöntemi ile analiz edilmiştir. Analizin sonucunda beş üst tema oluşturulmuştur: Ritüellerin eksikliğinde olumsuz duygular, Yas sürecini kolaylaştırması açısından ritüellere yapılan atıflar, Kayıpla baş etme yöntemleri, Gerçekleşmeyen ritüellerin telafisi ve Yasaklara rağmen: Ritüelleri gerçekleştirebilmek. Bu temalar Lacanyen psikanalitik bakış açısı ile simgesel, imgesel ve gerçek kavramları bağlamında değerlendirilmiştir. Simgesel düzlem özne için dil, kültür ve sosyal ortam olarak tanımlanırken imgesel düzlem öznenin içsel dünyalarında gerçeği anlamlandırdıkları düzlem olarak tanımlanabilir. Bu nedenle dini ve kültürel ritüellerin toplumsal, kültürel ve sosyal işlevi de göz önünde bulundurulduğunda katılımcıların yas sürecinde kayıplarını adlandırma ve kabul etme konusunda simgesel anlamda bir eksiklik yaşadıkları ve kaybı imgesel düzlemde anlamlandırmaya çalıştıkları düşünülmüştür. Bu bağlamda katılımcıların geliştirdikleri alternatif telafi yöntemleri kültürde ve toplumsal düzende, başka bir deyişle simgeselde kendilerine yer bulma çabası olarak yorumlanmıştır.", "dilo", new DateTime(2023, 8, 29, 22, 26, 17, 314, DateTimeKind.Local).AddTicks(2399), null, null, "\\images\\1.jpg", false, null, null, "Pandemide Yas: Dini ve Kültürel Ritüellerini Yerine Getiremeyen Bireylerin Deneyimleri", -2, 46 },
                    { 3, 2, "Bu makalenin amacı koruyucu etiğin moral temelini tanıtmak, koruyucu etik ile Kantçı etik yaklaşımların özerklik bağlamında farklılıklarını irdelemek; koruyucu etiğe en uygun bireysel özerklik kuramının ne olabileceği sorusunu araştırmaktır. Feminist özerklik anlayışına getirilen eleştirileri karşılamaya çalışırken Meyers’in geliştirdiği yeterlilik temelli özerklik anlayışının aslında Kant’ın karşı çıktığı geleneksel özerklik anlayışıyla temelde benzer olduğunu göstermeye çalışacağım. Yeterlilik temelli özerklik yaklaşımının bazı boyutlarında Kantçı anlamda özerk olmak mümkün olsa da bu durum koruyucu eylemlerin Kantçı anlamda özerk eylemler olduğunu ve etik değere sahip olduklarını göstermez. Bu iki özerklik anlayışı temelde farklıdır. Bu farklılık, özerkliğin değeri ile diğer bazı etik değerler arasındaki öncelik konusundaki yaklaşımdan kaynaklanmaktadır. Kantçı yaklaşıma göre feminist yaklaşım özerkliği bazı yaderklik koşullarında aramaktadır. Feminist etiğe göre ise Kant’ın yaderklik olarak gördüğü bu durumlarda önemli etik değerler vardır.", "selino", new DateTime(2023, 8, 29, 22, 26, 17, 314, DateTimeKind.Local).AddTicks(2401), null, null, "\\images\\28-1.jpg", false, null, null, "Kantçı ve feminist etik kuramlarda bireysel özerklik tartışması", -3, 3 },
                    { 4, 3, "Siyasal egemenliğe ilişkin temel kavramlardan olan dēmokratia (demokrasi) ve oligarkhia (oligarşi), anayasal yönetim biçimleri olarak antik Hellen siyasi coğrafyasının tarihi koşulları içinde ortaya çıkmıştır. Arkaik Dönem’in farklı polis merkezlerinde, kısmen birbirine koşut olarak ortaya çıkmalarının ardından bu iki yönetim biçimi, değişen devletlerarası dengelerin bir sonucu olarak zaman içinde büyüyen kırılmalarla birbirinden uzaklaşmaya başlamış ve nihayet Erken Hellenistik Dönem ile birlikte yeni siyasi konjonktür içinde sadece dēmokratia, polis için arzu edilen siyasal düzen olarak öne çıkmıştır. Konu edilen bu tarihi süreç, mevcut çalışmada özgün edebi ve epigrafik belgelere dayalı olarak antik Hellen siyasal dünyasının yoğunlukla devletlerarası dinamikleri ile devlet ideolojileri ekseninde ele alınmaktadır. Araştırmada uygulanan karşılaştırmalı yöntem sayesinde dēmokratia’nın hangi tarihi koşullarda oligarkhia’yı aştığını ve yaklaşık İÖ 3. yüzyılın başlarında en iyi sivil yönetim biçimi olarak kabul edilmeye başlandığını ortaya koymak amaçlanmaktadır.", "dilo", new DateTime(2023, 8, 29, 22, 26, 17, 314, DateTimeKind.Local).AddTicks(2403), null, null, "\\images\\8-.jpg", false, null, null, "DĒMOKRATIA - OLIGARKHIA: ERKEN HELLENİSTİK DÖNEM’E DEĞİN DEMOKRASİ VE OLİGARŞİNİN TARİHSEL GELİŞİMİ", -2, 57 },
                    { 5, 3, "Bu çalışma Homeros destanlarında philos ve kseinos kavramlarının incelenmesi yoluyla Homeros toplumunun kök değerlerinden biri olan dostluk anlayışına odaklanmaktadır. Çalışma üç ana bölümden oluşmaktadır: ilkin, philos’un iyelikten duygusal anlama uzanan semantik gelişimiyle ilgili tartışmalara ve değerlendirmelere yer verilmekte; ikincil olarak, “dost” anlamına gelen philos sözcüğü Homeros dünyasına özgü agathos’la ilişkisi bağlamında ele alınmakta ve son olarak dostluk olgusunu tamamlayacak bir başka kol olan “konuk-dost” anlamında kseinos sözcüğünün kullanımı işlenmektedir. Günümüzdeki gönüllü ve duygu yüklü dostluk anlayışından farklı olarak, Homeros’un anlattığı toplumda dostluk, çoğu zaman duygusal etkileşimin öncelikli olmadığı, yaşam koşullarının ve toplumsal ihtiyaçların yönlendirdiği bir ilişki biçimini imgeler. Farklı şekilde pratik edilmelerine rağmen philia’nın alt kümeleri sayılan philos (dost) ve kseinos (konuk-dost) kavramları dostluğun sosyal ve kurumsal boyutuna işaret eder. Polis’in henüz bir devlet birimi olarak olgunlaşmadığı ve bir mekân topluluğunu ifade ettiği bu tarihsel süreçte, philos ve kseinos’un Homeros’un anlattığı toplumun bey soylu üyelerini ayakta tutan dinamiklerden biri olduğu anlaşılmaktadır.", "selino", new DateTime(2023, 8, 29, 22, 26, 17, 314, DateTimeKind.Local).AddTicks(2428), null, null, "\\images\\homeros-kimdir.jpg", false, null, null, "HOMEROS DESTANLARINDA DOSTLUK ANLAYIŞI: PHILOS VE KSEINOS KAVRAMLARI", -3, 34 },
                    { 6, 4, "Yeni nesil mobil internet teknolojisi 5G, tahminlere göre Güney Kore'de 2020 yılından itibaren kullanılmaya başlanacak. Daha önceki mobil veri teknolojilerinde gördüğümüz geçiş dönemine baktığımızda, 5G'nin global olarak gelişmiş ülkelerde kullanılmaya başlanması ve sistemin stabil bir hale getirilmesinin ise 2022 yılı gibi gerçekleşeceği öngörülüyor. Fakat bu teknolojiye alışamadan Koronavirüs (Covid-19) ile birlikte 5G tartışmaları başladı. Peki gerçekten 5G ve Koronavirüs arasında bağlantı var mı? Önümüzde 5G için çok kısa olmayan bir süre var. Global olarak kullanılmaya devam eden 4G / LTE teknolojilerine göre 5G, nesnelerin internetine ne gibi katkılarda bulunacak?\r\n\r\n5G, neler vaat ediyor?\r\nMühendisler, 5G'nin tam olarak hazır hale geldiğinde günümüzdeki hücresel bağlantı sistemlerine göre 1000 kat daha fazla mobil veriyi yönetebileceğini belirtiyorlar. Ayrıca satış makineleri, arabalar, ev eşyaları gibi hem sabit hem de haraketli sistemleri birbirine bağlamada dev bir iskelet görevi göreceği tahmin ediliyor. Genel olarak ekonomistler ve mühendisler bu gelişmelerin ekonomik devrimler yaratacağını öne sürüyor. Bunu mümkün kılacak olan ise yeni teknolojiler, yeni mimariler ve yeni donanımlar olacak. Lancaster Üniversitesindeki bir araştırma ekibi ve Çin’deki Southwest Jiaotong Üniversitesinden bir araştırma ekibi son gelişmelere bakarak, 5G’nin gelecekteki ihtiyaçları ile ilgili bir makale yayınladılar.  Biz de bu makale ışığında 5G ve nesnelerin internetine ışık tutmaya çalışıyoruz.", "selino", new DateTime(2023, 8, 29, 22, 26, 17, 314, DateTimeKind.Local).AddTicks(2431), null, null, "\\images\\5g-iot-ana.jpg", false, null, null, "5G, Nesnelerin İnternetini Nasıl Etkileyecek?", -3, 36 }
                });

            migrationBuilder.InsertData(
                table: "Comment",
                columns: new[] { "ID", "AppUserId", "ArticleId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsDeleted", "ModifiedBy", "ModifiedDate" },
                values: new object[,]
                {
                    { 1, null, 1, "Yorumcghfghfj", "kardelen3@mail.com", new DateTime(2023, 8, 29, 22, 26, 17, 314, DateTimeKind.Local).AddTicks(3444), null, null, false, null, null },
                    { 2, null, 2, "Yorughfgjnfhjm", "dilo@gmail.com", new DateTime(2023, 8, 29, 22, 26, 17, 314, DateTimeKind.Local).AddTicks(3447), null, null, false, null, null },
                    { 3, null, 1, "Yorgvjngyhjukum", "dünya@gmail.com", new DateTime(2023, 8, 29, 22, 26, 17, 314, DateTimeKind.Local).AddTicks(3448), null, null, false, null, null },
                    { 4, null, 1, "içerik dfldkf", "User@gmail.com", new DateTime(2023, 8, 29, 22, 26, 17, 314, DateTimeKind.Local).AddTicks(3449), null, null, false, null, null },
                    { 5, null, 1, "içerik", "leyla@gmail.com", new DateTime(2023, 8, 29, 22, 26, 17, 314, DateTimeKind.Local).AddTicks(3451), null, null, false, null, null }
                });

            migrationBuilder.InsertData(
                table: "Rating",
                columns: new[] { "ID", "AppUserId", "ArticleId", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsDeleted", "ModifiedBy", "ModifiedDate", "RatingId", "RatingValue", "UserId" },
                values: new object[,]
                {
                    { 1, null, 3, "User4", new DateTime(2023, 8, 29, 22, 26, 17, 314, DateTimeKind.Local).AddTicks(3793), null, null, true, null, null, 0, "Üç", -1 },
                    { 2, null, 6, "User1", new DateTime(2023, 8, 29, 22, 26, 17, 314, DateTimeKind.Local).AddTicks(3796), null, null, true, null, null, 0, "İki", -2 },
                    { 3, null, 2, "User2", new DateTime(2023, 8, 29, 22, 26, 17, 314, DateTimeKind.Local).AddTicks(3798), null, null, true, null, null, 0, "Beş", -2 },
                    { 4, null, 1, "User3", new DateTime(2023, 8, 29, 22, 26, 17, 314, DateTimeKind.Local).AddTicks(3799), null, null, true, null, null, 0, "Bir", -3 },
                    { 5, null, 3, "User5", new DateTime(2023, 8, 29, 22, 26, 17, 314, DateTimeKind.Local).AddTicks(3801), null, null, true, null, null, 0, "Beş", -2 },
                    { 6, null, 4, "User6", new DateTime(2023, 8, 29, 22, 26, 17, 314, DateTimeKind.Local).AddTicks(3802), null, null, true, null, null, 0, "Dört", -3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Article_CategoryId",
                table: "Article",
                column: "CategoryId");

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

            migrationBuilder.CreateIndex(
                name: "IX_Comment_AppUserId",
                table: "Comment",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Comment_ArticleId",
                table: "Comment",
                column: "ArticleId");

            migrationBuilder.CreateIndex(
                name: "IX_Rating_AppUserId",
                table: "Rating",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Rating_ArticleId",
                table: "Rating",
                column: "ArticleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppWriters");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Comment");

            migrationBuilder.DropTable(
                name: "Rating");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Article");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Category");
        }
    }
}
