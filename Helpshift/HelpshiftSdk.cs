using Il2CppDummyDll;
using System;
using System.Collections.Generic;

namespace Helpshift
{
	public class HelpshiftSdk
	{
		[FieldOffset(Offset="0x0")]
		public const string HS_RATE_ALERT_CLOSE = "HS_RATE_ALERT_CLOSE";

		[FieldOffset(Offset="0x0")]
		public const string HS_RATE_ALERT_FEEDBACK = "HS_RATE_ALERT_FEEDBACK";

		[FieldOffset(Offset="0x0")]
		public const string HS_RATE_ALERT_SUCCESS = "HS_RATE_ALERT_SUCCESS";

		[FieldOffset(Offset="0x0")]
		public const string HS_RATE_ALERT_FAIL = "HS_RATE_ALERT_FAIL";

		[FieldOffset(Offset="0x0")]
		public const string HSTAGSKEY = "hs-tags";

		[FieldOffset(Offset="0x0")]
		public const string HSCUSTOMMETADATAKEY = "hs-custom-metadata";

		[FieldOffset(Offset="0x0")]
		public const string HSCUSTOMISSUEFIELDKEY = "hs-custom-issue-field";

		[FieldOffset(Offset="0x0")]
		public const string HSTAGSMATCHINGKEY = "withTagsMatching";

		[FieldOffset(Offset="0x0")]
		public const string CONTACT_US_ALWAYS = "always";

		[FieldOffset(Offset="0x0")]
		public const string CONTACT_US_NEVER = "never";

		[FieldOffset(Offset="0x0")]
		public const string CONTACT_US_AFTER_VIEWING_FAQS = "after_viewing_faqs";

		[FieldOffset(Offset="0x0")]
		public const string CONTACT_US_AFTER_MARKING_ANSWER_UNHELPFUL = "after_marking_answer_unhelpful";

		[FieldOffset(Offset="0x0")]
		public const string HSUserAcceptedTheSolution = "User accepted the solution";

		[FieldOffset(Offset="0x0")]
		public const string HSUserRejectedTheSolution = "User rejected the solution";

		[FieldOffset(Offset="0x0")]
		public const string HSUserSentScreenShot = "User sent a screenshot";

		[FieldOffset(Offset="0x0")]
		public const string HSUserReviewedTheApp = "User reviewed the app";

		[FieldOffset(Offset="0x0")]
		public const string HsFlowTypeDefault = "defaultFlow";

		[FieldOffset(Offset="0x0")]
		public const string HsFlowTypeConversation = "conversationFlow";

		[FieldOffset(Offset="0x0")]
		public const string HsFlowTypeFaqs = "faqsFlow";

		[FieldOffset(Offset="0x0")]
		public const string HsFlowTypeFaqSection = "faqSectionFlow";

		[FieldOffset(Offset="0x0")]
		public const string HsFlowTypeSingleFaq = "singleFaqFlow";

		[FieldOffset(Offset="0x0")]
		public const string HsFlowTypeNested = "dynamicFormFlow";

		[FieldOffset(Offset="0x0")]
		public const string HsCustomContactUsFlows = "customContactUsFlows";

		[FieldOffset(Offset="0x0")]
		public const string HsFlowType = "type";

		[FieldOffset(Offset="0x0")]
		public const string HsFlowConfig = "config";

		[FieldOffset(Offset="0x0")]
		public const string HsFlowData = "data";

		[FieldOffset(Offset="0x0")]
		public const string HsFlowTitle = "title";

		[FieldOffset(Offset="0x0")]
		private static HelpshiftSdk instance;

		[FieldOffset(Offset="0x8")]
		private static HelpshiftAndroid nativeSdk;

		[Address(RVA="0x12E6B3C", Offset="0x12E6B3C", VA="0x12E6B3C")]
		static HelpshiftSdk()
		{
		}

		[Address(RVA="0x12E5B50", Offset="0x12E5B50", VA="0x12E5B50")]
		private HelpshiftSdk()
		{
		}

		[Address(RVA="0x12E6AC4", Offset="0x12E6AC4", VA="0x12E6AC4")]
		public void checkIfConversationActive()
		{
		}

		[Address(RVA="0x12E6064", Offset="0x12E6064", VA="0x12E6064")]
		public void clearAnonymousUser()
		{
		}

		[Address(RVA="0x12E6254", Offset="0x12E6254", VA="0x12E6254")]
		public void clearBreadCrumbs()
		{
		}

		[Address(RVA="0x12E5B58", Offset="0x12E5B58", VA="0x12E5B58")]
		public static HelpshiftSdk getInstance()
		{
			return null;
		}

		[Address(RVA="0x12E656C", Offset="0x12E656C", VA="0x12E656C")]
		public void handlePushNotification(Dictionary<string, object> pushNotificationData)
		{
		}

