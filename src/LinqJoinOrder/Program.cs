using LinqJoinOrder.Models;

var tableA = new List<TableA> {
    new TableA(1, "errasd"),
    new TableA(2, "adfvxb"),
    new TableA(3, "dfvbcxb"),
    new TableA(4, "xcvcxzv"),
    new TableA(5, "cxv"),
    new TableA(6, "zxcvdfg"),
    new TableA(7, "fdgfdg"),
    new TableA(8, "sdffdsfg"),
};

var tableB = new List<TableB> {
    new TableB(1, 2),
    new TableB(2, 3),
    new TableB(3, 2),
    new TableB(4, 2),
    new TableB(5, 3),
    new TableB(6, 1),
    new TableB(7, 1),
    new TableB(8, 1),
};

var data = from a in tableA
           join b in tableB on a.Id equals b.Id
           orderby b.Type, a.Id
           select a;

data.ToList().ForEach(x =>
{
    Console.WriteLine($"Id: {x.Id}, Ref: {x.Ref}");
});

Console.WriteLine("Hello, World!");
