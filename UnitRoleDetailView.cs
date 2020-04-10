using Gamedata;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UnitRoleDetailView : APressedPopupView
{
	[Attribute(Name="InjectAttribute", RVA="0x105F7A0", Offset="0x105F7A0")]
	[FieldOffset(Offset="0x70")]
	private GamedataDomainController _gamedataDC;

	private UnitRoleDetailView.SerializedFields Fields
	{
		[Address(RVA="0x150CB14", Offset="0x150CB14", VA="0x150CB14")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x150CBF4", Offset="0x150CBF4", VA="0x150CBF4")]
	public UnitRoleDetailView()
	{
	}

	[Address(RVA="0x150C7B8", Offset="0x150C7B8", VA="0x150C7B8")]
	public void SetUnit(Unit unit)
	{
	}

	[Serializable]
	public class SerializedFields : PressedPopupViewSerializedFields
	{
		[FieldOffset(Offset="0x30")]
		public Image RoleIcon;

		[FieldOffset(Offset="0x38")]
		public UiLabel RoleLabel;

		[FieldOffset(Offset="0x40")]
		public List<UnitRoleDetailView.UnitRole> UnitRoles;

		[FieldOffset(Offset="0x48")]
		public SpriteSheetNameLookup UnitRoleSpriteLookup;

		[Address(RVA="0x150CBFC", Offset="0x150CBFC", VA="0x150CBFC")]
		public SerializedFields()
		{
		}
	}

	[Serializable]
	public class UnitRole
	{
		[FieldOffset(Offset="0x10")]
		public string RoleIcon;

		[FieldOffset(Offset="0x18")]
		public UnityEngine.GameObject Detail;

		[Address(RVA="0x150CC04", Offset="0x150CC04", VA="0x150CC04")]
		public UnitRole()
		{
		}
	}
}