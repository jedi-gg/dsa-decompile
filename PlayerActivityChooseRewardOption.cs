using Glunies;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

public class PlayerActivityChooseRewardOption : MonoBehaviour, ILoggable<LogCategory>
{
	[FieldOffset(Offset="0x18")]
	[SerializeField]
	private List<ViewSerializedFields.AutoLocalizedLabel> _autoLocalizedFields;

	public LogCategory LogCategory
	{
		[Address(RVA="0x132BE14", Offset="0x132BE14", VA="0x132BE14", Slot="4")]
		get
		{
			return new LogCategory();
		}
	}

	[Address(RVA="0x132C0F4", Offset="0x132C0F4", VA="0x132C0F4")]
	public PlayerActivityChooseRewardOption()
	{
	}

	[Address(RVA="0x132BE1C", Offset="0x132BE1C", VA="0x132BE1C")]
	public void Initialize(WidgetDependencyContainer dependencies)
	{
	}
}