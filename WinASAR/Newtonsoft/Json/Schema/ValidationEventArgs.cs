using System;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Schema
{
	// Token: 0x02000140 RID: 320
	[Obsolete("JSON Schema validation has been moved to its own package. See https://www.newtonsoft.com/jsonschema for more details.")]
	public class ValidationEventArgs : EventArgs
	{
		// Token: 0x06000D65 RID: 3429 RVA: 0x00072094 File Offset: 0x00070294
		internal ValidationEventArgs(JsonSchemaException ex)
		{
			int num = 2;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0361b8eb39074ea88f5257b13904930a != 0)
			{
				goto IL_001A;
			}
			goto IL_0062;
			for (;;)
			{
				IL_0047:
				this.jsonSchemaException_0 = ex;
				num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3a102d6e4dd542a6855b81a93c692545 == 0)
				{
					goto IL_0062;
				}
			}
			IL_001A:
			ValidationUtils.ArgumentNotNull(ex, Class15.smethod_17(82275348 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_832998aae3714af0a1270bf2bb566909));
			num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_6f87b5b72b9847f7b8ec5b44b0dccfa8 == 0)
			{
				goto IL_0047;
			}
			IL_0062:
			switch (num)
			{
			case 0:
				goto IL_0047;
			case 1:
				return;
			case 2:
				goto IL_001A;
			default:
				goto IL_0047;
			}
		}

		// Token: 0x170001F9 RID: 505
		// (get) Token: 0x06000D66 RID: 3430 RVA: 0x00005B97 File Offset: 0x00003D97
		public JsonSchemaException Exception
		{
			get
			{
				return this.jsonSchemaException_0;
			}
		}

		// Token: 0x170001FA RID: 506
		// (get) Token: 0x06000D67 RID: 3431 RVA: 0x00005B9F File Offset: 0x00003D9F
		public string Path
		{
			get
			{
				return this.jsonSchemaException_0.Path;
			}
		}

		// Token: 0x170001FB RID: 507
		// (get) Token: 0x06000D68 RID: 3432 RVA: 0x00005BAC File Offset: 0x00003DAC
		public string Message
		{
			get
			{
				return this.jsonSchemaException_0.Message;
			}
		}

		// Token: 0x0400067C RID: 1660
		private readonly JsonSchemaException jsonSchemaException_0;
	}
}
