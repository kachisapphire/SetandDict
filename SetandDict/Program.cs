Console.WriteLine("Set Operators");
string[] one = { "My", "father", "is", "a","working", "man" };
string[] two = { "Joshua's", "father", "is", "also", "a", "man" };

var distinctone = one.Distinct();
foreach (var result in distinctone)
    Console.WriteLine(result);
Console.WriteLine("**************");
var distincttwo = two.Distinct();
foreach (var result2 in distincttwo)
    Console.WriteLine(result2);
Console.WriteLine("************************");
//except
var resultexcept = one.Except(two);
foreach (var result3 in resultexcept)
    Console.WriteLine(result3);
Console.WriteLine("*************************");
//intersect
var resultintersect = one.Intersect(two);
foreach (var result4 in resultintersect)
    Console.WriteLine(result4);
Console.WriteLine("***********");
//union
var resultunion = one.Union(two);
foreach (var result5 in resultunion)
    Console.WriteLine(result5);
Console.WriteLine("****** Dictionary ******");
Dictionary<string, string> thisdictionary = new Dictionary<string, string>();
thisdictionary.Add("gravity:", "seriousness, force that attracts to the earth");
thisdictionary.Add("gravy;", "juice from cooked meat");
thisdictionary.Add("graze:", "feed on grpwing grass");
thisdictionary.Add("grease:", "fatty or oily matter");
thisdictionary.Add("greasepaint:", "makeup used by actors");
thisdictionary.Add("great:", "much above average");
thisdictionary.Add("greatly:", "very much");
thisdictionary.Add("grebe:", "a diving bird");
thisdictionary.Add("greed:", "excessive desire");
thisdictionary.Add("green:", "a color between yellow and blue");
foreach (var item in thisdictionary)
    Console.WriteLine(item.Key + "\t" + item.Value);
Console.ReadKey();
