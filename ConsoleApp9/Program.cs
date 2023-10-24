//using ConsoleApp9;

//string[] transportType = new string[] { "air", "sea", "land" };

//List<Transport> transports = new List<Transport>
//{
//    new Transport(){TransportType = "land", TransportName = "Train"},
//    new Transport(){TransportType = "land", TransportName = "Car"},
//    new Transport(){TransportType = "land", TransportName = "Bus"},
//    new Transport(){TransportType = "land", TransportName = "Metro"},
//    new Transport(){TransportType = "sea", TransportName = "Boat"},
//    new Transport(){TransportType = "sea", TransportName = "Cargo Ship"},
//    new Transport(){TransportType = "air", TransportName = "Helicopter"},
//    new Transport(){TransportType = "air", TransportName = "Boeing"},
//};


//var groupJoin = from tt in transportType
//                join tr in transports
//                on tt equals tr.TransportType
//                into transportGroup
//                select new
//                {
//                    type = tt,
//                    transports = transportGroup
//                };

//foreach(var item in groupJoin)
//{
//    Console.WriteLine(item.type);
//    foreach(var i in item.transports)
//    {
//        Console.WriteLine($"\t {i.TransportName}");
//    }
//}


//int[] nums = { 1, -2, 3, 0, 4 ,5 };

//var query = nums.Where(i=> i > 0).ToList();

//query.ForEach(query => Console.WriteLine(query));