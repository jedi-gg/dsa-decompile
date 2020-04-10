using Glunies;
using Glunies.Sequencer;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

namespace Glunies.Inferno
{
	public class EffectVisualPlayer
	{
		[Attribute(Name="InjectAttribute", RVA="0x106497C", Offset="0x106497C")]
		[FieldOffset(Offset="0x10")]
		private DiContainer _diContainer;

		[Attribute(Name="InjectAttribute", RVA="0x106498C", Offset="0x106498C")]
		[FieldOffset(Offset="0x18")]
		private AssetRegistry _assetRegistry;

		[Attribute(Name="InjectAttribute", RVA="0x106499C", Offset="0x106499C")]
		[FieldOffset(Offset="0x20")]
		private GameObject _groundPlaneGo;

		[FieldOffset(Offset="0x28")]
		private List<EffectVisualPlayer.DVisualHandle> _activeVisualHandles;

		public int NumVisualsPlaying
		{
			[Address(RVA="0x1520F0C", Offset="0x1520F0C", VA="0x1520F0C")]
			get
			{
				return new int();
			}
		}

		[Address(RVA="0x1522EB4", Offset="0x1522EB4", VA="0x1522EB4")]
		public EffectVisualPlayer()
		{
		}

		[Address(RVA="0x1522DD8", Offset="0x1522DD8", VA="0x1522DD8")]
		private void HandleActionPreInitialize(ASequenceAction sequenceAction)
		{
		}

		[Address(RVA="0x1522CDC", Offset="0x1522CDC", VA="0x1522CDC")]
		public void Interrupt()
		{
		}

		[Address(RVA="0x1521780", Offset="0x1521780", VA="0x1521780")]
		public void PlayVisual(string visualAssetId, EffectVisualPlayer.DPlayContext context)
		{
		}

		[Address(RVA="0x1522764", Offset="0x1522764", VA="0x1522764")]
		public void PlayVisual(EffectVisualSequencer visualPrefab, EffectVisualPlayer.DPlayContext context)
		{
		}

		[Address(RVA="0x15228F8", Offset="0x15228F8", VA="0x15228F8")]
		private void PlayVisual(EffectVisualPlayer.DVisualHandle visualHandle, EffectVisualPlayer.DPlayContext context)
		{
		}

		[Address(RVA="0x15218C4", Offset="0x15218C4", VA="0x15218C4")]
		public void StopAll()
		{
		}

		[Address(RVA="0x1520D78", Offset="0x1520D78", VA="0x1520D78")]
		public void TickUpdate()
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10511F8", Offset="0x10511F8")]
		private sealed class <>c__DisplayClass2_0
		{
			[FieldOffset(Offset="0x10")]
			public EffectVisualPlayer <>4__this;

			[FieldOffset(Offset="0x18")]
			public EffectVisualPlayer.DPlayContext context;

			[Address(RVA="0x152275C", Offset="0x152275C", VA="0x152275C")]
			public <>c__DisplayClass2_0()
			{
			}

			[Address(RVA="0x1522F24", Offset="0x1522F24", VA="0x1522F24")]
			internal void <PlayVisual>b__0(AssetHandle handle)
			{
			}
		}

		public struct DPlayContext
		{
			[FieldOffset(Offset="0x0")]
			public GameObject CasterUnit;

			[FieldOffset(Offset="0x8")]
			public GameObject TargetUnit;

			[FieldOffset(Offset="0x10")]
			public Vector3 TargetPos;

			[FieldOffset(Offset="0x1C")]
			public Vector3 OriginPos;

			[FieldOffset(Offset="0x28")]
			public float DurationS;

			[FieldOffset(Offset="0x2C")]
			public bool Interruptable;
		}

		public struct DVisualHandle
		{
			[FieldOffset(Offset="0x0")]
			public EffectVisualSequencer Visual;

			[FieldOffset(Offset="0x8")]
			public AssetHandle AssetHandle;

			[FieldOffset(Offset="0x10")]
			public bool Interruptable;
		}
	}
}