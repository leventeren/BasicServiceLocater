using UnityEngine;

public class GameController : MonoBehaviour
{
    private void Start()
    {
        var audio = ServiceLocator.Get<IAudioService>();
        var playerData = ServiceLocator.Get<IPlayerDataService>();

        Debug.Log($"Player Coin: {playerData.GetCoins()}");
        audio.PlaySound("level_start");
    }
}
