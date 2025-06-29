using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Linq
{
	// Token: 0x0200016A RID: 362
	[NullableContext(1)]
	[Nullable(0)]
	public class JTokenReader : JsonReader, IJsonLineInfo
	{
		// Token: 0x1700025B RID: 603
		// (get) Token: 0x06001037 RID: 4151 RVA: 0x00006661 File Offset: 0x00004861
		[Nullable(2)]
		public JToken CurrentToken
		{
			[NullableContext(2)]
			get
			{
				return this.jtoken_2;
			}
		}

		// Token: 0x06001038 RID: 4152 RVA: 0x000806C4 File Offset: 0x0007E8C4
		public JTokenReader(JToken token)
		{
			for (;;)
			{
				ValidationUtils.ArgumentNotNull(token, Class15.smethod_17(1387479722 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e5c1d856e0c64e6f8377f7d819e11923));
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f19acd91a8c44846a95d09d7dc3da2ba != 0)
				{
					goto IL_000A;
				}
				IL_0022:
				switch (num)
				{
				case 1:
					return;
				case 2:
					continue;
				}
				IL_000A:
				this.jtoken_0 = token;
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0005996a6a494de4880ac2956b2e0112 == 0)
				{
					goto IL_0022;
				}
				break;
			}
		}

		// Token: 0x06001039 RID: 4153 RVA: 0x00080738 File Offset: 0x0007E938
		public JTokenReader(JToken token, string initialPath)
			: this(token)
		{
			int num = 1;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3baf10aa2a73406aa2bb349717d797c7 != 0)
			{
				goto IL_0033;
			}
			IL_001B:
			this.string_1 = initialPath;
			num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cb7e1ff8cc1348bebf46c510e64a0134 != 0)
			{
				return;
			}
			IL_0033:
			switch (num)
			{
			case 1:
				goto IL_001B;
			}
		}

		// Token: 0x0600103A RID: 4154 RVA: 0x0008078C File Offset: 0x0007E98C
		public override bool Read()
		{
			IL_008F:
			while (base.CurrentState != JsonReader.State.Start)
			{
				JContainer jcontainer;
				for (;;)
				{
					if (this.jtoken_2 != null)
					{
						jcontainer = this.jtoken_2 as JContainer;
						goto IL_0066;
					}
					int num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4152404f503b492c83d9bc2e44bdd0a7 == 0)
					{
						break;
					}
					IL_0029:
					switch (num)
					{
					case 1:
						return false;
					case 2:
						IL_0066:
						if (jcontainer != null)
						{
							goto IL_0059;
						}
						goto IL_00D6;
					case 3:
						return true;
					case 4:
						goto IL_0059;
					case 5:
						goto IL_00BC;
					case 6:
						goto IL_009F;
					case 7:
						goto IL_008F;
					case 8:
						return false;
					case 9:
						continue;
					}
					break;
					IL_0059:
					if (this.jtoken_1 == jcontainer)
					{
						goto IL_00D6;
					}
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cbfb1e54efd84756a9b6d7b21adc0d65 != 0)
					{
						goto IL_0029;
					}
					break;
				}
				goto IL_00CD;
				IL_009F:
				if (this.jtoken_2 == this.jtoken_0)
				{
					return false;
				}
				this.jtoken_2 = this.jtoken_0;
				IL_00BC:
				this.method_14(this.jtoken_2);
				return true;
				IL_00CD:
				return this.method_12(jcontainer);
				IL_00D6:
				return this.method_9(this.jtoken_2);
			}
			goto IL_009F;
		}

		// Token: 0x0600103B RID: 4155 RVA: 0x0008087C File Offset: 0x0007EA7C
		private bool method_9(JToken jtoken_3)
		{
			JToken next;
			for (;;)
			{
				if (jtoken_3 != this.jtoken_0)
				{
					next = jtoken_3.Next;
					goto IL_0097;
				}
				int num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_43b8cdd768c545d884bf7ff1c8fefe89 == 0)
				{
					break;
				}
				IL_0047:
				switch (num)
				{
				case 1:
					goto IL_007B;
				case 2:
					goto IL_00D1;
				case 3:
					continue;
				case 4:
					IL_0097:
					if (next != null)
					{
						goto IL_007B;
					}
					num = 7;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5c76a4eb2c1748d1bee3513c8eaff2eb == 0)
					{
						goto IL_007B;
					}
					goto IL_0047;
				case 5:
					goto IL_00D8;
				case 6:
					goto IL_00FB;
				case 7:
				case 9:
					goto IL_00E6;
				case 8:
					return true;
				case 10:
					goto IL_00EE;
				}
				IL_0025:
				if (jtoken_3 != jtoken_3.Parent.Last)
				{
					goto IL_00C7;
				}
				num = 9;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3436841e08c54f56b10b76e1438d4224 != 0)
				{
					goto IL_0047;
				}
				goto IL_00C4;
				IL_007B:
				if (next == jtoken_3)
				{
					goto IL_00E6;
				}
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c08ab7af63da4f24a4fa3e9c7a732fae == 0)
				{
					goto IL_0025;
				}
				goto IL_0047;
			}
			goto IL_00D1;
			IL_00C4:
			goto IL_00E6;
			IL_00C7:
			this.jtoken_2 = next;
			goto IL_00D8;
			IL_00D1:
			return this.method_10();
			IL_00D8:
			this.method_14(this.jtoken_2);
			return true;
			IL_00E6:
			if (jtoken_3.Parent == null)
			{
				goto IL_00FB;
			}
			IL_00EE:
			return this.method_13(jtoken_3.Parent);
			IL_00FB:
			return this.method_10();
		}

		// Token: 0x0600103C RID: 4156 RVA: 0x0008098C File Offset: 0x0007EB8C
		private bool method_10()
		{
			for (;;)
			{
				this.jtoken_2 = null;
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4ac69ea2381b403582a2723337f67fa8 == 0)
				{
					goto IL_001E;
				}
				do
				{
					IL_0003:
					base.SetToken(JsonToken.None);
					num = 2;
				}
				while (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_370349efcd7c4959a098549c3d5bf14d == 0);
				IL_001E:
				switch (num)
				{
				case 0:
					goto IL_0003;
				case 1:
					break;
				case 2:
					return false;
				default:
					goto IL_0003;
				}
			}
			return false;
		}

		// Token: 0x0600103D RID: 4157 RVA: 0x000809E8 File Offset: 0x0007EBE8
		private JsonToken? method_11(JContainer jcontainer_0)
		{
			switch (jcontainer_0.Type)
			{
			case JTokenType.Object:
				return new JsonToken?(JsonToken.EndObject);
			case JTokenType.Array:
				return new JsonToken?(JsonToken.EndArray);
			case JTokenType.Constructor:
				return new JsonToken?(JsonToken.EndConstructor);
			case JTokenType.Property:
				return null;
			default:
				throw MiscellaneousUtils.CreateArgumentOutOfRangeException(Class15.smethod_17(2128216384 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_871a407507f34aa3b5bf52517d4f63a9), jcontainer_0.Type, Class15.smethod_17(1424596110 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bca7529ca324c188cfc0e64eb7d1cdf));
			}
		}

		// Token: 0x0600103E RID: 4158 RVA: 0x00080A70 File Offset: 0x0007EC70
		private bool method_12(JContainer jcontainer_0)
		{
			for (;;)
			{
				IL_0073:
				JToken first = jcontainer_0.First;
				for (;;)
				{
					IL_006C:
					int num;
					if (first == null)
					{
						num = 1;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e764f065c2fa404a85129e2e957d4f18 != 0)
						{
							goto Block_3;
						}
					}
					else
					{
						this.method_14(first);
						num = 2;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0efaea2f67ca4b0aa2880fbd34fc0fff == 0)
						{
							goto Block_1;
						}
					}
					for (;;)
					{
						switch (num)
						{
						case 1:
							goto IL_0083;
						case 2:
							this.jtoken_2 = first;
							num = 0;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_db7740c6ca7a4f3c8e1aa526bdb0a454 != 0)
							{
								continue;
							}
							break;
						case 3:
							return true;
						case 4:
							goto IL_006C;
						case 5:
							goto IL_0073;
						}
						goto Block_2;
					}
				}
			}
			Block_1:
			Block_2:
			goto IL_008C;
			Block_3:
			IL_0083:
			return this.method_13(jcontainer_0);
			IL_008C:
			this.jtoken_1 = jcontainer_0;
			return true;
		}

		// Token: 0x0600103F RID: 4159 RVA: 0x00080B14 File Offset: 0x0007ED14
		private bool method_13(JContainer jcontainer_0)
		{
			for (;;)
			{
				IL_006A:
				JsonToken? jsonToken = this.method_11(jcontainer_0);
				int num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2e3be65f7cb2480482903dc73ec42f7c != 0)
				{
					goto IL_0027;
				}
				for (;;)
				{
					IL_0045:
					switch (num)
					{
					case 1:
						goto IL_0027;
					case 2:
						goto IL_001E;
					case 3:
						goto IL_006A;
					case 4:
						this.jtoken_2 = jcontainer_0;
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_207f975845fc40cdbe6b166fce664cd5 != 0)
						{
							continue;
						}
						break;
					case 5:
						goto IL_0091;
					case 6:
						return true;
					}
					goto Block_2;
				}
				IL_001E:
				if (jsonToken == null)
				{
					goto IL_0091;
				}
				IL_0027:
				base.SetToken(jsonToken.GetValueOrDefault());
				num = 4;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d9581c727fcc4f50accd4f5de0d386f5 == 0)
				{
					goto IL_0045;
				}
			}
			Block_2:
			this.jtoken_1 = jcontainer_0;
			return true;
			IL_0091:
			return this.method_9(jcontainer_0);
		}

		// Token: 0x06001040 RID: 4160 RVA: 0x00080BBC File Offset: 0x0007EDBC
		private void method_14(JToken jtoken_3)
		{
			for (;;)
			{
				IL_01FB:
				JTokenType type = jtoken_3.Type;
				int num = 3;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8db627a8c96145a0afb24deffd2a8808 == 0)
				{
					goto Block_11;
				}
				for (;;)
				{
					object value;
					switch (num)
					{
					case 1:
						return;
					case 2:
						return;
					case 3:
						switch (type)
						{
						case JTokenType.Object:
							goto IL_0046;
						case JTokenType.Array:
							goto IL_021B;
						case JTokenType.Constructor:
							goto IL_0227;
						case JTokenType.Property:
							goto IL_023E;
						case JTokenType.Comment:
							goto IL_0255;
						case JTokenType.Integer:
							goto IL_026C;
						case JTokenType.Float:
							base.SetToken(JsonToken.Float, ((JValue)jtoken_3).Value);
							num = 2;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b17e63564ae246399767b60cf4b1528a == 0)
							{
								goto Block_5;
							}
							continue;
						case JTokenType.String:
							base.SetToken(JsonToken.String, ((JValue)jtoken_3).Value);
							num = 4;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d9581c727fcc4f50accd4f5de0d386f5 == 0)
							{
								goto Block_6;
							}
							continue;
						case JTokenType.Boolean:
							goto IL_028B;
						case JTokenType.Null:
							base.SetToken(JsonToken.Null, ((JValue)jtoken_3).Value);
							num = 1;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c367d9ce11cc43b595beeb4524149542 != 0)
							{
								goto Block_7;
							}
							continue;
						case JTokenType.Undefined:
							goto IL_02A9;
						case JTokenType.Date:
							goto IL_02C1;
						case JTokenType.Raw:
							goto IL_02D0;
						case JTokenType.Bytes:
							base.SetToken(JsonToken.Bytes, ((JValue)jtoken_3).Value);
							num = 9;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_676b866782704933888a7440512fd4ff == 0)
							{
								goto Block_8;
							}
							continue;
						case JTokenType.Guid:
							goto IL_02E7;
						case JTokenType.Uri:
							value = ((JValue)jtoken_3).Value;
							num = 15;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_6f87b5b72b9847f7b8ec5b44b0dccfa8 == 0)
							{
								goto IL_0006;
							}
							continue;
						case JTokenType.TimeSpan:
							goto IL_0302;
						}
						goto Block_4;
					case 4:
						goto IL_01FB;
					case 5:
						return;
					case 6:
						goto IL_0392;
					case 7:
						return;
					case 8:
						return;
					case 9:
						return;
					case 10:
						goto IL_0046;
					case 11:
						return;
					case 12:
						goto IL_032E;
					case 13:
						goto IL_0325;
					case 14:
						return;
					case 15:
						return;
					case 16:
						return;
					case 17:
						return;
					case 18:
						return;
					case 19:
						goto IL_033D;
					case 20:
						return;
					case 21:
						return;
					case 22:
						return;
					case 23:
						return;
					case 24:
						goto IL_0006;
					case 25:
						goto IL_037E;
					}
					goto Block_10;
					IL_0006:
					JsonToken jsonToken = JsonToken.String;
					Uri uri = value as Uri;
					base.SetToken(jsonToken, (uri != null) ? uri.OriginalString : this.method_15(value));
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_55c1fea936c04e47abbfb2b5f778aff7 != 0)
					{
						goto Block_2;
					}
					continue;
					IL_0046:
					base.SetToken(JsonToken.StartObject);
					num = 3;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5be00c24d71649dcae8af3eed7b74ac9 == 0)
					{
						goto Block_3;
					}
				}
			}
			Block_2:
			return;
			Block_3:
			return;
			Block_4:
			goto IL_033D;
			Block_5:
			return;
			Block_6:
			return;
			Block_7:
			return;
			Block_8:
			return;
			Block_10:
			return;
			Block_11:
			return;
			IL_021B:
			base.SetToken(JsonToken.StartArray);
			return;
			IL_0227:
			base.SetToken(JsonToken.StartConstructor, ((JConstructor)jtoken_3).Name);
			return;
			IL_023E:
			base.SetToken(JsonToken.PropertyName, ((JProperty)jtoken_3).Name);
			return;
			IL_0255:
			base.SetToken(JsonToken.Comment, ((JValue)jtoken_3).Value);
			return;
			IL_026C:
			base.SetToken(JsonToken.Integer, ((JValue)jtoken_3).Value);
			return;
			IL_028B:
			base.SetToken(JsonToken.Boolean, ((JValue)jtoken_3).Value);
			return;
			IL_02A9:
			base.SetToken(JsonToken.Undefined, ((JValue)jtoken_3).Value);
			return;
			IL_02C1:
			object obj = ((JValue)jtoken_3).Value;
			goto IL_0325;
			IL_02D0:
			base.SetToken(JsonToken.Raw, ((JValue)jtoken_3).Value);
			return;
			IL_02E7:
			base.SetToken(JsonToken.String, this.method_15(((JValue)jtoken_3).Value));
			return;
			IL_0302:
			base.SetToken(JsonToken.String, this.method_15(((JValue)jtoken_3).Value));
			return;
			IL_0325:
			if (!(obj is DateTime))
			{
				goto IL_0392;
			}
			IL_032E:
			DateTime dateTime = (DateTime)obj;
			goto IL_037E;
			IL_033D:
			throw MiscellaneousUtils.CreateArgumentOutOfRangeException(Class15.smethod_17(564895800 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_1db17fe7bd2442b599c52df89f39e610), jtoken_3.Type, Class15.smethod_17(974402593 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_92ac2a37edba4e2587eb1b9e8af3f63f));
			IL_037E:
			obj = DateTimeUtils.EnsureDateTime(dateTime, base.DateTimeZoneHandling);
			IL_0392:
			base.SetToken(JsonToken.Date, obj);
		}

		// Token: 0x06001041 RID: 4161 RVA: 0x00080F68 File Offset: 0x0007F168
		[NullableContext(2)]
		private string method_15(object object_1)
		{
			while (object_1 != null)
			{
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5f127c3ec2e04c11ab1bd26a8d965f2b != 0)
				{
					switch (num)
					{
					case 0:
						goto IL_0036;
					case 1:
						break;
					case 2:
						continue;
					default:
						goto IL_0036;
					}
				}
				return object_1.ToString();
			}
			IL_0036:
			return null;
		}

		// Token: 0x06001042 RID: 4162 RVA: 0x00080FAC File Offset: 0x0007F1AC
		bool IJsonLineInfo.HasLineInfo()
		{
			IJsonLineInfo jsonLineInfo;
			for (;;)
			{
				if (base.CurrentState != JsonReader.State.Start)
				{
					jsonLineInfo = this.jtoken_2;
					goto IL_0036;
				}
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2e3be65f7cb2480482903dc73ec42f7c == 0)
				{
					break;
				}
				IL_001E:
				switch (num)
				{
				case 1:
					continue;
				case 2:
					goto IL_0060;
				case 3:
					IL_0036:
					if (jsonLineInfo == null)
					{
						return false;
					}
					num = 2;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_1db17fe7bd2442b599c52df89f39e610 == 0)
					{
						goto IL_001E;
					}
					goto IL_005F;
				}
				break;
			}
			return false;
			IL_005F:
			IL_0060:
			return jsonLineInfo.HasLineInfo();
		}

		// Token: 0x1700025C RID: 604
		// (get) Token: 0x06001043 RID: 4163 RVA: 0x00081024 File Offset: 0x0007F224
		int IJsonLineInfo.LineNumber
		{
			get
			{
				while (base.CurrentState != JsonReader.State.Start)
				{
					IJsonLineInfo jsonLineInfo = this.jtoken_2;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_75738dd4edc84122bfe3748a1ea03d43 == 0)
					{
						goto IL_001D;
					}
					IL_0032:
					switch (num)
					{
					case 1:
						goto IL_005A;
					case 2:
						return 0;
					case 3:
						continue;
					}
					IL_001D:
					if (jsonLineInfo == null)
					{
						return 0;
					}
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8f48544341da433d9f954b548c7e9212 == 0)
					{
						goto IL_0032;
					}
					IL_005A:
					return jsonLineInfo.LineNumber;
				}
				return 0;
			}
		}

		// Token: 0x1700025D RID: 605
		// (get) Token: 0x06001044 RID: 4164 RVA: 0x00081094 File Offset: 0x0007F294
		int IJsonLineInfo.LinePosition
		{
			get
			{
				IL_003C:
				while (base.CurrentState != JsonReader.State.Start)
				{
					IJsonLineInfo jsonLineInfo;
					for (;;)
					{
						jsonLineInfo = this.jtoken_2;
						int num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3a299c01dd4f4a209bdbd1b98e3f1406 == 0)
						{
							switch (num)
							{
							case 1:
								goto IL_0048;
							case 2:
								continue;
							case 3:
								goto IL_003C;
							case 4:
								return 0;
							case 5:
								return 0;
							}
							break;
						}
						goto IL_0047;
					}
					goto IL_004C;
					IL_0047:
					IL_0048:
					if (jsonLineInfo == null)
					{
						return 0;
					}
					IL_004C:
					return jsonLineInfo.LinePosition;
				}
				return 0;
			}
		}

		// Token: 0x1700025E RID: 606
		// (get) Token: 0x06001045 RID: 4165 RVA: 0x000810F8 File Offset: 0x0007F2F8
		public override string Path
		{
			get
			{
				string text;
				for (;;)
				{
					IL_00E7:
					text = base.Path;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4b8a72ce901241b5b52fe60600cb3607 != 0)
					{
						goto IL_0093;
					}
					for (;;)
					{
						IL_00AF:
						switch (num)
						{
						case 1:
							goto IL_00E7;
						case 2:
							goto IL_0080;
						case 3:
							goto IL_0103;
						case 4:
							goto IL_0014;
						case 5:
							goto IL_010D;
						case 6:
						case 7:
						case 11:
							return text;
						case 8:
							goto IL_006D;
						case 9:
							goto IL_004F;
						case 10:
							if (!text.StartsWith('['))
							{
								goto IL_0014;
							}
							goto IL_010D;
						}
						break;
						IL_0014:
						text = this.string_1 + Class15.smethod_17(642125650 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa29cbda752f45acbe81e7d5285df2ba) + text;
						num = 11;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5dadf4f8cc824060ae20e1ee9bbca82a != 0)
						{
							goto Block_1;
						}
					}
					goto IL_0093;
					IL_004F:
					if (StringUtils.IsNullOrEmpty(text))
					{
						goto IL_0103;
					}
					num = 10;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c367d9ce11cc43b595beeb4524149542 == 0)
					{
						goto IL_00AF;
					}
					IL_006D:
					if (StringUtils.IsNullOrEmpty(this.string_1))
					{
						break;
					}
					goto IL_004F;
					IL_0080:
					this.string_1 = this.jtoken_0.Path;
					goto IL_006D;
					IL_0093:
					if (this.string_1 != null)
					{
						goto IL_006D;
					}
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d6c400f349964629bcd869033695bff0 == 0)
					{
						goto IL_0080;
					}
					goto IL_00AF;
				}
				Block_1:
				return text;
				IL_0103:
				return this.string_1;
				IL_010D:
				text = this.string_1 + text;
				return text;
			}
		}

		// Token: 0x04000722 RID: 1826
		private readonly JToken jtoken_0;

		// Token: 0x04000723 RID: 1827
		[Nullable(2)]
		private string string_1;

		// Token: 0x04000724 RID: 1828
		[Nullable(2)]
		private JToken jtoken_1;

		// Token: 0x04000725 RID: 1829
		[Nullable(2)]
		private JToken jtoken_2;
	}
}
