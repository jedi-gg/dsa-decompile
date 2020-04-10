using Glunies;
using Il2CppDummyDll;
using System;

public class StoreGameState : AGameState
{
	[Address(RVA="0x122F6A4", Offset="0x122F6A4", VA="0x122F6A4")]
	public StoreGameState()
	{
	}

	[Address(RVA="0x122F644", Offset="0x122F644", VA="0x122F644", Slot="4")]
	public override void Entering(ITransitionContext context)
	{
	}

	public class Context : GameStateTransitionContext
	{
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106BDBC", Offset="0x106BDBC")]
		[FieldOffset(Offset="0x20")]
		private StoreData <StoreData>k__BackingField;

		public StoreData StoreData
		{
			[Address(RVA="0x1227C68", Offset="0x1227C68", VA="0x1227C68")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108B89C", Offset="0x108B89C")]
			get
			{
				return null;
			}
			[Address(RVA="0x122A7BC", Offset="0x122A7BC", VA="0x122A7BC")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108B8AC", Offset="0x108B8AC")]
			set
			{
			}
		}

		[Address(RVA="0x1227C60", Offset="0x1227C60", VA="0x1227C60")]
		public Context()
		{
		}
	}

	public class DeepLinkToItemContext : StoreGameState.Context
	{
		[FieldOffset(Offset="0x28")]
		public readonly ulong ItemId;

		[Address(RVA="0x122A764", Offset="0x122A764", VA="0x122A764")]
		public DeepLinkToItemContext(ulong itemId)
		{
		}
	}

	public class DeepLinkToTabContext : StoreGameState.Context
	{
		[FieldOffset(Offset="0x28")]
		public ulong TabId;

		[Address(RVA="0x122A790", Offset="0x122A790", VA="0x122A790")]
		public DeepLinkToTabContext(ulong tabId)
		{
		}
	}

	public class NavigateToFirstStoreItemWithCostId : StoreGameState.Context
	{
		[FieldOffset(Offset="0x28")]
		public readonly ulong CostItemId;

		[Address(RVA="0x122F6AC", Offset="0x122F6AC", VA="0x122F6AC")]
		public NavigateToFirstStoreItemWithCostId(ulong costItemId)
		{
		}
	}

	public class PurchaseFirstItemOnTabContext : StoreGameState.DeepLinkToTabContext
	{
		[Address(RVA="0x122F6D8", Offset="0x122F6D8", VA="0x122F6D8")]
		public PurchaseFirstItemOnTabContext(ulong tabId)
		{
		}
	}

	public class PurchaseItemContext : StoreGameState.Context
	{
		[FieldOffset(Offset="0x28")]
		public readonly ulong ItemId;

		[FieldOffset(Offset="0x30")]
		public readonly string TelemetryItemLocation;

		[FieldOffset(Offset="0x38")]
		public readonly ulong CostItemId;

		[Address(RVA="0x122F704", Offset="0x122F704", VA="0x122F704")]
		public PurchaseItemContext(ulong itemId, string telemetryItemLocation, ulong costItemId = 0L)
		{
		}
	}
}