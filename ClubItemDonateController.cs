using Glunies;
using Google.Protobuf;
using Il2CppDummyDll;
using Serverproto;
using System;
using System.Collections.Generic;

public class ClubItemDonateController : AFeatureController, IDispatchHandler<DClubItemDonateListItemAction>, IDispatchHandler, IDispatchHandler<DClubItemDonatedAction>, IDispatchHandler<DClubSupportRequestListItemAction>, IDispatchHandler<DClubItemDonateViewAction>
{
	[Attribute(Name="InjectAttribute", RVA="0x1056168", Offset="0x1056168")]
	[FieldOffset(Offset="0x68")]
	private BadgingController _badgingController;

	[Attribute(Name="InjectAttribute", RVA="0x1056178", Offset="0x1056178")]
	[FieldOffset(Offset="0x70")]
	private ClubServiceUtility _clubServiceUtility;

	[Attribute(Name="InjectAttribute", RVA="0x1056188", Offset="0x1056188")]
	[FieldOffset(Offset="0x78")]
	private ClubService _clubService;

	[Attribute(Name="InjectAttribute", RVA="0x1056198", Offset="0x1056198")]
	[FieldOffset(Offset="0x80")]
	private PlayerDomainController _playerDc;

	[Attribute(Name="InjectAttribute", RVA="0x10561A8", Offset="0x10561A8")]
	[FieldOffset(Offset="0x88")]
	private LocalizationManager _lm;

	[FieldOffset(Offset="0x90")]
	private ClubItemDonateView _view;

	[FieldOffset(Offset="0x98")]
	private Club _club;

	[FieldOffset(Offset="0xA0")]
	private List<ClubItemDonateController.AClubRequestModel> _clubRequests;

	[Address(RVA="0x1255EA4", Offset="0x1255EA4", VA="0x1255EA4")]
	public ClubItemDonateController()
	{
	}

	[Address(RVA="0x1254EB4", Offset="0x1254EB4", VA="0x1254EB4", Slot="10")]
	protected override GameStateTransitionContext CreateContext()
	{
		return null;
	}

	[Address(RVA="0x1253510", Offset="0x1253510", VA="0x1253510", Slot="13")]
	public void HandleDispatchAction(DClubItemDonateListItemAction action)
	{
	}

	[Address(RVA="0x1253E1C", Offset="0x1253E1C", VA="0x1253E1C", Slot="14")]
	public void HandleDispatchAction(DClubItemDonatedAction action)
	{
	}

	[Address(RVA="0x12543A0", Offset="0x12543A0", VA="0x12543A0", Slot="15")]
	public void HandleDispatchAction(DClubSupportRequestListItemAction action)
	{
	}

	[Address(RVA="0x12549A8", Offset="0x12549A8", VA="0x12549A8", Slot="16")]
	public void HandleDispatchAction(DClubItemDonateViewAction action)
	{
	}

	[Address(RVA="0x1253218", Offset="0x1253218", VA="0x1253218", Slot="6")]
	public override void Initialize(GameStateTransitionContext context)
	{
	}

	[Address(RVA="0x1255070", Offset="0x1255070", VA="0x1255070")]
	private void InitializeFeature(GameStateTransitionContext context)
	{
	}

	[Address(RVA="0x1254F8C", Offset="0x1254F8C", VA="0x1254F8C")]
	private void LoadView(Action finished)
	{
	}

	[Address(RVA="0x1254F1C", Offset="0x1254F1C", VA="0x1254F1C")]
	private void ReloadState()
	{
	}

	[Address(RVA="0x1255B9C", Offset="0x1255B9C", VA="0x1255B9C")]
	private void RemoveAllSupportRequests()
	{
	}

	[Address(RVA="0x125488C", Offset="0x125488C", VA="0x125488C")]
	private void RemoveSupportRequest(ClubItemDonateController.ClubSupportRequestModel supportRequestModel, bool fulfilled)
	{
	}

	[Address(RVA="0x1255DF8", Offset="0x1255DF8", VA="0x1255DF8")]
	private int SortClubRequests(ClubItemDonateController.AClubRequestModel x, ClubItemDonateController.AClubRequestModel y)
	{
		return new int();
	}

	[Address(RVA="0x1253498", Offset="0x1253498", VA="0x1253498", Slot="8")]
	public override void TickUpdate()
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104B6AC", Offset="0x104B6AC")]
	private sealed class <>c__DisplayClass0_0
	{
		[FieldOffset(Offset="0x10")]
		public ClubItemDonateController <>4__this;

		[FieldOffset(Offset="0x18")]
		public GameStateTransitionContext context;

		[FieldOffset(Offset="0x20")]
		public Action<ClubResponse> <>9__2;

		[Address(RVA="0x1253490", Offset="0x1253490", VA="0x1253490")]
		public <>c__DisplayClass0_0()
		{
		}

		[Address(RVA="0x1255EAC", Offset="0x1255EAC", VA="0x1255EAC")]
		internal void <Initialize>b__0(Action finished)
		{
		}

		[Address(RVA="0x125612C", Offset="0x125612C", VA="0x125612C")]
		internal void <Initialize>b__1()
		{
		}

