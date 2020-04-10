using Il2CppDummyDll;
using System;

public struct DLoadedSocialFeatureAction
{
	[FieldOffset(Offset="0x0")]
	public readonly SocialGameState.Tab Tab;

	[FieldOffset(Offset="0x4")]
	public readonly SocialGameState.Feature Feature;

	[Address(RVA="0xEFE378", Offset="0xEFE378", VA="0xEFE378")]
	public DLoadedSocialFeatureAction(SocialGameState.Tab tab, SocialGameState.Feature feature)
	{
	}
}