using System;

namespace Csdk.GluMarketing.Implementation
{
	public interface ISerializableJsonObject
	{
		void WriteObject(JsonStringer json);
	}
}