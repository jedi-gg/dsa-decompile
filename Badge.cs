using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[Attribute(Name="RequireComponent", RVA="0x10484D8", Offset="0x10484D8")]
public class Badge : MonoBehaviour
{
	[FieldOffset(Offset="0x0")]
	public const int INVALID_CONTEXT_INDEX = -1;

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10528C4", Offset="0x10528C4")]
	[FieldOffset(Offset="0x18")]
	private Action<Badge> ContextChanged;

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10528D4", Offset="0x10528D4")]
	[FieldOffset(Offset="0x20")]
	private ulong <ContextContentId>k__BackingField;

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10528E4", Offset="0x10528E4")]
	[FieldOffset(Offset="0x28")]
	private int <ContextIndex>k__BackingField;

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10528F4", Offset="0x10528F4")]
	[FieldOffset(Offset="0x30")]
	private object <ContextObject>k__BackingField;

	[FieldOffset(Offset="0x38")]
	private Image _image;

	[FieldOffset(Offset="0x40")]
	private int _count;

	[Attribute(Name="EnumFlagAttribute", RVA="0x1052904", Offset="0x1052904")]
	[FieldOffset(Offset="0x44")]
	[SerializeField]
	private BadgingSource _source;

	[FieldOffset(Offset="0x48")]
	[SerializeField]
	private List<Sprite> _badgeSprites;

	public ulong ContextContentId
	{
		[Address(RVA="0x1160A54", Offset="0x1160A54", VA="0x1160A54")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106E088", Offset="0x106E088")]
		get
		{
			return new ulong();
		}
		[Address(RVA="0x1160A5C", Offset="0x1160A5C", VA="0x1160A5C")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106E098", Offset="0x106E098")]
		private set
		{
		}
	}

	public int ContextIndex
	{
		[Address(RVA="0x1160A64", Offset="0x1160A64", VA="0x1160A64")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106E0A8", Offset="0x106E0A8")]
		get
		{
			return new int();
		}
		[Address(RVA="0x1160A6C", Offset="0x1160A6C", VA="0x1160A6C")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106E0B8", Offset="0x106E0B8")]
		private set
		{
		}
	}

	public object ContextObject
	{
		[Address(RVA="0x1160A74", Offset="0x1160A74", VA="0x1160A74")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106E0C8", Offset="0x106E0C8")]
		get
		{
			return null;
		}
		[Address(RVA="0x1160A7C", Offset="0x1160A7C", VA="0x1160A7C")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106E0D8", Offset="0x106E0D8")]
		private set
		{
		}
	}

	public BadgingSource Source
	{
		[Address(RVA="0x1160A4C", Offset="0x1160A4C", VA="0x1160A4C")]
		get
		{
			return new BadgingSource();
		}
	}

	[Address(RVA="0x1160E10", Offset="0x1160E10", VA="0x1160E10")]
	public Badge()
	{
	}

	[Address(RVA="0x1160D78", Offset="0x1160D78", VA="0x1160D78")]
	private Image GetImage()
	{
		return null;
	}

	[Address(RVA="0x1160D64", Offset="0x1160D64", VA="0x1160D64")]
	private void OnDestroy()
	{
	}

	[Address(RVA="0x1160D60", Offset="0x1160D60", VA="0x1160D60")]
	private void OnEnable()
	{
	}

	[Address(RVA="0x1160C44", Offset="0x1160C44", VA="0x1160C44")]
	private void ResetContext()
	{
	}

	[Address(RVA="0x1160BC0", Offset="0x1160BC0", VA="0x1160BC0")]
	public void SetContext(ulong contentId, int index)
	{
	}

	[Address(RVA="0x1160C58", Offset="0x1160C58", VA="0x1160C58")]
	public void SetContextContentId(ulong contentId)
	{
	}

	[Address(RVA="0x1160CDC", Offset="0x1160CDC", VA="0x1160CDC")]
	public void SetContextObject(object contextObject)
	{
	}

	[Address(RVA="0x1160A84", Offset="0x1160A84", VA="0x1160A84")]
	public void SetCount(int count)
	{
	}

	[Address(RVA="0x1160A90", Offset="0x1160A90", VA="0x1160A90")]
	private void UpdateImage()
	{
	}

	public event Action<Badge> ContextChanged
	{
		[Address(RVA="0x1160874", Offset="0x1160874", VA="0x1160874")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106E068", Offset="0x106E068")]
		add
		{
		}
		[Address(RVA="0x1160960", Offset="0x1160960", VA="0x1160960")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106E078", Offset="0x106E078")]
		remove
		{
		}
	}
}