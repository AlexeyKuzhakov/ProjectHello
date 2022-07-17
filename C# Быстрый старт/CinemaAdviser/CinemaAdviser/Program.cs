Console.WriteLine("Здравствуйте, дорогой друг. Эта программа поможет подобрать вам фильм для вечерненго просмотра");
Console.WriteLine("Как вас зовут?");
String name = Console.ReadLine();
Console.WriteLine("Здравствуйте, " + name);

Console.WriteLine("Фильм какого жанра вы бы хотели посмотреть: комедия, драма, фантастика, триллер, боевик");
String genre = Console.ReadLine();

Console.WriteLine("В таком случае, рекомендую посмотреть вам следующие фильмы: ");

if (genre == "комедия")
{
    Console.WriteLine("* Иван Васильевич меняет профессию");
    Console.WriteLine("* Операция Ы и другие приключения Шурика");
}
else if (genre == "фантастика")
{
    Console.WriteLine("* Люди икс");
    Console.WriteLine("* Черепашки ниндзя");
}
else if (genre == "триллер")
{
    Console.WriteLine("* Время");
    Console.WriteLine("* В западне");
}
else if (genre == "боевик")
{
    Console.WriteLine("* Гнев человеческий");
    Console.WriteLine("* Бесконечность");
}
else
{
    Console.WriteLine("* Зеленая миля");
    Console.WriteLine("* Побег из Шоушенка");
}

Console.ReadLine();
