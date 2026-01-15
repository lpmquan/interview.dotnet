static IEnumerable<T> GetPage<T>(
    IEnumerable<T> source,
    int page,
    int pageSize)
{
    var total = source.Count();

    return source
        .Skip((page - 1) * pageSize)
        .Take(pageSize);
}

// Question:
// Any performance issues? What happens to the streaming source?
