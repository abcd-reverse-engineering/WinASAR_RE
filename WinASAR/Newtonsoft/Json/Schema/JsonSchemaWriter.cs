using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Schema
{
	// Token: 0x0200013D RID: 317
	[Obsolete("JSON Schema validation has been moved to its own package. See https://www.newtonsoft.com/jsonschema for more details.")]
	internal class JsonSchemaWriter
	{
		// Token: 0x06000D56 RID: 3414 RVA: 0x00070E08 File Offset: 0x0006F008
		public JsonSchemaWriter(JsonWriter writer, JsonSchemaResolver resolver)
		{
			for (;;)
			{
				ValidationUtils.ArgumentNotNull(writer, Class15.smethod_17(1802355053 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_991c06e999c744809f5b643cb7d9e7b4));
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d9581c727fcc4f50accd4f5de0d386f5 != 0)
				{
					goto IL_000A;
				}
				IL_0022:
				switch (num)
				{
				case 1:
					goto IL_006A;
				case 2:
					return;
				case 3:
					continue;
				}
				IL_000A:
				this.jsonWriter_0 = writer;
				num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5e301544981d4903aa4e531970a47849 == 0)
				{
					goto IL_0022;
				}
				break;
			}
			IL_006A:
			this.jsonSchemaResolver_0 = resolver;
		}

		// Token: 0x06000D57 RID: 3415 RVA: 0x00070E88 File Offset: 0x0006F088
		private void method_0(JsonSchema jsonSchema_0)
		{
			for (;;)
			{
				IL_0062:
				if (jsonSchema_0.Id != null)
				{
					goto IL_004C;
				}
				for (;;)
				{
					IL_0003:
					this.WriteSchema(jsonSchema_0);
					int num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8db627a8c96145a0afb24deffd2a8808 != 0)
					{
						switch (num)
						{
						case 1:
							return;
						case 2:
						case 7:
							continue;
						case 3:
							goto IL_0062;
						case 4:
							goto IL_0079;
						case 5:
							goto IL_00AA;
						case 6:
							goto IL_006E;
						case 8:
							goto IL_0099;
						case 9:
							return;
						}
						break;
					}
					break;
				}
				IL_004C:
				if (this.jsonSchemaResolver_0.GetSchema(jsonSchema_0.Id) == null)
				{
					goto IL_0003;
				}
				goto IL_006E;
			}
			return;
			IL_006E:
			this.jsonWriter_0.WriteStartObject();
			IL_0079:
			this.jsonWriter_0.WritePropertyName(Class15.smethod_17(613151315 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ad967bb0ba3f44528134c153f7ab1ef6));
			IL_0099:
			this.jsonWriter_0.WriteValue(jsonSchema_0.Id);
			IL_00AA:
			this.jsonWriter_0.WriteEndObject();
		}

		// Token: 0x06000D58 RID: 3416 RVA: 0x00070F4C File Offset: 0x0006F14C
		public void WriteSchema(JsonSchema schema)
		{
			for (;;)
			{
				IL_0B44:
				ValidationUtils.ArgumentNotNull(schema, Class15.smethod_17(1793892662 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0361b8eb39074ea88f5257b13904930a));
				for (;;)
				{
					IL_0B2E:
					if (this.jsonSchemaResolver_0.LoadedSchemas.Contains(schema))
					{
						goto IL_0B04;
					}
					int num = 8;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3a102d6e4dd542a6855b81a93c692545 == 0)
					{
						goto IL_0AF3;
					}
					for (;;)
					{
						IL_095E:
						IEnumerator<JToken> enumerator;
						JsonSchemaType? jsonSchemaType;
						switch (num)
						{
						case 1:
						case 29:
							goto IL_0091;
						case 2:
						case 41:
						case 70:
							goto IL_0006;
						case 3:
							goto IL_0099;
						case 4:
							goto IL_069B;
						case 5:
							goto IL_0629;
						case 6:
							goto IL_0109;
						case 7:
							goto IL_04ED;
						case 8:
							goto IL_02BC;
						case 9:
							this.method_4(this.jsonWriter_0, Class15.smethod_17(89008644 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_db7740c6ca7a4f3c8e1aa526bdb0a454), schema.Description);
							num = 4;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9bd9937edf9d4ad8bd673dfcb5a5e3cb == 0)
							{
								goto IL_07F7;
							}
							continue;
						case 10:
							goto IL_0264;
						case 11:
							goto IL_044E;
						case 12:
							goto IL_0302;
						case 13:
							goto IL_0823;
						case 14:
							goto IL_01A8;
						case 15:
							goto IL_0485;
						case 16:
							goto IL_0238;
						case 17:
							goto IL_01E0;
						case 18:
							goto IL_0AF3;
						case 19:
							this.method_4(this.jsonWriter_0, Class15.smethod_17(974411251 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_92ac2a37edba4e2587eb1b9e8af3f63f), schema.MinimumItems);
							num = 39;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_948fa5c193d44e279b41c3a0fab7b5c9 != 0)
							{
								goto Block_23;
							}
							continue;
						case 20:
							goto IL_004C;
						case 21:
							goto IL_04AC;
						case 22:
						case 59:
							goto IL_01B9;
						case 23:
							this.method_4(this.jsonWriter_0, Class15.smethod_17(1788666844 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bd75de9a0b64d6da3a43e57303102f1), schema.MinimumLength);
							goto IL_06E5;
						case 24:
							goto IL_0145;
						case 25:
							goto IL_0129;
						case 26:
						case 47:
						case 67:
							goto IL_0135;
						case 27:
							goto IL_021C;
						case 28:
							this.jsonWriter_0.WriteStartArray();
							goto IL_06C3;
						case 30:
							goto IL_00E1;
						case 31:
							goto IL_051E;
						case 32:
						case 58:
							goto IL_013D;
						case 33:
							if (schema.Extends.Count <= 0)
							{
								goto Block_22;
							}
							goto IL_067B;
						case 34:
							goto IL_067B;
						case 35:
							goto IL_0B2E;
						case 36:
							goto IL_0B44;
						case 37:
							goto IL_0173;
						case 38:
							goto IL_05E8;
						case 39:
							this.method_4(this.jsonWriter_0, Class15.smethod_17(676668642 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa49bb51056944098afe92e3a80a544b), schema.MaximumItems);
							goto IL_04ED;
						case 40:
							goto IL_07D2;
						case 42:
							goto IL_0540;
						case 43:
							goto IL_0354;
						case 44:
							goto IL_0165;
						case 45:
							goto IL_0290;
						case 46:
							goto IL_06E5;
						case 48:
							goto IL_07F7;
						case 49:
						case 65:
							goto IL_0101;
						case 50:
							goto IL_0A85;
						case 51:
							goto IL_06AC;
						case 52:
							goto IL_0347;
						case 53:
							try
							{
								for (;;)
								{
									if (enumerator.MoveNext())
									{
										goto IL_072F;
									}
									int num2 = 1;
									if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4b8a72ce901241b5b52fe60600cb3607 == 0)
									{
										break;
									}
									IL_0758:
									switch (num2)
									{
									case 1:
										IL_072F:
										enumerator.Current.WriteTo(this.jsonWriter_0, new JsonConverter[0]);
										num2 = 0;
										if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93ade03426d44b1841bfa7c633f49f3 == 0)
										{
											goto IL_0758;
										}
										break;
									case 2:
										goto IL_0790;
									}
								}
								IL_0790:;
							}
							finally
							{
								if (enumerator != null)
								{
									int num3 = 0;
									if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_676b866782704933888a7440512fd4ff != 0)
									{
										goto IL_07C0;
									}
									IL_07A8:
									enumerator.Dispose();
									num3 = 0;
									if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_afb77be96d644a2297c7f9466cb06ede == 0)
									{
										goto IL_07D1;
									}
									IL_07C0:
									switch (num3)
									{
									case 1:
										goto IL_07A8;
									}
								}
								IL_07D1:;
							}
							goto IL_07D2;
						case 54:
							goto IL_00BC;
						case 55:
							goto IL_06C3;
						case 56:
							goto IL_0B04;
						case 57:
							goto IL_0560;
						case 60:
							goto IL_0AC6;
						case 61:
						{
							string text = Class15.smethod_17(2008596221 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5c76a4eb2c1748d1bee3513c8eaff2eb);
							JsonWriter jsonWriter = this.jsonWriter_0;
							jsonSchemaType = schema.Disallow;
							this.method_3(text, jsonWriter, jsonSchemaType.GetValueOrDefault());
							num = 54;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0361b8eb39074ea88f5257b13904930a == 0)
							{
								goto IL_067B;
							}
							continue;
						}
						case 62:
							goto IL_0409;
						case 63:
							goto IL_05BC;
						case 64:
							this.jsonWriter_0.WriteValue(schema.AllowAdditionalProperties);
							num = 6;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8db627a8c96145a0afb24deffd2a8808 != 0)
							{
								goto IL_0135;
							}
							continue;
						case 66:
							goto IL_042E;
						case 68:
							goto IL_033C;
						case 69:
							goto IL_002B;
						}
						return;
						IL_002B:
						if (jsonSchemaType == null)
						{
							goto IL_00E1;
						}
						num = 8;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_948fa5c193d44e279b41c3a0fab7b5c9 == 0)
						{
							goto IL_004C;
						}
						continue;
						IL_0629:
						jsonSchemaType = schema.Type;
						goto IL_002B;
						IL_004C:
						string text2 = Class15.smethod_17(1788615418 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bd75de9a0b64d6da3a43e57303102f1);
						JsonWriter jsonWriter2 = this.jsonWriter_0;
						jsonSchemaType = schema.Type;
						this.method_3(text2, jsonWriter2, jsonSchemaType.GetValueOrDefault());
						num = 30;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7ae4da5a55de471eb12dd0de8dd4269c != 0)
						{
							goto IL_0091;
						}
						continue;
						IL_0099:
						if (jsonSchemaType == null)
						{
							goto IL_00BC;
						}
						num = 61;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_370349efcd7c4959a098549c3d5bf14d == 0)
						{
							goto Block_4;
						}
						continue;
						IL_0091:
						jsonSchemaType = schema.Disallow;
						goto IL_0099;
						IL_00BC:
						if (schema.Extends == null)
						{
							goto IL_0006;
						}
						num = 33;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b17e63564ae246399767b60cf4b1528a != 0)
						{
							goto IL_0264;
						}
						continue;
						IL_00E1:
						if (!schema.AllowAdditionalProperties)
						{
							goto IL_0302;
						}
						num = 42;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d6c400f349964629bcd869033695bff0 == 0)
						{
							goto IL_0101;
						}
						continue;
						IL_0173:
						this.jsonWriter_0.WritePropertyName(Class15.smethod_17(649929264 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0efaea2f67ca4b0aa2880fbd34fc0fff));
						num = 4;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f77f8ab5a3534e2e914063d52217b4e1 == 0)
						{
							goto IL_01A8;
						}
						continue;
						IL_0135:
						if (schema.AllowAdditionalItems)
						{
							goto IL_013D;
						}
						goto IL_0173;
						IL_0129:
						this.method_0(schema.AdditionalProperties);
						goto IL_0135;
						IL_0109:
						this.jsonWriter_0.WritePropertyName(Class15.smethod_17(1793893300 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0361b8eb39074ea88f5257b13904930a));
						goto IL_0129;
						IL_0101:
						if (schema.AdditionalProperties != null)
						{
							goto IL_0109;
						}
						goto IL_0135;
						IL_01E0:
						this.method_1(this.jsonWriter_0, Class15.smethod_17(552153706 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_01137da6c88c4265bdc0297aacf3340f), schema.PatternProperties);
						num = 21;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2a74c5ebb7d84adcad853e2eda393dc4 == 0)
						{
							goto IL_021C;
						}
						continue;
						IL_01B9:
						this.method_1(this.jsonWriter_0, Class15.smethod_17(124803970 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_57ce3fecb9e64a8f924ea7658e146719), schema.Properties);
						goto IL_01E0;
						IL_01A8:
						this.jsonWriter_0.WriteValue(schema.AllowAdditionalItems);
						goto IL_01B9;
						IL_0165:
						this.method_0(schema.AdditionalItems);
						goto IL_01B9;
						IL_0145:
						this.jsonWriter_0.WritePropertyName(Class15.smethod_17(1603831038 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d5af2cccac2f47ed978e804138a35d1c));
						goto IL_0165;
						IL_013D:
						if (schema.AdditionalItems != null)
						{
							goto IL_0145;
						}
						goto IL_01B9;
						IL_021C:
						this.method_2(schema);
						num = 14;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7dfc957a76cb4c58b17dc74a084c4e4a != 0)
						{
							goto IL_0238;
						}
						continue;
						IL_02BC:
						this.method_4(this.jsonWriter_0, Class15.smethod_17(41475245 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_079bd9b874b24353bef46f6c3f5d741d), schema.ExclusiveMaximum);
						num = 23;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_100d09ce3850492c8356d7fa1e667d54 == 0)
						{
							goto Block_8;
						}
						continue;
						IL_0290:
						this.method_4(this.jsonWriter_0, Class15.smethod_17(1829578415 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c08ab7af63da4f24a4fa3e9c7a732fae), schema.ExclusiveMinimum);
						goto IL_02BC;
						IL_0264:
						this.method_4(this.jsonWriter_0, Class15.smethod_17(1807910074 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c5a086ee5649458eb5e1e6e4f0f1f4d3), schema.Maximum);
						goto IL_0290;
						IL_0238:
						this.method_4(this.jsonWriter_0, Class15.smethod_17(613141157 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ad967bb0ba3f44528134c153f7ab1ef6), schema.Minimum);
						goto IL_0264;
						IL_0302:
						this.jsonWriter_0.WritePropertyName(Class15.smethod_17(1678052936 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ee35a23edd8f4998990ec1a2b40fc61a));
						num = 64;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7ae4da5a55de471eb12dd0de8dd4269c != 0)
						{
							break;
						}
						continue;
						IL_0409:
						this.jsonWriter_0.WriteEndArray();
						num = 70;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2e3be65f7cb2480482903dc73ec42f7c != 0)
						{
							goto IL_0173;
						}
						continue;
						IL_0354:
						IEnumerator<JsonSchema> enumerator2;
						try
						{
							for (;;)
							{
								if (enumerator2.MoveNext())
								{
									goto IL_0386;
								}
								int num4 = 3;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bca7529ca324c188cfc0e64eb7d1cdf == 0)
								{
									break;
								}
								IL_0371:
								JsonSchema jsonSchema;
								switch (num4)
								{
								default:
									IL_0386:
									jsonSchema = enumerator2.Current;
									num4 = 2;
									if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_832998aae3714af0a1270bf2bb566909 != 0)
									{
										goto IL_0371;
									}
									break;
								case 1:
									continue;
								case 2:
									break;
								case 3:
									goto IL_03C7;
								}
								this.method_0(jsonSchema);
								num4 = 1;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ad967bb0ba3f44528134c153f7ab1ef6 == 0)
								{
									goto IL_0371;
								}
							}
							IL_03C7:;
						}
						finally
						{
							if (enumerator2 != null)
							{
								int num5 = 0;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_75738dd4edc84122bfe3748a1ea03d43 == 0)
								{
									goto IL_03F7;
								}
								IL_03DF:
								enumerator2.Dispose();
								num5 = 1;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ee35a23edd8f4998990ec1a2b40fc61a != 0)
								{
									goto IL_0408;
								}
								IL_03F7:
								switch (num5)
								{
								case 0:
									goto IL_03DF;
								case 1:
									break;
								default:
									goto IL_03DF;
								}
							}
							IL_0408:;
						}
						goto IL_0409;
						IL_0347:
						enumerator2 = schema.Extends.GetEnumerator();
						goto IL_0354;
						IL_033C:
						this.jsonWriter_0.WriteStartArray();
						goto IL_0347;
						IL_069B:
						if (schema.Extends.Count == 1)
						{
							goto IL_06AC;
						}
						goto IL_033C;
						IL_067B:
						this.jsonWriter_0.WritePropertyName(Class15.smethod_17(124804510 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_57ce3fecb9e64a8f924ea7658e146719));
						goto IL_069B;
						IL_042E:
						if (schema.Enum == null)
						{
							goto IL_051E;
						}
						num = 9;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_55c1fea936c04e47abbfb2b5f778aff7 != 0)
						{
							continue;
						}
						IL_044E:
						this.jsonWriter_0.WritePropertyName(Class15.smethod_17(552154350 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_01137da6c88c4265bdc0297aacf3340f));
						num = 28;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_eaded84ad5b14e1ea8d4d97bfed1bb48 == 0)
						{
							goto IL_04ED;
						}
						continue;
						IL_04AC:
						this.method_4(this.jsonWriter_0, Class15.smethod_17(89009156 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_db7740c6ca7a4f3c8e1aa526bdb0a454), schema.Pattern);
						num = 7;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_548c52e5632b45898e377ad9c9a06469 == 0)
						{
							goto IL_042E;
						}
						continue;
						IL_0485:
						this.method_4(this.jsonWriter_0, Class15.smethod_17(277614894 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9f9b31fb7a85497499112abf86cccc98), schema.Format);
						goto IL_04AC;
						IL_04ED:
						this.method_4(this.jsonWriter_0, Class15.smethod_17(82272838 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_832998aae3714af0a1270bf2bb566909), schema.DivisibleBy);
						goto IL_0485;
						IL_051E:
						if (schema.Default != null)
						{
							goto IL_0540;
						}
						num = 1;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5dadf4f8cc824060ae20e1ee9bbca82a == 0)
						{
							goto IL_0091;
						}
						continue;
						IL_0560:
						schema.Default.WriteTo(this.jsonWriter_0, new JsonConverter[0]);
						num = 3;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3baf10aa2a73406aa2bb349717d797c7 != 0)
						{
							goto IL_0091;
						}
						continue;
						IL_0540:
						this.jsonWriter_0.WritePropertyName(Class15.smethod_17(613141899 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ad967bb0ba3f44528134c153f7ab1ef6));
						goto IL_0560;
						IL_05E8:
						this.method_4(this.jsonWriter_0, Class15.smethod_17(543279084 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_43b8cdd768c545d884bf7ff1c8fefe89), schema.Transient);
						num = 4;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4b8a72ce901241b5b52fe60600cb3607 == 0)
						{
							goto IL_0629;
						}
						continue;
						IL_05BC:
						this.method_4(this.jsonWriter_0, Class15.smethod_17(197542237 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c27e9fccdfcc44999155a4980faa4e81), schema.Hidden);
						goto IL_05E8;
						IL_0823:
						this.method_4(this.jsonWriter_0, Class15.smethod_17(1788666542 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bd75de9a0b64d6da3a43e57303102f1), schema.ReadOnly);
						goto IL_05BC;
						IL_07F7:
						this.method_4(this.jsonWriter_0, Class15.smethod_17(299916453 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d97e64d0f425406b9649f2b4562a5f0e), schema.Required);
						goto IL_0823;
						IL_06C3:
						enumerator = schema.Enum.GetEnumerator();
						num = 53;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_48fe014748e848c88d3254f339047927 != 0)
						{
							continue;
						}
						IL_06E5:
						this.method_4(this.jsonWriter_0, Class15.smethod_17(1176498934 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93c7140125045538ae5c40c6f39a5af), schema.MaximumLength);
						num = 19;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_db7740c6ca7a4f3c8e1aa526bdb0a454 == 0)
						{
							goto IL_0099;
						}
						continue;
						IL_07D2:
						this.jsonWriter_0.WriteEndArray();
						num = 31;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c27e9fccdfcc44999155a4980faa4e81 == 0)
						{
							goto IL_051E;
						}
					}
					Block_23:
					continue;
					Block_22:
					goto IL_0006;
					IL_06AC:
					this.method_0(schema.Extends[0]);
					goto IL_0006;
					Block_8:
					goto IL_0AF3;
					Block_4:
					goto IL_0B04;
					IL_0006:
					this.jsonWriter_0.WriteEndObject();
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8432da17e8384a688cea4636964d3693 == 0)
					{
						return;
					}
					goto IL_095E;
					IL_0A85:
					this.method_4(this.jsonWriter_0, Class15.smethod_17(89008662 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_db7740c6ca7a4f3c8e1aa526bdb0a454), schema.Title);
					num = 9;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4ac69ea2381b403582a2723337f67fa8 == 0)
					{
						goto IL_0006;
					}
					goto IL_095E;
					IL_0AC6:
					this.method_4(this.jsonWriter_0, Class15.smethod_17(1829576773 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c08ab7af63da4f24a4fa3e9c7a732fae), schema.Id);
					goto IL_0A85;
					IL_0B04:
					this.jsonWriter_0.WriteStartObject();
					goto IL_0AC6;
					IL_0AF3:
					this.jsonSchemaResolver_0.LoadedSchemas.Add(schema);
					goto IL_0B04;
				}
			}
		}

		// Token: 0x06000D59 RID: 3417 RVA: 0x00071AD8 File Offset: 0x0006FCD8
		private void method_1(JsonWriter jsonWriter_1, string string_0, IDictionary<string, JsonSchema> idictionary_0)
		{
			if (idictionary_0 != null)
			{
				jsonWriter_1.WritePropertyName(string_0);
				jsonWriter_1.WriteStartObject();
				foreach (KeyValuePair<string, JsonSchema> keyValuePair in idictionary_0)
				{
					jsonWriter_1.WritePropertyName(keyValuePair.Key);
					this.method_0(keyValuePair.Value);
				}
				jsonWriter_1.WriteEndObject();
			}
		}

		// Token: 0x06000D5A RID: 3418 RVA: 0x00071B4C File Offset: 0x0006FD4C
		private void method_2(JsonSchema jsonSchema_0)
		{
			for (;;)
			{
				IL_01ED:
				if (jsonSchema_0.Items == null)
				{
					goto IL_01C3;
				}
				for (;;)
				{
					IL_01CB:
					this.jsonWriter_0.WritePropertyName(Class15.smethod_17(926405305 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b2d935deb963472994f6f2321f1a6296));
					for (;;)
					{
						if (!jsonSchema_0.PositionalItemsValidation)
						{
							goto IL_0195;
						}
						int num = 1;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ad967bb0ba3f44528134c153f7ab1ef6 != 0)
						{
							goto IL_0139;
						}
						IL_0146:
						switch (num)
						{
						case 0:
							goto IL_0042;
						case 1:
							IL_0195:
							if (jsonSchema_0.Items == null)
							{
								goto IL_01FE;
							}
							num = 8;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa49bb51056944098afe92e3a80a544b != 0)
							{
								goto IL_0125;
							}
							goto IL_0146;
						case 2:
							IL_0139:
							this.jsonWriter_0.WriteStartArray();
							goto IL_00EE;
						case 3:
							goto IL_01C3;
						case 4:
							goto IL_01ED;
						case 5:
							return;
						case 6:
							return;
						case 7:
							return;
						case 8:
							return;
						case 9:
							goto IL_0209;
						case 10:
							goto IL_0125;
						case 11:
							goto IL_01CB;
						case 12:
							goto IL_00FC;
						case 13:
							goto IL_00EE;
						case 14:
							goto IL_00CC;
						case 15:
							continue;
						case 16:
							break;
						default:
							goto IL_0042;
						}
						IL_0020:
						IEnumerator<JsonSchema> enumerator = jsonSchema_0.Items.GetEnumerator();
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9a2e459a49464219810a951679aea12e != 0)
						{
							goto IL_0042;
						}
						goto IL_0146;
						IL_00EE:
						if (jsonSchema_0.Items != null)
						{
							goto IL_0020;
						}
						IL_00CC:
						this.jsonWriter_0.WriteEndArray();
						num = 5;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_1db17fe7bd2442b599c52df89f39e610 == 0)
						{
							goto Block_3;
						}
						goto IL_0146;
						IL_0042:
						try
						{
							IL_0081:
							while (enumerator.MoveNext())
							{
								JsonSchema jsonSchema;
								for (;;)
								{
									jsonSchema = enumerator.Current;
									int num2 = 0;
									if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_100d09ce3850492c8356d7fa1e667d54 != 0)
									{
										switch (num2)
										{
										case 1:
											continue;
										case 2:
											goto IL_0081;
										case 3:
											goto IL_008A;
										}
										break;
									}
									break;
								}
								IL_0079:
								this.method_0(jsonSchema);
								continue;
								goto IL_0079;
							}
							IL_008A:;
						}
						finally
						{
							if (enumerator != null)
							{
								int num3 = 0;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b2d935deb963472994f6f2321f1a6296 == 0)
								{
									goto IL_00BA;
								}
								IL_00A2:
								enumerator.Dispose();
								num3 = 0;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ae8c3d3c66a64b57beca0f5360302062 == 0)
								{
									goto IL_00CB;
								}
								IL_00BA:
								switch (num3)
								{
								case 0:
									goto IL_00A2;
								case 1:
									break;
								default:
									goto IL_00A2;
								}
							}
							IL_00CB:;
						}
						goto IL_00CC;
						IL_00FC:
						this.method_0(jsonSchema_0.Items[0]);
						num = 8;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ee35a23edd8f4998990ec1a2b40fc61a == 0)
						{
							goto Block_5;
						}
						goto IL_0146;
						IL_0125:
						if (jsonSchema_0.Items.Count > 0)
						{
							goto IL_00FC;
						}
						goto IL_01FE;
					}
				}
				Block_3:
				IL_01C3:
				if (jsonSchema_0.PositionalItemsValidation)
				{
					goto IL_01CB;
				}
				return;
			}
			Block_5:
			return;
			IL_01FE:
			this.jsonWriter_0.WriteStartObject();
			IL_0209:
			this.jsonWriter_0.WriteEndObject();
		}

		// Token: 0x06000D5B RID: 3419 RVA: 0x00071D80 File Offset: 0x0006FF80
		private void method_3(string string_0, JsonWriter jsonWriter_1, JsonSchemaType jsonSchemaType_0)
		{
			for (;;)
			{
				IL_01DA:
				int num;
				IEnumerator<JsonSchemaType> enumerator;
				if (Enum.IsDefined(typeof(JsonSchemaType), jsonSchemaType_0))
				{
					num = 12;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8db627a8c96145a0afb24deffd2a8808 == 0)
					{
						goto IL_0149;
					}
					goto IL_0178;
				}
				else
				{
					enumerator = EnumUtils.GetFlagsValues<JsonSchemaType>(jsonSchemaType_0).Where(new Func<JsonSchemaType, bool>(JsonSchemaWriter.<>c.<>c_0.method_0)).GetEnumerator();
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39f35935adc2477fa894750fee078177 != 0)
					{
						goto IL_0149;
					}
					goto IL_0178;
				}
				do
				{
					IL_00ED:
					jsonWriter_1.WriteEndArray();
					num = 2;
				}
				while (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b2d935deb963472994f6f2321f1a6296 == 0);
				JsonSchemaType jsonSchemaType;
				for (;;)
				{
					IL_0178:
					switch (num)
					{
					case 1:
						goto IL_0149;
					case 2:
						return;
					case 3:
						goto IL_00AB;
					case 4:
						goto IL_00A2;
					case 5:
						if (enumerator.MoveNext())
						{
							goto IL_0125;
						}
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_17bdafd603b54a77a2e4a383bd4dcffa == 0)
						{
							continue;
						}
						break;
					case 6:
						return;
					case 7:
						return;
					case 8:
						goto IL_0125;
					case 9:
						goto IL_00D2;
					case 10:
						goto IL_0107;
					case 11:
						goto IL_0099;
					case 12:
						jsonWriter_1.WritePropertyName(string_0);
						num = 14;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39a47a907a8a440980940ae96da3f3ad != 0)
						{
							goto Block_4;
						}
						continue;
					case 13:
						goto IL_01DA;
					case 14:
						goto IL_01FA;
					case 15:
						jsonWriter_1.WriteValue(JsonSchemaBuilder.MapType(jsonSchemaType));
						num = 8;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_725e5f82c8704b39b66ebddcee8df7fa == 0)
						{
							goto Block_3;
						}
						continue;
					}
					break;
					IL_0125:
					jsonWriter_1.WriteValue(JsonSchemaBuilder.MapType(enumerator.Current));
					num = 5;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c08ab7af63da4f24a4fa3e9c7a732fae == 0)
					{
						goto IL_0149;
					}
				}
				goto IL_00ED;
				IL_00AB:
				jsonWriter_1.WriteValue(JsonSchemaBuilder.MapType(jsonSchemaType));
				num = 6;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_550a8fe2e5fe4cc19bdfe1a82a7f12b8 == 0)
				{
					return;
				}
				goto IL_0178;
				IL_00A2:
				if (!enumerator.MoveNext())
				{
					goto IL_00AB;
				}
				goto IL_00D2;
				IL_0099:
				jsonSchemaType = enumerator.Current;
				goto IL_00A2;
				IL_00D2:
				jsonWriter_1.WriteStartArray();
				num = 15;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cb7e1ff8cc1348bebf46c510e64a0134 != 0)
				{
					goto IL_00ED;
				}
				goto IL_0178;
				IL_0107:
				jsonWriter_1.WritePropertyName(string_0);
				num = 11;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fd59e876ac704e7eaa7c7a24a9b3a23f != 0)
				{
					goto IL_0099;
				}
				goto IL_0178;
				IL_0149:
				if (enumerator.MoveNext())
				{
					goto IL_0107;
				}
				return;
			}
			Block_3:
			return;
			Block_4:
			IL_01FA:
			jsonWriter_1.WriteValue(JsonSchemaBuilder.MapType(jsonSchemaType_0));
		}

		// Token: 0x06000D5C RID: 3420 RVA: 0x00071F98 File Offset: 0x00070198
		private void method_4(JsonWriter jsonWriter_1, string string_0, object object_0)
		{
			for (;;)
			{
				if (object_0 != null)
				{
					goto IL_0003;
				}
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_11c6824de6514281a8425f6d6ab1a2d5 != 0)
				{
					break;
				}
				IL_001B:
				switch (num)
				{
				case 1:
					continue;
				case 2:
					goto IL_0055;
				case 4:
					IL_0003:
					jsonWriter_1.WritePropertyName(string_0);
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_43b32b9d66294210a955990bb6fcc511 != 0)
					{
						goto IL_001B;
					}
					goto IL_0054;
				}
				break;
			}
			return;
			IL_0054:
			IL_0055:
			jsonWriter_1.WriteValue(object_0);
		}

		// Token: 0x04000672 RID: 1650
		private readonly JsonWriter jsonWriter_0;

		// Token: 0x04000673 RID: 1651
		private readonly JsonSchemaResolver jsonSchemaResolver_0;
	}
}
