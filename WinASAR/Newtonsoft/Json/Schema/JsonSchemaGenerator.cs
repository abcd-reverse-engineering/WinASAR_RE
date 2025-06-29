using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Schema
{
	// Token: 0x02000132 RID: 306
	[Obsolete("JSON Schema validation has been moved to its own package. See https://www.newtonsoft.com/jsonschema for more details.")]
	public class JsonSchemaGenerator
	{
		// Token: 0x170001D7 RID: 471
		// (get) Token: 0x06000CCA RID: 3274 RVA: 0x00005987 File Offset: 0x00003B87
		// (set) Token: 0x06000CCB RID: 3275 RVA: 0x0006E478 File Offset: 0x0006C678
		public UndefinedSchemaIdHandling UndefinedSchemaIdHandling
		{
			[CompilerGenerated]
			get
			{
				return this.undefinedSchemaIdHandling_0;
			}
			[CompilerGenerated]
			set
			{
				for (;;)
				{
					this.undefinedSchemaIdHandling_0 = value;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2a74c5ebb7d84adcad853e2eda393dc4 != 0)
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

		// Token: 0x170001D8 RID: 472
		// (get) Token: 0x06000CCC RID: 3276 RVA: 0x0006E4B0 File Offset: 0x0006C6B0
		// (set) Token: 0x06000CCD RID: 3277 RVA: 0x0006E4FC File Offset: 0x0006C6FC
		public IContractResolver ContractResolver
		{
			get
			{
				while (this.icontractResolver_0 == null)
				{
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5be00c24d71649dcae8af3eed7b74ac9 == 0)
					{
						switch (num)
						{
						case 1:
							continue;
						}
					}
					return DefaultContractResolver.Instance;
				}
				return this.icontractResolver_0;
			}
			set
			{
				for (;;)
				{
					this.icontractResolver_0 = value;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cbfb1e54efd84756a9b6d7b21adc0d65 == 0)
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

		// Token: 0x06000CCE RID: 3278 RVA: 0x0000598F File Offset: 0x00003B8F
		private JsonSchema method_0()
		{
			return this.jsonSchema_0;
		}

		// Token: 0x06000CCF RID: 3279 RVA: 0x0006E534 File Offset: 0x0006C734
		private void method_1(JsonSchemaGenerator.Class8 class8_0)
		{
			for (;;)
			{
				this.jsonSchema_0 = class8_0.method_0();
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_100d09ce3850492c8356d7fa1e667d54 != 0)
				{
					goto IL_002D;
				}
				IL_004D:
				switch (num)
				{
				case 0:
					goto IL_002D;
				case 1:
					continue;
				case 2:
					break;
				case 3:
					return;
				default:
					goto IL_002D;
				}
				IL_0003:
				this.jsonSchemaResolver_0.LoadedSchemas.Add(class8_0.method_0());
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d6c400f349964629bcd869033695bff0 == 0)
				{
					break;
				}
				goto IL_004D;
				IL_002D:
				this.ilist_0.Add(class8_0);
				num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0b405dced5e94c80928a74c5773182d9 == 0)
				{
					goto IL_0003;
				}
				goto IL_004D;
			}
		}

		// Token: 0x06000CD0 RID: 3280 RVA: 0x0006E5C8 File Offset: 0x0006C7C8
		private JsonSchemaGenerator.Class8 method_2()
		{
			JsonSchemaGenerator.Class8 @class = this.ilist_0[this.ilist_0.Count - 1];
			this.ilist_0.RemoveAt(this.ilist_0.Count - 1);
			JsonSchemaGenerator.Class8 class2 = this.ilist_0.LastOrDefault<JsonSchemaGenerator.Class8>();
			if (class2 == null)
			{
				this.jsonSchema_0 = null;
				return @class;
			}
			this.jsonSchema_0 = class2.method_0();
			return @class;
		}

		// Token: 0x06000CD1 RID: 3281 RVA: 0x00005997 File Offset: 0x00003B97
		public JsonSchema Generate(Type type)
		{
			return this.Generate(type, new JsonSchemaResolver(), false);
		}

		// Token: 0x06000CD2 RID: 3282 RVA: 0x000059A6 File Offset: 0x00003BA6
		public JsonSchema Generate(Type type, JsonSchemaResolver resolver)
		{
			return this.Generate(type, resolver, false);
		}

		// Token: 0x06000CD3 RID: 3283 RVA: 0x000059B1 File Offset: 0x00003BB1
		public JsonSchema Generate(Type type, bool rootSchemaNullable)
		{
			return this.Generate(type, new JsonSchemaResolver(), rootSchemaNullable);
		}

		// Token: 0x06000CD4 RID: 3284 RVA: 0x0006E62C File Offset: 0x0006C82C
		public JsonSchema Generate(Type type, JsonSchemaResolver resolver, bool rootSchemaNullable)
		{
			for (;;)
			{
				IL_0062:
				ValidationUtils.ArgumentNotNull(type, Class15.smethod_17(1985296916 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f19acd91a8c44846a95d09d7dc3da2ba));
				for (;;)
				{
					ValidationUtils.ArgumentNotNull(resolver, Class15.smethod_17(41474425 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_079bd9b874b24353bef46f6c3f5d741d));
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b17e63564ae246399767b60cf4b1528a == 0)
					{
						goto IL_0003;
					}
					IL_001B:
					switch (num)
					{
					case 1:
						goto IL_0080;
					case 2:
						continue;
					case 3:
						goto IL_0062;
					}
					IL_0003:
					this.jsonSchemaResolver_0 = resolver;
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4b8a72ce901241b5b52fe60600cb3607 == 0)
					{
						goto IL_001B;
					}
					goto IL_007F;
				}
			}
			IL_007F:
			IL_0080:
			return this.method_6(type, rootSchemaNullable ? Required.Default : Required.Always, false);
		}

		// Token: 0x06000CD5 RID: 3285 RVA: 0x0006E6C8 File Offset: 0x0006C8C8
		private string method_3(Type type_0)
		{
			JsonContainerAttribute cachedAttribute;
			for (;;)
			{
				IL_005C:
				cachedAttribute = JsonTypeReflector.GetCachedAttribute<JsonContainerAttribute>(type_0);
				for (;;)
				{
					string text;
					if (cachedAttribute != null)
					{
						text = cachedAttribute.Title;
						goto IL_0037;
					}
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c5a086ee5649458eb5e1e6e4f0f1f4d3 != 0)
					{
						goto IL_0036;
					}
					IL_001D:
					switch (num)
					{
					default:
						IL_0036:
						text = null;
						break;
					case 1:
						goto IL_0067;
					case 2:
						goto IL_0069;
					case 3:
						continue;
					case 4:
						goto IL_005C;
					}
					IL_0037:
					if (!StringUtils.IsNullOrEmpty(text))
					{
						goto IL_0069;
					}
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_eaded84ad5b14e1ea8d4d97bfed1bb48 != 0)
					{
						goto IL_001D;
					}
					goto IL_0066;
				}
			}
			IL_0066:
			IL_0067:
			return null;
			IL_0069:
			return cachedAttribute.Title;
		}

		// Token: 0x06000CD6 RID: 3286 RVA: 0x0006E748 File Offset: 0x0006C948
		private string method_4(Type type_0)
		{
			JsonContainerAttribute cachedAttribute;
			DescriptionAttribute attribute;
			for (;;)
			{
				cachedAttribute = JsonTypeReflector.GetCachedAttribute<JsonContainerAttribute>(type_0);
				int num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_550a8fe2e5fe4cc19bdfe1a82a7f12b8 == 0)
				{
					goto IL_0003;
				}
				IL_004A:
				string text;
				switch (num)
				{
				case 1:
					text = null;
					goto IL_0022;
				case 2:
					IL_0029:
					attribute = ReflectionUtils.GetAttribute<DescriptionAttribute>(type_0);
					if (attribute != null)
					{
						goto IL_008F;
					}
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39d5fbfa4fe34ed9908db538e5340a6c != 0)
					{
						goto IL_004A;
					}
					break;
				case 3:
					IL_0003:
					if (cachedAttribute != null)
					{
						text = cachedAttribute.Description;
						goto IL_0022;
					}
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bd75de9a0b64d6da3a43e57303102f1 != 0)
					{
						goto IL_004A;
					}
					break;
				case 4:
					continue;
				case 5:
					goto IL_0095;
				}
				break;
				IL_0022:
				if (StringUtils.IsNullOrEmpty(text))
				{
					goto IL_0029;
				}
				goto IL_0095;
			}
			return null;
			IL_008F:
			return attribute.Description;
			IL_0095:
			return cachedAttribute.Description;
		}

		// Token: 0x06000CD7 RID: 3287 RVA: 0x0006E7F4 File Offset: 0x0006C9F4
		private string method_5(Type type_0, bool bool_0)
		{
			JsonContainerAttribute cachedAttribute;
			for (;;)
			{
				IL_00C5:
				cachedAttribute = JsonTypeReflector.GetCachedAttribute<JsonContainerAttribute>(type_0);
				for (;;)
				{
					if (cachedAttribute == null)
					{
						goto IL_00AD;
					}
					string text = cachedAttribute.Id;
					IL_00AE:
					if (!StringUtils.IsNullOrEmpty(text))
					{
						goto IL_00E5;
					}
					int num = 4;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_aa43e77a676848e0bd70abf647d6a9f1 == 0)
					{
						goto IL_0045;
					}
					IL_007D:
					UndefinedSchemaIdHandling undefinedSchemaIdHandling;
					switch (num)
					{
					case 1:
						goto IL_00DC;
					case 2:
						goto IL_00E5;
					case 3:
						goto IL_0064;
					case 4:
						IL_0045:
						if (!bool_0)
						{
							undefinedSchemaIdHandling = this.UndefinedSchemaIdHandling;
							goto IL_0064;
						}
						num = 6;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4ac69ea2381b403582a2723337f67fa8 == 0)
						{
							goto Block_5;
						}
						goto IL_007D;
					case 5:
						goto IL_00AD;
					case 6:
						goto IL_00D9;
					case 7:
						goto IL_0026;
					case 8:
						continue;
					case 9:
						goto IL_00C5;
					}
					goto Block_8;
					IL_0026:
					if (undefinedSchemaIdHandling == UndefinedSchemaIdHandling.UseAssemblyQualifiedName)
					{
						goto IL_00DE;
					}
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ee35a23edd8f4998990ec1a2b40fc61a != 0)
					{
						goto Block_3;
					}
					goto IL_007D;
					IL_0064:
					if (undefinedSchemaIdHandling == UndefinedSchemaIdHandling.UseTypeName)
					{
						goto IL_00D2;
					}
					num = 4;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9f9b31fb7a85497499112abf86cccc98 != 0)
					{
						goto IL_0026;
					}
					goto IL_007D;
					IL_00AD:
					text = null;
					goto IL_00AE;
				}
			}
			Block_3:
			Block_5:
			goto IL_00DC;
			Block_8:
			IL_00D2:
			return type_0.FullName;
			IL_00D9:
			return null;
			IL_00DC:
			return null;
			IL_00DE:
			return type_0.AssemblyQualifiedName;
			IL_00E5:
			return cachedAttribute.Id;
		}

		// Token: 0x06000CD8 RID: 3288 RVA: 0x0006E8F0 File Offset: 0x0006CAF0
		private JsonSchema method_6(Type type_0, Required required_0, bool bool_0)
		{
			JsonSchemaGenerator.<>c__DisplayClass23_0 CS$<>8__locals1;
			JsonSchema schema;
			JsonContract jsonContract;
			bool flag2;
			bool? required;
			for (;;)
			{
				IL_0795:
				CS$<>8__locals1 = new JsonSchemaGenerator.<>c__DisplayClass23_0();
				int num = 9;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_48fe014748e848c88d3254f339047927 != 0)
				{
					goto IL_062B;
				}
				string text;
				for (;;)
				{
					IL_064D:
					int num2;
					JsonArrayAttribute cachedAttribute;
					bool flag;
					JsonSchemaType? jsonSchemaType;
					Type collectionItemType;
					string text2;
					JsonSchemaType jsonSchemaType2;
					JToken jtoken;
					JsonContractType contractType;
					switch (num)
					{
					case 0:
						goto IL_05B5;
					case 1:
						num2 = 0;
						goto IL_0340;
					case 2:
						goto IL_0851;
					case 3:
						goto IL_01DF;
					case 4:
						goto IL_08AC;
					case 5:
						if (cachedAttribute == null)
						{
							flag = true;
							goto IL_052F;
						}
						goto IL_0528;
					case 6:
					case 24:
						return schema;
					case 7:
					case 13:
					case 14:
					case 15:
					case 26:
					case 28:
					case 35:
					case 61:
					case 75:
					case 77:
						goto IL_08D8;
					case 8:
						goto IL_03E3;
					case 9:
						goto IL_07B6;
					case 10:
						goto IL_0864;
					case 11:
						goto IL_0095;
					case 12:
						goto IL_01F8;
					case 16:
						goto IL_0569;
					case 17:
						goto IL_0592;
					case 18:
						goto IL_05B8;
					case 19:
						goto IL_00F1;
					case 20:
						goto IL_062B;
					case 21:
						goto IL_0795;
					case 22:
					case 72:
						goto IL_026B;
					case 23:
						goto IL_0123;
					case 25:
						goto IL_024E;
					case 27:
						goto IL_0562;
					case 29:
					case 54:
						goto IL_0340;
					case 30:
						goto IL_0350;
					case 31:
						goto IL_0183;
					case 32:
						goto IL_087D;
					case 33:
					case 42:
						goto IL_07D4;
					case 34:
						if (StringUtils.IsNullOrEmpty(text))
						{
							goto IL_026B;
						}
						goto IL_0608;
					case 36:
						goto IL_0490;
					case 37:
						goto IL_029C;
					case 38:
						goto IL_014B;
					case 39:
						goto IL_00C3;
					case 40:
						goto IL_0211;
					case 41:
						goto IL_0608;
					case 43:
						jsonSchemaType = this.method_0().Type;
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_67a271e0ae064fc7a3a74905868add95 == 0)
						{
							goto IL_05B5;
						}
						continue;
					case 44:
						IL_0531:
						collectionItemType = ReflectionUtils.GetCollectionItemType(CS$<>8__locals1.type_0);
						goto IL_03E3;
					case 45:
						this.method_0().Enum = new List<JToken>();
						goto IL_0592;
					case 46:
						goto IL_0024;
					case 47:
						goto IL_0544;
					case 48:
						goto IL_0818;
					case 49:
						goto IL_035C;
					case 50:
						goto IL_0801;
					case 51:
						goto IL_0429;
					case 52:
						goto IL_039D;
					case 53:
						goto IL_0528;
					case 55:
						goto IL_010A;
					case 56:
						text2 = this.method_5(CS$<>8__locals1.type_0, true);
						num = 34;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d97e64d0f425406b9649f2b4562a5f0e == 0)
						{
							goto IL_0095;
						}
						continue;
					case 57:
						IL_01B3:
						this.method_0().Type = new JsonSchemaType?(jsonSchemaType2);
						num = 2;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cbfb1e54efd84756a9b6d7b21adc0d65 == 0)
						{
							goto Block_7;
						}
						continue;
					case 58:
						goto IL_04C6;
					case 59:
						goto IL_01A9;
					case 60:
						goto IL_047F;
					case 62:
						goto IL_02BC;
					case 63:
						this.method_0().Enum.Add(jtoken);
						num = 70;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_55c1fea936c04e47abbfb2b5f778aff7 != 0)
						{
							goto IL_0340;
						}
						continue;
					case 64:
					case 76:
						goto IL_023F;
					case 65:
						goto IL_0067;
					case 66:
						goto IL_03AD;
					case 67:
						goto IL_0897;
					case 68:
						goto IL_088D;
					case 69:
						goto IL_03F3;
					case 70:
						num2++;
						goto IL_0340;
					case 71:
						goto IL_01A6;
					case 73:
						goto IL_08C6;
					case 74:
						goto IL_0245;
					case 78:
						IL_0006:
						contractType = jsonContract.ContractType;
						num = 38;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_193800745ad94a529d9e5edc977c4f02 == 0)
						{
							goto IL_0024;
						}
						continue;
					default:
						goto IL_05B5;
					}
					IL_02C3:
					this.method_1(new JsonSchemaGenerator.Class8(CS$<>8__locals1.type_0, new JsonSchema()));
					if (text2 != null)
					{
						this.method_0().Id = text2;
					}
					if (bool_0)
					{
						this.method_0().Required = new bool?(true);
					}
					this.method_0().Title = this.method_3(CS$<>8__locals1.type_0);
					this.method_0().Description = this.method_4(CS$<>8__locals1.type_0);
					JsonConverter jsonConverter;
					if (jsonConverter != null)
					{
						goto Block_14;
					}
					goto IL_0006;
					IL_029C:
					if ((jsonConverter = jsonContract.Converter) != null)
					{
						goto IL_02C3;
					}
					num = 15;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_207f975845fc40cdbe6b166fce664cd5 == 0)
					{
						goto IL_02BC;
					}
					continue;
					IL_026B:
					if (!this.ilist_0.Any(new Func<JsonSchemaGenerator.Class8, bool>(CS$<>8__locals1.xIvLtjolhL)))
					{
						jsonContract = this.ContractResolver.ResolveContract(CS$<>8__locals1.type_0);
						goto IL_029C;
					}
					goto IL_0818;
					IL_0024:
					switch (contractType)
					{
					case JsonContractType.Object:
						IL_0067:
						this.method_0().Type = new JsonSchemaType?(this.method_7(JsonSchemaType.Object, required_0));
						num = 1;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_948fa5c193d44e279b41c3a0fab7b5c9 != 0)
						{
							continue;
						}
						break;
					case JsonContractType.Array:
						IL_00F1:
						this.method_0().Type = new JsonSchemaType?(this.method_7(JsonSchemaType.Array, required_0));
						goto IL_010A;
					case JsonContractType.Primitive:
						IL_014B:
						this.method_0().Type = new JsonSchemaType?(this.method_11(CS$<>8__locals1.type_0, required_0));
						num = 43;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ae8c3d3c66a64b57beca0f5360302062 != 0)
						{
							goto Block_5;
						}
						continue;
					case JsonContractType.String:
						IL_0183:
						if (ReflectionUtils.IsNullable(jsonContract.UnderlyingType))
						{
							goto IL_01A9;
						}
						num = 34;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d5af2cccac2f47ed978e804138a35d1c != 0)
						{
							goto IL_01A6;
						}
						continue;
					case JsonContractType.Dictionary:
						goto IL_0864;
					case JsonContractType.Dynamic:
					case JsonContractType.Linq:
						goto IL_08C6;
					case JsonContractType.Serializable:
						IL_01DF:
						this.method_0().Type = new JsonSchemaType?(this.method_7(JsonSchemaType.Object, required_0));
						goto IL_01F8;
					default:
						num = 42;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ee35a23edd8f4998990ec1a2b40fc61a == 0)
						{
							goto Block_2;
						}
						continue;
					}
					IL_0095:
					this.method_0().Id = this.method_5(CS$<>8__locals1.type_0, false);
					num = 34;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3a102d6e4dd542a6855b81a93c692545 != 0)
					{
						continue;
					}
					IL_00C3:
					this.method_9(CS$<>8__locals1.type_0, (JsonObjectContract)jsonContract);
					num = 17;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa49bb51056944098afe92e3a80a544b != 0)
					{
						goto Block_3;
					}
					continue;
					IL_0123:
					cachedAttribute = JsonTypeReflector.GetCachedAttribute<JsonArrayAttribute>(CS$<>8__locals1.type_0);
					num = 5;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_48fe014748e848c88d3254f339047927 == 0)
					{
						goto IL_01DF;
					}
					continue;
					IL_010A:
					this.method_0().Id = this.method_5(CS$<>8__locals1.type_0, false);
					goto IL_0123;
					IL_01B1:
					JsonSchemaType jsonSchemaType3;
					jsonSchemaType2 = jsonSchemaType3;
					goto IL_01B3;
					IL_01A9:
					jsonSchemaType3 = this.method_7(JsonSchemaType.String, required_0);
					goto IL_01B1;
					IL_01A6:
					jsonSchemaType3 = JsonSchemaType.String;
					goto IL_01B1;
					IL_0211:
					this.method_10(CS$<>8__locals1.type_0, (JsonISerializableContract)jsonContract);
					num = 7;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_48fe014748e848c88d3254f339047927 == 0)
					{
						goto Block_8;
					}
					continue;
					IL_01F8:
					this.method_0().Id = this.method_5(CS$<>8__locals1.type_0, false);
					goto IL_0211;
					IL_024E:
					flag2 = true;
					num = 9;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_48fe014748e848c88d3254f339047927 == 0)
					{
						goto IL_01DF;
					}
					continue;
					IL_0245:
					required = schema.Required;
					goto IL_024E;
					IL_023F:
					if (bool_0)
					{
						goto IL_0245;
					}
					return schema;
					IL_0569:
					if (JsonSchemaGenerator.HasFlag(schema.Type, JsonSchemaType.Null))
					{
						goto IL_023F;
					}
					goto IL_04C6;
					IL_0562:
					if (required_0 != Required.Always)
					{
						goto IL_0569;
					}
					goto IL_023F;
					IL_0544:
					if (schema != null)
					{
						goto IL_0562;
					}
					num = 2;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2e3be65f7cb2480482903dc73ec42f7c == 0)
					{
						goto IL_026B;
					}
					continue;
					IL_0608:
					schema = this.jsonSchemaResolver_0.GetSchema(text);
					goto IL_0544;
					IL_04C6:
					JsonSchema jsonSchema = schema;
					jsonSchemaType = jsonSchema.Type;
					jsonSchema.Type = jsonSchemaType | JsonSchemaType.Null;
					goto IL_023F;
					IL_035C:
					ulong num3;
					jtoken = JToken.FromObject(Enum.ToObject(CS$<>8__locals1.type_0, num3));
					num = 63;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93c7140125045538ae5c40c6f39a5af == 0)
					{
						goto IL_03E3;
					}
					continue;
					IL_0350:
					EnumInfo enumValuesAndNames;
					num3 = enumValuesAndNames.Values[num2];
					goto IL_035C;
					IL_0340:
					if (num2 < enumValuesAndNames.Names.Length)
					{
						goto IL_0350;
					}
					goto IL_08D8;
					IL_03AD:
					bool flag3;
					this.method_0().Items.Add(this.method_6(collectionItemType, flag3 ? Required.Default : Required.Always, false));
					num = 13;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0005996a6a494de4880ac2956b2e0112 == 0)
					{
						goto IL_03E3;
					}
					continue;
					IL_039D:
					this.method_0().Items = new List<JsonSchema>();
					goto IL_03AD;
					IL_03E3:
					if (!(collectionItemType != null))
					{
						goto IL_08D8;
					}
					num = 23;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_67cbcb2ad04040d48847c1ca2f65be32 == 0)
					{
						goto IL_039D;
					}
					continue;
					IL_052F:
					flag3 = flag;
					goto IL_0531;
					IL_0528:
					flag = cachedAttribute.AllowNullItems;
					goto IL_052F;
					IL_0490:
					if (CS$<>8__locals1.type_0.IsDefined(typeof(FlagsAttribute), true))
					{
						goto IL_08D8;
					}
					num = 45;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c5a086ee5649458eb5e1e6e4f0f1f4d3 == 0)
					{
						break;
					}
					continue;
					IL_047F:
					if (CS$<>8__locals1.type_0.IsEnum())
					{
						goto IL_0490;
					}
					goto IL_08D8;
					IL_05B8:
					JsonSchemaType jsonSchemaType4;
					if ((jsonSchemaType.GetValueOrDefault() == jsonSchemaType4) & (jsonSchemaType != null))
					{
						goto IL_047F;
					}
					num = 26;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_55c1fea936c04e47abbfb2b5f778aff7 != 0)
					{
						goto IL_00F1;
					}
					continue;
					IL_05B5:
					jsonSchemaType4 = JsonSchemaType.Integer;
					goto IL_05B8;
					IL_0592:
					enumValuesAndNames = EnumUtils.GetEnumValuesAndNames(CS$<>8__locals1.type_0);
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_370349efcd7c4959a098549c3d5bf14d == 0)
					{
						goto IL_05B5;
					}
					continue;
					IL_02BC:
					jsonConverter = jsonContract.InternalConverter;
					goto IL_02C3;
				}
				continue;
				IL_03F3:
				ValidationUtils.ArgumentNotNull(CS$<>8__locals1.type_0, Class15.smethod_17(2008565603 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5c76a4eb2c1748d1bee3513c8eaff2eb));
				num = 46;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa29cbda752f45acbe81e7d5285df2ba != 0)
				{
					goto IL_0429;
				}
				goto IL_064D;
				IL_062B:
				CS$<>8__locals1.type_0 = type_0;
				goto IL_03F3;
				IL_0429:
				text = this.method_5(CS$<>8__locals1.type_0, false);
				num = 56;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_6f87b5b72b9847f7b8ec5b44b0dccfa8 != 0)
				{
					break;
				}
				goto IL_064D;
			}
			Block_2:
			Block_3:
			goto IL_08D8;
			Block_5:
			goto IL_0851;
			Block_7:
			Block_8:
			goto IL_08D8;
			Block_14:
			goto IL_0801;
			goto IL_08D8;
			IL_07B6:
			if ((required.GetValueOrDefault() == flag2) & (required != null))
			{
				return schema;
			}
			goto IL_0851;
			IL_07D4:
			throw new JsonException(Class15.smethod_17(552156158 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_01137da6c88c4265bdc0297aacf3340f).FormatWith(CultureInfo.InvariantCulture, jsonContract));
			IL_0801:
			this.method_0().Type = new JsonSchemaType?(JsonSchemaType.Any);
			goto IL_08D8;
			IL_0818:
			throw new JsonException(Class15.smethod_17(299915249 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d97e64d0f425406b9649f2b4562a5f0e).FormatWith(CultureInfo.InvariantCulture, CS$<>8__locals1.type_0));
			IL_0851:
			schema.Required = new bool?(true);
			return schema;
			IL_0864:
			this.method_0().Type = new JsonSchemaType?(this.method_7(JsonSchemaType.Object, required_0));
			IL_087D:
			Type type;
			Type type2;
			ReflectionUtils.GetDictionaryKeyValueTypes(CS$<>8__locals1.type_0, out type, out type2);
			IL_088D:
			if (!(type != null))
			{
				goto IL_08D8;
			}
			IL_0897:
			if (this.ContractResolver.ResolveContract(type).ContractType != JsonContractType.Primitive)
			{
				goto IL_08D8;
			}
			IL_08AC:
			this.method_0().AdditionalProperties = this.method_6(type2, Required.Default, false);
			goto IL_08D8;
			IL_08C6:
			this.method_0().Type = new JsonSchemaType?(JsonSchemaType.Any);
			IL_08D8:
			return this.method_2().method_0();
		}

		// Token: 0x06000CD9 RID: 3289 RVA: 0x0006F1E0 File Offset: 0x0006D3E0
		private JsonSchemaType method_7(JsonSchemaType jsonSchemaType_0, Required required_0)
		{
			while (required_0 != Required.Always)
			{
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_676b866782704933888a7440512fd4ff != 0)
				{
					switch (num)
					{
					case 1:
						continue;
					}
				}
				return jsonSchemaType_0 | JsonSchemaType.Null;
			}
			return jsonSchemaType_0;
		}

		// Token: 0x06000CDA RID: 3290 RVA: 0x00004FC2 File Offset: 0x000031C2
		private bool method_8(DefaultValueHandling defaultValueHandling_0, DefaultValueHandling defaultValueHandling_1)
		{
			return (defaultValueHandling_0 & defaultValueHandling_1) == defaultValueHandling_1;
		}

		// Token: 0x06000CDB RID: 3291 RVA: 0x0006F220 File Offset: 0x0006D420
		private void method_9(Type type_0, JsonObjectContract jsonObjectContract_0)
		{
			for (;;)
			{
				IL_0224:
				this.method_0().Properties = new Dictionary<string, JsonSchema>();
				for (;;)
				{
					IL_0215:
					IEnumerator<JsonProperty> enumerator = jsonObjectContract_0.Properties.GetEnumerator();
					for (;;)
					{
						try
						{
							IL_0188:
							while (enumerator.MoveNext())
							{
								JsonProperty jsonProperty;
								JsonSchema jsonSchema;
								for (;;)
								{
									IL_0160:
									jsonProperty = enumerator.Current;
									IL_0154:
									while (!jsonProperty.Ignored)
									{
										for (;;)
										{
											NullValueHandling? nullValueHandling = jsonProperty.NullValueHandling;
											int num = 12;
											if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4ac69ea2381b403582a2723337f67fa8 == 0)
											{
												goto IL_0072;
											}
											IL_00E9:
											NullValueHandling nullValueHandling2;
											bool flag;
											switch (num)
											{
											case 0:
												goto IL_003C;
											case 1:
												goto IL_016F;
											case 2:
												break;
											case 3:
												continue;
											case 4:
												goto IL_008A;
											case 5:
												goto IL_0075;
											case 6:
												goto IL_0048;
											case 7:
											case 14:
												goto IL_0188;
											case 8:
												goto IL_0154;
											case 9:
												goto IL_0160;
											case 10:
												if (jsonProperty.ShouldSerialize != null)
												{
													goto IL_00BA;
												}
												break;
											case 11:
												goto IL_00BA;
											case 12:
												IL_0072:
												nullValueHandling2 = NullValueHandling.Ignore;
												goto IL_0075;
											case 13:
												IL_000C:
												jsonSchema = this.method_6(jsonProperty.PropertyType, jsonProperty.Required, !flag);
												num = 0;
												if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa29cbda752f45acbe81e7d5285df2ba != 0)
												{
													goto IL_003C;
												}
												goto IL_00E9;
											case 15:
												goto IL_0191;
											default:
												goto IL_003C;
											}
											bool flag2 = jsonProperty.GetIsSpecified != null;
											goto IL_00BB;
											IL_0048:
											jsonSchema.Default = JToken.FromObject(jsonProperty.DefaultValue);
											num = 0;
											if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f77f8ab5a3534e2e914063d52217b4e1 == 0)
											{
												goto Block_5;
											}
											goto IL_00E9;
											IL_003C:
											if (jsonProperty.DefaultValue != null)
											{
												goto IL_0048;
											}
											goto IL_016F;
											IL_008A:
											if (this.method_8(jsonProperty.DefaultValueHandling.GetValueOrDefault(), DefaultValueHandling.Ignore))
											{
												goto IL_00BA;
											}
											num = 10;
											if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_991c06e999c744809f5b643cb7d9e7b4 == 0)
											{
												goto Block_7;
											}
											goto IL_00E9;
											IL_0075:
											if (!((nullValueHandling.GetValueOrDefault() == nullValueHandling2) & (nullValueHandling != null)))
											{
												goto IL_008A;
											}
											goto IL_00BA;
											IL_00BB:
											flag = flag2;
											num = 13;
											if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_948fa5c193d44e279b41c3a0fab7b5c9 == 0)
											{
												goto IL_000C;
											}
											goto IL_00E9;
											IL_00BA:
											flag2 = true;
											goto IL_00BB;
										}
									}
									break;
								}
								Block_7:
								continue;
								IL_016F:
								this.method_0().Properties.Add(jsonProperty.PropertyName, jsonSchema);
								continue;
								Block_5:
								goto IL_016F;
							}
							IL_0191:
							goto IL_0204;
						}
						finally
						{
							if (enumerator != null)
							{
								int num2 = 1;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39d5fbfa4fe34ed9908db538e5340a6c == 0)
								{
									goto IL_01C1;
								}
								IL_01A9:
								enumerator.Dispose();
								num2 = 0;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_193800745ad94a529d9e5edc977c4f02 != 0)
								{
									goto IL_01D2;
								}
								IL_01C1:
								switch (num2)
								{
								case 1:
									goto IL_01A9;
								}
							}
							IL_01D2:;
						}
						IL_01D3:
						int num3 = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_370349efcd7c4959a098549c3d5bf14d == 0)
						{
							switch (num3)
							{
							case 1:
								goto IL_0204;
							case 2:
								goto IL_0215;
							case 3:
								goto IL_0224;
							case 4:
								continue;
							case 5:
								return;
							}
							goto Block_3;
						}
						goto IL_0236;
						IL_0204:
						if (type_0.IsSealed())
						{
							goto IL_01D3;
						}
						return;
					}
				}
			}
			Block_3:
			IL_0236:
			this.method_0().AllowAdditionalProperties = false;
		}

		// Token: 0x06000CDC RID: 3292 RVA: 0x0006F48C File Offset: 0x0006D68C
		private void method_10(Type type_0, JsonISerializableContract jsonISerializableContract_0)
		{
			for (;;)
			{
				this.method_0().AllowAdditionalProperties = true;
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_75738dd4edc84122bfe3748a1ea03d43 == 0)
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

		// Token: 0x06000CDD RID: 3293 RVA: 0x0006F4C8 File Offset: 0x0006D6C8
		internal static bool HasFlag(JsonSchemaType? value, JsonSchemaType flag)
		{
			if (value == null)
			{
				return true;
			}
			JsonSchemaType? jsonSchemaType = value & flag;
			if ((jsonSchemaType.GetValueOrDefault() == flag) & (jsonSchemaType != null))
			{
				return true;
			}
			if (flag == JsonSchemaType.Integer)
			{
				jsonSchemaType = value & JsonSchemaType.Float;
				if ((jsonSchemaType.GetValueOrDefault() == JsonSchemaType.Float) & (jsonSchemaType != null))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06000CDE RID: 3294 RVA: 0x0006F564 File Offset: 0x0006D764
		private JsonSchemaType method_11(Type type_0, Required required_0)
		{
			JsonSchemaType jsonSchemaType;
			for (;;)
			{
				IL_005E:
				jsonSchemaType = JsonSchemaType.None;
				IL_0057:
				while (required_0 != Required.Always)
				{
					IL_004C:
					while (ReflectionUtils.IsNullable(type_0))
					{
						for (;;)
						{
							jsonSchemaType = JsonSchemaType.Null;
							int num = 0;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_67cbcb2ad04040d48847c1ca2f65be32 == 0)
							{
								switch (num)
								{
								case 1:
									continue;
								case 2:
									goto IL_012E;
								case 3:
									goto IL_0057;
								case 4:
									goto IL_005E;
								case 5:
									goto IL_006C;
								case 6:
								case 7:
									goto IL_0074;
								case 8:
									goto IL_014C;
								case 9:
									goto IL_004C;
								case 10:
									goto IL_007C;
								}
								goto Block_2;
							}
							goto IL_0063;
						}
					}
					break;
				}
				goto IL_0074;
			}
			Block_2:
			goto IL_0064;
			goto IL_0074;
			IL_0063:
			IL_0064:
			if (!ReflectionUtils.IsNullableType(type_0))
			{
				goto IL_0074;
			}
			IL_006C:
			type_0 = Nullable.GetUnderlyingType(type_0);
			IL_0074:
			PrimitiveTypeCode typeCode = ConvertUtils.GetTypeCode(type_0);
			IL_007C:
			switch (typeCode)
			{
			case PrimitiveTypeCode.Empty:
			case PrimitiveTypeCode.Object:
				IL_012E:
				return jsonSchemaType | JsonSchemaType.String;
			case PrimitiveTypeCode.Char:
				return jsonSchemaType | JsonSchemaType.String;
			case PrimitiveTypeCode.Boolean:
				return jsonSchemaType | JsonSchemaType.Boolean;
			case PrimitiveTypeCode.SByte:
			case PrimitiveTypeCode.Int16:
			case PrimitiveTypeCode.UInt16:
			case PrimitiveTypeCode.Int32:
			case PrimitiveTypeCode.Byte:
			case PrimitiveTypeCode.UInt32:
			case PrimitiveTypeCode.Int64:
			case PrimitiveTypeCode.UInt64:
			case PrimitiveTypeCode.BigInteger:
				return jsonSchemaType | JsonSchemaType.Integer;
			case PrimitiveTypeCode.Single:
			case PrimitiveTypeCode.Double:
			case PrimitiveTypeCode.Decimal:
				return jsonSchemaType | JsonSchemaType.Float;
			case PrimitiveTypeCode.DateTime:
			case PrimitiveTypeCode.DateTimeOffset:
				return jsonSchemaType | JsonSchemaType.String;
			case PrimitiveTypeCode.Guid:
			case PrimitiveTypeCode.TimeSpan:
			case PrimitiveTypeCode.Uri:
			case PrimitiveTypeCode.String:
			case PrimitiveTypeCode.Bytes:
				return jsonSchemaType | JsonSchemaType.String;
			case PrimitiveTypeCode.DBNull:
				return jsonSchemaType | JsonSchemaType.Null;
			}
			IL_014C:
			throw new JsonException(Class15.smethod_17(564870648 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_1db17fe7bd2442b599c52df89f39e610).FormatWith(CultureInfo.InvariantCulture, typeCode, type_0));
		}

		// Token: 0x06000CDF RID: 3295 RVA: 0x0006F6F4 File Offset: 0x0006D8F4
		public JsonSchemaGenerator()
		{
			int num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f77f8ab5a3534e2e914063d52217b4e1 != 0)
			{
				switch (num)
				{
				}
			}
		}

		// Token: 0x04000630 RID: 1584
		[CompilerGenerated]
		private UndefinedSchemaIdHandling undefinedSchemaIdHandling_0;

		// Token: 0x04000631 RID: 1585
		private IContractResolver icontractResolver_0;

		// Token: 0x04000632 RID: 1586
		private JsonSchemaResolver jsonSchemaResolver_0;

		// Token: 0x04000633 RID: 1587
		private readonly IList<JsonSchemaGenerator.Class8> ilist_0 = new List<JsonSchemaGenerator.Class8>();

		// Token: 0x04000634 RID: 1588
		private JsonSchema jsonSchema_0;

		// Token: 0x02000133 RID: 307
		private class Class8
		{
			// Token: 0x170001D9 RID: 473
			// (get) Token: 0x06000CE3 RID: 3299 RVA: 0x000059C0 File Offset: 0x00003BC0
			public Type Type { get; }

			// Token: 0x06000CE4 RID: 3300 RVA: 0x000059C8 File Offset: 0x00003BC8
			[CompilerGenerated]
			public JsonSchema method_0()
			{
				return this.jsonSchema_0;
			}

			// Token: 0x06000CE5 RID: 3301 RVA: 0x0006F734 File Offset: 0x0006D934
			public Class8(Type type_1, JsonSchema jsonSchema_1)
			{
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d6c400f349964629bcd869033695bff0 == 0)
				{
					goto IL_0059;
				}
				goto IL_0076;
				IL_001C:
				ValidationUtils.ArgumentNotNull(jsonSchema_1, Class15.smethod_17(926404649 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b2d935deb963472994f6f2321f1a6296));
				IL_0037:
				this.Type = type_1;
				IL_003E:
				this.jsonSchema_0 = jsonSchema_1;
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b2d935deb963472994f6f2321f1a6296 == 0)
				{
					return;
				}
				goto IL_0076;
				IL_0059:
				ValidationUtils.ArgumentNotNull(type_1, Class15.smethod_17(974433339 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_92ac2a37edba4e2587eb1b9e8af3f63f));
				goto IL_001C;
				IL_0076:
				switch (num)
				{
				case 1:
					goto IL_0059;
				case 2:
					goto IL_0037;
				case 3:
					goto IL_003E;
				case 4:
					goto IL_001C;
				}
			}

			// Token: 0x04000636 RID: 1590
			[CompilerGenerated]
			private readonly Type type_0;

			// Token: 0x04000637 RID: 1591
			[CompilerGenerated]
			private readonly JsonSchema jsonSchema_0;
		}
	}
}
