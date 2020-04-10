using DG.Tweening;
using Gamedata;
using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.UI;

public class HudItemComponent : MonoBehaviour
{
	[FieldOffset(Offset="0x0")]
	private const float TALLY_DURATION_LOG_BASE = 200f;

	[FieldOffset(Offset="0x18")]
	private DispatchSystem _dispatch;

	[FieldOffset(Offset="0x20")]
	private SingleAssetRegistry _assetRegistry;

	[FieldOffset(Offset="0x28")]
	private HudItemComponent.Data _data;

	[FieldOffset(Offset="0x30")]
	private UnityEngine.Color? _defaultLabelColor;

	[FieldOffset(Offset="0x48")]
	private Sequence _increaseSeq;

	[FieldOffset(Offset="0x50")]
	private Sequence _decreaseSeq;

	[FieldOffset(Offset="0x58")]
	[SerializeField]
	private RawImage _icon;

	[FieldOffset(Offset="0x60")]
	[SerializeField]
	private TallyLabelSigned _label;

	[FieldOffset(Offset="0x68")]
	[SerializeField]
	private Button _button;

	[FieldOffset(Offset="0x70")]
	[SerializeField]
	private GameObject _bonusIndicator;

	[FieldOffset(Offset="0x78")]
	[SerializeField]
	private UnityEngine.Color _bonusLabelColor;

	[FieldOffset(Offset="0x88")]
	[SerializeField]
	private GameObject _buyIndicator;

	[FieldOffset(Offset="0x90")]
	[SerializeField]
	private HudItemComponent.TweenParameters _tweenParams;

	public RectTransform IconRectTransform
	{
		[Address(RVA="0x1177F88", Offset="0x1177F88", VA="0x1177F88")]
		get
		{
			return null;
		}
	}

	public Texture IconTexture
	{
		[Address(RVA="0x1177FB8", Offset="0x1177FB8", VA="0x1177FB8")]
		get
		{
			return null;
		}
	}

	public ulong ItemContentId
	{
		[Address(RVA="0x1177F70", Offset="0x1177F70", VA="0x1177F70")]
		get
		{
			return new ulong();
		}
	}

	[Address(RVA="0x117942C", Offset="0x117942C", VA="0x117942C")]
	public HudItemComponent()
	{
	}

	[Address(RVA="0x117939C", Offset="0x117939C", VA="0x117939C")]
	private void ButtonClicked()
	{
	}

	[Address(RVA="0x1177FE8", Offset="0x1177FE8", VA="0x1177FE8")]
	public void Initialize(WidgetDependencyContainer dependencies)
	{
	}

	[Address(RVA="0x11792D0", Offset="0x11792D0", VA="0x11792D0")]
	private void OnDisable()
	{
	}

	[Address(RVA="0x1178F44", Offset="0x1178F44", VA="0x1178F44")]
	private void PlayTallySequence(bool forceRestart = false)
	{
	}

	[Address(RVA="0x1179138", Offset="0x1179138", VA="0x1179138")]
	private void Reset()
	{
	}

	[Address(RVA="0x11790C0", Offset="0x11790C0", VA="0x11790C0")]
	public void ResetTallyValues()
	{
	}

	[Address(RVA="0x1178764", Offset="0x1178764", VA="0x1178764")]
	public void SetData(HudItemComponent.Data data)
	{
	}

	[Address(RVA="0x1178C14", Offset="0x1178C14", VA="0x1178C14")]
	public void SetItemCount(long count)
	{
	}

	[Address(RVA="0x1178AD8", Offset="0x1178AD8", VA="0x1178AD8")]
	private void SetOrLoadTexture()
	{
	}

	[Address(RVA="0x1178E20", Offset="0x1178E20", VA="0x1178E20")]
	public void SetTallyValues(long from, long to, float duration)
	{
	}

	[Address(RVA="0x117863C", Offset="0x117863C", VA="0x117863C")]
	public void Shutdown()
	{
	}

	[Address(RVA="0x1178EE4", Offset="0x1178EE4", VA="0x1178EE4")]
	public void Tally()
	{
	}

	[Address(RVA="0x1178750", Offset="0x1178750", VA="0x1178750")]
	public void UnloadIconAsset()
	{
	}

	[Address(RVA="0x11791C0", Offset="0x11791C0", VA="0x11791C0")]
	private void Update()
	{
	}

	[Address(RVA="0x1178960", Offset="0x1178960", VA="0x1178960")]
	public void UpdateBonusIndicatorVisibility()
	{
	}

	public class Data
	{
		[FieldOffset(Offset="0x10")]
		public ulong ItemContentId;

		[FieldOffset(Offset="0x18")]
		public InventoryItemType ItemType;

		[FieldOffset(Offset="0x1C")]
		public uint MaxAmount;

		[FieldOffset(Offset="0x20")]
		public bool ShowBonus;

		[FieldOffset(Offset="0x21")]
		public bool ShouldTally;

		[FieldOffset(Offset="0x22")]
		public bool CanBePurchased;

		[FieldOffset(Offset="0x28")]
		public long DeltaAmount;

		[FieldOffset(Offset="0x30")]
		public Texture Image;

		[FieldOffset(Offset="0x38")]
		public string ImageAssetName;

		[Address(RVA="0x1179434", Offset="0x1179434", VA="0x1179434")]
		public Data()
		{
		}
	}

	[Serializable]
	public class TweenParameters
	{
		[FieldOffset(Offset="0x10")]
		public float IncreaseIdleDuration;

		[FieldOffset(Offset="0x14")]
		public float IncreaseScaleDuration;

		[FieldOffset(Offset="0x18")]
		public float IncreaseScaleXMagnitude;

		[FieldOffset(Offset="0x1C")]
		public float IncreaseScaleYMagnitude;

		[FieldOffset(Offset="0x20")]
		public float IncreaseScaleYPhaseOffset;

		[FieldOffset(Offset="0x24")]
		public float DecreasePunchDuration;

		[FieldOffset(Offset="0x28")]
		public int DecreasePunchVibrato;

		[FieldOffset(Offset="0x2C")]
		public Vector3 DecreasePunch;

		[Address(RVA="0x117944C", Offset="0x117944C", VA="0x117944C")]
		public TweenParameters()
		{
		}
	}
}