using Glunies;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

public class UiCarousel : MonoBehaviour, IDispatchHandler<DUiCarouselPipAction>, IDispatchHandler
{
	[FieldOffset(Offset="0x18")]
	private WidgetDependencyContainer _dependencies;

	[FieldOffset(Offset="0x20")]
	private DispatchSystem _dispatchSystem;

	[FieldOffset(Offset="0x28")]
	private List<UiCarouselPip> _carouselPipPool;

	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private UiCarouselPip _carouselPipArchetype;

	[FieldOffset(Offset="0x38")]
	[SerializeField]
	private Transform _carouselParentOverride;

	[Address(RVA="0x15850B8", Offset="0x15850B8", VA="0x15850B8")]
	public UiCarousel()
	{
	}

	[Address(RVA="0x1584EC0", Offset="0x1584EC0", VA="0x1584EC0", Slot="4")]
	public void HandleDispatchAction(DUiCarouselPipAction action)
	{
	}

	[Address(RVA="0x15848BC", Offset="0x15848BC", VA="0x15848BC")]
	public void Initialize(WidgetDependencyContainer dependencies)
	{
	}

	[Address(RVA="0x1584AE0", Offset="0x1584AE0", VA="0x1584AE0")]
	public void SetCount(int count)
	{
	}

	[Address(RVA="0x1584DB8", Offset="0x1584DB8", VA="0x1584DB8")]
	public void SetSelectedIndex(int index)
	{
	}

	[Address(RVA="0x1584944", Offset="0x1584944", VA="0x1584944")]
	public void Shutdown()
	{
	}

	[Address(RVA="0x1584C04", Offset="0x1584C04", VA="0x1584C04")]
	private void SpawnNewCarouselPip()
	{
	}
}