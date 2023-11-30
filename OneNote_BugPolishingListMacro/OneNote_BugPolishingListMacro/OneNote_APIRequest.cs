using GraphBasics;
using Microsoft.Graph;

string tenantId = "1a27bdbf-e6cc-4e33-85d2-e1c81bad930a";
string clientId = "64ba9a2a-8be4-4a9b-9c21-66681bbac01d";
string clientSecret = "WNS8Q~FJcnWAKc8FAvGtoAAagct.4OIi.x.bza0z";


var graphHandler = new GraphHandler(tenantId, clientId, clientSecret);

Console.WriteLine("Get display name");
var notebook = await graphHandler.GetNotebook("outofthepark@bluehole.net");
Console.WriteLine(notebook);
