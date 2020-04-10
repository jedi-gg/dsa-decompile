using System;

namespace Csdk.GluMarketing.Implementation
{
	public interface ISerializableJson
	{
		void Write(JsonStringer json, string key);
	}
}