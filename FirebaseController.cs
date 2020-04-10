using Firebase;
using Firebase.Messaging;
using Glunies;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class FirebaseController : ILoggable<LogCategory>, IDispatchHandler<DPlayerChangeAction>, IDispatchHandler, IDispatchHandler<DSetLogMetadataAction>, IDispatchHandler<DClearLogMetadataAction>, IDispatchHandler<DFirebaseLogEventAction>, IDispatchHandler<DFatalAction>
{
	[Attribute(Name="InjectAttribute", RVA="0x10584C0", Offset="0x10584C0")]
	[FieldOffset(Offset="0x10")]
	private ANotificationController _notificationController;

	[Attribute(Name="InjectAttribute", RVA="0x10584D0", Offset="0x10584D0")]
	[FieldOffset(Offset="0x18")]
	private DispatchSystem _dispatch;

	[FieldOffset(Offset="0x20")]
	private FirebaseApp _firebaseApp;

	[FieldOffset(Offset="0x28")]
	private HashSet<string> _transientMetadataKeys;

	public LogCategory LogCategory
	{
		[Address(RVA="0x12C9328", Offset="0x12C9328", VA="0x12C9328", Slot="4")]
		get
		{
			return new LogCategory();
		}
	}

	[Address(RVA="0x12C9F68", Offset="0x12C9F68", VA="0x12C9F68")]
	public FirebaseController()
	{
	}

	[Address(RVA="0x12C9FD8", Offset="0x12C9FD8", VA="0x12C9FD8")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106F7A4", Offset="0x106F7A4")]
	private void <Initialize>b__2_0(Task<DependencyStatus> task)
	{
	}

	[Address(RVA="0x12C9E7C", Offset="0x12C9E7C", VA="0x12C9E7C")]
	private void FcmMessageReceivedHandler(object sender, MessageReceivedEventArgs e)
	{
	}

	[Address(RVA="0x12C9D84", Offset="0x12C9D84", VA="0x12C9D84")]
	private void FcmTokenReceivedHandler(object sender, TokenReceivedEventArgs token)
	{
	}

	[Address(RVA="0x12C9998", Offset="0x12C9998", VA="0x12C9998", Slot="5")]
	public void HandleDispatchAction(DPlayerChangeAction action)
	{
	}

	[Address(RVA="0x12C99C8", Offset="0x12C99C8", VA="0x12C99C8", Slot="6")]
	public void HandleDispatchAction(DSetLogMetadataAction action)
	{
	}

	[Address(RVA="0x12C9A9C", Offset="0x12C9A9C", VA="0x12C9A9C", Slot="7")]
	public void HandleDispatchAction(DClearLogMetadataAction action)
	{
	}

	[Address(RVA="0x12C9C04", Offset="0x12C9C04", VA="0x12C9C04", Slot="8")]
	public void HandleDispatchAction(DFirebaseLogEventAction action)
	{
	}

	[Address(RVA="0x12C9C50", Offset="0x12C9C50", VA="0x12C9C50", Slot="9")]
	public void HandleDispatchAction(DFatalAction action)
	{
	}

	[Address(RVA="0x12C9F50", Offset="0x12C9F50", VA="0x12C9F50")]
	private void HandleUnityLogThreaded(string logString, string stackTrace, LogType type)
	{
	}

	[Address(RVA="0x12C9330", Offset="0x12C9330", VA="0x12C9330")]
	public void Initialize()
	{
	}

	[Address(RVA="0x12C95CC", Offset="0x12C95CC", VA="0x12C95CC")]
	public void LogEvent(string name, string parameterName, double parameterValue)
	{
	}

	[Address(RVA="0x12C9764", Offset="0x12C9764", VA="0x12C9764")]
	public void LogEvent(string name, string parameterName, string parameterValue)
	{
	}

	[Address(RVA="0x12C946C", Offset="0x12C946C", VA="0x12C946C")]
	public void Shutdown()
	{
	}
}