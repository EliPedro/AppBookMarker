
//using BookMarker.Core.Domain.Handles;
//using SimpleInjector;

//namespace BookMarker.Infra.loC.loC
//{
//    public class Bootstrap
//    {
//        private static Container container;

//        public static void Start()
//        {
//            container = new Container();

//            container.RegisterCollection(typeof(IHandler<>), typeof(IHandler<>).Assembly);
//            container.Verify();
//        }

//        public static Container GetContainer()
//        {
//            return container;
//        }
//    }
//}
