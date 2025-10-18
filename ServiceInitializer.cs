using UnityEngine;

public class ServiceInitializer : MonoBehaviour
{
    private void Awake()
    {
        ServiceLocator.Register<IAudioService>(new AudioService());
        ServiceLocator.Register<IPlayerDataService>(new PlayerDataService());
    }

    private void OnDestroy()
    {
        ServiceLocator.Clear();
    }
}
