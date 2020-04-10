using Glunies.Audio;
using Il2CppDummyDll;
using System;
using UnityEngine;
using Zenject;

namespace Glunies
{
	public abstract class AView : ILoggable<LogCategory>
	{
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1064360", Offset="0x1064360")]
		[FieldOffset(Offset="0x10")]
		private readonly ViewDepth <Depth>k__BackingField;

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1064370", Offset="0x1064370")]
		[FieldOffset(Offset="0x14")]
		private readonly RenderMode <MainCanvasRenderMode>k__BackingField;

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1064380", Offset="0x1064380")]
		[FieldOffset(Offset="0x18")]
		private int <SortingOrder>k__BackingField;

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1064390", Offset="0x1064390")]
		[FieldOffset(Offset="0x1C")]
		private int <ZDepth>k__BackingField;

		[FieldOffset(Offset="0x0")]
		private const float SCREEN_SPACE_Z_SEPARATION = 500f;

		[FieldOffset(Offset="0x0")]
		private const string VIEW_BUNDLE_PREFIX = "ui_view_";

		[FieldOffset(Offset="0x0")]
		private const string DEFAULT_SORTING_LAYER = "Default";

		[FieldOffset(Offset="0x0")]
		private const string BACKDROP_SORTING_LAYER = "Backdrop";

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10643A0", Offset="0x10643A0")]
		[FieldOffset(Offset="0x20")]
		private readonly bool <WillHandleBackButton>k__BackingField;

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10643B0", Offset="0x10643B0")]
		[FieldOffset(Offset="0x28")]
		private Glunies.WidgetDependencyContainer <WidgetDependencyContainer>k__BackingField;

		[Attribute(Name="InjectAttribute", RVA="0x10643C0", Offset="0x10643C0")]
		[FieldOffset(Offset="0x30")]
		protected DiContainer _diContainer;

		[Attribute(Name="InjectAttribute", RVA="0x10643D0", Offset="0x10643D0")]
		[FieldOffset(Offset="0x38")]
		protected AssetRegistry _assetRegistry;

		[Attribute(Name="InjectAttribute", RVA="0x10643E0", Offset="0x10643E0")]
		[FieldOffset(Offset="0x40")]
		protected DispatchSystem _dispatchSystem;

		[Attribute(Name="InjectAttribute", RVA="0x10643F0", Offset="0x10643F0")]
		[FieldOffset(Offset="0x48")]
		protected LocalizationManager _lm;

		[Attribute(Name="InjectAttribute", RVA="0x1064400", Offset="0x1064400")]
		[FieldOffset(Offset="0x50")]
		protected FontManager _fontManager;

		[FieldOffset(Offset="0x58")]
		protected AViewMonoBehaviour _monoBehaviour;

		[FieldOffset(Offset="0x60")]
		private string _typeName;

		public virtual bool CanTriggerContextualMessages
		{
			[Address(RVA="0x14F7518", Offset="0x14F7518", VA="0x14F7518", Slot="7")]
			get
			{
				return new bool();
			}
		}

