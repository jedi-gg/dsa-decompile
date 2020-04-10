using Il2CppDummyDll;
using System;
using Zenject;

public class GameInstaller : MonoInstaller<GameInstaller>
{
	[Address(RVA="0x15EC1E4", Offset="0x15EC1E4", VA="0x15EC1E4")]
	public GameInstaller()
	{
	}

	[Address(RVA="0x15EA578", Offset="0x15EA578", VA="0x15EA578", Slot="8")]
	public override void InstallBindings()
	{
	}
}