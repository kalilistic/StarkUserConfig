namespace StarkUserConfig
{
    public interface IConfigManager
    {
        void SaveSettings();
        void LoadSettings();
        void DeInit();
    }
}