		public virtual ViewDepth Depth
		{
			[Address(RVA="0x14F7508", Offset="0x14F7508", VA="0x14F7508", Slot="5")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108A3A4", Offset="0x108A3A4")]
			get
			{
				return new ViewDepth();
			}
		}

		public UnityEngine.GameObject GameObject
		{
			[Address(RVA="0x14F7558", Offset="0x14F7558", VA="0x14F7558")]
			get
			{
				return null;
			}
		}

		protected virtual bool IgnoreDepthSorting
		{
			[Address(RVA="0x14F8CA0", Offset="0x14F8CA0", VA="0x14F8CA0", Slot="20")]
			get
			{
				return new bool();
			}
		}

		public LogCategory LogCategory
		{
			[Address(RVA="0x14F7500", Offset="0x14F7500", VA="0x14F7500", Slot="4")]
			get
			{
				return new LogCategory();
			}
		}

		public virtual RenderMode MainCanvasRenderMode
		{
			[Address(RVA="0x14F7510", Offset="0x14F7510", VA="0x14F7510", Slot="6")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108A3B4", Offset="0x108A3B4")]
			get
			{
				return new RenderMode();
			}
		}

		public virtual bool OverridesContextualMessageInput
		{
			[Address(RVA="0x14F7528", Offset="0x14F7528", VA="0x14F7528", Slot="9")]
			get
			{
				return new bool();
			}
		}

		public virtual string PrefabName
		{
			[Address(RVA="0x14F7520", Offset="0x14F7520", VA="0x14F7520", Slot="8")]
			get
			{
				return null;
			}
		}

		public int SortingOrder
		{
			[Address(RVA="0x14F7538", Offset="0x14F7538", VA="0x14F7538")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108A3C4", Offset="0x108A3C4")]
			get
			{
				return new int();
			}
			[Address(RVA="0x14F7540", Offset="0x14F7540", VA="0x14F7540")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108A3D4", Offset="0x108A3D4")]
			set
			{
			}
		}

		public string TypeName
		{
			[Address(RVA="0x14F7530", Offset="0x14F7530", VA="0x14F7530")]
			get
			{
				return null;
			}
		}

		protected Glunies.WidgetDependencyContainer WidgetDependencyContainer
		{
			[Address(RVA="0x14F7480", Offset="0x14F7480", VA="0x14F7480")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108A414", Offset="0x108A414")]
			get
			{
				return null;
			}
			[Address(RVA="0x14F8CA8", Offset="0x14F8CA8", VA="0x14F8CA8")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108A424", Offset="0x108A424")]
			private set
			{
			}
		}

		protected virtual bool WillHandleBackButton
		{
			[Address(RVA="0x14F8C98", Offset="0x14F8C98", VA="0x14F8C98", Slot="19")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108A404", Offset="0x108A404")]
			get
			{
				return new bool();
			}
		}

		public int ZDepth
		{
			[Address(RVA="0x14F7548", Offset="0x14F7548", VA="0x14F7548")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108A3E4", Offset="0x108A3E4")]
			get
			{
				return new int();
			}
			[Address(RVA="0x14F7550", Offset="0x14F7550", VA="0x14F7550")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108A3F4", Offset="0x108A3F4")]
			set
			{
			}
		}

		[Address(RVA="0x14F7238", Offset="0x14F7238", VA="0x14F7238")]
		public AView()
		{
		}

		[Address(RVA="0x14F8A6C", Offset="0x14F8A6C", VA="0x14F8A6C")]
		protected void DispatchAudioPlay(AudioClipGroup audioClipGroup)
		{
		}

		[Address(RVA="0x14F8B00", Offset="0x14F8B00", VA="0x14F8B00")]
		protected void DispatchAudioStop(AudioClipGroup audioClipGroup)
		{
		}

		[Address(RVA="0x14F8B88", Offset="0x14F8B88", VA="0x14F8B88")]
		protected void DispatchMusicPlay(AudioClipGroup audioClipGroup)
		{
		}

		[Address(RVA="0x14F8A58", Offset="0x14F8A58", VA="0x14F8A58", Slot="15")]
		protected virtual RectTransform GetDynamicPointAtObject(string pointAtId)
		{
			return null;
		}

		[Address(RVA="0x14F8A60", Offset="0x14F8A60", VA="0x14F8A60", Slot="16")]
		protected virtual Camera GetDynamicPointAtObjectWorldCamera(string pointAtId)
		{
			return null;
		}

		[Address(RVA="0x14F86F0", Offset="0x14F86F0", VA="0x14F86F0")]
		public RectTransform GetPointAtObject(string pointAtId)
		{
			return null;
		}

		[Address(RVA="0x14F8940", Offset="0x14F8940", VA="0x14F8940")]
		public Camera GetPointAtObjectWorldCamera(string pointAtId)
		{
			return null;
		}

		[Address(RVA="0x14F80B0", Offset="0x14F80B0", VA="0x14F80B0")]
		public bool HandleBackButton()
		{
			return new bool();
		}

		[Address(RVA="0x14F75F8", Offset="0x14F75F8", VA="0x14F75F8")]
		public void Initialize(bool startActive, Action success, Action failure)
		{
		}

		[Address(RVA="0x14F84D0", Offset="0x14F84D0", VA="0x14F84D0")]
		public void InjectBundledFallbackFont()
		{
		}

		[Address(RVA="0x14F8000", Offset="0x14F8000", VA="0x14F8000", Slot="10")]
		public virtual bool IsShowing()
		{
			return new bool();
		}

		[Address(RVA="0x14F8A68", Offset="0x14F8A68", VA="0x14F8A68", Slot="17")]
		protected virtual void PointAtObjectTriggered(RectTransform pointAtObject)
		{
		}

		[Address(RVA="0x14F8C10", Offset="0x14F8C10", VA="0x14F8C10", Slot="18")]
		protected virtual void ProcessBackButton()
		{
		}

		[Address(RVA="0x14F81A4", Offset="0x14F81A4", VA="0x14F81A4")]
		public void SetMainCanvasDepth()
		{
		}

		[Address(RVA="0x14F7F70", Offset="0x14F7F70", VA="0x14F7F70")]
		public void Show(bool show)
		{
		}

		[Address(RVA="0x14F78CC", Offset="0x14F78CC", VA="0x14F78CC")]
		public void Shutdown()
		{
		}

		[Address(RVA="0x14F6F60", Offset="0x14F6F60", VA="0x14F6F60", Slot="11")]
		protected virtual void ViewAssetLoaded()
		{
		}

		[Address(RVA="0x14F89D4", Offset="0x14F89D4", VA="0x14F89D4", Slot="14")]
		protected virtual void ViewHidden()
		{
		}

		[Address(RVA="0x14F8950", Offset="0x14F8950", VA="0x14F8950", Slot="13")]
		protected virtual void ViewShown()
		{
		}

		[Address(RVA="0x14F71AC", Offset="0x14F71AC", VA="0x14F71AC", Slot="12")]
		protected virtual void ViewShuttingDown()
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1051098", Offset="0x1051098")]
		private sealed class <>c__DisplayClass27_0
		{
			[FieldOffset(Offset="0x10")]
			public AView <>4__this;

			[FieldOffset(Offset="0x18")]
			public bool startActive;

			[FieldOffset(Offset="0x20")]
			public Action success;

			[FieldOffset(Offset="0x28")]
			public Action failure;

			[Address(RVA="0x14F778C", Offset="0x14F778C", VA="0x14F778C")]
			public <>c__DisplayClass27_0()
			{
			}

			[Address(RVA="0x14F8CB0", Offset="0x14F8CB0", VA="0x14F8CB0")]
			internal void <Initialize>b__0(AssetHandle assetHandle)
			{
			}
		}
	}
}