using System;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Schema
{
	// Token: 0x0200012A RID: 298
	[Obsolete("JSON Schema validation has been moved to its own package. See https://www.newtonsoft.com/jsonschema for more details.")]
	public static class Extensions
	{
		// Token: 0x06000C3D RID: 3133 RVA: 0x0006B268 File Offset: 0x00069468
		[Obsolete("JSON Schema validation has been moved to its own package. See https://www.newtonsoft.com/jsonschema for more details.")]
		public static bool IsValid(this JToken source, JsonSchema schema)
		{
			Extensions.<>c__DisplayClass0_0 CS$<>8__locals1;
			for (;;)
			{
				CS$<>8__locals1 = new Extensions.<>c__DisplayClass0_0();
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3cf8a2073cc248c2915ebb05bcd2a099 != 0)
				{
					goto IL_0003;
				}
				goto IL_0045;
				do
				{
					IL_001D:
					source.Validate(schema, new ValidationEventHandler(CS$<>8__locals1.method_0));
					num = 3;
				}
				while (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cf58136e49114a5691c4a9d0e9788de1 != 0);
				IL_0045:
				switch (num)
				{
				case 0:
					goto IL_001D;
				case 1:
					IL_0003:
					CS$<>8__locals1.bool_0 = true;
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c27e9fccdfcc44999155a4980faa4e81 == 0)
					{
						goto IL_001D;
					}
					goto IL_0045;
				case 2:
					break;
				case 3:
					goto IL_0078;
				default:
					goto IL_001D;
				}
			}
			IL_0078:
			return CS$<>8__locals1.bool_0;
		}

		// Token: 0x06000C3E RID: 3134 RVA: 0x0006B2F4 File Offset: 0x000694F4
		[Obsolete("JSON Schema validation has been moved to its own package. See https://www.newtonsoft.com/jsonschema for more details.")]
		public static bool IsValid(this JToken source, JsonSchema schema, out IList<string> errorMessages)
		{
			for (;;)
			{
				Extensions.<>c__DisplayClass1_0 CS$<>8__locals1 = new Extensions.<>c__DisplayClass1_0();
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93ade03426d44b1841bfa7c633f49f3 != 0)
				{
					goto IL_0020;
				}
				IL_0066:
				switch (num)
				{
				case 0:
					goto IL_003E;
				case 1:
					IL_0020:
					CS$<>8__locals1.ilist_0 = new List<string>();
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cb7e1ff8cc1348bebf46c510e64a0134 == 0)
					{
						goto IL_003E;
					}
					goto IL_0066;
				case 2:
					continue;
				case 3:
					break;
				case 4:
					goto IL_009E;
				default:
					goto IL_003E;
				}
				IL_0003:
				errorMessages = CS$<>8__locals1.ilist_0;
				num = 4;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8d68b74cee6442019d959192b2974e3d == 0)
				{
					break;
				}
				goto IL_0066;
				IL_003E:
				source.Validate(schema, new ValidationEventHandler(CS$<>8__locals1.method_0));
				num = 3;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_871a407507f34aa3b5bf52517d4f63a9 != 0)
				{
					goto IL_0003;
				}
				goto IL_0066;
			}
			IL_009E:
			return errorMessages.Count == 0;
		}

		// Token: 0x06000C3F RID: 3135 RVA: 0x0006B3AC File Offset: 0x000695AC
		[Obsolete("JSON Schema validation has been moved to its own package. See https://www.newtonsoft.com/jsonschema for more details.")]
		public static void Validate(this JToken source, JsonSchema schema)
		{
			for (;;)
			{
				source.Validate(schema, null);
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a5994720d09542abb897ebf6ad9b5a19 == 0)
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
		}

		// Token: 0x06000C40 RID: 3136 RVA: 0x0006B3E4 File Offset: 0x000695E4
		[Obsolete("JSON Schema validation has been moved to its own package. See https://www.newtonsoft.com/jsonschema for more details.")]
		public static void Validate(this JToken source, JsonSchema schema, ValidationEventHandler validationEventHandler)
		{
			for (;;)
			{
				IL_004B:
				ValidationUtils.ArgumentNotNull(source, Class15.smethod_17(564906732 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_1db17fe7bd2442b599c52df89f39e610));
				for (;;)
				{
					ValidationUtils.ArgumentNotNull(schema, Class15.smethod_17(1678052554 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ee35a23edd8f4998990ec1a2b40fc61a));
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cf58136e49114a5691c4a9d0e9788de1 == 0)
					{
						switch (num)
						{
						case 1:
							return;
						case 2:
							continue;
						case 3:
							goto IL_004B;
						case 4:
							goto IL_0076;
						}
						goto Block_2;
					}
					goto IL_0068;
				}
			}
			Block_2:
			IL_0068:
			JsonValidatingReader jsonValidatingReader = new JsonValidatingReader(source.CreateReader());
			IL_0076:
			try
			{
				jsonValidatingReader.Schema = schema;
				for (;;)
				{
					if (validationEventHandler != null)
					{
						goto IL_00BA;
					}
					int num2 = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a5994720d09542abb897ebf6ad9b5a19 != 0)
					{
						goto IL_0092;
					}
					IL_00AE:
					while (jsonValidatingReader.Read())
					{
					}
					num2 = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_67a271e0ae064fc7a3a74905868add95 != 0)
					{
						break;
					}
					IL_0092:
					switch (num2)
					{
					case 1:
					case 3:
						goto IL_00AE;
					case 2:
						IL_00BA:
						jsonValidatingReader.ValidationEventHandler += validationEventHandler;
						goto IL_00AE;
					case 4:
						continue;
					}
					break;
				}
			}
			finally
			{
				if (jsonValidatingReader != null)
				{
					goto IL_010A;
				}
				int num3 = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3bf07bb1c323490cb457eef2b2e78695 == 0)
				{
					goto IL_0123;
				}
				IL_00F9:
				switch (num3)
				{
				default:
					IL_010A:
					((IDisposable)jsonValidatingReader).Dispose();
					num3 = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_57ce3fecb9e64a8f924ea7658e146719 == 0)
					{
						goto IL_00F9;
					}
					break;
				case 1:
				case 2:
					break;
				}
				IL_0123:;
			}
		}
	}
}
