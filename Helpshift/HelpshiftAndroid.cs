using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Helpshift
{
	public class HelpshiftAndroid
	{
		[FieldOffset(Offset="0x10")]
		private AndroidJavaClass jc;

		[FieldOffset(Offset="0x18")]
		private AndroidJavaObject currentActivity;

		[FieldOffset(Offset="0x20")]
		private AndroidJavaObject application;

		[FieldOffset(Offset="0x28")]
		private AndroidJavaClass hsHelpshiftClass;

		[Address(RVA="0x12E2948", Offset="0x12E2948", VA="0x12E2948")]
		public HelpshiftAndroid()
		{
		}

		[Address(RVA="0x12E472C", Offset="0x12E472C", VA="0x12E472C")]
		public void checkIfConversationActive()
		{
		}

		[Address(RVA="0x12E39E0", Offset="0x12E39E0", VA="0x12E39E0")]
		private Dictionary<string, object> cleanConfig(Dictionary<string, object> configMap)
		{
			return null;
		}

		[Address(RVA="0x12E38C8", Offset="0x12E38C8", VA="0x12E38C8")]
		public void clearAnonymousUser()
		{
		}

		[Address(RVA="0x12E340C", Offset="0x12E340C", VA="0x12E340C")]
		public void clearBreadCrumbs()
		{
		}

		[Address(RVA="0x12E4194", Offset="0x12E4194", VA="0x12E4194")]
		public void handlePushNotification(Dictionary<string, object> pushNotificationData)
		{
		}

		[Address(RVA="0x12E2A68", Offset="0x12E2A68", VA="0x12E2A68")]
		public void install(string apiKey, string domain, string appId, Dictionary<string, object> configMap)
		{
		}

		[Address(RVA="0x12E3794", Offset="0x12E3794", VA="0x12E3794")]
		private string jsonifyHelpshiftUser(HelpshiftUser helpshiftUser)
		{
			return null;
		}

		[Address(RVA="0x12E332C", Offset="0x12E332C", VA="0x12E332C")]
		public void leaveBreadCrumb(string breadCrumb)
		{
		}

		[Address(RVA="0x12E3488", Offset="0x12E3488", VA="0x12E3488")]
		[Attribute(Name="ObsoleteAttribute", RVA="0x1075038", Offset="0x1075038")]
		public void login(string identifier, string userName, string email)
		{
		}

		[Address(RVA="0x12E3650", Offset="0x12E3650", VA="0x12E3650")]
		public void login(HelpshiftUser helpshiftUser)
		{
		}

		[Address(RVA="0x12E3944", Offset="0x12E3944", VA="0x12E3944")]
		public void logout()
		{
		}

		[Address(RVA="0x12E47A8", Offset="0x12E47A8", VA="0x12E47A8")]
		public void onApplicationQuit()
		{
		}

		[Address(RVA="0x12E4414", Offset="0x12E4414", VA="0x12E4414")]
		public void registerDelegates()
		{
		}

		[Address(RVA="0x12E31B8", Offset="0x12E31B8", VA="0x12E31B8")]
		public void registerDeviceToken(string deviceToken)
		{
		}

		[Address(RVA="0x12E2E48", Offset="0x12E2E48", VA="0x12E2E48")]
		public void requestUnreadMessagesCount(bool isAsync)
		{
		}

		[Address(RVA="0x12E39C0", Offset="0x12E39C0", VA="0x12E39C0")]
		private string serializeApiConfig(Dictionary<string, object> configMap)
		{
			return null;
		}

		[Address(RVA="0x12E2FAC", Offset="0x12E2FAC", VA="0x12E2FAC")]
		[Attribute(Name="ObsoleteAttribute", RVA="0x1075018", Offset="0x1075018")]
		public void setNameAndEmail(string userName, string email)
		{
		}

		[Address(RVA="0x12E44C0", Offset="0x12E44C0", VA="0x12E44C0")]
		public void setSDKLanguage(string locale)
		{
		}

		[Address(RVA="0x12E30D8", Offset="0x12E30D8", VA="0x12E30D8")]
		[Attribute(Name="ObsoleteAttribute", RVA="0x1075028", Offset="0x1075028")]
		public void setUserIdentifier(string identifier)
		{
		}

		[Address(RVA="0x12E4334", Offset="0x12E4334", VA="0x12E4334")]
		public void showAlertToRateAppWithURL(string url)
		{
		}

		[Address(RVA="0x12E3AFC", Offset="0x12E3AFC", VA="0x12E3AFC")]
		public void showConversation(Dictionary<string, object> configMap)
		{
		}

		[Address(RVA="0x12E45A0", Offset="0x12E45A0", VA="0x12E45A0")]
		public void showDynamicForm(string title, Dictionary<string, object>[] flows)
		{
		}

		[Address(RVA="0x12E3F60", Offset="0x12E3F60", VA="0x12E3F60")]
		public void showFAQs(Dictionary<string, object> configMap)
		{
		}

		[Address(RVA="0x12E3C40", Offset="0x12E3C40", VA="0x12E3C40")]
		public void showFAQSection(string sectionPublishId, Dictionary<string, object> configMap)
		{
		}

		[Address(RVA="0x12E3DD0", Offset="0x12E3DD0", VA="0x12E3DD0")]
		public void showSingleFAQ(string questionPublishId, Dictionary<string, object> configMap)
		{
		}

		[Address(RVA="0x12E40A4", Offset="0x12E40A4", VA="0x12E40A4")]
		public void updateMetaData(Dictionary<string, object> metaData)
		{
		}
	}
}