		[Address(RVA="0x12560E0", Offset="0x12560E0", VA="0x12560E0")]
		internal void <Initialize>b__2(ClubResponse response)
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104B6BC", Offset="0x104B6BC")]
	private sealed class <>c__DisplayClass0_1
	{
		[FieldOffset(Offset="0x10")]
		public ClubRequest clubRequest;

		[FieldOffset(Offset="0x18")]
		public ClubItemDonateController.<>c__DisplayClass0_0 CS$<>8__locals1;

		[Address(RVA="0x12560D8", Offset="0x12560D8", VA="0x12560D8")]
		public <>c__DisplayClass0_1()
		{
		}

		[Address(RVA="0x12561DC", Offset="0x12561DC", VA="0x12561DC")]
		internal void <Initialize>b__3(long errorCode)
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104B6CC", Offset="0x104B6CC")]
	private sealed class <>c__DisplayClass3_0
	{
		[FieldOffset(Offset="0x10")]
		public DClubItemDonatedAction action;

		[Address(RVA="0x1253FA0", Offset="0x1253FA0", VA="0x1253FA0")]
		public <>c__DisplayClass3_0()
		{
		}

		[Address(RVA="0x12562DC", Offset="0x12562DC", VA="0x12562DC")]
		internal bool <HandleDispatchAction>b__0(ClubItemDonateController.AClubRequestModel r)
		{
			return new bool();
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104B6DC", Offset="0x104B6DC")]
	private sealed class <>c__DisplayClass4_0
	{
		[FieldOffset(Offset="0x10")]
		public ClubItemDonateController <>4__this;

		[FieldOffset(Offset="0x18")]
		public DClubSupportRequestListItemAction action;

		[Address(RVA="0x1254584", Offset="0x1254584", VA="0x1254584")]
		public <>c__DisplayClass4_0()
		{
		}

		[Address(RVA="0x1256460", Offset="0x1256460", VA="0x1256460")]
		internal void <HandleDispatchAction>b__0()
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104B6EC", Offset="0x104B6EC")]
	private sealed class <>c__DisplayClass8_0
	{
		[FieldOffset(Offset="0x10")]
		public ClubItemDonateController <>4__this;

		[FieldOffset(Offset="0x18")]
		public Action finished;

		[Address(RVA="0x1255068", Offset="0x1255068", VA="0x1255068")]
		public <>c__DisplayClass8_0()
		{
		}

		[Address(RVA="0x1256498", Offset="0x1256498", VA="0x1256498")]
		internal void <LoadView>b__0(ClubItemDonateView view)
		{
		}
	}

	public abstract class AClubRequestModel
	{
		[FieldOffset(Offset="0x10")]
		public readonly bool IsLocalPlayer;

		public abstract DateTime Expiry
		{
			get;
		}

		public abstract ByteString Id
		{
			get;
		}

		public abstract PlayerProfileSimple Owner
		{
			get;
		}

		[Address(RVA="0x12564F0", Offset="0x12564F0", VA="0x12564F0")]
		public AClubRequestModel(bool isLocalPlayer)
		{
		}
	}

	public class ClubItemRequestModel : ClubItemDonateController.AClubRequestModel
	{
		[FieldOffset(Offset="0x18")]
		public readonly ClubItemRequest Data;

		public ulong DonationCapacity
		{
			[Address(RVA="0x1256430", Offset="0x1256430", VA="0x1256430")]
			get
			{
				return new ulong();
			}
		}

		public ulong DonationCount
		{
			[Address(RVA="0x1256400", Offset="0x1256400", VA="0x1256400")]
			get
			{
				return new ulong();
			}
		}

		public override DateTime Expiry
		{
			[Address(RVA="0x1256580", Offset="0x1256580", VA="0x1256580", Slot="6")]
			get
			{
				return new DateTime();
			}
		}

		public override ByteString Id
		{
			[Address(RVA="0x1256520", Offset="0x1256520", VA="0x1256520", Slot="4")]
			get
			{
				return null;
			}
		}

		public ulong ItemId
		{
			[Address(RVA="0x125660C", Offset="0x125660C", VA="0x125660C")]
			get
			{
				return new ulong();
			}
		}

		public override PlayerProfileSimple Owner
		{
			[Address(RVA="0x1256550", Offset="0x1256550", VA="0x1256550", Slot="5")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1255B1C", Offset="0x1255B1C", VA="0x1255B1C")]
		public ClubItemRequestModel(ClubItemRequest data, bool isLocalPlayer)
		{
		}
	}

	public class ClubSupportRequestModel : ClubItemDonateController.AClubRequestModel
	{
		[FieldOffset(Offset="0x18")]
		public readonly ClubSupportRequest Data;

		public override DateTime Expiry
		{
			[Address(RVA="0x125669C", Offset="0x125669C", VA="0x125669C", Slot="6")]
			get
			{
				return new DateTime();
			}
		}

		public override ByteString Id
		{
			[Address(RVA="0x125663C", Offset="0x125663C", VA="0x125663C", Slot="4")]
			get
			{
				return null;
			}
		}

		public override PlayerProfileSimple Owner
		{
			[Address(RVA="0x125666C", Offset="0x125666C", VA="0x125666C", Slot="5")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1255B5C", Offset="0x1255B5C", VA="0x1255B5C")]
		public ClubSupportRequestModel(ClubSupportRequest data, bool isLocalPlayer)
		{
		}
	}
}