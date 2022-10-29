namespace CreationalLibrary
{
    // Bir futbol müsabakasında yalnızca bir top bulunmaktadır.
    // Eğer o anda top, taca çıktıysa veya saha dışına gittiyse yeni bir top veya
    // yakındaysa aynı top sahada oynanmaya devam etmektedir.
    // Bu sebeple singleton örneğini verirken
    // futbol topu üzerinden bir örnek tercih ettim.

    public class SingletonBall
    {

        private static SingletonBall? _instance; // static private tanımlayarak nesnemizi, bu classın içerisinde oluşturup dışarıya sunuyoruz.
        private SingletonBall() { } // dışarıdan bu class'ın instance' inin alınmamasını private ctor ile sağlamış oluyoruz. (futbolcuların topu kendilerinin almaması gibi)

        public string Name { get; set; } = "Nike Pro Ball";

        public static SingletonBall GetInstance() // bu fonksiyon sayesinde field'da tanımlanan nesnenin tekil olarak oluşturulması sağlanıyor. (sahanın kenarında bekleyen ve topları futbolculara ileten görevli(ler))
        {
            if( _instance == null ) _instance = new SingletonBall();
            return _instance;
        }
    }
}