using Glunies;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.UI;

public class TitleView : AView
{
	[FieldOffset(Offset="0x0")]
	private const float TIME_SCALE = 1.5f;

	[FieldOffset(Offset="0x0")]
	private static bool s_sentInitialLoadTime;

	[Attribute(Name="InjectAttribute", RVA="0x105D6B8", Offset="0x105D6B8")]
	[FieldOffset(Offset="0x68")]
	private Procrastinator _procrastinator;

	[Attribute(Name="InjectAttribute", RVA="0x105D6C8", Offset="0x105D6C8")]
	[FieldOffset(Offset="0x70")]
	private PlayerDomainController _playerDC;

	[Attribute(Name="InjectAttribute", RVA="0x105D6D8", Offset="0x105D6D8")]
	[FieldOffset(Offset="0x78")]
	private SharedPrefs _sharedPrefs;

	[Attribute(Name="InjectAttribute", RVA="0x105D6E8", Offset="0x105D6E8")]
	[FieldOffset(Offset="0x80")]
	private FirebaseController _firebaseController;

	[FieldOffset(Offset="0x88")]
	private Camera _mainCamera;

	[FieldOffset(Offset="0x90")]
	private int _defaultMainCameraCullingMask;

	[FieldOffset(Offset="0x94")]
	private TitleView.InitialState _initialState;

	[FieldOffset(Offset="0x98")]
	private uint? _timeScaleId;

	public override bool CanTriggerContextualMessages
	{
		[Address(RVA="0x13277F0", Offset="0x13277F0", VA="0x13277F0", Slot="7")]
		get
		{
			return new bool();
		}
	}

	public override ViewDepth Depth
	{
		[Address(RVA="0x13277E8", Offset="0x13277E8", VA="0x13277E8", Slot="5")]
		get
		{
			return new ViewDepth();
		}
	}

