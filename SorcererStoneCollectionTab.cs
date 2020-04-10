using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.UI;

public class SorcererStoneCollectionTab : MonoBehaviour
{
	[FieldOffset(Offset="0x18")]
	[SerializeField]
	private Button _button;

	[FieldOffset(Offset="0x20")]
	[SerializeField]
	private RawImage _icon;

	[FieldOffset(Offset="0x28")]
	[SerializeField]
	private GameObject _selectedIndicator;

	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private Transform _selectionContainer;

	[FieldOffset(Offset="0x38")]
	[SerializeField]
	private float _selectedScale;

	[FieldOffset(Offset="0x3C")]
	[SerializeField]
	private Vector3 _selectedOffset;

	[FieldOffset(Offset="0x48")]
	[SerializeField]
	private UiLabel _countLabel;

	[Address(RVA="0x123711C", Offset="0x123711C", VA="0x123711C")]
	public SorcererStoneCollectionTab()
	{
	}

	[Address(RVA="0x1236C28", Offset="0x1236C28", VA="0x1236C28")]
	public void Initialize(WidgetDependencyContainer dependencies, int index)
	{
	}

	[Address(RVA="0x1236FA0", Offset="0x1236FA0", VA="0x1236FA0")]
	public void SetIcon(Texture texture)
	{
	}

	[Address(RVA="0x123701C", Offset="0x123701C", VA="0x123701C")]
	public void SetOwnedCount(long count)
	{
	}

	[Address(RVA="0x1236D70", Offset="0x1236D70", VA="0x1236D70")]
	public void SetSelected(bool selected)
	{
	}

	[Address(RVA="0x1236F58", Offset="0x1236F58", VA="0x1236F58")]
	public void Shutdown()
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104C9DC", Offset="0x104C9DC")]
	private sealed class <>c__DisplayClass0_0
	{
		[FieldOffset(Offset="0x10")]
		public WidgetDependencyContainer dependencies;

		[FieldOffset(Offset="0x18")]
		public int index;

		[Address(RVA="0x1236D68", Offset="0x1236D68", VA="0x1236D68")]
		public <>c__DisplayClass0_0()
		{
		}

		[Address(RVA="0x123712C", Offset="0x123712C", VA="0x123712C")]
		internal void <Initialize>b__0()
		{
		}
	}
}