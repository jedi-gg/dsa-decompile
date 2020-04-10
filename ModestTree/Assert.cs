using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using Zenject;

namespace ModestTree
{
	public static class Assert
	{
		[Address(RVA="0x12F603C", Offset="0x12F603C", VA="0x12F603C")]
		public static ZenjectException CreateException()
		{
			return null;
		}

		[Address(RVA="0x12F464C", Offset="0x12F464C", VA="0x12F464C")]
		public static ZenjectException CreateException(string message)
		{
			return null;
		}

		[Address(RVA="0x12F48F8", Offset="0x12F48F8", VA="0x12F48F8")]
		public static ZenjectException CreateException(string message, params object[] parameters)
		{
			return null;
		}

		[Address(RVA="0x12F60A4", Offset="0x12F60A4", VA="0x12F60A4")]
		public static ZenjectException CreateException(Exception innerException, string message, params object[] parameters)
		{
			return null;
		}

		[Address(RVA="0x13891BC", Offset="0x13891BC", VA="0x13891BC")]
		public static void DerivesFrom<T>(Type type)
		{
		}

		[Address(RVA="0x12F4728", Offset="0x12F4728", VA="0x12F4728")]
		public static void DerivesFrom(Type childType, Type parentType)
		{
		}

		[Address(RVA="0x138935C", Offset="0x138935C", VA="0x138935C")]
		public static void DerivesFromOrEqual<T>(Type type)
		{
		}

		[Address(RVA="0x12F497C", Offset="0x12F497C", VA="0x12F497C")]
		public static void DerivesFromOrEqual(Type childType, Type parentType)
		{
		}

		[Address(RVA="0x12F54F4", Offset="0x12F54F4", VA="0x12F54F4")]
		private static string FormatString(string format, params object[] parameters)
		{
			return null;
		}

		[Address(RVA="0x12F4E60", Offset="0x12F4E60", VA="0x12F4E60")]
		public static void IsApproximately(float left, float right, float epsilon = 1E-05f)
		{
		}

		[Address(RVA="0x13894FC", Offset="0x13894FC", VA="0x13894FC")]
		public static void IsEmpty<T>(IEnumerable<T> sequence)
		{
		}

		[Address(RVA="0x12F4B64", Offset="0x12F4B64", VA="0x12F4B64")]
		public static void IsEqual(object left, object right)
		{
		}

		[Address(RVA="0x12F4CFC", Offset="0x12F4CFC", VA="0x12F4CFC")]
		public static void IsEqual(object left, object right, Func<string> messageGenerator)
		{
		}

		[Address(RVA="0x12F4BC4", Offset="0x12F4BC4", VA="0x12F4BC4")]
		public static void IsEqual(object left, object right, string message)
		{
		}

		[Address(RVA="0x12F46B0", Offset="0x12F46B0", VA="0x12F46B0")]
		public static void IsNotEmpty(string str)
		{
		}

		[Address(RVA="0x1389604", Offset="0x1389604", VA="0x1389604")]
		public static void IsNotEmpty<T>(IEnumerable<T> val, string message = "")
		{
		}

		[Address(RVA="0x12F4FBC", Offset="0x12F4FBC", VA="0x12F4FBC")]
		public static void IsNotEqual(object left, object right)
		{
		}

		[Address(RVA="0x12F5124", Offset="0x12F5124", VA="0x12F5124")]
		public static void IsNotEqual(object left, object right, Func<string> messageGenerator)
		{
		}

		[Address(RVA="0x12F501C", Offset="0x12F501C", VA="0x12F501C")]
		public static void IsNotEqual(object left, object right, string message)
		{
		}

		[Address(RVA="0x12F5694", Offset="0x12F5694", VA="0x12F5694")]
		public static void IsNotNull(object val)
		{
		}

		[Address(RVA="0x12F5700", Offset="0x12F5700", VA="0x12F5700")]
		public static void IsNotNull(object val, string message)
		{
		}

		[Address(RVA="0x12F57B8", Offset="0x12F57B8", VA="0x12F57B8")]
		public static void IsNotNull(object val, string message, object p1)
		{
		}

		[Address(RVA="0x12F58C0", Offset="0x12F58C0", VA="0x12F58C0")]
		public static void IsNotNull(object val, string message, object p1, object p2)
		{
		}

		[Address(RVA="0x12F5288", Offset="0x12F5288", VA="0x12F5288")]
		public static void IsNull(object val)
		{
		}

		[Address(RVA="0x12F5334", Offset="0x12F5334", VA="0x12F5334")]
		public static void IsNull(object val, string message)
		{
		}

		[Address(RVA="0x12F53EC", Offset="0x12F53EC", VA="0x12F53EC")]
		public static void IsNull(object val, string message, object p1)
		{
		}

		[Address(RVA="0x1389740", Offset="0x1389740", VA="0x1389740")]
		public static void IsType<T>(object obj)
		{
		}

		[Address(RVA="0x13897A8", Offset="0x13897A8", VA="0x13897A8")]
		public static void IsType<T>(object obj, string message)
		{
		}

		[Address(RVA="0x12F45E0", Offset="0x12F45E0", VA="0x12F45E0")]
		public static void That(bool condition)
		{
		}

		[Address(RVA="0x12F5BC0", Offset="0x12F5BC0", VA="0x12F5BC0")]
		public static void That(bool condition, string message)
		{
		}

		[Address(RVA="0x12F5C44", Offset="0x12F5C44", VA="0x12F5C44")]
		public static void That(bool condition, string message, object p1)
		{
		}

		[Address(RVA="0x12F5D18", Offset="0x12F5D18", VA="0x12F5D18")]
		public static void That(bool condition, string message, object p1, object p2)
		{
		}

		[Address(RVA="0x12F5E20", Offset="0x12F5E20", VA="0x12F5E20")]
		public static void That(bool condition, string message, object p1, object p2, object p3)
		{
		}

		[Address(RVA="0x12F5FEC", Offset="0x12F5FEC", VA="0x12F5FEC")]
		public static void Throws(Action action)
		{
		}

		[Address(RVA="0x1389980", Offset="0x1389980", VA="0x1389980")]
		public static void Throws<TException>(Action action)
		where TException : Exception
		{
		}

		[Address(RVA="0x12F5A00", Offset="0x12F5A00", VA="0x12F5A00")]
		public static void Warn(bool condition)
		{
		}

		[Address(RVA="0x12F5B00", Offset="0x12F5B00", VA="0x12F5B00")]
		public static void Warn(bool condition, Func<string> messageGenerator)
		{
		}

		[Address(RVA="0x12F5F54", Offset="0x12F5F54", VA="0x12F5F54")]
		public static void Warn(bool condition, string message)
		{
		}
	}
}