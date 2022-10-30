using CreationalLibrary;


#region Singleton
// SingletonBall singletonBall = new SingletonBall(); // => SingletonBall classında private ctor sayesinde dışarıdan erişim engellenmiştir.

//SingletonBall singletonBall = SingletonBall.GetInstance();
//SingletonBall singletonBall2 = SingletonBall.GetInstance();

//Console.WriteLine(singletonBall.Name);
//Console.WriteLine(singletonBall2.Name);
//Console.WriteLine(singletonBall.Equals(singletonBall2)? "Aynı top" : "Farklı top");
//Console.ReadLine();
#endregion

#region Factory
/// Birbirleriyle ilişkili nesneleri oluşturmak için bir arayüz sağlar ve alt sınıfların hangi sınıfın örneğini oluşturacağına olanak tanır.
/// Buradaki amaç istemci tarafından birbirleriyle ilişkili nesnelerin oluşturulma anını soyutlamak, istemci hangi sınıf örneğini alabileceğini 
/// bilebilir ama oluşturulma detaylarını bilemez. Nesnenin nasıl oluşturulacağı soyutlanır.

//Admin admin = new Admin(); // bildirim göndereceğimiz nesnemiz
//admin.Email = "mustafasuheylkilic@gmail.com";
//admin.GSM = "555 555 55 55";
//NotifyFactory notifyFactory = new NotifyFactory(); // bildirim türlerini üretecek class
//INotify notify = notifyFactory.CreateNotify(NotifyType.Email); // enum yoluyla hangi türde bildirimin üretileceğini bu aşamada bildiriyoruz.
//Console.WriteLine(notify.SendNotification(admin)); // bildirimin gönderildiği fonksiyon burada tetiklenmiş ve sonuç dönmüş oluyor.
//Console.ReadLine();
#endregion

#region AbstractFactory
//DatabaseOperation databaseOperation = new DatabaseOperation(new OracleDatabaseFactory());
//databaseOperation.RemoveById(1);
#endregion

#region Builder
HouseBuilder houseBuilder = new BasicHouseBuilder();
HouseDirector houseDirector = new HouseDirector(houseBuilder);
houseDirector.Build();

House house = houseBuilder.GetResult();

Console.WriteLine($"Your house name is {house.Name} and \n window count : {house.WindowCount}");
Console.Read();

#endregion