	private TitleView.SerializedFields Fields
	{
		[Address(RVA="0x13278D4", Offset="0x13278D4", VA="0x13278D4")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x1328CA4", Offset="0x1328CA4", VA="0x1328CA4")]
	static TitleView()
	{
	}

	[Address(RVA="0x1328C9C", Offset="0x1328C9C", VA="0x1328C9C")]
	public TitleView()
	{
	}

	[Address(RVA="0x1328CA8", Offset="0x1328CA8", VA="0x1328CA8")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1070DA4", Offset="0x1070DA4")]
	private void <CaseOpenCinematicCompleted>g__CaseOpeningPlusDelayCompleted|15_0()
	{
	}

	[Address(RVA="0x1328AA4", Offset="0x1328AA4", VA="0x1328AA4")]
	private void CaseOpenCinematicCompleted()
	{
	}

	[Address(RVA="0x1328374", Offset="0x1328374", VA="0x1328374")]
	private void ClearTimeScale()
	{
	}

	[Address(RVA="0x13279B4", Offset="0x13279B4", VA="0x13279B4")]
	private void GoToPreCaseOpeningStateImmediately()
	{
	}

	[Address(RVA="0x13277F8", Offset="0x13277F8", VA="0x13277F8")]
	private void InitializeIntroCinematic()
	{
	}

	[Address(RVA="0x1328708", Offset="0x1328708", VA="0x1328708")]
	private void IntroCinematicCompleted(PlayableDirector playableDirector)
	{
	}

	[Address(RVA="0x13284E4", Offset="0x13284E4", VA="0x13284E4")]
	private void IntroCinematicPlayed(PlayableDirector playableDirector)
	{
	}

	[Address(RVA="0x132728C", Offset="0x132728C", VA="0x132728C")]
	public void PlayOpeningAnimation()
	{
	}

	[Address(RVA="0x13289E0", Offset="0x13289E0", VA="0x13289E0")]
	private void SaveCinematicWatchedPref()
	{
	}

	[Address(RVA="0x1327078", Offset="0x1327078", VA="0x1327078")]
	public void SetInitialState(TitleView.InitialState initialState)
	{
	}

	[Address(RVA="0x1328784", Offset="0x1328784", VA="0x1328784")]
	private void SetPreCaseOpeningState()
	{
	}

	[Address(RVA="0x1327444", Offset="0x1327444", VA="0x1327444")]
	public void SetReadyToOpenCase()
	{
	}

	[Address(RVA="0x1327158", Offset="0x1327158", VA="0x1327158")]
	public void SetReadyToSkipIntroCinematic()
	{
	}

	[Address(RVA="0x1328BA8", Offset="0x1328BA8", VA="0x1328BA8")]
	private void SkipButtonClicked()
	{
	}

	[Address(RVA="0x1328440", Offset="0x1328440", VA="0x1328440")]
	private void StartMainCameraRendering()
	{
	}

	[Address(RVA="0x1328158", Offset="0x1328158", VA="0x1328158")]
	private void StopMainCameraRendering()
	{
	}

	[Address(RVA="0x1327BFC", Offset="0x1327BFC", VA="0x1327BFC", Slot="11")]
	protected override void ViewAssetLoaded()
	{
	}

	[Address(RVA="0x13281B0", Offset="0x13281B0", VA="0x13281B0", Slot="12")]
	protected override void ViewShuttingDown()
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104CE6C", Offset="0x104CE6C")]
	[Serializable]
	private sealed class <>c
	{
		[FieldOffset(Offset="0x0")]
		public readonly static TitleView.<>c <>9;

		[FieldOffset(Offset="0x8")]
		public static Action<UnityEngine.GameObject> <>9__8_0;

		[FieldOffset(Offset="0x10")]
		public static Action<UnityEngine.GameObject> <>9__8_1;

		[FieldOffset(Offset="0x18")]
		public static Action<UnityEngine.GameObject> <>9__11_0;

		[FieldOffset(Offset="0x20")]
		public static Action<UnityEngine.GameObject> <>9__11_1;

		[FieldOffset(Offset="0x28")]
		public static Action<UnityEngine.GameObject> <>9__13_0;

		[FieldOffset(Offset="0x30")]
		public static Action<UnityEngine.GameObject> <>9__13_1;

		[Address(RVA="0x1328D2C", Offset="0x1328D2C", VA="0x1328D2C")]
		static <>c()
		{
		}

		[Address(RVA="0x1328D90", Offset="0x1328D90", VA="0x1328D90")]
		public <>c()
		{
		}

		[Address(RVA="0x1328E00", Offset="0x1328E00", VA="0x1328E00")]
		internal void <IntroCinematicPlayed>b__11_0(UnityEngine.GameObject o)
		{
		}

		[Address(RVA="0x1328E34", Offset="0x1328E34", VA="0x1328E34")]
		internal void <IntroCinematicPlayed>b__11_1(UnityEngine.GameObject o)
		{
		}

		[Address(RVA="0x1328E68", Offset="0x1328E68", VA="0x1328E68")]
		internal void <SetPreCaseOpeningState>b__13_0(UnityEngine.GameObject o)
		{
		}

		[Address(RVA="0x1328E9C", Offset="0x1328E9C", VA="0x1328E9C")]
		internal void <SetPreCaseOpeningState>b__13_1(UnityEngine.GameObject o)
		{
		}

		[Address(RVA="0x1328D98", Offset="0x1328D98", VA="0x1328D98")]
		internal void <ViewAssetLoaded>b__8_0(UnityEngine.GameObject o)
		{
		}

		[Address(RVA="0x1328DCC", Offset="0x1328DCC", VA="0x1328DCC")]
		internal void <ViewAssetLoaded>b__8_1(UnityEngine.GameObject o)
		{
		}
	}

	public enum InitialState
	{
		[FieldOffset(Offset="0x0")]
		PlayIntroCinematic,
		[FieldOffset(Offset="0x0")]
		StartOnCaseWithoutIntro,
		[FieldOffset(Offset="0x0")]
		StandaloneIntroCinematic
	}

	[Serializable]
	public class SerializedFields : ViewSerializedFields
	{
		[Attribute(Name="HeaderAttribute", RVA="0x106BF2C", Offset="0x106BF2C")]
		[FieldOffset(Offset="0x28")]
		public PlayableDirector IntroCinematic;

		[FieldOffset(Offset="0x30")]
		public Button SkipIntroCinematicButton;

		[FieldOffset(Offset="0x38")]
		public UnityEngine.GameObject FinalTimelineBoard;

		[Attribute(Name="HeaderAttribute", RVA="0x106BF64", Offset="0x106BF64")]
		[FieldOffset(Offset="0x40")]
		public List<UnityEngine.GameObject> IntroCinematicObjs;

		[FieldOffset(Offset="0x48")]
		public List<UnityEngine.GameObject> CaseOpeningObjs;

		[FieldOffset(Offset="0x50")]
		public UnityEngine.GameObject LoadingContainer;

		[FieldOffset(Offset="0x58")]
		public Button TapToContinueButton;

		[FieldOffset(Offset="0x60")]
		public Animation CaseOpeningAnimation;

		[FieldOffset(Offset="0x68")]
		public AnimationClip CaseOpeningAnimationClip;

		[FieldOffset(Offset="0x70")]
		public float HideAnimationCompletedDelay;

		[FieldOffset(Offset="0x78")]
		public UiLabel PlayerIdLabel;

		[Attribute(Name="HeaderAttribute", RVA="0x106BF9C", Offset="0x106BF9C")]
		[FieldOffset(Offset="0x80")]
		public AudioSource AudioSource;

		[Address(RVA="0x1328ED0", Offset="0x1328ED0", VA="0x1328ED0")]
		public SerializedFields()
		{
		}
	}
}