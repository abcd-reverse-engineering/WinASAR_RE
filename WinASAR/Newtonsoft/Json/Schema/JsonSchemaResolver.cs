using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Schema
{
	// Token: 0x0200013A RID: 314
	[Obsolete("JSON Schema validation has been moved to its own package. See https://www.newtonsoft.com/jsonschema for more details.")]
	public class JsonSchemaResolver
	{
		// Token: 0x170001F8 RID: 504
		// (get) Token: 0x06000D49 RID: 3401 RVA: 0x00005B58 File Offset: 0x00003D58
		// (set) Token: 0x06000D4A RID: 3402 RVA: 0x00005B60 File Offset: 0x00003D60
		public IList<JsonSchema> LoadedSchemas { get; protected set; }

		// Token: 0x06000D4B RID: 3403 RVA: 0x00070CC8 File Offset: 0x0006EEC8
		public JsonSchemaResolver()
		{
			int num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3436841e08c54f56b10b76e1438d4224 != 0)
			{
				goto IL_0039;
			}
			do
			{
				IL_001A:
				this.LoadedSchemas = new List<JsonSchema>();
				num = 1;
			}
			while (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0361b8eb39074ea88f5257b13904930a == 0);
			IL_0039:
			switch (num)
			{
			case 0:
				goto IL_001A;
			case 1:
				return;
			default:
				goto IL_001A;
			}
		}

		// Token: 0x06000D4C RID: 3404 RVA: 0x00070D20 File Offset: 0x0006EF20
		public virtual JsonSchema GetSchema(string reference)
		{
			JsonSchema jsonSchema;
			for (;;)
			{
				IL_00B8:
				JsonSchemaResolver.<>c__DisplayClass5_0 CS$<>8__locals1 = new JsonSchemaResolver.<>c__DisplayClass5_0();
				int num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cbfb1e54efd84756a9b6d7b21adc0d65 != 0)
				{
					goto IL_004B;
				}
				do
				{
					IL_0098:
					switch (num)
					{
					case 1:
						goto IL_0032;
					case 2:
						CS$<>8__locals1.string_0 = reference;
						num = 1;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_186d640068094cc595a341ef95c9a29a == 0)
						{
							goto IL_0006;
						}
						continue;
					case 3:
						goto IL_00B8;
					case 4:
						goto IL_0006;
					case 5:
						return jsonSchema;
					}
					break;
					IL_0006:
					jsonSchema = this.LoadedSchemas.SingleOrDefault(new Func<JsonSchema, bool>(CS$<>8__locals1.method_0));
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_991c06e999c744809f5b643cb7d9e7b4 != 0)
					{
						continue;
					}
					IL_0032:
					if (jsonSchema != null)
					{
						return jsonSchema;
					}
					num = 0;
				}
				while (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39f35935adc2477fa894750fee078177 != 0);
				IL_004B:
				jsonSchema = this.LoadedSchemas.SingleOrDefault(new Func<JsonSchema, bool>(CS$<>8__locals1.method_1));
				num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0b405dced5e94c80928a74c5773182d9 == 0)
				{
					break;
				}
				goto IL_0098;
			}
			return jsonSchema;
		}

		// Token: 0x04000664 RID: 1636
		[CompilerGenerated]
		private IList<JsonSchema> ilist_0;
	}
}
