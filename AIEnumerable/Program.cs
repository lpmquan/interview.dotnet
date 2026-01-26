var source = GetSource();
var page = GetPage(source, 1, 10);

static IEnumerable<int> GetPage(
    IEnumerable<int> source,
    int page,
    int pageSize)
{
    var total = source.Count();

    return source
        .Skip((page - 1) * pageSize)
        .Take(pageSize);
}

static IEnumerable<int> GetSource()
{
    Console.WriteLine(1);
    yield return 1;

    Console.WriteLine(2);
    yield return 2;

    Console.WriteLine(3);
    yield return 3;
}

// Question:
// Any performance issues? What happens to the streaming source?
