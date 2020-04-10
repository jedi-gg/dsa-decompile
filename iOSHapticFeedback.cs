using Il2CppDummyDll;
using System;
using UnityEngine;

public class iOSHapticFeedback : MonoBehaviour
{
	[FieldOffset(Offset="0x0")]
	private static iOSHapticFeedback _instance;

	[FieldOffset(Offset="0x18")]
	public iOSHapticFeedback.iOSFeedbackTypeSettings usedFeedbackTypes;

	[FieldOffset(Offset="0x20")]
	private bool feedbackGeneratorsSetUp;

	[FieldOffset(Offset="0x21")]
	public bool debug;

	public static iOSHapticFeedback Instance
	{
		[Address(RVA="0x2340B94", Offset="0x2340B94", VA="0x2340B94")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x2341480", Offset="0x2341480", VA="0x2341480")]
	public iOSHapticFeedback()
	{
	}

	[Address(RVA="0x23410E8", Offset="0x23410E8", VA="0x23410E8")]
	private void _instantiateFeedbackGenerator(int id)
	{
	}

	[Address(RVA="0x23410EC", Offset="0x23410EC", VA="0x23410EC")]
	private void _prepareFeedbackGenerator(int id)
	{
	}

	[Address(RVA="0x23410F4", Offset="0x23410F4", VA="0x23410F4")]
	private void _releaseFeedbackGenerator(int id)
	{
	}

	[Address(RVA="0x23410F0", Offset="0x23410F0", VA="0x23410F0")]
	private void _triggerFeedbackGenerator(int id, bool advanced)
	{
	}

	[Address(RVA="0x2340CA8", Offset="0x2340CA8", VA="0x2340CA8", Slot="4")]
	protected virtual void Awake()
	{
	}

	[Address(RVA="0x2340E24", Offset="0x2340E24", VA="0x2340E24")]
	protected bool FeedbackIdSet(int id)
	{
		return new bool();
	}

	[Address(RVA="0x2340EF8", Offset="0x2340EF8", VA="0x2340EF8")]
	protected void InstantiateFeedbackGenerator(int id)
	{
	}

	[Address(RVA="0x2341478", Offset="0x2341478", VA="0x2341478")]
	public bool IsSupported()
	{
		return new bool();
	}

	[Address(RVA="0x2340FB4", Offset="0x2340FB4", VA="0x2340FB4")]
	protected void OnDestroy()
	{
	}

	[Address(RVA="0x23410F8", Offset="0x23410F8", VA="0x23410F8")]
	protected void PrepareFeedbackGenerator(int id)
	{
	}

	[Address(RVA="0x2341004", Offset="0x2341004", VA="0x2341004")]
	protected void ReleaseFeedbackGenerator(int id)
	{
	}

	[Address(RVA="0x23413D0", Offset="0x23413D0", VA="0x23413D0", Slot="5")]
	public virtual void Trigger(iOSHapticFeedback.iOSFeedbackType feedbackType)
	{
	}

	[Address(RVA="0x23411B4", Offset="0x23411B4", VA="0x23411B4")]
	protected void TriggerFeedbackGenerator(int id, bool advanced)
	{
	}

	public enum iOSFeedbackType
	{
		[FieldOffset(Offset="0x0")]
		SelectionChange,
		[FieldOffset(Offset="0x0")]
		ImpactLight,
		[FieldOffset(Offset="0x0")]
		ImpactMedium,
		[FieldOffset(Offset="0x0")]
		ImpactHeavy,
		[FieldOffset(Offset="0x0")]
		Success,
		[FieldOffset(Offset="0x0")]
		Warning,
		[FieldOffset(Offset="0x0")]
		Failure,
		[FieldOffset(Offset="0x0")]
		None
	}

	[Serializable]
	public class iOSFeedbackTypeSettings
	{
		[FieldOffset(Offset="0x10")]
		public bool SelectionChange;

		[FieldOffset(Offset="0x11")]
		public bool ImpactLight;

		[FieldOffset(Offset="0x12")]
		public bool ImpactMedium;

		[FieldOffset(Offset="0x13")]
		public bool ImpactHeavy;

		[FieldOffset(Offset="0x14")]
		public bool NotificationSuccess;

		[FieldOffset(Offset="0x15")]
		public bool NotificationWarning;

		[FieldOffset(Offset="0x16")]
		public bool NotificationFailure;

		public bool Notifications
		{
			[Address(RVA="0x23410C0", Offset="0x23410C0", VA="0x23410C0")]
			get
			{
				return new bool();
			}
		}

		[Address(RVA="0x234150C", Offset="0x234150C", VA="0x234150C")]
		public iOSFeedbackTypeSettings()
		{
		}
	}
}