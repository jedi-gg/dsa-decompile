using Gamedata;
using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;
using Zenject;

public class PinPageItemData
{
	[FieldOffset(Offset="0x10")]
	private Gamedata.PinPageItem? _pinPageItem;

	[FieldOffset(Offset="0x28")]
	private Gamedata.InventoryItem? _inventoryItem;

	[FieldOffset(Offset="0x40")]
	private Serverproto.PlayerActivity _achievement;

	[FieldOffset(Offset="0x48")]
	private bool _pinOwned;

	[FieldOffset(Offset="0x50")]
	private string _name;

	[FieldOffset(Offset="0x58")]
	private string _description;

	public Serverproto.PlayerActivity Achievement
	{
		[Address(RVA="0x1411018", Offset="0x1411018", VA="0x1411018")]
		get
		{
			return null;
		}
	}

	public string Description
	{
		[Address(RVA="0x1411180", Offset="0x1411180", VA="0x1411180")]
		get
		{
			return null;
		}
	}

	public Gamedata.InventoryItem? InventoryItem
	{
		[Address(RVA="0x1410120", Offset="0x1410120", VA="0x1410120")]
		get
		{
			return null;
		}
	}

	public bool Mystery
	{
		[Address(RVA="0x14110C0", Offset="0x14110C0", VA="0x14110C0")]
		get
		{
			return new bool();
		}
	}

	public string Name
	{
		[Address(RVA="0x1411178", Offset="0x1411178", VA="0x1411178")]
		get
		{
			return null;
		}
	}

	public bool ObscureIcon
	{
		[Address(RVA="0x1410F34", Offset="0x1410F34", VA="0x1410F34")]
		get
		{
			return new bool();
		}
	}

	public bool PinOwned
	{
		[Address(RVA="0x1410FEC", Offset="0x1410FEC", VA="0x1410FEC")]
		get
		{
			return new bool();
		}
	}

	public Gamedata.PinPageItem? PinPageItem
	{
		[Address(RVA="0x14110AC", Offset="0x14110AC", VA="0x14110AC")]
		get
		{
			return null;
		}
	}

	public bool ShowAchievement
	{
		[Address(RVA="0x1410FF4", Offset="0x1410FF4", VA="0x1410FF4")]
		get
		{
			return new bool();
		}
	}

	[Address(RVA="0x1411188", Offset="0x1411188", VA="0x1411188")]
	public PinPageItemData()
	{
	}

	public class Factory : IFactory<PinPageItemData>, IFactory
	{
		[Address(RVA="0x140D6EC", Offset="0x140D6EC", VA="0x140D6EC")]
		public Factory()
		{
		}

		[Address(RVA="0x1411190", Offset="0x1411190", VA="0x1411190", Slot="4")]
		public PinPageItemData Create()
		{
			return null;
		}
	}

	public class Pool : MemoryPool<Gamedata.PinPageItem?, Gamedata.InventoryItem?, PinPageItemData>
	{
		[Attribute(Name="InjectAttribute", RVA="0x106B3DC", Offset="0x106B3DC")]
		[FieldOffset(Offset="0x30")]
		private PlayerDomainController _playerDC;

		[Attribute(Name="InjectAttribute", RVA="0x106B3EC", Offset="0x106B3EC")]
		[FieldOffset(Offset="0x38")]
		private LocalizationManager _lm;

		[Address(RVA="0x1411450", Offset="0x1411450", VA="0x1411450")]
		public Pool()
		{
		}

		[Address(RVA="0x14111EC", Offset="0x14111EC", VA="0x14111EC", Slot="15")]
		protected override void Reinitialize(Gamedata.PinPageItem? pinPageItem, Gamedata.InventoryItem? inventoryItem, PinPageItemData data)
		{
		}
	}
}