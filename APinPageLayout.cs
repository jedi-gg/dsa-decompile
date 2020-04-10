using Glunies;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

public abstract class APinPageLayout : MonoBehaviour
{
	[Address(RVA="0x10ED444", Offset="0x10ED444", VA="0x10ED444")]
	protected APinPageLayout()
	{
	}

	public abstract void Initialize(WidgetDependencyContainer dependencies, PinPageItemComponent pinPageItemArchetype);

	public abstract void MarkAsNoLongerCurrentPage();

	public abstract void SetData(List<PinPageItemData> pinData);

	public abstract void Shutdown();
}