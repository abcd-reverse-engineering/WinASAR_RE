using System;
using System.Collections.Generic;
using System.Linq;

namespace Newtonsoft.Json.Schema
{
	// Token: 0x02000136 RID: 310
	[Obsolete("JSON Schema validation has been moved to its own package. See https://www.newtonsoft.com/jsonschema for more details.")]
	internal class JsonSchemaModelBuilder
	{
		// Token: 0x06000D22 RID: 3362 RVA: 0x0006FEC8 File Offset: 0x0006E0C8
		public JsonSchemaModel Build(JsonSchema schema)
		{
			for (;;)
			{
				this.jsonSchemaNodeCollection_0 = new JsonSchemaNodeCollection();
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3a102d6e4dd542a6855b81a93c692545 == 0)
				{
					goto IL_0022;
				}
				IL_0032:
				switch (num)
				{
				case 0:
					goto IL_0022;
				case 1:
					continue;
				case 2:
					goto IL_006A;
				case 3:
					break;
				default:
					goto IL_0022;
				}
				IL_0003:
				this.dictionary_0 = new Dictionary<JsonSchemaNode, JsonSchemaModel>();
				num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_57ce3fecb9e64a8f924ea7658e146719 != 0)
				{
					break;
				}
				goto IL_0032;
				IL_0022:
				this.jsonSchemaNode_0 = this.AddSchema(null, schema);
				goto IL_0003;
			}
			IL_006A:
			return this.method_0(this.jsonSchemaNode_0);
		}

		// Token: 0x06000D23 RID: 3363 RVA: 0x0006FF4C File Offset: 0x0006E14C
		public JsonSchemaNode AddSchema(JsonSchemaNode existingNode, JsonSchema schema)
		{
			JsonSchemaNode jsonSchemaNode;
			string text;
			for (;;)
			{
				IL_02AA:
				if (existingNode != null)
				{
					goto IL_0279;
				}
				int num = 20;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_991c06e999c744809f5b643cb7d9e7b4 == 0)
				{
					goto IL_0134;
				}
				for (;;)
				{
					IL_01F2:
					switch (num)
					{
					case 0:
						goto IL_00B2;
					case 1:
						goto IL_0053;
					case 2:
					case 11:
						goto IL_0085;
					case 3:
					case 18:
						goto IL_00CB;
					case 4:
					case 26:
						goto IL_00E2;
					case 5:
					case 10:
						return jsonSchemaNode;
					case 6:
						this.AddProperties(schema.Properties, jsonSchemaNode.Properties);
						num = 24;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8db627a8c96145a0afb24deffd2a8808 != 0)
						{
							continue;
						}
						break;
					case 7:
					case 30:
						goto IL_0020;
					case 8:
						goto IL_0279;
					case 9:
						goto IL_0134;
					case 12:
						goto IL_0184;
					case 13:
						return existingNode;
					case 14:
						goto IL_0063;
					case 15:
						goto IL_0123;
					case 16:
						goto IL_02B0;
					case 17:
						break;
					case 19:
						goto IL_033F;
					case 20:
					case 25:
						text = JsonSchemaNode.GetId(new JsonSchema[] { schema });
						goto IL_00E2;
					case 21:
						goto IL_02AA;
					case 22:
						goto IL_012C;
					case 23:
						text = JsonSchemaNode.GetId(existingNode.Schemas.Union(new JsonSchema[] { schema }));
						num = 11;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c28a4ed7a58e45aaa9902e336fd60b97 == 0)
						{
							goto IL_00E2;
						}
						continue;
					case 24:
						this.AddProperties(schema.PatternProperties, jsonSchemaNode.PatternProperties);
						goto IL_0184;
					case 27:
						goto IL_00DD;
					case 28:
						goto IL_0093;
					case 29:
						goto IL_004B;
					default:
						goto IL_00B2;
					}
					IL_0028:
					this.AddAdditionalItems(jsonSchemaNode, schema.AdditionalItems);
					num = 24;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93ade03426d44b1841bfa7c633f49f3 == 0)
					{
						goto IL_004B;
					}
					continue;
					IL_0020:
					if (schema.AdditionalItems != null)
					{
						goto IL_0028;
					}
					goto IL_004B;
					IL_0184:
					if (schema.Items == null)
					{
						goto IL_0020;
					}
					goto IL_00DD;
					IL_0063:
					IEnumerator<JsonSchema> enumerator = schema.Extends.GetEnumerator();
					num = 16;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c27e9fccdfcc44999155a4980faa4e81 != 0)
					{
						continue;
					}
					IL_0085:
					if (schema.Extends == null)
					{
						goto Block_2;
					}
					goto IL_0063;
					IL_0053:
					this.AddAdditionalProperties(jsonSchemaNode, schema.AdditionalProperties);
					goto IL_0085;
					IL_004B:
					if (schema.AdditionalProperties != null)
					{
						goto IL_0053;
					}
					goto IL_0085;
					IL_00CB:
					int num2;
					if (num2 < schema.Items.Count)
					{
						goto IL_00B2;
					}
					num = 30;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5c76a4eb2c1748d1bee3513c8eaff2eb == 0)
					{
						goto IL_0093;
					}
					continue;
					IL_00DD:
					num2 = 0;
					goto IL_00CB;
					IL_0093:
					num2++;
					goto IL_00CB;
					IL_00B2:
					this.AddItem(jsonSchemaNode, num2, schema.Items[num2]);
					goto IL_0093;
					IL_00E2:
					if (this.jsonSchemaNodeCollection_0.Contains(text))
					{
						num = 19;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39d5fbfa4fe34ed9908db538e5340a6c == 0)
						{
							goto Block_6;
						}
					}
					else
					{
						if (existingNode == null)
						{
							goto IL_012C;
						}
						num = 3;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4b8a72ce901241b5b52fe60600cb3607 == 0)
						{
							goto IL_0123;
						}
					}
				}
				IL_0132:
				JsonSchemaNode jsonSchemaNode2;
				jsonSchemaNode = jsonSchemaNode2;
				goto IL_0134;
				IL_012C:
				jsonSchemaNode2 = new JsonSchemaNode(schema);
				goto IL_0132;
				IL_0123:
				jsonSchemaNode2 = existingNode.Combine(schema);
				goto IL_0132;
				IL_0279:
				while (!existingNode.Schemas.Contains(schema))
				{
					num = 23;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c27e9fccdfcc44999155a4980faa4e81 != 0)
					{
						goto IL_01F2;
					}
				}
				return existingNode;
				IL_0134:
				this.jsonSchemaNodeCollection_0.Add(jsonSchemaNode);
				num = 6;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0005996a6a494de4880ac2956b2e0112 == 0)
				{
					break;
				}
				goto IL_01F2;
			}
			Block_2:
			return jsonSchemaNode;
			Block_6:
			goto IL_033E;
			IL_02B0:
			try
			{
				IL_02F3:
				IEnumerator<JsonSchema> enumerator;
				while (enumerator.MoveNext())
				{
					JsonSchema jsonSchema;
					for (;;)
					{
						jsonSchema = enumerator.Current;
						int num3 = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_725e5f82c8704b39b66ebddcee8df7fa != 0)
						{
							switch (num3)
							{
							case 1:
								continue;
							case 2:
								goto IL_02F3;
							case 3:
								goto IL_02FC;
							}
							break;
						}
						break;
					}
					IL_02E7:
					jsonSchemaNode = this.AddSchema(jsonSchemaNode, jsonSchema);
					continue;
					goto IL_02E7;
				}
				IL_02FC:
				return jsonSchemaNode;
			}
			finally
			{
				IEnumerator<JsonSchema> enumerator;
				if (enumerator != null)
				{
					int num4 = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8d68b74cee6442019d959192b2974e3d == 0)
					{
						goto IL_032C;
					}
					IL_0314:
					enumerator.Dispose();
					num4 = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa49bb51056944098afe92e3a80a544b == 0)
					{
						goto IL_033D;
					}
					IL_032C:
					switch (num4)
					{
					case 0:
						goto IL_0314;
					case 1:
						break;
					default:
						goto IL_0314;
					}
				}
				IL_033D:;
			}
			IL_033E:
			IL_033F:
			return this.jsonSchemaNodeCollection_0[text];
		}

		// Token: 0x06000D24 RID: 3364 RVA: 0x000702BC File Offset: 0x0006E4BC
		public void AddProperties(IDictionary<string, JsonSchema> source, IDictionary<string, JsonSchemaNode> target)
		{
			if (source != null)
			{
				foreach (KeyValuePair<string, JsonSchema> keyValuePair in source)
				{
					this.AddProperty(target, keyValuePair.Key, keyValuePair.Value);
				}
			}
		}

		// Token: 0x06000D25 RID: 3365 RVA: 0x00070318 File Offset: 0x0006E518
		public void AddProperty(IDictionary<string, JsonSchemaNode> target, string propertyName, JsonSchema schema)
		{
			JsonSchemaNode jsonSchemaNode;
			target.TryGetValue(propertyName, out jsonSchemaNode);
			target[propertyName] = this.AddSchema(jsonSchemaNode, schema);
		}

		// Token: 0x06000D26 RID: 3366 RVA: 0x00070340 File Offset: 0x0006E540
		public void AddItem(JsonSchemaNode parentNode, int index, JsonSchema schema)
		{
			JsonSchemaNode jsonSchemaNode2;
			for (;;)
			{
				if (parentNode.Items.Count <= index)
				{
					goto IL_0095;
				}
				int num = 3;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_948fa5c193d44e279b41c3a0fab7b5c9 == 0)
				{
					goto IL_0085;
				}
				IL_0027:
				JsonSchemaNode jsonSchemaNode;
				JsonSchemaNode jsonSchemaNode3;
				switch (num)
				{
				case 1:
					goto IL_00C1;
				case 2:
					goto IL_0067;
				case 3:
					return;
				case 4:
					IL_0085:
					jsonSchemaNode = parentNode.Items[index];
					goto IL_0091;
				case 5:
					continue;
				case 6:
					IL_0078:
					jsonSchemaNode2 = this.AddSchema(jsonSchemaNode3, schema);
					goto IL_0067;
				case 7:
					IL_0095:
					jsonSchemaNode = null;
					goto IL_0091;
				case 8:
					return;
				}
				IL_0006:
				parentNode.Items.Add(jsonSchemaNode2);
				num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cbfb1e54efd84756a9b6d7b21adc0d65 != 0)
				{
					goto IL_0027;
				}
				return;
				IL_0067:
				if (parentNode.Items.Count <= index)
				{
					goto IL_0006;
				}
				num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3a299c01dd4f4a209bdbd1b98e3f1406 == 0)
				{
					break;
				}
				goto IL_0027;
				IL_0091:
				jsonSchemaNode3 = jsonSchemaNode;
				goto IL_0078;
			}
			IL_00C1:
			parentNode.Items[index] = jsonSchemaNode2;
		}

		// Token: 0x06000D27 RID: 3367 RVA: 0x00070420 File Offset: 0x0006E620
		public void AddAdditionalProperties(JsonSchemaNode parentNode, JsonSchema schema)
		{
			for (;;)
			{
				parentNode.AdditionalProperties = this.AddSchema(parentNode.AdditionalProperties, schema);
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a41eabd4b99f489fb7d86310d3f95ba2 == 0)
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

		// Token: 0x06000D28 RID: 3368 RVA: 0x00070464 File Offset: 0x0006E664
		public void AddAdditionalItems(JsonSchemaNode parentNode, JsonSchema schema)
		{
			for (;;)
			{
				parentNode.AdditionalItems = this.AddSchema(parentNode.AdditionalItems, schema);
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ad967bb0ba3f44528134c153f7ab1ef6 == 0)
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

		// Token: 0x06000D29 RID: 3369 RVA: 0x000704A8 File Offset: 0x0006E6A8
		private JsonSchemaModel method_0(JsonSchemaNode jsonSchemaNode_1)
		{
			IL_03D5:
			JsonSchemaModel jsonSchemaModel;
			while (!this.dictionary_0.TryGetValue(jsonSchemaNode_1, out jsonSchemaModel))
			{
				int num = 12;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_6bf87ae21d2446cfa7edc53669bb8039 != 0)
				{
					goto IL_00AA;
				}
				for (;;)
				{
					IL_038E:
					List<JsonSchemaNode>.Enumerator enumerator;
					switch (num)
					{
					case 1:
						goto IL_005F;
					case 2:
						goto IL_0042;
					case 3:
						goto IL_007D;
					case 4:
						goto IL_02AA;
					case 5:
						return jsonSchemaModel;
					case 6:
						return jsonSchemaModel;
					case 7:
						goto IL_01D2;
					case 8:
						try
						{
							while (enumerator.MoveNext())
							{
								for (;;)
								{
									IL_0349:
									JsonSchemaNode jsonSchemaNode = enumerator.Current;
									for (;;)
									{
										IL_033D:
										if (jsonSchemaModel.Items != null)
										{
											goto IL_0301;
										}
										int num2 = 2;
										if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_75738dd4edc84122bfe3748a1ea03d43 != 0)
										{
											goto IL_0301;
										}
										for (;;)
										{
											IL_02E0:
											switch (num2)
											{
											case 1:
												goto IL_0301;
											case 2:
												jsonSchemaModel.Items = new List<JsonSchemaModel>();
												num2 = 0;
												if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_871a407507f34aa3b5bf52517d4f63a9 == 0)
												{
													continue;
												}
												goto IL_0300;
											case 3:
												goto IL_035E;
											case 4:
												goto IL_033D;
											case 5:
												goto IL_0349;
											}
											goto Block_25;
										}
										IL_0300:
										IL_0301:
										jsonSchemaModel.Items.Add(this.method_0(jsonSchemaNode));
										num2 = 0;
										if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7dfc957a76cb4c58b17dc74a084c4e4a == 0)
										{
											goto Block_26;
										}
										goto IL_02E0;
									}
								}
								Block_25:
								Block_26:;
							}
							IL_035E:
							goto IL_0042;
						}
						finally
						{
							((IDisposable)enumerator).Dispose();
							int num3 = 0;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ad967bb0ba3f44528134c153f7ab1ef6 != 0)
							{
								switch (num3)
								{
								}
							}
						}
						continue;
					case 9:
						goto IL_01C5;
					case 10:
						goto IL_00F4;
					case 11:
						goto IL_0072;
					case 12:
						goto IL_00AA;
					case 13:
						goto IL_03D5;
					case 14:
						goto IL_0020;
					}
					break;
					IL_0020:
					enumerator = jsonSchemaNode_1.Items.GetEnumerator();
					num = 8;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39d5fbfa4fe34ed9908db538e5340a6c == 0)
					{
						goto IL_0042;
					}
					continue;
					IL_00F4:
					Dictionary<string, JsonSchemaNode>.Enumerator enumerator2;
					try
					{
						for (;;)
						{
							if (enumerator2.MoveNext())
							{
								goto IL_00FB;
							}
							int num4 = 0;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9bd9937edf9d4ad8bd673dfcb5a5e3cb == 0)
							{
								break;
							}
							IL_0115:
							KeyValuePair<string, JsonSchemaNode> keyValuePair;
							switch (num4)
							{
							case 1:
								goto IL_013A;
							case 2:
								IL_00FB:
								keyValuePair = enumerator2.Current;
								num4 = 0;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3dc45d1ecdeb4859b7f470093f5eeed2 != 0)
								{
									goto IL_0115;
								}
								goto IL_013A;
							case 3:
								continue;
							case 4:
								goto IL_0143;
							case 5:
							case 6:
								goto IL_014F;
							}
							break;
							IL_014F:
							jsonSchemaModel.PatternProperties[keyValuePair.Key] = this.method_0(keyValuePair.Value);
							continue;
							IL_013A:
							if (jsonSchemaModel.PatternProperties != null)
							{
								goto IL_014F;
							}
							IL_0143:
							jsonSchemaModel.PatternProperties = new Dictionary<string, JsonSchemaModel>();
							goto IL_014F;
						}
						goto IL_0020;
					}
					finally
					{
						((IDisposable)enumerator2).Dispose();
						int num5 = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_48fe014748e848c88d3254f339047927 != 0)
						{
							switch (num5)
							{
							}
						}
					}
					goto IL_01C5;
					IL_02AA:
					enumerator2 = jsonSchemaNode_1.PatternProperties.GetEnumerator();
					goto IL_00F4;
					IL_01D2:
					try
					{
						while (enumerator2.MoveNext())
						{
							for (;;)
							{
								IL_0256:
								KeyValuePair<string, JsonSchemaNode> keyValuePair2 = enumerator2.Current;
								int num6 = 1;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_db7740c6ca7a4f3c8e1aa526bdb0a454 == 0)
								{
									break;
								}
								for (;;)
								{
									switch (num6)
									{
									case 1:
										if (jsonSchemaModel.Properties != null)
										{
											goto IL_01E5;
										}
										num6 = 0;
										if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_991c06e999c744809f5b643cb7d9e7b4 != 0)
										{
											goto IL_01D9;
										}
										continue;
									case 2:
										goto IL_01E5;
									case 3:
										goto IL_01D9;
									case 4:
										goto IL_0256;
									case 5:
										goto IL_027D;
									}
									goto Block_20;
									IL_01E5:
									jsonSchemaModel.Properties[keyValuePair2.Key] = this.method_0(keyValuePair2.Value);
									num6 = 0;
									if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ad967bb0ba3f44528134c153f7ab1ef6 == 0)
									{
										goto Block_17;
									}
									continue;
									IL_01D9:
									jsonSchemaModel.Properties = new Dictionary<string, JsonSchemaModel>();
									goto IL_01E5;
								}
							}
							Block_17:
							Block_20:;
						}
						IL_027D:;
					}
					finally
					{
						((IDisposable)enumerator2).Dispose();
						int num7 = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3cf8a2073cc248c2915ebb05bcd2a099 == 0)
						{
							switch (num7)
							{
							}
						}
					}
					goto IL_02AA;
					IL_01C5:
					enumerator2 = jsonSchemaNode_1.Properties.GetEnumerator();
					goto IL_01D2;
					IL_0042:
					if (jsonSchemaNode_1.AdditionalProperties == null)
					{
						goto IL_0072;
					}
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_079bd9b874b24353bef46f6c3f5d741d != 0)
					{
						goto IL_005F;
					}
					continue;
					IL_007D:
					jsonSchemaModel.AdditionalItems = this.method_0(jsonSchemaNode_1.AdditionalItems);
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e5c1d856e0c64e6f8377f7d819e11923 != 0)
					{
						return jsonSchemaModel;
					}
					continue;
					IL_0072:
					if (jsonSchemaNode_1.AdditionalItems != null)
					{
						goto IL_007D;
					}
					return jsonSchemaModel;
					IL_005F:
					jsonSchemaModel.AdditionalProperties = this.method_0(jsonSchemaNode_1.AdditionalProperties);
					goto IL_0072;
				}
				goto IL_00CC;
				IL_00AA:
				jsonSchemaModel = JsonSchemaModel.Create(jsonSchemaNode_1.Schemas);
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39f35935adc2477fa894750fee078177 == 0)
				{
					goto IL_038E;
				}
				IL_00CC:
				this.dictionary_0[jsonSchemaNode_1] = jsonSchemaModel;
				num = 9;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d97e64d0f425406b9649f2b4562a5f0e == 0)
				{
					break;
				}
				goto IL_038E;
			}
			return jsonSchemaModel;
		}

		// Token: 0x06000D2A RID: 3370 RVA: 0x000708D4 File Offset: 0x0006EAD4
		public JsonSchemaModelBuilder()
		{
			int num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_43b8cdd768c545d884bf7ff1c8fefe89 != 0)
			{
				switch (num)
				{
				}
			}
		}

		// Token: 0x04000653 RID: 1619
		private JsonSchemaNodeCollection jsonSchemaNodeCollection_0 = new JsonSchemaNodeCollection();

		// Token: 0x04000654 RID: 1620
		private Dictionary<JsonSchemaNode, JsonSchemaModel> dictionary_0 = new Dictionary<JsonSchemaNode, JsonSchemaModel>();

		// Token: 0x04000655 RID: 1621
		private JsonSchemaNode jsonSchemaNode_0;
	}
}
