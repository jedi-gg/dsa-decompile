using Glunies;
using Il2CppDummyDll;
using System;

namespace Glunies.Inferno
{
	public class EnvironmentController : AInfernoController, IDispatchHandler<DEnvironmentMenuViewAction>, IDispatchHandler
	{
		[Attribute(Name="InjectAttribute", RVA="0x1064A00", Offset="0x1064A00")]
		[FieldOffset(Offset="0x28")]
		private DispatchSystem _dispatchSystem;

		[Attribute(Name="InjectAttribute", RVA="0x1064A10", Offset="0x1064A10")]
		[FieldOffset(Offset="0x30")]
		private SingleAssetRegistry _envAssetRegistry;

		private Glunies.Inferno.EnvironmentView EnvironmentView
		{
			[Address(RVA="0x152358C", Offset="0x152358C", VA="0x152358C")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x152386C", Offset="0x152386C", VA="0x152386C")]
		public EnvironmentController()
		{
		}

		[Address(RVA="0x1523444", Offset="0x1523444", VA="0x1523444")]
		private void EnvironmentLoaded(AssetHandle assetHandle)
		{
		}

		[Address(RVA="0x1523334", Offset="0x1523334", VA="0x1523334", Slot="7")]
		public void HandleDispatchAction(DEnvironmentMenuViewAction action)
		{
		}

		[Address(RVA="0x15231E8", Offset="0x15231E8", VA="0x15231E8", Slot="4")]
		public override void Initialize(Action finished)
		{
		}

		[Address(RVA="0x1523350", Offset="0x1523350", VA="0x1523350")]
		private void LoadEnvironment(string envAssetId)
		{
		}

		[Address(RVA="0x15232D4", Offset="0x15232D4", VA="0x15232D4", Slot="5")]
		public override void Shutdown()
		{
		}

		[Address(RVA="0x15233F4", Offset="0x15233F4", VA="0x15233F4")]
		private void UnloadEnvironment()
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1051218", Offset="0x1051218")]
		private sealed class <>c__DisplayClass0_0
		{
			[FieldOffset(Offset="0x10")]
			public Action finished;

			[Address(RVA="0x15232CC", Offset="0x15232CC", VA="0x15232CC")]
			public <>c__DisplayClass0_0()
			{
			}

			[Address(RVA="0x1523874", Offset="0x1523874", VA="0x1523874")]
			internal void <Initialize>b__0(Glunies.Inferno.EnvironmentView view)
			{
			}
		}
	}
}