		[Address(RVA="0x12E5C3C", Offset="0x12E5C3C", VA="0x12E5C3C")]
		public void install(string apiKey, string domainName, string appId, Dictionary<string, object> config = // 
		// Current member / type: System.Void Helpshift.HelpshiftSdk::install(System.String,System.String,System.String,System.Collections.Generic.Dictionary`2<System.String,System.Object>)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: System.Void install(System.String,System.String,System.String,System.Collections.Generic.Dictionary<System.String,System.Object>)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x12E61D4", Offset="0x12E61D4", VA="0x12E61D4")]
		public void leaveBreadCrumb(string breadCrumb)
		{
		}

		[Address(RVA="0x12E5F4C", Offset="0x12E5F4C", VA="0x12E5F4C")]
		[Attribute(Name="ObsoleteAttribute", RVA="0x1075090", Offset="0x1075090")]
		public void login(string identifier, string name, string email)
		{
		}

		[Address(RVA="0x12E5FE4", Offset="0x12E5FE4", VA="0x12E5FE4")]
		public void login(HelpshiftUser helpshiftUser)
		{
		}

		[Address(RVA="0x12E60DC", Offset="0x12E60DC", VA="0x12E60DC")]
		public void logout()
		{
		}

		[Address(RVA="0x12E6A50", Offset="0x12E6A50", VA="0x12E6A50")]
		public void onApplicationQuit()
		{
		}

		[Address(RVA="0x12E6948", Offset="0x12E6948", VA="0x12E6948")]
		public void registerDelegates()
		{
		}

		[Address(RVA="0x12E6154", Offset="0x12E6154", VA="0x12E6154")]
		public void registerDeviceToken(string deviceToken)
		{
		}

		[Address(RVA="0x12E5DBC", Offset="0x12E5DBC", VA="0x12E5DBC")]
		public void requestUnreadMessagesCount(bool isAsync)
		{
		}

		[Address(RVA="0x12E5E3C", Offset="0x12E5E3C", VA="0x12E5E3C")]
		[Attribute(Name="ObsoleteAttribute", RVA="0x1075070", Offset="0x1075070")]
		public void setNameAndEmail(string userName, string email)
		{
		}

		[Address(RVA="0x12E68C8", Offset="0x12E68C8", VA="0x12E68C8")]
		public void setSDKLanguage(string locale)
		{
		}

		[Address(RVA="0x12E5ECC", Offset="0x12E5ECC", VA="0x12E5ECC")]
		[Attribute(Name="ObsoleteAttribute", RVA="0x1075080", Offset="0x1075080")]
		public void setUserIdentifier(string identifier)
		{
		}

		[Address(RVA="0x12E6848", Offset="0x12E6848", VA="0x12E6848")]
		public void showAlertToRateAppWithURL(string url)
		{
		}

		[Address(RVA="0x12E62CC", Offset="0x12E62CC", VA="0x12E62CC")]
		public void showConversation(Dictionary<string, object> configMap = // 
		// Current member / type: System.Void Helpshift.HelpshiftSdk::showConversation(System.Collections.Generic.Dictionary`2<System.String,System.Object>)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: System.Void showConversation(System.Collections.Generic.Dictionary<System.String,System.Object>)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x12E69C0", Offset="0x12E69C0", VA="0x12E69C0")]
		public void showDynamicForm(string title, Dictionary<string, object>[] flows)
		{
		}

		[Address(RVA="0x12E646C", Offset="0x12E646C", VA="0x12E646C")]
		public void showFAQs(Dictionary<string, object> configMap = // 
		// Current member / type: System.Void Helpshift.HelpshiftSdk::showFAQs(System.Collections.Generic.Dictionary`2<System.String,System.Object>)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: System.Void showFAQs(System.Collections.Generic.Dictionary<System.String,System.Object>)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x12E634C", Offset="0x12E634C", VA="0x12E634C")]
		public void showFAQSection(string sectionPublishId, Dictionary<string, object> configMap = // 
		// Current member / type: System.Void Helpshift.HelpshiftSdk::showFAQSection(System.String,System.Collections.Generic.Dictionary`2<System.String,System.Object>)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: System.Void showFAQSection(System.String,System.Collections.Generic.Dictionary<System.String,System.Object>)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x12E63DC", Offset="0x12E63DC", VA="0x12E63DC")]
		public void showSingleFAQ(string questionPublishId, Dictionary<string, object> configMap = // 
		// Current member / type: System.Void Helpshift.HelpshiftSdk::showSingleFAQ(System.String,System.Collections.Generic.Dictionary`2<System.String,System.Object>)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: System.Void showSingleFAQ(System.String,System.Collections.Generic.Dictionary<System.String,System.Object>)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x12E64EC", Offset="0x12E64EC", VA="0x12E64EC")]
		public void updateMetaData(Dictionary<string, object> metaData)
		{
		}
	}
}