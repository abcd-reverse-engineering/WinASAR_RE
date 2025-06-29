using System;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Linq
{
	// Token: 0x0200015D RID: 349
	[NullableContext(1)]
	[Nullable(0)]
	public class JRaw : JValue
	{
		// Token: 0x06000F31 RID: 3889 RVA: 0x0007B004 File Offset: 0x00079204
		public JRaw(JRaw other)
			: base(other, null)
		{
			int num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_67a271e0ae064fc7a3a74905868add95 != 0)
			{
				switch (num)
				{
				}
			}
		}

		// Token: 0x06000F32 RID: 3890 RVA: 0x0007B038 File Offset: 0x00079238
		internal JRaw(JRaw other, [Nullable(2)] JsonCloneSettings settings)
			: base(other, settings)
		{
			int num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3bf07bb1c323490cb457eef2b2e78695 != 0)
			{
				switch (num)
				{
				}
			}
		}

		// Token: 0x06000F33 RID: 3891 RVA: 0x0007B06C File Offset: 0x0007926C
		[NullableContext(2)]
		public JRaw(object rawJson)
			: base(rawJson, JTokenType.Raw)
		{
			int num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3cf8a2073cc248c2915ebb05bcd2a099 != 0)
			{
				switch (num)
				{
				}
			}
		}

		// Token: 0x06000F34 RID: 3892 RVA: 0x0007B0A4 File Offset: 0x000792A4
		public static JRaw Create(JsonReader reader)
		{
			StringWriter stringWriter;
			JRaw jraw;
			for (;;)
			{
				stringWriter = new StringWriter(CultureInfo.InvariantCulture);
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8f48544341da433d9f954b548c7e9212 != 0)
				{
					switch (num)
					{
					case 1:
						continue;
					case 2:
						return jraw;
					}
					break;
				}
				break;
			}
			try
			{
				JsonTextWriter jsonTextWriter = new JsonTextWriter(stringWriter);
				int num2 = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_1db17fe7bd2442b599c52df89f39e610 != 0)
				{
					switch (num2)
					{
					}
				}
				try
				{
					jsonTextWriter.WriteToken(reader);
					int num3 = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93c7140125045538ae5c40c6f39a5af != 0)
					{
						goto IL_0094;
					}
					IL_0075:
					jraw = new JRaw(stringWriter.ToString());
					num3 = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_aa43e77a676848e0bd70abf647d6a9f1 == 0)
					{
						goto IL_00A5;
					}
					IL_0094:
					switch (num3)
					{
					case 0:
						goto IL_0075;
					case 1:
						break;
					default:
						goto IL_0075;
					}
					IL_00A5:;
				}
				finally
				{
					if (jsonTextWriter != null)
					{
						int num4 = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b3c865ee224546b18f2991d2a8895f6a == 0)
						{
							goto IL_00D5;
						}
						IL_00BD:
						((IDisposable)jsonTextWriter).Dispose();
						num4 = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5f127c3ec2e04c11ab1bd26a8d965f2b != 0)
						{
							goto IL_00E6;
						}
						IL_00D5:
						switch (num4)
						{
						case 0:
							goto IL_00BD;
						case 1:
							break;
						default:
							goto IL_00BD;
						}
					}
					IL_00E6:;
				}
			}
			finally
			{
				if (stringWriter == null)
				{
					int num5 = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_eaded84ad5b14e1ea8d4d97bfed1bb48 == 0)
					{
						goto IL_011A;
					}
					switch (num5)
					{
					case 0:
					case 2:
						goto IL_011A;
					case 1:
						break;
					default:
						goto IL_011A;
					}
				}
				((IDisposable)stringWriter).Dispose();
				IL_011A:;
			}
			return jraw;
		}

		// Token: 0x06000F35 RID: 3893 RVA: 0x000061ED File Offset: 0x000043ED
		internal override JToken CloneToken([Nullable(2)] JsonCloneSettings settings)
		{
			return new JRaw(this, settings);
		}
	}
}
