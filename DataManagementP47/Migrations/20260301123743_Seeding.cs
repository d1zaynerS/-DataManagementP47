using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataManagementP47.Migrations
{
    /// <inheritdoc />
    public partial class Seeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Birthdate", "FirmId", "Name" },
                values: new object[,]
                {
                    { new Guid("04d0ac0b-86ce-4321-ae43-a4c58556629f"), new DateTime(1996, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c6d1ee0e-cb5b-4b13-96a9-f87714a27c2a"), "Данькевич Будислав" },
                    { new Guid("063d68ab-fc23-4600-ad80-504e1ef8b0d5"), new DateTime(1987, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4e96d0a1-2ba9-411a-afd7-27bceb862c93"), "Завітневич Йосипа" },
                    { new Guid("066744b5-dac1-4f37-bfcf-8c6f25d3a496"), new DateTime(1993, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("48f0708a-11d4-4648-9ac7-12a1fff5e1e7"), "Криштопович Еміль" },
                    { new Guid("06782fcf-2c8c-4235-aeeb-19f11d0758f0"), new DateTime(1985, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c6d1ee0e-cb5b-4b13-96a9-f87714a27c2a"), "Досенко Барбара" },
                    { new Guid("097a2029-dce9-42f9-8e3f-57802930426e"), new DateTime(1981, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4e96d0a1-2ba9-411a-afd7-27bceb862c93"), "Адамчук Еразм" },
                    { new Guid("0993de6f-0509-4c57-98be-a27cf201d6e4"), new DateTime(2004, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8cef13dc-8ccd-4ef9-ac39-3b1f4860a2e5"), "Ярова Бажана" },
                    { new Guid("0d0858e7-0a8e-49e1-80ac-eaf9abcfe1c8"), new DateTime(1992, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("48f0708a-11d4-4648-9ac7-12a1fff5e1e7"), "Бусленко Йосифата" },
                    { new Guid("0f267240-d301-4584-96b9-45e336d8007e"), new DateTime(1992, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3d4e5f82-4d89-4620-8023-9e90473b8c2d"), "Ковчі Любомисл" },
                    { new Guid("0f2e1978-f9e7-4a94-82ed-446724bb9a4b"), new DateTime(2001, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4e96d0a1-2ba9-411a-afd7-27bceb862c93"), "Любович Еммануїл" },
                    { new Guid("0f5e73d3-83bd-4354-93e2-1db6854f4518"), new DateTime(1988, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("50caad3a-5055-4b94-90ce-72886cc9d5b0"), "Верхратський Цвітан" },
                    { new Guid("1ef0f1fa-6624-45d9-9dcd-28204bd8c996"), new DateTime(1996, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("48f0708a-11d4-4648-9ac7-12a1fff5e1e7"), "Куликовська Елла" },
                    { new Guid("205a8ff3-cfea-4067-80cf-e5667bac231c"), new DateTime(1977, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("6d2a6a6a-488e-488b-8d2f-c77f1b3416a3"), "Ус Шарлота" },
                    { new Guid("236dbc89-e48a-4748-a7c5-cf42f37cc016"), new DateTime(1971, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("6d2a6a6a-488e-488b-8d2f-c77f1b3416a3"), "Євецька Цецілія" },
                    { new Guid("23eeb88a-8851-48f0-bb30-a9889a3f7471"), new DateTime(2003, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3d4e5f82-4d89-4620-8023-9e90473b8c2d"), "Воєвода Іоанн" },
                    { new Guid("2b3afaac-b3b2-4eab-9cff-2064d51d8769"), new DateTime(1998, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3d4e5f82-4d89-4620-8023-9e90473b8c2d"), "Янчик Еріка" },
                    { new Guid("2bbafef0-3367-4561-95c9-ff789318cc23"), new DateTime(1987, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("fb1286a8-2d7f-436b-bee1-8fadaaaf104b"), "Юденко Інга" },
                    { new Guid("2e8f2133-1a01-42dc-aefd-a3a651510108"), new DateTime(2001, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c6d1ee0e-cb5b-4b13-96a9-f87714a27c2a"), "Яремко Яр" },
                    { new Guid("306fd89d-e0f0-42bb-addd-d3abbfb1eac6"), new DateTime(1994, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("6d2a6a6a-488e-488b-8d2f-c77f1b3416a3"), "Блажевська Шушана" },
                    { new Guid("3178af87-e786-4138-ad91-b74edd3acf48"), new DateTime(2001, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3d4e5f82-4d89-4620-8023-9e90473b8c2d"), "Цимбал Дана" },
                    { new Guid("35815e16-769b-430b-8c64-ca7f2b23189c"), new DateTime(1992, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4e96d0a1-2ba9-411a-afd7-27bceb862c93"), "Гриб Русан" },
                    { new Guid("35ac3ab8-bf58-4291-b671-ff2f118893c3"), new DateTime(1976, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("48f0708a-11d4-4648-9ac7-12a1fff5e1e7"), "Косьяненко Пор" },
                    { new Guid("3687ff73-37c2-4567-b5fa-4bfe4ee7fadd"), new DateTime(1997, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8cef13dc-8ccd-4ef9-ac39-3b1f4860a2e5"), "Гуляницька Чеслава" },
                    { new Guid("3920757e-6aed-465d-8d02-3f48f974b1c9"), new DateTime(1979, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("50caad3a-5055-4b94-90ce-72886cc9d5b0"), "Громницький Людомил" },
                    { new Guid("3df43ff3-9a36-423f-93e4-fdfb9490caf1"), new DateTime(2002, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("48f0708a-11d4-4648-9ac7-12a1fff5e1e7"), "Щаслива Альбертина" },
                    { new Guid("3fb7a910-d37b-4363-89a5-150bc7199f5e"), new DateTime(1984, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("fb1286a8-2d7f-436b-bee1-8fadaaaf104b"), "Біба Ус" },
                    { new Guid("3ffc8f03-aa6e-4fea-b83a-9791d2bf8ea3"), new DateTime(2000, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("fb1286a8-2d7f-436b-bee1-8fadaaaf104b"), "Жевченко Цвітана" },
                    { new Guid("435f76ba-3157-4472-9f5c-360334c3d9a0"), new DateTime(1984, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("6d2a6a6a-488e-488b-8d2f-c77f1b3416a3"), "Хомич Златоус" },
                    { new Guid("45632874-beb7-401d-b92a-2721df4e8fa8"), new DateTime(1983, 9, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3d4e5f82-4d89-4620-8023-9e90473b8c2d"), "Ніколайчук Ус" },
                    { new Guid("47ce489f-4ed5-433e-9205-390bc5d5cafe"), new DateTime(1986, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("931dfb69-edfa-4fe8-8c7d-1edd00d22498"), "Щорс Шушана" },
                    { new Guid("4a7174ce-7b95-4260-bc8c-b5e3cc028073"), new DateTime(2008, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("fb1286a8-2d7f-436b-bee1-8fadaaaf104b"), "Савчак Сарра" },
                    { new Guid("4e236c70-b672-4e11-8f5b-87093e82b29e"), new DateTime(1973, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("fb1286a8-2d7f-436b-bee1-8fadaaaf104b"), "Іваненко Єва" },
                    { new Guid("4e340e5b-6071-42e8-a748-1e758d1677ca"), new DateTime(1985, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("50caad3a-5055-4b94-90ce-72886cc9d5b0"), "Ящуржинська Дзвенимира" },
                    { new Guid("53cae081-7ab0-4761-a4da-5a6d21496d04"), new DateTime(2008, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8cef13dc-8ccd-4ef9-ac39-3b1f4860a2e5"), "Лобай Цецілія" },
                    { new Guid("548bf6ca-c0f0-418a-b360-09c29ae6b113"), new DateTime(1979, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("6d2a6a6a-488e-488b-8d2f-c77f1b3416a3"), "Жданович Радомир" },
                    { new Guid("6128b1bb-018a-4c51-b410-06657b786fac"), new DateTime(1972, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("931dfb69-edfa-4fe8-8c7d-1edd00d22498"), "Єщенко Уляна" },
                    { new Guid("643b15e8-b083-4ddb-a060-8446d1493b51"), new DateTime(2006, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3d4e5f82-4d89-4620-8023-9e90473b8c2d"), "Науменко Жадан" },
                    { new Guid("67ccacf8-b71c-4c37-8cb0-30cdefc7fbd9"), new DateTime(1975, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("6d2a6a6a-488e-488b-8d2f-c77f1b3416a3"), "Тімченко Шерлок" },
                    { new Guid("6b2d88b4-7fdc-4ede-bb51-7658e7ca910f"), new DateTime(2002, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("50caad3a-5055-4b94-90ce-72886cc9d5b0"), "Журавленко Жозефіна" },
                    { new Guid("6c1ae71e-85e0-4408-9552-45331a4e5bd1"), new DateTime(1988, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3d4e5f82-4d89-4620-8023-9e90473b8c2d"), "Шапаренко Шаміль" },
                    { new Guid("6f7632eb-55ab-4e3c-a326-2a042e2d4627"), new DateTime(1996, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("6d2a6a6a-488e-488b-8d2f-c77f1b3416a3"), "Щаслива Цецілія" },
                    { new Guid("74025549-7f8c-459d-b748-399663b8efb9"), new DateTime(1973, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("48f0708a-11d4-4648-9ac7-12a1fff5e1e7"), "Ілінський Оримир" },
                    { new Guid("7551321a-09a6-4e5e-8d83-599fa4907c8a"), new DateTime(2005, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4e96d0a1-2ba9-411a-afd7-27bceb862c93"), "Юцевич Сологуба" },
                    { new Guid("76f2594c-a006-44b3-afaa-ffcfa0159c2d"), new DateTime(1985, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8cef13dc-8ccd-4ef9-ac39-3b1f4860a2e5"), "Юрченко Параскевія" },
                    { new Guid("7ccbbc76-adc1-40e9-8787-fc0a7fa4b2f4"), new DateTime(1998, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4e96d0a1-2ba9-411a-afd7-27bceb862c93"), "Ерстенюк Дарина" },
                    { new Guid("82f8dba2-1858-4e1a-abd2-a59df6965f9d"), new DateTime(1989, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("48f0708a-11d4-4648-9ac7-12a1fff5e1e7"), "Устиянович Улита" },
                    { new Guid("841f06fe-3264-4bc3-beef-8fa92cee2293"), new DateTime(1988, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("931dfb69-edfa-4fe8-8c7d-1edd00d22498"), "Якобовський Мстивой" },
                    { new Guid("863d17e9-d16b-46d0-a69e-d12e1447a706"), new DateTime(1999, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("48f0708a-11d4-4648-9ac7-12a1fff5e1e7"), "Онищук Медомир" },
                    { new Guid("87329e18-3d28-4a3d-a141-74c9fb8705ec"), new DateTime(1973, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4e96d0a1-2ba9-411a-afd7-27bceb862c93"), "Стельмащук Васса" },
                    { new Guid("8759ee27-37c9-4ceb-b931-a548f17f4c37"), new DateTime(1984, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c6d1ee0e-cb5b-4b13-96a9-f87714a27c2a"), "Гринчак Доморад" },
                    { new Guid("8999366a-b868-4a84-a934-ed60b694b189"), new DateTime(1977, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("48f0708a-11d4-4648-9ac7-12a1fff5e1e7"), "Омельчук Остромов" },
                    { new Guid("8a6c2dae-5f0e-4a09-9d12-14eacaa5a33d"), new DateTime(1985, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("fb1286a8-2d7f-436b-bee1-8fadaaaf104b"), "Їжакевич Оріяна" },
                    { new Guid("8d68bc4c-7bf8-40fe-9a81-e04b3d91497b"), new DateTime(2003, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c6d1ee0e-cb5b-4b13-96a9-f87714a27c2a"), "Пилипишин Щастибог" },
                    { new Guid("8dfab2e7-d100-4e53-b94c-e2bbbc363673"), new DateTime(1978, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8cef13dc-8ccd-4ef9-ac39-3b1f4860a2e5"), "Онофрійчук Никодим" },
                    { new Guid("96fb6838-6208-4c31-a77f-bd11fc06eb1c"), new DateTime(1994, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1ea7d698-924b-47df-b574-88f4f71306e6"), "Гринішак Шанетта" },
                    { new Guid("978dc6f9-70ee-49d8-96bc-37e79e52a3c2"), new DateTime(1995, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("50caad3a-5055-4b94-90ce-72886cc9d5b0"), "Іванців Роксолан" },
                    { new Guid("98af6726-7943-4de4-8aa7-8d91ecca74ff"), new DateTime(2005, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("931dfb69-edfa-4fe8-8c7d-1edd00d22498"), "Рябченко Леля" },
                    { new Guid("9b3dc264-8993-44a2-ac94-5df4d2f4ae51"), new DateTime(1979, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("50caad3a-5055-4b94-90ce-72886cc9d5b0"), "Чекман Вишеслав" },
                    { new Guid("9e1ac0ee-c2b5-4302-9840-0f94e598aad1"), new DateTime(1997, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("931dfb69-edfa-4fe8-8c7d-1edd00d22498"), "Каніщенко Еммануїл" },
                    { new Guid("a034f7db-026e-4389-adb8-9985ef337703"), new DateTime(1973, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("6d2a6a6a-488e-488b-8d2f-c77f1b3416a3"), "Трух Іоанн" },
                    { new Guid("a060d3e8-6156-4a6a-9826-b15da3ec2854"), new DateTime(1988, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c6d1ee0e-cb5b-4b13-96a9-f87714a27c2a"), "Підопригора Зорян" },
                    { new Guid("a3cda1e5-647d-44b9-a6ac-6aef43b4cda9"), new DateTime(1996, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("6d2a6a6a-488e-488b-8d2f-c77f1b3416a3"), "Тишик Едуард" },
                    { new Guid("a4edd7c8-155f-478d-b4f8-2512e2565491"), new DateTime(2002, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("6d2a6a6a-488e-488b-8d2f-c77f1b3416a3"), "Філіпчук Харитя" },
                    { new Guid("a620a4f3-41fc-4409-9df4-71129755bb6a"), new DateTime(1992, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("931dfb69-edfa-4fe8-8c7d-1edd00d22498"), "Кушнір Борис" },
                    { new Guid("a865affe-efc9-4419-9954-2db7b1191dbd"), new DateTime(1978, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1ea7d698-924b-47df-b574-88f4f71306e6"), "Кулинич Жадана" },
                    { new Guid("afde137c-546b-493b-9353-52715d764814"), new DateTime(2007, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("6d2a6a6a-488e-488b-8d2f-c77f1b3416a3"), "Щуренко Голубко" },
                    { new Guid("b483817a-69d4-4c3a-b4a7-5b081e4d0de5"), new DateTime(1995, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("6d2a6a6a-488e-488b-8d2f-c77f1b3416a3"), "Іщак Фотинія" },
                    { new Guid("b5df7f42-cb51-4f23-afc9-2f9a1f82db87"), new DateTime(2007, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1ea7d698-924b-47df-b574-88f4f71306e6"), "Фещак Осипа" },
                    { new Guid("b6d219e2-a832-4720-8443-fff68d5fb805"), new DateTime(1998, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1ea7d698-924b-47df-b574-88f4f71306e6"), "Губ`як Шарлота" },
                    { new Guid("b7a9f3f1-db7c-42e8-ac0a-49c8ea04f5c1"), new DateTime(1995, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3d4e5f82-4d89-4620-8023-9e90473b8c2d"), "Їжак Цецілія" },
                    { new Guid("b8d62476-d71f-451b-b0d3-30df11213f3d"), new DateTime(1996, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1ea7d698-924b-47df-b574-88f4f71306e6"), "Деряжний Щавелина" },
                    { new Guid("bc9c0806-f852-4aae-8481-0e49b145ea11"), new DateTime(1986, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8cef13dc-8ccd-4ef9-ac39-3b1f4860a2e5"), "Мусієнко Яромира" },
                    { new Guid("bd23de9d-8a4e-4849-8796-39cef4a980f5"), new DateTime(1984, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("48f0708a-11d4-4648-9ac7-12a1fff5e1e7"), "Горох Хриса" },
                    { new Guid("c009988a-470a-4503-9321-068e66557ac1"), new DateTime(1973, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3d4e5f82-4d89-4620-8023-9e90473b8c2d"), "Худенко Іларія" },
                    { new Guid("c15801bb-08c1-4dbb-9dc9-e37dcfd7f462"), new DateTime(1982, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("48f0708a-11d4-4648-9ac7-12a1fff5e1e7"), "Їжак Гордислав" },
                    { new Guid("cb072571-1053-4f0e-ae39-8088e14f92af"), new DateTime(1972, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("50caad3a-5055-4b94-90ce-72886cc9d5b0"), "Шкурган Пантелеймон" },
                    { new Guid("cc8dd042-362e-4d5f-9a1a-fca88c9932b9"), new DateTime(1981, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("931dfb69-edfa-4fe8-8c7d-1edd00d22498"), "Запорожець Радослав" },
                    { new Guid("cca1bca0-3346-48e6-97a0-d6be43372072"), new DateTime(2000, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("50caad3a-5055-4b94-90ce-72886cc9d5b0"), "Хаварівська Карина" },
                    { new Guid("cd711a28-3821-4482-b2f5-4de761371b6c"), new DateTime(1980, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4e96d0a1-2ba9-411a-afd7-27bceb862c93"), "Щерба Жадан" },
                    { new Guid("cd95edcd-0319-424b-a3ce-27d97f90cfb3"), new DateTime(1975, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c6d1ee0e-cb5b-4b13-96a9-f87714a27c2a"), "Височан Орина" },
                    { new Guid("ce1955ce-a251-4eb6-ac90-664624193d34"), new DateTime(1997, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("50caad3a-5055-4b94-90ce-72886cc9d5b0"), "Ірванець Немира" },
                    { new Guid("d4cc884c-cbc8-466c-9e85-dc5f74fdaf99"), new DateTime(1983, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("6d2a6a6a-488e-488b-8d2f-c77f1b3416a3"), "Олешко Адріан" },
                    { new Guid("d636f812-b2ef-4d1e-aeb6-63d240a6a5ce"), new DateTime(1977, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1ea7d698-924b-47df-b574-88f4f71306e6"), "Їжакевич Цвітана" },
                    { new Guid("d98116e4-bf64-48fd-866b-85cea4d0c793"), new DateTime(2000, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1ea7d698-924b-47df-b574-88f4f71306e6"), "Циба Горпина" },
                    { new Guid("d9b7f2a3-ecb8-4faf-9956-c69c8e00597c"), new DateTime(1996, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1ea7d698-924b-47df-b574-88f4f71306e6"), "Полтавець Квітка" },
                    { new Guid("de3bc158-4a16-4b4c-a74b-06b8522ac00b"), new DateTime(2000, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("6d2a6a6a-488e-488b-8d2f-c77f1b3416a3"), "Андрейчук Родан" },
                    { new Guid("def23115-c759-4495-aef5-048bd4b68f67"), new DateTime(1972, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("48f0708a-11d4-4648-9ac7-12a1fff5e1e7"), "Ерстенюк Йосип" },
                    { new Guid("df451daf-a4a5-4655-82a1-73407874a076"), new DateTime(1990, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3d4e5f82-4d89-4620-8023-9e90473b8c2d"), "Панасюк Йомер" },
                    { new Guid("dffdf291-c6d6-4af2-93b2-f452531c5f95"), new DateTime(2002, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("fb1286a8-2d7f-436b-bee1-8fadaaaf104b"), "Безсмертний Євгеній" },
                    { new Guid("e6e8d542-eef1-409d-aadb-8f36b4a80f7a"), new DateTime(1980, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("6d2a6a6a-488e-488b-8d2f-c77f1b3416a3"), "Їжак Чесмил" },
                    { new Guid("e9a1c852-affd-4742-9542-958b8975b527"), new DateTime(1984, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1ea7d698-924b-47df-b574-88f4f71306e6"), "Їжак Хотибор" },
                    { new Guid("eb540332-9d36-49ed-85b5-deed6930df58"), new DateTime(1992, 9, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("fb1286a8-2d7f-436b-bee1-8fadaaaf104b"), "Манило Юдихва" },
                    { new Guid("eb5bc95f-b3f8-49f8-9cff-c6d169a52e48"), new DateTime(1970, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("48f0708a-11d4-4648-9ac7-12a1fff5e1e7"), "Устимович Пребислав" },
                    { new Guid("f26d87cb-3993-469e-93a5-ce2c3da12336"), new DateTime(1972, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3d4e5f82-4d89-4620-8023-9e90473b8c2d"), "Філіпенко Полель" },
                    { new Guid("f799d7c6-4ab5-4243-af1f-e56e0564ded3"), new DateTime(1982, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("6d2a6a6a-488e-488b-8d2f-c77f1b3416a3"), "Синько Федір" },
                    { new Guid("f9a700d0-7be2-4241-a187-4a1acb737433"), new DateTime(1985, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1ea7d698-924b-47df-b574-88f4f71306e6"), "Їжак Земислав" },
                    { new Guid("fc32e420-0aa5-490a-8e2b-a2978208595e"), new DateTime(1999, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("50caad3a-5055-4b94-90ce-72886cc9d5b0"), "Семеніхін Лаврін" },
                    { new Guid("fc384f1a-5bed-4a5e-b677-78aa9fbbc673"), new DateTime(1990, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8cef13dc-8ccd-4ef9-ac39-3b1f4860a2e5"), "Савойка Цецілія" },
                    { new Guid("fc440f87-4320-4f85-bb2c-4075f14ed755"), new DateTime(2006, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("48f0708a-11d4-4648-9ac7-12a1fff5e1e7"), "Мицик Чеслава" },
                    { new Guid("fe24a19a-f393-4f75-8b0d-a407ba89691d"), new DateTime(1982, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3d4e5f82-4d89-4620-8023-9e90473b8c2d"), "Цимбалюк Шерлок" }
                });

            migrationBuilder.InsertData(
                table: "Firms",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("1ea7d698-924b-47df-b574-88f4f71306e6"), "АТ Крамниця" },
                    { new Guid("3d4e5f82-4d89-4620-8023-9e90473b8c2d"), "АТ Маркетолог" },
                    { new Guid("48f0708a-11d4-4648-9ac7-12a1fff5e1e7"), "ФОП Торговенко" },
                    { new Guid("4e96d0a1-2ba9-411a-afd7-27bceb862c93"), "Everyday Essentials LLC" },
                    { new Guid("50caad3a-5055-4b94-90ce-72886cc9d5b0"), "ТОВ Скарбниця" },
                    { new Guid("6d2a6a6a-488e-488b-8d2f-c77f1b3416a3"), "Smart Store LLC" },
                    { new Guid("8cef13dc-8ccd-4ef9-ac39-3b1f4860a2e5"), "Prime Goods LLC" },
                    { new Guid("931dfb69-edfa-4fe8-8c7d-1edd00d22498"), "EcoResale JSC" },
                    { new Guid("c6d1ee0e-cb5b-4b13-96a9-f87714a27c2a"), "MultiUse Market JSC" },
                    { new Guid("fb1286a8-2d7f-436b-bee1-8fadaaaf104b"), "ПАТ Ваша Знижка" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("005035c9-81ff-4fe8-8fe3-521f1f5d41b0"), "Блок живлення 400Вт FSP ATX-400PNR", 400m },
                    { new Guid("01321943-1e98-43e3-a905-7bab66774c6f"), "Адаптер (Optibay) 2.5 SATA-SATA, 9,5 мм ", 200m },
                    { new Guid("05d0fb39-6374-4499-9bb9-58ccfaec0f8d"), "HDD Для ноутбука SATA 160Gb", 300m },
                    { new Guid("089b024c-b9b4-4bd7-b613-e124ac43204b"), "RAM Для ноутбука DDR4  2Gb  2400", 150m },
                    { new Guid("0b18a7ff-f156-4051-8ac9-a488e7ea707b"), "Зарядний пристрій HOCO C12  2xUSB 2,4A", 270m },
                    { new Guid("0b87db13-88e2-4ec4-9bcc-c060b7c71761"), "Монітор 22” Asus VS228 VGA DVI 1920x1080 LED ", 1600m },
                    { new Guid("10cc39da-7c0c-45d2-8ef6-0f0dee6137e2"), "Блок живлення БП 5В 4А", 250m },
                    { new Guid("14e645ca-7559-4eec-a574-6ae985bf620c"), "Монітор 15” NEC 500p   VGA", 300m },
                    { new Guid("14f8629f-871f-44d7-9986-1c3ab1d17b24"), "SSD 120Gb Foxconn Foxline X5", 600m },
                    { new Guid("1a52f384-5fe0-48e3-b420-45de614d1547"), "Блок живлення Lenovo 20V  2.25A  USB pin + силовий кабель ", 300m },
                    { new Guid("1a91820a-5ed9-45d4-a172-2d209fecf9d8"), "Блок живлення HP 90W 19V 4.74A 4.8x1.7 ", 300m },
                    { new Guid("1eea0854-748f-47f2-a642-3a97b5d7ae3b"), "HDD SATA 250Gb", 300m },
                    { new Guid("240f866e-e5ea-4c8c-89bf-c91adb0892e1"), "Блок живлення 360Вт Microlab ", 300m },
                    { new Guid("24be3976-dd68-4f3f-bf5c-d667ab9ba258"), "Зарядний пристрій BORASCO для Xiaomi Mi Band 5", 200m },
                    { new Guid("25a87fc2-435c-4dc9-8088-0cf2fa324aea"), "Монітор 22” LG W2243S VGA  1920 x 1080", 1500m },
                    { new Guid("25fba7a0-4691-4814-8f9a-0d7f8928416e"), "Веб-камера 2МП с мікрофоном", 300m },
                    { new Guid("27e028e2-5281-40e9-bf37-754e5b3fb550"), "Кабель TypeC — 3,5” ", 100m },
                    { new Guid("2b13f4c9-8587-4c55-a754-b7c55d685acb"), "Блок живлення Asus 65W 19V 3.42A 4.0x1.35 + силовий кабель ", 550m },
                    { new Guid("2ce21d4d-cc04-4a6f-ae0c-ff96f454d1c2"), "БЖ 5В 1А  б/в", 50m },
                    { new Guid("2f2a0df0-f682-40ac-8cc3-592518598b3d"), "Клавіатура GamePro GK670 ігрова з підсвіткою", 550m },
                    { new Guid("320ef1f2-be7d-41b0-8f05-d6ba4cc04e6f"), "Клавіатура USB Gembird MCH-04-UA", 280m },
                    { new Guid("34c4df70-437d-47fe-a1f6-eb6b44b16204"), "RAM Для ноутбука DDR3  2Gb в асортименті  ", 200m },
                    { new Guid("34d79214-9bbb-4057-a306-a9020deb9100"), "RAM Для ноутбука DDR3  4Gb  в асортименті  ", 400m },
                    { new Guid("37ace814-896e-446a-a313-5dbf78a32a93"), "Блок живлення 350Вт в асортименті", 250m },
                    { new Guid("37e0e876-de2e-4187-b804-941a25fb9e06"), "Миша бездротова REAL-EL RM-304 чорна", 350m },
                    { new Guid("3d2b217b-9960-41ea-96e5-03890d906c0f"), "Кабель HOCO X1 Rapid для Type-C , білий  ", 120m },
                    { new Guid("3e1b052d-bf9e-4c31-b7fb-3fb4fb13bc26"), "Монітор 17” ViewSonic VA703b  VGA", 500m },
                    { new Guid("3e922cf1-f068-4e1c-bc22-d2f9cb56086e"), "Миша бездротова SVEN RX-270W чорна", 400m },
                    { new Guid("3fe71809-4b33-40a4-aa97-15f4b3ad374a"), "Блок живлення 400Вт VINGA новые VPS-400-12    VPS-400-120", 400m },
                    { new Guid("42eae1f1-2b49-4d76-a012-7a5bbd17a2f9"), "RAM DDR3 4Gb Kingston", 400m },
                    { new Guid("45ed5008-1fe5-49d0-8f74-d66a05193a2f"), "Блок живлення 330Вт SVEN", 200m },
                    { new Guid("46f1df2e-774b-4f32-b18d-cac21ef47af3"), "RAM Для ноутбука DDR2 2Gb в асортименті", 250m },
                    { new Guid("48039dbf-7a7f-4e34-87f6-38388f253468"), "RAM Для ноутбука DDR3  1Gb", 30m },
                    { new Guid("4892fc19-80ff-41ff-beeb-086240bc1b31"), "Миша USB Esperanza EM102K", 180m },
                    { new Guid("4b541626-f61d-484b-86ff-d93c095c01f8"), "Монітор 20” Asus VH203    VGA   1600x900", 1200m },
                    { new Guid("4eb49873-9b7c-4b5e-92a9-2f2b3f46fec4"), "RAM DDR3 4Gb в асортименті", 350m },
                    { new Guid("51467a14-c2c4-40e5-a27a-0f800885f12d"), "RAM Для ноутбука DDR3L  2Gb в асортименті  ", 250m },
                    { new Guid("529db51d-6658-4877-a224-4136bb892a59"), "Блок живлення HP 19V, 4.74A, 90W, 4.5*3.0-PIN + силовий кабель  ", 300m },
                    { new Guid("5570f8dc-c4e5-46ae-816b-7e28741e4f93"), "RAM DDR2 1Gb  в асортименті  ", 150m },
                    { new Guid("5711e692-776b-438b-9cfc-d17614a26b28"), "Системний блок Pentium G5400  3,7Ghz  ( 2 ядра 4 потока) / S1151 Asrock H310CM-DVS / 8Gb DDR4 / SSD 120Gb / VGA+DVI/ 2xUSB3.0", 6000m },
                    { new Guid("5965201d-077c-458b-81af-f2fa71bbbd2e"), "Блок живлення 450Вт Delux", 400m },
                    { new Guid("5c6036d6-efa4-4185-985f-97433b86c393"), "RAM Для ноутбука DDR2 1Gb", 150m },
                    { new Guid("5d325160-1de8-4a13-8b2c-4fabd1a9a5d1"), "Адаптер (Optibay) 2.5 SATA-SATA, 12,7 мм ", 200m },
                    { new Guid("5e600af9-462e-486a-88f2-acf64e2205ec"), "Блок живлення 380W CoolerMaster кулер 8см", 300m },
                    { new Guid("5fd77645-66f7-4d04-9b0a-f54fd8dcabd3"), "Кабель microUSB бу", 40m },
                    { new Guid("617f37c2-bcbb-4019-866e-14be2018f088"), "Системний блок Sempron 2300 DualCore 1,6Ghz / 3Gb / 80Gb", 600m },
                    { new Guid("6464cc39-a825-4a72-b799-f00085fa9d90"), "Блок живлення БП 5В 0,6А ", 90m },
                    { new Guid("6b85e4ce-5c91-421f-b86e-0fc767e74bb8"), "Кабель для Iphone HOCO x26 2,4A 100cm", 140m },
                    { new Guid("6d0c41c3-4825-4f63-935f-627de65dcf93"), "Блок живлення 350Вт пікова 400Вт FSP  в асортименті", 300m },
                    { new Guid("73732da8-2a1e-4c93-8430-4938a06086d6"), "Клавіатура USB KB-8320U Gembird", 280m },
                    { new Guid("759fdfbd-349d-4ab2-8889-8d39658f9561"), "Блок живлення БП 9В 0,85А", 120m },
                    { new Guid("7ae7d140-a3a6-4c9d-9480-0c2438310e98"), "Системний блок A4-6300 2 ядра FM2 Gigabyte GA-F2A68HM-S1    6Gb DDR3/ 500Gb /2xUSB3.0/VGA", 3500m },
                    { new Guid("7b2c4294-ded8-4fbb-bcc8-70574824fc30"), "Блок живлення Asus 65W 19V 3.42A 5.5x2.5 + силовий кабель  ", 550m },
                    { new Guid("824c3734-eede-4baf-8ca4-2d2c9fc5c5c1"), "Ноутбук 14” Toshiba L745 Intel Core i3-2310M 2,1Ghz/ 3Gb / 320Gb / батарея не держит, пропадает звук", 3000m },
                    { new Guid("8283947d-63e4-4b63-968a-1daea45e2efc"), "Миша USB Havit HV-MS858GT бездротова", 300m },
                    { new Guid("861074e9-b12d-4c9e-8313-61d9d024b92a"), "Монітор 22” LG 22EN33S  VGA 1920 x 1080", 1500m },
                    { new Guid("871e77bd-50c1-4fe2-8189-2d3e42e557b1"), "Карман 2,5” USB IDE підтримка до 1Тб", 200m },
                    { new Guid("8e866909-1c8b-4aa6-8b0a-5df802e9d0a4"), "Монітор 19” LG L1900R-BF  DVI + зовнішній БЖ", 1500m },
                    { new Guid("8ecfbdc3-f513-4540-9fb7-9775d4d1d887"), "Веб-камера Microsoft Web cam vx-800 ", 600m },
                    { new Guid("91dd91a0-2998-428b-9400-44a0fc7b1984"), "Блок живлення 450Вт DeTech ", 400m },
                    { new Guid("92b3ea18-61fc-4e13-9312-e7a89f89a209"), "Відеокарта AMD Radeon HD 8490 1gb PCI-Ex DDR3 64bit (DVI + DP)", 750m },
                    { new Guid("93e80484-4abf-4402-8bc1-5cf52d1eea95"), "Клавіатура PS2 Gembird KB-103-UA", 250m },
                    { new Guid("93ed11a2-ca8b-4692-9c8e-1f3d349c9494"), "Веб-камера Logitech C170", 500m },
                    { new Guid("95979092-fa5a-4a98-b82c-5790401ded37"), "HDD SATA 160Gb", 200m },
                    { new Guid("95eab3eb-0c23-4f42-9802-58997b031392"), "Кабель Hoco X35 Premium Charging для Type-C , чорний , 0.25м", 100m },
                    { new Guid("969154ec-206a-4e39-80f6-fb3bd5b7aefa"), "Миша USB KAPPA Speedlink", 250m },
                    { new Guid("97918223-b624-43b7-a6ec-d56fbec9c576"), "RAM Для ноутбука DDR3L  4Gb  в асортименті  ", 400m },
                    { new Guid("98e4a805-089a-4e93-bc98-abfef5a6d0da"), "Миша USB Havit HV-MS672 ігрова", 300m },
                    { new Guid("99b7e98a-a6af-4690-9be6-43e6230b6877"), "Кабель microUSB HOCO x13 2,4A 100cm", 110m },
                    { new Guid("9b49289f-a7b2-4425-ae32-a03578239fc5"), "Зарядний пристрій, кабель для смарт-годинників Amazfit GTS 2e/ Amazfit GTS 2 mini/ Amazfit GTR 2e", 300m },
                    { new Guid("9e880c16-5dc5-40d9-a9c6-6ddac2ff2322"), "Блок живлення 400Вт FSP ATX-400PNR PRO ", 650m },
                    { new Guid("a0efc3a1-0ce2-4947-9707-10466df5bcb4"), "HDD SATA 1Tb", 850m },
                    { new Guid("a47c6020-c03d-4323-8b05-91c8c2f8f775"), "Монітор Lg 12v 2a", 300m },
                    { new Guid("a6c7afba-220a-4c77-b94f-5dfe3f86bbf9"), "Блок живлення HP 19,5V  2,05А 40Вт  7.4*5.0-PIN ", 300m },
                    { new Guid("a75b3f00-7e80-434f-aba1-33a20b2f422e"), "Блок живлення 390Вт CoolerMaster RS-390-PMSR-A3", 400m },
                    { new Guid("ac732262-b2a1-47b3-96c1-57b4be0443fa"), "RAM Для ноутбука DDR4  4Gb  в асортименті  ", 500m },
                    { new Guid("ad8bae68-a367-4442-8fbb-98c6a6b6e00d"), "Монітор 22” Acer V226HQL VGA DVI    1920 x 1080", 1600m },
                    { new Guid("b16720bf-350f-43ae-8295-d75c25d8620b"), "SSD 120Gb Smartbuy ", 600m },
                    { new Guid("b285e083-be43-4852-ab4e-870d0a5218cd"), "Миша бездротова Meetion MT-R545 чорна", 300m },
                    { new Guid("b892bdcf-4919-4c6b-9c97-1be7f786c4b5"), "Миша USB Gembird KB-U-103-UA", 180m },
                    { new Guid("b9ed29bd-629a-4bc0-a39d-ac31e6506b36"), "RAM DDR4 4Gb  ", 550m },
                    { new Guid("be66c0f2-b4fa-494d-9a2b-39ac53dbeb0f"), "RAM DDR3 1Gb  ", 250m },
                    { new Guid("c10b8321-014c-416f-9139-2feb953d9e82"), "Блок живлення 400Вт Vinga б/в", 300m },
                    { new Guid("c1423ea9-9995-42d4-ae24-e000b8cec72a"), "Відеокарта 2Gb GeForce GT710 Palit DDR3 64bit ", 2400m },
                    { new Guid("c67c96a8-680b-405b-a831-12e7dff972a0"), "RAM DDR3 4Gb HyperX Beast 1600Mhz", 400m },
                    { new Guid("c80586ea-a163-45e5-8575-9e68ae3101e8"), "Відеокарта 1Gb GeForce GT210 Asus DDR3 64bit ", 1500m },
                    { new Guid("c88e1f15-8400-4fc4-9d4e-103a4f72e5ba"), "RAM DDR2 2Gb  в асортименті  ", 200m },
                    { new Guid("d2bf51b7-ac9b-42cc-b11e-9684936f0d30"), "RAM Для ноутбука DDR3  8Gb", 700m },
                    { new Guid("d2ea8a67-3476-473a-b219-ec792c4c3138"), "Блок живлення 400Вт Griffon CPU 4pin + GPU 6pin", 400m },
                    { new Guid("d97f46e4-d6df-467a-8739-1c5fb721c48f"), "Блок живлення DELL 19.5V, 3.34A, 65W, 7.4*5.0-PIN   ", 550m },
                    { new Guid("d996252c-2089-442c-9061-e08026366919"), "HDD SATA 500Gb ", 400m },
                    { new Guid("d9f0b9fd-c733-489c-a882-907a605dfdc7"), "Блок живлення Lenovo 20V, 3.25A,65W, 7.9*5.5мм, 3 hole, with pin inside  ", 300m },
                    { new Guid("da4fb2b2-d62a-4834-98a3-5d91877cbb70"), "Блок живлення Asus 33W(19V/1.75A) ASUS special USB", 550m },
                    { new Guid("daeaa256-7ee6-4480-b4b7-819d7146468d"), "RAM DDR3 2Gb в асортименті  ", 150m },
                    { new Guid("dc5698a0-3ef6-48d1-8eda-1bdd3b0b4dc0"), "Миша бездротова Maxter mr-337 ", 250m },
                    { new Guid("df26ee3e-3db4-45e8-83e4-17c8975785a7"), "RAM DDR3 8Gb ", 800m },
                    { new Guid("dfd594db-4e47-4ea3-a572-70f9e85f2126"), "RAM DDR3 4Gb серверна", 300m },
                    { new Guid("dfde8028-359c-445f-9c38-d5b0640614d1"), "SSD mSATA 128Gb", 650m },
                    { new Guid("e1815889-cef3-4823-99e2-acec4457a8b4"), "Клавиатура цифровая Genius GK-060022/U (бу)", 100m },
                    { new Guid("e36556f3-f9e8-4374-a3e4-7fa39d27af1a"), "OTG TypeC", 150m },
                    { new Guid("e690477e-a48f-4e88-bf6c-60e8cdc99b05"), "Миша бездротова Maxxter біла Mr-333-W", 300m },
                    { new Guid("ef3b3658-9fb9-4940-8c02-1e27b54b706a"), "Блок живлення Acer 65W 19V 3.42A 5.5x1.7 + силовий кабель  ", 550m },
                    { new Guid("f0a0cf69-e963-4e06-b676-18c9f17e870c"), "Блок живлення 400Вт в асортименті", 300m },
                    { new Guid("f1d0f7d8-0d43-426d-86fc-d1a9465ab27b"), "RAM DDR3 8Gb  Kingston 1600Mhz", 800m },
                    { new Guid("f3475cd9-218e-4b16-a565-5733eaaba8dd"), "Монітор 20” Samsung 2043nw   VGA  1680x1050", 1450m },
                    { new Guid("f5df2c81-df25-41e3-a9e6-5faf2257b4bf"), "RAM DDR2 4Gb  для AMD ", 300m },
                    { new Guid("f7e21f11-4895-4841-9784-89956131c551"), "Блок живлення 300Вт в асортименті", 200m },
                    { new Guid("fb2c9434-15b2-4cba-98ee-828f1fe93442"), "Веб-камера A4Tech PK-950H  Full HD (1080p)", 650m },
                    { new Guid("fb73719e-d763-4d16-b7ca-5ebadffebb82"), "Блок живлення HP 19V, 2.31A, 4.5*3.0-PIN + силовий кабель  ", 300m },
                    { new Guid("fba42151-57d5-47ee-bd9c-a3e17e4a478b"), "Блок живлення Asus 45W 19V 2.37A 4.0x1.35 + силовий кабель", 550m },
                    { new Guid("fbb24d1d-a814-4fa3-9751-0a2aef3fadc0"), "Системний блок Xeon X5450 / Biostar G41D3 / 8Gb / SSD 120 / frontier 400", 4000m },
                    { new Guid("fc184c40-21bf-495e-b425-b4a3c1243217"), "Адаптер переходник USB 3.0 To SATA  для жорсткого диска 2,5”", 250m },
                    { new Guid("fc829c60-33ff-4995-8999-5830bd2e92eb"), "Клавіатура PS/2 Defender HB-520", 200m },
                    { new Guid("fe4e89b7-27e6-4c36-b1fa-99b0c975d5f5"), "Монітор 22” LG W2253TQ VGA + DVI  1920 x 1080", 1500m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("04d0ac0b-86ce-4321-ae43-a4c58556629f"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("063d68ab-fc23-4600-ad80-504e1ef8b0d5"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("066744b5-dac1-4f37-bfcf-8c6f25d3a496"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("06782fcf-2c8c-4235-aeeb-19f11d0758f0"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("097a2029-dce9-42f9-8e3f-57802930426e"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("0993de6f-0509-4c57-98be-a27cf201d6e4"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("0d0858e7-0a8e-49e1-80ac-eaf9abcfe1c8"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("0f267240-d301-4584-96b9-45e336d8007e"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("0f2e1978-f9e7-4a94-82ed-446724bb9a4b"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("0f5e73d3-83bd-4354-93e2-1db6854f4518"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("1ef0f1fa-6624-45d9-9dcd-28204bd8c996"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("205a8ff3-cfea-4067-80cf-e5667bac231c"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("236dbc89-e48a-4748-a7c5-cf42f37cc016"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("23eeb88a-8851-48f0-bb30-a9889a3f7471"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("2b3afaac-b3b2-4eab-9cff-2064d51d8769"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("2bbafef0-3367-4561-95c9-ff789318cc23"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("2e8f2133-1a01-42dc-aefd-a3a651510108"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("306fd89d-e0f0-42bb-addd-d3abbfb1eac6"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("3178af87-e786-4138-ad91-b74edd3acf48"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("35815e16-769b-430b-8c64-ca7f2b23189c"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("35ac3ab8-bf58-4291-b671-ff2f118893c3"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("3687ff73-37c2-4567-b5fa-4bfe4ee7fadd"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("3920757e-6aed-465d-8d02-3f48f974b1c9"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("3df43ff3-9a36-423f-93e4-fdfb9490caf1"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("3fb7a910-d37b-4363-89a5-150bc7199f5e"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("3ffc8f03-aa6e-4fea-b83a-9791d2bf8ea3"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("435f76ba-3157-4472-9f5c-360334c3d9a0"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("45632874-beb7-401d-b92a-2721df4e8fa8"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("47ce489f-4ed5-433e-9205-390bc5d5cafe"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("4a7174ce-7b95-4260-bc8c-b5e3cc028073"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("4e236c70-b672-4e11-8f5b-87093e82b29e"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("4e340e5b-6071-42e8-a748-1e758d1677ca"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("53cae081-7ab0-4761-a4da-5a6d21496d04"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("548bf6ca-c0f0-418a-b360-09c29ae6b113"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("6128b1bb-018a-4c51-b410-06657b786fac"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("643b15e8-b083-4ddb-a060-8446d1493b51"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("67ccacf8-b71c-4c37-8cb0-30cdefc7fbd9"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("6b2d88b4-7fdc-4ede-bb51-7658e7ca910f"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("6c1ae71e-85e0-4408-9552-45331a4e5bd1"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("6f7632eb-55ab-4e3c-a326-2a042e2d4627"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("74025549-7f8c-459d-b748-399663b8efb9"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("7551321a-09a6-4e5e-8d83-599fa4907c8a"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("76f2594c-a006-44b3-afaa-ffcfa0159c2d"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("7ccbbc76-adc1-40e9-8787-fc0a7fa4b2f4"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("82f8dba2-1858-4e1a-abd2-a59df6965f9d"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("841f06fe-3264-4bc3-beef-8fa92cee2293"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("863d17e9-d16b-46d0-a69e-d12e1447a706"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("87329e18-3d28-4a3d-a141-74c9fb8705ec"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("8759ee27-37c9-4ceb-b931-a548f17f4c37"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("8999366a-b868-4a84-a934-ed60b694b189"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("8a6c2dae-5f0e-4a09-9d12-14eacaa5a33d"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("8d68bc4c-7bf8-40fe-9a81-e04b3d91497b"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("8dfab2e7-d100-4e53-b94c-e2bbbc363673"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("96fb6838-6208-4c31-a77f-bd11fc06eb1c"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("978dc6f9-70ee-49d8-96bc-37e79e52a3c2"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("98af6726-7943-4de4-8aa7-8d91ecca74ff"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("9b3dc264-8993-44a2-ac94-5df4d2f4ae51"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("9e1ac0ee-c2b5-4302-9840-0f94e598aad1"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("a034f7db-026e-4389-adb8-9985ef337703"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("a060d3e8-6156-4a6a-9826-b15da3ec2854"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("a3cda1e5-647d-44b9-a6ac-6aef43b4cda9"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("a4edd7c8-155f-478d-b4f8-2512e2565491"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("a620a4f3-41fc-4409-9df4-71129755bb6a"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("a865affe-efc9-4419-9954-2db7b1191dbd"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("afde137c-546b-493b-9353-52715d764814"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("b483817a-69d4-4c3a-b4a7-5b081e4d0de5"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("b5df7f42-cb51-4f23-afc9-2f9a1f82db87"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("b6d219e2-a832-4720-8443-fff68d5fb805"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("b7a9f3f1-db7c-42e8-ac0a-49c8ea04f5c1"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("b8d62476-d71f-451b-b0d3-30df11213f3d"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("bc9c0806-f852-4aae-8481-0e49b145ea11"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("bd23de9d-8a4e-4849-8796-39cef4a980f5"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("c009988a-470a-4503-9321-068e66557ac1"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("c15801bb-08c1-4dbb-9dc9-e37dcfd7f462"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("cb072571-1053-4f0e-ae39-8088e14f92af"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("cc8dd042-362e-4d5f-9a1a-fca88c9932b9"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("cca1bca0-3346-48e6-97a0-d6be43372072"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("cd711a28-3821-4482-b2f5-4de761371b6c"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("cd95edcd-0319-424b-a3ce-27d97f90cfb3"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("ce1955ce-a251-4eb6-ac90-664624193d34"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("d4cc884c-cbc8-466c-9e85-dc5f74fdaf99"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("d636f812-b2ef-4d1e-aeb6-63d240a6a5ce"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("d98116e4-bf64-48fd-866b-85cea4d0c793"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("d9b7f2a3-ecb8-4faf-9956-c69c8e00597c"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("de3bc158-4a16-4b4c-a74b-06b8522ac00b"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("def23115-c759-4495-aef5-048bd4b68f67"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("df451daf-a4a5-4655-82a1-73407874a076"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("dffdf291-c6d6-4af2-93b2-f452531c5f95"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("e6e8d542-eef1-409d-aadb-8f36b4a80f7a"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("e9a1c852-affd-4742-9542-958b8975b527"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("eb540332-9d36-49ed-85b5-deed6930df58"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("eb5bc95f-b3f8-49f8-9cff-c6d169a52e48"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("f26d87cb-3993-469e-93a5-ce2c3da12336"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("f799d7c6-4ab5-4243-af1f-e56e0564ded3"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("f9a700d0-7be2-4241-a187-4a1acb737433"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("fc32e420-0aa5-490a-8e2b-a2978208595e"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("fc384f1a-5bed-4a5e-b677-78aa9fbbc673"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("fc440f87-4320-4f85-bb2c-4075f14ed755"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("fe24a19a-f393-4f75-8b0d-a407ba89691d"));

            migrationBuilder.DeleteData(
                table: "Firms",
                keyColumn: "Id",
                keyValue: new Guid("1ea7d698-924b-47df-b574-88f4f71306e6"));

            migrationBuilder.DeleteData(
                table: "Firms",
                keyColumn: "Id",
                keyValue: new Guid("3d4e5f82-4d89-4620-8023-9e90473b8c2d"));

            migrationBuilder.DeleteData(
                table: "Firms",
                keyColumn: "Id",
                keyValue: new Guid("48f0708a-11d4-4648-9ac7-12a1fff5e1e7"));

            migrationBuilder.DeleteData(
                table: "Firms",
                keyColumn: "Id",
                keyValue: new Guid("4e96d0a1-2ba9-411a-afd7-27bceb862c93"));

            migrationBuilder.DeleteData(
                table: "Firms",
                keyColumn: "Id",
                keyValue: new Guid("50caad3a-5055-4b94-90ce-72886cc9d5b0"));

            migrationBuilder.DeleteData(
                table: "Firms",
                keyColumn: "Id",
                keyValue: new Guid("6d2a6a6a-488e-488b-8d2f-c77f1b3416a3"));

            migrationBuilder.DeleteData(
                table: "Firms",
                keyColumn: "Id",
                keyValue: new Guid("8cef13dc-8ccd-4ef9-ac39-3b1f4860a2e5"));

            migrationBuilder.DeleteData(
                table: "Firms",
                keyColumn: "Id",
                keyValue: new Guid("931dfb69-edfa-4fe8-8c7d-1edd00d22498"));

            migrationBuilder.DeleteData(
                table: "Firms",
                keyColumn: "Id",
                keyValue: new Guid("c6d1ee0e-cb5b-4b13-96a9-f87714a27c2a"));

            migrationBuilder.DeleteData(
                table: "Firms",
                keyColumn: "Id",
                keyValue: new Guid("fb1286a8-2d7f-436b-bee1-8fadaaaf104b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("005035c9-81ff-4fe8-8fe3-521f1f5d41b0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("01321943-1e98-43e3-a905-7bab66774c6f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("05d0fb39-6374-4499-9bb9-58ccfaec0f8d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("089b024c-b9b4-4bd7-b613-e124ac43204b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0b18a7ff-f156-4051-8ac9-a488e7ea707b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0b87db13-88e2-4ec4-9bcc-c060b7c71761"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("10cc39da-7c0c-45d2-8ef6-0f0dee6137e2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("14e645ca-7559-4eec-a574-6ae985bf620c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("14f8629f-871f-44d7-9986-1c3ab1d17b24"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1a52f384-5fe0-48e3-b420-45de614d1547"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1a91820a-5ed9-45d4-a172-2d209fecf9d8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1eea0854-748f-47f2-a642-3a97b5d7ae3b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("240f866e-e5ea-4c8c-89bf-c91adb0892e1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("24be3976-dd68-4f3f-bf5c-d667ab9ba258"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("25a87fc2-435c-4dc9-8088-0cf2fa324aea"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("25fba7a0-4691-4814-8f9a-0d7f8928416e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("27e028e2-5281-40e9-bf37-754e5b3fb550"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2b13f4c9-8587-4c55-a754-b7c55d685acb"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2ce21d4d-cc04-4a6f-ae0c-ff96f454d1c2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2f2a0df0-f682-40ac-8cc3-592518598b3d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("320ef1f2-be7d-41b0-8f05-d6ba4cc04e6f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("34c4df70-437d-47fe-a1f6-eb6b44b16204"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("34d79214-9bbb-4057-a306-a9020deb9100"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("37ace814-896e-446a-a313-5dbf78a32a93"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("37e0e876-de2e-4187-b804-941a25fb9e06"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3d2b217b-9960-41ea-96e5-03890d906c0f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3e1b052d-bf9e-4c31-b7fb-3fb4fb13bc26"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3e922cf1-f068-4e1c-bc22-d2f9cb56086e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3fe71809-4b33-40a4-aa97-15f4b3ad374a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("42eae1f1-2b49-4d76-a012-7a5bbd17a2f9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("45ed5008-1fe5-49d0-8f74-d66a05193a2f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("46f1df2e-774b-4f32-b18d-cac21ef47af3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("48039dbf-7a7f-4e34-87f6-38388f253468"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4892fc19-80ff-41ff-beeb-086240bc1b31"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4b541626-f61d-484b-86ff-d93c095c01f8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4eb49873-9b7c-4b5e-92a9-2f2b3f46fec4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("51467a14-c2c4-40e5-a27a-0f800885f12d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("529db51d-6658-4877-a224-4136bb892a59"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5570f8dc-c4e5-46ae-816b-7e28741e4f93"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5711e692-776b-438b-9cfc-d17614a26b28"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5965201d-077c-458b-81af-f2fa71bbbd2e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5c6036d6-efa4-4185-985f-97433b86c393"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5d325160-1de8-4a13-8b2c-4fabd1a9a5d1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5e600af9-462e-486a-88f2-acf64e2205ec"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5fd77645-66f7-4d04-9b0a-f54fd8dcabd3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("617f37c2-bcbb-4019-866e-14be2018f088"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6464cc39-a825-4a72-b799-f00085fa9d90"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6b85e4ce-5c91-421f-b86e-0fc767e74bb8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6d0c41c3-4825-4f63-935f-627de65dcf93"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("73732da8-2a1e-4c93-8430-4938a06086d6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("759fdfbd-349d-4ab2-8889-8d39658f9561"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7ae7d140-a3a6-4c9d-9480-0c2438310e98"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7b2c4294-ded8-4fbb-bcc8-70574824fc30"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("824c3734-eede-4baf-8ca4-2d2c9fc5c5c1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8283947d-63e4-4b63-968a-1daea45e2efc"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("861074e9-b12d-4c9e-8313-61d9d024b92a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("871e77bd-50c1-4fe2-8189-2d3e42e557b1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8e866909-1c8b-4aa6-8b0a-5df802e9d0a4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8ecfbdc3-f513-4540-9fb7-9775d4d1d887"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("91dd91a0-2998-428b-9400-44a0fc7b1984"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("92b3ea18-61fc-4e13-9312-e7a89f89a209"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("93e80484-4abf-4402-8bc1-5cf52d1eea95"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("93ed11a2-ca8b-4692-9c8e-1f3d349c9494"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("95979092-fa5a-4a98-b82c-5790401ded37"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("95eab3eb-0c23-4f42-9802-58997b031392"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("969154ec-206a-4e39-80f6-fb3bd5b7aefa"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("97918223-b624-43b7-a6ec-d56fbec9c576"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("98e4a805-089a-4e93-bc98-abfef5a6d0da"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("99b7e98a-a6af-4690-9be6-43e6230b6877"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9b49289f-a7b2-4425-ae32-a03578239fc5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9e880c16-5dc5-40d9-a9c6-6ddac2ff2322"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a0efc3a1-0ce2-4947-9707-10466df5bcb4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a47c6020-c03d-4323-8b05-91c8c2f8f775"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a6c7afba-220a-4c77-b94f-5dfe3f86bbf9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a75b3f00-7e80-434f-aba1-33a20b2f422e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ac732262-b2a1-47b3-96c1-57b4be0443fa"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ad8bae68-a367-4442-8fbb-98c6a6b6e00d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b16720bf-350f-43ae-8295-d75c25d8620b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b285e083-be43-4852-ab4e-870d0a5218cd"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b892bdcf-4919-4c6b-9c97-1be7f786c4b5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b9ed29bd-629a-4bc0-a39d-ac31e6506b36"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("be66c0f2-b4fa-494d-9a2b-39ac53dbeb0f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c10b8321-014c-416f-9139-2feb953d9e82"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c1423ea9-9995-42d4-ae24-e000b8cec72a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c67c96a8-680b-405b-a831-12e7dff972a0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c80586ea-a163-45e5-8575-9e68ae3101e8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c88e1f15-8400-4fc4-9d4e-103a4f72e5ba"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d2bf51b7-ac9b-42cc-b11e-9684936f0d30"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d2ea8a67-3476-473a-b219-ec792c4c3138"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d97f46e4-d6df-467a-8739-1c5fb721c48f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d996252c-2089-442c-9061-e08026366919"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d9f0b9fd-c733-489c-a882-907a605dfdc7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("da4fb2b2-d62a-4834-98a3-5d91877cbb70"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("daeaa256-7ee6-4480-b4b7-819d7146468d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("dc5698a0-3ef6-48d1-8eda-1bdd3b0b4dc0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("df26ee3e-3db4-45e8-83e4-17c8975785a7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("dfd594db-4e47-4ea3-a572-70f9e85f2126"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("dfde8028-359c-445f-9c38-d5b0640614d1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e1815889-cef3-4823-99e2-acec4457a8b4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e36556f3-f9e8-4374-a3e4-7fa39d27af1a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e690477e-a48f-4e88-bf6c-60e8cdc99b05"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ef3b3658-9fb9-4940-8c02-1e27b54b706a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f0a0cf69-e963-4e06-b676-18c9f17e870c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f1d0f7d8-0d43-426d-86fc-d1a9465ab27b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f3475cd9-218e-4b16-a565-5733eaaba8dd"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f5df2c81-df25-41e3-a9e6-5faf2257b4bf"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f7e21f11-4895-4841-9784-89956131c551"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fb2c9434-15b2-4cba-98ee-828f1fe93442"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fb73719e-d763-4d16-b7ca-5ebadffebb82"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fba42151-57d5-47ee-bd9c-a3e17e4a478b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fbb24d1d-a814-4fa3-9751-0a2aef3fadc0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fc184c40-21bf-495e-b425-b4a3c1243217"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fc829c60-33ff-4995-8999-5830bd2e92eb"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fe4e89b7-27e6-4c36-b1fa-99b0c975d5f5"));
        }
    }
}
