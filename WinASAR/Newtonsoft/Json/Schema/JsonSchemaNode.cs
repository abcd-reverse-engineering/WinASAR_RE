using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Schema
{
	// Token: 0x02000137 RID: 311
	[Obsolete("JSON Schema validation has been moved to its own package. See https://www.newtonsoft.com/jsonschema for more details.")]
	internal class JsonSchemaNode
	{
		// Token: 0x170001F1 RID: 497
		// (get) Token: 0x06000D2E RID: 3374 RVA: 0x00005B07 File Offset: 0x00003D07
		public string Id { get; }

		// Token: 0x170001F2 RID: 498
		// (get) Token: 0x06000D2F RID: 3375 RVA: 0x00005B0F File Offset: 0x00003D0F
		public ReadOnlyCollection<JsonSchema> Schemas { get; }

		// Token: 0x170001F3 RID: 499
		// (get) Token: 0x06000D30 RID: 3376 RVA: 0x00005B17 File Offset: 0x00003D17
		public Dictionary<string, JsonSchemaNode> Properties { get; }

		// Token: 0x170001F4 RID: 500
		// (get) Token: 0x06000D31 RID: 3377 RVA: 0x00005B1F File Offset: 0x00003D1F
		public Dictionary<string, JsonSchemaNode> PatternProperties { get; }

		// Token: 0x170001F5 RID: 501
		// (get) Token: 0x06000D32 RID: 3378 RVA: 0x00005B27 File Offset: 0x00003D27
		public List<JsonSchemaNode> Items { get; }

		// Token: 0x170001F6 RID: 502
		// (get) Token: 0x06000D33 RID: 3379 RVA: 0x00005B2F File Offset: 0x00003D2F
		// (set) Token: 0x06000D34 RID: 3380 RVA: 0x0007091C File Offset: 0x0006EB1C
		public JsonSchemaNode AdditionalProperties
		{
			[CompilerGenerated]
			get
			{
				return this.jsonSchemaNode_0;
			}
			[CompilerGenerated]
			set
			{
				for (;;)
				{
					this.jsonSchemaNode_0 = value;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0b405dced5e94c80928a74c5773182d9 != 0)
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
		}

		// Token: 0x170001F7 RID: 503
		// (get) Token: 0x06000D35 RID: 3381 RVA: 0x00005B37 File Offset: 0x00003D37
		// (set) Token: 0x06000D36 RID: 3382 RVA: 0x00070954 File Offset: 0x0006EB54
		public JsonSchemaNode AdditionalItems
		{
			[CompilerGenerated]
			get
			{
				return this.jsonSchemaNode_1;
			}
			[CompilerGenerated]
			set
			{
				for (;;)
				{
					this.jsonSchemaNode_1 = value;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7ae4da5a55de471eb12dd0de8dd4269c == 0)
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
		}

		// Token: 0x06000D37 RID: 3383 RVA: 0x0007098C File Offset: 0x0006EB8C
		public JsonSchemaNode(JsonSchema schema)
		{
			for (;;)
			{
				IL_0073:
				this.Schemas = new ReadOnlyCollection<JsonSchema>(new JsonSchema[] { schema });
				for (;;)
				{
					this.Properties = new Dictionary<string, JsonSchemaNode>();
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_6f87b5b72b9847f7b8ec5b44b0dccfa8 != 0)
					{
						goto IL_0027;
					}
					IL_0034:
					switch (num)
					{
					case 0:
						goto IL_0027;
					case 1:
						goto IL_008A;
					case 2:
						return;
					case 3:
						continue;
					case 4:
						break;
					case 5:
						goto IL_0073;
					default:
						goto IL_0027;
					}
					IL_000A:
					this.Items = new List<JsonSchemaNode>();
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8432da17e8384a688cea4636964d3693 == 0)
					{
						goto IL_0034;
					}
					IL_0027:
					this.PatternProperties = new Dictionary<string, JsonSchemaNode>();
					goto IL_000A;
				}
			}
			IL_008A:
			this.Id = JsonSchemaNode.GetId(this.Schemas);
		}

		// Token: 0x06000D38 RID: 3384 RVA: 0x00070A34 File Offset: 0x0006EC34
		private JsonSchemaNode(JsonSchemaNode source, JsonSchema schema)
		{
			int num = 2;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7ae4da5a55de471eb12dd0de8dd4269c != 0)
			{
				goto IL_00F9;
			}
			for (;;)
			{
				IL_0119:
				switch (num)
				{
				case 1:
					goto IL_00F9;
				case 2:
					this.Schemas = new ReadOnlyCollection<JsonSchema>(source.Schemas.Union(new JsonSchema[] { schema }).ToList<JsonSchema>());
					goto IL_004D;
				case 3:
					goto IL_00AA;
				case 4:
					goto IL_0073;
				case 5:
					goto IL_0099;
				case 6:
					goto IL_004D;
				case 7:
					this.Id = JsonSchemaNode.GetId(this.Schemas);
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_832998aae3714af0a1270bf2bb566909 == 0)
					{
						continue;
					}
					break;
				}
				break;
				IL_004D:
				this.Properties = new Dictionary<string, JsonSchemaNode>(source.Properties);
				num = 5;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_52d717cd31b74287b67c03ee736a6211 != 0)
				{
					goto IL_0073;
				}
			}
			return;
			IL_0073:
			this.AdditionalProperties = source.AdditionalProperties;
			num = 1;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0efaea2f67ca4b0aa2880fbd34fc0fff == 0)
			{
				return;
			}
			goto IL_0119;
			IL_0099:
			this.PatternProperties = new Dictionary<string, JsonSchemaNode>(source.PatternProperties);
			IL_00AA:
			this.Items = new List<JsonSchemaNode>(source.Items);
			num = 2;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7dfc957a76cb4c58b17dc74a084c4e4a != 0)
			{
				goto IL_0073;
			}
			goto IL_0119;
			IL_00F9:
			this.AdditionalItems = source.AdditionalItems;
			num = 7;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f19acd91a8c44846a95d09d7dc3da2ba == 0)
			{
				goto IL_0099;
			}
			goto IL_0119;
		}

		// Token: 0x06000D39 RID: 3385 RVA: 0x00005B3F File Offset: 0x00003D3F
		public JsonSchemaNode Combine(JsonSchema schema)
		{
			return new JsonSchemaNode(this, schema);
		}

		// Token: 0x06000D3A RID: 3386 RVA: 0x00070B88 File Offset: 0x0006ED88
		public static string GetId(IEnumerable<JsonSchema> schemata)
		{
			return string.Join(Class15.smethod_17(1042111165 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39a47a907a8a440980940ae96da3f3ad), schemata.Select(new Func<JsonSchema, string>(JsonSchemaNode.<>c.<>c_0.method_0)).OrderBy(new Func<string, string>(JsonSchemaNode.<>c.<>c_0.method_1), StringComparer.Ordinal));
		}

		// Token: 0x04000657 RID: 1623
		[CompilerGenerated]
		private readonly string string_0;

		// Token: 0x04000658 RID: 1624
		[CompilerGenerated]
		private readonly ReadOnlyCollection<JsonSchema> readOnlyCollection_0;

		// Token: 0x04000659 RID: 1625
		[CompilerGenerated]
		private readonly Dictionary<string, JsonSchemaNode> dictionary_0;

		// Token: 0x0400065A RID: 1626
		[CompilerGenerated]
		private readonly Dictionary<string, JsonSchemaNode> dictionary_1;

		// Token: 0x0400065B RID: 1627
		[CompilerGenerated]
		private readonly List<JsonSchemaNode> list_0;

		// Token: 0x0400065C RID: 1628
		[CompilerGenerated]
		private JsonSchemaNode jsonSchemaNode_0;

		// Token: 0x0400065D RID: 1629
		[CompilerGenerated]
		private JsonSchemaNode jsonSchemaNode_1;
	}
}
