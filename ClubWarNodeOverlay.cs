using Gamedata;
using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[Attribute(Name="RequireComponent", RVA="0x10488A0", Offset="0x10488A0")]
public class ClubWarNodeOverlay : MonoBehaviour, ILoggable<LogCategory>
{
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1056E48", Offset="0x1056E48")]
	[FieldOffset(Offset="0x18")]
	private string <Id>k__BackingField;

	[FieldOffset(Offset="0x20")]
	[SerializeField]
	private Button _button;

	[FieldOffset(Offset="0x28")]
	[SerializeField]
	private UiInputSquish _buttonSquish;

	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private GameObject _targetRoot;

	[FieldOffset(Offset="0x38")]
	[SerializeField]
	private ClubWarHealthBar _healthBar;

	[FieldOffset(Offset="0x40")]
	private Camera _mainCamera;

	[FieldOffset(Offset="0x48")]
	private Transform _followTarget;

	public string Id
	{
		[Address(RVA="0x14D0DD8", Offset="0x14D0DD8", VA="0x14D0DD8")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106F1F4", Offset="0x106F1F4")]
		get
		{
			return null;
		}
		[Address(RVA="0x14D0DE0", Offset="0x14D0DE0", VA="0x14D0DE0")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106F204", Offset="0x106F204")]
		private set
		{
		}
	}

	public LogCategory LogCategory
	{
		[Address(RVA="0x14D0DD0", Offset="0x14D0DD0", VA="0x14D0DD0", Slot="4")]
		get
		{
			return new LogCategory();
		}
	}

	[Address(RVA="0x14D1290", Offset="0x14D1290", VA="0x14D1290")]
	public ClubWarNodeOverlay()
	{
	}

	[Address(RVA="0x14D0DE8", Offset="0x14D0DE8", VA="0x14D0DE8")]
	public void Initialize(string nodeId, Camera mainCamera, Transform followTarget, string idLabel, UnityAction clickHandler)
	{
	}

	[Address(RVA="0x14D1138", Offset="0x14D1138", VA="0x14D1138")]
	private void LateUpdate()
	{
	}

	[Address(RVA="0x14D0F5C", Offset="0x14D0F5C", VA="0x14D0F5C")]
	public void SetSummaryData(Serverproto.ClubWar.Types.NodeSummary nodeSummary, ClubWarNodeType nodeType)
	{
	}

	[Address(RVA="0x14D0EAC", Offset="0x14D0EAC", VA="0x14D0EAC")]
	public void SetTargeted(bool targeted)
	{
	}

	[Address(RVA="0x14D10EC", Offset="0x14D10EC", VA="0x14D10EC")]
	public void Shutdown()
	{
	}
}