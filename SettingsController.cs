using Glunies;
using Il2CppDummyDll;
using System;

public class SettingsController : APopupController, IDispatchHandler<DSettingsViewAction>, IDispatchHandler
{
	[Attribute(Name="InjectAttribute", RVA="0x105C220", Offset="0x105C220")]
	[FieldOffset(Offset="0x38")]
	private GamedataDomainController _gamedataDc;

	[Attribute(Name="InjectAttribute", RVA="0x105C230", Offset="0x105C230")]
	[FieldOffset(Offset="0x40")]
	private HelpshiftController _helpshiftController;

	[Attribute(Name="InjectAttribute", RVA="0x105C240", Offset="0x105C240")]
	[FieldOffset(Offset="0x48")]
	private RevSdkController _revSdk;

	[Address(RVA="0x14B90F4", Offset="0x14B90F4", VA="0x14B90F4")]
	public SettingsController()
	{
	}

	[Address(RVA="0x14B8F38", Offset="0x14B8F38", VA="0x14B8F38", Slot="14")]
	public void HandleDispatchAction(DSettingsViewAction action)
	{
	}

	[Address(RVA="0x14B8E34", Offset="0x14B8E34", VA="0x14B8E34", Slot="8")]
	public override void Initialize(ITransitionContext context, Action completed)
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104C93C", Offset="0x104C93C")]
	private sealed class <>c__DisplayClass0_0
	{
		[FieldOffset(Offset="0x10")]
		public Action completed;

		[Address(RVA="0x14B8F30", Offset="0x14B8F30", VA="0x14B8F30")]
		public <>c__DisplayClass0_0()
		{
		}

		[Address(RVA="0x14B90FC", Offset="0x14B90FC", VA="0x14B90FC")]
		internal void <Initialize>b__0(SettingsView view)
		{
		}
	}
}