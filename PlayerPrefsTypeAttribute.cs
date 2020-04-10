using Il2CppDummyDll;
using System;

[Attribute(Name="AttributeUsageAttribute", RVA="0x1048A68", Offset="0x1048A68")]
public class PlayerPrefsTypeAttribute : Attribute
{
	[FieldOffset(Offset="0x10")]
	private PlayerPrefsType _prefType;

	public PlayerPrefsType PrefType
	{
		[Address(RVA="0x133E68C", Offset="0x133E68C", VA="0x133E68C")]
		get
		{
			return new PlayerPrefsType();
		}
	}

	[Address(RVA="0x133E694", Offset="0x133E694", VA="0x133E694")]
	public PlayerPrefsTypeAttribute(PlayerPrefsType prefType)
	{
	}
}