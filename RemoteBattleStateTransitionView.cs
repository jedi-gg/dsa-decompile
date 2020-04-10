using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;
using System.Collections.Generic;
using UnityEngine;

public class RemoteBattleStateTransitionView : AView
{
	public override ViewDepth Depth
	{
		[Address(RVA="0x2C2E9E8", Offset="0x2C2E9E8", VA="0x2C2E9E8", Slot="5")]
		get
		{
			return new ViewDepth();
		}
	}

	private RemoteBattleStateTransitionView.SerializedFields Fields
	{
		[Address(RVA="0x2C2EBE8", Offset="0x2C2EBE8", VA="0x2C2EBE8")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x2C2EDF4", Offset="0x2C2EDF4", VA="0x2C2EDF4")]
	public RemoteBattleStateTransitionView()
	{
	}

	[Address(RVA="0x2C2E9F0", Offset="0x2C2E9F0", VA="0x2C2E9F0")]
	public void Initialize(MatchType matchType, RemoteBattlePlayerSquadWidget.Data localPlayerData, RemoteBattlePlayerSquadWidget.Data remotePlayerData)
	{
	}

	[Address(RVA="0x2C2D630", Offset="0x2C2D630", VA="0x2C2D630")]
	public void StartTransitionIntoBattle()
	{
	}

	[Address(RVA="0x2C2ECC8", Offset="0x2C2ECC8", VA="0x2C2ECC8", Slot="11")]
	protected override void ViewAssetLoaded()
	{
	}

	[Address(RVA="0x2C2ED70", Offset="0x2C2ED70", VA="0x2C2ED70", Slot="12")]
	protected override void ViewShuttingDown()
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104B08C", Offset="0x104B08C")]
	[Serializable]
	private sealed class <>c
	{
		[FieldOffset(Offset="0x0")]
		public readonly static RemoteBattleStateTransitionView.<>c <>9;

		[FieldOffset(Offset="0x8")]
		public static Action<UnityEngine.GameObject> <>9__3_0;

		[Address(RVA="0x2C2EDFC", Offset="0x2C2EDFC", VA="0x2C2EDFC")]
		static <>c()
		{
		}

		[Address(RVA="0x2C2EE60", Offset="0x2C2EE60", VA="0x2C2EE60")]
		public <>c()
		{
		}

		[Address(RVA="0x2C2EE68", Offset="0x2C2EE68", VA="0x2C2EE68")]
		internal void <StartTransitionIntoBattle>b__3_0(UnityEngine.GameObject o)
		{
		}
	}

	[Serializable]
	public class SerializedFields : ViewSerializedFields
	{
		[FieldOffset(Offset="0x28")]
		public RemoteBattlePlayerSquadWidget LocalPlayerContainer;

		[FieldOffset(Offset="0x30")]
		public RemoteBattlePlayerSquadWidget RemotePlayerContainer;

		[FieldOffset(Offset="0x38")]
		public UnityEngine.GameObject VersusIcon;

		[FieldOffset(Offset="0x40")]
		public UnityEngine.GameObject CoopIcon;

		[FieldOffset(Offset="0x48")]
		public CanvasGroup BackgroundCanvasGroup;

		[Attribute(Name="HeaderAttribute", RVA="0x1069AC4", Offset="0x1069AC4")]
		[FieldOffset(Offset="0x50")]
		public List<UnityEngine.GameObject> ObjectsToDisableOnBattleStart;

		[FieldOffset(Offset="0x58")]
		public float PlayerInfoTweenXAmount;

		[FieldOffset(Offset="0x5C")]
		public float PlayerInfoTweenDurationS;

		[FieldOffset(Offset="0x60")]
		public float PlayerInfoTweenDelayS;

		[FieldOffset(Offset="0x64")]
		public float BackgroundFadeDurationS;

		[Address(RVA="0x2C2EE9C", Offset="0x2C2EE9C", VA="0x2C2EE9C")]
		public SerializedFields()
		{
		}
	}
}