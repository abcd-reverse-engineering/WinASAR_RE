using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Newtonsoft.Json
{
	// Token: 0x02000058 RID: 88
	[NullableContext(1)]
	[Nullable(0)]
	[Serializable]
	public class JsonException : Exception
	{
		// Token: 0x060002B1 RID: 689 RVA: 0x000286F8 File Offset: 0x000268F8
		public JsonException()
		{
			int num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fd59e876ac704e7eaa7c7a24a9b3a23f == 0)
			{
				switch (num)
				{
				}
			}
		}

		// Token: 0x060002B2 RID: 690 RVA: 0x0002872C File Offset: 0x0002692C
		public JsonException(string message)
			: base(message)
		{
			int num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0005996a6a494de4880ac2956b2e0112 != 0)
			{
				switch (num)
				{
				}
			}
		}

		// Token: 0x060002B3 RID: 691 RVA: 0x00028760 File Offset: 0x00026960
		public JsonException(string message, [Nullable(2)] Exception innerException)
			: base(message, innerException)
		{
			int num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8432da17e8384a688cea4636964d3693 != 0)
			{
				switch (num)
				{
				}
			}
		}

		// Token: 0x060002B4 RID: 692 RVA: 0x00028794 File Offset: 0x00026994
		public JsonException(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
			int num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2a74c5ebb7d84adcad853e2eda393dc4 != 0)
			{
				switch (num)
				{
				}
			}
		}

		// Token: 0x060002B5 RID: 693 RVA: 0x000287C8 File Offset: 0x000269C8
		internal static JsonException Create(IJsonLineInfo lineInfo, string path, string message)
		{
			for (;;)
			{
				message = JsonPosition.FormatMessage(lineInfo, path, message);
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_207f975845fc40cdbe6b166fce664cd5 != 0)
				{
					switch (num)
					{
					case 1:
						continue;
					}
					break;
				}
				break;
			}
			return new JsonException(message);
		}
	}
}
