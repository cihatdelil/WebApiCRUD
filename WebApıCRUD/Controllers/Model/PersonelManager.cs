namespace WebApıCRUD.Controllers.Model
{
    public class PersonelManager
    {
        public static List<Personel> personels { get; set; }
        static PersonelManager()
        {
            personels = new List<Personel>()
            {
                new Personel(){Id=1,Name="Hüseyin",Title="CTO"},
                new Personel(){Id=2,Name="Y-İsmail",Title="Developer"},
                new Personel(){Id=3,Name="K-İsmail",Title="Software"},
                new Personel(){Id=4,Name="Ziya",Title="Kasap"},
                new Personel(){Id=5,Name="Şafak",Title="CEO"},
                new Personel(){Id=6,Name="Cihat",Title="Mühendis"},
            };
        }
    }
}
