using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Schema
{
	// Token: 0x0200012D RID: 301
	[Obsolete("JSON Schema validation has been moved to its own package. See https://www.newtonsoft.com/jsonschema for more details.")]
	public class JsonSchema
	{
		// Token: 0x170001AF RID: 431
		// (get) Token: 0x06000C4E RID: 3150 RVA: 0x0000572F File Offset: 0x0000392F
		// (set) Token: 0x06000C4F RID: 3151 RVA: 0x0006B5D8 File Offset: 0x000697D8
		public string Id
		{
			[CompilerGenerated]
			get
			{
				return this.string_0;
			}
			[CompilerGenerated]
			set
			{
				for (;;)
				{
					this.string_0 = value;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8bcabc342a5a44748f3978da7f62051e != 0)
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

		// Token: 0x170001B0 RID: 432
		// (get) Token: 0x06000C50 RID: 3152 RVA: 0x00005737 File Offset: 0x00003937
		// (set) Token: 0x06000C51 RID: 3153 RVA: 0x0006B610 File Offset: 0x00069810
		public string Title
		{
			[CompilerGenerated]
			get
			{
				return this.mMwqiVobrC;
			}
			[CompilerGenerated]
			set
			{
				for (;;)
				{
					this.mMwqiVobrC = value;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5be00c24d71649dcae8af3eed7b74ac9 != 0)
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

		// Token: 0x170001B1 RID: 433
		// (get) Token: 0x06000C52 RID: 3154 RVA: 0x0000573F File Offset: 0x0000393F
		// (set) Token: 0x06000C53 RID: 3155 RVA: 0x00005747 File Offset: 0x00003947
		public bool? Required { get; set; }

		// Token: 0x170001B2 RID: 434
		// (get) Token: 0x06000C54 RID: 3156 RVA: 0x00005750 File Offset: 0x00003950
		// (set) Token: 0x06000C55 RID: 3157 RVA: 0x00005758 File Offset: 0x00003958
		public bool? ReadOnly { get; set; }

		// Token: 0x170001B3 RID: 435
		// (get) Token: 0x06000C56 RID: 3158 RVA: 0x00005761 File Offset: 0x00003961
		// (set) Token: 0x06000C57 RID: 3159 RVA: 0x00005769 File Offset: 0x00003969
		public bool? Hidden { get; set; }

		// Token: 0x170001B4 RID: 436
		// (get) Token: 0x06000C58 RID: 3160 RVA: 0x00005772 File Offset: 0x00003972
		// (set) Token: 0x06000C59 RID: 3161 RVA: 0x0000577A File Offset: 0x0000397A
		public bool? Transient { get; set; }

		// Token: 0x170001B5 RID: 437
		// (get) Token: 0x06000C5A RID: 3162 RVA: 0x00005783 File Offset: 0x00003983
		// (set) Token: 0x06000C5B RID: 3163 RVA: 0x0006B648 File Offset: 0x00069848
		public string Description
		{
			[CompilerGenerated]
			get
			{
				return this.string_1;
			}
			[CompilerGenerated]
			set
			{
				for (;;)
				{
					this.string_1 = value;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3bf07bb1c323490cb457eef2b2e78695 == 0)
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

		// Token: 0x170001B6 RID: 438
		// (get) Token: 0x06000C5C RID: 3164 RVA: 0x0000578B File Offset: 0x0000398B
		// (set) Token: 0x06000C5D RID: 3165 RVA: 0x00005793 File Offset: 0x00003993
		public JsonSchemaType? Type { get; set; }

		// Token: 0x170001B7 RID: 439
		// (get) Token: 0x06000C5E RID: 3166 RVA: 0x0000579C File Offset: 0x0000399C
		// (set) Token: 0x06000C5F RID: 3167 RVA: 0x0006B680 File Offset: 0x00069880
		public string Pattern
		{
			[CompilerGenerated]
			get
			{
				return this.string_2;
			}
			[CompilerGenerated]
			set
			{
				for (;;)
				{
					this.string_2 = value;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_6f87b5b72b9847f7b8ec5b44b0dccfa8 != 0)
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

		// Token: 0x170001B8 RID: 440
		// (get) Token: 0x06000C60 RID: 3168 RVA: 0x000057A4 File Offset: 0x000039A4
		// (set) Token: 0x06000C61 RID: 3169 RVA: 0x000057AC File Offset: 0x000039AC
		public int? MinimumLength { get; set; }

		// Token: 0x170001B9 RID: 441
		// (get) Token: 0x06000C62 RID: 3170 RVA: 0x000057B5 File Offset: 0x000039B5
		// (set) Token: 0x06000C63 RID: 3171 RVA: 0x000057BD File Offset: 0x000039BD
		public int? MaximumLength { get; set; }

		// Token: 0x170001BA RID: 442
		// (get) Token: 0x06000C64 RID: 3172 RVA: 0x000057C6 File Offset: 0x000039C6
		// (set) Token: 0x06000C65 RID: 3173 RVA: 0x000057CE File Offset: 0x000039CE
		public double? DivisibleBy { get; set; }

		// Token: 0x170001BB RID: 443
		// (get) Token: 0x06000C66 RID: 3174 RVA: 0x000057D7 File Offset: 0x000039D7
		// (set) Token: 0x06000C67 RID: 3175 RVA: 0x000057DF File Offset: 0x000039DF
		public double? Minimum { get; set; }

		// Token: 0x170001BC RID: 444
		// (get) Token: 0x06000C68 RID: 3176 RVA: 0x000057E8 File Offset: 0x000039E8
		// (set) Token: 0x06000C69 RID: 3177 RVA: 0x000057F0 File Offset: 0x000039F0
		public double? Maximum { get; set; }

		// Token: 0x170001BD RID: 445
		// (get) Token: 0x06000C6A RID: 3178 RVA: 0x000057F9 File Offset: 0x000039F9
		// (set) Token: 0x06000C6B RID: 3179 RVA: 0x00005801 File Offset: 0x00003A01
		public bool? ExclusiveMinimum { get; set; }

		// Token: 0x170001BE RID: 446
		// (get) Token: 0x06000C6C RID: 3180 RVA: 0x0000580A File Offset: 0x00003A0A
		// (set) Token: 0x06000C6D RID: 3181 RVA: 0x00005812 File Offset: 0x00003A12
		public bool? ExclusiveMaximum { get; set; }

		// Token: 0x170001BF RID: 447
		// (get) Token: 0x06000C6E RID: 3182 RVA: 0x0000581B File Offset: 0x00003A1B
		// (set) Token: 0x06000C6F RID: 3183 RVA: 0x00005823 File Offset: 0x00003A23
		public int? MinimumItems { get; set; }

		// Token: 0x170001C0 RID: 448
		// (get) Token: 0x06000C70 RID: 3184 RVA: 0x0000582C File Offset: 0x00003A2C
		// (set) Token: 0x06000C71 RID: 3185 RVA: 0x00005834 File Offset: 0x00003A34
		public int? MaximumItems { get; set; }

		// Token: 0x170001C1 RID: 449
		// (get) Token: 0x06000C72 RID: 3186 RVA: 0x0000583D File Offset: 0x00003A3D
		// (set) Token: 0x06000C73 RID: 3187 RVA: 0x00005845 File Offset: 0x00003A45
		public IList<JsonSchema> Items { get; set; }

		// Token: 0x170001C2 RID: 450
		// (get) Token: 0x06000C74 RID: 3188 RVA: 0x0000584E File Offset: 0x00003A4E
		// (set) Token: 0x06000C75 RID: 3189 RVA: 0x0006B6B8 File Offset: 0x000698B8
		public bool PositionalItemsValidation
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
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2e3be65f7cb2480482903dc73ec42f7c != 0)
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

		// Token: 0x170001C3 RID: 451
		// (get) Token: 0x06000C76 RID: 3190 RVA: 0x00005856 File Offset: 0x00003A56
		// (set) Token: 0x06000C77 RID: 3191 RVA: 0x0006B6F0 File Offset: 0x000698F0
		public JsonSchema AdditionalItems
		{
			[CompilerGenerated]
			get
			{
				return this.jsonSchema_0;
			}
			[CompilerGenerated]
			set
			{
				for (;;)
				{
					this.jsonSchema_0 = value;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f19acd91a8c44846a95d09d7dc3da2ba != 0)
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

		// Token: 0x170001C4 RID: 452
		// (get) Token: 0x06000C78 RID: 3192 RVA: 0x0000585E File Offset: 0x00003A5E
		// (set) Token: 0x06000C79 RID: 3193 RVA: 0x0006B728 File Offset: 0x00069928
		public bool AllowAdditionalItems
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
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7af5c533f30e4bd1bda86ce6098441d2 != 0)
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

		// Token: 0x170001C5 RID: 453
		// (get) Token: 0x06000C7A RID: 3194 RVA: 0x00005866 File Offset: 0x00003A66
		// (set) Token: 0x06000C7B RID: 3195 RVA: 0x0006B760 File Offset: 0x00069960
		public bool UniqueItems
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
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3bf07bb1c323490cb457eef2b2e78695 != 0)
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

		// Token: 0x170001C6 RID: 454
		// (get) Token: 0x06000C7C RID: 3196 RVA: 0x0000586E File Offset: 0x00003A6E
		// (set) Token: 0x06000C7D RID: 3197 RVA: 0x00005876 File Offset: 0x00003A76
		public IDictionary<string, JsonSchema> Properties { get; set; }

		// Token: 0x170001C7 RID: 455
		// (get) Token: 0x06000C7E RID: 3198 RVA: 0x0000587F File Offset: 0x00003A7F
		// (set) Token: 0x06000C7F RID: 3199 RVA: 0x0006B798 File Offset: 0x00069998
		public JsonSchema AdditionalProperties
		{
			[CompilerGenerated]
			get
			{
				return this.jsonSchema_1;
			}
			[CompilerGenerated]
			set
			{
				for (;;)
				{
					this.jsonSchema_1 = value;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7ae4da5a55de471eb12dd0de8dd4269c != 0)
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

		// Token: 0x170001C8 RID: 456
		// (get) Token: 0x06000C80 RID: 3200 RVA: 0x00005887 File Offset: 0x00003A87
		// (set) Token: 0x06000C81 RID: 3201 RVA: 0x0000588F File Offset: 0x00003A8F
		public IDictionary<string, JsonSchema> PatternProperties { get; set; }

		// Token: 0x170001C9 RID: 457
		// (get) Token: 0x06000C82 RID: 3202 RVA: 0x00005898 File Offset: 0x00003A98
		// (set) Token: 0x06000C83 RID: 3203 RVA: 0x0006B7D0 File Offset: 0x000699D0
		public bool AllowAdditionalProperties
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
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39d5fbfa4fe34ed9908db538e5340a6c != 0)
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

		// Token: 0x170001CA RID: 458
		// (get) Token: 0x06000C84 RID: 3204 RVA: 0x000058A0 File Offset: 0x00003AA0
		// (set) Token: 0x06000C85 RID: 3205 RVA: 0x0006B808 File Offset: 0x00069A08
		public string Requires
		{
			[CompilerGenerated]
			get
			{
				return this.string_3;
			}
			[CompilerGenerated]
			set
			{
				for (;;)
				{
					this.string_3 = value;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_67a271e0ae064fc7a3a74905868add95 != 0)
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

		// Token: 0x170001CB RID: 459
		// (get) Token: 0x06000C86 RID: 3206 RVA: 0x000058A8 File Offset: 0x00003AA8
		// (set) Token: 0x06000C87 RID: 3207 RVA: 0x000058B0 File Offset: 0x00003AB0
		public IList<JToken> Enum { get; set; }

		// Token: 0x170001CC RID: 460
		// (get) Token: 0x06000C88 RID: 3208 RVA: 0x000058B9 File Offset: 0x00003AB9
		// (set) Token: 0x06000C89 RID: 3209 RVA: 0x000058C1 File Offset: 0x00003AC1
		public JsonSchemaType? Disallow { get; set; }

		// Token: 0x170001CD RID: 461
		// (get) Token: 0x06000C8A RID: 3210 RVA: 0x000058CA File Offset: 0x00003ACA
		// (set) Token: 0x06000C8B RID: 3211 RVA: 0x0006B840 File Offset: 0x00069A40
		public JToken Default
		{
			[CompilerGenerated]
			get
			{
				return this.jtoken_0;
			}
			[CompilerGenerated]
			set
			{
				for (;;)
				{
					this.jtoken_0 = value;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_550a8fe2e5fe4cc19bdfe1a82a7f12b8 != 0)
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

		// Token: 0x170001CE RID: 462
		// (get) Token: 0x06000C8C RID: 3212 RVA: 0x000058D2 File Offset: 0x00003AD2
		// (set) Token: 0x06000C8D RID: 3213 RVA: 0x000058DA File Offset: 0x00003ADA
		public IList<JsonSchema> Extends { get; set; }

		// Token: 0x170001CF RID: 463
		// (get) Token: 0x06000C8E RID: 3214 RVA: 0x000058E3 File Offset: 0x00003AE3
		// (set) Token: 0x06000C8F RID: 3215 RVA: 0x0006B878 File Offset: 0x00069A78
		public string Format
		{
			[CompilerGenerated]
			get
			{
				return this.string_4;
			}
			[CompilerGenerated]
			set
			{
				for (;;)
				{
					this.string_4 = value;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b17e63564ae246399767b60cf4b1528a != 0)
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

		// Token: 0x170001D0 RID: 464
		// (get) Token: 0x06000C90 RID: 3216 RVA: 0x000058EB File Offset: 0x00003AEB
		// (set) Token: 0x06000C91 RID: 3217 RVA: 0x0006B8B0 File Offset: 0x00069AB0
		internal string Location
		{
			[CompilerGenerated]
			get
			{
				return this.string_5;
			}
			[CompilerGenerated]
			set
			{
				for (;;)
				{
					this.string_5 = value;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0efaea2f67ca4b0aa2880fbd34fc0fff != 0)
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

		// Token: 0x170001D1 RID: 465
		// (get) Token: 0x06000C92 RID: 3218 RVA: 0x000058F3 File Offset: 0x00003AF3
		internal string InternalId
		{
			get
			{
				return this.string_6;
			}
		}

		// Token: 0x170001D2 RID: 466
		// (get) Token: 0x06000C93 RID: 3219 RVA: 0x000058FB File Offset: 0x00003AFB
		// (set) Token: 0x06000C94 RID: 3220 RVA: 0x0006B8E8 File Offset: 0x00069AE8
		internal string DeferredReference
		{
			[CompilerGenerated]
			get
			{
				return this.string_7;
			}
			[CompilerGenerated]
			set
			{
				for (;;)
				{
					this.string_7 = value;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_55c1fea936c04e47abbfb2b5f778aff7 != 0)
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

		// Token: 0x170001D3 RID: 467
		// (get) Token: 0x06000C95 RID: 3221 RVA: 0x00005903 File Offset: 0x00003B03
		// (set) Token: 0x06000C96 RID: 3222 RVA: 0x0006B920 File Offset: 0x00069B20
		internal bool ReferencesResolved
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
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_17bdafd603b54a77a2e4a383bd4dcffa != 0)
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

		// Token: 0x06000C97 RID: 3223 RVA: 0x0006B958 File Offset: 0x00069B58
		public JsonSchema()
		{
			int num = 1;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_100d09ce3850492c8356d7fa1e667d54 != 0)
			{
				do
				{
					switch (num)
					{
					case 1:
						this.AllowAdditionalProperties = true;
						goto IL_0045;
					case 2:
						goto IL_0045;
					}
					break;
					IL_0045:
					this.AllowAdditionalItems = true;
					num = 0;
				}
				while (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bd75de9a0b64d6da3a43e57303102f1 != 0);
			}
		}

		// Token: 0x06000C98 RID: 3224 RVA: 0x0000590B File Offset: 0x00003B0B
		public static JsonSchema Read(JsonReader reader)
		{
			return JsonSchema.Read(reader, new JsonSchemaResolver());
		}

		// Token: 0x06000C99 RID: 3225 RVA: 0x0006B9E4 File Offset: 0x00069BE4
		public static JsonSchema Read(JsonReader reader, JsonSchemaResolver resolver)
		{
			for (;;)
			{
				ValidationUtils.ArgumentNotNull(reader, Class15.smethod_17(2071409762 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8db627a8c96145a0afb24deffd2a8808));
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0efaea2f67ca4b0aa2880fbd34fc0fff != 0)
				{
					goto IL_0003;
				}
				IL_002F:
				switch (num)
				{
				case 1:
					continue;
				case 2:
					goto IL_0073;
				}
				IL_0003:
				ValidationUtils.ArgumentNotNull(resolver, Class15.smethod_17(1788667458 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bd75de9a0b64d6da3a43e57303102f1));
				num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e368897ba1744663a6d0bc59b9b65b5f == 0)
				{
					goto IL_002F;
				}
				break;
			}
			IL_0073:
			return new JsonSchemaBuilder(resolver).Read(reader);
		}

		// Token: 0x06000C9A RID: 3226 RVA: 0x00005918 File Offset: 0x00003B18
		public static JsonSchema Parse(string json)
		{
			return JsonSchema.Parse(json, new JsonSchemaResolver());
		}

		// Token: 0x06000C9B RID: 3227 RVA: 0x0006BA70 File Offset: 0x00069C70
		public static JsonSchema Parse(string json, JsonSchemaResolver resolver)
		{
			JsonSchema jsonSchema;
			JsonReader jsonReader;
			for (;;)
			{
				ValidationUtils.ArgumentNotNull(json, Class15.smethod_17(1176499370 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93c7140125045538ae5c40c6f39a5af));
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c367d9ce11cc43b595beeb4524149542 == 0)
				{
					goto IL_0003;
				}
				IL_0021:
				switch (num)
				{
				case 1:
					continue;
				case 2:
					goto IL_0069;
				case 3:
					return jsonSchema;
				}
				IL_0003:
				jsonReader = new JsonTextReader(new StringReader(json));
				num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5be00c24d71649dcae8af3eed7b74ac9 != 0)
				{
					goto IL_0021;
				}
				break;
			}
			IL_0069:
			try
			{
				jsonSchema = JsonSchema.Read(jsonReader, resolver);
				int num2 = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_193800745ad94a529d9e5edc977c4f02 != 0)
				{
					switch (num2)
					{
					}
				}
			}
			finally
			{
				if (jsonReader != null)
				{
					goto IL_00BF;
				}
				int num3 = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8432da17e8384a688cea4636964d3693 != 0)
				{
					goto IL_00D8;
				}
				IL_00AB:
				switch (num3)
				{
				case 2:
					IL_00BF:
					((IDisposable)jsonReader).Dispose();
					num3 = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_676b866782704933888a7440512fd4ff != 0)
					{
						goto IL_00AB;
					}
					break;
				}
				IL_00D8:;
			}
			return jsonSchema;
		}

		// Token: 0x06000C9C RID: 3228 RVA: 0x0006BB68 File Offset: 0x00069D68
		public void WriteTo(JsonWriter writer)
		{
			for (;;)
			{
				this.WriteTo(writer, new JsonSchemaResolver());
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e6fac70dd3e841b6925374855ecd7fb1 != 0)
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

		// Token: 0x06000C9D RID: 3229 RVA: 0x0006BBA4 File Offset: 0x00069DA4
		public void WriteTo(JsonWriter writer, JsonSchemaResolver resolver)
		{
			for (;;)
			{
				ValidationUtils.ArgumentNotNull(writer, Class15.smethod_17(974433757 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_92ac2a37edba4e2587eb1b9e8af3f63f));
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0005996a6a494de4880ac2956b2e0112 != 0)
				{
					goto IL_0024;
				}
				IL_0041:
				switch (num)
				{
				case 1:
					IL_0024:
					ValidationUtils.ArgumentNotNull(resolver, Class15.smethod_17(768738286 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3baf10aa2a73406aa2bb349717d797c7));
					goto IL_0003;
				case 2:
					continue;
				case 3:
					goto IL_0003;
				}
				break;
				IL_0003:
				new JsonSchemaWriter(writer, resolver).WriteSchema(this);
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c28a4ed7a58e45aaa9902e336fd60b97 != 0)
				{
					break;
				}
				goto IL_0041;
			}
		}

		// Token: 0x06000C9E RID: 3230 RVA: 0x0006BC3C File Offset: 0x00069E3C
		public override string ToString()
		{
			StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture);
			this.WriteTo(new JsonTextWriter(stringWriter)
			{
				Formatting = Formatting.Indented
			});
			return stringWriter.ToString();
		}

		// Token: 0x040005DC RID: 1500
		[CompilerGenerated]
		private string string_0;

		// Token: 0x040005DD RID: 1501
		[CompilerGenerated]
		private string mMwqiVobrC;

		// Token: 0x040005DE RID: 1502
		[CompilerGenerated]
		private bool? nullable_0;

		// Token: 0x040005DF RID: 1503
		[CompilerGenerated]
		private bool? nullable_1;

		// Token: 0x040005E0 RID: 1504
		[CompilerGenerated]
		private bool? nullable_2;

		// Token: 0x040005E1 RID: 1505
		[CompilerGenerated]
		private bool? nullable_3;

		// Token: 0x040005E2 RID: 1506
		[CompilerGenerated]
		private string string_1;

		// Token: 0x040005E3 RID: 1507
		[CompilerGenerated]
		private JsonSchemaType? nullable_4;

		// Token: 0x040005E4 RID: 1508
		[CompilerGenerated]
		private string string_2;

		// Token: 0x040005E5 RID: 1509
		[CompilerGenerated]
		private int? nullable_5;

		// Token: 0x040005E6 RID: 1510
		[CompilerGenerated]
		private int? nullable_6;

		// Token: 0x040005E7 RID: 1511
		[CompilerGenerated]
		private double? nullable_7;

		// Token: 0x040005E8 RID: 1512
		[CompilerGenerated]
		private double? nullable_8;

		// Token: 0x040005E9 RID: 1513
		[CompilerGenerated]
		private double? nullable_9;

		// Token: 0x040005EA RID: 1514
		[CompilerGenerated]
		private bool? nullable_10;

		// Token: 0x040005EB RID: 1515
		[CompilerGenerated]
		private bool? nullable_11;

		// Token: 0x040005EC RID: 1516
		[CompilerGenerated]
		private int? nullable_12;

		// Token: 0x040005ED RID: 1517
		[CompilerGenerated]
		private int? nullable_13;

		// Token: 0x040005EE RID: 1518
		[CompilerGenerated]
		private IList<JsonSchema> ilist_0;

		// Token: 0x040005EF RID: 1519
		[CompilerGenerated]
		private bool bool_0;

		// Token: 0x040005F0 RID: 1520
		[CompilerGenerated]
		private JsonSchema jsonSchema_0;

		// Token: 0x040005F1 RID: 1521
		[CompilerGenerated]
		private bool bool_1;

		// Token: 0x040005F2 RID: 1522
		[CompilerGenerated]
		private bool bool_2;

		// Token: 0x040005F3 RID: 1523
		[CompilerGenerated]
		private IDictionary<string, JsonSchema> idictionary_0;

		// Token: 0x040005F4 RID: 1524
		[CompilerGenerated]
		private JsonSchema jsonSchema_1;

		// Token: 0x040005F5 RID: 1525
		[CompilerGenerated]
		private IDictionary<string, JsonSchema> idictionary_1;

		// Token: 0x040005F6 RID: 1526
		[CompilerGenerated]
		private bool bool_3;

		// Token: 0x040005F7 RID: 1527
		[CompilerGenerated]
		private string string_3;

		// Token: 0x040005F8 RID: 1528
		[CompilerGenerated]
		private IList<JToken> ilist_1;

		// Token: 0x040005F9 RID: 1529
		[CompilerGenerated]
		private JsonSchemaType? nullable_14;

		// Token: 0x040005FA RID: 1530
		[CompilerGenerated]
		private JToken jtoken_0;

		// Token: 0x040005FB RID: 1531
		[CompilerGenerated]
		private IList<JsonSchema> ilist_2;

		// Token: 0x040005FC RID: 1532
		[CompilerGenerated]
		private string string_4;

		// Token: 0x040005FD RID: 1533
		[CompilerGenerated]
		private string string_5;

		// Token: 0x040005FE RID: 1534
		private readonly string string_6 = Guid.NewGuid().ToString(Class15.smethod_17(1678052602 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ee35a23edd8f4998990ec1a2b40fc61a));

		// Token: 0x040005FF RID: 1535
		[CompilerGenerated]
		private string string_7;

		// Token: 0x04000600 RID: 1536
		[CompilerGenerated]
		private bool bool_4;
	}
}
