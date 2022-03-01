namespace milad.Framework.Core.DependencyInjection
{
    public class ServiceLocator
    {
        public static IDiContainer Current { get; private set; } 

        public static void Initial(IDiContainer container)
        {
            if(Current == null)
            {
                Current = container;
            }
        }
    }
}
