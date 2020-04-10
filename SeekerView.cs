using DG.Tweening;
using Gamedata;
using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.UI;

public class SeekerView : AView
{
	[FieldOffset(Offset="0x0")]
	private const int NUM_STATE_TRANSITIONS_BEFORE_CLEANUP = 5;

	[FieldOffset(Offset="0x0")]
	private readonly static int s_defaultAnimationHash;

	[Attribute(Name="InjectAttribute", RVA="0x105C1E0", Offset="0x105C1E0")]
	[FieldOffset(Offset="0x68")]
	private GamedataDomainController _gamedataDc;

	[Attribute(Name="InjectAttribute", RVA="0x105C1F0", Offset="0x105C1F0")]
	[FieldOffset(Offset="0x70")]
	private AssetRegistry _seekerAssetRegistry;

	[Attribute(Name="InjectAttribute", RVA="0x105C200", Offset="0x105C200")]
	[FieldOffset(Offset="0x78")]
	private Procrastinator _procrastinator;

	[FieldOffset(Offset="0x80")]
	private string[] _seekerAssetNames;

	[FieldOffset(Offset="0x88")]
	private string _seekerPrefabAssetName;

	[FieldOffset(Offset="0x90")]
	private string _seekerRenderTextureAssetName;

	[FieldOffset(Offset="0x98")]
	private UnityEngine.GameObject _seekerInstance;

	[FieldOffset(Offset="0xA0")]
	private Animator _seekerInstanceAnimator;

	[FieldOffset(Offset="0xA8")]
	private RenderTexture _renderTextureInstance;

	[FieldOffset(Offset="0xB0")]
	private Tweener _seekerAppearTween;

	[FieldOffset(Offset="0xB8")]
	private SeekerPointAt? _pointAtData;

	[FieldOffset(Offset="0xD0")]
	private RectTransform _pointAtTarget;

	[FieldOffset(Offset="0xD8")]
	private int _stateTransitionCount;

	public override bool CanTriggerContextualMessages
	{
		[Address(RVA="0x2C40C1C", Offset="0x2C40C1C", VA="0x2C40C1C", Slot="7")]
		get
		{
			return new bool();
		}
	}

	public override ViewDepth Depth
	{
		[Address(RVA="0x2C40C14", Offset="0x2C40C14", VA="0x2C40C14", Slot="5")]
		get
		{
			return new ViewDepth();
		}
	}

	private SeekerView.SerializedFields Fields
	{
		[Address(RVA="0x2C412F4", Offset="0x2C412F4", VA="0x2C412F4")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x2C42098", Offset="0x2C42098", VA="0x2C42098")]
	static SeekerView()
	{
	}

	[Address(RVA="0x2C42038", Offset="0x2C42038", VA="0x2C42038")]
	public SeekerView()
	{
	}

	[Address(RVA="0x2C420FC", Offset="0x2C420FC", VA="0x2C420FC")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1070834", Offset="0x1070834")]
	private void <DisappearAndHideView>g__TurnOffView|6_0()
	{
	}

	[Address(RVA="0x2C421F8", Offset="0x2C421F8", VA="0x2C421F8")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1070844", Offset="0x1070844")]
	private void <LoadSeeker>b__11_0(AssetCollection collection)
	{
	}

	[Address(RVA="0x2C40DE4", Offset="0x2C40DE4", VA="0x2C40DE4")]
	public void Configure(SeekerPointAt? pointAtData, RectTransform pointAtTarget)
	{
	}

	[Address(RVA="0x2C416FC", Offset="0x2C416FC", VA="0x2C416FC")]
	public void DisappearAndHideView()
	{
	}

	[Address(RVA="0x2C4197C", Offset="0x2C4197C", VA="0x2C4197C")]
	public void HandleGameStateExited()
	{
	}

	[Address(RVA="0x2C413D4", Offset="0x2C413D4", VA="0x2C413D4")]
	private void LoadSeeker()
	{
	}

	[Address(RVA="0x2C414C0", Offset="0x2C414C0", VA="0x2C414C0")]
	private void PlaySeekerAppear()
	{
	}

	[Address(RVA="0x2C40C24", Offset="0x2C40C24", VA="0x2C40C24")]
	public void TickUpdate()
	{
	}

	[Address(RVA="0x2C41A30", Offset="0x2C41A30", VA="0x2C41A30")]
	public void UnloadSeeker()
	{
	}

	[Address(RVA="0x2C40C28", Offset="0x2C40C28", VA="0x2C40C28")]
	private void UpdatePointAtTargetPosition()
	{
	}

	[Address(RVA="0x2C41B40", Offset="0x2C41B40", VA="0x2C41B40", Slot="11")]
	protected override void ViewAssetLoaded()
	{
	}

	[Address(RVA="0x2C41FDC", Offset="0x2C41FDC", VA="0x2C41FDC", Slot="12")]
	protected override void ViewShuttingDown()
	{
	}

	[Serializable]
	public class SerializedFields : ViewSerializedFields
	{
		[FieldOffset(Offset="0x28")]
		[SerializeField]
		public RectTransform PointAtProxy;

		[FieldOffset(Offset="0x30")]
		[SerializeField]
		public RectTransform SeekerPositionerRoot;

		[FieldOffset(Offset="0x38")]
		[SerializeField]
		public RectTransform SeekerImageRoot;

		[FieldOffset(Offset="0x40")]
		[SerializeField]
		public CanvasGroup SeekerImageRootCanvasGroup;

		[FieldOffset(Offset="0x48")]
		[SerializeField]
		public RawImage SeekerRawImage;

		[FieldOffset(Offset="0x50")]
		[SerializeField]
		public Camera WorldCamera;

		[Attribute(Name="HeaderAttribute", RVA="0x106B8BC", Offset="0x106B8BC")]
		[FieldOffset(Offset="0x58")]
		[SerializeField]
		public ParticleSystem AppearParticles;

		[FieldOffset(Offset="0x60")]
		[SerializeField]
		public ParticleSystem DisappearParticles;

		[FieldOffset(Offset="0x68")]
		[SerializeField]
		public float DisappearHideDelayS;

		[Attribute(Name="HeaderAttribute", RVA="0x106B928", Offset="0x106B928")]
		[FieldOffset(Offset="0x6C")]
		[SerializeField]
		public float SeekerAppearTweenDurationS;

		[FieldOffset(Offset="0x70")]
		[SerializeField]
		public float SeekerAppearTweenDelayS;

		[FieldOffset(Offset="0x74")]
		[SerializeField]
		public Ease SeekerAppearEase;

		[Address(RVA="0x2C42528", Offset="0x2C42528", VA="0x2C42528")]
		public SerializedFields()
		{
		}
	}
}