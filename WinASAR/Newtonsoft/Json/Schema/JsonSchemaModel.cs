using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Schema
{
	// Token: 0x02000135 RID: 309
	[Obsolete("JSON Schema validation has been moved to its own package. See https://www.newtonsoft.com/jsonschema for more details.")]
	internal class JsonSchemaModel
	{
		// Token: 0x170001DA RID: 474
		// (get) Token: 0x06000CEE RID: 3310 RVA: 0x000059E3 File Offset: 0x00003BE3
		// (set) Token: 0x06000CEF RID: 3311 RVA: 0x0006F808 File Offset: 0x0006DA08
		public bool Required
		{
			[CompilerGenerated]
			get
			{
				return this.bool_0;
			}
			[CompilerGenerated]
			set
			{
				for (;;)
				{
					this.bool_0 = value;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_193800745ad94a529d9e5edc977c4f02 != 0)
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

		// Token: 0x170001DB RID: 475
		// (get) Token: 0x06000CF0 RID: 3312 RVA: 0x000059EB File Offset: 0x00003BEB
		// (set) Token: 0x06000CF1 RID: 3313 RVA: 0x0006F840 File Offset: 0x0006DA40
		public JsonSchemaType Type
		{
			[CompilerGenerated]
			get
			{
				return this.jsonSchemaType_0;
			}
			[CompilerGenerated]
			set
			{
				for (;;)
				{
					this.jsonSchemaType_0 = value;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8f48544341da433d9f954b548c7e9212 == 0)
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

		// Token: 0x170001DC RID: 476
		// (get) Token: 0x06000CF2 RID: 3314 RVA: 0x000059F3 File Offset: 0x00003BF3
		// (set) Token: 0x06000CF3 RID: 3315 RVA: 0x000059FB File Offset: 0x00003BFB
		public int? MinimumLength { get; set; }

		// Token: 0x170001DD RID: 477
		// (get) Token: 0x06000CF4 RID: 3316 RVA: 0x00005A04 File Offset: 0x00003C04
		// (set) Token: 0x06000CF5 RID: 3317 RVA: 0x00005A0C File Offset: 0x00003C0C
		public int? MaximumLength { get; set; }

		// Token: 0x170001DE RID: 478
		// (get) Token: 0x06000CF6 RID: 3318 RVA: 0x00005A15 File Offset: 0x00003C15
		// (set) Token: 0x06000CF7 RID: 3319 RVA: 0x00005A1D File Offset: 0x00003C1D
		public double? DivisibleBy { get; set; }

		// Token: 0x170001DF RID: 479
		// (get) Token: 0x06000CF8 RID: 3320 RVA: 0x00005A26 File Offset: 0x00003C26
		// (set) Token: 0x06000CF9 RID: 3321 RVA: 0x00005A2E File Offset: 0x00003C2E
		public double? Minimum { get; set; }

		// Token: 0x170001E0 RID: 480
		// (get) Token: 0x06000CFA RID: 3322 RVA: 0x00005A37 File Offset: 0x00003C37
		// (set) Token: 0x06000CFB RID: 3323 RVA: 0x00005A3F File Offset: 0x00003C3F
		public double? Maximum { get; set; }

		// Token: 0x170001E1 RID: 481
		// (get) Token: 0x06000CFC RID: 3324 RVA: 0x00005A48 File Offset: 0x00003C48
		// (set) Token: 0x06000CFD RID: 3325 RVA: 0x0006F878 File Offset: 0x0006DA78
		public bool ExclusiveMinimum
		{
			[CompilerGenerated]
			get
			{
				return this.bool_1;
			}
			[CompilerGenerated]
			set
			{
				for (;;)
				{
					this.bool_1 = value;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_676b866782704933888a7440512fd4ff != 0)
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

		// Token: 0x170001E2 RID: 482
		// (get) Token: 0x06000CFE RID: 3326 RVA: 0x00005A50 File Offset: 0x00003C50
		// (set) Token: 0x06000CFF RID: 3327 RVA: 0x0006F8B0 File Offset: 0x0006DAB0
		public bool ExclusiveMaximum
		{
			[CompilerGenerated]
			get
			{
				return this.bool_2;
			}
			[CompilerGenerated]
			set
			{
				for (;;)
				{
					this.bool_2 = value;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93ade03426d44b1841bfa7c633f49f3 == 0)
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

		// Token: 0x170001E3 RID: 483
		// (get) Token: 0x06000D00 RID: 3328 RVA: 0x00005A58 File Offset: 0x00003C58
		// (set) Token: 0x06000D01 RID: 3329 RVA: 0x00005A60 File Offset: 0x00003C60
		public int? MinimumItems { get; set; }

		// Token: 0x170001E4 RID: 484
		// (get) Token: 0x06000D02 RID: 3330 RVA: 0x00005A69 File Offset: 0x00003C69
		// (set) Token: 0x06000D03 RID: 3331 RVA: 0x00005A71 File Offset: 0x00003C71
		public int? MaximumItems { get; set; }

		// Token: 0x170001E5 RID: 485
		// (get) Token: 0x06000D04 RID: 3332 RVA: 0x00005A7A File Offset: 0x00003C7A
		// (set) Token: 0x06000D05 RID: 3333 RVA: 0x00005A82 File Offset: 0x00003C82
		public IList<string> Patterns { get; set; }

		// Token: 0x170001E6 RID: 486
		// (get) Token: 0x06000D06 RID: 3334 RVA: 0x00005A8B File Offset: 0x00003C8B
		// (set) Token: 0x06000D07 RID: 3335 RVA: 0x00005A93 File Offset: 0x00003C93
		public IList<JsonSchemaModel> Items { get; set; }

		// Token: 0x170001E7 RID: 487
		// (get) Token: 0x06000D08 RID: 3336 RVA: 0x00005A9C File Offset: 0x00003C9C
		// (set) Token: 0x06000D09 RID: 3337 RVA: 0x00005AA4 File Offset: 0x00003CA4
		public IDictionary<string, JsonSchemaModel> Properties { get; set; }

		// Token: 0x170001E8 RID: 488
		// (get) Token: 0x06000D0A RID: 3338 RVA: 0x00005AAD File Offset: 0x00003CAD
		// (set) Token: 0x06000D0B RID: 3339 RVA: 0x00005AB5 File Offset: 0x00003CB5
		public IDictionary<string, JsonSchemaModel> PatternProperties { get; set; }

		// Token: 0x170001E9 RID: 489
		// (get) Token: 0x06000D0C RID: 3340 RVA: 0x00005ABE File Offset: 0x00003CBE
		// (set) Token: 0x06000D0D RID: 3341 RVA: 0x0006F8E8 File Offset: 0x0006DAE8
		public JsonSchemaModel AdditionalProperties
		{
			[CompilerGenerated]
			get
			{
				return this.jsonSchemaModel_0;
			}
			[CompilerGenerated]
			set
			{
				for (;;)
				{
					this.jsonSchemaModel_0 = value;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_01137da6c88c4265bdc0297aacf3340f != 0)
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

		// Token: 0x170001EA RID: 490
		// (get) Token: 0x06000D0E RID: 3342 RVA: 0x00005AC6 File Offset: 0x00003CC6
		// (set) Token: 0x06000D0F RID: 3343 RVA: 0x0006F920 File Offset: 0x0006DB20
		public JsonSchemaModel AdditionalItems
		{
			[CompilerGenerated]
			get
			{
				return this.jsonSchemaModel_1;
			}
			[CompilerGenerated]
			set
			{
				for (;;)
				{
					this.jsonSchemaModel_1 = value;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8432da17e8384a688cea4636964d3693 == 0)
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

		// Token: 0x170001EB RID: 491
		// (get) Token: 0x06000D10 RID: 3344 RVA: 0x00005ACE File Offset: 0x00003CCE
		// (set) Token: 0x06000D11 RID: 3345 RVA: 0x0006F958 File Offset: 0x0006DB58
		public bool PositionalItemsValidation
		{
			[CompilerGenerated]
			get
			{
				return this.bool_3;
			}
			[CompilerGenerated]
			set
			{
				for (;;)
				{
					this.bool_3 = value;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e764f065c2fa404a85129e2e957d4f18 == 0)
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

		// Token: 0x170001EC RID: 492
		// (get) Token: 0x06000D12 RID: 3346 RVA: 0x00005AD6 File Offset: 0x00003CD6
		// (set) Token: 0x06000D13 RID: 3347 RVA: 0x0006F990 File Offset: 0x0006DB90
		public bool AllowAdditionalProperties
		{
			[CompilerGenerated]
			get
			{
				return this.bool_4;
			}
			[CompilerGenerated]
			set
			{
				for (;;)
				{
					this.bool_4 = value;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3a102d6e4dd542a6855b81a93c692545 == 0)
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

		// Token: 0x170001ED RID: 493
		// (get) Token: 0x06000D14 RID: 3348 RVA: 0x00005ADE File Offset: 0x00003CDE
		// (set) Token: 0x06000D15 RID: 3349 RVA: 0x0006F9C8 File Offset: 0x0006DBC8
		public bool AllowAdditionalItems
		{
			[CompilerGenerated]
			get
			{
				return this.bool_5;
			}
			[CompilerGenerated]
			set
			{
				for (;;)
				{
					this.bool_5 = value;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5c76a4eb2c1748d1bee3513c8eaff2eb == 0)
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

		// Token: 0x170001EE RID: 494
		// (get) Token: 0x06000D16 RID: 3350 RVA: 0x00005AE6 File Offset: 0x00003CE6
		// (set) Token: 0x06000D17 RID: 3351 RVA: 0x0006FA00 File Offset: 0x0006DC00
		public bool UniqueItems
		{
			[CompilerGenerated]
			get
			{
				return this.bool_6;
			}
			[CompilerGenerated]
			set
			{
				for (;;)
				{
					this.bool_6 = value;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_079bd9b874b24353bef46f6c3f5d741d == 0)
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

		// Token: 0x170001EF RID: 495
		// (get) Token: 0x06000D18 RID: 3352 RVA: 0x00005AEE File Offset: 0x00003CEE
		// (set) Token: 0x06000D19 RID: 3353 RVA: 0x00005AF6 File Offset: 0x00003CF6
		public IList<JToken> Enum { get; set; }

		// Token: 0x170001F0 RID: 496
		// (get) Token: 0x06000D1A RID: 3354 RVA: 0x00005AFF File Offset: 0x00003CFF
		// (set) Token: 0x06000D1B RID: 3355 RVA: 0x0006FA38 File Offset: 0x0006DC38
		public JsonSchemaType Disallow
		{
			[CompilerGenerated]
			get
			{
				return this.jsonSchemaType_1;
			}
			[CompilerGenerated]
			set
			{
				for (;;)
				{
					this.jsonSchemaType_1 = value;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39f35935adc2477fa894750fee078177 != 0)
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

		// Token: 0x06000D1C RID: 3356 RVA: 0x0006FA70 File Offset: 0x0006DC70
		public JsonSchemaModel()
		{
			for (;;)
			{
				IL_0075:
				this.Type = JsonSchemaType.Any;
				for (;;)
				{
					IL_005A:
					this.AllowAdditionalProperties = true;
					int num = 4;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e368897ba1744663a6d0bc59b9b65b5f != 0)
					{
						for (;;)
						{
							switch (num)
							{
							case 1:
								return;
							case 2:
								goto IL_005A;
							case 3:
								goto IL_0075;
							case 4:
								this.AllowAdditionalItems = true;
								num = 0;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_17bdafd603b54a77a2e4a383bd4dcffa != 0)
								{
									continue;
								}
								break;
							}
							do
							{
								this.Required = false;
								num = 1;
							}
							while (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_48fe014748e848c88d3254f339047927 == 0);
						}
					}
				}
			}
		}

		// Token: 0x06000D1D RID: 3357 RVA: 0x0006FAFC File Offset: 0x0006DCFC
		public static JsonSchemaModel Create(IList<JsonSchema> schemata)
		{
			JsonSchemaModel jsonSchemaModel = new JsonSchemaModel();
			foreach (JsonSchema jsonSchema in schemata)
			{
				JsonSchemaModel.smethod_0(jsonSchemaModel, jsonSchema);
			}
			return jsonSchemaModel;
		}

		// Token: 0x06000D1E RID: 3358 RVA: 0x0006FB4C File Offset: 0x0006DD4C
		private static void smethod_0(JsonSchemaModel jsonSchemaModel_2, JsonSchema jsonSchema_0)
		{
			for (;;)
			{
				IL_0001:
				jsonSchemaModel_2.Required = jsonSchemaModel_2.Required || jsonSchema_0.Required.GetValueOrDefault();
				int num = 17;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d5af2cccac2f47ed978e804138a35d1c == 0)
				{
					goto IL_01B3;
				}
				for (;;)
				{
					IL_02F6:
					switch (num)
					{
					case 0:
					case 22:
						goto IL_014D;
					case 1:
						goto IL_01B3;
					case 2:
						goto IL_028C;
					case 3:
						goto IL_01E8;
					case 4:
						goto IL_02C8;
					case 5:
						goto IL_0099;
					case 6:
						jsonSchemaModel_2.ExclusiveMaximum = jsonSchemaModel_2.ExclusiveMaximum || jsonSchema_0.ExclusiveMaximum.GetValueOrDefault();
						goto IL_02C8;
					case 7:
						goto IL_00DD;
					case 8:
						goto IL_0275;
					case 9:
						goto IL_010F;
					case 10:
						goto IL_0244;
					case 11:
						goto IL_00C0;
					case 12:
						goto IL_004D;
					case 13:
						goto IL_00B5;
					case 14:
						goto IL_0126;
					case 15:
						goto IL_0187;
					case 16:
						return;
					case 17:
					{
						JsonSchemaType type = jsonSchemaModel_2.Type;
						JsonSchemaType? type2 = jsonSchema_0.Type;
						jsonSchemaModel_2.Type = type & ((type2 == null) ? JsonSchemaType.Any : type2.GetValueOrDefault());
						num = 8;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c08ab7af63da4f24a4fa3e9c7a732fae == 0)
						{
							goto IL_014D;
						}
						continue;
					}
					case 18:
						goto IL_0001;
					case 19:
						goto IL_0086;
					case 20:
						goto IL_016E;
					case 21:
						break;
					case 23:
						goto IL_008E;
					case 24:
						goto IL_00E8;
					case 25:
						goto IL_003B;
					default:
						goto IL_014D;
					}
					IL_0064:
					if (jsonSchema_0.Enum != null)
					{
						goto IL_0086;
					}
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_6f87b5b72b9847f7b8ec5b44b0dccfa8 == 0)
					{
						goto IL_014D;
					}
					continue;
					IL_004D:
					jsonSchemaModel_2.UniqueItems = jsonSchemaModel_2.UniqueItems || jsonSchema_0.UniqueItems;
					goto IL_0064;
					IL_003B:
					jsonSchemaModel_2.AllowAdditionalItems = jsonSchemaModel_2.AllowAdditionalItems && jsonSchema_0.AllowAdditionalItems;
					goto IL_004D;
					IL_0126:
					jsonSchemaModel_2.AllowAdditionalProperties = jsonSchemaModel_2.AllowAdditionalProperties && jsonSchema_0.AllowAdditionalProperties;
					goto IL_003B;
					IL_010F:
					jsonSchemaModel_2.PositionalItemsValidation = jsonSchemaModel_2.PositionalItemsValidation || jsonSchema_0.PositionalItemsValidation;
					goto IL_0126;
					IL_00C0:
					if (jsonSchemaModel_2.Patterns != null)
					{
						goto IL_00E8;
					}
					num = 7;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3a102d6e4dd542a6855b81a93c692545 != 0)
					{
						goto IL_00DD;
					}
					continue;
					IL_00B5:
					if (jsonSchema_0.Pattern != null)
					{
						goto IL_00C0;
					}
					return;
					IL_014D:
					jsonSchemaModel_2.Disallow |= jsonSchema_0.Disallow.GetValueOrDefault();
					goto IL_00B5;
					IL_0099:
					jsonSchemaModel_2.Enum.AddRangeDistinct(jsonSchema_0.Enum, JToken.EqualityComparer);
					goto IL_014D;
					IL_0086:
					if (jsonSchemaModel_2.Enum == null)
					{
						goto IL_008E;
					}
					goto IL_0099;
					IL_00E8:
					jsonSchemaModel_2.Patterns.AddDistinct(jsonSchema_0.Pattern);
					num = 16;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7ae4da5a55de471eb12dd0de8dd4269c != 0)
					{
						goto IL_010F;
					}
					continue;
					IL_00DD:
					jsonSchemaModel_2.Patterns = new List<string>();
					goto IL_00E8;
					IL_0244:
					jsonSchemaModel_2.MaximumItems = MathUtils.Min(jsonSchemaModel_2.MaximumItems, jsonSchema_0.MaximumItems);
					num = 9;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_bc7a9075386042ad9ce36653fcde3fc3 == 0)
					{
						goto IL_010F;
					}
					continue;
					IL_02C8:
					jsonSchemaModel_2.MinimumItems = MathUtils.Max(jsonSchemaModel_2.MinimumItems, jsonSchema_0.MinimumItems);
					num = 8;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c5a086ee5649458eb5e1e6e4f0f1f4d3 != 0)
					{
						goto IL_0244;
					}
					continue;
					IL_008E:
					jsonSchemaModel_2.Enum = new List<JToken>();
					goto IL_0099;
				}
				IL_016E:
				jsonSchemaModel_2.DivisibleBy = MathUtils.Max(jsonSchemaModel_2.DivisibleBy, jsonSchema_0.DivisibleBy);
				goto IL_01E8;
				IL_028C:
				jsonSchemaModel_2.MaximumLength = MathUtils.Min(jsonSchemaModel_2.MaximumLength, jsonSchema_0.MaximumLength);
				goto IL_016E;
				IL_0275:
				jsonSchemaModel_2.MinimumLength = MathUtils.Max(jsonSchemaModel_2.MinimumLength, jsonSchema_0.MinimumLength);
				goto IL_028C;
				IL_0187:
				jsonSchemaModel_2.Maximum = MathUtils.Max(jsonSchemaModel_2.Maximum, jsonSchema_0.Maximum);
				num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_bc7a9075386042ad9ce36653fcde3fc3 != 0)
				{
					goto IL_01B3;
				}
				goto IL_02F6;
				IL_01E8:
				jsonSchemaModel_2.Minimum = MathUtils.Max(jsonSchemaModel_2.Minimum, jsonSchema_0.Minimum);
				goto IL_0187;
				IL_01B3:
				jsonSchemaModel_2.ExclusiveMinimum = jsonSchemaModel_2.ExclusiveMinimum || jsonSchema_0.ExclusiveMinimum.GetValueOrDefault();
				num = 6;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4b8a72ce901241b5b52fe60600cb3607 != 0)
				{
					goto IL_01E8;
				}
				goto IL_02F6;
			}
		}

		// Token: 0x0400063B RID: 1595
		[CompilerGenerated]
		private bool bool_0;

		// Token: 0x0400063C RID: 1596
		[CompilerGenerated]
		private JsonSchemaType jsonSchemaType_0;

		// Token: 0x0400063D RID: 1597
		[CompilerGenerated]
		private int? nullable_0;

		// Token: 0x0400063E RID: 1598
		[CompilerGenerated]
		private int? nullable_1;

		// Token: 0x0400063F RID: 1599
		[CompilerGenerated]
		private double? nullable_2;

		// Token: 0x04000640 RID: 1600
		[CompilerGenerated]
		private double? nullable_3;

		// Token: 0x04000641 RID: 1601
		[CompilerGenerated]
		private double? nullable_4;

		// Token: 0x04000642 RID: 1602
		[CompilerGenerated]
		private bool bool_1;

		// Token: 0x04000643 RID: 1603
		[CompilerGenerated]
		private bool bool_2;

		// Token: 0x04000644 RID: 1604
		[CompilerGenerated]
		private int? IfSwweVeYW;

		// Token: 0x04000645 RID: 1605
		[CompilerGenerated]
		private int? nullable_5;

		// Token: 0x04000646 RID: 1606
		[CompilerGenerated]
		private IList<string> ilist_0;

		// Token: 0x04000647 RID: 1607
		[CompilerGenerated]
		private IList<JsonSchemaModel> ilist_1;

		// Token: 0x04000648 RID: 1608
		[CompilerGenerated]
		private IDictionary<string, JsonSchemaModel> hGbwjgoMdh;

		// Token: 0x04000649 RID: 1609
		[CompilerGenerated]
		private IDictionary<string, JsonSchemaModel> idictionary_0;

		// Token: 0x0400064A RID: 1610
		[CompilerGenerated]
		private JsonSchemaModel jsonSchemaModel_0;

		// Token: 0x0400064B RID: 1611
		[CompilerGenerated]
		private JsonSchemaModel jsonSchemaModel_1;

		// Token: 0x0400064C RID: 1612
		[CompilerGenerated]
		private bool bool_3;

		// Token: 0x0400064D RID: 1613
		[CompilerGenerated]
		private bool bool_4;

		// Token: 0x0400064E RID: 1614
		[CompilerGenerated]
		private bool bool_5;

		// Token: 0x0400064F RID: 1615
		[CompilerGenerated]
		private bool bool_6;

		// Token: 0x04000650 RID: 1616
		[CompilerGenerated]
		private IList<JToken> ilist_2;

		// Token: 0x04000651 RID: 1617
		[CompilerGenerated]
		private JsonSchemaType jsonSchemaType_1;
	}
}
