using Glunies;
using Il2CppDummyDll;
using System;

public class BattleFlyingTextView : AStandardView, IDispatchHandler<DBattleDamageAction>, IDispatchHandler, IDispatchHandler<DBattleFlyingTextAction>, IDispatchHandler<DBattleDamageNumbersSettingChangedAction>
{
	[FieldOffset(Offset="0x0")]
	private const int INITIAL_FLYING_TEXT_POOL_SIZE = 20;

	[Attribute(Name="InjectAttribute", RVA="0x1053534", Offset="0x1053534")]
	[FieldOffset(Offset="0x68")]
	private DispatchSystem _dispatch;

	[Attribute(Name="InjectAttribute", RVA="0x1053544", Offset="0x1053544")]
	[FieldOffset(Offset="0x70")]
	private SharedPrefs _sharedPrefs;

	[FieldOffset(Offset="0x78")]
	private MonoArchetypePool<BattleFlyingText> _flyingTextPool;

	[FieldOffset(Offset="0x80")]
	private string _localizedCrit;

	[FieldOffset(Offset="0x88")]
	private string _localizedStrong;

	[FieldOffset(Offset="0x90")]
	private string _localizedWeak;

	[FieldOffset(Offset="0x98")]
	private string _emptyHeader;

	[FieldOffset(Offset="0xA0")]
	private bool _showDamageNumbers;

	private BattleFlyingTextView.SerializedFields Fields
	{
		[Address(RVA="0x11481A0", Offset="0x11481A0", VA="0x11481A0")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x114830C", Offset="0x114830C", VA="0x114830C")]
	public BattleFlyingTextView()
	{
	}

	[Address(RVA="0x1147E94", Offset="0x1147E94", VA="0x1147E94")]
	public void Clear()
	{
	}

	[Address(RVA="0x1147A38", Offset="0x1147A38", VA="0x1147A38", Slot="21")]
	public void HandleDispatchAction(DBattleDamageAction action)
	{
	}

	[Address(RVA="0x1147C4C", Offset="0x1147C4C", VA="0x1147C4C", Slot="22")]
	public void HandleDispatchAction(DBattleFlyingTextAction action)
	{
	}

	[Address(RVA="0x1147D10", Offset="0x1147D10", VA="0x1147D10", Slot="23")]
	public void HandleDispatchAction(DBattleDamageNumbersSettingChangedAction action)
	{
	}

	[Address(RVA="0x1147B70", Offset="0x1147B70", VA="0x1147B70")]
	private BattleFlyingText SpawnFlyingText()
	{
		return null;
	}

	[Address(RVA="0x1147D84", Offset="0x1147D84", VA="0x1147D84")]
	public void TickUpdate()
	{
	}

	[Address(RVA="0x1147F7C", Offset="0x1147F7C", VA="0x1147F7C", Slot="11")]
	protected override void ViewAssetLoaded()
	{
	}

	[Address(RVA="0x1148280", Offset="0x1148280", VA="0x1148280", Slot="12")]
	protected override void ViewShuttingDown()
	{
	}

	[Serializable]
	public class SerializedFields : ViewSerializedFields
	{
		[FieldOffset(Offset="0x28")]
		public BattleFlyingText FlyingTextArchetype;

		[Address(RVA="0x1148380", Offset="0x1148380", VA="0x1148380")]
		public SerializedFields()
		{
		}
	}
}