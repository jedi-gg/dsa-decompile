using Glunies;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

public class HelpshiftController : MonoBehaviour, ILoggable<LogCategory>, IDispatchHandler<DPlayerChangeAction>, IDispatchHandler, IDispatchHandler<DPlayerTotalSpendChangeAction>, IDispatchHandler<DHelpshiftShowAction>, IDispatchHandler<DPushNotificationTokenChangedAction>
{
	[FieldOffset(Offset="0x0")]
	private readonly static string HS_API_KEY;

	[FieldOffset(Offset="0x8")]
	private readonly static string HS_DOMAIN;

	[FieldOffset(Offset="0x10")]
	private readonly static string HS_APP_ID;

	[Attribute(Name="InjectAttribute", RVA="0x1058740", Offset="0x1058740")]
	[FieldOffset(Offset="0x18")]
	private RevSdkController _revSdk;

	[Attribute(Name="InjectAttribute", RVA="0x1058750", Offset="0x1058750")]
	[FieldOffset(Offset="0x20")]
	private DispatchSystem _dispatch;

	[Attribute(Name="InjectAttribute", RVA="0x1058760", Offset="0x1058760")]
	[FieldOffset(Offset="0x28")]
	private PlayerDomainController _playerDc;

	[Attribute(Name="InjectAttribute", RVA="0x1058770", Offset="0x1058770")]
	[FieldOffset(Offset="0x30")]
	private GamedataDomainController _gamedataDc;

	[Attribute(Name="InjectAttribute", RVA="0x1058780", Offset="0x1058780")]
	[FieldOffset(Offset="0x38")]
	private SharedPrefs _sharedPrefs;

	[Attribute(Name="InjectAttribute", RVA="0x1058790", Offset="0x1058790")]
	[FieldOffset(Offset="0x40")]
	private ANotificationController _notificationController;

	[FieldOffset(Offset="0x48")]
	private float _ltv;

	public LogCategory LogCategory
	{
		[Address(RVA="0x12E6C94", Offset="0x12E6C94", VA="0x12E6C94", Slot="4")]
		get
		{
			return new LogCategory();
		}
	}

	[Address(RVA="0x12E7DC0", Offset="0x12E7DC0", VA="0x12E7DC0")]
	static HelpshiftController()
	{
	}

	[Address(RVA="0x12E7DB8", Offset="0x12E7DB8", VA="0x12E7DB8")]
	public HelpshiftController()
	{
	}

	[Address(RVA="0x12E7D28", Offset="0x12E7D28", VA="0x12E7D28")]
	public void didReceiveUnreadMessagesCount(string count)
	{
	}

	[Address(RVA="0x12E7218", Offset="0x12E7218", VA="0x12E7218")]
	private Dictionary<string, object> GetMetadata(bool addGdprTag)
	{
		return null;
	}

	[Address(RVA="0x12E7BEC", Offset="0x12E7BEC", VA="0x12E7BEC", Slot="5")]
	public void HandleDispatchAction(DPlayerChangeAction playerChangeAction)
	{
	}

	[Address(RVA="0x12E7D14", Offset="0x12E7D14", VA="0x12E7D14", Slot="6")]
	public void HandleDispatchAction(DPlayerTotalSpendChangeAction action)
	{
	}

	[Address(RVA="0x12E7D1C", Offset="0x12E7D1C", VA="0x12E7D1C", Slot="7")]
	public void HandleDispatchAction(DHelpshiftShowAction action)
	{
	}

	[Address(RVA="0x12E7D24", Offset="0x12E7D24", VA="0x12E7D24", Slot="8")]
	public void HandleDispatchAction(DPushNotificationTokenChangedAction action)
	{
	}

	[Address(RVA="0x12E7DB4", Offset="0x12E7DB4", VA="0x12E7DB4")]
	public void helpshiftSessionEnded()
	{
	}

	[Address(RVA="0x12E6C9C", Offset="0x12E6C9C", VA="0x12E6C9C")]
	public void Initialize()
	{
	}

	[Address(RVA="0x12E7A88", Offset="0x12E7A88", VA="0x12E7A88")]
	public void RequestUnreadMessageCount()
	{
	}

	[Address(RVA="0x12E7B08", Offset="0x12E7B08", VA="0x12E7B08")]
	public void SetPlayerId(string playerId)
	{
	}

	[Address(RVA="0x12E6F40", Offset="0x12E6F40", VA="0x12E6F40")]
	private void SetPushToken()
	{
	}

	[Address(RVA="0x12E7028", Offset="0x12E7028", VA="0x12E7028")]
	public void ShowFaqs(bool addGdprTag = false)
	{
	}

	[Address(RVA="0x12E6FF0", Offset="0x12E6FF0", VA="0x12E6FF0")]
	public void Shutdown()
	{
	}
}