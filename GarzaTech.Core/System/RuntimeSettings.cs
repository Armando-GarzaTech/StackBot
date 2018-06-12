namespace GarzaTech.Core.System
{

    public interface IRuntimeSettings
    {
        string LuisApi { get; }
        string StackApi { get; }
        string GitApi { get; }
        string DataFileName { get; }
    }

    public class RuntimeSettings: IRuntimeSettings
    {
        public string LuisApi { get; set; }
        public string StackApi { get; set; }
        public string GitApi { get; set; }
        public string DataFileName { get; set; }

        public static IRuntimeSettings Instance
        {
            get;
            private set;
        }

        public static void SetInstance(IRuntimeSettings settings)
        {
            Instance = settings;
        }

    }
}
