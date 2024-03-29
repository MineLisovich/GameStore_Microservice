﻿// <auto-generated />
using System;
using Microservice.Products.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Microservice.Products.Migrations
{
    [DbContext(typeof(ProductsDbContext))]
    partial class ProductsDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.21")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Microservice.Products.Data.Entities.Developers", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("NameDeveloper")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Developers");

                    b.HasData(
                        new
                        {
                            Id = 101,
                            NameDeveloper = "Bethesda"
                        },
                        new
                        {
                            Id = 102,
                            NameDeveloper = "Blizzard"
                        },
                        new
                        {
                            Id = 103,
                            NameDeveloper = "Valve"
                        },
                        new
                        {
                            Id = 104,
                            NameDeveloper = "Electronic Arts"
                        },
                        new
                        {
                            Id = 105,
                            NameDeveloper = "RockStar Games"
                        },
                        new
                        {
                            Id = 106,
                            NameDeveloper = "Ubisoft"
                        },
                        new
                        {
                            Id = 107,
                            NameDeveloper = "Square Enix"
                        },
                        new
                        {
                            Id = 108,
                            NameDeveloper = "Activision"
                        },
                        new
                        {
                            Id = 109,
                            NameDeveloper = "Konami"
                        },
                        new
                        {
                            Id = 110,
                            NameDeveloper = "2K Games"
                        },
                        new
                        {
                            Id = 111,
                            NameDeveloper = "Matrix Games"
                        },
                        new
                        {
                            Id = 112,
                            NameDeveloper = "Nacon"
                        },
                        new
                        {
                            Id = 113,
                            NameDeveloper = "Majesco"
                        },
                        new
                        {
                            Id = 114,
                            NameDeveloper = "CD Projekt Red"
                        },
                        new
                        {
                            Id = 115,
                            NameDeveloper = "Iron Gate AB"
                        });
                });

            modelBuilder.Entity("Microservice.Products.Data.Entities.Games", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CPU")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateAddedSite")
                        .HasColumnType("datetime2");

                    b.Property<string>("DescriptionG")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Developersid")
                        .HasColumnType("int");

                    b.Property<string>("Features")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GameWeight")
                        .HasColumnType("int");

                    b.Property<int>("Ganresid")
                        .HasColumnType("int");

                    b.Property<string>("LinkTrailerGame")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameGame")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OS")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Platformsid")
                        .HasColumnType("int");

                    b.Property<string>("Poster")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasPrecision(10, 2)
                        .HasColumnType("decimal(10,2)");

                    b.Property<int>("RAM")
                        .HasColumnType("int");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ScreenshotGame1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ScreenshotGame2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ScreenshotGame3")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ScreenshotGame4")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VRAM")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Developersid");

                    b.HasIndex("Ganresid");

                    b.HasIndex("Platformsid");

                    b.ToTable("Games");

                    b.HasData(
                        new
                        {
                            Id = 401,
                            CPU = "Intel Core i5-11400F or AMD Ryzen 5 5600X",
                            DateAddedSite = new DateTime(2022, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DescriptionG = "Cyberpunk 2077 — приключенческая ролевая игра, действие которой происходит в мегаполисе Найт-Сити, где власть, роскошь и модификации тела ценятся выше всего. Вы играете за V, наёмника в поисках устройства, позволяющего обрести бессмертие. Вы сможете менять киберимпланты, навыки и стиль игры своего персонажа, исследуя открытый мир, где ваши поступки влияют на ход сюжета и всё, что вас окружает.",
                            Developersid = 114,
                            Features = "Для одного игрока",
                            GameWeight = 80,
                            Ganresid = 203,
                            LinkTrailerGame = "aSrFWinrkeQ",
                            NameGame = "Cyberpunk 2077",
                            OS = "Windows 10 64 bit",
                            Platformsid = 301,
                            Poster = "2077.png",
                            Price = 34m,
                            RAM = 8,
                            ReleaseDate = new DateTime(2020, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ScreenshotGame1 = "Cyberpunk_screenshotGame_1.png",
                            ScreenshotGame2 = "Cyberpunk_screenshotGame_2.png",
                            ScreenshotGame3 = "Cyberpunk_screenshotGame_3.png",
                            ScreenshotGame4 = "Cyberpunk_screenshotGame_4.png",
                            VRAM = "Nvidia GeForce GTX 1660 GP 6GB GDDR6"
                        },
                        new
                        {
                            Id = 402,
                            CPU = "Intel® Core™ 2 Q6600 / AMD Phenom 9850",
                            DateAddedSite = new DateTime(2022, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DescriptionG = "Действие игры происходит в вымышленном штате Сан-Андреас, прообразом которого послужила Южная Калифорния. Сюжет в однопользовательском режиме строится вокруг приключений троих грабителей, устраивающих всё более дерзкие ограбления и противостоящих как организованной преступности, так и правоохранительным ведомствам. В процессе игры игрок управляет выбранным персонажем в режиме от первого или от третьего лица; персонаж может свободно передвигаться по обширному миру игры как пешком, так и на автомобилях и других видах транспорта. Особенностью Grand Theft Auto V по сравнению с другими играми серии является возможность переключаться между персонажами в любой момент, как во время выполнения заданий, так и вне их. Многие задания игры связаны с ограблениями и угоном автомобилей; при этом игровой персонаж может участвовать в перестрелках и погонях. Grand Theft Auto Online представляет собой встроенный многопользовательский онлайн-режим, поддерживающий до 30 игроков одновременно — для них предлагаются как кооперативные, так и соревновательные задания.",
                            Developersid = 105,
                            Features = "Для нескольких игроков / Для одного игрока",
                            GameWeight = 110,
                            Ganresid = 201,
                            LinkTrailerGame = "QkkoHAzjnUs",
                            NameGame = "Grand Theft Auto V",
                            OS = "Windows 7 64 bit / Windows 10 64 bit",
                            Platformsid = 301,
                            Poster = "GTA5.png",
                            Price = 67m,
                            RAM = 4,
                            ReleaseDate = new DateTime(2013, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ScreenshotGame1 = "GTAV_screenshotGame_1.png",
                            ScreenshotGame2 = "GTAV_screenshotGame_2.png",
                            ScreenshotGame3 = "GTAV_screenshotGame_3.png",
                            ScreenshotGame4 = "GTAV_screenshotGame_4.png",
                            VRAM = "NVIDIA® 9800 GT / AMD HD 4870"
                        },
                        new
                        {
                            Id = 403,
                            CPU = "2.6 GHz Quad Core or similar",
                            DateAddedSite = new DateTime(2022, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DescriptionG = "Вальхейм — это игра, в которой вам предстоит исследовать огромный фэнтезийный мир, пропитанный скандинавской мифологией и культурой викингов. Ваше приключение начнется в самом сердце Вальхейма, месте довольно спокойном. Но берегитесь, ведь чем дальше вы будете продвигаться, тем опаснее будет становиться мир вокруг. К счастью, по пути вас будут ждать не только опасности — вы также будете чаще находить ценные материалы, которые весьма пригодятся для создания смертоносного оружия и крепкой брони. Возводите крепости и заставы по всему миру! А со временем постройте несокрушимый драккар и отправьтесь покорять бескрайние океаны в поиске чужестранных земель... Но постарайтесь не заплыть слишком далеко...",
                            Developersid = 115,
                            Features = "Для нескольких игроков",
                            GameWeight = 2,
                            Ganresid = 203,
                            LinkTrailerGame = "5mHRJ1KFe20",
                            NameGame = "Valheim",
                            OS = "Windows 7 64 bit",
                            Platformsid = 301,
                            Poster = "Valheim.png",
                            Price = 25m,
                            RAM = 8,
                            ReleaseDate = new DateTime(2021, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ScreenshotGame1 = "Valheim_screenshotGame_1.png",
                            ScreenshotGame2 = "Valheim_screenshotGame_2.png",
                            ScreenshotGame3 = "Valheim_screenshotGame_3.png",
                            ScreenshotGame4 = "Valheim_screenshotGame_4.png",
                            VRAM = "GeForce GTX 950 or Radeon HD 7970"
                        },
                        new
                        {
                            Id = 404,
                            CPU = "Dual core (Intel Pentium D или лучше)",
                            DateAddedSite = new DateTime(2022, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DescriptionG = "Действие игры разворачивается во времена Третьего крестового похода, а именно в 1191 году. В настоящем времени бармена Дезмонда Майлса, главного героя, похищает корпорация «Абстерго», которая с помощью Анимуса, машины для извлечения генетической памяти, хочет найти артефакт Первой Цивилизации. В курс дела Дезмонда вводят учёный Уоррен Видик и его ассистентка Люси Стиллман. Они рассказывают ему, что он является потомком ассасина Альтаира ибн-Ла-Ахада, который обнаружил артефакт, и через него хотят узнать местонахождение артефакта.",
                            Developersid = 114,
                            Features = "Для одного игрока",
                            GameWeight = 16,
                            Ganresid = 203,
                            LinkTrailerGame = "RjQ6ZtyXoA0",
                            NameGame = "Assassin’s Creed",
                            OS = "Windows XP/Vista / Windows 7",
                            Platformsid = 301,
                            Poster = "Assassin1.png",
                            Price = 13m,
                            RAM = 2,
                            ReleaseDate = new DateTime(2007, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ScreenshotGame1 = "Assassin1_screenshotGame_1.png",
                            ScreenshotGame2 = "Assassin1_screenshotGame_2.png",
                            ScreenshotGame3 = "Assassin1_screenshotGame_3.png",
                            ScreenshotGame4 = "Assassin1_screenshotGame_4.png",
                            VRAM = "256MB с поддержкой Shader Model 3.0 или выше"
                        },
                        new
                        {
                            Id = 405,
                            CPU = "Intel Core i5-6600K",
                            DateAddedSite = new DateTime(2022, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DescriptionG = "События игры происходят в 2102 году в Западной Виргинии. Игрок — житель Убежища 76 (Резидент), проспавший выход на поверхность. Находя голозаписи Смотрительницы Убежища, которая покинула его раньше всех, игрок понимает, что над регионом нависла опасность в виде горелых — людей, заражённых инфекцией, превращающихся со временем в неподвижные статуи, которые, распадаясь, разносят заразу, заражая как и других существ, так и людей. Как выясняется, источник той болезни — зверожоги. Это мутировавшие драконоподобные летучие мыши, обитавшие под землёй. По мере продвижения по сюжету и выполнению квестов игрок создаёт вакцину против чумы зверожогов. Далее Резиденту предстоит проникнуть в хорошо спрятанный бункер «Анклава» — бывшего правительства США. Там ему встречается МОДУС — суперкомпьютер, который убил всех членов Анклава в качестве мести за попытку уничтожить его. МОДУС рассказывает о ядерных ракетах и как их запустить. Игрок завладевает кодами запуска и, проведя бомбардировку главного разлома, откуда вылезают зверожоги, сталкивается с ещё более страшной угрозой — маткой зверожогов. В тяжёлом бою её удаётся убить, и зверожоги, оставшись без главы, разлетаются подобно муравьям, оставшимся без королевы.",
                            Developersid = 114,
                            Features = "Для нескольких игроков",
                            GameWeight = 60,
                            Ganresid = 203,
                            LinkTrailerGame = "EtiVOmFiWA0",
                            NameGame = "Fallout 76",
                            OS = "Windows 7/8/8.1/10",
                            Platformsid = 301,
                            Poster = "Fallout76.png",
                            Price = 70m,
                            RAM = 8,
                            ReleaseDate = new DateTime(2018, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ScreenshotGame1 = "Fallout76Screenshot_1.png",
                            ScreenshotGame2 = "Fallout76Screenshot_2.png",
                            ScreenshotGame3 = "Fallout76Screenshot_3.png",
                            ScreenshotGame4 = "Fallout76Screenshot_4.png",
                            VRAM = "NVIDIA GeForce GTX 780"
                        },
                        new
                        {
                            Id = 406,
                            CPU = "AMD Ryzen™ 5 2600 (Intel i7-4770)",
                            DateAddedSite = new DateTime(2022, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DescriptionG = "Всеми любимый «шутер с базиллионами лута» возвращается, чтобы порадовать вас несметным множеством убойных стволов и новым крышесносным приключением! Вам предстоит покорить доселе не виданные миры, играя за одного из четырёх новых искателей Хранилища – нереально крутых перцев, у каждого из которых уникальные навыки, способности и модификации. Действуя в одиночку или в компании друзей, вы должны будете дать бой яростным противникам, нагрести побольше трофеев и спасти свой дом от безжалостных психопатов, возглавляющих самую опасную секту в галактике.",
                            Developersid = 114,
                            Features = "Для одного игрока / Для нескольких игроков",
                            GameWeight = 75,
                            Ganresid = 203,
                            LinkTrailerGame = "tQj8CLKoTCs",
                            NameGame = "Borderlands 3",
                            OS = "Windows 7/10 (с последней версией пакета обновлений)",
                            Platformsid = 301,
                            Poster = "Borderlands3.png",
                            Price = 70m,
                            RAM = 16,
                            ReleaseDate = new DateTime(2019, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ScreenshotGame1 = "borderlands3_screenshot_1.png",
                            ScreenshotGame2 = "borderlands3_screenshot_2.png",
                            ScreenshotGame3 = "borderlands3_screenshot_3.png",
                            ScreenshotGame4 = "borderlands3_screenshot_4.png",
                            VRAM = "AMD Radeon™ RX 590 (NVIDIA GeForce GTX 1060 6 ГБ)"
                        },
                        new
                        {
                            Id = 407,
                            CPU = "Intel Core i7 3770 с частотой 3,4 ГГц / AMD FX-8350 с частотой 4 ГГц",
                            DateAddedSite = new DateTime(2022, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DescriptionG = "Станьте профессиональным убийцей монстров и отправляйтесь в приключение эпических масштабов! После своего выхода игра «Ведьмак 3: Дикая Охота» (The Witcher 3: Wild Hunt) стала настоящей классикой, получив более 250 наград в номинации «Игра года». Вас ждёт более 100 часов грандиозного приключения по открытому миру, а также сюжетные расширения, которые растянутся ещё на 50 часов игры. Это издание включает в себя весь дополнительный контент: новое оружие, броню, экипировку для компаньонов, новый режим игры и побочные квесты.",
                            Developersid = 114,
                            Features = "Для одного игрока",
                            GameWeight = 77,
                            Ganresid = 203,
                            LinkTrailerGame = "4ndIeNusRLI",
                            NameGame = "Ведьмак 3: Дикая Охота",
                            OS = "64-разрядная Windows 7, 64-разрядная Windows 8 (8.1) или 64-разрядная Windows 10",
                            Platformsid = 301,
                            Poster = "Witcher3.png",
                            Price = 50m,
                            RAM = 8,
                            ReleaseDate = new DateTime(2014, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ScreenshotGame1 = "witcher3__screenshot_1.png",
                            ScreenshotGame2 = "witcher3__screenshot_2.png",
                            ScreenshotGame3 = "witcher3__screenshot_3.png",
                            ScreenshotGame4 = "witcher3__screenshot_4.png",
                            VRAM = "NVIDIA GPU GeForce GTX 770 / AMD GPU Radeon R9 290"
                        },
                        new
                        {
                            Id = 408,
                            CPU = "Intel® Core™ i7-4770K / AMD Ryzen 5 1500x",
                            DateAddedSite = new DateTime(2022, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DescriptionG = "Америка, 1899 год. Артур Морган и другие подручные Датча ван дер Линде вынуждены пуститься в бега. Их банде предстоит участвовать в кражах, грабежах и перестрелках в самом сердце Америки. За ними по пятам идут федеральные агенты и лучшие в стране охотники за головами, а саму банду разрывают внутренние противоречия. Артуру предстоит выбрать, что для него важнее: его собственные идеалы или же верность людям, которые его взрастили.",
                            Developersid = 114,
                            Features = "Для одного игрока / Для нескольких игроков",
                            GameWeight = 150,
                            Ganresid = 203,
                            LinkTrailerGame = "0kqEBOZaP94",
                            NameGame = "Red Dead Redemption 2",
                            OS = "Windows 10 - April 2018 Update (v1803)",
                            Platformsid = 301,
                            Poster = "rdr2.png",
                            Price = 80m,
                            RAM = 12,
                            ReleaseDate = new DateTime(2019, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ScreenshotGame1 = "RDR2_screenshot_1.png",
                            ScreenshotGame2 = "RDR2_screenshot_2.png",
                            ScreenshotGame3 = "RDR2_screenshot_3.png",
                            ScreenshotGame4 = "RDR2_screenshot_4.png",
                            VRAM = "Nvidia GeForce GTX 1060 6 ГБ / AMD Radeon RX 480 4 ГБ"
                        },
                        new
                        {
                            Id = 409,
                            CPU = "AMD Ryzen 5 1500X | Intel Core I7-4790",
                            DateAddedSite = new DateTime(2022, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DescriptionG = "Вашингтон на грани катастрофы. Нашему обществу угрожает беззаконие и нестабильность, и слухи о перевороте в Капитолии только способствуют хаосу. Мы крайне нуждаемся в каждом действующем агенте группы Division — только с ними мы сможем спасти город, пока не поздно.",
                            Developersid = 114,
                            Features = "Для нескольких игроков",
                            GameWeight = 4,
                            Ganresid = 203,
                            LinkTrailerGame = "ssyC-QwcPug",
                            NameGame = "Tom Clancy's The Division®2",
                            OS = "Windows 7/8/10",
                            Platformsid = 301,
                            Poster = "Division2.png",
                            Price = 40m,
                            RAM = 8,
                            ReleaseDate = new DateTime(2019, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ScreenshotGame1 = "thedivision2_screenshot_1.png",
                            ScreenshotGame2 = "thedivision2_screenshot_2.png",
                            ScreenshotGame3 = "thedivision2_screenshot_3.png",
                            ScreenshotGame4 = "thedivision2_screenshot_4.png",
                            VRAM = "AMD RX 480 NVIDIA GeForce GTX 970"
                        },
                        new
                        {
                            Id = 410,
                            CPU = "Intel Core i5-2300 2,8 ГГц/AMD Phenom II X4 945 3 ГГц",
                            DateAddedSite = new DateTime(2022, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DescriptionG = "Добро пожаловать в игру нового поколения с открытым миром! Вы — единственный выживший из убежища 111, оказавшийся в мире, разрушенном ядерной войной. Каждый миг вы сражаетесь за выживание, каждое решение может стать последним. Но именно от вас зависит судьба пустошей. Добро пожаловать домой.",
                            Developersid = 114,
                            Features = "Для одного игрока",
                            GameWeight = 60,
                            Ganresid = 203,
                            LinkTrailerGame = "ErgtR14-MV8",
                            NameGame = "Fallout 4",
                            OS = "Windows 7/8/10/11 (необходима 64-битная ОС)",
                            Platformsid = 301,
                            Poster = "Fallout4.png",
                            Price = 50m,
                            RAM = 8,
                            ReleaseDate = new DateTime(2015, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ScreenshotGame1 = "fallout4_1.png",
                            ScreenshotGame2 = "fallout4_2.png",
                            ScreenshotGame3 = "fallout4_3.png",
                            ScreenshotGame4 = "fallout4_4.png",
                            VRAM = "NVIDIA GTX 550 Ti 2 Гб/AMD Radeon HD 7870 2 Гб"
                        });
                });

            modelBuilder.Entity("Microservice.Products.Data.Entities.GamesKeys", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Gamesid")
                        .HasColumnType("int");

                    b.Property<string>("Key_game")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Gamesid");

                    b.ToTable("GamesKeys");

                    b.HasData(
                        new
                        {
                            Id = 501,
                            Gamesid = 401,
                            Key_game = "GHZNAZXB-ZXNHDANX-IOEJZNDG-MSHSJWUJ"
                        },
                        new
                        {
                            Id = 502,
                            Gamesid = 402,
                            Key_game = "IEUWYHDB-DKSNZMEU-XHSKDMWO-XMBADHNR"
                        },
                        new
                        {
                            Id = 503,
                            Gamesid = 403,
                            Key_game = "ZXNEYTAB-KFBSYDBF-XHSNWDAC-DNWHDDEWE"
                        },
                        new
                        {
                            Id = 504,
                            Gamesid = 404,
                            Key_game = "FJNVCDKM-KLWDEIRU-SXJNHWEG-SAJKFHJD"
                        },
                        new
                        {
                            Id = 505,
                            Gamesid = 405,
                            Key_game = "GRHUSDNM-CXJNWGVD-DJNCLKWD-WEYUXZBN"
                        },
                        new
                        {
                            Id = 506,
                            Gamesid = 406,
                            Key_game = "RTIOSDBN-REHJNMSAX-REUYBSXN-DSHJVBWE"
                        },
                        new
                        {
                            Id = 507,
                            Gamesid = 407,
                            Key_game = "REYUCBXN-YUEWVSBA-SAHJWVBQ-OXZIQVWB"
                        },
                        new
                        {
                            Id = 508,
                            Gamesid = 408,
                            Key_game = "VFBNYTWE-DSHJWQVB-DISUQWVB-KSJAEWBV"
                        },
                        new
                        {
                            Id = 509,
                            Gamesid = 409,
                            Key_game = "CXBNWJHE-KFJHDHJWFEK-HWEJRF-WHKFEUJ"
                        },
                        new
                        {
                            Id = 510,
                            Gamesid = 410,
                            Key_game = "WFOQEUIFHW-KWEFHJ-BEWFJH-WEFVHGJ"
                        });
                });

            modelBuilder.Entity("Microservice.Products.Data.Entities.Ganres", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("NameGanres")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Ganres");

                    b.HasData(
                        new
                        {
                            Id = 201,
                            NameGanres = "Экшн"
                        },
                        new
                        {
                            Id = 202,
                            NameGanres = "Приключения"
                        },
                        new
                        {
                            Id = 203,
                            NameGanres = "RPG"
                        },
                        new
                        {
                            Id = 204,
                            NameGanres = "Симуляторы"
                        },
                        new
                        {
                            Id = 205,
                            NameGanres = "Спорт"
                        },
                        new
                        {
                            Id = 206,
                            NameGanres = "Гонки"
                        },
                        new
                        {
                            Id = 207,
                            NameGanres = "Казуал"
                        });
                });

            modelBuilder.Entity("Microservice.Products.Data.Entities.Platforms", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("NamePlatform")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Platforms");

                    b.HasData(
                        new
                        {
                            Id = 301,
                            NamePlatform = "Steam"
                        },
                        new
                        {
                            Id = 302,
                            NamePlatform = "Origin"
                        },
                        new
                        {
                            Id = 303,
                            NamePlatform = "Battle.net"
                        },
                        new
                        {
                            Id = 304,
                            NamePlatform = "RockStar Launcher"
                        },
                        new
                        {
                            Id = 305,
                            NamePlatform = "Epic Games Launcher"
                        },
                        new
                        {
                            Id = 306,
                            NamePlatform = "Ubisoft Connect"
                        });
                });

            modelBuilder.Entity("Microservice.Products.Data.Entities.Shares", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<decimal>("DiscountPrice")
                        .HasPrecision(10, 2)
                        .HasColumnType("decimal(10,2)");

                    b.Property<int>("Gamesid")
                        .HasColumnType("int");

                    b.Property<string>("NameImageSlider")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Gamesid");

                    b.ToTable("Shares");

                    b.HasData(
                        new
                        {
                            Id = 701,
                            DiscountPrice = 30m,
                            Gamesid = 401,
                            NameImageSlider = "2077.png"
                        },
                        new
                        {
                            Id = 702,
                            DiscountPrice = 55m,
                            Gamesid = 405,
                            NameImageSlider = "Fallout76.png"
                        },
                        new
                        {
                            Id = 703,
                            DiscountPrice = 70m,
                            Gamesid = 408,
                            NameImageSlider = "rdr2.png"
                        },
                        new
                        {
                            Id = 704,
                            DiscountPrice = 30m,
                            Gamesid = 407,
                            NameImageSlider = "Wicher3.png"
                        });
                });

            modelBuilder.Entity("Microservice.Products.Data.Entities.Games", b =>
                {
                    b.HasOne("Microservice.Products.Data.Entities.Developers", "Developers")
                        .WithMany()
                        .HasForeignKey("Developersid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microservice.Products.Data.Entities.Ganres", "Ganres")
                        .WithMany("GanresGames")
                        .HasForeignKey("Ganresid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microservice.Products.Data.Entities.Platforms", "Platforms")
                        .WithMany()
                        .HasForeignKey("Platformsid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Developers");

                    b.Navigation("Ganres");

                    b.Navigation("Platforms");
                });

            modelBuilder.Entity("Microservice.Products.Data.Entities.GamesKeys", b =>
                {
                    b.HasOne("Microservice.Products.Data.Entities.Games", "Games")
                        .WithMany()
                        .HasForeignKey("Gamesid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Games");
                });

            modelBuilder.Entity("Microservice.Products.Data.Entities.Shares", b =>
                {
                    b.HasOne("Microservice.Products.Data.Entities.Games", "Games")
                        .WithMany()
                        .HasForeignKey("Gamesid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Games");
                });

            modelBuilder.Entity("Microservice.Products.Data.Entities.Ganres", b =>
                {
                    b.Navigation("GanresGames");
                });
#pragma warning restore 612, 618
        }
    }
}
