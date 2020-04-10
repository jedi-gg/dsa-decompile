using Il2CppDummyDll;
using System;
using Zenject;

public class ProjectInstaller : MonoInstaller<ProjectInstaller>
{
	[Address(RVA="0x127F0F0", Offset="0x127F0F0", VA="0x127F0F0")]
	public ProjectInstaller()
	{
	}

	[Address(RVA="0x127EA40", Offset="0x127EA40", VA="0x127EA40", Slot="8")]
	public override void InstallBindings()
	{
	}
}