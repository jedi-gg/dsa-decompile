using DG.Tweening;
using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;
using UnityEngine;
using UnityEngine.UI;

public class SquadSelectSpellSlot : MonoBehaviour
{
	[FieldOffset(Offset="0x0")]
	private const float ENABLED_ALPHA = 1f;

	[FieldOffset(Offset="0x0")]
	private const float DISABLED_ALPHA = 0.35f;

	[FieldOffset(Offset="0x18")]
	private Spell _spell;

	[FieldOffset(Offset="0x20")]
	private Tweener _addIconTween;

	[FieldOffset(Offset="0x28")]
	private bool _enabled;

	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private SpellListItem _spellListItem;

	[FieldOffset(Offset="0x38")]
	[SerializeField]
	private CanvasGroup _canvasGroup;

	[FieldOffset(Offset="0x40")]
	[SerializeField]
	private UnityEngine.UI.Button _button;

	[FieldOffset(Offset="0x48")]
	[SerializeField]
	private UnityEngine.UI.Button _infoButton;

	[FieldOffset(Offset="0x50")]
	[SerializeField]
	private PressEventHandler _slotPressHandler;

	[Attribute(Name="HeaderAttribute", RVA="0x105CA10", Offset="0x105CA10")]
	[FieldOffset(Offset="0x58")]
	[SerializeField]
	private GameObject _addIconParent;

	[FieldOffset(Offset="0x60")]
	[SerializeField]
	private GameObject _addIcon;

	[FieldOffset(Offset="0x68")]
	[SerializeField]
	private float _addIconTweenScale;

	[FieldOffset(Offset="0x6C")]
	[SerializeField]
	private float _addIconTweenDuration;

	[FieldOffset(Offset="0x70")]
	[SerializeField]
	private Ease _addIconTweenEase;

	public UnityEngine.UI.Button Button
	{
		[Address(RVA="0x122257C", Offset="0x122257C", VA="0x122257C")]
		get
		{
			return null;
		}
	}

	public bool IsEmpty
	{
		[Address(RVA="0x1222564", Offset="0x1222564", VA="0x1222564")]
		get
		{
			return new bool();
		}
	}

	public bool IsEnabled
	{
		[Address(RVA="0x1222574", Offset="0x1222574", VA="0x1222574")]
		get
		{
			return new bool();
		}
	}

	[Address(RVA="0x1222A5C", Offset="0x1222A5C", VA="0x1222A5C")]
	public SquadSelectSpellSlot()
	{
	}

	[Address(RVA="0x1222584", Offset="0x1222584", VA="0x1222584")]
	public void Initialize(WidgetDependencyContainer dependencies, int index, bool enabled)
	{
	}

	[Address(RVA="0x1222884", Offset="0x1222884", VA="0x1222884")]
	public void SetSpell(Spell spell)
	{
	}

	[Address(RVA="0x1222974", Offset="0x1222974", VA="0x1222974")]
	public void Shutdown()
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104CC2C", Offset="0x104CC2C")]
	private sealed class <>c__DisplayClass6_0
	{
		[FieldOffset(Offset="0x10")]
		public WidgetDependencyContainer dependencies;

		[FieldOffset(Offset="0x18")]
		public int index;

		[Address(RVA="0x122287C", Offset="0x122287C", VA="0x122287C")]
		public <>c__DisplayClass6_0()
		{
		}

		[Address(RVA="0x1222A78", Offset="0x1222A78", VA="0x1222A78")]
		internal void <Initialize>b__0()
		{
		}

		[Address(RVA="0x1222B10", Offset="0x1222B10", VA="0x1222B10")]
		internal void <Initialize>b__1()
		{
		}

		[Address(RVA="0x1222BA8", Offset="0x1222BA8", VA="0x1222BA8")]
		internal void <Initialize>b__2()
		{
		}
	}
}