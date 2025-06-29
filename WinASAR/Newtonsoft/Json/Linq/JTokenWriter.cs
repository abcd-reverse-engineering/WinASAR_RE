using System;
using System.Globalization;
using System.Numerics;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Linq
{
	// Token: 0x0200016C RID: 364
	[NullableContext(2)]
	[Nullable(0)]
	public class JTokenWriter : JsonWriter
	{
		// Token: 0x1700025F RID: 607
		// (get) Token: 0x06001049 RID: 4169 RVA: 0x00006669 File Offset: 0x00004869
		public JToken CurrentToken
		{
			get
			{
				return this.jtoken_0;
			}
		}

		// Token: 0x17000260 RID: 608
		// (get) Token: 0x0600104A RID: 4170 RVA: 0x00081224 File Offset: 0x0007F424
		public JToken Token
		{
			get
			{
				while (this.jcontainer_0 != null)
				{
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_75738dd4edc84122bfe3748a1ea03d43 != 0)
					{
						switch (num)
						{
						case 1:
							continue;
						}
					}
					return this.jcontainer_0;
				}
				return this.jvalue_0;
			}
		}

		// Token: 0x0600104B RID: 4171 RVA: 0x00081270 File Offset: 0x0007F470
		[NullableContext(1)]
		public JTokenWriter(JContainer container)
		{
			int num = 1;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_253407eb812c4aefb734fa1e267fe779 != 0)
			{
				goto IL_0037;
			}
			goto IL_007F;
			IL_001C:
			this.jcontainer_1 = container;
			num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_67cbcb2ad04040d48847c1ca2f65be32 == 0)
			{
				return;
			}
			goto IL_007F;
			IL_0037:
			ValidationUtils.ArgumentNotNull(container, Class15.smethod_17(635790365 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a41eabd4b99f489fb7d86310d3f95ba2));
			num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b17e63564ae246399767b60cf4b1528a == 0)
			{
				goto IL_007F;
			}
			IL_0064:
			this.jcontainer_0 = container;
			num = 3;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa29cbda752f45acbe81e7d5285df2ba != 0)
			{
				goto IL_001C;
			}
			IL_007F:
			switch (num)
			{
			case 0:
				goto IL_0064;
			case 1:
				goto IL_0037;
			case 2:
				break;
			case 3:
				goto IL_001C;
			default:
				goto IL_0064;
			}
		}

		// Token: 0x0600104C RID: 4172 RVA: 0x00081318 File Offset: 0x0007F518
		public JTokenWriter()
		{
			int num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4152404f503b492c83d9bc2e44bdd0a7 != 0)
			{
				switch (num)
				{
				}
			}
		}

		// Token: 0x0600104D RID: 4173 RVA: 0x00002420 File Offset: 0x00000620
		public override void Flush()
		{
		}

		// Token: 0x0600104E RID: 4174 RVA: 0x00006671 File Offset: 0x00004871
		public override void Close()
		{
			base.Close();
		}

		// Token: 0x0600104F RID: 4175 RVA: 0x0008134C File Offset: 0x0007F54C
		public override void WriteStartObject()
		{
			for (;;)
			{
				base.WriteStartObject();
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_48fe014748e848c88d3254f339047927 == 0)
				{
					goto IL_0003;
				}
				IL_001F:
				switch (num)
				{
				case 1:
					continue;
				case 2:
					return;
				}
				IL_0003:
				this.method_13(new JObject());
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_193800745ad94a529d9e5edc977c4f02 != 0)
				{
					goto IL_001F;
				}
				break;
			}
		}

		// Token: 0x06001050 RID: 4176 RVA: 0x000813A8 File Offset: 0x0007F5A8
		[NullableContext(1)]
		private void method_13(JContainer jcontainer_2)
		{
			for (;;)
			{
				IL_009E:
				if (this.jcontainer_1 != null)
				{
					goto IL_007C;
				}
				int num = 5;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f77f8ab5a3534e2e914063d52217b4e1 != 0)
				{
					goto IL_0061;
				}
				goto IL_003C;
				do
				{
					IL_0021:
					this.jtoken_0 = jcontainer_2;
					num = 2;
				}
				while (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0efaea2f67ca4b0aa2880fbd34fc0fff == 0);
				for (;;)
				{
					IL_003C:
					switch (num)
					{
					case 1:
					case 3:
						goto IL_0061;
					case 2:
						return;
					case 4:
						goto IL_007C;
					case 5:
						this.jcontainer_0 = jcontainer_2;
						num = 1;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b17e63564ae246399767b60cf4b1528a != 0)
						{
							goto Block_1;
						}
						continue;
					case 6:
						goto IL_009E;
					}
					goto Block_3;
				}
				Block_1:
				goto IL_0061;
				Block_3:
				goto IL_0021;
				IL_0061:
				this.jcontainer_1 = jcontainer_2;
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93c7140125045538ae5c40c6f39a5af != 0)
				{
					goto IL_0021;
				}
				goto IL_003C;
				IL_007C:
				this.jcontainer_1.AddAndSkipParentCheck(jcontainer_2);
				goto IL_0061;
			}
		}

		// Token: 0x06001051 RID: 4177 RVA: 0x00081460 File Offset: 0x0007F660
		private void method_14()
		{
			for (;;)
			{
				IL_0099:
				this.jtoken_0 = this.jcontainer_1;
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7ae4da5a55de471eb12dd0de8dd4269c != 0)
				{
					goto IL_0029;
				}
				for (;;)
				{
					IL_0075:
					switch (num)
					{
					case 1:
						goto IL_0099;
					case 2:
					case 6:
						return;
					case 3:
						goto IL_0056;
					case 4:
						goto IL_003A;
					case 5:
						this.jcontainer_1 = this.jcontainer_1.Parent;
						num = 2;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39f35935adc2477fa894750fee078177 != 0)
						{
							continue;
						}
						break;
					}
					break;
				}
				goto IL_0029;
				IL_003A:
				if (this.jcontainer_1 != null)
				{
					goto IL_0056;
				}
				num = 4;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8f48544341da433d9f954b548c7e9212 == 0)
				{
					break;
				}
				goto IL_0075;
				IL_0029:
				this.jcontainer_1 = this.jcontainer_1.Parent;
				goto IL_003A;
				IL_0056:
				if (this.jcontainer_1.Type != JTokenType.Property)
				{
					break;
				}
				num = 5;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3a299c01dd4f4a209bdbd1b98e3f1406 != 0)
				{
					goto IL_0075;
				}
				break;
			}
		}

		// Token: 0x06001052 RID: 4178 RVA: 0x00081530 File Offset: 0x0007F730
		public override void WriteStartArray()
		{
			for (;;)
			{
				base.WriteStartArray();
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_43b32b9d66294210a955990bb6fcc511 == 0)
				{
					goto IL_0003;
				}
				IL_001F:
				switch (num)
				{
				case 1:
					continue;
				case 2:
					return;
				}
				IL_0003:
				this.method_13(new JArray());
				num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_92ac2a37edba4e2587eb1b9e8af3f63f != 0)
				{
					goto IL_001F;
				}
				break;
			}
		}

		// Token: 0x06001053 RID: 4179 RVA: 0x0008158C File Offset: 0x0007F78C
		[NullableContext(1)]
		public override void WriteStartConstructor(string name)
		{
			for (;;)
			{
				base.WriteStartConstructor(name);
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4b8a72ce901241b5b52fe60600cb3607 != 0)
				{
					goto IL_0003;
				}
				IL_0020:
				switch (num)
				{
				case 1:
					continue;
				case 2:
					return;
				}
				IL_0003:
				this.method_13(new JConstructor(name));
				num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0b405dced5e94c80928a74c5773182d9 == 0)
				{
					goto IL_0020;
				}
			}
		}

		// Token: 0x06001054 RID: 4180 RVA: 0x00006679 File Offset: 0x00004879
		protected override void WriteEnd(JsonToken token)
		{
			this.method_14();
		}

		// Token: 0x06001055 RID: 4181 RVA: 0x000815EC File Offset: 0x0007F7EC
		[NullableContext(1)]
		public override void WritePropertyName(string name)
		{
			for (;;)
			{
				IL_0001:
				JObject jobject = this.jcontainer_1 as JObject;
				if (jobject != null)
				{
					jobject.Remove(name);
				}
				for (;;)
				{
					this.method_13(new JProperty(name));
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9f5329f120e842948536b8235793166c == 0)
					{
						goto IL_0033;
					}
					do
					{
						IL_0018:
						base.WritePropertyName(name);
						num = 1;
					}
					while (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a321d34f24314561b0d80437d5d859e8 == 0);
					IL_0033:
					switch (num)
					{
					case 0:
						goto IL_0018;
					case 1:
						return;
					case 2:
					case 4:
						break;
					case 3:
						goto IL_0001;
					default:
						goto IL_0018;
					}
				}
			}
		}

		// Token: 0x06001056 RID: 4182 RVA: 0x0008166C File Offset: 0x0007F86C
		private void method_15(object object_0, JTokenType jtokenType_0, JsonToken jsonToken_0)
		{
			for (;;)
			{
				this.method_16(new JValue(object_0, jtokenType_0), jsonToken_0);
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9f9b31fb7a85497499112abf86cccc98 != 0)
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

		// Token: 0x06001057 RID: 4183 RVA: 0x000816AC File Offset: 0x0007F8AC
		internal void method_16(JValue value, JsonToken token)
		{
			for (;;)
			{
				IL_00CD:
				if (this.jcontainer_1 != null)
				{
					goto IL_00A8;
				}
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_aa43e77a676848e0bd70abf647d6a9f1 == 0)
				{
					goto Block_6;
				}
				for (;;)
				{
					IL_0053:
					switch (num)
					{
					case 1:
						goto IL_0083;
					case 2:
						goto IL_00EE;
					case 3:
						goto IL_00DE;
					case 4:
						goto IL_00CD;
					case 5:
					case 6:
						return;
					case 7:
						goto IL_00A8;
					case 8:
						if (this.jcontainer_1.Type != JTokenType.Property)
						{
							return;
						}
						num = 9;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_11c6824de6514281a8425f6d6ab1a2d5 == 0)
						{
							continue;
						}
						return;
					case 9:
						this.jcontainer_1 = this.jcontainer_1.Parent;
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7af5c533f30e4bd1bda86ce6098441d2 != 0)
						{
							continue;
						}
						break;
					}
					goto Block_3;
				}
				IL_0083:
				this.jtoken_0 = this.jcontainer_1.Last;
				num = 8;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_871a407507f34aa3b5bf52517d4f63a9 == 0)
				{
					goto Block_4;
				}
				goto IL_0053;
				IL_00A8:
				if (!this.jcontainer_1.TryAdd(value))
				{
					goto Block_5;
				}
				goto IL_0083;
			}
			Block_3:
			return;
			Block_4:
			Block_5:
			return;
			Block_6:
			IL_00DE:
			this.jvalue_0 = value ?? JValue.CreateNull();
			IL_00EE:
			this.jtoken_0 = this.jvalue_0;
		}

		// Token: 0x06001058 RID: 4184 RVA: 0x000817B8 File Offset: 0x0007F9B8
		public override void WriteValue(object value)
		{
			while (value is BigInteger)
			{
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_67cbcb2ad04040d48847c1ca2f65be32 != 0)
				{
					goto IL_0015;
				}
				IL_002D:
				switch (num)
				{
				case 1:
					continue;
				case 2:
					goto IL_0055;
				case 3:
					return;
				case 4:
					return;
				}
				IL_0015:
				base.InternalWriteValue(JsonToken.Integer);
				num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b3c865ee224546b18f2991d2a8895f6a != 0)
				{
					goto IL_002D;
				}
				IL_0055:
				this.method_15(value, JTokenType.Integer, JsonToken.Integer);
				return;
			}
			base.WriteValue(value);
		}

		// Token: 0x06001059 RID: 4185 RVA: 0x0008182C File Offset: 0x0007FA2C
		public override void WriteNull()
		{
			for (;;)
			{
				base.WriteNull();
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_afb77be96d644a2297c7f9466cb06ede == 0)
				{
					goto IL_0003;
				}
				IL_0021:
				switch (num)
				{
				case 1:
					IL_0003:
					this.method_16(JValue.CreateNull(), JsonToken.Null);
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_079bd9b874b24353bef46f6c3f5d741d == 0)
					{
						goto IL_0021;
					}
					break;
				case 2:
					continue;
				}
				break;
			}
		}

		// Token: 0x0600105A RID: 4186 RVA: 0x0008188C File Offset: 0x0007FA8C
		public override void WriteUndefined()
		{
			for (;;)
			{
				base.WriteUndefined();
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d9581c727fcc4f50accd4f5de0d386f5 != 0)
				{
					goto IL_0003;
				}
				IL_0021:
				switch (num)
				{
				case 1:
					continue;
				case 2:
					return;
				}
				IL_0003:
				this.method_16(JValue.CreateUndefined(), JsonToken.Undefined);
				num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39d5fbfa4fe34ed9908db538e5340a6c != 0)
				{
					goto IL_0021;
				}
			}
		}

		// Token: 0x0600105B RID: 4187 RVA: 0x000818EC File Offset: 0x0007FAEC
		public override void WriteRaw(string json)
		{
			for (;;)
			{
				IL_0035:
				base.WriteRaw(json);
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_eaded84ad5b14e1ea8d4d97bfed1bb48 == 0)
				{
					break;
				}
				for (;;)
				{
					switch (num)
					{
					case 1:
						this.method_16(new JRaw(json), JsonToken.Raw);
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9f5329f120e842948536b8235793166c != 0)
						{
							continue;
						}
						break;
					case 2:
						goto IL_0035;
					}
					return;
				}
			}
		}

		// Token: 0x0600105C RID: 4188 RVA: 0x0008194C File Offset: 0x0007FB4C
		public override void WriteComment(string text)
		{
			for (;;)
			{
				base.WriteComment(text);
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c08ab7af63da4f24a4fa3e9c7a732fae != 0)
				{
					goto IL_0003;
				}
				IL_0021:
				switch (num)
				{
				case 1:
					IL_0003:
					this.method_16(JValue.CreateComment(text), JsonToken.Comment);
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cf58136e49114a5691c4a9d0e9788de1 != 0)
					{
						goto IL_0021;
					}
					break;
				case 2:
					continue;
				}
				break;
			}
		}

		// Token: 0x0600105D RID: 4189 RVA: 0x000819AC File Offset: 0x0007FBAC
		public override void WriteValue(string value)
		{
			while (value != null)
			{
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_991c06e999c744809f5b643cb7d9e7b4 == 0)
				{
					goto IL_0015;
				}
				IL_002D:
				switch (num)
				{
				case 1:
					continue;
				case 2:
					goto IL_0054;
				case 3:
					return;
				case 4:
					goto IL_0063;
				case 5:
					return;
				}
				IL_0015:
				base.WriteValue(value);
				num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e764f065c2fa404a85129e2e957d4f18 == 0)
				{
					goto IL_002D;
				}
				IL_0054:
				this.method_16(new JValue(value), JsonToken.String);
				return;
			}
			IL_0063:
			this.WriteNull();
		}

		// Token: 0x0600105E RID: 4190 RVA: 0x00081A24 File Offset: 0x0007FC24
		public override void WriteValue(int value)
		{
			for (;;)
			{
				base.WriteValue(value);
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_afb77be96d644a2297c7f9466cb06ede == 0)
				{
					goto IL_0003;
				}
				IL_0022:
				switch (num)
				{
				case 1:
					IL_0003:
					this.method_15(value, JTokenType.Integer, JsonToken.Integer);
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_186d640068094cc595a341ef95c9a29a != 0)
					{
						goto IL_0022;
					}
					break;
				case 2:
					continue;
				}
				break;
			}
		}

		// Token: 0x0600105F RID: 4191 RVA: 0x00081A84 File Offset: 0x0007FC84
		[CLSCompliant(false)]
		public override void WriteValue(uint value)
		{
			for (;;)
			{
				IL_0036:
				base.WriteValue(value);
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5c76a4eb2c1748d1bee3513c8eaff2eb == 0)
				{
					break;
				}
				for (;;)
				{
					switch (num)
					{
					case 1:
						this.method_15(value, JTokenType.Integer, JsonToken.Integer);
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8db627a8c96145a0afb24deffd2a8808 == 0)
						{
							continue;
						}
						break;
					case 2:
						goto IL_0036;
					}
					return;
				}
			}
		}

		// Token: 0x06001060 RID: 4192 RVA: 0x00081AE4 File Offset: 0x0007FCE4
		public override void WriteValue(long value)
		{
			for (;;)
			{
				IL_0035:
				base.WriteValue(value);
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4ac69ea2381b403582a2723337f67fa8 == 0)
				{
					break;
				}
				for (;;)
				{
					switch (num)
					{
					case 1:
						this.method_16(new JValue(value), JsonToken.Integer);
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3a299c01dd4f4a209bdbd1b98e3f1406 != 0)
						{
							continue;
						}
						break;
					case 2:
						goto IL_0035;
					}
					return;
				}
			}
		}

		// Token: 0x06001061 RID: 4193 RVA: 0x00081B44 File Offset: 0x0007FD44
		[CLSCompliant(false)]
		public override void WriteValue(ulong value)
		{
			for (;;)
			{
				base.WriteValue(value);
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8bcabc342a5a44748f3978da7f62051e == 0)
				{
					goto IL_0003;
				}
				IL_0021:
				switch (num)
				{
				case 1:
					IL_0003:
					this.method_16(new JValue(value), JsonToken.Integer);
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_676b866782704933888a7440512fd4ff == 0)
					{
						goto IL_0021;
					}
					break;
				case 2:
					continue;
				}
				break;
			}
		}

		// Token: 0x06001062 RID: 4194 RVA: 0x00081BA4 File Offset: 0x0007FDA4
		public override void WriteValue(float value)
		{
			for (;;)
			{
				IL_0035:
				base.WriteValue(value);
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ee35a23edd8f4998990ec1a2b40fc61a == 0)
				{
					break;
				}
				for (;;)
				{
					switch (num)
					{
					case 1:
						this.method_16(new JValue(value), JsonToken.Float);
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9bd9937edf9d4ad8bd673dfcb5a5e3cb != 0)
						{
							continue;
						}
						break;
					case 2:
						goto IL_0035;
					}
					return;
				}
			}
		}

		// Token: 0x06001063 RID: 4195 RVA: 0x00081C04 File Offset: 0x0007FE04
		public override void WriteValue(double value)
		{
			for (;;)
			{
				base.WriteValue(value);
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bd75de9a0b64d6da3a43e57303102f1 != 0)
				{
					goto IL_0003;
				}
				IL_0021:
				switch (num)
				{
				case 1:
					IL_0003:
					this.method_16(new JValue(value), JsonToken.Float);
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d97e64d0f425406b9649f2b4562a5f0e == 0)
					{
						goto IL_0021;
					}
					break;
				case 2:
					continue;
				}
				break;
			}
		}

		// Token: 0x06001064 RID: 4196 RVA: 0x00081C64 File Offset: 0x0007FE64
		public override void WriteValue(bool value)
		{
			for (;;)
			{
				IL_0036:
				base.WriteValue(value);
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_db7740c6ca7a4f3c8e1aa526bdb0a454 == 0)
				{
					break;
				}
				for (;;)
				{
					switch (num)
					{
					case 1:
						this.method_16(new JValue(value), JsonToken.Boolean);
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3a299c01dd4f4a209bdbd1b98e3f1406 != 0)
						{
							continue;
						}
						break;
					case 2:
						goto IL_0036;
					}
					return;
				}
			}
		}

		// Token: 0x06001065 RID: 4197 RVA: 0x00081CC4 File Offset: 0x0007FEC4
		public override void WriteValue(short value)
		{
			for (;;)
			{
				base.WriteValue(value);
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4152404f503b492c83d9bc2e44bdd0a7 != 0)
				{
					goto IL_0003;
				}
				IL_0022:
				switch (num)
				{
				case 1:
					continue;
				case 2:
					return;
				}
				IL_0003:
				this.method_15(value, JTokenType.Integer, JsonToken.Integer);
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_370349efcd7c4959a098549c3d5bf14d == 0)
				{
					goto IL_0022;
				}
				break;
			}
		}

		// Token: 0x06001066 RID: 4198 RVA: 0x00081D24 File Offset: 0x0007FF24
		[CLSCompliant(false)]
		public override void WriteValue(ushort value)
		{
			for (;;)
			{
				IL_0036:
				base.WriteValue(value);
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c27e9fccdfcc44999155a4980faa4e81 == 0)
				{
					break;
				}
				for (;;)
				{
					switch (num)
					{
					case 1:
						this.method_15(value, JTokenType.Integer, JsonToken.Integer);
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_253407eb812c4aefb734fa1e267fe779 != 0)
						{
							continue;
						}
						break;
					case 2:
						goto IL_0036;
					}
					return;
				}
			}
		}

		// Token: 0x06001067 RID: 4199 RVA: 0x00081D84 File Offset: 0x0007FF84
		public override void WriteValue(char value)
		{
			string text;
			for (;;)
			{
				base.WriteValue(value);
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ae8c3d3c66a64b57beca0f5360302062 != 0)
				{
					goto IL_0003;
				}
				IL_0022:
				switch (num)
				{
				case 1:
					continue;
				case 2:
					goto IL_0056;
				case 3:
					return;
				}
				IL_0003:
				text = value.ToString(CultureInfo.InvariantCulture);
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5dadf4f8cc824060ae20e1ee9bbca82a != 0)
				{
					goto IL_0022;
				}
				break;
			}
			IL_0056:
			this.method_16(new JValue(text), JsonToken.String);
		}

		// Token: 0x06001068 RID: 4200 RVA: 0x00081DF8 File Offset: 0x0007FFF8
		public override void WriteValue(byte value)
		{
			for (;;)
			{
				base.WriteValue(value);
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_92ac2a37edba4e2587eb1b9e8af3f63f == 0)
				{
					goto IL_0003;
				}
				IL_0022:
				switch (num)
				{
				case 1:
					continue;
				case 2:
					return;
				}
				IL_0003:
				this.method_15(value, JTokenType.Integer, JsonToken.Integer);
				num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2e3be65f7cb2480482903dc73ec42f7c != 0)
				{
					goto IL_0022;
				}
				break;
			}
		}

		// Token: 0x06001069 RID: 4201 RVA: 0x00081E58 File Offset: 0x00080058
		[CLSCompliant(false)]
		public override void WriteValue(sbyte value)
		{
			for (;;)
			{
				base.WriteValue(value);
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fd59e876ac704e7eaa7c7a24a9b3a23f == 0)
				{
					goto IL_0003;
				}
				IL_0022:
				switch (num)
				{
				case 1:
					IL_0003:
					this.method_15(value, JTokenType.Integer, JsonToken.Integer);
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3bf07bb1c323490cb457eef2b2e78695 != 0)
					{
						goto IL_0022;
					}
					break;
				case 2:
					continue;
				}
				break;
			}
		}

		// Token: 0x0600106A RID: 4202 RVA: 0x00081EB8 File Offset: 0x000800B8
		public override void WriteValue(decimal value)
		{
			for (;;)
			{
				base.WriteValue(value);
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_100d09ce3850492c8356d7fa1e667d54 == 0)
				{
					goto IL_0003;
				}
				IL_0021:
				switch (num)
				{
				case 1:
					IL_0003:
					this.method_16(new JValue(value), JsonToken.Float);
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_548c52e5632b45898e377ad9c9a06469 == 0)
					{
						goto IL_0021;
					}
					break;
				case 2:
					continue;
				}
				break;
			}
		}

		// Token: 0x0600106B RID: 4203 RVA: 0x00081F18 File Offset: 0x00080118
		public override void WriteValue(DateTime value)
		{
			for (;;)
			{
				base.WriteValue(value);
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_eaded84ad5b14e1ea8d4d97bfed1bb48 != 0)
				{
					goto IL_0003;
				}
				IL_0022:
				switch (num)
				{
				case 1:
					continue;
				case 2:
					goto IL_0056;
				case 3:
					return;
				}
				IL_0003:
				value = DateTimeUtils.EnsureDateTime(value, base.DateTimeZoneHandling);
				num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8db627a8c96145a0afb24deffd2a8808 != 0)
				{
					goto IL_0022;
				}
			}
			IL_0056:
			this.method_16(new JValue(value), JsonToken.Date);
		}

		// Token: 0x0600106C RID: 4204 RVA: 0x00081F8C File Offset: 0x0008018C
		public override void WriteValue(DateTimeOffset value)
		{
			for (;;)
			{
				IL_0036:
				base.WriteValue(value);
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d5af2cccac2f47ed978e804138a35d1c == 0)
				{
					break;
				}
				for (;;)
				{
					switch (num)
					{
					case 1:
						this.method_16(new JValue(value), JsonToken.Date);
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_eaded84ad5b14e1ea8d4d97bfed1bb48 != 0)
						{
							continue;
						}
						break;
					case 2:
						goto IL_0036;
					}
					return;
				}
			}
		}

		// Token: 0x0600106D RID: 4205 RVA: 0x00081FEC File Offset: 0x000801EC
		public override void WriteValue(byte[] value)
		{
			for (;;)
			{
				base.WriteValue(value);
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7af5c533f30e4bd1bda86ce6098441d2 == 0)
				{
					goto IL_0003;
				}
				IL_0024:
				switch (num)
				{
				case 1:
					continue;
				case 2:
					return;
				}
				IL_0003:
				this.method_16(new JValue(value, JTokenType.Bytes), JsonToken.Bytes);
				num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_548c52e5632b45898e377ad9c9a06469 != 0)
				{
					goto IL_0024;
				}
				break;
			}
		}

		// Token: 0x0600106E RID: 4206 RVA: 0x00082050 File Offset: 0x00080250
		public override void WriteValue(TimeSpan value)
		{
			for (;;)
			{
				IL_0036:
				base.WriteValue(value);
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ca6ac77a767741aa91cb31f8080f093b != 0)
				{
					break;
				}
				for (;;)
				{
					switch (num)
					{
					case 1:
						this.method_16(new JValue(value), JsonToken.String);
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d97e64d0f425406b9649f2b4562a5f0e != 0)
						{
							continue;
						}
						break;
					case 2:
						goto IL_0036;
					}
					return;
				}
			}
		}

		// Token: 0x0600106F RID: 4207 RVA: 0x000820B0 File Offset: 0x000802B0
		public override void WriteValue(Guid value)
		{
			for (;;)
			{
				base.WriteValue(value);
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7ae4da5a55de471eb12dd0de8dd4269c == 0)
				{
					goto IL_0003;
				}
				IL_0022:
				switch (num)
				{
				case 1:
					continue;
				case 2:
					return;
				}
				IL_0003:
				this.method_16(new JValue(value), JsonToken.String);
				num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_991c06e999c744809f5b643cb7d9e7b4 != 0)
				{
					goto IL_0022;
				}
			}
		}

		// Token: 0x06001070 RID: 4208 RVA: 0x00082110 File Offset: 0x00080310
		public override void WriteValue(Uri value)
		{
			for (;;)
			{
				base.WriteValue(value);
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0361b8eb39074ea88f5257b13904930a != 0)
				{
					goto IL_0003;
				}
				IL_0022:
				switch (num)
				{
				case 1:
					IL_0003:
					this.method_16(new JValue(value), JsonToken.String);
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa29cbda752f45acbe81e7d5285df2ba != 0)
					{
						goto IL_0022;
					}
					break;
				case 2:
					continue;
				}
				break;
			}
		}

		// Token: 0x06001071 RID: 4209 RVA: 0x00082170 File Offset: 0x00080370
		[NullableContext(1)]
		internal override void WriteToken(JsonReader reader, bool writeChildren, bool writeDateConstructorAsDate, bool writeComments)
		{
			for (;;)
			{
				IL_0230:
				JTokenReader jtokenReader = reader as JTokenReader;
				for (;;)
				{
					IL_021C:
					int num;
					if (jtokenReader != null && writeChildren && writeDateConstructorAsDate && writeComments)
					{
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a41eabd4b99f489fb7d86310d3f95ba2 == 0)
						{
							goto IL_0189;
						}
					}
					else
					{
						base.WriteToken(reader, writeChildren, writeDateConstructorAsDate, writeComments);
						num = 15;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_370349efcd7c4959a098549c3d5bf14d == 0)
						{
							goto IL_009C;
						}
					}
					JToken jtoken;
					for (;;)
					{
						IL_01A9:
						switch (num)
						{
						case 1:
							goto IL_0069;
						case 2:
						case 6:
							goto IL_009C;
						case 3:
							goto IL_0104;
						case 4:
							return;
						case 5:
							goto IL_0035;
						case 7:
							goto IL_00E2;
						case 8:
							goto IL_0046;
						case 9:
							goto IL_00C5;
						case 10:
							if (jtokenReader.Read())
							{
								goto IL_0178;
							}
							num = 4;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ca6ac77a767741aa91cb31f8080f093b == 0)
							{
								goto Block_10;
							}
							continue;
						case 11:
							goto IL_014A;
						case 12:
						case 18:
							goto IL_012B;
						case 13:
							goto IL_007A;
						case 14:
							return;
						case 15:
							return;
						case 16:
							goto IL_021C;
						case 17:
							goto IL_0230;
						case 19:
							if (this.jcontainer_0 == null)
							{
								goto IL_00C5;
							}
							goto IL_009C;
						case 20:
							goto IL_0028;
						}
						break;
						IL_00C5:
						if (this.jvalue_0 != null)
						{
							goto IL_009C;
						}
						num = 7;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8db627a8c96145a0afb24deffd2a8808 != 0)
						{
							continue;
						}
						IL_00E2:
						this.jcontainer_0 = jtoken as JContainer;
						num = 3;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_67cbcb2ad04040d48847c1ca2f65be32 == 0)
						{
							goto IL_0104;
						}
					}
					goto IL_0189;
					IL_0046:
					if (this.jcontainer_1.Type != JTokenType.Property)
					{
						goto IL_009C;
					}
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2e3be65f7cb2480482903dc73ec42f7c == 0)
					{
						goto IL_0069;
					}
					goto IL_01A9;
					IL_0035:
					this.jtoken_0 = this.jcontainer_1.Last;
					goto IL_0046;
					IL_0028:
					this.jcontainer_1.Add(jtoken);
					goto IL_0035;
					IL_014A:
					if (this.jcontainer_1 == null)
					{
						goto IL_012B;
					}
					goto IL_0028;
					IL_0178:
					jtoken = jtokenReader.CurrentToken.CloneToken(null);
					goto IL_014A;
					IL_0189:
					if (jtokenReader.TokenType != JsonToken.None)
					{
						goto IL_0178;
					}
					num = 10;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_991c06e999c744809f5b643cb7d9e7b4 == 0)
					{
						goto IL_0104;
					}
					goto IL_01A9;
					IL_007A:
					base.InternalWriteValue(JsonToken.Null);
					num = 6;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8db627a8c96145a0afb24deffd2a8808 == 0)
					{
						goto Block_3;
					}
					goto IL_01A9;
					IL_0069:
					this.jcontainer_1 = this.jcontainer_1.Parent;
					goto IL_007A;
					IL_009C:
					jtokenReader.Skip();
					num = 12;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_52d717cd31b74287b67c03ee736a6211 == 0)
					{
						goto Block_4;
					}
					goto IL_01A9;
					IL_0104:
					this.jvalue_0 = jtoken as JValue;
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b3c865ee224546b18f2991d2a8895f6a == 0)
					{
						goto IL_009C;
					}
					goto IL_01A9;
					IL_012B:
					this.jtoken_0 = jtoken;
					num = 19;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e6fac70dd3e841b6925374855ecd7fb1 != 0)
					{
						goto Block_7;
					}
					goto IL_01A9;
				}
			}
			Block_3:
			return;
			Block_4:
			Block_7:
			return;
			Block_10:;
		}

		// Token: 0x0400073A RID: 1850
		private JContainer jcontainer_0;

		// Token: 0x0400073B RID: 1851
		private JContainer jcontainer_1;

		// Token: 0x0400073C RID: 1852
		private JValue jvalue_0;

		// Token: 0x0400073D RID: 1853
		private JToken jtoken_0;
	}
}
