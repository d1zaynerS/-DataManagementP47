using DataManagementP47.EF.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataManagementP47.EF
{
    internal class EfContext : DbContext
    {
        public EfContext(DbContextOptions options) : base(options)
        {
        }

        public EfContext()
        {
        }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<Firm> Firms { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<Sale> Sales { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=EfDmP47;Integrated Security=True");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            SeedFirms(modelBuilder);
            SeedProducts(modelBuilder);
            SeedEmployee(modelBuilder);
        }

        private void SeedEmployee(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Entities.Employee>().HasData(
                new Entities.Employee
                {
                    Id = Guid.Parse("def23115-c759-4495-aef5-048bd4b68f67"),
                    FirmId = Guid.Parse("48f0708a-11d4-4648-9ac7-12a1fff5e1e7"),
                    Name = "Ерстенюк Йосип",
                    Birthdate = DateTime.Parse("1972-08-10")
                }, new Entities.Employee
                {
                    Id = Guid.Parse("6128b1bb-018a-4c51-b410-06657b786fac"),
                    FirmId = Guid.Parse("931dfb69-edfa-4fe8-8c7d-1edd00d22498"),
                    Name = "Єщенко Уляна",
                    Birthdate = DateTime.Parse("1972-09-21")
                }, new Entities.Employee
                {
                    Id = Guid.Parse("c009988a-470a-4503-9321-068e66557ac1"),
                    FirmId = Guid.Parse("3d4e5f82-4d89-4620-8023-9e90473b8c2d"),
                    Name = "Худенко Іларія",
                    Birthdate = DateTime.Parse("1973-03-13")
                }, new Entities.Employee
                {
                    Id = Guid.Parse("de3bc158-4a16-4b4c-a74b-06b8522ac00b"),
                    FirmId = Guid.Parse("6d2a6a6a-488e-488b-8d2f-c77f1b3416a3"),
                    Name = "Андрейчук Родан",
                    Birthdate = DateTime.Parse("2000-11-08")
                }, new Entities.Employee
                {
                    Id = Guid.Parse("548bf6ca-c0f0-418a-b360-09c29ae6b113"),
                    FirmId = Guid.Parse("6d2a6a6a-488e-488b-8d2f-c77f1b3416a3"),
                    Name = "Жданович Радомир",
                    Birthdate = DateTime.Parse("1979-01-02")
                }, new Entities.Employee
                {
                    Id = Guid.Parse("bc9c0806-f852-4aae-8481-0e49b145ea11"),
                    FirmId = Guid.Parse("8cef13dc-8ccd-4ef9-ac39-3b1f4860a2e5"),
                    Name = "Мусієнко Яромира",
                    Birthdate = DateTime.Parse("1986-05-16")
                }, new Entities.Employee
                {
                    Id = Guid.Parse("9e1ac0ee-c2b5-4302-9840-0f94e598aad1"),
                    FirmId = Guid.Parse("931dfb69-edfa-4fe8-8c7d-1edd00d22498"),
                    Name = "Каніщенко Еммануїл",
                    Birthdate = DateTime.Parse("1997-11-04")
                }, new Entities.Employee
                {
                    Id = Guid.Parse("8a6c2dae-5f0e-4a09-9d12-14eacaa5a33d"),
                    FirmId = Guid.Parse("fb1286a8-2d7f-436b-bee1-8fadaaaf104b"),
                    Name = "Їжакевич Оріяна",
                    Birthdate = DateTime.Parse("1985-01-08")
                }, new Entities.Employee
                {
                    Id = Guid.Parse("3fb7a910-d37b-4363-89a5-150bc7199f5e"),
                    FirmId = Guid.Parse("fb1286a8-2d7f-436b-bee1-8fadaaaf104b"),
                    Name = "Біба Ус",
                    Birthdate = DateTime.Parse("1984-06-20")
                }, new Entities.Employee
                {
                    Id = Guid.Parse("06782fcf-2c8c-4235-aeeb-19f11d0758f0"),
                    FirmId = Guid.Parse("c6d1ee0e-cb5b-4b13-96a9-f87714a27c2a"),
                    Name = "Досенко Барбара",
                    Birthdate = DateTime.Parse("1985-05-23")
                }, new Entities.Employee
                {
                    Id = Guid.Parse("0f5e73d3-83bd-4354-93e2-1db6854f4518"),
                    FirmId = Guid.Parse("50caad3a-5055-4b94-90ce-72886cc9d5b0"),
                    Name = "Верхратський Цвітан",
                    Birthdate = DateTime.Parse("1988-12-14")
                }, new Entities.Employee
                {
                    Id = Guid.Parse("4e340e5b-6071-42e8-a748-1e758d1677ca"),
                    FirmId = Guid.Parse("50caad3a-5055-4b94-90ce-72886cc9d5b0"),
                    Name = "Ящуржинська Дзвенимира",
                    Birthdate = DateTime.Parse("1985-04-15")
                }, new Entities.Employee
                {
                    Id = Guid.Parse("2b3afaac-b3b2-4eab-9cff-2064d51d8769"),
                    FirmId = Guid.Parse("3d4e5f82-4d89-4620-8023-9e90473b8c2d"),
                    Name = "Янчик Еріка",
                    Birthdate = DateTime.Parse("1998-09-21")
                }, new Entities.Employee
                {
                    Id = Guid.Parse("a4edd7c8-155f-478d-b4f8-2512e2565491"),
                    FirmId = Guid.Parse("6d2a6a6a-488e-488b-8d2f-c77f1b3416a3"),
                    Name = "Філіпчук Харитя",
                    Birthdate = DateTime.Parse("2002-11-01")
                }, new Entities.Employee
                {
                    Id = Guid.Parse("45632874-beb7-401d-b92a-2721df4e8fa8"),
                    FirmId = Guid.Parse("3d4e5f82-4d89-4620-8023-9e90473b8c2d"),
                    Name = "Ніколайчук Ус",
                    Birthdate = DateTime.Parse("1983-09-06")
                }, new Entities.Employee
                {
                    Id = Guid.Parse("cd95edcd-0319-424b-a3ce-27d97f90cfb3"),
                    FirmId = Guid.Parse("c6d1ee0e-cb5b-4b13-96a9-f87714a27c2a"),
                    Name = "Височан Орина",
                    Birthdate = DateTime.Parse("1975-03-11")
                }, new Entities.Employee
                {
                    Id = Guid.Parse("1ef0f1fa-6624-45d9-9dcd-28204bd8c996"),
                    FirmId = Guid.Parse("48f0708a-11d4-4648-9ac7-12a1fff5e1e7"),
                    Name = "Куликовська Елла",
                    Birthdate = DateTime.Parse("1996-06-12")
                }, new Entities.Employee
                {
                    Id = Guid.Parse("6f7632eb-55ab-4e3c-a326-2a042e2d4627"),
                    FirmId = Guid.Parse("6d2a6a6a-488e-488b-8d2f-c77f1b3416a3"),
                    Name = "Щаслива Цецілія",
                    Birthdate = DateTime.Parse("1996-07-31")
                }, new Entities.Employee
                {
                    Id = Guid.Parse("a865affe-efc9-4419-9954-2db7b1191dbd"),
                    FirmId = Guid.Parse("1ea7d698-924b-47df-b574-88f4f71306e6"),
                    Name = "Кулинич Жадана",
                    Birthdate = DateTime.Parse("1978-01-04")
                }, new Entities.Employee
                {
                    Id = Guid.Parse("b5df7f42-cb51-4f23-afc9-2f9a1f82db87"),
                    FirmId = Guid.Parse("1ea7d698-924b-47df-b574-88f4f71306e6"),
                    Name = "Фещак Осипа",
                    Birthdate = DateTime.Parse("2007-09-13")
                }, new Entities.Employee
                {
                    Id = Guid.Parse("67ccacf8-b71c-4c37-8cb0-30cdefc7fbd9"),
                    FirmId = Guid.Parse("6d2a6a6a-488e-488b-8d2f-c77f1b3416a3"),
                    Name = "Тімченко Шерлок",
                    Birthdate = DateTime.Parse("1975-05-20")
                }, new Entities.Employee
                {
                    Id = Guid.Parse("b8d62476-d71f-451b-b0d3-30df11213f3d"),
                    FirmId = Guid.Parse("1ea7d698-924b-47df-b574-88f4f71306e6"),
                    Name = "Деряжний Щавелина",
                    Birthdate = DateTime.Parse("1996-08-20")
                }, new Entities.Employee
                {
                    Id = Guid.Parse("435f76ba-3157-4472-9f5c-360334c3d9a0"),
                    FirmId = Guid.Parse("6d2a6a6a-488e-488b-8d2f-c77f1b3416a3"),
                    Name = "Хомич Златоус",
                    Birthdate = DateTime.Parse("1984-09-07")
                }, new Entities.Employee
                {
                    Id = Guid.Parse("978dc6f9-70ee-49d8-96bc-37e79e52a3c2"),
                    FirmId = Guid.Parse("50caad3a-5055-4b94-90ce-72886cc9d5b0"),
                    Name = "Іванців Роксолан",
                    Birthdate = DateTime.Parse("1995-01-25")
                }, new Entities.Employee
                {
                    Id = Guid.Parse("47ce489f-4ed5-433e-9205-390bc5d5cafe"),
                    FirmId = Guid.Parse("931dfb69-edfa-4fe8-8c7d-1edd00d22498"),
                    Name = "Щорс Шушана",
                    Birthdate = DateTime.Parse("1986-10-28")
                }, new Entities.Employee
                {
                    Id = Guid.Parse("74025549-7f8c-459d-b748-399663b8efb9"),
                    FirmId = Guid.Parse("48f0708a-11d4-4648-9ac7-12a1fff5e1e7"),
                    Name = "Ілінський Оримир",
                    Birthdate = DateTime.Parse("1973-04-04")
                }, new Entities.Employee
                {
                    Id = Guid.Parse("bd23de9d-8a4e-4849-8796-39cef4a980f5"),
                    FirmId = Guid.Parse("48f0708a-11d4-4648-9ac7-12a1fff5e1e7"),
                    Name = "Горох Хриса",
                    Birthdate = DateTime.Parse("1984-04-16")
                }, new Entities.Employee
                {
                    Id = Guid.Parse("3920757e-6aed-465d-8d02-3f48f974b1c9"),
                    FirmId = Guid.Parse("50caad3a-5055-4b94-90ce-72886cc9d5b0"),
                    Name = "Громницький Людомил",
                    Birthdate = DateTime.Parse("1979-08-13")
                }, new Entities.Employee
                {
                    Id = Guid.Parse("fc440f87-4320-4f85-bb2c-4075f14ed755"),
                    FirmId = Guid.Parse("48f0708a-11d4-4648-9ac7-12a1fff5e1e7"),
                    Name = "Мицик Чеслава",
                    Birthdate = DateTime.Parse("2006-03-27")
                }, new Entities.Employee
                {
                    Id = Guid.Parse("0f2e1978-f9e7-4a94-82ed-446724bb9a4b"),
                    FirmId = Guid.Parse("4e96d0a1-2ba9-411a-afd7-27bceb862c93"),
                    Name = "Любович Еммануїл",
                    Birthdate = DateTime.Parse("2001-10-31")
                }, new Entities.Employee
                {
                    Id = Guid.Parse("6c1ae71e-85e0-4408-9552-45331a4e5bd1"),
                    FirmId = Guid.Parse("3d4e5f82-4d89-4620-8023-9e90473b8c2d"),
                    Name = "Шапаренко Шаміль",
                    Birthdate = DateTime.Parse("1988-08-30")
                }, new Entities.Employee
                {
                    Id = Guid.Parse("0f267240-d301-4584-96b9-45e336d8007e"),
                    FirmId = Guid.Parse("3d4e5f82-4d89-4620-8023-9e90473b8c2d"),
                    Name = "Ковчі Любомисл",
                    Birthdate = DateTime.Parse("1992-07-06")
                }, new Entities.Employee
                {
                    Id = Guid.Parse("b7a9f3f1-db7c-42e8-ac0a-49c8ea04f5c1"),
                    FirmId = Guid.Parse("3d4e5f82-4d89-4620-8023-9e90473b8c2d"),
                    Name = "Їжак Цецілія",
                    Birthdate = DateTime.Parse("1995-04-19")
                }, new Entities.Employee
                {
                    Id = Guid.Parse("f9a700d0-7be2-4241-a187-4a1acb737433"),
                    FirmId = Guid.Parse("1ea7d698-924b-47df-b574-88f4f71306e6"),
                    Name = "Їжак Земислав",
                    Birthdate = DateTime.Parse("1985-09-04")
                }, new Entities.Employee
                {
                    Id = Guid.Parse("3687ff73-37c2-4567-b5fa-4bfe4ee7fadd"),
                    FirmId = Guid.Parse("8cef13dc-8ccd-4ef9-ac39-3b1f4860a2e5"),
                    Name = "Гуляницька Чеслава",
                    Birthdate = DateTime.Parse("1997-10-16")
                }, new Entities.Employee
                {
                    Id = Guid.Parse("cd711a28-3821-4482-b2f5-4de761371b6c"),
                    FirmId = Guid.Parse("4e96d0a1-2ba9-411a-afd7-27bceb862c93"),
                    Name = "Щерба Жадан",
                    Birthdate = DateTime.Parse("1980-09-01")
                }, new Entities.Employee
                {
                    Id = Guid.Parse("063d68ab-fc23-4600-ad80-504e1ef8b0d5"),
                    FirmId = Guid.Parse("4e96d0a1-2ba9-411a-afd7-27bceb862c93"),
                    Name = "Завітневич Йосипа",
                    Birthdate = DateTime.Parse("1987-07-14")
                }, new Entities.Employee
                {
                    Id = Guid.Parse("afde137c-546b-493b-9353-52715d764814"),
                    FirmId = Guid.Parse("6d2a6a6a-488e-488b-8d2f-c77f1b3416a3"),
                    Name = "Щуренко Голубко",
                    Birthdate = DateTime.Parse("2007-05-24")
                }, new Entities.Employee
                {
                    Id = Guid.Parse("097a2029-dce9-42f9-8e3f-57802930426e"),
                    FirmId = Guid.Parse("4e96d0a1-2ba9-411a-afd7-27bceb862c93"),
                    Name = "Адамчук Еразм",
                    Birthdate = DateTime.Parse("1981-01-22")
                }, new Entities.Employee
                {
                    Id = Guid.Parse("7551321a-09a6-4e5e-8d83-599fa4907c8a"),
                    FirmId = Guid.Parse("4e96d0a1-2ba9-411a-afd7-27bceb862c93"),
                    Name = "Юцевич Сологуба",
                    Birthdate = DateTime.Parse("2005-07-28")
                }, new Entities.Employee
                {
                    Id = Guid.Parse("53cae081-7ab0-4761-a4da-5a6d21496d04"),
                    FirmId = Guid.Parse("8cef13dc-8ccd-4ef9-ac39-3b1f4860a2e5"),
                    Name = "Лобай Цецілія",
                    Birthdate = DateTime.Parse("2008-01-23")
                }, new Entities.Employee
                {
                    Id = Guid.Parse("b483817a-69d4-4c3a-b4a7-5b081e4d0de5"),
                    FirmId = Guid.Parse("6d2a6a6a-488e-488b-8d2f-c77f1b3416a3"),
                    Name = "Іщак Фотинія",
                    Birthdate = DateTime.Parse("1995-09-12")
                }, new Entities.Employee
                {
                    Id = Guid.Parse("9b3dc264-8993-44a2-ac94-5df4d2f4ae51"),
                    FirmId = Guid.Parse("50caad3a-5055-4b94-90ce-72886cc9d5b0"),
                    Name = "Чекман Вишеслав",
                    Birthdate = DateTime.Parse("1979-01-08")
                }, new Entities.Employee
                {
                    Id = Guid.Parse("d636f812-b2ef-4d1e-aeb6-63d240a6a5ce"),
                    FirmId = Guid.Parse("1ea7d698-924b-47df-b574-88f4f71306e6"),
                    Name = "Їжакевич Цвітана",
                    Birthdate = DateTime.Parse("1977-07-07")
                }, new Entities.Employee
                {
                    Id = Guid.Parse("ce1955ce-a251-4eb6-ac90-664624193d34"),
                    FirmId = Guid.Parse("50caad3a-5055-4b94-90ce-72886cc9d5b0"),
                    Name = "Ірванець Немира",
                    Birthdate = DateTime.Parse("1997-12-31")
                }, new Entities.Employee
                {
                    Id = Guid.Parse("a3cda1e5-647d-44b9-a6ac-6aef43b4cda9"),
                    FirmId = Guid.Parse("6d2a6a6a-488e-488b-8d2f-c77f1b3416a3"),
                    Name = "Тишик Едуард",
                    Birthdate = DateTime.Parse("1996-12-31")
                }, new Entities.Employee
                {
                    Id = Guid.Parse("a620a4f3-41fc-4409-9df4-71129755bb6a"),
                    FirmId = Guid.Parse("931dfb69-edfa-4fe8-8c7d-1edd00d22498"),
                    Name = "Кушнір Борис",
                    Birthdate = DateTime.Parse("1992-04-06")
                }, new Entities.Employee
                {
                    Id = Guid.Parse("df451daf-a4a5-4655-82a1-73407874a076"),
                    FirmId = Guid.Parse("3d4e5f82-4d89-4620-8023-9e90473b8c2d"),
                    Name = "Панасюк Йомер",
                    Birthdate = DateTime.Parse("1990-11-20")
                }, new Entities.Employee
                {
                    Id = Guid.Parse("87329e18-3d28-4a3d-a141-74c9fb8705ec"),
                    FirmId = Guid.Parse("4e96d0a1-2ba9-411a-afd7-27bceb862c93"),
                    Name = "Стельмащук Васса",
                    Birthdate = DateTime.Parse("1973-03-28")
                }, new Entities.Employee
                {
                    Id = Guid.Parse("6b2d88b4-7fdc-4ede-bb51-7658e7ca910f"),
                    FirmId = Guid.Parse("50caad3a-5055-4b94-90ce-72886cc9d5b0"),
                    Name = "Журавленко Жозефіна",
                    Birthdate = DateTime.Parse("2002-11-28")
                }, new Entities.Employee
                {
                    Id = Guid.Parse("fc384f1a-5bed-4a5e-b677-78aa9fbbc673"),
                    FirmId = Guid.Parse("8cef13dc-8ccd-4ef9-ac39-3b1f4860a2e5"),
                    Name = "Савойка Цецілія",
                    Birthdate = DateTime.Parse("1990-08-09")
                }, new Entities.Employee
                {
                    Id = Guid.Parse("cb072571-1053-4f0e-ae39-8088e14f92af"),
                    FirmId = Guid.Parse("50caad3a-5055-4b94-90ce-72886cc9d5b0"),
                    Name = "Шкурган Пантелеймон",
                    Birthdate = DateTime.Parse("1972-12-13")
                }, new Entities.Employee
                {
                    Id = Guid.Parse("643b15e8-b083-4ddb-a060-8446d1493b51"),
                    FirmId = Guid.Parse("3d4e5f82-4d89-4620-8023-9e90473b8c2d"),
                    Name = "Науменко Жадан",
                    Birthdate = DateTime.Parse("2006-02-27")
                }, new Entities.Employee
                {
                    Id = Guid.Parse("d98116e4-bf64-48fd-866b-85cea4d0c793"),
                    FirmId = Guid.Parse("1ea7d698-924b-47df-b574-88f4f71306e6"),
                    Name = "Циба Горпина",
                    Birthdate = DateTime.Parse("2000-11-23")
                }, new Entities.Employee
                {
                    Id = Guid.Parse("4e236c70-b672-4e11-8f5b-87093e82b29e"),
                    FirmId = Guid.Parse("fb1286a8-2d7f-436b-bee1-8fadaaaf104b"),
                    Name = "Іваненко Єва",
                    Birthdate = DateTime.Parse("1973-07-05")
                }, new Entities.Employee
                {
                    Id = Guid.Parse("066744b5-dac1-4f37-bfcf-8c6f25d3a496"),
                    FirmId = Guid.Parse("48f0708a-11d4-4648-9ac7-12a1fff5e1e7"),
                    Name = "Криштопович Еміль",
                    Birthdate = DateTime.Parse("1993-08-10")
                }, new Entities.Employee
                {
                    Id = Guid.Parse("98af6726-7943-4de4-8aa7-8d91ecca74ff"),
                    FirmId = Guid.Parse("931dfb69-edfa-4fe8-8c7d-1edd00d22498"),
                    Name = "Рябченко Леля",
                    Birthdate = DateTime.Parse("2005-01-18")
                }, new Entities.Employee
                {
                    Id = Guid.Parse("e6e8d542-eef1-409d-aadb-8f36b4a80f7a"),
                    FirmId = Guid.Parse("6d2a6a6a-488e-488b-8d2f-c77f1b3416a3"),
                    Name = "Їжак Чесмил",
                    Birthdate = DateTime.Parse("1980-04-07")
                }, new Entities.Employee
                {
                    Id = Guid.Parse("841f06fe-3264-4bc3-beef-8fa92cee2293"),
                    FirmId = Guid.Parse("931dfb69-edfa-4fe8-8c7d-1edd00d22498"),
                    Name = "Якобовський Мстивой",
                    Birthdate = DateTime.Parse("1988-01-01")
                }, new Entities.Employee
                {
                    Id = Guid.Parse("e9a1c852-affd-4742-9542-958b8975b527"),
                    FirmId = Guid.Parse("1ea7d698-924b-47df-b574-88f4f71306e6"),
                    Name = "Їжак Хотибор",
                    Birthdate = DateTime.Parse("1984-11-26")
                }, new Entities.Employee
                {
                    Id = Guid.Parse("3ffc8f03-aa6e-4fea-b83a-9791d2bf8ea3"),
                    FirmId = Guid.Parse("fb1286a8-2d7f-436b-bee1-8fadaaaf104b"),
                    Name = "Жевченко Цвітана",
                    Birthdate = DateTime.Parse("2000-11-09")
                }, new Entities.Employee
                {
                    Id = Guid.Parse("a034f7db-026e-4389-adb8-9985ef337703"),
                    FirmId = Guid.Parse("6d2a6a6a-488e-488b-8d2f-c77f1b3416a3"),
                    Name = "Трух Іоанн",
                    Birthdate = DateTime.Parse("1973-07-11")
                }, new Entities.Employee
                {
                    Id = Guid.Parse("0993de6f-0509-4c57-98be-a27cf201d6e4"),
                    FirmId = Guid.Parse("8cef13dc-8ccd-4ef9-ac39-3b1f4860a2e5"),
                    Name = "Ярова Бажана",
                    Birthdate = DateTime.Parse("2004-06-24")
                }, new Entities.Employee
                {
                    Id = Guid.Parse("fc32e420-0aa5-490a-8e2b-a2978208595e"),
                    FirmId = Guid.Parse("50caad3a-5055-4b94-90ce-72886cc9d5b0"),
                    Name = "Семеніхін Лаврін",
                    Birthdate = DateTime.Parse("1999-12-08")
                }, new Entities.Employee
                {
                    Id = Guid.Parse("2e8f2133-1a01-42dc-aefd-a3a651510108"),
                    FirmId = Guid.Parse("c6d1ee0e-cb5b-4b13-96a9-f87714a27c2a"),
                    Name = "Яремко Яр",
                    Birthdate = DateTime.Parse("2001-08-17")
                }, new Entities.Employee
                {
                    Id = Guid.Parse("fe24a19a-f393-4f75-8b0d-a407ba89691d"),
                    FirmId = Guid.Parse("3d4e5f82-4d89-4620-8023-9e90473b8c2d"),
                    Name = "Цимбалюк Шерлок",
                    Birthdate = DateTime.Parse("1982-03-05")
                }, new Entities.Employee
                {
                    Id = Guid.Parse("04d0ac0b-86ce-4321-ae43-a4c58556629f"),
                    FirmId = Guid.Parse("c6d1ee0e-cb5b-4b13-96a9-f87714a27c2a"),
                    Name = "Данькевич Будислав",
                    Birthdate = DateTime.Parse("1996-09-12")
                }, new Entities.Employee
                {
                    Id = Guid.Parse("8759ee27-37c9-4ceb-b931-a548f17f4c37"),
                    FirmId = Guid.Parse("c6d1ee0e-cb5b-4b13-96a9-f87714a27c2a"),
                    Name = "Гринчак Доморад",
                    Birthdate = DateTime.Parse("1984-09-18")
                }, new Entities.Employee
                {
                    Id = Guid.Parse("82f8dba2-1858-4e1a-abd2-a59df6965f9d"),
                    FirmId = Guid.Parse("48f0708a-11d4-4648-9ac7-12a1fff5e1e7"),
                    Name = "Устиянович Улита",
                    Birthdate = DateTime.Parse("1989-08-16")
                }, new Entities.Employee
                {
                    Id = Guid.Parse("23eeb88a-8851-48f0-bb30-a9889a3f7471"),
                    FirmId = Guid.Parse("3d4e5f82-4d89-4620-8023-9e90473b8c2d"),
                    Name = "Воєвода Іоанн",
                    Birthdate = DateTime.Parse("2003-02-10")
                }, new Entities.Employee
                {
                    Id = Guid.Parse("a060d3e8-6156-4a6a-9826-b15da3ec2854"),
                    FirmId = Guid.Parse("c6d1ee0e-cb5b-4b13-96a9-f87714a27c2a"),
                    Name = "Підопригора Зорян",
                    Birthdate = DateTime.Parse("1988-11-10")
                }, new Entities.Employee
                {
                    Id = Guid.Parse("4a7174ce-7b95-4260-bc8c-b5e3cc028073"),
                    FirmId = Guid.Parse("fb1286a8-2d7f-436b-bee1-8fadaaaf104b"),
                    Name = "Савчак Сарра",
                    Birthdate = DateTime.Parse("2008-04-09")
                }, new Entities.Employee
                {
                    Id = Guid.Parse("3178af87-e786-4138-ad91-b74edd3acf48"),
                    FirmId = Guid.Parse("3d4e5f82-4d89-4620-8023-9e90473b8c2d"),
                    Name = "Цимбал Дана",
                    Birthdate = DateTime.Parse("2001-02-16")
                }, new Entities.Employee
                {
                    Id = Guid.Parse("96fb6838-6208-4c31-a77f-bd11fc06eb1c"),
                    FirmId = Guid.Parse("1ea7d698-924b-47df-b574-88f4f71306e6"),
                    Name = "Гринішак Шанетта",
                    Birthdate = DateTime.Parse("1994-12-23")
                }, new Entities.Employee
                {
                    Id = Guid.Parse("d9b7f2a3-ecb8-4faf-9956-c69c8e00597c"),
                    FirmId = Guid.Parse("1ea7d698-924b-47df-b574-88f4f71306e6"),
                    Name = "Полтавець Квітка",
                    Birthdate = DateTime.Parse("1996-09-18")
                }, new Entities.Employee
                {
                    Id = Guid.Parse("eb5bc95f-b3f8-49f8-9cff-c6d169a52e48"),
                    FirmId = Guid.Parse("48f0708a-11d4-4648-9ac7-12a1fff5e1e7"),
                    Name = "Устимович Пребислав",
                    Birthdate = DateTime.Parse("1970-11-25")
                }, new Entities.Employee
                {
                    Id = Guid.Parse("35815e16-769b-430b-8c64-ca7f2b23189c"),
                    FirmId = Guid.Parse("4e96d0a1-2ba9-411a-afd7-27bceb862c93"),
                    Name = "Гриб Русан",
                    Birthdate = DateTime.Parse("1992-07-30")
                }, new Entities.Employee
                {
                    Id = Guid.Parse("f26d87cb-3993-469e-93a5-ce2c3da12336"),
                    FirmId = Guid.Parse("3d4e5f82-4d89-4620-8023-9e90473b8c2d"),
                    Name = "Філіпенко Полель",
                    Birthdate = DateTime.Parse("1972-11-06")
                }, new Entities.Employee
                {
                    Id = Guid.Parse("236dbc89-e48a-4748-a7c5-cf42f37cc016"),
                    FirmId = Guid.Parse("6d2a6a6a-488e-488b-8d2f-c77f1b3416a3"),
                    Name = "Євецька Цецілія",
                    Birthdate = DateTime.Parse("1971-04-23")
                }, new Entities.Employee
                {
                    Id = Guid.Parse("863d17e9-d16b-46d0-a69e-d12e1447a706"),
                    FirmId = Guid.Parse("48f0708a-11d4-4648-9ac7-12a1fff5e1e7"),
                    Name = "Онищук Медомир",
                    Birthdate = DateTime.Parse("1999-06-11")
                }, new Entities.Employee
                {
                    Id = Guid.Parse("306fd89d-e0f0-42bb-addd-d3abbfb1eac6"),
                    FirmId = Guid.Parse("6d2a6a6a-488e-488b-8d2f-c77f1b3416a3"),
                    Name = "Блажевська Шушана",
                    Birthdate = DateTime.Parse("1994-02-11")
                }, new Entities.Employee
                {
                    Id = Guid.Parse("cca1bca0-3346-48e6-97a0-d6be43372072"),
                    FirmId = Guid.Parse("50caad3a-5055-4b94-90ce-72886cc9d5b0"),
                    Name = "Хаварівська Карина",
                    Birthdate = DateTime.Parse("2000-06-29")
                }, new Entities.Employee
                {
                    Id = Guid.Parse("d4cc884c-cbc8-466c-9e85-dc5f74fdaf99"),
                    FirmId = Guid.Parse("6d2a6a6a-488e-488b-8d2f-c77f1b3416a3"),
                    Name = "Олешко Адріан",
                    Birthdate = DateTime.Parse("1983-02-23")
                }, new Entities.Employee
                {
                    Id = Guid.Parse("eb540332-9d36-49ed-85b5-deed6930df58"),
                    FirmId = Guid.Parse("fb1286a8-2d7f-436b-bee1-8fadaaaf104b"),
                    Name = "Манило Юдихва",
                    Birthdate = DateTime.Parse("1992-09-24")
                }, new Entities.Employee
                {
                    Id = Guid.Parse("8d68bc4c-7bf8-40fe-9a81-e04b3d91497b"),
                    FirmId = Guid.Parse("c6d1ee0e-cb5b-4b13-96a9-f87714a27c2a"),
                    Name = "Пилипишин Щастибог",
                    Birthdate = DateTime.Parse("2003-11-05")
                }, new Entities.Employee
                {
                    Id = Guid.Parse("8dfab2e7-d100-4e53-b94c-e2bbbc363673"),
                    FirmId = Guid.Parse("8cef13dc-8ccd-4ef9-ac39-3b1f4860a2e5"),
                    Name = "Онофрійчук Никодим",
                    Birthdate = DateTime.Parse("1978-08-02")
                }, new Entities.Employee
                {
                    Id = Guid.Parse("c15801bb-08c1-4dbb-9dc9-e37dcfd7f462"),
                    FirmId = Guid.Parse("48f0708a-11d4-4648-9ac7-12a1fff5e1e7"),
                    Name = "Їжак Гордислав",
                    Birthdate = DateTime.Parse("1982-10-05")
                }, new Entities.Employee
                {
                    Id = Guid.Parse("205a8ff3-cfea-4067-80cf-e5667bac231c"),
                    FirmId = Guid.Parse("6d2a6a6a-488e-488b-8d2f-c77f1b3416a3"),
                    Name = "Ус Шарлота",
                    Birthdate = DateTime.Parse("1977-02-04")
                }, new Entities.Employee
                {
                    Id = Guid.Parse("f799d7c6-4ab5-4243-af1f-e56e0564ded3"),
                    FirmId = Guid.Parse("6d2a6a6a-488e-488b-8d2f-c77f1b3416a3"),
                    Name = "Синько Федір",
                    Birthdate = DateTime.Parse("1982-11-08")
                }, new Entities.Employee
                {
                    Id = Guid.Parse("0d0858e7-0a8e-49e1-80ac-eaf9abcfe1c8"),
                    FirmId = Guid.Parse("48f0708a-11d4-4648-9ac7-12a1fff5e1e7"),
                    Name = "Бусленко Йосифата",
                    Birthdate = DateTime.Parse("1992-09-17")
                }, new Entities.Employee
                {
                    Id = Guid.Parse("8999366a-b868-4a84-a934-ed60b694b189"),
                    FirmId = Guid.Parse("48f0708a-11d4-4648-9ac7-12a1fff5e1e7"),
                    Name = "Омельчук Остромов",
                    Birthdate = DateTime.Parse("1977-02-22")
                }, new Entities.Employee
                {
                    Id = Guid.Parse("dffdf291-c6d6-4af2-93b2-f452531c5f95"),
                    FirmId = Guid.Parse("fb1286a8-2d7f-436b-bee1-8fadaaaf104b"),
                    Name = "Безсмертний Євгеній",
                    Birthdate = DateTime.Parse("2002-01-02")
                }, new Entities.Employee
                {
                    Id = Guid.Parse("7ccbbc76-adc1-40e9-8787-fc0a7fa4b2f4"),
                    FirmId = Guid.Parse("4e96d0a1-2ba9-411a-afd7-27bceb862c93"),
                    Name = "Ерстенюк Дарина",
                    Birthdate = DateTime.Parse("1998-03-27")
                }, new Entities.Employee
                {
                    Id = Guid.Parse("cc8dd042-362e-4d5f-9a1a-fca88c9932b9"),
                    FirmId = Guid.Parse("931dfb69-edfa-4fe8-8c7d-1edd00d22498"),
                    Name = "Запорожець Радослав",
                    Birthdate = DateTime.Parse("1981-11-03")
                }, new Entities.Employee
                {
                    Id = Guid.Parse("3df43ff3-9a36-423f-93e4-fdfb9490caf1"),
                    FirmId = Guid.Parse("48f0708a-11d4-4648-9ac7-12a1fff5e1e7"),
                    Name = "Щаслива Альбертина",
                    Birthdate = DateTime.Parse("2002-02-18")
                }, new Entities.Employee
                {
                    Id = Guid.Parse("35ac3ab8-bf58-4291-b671-ff2f118893c3"),
                    FirmId = Guid.Parse("48f0708a-11d4-4648-9ac7-12a1fff5e1e7"),
                    Name = "Косьяненко Пор",
                    Birthdate = DateTime.Parse("1976-09-01")
                }, new Entities.Employee
                {
                    Id = Guid.Parse("2bbafef0-3367-4561-95c9-ff789318cc23"),
                    FirmId = Guid.Parse("fb1286a8-2d7f-436b-bee1-8fadaaaf104b"),
                    Name = "Юденко Інга",
                    Birthdate = DateTime.Parse("1987-08-13")
                }, new Entities.Employee
                {
                    Id = Guid.Parse("76f2594c-a006-44b3-afaa-ffcfa0159c2d"),
                    FirmId = Guid.Parse("8cef13dc-8ccd-4ef9-ac39-3b1f4860a2e5"),
                    Name = "Юрченко Параскевія",
                    Birthdate = DateTime.Parse("1985-09-05")
                }, new Entities.Employee
                {
                    Id = Guid.Parse("b6d219e2-a832-4720-8443-fff68d5fb805"),
                    FirmId = Guid.Parse("1ea7d698-924b-47df-b574-88f4f71306e6"),
                    Name = "Губ`як Шарлота",
                    Birthdate = DateTime.Parse("1998-12-30")
                },//Сотрудники для "TechNova Solutions Inc" (FirmId = d1b2c3d4-e5f6-4711-9a2b-0000000000a1)
                new Entities.Employee
                {
                    Id = Guid.Parse("f1111111-1111-4111-8111-0000000000a1"),
                    FirmId = Guid.Parse("d1b2c3d4-e5f6-4711-9a2b-0000000000a1"),
                    Name = "Іваненко Петро",
                    Birthdate = DateTime.Parse("1985-04-12")
                },
                new Entities.Employee
                {
                    Id = Guid.Parse("f2222222-2222-4222-8222-0000000000a2"),
                    FirmId = Guid.Parse("d1b2c3d4-e5f6-4711-9a2b-0000000000a1"),
                    Name = "Петренко Марія",
                    Birthdate = DateTime.Parse("1990-09-03")
                },
                new Entities.Employee
                {
                    Id = Guid.Parse("f3333333-3333-4333-8333-0000000000a3"),
                    FirmId = Guid.Parse("d1b2c3d4-e5f6-4711-9a2b-0000000000a1"),
                    Name = "Сидоренко Олег",
                    Birthdate = DateTime.Parse("1978-01-20")
                },
                new Entities.Employee
                {
                    Id = Guid.Parse("f4444444-4444-4444-8444-0000000000a4"),
                    FirmId = Guid.Parse("d1b2c3d4-e5f6-4711-9a2b-0000000000a1"),
                    Name = "Коваленко Анна",
                    Birthdate = DateTime.Parse("1995-07-15")
                },
                new Entities.Employee
                {
                    Id = Guid.Parse("f5555555-5555-4555-8555-0000000000a5"),
                    FirmId = Guid.Parse("d1b2c3d4-e5f6-4711-9a2b-0000000000a1"),
                    Name = "Богданенко Роман",
                    Birthdate = DateTime.Parse("1982-11-30")
                },

                // Сотрудники для "Sunrise Components Ltd" (FirmId = e2c3d4e5-f6a7-4822-8b3c-0000000000b2)
                new Entities.Employee
                {
                    Id = Guid.Parse("f6666666-6666-4666-8666-0000000000b6"),
                    FirmId = Guid.Parse("e2c3d4e5-f6a7-4822-8b3c-0000000000b2"),
                    Name = "Левченко Назар",
                    Birthdate = DateTime.Parse("1987-03-22")
                },
                new Entities.Employee
                {
                    Id = Guid.Parse("f7777777-7777-4777-8777-0000000000b7"),
                    FirmId = Guid.Parse("e2c3d4e5-f6a7-4822-8b3c-0000000000b2"),
                    Name = "Мартинюк Оксана",
                    Birthdate = DateTime.Parse("1991-06-10")
                },
                new Entities.Employee
                {
                    Id = Guid.Parse("f8888888-8888-4888-8888-0000000000b8"),
                    FirmId = Guid.Parse("e2c3d4e5-f6a7-4822-8b3c-0000000000b2"),
                    Name = "Проценко Ігор",
                    Birthdate = DateTime.Parse("1976-12-05")
                },
                new Entities.Employee
                {
                    Id = Guid.Parse("f9999999-9999-4999-8999-0000000000b9"),
                    FirmId = Guid.Parse("e2c3d4e5-f6a7-4822-8b3c-0000000000b2"),
                    Name = "Демченко Лідія",
                    Birthdate = DateTime.Parse("1993-02-28")
                },
                new Entities.Employee
                {
                    Id = Guid.Parse("fa0a0a0a-0a0a-4a0a-8a0a-0000000000ba"),
                    FirmId = Guid.Parse("e2c3d4e5-f6a7-4822-8b3c-0000000000b2"),
                    Name = "Гнатюк Василь",
                    Birthdate = DateTime.Parse("1980-08-19")
                });
        }
        private void SeedProducts(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Entities.Product>().HasData(
                new Entities.Product
                {
                    Id = Guid.Parse("3d2b217b-9960-41ea-96e5-03890d906c0f"),
                    Name = "Кабель HOCO X1 Rapid для Type-C , білий  ",
                    Price = 120m
                }, new Entities.Product
                {
                    Id = Guid.Parse("4892fc19-80ff-41ff-beeb-086240bc1b31"),
                    Name = "Миша USB Esperanza EM102K",
                    Price = 180m
                }, new Entities.Product
                {
                    Id = Guid.Parse("fbb24d1d-a814-4fa3-9751-0a2aef3fadc0"),
                    Name = "Системний блок Xeon X5450 / Biostar G41D3 / 8Gb / SSD 120 / frontier 400",
                    Price = 4000m
                }, new Entities.Product
                {
                    Id = Guid.Parse("7ae7d140-a3a6-4c9d-9480-0c2438310e98"),
                    Name = "Системний блок A4-6300 2 ядра FM2 Gigabyte GA-F2A68HM-S1    6Gb DDR3/ 500Gb /2xUSB3.0/VGA",
                    Price = 3500m
                }, new Entities.Product
                {
                    Id = Guid.Parse("25a87fc2-435c-4dc9-8088-0cf2fa324aea"),
                    Name = "Монітор 22” LG W2243S VGA  1920 x 1080",
                    Price = 1500m
                }, new Entities.Product
                {
                    Id = Guid.Parse("25fba7a0-4691-4814-8f9a-0d7f8928416e"),
                    Name = "Веб-камера 2МП с мікрофоном",
                    Price = 300m
                }, new Entities.Product
                {
                    Id = Guid.Parse("10cc39da-7c0c-45d2-8ef6-0f0dee6137e2"),
                    Name = "Блок живлення БП 5В 4А",
                    Price = 250m
                }, new Entities.Product
                {
                    Id = Guid.Parse("51467a14-c2c4-40e5-a27a-0f800885f12d"),
                    Name = "RAM Для ноутбука DDR3L  2Gb в асортименті  ",
                    Price = 250m
                }, new Entities.Product
                {
                    Id = Guid.Parse("6b85e4ce-5c91-421f-b86e-0fc767e74bb8"),
                    Name = "Кабель для Iphone HOCO x26 2,4A 100cm",
                    Price = 140m
                }, new Entities.Product
                {
                    Id = Guid.Parse("c88e1f15-8400-4fc4-9d4e-103a4f72e5ba"),
                    Name = "RAM DDR2 2Gb  в асортименті  ",
                    Price = 200m
                }, new Entities.Product
                {
                    Id = Guid.Parse("a0efc3a1-0ce2-4947-9707-10466df5bcb4"),
                    Name = "HDD SATA 1Tb",
                    Price = 850m
                }, new Entities.Product
                {
                    Id = Guid.Parse("c67c96a8-680b-405b-a831-12e7dff972a0"),
                    Name = "RAM DDR3 4Gb HyperX Beast 1600Mhz",
                    Price = 400m
                }, new Entities.Product
                {
                    Id = Guid.Parse("617f37c2-bcbb-4019-866e-14be2018f088"),
                    Name = "Системний блок Sempron 2300 DualCore 1,6Ghz / 3Gb / 80Gb",
                    Price = 600m
                }, new Entities.Product
                {
                    Id = Guid.Parse("3fe71809-4b33-40a4-aa97-15f4b3ad374a"),
                    Name = "Блок живлення 400Вт VINGA новые VPS-400-12    VPS-400-120",
                    Price = 400m
                }, new Entities.Product
                {
                    Id = Guid.Parse("df26ee3e-3db4-45e8-83e4-17c8975785a7"),
                    Name = "RAM DDR3 8Gb ",
                    Price = 800m
                }, new Entities.Product
                {
                    Id = Guid.Parse("f0a0cf69-e963-4e06-b676-18c9f17e870c"),
                    Name = "Блок живлення 400Вт в асортименті",
                    Price = 300m
                }, new Entities.Product
                {
                    Id = Guid.Parse("dc5698a0-3ef6-48d1-8eda-1bdd3b0b4dc0"),
                    Name = "Миша бездротова Maxter mr-337 ",
                    Price = 250m
                }, new Entities.Product
                {
                    Id = Guid.Parse("b892bdcf-4919-4c6b-9c97-1be7f786c4b5"),
                    Name = "Миша USB Gembird KB-U-103-UA",
                    Price = 180m
                }, new Entities.Product
                {
                    Id = Guid.Parse("14f8629f-871f-44d7-9986-1c3ab1d17b24"),
                    Name = "SSD 120Gb Foxconn Foxline X5",
                    Price = 600m
                }, new Entities.Product
                {
                    Id = Guid.Parse("d97f46e4-d6df-467a-8739-1c5fb721c48f"),
                    Name = "Блок живлення DELL 19.5V, 3.34A, 65W, 7.4*5.0-PIN   ",
                    Price = 550m
                }, new Entities.Product
                {
                    Id = Guid.Parse("8283947d-63e4-4b63-968a-1daea45e2efc"),
                    Name = "Миша USB Havit HV-MS858GT бездротова",
                    Price = 300m
                }, new Entities.Product
                {
                    Id = Guid.Parse("ef3b3658-9fb9-4940-8c02-1e27b54b706a"),
                    Name = "Блок живлення Acer 65W 19V 3.42A 5.5x1.7 + силовий кабель  ",
                    Price = 550m
                }, new Entities.Product
                {
                    Id = Guid.Parse("93ed11a2-ca8b-4692-9c8e-1f3d349c9494"),
                    Name = "Веб-камера Logitech C170",
                    Price = 500m
                }, new Entities.Product
                {
                    Id = Guid.Parse("1a91820a-5ed9-45d4-a172-2d209fecf9d8"),
                    Name = "Блок живлення HP 90W 19V 4.74A 4.8x1.7 ",
                    Price = 300m
                }, new Entities.Product
                {
                    Id = Guid.Parse("824c3734-eede-4baf-8ca4-2d2c9fc5c5c1"),
                    Name = "Ноутбук 14” Toshiba L745 Intel Core i3-2310M 2,1Ghz/ 3Gb / 320Gb / батарея не держит, пропадает звук",
                    Price = 3000m
                }, new Entities.Product
                {
                    Id = Guid.Parse("871e77bd-50c1-4fe2-8189-2d3e42e557b1"),
                    Name = "Карман 2,5” USB IDE підтримка до 1Тб",
                    Price = 200m
                }, new Entities.Product
                {
                    Id = Guid.Parse("4eb49873-9b7c-4b5e-92a9-2f2b3f46fec4"),
                    Name = "RAM DDR3 4Gb в асортименті",
                    Price = 350m
                }, new Entities.Product
                {
                    Id = Guid.Parse("c10b8321-014c-416f-9139-2feb953d9e82"),
                    Name = "Блок живлення 400Вт Vinga б/в",
                    Price = 300m
                }, new Entities.Product
                {
                    Id = Guid.Parse("a75b3f00-7e80-434f-aba1-33a20b2f422e"),
                    Name = "Блок живлення 390Вт CoolerMaster RS-390-PMSR-A3",
                    Price = 400m
                }, new Entities.Product
                {
                    Id = Guid.Parse("48039dbf-7a7f-4e34-87f6-38388f253468"),
                    Name = "RAM Для ноутбука DDR3  1Gb",
                    Price = 30m
                }, new Entities.Product
                {
                    Id = Guid.Parse("be66c0f2-b4fa-494d-9a2b-39ac53dbeb0f"),
                    Name = "RAM DDR3 1Gb  ",
                    Price = 250m
                }, new Entities.Product
                {
                    Id = Guid.Parse("1eea0854-748f-47f2-a642-3a97b5d7ae3b"),
                    Name = "HDD SATA 250Gb",
                    Price = 300m
                }, new Entities.Product
                {
                    Id = Guid.Parse("3e1b052d-bf9e-4c31-b7fb-3fb4fb13bc26"),
                    Name = "Монітор 17” ViewSonic VA703b  VGA",
                    Price = 500m
                }, new Entities.Product
                {
                    Id = Guid.Parse("529db51d-6658-4877-a224-4136bb892a59"),
                    Name = "Блок живлення HP 19V, 4.74A, 90W, 4.5*3.0-PIN + силовий кабель  ",
                    Price = 300m
                }, new Entities.Product
                {
                    Id = Guid.Parse("99b7e98a-a6af-4690-9be6-43e6230b6877"),
                    Name = "Кабель microUSB HOCO x13 2,4A 100cm",
                    Price = 110m
                }, new Entities.Product
                {
                    Id = Guid.Parse("91dd91a0-2998-428b-9400-44a0fc7b1984"),
                    Name = "Блок живлення 450Вт DeTech ",
                    Price = 400m
                }, new Entities.Product
                {
                    Id = Guid.Parse("1a52f384-5fe0-48e3-b420-45de614d1547"),
                    Name = "Блок живлення Lenovo 20V  2.25A  USB pin + силовий кабель ",
                    Price = 300m
                }, new Entities.Product
                {
                    Id = Guid.Parse("73732da8-2a1e-4c93-8430-4938a06086d6"),
                    Name = "Клавіатура USB KB-8320U Gembird",
                    Price = 280m
                }, new Entities.Product
                {
                    Id = Guid.Parse("5d325160-1de8-4a13-8b2c-4fabd1a9a5d1"),
                    Name = "Адаптер (Optibay) 2.5 SATA-SATA, 12,7 мм ",
                    Price = 200m
                }, new Entities.Product
                {
                    Id = Guid.Parse("005035c9-81ff-4fe8-8fe3-521f1f5d41b0"),
                    Name = "Блок живлення 400Вт FSP ATX-400PNR",
                    Price = 400m
                }, new Entities.Product
                {
                    Id = Guid.Parse("f3475cd9-218e-4b16-a565-5733eaaba8dd"),
                    Name = "Монітор 20” Samsung 2043nw   VGA  1680x1050",
                    Price = 1450m
                }, new Entities.Product
                {
                    Id = Guid.Parse("95979092-fa5a-4a98-b82c-5790401ded37"),
                    Name = "HDD SATA 160Gb",
                    Price = 200m
                }, new Entities.Product
                {
                    Id = Guid.Parse("ac732262-b2a1-47b3-96c1-57b4be0443fa"),
                    Name = "RAM Для ноутбука DDR4  4Gb  в асортименті  ",
                    Price = 500m
                }, new Entities.Product
                {
                    Id = Guid.Parse("fc829c60-33ff-4995-8999-5830bd2e92eb"),
                    Name = "Клавіатура PS/2 Defender HB-520",
                    Price = 200m
                }, new Entities.Product
                {
                    Id = Guid.Parse("95eab3eb-0c23-4f42-9802-58997b031392"),
                    Name = "Кабель Hoco X35 Premium Charging для Type-C , чорний , 0.25м",
                    Price = 100m
                }, new Entities.Product
                {
                    Id = Guid.Parse("05d0fb39-6374-4499-9bb9-58ccfaec0f8d"),
                    Name = "HDD Для ноутбука SATA 160Gb",
                    Price = 300m
                }, new Entities.Product
                {
                    Id = Guid.Parse("2f2a0df0-f682-40ac-8cc3-592518598b3d"),
                    Name = "Клавіатура GamePro GK670 ігрова з підсвіткою",
                    Price = 550m
                }, new Entities.Product
                {
                    Id = Guid.Parse("93e80484-4abf-4402-8bc1-5cf52d1eea95"),
                    Name = "Клавіатура PS2 Gembird KB-103-UA",
                    Price = 250m
                }, new Entities.Product
                {
                    Id = Guid.Parse("da4fb2b2-d62a-4834-98a3-5d91877cbb70"),
                    Name = "Блок живлення Asus 33W(19V/1.75A) ASUS special USB",
                    Price = 550m
                }, new Entities.Product
                {
                    Id = Guid.Parse("37ace814-896e-446a-a313-5dbf78a32a93"),
                    Name = "Блок живлення 350Вт в асортименті",
                    Price = 250m
                }, new Entities.Product
                {
                    Id = Guid.Parse("8e866909-1c8b-4aa6-8b0a-5df802e9d0a4"),
                    Name = "Монітор 19” LG L1900R-BF  DVI + зовнішній БЖ",
                    Price = 1500m
                }, new Entities.Product
                {
                    Id = Guid.Parse("a6c7afba-220a-4c77-b94f-5dfe3f86bbf9"),
                    Name = "Блок живлення HP 19,5V  2,05А 40Вт  7.4*5.0-PIN ",
                    Price = 300m
                }, new Entities.Product
                {
                    Id = Guid.Parse("fb73719e-d763-4d16-b7ca-5ebadffebb82"),
                    Name = "Блок живлення HP 19V, 2.31A, 4.5*3.0-PIN + силовий кабель  ",
                    Price = 300m
                }, new Entities.Product
                {
                    Id = Guid.Parse("f5df2c81-df25-41e3-a9e6-5faf2257b4bf"),
                    Name = "RAM DDR2 4Gb  для AMD ",
                    Price = 300m
                }, new Entities.Product
                {
                    Id = Guid.Parse("e690477e-a48f-4e88-bf6c-60e8cdc99b05"),
                    Name = "Миша бездротова Maxxter біла Mr-333-W",
                    Price = 300m
                }, new Entities.Product
                {
                    Id = Guid.Parse("861074e9-b12d-4c9e-8313-61d9d024b92a"),
                    Name = "Монітор 22” LG 22EN33S  VGA 1920 x 1080",
                    Price = 1500m
                }, new Entities.Product
                {
                    Id = Guid.Parse("6d0c41c3-4825-4f63-935f-627de65dcf93"),
                    Name = "Блок живлення 350Вт пікова 400Вт FSP  в асортименті",
                    Price = 300m
                }, new Entities.Product
                {
                    Id = Guid.Parse("14e645ca-7559-4eec-a574-6ae985bf620c"),
                    Name = "Монітор 15” NEC 500p   VGA",
                    Price = 300m
                }, new Entities.Product
                {
                    Id = Guid.Parse("9e880c16-5dc5-40d9-a9c6-6ddac2ff2322"),
                    Name = "Блок живлення 400Вт FSP ATX-400PNR PRO ",
                    Price = 650m
                }, new Entities.Product
                {
                    Id = Guid.Parse("7b2c4294-ded8-4fbb-bcc8-70574824fc30"),
                    Name = "Блок живлення Asus 65W 19V 3.42A 5.5x2.5 + силовий кабель  ",
                    Price = 550m
                }, new Entities.Product
                {
                    Id = Guid.Parse("dfd594db-4e47-4ea3-a572-70f9e85f2126"),
                    Name = "RAM DDR3 4Gb серверна",
                    Price = 300m
                }, new Entities.Product
                {
                    Id = Guid.Parse("27e028e2-5281-40e9-bf37-754e5b3fb550"),
                    Name = "Кабель TypeC — 3,5” ",
                    Price = 100m
                }, new Entities.Product
                {
                    Id = Guid.Parse("42eae1f1-2b49-4d76-a012-7a5bbd17a2f9"),
                    Name = "RAM DDR3 4Gb Kingston",
                    Price = 400m
                }, new Entities.Product
                {
                    Id = Guid.Parse("01321943-1e98-43e3-a905-7bab66774c6f"),
                    Name = "Адаптер (Optibay) 2.5 SATA-SATA, 9,5 мм ",
                    Price = 200m
                }, new Entities.Product
                {
                    Id = Guid.Parse("5570f8dc-c4e5-46ae-816b-7e28741e4f93"),
                    Name = "RAM DDR2 1Gb  в асортименті  ",
                    Price = 150m
                }, new Entities.Product
                {
                    Id = Guid.Parse("e36556f3-f9e8-4374-a3e4-7fa39d27af1a"),
                    Name = "OTG TypeC",
                    Price = 150m
                }, new Entities.Product
                {
                    Id = Guid.Parse("daeaa256-7ee6-4480-b4b7-819d7146468d"),
                    Name = "RAM DDR3 2Gb в асортименті  ",
                    Price = 150m
                }, new Entities.Product
                {
                    Id = Guid.Parse("fb2c9434-15b2-4cba-98ee-828f1fe93442"),
                    Name = "Веб-камера A4Tech PK-950H  Full HD (1080p)",
                    Price = 650m
                }, new Entities.Product
                {
                    Id = Guid.Parse("b285e083-be43-4852-ab4e-870d0a5218cd"),
                    Name = "Миша бездротова Meetion MT-R545 чорна",
                    Price = 300m
                }, new Entities.Product
                {
                    Id = Guid.Parse("f7e21f11-4895-4841-9784-89956131c551"),
                    Name = "Блок живлення 300Вт в асортименті",
                    Price = 200m
                }, new Entities.Product
                {
                    Id = Guid.Parse("759fdfbd-349d-4ab2-8889-8d39658f9561"),
                    Name = "Блок живлення БП 9В 0,85А",
                    Price = 120m
                }, new Entities.Product
                {
                    Id = Guid.Parse("d9f0b9fd-c733-489c-a882-907a605dfdc7"),
                    Name = "Блок живлення Lenovo 20V, 3.25A,65W, 7.9*5.5мм, 3 hole, with pin inside  ",
                    Price = 300m
                }, new Entities.Product
                {
                    Id = Guid.Parse("a47c6020-c03d-4323-8b05-91c8c2f8f775"),
                    Name = "Монітор Lg 12v 2a",
                    Price = 300m
                }, new Entities.Product
                {
                    Id = Guid.Parse("37e0e876-de2e-4187-b804-941a25fb9e06"),
                    Name = "Миша бездротова REAL-EL RM-304 чорна",
                    Price = 350m
                }, new Entities.Product
                {
                    Id = Guid.Parse("d2bf51b7-ac9b-42cc-b11e-9684936f0d30"),
                    Name = "RAM Для ноутбука DDR3  8Gb",
                    Price = 700m
                }, new Entities.Product
                {
                    Id = Guid.Parse("5c6036d6-efa4-4185-985f-97433b86c393"),
                    Name = "RAM Для ноутбука DDR2 1Gb",
                    Price = 150m
                }, new Entities.Product
                {
                    Id = Guid.Parse("8ecfbdc3-f513-4540-9fb7-9775d4d1d887"),
                    Name = "Веб-камера Microsoft Web cam vx-800 ",
                    Price = 600m
                }, new Entities.Product
                {
                    Id = Guid.Parse("ad8bae68-a367-4442-8fbb-98c6a6b6e00d"),
                    Name = "Монітор 22” Acer V226HQL VGA DVI    1920 x 1080",
                    Price = 1600m
                }, new Entities.Product
                {
                    Id = Guid.Parse("fe4e89b7-27e6-4c36-b1fa-99b0c975d5f5"),
                    Name = "Монітор 22” LG W2253TQ VGA + DVI  1920 x 1080",
                    Price = 1500m
                }, new Entities.Product
                {
                    Id = Guid.Parse("c80586ea-a163-45e5-8575-9e68ae3101e8"),
                    Name = "Відеокарта 1Gb GeForce GT210 Asus DDR3 64bit ",
                    Price = 1500m
                }, new Entities.Product
                {
                    Id = Guid.Parse("9b49289f-a7b2-4425-ae32-a03578239fc5"),
                    Name = "Зарядний пристрій, кабель для смарт-годинників Amazfit GTS 2e/ Amazfit GTS 2 mini/ Amazfit GTR 2e",
                    Price = 300m
                }, new Entities.Product
                {
                    Id = Guid.Parse("fba42151-57d5-47ee-bd9c-a3e17e4a478b"),
                    Name = "Блок живлення Asus 45W 19V 2.37A 4.0x1.35 + силовий кабель",
                    Price = 550m
                }, new Entities.Product
                {
                    Id = Guid.Parse("0b18a7ff-f156-4051-8ac9-a488e7ea707b"),
                    Name = "Зарядний пристрій HOCO C12  2xUSB 2,4A",
                    Price = 270m
                }, new Entities.Product
                {
                    Id = Guid.Parse("34d79214-9bbb-4057-a306-a9020deb9100"),
                    Name = "RAM Для ноутбука DDR3  4Gb  в асортименті  ",
                    Price = 400m
                }, new Entities.Product
                {
                    Id = Guid.Parse("98e4a805-089a-4e93-bc98-abfef5a6d0da"),
                    Name = "Миша USB Havit HV-MS672 ігрова",
                    Price = 300m
                }, new Entities.Product
                {
                    Id = Guid.Parse("b9ed29bd-629a-4bc0-a39d-ac31e6506b36"),
                    Name = "RAM DDR4 4Gb  ",
                    Price = 550m
                }, new Entities.Product
                {
                    Id = Guid.Parse("e1815889-cef3-4823-99e2-acec4457a8b4"),
                    Name = "Клавиатура цифровая Genius GK-060022/U (бу)",
                    Price = 100m
                }, new Entities.Product
                {
                    Id = Guid.Parse("5e600af9-462e-486a-88f2-acf64e2205ec"),
                    Name = "Блок живлення 380W CoolerMaster кулер 8см",
                    Price = 300m
                }, new Entities.Product
                {
                    Id = Guid.Parse("fc184c40-21bf-495e-b425-b4a3c1243217"),
                    Name = "Адаптер переходник USB 3.0 To SATA  для жорсткого диска 2,5”",
                    Price = 250m
                }, new Entities.Product
                {
                    Id = Guid.Parse("2b13f4c9-8587-4c55-a754-b7c55d685acb"),
                    Name = "Блок живлення Asus 65W 19V 3.42A 4.0x1.35 + силовий кабель ",
                    Price = 550m
                }, new Entities.Product
                {
                    Id = Guid.Parse("0b87db13-88e2-4ec4-9bcc-c060b7c71761"),
                    Name = "Монітор 22” Asus VS228 VGA DVI 1920x1080 LED ",
                    Price = 1600m
                }, new Entities.Product
                {
                    Id = Guid.Parse("240f866e-e5ea-4c8c-89bf-c91adb0892e1"),
                    Name = "Блок живлення 360Вт Microlab ",
                    Price = 300m
                }, new Entities.Product
                {
                    Id = Guid.Parse("46f1df2e-774b-4f32-b18d-cac21ef47af3"),
                    Name = "RAM Для ноутбука DDR2 2Gb в асортименті",
                    Price = 250m
                }, new Entities.Product
                {
                    Id = Guid.Parse("5711e692-776b-438b-9cfc-d17614a26b28"),
                    Name = "Системний блок Pentium G5400  3,7Ghz  ( 2 ядра 4 потока) / S1151 Asrock H310CM-DVS / 8Gb DDR4 / SSD 120Gb / VGA+DVI/ 2xUSB3.0",
                    Price = 6000m
                }, new Entities.Product
                {
                    Id = Guid.Parse("f1d0f7d8-0d43-426d-86fc-d1a9465ab27b"),
                    Name = "RAM DDR3 8Gb  Kingston 1600Mhz",
                    Price = 800m
                }, new Entities.Product
                {
                    Id = Guid.Parse("3e922cf1-f068-4e1c-bc22-d2f9cb56086e"),
                    Name = "Миша бездротова SVEN RX-270W чорна",
                    Price = 400m
                }, new Entities.Product
                {
                    Id = Guid.Parse("97918223-b624-43b7-a6ec-d56fbec9c576"),
                    Name = "RAM Для ноутбука DDR3L  4Gb  в асортименті  ",
                    Price = 400m
                }, new Entities.Product
                {
                    Id = Guid.Parse("dfde8028-359c-445f-9c38-d5b0640614d1"),
                    Name = "SSD mSATA 128Gb",
                    Price = 650m
                }, new Entities.Product
                {
                    Id = Guid.Parse("24be3976-dd68-4f3f-bf5c-d667ab9ba258"),
                    Name = "Зарядний пристрій BORASCO для Xiaomi Mi Band 5",
                    Price = 200m
                }, new Entities.Product
                {
                    Id = Guid.Parse("45ed5008-1fe5-49d0-8f74-d66a05193a2f"),
                    Name = "Блок живлення 330Вт SVEN",
                    Price = 200m
                }, new Entities.Product
                {
                    Id = Guid.Parse("320ef1f2-be7d-41b0-8f05-d6ba4cc04e6f"),
                    Name = "Клавіатура USB Gembird MCH-04-UA",
                    Price = 280m
                }, new Entities.Product
                {
                    Id = Guid.Parse("b16720bf-350f-43ae-8295-d75c25d8620b"),
                    Name = "SSD 120Gb Smartbuy ",
                    Price = 600m
                }, new Entities.Product
                {
                    Id = Guid.Parse("4b541626-f61d-484b-86ff-d93c095c01f8"),
                    Name = "Монітор 20” Asus VH203    VGA   1600x900",
                    Price = 1200m
                }, new Entities.Product
                {
                    Id = Guid.Parse("c1423ea9-9995-42d4-ae24-e000b8cec72a"),
                    Name = "Відеокарта 2Gb GeForce GT710 Palit DDR3 64bit ",
                    Price = 2400m
                }, new Entities.Product
                {
                    Id = Guid.Parse("d996252c-2089-442c-9061-e08026366919"),
                    Name = "HDD SATA 500Gb ",
                    Price = 400m
                }, new Entities.Product
                {
                    Id = Guid.Parse("089b024c-b9b4-4bd7-b613-e124ac43204b"),
                    Name = "RAM Для ноутбука DDR4  2Gb  2400",
                    Price = 150m
                }, new Entities.Product
                {
                    Id = Guid.Parse("92b3ea18-61fc-4e13-9312-e7a89f89a209"),
                    Name = "Відеокарта AMD Radeon HD 8490 1gb PCI-Ex DDR3 64bit (DVI + DP)",
                    Price = 750m
                }, new Entities.Product
                {
                    Id = Guid.Parse("34c4df70-437d-47fe-a1f6-eb6b44b16204"),
                    Name = "RAM Для ноутбука DDR3  2Gb в асортименті  ",
                    Price = 200m
                }, new Entities.Product
                {
                    Id = Guid.Parse("d2ea8a67-3476-473a-b219-ec792c4c3138"),
                    Name = "Блок живлення 400Вт Griffon CPU 4pin + GPU 6pin",
                    Price = 400m
                }, new Entities.Product
                {
                    Id = Guid.Parse("6464cc39-a825-4a72-b799-f00085fa9d90"),
                    Name = "Блок живлення БП 5В 0,6А ",
                    Price = 90m
                }, new Entities.Product
                {
                    Id = Guid.Parse("5965201d-077c-458b-81af-f2fa71bbbd2e"),
                    Name = "Блок живлення 450Вт Delux",
                    Price = 400m
                }, new Entities.Product
                {
                    Id = Guid.Parse("5fd77645-66f7-4d04-9b0a-f54fd8dcabd3"),
                    Name = "Кабель microUSB бу",
                    Price = 40m
                }, new Entities.Product
                {
                    Id = Guid.Parse("969154ec-206a-4e39-80f6-fb3bd5b7aefa"),
                    Name = "Миша USB KAPPA Speedlink",
                    Price = 250m
                }, new Entities.Product
                {
                    Id = Guid.Parse("2ce21d4d-cc04-4a6f-ae0c-ff96f454d1c2"),
                    Name = "БЖ 5В 1А  б/в",
                    Price = 50m
                },
                // Добавленные 5 товарів
                new Entities.Product
                {
                    Id = Guid.Parse("aa111111-1111-4111-8111-0000000000a1"),
                    Name = "Кабель USB-C 1.5м Hoppe",
                    Price = 120m
                }, new Entities.Product
                {
                    Id = Guid.Parse("aa222222-2222-4222-8222-0000000000a2"),
                    Name = "SSD 256Gb Kingston A400",
                    Price = 900m
                }, new Entities.Product
                {
                    Id = Guid.Parse("aa333333-3333-4333-8333-0000000000a3"),
                    Name = "HDD SATA 2Tb Western Digital",
                    Price = 2200m
                }, new Entities.Product
                {
                    Id = Guid.Parse("aa444444-4444-4444-8444-0000000000a4"),
                    Name = "Миша оптична Logitech M90",
                    Price = 180m
                }, new Entities.Product
                {
                    Id = Guid.Parse("aa555555-5555-4555-8555-0000000000a5"),
                    Name = "Блок живлення 12V 5A MeanWell",
                    Price = 650m
                });
        }


        private void SeedFirms(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Entities.Firm>().HasData(
                new Entities.Firm
                {
                    Id = Guid.Parse("48f0708a-11d4-4648-9ac7-12a1fff5e1e7"),
                    Name = "ФОП Торговенко"
                },
                new Entities.Firm
                {
                    Id = Guid.Parse("931dfb69-edfa-4fe8-8c7d-1edd00d22498"),
                    Name = "EcoResale JSC"
                },
                new Entities.Firm
                {
                    Id = Guid.Parse("4e96d0a1-2ba9-411a-afd7-27bceb862c93"),
                    Name = "Everyday Essentials LLC"
                },
                new Entities.Firm
                {
                    Id = Guid.Parse("8cef13dc-8ccd-4ef9-ac39-3b1f4860a2e5"),
                    Name = "Prime Goods LLC"
                },
                new Entities.Firm
                {
                    Id = Guid.Parse("50caad3a-5055-4b94-90ce-72886cc9d5b0"),
                    Name = "ТОВ Скарбниця"
                },
                new Entities.Firm
                {
                    Id = Guid.Parse("1ea7d698-924b-47df-b574-88f4f71306e6"),
                    Name = "АТ Крамниця"
                },
                new Entities.Firm
                {
                    Id = Guid.Parse("fb1286a8-2d7f-436b-bee1-8fadaaaf104b"),
                    Name = "ПАТ Ваша Знижка"
                },
                new Entities.Firm
                {
                    Id = Guid.Parse("3d4e5f82-4d89-4620-8023-9e90473b8c2d"),
                    Name = "АТ Маркетолог"
                },
                new Entities.Firm
                {
                    Id = Guid.Parse("6d2a6a6a-488e-488b-8d2f-c77f1b3416a3"),
                    Name = "Smart Store LLC"
                },
                new Entities.Firm
                {
                    Id = Guid.Parse("c6d1ee0e-cb5b-4b13-96a9-f87714a27c2a"),
                    Name = "MultiUse Market JSC"
                },
                // new firms
                new Entities.Firm
                {
                    Id = Guid.Parse("d1b2c3d4-e5f6-4711-9a2b-0000000000a1"),
                    Name = "Novus Supplies LLC"
                },
                new Entities.Firm
                {
                    Id = Guid.Parse("e2c3d4e5-f6a7-4822-8b3c-0000000000b2"),
                    Name = "Sunrise Components Ltd"
                });
        }

    }
}
