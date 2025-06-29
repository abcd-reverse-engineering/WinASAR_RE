using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Schema
{
	// Token: 0x0200012E RID: 302
	[Obsolete("JSON Schema validation has been moved to its own package. See https://www.newtonsoft.com/jsonschema for more details.")]
	internal class JsonSchemaBuilder
	{
		// Token: 0x06000CA2 RID: 3234 RVA: 0x0006BC70 File Offset: 0x00069E70
		public JsonSchemaBuilder(JsonSchemaResolver resolver)
		{
			int num = 1;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c27e9fccdfcc44999155a4980faa4e81 == 0)
			{
				goto IL_003B;
			}
			goto IL_0048;
			IL_001C:
			this.idictionary_0 = new Dictionary<string, JsonSchema>();
			num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f19acd91a8c44846a95d09d7dc3da2ba != 0)
			{
				goto IL_0061;
			}
			goto IL_0048;
			IL_003B:
			this.ilist_0 = new List<JsonSchema>();
			goto IL_001C;
			IL_0048:
			switch (num)
			{
			case 1:
				goto IL_003B;
			case 2:
				return;
			case 3:
				goto IL_001C;
			}
			IL_0061:
			this.jsonSchemaResolver_0 = resolver;
		}

		// Token: 0x06000CA3 RID: 3235 RVA: 0x0006BCE8 File Offset: 0x00069EE8
		private void method_0(JsonSchema jsonSchema_1)
		{
			for (;;)
			{
				IL_0061:
				this.jsonSchema_0 = jsonSchema_1;
				for (;;)
				{
					IL_0041:
					this.ilist_0.Add(jsonSchema_1);
					int num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5be00c24d71649dcae8af3eed7b74ac9 != 0)
					{
						goto Block_2;
					}
					for (;;)
					{
						switch (num)
						{
						case 1:
							this.jsonSchemaResolver_0.LoadedSchemas.Add(jsonSchema_1);
							num = 0;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0005996a6a494de4880ac2956b2e0112 != 0)
							{
								continue;
							}
							break;
						case 2:
							goto IL_0041;
						case 3:
							goto IL_0061;
						case 4:
							return;
						}
						goto Block_1;
					}
				}
			}
			Block_1:
			Block_2:
			this.idictionary_0.Add(jsonSchema_1.Location, jsonSchema_1);
		}

		// Token: 0x06000CA4 RID: 3236 RVA: 0x00005925 File Offset: 0x00003B25
		private JsonSchema method_1()
		{
			JsonSchema jsonSchema = this.jsonSchema_0;
			this.ilist_0.RemoveAt(this.ilist_0.Count - 1);
			this.jsonSchema_0 = this.ilist_0.LastOrDefault<JsonSchema>();
			return jsonSchema;
		}

		// Token: 0x06000CA5 RID: 3237 RVA: 0x00005956 File Offset: 0x00003B56
		private JsonSchema method_2()
		{
			return this.jsonSchema_0;
		}

		// Token: 0x06000CA6 RID: 3238 RVA: 0x0006BD78 File Offset: 0x00069F78
		internal JsonSchema Read(JsonReader reader)
		{
			JToken jtoken;
			JsonSchema jsonSchema;
			for (;;)
			{
				jtoken = JToken.ReadFrom(reader);
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3436841e08c54f56b10b76e1438d4224 == 0)
				{
					goto IL_0003;
				}
				IL_0021:
				switch (num)
				{
				case 1:
					IL_0003:
					this.jobject_0 = jtoken as JObject;
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8432da17e8384a688cea4636964d3693 == 0)
					{
						goto IL_0021;
					}
					break;
				case 2:
					continue;
				case 3:
					goto IL_0064;
				case 4:
					return jsonSchema;
				}
				break;
			}
			jsonSchema = this.method_5(jtoken);
			IL_0064:
			this.method_4(jsonSchema);
			return jsonSchema;
		}

		// Token: 0x06000CA7 RID: 3239 RVA: 0x0006BDF4 File Offset: 0x00069FF4
		private string method_3(string string_0)
		{
			return StringUtils.Replace(StringUtils.Replace(Uri.UnescapeDataString(string_0), Class15.smethod_17(1042135815 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39a47a907a8a440980940ae96da3f3ad), Class15.smethod_17(768737302 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3baf10aa2a73406aa2bb349717d797c7)), Class15.smethod_17(635765625 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a41eabd4b99f489fb7d86310d3f95ba2), Class15.smethod_17(1985332578 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f19acd91a8c44846a95d09d7dc3da2ba));
		}

		// Token: 0x06000CA8 RID: 3240 RVA: 0x0006BE68 File Offset: 0x0006A068
		private JsonSchema method_4(JsonSchema jsonSchema_1)
		{
			for (;;)
			{
				IL_0693:
				if (jsonSchema_1.DeferredReference != null)
				{
					goto IL_0306;
				}
				goto IL_0685;
				int num;
				JToken jtoken;
				JsonSchema jsonSchema;
				List<KeyValuePair<string, JsonSchema>>.Enumerator enumerator;
				bool flag;
				string[] array2;
				for (;;)
				{
					IL_0560:
					switch (num)
					{
					case 1:
						goto IL_00D6;
					case 2:
					case 47:
						goto IL_03C9;
					case 3:
						goto IL_020B;
					case 4:
						goto IL_00E8;
					case 5:
						goto IL_0055;
					case 6:
						goto IL_029F;
					case 7:
						goto IL_042C;
					case 8:
					case 23:
					case 36:
						goto IL_0401;
					case 9:
					case 18:
						goto IL_040B;
					case 10:
						goto IL_0245;
					case 11:
						goto IL_0203;
					case 12:
					case 50:
						goto IL_0031;
					case 13:
						goto IL_011C;
					case 14:
						return jsonSchema_1;
					case 15:
					case 16:
						goto IL_005A;
					case 17:
						goto IL_03E1;
					case 19:
						goto IL_039C;
					case 20:
						jsonSchema = this.method_5(jtoken);
						num = 13;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7af5c533f30e4bd1bda86ce6098441d2 == 0)
						{
							continue;
						}
						goto IL_0663;
					case 21:
						goto IL_0317;
					case 22:
						goto IL_03A7;
					case 24:
						goto IL_0664;
					case 25:
						goto IL_0333;
					case 26:
					case 30:
						goto IL_0260;
					case 27:
						goto IL_04FA;
					case 28:
						goto IL_06A7;
					case 29:
						goto IL_0388;
					case 31:
					case 33:
						goto IL_00AA;
					case 32:
						goto IL_0685;
					case 34:
						goto IL_0392;
					case 35:
						goto IL_01DC;
					case 37:
						goto IL_026F;
					case 38:
						goto IL_010A;
					case 39:
						goto IL_03AC;
					case 40:
						goto IL_0668;
					case 41:
						try
						{
							for (;;)
							{
								if (enumerator.MoveNext())
								{
									goto IL_048D;
								}
								int num2 = 2;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_48fe014748e848c88d3254f339047927 == 0)
								{
									goto IL_0444;
								}
								IL_0474:
								switch (num2)
								{
								case 1:
									goto IL_048D;
								case 2:
									goto IL_04CA;
								case 3:
									continue;
								}
								IL_0444:
								KeyValuePair<string, JsonSchema> keyValuePair;
								jsonSchema_1.Properties[keyValuePair.Key] = this.method_4(keyValuePair.Value);
								num2 = 3;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ee35a23edd8f4998990ec1a2b40fc61a != 0)
								{
									goto IL_0474;
								}
								IL_048D:
								keyValuePair = enumerator.Current;
								num2 = 0;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa29cbda752f45acbe81e7d5285df2ba == 0)
								{
									goto IL_0444;
								}
								goto IL_0474;
							}
							IL_04CA:
							goto IL_029F;
						}
						finally
						{
							((IDisposable)enumerator).Dispose();
							int num3 = 0;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b2d935deb963472994f6f2321f1a6296 == 0)
							{
								switch (num3)
								{
								}
							}
						}
						goto IL_04FA;
					case 42:
					case 45:
						goto IL_0432;
					case 43:
						goto IL_035C;
					case 44:
						goto IL_03B7;
					case 46:
						goto IL_008F;
					case 48:
						goto IL_033B;
					case 49:
						if (jsonSchema == null)
						{
							goto IL_0317;
						}
						goto IL_0668;
					case 51:
					case 54:
						goto IL_0294;
					case 52:
						goto IL_0306;
					case 53:
						goto IL_0693;
					case 55:
						return jsonSchema_1;
					case 56:
						goto IL_00B9;
					case 57:
						goto IL_02E5;
					case 58:
						goto IL_06D5;
					case 59:
						goto IL_02C4;
					case 60:
						goto IL_0210;
					case 61:
						goto IL_0027;
					}
					goto Block_20;
					IL_0317:
					if (!flag)
					{
						goto IL_0664;
					}
					num = 27;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bca7529ca324c188cfc0e64eb7d1cdf == 0)
					{
						break;
					}
					continue;
					IL_04FA:
					string[] array = jsonSchema_1.DeferredReference.TrimStart(new char[] { '#' }).Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);
					jtoken = this.jobject_0;
					array2 = array;
					num = 25;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e368897ba1744663a6d0bc59b9b65b5f == 0)
					{
						goto Block_19;
					}
				}
				IL_0333:
				int num4 = 0;
				goto IL_0432;
				Block_20:
				goto IL_037B;
				IL_0663:
				goto IL_0664;
				IL_0685:
				if (jsonSchema_1.ReferencesResolved)
				{
					num = 31;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa29cbda752f45acbe81e7d5285df2ba != 0)
					{
						goto Block_21;
					}
					goto IL_0560;
				}
				else
				{
					jsonSchema_1.ReferencesResolved = true;
					num = 11;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a41eabd4b99f489fb7d86310d3f95ba2 == 0)
					{
						goto IL_03C9;
					}
					goto IL_0560;
				}
				IL_0031:
				string text;
				jsonSchema = this.jsonSchemaResolver_0.GetSchema(text);
				num = 49;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_6bf87ae21d2446cfa7edc53669bb8039 == 0)
				{
					goto IL_0055;
				}
				goto IL_0560;
				IL_0027:
				text = this.method_3(text);
				goto IL_0031;
				IL_02C4:
				if (flag)
				{
					goto IL_0027;
				}
				num = 12;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d9581c727fcc4f50accd4f5de0d386f5 == 0)
				{
					goto IL_0031;
				}
				goto IL_0560;
				IL_02E5:
				flag = text.StartsWith(Class15.smethod_17(926405591 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b2d935deb963472994f6f2321f1a6296), StringComparison.Ordinal);
				goto IL_02C4;
				IL_0306:
				text = jsonSchema_1.DeferredReference;
				goto IL_02E5;
				IL_005A:
				int num5;
				jsonSchema_1.Items[num5] = this.method_4(jsonSchema_1.Items[num5]);
				num = 26;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cbfb1e54efd84756a9b6d7b21adc0d65 == 0)
				{
					goto IL_008F;
				}
				goto IL_0560;
				IL_00AA:
				if (num5 >= jsonSchema_1.Items.Count)
				{
					goto IL_00B9;
				}
				goto IL_005A;
				IL_0055:
				num5 = 0;
				goto IL_00AA;
				IL_008F:
				num5++;
				num = 9;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b3c865ee224546b18f2991d2a8895f6a == 0)
				{
					goto IL_00AA;
				}
				goto IL_0560;
				IL_00B9:
				if (jsonSchema_1.AdditionalItems == null)
				{
					goto IL_00E8;
				}
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_186d640068094cc595a341ef95c9a29a == 0)
				{
					goto IL_00D6;
				}
				goto IL_0560;
				IL_026F:
				if (jsonSchema_1.Items == null)
				{
					goto IL_00B9;
				}
				num = 5;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93ade03426d44b1841bfa7c633f49f3 == 0)
				{
					goto IL_0055;
				}
				goto IL_0560;
				IL_0260:
				int num6;
				if (num6 >= jsonSchema_1.Extends.Count)
				{
					goto IL_026F;
				}
				goto IL_0210;
				IL_020B:
				num6 = 0;
				goto IL_0260;
				IL_0203:
				if (jsonSchema_1.Extends != null)
				{
					goto IL_020B;
				}
				goto IL_026F;
				IL_00E8:
				if (jsonSchema_1.PatternProperties != null)
				{
					goto IL_010A;
				}
				num = 54;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_57ce3fecb9e64a8f924ea7658e146719 == 0)
				{
					goto IL_020B;
				}
				goto IL_0560;
				IL_00D6:
				jsonSchema_1.AdditionalItems = this.method_4(jsonSchema_1.AdditionalItems);
				goto IL_00E8;
				IL_01C7:
				num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cbfb1e54efd84756a9b6d7b21adc0d65 == 0)
				{
					goto IL_01DC;
				}
				goto IL_0560;
				IL_0294:
				if (jsonSchema_1.Properties == null)
				{
					goto IL_029F;
				}
				goto IL_01C7;
				IL_011C:
				try
				{
					for (;;)
					{
						if (enumerator.MoveNext())
						{
							goto IL_0168;
						}
						int num7 = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e368897ba1744663a6d0bc59b9b65b5f != 0)
						{
							break;
						}
						IL_0150:
						KeyValuePair<string, JsonSchema> keyValuePair2;
						switch (num7)
						{
						case 1:
							continue;
						case 2:
							goto IL_0120;
						case 3:
							IL_0168:
							keyValuePair2 = enumerator.Current;
							goto IL_0120;
						}
						break;
						IL_0120:
						jsonSchema_1.PatternProperties[keyValuePair2.Key] = this.method_4(keyValuePair2.Value);
						num7 = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3a299c01dd4f4a209bdbd1b98e3f1406 == 0)
						{
							goto IL_0150;
						}
					}
					goto IL_0294;
				}
				finally
				{
					((IDisposable)enumerator).Dispose();
					int num8 = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e368897ba1744663a6d0bc59b9b65b5f != 0)
					{
						switch (num8)
						{
						}
					}
				}
				goto IL_01C7;
				IL_010A:
				enumerator = jsonSchema_1.PatternProperties.ToList<KeyValuePair<string, JsonSchema>>().GetEnumerator();
				goto IL_011C;
				IL_01DC:
				enumerator = jsonSchema_1.Properties.ToList<KeyValuePair<string, JsonSchema>>().GetEnumerator();
				num = 41;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d5af2cccac2f47ed978e804138a35d1c == 0)
				{
					goto IL_0203;
				}
				goto IL_0560;
				IL_0210:
				jsonSchema_1.Extends[num6] = this.method_4(jsonSchema_1.Extends[num6]);
				num = 7;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8d68b74cee6442019d959192b2974e3d != 0)
				{
					goto IL_0560;
				}
				IL_0245:
				num6++;
				num = 23;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7af5c533f30e4bd1bda86ce6098441d2 != 0)
				{
					goto IL_0260;
				}
				goto IL_0560;
				IL_029F:
				if (jsonSchema_1.AdditionalProperties == null)
				{
					return jsonSchema_1;
				}
				num = 15;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_afb77be96d644a2297c7f9466cb06ede == 0)
				{
					break;
				}
				goto IL_0560;
				IL_033B:
				if (jtoken == null)
				{
					goto IL_0664;
				}
				num = 20;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8db627a8c96145a0afb24deffd2a8808 == 0)
				{
					goto IL_040B;
				}
				goto IL_0560;
				IL_0432:
				if (num4 < array2.Length)
				{
					goto IL_040B;
				}
				goto IL_033B;
				IL_042C:
				num4++;
				goto IL_0432;
				IL_0401:
				if (jtoken == null)
				{
					goto IL_033B;
				}
				num = 4;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_67cbcb2ad04040d48847c1ca2f65be32 == 0)
				{
					goto IL_042C;
				}
				goto IL_0560;
				IL_03B7:
				int num9;
				jtoken = jtoken[num9];
				goto IL_0401;
				IL_03AC:
				if (num9 < jtoken.Count<JToken>())
				{
					goto IL_03B7;
				}
				goto IL_03C9;
				IL_03A7:
				if (num9 >= 0)
				{
					goto IL_03AC;
				}
				goto IL_03C9;
				IL_039C:
				string text2;
				if (int.TryParse(text2, out num9))
				{
					goto IL_03A7;
				}
				goto IL_03C9;
				IL_0388:
				if (jtoken.Type != JTokenType.Array)
				{
					goto IL_0392;
				}
				goto IL_039C;
				IL_037B:
				if (jtoken.Type == JTokenType.Object)
				{
					goto IL_03E1;
				}
				goto IL_0388;
				IL_0392:
				if (jtoken.Type == JTokenType.Constructor)
				{
					goto IL_039C;
				}
				goto IL_0401;
				IL_035C:
				string text3;
				text2 = this.method_3(text3);
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9a2e459a49464219810a951679aea12e == 0)
				{
					goto IL_037B;
				}
				goto IL_0560;
				IL_040B:
				text3 = array2[num4];
				goto IL_035C;
				IL_03C9:
				jtoken = null;
				num = 23;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_100d09ce3850492c8356d7fa1e667d54 != 0)
				{
					goto IL_0560;
				}
				IL_03E1:
				jtoken = jtoken[text2];
				num = 3;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4b8a72ce901241b5b52fe60600cb3607 == 0)
				{
					goto IL_0401;
				}
				goto IL_0560;
				IL_0668:
				jsonSchema_1 = jsonSchema;
				goto IL_0685;
				IL_0664:
				if (jsonSchema != null)
				{
					goto IL_0668;
				}
				goto IL_06A7;
			}
			goto IL_06D5;
			Block_19:
			return jsonSchema_1;
			Block_21:
			return jsonSchema_1;
			IL_06A7:
			throw new JsonException(Class15.smethod_17(613141371 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ad967bb0ba3f44528134c153f7ab1ef6).FormatWith(CultureInfo.InvariantCulture, jsonSchema_1.DeferredReference));
			IL_06D5:
			jsonSchema_1.AdditionalProperties = this.method_4(jsonSchema_1.AdditionalProperties);
			return jsonSchema_1;
		}

		// Token: 0x06000CA9 RID: 3241 RVA: 0x0006C57C File Offset: 0x0006A77C
		private JsonSchema method_5(JToken jtoken_0)
		{
			JToken jtoken;
			for (;;)
			{
				IL_021D:
				JObject jobject = jtoken_0 as JObject;
				IL_0216:
				while (jobject != null)
				{
					for (;;)
					{
						IL_01F0:
						string text;
						if (!jobject.TryGetValue(Class15.smethod_17(564857994 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_1db17fe7bd2442b599c52df89f39e610), out jtoken))
						{
							text = jtoken_0.Path;
							goto IL_0189;
						}
						int num = 2;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_43b32b9d66294210a955990bb6fcc511 != 0)
						{
							goto IL_0064;
						}
						JsonSchema jsonSchema;
						for (;;)
						{
							IL_013E:
							switch (num)
							{
							case 1:
								text = StringUtils.Replace(text, Class15.smethod_17(1424620392 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bca7529ca324c188cfc0e64eb7d1cdf), Class15.smethod_17(299916665 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d97e64d0f425406b9649f2b4562a5f0e));
								goto IL_00C2;
							case 2:
								goto IL_0227;
							case 3:
								goto IL_0078;
							case 4:
								goto IL_01F0;
							case 5:
								return jsonSchema;
							case 6:
								goto IL_0189;
							case 7:
								goto IL_0216;
							case 8:
								goto IL_021D;
							case 9:
								goto IL_0240;
							case 10:
								goto IL_00F7;
							case 11:
								goto IL_0031;
							case 12:
								goto IL_00A0;
							case 13:
								goto IL_00C2;
							case 14:
								goto IL_0013;
							case 15:
								goto IL_0277;
							}
							break;
							IL_0031:
							text = Class15.smethod_17(2057026451 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_eaded84ad5b14e1ea8d4d97bfed1bb48) + text;
							num = 0;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4ac69ea2381b403582a2723337f67fa8 != 0)
							{
								break;
							}
							continue;
							IL_0013:
							text = Class15.smethod_17(926405611 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b2d935deb963472994f6f2321f1a6296) + text;
							goto IL_0031;
							IL_00C2:
							text = StringUtils.Replace(text, Class15.smethod_17(1760333229 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_6bf87ae21d2446cfa7edc53669bb8039), string.Empty);
							num = 10;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_57ce3fecb9e64a8f924ea7658e146719 == 0)
							{
								continue;
							}
							IL_00F7:
							if (!StringUtils.IsNullOrEmpty(text))
							{
								goto IL_0013;
							}
							goto IL_0031;
						}
						goto IL_0064;
						IL_0078:
						this.method_0(new JsonSchema
						{
							Location = text
						});
						num = 11;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_11c6824de6514281a8425f6d6ab1a2d5 == 0)
						{
							goto IL_00A0;
						}
						goto IL_013E;
						IL_0064:
						if (!this.idictionary_0.TryGetValue(text, out jsonSchema))
						{
							goto IL_0078;
						}
						return jsonSchema;
						IL_00A0:
						this.method_6(jobject);
						num = 1;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fd59e876ac704e7eaa7c7a24a9b3a23f == 0)
						{
							goto Block_1;
						}
						goto IL_013E;
						IL_0189:
						text = StringUtils.Replace(text, Class15.smethod_17(1570990231 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3a299c01dd4f4a209bdbd1b98e3f1406), Class15.smethod_17(1829576879 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c08ab7af63da4f24a4fa3e9c7a732fae));
						num = 1;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_6f87b5b72b9847f7b8ec5b44b0dccfa8 != 0)
						{
							goto IL_0064;
						}
						goto IL_013E;
					}
				}
				goto IL_0240;
			}
			Block_1:
			goto IL_0277;
			IL_0227:
			return new JsonSchema
			{
				DeferredReference = (string)jtoken
			};
			IL_0240:
			throw JsonException.Create(jtoken_0, jtoken_0.Path, Class15.smethod_17(299916777 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d97e64d0f425406b9649f2b4562a5f0e).FormatWith(CultureInfo.InvariantCulture, jtoken_0.Type));
			IL_0277:
			return this.method_1();
		}

		// Token: 0x06000CAA RID: 3242 RVA: 0x0006C808 File Offset: 0x0006AA08
		private void method_6(JObject jobject_1)
		{
			for (;;)
			{
				IEnumerator<KeyValuePair<string, JToken>> enumerator = jobject_1.GetEnumerator();
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0361b8eb39074ea88f5257b13904930a == 0)
				{
					switch (num)
					{
					case 1:
						goto IL_0032;
					case 2:
						continue;
					}
					break;
				}
				goto IL_0031;
			}
			return;
			IL_0031:
			IL_0032:
			try
			{
				IL_1057:
				IEnumerator<KeyValuePair<string, JToken>> enumerator;
				while (enumerator.MoveNext())
				{
					KeyValuePair<string, JToken> keyValuePair;
					uint num3;
					string key;
					for (;;)
					{
						IL_0BDC:
						keyValuePair = enumerator.Current;
						int num2 = 72;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9f9b31fb7a85497499112abf86cccc98 == 0)
						{
							goto IL_010C;
						}
						for (;;)
						{
							IL_08D9:
							switch (num2)
							{
							case 0:
								goto IL_08AA;
							case 1:
								goto IL_0190;
							case 2:
								goto IL_0E35;
							case 3:
							case 5:
							case 7:
							case 11:
							case 14:
							case 16:
							case 19:
							case 20:
							case 22:
							case 29:
							case 30:
							case 33:
							case 34:
							case 38:
							case 44:
							case 52:
							case 53:
							case 54:
							case 57:
							case 58:
							case 59:
							case 61:
							case 65:
							case 66:
							case 67:
							case 68:
							case 69:
							case 71:
							case 75:
							case 77:
							case 78:
							case 79:
							case 80:
							case 82:
							case 87:
							case 91:
							case 92:
							case 101:
							case 105:
							case 106:
							case 110:
							case 118:
							case 121:
							case 125:
							case 131:
							case 135:
							case 137:
							case 138:
							case 141:
							case 145:
							case 148:
							case 150:
							case 153:
							case 158:
							case 159:
							case 161:
							case 162:
							case 163:
							case 164:
							case 165:
							case 170:
							case 173:
							case 174:
							case 176:
							case 177:
							case 180:
							case 181:
							case 182:
							case 183:
							case 184:
							case 189:
								goto IL_1057;
							case 4:
								goto IL_012D;
							case 6:
								goto IL_0666;
							case 8:
								goto IL_0FCB;
							case 9:
								goto IL_0547;
							case 10:
								if (num3 != 2268922153U)
								{
									goto IL_07CE;
								}
								goto IL_0857;
							case 12:
							case 123:
								goto IL_03DB;
							case 13:
								goto IL_041B;
							case 15:
								goto IL_0FE9;
							case 17:
								goto IL_0712;
							case 18:
							case 99:
								goto IL_0C02;
							case 21:
								goto IL_0DA9;
							case 23:
								goto IL_0CEF;
							case 24:
								break;
							case 25:
								goto IL_0F04;
							case 26:
								goto IL_06C0;
							case 27:
								goto IL_00AE;
							case 28:
							case 86:
								goto IL_0F34;
							case 31:
								goto IL_057F;
							case 32:
								goto IL_074A;
							case 35:
								goto IL_04F3;
							case 36:
								goto IL_0EC1;
							case 37:
							case 84:
								goto IL_0EE2;
							case 39:
								goto IL_030C;
							case 40:
								goto IL_0559;
							case 41:
								goto IL_0848;
							case 42:
								goto IL_1031;
							case 43:
							case 171:
								goto IL_0384;
							case 45:
								goto IL_0248;
							case 46:
								goto IL_04C0;
							case 47:
							case 166:
								goto IL_0DE9;
							case 48:
								goto IL_0F6F;
							case 49:
							case 115:
								goto IL_0D49;
							case 50:
								goto IL_010C;
							case 51:
								goto IL_0C23;
							case 55:
								goto IL_02C2;
							case 56:
							case 140:
								this.method_2().DivisibleBy = new double?((double)keyValuePair.Value);
								num2 = 106;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c27e9fccdfcc44999155a4980faa4e81 == 0)
								{
									goto Block_55;
								}
								continue;
							case 60:
								goto IL_02F4;
							case 62:
								goto IL_058B;
							case 63:
								goto IL_0441;
							case 64:
								goto IL_1063;
							case 70:
							case 108:
								goto IL_06E1;
							case 72:
								key = keyValuePair.Key;
								num2 = 0;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_253407eb812c4aefb734fa1e267fe779 == 0)
								{
									goto IL_08AA;
								}
								continue;
							case 73:
								goto IL_0857;
							case 74:
								goto IL_0F13;
							case 76:
								goto IL_04B4;
							case 81:
								goto IL_05B7;
							case 83:
								if (num3 != 334560121U)
								{
									goto IL_0848;
								}
								goto IL_0039;
							case 85:
								goto IL_0D28;
							case 88:
								goto IL_0657;
							case 89:
								goto IL_069E;
							case 90:
							case 156:
								goto IL_0DCD;
							case 93:
								goto IL_02A1;
							case 94:
								goto IL_01C0;
							case 95:
								goto IL_07EF;
							case 96:
								goto IL_0529;
							case 97:
								goto IL_05DA;
							case 98:
								goto IL_04C9;
							case 100:
								goto IL_0BDC;
							case 102:
								goto IL_0636;
							case 103:
								goto IL_0CB9;
							case 104:
							case 188:
								goto IL_1040;
							case 107:
								goto IL_016F;
							case 109:
							case 151:
								goto IL_0E9F;
							case 111:
							case 127:
								goto IL_01F6;
							case 112:
								goto IL_0771;
							case 113:
							case 142:
								goto IL_032D;
							case 114:
								goto IL_05AE;
							case 116:
								goto IL_02FD;
							case 117:
								goto IL_1013;
							case 119:
								goto IL_0363;
							case 120:
								goto IL_0C44;
							case 122:
								goto IL_0E14;
							case 124:
								goto IL_0801;
							case 126:
								goto IL_0227;
							case 128:
								goto IL_0502;
							case 129:
								goto IL_0C83;
							case 130:
								goto IL_04D2;
							case 132:
								goto IL_0C14;
							case 133:
								goto IL_0C92;
							case 134:
								goto IL_0615;
							case 136:
								goto IL_07CE;
							case 139:
								goto IL_0D88;
							case 143:
								goto IL_01B1;
							case 144:
							case 147:
								goto IL_0C67;
							case 146:
								goto IL_0CE0;
							case 149:
								goto IL_026B;
							case 152:
								goto IL_047C;
							case 154:
								goto IL_0412;
							case 155:
								goto IL_0D9A;
							case 157:
								goto IL_00D1;
							case 160:
								goto IL_0F52;
							case 167:
							case 175:
								goto IL_0E5C;
							case 168:
								goto IL_0FA8;
							case 169:
								goto IL_0E05;
							case 172:
								goto IL_03BA;
							case 178:
								goto IL_0E7E;
							case 179:
								goto IL_0163;
							case 185:
								goto IL_0090;
							case 186:
								goto IL_0039;
							case 187:
								goto IL_1007;
							default:
								goto IL_08AA;
							}
							IL_005A:
							this.method_2().MinimumItems = new int?((int)keyValuePair.Value);
							num2 = 69;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3bf07bb1c323490cb457eef2b2e78695 != 0)
							{
								goto Block_4;
							}
							continue;
							IL_0039:
							if (key == Class15.smethod_17(1793893500 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0361b8eb39074ea88f5257b13904930a))
							{
								goto IL_005A;
							}
							goto IL_1057;
							IL_0090:
							if (num3 == 3456888823U)
							{
								goto IL_010C;
							}
							num2 = 19;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa49bb51056944098afe92e3a80a544b != 0)
							{
								goto IL_00AE;
							}
							continue;
							IL_016F:
							if (num3 > 3114108242U)
							{
								goto IL_0090;
							}
							num2 = 1;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8432da17e8384a688cea4636964d3693 == 0)
							{
								goto IL_0190;
							}
							continue;
							IL_0163:
							if (num3 <= 3522602594U)
							{
								goto IL_016F;
							}
							goto IL_0227;
							IL_057F:
							if (num3 <= 2692244416U)
							{
								goto IL_058B;
							}
							goto IL_0163;
							IL_04B4:
							if (num3 <= 2223801888U)
							{
								goto IL_04C0;
							}
							goto IL_057F;
							IL_00AE:
							if (num3 != 3522602594U)
							{
								num2 = 44;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_991c06e999c744809f5b643cb7d9e7b4 != 0)
								{
									goto Block_7;
								}
								continue;
							}
							IL_00D1:
							if (key == Class15.smethod_17(1243230714 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_67a271e0ae064fc7a3a74905868add95))
							{
								goto IL_0FA8;
							}
							num2 = 184;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3cf8a2073cc248c2915ebb05bcd2a099 != 0)
							{
								goto Block_9;
							}
							continue;
							IL_0190:
							if (num3 == 2957261815U)
							{
								goto IL_0EC1;
							}
							num2 = 0;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f19acd91a8c44846a95d09d7dc3da2ba != 0)
							{
								goto IL_01B1;
							}
							continue;
							IL_01C0:
							if (!(key == Class15.smethod_17(1788763435 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_1d8dbb531d7349c0bc15bad339f7815c)))
							{
								goto IL_1057;
							}
							num2 = 69;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_832998aae3714af0a1270bf2bb566909 != 0)
							{
								goto IL_01F6;
							}
							continue;
							IL_01B1:
							if (num3 != 3114108242U)
							{
								goto Block_13;
							}
							goto IL_01C0;
							IL_01F6:
							this.method_2().Format = (string)keyValuePair.Value;
							num2 = 47;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa49bb51056944098afe92e3a80a544b != 0)
							{
								goto Block_15;
							}
							continue;
							IL_0227:
							if (num3 > 3947606640U)
							{
								goto IL_02F4;
							}
							num2 = 0;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9bd9937edf9d4ad8bd673dfcb5a5e3cb != 0)
							{
								continue;
							}
							IL_0248:
							if (num3 != 3526559937U)
							{
								num2 = 16;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bd75de9a0b64d6da3a43e57303102f1 != 0)
								{
									goto Block_18;
								}
								continue;
							}
							IL_026B:
							if (key == Class15.smethod_17(1042136407 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39a47a907a8a440980940ae96da3f3ad))
							{
								goto IL_0F6F;
							}
							num2 = 165;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b2d935deb963472994f6f2321f1a6296 == 0)
							{
								goto IL_02A1;
							}
							continue;
							IL_02C2:
							this.method_2().Type = this.method_13(keyValuePair.Value);
							num2 = 189;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39d5fbfa4fe34ed9908db538e5340a6c == 0)
							{
								goto Block_20;
							}
							continue;
							IL_02A1:
							if (key == Class15.smethod_17(1807908332 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c5a086ee5649458eb5e1e6e4f0f1f4d3))
							{
								goto IL_02C2;
							}
							goto IL_1057;
							IL_0547:
							if (num3 != 1361572173U)
							{
								goto Block_35;
							}
							goto IL_02A1;
							IL_032D:
							this.method_2().MaximumItems = new int?((int)keyValuePair.Value);
							num2 = 10;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_52d717cd31b74287b67c03ee736a6211 == 0)
							{
								goto Block_22;
							}
							continue;
							IL_030C:
							if (key == Class15.smethod_17(2008596159 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5c76a4eb2c1748d1bee3513c8eaff2eb))
							{
								goto IL_032D;
							}
							goto IL_1057;
							IL_02FD:
							if (num3 != 4244322099U)
							{
								goto Block_21;
							}
							goto IL_030C;
							IL_02F4:
							if (num3 != 4128829753U)
							{
								goto IL_02FD;
							}
							goto IL_0363;
							IL_0384:
							this.method_2().Hidden = new bool?((bool)keyValuePair.Value);
							num2 = 1;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_253407eb812c4aefb734fa1e267fe779 == 0)
							{
								goto Block_23;
							}
							continue;
							IL_0363:
							if (key == Class15.smethod_17(1270946864 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0005996a6a494de4880ac2956b2e0112))
							{
								goto IL_0384;
							}
							goto IL_1057;
							IL_03DB:
							this.method_2().Minimum = new double?((double)keyValuePair.Value);
							num2 = 10;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7ae4da5a55de471eb12dd0de8dd4269c == 0)
							{
								goto Block_24;
							}
							continue;
							IL_03BA:
							if (key == Class15.smethod_17(1760332965 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_6bf87ae21d2446cfa7edc53669bb8039))
							{
								goto IL_03DB;
							}
							goto IL_1057;
							IL_07EF:
							if (num3 != 2474713847U)
							{
								goto Block_57;
							}
							goto IL_03BA;
							IL_041B:
							if (num3 == 2223801888U)
							{
								goto IL_0FCB;
							}
							num2 = 84;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3436841e08c54f56b10b76e1438d4224 == 0)
							{
								goto Block_26;
							}
							continue;
							IL_0412:
							if (num3 != 2171383808U)
							{
								goto IL_041B;
							}
							goto IL_0441;
							IL_0559:
							if (num3 > 2051482624U)
							{
								goto IL_0412;
							}
							num2 = 102;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39a47a907a8a440980940ae96da3f3ad != 0)
							{
								goto IL_0636;
							}
							continue;
							IL_0529:
							if (num3 > 1693958795U)
							{
								goto IL_0559;
							}
							num2 = 6;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8f48544341da433d9f954b548c7e9212 == 0)
							{
								goto IL_0547;
							}
							continue;
							IL_04C0:
							if (num3 <= 981021583U)
							{
								goto IL_04C9;
							}
							goto IL_0529;
							IL_0441:
							if (key == Class15.smethod_17(1788666504 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bd75de9a0b64d6da3a43e57303102f1))
							{
								goto IL_0D88;
							}
							num2 = 174;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7dfc957a76cb4c58b17dc74a084c4e4a == 0)
							{
								goto Block_28;
							}
							continue;
							IL_047C:
							if (num3 > 879704937U)
							{
								goto IL_0771;
							}
							num2 = 20;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ae8c3d3c66a64b57beca0f5360302062 == 0)
							{
								goto IL_04F3;
							}
							continue;
							IL_04C9:
							if (num3 > 353304077U)
							{
								goto IL_047C;
							}
							IL_04D2:
							if (num3 == 299789532U)
							{
								goto IL_0CB9;
							}
							num2 = 83;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_6f87b5b72b9847f7b8ec5b44b0dccfa8 != 0)
							{
								goto IL_04F3;
							}
							continue;
							IL_0502:
							if (!(key == Class15.smethod_17(1788773273 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_1d8dbb531d7349c0bc15bad339f7815c)))
							{
								goto IL_1057;
							}
							num2 = 99;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0b405dced5e94c80928a74c5773182d9 != 0)
							{
								goto IL_04B4;
							}
							continue;
							IL_04F3:
							if (num3 != 479998177U)
							{
								goto Block_32;
							}
							goto IL_0502;
							IL_058B:
							if (num3 > 2474713847U)
							{
								goto IL_05AE;
							}
							num2 = 10;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5e301544981d4903aa4e531970a47849 != 0)
							{
								break;
							}
							continue;
							IL_05B7:
							if (num3 == 2556802313U)
							{
								goto IL_05DA;
							}
							num2 = 155;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9f5329f120e842948536b8235793166c != 0)
							{
								goto Block_41;
							}
							continue;
							IL_05AE:
							if (num3 <= 2609687125U)
							{
								goto IL_05B7;
							}
							goto IL_0615;
							IL_05DA:
							if (!(key == Class15.smethod_17(926405369 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b2d935deb963472994f6f2321f1a6296)))
							{
								goto IL_1057;
							}
							num2 = 123;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_1db17fe7bd2442b599c52df89f39e610 != 0)
							{
								goto Block_43;
							}
							continue;
							IL_0615:
							if (num3 == 2642794062U)
							{
								goto IL_0712;
							}
							num2 = 132;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_52d717cd31b74287b67c03ee736a6211 == 0)
							{
								continue;
							}
							IL_0636:
							if (num3 == 1913005517U)
							{
								goto IL_0D28;
							}
							num2 = 87;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39d5fbfa4fe34ed9908db538e5340a6c != 0)
							{
								goto IL_0657;
							}
							continue;
							IL_0666:
							if (key == Class15.smethod_17(1116203807 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_100d09ce3850492c8356d7fa1e667d54))
							{
								goto IL_069E;
							}
							num2 = 150;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_eaded84ad5b14e1ea8d4d97bfed1bb48 == 0)
							{
								goto IL_041B;
							}
							continue;
							IL_0657:
							if (num3 != 2051482624U)
							{
								goto Block_46;
							}
							goto IL_0666;
							IL_069E:
							this.method_10(keyValuePair.Value);
							num2 = 78;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c27e9fccdfcc44999155a4980faa4e81 == 0)
							{
								goto IL_06C0;
							}
							continue;
							IL_06E1:
							this.method_2().Default = keyValuePair.Value.DeepClone();
							num2 = 7;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cb7e1ff8cc1348bebf46c510e64a0134 != 0)
							{
								goto Block_49;
							}
							continue;
							IL_06C0:
							if (key == Class15.smethod_17(1471384917 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8bcabc342a5a44748f3978da7f62051e))
							{
								goto IL_06E1;
							}
							goto IL_1057;
							IL_07CE:
							if (num3 == 2470140894U)
							{
								goto IL_06C0;
							}
							num2 = 44;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f19acd91a8c44846a95d09d7dc3da2ba != 0)
							{
								goto IL_07EF;
							}
							continue;
							IL_0712:
							if (!(key == Class15.smethod_17(486501956 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39d5fbfa4fe34ed9908db538e5340a6c)))
							{
								num2 = 163;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d97e64d0f425406b9649f2b4562a5f0e == 0)
								{
									goto Block_51;
								}
								continue;
							}
							IL_074A:
							this.method_7(keyValuePair.Value);
							num2 = 100;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_100d09ce3850492c8356d7fa1e667d54 != 0)
							{
								goto Block_52;
							}
							continue;
							IL_0771:
							if (num3 == 926444256U)
							{
								goto IL_0E7E;
							}
							num2 = 187;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4152404f503b492c83d9bc2e44bdd0a7 == 0)
							{
								goto Block_54;
							}
							continue;
							IL_0801:
							if (!(key == Class15.smethod_17(1571027959 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3a299c01dd4f4a209bdbd1b98e3f1406)))
							{
								goto IL_1057;
							}
							num2 = 140;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_55c1fea936c04e47abbfb2b5f778aff7 != 0)
							{
								goto IL_0502;
							}
							continue;
							IL_0848:
							if (num3 != 353304077U)
							{
								goto Block_60;
							}
							goto IL_0801;
							IL_0857:
							if (!(key == Class15.smethod_17(124804536 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_57ce3fecb9e64a8f924ea7658e146719)))
							{
								goto IL_1057;
							}
							num2 = 120;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ee35a23edd8f4998990ec1a2b40fc61a != 0)
							{
								goto Block_62;
							}
							continue;
							IL_08AA:
							num3 = <PrivateImplementationDetails>.ComputeStringHash(key);
							num2 = 10;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_6f87b5b72b9847f7b8ec5b44b0dccfa8 == 0)
							{
								goto IL_04B4;
							}
						}
						IL_012D:
						this.method_2().ReadOnly = new bool?((bool)keyValuePair.Value);
						num2 = 12;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ad967bb0ba3f44528134c153f7ab1ef6 != 0)
						{
							break;
						}
						goto IL_08D9;
						IL_010C:
						if (key == Class15.smethod_17(124804524 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_57ce3fecb9e64a8f924ea7658e146719))
						{
							goto IL_012D;
						}
						break;
					}
					Block_7:
					Block_9:
					Block_13:
					Block_15:
					Block_21:
					Block_22:
					Block_23:
					Block_24:
					Block_26:
					Block_28:
					Block_41:
					Block_46:
					Block_49:
					Block_51:
					Block_52:
					Block_55:
					Block_57:
					Block_60:
					continue;
					IL_0C02:
					this.method_9(keyValuePair.Value);
					continue;
					IL_0C14:
					if (num3 != 2692244416U)
					{
						continue;
					}
					IL_0C23:
					if (!(key == Class15.smethod_17(543279594 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_43b8cdd768c545d884bf7ff1c8fefe89)))
					{
						continue;
					}
					IL_0C44:
					this.method_2().Disallow = this.method_13(keyValuePair.Value);
					continue;
					IL_0C67:
					this.method_2().Pattern = (string)keyValuePair.Value;
					continue;
					Block_62:
					goto IL_0C67;
					IL_0C83:
					if (num3 != 879704937U)
					{
						continue;
					}
					goto IL_0C92;
					Block_32:
					goto IL_0C83;
					IL_0C92:
					if (key == Class15.smethod_17(1953653503 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e368897ba1744663a6d0bc59b9b65b5f))
					{
						goto IL_1040;
					}
					continue;
					IL_0CB9:
					if (!(key == Class15.smethod_17(1176499588 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93c7140125045538ae5c40c6f39a5af)))
					{
						continue;
					}
					goto IL_0F52;
					IL_0CEF:
					if (key == Class15.smethod_17(552154570 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_01137da6c88c4265bdc0297aacf3340f))
					{
						goto IL_0E5C;
					}
					continue;
					IL_0CE0:
					if (num3 != 1542649473U)
					{
						goto IL_0E05;
					}
					goto IL_0CEF;
					Block_35:
					goto IL_0CE0;
					IL_0D28:
					if (!(key == Class15.smethod_17(768738838 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3baf10aa2a73406aa2bb349717d797c7)))
					{
						continue;
					}
					IL_0D49:
					this.method_2().ExclusiveMinimum = new bool?((bool)keyValuePair.Value);
					continue;
					IL_0D88:
					this.method_8(keyValuePair.Value);
					continue;
					IL_0D9A:
					if (num3 != 2609687125U)
					{
						continue;
					}
					IL_0DA9:
					if (key == Class15.smethod_17(635765439 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a41eabd4b99f489fb7d86310d3f95ba2))
					{
						goto IL_0DE9;
					}
					continue;
					IL_0DCD:
					this.method_2().Title = (string)keyValuePair.Value;
					continue;
					Block_43:
					goto IL_0DCD;
					IL_0DE9:
					this.method_2().Requires = (string)keyValuePair.Value;
					continue;
					IL_0E05:
					if (num3 != 1693958795U)
					{
						continue;
					}
					IL_0E14:
					if (!(key == Class15.smethod_17(1802320359 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_991c06e999c744809f5b643cb7d9e7b4)))
					{
						continue;
					}
					IL_0E35:
					this.method_2().ExclusiveMaximum = new bool?((bool)keyValuePair.Value);
					continue;
					IL_0E5C:
					this.method_2().Maximum = new double?((double)keyValuePair.Value);
					continue;
					Block_54:
					goto IL_0E5C;
					IL_0E7E:
					if (!(key == Class15.smethod_17(926405377 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b2d935deb963472994f6f2321f1a6296)))
					{
						continue;
					}
					IL_0E9F:
					this.method_2().Id = (string)keyValuePair.Value;
					continue;
					IL_0EC1:
					if (!(key == Class15.smethod_17(1678051694 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ee35a23edd8f4998990ec1a2b40fc61a)))
					{
						continue;
					}
					IL_0EE2:
					this.method_2().MinimumLength = new int?((int)keyValuePair.Value);
					continue;
					IL_0F04:
					if (num3 != 3947606640U)
					{
						continue;
					}
					goto IL_0F13;
					Block_18:
					goto IL_0F04;
					IL_0F13:
					if (!(key == Class15.smethod_17(2008594837 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5c76a4eb2c1748d1bee3513c8eaff2eb)))
					{
						continue;
					}
					IL_0F34:
					this.method_2().PatternProperties = this.method_11(keyValuePair.Value);
					continue;
					IL_0F52:
					this.method_2().Properties = this.method_11(keyValuePair.Value);
					continue;
					Block_20:
					goto IL_0F52;
					IL_0F6F:
					this.method_2().MaximumLength = new int?((int)keyValuePair.Value);
					continue;
					IL_0FA8:
					this.method_2().UniqueItems = (bool)keyValuePair.Value;
					continue;
					IL_0FCB:
					if (key == Class15.smethod_17(642161482 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa29cbda752f45acbe81e7d5285df2ba))
					{
						goto IL_0FE9;
					}
					continue;
					Block_4:
					goto IL_0FCB;
					IL_0FE9:
					this.method_2().Required = new bool?((bool)keyValuePair.Value);
					continue;
					IL_1007:
					if (num3 != 981021583U)
					{
						continue;
					}
					IL_1013:
					if (!(key == Class15.smethod_17(197543659 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c27e9fccdfcc44999155a4980faa4e81)))
					{
						continue;
					}
					IL_1031:
					this.method_12(keyValuePair.Value);
					continue;
					IL_1040:
					this.method_2().Description = (string)keyValuePair.Value;
				}
				IL_1063:;
			}
			finally
			{
				IEnumerator<KeyValuePair<string, JToken>> enumerator;
				if (enumerator != null)
				{
					goto IL_1091;
				}
				int num4 = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39a47a907a8a440980940ae96da3f3ad == 0)
				{
					goto IL_10AA;
				}
				IL_107D:
				switch (num4)
				{
				case 2:
					IL_1091:
					enumerator.Dispose();
					num4 = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_52d717cd31b74287b67c03ee736a6211 != 0)
					{
						goto IL_107D;
					}
					break;
				}
				IL_10AA:;
			}
		}

		// Token: 0x06000CAB RID: 3243 RVA: 0x0006D8DC File Offset: 0x0006BADC
		private void method_7(JToken jtoken_0)
		{
			IList<JsonSchema> list;
			IEnumerator<JToken> enumerator;
			JsonSchema jsonSchema;
			for (;;)
			{
				list = new List<JsonSchema>();
				int num = 4;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c5a086ee5649458eb5e1e6e4f0f1f4d3 != 0)
				{
					goto IL_0022;
				}
				IL_0048:
				switch (num)
				{
				case 1:
					goto IL_002E;
				case 2:
					goto IL_00A6;
				case 3:
					goto IL_0164;
				case 4:
					goto IL_015A;
				case 5:
					IL_0022:
					if (jtoken_0.Type == JTokenType.Array)
					{
						goto IL_0003;
					}
					goto IL_002E;
				case 6:
					continue;
				case 7:
					goto IL_0003;
				case 8:
				case 9:
					return;
				case 10:
					goto IL_0151;
				}
				goto Block_3;
				IL_0003:
				enumerator = ((IEnumerable<JToken>)jtoken_0).GetEnumerator();
				num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e368897ba1744663a6d0bc59b9b65b5f == 0)
				{
					break;
				}
				goto IL_0048;
				IL_002E:
				jsonSchema = this.method_5(jtoken_0);
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_57ce3fecb9e64a8f924ea7658e146719 == 0)
				{
					goto IL_0048;
				}
				goto IL_0097;
			}
			goto IL_00A6;
			Block_3:
			IL_0097:
			if (jsonSchema != null)
			{
				goto IL_0151;
			}
			goto IL_015A;
			IL_00A6:
			try
			{
				for (;;)
				{
					if (enumerator.MoveNext())
					{
						goto IL_00AA;
					}
					int num2 = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d5af2cccac2f47ed978e804138a35d1c == 0)
					{
						break;
					}
					IL_00C4:
					JToken jtoken;
					switch (num2)
					{
					case 1:
						goto IL_00DD;
					case 2:
						IL_00AA:
						jtoken = enumerator.Current;
						num2 = 1;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c5a086ee5649458eb5e1e6e4f0f1f4d3 == 0)
						{
							goto IL_00C4;
						}
						goto IL_00DD;
					case 3:
						continue;
					}
					break;
					IL_00DD:
					list.Add(this.method_5(jtoken));
				}
				goto IL_015A;
			}
			finally
			{
				if (enumerator != null)
				{
					int num3 = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3baf10aa2a73406aa2bb349717d797c7 != 0)
					{
						goto IL_013F;
					}
					IL_0127:
					enumerator.Dispose();
					num3 = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa29cbda752f45acbe81e7d5285df2ba == 0)
					{
						goto IL_0150;
					}
					IL_013F:
					switch (num3)
					{
					case 0:
						goto IL_0127;
					case 1:
						break;
					default:
						goto IL_0127;
					}
				}
				IL_0150:;
			}
			IL_0151:
			list.Add(jsonSchema);
			IL_015A:
			if (list.Count <= 0)
			{
				return;
			}
			IL_0164:
			this.method_2().Extends = list;
		}

		// Token: 0x06000CAC RID: 3244 RVA: 0x0006DA6C File Offset: 0x0006BC6C
		private void method_8(JToken jtoken_0)
		{
			IL_004B:
			while (jtoken_0.Type == JTokenType.Array)
			{
				this.method_2().Enum = new List<JToken>();
				for (;;)
				{
					IEnumerator<JToken> enumerator = ((IEnumerable<JToken>)jtoken_0).GetEnumerator();
					int num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3a299c01dd4f4a209bdbd1b98e3f1406 == 0)
					{
						switch (num)
						{
						case 1:
							goto IL_008C;
						case 2:
							goto IL_0054;
						case 3:
							goto IL_004B;
						case 4:
							continue;
						}
						break;
					}
					goto IL_008B;
				}
				return;
				IL_008B:
				IL_008C:
				try
				{
					for (;;)
					{
						IEnumerator<JToken> enumerator;
						if (enumerator.MoveNext())
						{
							goto IL_0090;
						}
						int num2 = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2a74c5ebb7d84adcad853e2eda393dc4 == 0)
						{
							break;
						}
						switch (num2)
						{
						case 0:
							goto IL_0090;
						case 1:
							goto IL_00E8;
						case 2:
							continue;
						case 3:
							break;
						default:
							goto IL_0090;
						}
						IL_0099:
						JToken jtoken;
						this.method_2().Enum.Add(jtoken.DeepClone());
						continue;
						IL_0090:
						jtoken = enumerator.Current;
						goto IL_0099;
					}
					IL_00E8:;
				}
				finally
				{
					IEnumerator<JToken> enumerator;
					if (enumerator != null)
					{
						int num3 = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39f35935adc2477fa894750fee078177 == 0)
						{
							goto IL_0118;
						}
						IL_0100:
						enumerator.Dispose();
						num3 = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93ade03426d44b1841bfa7c633f49f3 == 0)
						{
							goto IL_0129;
						}
						IL_0118:
						switch (num3)
						{
						case 0:
							goto IL_0100;
						case 1:
							break;
						default:
							goto IL_0100;
						}
					}
					IL_0129:;
				}
				return;
			}
			IL_0054:
			throw JsonException.Create(jtoken_0, jtoken_0.Path, Class15.smethod_17(538785117 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_725e5f82c8704b39b66ebddcee8df7fa).FormatWith(CultureInfo.InvariantCulture, jtoken_0.Type));
		}

		// Token: 0x06000CAD RID: 3245 RVA: 0x0006DBB4 File Offset: 0x0006BDB4
		private void method_9(JToken jtoken_0)
		{
			while (jtoken_0.Type == JTokenType.Boolean)
			{
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_aa43e77a676848e0bd70abf647d6a9f1 != 0)
				{
					goto IL_0015;
				}
				IL_0037:
				switch (num)
				{
				case 1:
					continue;
				case 2:
					return;
				case 3:
					return;
				}
				IL_0015:
				this.method_2().AllowAdditionalProperties = (bool)jtoken_0;
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cbfb1e54efd84756a9b6d7b21adc0d65 != 0)
				{
					goto IL_0037;
				}
				return;
			}
			this.method_2().AdditionalProperties = this.method_5(jtoken_0);
		}

		// Token: 0x06000CAE RID: 3246 RVA: 0x0006DC34 File Offset: 0x0006BE34
		private void method_10(JToken jtoken_0)
		{
			while (jtoken_0.Type == JTokenType.Boolean)
			{
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_6bf87ae21d2446cfa7edc53669bb8039 != 0)
				{
					goto IL_0015;
				}
				IL_0037:
				switch (num)
				{
				case 1:
					IL_0015:
					this.method_2().AllowAdditionalItems = (bool)jtoken_0;
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_48fe014748e848c88d3254f339047927 != 0)
					{
						goto IL_0037;
					}
					break;
				case 2:
					continue;
				case 3:
					return;
				}
				return;
			}
			this.method_2().AdditionalItems = this.method_5(jtoken_0);
		}

		// Token: 0x06000CAF RID: 3247 RVA: 0x0006DCB4 File Offset: 0x0006BEB4
		private IDictionary<string, JsonSchema> method_11(JToken jtoken_0)
		{
			IDictionary<string, JsonSchema> dictionary = new Dictionary<string, JsonSchema>();
			if (jtoken_0.Type != JTokenType.Object)
			{
				throw JsonException.Create(jtoken_0, jtoken_0.Path, Class15.smethod_17(1424620616 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bca7529ca324c188cfc0e64eb7d1cdf).FormatWith(CultureInfo.InvariantCulture, jtoken_0.Type));
			}
			foreach (JToken jtoken in ((IEnumerable<JToken>)jtoken_0))
			{
				JProperty jproperty = (JProperty)jtoken;
				if (dictionary.ContainsKey(jproperty.Name))
				{
					throw new JsonException(Class15.smethod_17(197542905 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c27e9fccdfcc44999155a4980faa4e81).FormatWith(CultureInfo.InvariantCulture, jproperty.Name));
				}
				dictionary.Add(jproperty.Name, this.method_5(jproperty.Value));
			}
			return dictionary;
		}

		// Token: 0x06000CB0 RID: 3248 RVA: 0x0006DD98 File Offset: 0x0006BF98
		private void method_12(JToken jtoken_0)
		{
			for (;;)
			{
				IL_00B7:
				this.method_2().Items = new List<JsonSchema>();
				for (;;)
				{
					IL_00AD:
					JTokenType type = jtoken_0.Type;
					for (;;)
					{
						if (type == JTokenType.Object)
						{
							goto IL_0063;
						}
						int num = 1;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93c7140125045538ae5c40c6f39a5af != 0)
						{
							goto IL_0006;
						}
						IL_002E:
						switch (num)
						{
						case 1:
							IL_0006:
							if (type != JTokenType.Array)
							{
								goto Block_1;
							}
							this.method_2().PositionalItemsValidation = true;
							num = 4;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c08ab7af63da4f24a4fa3e9c7a732fae != 0)
							{
								goto IL_002E;
							}
							break;
						case 2:
							goto IL_00D7;
						case 3:
							continue;
						case 4:
							goto IL_00CF;
						case 5:
							goto IL_00AD;
						case 6:
							goto IL_00B7;
						case 7:
							return;
						case 8:
						case 9:
							goto IL_0194;
						case 10:
							goto IL_01CB;
						}
						IL_0063:
						this.method_2().Items.Add(this.method_5(jtoken_0));
						num = 10;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0361b8eb39074ea88f5257b13904930a == 0)
						{
							goto Block_3;
						}
						goto IL_002E;
					}
				}
			}
			Block_1:
			goto IL_0194;
			Block_3:
			return;
			IL_00CF:
			IEnumerator<JToken> enumerator = ((IEnumerable<JToken>)jtoken_0).GetEnumerator();
			IL_00D7:
			try
			{
				for (;;)
				{
					if (enumerator.MoveNext())
					{
						goto IL_011C;
					}
					int num2 = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_43b32b9d66294210a955990bb6fcc511 != 0)
					{
						break;
					}
					IL_0104:
					JToken jtoken;
					switch (num2)
					{
					case 1:
						continue;
					case 2:
						goto IL_00DB;
					case 3:
						IL_011C:
						jtoken = enumerator.Current;
						goto IL_00DB;
					}
					break;
					IL_00DB:
					this.method_2().Items.Add(this.method_5(jtoken));
					num2 = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39f35935adc2477fa894750fee078177 != 0)
					{
						goto IL_0104;
					}
					break;
				}
			}
			finally
			{
				if (enumerator != null)
				{
					goto IL_0179;
				}
				int num3 = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d97e64d0f425406b9649f2b4562a5f0e == 0)
				{
					goto IL_0192;
				}
				IL_0165:
				switch (num3)
				{
				case 2:
					IL_0179:
					enumerator.Dispose();
					num3 = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39a47a907a8a440980940ae96da3f3ad != 0)
					{
						goto IL_0165;
					}
					break;
				}
				IL_0192:;
			}
			return;
			IL_0194:
			throw JsonException.Create(jtoken_0, jtoken_0.Path, Class15.smethod_17(2008595599 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5c76a4eb2c1748d1bee3513c8eaff2eb).FormatWith(CultureInfo.InvariantCulture, jtoken_0.Type));
			IL_01CB:
			this.method_2().PositionalItemsValidation = false;
		}

		// Token: 0x06000CB1 RID: 3249 RVA: 0x0006DF8C File Offset: 0x0006C18C
		private JsonSchemaType? method_13(JToken jtoken_0)
		{
			JTokenType type = jtoken_0.Type;
			if (type == JTokenType.Array)
			{
				JsonSchemaType? jsonSchemaType = new JsonSchemaType?(JsonSchemaType.None);
				foreach (JToken jtoken in ((IEnumerable<JToken>)jtoken_0))
				{
					if (jtoken.Type != JTokenType.String)
					{
						throw JsonException.Create(jtoken, jtoken.Path, Class15.smethod_17(197542581 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c27e9fccdfcc44999155a4980faa4e81).FormatWith(CultureInfo.InvariantCulture, jtoken_0.Type));
					}
					jsonSchemaType |= JsonSchemaBuilder.MapType((string)jtoken);
				}
				return jsonSchemaType;
			}
			if (type != JTokenType.String)
			{
				throw JsonException.Create(jtoken_0, jtoken_0.Path, Class15.smethod_17(2008595787 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5c76a4eb2c1748d1bee3513c8eaff2eb).FormatWith(CultureInfo.InvariantCulture, jtoken_0.Type));
			}
			return new JsonSchemaType?(JsonSchemaBuilder.MapType((string)jtoken_0));
		}

		// Token: 0x06000CB2 RID: 3250 RVA: 0x0006E0AC File Offset: 0x0006C2AC
		internal static JsonSchemaType MapType(string type)
		{
			JsonSchemaType jsonSchemaType;
			while (!JsonSchemaConstants.JsonSchemaTypeMapping.TryGetValue(type, out jsonSchemaType))
			{
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8bcabc342a5a44748f3978da7f62051e != 0)
				{
					switch (num)
					{
					case 1:
						continue;
					}
				}
				throw new JsonException(Class15.smethod_17(1387511636 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e5c1d856e0c64e6f8377f7d819e11923).FormatWith(CultureInfo.InvariantCulture, type));
			}
			return jsonSchemaType;
		}

		// Token: 0x06000CB3 RID: 3251 RVA: 0x0006E118 File Offset: 0x0006C318
		internal static string MapType(JsonSchemaType type)
		{
			KeyValuePair<string, JsonSchemaType> keyValuePair;
			for (;;)
			{
				IL_0061:
				JsonSchemaBuilder.<>c__DisplayClass23_0 CS$<>8__locals1 = new JsonSchemaBuilder.<>c__DisplayClass23_0();
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3a102d6e4dd542a6855b81a93c692545 != 0)
				{
					goto IL_0030;
				}
				for (;;)
				{
					IL_0049:
					switch (num)
					{
					case 1:
						goto IL_0030;
					case 2:
						goto IL_0061;
					case 3:
						keyValuePair = JsonSchemaConstants.JsonSchemaTypeMapping.Single(new Func<KeyValuePair<string, JsonSchemaType>, bool>(CS$<>8__locals1.method_0));
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ee35a23edd8f4998990ec1a2b40fc61a == 0)
						{
							continue;
						}
						break;
					}
					goto Block_2;
				}
				IL_0030:
				CS$<>8__locals1.jsonSchemaType_0 = type;
				num = 3;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bca7529ca324c188cfc0e64eb7d1cdf != 0)
				{
					goto IL_0049;
				}
				break;
			}
			Block_2:
			return keyValuePair.Key;
		}

		// Token: 0x04000602 RID: 1538
		private readonly IList<JsonSchema> ilist_0;

		// Token: 0x04000603 RID: 1539
		private readonly JsonSchemaResolver jsonSchemaResolver_0;

		// Token: 0x04000604 RID: 1540
		private readonly IDictionary<string, JsonSchema> idictionary_0;

		// Token: 0x04000605 RID: 1541
		private JsonSchema jsonSchema_0;

		// Token: 0x04000606 RID: 1542
		private JObject jobject_0;
	}
}
