using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Threading;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json
{
	// Token: 0x0200006C RID: 108
	[Obsolete("JSON Schema validation has been moved to its own package. See https://www.newtonsoft.com/jsonschema for more details.")]
	public class JsonValidatingReader : JsonReader, IJsonLineInfo
	{
		// Token: 0x14000003 RID: 3
		// (add) Token: 0x060004A9 RID: 1193 RVA: 0x00037F94 File Offset: 0x00036194
		// (remove) Token: 0x060004AA RID: 1194 RVA: 0x00038038 File Offset: 0x00036238
		public event ValidationEventHandler ValidationEventHandler
		{
			[CompilerGenerated]
			add
			{
				for (;;)
				{
					IL_0089:
					ValidationEventHandler validationEventHandler = this.validationEventHandler_0;
					for (;;)
					{
						IL_0071:
						ValidationEventHandler validationEventHandler2 = validationEventHandler;
						int num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_eaded84ad5b14e1ea8d4d97bfed1bb48 != 0)
						{
							goto IL_0029;
						}
						for (;;)
						{
							IL_0051:
							switch (num)
							{
							case 1:
								if (validationEventHandler != validationEventHandler2)
								{
									goto IL_0071;
								}
								num = 1;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c5a086ee5649458eb5e1e6e4f0f1f4d3 == 0)
								{
									continue;
								}
								return;
							case 2:
								return;
							case 3:
								goto IL_0006;
							case 4:
								goto IL_0071;
							case 5:
								goto IL_0089;
							}
							break;
						}
						goto IL_0029;
						IL_0006:
						ValidationEventHandler validationEventHandler3;
						validationEventHandler = Interlocked.CompareExchange<ValidationEventHandler>(ref this.validationEventHandler_0, validationEventHandler3, validationEventHandler2);
						num = 1;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3bf07bb1c323490cb457eef2b2e78695 == 0)
						{
							goto IL_0051;
						}
						IL_0029:
						validationEventHandler3 = (ValidationEventHandler)Delegate.Combine(validationEventHandler2, value);
						goto IL_0006;
					}
				}
			}
			[CompilerGenerated]
			remove
			{
				for (;;)
				{
					IL_0078:
					ValidationEventHandler validationEventHandler = this.validationEventHandler_0;
					for (;;)
					{
						IL_0072:
						ValidationEventHandler validationEventHandler2 = validationEventHandler;
						for (;;)
						{
							ValidationEventHandler validationEventHandler3 = (ValidationEventHandler)Delegate.Remove(validationEventHandler2, value);
							int num = 1;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_676b866782704933888a7440512fd4ff != 0)
							{
								goto IL_0003;
							}
							IL_0025:
							switch (num)
							{
							case 1:
								IL_0003:
								validationEventHandler = Interlocked.CompareExchange<ValidationEventHandler>(ref this.validationEventHandler_0, validationEventHandler3, validationEventHandler2);
								num = 0;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c28a4ed7a58e45aaa9902e336fd60b97 != 0)
								{
									goto IL_0025;
								}
								break;
							case 2:
								continue;
							case 3:
								return;
							case 4:
								goto IL_0072;
							case 5:
								goto IL_0078;
							}
							break;
						}
						IL_0069:
						if (validationEventHandler == validationEventHandler2)
						{
							return;
						}
						continue;
						goto IL_0069;
					}
				}
			}
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x060004AB RID: 1195 RVA: 0x000032BE File Offset: 0x000014BE
		public override object Value
		{
			get
			{
				return this.jsonReader_0.Value;
			}
		}

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x060004AC RID: 1196 RVA: 0x000032CB File Offset: 0x000014CB
		public override int Depth
		{
			get
			{
				return this.jsonReader_0.Depth;
			}
		}

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x060004AD RID: 1197 RVA: 0x000032D8 File Offset: 0x000014D8
		public override string Path
		{
			get
			{
				return this.jsonReader_0.Path;
			}
		}

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x060004AE RID: 1198 RVA: 0x000032E5 File Offset: 0x000014E5
		// (set) Token: 0x060004AF RID: 1199 RVA: 0x00002420 File Offset: 0x00000620
		public override char QuoteChar
		{
			get
			{
				return this.jsonReader_0.QuoteChar;
			}
			protected internal set
			{
			}
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x060004B0 RID: 1200 RVA: 0x000032F2 File Offset: 0x000014F2
		public override JsonToken TokenType
		{
			get
			{
				return this.jsonReader_0.TokenType;
			}
		}

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x060004B1 RID: 1201 RVA: 0x000032FF File Offset: 0x000014FF
		public override Type ValueType
		{
			get
			{
				return this.jsonReader_0.ValueType;
			}
		}

		// Token: 0x060004B2 RID: 1202 RVA: 0x000380C8 File Offset: 0x000362C8
		private void method_9(JsonValidatingReader.Class1 class1_1)
		{
			for (;;)
			{
				this.stack_0.Push(class1_1);
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0005996a6a494de4880ac2956b2e0112 != 0)
				{
					goto IL_0003;
				}
				IL_001B:
				switch (num)
				{
				case 1:
					IL_0003:
					this.class1_0 = class1_1;
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4152404f503b492c83d9bc2e44bdd0a7 != 0)
					{
						goto IL_001B;
					}
					break;
				case 2:
					continue;
				}
				break;
			}
		}

		// Token: 0x060004B3 RID: 1203 RVA: 0x0000330C File Offset: 0x0000150C
		private JsonValidatingReader.Class1 method_10()
		{
			JsonValidatingReader.Class1 @class = this.stack_0.Pop();
			this.class1_0 = ((this.stack_0.Count == 0) ? null : this.stack_0.Peek());
			return @class;
		}

		// Token: 0x060004B4 RID: 1204 RVA: 0x0000333A File Offset: 0x0000153A
		private IList<JsonSchemaModel> method_11()
		{
			return this.class1_0.method_7();
		}

		// Token: 0x060004B5 RID: 1205 RVA: 0x00038128 File Offset: 0x00036328
		private IList<JsonSchemaModel> method_12()
		{
			if (this.class1_0 == null)
			{
				return new List<JsonSchemaModel>(new JsonSchemaModel[] { this.jsonSchemaModel_0 });
			}
			if (this.class1_0.method_7() == null || this.class1_0.method_7().Count == 0)
			{
				return JsonValidatingReader.ilist_0;
			}
			switch (this.class1_0.TokenType)
			{
			case JTokenType.None:
				return this.class1_0.method_7();
			case JTokenType.Object:
			{
				if (this.class1_0.method_0() == null)
				{
					throw new JsonReaderException(Class15.smethod_17(1788743517 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_1d8dbb531d7349c0bc15bad339f7815c));
				}
				IList<JsonSchemaModel> list = new List<JsonSchemaModel>();
				foreach (JsonSchemaModel jsonSchemaModel in this.method_11())
				{
					JsonSchemaModel jsonSchemaModel2;
					if (jsonSchemaModel.Properties != null && jsonSchemaModel.Properties.TryGetValue(this.class1_0.method_0(), out jsonSchemaModel2))
					{
						list.Add(jsonSchemaModel2);
					}
					if (jsonSchemaModel.PatternProperties != null)
					{
						foreach (KeyValuePair<string, JsonSchemaModel> keyValuePair in jsonSchemaModel.PatternProperties)
						{
							if (Regex.IsMatch(this.class1_0.method_0(), keyValuePair.Key))
							{
								list.Add(keyValuePair.Value);
							}
						}
					}
					if (list.Count == 0 && jsonSchemaModel.AllowAdditionalProperties && jsonSchemaModel.AdditionalProperties != null)
					{
						list.Add(jsonSchemaModel.AdditionalProperties);
					}
				}
				return list;
			}
			case JTokenType.Array:
			{
				IList<JsonSchemaModel> list2 = new List<JsonSchemaModel>();
				foreach (JsonSchemaModel jsonSchemaModel3 in this.method_11())
				{
					if (!jsonSchemaModel3.PositionalItemsValidation)
					{
						if (jsonSchemaModel3.Items != null && jsonSchemaModel3.Items.Count > 0)
						{
							list2.Add(jsonSchemaModel3.Items[0]);
						}
					}
					else
					{
						if (jsonSchemaModel3.Items != null && jsonSchemaModel3.Items.Count > 0 && jsonSchemaModel3.Items.Count > this.class1_0.method_2() - 1)
						{
							list2.Add(jsonSchemaModel3.Items[this.class1_0.method_2() - 1]);
						}
						if (jsonSchemaModel3.AllowAdditionalItems && jsonSchemaModel3.AdditionalItems != null)
						{
							list2.Add(jsonSchemaModel3.AdditionalItems);
						}
					}
				}
				return list2;
			}
			case JTokenType.Constructor:
				return JsonValidatingReader.ilist_0;
			default:
				throw new ArgumentOutOfRangeException(Class15.smethod_17(41441125 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_079bd9b874b24353bef46f6c3f5d741d), Class15.smethod_17(1829622461 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c08ab7af63da4f24a4fa3e9c7a732fae).FormatWith(CultureInfo.InvariantCulture, this.class1_0.TokenType));
			}
		}

		// Token: 0x060004B6 RID: 1206 RVA: 0x0003841C File Offset: 0x0003661C
		private void method_13(string string_1, JsonSchemaModel jsonSchemaModel_1)
		{
			string text2;
			for (;;)
			{
				int num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bd75de9a0b64d6da3a43e57303102f1 != 0)
				{
					goto IL_0006;
				}
				IL_0074:
				string text;
				switch (num)
				{
				case 0:
					goto IL_0021;
				case 1:
					goto IL_00AB;
				case 2:
					IL_0006:
					if (!((IJsonLineInfo)this).HasLineInfo())
					{
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8432da17e8384a688cea4636964d3693 == 0)
						{
							goto IL_0021;
						}
						goto IL_0074;
					}
					else
					{
						text = string_1 + Class15.smethod_17(594348272 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5f127c3ec2e04c11ab1bd26a8d965f2b).FormatWith(CultureInfo.InvariantCulture, ((IJsonLineInfo)this).LineNumber, ((IJsonLineInfo)this).LinePosition);
					}
					break;
				case 3:
					continue;
				case 4:
					return;
				default:
					goto IL_0021;
				}
				IL_0061:
				text2 = text;
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ca6ac77a767741aa91cb31f8080f093b != 0)
				{
					goto IL_0074;
				}
				break;
				IL_0021:
				text = string_1;
				goto IL_0061;
			}
			IL_00AB:
			this.method_14(new JsonSchemaException(text2, null, this.Path, ((IJsonLineInfo)this).LineNumber, ((IJsonLineInfo)this).LinePosition));
		}

		// Token: 0x060004B7 RID: 1207 RVA: 0x000384F8 File Offset: 0x000366F8
		private void method_14(JsonSchemaException jsonSchemaException_0)
		{
			for (;;)
			{
				ValidationEventHandler validationEventHandler = this.validationEventHandler_0;
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a321d34f24314561b0d80437d5d859e8 != 0)
				{
					goto IL_0025;
				}
				IL_003A:
				switch (num)
				{
				case 0:
					goto IL_0025;
				case 1:
					continue;
				case 2:
					goto IL_0073;
				case 3:
					break;
				case 4:
					return;
				default:
					goto IL_0025;
				}
				IL_0003:
				validationEventHandler(this, new ValidationEventArgs(jsonSchemaException_0));
				num = 4;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a5994720d09542abb897ebf6ad9b5a19 != 0)
				{
					break;
				}
				goto IL_003A;
				IL_0025:
				if (validationEventHandler != null)
				{
					goto IL_0003;
				}
				num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cb7e1ff8cc1348bebf46c510e64a0134 == 0)
				{
					goto IL_003A;
				}
			}
			return;
			IL_0073:
			throw jsonSchemaException_0;
		}

		// Token: 0x060004B8 RID: 1208 RVA: 0x0003857C File Offset: 0x0003677C
		public JsonValidatingReader(JsonReader reader)
		{
			for (;;)
			{
				ValidationUtils.ArgumentNotNull(reader, Class15.smethod_17(538817101 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_725e5f82c8704b39b66ebddcee8df7fa));
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_db7740c6ca7a4f3c8e1aa526bdb0a454 != 0)
				{
					goto IL_000A;
				}
				IL_0022:
				switch (num)
				{
				case 1:
					IL_000A:
					this.jsonReader_0 = reader;
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3cf8a2073cc248c2915ebb05bcd2a099 == 0)
					{
						goto IL_0022;
					}
					break;
				case 2:
					continue;
				case 3:
					return;
				}
				break;
			}
			this.stack_0 = new Stack<JsonValidatingReader.Class1>();
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x060004B9 RID: 1209 RVA: 0x00003347 File Offset: 0x00001547
		// (set) Token: 0x060004BA RID: 1210 RVA: 0x00038600 File Offset: 0x00036800
		public JsonSchema Schema
		{
			get
			{
				return this.jsonSchema_0;
			}
			set
			{
				while (this.TokenType == JsonToken.None)
				{
					this.jsonSchema_0 = value;
					int num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0005996a6a494de4880ac2956b2e0112 != 0)
					{
						goto IL_001C;
					}
					IL_0034:
					switch (num)
					{
					case 1:
						IL_001C:
						this.jsonSchemaModel_0 = null;
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cbfb1e54efd84756a9b6d7b21adc0d65 != 0)
						{
							goto IL_0034;
						}
						break;
					case 2:
						IL_005A:
						throw new InvalidOperationException(Class15.smethod_17(543243602 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_43b8cdd768c545d884bf7ff1c8fefe89));
					case 3:
						continue;
					}
					return;
				}
				goto IL_005A;
			}
		}

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x060004BB RID: 1211 RVA: 0x0000334F File Offset: 0x0000154F
		public JsonReader Reader
		{
			get
			{
				return this.jsonReader_0;
			}
		}

		// Token: 0x060004BC RID: 1212 RVA: 0x00038684 File Offset: 0x00036884
		public override void Close()
		{
			for (;;)
			{
				IL_0038:
				base.Close();
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3baf10aa2a73406aa2bb349717d797c7 == 0)
				{
					break;
				}
				for (;;)
				{
					switch (num)
					{
					case 1:
						if (!base.CloseInput)
						{
							return;
						}
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8f48544341da433d9f954b548c7e9212 != 0)
						{
							continue;
						}
						break;
					case 2:
						goto IL_0038;
					case 3:
						return;
					case 4:
						return;
					}
					goto Block_2;
				}
			}
			Block_2:
			JsonReader jsonReader = this.jsonReader_0;
			if (jsonReader != null)
			{
				jsonReader.Close();
				return;
			}
		}

		// Token: 0x060004BD RID: 1213 RVA: 0x000386F8 File Offset: 0x000368F8
		private void method_15(JsonSchemaModel jsonSchemaModel_1)
		{
			IL_00C7:
			while (jsonSchemaModel_1 != null)
			{
				for (;;)
				{
					JsonSchemaType? jsonSchemaType = this.method_16();
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d5af2cccac2f47ed978e804138a35d1c != 0)
					{
						goto IL_0077;
					}
					IL_0083:
					switch (num)
					{
					case 0:
						goto IL_0077;
					case 1:
					case 5:
						return;
					case 2:
						continue;
					case 3:
						goto IL_00C7;
					case 4:
						goto IL_0036;
					case 6:
						break;
					case 7:
						return;
					default:
						goto IL_0077;
					}
					IL_0006:
					if (JsonSchemaGenerator.HasFlag(new JsonSchemaType?(jsonSchemaModel_1.Disallow), jsonSchemaType.GetValueOrDefault()))
					{
						goto IL_0036;
					}
					num = 5;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cbfb1e54efd84756a9b6d7b21adc0d65 != 0)
					{
						break;
					}
					goto IL_0083;
					IL_0077:
					if (jsonSchemaType != null)
					{
						goto IL_0006;
					}
					break;
					IL_0036:
					this.method_13(Class15.smethod_17(698986800 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7dfc957a76cb4c58b17dc74a084c4e4a).FormatWith(CultureInfo.InvariantCulture, jsonSchemaType), jsonSchemaModel_1);
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4b8a72ce901241b5b52fe60600cb3607 == 0)
					{
						break;
					}
					goto IL_0083;
				}
				return;
			}
		}

		// Token: 0x060004BE RID: 1214 RVA: 0x000387D8 File Offset: 0x000369D8
		private JsonSchemaType? method_16()
		{
			switch (this.jsonReader_0.TokenType)
			{
			case JsonToken.StartObject:
				return new JsonSchemaType?(JsonSchemaType.Object);
			case JsonToken.StartArray:
				return new JsonSchemaType?(JsonSchemaType.Array);
			case JsonToken.Integer:
				return new JsonSchemaType?(JsonSchemaType.Integer);
			case JsonToken.Float:
				return new JsonSchemaType?(JsonSchemaType.Float);
			case JsonToken.String:
				return new JsonSchemaType?(JsonSchemaType.String);
			case JsonToken.Boolean:
				return new JsonSchemaType?(JsonSchemaType.Boolean);
			case JsonToken.Null:
				return new JsonSchemaType?(JsonSchemaType.Null);
			}
			return null;
		}

		// Token: 0x060004BF RID: 1215 RVA: 0x00003357 File Offset: 0x00001557
		public override int? vmethod_0()
		{
			int? num = this.jsonReader_0.vmethod_0();
			this.method_17();
			return num;
		}

		// Token: 0x060004C0 RID: 1216 RVA: 0x0000336A File Offset: 0x0000156A
		public override byte[] ReadAsBytes()
		{
			byte[] array = this.jsonReader_0.ReadAsBytes();
			this.method_17();
			return array;
		}

		// Token: 0x060004C1 RID: 1217 RVA: 0x0000337D File Offset: 0x0000157D
		public override decimal? ReadAsDecimal()
		{
			decimal? num = this.jsonReader_0.ReadAsDecimal();
			this.method_17();
			return num;
		}

		// Token: 0x060004C2 RID: 1218 RVA: 0x00003390 File Offset: 0x00001590
		public override double? ReadAsDouble()
		{
			double? num = this.jsonReader_0.ReadAsDouble();
			this.method_17();
			return num;
		}

		// Token: 0x060004C3 RID: 1219 RVA: 0x000033A3 File Offset: 0x000015A3
		public override bool? ReadAsBoolean()
		{
			bool? flag = this.jsonReader_0.ReadAsBoolean();
			this.method_17();
			return flag;
		}

		// Token: 0x060004C4 RID: 1220 RVA: 0x000033B6 File Offset: 0x000015B6
		public override string ReadAsString()
		{
			string text = this.jsonReader_0.ReadAsString();
			this.method_17();
			return text;
		}

		// Token: 0x060004C5 RID: 1221 RVA: 0x000033C9 File Offset: 0x000015C9
		public override DateTime? ReadAsDateTime()
		{
			DateTime? dateTime = this.jsonReader_0.ReadAsDateTime();
			this.method_17();
			return dateTime;
		}

		// Token: 0x060004C6 RID: 1222 RVA: 0x000033DC File Offset: 0x000015DC
		public override DateTimeOffset? ReadAsDateTimeOffset()
		{
			DateTimeOffset? dateTimeOffset = this.jsonReader_0.ReadAsDateTimeOffset();
			this.method_17();
			return dateTimeOffset;
		}

		// Token: 0x060004C7 RID: 1223 RVA: 0x00038868 File Offset: 0x00036A68
		public override bool Read()
		{
			IL_005B:
			while (this.jsonReader_0.Read())
			{
				for (;;)
				{
					int num;
					if (this.jsonReader_0.TokenType == JsonToken.Comment)
					{
						num = 1;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0005996a6a494de4880ac2956b2e0112 == 0)
						{
							return true;
						}
					}
					else
					{
						this.method_17();
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_43b8cdd768c545d884bf7ff1c8fefe89 == 0)
						{
							break;
						}
					}
					switch (num)
					{
					case 1:
						return true;
					case 2:
						return false;
					case 3:
						continue;
					case 4:
						goto IL_005B;
					}
					break;
				}
				return true;
			}
			return false;
		}

		// Token: 0x060004C8 RID: 1224 RVA: 0x000388E8 File Offset: 0x00036AE8
		private void method_17()
		{
			IEnumerator<JsonSchemaModel> enumerator;
			IList<JsonSchemaModel> list2;
			for (;;)
			{
				IL_0474:
				if (this.jsonSchemaModel_0 == null)
				{
					goto IL_0454;
				}
				int num = 21;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa49bb51056944098afe92e3a80a544b == 0)
				{
					goto Block_14;
				}
				for (;;)
				{
					IL_033C:
					IList<JsonSchemaModel> list;
					switch (num)
					{
					case 0:
						goto IL_0249;
					case 1:
						goto IL_048F;
					case 2:
						goto IL_08A3;
					case 3:
						goto IL_04BD;
					case 4:
						goto IL_0873;
					case 5:
						goto IL_0454;
					case 6:
						goto IL_04B0;
					case 7:
						return;
					case 8:
						goto IL_013D;
					case 9:
						goto IL_05AC;
					case 10:
						goto IL_0427;
					case 11:
						goto IL_049D;
					case 12:
						goto IL_0163;
					case 13:
						return;
					case 14:
						break;
					case 15:
						goto IL_0105;
					case 16:
						goto IL_08B0;
					case 17:
					case 21:
						goto IL_00DB;
					case 18:
						goto IL_0885;
					case 19:
						goto IL_0953;
					case 20:
						goto IL_07CB;
					case 22:
						goto IL_0474;
					case 23:
						goto IL_0710;
					case 24:
						return;
					case 25:
						goto IL_05A0;
					case 26:
						try
						{
							for (;;)
							{
								if (enumerator.MoveNext())
								{
									goto IL_02C2;
								}
								int num2 = 1;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_871a407507f34aa3b5bf52517d4f63a9 != 0)
								{
									break;
								}
								IL_02AD:
								JsonSchemaModel jsonSchemaModel;
								switch (num2)
								{
								default:
									IL_02C2:
									jsonSchemaModel = enumerator.Current;
									break;
								case 1:
									continue;
								case 2:
									goto IL_02F1;
								case 3:
									break;
								}
								this.method_20(jsonSchemaModel);
								num2 = 0;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_193800745ad94a529d9e5edc977c4f02 != 0)
								{
									goto IL_02AD;
								}
							}
							IL_02F1:
							goto IL_026F;
						}
						finally
						{
							if (enumerator != null)
							{
								goto IL_0322;
							}
							int num3 = 1;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e368897ba1744663a6d0bc59b9b65b5f == 0)
							{
								continue;
							}
							IL_030E:
							switch (num3)
							{
							case 2:
								IL_0322:
								enumerator.Dispose();
								num3 = 0;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_55c1fea936c04e47abbfb2b5f778aff7 != 0)
								{
									goto IL_030E;
								}
								break;
							}
						}
						continue;
					case 27:
						return;
					case 28:
						goto IL_016F;
					case 29:
						goto IL_07D8;
					case 30:
						return;
					case 31:
						goto IL_0482;
					case 32:
						goto IL_006B;
					case 33:
						goto IL_05B9;
					case 34:
						goto IL_0945;
					case 35:
						goto IL_00EA;
					case 36:
						goto IL_0879;
					case 37:
						goto IL_06F7;
					case 38:
						return;
					case 39:
						return;
					case 40:
						goto IL_04D6;
					case 41:
						goto IL_0897;
					case 42:
						goto IL_026F;
					case 43:
						goto IL_0592;
					case 44:
						goto IL_06F1;
					case 45:
						goto IL_04E3;
					case 46:
						return;
					case 47:
						goto IL_0703;
					case 48:
						goto IL_0649;
					case 49:
						goto IL_0057;
					case 50:
						goto IL_07B9;
					case 51:
						goto IL_07BF;
					case 52:
						goto IL_015D;
					case 53:
						list = this.method_12().Where(new Func<JsonSchemaModel, bool>(this.method_29)).ToList<JsonSchemaModel>();
						num = 14;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c27e9fccdfcc44999155a4980faa4e81 != 0)
						{
							continue;
						}
						break;
					case 54:
						goto IL_002D;
					case 55:
						goto IL_0006;
					default:
						goto IL_0249;
					}
					this.method_9(new JsonValidatingReader.Class1(JTokenType.Array, list));
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_55c1fea936c04e47abbfb2b5f778aff7 == 0)
					{
						continue;
					}
					IL_0249:
					this.method_18(this.method_11());
					num = 7;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d6c400f349964629bcd869033695bff0 == 0)
					{
						goto Block_9;
					}
					continue;
					IL_026F:
					this.method_10();
					num = 2;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9bd9937edf9d4ad8bd673dfcb5a5e3cb == 0)
					{
						goto Block_10;
					}
				}
				IL_0006:
				enumerator = this.method_11().GetEnumerator();
				num = 26;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cf58136e49114a5691c4a9d0e9788de1 != 0)
				{
					break;
				}
				goto IL_033C;
				IL_006B:
				JsonToken tokenType;
				switch (tokenType)
				{
				case JsonToken.None:
					return;
				case JsonToken.StartObject:
					IL_00EA:
					this.method_25();
					num = 12;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3bf07bb1c323490cb457eef2b2e78695 == 0)
					{
						goto IL_0105;
					}
					goto IL_033C;
				case JsonToken.StartArray:
					this.method_25();
					num = 53;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_550a8fe2e5fe4cc19bdfe1a82a7f12b8 != 0)
					{
						goto IL_00DB;
					}
					goto IL_033C;
				case JsonToken.StartConstructor:
					goto IL_04AA;
				case JsonToken.PropertyName:
					goto IL_04CA;
				case JsonToken.Raw:
					IL_013D:
					this.method_25();
					num = 4;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d5af2cccac2f47ed978e804138a35d1c != 0)
					{
						goto Block_5;
					}
					goto IL_033C;
				case JsonToken.Integer:
					goto IL_059A;
				case JsonToken.Float:
					IL_015D:
					this.method_25();
					goto IL_0163;
				case JsonToken.String:
					goto IL_06F1;
				case JsonToken.Boolean:
					goto IL_07B9;
				case JsonToken.Null:
					goto IL_0873;
				case JsonToken.Undefined:
				case JsonToken.Date:
				case JsonToken.Bytes:
					this.method_18(this.method_12());
					num = 5;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_55c1fea936c04e47abbfb2b5f778aff7 == 0)
					{
						goto Block_8;
					}
					goto IL_033C;
				case JsonToken.EndObject:
					goto IL_0897;
				case JsonToken.EndArray:
					this.method_18(this.method_11());
					goto IL_0006;
				case JsonToken.EndConstructor:
					this.method_18(this.method_11());
					num = 31;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ae8c3d3c66a64b57beca0f5360302062 != 0)
					{
						goto Block_7;
					}
					goto IL_033C;
				}
				goto Block_3;
				IL_00DB:
				tokenType = this.jsonReader_0.TokenType;
				goto IL_006B;
				IL_002D:
				if (JsonTokenUtils.IsStartToken(this.jsonReader_0.TokenType))
				{
					goto IL_00DB;
				}
				num = 4;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5f127c3ec2e04c11ab1bd26a8d965f2b != 0)
				{
					goto IL_0057;
				}
				goto IL_033C;
				IL_0105:
				list2 = this.method_12().Where(new Func<JsonSchemaModel, bool>(this.method_30)).ToList<JsonSchemaModel>();
				num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d9581c727fcc4f50accd4f5de0d386f5 != 0)
				{
					goto Block_4;
				}
				goto IL_033C;
				IL_016F:
				enumerator = this.method_12().GetEnumerator();
				num = 26;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3a102d6e4dd542a6855b81a93c692545 == 0)
				{
					goto Block_6;
				}
				goto IL_033C;
				IL_0163:
				this.method_18(this.method_12());
				goto IL_016F;
				IL_0427:
				JsonSchemaModelBuilder jsonSchemaModelBuilder;
				this.jsonSchemaModel_0 = jsonSchemaModelBuilder.Build(this.jsonSchema_0);
				num = 5;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_193800745ad94a529d9e5edc977c4f02 == 0)
				{
					goto IL_002D;
				}
				goto IL_033C;
				IL_0454:
				jsonSchemaModelBuilder = new JsonSchemaModelBuilder();
				goto IL_0427;
				IL_0057:
				this.method_9(new JsonValidatingReader.Class1(JTokenType.None, this.method_12()));
				goto IL_00DB;
			}
			goto IL_0953;
			Block_3:
			goto IL_0592;
			Block_4:
			goto IL_048F;
			Block_5:
			return;
			Block_6:
			goto IL_0648;
			Block_7:
			goto IL_0953;
			Block_8:
			return;
			Block_9:
			return;
			Block_10:
			return;
			Block_14:
			return;
			IL_0482:
			this.method_10();
			return;
			IL_048F:
			this.method_9(new JsonValidatingReader.Class1(JTokenType.Object, list2));
			IL_049D:
			this.method_18(this.method_11());
			return;
			IL_04AA:
			this.method_25();
			IL_04B0:
			this.method_9(new JsonValidatingReader.Class1(JTokenType.Constructor, null));
			IL_04BD:
			this.method_18(this.method_11());
			return;
			IL_04CA:
			this.method_18(this.method_11());
			IL_04D6:
			enumerator = this.method_11().GetEnumerator();
			IL_04E3:
			try
			{
				for (;;)
				{
					if (enumerator.MoveNext())
					{
						goto IL_04E7;
					}
					int num4 = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_67a271e0ae064fc7a3a74905868add95 == 0)
					{
						break;
					}
					IL_0501:
					switch (num4)
					{
					case 1:
					{
						JsonSchemaModel jsonSchemaModel2;
						this.method_27(jsonSchemaModel2);
						continue;
					}
					case 2:
						continue;
					case 3:
					{
						IL_04E7:
						JsonSchemaModel jsonSchemaModel2 = enumerator.Current;
						num4 = 1;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0361b8eb39074ea88f5257b13904930a != 0)
						{
							goto IL_0501;
						}
						break;
					}
					}
					break;
				}
				return;
			}
			finally
			{
				if (enumerator != null)
				{
					goto IL_0578;
				}
				int num5 = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c27e9fccdfcc44999155a4980faa4e81 == 0)
				{
					goto IL_0591;
				}
				IL_0564:
				switch (num5)
				{
				case 2:
					IL_0578:
					enumerator.Dispose();
					num5 = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_6f87b5b72b9847f7b8ec5b44b0dccfa8 != 0)
					{
						goto IL_0564;
					}
					break;
				}
				IL_0591:;
			}
			IL_0592:
			throw new ArgumentOutOfRangeException();
			IL_059A:
			this.method_25();
			IL_05A0:
			this.method_18(this.method_12());
			IL_05AC:
			enumerator = this.method_12().GetEnumerator();
			IL_05B9:
			try
			{
				IL_05FA:
				while (enumerator.MoveNext())
				{
					for (;;)
					{
						JsonSchemaModel jsonSchemaModel3 = enumerator.Current;
						for (;;)
						{
							this.method_24(jsonSchemaModel3);
							int num6 = 1;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ca6ac77a767741aa91cb31f8080f093b == 0)
							{
								switch (num6)
								{
								case 1:
									goto IL_05FA;
								case 2:
									goto IL_0603;
								case 3:
									continue;
								}
								break;
							}
							break;
						}
					}
				}
				IL_0603:
				return;
			}
			finally
			{
				if (enumerator != null)
				{
					int num7 = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d9581c727fcc4f50accd4f5de0d386f5 != 0)
					{
						goto IL_0636;
					}
					IL_061E:
					enumerator.Dispose();
					num7 = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e764f065c2fa404a85129e2e957d4f18 == 0)
					{
						goto IL_0647;
					}
					IL_0636:
					switch (num7)
					{
					case 1:
						goto IL_061E;
					}
				}
				IL_0647:;
			}
			IL_0648:
			IL_0649:
			try
			{
				for (;;)
				{
					if (enumerator.MoveNext())
					{
						goto IL_067F;
					}
					int num8 = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa29cbda752f45acbe81e7d5285df2ba == 0)
					{
						goto IL_067F;
					}
					IL_0666:
					switch (num8)
					{
					case 0:
						goto IL_067F;
					case 1:
						goto IL_06AA;
					case 2:
						continue;
					case 3:
						break;
					default:
						goto IL_067F;
					}
					IL_064D:
					JsonSchemaModel jsonSchemaModel4;
					this.method_26(jsonSchemaModel4);
					num8 = 2;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c27e9fccdfcc44999155a4980faa4e81 != 0)
					{
						goto IL_0666;
					}
					IL_067F:
					jsonSchemaModel4 = enumerator.Current;
					goto IL_064D;
				}
				IL_06AA:
				return;
			}
			finally
			{
				if (enumerator != null)
				{
					int num9 = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3dc45d1ecdeb4859b7f470093f5eeed2 == 0)
					{
						goto IL_06E0;
					}
					do
					{
						IL_06C5:
						enumerator.Dispose();
						num9 = 1;
					}
					while (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a321d34f24314561b0d80437d5d859e8 == 0);
					IL_06E0:
					switch (num9)
					{
					case 0:
						goto IL_06C5;
					case 1:
						break;
					default:
						goto IL_06C5;
					}
				}
			}
			IL_06F1:
			this.method_25();
			IL_06F7:
			this.method_18(this.method_12());
			IL_0703:
			enumerator = this.method_12().GetEnumerator();
			IL_0710:
			try
			{
				for (;;)
				{
					if (enumerator.MoveNext())
					{
						goto IL_0745;
					}
					int num10 = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5dadf4f8cc824060ae20e1ee9bbca82a == 0)
					{
						break;
					}
					IL_072D:
					JsonSchemaModel jsonSchemaModel5;
					switch (num10)
					{
					case 1:
						continue;
					case 2:
						IL_0745:
						jsonSchemaModel5 = enumerator.Current;
						goto IL_0714;
					case 3:
						goto IL_0714;
					}
					break;
					IL_0714:
					this.method_23(jsonSchemaModel5);
					num10 = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e6fac70dd3e841b6925374855ecd7fb1 == 0)
					{
						goto IL_072D;
					}
					break;
				}
				return;
			}
			finally
			{
				if (enumerator != null)
				{
					int num11 = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3cf8a2073cc248c2915ebb05bcd2a099 != 0)
					{
						goto IL_07A7;
					}
					IL_078F:
					enumerator.Dispose();
					num11 = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cf58136e49114a5691c4a9d0e9788de1 == 0)
					{
						goto IL_07B8;
					}
					IL_07A7:
					switch (num11)
					{
					case 0:
						goto IL_078F;
					case 1:
						break;
					default:
						goto IL_078F;
					}
				}
				IL_07B8:;
			}
			IL_07B9:
			this.method_25();
			IL_07BF:
			this.method_18(this.method_12());
			IL_07CB:
			enumerator = this.method_12().GetEnumerator();
			IL_07D8:
			try
			{
				for (;;)
				{
					if (enumerator.MoveNext())
					{
						goto IL_080D;
					}
					int num12 = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a41eabd4b99f489fb7d86310d3f95ba2 == 0)
					{
						break;
					}
					IL_07F5:
					JsonSchemaModel jsonSchemaModel6;
					switch (num12)
					{
					case 1:
						continue;
					case 2:
						IL_080D:
						jsonSchemaModel6 = enumerator.Current;
						goto IL_07DC;
					case 3:
						goto IL_07DC;
					}
					break;
					IL_07DC:
					this.method_22(jsonSchemaModel6);
					num12 = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93c7140125045538ae5c40c6f39a5af != 0)
					{
						goto IL_07F5;
					}
				}
				return;
			}
			finally
			{
				if (enumerator != null)
				{
					for (;;)
					{
						enumerator.Dispose();
						int num13 = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0361b8eb39074ea88f5257b13904930a == 0)
						{
							switch (num13)
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
			IL_0873:
			this.method_25();
			IL_0879:
			this.method_18(this.method_12());
			IL_0885:
			enumerator = this.method_12().GetEnumerator();
			goto IL_0953;
			IL_0897:
			this.method_18(this.method_11());
			IL_08A3:
			enumerator = this.method_11().GetEnumerator();
			IL_08B0:
			try
			{
				for (;;)
				{
					if (enumerator.MoveNext())
					{
						goto IL_08B4;
					}
					int num14 = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3bf07bb1c323490cb457eef2b2e78695 == 0)
					{
						break;
					}
					IL_08CE:
					JsonSchemaModel jsonSchemaModel7;
					switch (num14)
					{
					case 1:
						goto IL_0912;
					case 2:
						IL_08B4:
						jsonSchemaModel7 = enumerator.Current;
						num14 = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_43b32b9d66294210a955990bb6fcc511 == 0)
						{
							goto IL_08CE;
						}
						break;
					case 3:
						continue;
					}
					this.method_19(jsonSchemaModel7);
				}
				IL_0912:;
			}
			finally
			{
				if (enumerator == null)
				{
					int num15 = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_eaded84ad5b14e1ea8d4d97bfed1bb48 != 0)
					{
						goto IL_0944;
					}
					switch (num15)
					{
					case 1:
					case 2:
						goto IL_0944;
					}
				}
				enumerator.Dispose();
				IL_0944:;
			}
			IL_0945:
			this.method_10();
			return;
			IL_0953:
			try
			{
				for (;;)
				{
					if (enumerator.MoveNext())
					{
						goto IL_0957;
					}
					int num16 = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_11c6824de6514281a8425f6d6ab1a2d5 == 0)
					{
						break;
					}
					IL_0971:
					switch (num16)
					{
					case 1:
						goto IL_098A;
					case 2:
						continue;
					case 3:
						goto IL_09B5;
					}
					IL_0957:
					JsonSchemaModel jsonSchemaModel8 = enumerator.Current;
					num16 = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d97e64d0f425406b9649f2b4562a5f0e == 0)
					{
						goto IL_0971;
					}
					IL_098A:
					this.method_21(jsonSchemaModel8);
				}
				IL_09B5:;
			}
			finally
			{
				if (enumerator == null)
				{
					int num17 = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_253407eb812c4aefb734fa1e267fe779 == 0)
					{
						goto IL_09E7;
					}
					switch (num17)
					{
					case 1:
					case 2:
						goto IL_09E7;
					}
				}
				enumerator.Dispose();
				IL_09E7:;
			}
		}

		// Token: 0x060004C9 RID: 1225 RVA: 0x00039344 File Offset: 0x00037544
		private void method_18(IList<JsonSchemaModel> ilist_1)
		{
			foreach (JsonValidatingReader.Class1 @class in this.stack_0)
			{
				bool flag;
				if (!(flag = @class.TokenType == JTokenType.Array && @class.method_4() && @class.method_2() > 0))
				{
					if (!ilist_1.Any(new Func<JsonSchemaModel, bool>(JsonValidatingReader.<>c.<>c_0.method_0)))
					{
						continue;
					}
				}
				if (@class.RgfuhiGaAJ() == null)
				{
					if (JsonTokenUtils.IsEndToken(this.jsonReader_0.TokenType))
					{
						continue;
					}
					@class.method_6(new JTokenWriter());
				}
				@class.RgfuhiGaAJ().WriteToken(this.jsonReader_0, false);
				if (@class.RgfuhiGaAJ().Top == 0 && this.jsonReader_0.TokenType != JsonToken.PropertyName)
				{
					JToken token = @class.RgfuhiGaAJ().Token;
					@class.method_6(null);
					if (flag)
					{
						if (@class.method_5().Contains(token, JToken.EqualityComparer))
						{
							this.method_13(Class15.smethod_17(41429099 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_079bd9b874b24353bef46f6c3f5d741d).FormatWith(CultureInfo.InvariantCulture, @class.method_2() - 1), @class.method_7().First(new Func<JsonSchemaModel, bool>(JsonValidatingReader.<>c.<>c_0.qFjuUprtoH)));
						}
						@class.method_5().Add(token);
					}
					else if (ilist_1.Any(new Func<JsonSchemaModel, bool>(JsonValidatingReader.<>c.<>c_0.method_1)))
					{
						foreach (JsonSchemaModel jsonSchemaModel in ilist_1)
						{
							if (jsonSchemaModel.Enum != null && !jsonSchemaModel.Enum.ContainsValue(token, JToken.EqualityComparer))
							{
								StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture);
								token.WriteTo(new JsonTextWriter(stringWriter), new JsonConverter[0]);
								this.method_13(Class15.smethod_17(698986676 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7dfc957a76cb4c58b17dc74a084c4e4a).FormatWith(CultureInfo.InvariantCulture, stringWriter.ToString()), jsonSchemaModel);
							}
						}
					}
				}
			}
		}

		// Token: 0x060004CA RID: 1226 RVA: 0x000395BC File Offset: 0x000377BC
		private void method_19(JsonSchemaModel jsonSchemaModel_1)
		{
			IL_0147:
			while (jsonSchemaModel_1 != null)
			{
				for (;;)
				{
					IL_0138:
					Dictionary<string, bool> dictionary = this.class1_0.method_8();
					IL_012E:
					while (dictionary != null)
					{
						for (;;)
						{
							if (dictionary.Values.Any(new Func<bool, bool>(JsonValidatingReader.<>c.<>c_0.method_2)))
							{
								goto IL_004D;
							}
							int num = 3;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c28a4ed7a58e45aaa9902e336fd60b97 == 0)
							{
								goto Block_3;
							}
							IL_00FE:
							IEnumerable<string> enumerable;
							switch (num)
							{
							case 1:
								IL_004D:
								enumerable = dictionary.Where(new Func<KeyValuePair<string, bool>, bool>(JsonValidatingReader.<>c.<>c_0.method_3)).Select(new Func<KeyValuePair<string, bool>, string>(JsonValidatingReader.<>c.<>c_0.method_4));
								num = 6;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_75738dd4edc84122bfe3748a1ea03d43 == 0)
								{
									goto IL_00AB;
								}
								goto IL_00FE;
							case 2:
								continue;
							case 3:
							case 4:
							case 6:
								return;
							case 5:
								goto IL_012E;
							case 7:
								goto IL_0138;
							case 8:
								goto IL_0147;
							case 9:
								goto IL_00AB;
							}
							goto Block_6;
							IL_00AB:
							this.method_13(Class15.smethod_17(299937507 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d97e64d0f425406b9649f2b4562a5f0e).FormatWith(CultureInfo.InvariantCulture, string.Join(Class15.smethod_17(486513282 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39d5fbfa4fe34ed9908db538e5340a6c), enumerable)), jsonSchemaModel_1);
							num = 3;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_52d717cd31b74287b67c03ee736a6211 != 0)
							{
								goto IL_00FE;
							}
							return;
						}
					}
					break;
				}
				Block_3:
				return;
				Block_6:
				break;
			}
		}

		// Token: 0x060004CB RID: 1227 RVA: 0x0003971C File Offset: 0x0003791C
		private void method_20(JsonSchemaModel jsonSchemaModel_1)
		{
			IL_01AE:
			while (jsonSchemaModel_1 != null)
			{
				int num = 9;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ee35a23edd8f4998990ec1a2b40fc61a != 0)
				{
					goto IL_00FA;
				}
				int? num2;
				int num4;
				for (;;)
				{
					IL_0167:
					switch (num)
					{
					case 1:
						goto IL_012A;
					case 2:
					case 4:
					case 7:
						return;
					case 3:
						goto IL_007A;
					case 5:
						return;
					case 6:
						if (num2 == null)
						{
							goto Block_7;
						}
						goto IL_00AC;
					case 8:
					case 13:
						goto IL_0072;
					case 9:
						goto IL_0086;
					case 10:
						goto IL_00FA;
					case 11:
						goto IL_01AE;
					case 12:
						goto IL_00AC;
					case 14:
						goto IL_0020;
					}
					goto Block_8;
					IL_00AC:
					int num3 = num4;
					num2 = jsonSchemaModel_1.MaximumItems;
					if (!((num3 > num2.GetValueOrDefault()) & (num2 != null)))
					{
						break;
					}
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e6fac70dd3e841b6925374855ecd7fb1 != 0)
					{
						goto IL_00DE;
					}
				}
				IL_0072:
				num2 = jsonSchemaModel_1.MinimumItems;
				goto IL_007A;
				Block_8:
				goto IL_00DE;
				Block_7:
				goto IL_0072;
				IL_012A:
				this.method_13(Class15.smethod_17(676712854 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa49bb51056944098afe92e3a80a544b).FormatWith(CultureInfo.InvariantCulture, num4, jsonSchemaModel_1.MaximumItems), jsonSchemaModel_1);
				goto IL_0072;
				IL_0020:
				this.method_13(Class15.smethod_17(1116150523 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_100d09ce3850492c8356d7fa1e667d54).FormatWith(CultureInfo.InvariantCulture, num4, jsonSchemaModel_1.MinimumItems), jsonSchemaModel_1);
				num = 5;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_6f87b5b72b9847f7b8ec5b44b0dccfa8 == 0)
				{
					return;
				}
				goto IL_0167;
				IL_0086:
				int num5 = num4;
				num2 = jsonSchemaModel_1.MinimumItems;
				if (!((num5 < num2.GetValueOrDefault()) & (num2 != null)))
				{
					return;
				}
				goto IL_0020;
				IL_007A:
				if (num2 != null)
				{
					goto IL_0086;
				}
				return;
				IL_00DE:
				num2 = jsonSchemaModel_1.MaximumItems;
				num = 6;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_186d640068094cc595a341ef95c9a29a != 0)
				{
					goto IL_007A;
				}
				goto IL_0167;
				IL_00FA:
				num4 = this.class1_0.method_2();
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5e301544981d4903aa4e531970a47849 == 0)
				{
					goto IL_00DE;
				}
				goto IL_0167;
			}
		}

		// Token: 0x060004CC RID: 1228 RVA: 0x000398E4 File Offset: 0x00037AE4
		private void method_21(JsonSchemaModel jsonSchemaModel_1)
		{
			IL_0042:
			while (jsonSchemaModel_1 != null)
			{
				while (this.method_31(jsonSchemaModel_1, JsonSchemaType.Null))
				{
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_207f975845fc40cdbe6b166fce664cd5 != 0)
					{
						switch (num)
						{
						case 1:
							return;
						case 2:
							return;
						case 3:
							return;
						case 4:
							continue;
						case 5:
							goto IL_0042;
						}
					}
					this.method_15(jsonSchemaModel_1);
					return;
				}
				return;
			}
		}

		// Token: 0x060004CD RID: 1229 RVA: 0x00039944 File Offset: 0x00037B44
		private void method_22(JsonSchemaModel jsonSchemaModel_1)
		{
			IL_0058:
			while (jsonSchemaModel_1 != null)
			{
				for (;;)
				{
					int num;
					if (!this.method_31(jsonSchemaModel_1, JsonSchemaType.Boolean))
					{
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7af5c533f30e4bd1bda86ce6098441d2 != 0)
						{
							break;
						}
					}
					else
					{
						this.method_15(jsonSchemaModel_1);
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bd75de9a0b64d6da3a43e57303102f1 != 0)
						{
							return;
						}
					}
					switch (num)
					{
					case 1:
						return;
					case 2:
						continue;
					case 3:
						goto IL_0058;
					case 4:
						return;
					}
					break;
				}
				return;
			}
		}

		// Token: 0x060004CE RID: 1230 RVA: 0x000399B4 File Offset: 0x00037BB4
		private void method_23(JsonSchemaModel jsonSchemaModel_1)
		{
			IL_01F9:
			while (jsonSchemaModel_1 != null)
			{
				if (this.method_31(jsonSchemaModel_1, JsonSchemaType.String))
				{
					this.method_15(jsonSchemaModel_1);
					for (;;)
					{
						IL_01E5:
						string text = this.jsonReader_0.Value.ToString();
						for (;;)
						{
							IL_01DB:
							int? num = jsonSchemaModel_1.MaximumLength;
							for (;;)
							{
								IL_01CF:
								if (num != null)
								{
									goto IL_018D;
								}
								int num2 = 0;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c27e9fccdfcc44999155a4980faa4e81 != 0)
								{
									goto IL_0107;
								}
								for (;;)
								{
									IL_0129:
									switch (num2)
									{
									case 1:
										goto IL_020B;
									case 2:
										goto IL_01E5;
									case 3:
										return;
									case 4:
										goto IL_01F9;
									case 5:
										goto IL_00AC;
									case 6:
										return;
									case 7:
										goto IL_00CE;
									case 9:
										goto IL_00A3;
									case 10:
										goto IL_018D;
									case 11:
										return;
									case 12:
										goto IL_01DB;
									case 13:
										goto IL_001F;
									case 14:
										goto IL_007E;
									case 15:
										goto IL_01CF;
									case 17:
									{
										IEnumerator<string> enumerator = jsonSchemaModel_1.Patterns.GetEnumerator();
										num2 = 1;
										if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_1db17fe7bd2442b599c52df89f39e610 != 0)
										{
											continue;
										}
										break;
									}
									}
									goto Block_6;
								}
								IL_00AC:
								int length = text.Length;
								num = jsonSchemaModel_1.MinimumLength;
								if ((length < num.GetValueOrDefault()) & (num != null))
								{
									goto IL_00CE;
								}
								goto IL_007E;
								IL_00A3:
								if (num != null)
								{
									goto IL_00AC;
								}
								goto IL_007E;
								Block_6:
								goto IL_0107;
								IL_007E:
								if (jsonSchemaModel_1.Patterns == null)
								{
									return;
								}
								num2 = 17;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_186d640068094cc595a341ef95c9a29a != 0)
								{
									goto IL_001F;
								}
								goto IL_0129;
								IL_0107:
								num = jsonSchemaModel_1.MinimumLength;
								num2 = 9;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a41eabd4b99f489fb7d86310d3f95ba2 == 0)
								{
									goto IL_00CE;
								}
								goto IL_0129;
								IL_001F:
								this.method_13(Class15.smethod_17(698987306 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7dfc957a76cb4c58b17dc74a084c4e4a).FormatWith(CultureInfo.InvariantCulture, text, jsonSchemaModel_1.MaximumLength), jsonSchemaModel_1);
								goto IL_0107;
								IL_018D:
								int length2 = text.Length;
								num = jsonSchemaModel_1.MaximumLength;
								if ((length2 > num.GetValueOrDefault()) & (num != null))
								{
									goto IL_001F;
								}
								num2 = 16;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_67a271e0ae064fc7a3a74905868add95 == 0)
								{
									goto Block_7;
								}
								goto IL_0129;
								IL_00CE:
								this.method_13(Class15.smethod_17(1116150703 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_100d09ce3850492c8356d7fa1e667d54).FormatWith(CultureInfo.InvariantCulture, text, jsonSchemaModel_1.MinimumLength), jsonSchemaModel_1);
								goto IL_007E;
							}
						}
					}
					Block_7:
					return;
					IL_020B:
					try
					{
						IEnumerator<string> enumerator;
						while (enumerator.MoveNext())
						{
							for (;;)
							{
								IL_0274:
								string text2 = enumerator.Current;
								IL_0266:
								string text;
								while (!Regex.IsMatch(text, text2))
								{
									for (;;)
									{
										this.method_13(Class15.smethod_17(1570966739 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3a299c01dd4f4a209bdbd1b98e3f1406).FormatWith(CultureInfo.InvariantCulture, text, text2), jsonSchemaModel_1);
										int num3 = 0;
										if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ee35a23edd8f4998990ec1a2b40fc61a == 0)
										{
											switch (num3)
											{
											case 1:
												goto IL_0274;
											case 2:
												goto IL_0266;
											case 3:
												goto IL_0289;
											case 4:
												continue;
											}
											goto Block_15;
										}
										goto IL_027F;
									}
								}
								break;
							}
							Block_15:
							IL_027F:;
						}
						IL_0289:
						return;
					}
					finally
					{
						IEnumerator<string> enumerator;
						if (enumerator != null)
						{
							goto IL_02B7;
						}
						int num4 = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3a299c01dd4f4a209bdbd1b98e3f1406 != 0)
						{
							break;
						}
						IL_02A3:
						switch (num4)
						{
						case 2:
							IL_02B7:
							enumerator.Dispose();
							num4 = 0;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5be00c24d71649dcae8af3eed7b74ac9 != 0)
							{
								goto IL_02A3;
							}
							break;
						}
					}
					return;
				}
				return;
			}
		}

		// Token: 0x060004CF RID: 1231 RVA: 0x00039CA4 File Offset: 0x00037EA4
		private void method_24(JsonSchemaModel jsonSchemaModel_1)
		{
			for (;;)
			{
				IL_0484:
				int num;
				if (jsonSchemaModel_1 == null)
				{
					num = 25;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7dfc957a76cb4c58b17dc74a084c4e4a == 0)
					{
						goto IL_0432;
					}
				}
				else
				{
					if (this.method_31(jsonSchemaModel_1, JsonSchemaType.Integer))
					{
						goto IL_0464;
					}
					return;
				}
				double? num2;
				object value2;
				for (;;)
				{
					IL_02F9:
					double num3;
					switch (num)
					{
					case 1:
						goto IL_0432;
					case 2:
					case 7:
					case 13:
						goto IL_00E7;
					case 3:
						goto IL_0192;
					case 4:
						goto IL_0409;
					case 5:
					case 34:
						goto IL_00AC;
					case 6:
						goto IL_0186;
					case 8:
						goto IL_0019;
					case 9:
					case 30:
						return;
					case 10:
						goto IL_0455;
					case 11:
						goto IL_0464;
					case 12:
						goto IL_03FB;
					case 14:
					{
						double value = num2.Value;
						num2 = jsonSchemaModel_1.DivisibleBy;
						num3 = Math.Abs(value - Math.Truncate(num2.Value));
						goto IL_0037;
					}
					case 15:
						goto IL_00D5;
					case 16:
						if (JValue.Compare(JTokenType.Integer, value2, jsonSchemaModel_1.Maximum) != 0)
						{
							goto IL_0432;
						}
						num = 22;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4152404f503b492c83d9bc2e44bdd0a7 != 0)
						{
							goto IL_01B5;
						}
						continue;
					case 17:
					case 27:
					case 32:
						goto IL_03D3;
					case 18:
						num2 = jsonSchemaModel_1.DivisibleBy;
						num = 14;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_bc7a9075386042ad9ce36653fcde3fc3 != 0)
						{
							goto Block_10;
						}
						continue;
					case 19:
						goto IL_024B;
					case 20:
						goto IL_0064;
					case 21:
						goto IL_043C;
					case 22:
					case 28:
						goto IL_0202;
					case 23:
						goto IL_03A0;
					case 24:
						goto IL_0232;
					case 25:
						return;
					case 26:
						goto IL_0484;
					case 29:
						goto IL_01B5;
					case 31:
						goto IL_044B;
					case 33:
						goto IL_0166;
					case 35:
						if (num2 == null)
						{
							return;
						}
						num = 6;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3baf10aa2a73406aa2bb349717d797c7 == 0)
						{
							goto Block_6;
						}
						continue;
					case 36:
						return;
					case 37:
						goto IL_0037;
					case 38:
						goto IL_0425;
					}
					break;
					IL_0037:
					if (!num3.Equals(0.0))
					{
						goto IL_00D5;
					}
					num = 22;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3bf07bb1c323490cb457eef2b2e78695 != 0)
					{
						goto IL_0064;
					}
					continue;
					IL_01B5:
					this.method_13(Class15.smethod_17(1743185164 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a321d34f24314561b0d80437d5d859e8).FormatWith(CultureInfo.InvariantCulture, value2, jsonSchemaModel_1.Maximum), jsonSchemaModel_1);
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a5994720d09542abb897ebf6ad9b5a19 == 0)
					{
						goto Block_9;
					}
				}
				goto IL_00EE;
				IL_0202:
				BigInteger bigInteger2;
				BigInteger bigInteger = bigInteger2;
				num2 = jsonSchemaModel_1.DivisibleBy;
				bool flag = bigInteger % new BigInteger(num2.Value) != 0L;
				goto IL_00E7;
				IL_00D5:
				flag = bigInteger2 != 0L;
				goto IL_00E7;
				Block_6:
				goto IL_00AC;
				Block_9:
				goto IL_0432;
				Block_10:
				goto IL_00E7;
				IL_0064:
				this.method_13(Class15.smethod_17(89054670 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_db7740c6ca7a4f3c8e1aa526bdb0a454).FormatWith(CultureInfo.InvariantCulture, value2, jsonSchemaModel_1.Minimum), jsonSchemaModel_1);
				num = 12;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_1d8dbb531d7349c0bc15bad339f7815c == 0)
				{
					goto IL_00AC;
				}
				goto IL_02F9;
				IL_0409:
				if (JValue.Compare(JTokenType.Integer, value2, jsonSchemaModel_1.Minimum) < 0)
				{
					goto IL_0064;
				}
				goto IL_03FB;
				IL_0425:
				if (num2 == null)
				{
					goto IL_03D3;
				}
				goto IL_0409;
				IL_0432:
				num2 = jsonSchemaModel_1.Minimum;
				goto IL_0425;
				IL_0166:
				if (!jsonSchemaModel_1.ExclusiveMaximum)
				{
					goto IL_0432;
				}
				num = 16;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9a2e459a49464219810a951679aea12e != 0)
				{
					goto IL_0186;
				}
				goto IL_02F9;
				IL_0232:
				if (JValue.Compare(JTokenType.Integer, value2, jsonSchemaModel_1.Maximum) > 0)
				{
					goto IL_024B;
				}
				goto IL_0166;
				IL_00EE:
				this.method_13(Class15.smethod_17(197570659 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c27e9fccdfcc44999155a4980faa4e81).FormatWith(CultureInfo.InvariantCulture, JsonConvert.ToString(value2), jsonSchemaModel_1.DivisibleBy), jsonSchemaModel_1);
				num = 9;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9f5329f120e842948536b8235793166c != 0)
				{
					break;
				}
				goto IL_02F9;
				IL_00E7:
				if (flag)
				{
					goto IL_00EE;
				}
				break;
				IL_00AC:
				double num4 = (double)Convert.ToInt64(value2, CultureInfo.InvariantCulture);
				num2 = jsonSchemaModel_1.DivisibleBy;
				flag = !JsonValidatingReader.smethod_1(num4 % num2.GetValueOrDefault());
				goto IL_00E7;
				IL_0186:
				if (!(value2 is BigInteger))
				{
					goto IL_00AC;
				}
				IL_0192:
				bigInteger2 = (BigInteger)value2;
				num = 18;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3bf07bb1c323490cb457eef2b2e78695 != 0)
				{
					goto IL_0019;
				}
				goto IL_02F9;
				IL_03D3:
				num2 = jsonSchemaModel_1.DivisibleBy;
				num = 35;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a41eabd4b99f489fb7d86310d3f95ba2 == 0)
				{
					goto IL_00AC;
				}
				goto IL_02F9;
				IL_03FB:
				if (!jsonSchemaModel_1.ExclusiveMinimum)
				{
					goto IL_03D3;
				}
				goto IL_0019;
				IL_03A0:
				this.method_13(Class15.smethod_17(676713812 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa49bb51056944098afe92e3a80a544b).FormatWith(CultureInfo.InvariantCulture, value2, jsonSchemaModel_1.Minimum), jsonSchemaModel_1);
				goto IL_03D3;
				IL_0019:
				if (JValue.Compare(JTokenType.Integer, value2, jsonSchemaModel_1.Minimum) == 0)
				{
					goto IL_03A0;
				}
				goto IL_03D3;
				IL_043C:
				if (num2 != null)
				{
					goto IL_0232;
				}
				goto IL_0432;
				IL_044B:
				num2 = jsonSchemaModel_1.Maximum;
				goto IL_043C;
				IL_0455:
				value2 = this.jsonReader_0.Value;
				goto IL_044B;
				IL_0464:
				this.method_15(jsonSchemaModel_1);
				goto IL_0455;
				IL_024B:
				this.method_13(Class15.smethod_17(1176438098 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93c7140125045538ae5c40c6f39a5af).FormatWith(CultureInfo.InvariantCulture, value2, jsonSchemaModel_1.Maximum), jsonSchemaModel_1);
				goto IL_0166;
			}
		}

		// Token: 0x060004D0 RID: 1232 RVA: 0x0003A144 File Offset: 0x00038344
		private void method_25()
		{
			IL_0062:
			while (this.class1_0 != null)
			{
				IL_004E:
				while (this.class1_0.TokenType == JTokenType.Array)
				{
					for (;;)
					{
						JsonValidatingReader.Class1 @class = this.class1_0;
						int num = @class.method_2();
						@class.method_3(num + 1);
						int num2 = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8432da17e8384a688cea4636964d3693 != 0)
						{
							switch (num2)
							{
							case 1:
								goto IL_0071;
							case 2:
								goto IL_004E;
							case 3:
								goto IL_0062;
							case 4:
								continue;
							case 5:
								goto IL_007E;
							}
							break;
						}
						goto IL_0070;
					}
					break;
					IL_0070:
					IL_0071:
					IEnumerator<JsonSchemaModel> enumerator = this.method_11().GetEnumerator();
					IL_007E:
					try
					{
						IL_018E:
						while (enumerator.MoveNext())
						{
							JsonSchemaModel jsonSchemaModel;
							for (;;)
							{
								IL_0146:
								jsonSchemaModel = enumerator.Current;
								IL_013E:
								while (jsonSchemaModel != null)
								{
									for (;;)
									{
										if (jsonSchemaModel.PositionalItemsValidation)
										{
											goto IL_0112;
										}
										int num3 = 3;
										if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ca6ac77a767741aa91cb31f8080f093b != 0)
										{
											break;
										}
										IL_00B7:
										switch (num3)
										{
										case 1:
											goto IL_0146;
										case 2:
											goto IL_0103;
										case 3:
										case 5:
										case 8:
											goto IL_018E;
										case 4:
											goto IL_013E;
										case 6:
										case 9:
											goto IL_0157;
										case 7:
											goto IL_0197;
										case 10:
											continue;
										case 11:
											IL_0112:
											if (!jsonSchemaModel.AllowAdditionalItems)
											{
												goto IL_0103;
											}
											goto IL_018E;
										}
										IL_0085:
										if (this.class1_0.method_2() - 1 >= jsonSchemaModel.Items.Count)
										{
											goto IL_0157;
										}
										num3 = 4;
										if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cf58136e49114a5691c4a9d0e9788de1 != 0)
										{
											goto IL_00B7;
										}
										goto IL_0154;
										IL_0103:
										if (jsonSchemaModel.Items != null)
										{
											goto IL_0085;
										}
										num3 = 9;
										if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c28a4ed7a58e45aaa9902e336fd60b97 == 0)
										{
											goto Block_9;
										}
										goto IL_00B7;
									}
									goto IL_0146;
								}
								break;
							}
							IL_0154:
							continue;
							IL_0157:
							this.method_13(Class15.smethod_17(642150058 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa29cbda752f45acbe81e7d5285df2ba).FormatWith(CultureInfo.InvariantCulture, this.class1_0.method_2()), jsonSchemaModel);
							continue;
							Block_9:
							goto IL_0157;
						}
						IL_0197:;
					}
					finally
					{
						if (enumerator != null)
						{
							int num4 = 1;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bd75de9a0b64d6da3a43e57303102f1 == 0)
							{
								goto IL_01C7;
							}
							IL_01AF:
							enumerator.Dispose();
							num4 = 0;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9f9b31fb7a85497499112abf86cccc98 == 0)
							{
								break;
							}
							IL_01C7:
							switch (num4)
							{
							case 1:
								goto IL_01AF;
							}
						}
					}
					break;
				}
				break;
			}
		}

		// Token: 0x060004D1 RID: 1233 RVA: 0x0003A348 File Offset: 0x00038548
		private void method_26(JsonSchemaModel jsonSchemaModel_1)
		{
			IL_03A1:
			while (jsonSchemaModel_1 != null)
			{
				if (this.method_31(jsonSchemaModel_1, JsonSchemaType.Float))
				{
					this.method_15(jsonSchemaModel_1);
					for (;;)
					{
						IL_0388:
						double num = Convert.ToDouble(this.jsonReader_0.Value, CultureInfo.InvariantCulture);
						for (;;)
						{
							IL_037E:
							double? num2 = jsonSchemaModel_1.Maximum;
							for (;;)
							{
								IL_0372:
								if (num2 == null)
								{
									goto IL_0328;
								}
								goto IL_034F;
								int num3;
								for (;;)
								{
									IL_02A7:
									switch (num3)
									{
									case 1:
										goto IL_01CF;
									case 2:
									case 3:
									case 7:
									case 17:
										goto IL_0328;
									case 4:
										goto IL_0126;
									case 5:
										return;
									case 6:
										goto IL_00C9;
									case 8:
										goto IL_034F;
									case 9:
									case 22:
										goto IL_00BE;
									case 10:
										goto IL_001F;
									case 11:
										goto IL_037E;
									case 12:
									case 20:
										goto IL_0184;
									case 13:
									{
										double num4 = num;
										num2 = jsonSchemaModel_1.DivisibleBy;
										if (JsonValidatingReader.smethod_1(JsonValidatingReader.smethod_0(num4, num2.GetValueOrDefault())))
										{
											return;
										}
										num3 = 1;
										if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3dc45d1ecdeb4859b7f470093f5eeed2 == 0)
										{
											continue;
										}
										break;
									}
									case 14:
										goto IL_00E9;
									case 15:
										goto IL_0194;
									case 16:
										this.method_13(Class15.smethod_17(1603829628 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d5af2cccac2f47ed978e804138a35d1c).FormatWith(CultureInfo.InvariantCulture, JsonConvert.ToString(num), jsonSchemaModel_1.Minimum), jsonSchemaModel_1);
										num3 = 0;
										if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d5af2cccac2f47ed978e804138a35d1c == 0)
										{
											continue;
										}
										break;
									case 18:
										return;
									case 19:
										goto IL_03A1;
									case 21:
										goto IL_0152;
									case 23:
										goto IL_012F;
									case 24:
										goto IL_0372;
									case 25:
										goto IL_0388;
									case 26:
										goto IL_0071;
									case 27:
										return;
									}
									break;
								}
								goto IL_018C;
								IL_001F:
								this.method_13(Class15.smethod_17(1042108355 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39a47a907a8a440980940ae96da3f3ad).FormatWith(CultureInfo.InvariantCulture, JsonConvert.ToString(num), jsonSchemaModel_1.Maximum), jsonSchemaModel_1);
								num3 = 7;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_11c6824de6514281a8425f6d6ab1a2d5 == 0)
								{
									goto IL_00BE;
								}
								goto IL_02A7;
								IL_0071:
								this.method_13(Class15.smethod_17(1396543038 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4152404f503b492c83d9bc2e44bdd0a7).FormatWith(CultureInfo.InvariantCulture, JsonConvert.ToString(num), jsonSchemaModel_1.Minimum), jsonSchemaModel_1);
								num3 = 20;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0005996a6a494de4880ac2956b2e0112 == 0)
								{
									goto IL_00BE;
								}
								goto IL_02A7;
								IL_012F:
								double num5 = num;
								num2 = jsonSchemaModel_1.Minimum;
								if (!((num5 < num2.GetValueOrDefault()) & (num2 != null)))
								{
									goto IL_0184;
								}
								goto IL_0071;
								IL_0126:
								if (num2 != null)
								{
									goto IL_012F;
								}
								goto IL_018C;
								IL_0328:
								num2 = jsonSchemaModel_1.Minimum;
								goto IL_0126;
								IL_00C9:
								double num6 = num;
								num2 = jsonSchemaModel_1.Maximum;
								if ((num6 == num2.GetValueOrDefault()) & (num2 != null))
								{
									goto IL_00E9;
								}
								goto IL_0328;
								IL_00BE:
								if (jsonSchemaModel_1.ExclusiveMaximum)
								{
									goto IL_00C9;
								}
								num3 = 17;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_100d09ce3850492c8356d7fa1e667d54 == 0)
								{
									goto IL_01CF;
								}
								goto IL_02A7;
								IL_0152:
								double num7 = num;
								num2 = jsonSchemaModel_1.Minimum;
								if (!((num7 == num2.GetValueOrDefault()) & (num2 != null)))
								{
									goto IL_018C;
								}
								num3 = 16;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4ac69ea2381b403582a2723337f67fa8 != 0)
								{
									goto IL_02A7;
								}
								IL_0184:
								if (!jsonSchemaModel_1.ExclusiveMinimum)
								{
									goto IL_018C;
								}
								goto IL_0152;
								IL_0194:
								if (num2 == null)
								{
									return;
								}
								num3 = 13;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0361b8eb39074ea88f5257b13904930a == 0)
								{
									goto IL_0328;
								}
								goto IL_02A7;
								IL_018C:
								num2 = jsonSchemaModel_1.DivisibleBy;
								goto IL_0194;
								IL_01CF:
								this.method_13(Class15.smethod_17(2048555287 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e764f065c2fa404a85129e2e957d4f18).FormatWith(CultureInfo.InvariantCulture, JsonConvert.ToString(num), jsonSchemaModel_1.DivisibleBy), jsonSchemaModel_1);
								num3 = 27;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_548c52e5632b45898e377ad9c9a06469 == 0)
								{
									goto IL_02A7;
								}
								IL_034F:
								double num8 = num;
								num2 = jsonSchemaModel_1.Maximum;
								if ((num8 > num2.GetValueOrDefault()) & (num2 != null))
								{
									goto IL_001F;
								}
								num3 = 22;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ae8c3d3c66a64b57beca0f5360302062 != 0)
								{
									goto IL_0328;
								}
								goto IL_02A7;
								IL_00E9:
								this.method_13(Class15.smethod_17(486513772 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39d5fbfa4fe34ed9908db538e5340a6c).FormatWith(CultureInfo.InvariantCulture, JsonConvert.ToString(num), jsonSchemaModel_1.Maximum), jsonSchemaModel_1);
								goto IL_0328;
							}
						}
					}
					return;
				}
				return;
			}
		}

		// Token: 0x060004D2 RID: 1234 RVA: 0x000033EF File Offset: 0x000015EF
		private static double smethod_0(double double_0, double double_1)
		{
			return double_0 - Math.Floor(double_0 / double_1) * double_1;
		}

		// Token: 0x060004D3 RID: 1235 RVA: 0x000033FD File Offset: 0x000015FD
		private static bool smethod_1(double double_0)
		{
			return Math.Abs(double_0) < 4.440892098500626E-15;
		}

		// Token: 0x060004D4 RID: 1236 RVA: 0x0003A700 File Offset: 0x00038900
		private void method_27(JsonSchemaModel jsonSchemaModel_1)
		{
			while (jsonSchemaModel_1 != null)
			{
				string text = Convert.ToString(this.jsonReader_0.Value, CultureInfo.InvariantCulture);
				int num = 5;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a321d34f24314561b0d80437d5d859e8 != 0)
				{
					goto IL_008F;
				}
				IL_00CF:
				switch (num)
				{
				case 0:
					return;
				case 1:
					goto IL_00BE;
				case 2:
					return;
				case 3:
					continue;
				case 4:
					goto IL_00A3;
				case 5:
					goto IL_00B6;
				case 6:
				case 8:
					goto IL_006E;
				case 7:
					IL_008F:
					if (this.class1_0.method_8().ContainsKey(text))
					{
						goto IL_00A3;
					}
					goto IL_00B6;
				case 9:
					break;
				default:
					return;
				}
				IL_0034:
				this.method_13(Class15.smethod_17(1243270234 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_67a271e0ae064fc7a3a74905868add95).FormatWith(CultureInfo.InvariantCulture, text), jsonSchemaModel_1);
				num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_92ac2a37edba4e2587eb1b9e8af3f63f != 0)
				{
					goto IL_006E;
				}
				goto IL_00CF;
				IL_00BE:
				if (!this.method_28(jsonSchemaModel_1, text))
				{
					goto IL_0034;
				}
				goto IL_006E;
				IL_00B6:
				if (!jsonSchemaModel_1.AllowAdditionalProperties)
				{
					goto IL_00BE;
				}
				goto IL_006E;
				IL_00A3:
				this.class1_0.method_8()[text] = true;
				goto IL_00B6;
				IL_006E:
				this.class1_0.method_1(text);
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_193800745ad94a529d9e5edc977c4f02 != 0)
				{
					goto IL_00CF;
				}
				return;
			}
		}

		// Token: 0x060004D5 RID: 1237 RVA: 0x0003A814 File Offset: 0x00038A14
		private bool method_28(JsonSchemaModel jsonSchemaModel_1, string string_1)
		{
			IEnumerator<string> enumerator;
			for (;;)
			{
				if (jsonSchemaModel_1.Properties == null)
				{
					goto IL_0077;
				}
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8432da17e8384a688cea4636964d3693 == 0)
				{
					goto IL_0006;
				}
				IL_0028:
				switch (num)
				{
				case 0:
					goto IL_0077;
				case 1:
					IL_0006:
					if (jsonSchemaModel_1.Properties.ContainsKey(string_1))
					{
						return true;
					}
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ae8c3d3c66a64b57beca0f5360302062 == 0)
					{
						goto IL_0028;
					}
					goto IL_0077;
				case 2:
					continue;
				case 3:
					goto IL_00A8;
				case 4:
				case 5:
					return false;
				case 6:
					return true;
				case 7:
					break;
				default:
					goto IL_0077;
				}
				IL_0050:
				enumerator = jsonSchemaModel_1.PatternProperties.Keys.GetEnumerator();
				num = 3;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_43b32b9d66294210a955990bb6fcc511 == 0)
				{
					break;
				}
				goto IL_0028;
				IL_0077:
				if (jsonSchemaModel_1.PatternProperties == null)
				{
					goto Block_4;
				}
				goto IL_0050;
			}
			goto IL_00A8;
			Block_4:
			return false;
			IL_00A8:
			bool flag;
			try
			{
				while (enumerator.MoveNext())
				{
					for (;;)
					{
						IL_00EE:
						string text = enumerator.Current;
						while (!Regex.IsMatch(string_1, text))
						{
							int num2 = 0;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_92ac2a37edba4e2587eb1b9e8af3f63f != 0)
							{
								switch (num2)
								{
								case 1:
									goto IL_00EE;
								case 2:
									goto IL_0105;
								case 3:
									goto IL_0108;
								case 5:
									goto IL_0103;
								case 6:
									continue;
								}
								goto Block_10;
							}
							goto IL_00F9;
						}
						goto IL_0105;
					}
					Block_10:
					IL_00F9:
					continue;
					IL_0105:
					flag = true;
					IL_0108:
					return flag;
				}
				IL_0103:
				return false;
			}
			finally
			{
				if (enumerator != null)
				{
					int num3 = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_75738dd4edc84122bfe3748a1ea03d43 != 0)
					{
						goto IL_0138;
					}
					IL_0120:
					enumerator.Dispose();
					num3 = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e764f065c2fa404a85129e2e957d4f18 != 0)
					{
						goto IL_0149;
					}
					IL_0138:
					switch (num3)
					{
					case 1:
						goto IL_0120;
					}
				}
				IL_0149:;
			}
			return flag;
		}

		// Token: 0x060004D6 RID: 1238 RVA: 0x0003A984 File Offset: 0x00038B84
		private bool method_29(JsonSchemaModel jsonSchemaModel_1)
		{
			while (jsonSchemaModel_1 == null)
			{
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cbfb1e54efd84756a9b6d7b21adc0d65 != 0)
				{
					switch (num)
					{
					case 1:
						continue;
					}
				}
				return true;
			}
			return this.method_31(jsonSchemaModel_1, JsonSchemaType.Array);
		}

		// Token: 0x060004D7 RID: 1239 RVA: 0x0003A9C8 File Offset: 0x00038BC8
		private bool method_30(JsonSchemaModel jsonSchemaModel_1)
		{
			while (jsonSchemaModel_1 == null)
			{
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8d68b74cee6442019d959192b2974e3d != 0)
				{
					switch (num)
					{
					case 1:
						continue;
					}
				}
				return true;
			}
			return this.method_31(jsonSchemaModel_1, JsonSchemaType.Object);
		}

		// Token: 0x060004D8 RID: 1240 RVA: 0x0003AA0C File Offset: 0x00038C0C
		private bool method_31(JsonSchemaModel jsonSchemaModel_1, JsonSchemaType jsonSchemaType_0)
		{
			IL_0063:
			while (!JsonSchemaGenerator.HasFlag(new JsonSchemaType?(jsonSchemaModel_1.Type), jsonSchemaType_0))
			{
				for (;;)
				{
					this.method_13(Class15.smethod_17(1793874296 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0361b8eb39074ea88f5257b13904930a).FormatWith(CultureInfo.InvariantCulture, jsonSchemaModel_1.Type, jsonSchemaType_0), jsonSchemaModel_1);
					int num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c08ab7af63da4f24a4fa3e9c7a732fae == 0)
					{
						break;
					}
					switch (num)
					{
					case 1:
						return false;
					case 2:
						return true;
					case 3:
						goto IL_0063;
					}
				}
				return false;
			}
			return true;
		}

		// Token: 0x060004D9 RID: 1241 RVA: 0x0003AA94 File Offset: 0x00038C94
		bool IJsonLineInfo.HasLineInfo()
		{
			IJsonLineInfo jsonLineInfo;
			for (;;)
			{
				jsonLineInfo = this.jsonReader_0 as IJsonLineInfo;
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_193800745ad94a529d9e5edc977c4f02 == 0)
				{
					goto IL_0003;
				}
				IL_0018:
				switch (num)
				{
				case 1:
					continue;
				case 2:
					goto IL_0052;
				}
				IL_0003:
				if (jsonLineInfo == null)
				{
					return false;
				}
				num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_676b866782704933888a7440512fd4ff == 0)
				{
					goto IL_0018;
				}
				break;
			}
			IL_0052:
			return jsonLineInfo.HasLineInfo();
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x060004DA RID: 1242 RVA: 0x0003AAFC File Offset: 0x00038CFC
		int IJsonLineInfo.LineNumber
		{
			get
			{
				IJsonLineInfo jsonLineInfo;
				for (;;)
				{
					jsonLineInfo = this.jsonReader_0 as IJsonLineInfo;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c27e9fccdfcc44999155a4980faa4e81 != 0)
					{
						goto IL_0003;
					}
					IL_0018:
					switch (num)
					{
					case 1:
						IL_0003:
						if (jsonLineInfo != null)
						{
							goto IL_0050;
						}
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_afb77be96d644a2297c7f9466cb06ede == 0)
						{
							goto IL_0018;
						}
						break;
					case 2:
						continue;
					}
					break;
				}
				return 0;
				IL_0050:
				return jsonLineInfo.LineNumber;
			}
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x060004DB RID: 1243 RVA: 0x0003AB60 File Offset: 0x00038D60
		int IJsonLineInfo.LinePosition
		{
			get
			{
				IJsonLineInfo jsonLineInfo;
				for (;;)
				{
					IL_0033:
					jsonLineInfo = this.jsonReader_0 as IJsonLineInfo;
					while (jsonLineInfo != null)
					{
						int num = 1;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c08ab7af63da4f24a4fa3e9c7a732fae != 0)
						{
							switch (num)
							{
							case 1:
								goto IL_0043;
							case 2:
								continue;
							case 3:
								goto IL_0033;
							}
							break;
						}
						goto IL_0042;
					}
					break;
				}
				return 0;
				IL_0042:
				IL_0043:
				return jsonLineInfo.LinePosition;
			}
		}

		// Token: 0x060004DC RID: 1244 RVA: 0x0003ABBC File Offset: 0x00038DBC
		static JsonValidatingReader()
		{
			for (;;)
			{
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b3c865ee224546b18f2991d2a8895f6a == 0)
				{
					goto IL_0003;
				}
				IL_0031:
				switch (num)
				{
				case 1:
					return;
				case 2:
					IL_0003:
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c08ab7af63da4f24a4fa3e9c7a732fae != 0)
					{
						goto IL_0031;
					}
					break;
				case 3:
					continue;
				}
				JsonValidatingReader.ilist_0 = new List<JsonSchemaModel>();
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa49bb51056944098afe92e3a80a544b == 0)
				{
					goto IL_0031;
				}
				break;
			}
		}

		// Token: 0x040002CA RID: 714
		private readonly JsonReader jsonReader_0;

		// Token: 0x040002CB RID: 715
		private readonly Stack<JsonValidatingReader.Class1> stack_0;

		// Token: 0x040002CC RID: 716
		private JsonSchema jsonSchema_0;

		// Token: 0x040002CD RID: 717
		private JsonSchemaModel jsonSchemaModel_0;

		// Token: 0x040002CE RID: 718
		private JsonValidatingReader.Class1 class1_0;

		// Token: 0x040002CF RID: 719
		[CompilerGenerated]
		private ValidationEventHandler validationEventHandler_0;

		// Token: 0x040002D0 RID: 720
		private static readonly IList<JsonSchemaModel> ilist_0;

		// Token: 0x0200006D RID: 109
		private class Class1
		{
			// Token: 0x060004DF RID: 1247 RVA: 0x00003410 File Offset: 0x00001610
			[CompilerGenerated]
			public string method_0()
			{
				return this.string_0;
			}

			// Token: 0x060004E0 RID: 1248 RVA: 0x0003AC28 File Offset: 0x00038E28
			[CompilerGenerated]
			public void method_1(string string_1)
			{
				for (;;)
				{
					this.string_0 = string_1;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5f127c3ec2e04c11ab1bd26a8d965f2b == 0)
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

			// Token: 0x060004E1 RID: 1249 RVA: 0x00003418 File Offset: 0x00001618
			[CompilerGenerated]
			public int method_2()
			{
				return this.int_0;
			}

			// Token: 0x060004E2 RID: 1250 RVA: 0x0003AC60 File Offset: 0x00038E60
			[CompilerGenerated]
			public void method_3(int int_1)
			{
				for (;;)
				{
					this.int_0 = int_1;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bd75de9a0b64d6da3a43e57303102f1 != 0)
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

			// Token: 0x060004E3 RID: 1251 RVA: 0x00003420 File Offset: 0x00001620
			[CompilerGenerated]
			public bool method_4()
			{
				return this.bool_0;
			}

			// Token: 0x060004E4 RID: 1252 RVA: 0x00003428 File Offset: 0x00001628
			[CompilerGenerated]
			public IList<JToken> method_5()
			{
				return this.TewuYinpIV;
			}

			// Token: 0x060004E5 RID: 1253 RVA: 0x00003430 File Offset: 0x00001630
			[CompilerGenerated]
			public JTokenWriter RgfuhiGaAJ()
			{
				return this.jtokenWriter_0;
			}

			// Token: 0x060004E6 RID: 1254 RVA: 0x0003AC98 File Offset: 0x00038E98
			[CompilerGenerated]
			public void method_6(JTokenWriter jtokenWriter_1)
			{
				for (;;)
				{
					this.jtokenWriter_0 = jtokenWriter_1;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3baf10aa2a73406aa2bb349717d797c7 == 0)
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

			// Token: 0x060004E7 RID: 1255 RVA: 0x00003438 File Offset: 0x00001638
			public IList<JsonSchemaModel> method_7()
			{
				return this.ilist_0;
			}

			// Token: 0x060004E8 RID: 1256 RVA: 0x00003440 File Offset: 0x00001640
			public Dictionary<string, bool> method_8()
			{
				return this.dictionary_0;
			}

			// Token: 0x170000D0 RID: 208
			// (get) Token: 0x060004E9 RID: 1257 RVA: 0x00003448 File Offset: 0x00001648
			public JTokenType TokenType
			{
				get
				{
					return this.jtokenType_0;
				}
			}

			// Token: 0x060004EA RID: 1258 RVA: 0x0003ACD0 File Offset: 0x00038ED0
			public Class1(JTokenType jtokenType_1, IList<JsonSchemaModel> ilist_1)
			{
				this.jtokenType_0 = jtokenType_1;
				this.ilist_0 = ilist_1;
				this.dictionary_0 = ilist_1.SelectMany(new Func<JsonSchemaModel, IEnumerable<string>>(this.method_9)).Distinct<string>().ToDictionary(new Func<string, string>(JsonValidatingReader.Class1.<>c.<>c_0.method_0), new Func<string, bool>(JsonValidatingReader.Class1.<>c.<>c_0.method_1));
				if (jtokenType_1 == JTokenType.Array)
				{
					if (ilist_1.Any(new Func<JsonSchemaModel, bool>(JsonValidatingReader.Class1.<>c.<>c_0.method_2)))
					{
						this.bool_0 = true;
						this.TewuYinpIV = new List<JToken>();
					}
				}
			}

			// Token: 0x060004EB RID: 1259 RVA: 0x0003AD90 File Offset: 0x00038F90
			private IEnumerable<string> method_9(JsonSchemaModel jsonSchemaModel_0)
			{
				if (((jsonSchemaModel_0 != null) ? jsonSchemaModel_0.Properties : null) == null)
				{
					return Enumerable.Empty<string>();
				}
				return jsonSchemaModel_0.Properties.Where(new Func<KeyValuePair<string, JsonSchemaModel>, bool>(JsonValidatingReader.Class1.<>c.<>c_0.method_3)).Select(new Func<KeyValuePair<string, JsonSchemaModel>, string>(JsonValidatingReader.Class1.<>c.<>c_0.method_4));
			}

			// Token: 0x040002D2 RID: 722
			private readonly JTokenType jtokenType_0;

			// Token: 0x040002D3 RID: 723
			private readonly IList<JsonSchemaModel> ilist_0;

			// Token: 0x040002D4 RID: 724
			private readonly Dictionary<string, bool> dictionary_0;

			// Token: 0x040002D5 RID: 725
			[CompilerGenerated]
			private string string_0;

			// Token: 0x040002D6 RID: 726
			[CompilerGenerated]
			private int int_0;

			// Token: 0x040002D7 RID: 727
			[CompilerGenerated]
			private readonly bool bool_0;

			// Token: 0x040002D8 RID: 728
			[CompilerGenerated]
			private readonly IList<JToken> TewuYinpIV;

			// Token: 0x040002D9 RID: 729
			[CompilerGenerated]
			private JTokenWriter jtokenWriter_0;
		}
	}
}
