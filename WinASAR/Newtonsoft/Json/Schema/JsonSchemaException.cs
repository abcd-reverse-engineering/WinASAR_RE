using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Newtonsoft.Json.Schema
{
	// Token: 0x02000131 RID: 305
	[Obsolete("JSON Schema validation has been moved to its own package. See https://www.newtonsoft.com/jsonschema for more details.")]
	[Serializable]
	public class JsonSchemaException : JsonException
	{
		// Token: 0x170001D4 RID: 468
		// (get) Token: 0x06000CBF RID: 3263 RVA: 0x0000596F File Offset: 0x00003B6F
		public int LineNumber { get; }

		// Token: 0x170001D5 RID: 469
		// (get) Token: 0x06000CC0 RID: 3264 RVA: 0x00005977 File Offset: 0x00003B77
		public int LinePosition { get; }

		// Token: 0x170001D6 RID: 470
		// (get) Token: 0x06000CC1 RID: 3265 RVA: 0x0000597F File Offset: 0x00003B7F
		public string Path { get; }

		// Token: 0x06000CC2 RID: 3266 RVA: 0x0006E338 File Offset: 0x0006C538
		public JsonSchemaException()
		{
			int num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5f127c3ec2e04c11ab1bd26a8d965f2b == 0)
			{
				switch (num)
				{
				}
			}
		}

		// Token: 0x06000CC3 RID: 3267 RVA: 0x0006E36C File Offset: 0x0006C56C
		public JsonSchemaException(string message)
			: base(message)
		{
			int num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8f48544341da433d9f954b548c7e9212 == 0)
			{
				switch (num)
				{
				}
			}
		}

		// Token: 0x06000CC4 RID: 3268 RVA: 0x0006E3A0 File Offset: 0x0006C5A0
		public JsonSchemaException(string message, Exception innerException)
			: base(message, innerException)
		{
			int num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f19acd91a8c44846a95d09d7dc3da2ba == 0)
			{
				switch (num)
				{
				}
			}
		}

		// Token: 0x06000CC5 RID: 3269 RVA: 0x0006E3D4 File Offset: 0x0006C5D4
		public JsonSchemaException(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
			int num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39f35935adc2477fa894750fee078177 != 0)
			{
				switch (num)
				{
				}
			}
		}

		// Token: 0x06000CC6 RID: 3270 RVA: 0x0006E408 File Offset: 0x0006C608
		internal JsonSchemaException(string message, Exception innerException, string path, int lineNumber, int linePosition)
			: base(message, innerException)
		{
			for (;;)
			{
				IL_0059:
				this.Path = path;
				for (;;)
				{
					this.LineNumber = lineNumber;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ae8c3d3c66a64b57beca0f5360302062 != 0)
					{
						goto IL_000C;
					}
					IL_0025:
					switch (num)
					{
					case 1:
						return;
					case 2:
						continue;
					case 3:
						goto IL_0059;
					}
					IL_000C:
					this.LinePosition = linePosition;
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e764f065c2fa404a85129e2e957d4f18 == 0)
					{
						goto IL_0025;
					}
					return;
				}
			}
		}

		// Token: 0x0400062C RID: 1580
		[CompilerGenerated]
		private readonly int int_0;

		// Token: 0x0400062D RID: 1581
		[CompilerGenerated]
		private readonly int int_1;

		// Token: 0x0400062E RID: 1582
		[CompilerGenerated]
		private readonly string string_0;
	}
}
