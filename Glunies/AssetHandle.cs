using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Glunies
{
	public class AssetHandle : AssetHandle.ITest
	{
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1063DEC", Offset="0x1063DEC")]
		[FieldOffset(Offset="0x10")]
		private Glunies.AssetId <AssetId>k__BackingField;

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1063DFC", Offset="0x1063DFC")]
		[FieldOffset(Offset="0x18")]
		private bool <Persistent>k__BackingField;

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1063E0C", Offset="0x1063E0C")]
		[FieldOffset(Offset="0x19")]
		private bool <IsDestroyed>k__BackingField;

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1063E1C", Offset="0x1063E1C")]
		[FieldOffset(Offset="0x1C")]
		private UnityEngine.SceneManagement.Scene? <Scene>k__BackingField;

		[FieldOffset(Offset="0x28")]
		private UnityEngine.Object _asset;

		public Glunies.AssetId AssetId
		{
			[Address(RVA="0x14FC8B0", Offset="0x14FC8B0", VA="0x14FC8B0")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108A0C4", Offset="0x108A0C4")]
			get
			{
				return null;
			}
			[Address(RVA="0x14FCD00", Offset="0x14FCD00", VA="0x14FCD00")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108A0D4", Offset="0x108A0D4")]
			private set
			{
			}
		}

		private UnityEngine.Object Glunies.AssetHandle.ITest.Asset
		{
			[Address(RVA="0x14FCE04", Offset="0x14FCE04", VA="0x14FCE04", Slot="4")]
			get
			{
				return null;
			}
		}

		public bool IsDestroyed
		{
			[Address(RVA="0x14FCD1C", Offset="0x14FCD1C", VA="0x14FCD1C")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108A104", Offset="0x108A104")]
			get
			{
				return new bool();
			}
			[Address(RVA="0x14FCD24", Offset="0x14FCD24", VA="0x14FCD24")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108A114", Offset="0x108A114")]
			private set
			{
			}
		}

		public bool IsValid
		{
			[Address(RVA="0x14FCD40", Offset="0x14FCD40", VA="0x14FCD40")]
			get
			{
				return new bool();
			}
		}

		public bool Persistent
		{
			[Address(RVA="0x14FCD08", Offset="0x14FCD08", VA="0x14FCD08")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108A0E4", Offset="0x108A0E4")]
			get
			{
				return new bool();
			}
			[Address(RVA="0x14FCD10", Offset="0x14FCD10", VA="0x14FCD10")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108A0F4", Offset="0x108A0F4")]
			private set
			{
			}
		}

		public UnityEngine.SceneManagement.Scene? Scene
		{
			[Address(RVA="0x14FCD30", Offset="0x14FCD30", VA="0x14FCD30")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108A124", Offset="0x108A124")]
			get
			{
				return null;
			}
			[Address(RVA="0x14FCD38", Offset="0x14FCD38", VA="0x14FCD38")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108A134", Offset="0x108A134")]
			private set
			{
			}
		}

		[Address(RVA="0x14FCDFC", Offset="0x14FCDFC", VA="0x14FCDFC")]
		private AssetHandle()
		{
		}

		[Address(RVA="0x16A998C", Offset="0x16A998C", VA="0x16A998C")]
		public T GetAsset<T>()
		where T : UnityEngine.Object
		{
			return null;
		}

		public class Factory
		{
			[Address(RVA="0x14F3D9C", Offset="0x14F3D9C", VA="0x14F3D9C")]
			public Factory()
			{
			}

			[Address(RVA="0x14F4478", Offset="0x14F4478", VA="0x14F4478")]
			public AssetHandle CreateAsset(Glunies.AssetId assetId, UnityEngine.Object asset, bool persistent)
			{
				return null;
			}

			[Address(RVA="0x14FCE0C", Offset="0x14FCE0C", VA="0x14FCE0C")]
			public AssetHandle CreateScene(Glunies.AssetId assetId, UnityEngine.SceneManagement.Scene? scene)
			{
				return null;
			}

			[Address(RVA="0x14FCED8", Offset="0x14FCED8", VA="0x14FCED8")]
			public void Destroy(AssetHandle assetHandle)
			{
			}
		}

		public interface ITest
		{
			UnityEngine.Object Asset
			{
				get;
			}
		}
	}
}