using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace UTNotifications
{
	public abstract class Manager : MonoBehaviour
	{
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1060A94", Offset="0x1060A94")]
		[FieldOffset(Offset="0x18")]
		private Manager.OnInitializedHandler OnInitialized;

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1060AA4", Offset="0x1060AA4")]
		[FieldOffset(Offset="0x20")]
		private Manager.OnSendRegistrationIdHandler OnSendRegistrationId;

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1060AB4", Offset="0x1060AB4")]
		[FieldOffset(Offset="0x28")]
		private Manager.OnNotificationClickedHandler OnNotificationClicked;

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1060AC4", Offset="0x1060AC4")]
		[FieldOffset(Offset="0x30")]
		private Manager.OnNotificationsReceivedHandler OnNotificationsReceived;

		[FieldOffset(Offset="0x0")]
		private static Manager m_instance;

		[FieldOffset(Offset="0x8")]
		private static bool m_destroyed;

		[FieldOffset(Offset="0x38")]
		private bool m_initialized;

		public bool Initialized
		{
			[Address(RVA="0x1445FC0", Offset="0x1445FC0", VA="0x1445FC0")]
			get
			{
				return new bool();
			}
			[Address(RVA="0x1445FC8", Offset="0x1445FC8", VA="0x1445FC8")]
			protected set
			{
			}
		}

		public static Manager Instance
		{
			[Address(RVA="0x1445DE4", Offset="0x1445DE4", VA="0x1445DE4")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1448500", Offset="0x1448500", VA="0x1448500")]
		static Manager()
		{
		}

		[Address(RVA="0x14484F8", Offset="0x14484F8", VA="0x14484F8")]
		protected Manager()
		{
		}

		[Address(RVA="0x1447448", Offset="0x1447448", VA="0x1447448")]
		protected void _OnNotificationClicked(ReceivedNotification notification)
		{
		}

		[Address(RVA="0x1447BC0", Offset="0x1447BC0", VA="0x1447BC0")]
		protected void _OnNotificationsReceived(IList<ReceivedNotification> receivedNotifications)
		{
		}

		[Address(RVA="0x1446C74", Offset="0x1446C74", VA="0x1446C74")]
		protected void _OnSendRegistrationId(string providerName, string registrationId)
		{
		}

		public abstract void CancelAllNotifications();

		public abstract void CancelNotification(int id);

		[Address(RVA="0x1448468", Offset="0x1448468", VA="0x1448468")]
		protected bool CheckInitialized()
		{
			return new bool();
		}

		public abstract int GetBadge();

		public abstract void HideAllNotifications();

		public abstract void HideNotification(int id);

		public abstract bool Initialize(bool willHandleReceivedNotifications, int startId = 0, bool incrementalId = false);

		[Address(RVA="0x1445E50", Offset="0x1445E50", VA="0x1445E50")]
		private static void InstanceRequired()
		{
		}

		public abstract bool NotificationsAllowed();

		public abstract bool NotificationsEnabled();

		[Address(RVA="0x14483A0", Offset="0x14483A0", VA="0x14483A0")]
		protected void NotSupported(string feature = // 
		// Current member / type: System.Void UTNotifications.Manager::NotSupported(System.String)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: System.Void NotSupported(System.String)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x1448328", Offset="0x1448328", VA="0x1448328", Slot="19")]
		protected virtual void OnDestroy()
		{
		}

		[Address(RVA="0x1447438", Offset="0x1447438", VA="0x1447438")]
		protected bool OnNotificationClickedHasSubscribers()
		{
			return new bool();
		}

		[Address(RVA="0x1447BB0", Offset="0x1447BB0", VA="0x1447BB0")]
		protected bool OnNotificationsReceivedHasSubscribers()
		{
			return new bool();
		}

		[Address(RVA="0x1446C64", Offset="0x1446C64", VA="0x1446C64")]
		protected bool OnSendRegistrationIdHasSubscribers()
		{
			return new bool();
		}

		public abstract void PostLocalNotification(string title, string text, int id, IDictionary<string, string> userData = // 
		// Current member / type: System.Void UTNotifications.Manager::PostLocalNotification(System.String,System.String,System.Int32,System.Collections.Generic.IDictionary`2<System.String,System.String>,System.String,System.Int32,System.Collections.Generic.ICollection`1<UTNotifications.Button>)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: System.Void PostLocalNotification(System.String,System.String,System.Int32,System.Collections.Generic.IDictionary<System.String,System.String>,System.String,System.Int32,System.Collections.Generic.ICollection<UTNotifications.Button>)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		public abstract bool PushNotificationsEnabled();

		public abstract void ScheduleNotification(int triggerInSeconds, string title, string text, int id, IDictionary<string, string> userData = // 
		// Current member / type: System.Void UTNotifications.Manager::ScheduleNotification(System.Int32,System.String,System.String,System.Int32,System.Collections.Generic.IDictionary`2<System.String,System.String>,System.String,System.Int32,System.Collections.Generic.ICollection`1<UTNotifications.Button>)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: System.Void ScheduleNotification(System.Int32,System.String,System.String,System.Int32,System.Collections.Generic.IDictionary<System.String,System.String>,System.String,System.Int32,System.Collections.Generic.ICollection<UTNotifications.Button>)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x14463E4", Offset="0x14463E4", VA="0x14463E4")]
		public void ScheduleNotification(DateTime triggerDateTime, string title, string text, int id, IDictionary<string, string> userData = // 
		// Current member / type: System.Void UTNotifications.Manager::ScheduleNotification(System.DateTime,System.String,System.String,System.Int32,System.Collections.Generic.IDictionary`2<System.String,System.String>,System.String,System.Int32,System.Collections.Generic.ICollection`1<UTNotifications.Button>)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: System.Void ScheduleNotification(System.DateTime,System.String,System.String,System.Int32,System.Collections.Generic.IDictionary<System.String,System.String>,System.String,System.Int32,System.Collections.Generic.ICollection<UTNotifications.Button>)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		public abstract void ScheduleNotificationRepeating(int firstTriggerInSeconds, int intervalSeconds, string title, string text, int id, IDictionary<string, string> userData = // 
		// Current member / type: System.Void UTNotifications.Manager::ScheduleNotificationRepeating(System.Int32,System.Int32,System.String,System.String,System.Int32,System.Collections.Generic.IDictionary`2<System.String,System.String>,System.String,System.Int32,System.Collections.Generic.ICollection`1<UTNotifications.Button>)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: System.Void ScheduleNotificationRepeating(System.Int32,System.Int32,System.String,System.String,System.Int32,System.Collections.Generic.IDictionary<System.String,System.String>,System.String,System.Int32,System.Collections.Generic.ICollection<UTNotifications.Button>)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x144646C", Offset="0x144646C", VA="0x144646C")]
		public void ScheduleNotificationRepeating(DateTime firstTriggerDateTime, int intervalSeconds, string title, string text, int id, IDictionary<string, string> userData = // 
		// Current member / type: System.Void UTNotifications.Manager::ScheduleNotificationRepeating(System.DateTime,System.Int32,System.String,System.String,System.Int32,System.Collections.Generic.IDictionary`2<System.String,System.String>,System.String,System.Int32,System.Collections.Generic.ICollection`1<UTNotifications.Button>)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: System.Void ScheduleNotificationRepeating(System.DateTime,System.Int32,System.String,System.String,System.Int32,System.Collections.Generic.IDictionary<System.String,System.String>,System.String,System.Int32,System.Collections.Generic.ICollection<UTNotifications.Button>)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		public abstract void SetBadge(int bandgeNumber);

		public abstract void SetNotificationsEnabled(bool enabled);

		public abstract bool SetPushNotificationsEnabled(bool enable);

		public event Manager.OnInitializedHandler OnInitialized
		{
			[Address(RVA="0x1446504", Offset="0x1446504", VA="0x1446504")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10741C8", Offset="0x10741C8")]
			add
			{
			}
			[Address(RVA="0x14465F0", Offset="0x14465F0", VA="0x14465F0")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10741D8", Offset="0x10741D8")]
			remove
			{
			}
		}

		public event Manager.OnNotificationClickedHandler OnNotificationClicked
		{
			[Address(RVA="0x14468B4", Offset="0x14468B4", VA="0x14468B4")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1074208", Offset="0x1074208")]
			add
			{
			}
			[Address(RVA="0x14469A0", Offset="0x14469A0", VA="0x14469A0")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1074218", Offset="0x1074218")]
			remove
			{
			}
		}

		public event Manager.OnNotificationsReceivedHandler OnNotificationsReceived
		{
			[Address(RVA="0x1446A8C", Offset="0x1446A8C", VA="0x1446A8C")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1074228", Offset="0x1074228")]
			add
			{
			}
			[Address(RVA="0x1446B78", Offset="0x1446B78", VA="0x1446B78")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1074238", Offset="0x1074238")]
			remove
			{
			}
		}

		public event Manager.OnSendRegistrationIdHandler OnSendRegistrationId
		{
			[Address(RVA="0x14466DC", Offset="0x14466DC", VA="0x14466DC")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10741E8", Offset="0x10741E8")]
			add
			{
			}
			[Address(RVA="0x14467C8", Offset="0x14467C8", VA="0x14467C8")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10741F8", Offset="0x10741F8")]
			remove
			{
			}
		}

		public delegate void OnInitializedHandler();

		public delegate void OnNotificationClickedHandler(ReceivedNotification notification);

		public delegate void OnNotificationsReceivedHandler(IList<ReceivedNotification> receivedNotifications);

		public delegate void OnSendRegistrationIdHandler(string providerName, string registrationId);
	}
}