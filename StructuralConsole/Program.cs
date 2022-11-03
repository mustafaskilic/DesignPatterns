using StructuralLibrary;
#region Adapter
CustomJsonAdapter customJsonAdapter = new CustomJsonAdapter();
JSonOperation jSonOperation = new JSonOperation(customJsonAdapter);
object obj = new object();
obj = "Json olacak veri";

Console.WriteLine(jSonOperation.Serialize(obj));
Console.ReadLine();
#endregion