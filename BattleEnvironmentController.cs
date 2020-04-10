using BattleLib;
using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BattleEnvironmentController : ILoggable<LogCategory>, IDispatchHandler<DBattleUnitsControllerAction>, IDispatchHandler, IDispatchHandler<DBattleViewControllerAction>, IDispatchHandler<DBattleEncounterAction>, IDispatchHandler<DTitleViewAction>, IDispatchHandler<DBattleSelectTargetAction>, IDispatchHandler<DBattleMsgAction<BattleLib_UpdateResult.Types.UnitTurnStarted>>
{
	[Attribute(Name="InjectAttribute", RVA="0x105330C", Offset="0x105330C")]
	[FieldOffset(Offset="0x10")]
	private AssetRegistry _assetRegistry;

	[Attribute(Name="InjectAttribute", RVA="0x105331C", Offset="0x105331C")]
	[FieldOffset(Offset="0x18")]
	private DispatchSystem _dispatch;

	[Attribute(Name="InjectAttribute", RVA="0x105332C", Offset="0x105332C")]
	[FieldOffset(Offset="0x20")]
	private BattleConfig _battleConfig;

	[Attribute(Name="InjectAttribute", RVA="0x105333C", Offset="0x105333C")]
	[FieldOffset(Offset="0x28")]
	private ABattle _battle;

	[Attribute(Name="InjectAttribute", RVA="0x105334C", Offset="0x105334C")]
	[FieldOffset(Offset="0x30")]
	private LocalizationManager _lm;

	[Attribute(Name="InjectAttribute", RVA="0x105335C", Offset="0x105335C")]
	[FieldOffset(Offset="0x38")]
	private BattleUnitsController _unitsController;

	[Attribute(Name="InjectAttribute", RVA="0x105336C", Offset="0x105336C")]
	[FieldOffset(Offset="0x40")]
	private GraphicsSettings _graphicsSettings;

	[FieldOffset(Offset="0x48")]
	private BattleCamera _battleCam;

	[FieldOffset(Offset="0x50")]
	private BattleEnvironment _firstSceneEnv;

	[FieldOffset(Offset="0x58")]
	private List<BattleEnvironmentController.SceneHandle> _scenes;

	[FieldOffset(Offset="0x60")]
	private int _currentSceneIndex;

	[FieldOffset(Offset="0x64")]
	private float _currentVerticality;

	[FieldOffset(Offset="0x68")]
	private BattleIntroCinematic _introCinematic;

	public BattleCamera BattleCamera
	{
		[Address(RVA="0x1143934", Offset="0x1143934", VA="0x1143934")]
		get
		{
			return null;
		}
	}

	public float CurrentVerticality
	{
		[Address(RVA="0x114392C", Offset="0x114392C", VA="0x114392C")]
		get
		{
			return new float();
		}
	}

	public BattleIntroCinematic IntroCinematic
	{
		[Address(RVA="0x113DDD4", Offset="0x113DDD4", VA="0x113DDD4")]
		get
		{
			return null;
		}
	}

	public LogCategory LogCategory
	{
		[Address(RVA="0x1143924", Offset="0x1143924", VA="0x1143924", Slot="4")]
		get
		{
			return new LogCategory();
		}
	}

	[Address(RVA="0x1144998", Offset="0x1144998", VA="0x1144998")]
	public BattleEnvironmentController()
	{
	}

	[Address(RVA="0x1143FB0", Offset="0x1143FB0", VA="0x1143FB0", Slot="5")]
	public void HandleDispatchAction(DBattleUnitsControllerAction action)
	{
	}

	[Address(RVA="0x114409C", Offset="0x114409C", VA="0x114409C", Slot="6")]
	public void HandleDispatchAction(DBattleViewControllerAction action)
	{
	}

	[Address(RVA="0x1144148", Offset="0x1144148", VA="0x1144148", Slot="7")]
	public void HandleDispatchAction(DBattleEncounterAction action)
	{
	}

	[Address(RVA="0x114444C", Offset="0x114444C", VA="0x114444C", Slot="8")]
	public void HandleDispatchAction(DTitleViewAction action)
	{
	}

	[Address(RVA="0x11447E8", Offset="0x11447E8", VA="0x11447E8", Slot="9")]
	public void HandleDispatchAction(DBattleSelectTargetAction action)
	{
	}

	[Address(RVA="0x1144894", Offset="0x1144894", VA="0x1144894", Slot="10")]
	public void HandleDispatchAction(DBattleMsgAction<BattleLib_UpdateResult.Types.UnitTurnStarted> action)
	{
	}

	[Address(RVA="0x114393C", Offset="0x114393C", VA="0x114393C")]
	public void Initialize()
	{
	}

	[Address(RVA="0x1143974", Offset="0x1143974", VA="0x1143974")]
	public void LoadAssets(string[] envAssets, Action finished)
	{
	}

	[Address(RVA="0x1144524", Offset="0x1144524", VA="0x1144524")]
	private void PlayAudio()
	{
	}

	[Address(RVA="0x1143F18", Offset="0x1143F18", VA="0x1143F18")]
	public void PlayVictory()
	{
	}

	[Address(RVA="0x113C220", Offset="0x113C220", VA="0x113C220")]
	public void SetSpawnPointsIncludedInCameraBounds(bool includeSpawnPoints)
	{
	}

	[Address(RVA="0x1143A94", Offset="0x1143A94", VA="0x1143A94")]
	public void SetVerticality(float v)
	{
	}

	[Address(RVA="0x1143A9C", Offset="0x1143A9C", VA="0x1143A9C")]
	public void Shutdown()
	{
	}

	[Address(RVA="0x11442E0", Offset="0x11442E0", VA="0x11442E0")]
	private void SwapToNextScene()
	{
	}

	[Address(RVA="0x1143E88", Offset="0x1143E88", VA="0x1143E88")]
	public void TickUpdate()
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104AF9C", Offset="0x104AF9C")]
	private sealed class <>c__DisplayClass9_0
	{
		[FieldOffset(Offset="0x10")]
		public string[] envAssets;

		[FieldOffset(Offset="0x18")]
		public BattleEnvironmentController <>4__this;

		[FieldOffset(Offset="0x20")]
		public Action finished;

		[Address(RVA="0x1143A8C", Offset="0x1143A8C", VA="0x1143A8C")]
		public <>c__DisplayClass9_0()
		{
		}

		[Address(RVA="0x1144A08", Offset="0x1144A08", VA="0x1144A08")]
		internal void <LoadAssets>b__0(AssetCollection collection)
		{
		}
	}

	private class SceneHandle
	{
		[FieldOffset(Offset="0x10")]
		public AssetHandle AssetHandle;

		[FieldOffset(Offset="0x18")]
		public GameObject RootObject;

		public Scene? Scene
		{
			[Address(RVA="0x1144984", Offset="0x1144984", VA="0x1144984")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1145304", Offset="0x1145304", VA="0x1145304")]
		public SceneHandle()
		{
		}
	}
}