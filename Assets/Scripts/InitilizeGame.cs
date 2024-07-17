using UnityEngine;
using Zenject;

public class InitilizeGame : MonoInstaller
{
    public override void InstallBindings()
    {
        Debug.Log("Initialized");
        
        Container.Bind<StartMenuMV>().AsSingle();
    }
}