public interface IAudioService
{
    void PlaySound(string soundName);
}

public class AudioService : IAudioService
{
    public void PlaySound(string soundName)
    {
        Debug.Log($"Ses oynatılıyor: {soundName}");
    }
}

public interface IPlayerDataService
{
    int GetCoins();
}

public class PlayerDataService : IPlayerDataService
{
    private int coins = 100;
    public int GetCoins() => coins;
}
