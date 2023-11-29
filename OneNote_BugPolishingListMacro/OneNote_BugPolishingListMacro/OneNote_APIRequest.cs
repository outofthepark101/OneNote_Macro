using GraphBasics;
using Microsoft.Graph;

string tenantId = "fc6c25a4-0c67-4283-b2c8-edf42f343d5c";
string clientId = "1602dabe-7df3-48f1-8a23-9dbb6445742f";
string clientSecret = "n~18Q~kKKKtsiZr8~PXR3HPJgFduspAUFB13.bfr";

var notebookId = "마이리틀퍼피";
var sectionId = "박병성";
var pageId = "마일스톤#26";


var graphHandler = new GraphHandler(tenantId, clientId, clientSecret);

Console.WriteLine("Get display name of user");
var user = await graphHandler.GetUser("outofthepark101_gmail.com#EXT#@outofthepark101gmail.onmicrosoft.com");
Console.WriteLine(user?.DisplayName);


Console.WriteLine("Get page name");
var notePage = await graphHandler.GraphClient.Me.Onenote.Notebooks[notebookId].Sections[sectionId].Pages[pageId].GetAsync();
Console.WriteLine(notePage?.Title);
