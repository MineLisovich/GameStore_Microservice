using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Microservice.Products.Migrations
{
    public partial class products_mig_1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Developers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameDeveloper = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Developers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ganres",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameGanres = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ganres", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Platforms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NamePlatform = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Platforms", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameGame = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DescriptionG = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReleaseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: false),
                    Poster = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateAddedSite = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ScreenshotGame1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ScreenshotGame2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ScreenshotGame3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ScreenshotGame4 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LinkTrailerGame = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OS = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CPU = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RAM = table.Column<int>(type: "int", nullable: false),
                    VRAM = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GameWeight = table.Column<int>(type: "int", nullable: false),
                    Features = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ganresid = table.Column<int>(type: "int", nullable: false),
                    Developersid = table.Column<int>(type: "int", nullable: false),
                    Platformsid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Games_Developers_Developersid",
                        column: x => x.Developersid,
                        principalTable: "Developers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Games_Ganres_Ganresid",
                        column: x => x.Ganresid,
                        principalTable: "Ganres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Games_Platforms_Platformsid",
                        column: x => x.Platformsid,
                        principalTable: "Platforms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GamesKeys",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Key_game = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gamesid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GamesKeys", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GamesKeys_Games_Gamesid",
                        column: x => x.Gamesid,
                        principalTable: "Games",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Shares",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DiscountPrice = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: false),
                    NameImageSlider = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gamesid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shares", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Shares_Games_Gamesid",
                        column: x => x.Gamesid,
                        principalTable: "Games",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Developers",
                columns: new[] { "Id", "NameDeveloper" },
                values: new object[,]
                {
                    { 101, "Bethesda" },
                    { 102, "Blizzard" },
                    { 103, "Valve" },
                    { 104, "Electronic Arts" },
                    { 105, "RockStar Games" },
                    { 106, "Ubisoft" },
                    { 107, "Square Enix" },
                    { 108, "Activision" },
                    { 109, "Konami" },
                    { 110, "2K Games" },
                    { 111, "Matrix Games" },
                    { 112, "Nacon" },
                    { 113, "Majesco" },
                    { 114, "CD Projekt Red" },
                    { 115, "Iron Gate AB" }
                });

            migrationBuilder.InsertData(
                table: "Ganres",
                columns: new[] { "Id", "NameGanres" },
                values: new object[,]
                {
                    { 201, "Экшн" },
                    { 202, "Приключения" },
                    { 203, "RPG" },
                    { 204, "Симуляторы" },
                    { 205, "Спорт" },
                    { 206, "Гонки" },
                    { 207, "Казуал" }
                });

            migrationBuilder.InsertData(
                table: "Platforms",
                columns: new[] { "Id", "NamePlatform" },
                values: new object[,]
                {
                    { 301, "Steam" },
                    { 302, "Origin" },
                    { 303, "Battle.net" },
                    { 304, "RockStar Launcher" },
                    { 305, "Epic Games Launcher" },
                    { 306, "Ubisoft Connect" }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "CPU", "DateAddedSite", "DescriptionG", "Developersid", "Features", "GameWeight", "Ganresid", "LinkTrailerGame", "NameGame", "OS", "Platformsid", "Poster", "Price", "RAM", "ReleaseDate", "ScreenshotGame1", "ScreenshotGame2", "ScreenshotGame3", "ScreenshotGame4", "VRAM" },
                values: new object[,]
                {
                    { 401, "Intel Core i5-11400F or AMD Ryzen 5 5600X", new DateTime(2022, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cyberpunk 2077 — приключенческая ролевая игра, действие которой происходит в мегаполисе Найт-Сити, где власть, роскошь и модификации тела ценятся выше всего. Вы играете за V, наёмника в поисках устройства, позволяющего обрести бессмертие. Вы сможете менять киберимпланты, навыки и стиль игры своего персонажа, исследуя открытый мир, где ваши поступки влияют на ход сюжета и всё, что вас окружает.", 114, "Для одного игрока", 80, 203, "aSrFWinrkeQ", "Cyberpunk 2077", "Windows 10 64 bit", 301, "2077.png", 34m, 8, new DateTime(2020, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cyberpunk_screenshotGame_1.png", "Cyberpunk_screenshotGame_2.png", "Cyberpunk_screenshotGame_3.png", "Cyberpunk_screenshotGame_4.png", "Nvidia GeForce GTX 1660 GP 6GB GDDR6" },
                    { 402, "Intel® Core™ 2 Q6600 / AMD Phenom 9850", new DateTime(2022, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Действие игры происходит в вымышленном штате Сан-Андреас, прообразом которого послужила Южная Калифорния. Сюжет в однопользовательском режиме строится вокруг приключений троих грабителей, устраивающих всё более дерзкие ограбления и противостоящих как организованной преступности, так и правоохранительным ведомствам. В процессе игры игрок управляет выбранным персонажем в режиме от первого или от третьего лица; персонаж может свободно передвигаться по обширному миру игры как пешком, так и на автомобилях и других видах транспорта. Особенностью Grand Theft Auto V по сравнению с другими играми серии является возможность переключаться между персонажами в любой момент, как во время выполнения заданий, так и вне их. Многие задания игры связаны с ограблениями и угоном автомобилей; при этом игровой персонаж может участвовать в перестрелках и погонях. Grand Theft Auto Online представляет собой встроенный многопользовательский онлайн-режим, поддерживающий до 30 игроков одновременно — для них предлагаются как кооперативные, так и соревновательные задания.", 105, "Для нескольких игроков / Для одного игрока", 110, 201, "QkkoHAzjnUs", "Grand Theft Auto V", "Windows 7 64 bit / Windows 10 64 bit", 301, "GTA5.png", 67m, 4, new DateTime(2013, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "GTAV_screenshotGame_1.png", "GTAV_screenshotGame_2.png", "GTAV_screenshotGame_3.png", "GTAV_screenshotGame_4.png", "NVIDIA® 9800 GT / AMD HD 4870" },
                    { 403, "2.6 GHz Quad Core or similar", new DateTime(2022, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Вальхейм — это игра, в которой вам предстоит исследовать огромный фэнтезийный мир, пропитанный скандинавской мифологией и культурой викингов. Ваше приключение начнется в самом сердце Вальхейма, месте довольно спокойном. Но берегитесь, ведь чем дальше вы будете продвигаться, тем опаснее будет становиться мир вокруг. К счастью, по пути вас будут ждать не только опасности — вы также будете чаще находить ценные материалы, которые весьма пригодятся для создания смертоносного оружия и крепкой брони. Возводите крепости и заставы по всему миру! А со временем постройте несокрушимый драккар и отправьтесь покорять бескрайние океаны в поиске чужестранных земель... Но постарайтесь не заплыть слишком далеко...", 115, "Для нескольких игроков", 2, 203, "5mHRJ1KFe20", "Valheim", "Windows 7 64 bit", 301, "Valheim.png", 25m, 8, new DateTime(2021, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Valheim_screenshotGame_1.png", "Valheim_screenshotGame_2.png", "Valheim_screenshotGame_3.png", "Valheim_screenshotGame_4.png", "GeForce GTX 950 or Radeon HD 7970" },
                    { 404, "Dual core (Intel Pentium D или лучше)", new DateTime(2022, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Действие игры разворачивается во времена Третьего крестового похода, а именно в 1191 году. В настоящем времени бармена Дезмонда Майлса, главного героя, похищает корпорация «Абстерго», которая с помощью Анимуса, машины для извлечения генетической памяти, хочет найти артефакт Первой Цивилизации. В курс дела Дезмонда вводят учёный Уоррен Видик и его ассистентка Люси Стиллман. Они рассказывают ему, что он является потомком ассасина Альтаира ибн-Ла-Ахада, который обнаружил артефакт, и через него хотят узнать местонахождение артефакта.", 114, "Для одного игрока", 16, 203, "RjQ6ZtyXoA0", "Assassin’s Creed", "Windows XP/Vista / Windows 7", 301, "Assassin1.png", 13m, 2, new DateTime(2007, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Assassin1_screenshotGame_1.png", "Assassin1_screenshotGame_2.png", "Assassin1_screenshotGame_3.png", "Assassin1_screenshotGame_4.png", "256MB с поддержкой Shader Model 3.0 или выше" },
                    { 405, "Intel Core i5-6600K", new DateTime(2022, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "События игры происходят в 2102 году в Западной Виргинии. Игрок — житель Убежища 76 (Резидент), проспавший выход на поверхность. Находя голозаписи Смотрительницы Убежища, которая покинула его раньше всех, игрок понимает, что над регионом нависла опасность в виде горелых — людей, заражённых инфекцией, превращающихся со временем в неподвижные статуи, которые, распадаясь, разносят заразу, заражая как и других существ, так и людей. Как выясняется, источник той болезни — зверожоги. Это мутировавшие драконоподобные летучие мыши, обитавшие под землёй. По мере продвижения по сюжету и выполнению квестов игрок создаёт вакцину против чумы зверожогов. Далее Резиденту предстоит проникнуть в хорошо спрятанный бункер «Анклава» — бывшего правительства США. Там ему встречается МОДУС — суперкомпьютер, который убил всех членов Анклава в качестве мести за попытку уничтожить его. МОДУС рассказывает о ядерных ракетах и как их запустить. Игрок завладевает кодами запуска и, проведя бомбардировку главного разлома, откуда вылезают зверожоги, сталкивается с ещё более страшной угрозой — маткой зверожогов. В тяжёлом бою её удаётся убить, и зверожоги, оставшись без главы, разлетаются подобно муравьям, оставшимся без королевы.", 114, "Для нескольких игроков", 60, 203, "EtiVOmFiWA0", "Fallout 76", "Windows 7/8/8.1/10", 301, "Fallout76.png", 70m, 8, new DateTime(2018, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fallout76Screenshot_1.png", "Fallout76Screenshot_2.png", "Fallout76Screenshot_3.png", "Fallout76Screenshot_4.png", "NVIDIA GeForce GTX 780" },
                    { 406, "AMD Ryzen™ 5 2600 (Intel i7-4770)", new DateTime(2022, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Всеми любимый «шутер с базиллионами лута» возвращается, чтобы порадовать вас несметным множеством убойных стволов и новым крышесносным приключением! Вам предстоит покорить доселе не виданные миры, играя за одного из четырёх новых искателей Хранилища – нереально крутых перцев, у каждого из которых уникальные навыки, способности и модификации. Действуя в одиночку или в компании друзей, вы должны будете дать бой яростным противникам, нагрести побольше трофеев и спасти свой дом от безжалостных психопатов, возглавляющих самую опасную секту в галактике.", 114, "Для одного игрока / Для нескольких игроков", 75, 203, "tQj8CLKoTCs", "Borderlands 3", "Windows 7/10 (с последней версией пакета обновлений)", 301, "Borderlands3.png", 70m, 16, new DateTime(2019, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "borderlands3_screenshot_1.png", "borderlands3_screenshot_2.png", "borderlands3_screenshot_3.png", "borderlands3_screenshot_4.png", "AMD Radeon™ RX 590 (NVIDIA GeForce GTX 1060 6 ГБ)" },
                    { 407, "Intel Core i7 3770 с частотой 3,4 ГГц / AMD FX-8350 с частотой 4 ГГц", new DateTime(2022, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Станьте профессиональным убийцей монстров и отправляйтесь в приключение эпических масштабов! После своего выхода игра «Ведьмак 3: Дикая Охота» (The Witcher 3: Wild Hunt) стала настоящей классикой, получив более 250 наград в номинации «Игра года». Вас ждёт более 100 часов грандиозного приключения по открытому миру, а также сюжетные расширения, которые растянутся ещё на 50 часов игры. Это издание включает в себя весь дополнительный контент: новое оружие, броню, экипировку для компаньонов, новый режим игры и побочные квесты.", 114, "Для одного игрока", 77, 203, "4ndIeNusRLI", "Ведьмак 3: Дикая Охота", "64-разрядная Windows 7, 64-разрядная Windows 8 (8.1) или 64-разрядная Windows 10", 301, "Witcher3.png", 50m, 8, new DateTime(2014, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "witcher3__screenshot_1.png", "witcher3__screenshot_2.png", "witcher3__screenshot_3.png", "witcher3__screenshot_4.png", "NVIDIA GPU GeForce GTX 770 / AMD GPU Radeon R9 290" },
                    { 408, "Intel® Core™ i7-4770K / AMD Ryzen 5 1500x", new DateTime(2022, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Америка, 1899 год. Артур Морган и другие подручные Датча ван дер Линде вынуждены пуститься в бега. Их банде предстоит участвовать в кражах, грабежах и перестрелках в самом сердце Америки. За ними по пятам идут федеральные агенты и лучшие в стране охотники за головами, а саму банду разрывают внутренние противоречия. Артуру предстоит выбрать, что для него важнее: его собственные идеалы или же верность людям, которые его взрастили.", 114, "Для одного игрока / Для нескольких игроков", 150, 203, "0kqEBOZaP94", "Red Dead Redemption 2", "Windows 10 - April 2018 Update (v1803)", 301, "rdr2.png", 80m, 12, new DateTime(2019, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "RDR2_screenshot_1.png", "RDR2_screenshot_2.png", "RDR2_screenshot_3.png", "RDR2_screenshot_4.png", "Nvidia GeForce GTX 1060 6 ГБ / AMD Radeon RX 480 4 ГБ" },
                    { 409, "AMD Ryzen 5 1500X | Intel Core I7-4790", new DateTime(2022, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Вашингтон на грани катастрофы. Нашему обществу угрожает беззаконие и нестабильность, и слухи о перевороте в Капитолии только способствуют хаосу. Мы крайне нуждаемся в каждом действующем агенте группы Division — только с ними мы сможем спасти город, пока не поздно.", 114, "Для нескольких игроков", 4, 203, "ssyC-QwcPug", "Tom Clancy's The Division®2", "Windows 7/8/10", 301, "Division2.png", 40m, 8, new DateTime(2019, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "thedivision2_screenshot_1.png", "thedivision2_screenshot_2.png", "thedivision2_screenshot_3.png", "thedivision2_screenshot_4.png", "AMD RX 480 NVIDIA GeForce GTX 970" },
                    { 410, "Intel Core i5-2300 2,8 ГГц/AMD Phenom II X4 945 3 ГГц", new DateTime(2022, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Добро пожаловать в игру нового поколения с открытым миром! Вы — единственный выживший из убежища 111, оказавшийся в мире, разрушенном ядерной войной. Каждый миг вы сражаетесь за выживание, каждое решение может стать последним. Но именно от вас зависит судьба пустошей. Добро пожаловать домой.", 114, "Для одного игрока", 60, 203, "ErgtR14-MV8", "Fallout 4", "Windows 7/8/10/11 (необходима 64-битная ОС)", 301, "Fallout4.png", 50m, 8, new DateTime(2015, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "fallout4_1.png", "fallout4_2.png", "fallout4_3.png", "fallout4_4.png", "NVIDIA GTX 550 Ti 2 Гб/AMD Radeon HD 7870 2 Гб" }
                });

            migrationBuilder.InsertData(
                table: "GamesKeys",
                columns: new[] { "Id", "Gamesid", "Key_game" },
                values: new object[,]
                {
                    { 501, 401, "GHZNAZXB-ZXNHDANX-IOEJZNDG-MSHSJWUJ" },
                    { 502, 402, "IEUWYHDB-DKSNZMEU-XHSKDMWO-XMBADHNR" },
                    { 503, 403, "ZXNEYTAB-KFBSYDBF-XHSNWDAC-DNWHDDEWE" },
                    { 504, 404, "FJNVCDKM-KLWDEIRU-SXJNHWEG-SAJKFHJD" },
                    { 505, 405, "GRHUSDNM-CXJNWGVD-DJNCLKWD-WEYUXZBN" },
                    { 506, 406, "RTIOSDBN-REHJNMSAX-REUYBSXN-DSHJVBWE" },
                    { 507, 407, "REYUCBXN-YUEWVSBA-SAHJWVBQ-OXZIQVWB" },
                    { 508, 408, "VFBNYTWE-DSHJWQVB-DISUQWVB-KSJAEWBV" },
                    { 509, 409, "CXBNWJHE-KFJHDHJWFEK-HWEJRF-WHKFEUJ" },
                    { 510, 410, "WFOQEUIFHW-KWEFHJ-BEWFJH-WEFVHGJ" }
                });

            migrationBuilder.InsertData(
                table: "Shares",
                columns: new[] { "Id", "DiscountPrice", "Gamesid", "NameImageSlider" },
                values: new object[,]
                {
                    { 701, 30m, 401, "2077.png" },
                    { 702, 55m, 405, "Fallout76.png" },
                    { 703, 70m, 408, "rdr2.png" },
                    { 704, 30m, 407, "Wicher3.png" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Games_Developersid",
                table: "Games",
                column: "Developersid");

            migrationBuilder.CreateIndex(
                name: "IX_Games_Ganresid",
                table: "Games",
                column: "Ganresid");

            migrationBuilder.CreateIndex(
                name: "IX_Games_Platformsid",
                table: "Games",
                column: "Platformsid");

            migrationBuilder.CreateIndex(
                name: "IX_GamesKeys_Gamesid",
                table: "GamesKeys",
                column: "Gamesid");

            migrationBuilder.CreateIndex(
                name: "IX_Shares_Gamesid",
                table: "Shares",
                column: "Gamesid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GamesKeys");

            migrationBuilder.DropTable(
                name: "Shares");

            migrationBuilder.DropTable(
                name: "Games");

            migrationBuilder.DropTable(
                name: "Developers");

            migrationBuilder.DropTable(
                name: "Ganres");

            migrationBuilder.DropTable(
                name: "Platforms");
        }
    }
}
