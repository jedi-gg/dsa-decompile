using Il2CppDummyDll;
using System;
using UnityEngine;

[Serializable]
public class HelpshiftConfig : ScriptableObject
{
	[FieldOffset(Offset="0x0")]
	private static HelpshiftConfig instance;

	[FieldOffset(Offset="0x0")]
	private const string helpshiftConfigAssetName = "HelpshiftConfig";

	[FieldOffset(Offset="0x0")]
	private const string helpshiftConfigPath = "Helpshift/Resources";

	[FieldOffset(Offset="0x0")]
	public const string pluginVersion = "5.1.0";

	public static HelpshiftConfig Instance
	{
		[Address(RVA="0x12E6B8C", Offset="0x12E6B8C", VA="0x12E6B8C")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x12E6C8C", Offset="0x12E6C8C", VA="0x12E6C8C")]
	public HelpshiftConfig()
	{
	}
}