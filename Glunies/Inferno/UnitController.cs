using Glunies;
using Il2CppDummyDll;
using System;

namespace Glunies.Inferno
{
	public class UnitController : AInfernoController, IDispatchHandler<DUnitMenuViewAction>, IDispatchHandler
	{
		[FieldOffset(Offset="0x0")]
		private const string UNIT_SHADER_NAME = "Glunies/Unit";

		[Attribute(Name="InjectAttribute", RVA="0x1064B90", Offset="0x1064B90")]
		[FieldOffset(Offset="0x28")]
		private DispatchSystem _dispatchSystem;

		[Attribute(Name="InjectAttribute", RVA="0x1064BA0", Offset="0x1064BA0")]
		[FieldOffset(Offset="0x30")]
		private SingleAssetRegistry _unitAssetRegistry;

		private Glunies.Inferno.UnitView UnitView
		{
			[Address(RVA="0x15261B4", Offset="0x15261B4", VA="0x15261B4")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1526494", Offset="0x1526494", VA="0x1526494")]
		public UnitController()
		{
		}

		[Address(RVA="0x1525D48", Offset="0x1525D48", VA="0x1525D48", Slot="7")]
		public void HandleDispatchAction(DUnitMenuViewAction action)
		{
		}

		[Address(RVA="0x1525BFC", Offset="0x1525BFC", VA="0x1525BFC", Slot="4")]
		public override void Initialize(Action finished)
		{
		}

		[Address(RVA="0x1525D64", Offset="0x1525D64", VA="0x1525D64")]
		private void LoadUnit(string unitAssetId)
		{
		}

		[Address(RVA="0x1525CE8", Offset="0x1525CE8", VA="0x1525CE8", Slot="5")]
		public override void Shutdown()
		{
		}

		[Address(RVA="0x1525EA8", Offset="0x1525EA8", VA="0x1525EA8")]
		private void UnitLoaded(AssetHandle assetHandle)
		{
		}

		[Address(RVA="0x1525E08", Offset="0x1525E08", VA="0x1525E08")]
		private void UnloadUnit()
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1051278", Offset="0x1051278")]
		private sealed class <>c__DisplayClass0_0
		{
			[FieldOffset(Offset="0x10")]
			public Action finished;

			[Address(RVA="0x1525CE0", Offset="0x1525CE0", VA="0x1525CE0")]
			public <>c__DisplayClass0_0()
			{
			}

			[Address(RVA="0x152649C", Offset="0x152649C", VA="0x152649C")]
			internal void <Initialize>b__0(Glunies.Inferno.UnitView view)
			{
			}
		}
	}
}