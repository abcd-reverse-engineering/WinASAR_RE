using System;
using System.Globalization;
using System.IO;
using System.Numerics;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Bson
{
	// Token: 0x020001C6 RID: 454
	[Obsolete("BSON reading and writing has been moved to its own package. See https://www.nuget.org/packages/Newtonsoft.Json.Bson for more details.")]
	public class BsonWriter : JsonWriter
	{
		// Token: 0x170002ED RID: 749
		// (get) Token: 0x060013C1 RID: 5057 RVA: 0x0000707D File Offset: 0x0000527D
		// (set) Token: 0x060013C2 RID: 5058 RVA: 0x0009A520 File Offset: 0x00098720
		public DateTimeKind DateTimeKindHandling
		{
			get
			{
				return this.LpIuobxlwm.DateTimeKindHandling;
			}
			set
			{
				for (;;)
				{
					this.LpIuobxlwm.DateTimeKindHandling = value;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ca6ac77a767741aa91cb31f8080f093b == 0)
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

		// Token: 0x060013C3 RID: 5059 RVA: 0x0009A55C File Offset: 0x0009875C
		public BsonWriter(Stream stream)
		{
			int num = 1;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_193800745ad94a529d9e5edc977c4f02 == 0)
			{
				goto IL_0041;
			}
			goto IL_005E;
			IL_001C:
			this.LpIuobxlwm = new BsonBinaryWriter(new BinaryWriter(stream));
			num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c08ab7af63da4f24a4fa3e9c7a732fae == 0)
			{
				return;
			}
			goto IL_005E;
			IL_0041:
			ValidationUtils.ArgumentNotNull(stream, Class15.smethod_17(2008609307 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5c76a4eb2c1748d1bee3513c8eaff2eb));
			goto IL_001C;
			IL_005E:
			switch (num)
			{
			case 1:
				goto IL_0041;
			case 2:
				goto IL_001C;
			}
		}

		// Token: 0x060013C4 RID: 5060 RVA: 0x0009A5DC File Offset: 0x000987DC
		public BsonWriter(BinaryWriter writer)
		{
			int num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3a102d6e4dd542a6855b81a93c692545 != 0)
			{
				goto IL_0064;
			}
			IL_001A:
			ValidationUtils.ArgumentNotNull(writer, Class15.smethod_17(1603828684 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d5af2cccac2f47ed978e804138a35d1c));
			num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa29cbda752f45acbe81e7d5285df2ba != 0)
			{
				goto IL_0064;
			}
			IL_0047:
			this.LpIuobxlwm = new BsonBinaryWriter(writer);
			num = 2;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3a299c01dd4f4a209bdbd1b98e3f1406 == 0)
			{
				return;
			}
			IL_0064:
			switch (num)
			{
			case 0:
				goto IL_0047;
			case 1:
				goto IL_001A;
			case 2:
				break;
			default:
				goto IL_0047;
			}
		}

		// Token: 0x060013C5 RID: 5061 RVA: 0x0009A664 File Offset: 0x00098864
		public override void Flush()
		{
			for (;;)
			{
				this.LpIuobxlwm.Flush();
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_1db17fe7bd2442b599c52df89f39e610 != 0)
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

		// Token: 0x060013C6 RID: 5062 RVA: 0x0009A6A0 File Offset: 0x000988A0
		protected override void WriteEnd(JsonToken token)
		{
			for (;;)
			{
				IL_0073:
				base.WriteEnd(token);
				for (;;)
				{
					IL_005B:
					this.method_14();
					int num = 4;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bd75de9a0b64d6da3a43e57303102f1 == 0)
					{
						break;
					}
					for (;;)
					{
						switch (num)
						{
						case 1:
							goto IL_001D;
						case 2:
							goto IL_005B;
						case 3:
							goto IL_0073;
						case 4:
							if (base.Top == 0)
							{
								num = 1;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93c7140125045538ae5c40c6f39a5af == 0)
								{
									goto IL_001D;
								}
								continue;
							}
							break;
						}
						return;
						IL_001D:
						this.LpIuobxlwm.WriteToken(this.bsonToken_0);
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_eaded84ad5b14e1ea8d4d97bfed1bb48 != 0)
						{
							return;
						}
					}
				}
			}
		}

		// Token: 0x060013C7 RID: 5063 RVA: 0x0000708A File Offset: 0x0000528A
		public override void WriteComment(string text)
		{
			throw JsonWriterException.Create(this, Class15.smethod_17(1270960868 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0005996a6a494de4880ac2956b2e0112), null);
		}

		// Token: 0x060013C8 RID: 5064 RVA: 0x000070A8 File Offset: 0x000052A8
		public override void WriteStartConstructor(string name)
		{
			throw JsonWriterException.Create(this, Class15.smethod_17(1793911436 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0361b8eb39074ea88f5257b13904930a), null);
		}

		// Token: 0x060013C9 RID: 5065 RVA: 0x000070C6 File Offset: 0x000052C6
		public override void WriteRaw(string json)
		{
			throw JsonWriterException.Create(this, Class15.smethod_17(1424601894 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bca7529ca324c188cfc0e64eb7d1cdf), null);
		}

		// Token: 0x060013CA RID: 5066 RVA: 0x000070E4 File Offset: 0x000052E4
		public override void WriteRawValue(string json)
		{
			throw JsonWriterException.Create(this, Class15.smethod_17(1788652818 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bd75de9a0b64d6da3a43e57303102f1), null);
		}

		// Token: 0x060013CB RID: 5067 RVA: 0x0009A72C File Offset: 0x0009892C
		public override void WriteStartArray()
		{
			for (;;)
			{
				base.WriteStartArray();
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bd75de9a0b64d6da3a43e57303102f1 != 0)
				{
					goto IL_0003;
				}
				IL_001F:
				switch (num)
				{
				case 1:
					IL_0003:
					this.method_13(new BsonArray());
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa49bb51056944098afe92e3a80a544b != 0)
					{
						goto IL_001F;
					}
					break;
				case 2:
					continue;
				}
				break;
			}
		}

		// Token: 0x060013CC RID: 5068 RVA: 0x0009A788 File Offset: 0x00098988
		public override void WriteStartObject()
		{
			for (;;)
			{
				base.WriteStartObject();
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ee35a23edd8f4998990ec1a2b40fc61a == 0)
				{
					goto IL_0003;
				}
				IL_001F:
				switch (num)
				{
				case 1:
					IL_0003:
					this.method_13(new BsonObject());
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8d68b74cee6442019d959192b2974e3d == 0)
					{
						goto IL_001F;
					}
					break;
				case 2:
					continue;
				}
				break;
			}
		}

		// Token: 0x060013CD RID: 5069 RVA: 0x0009A7E4 File Offset: 0x000989E4
		public override void WritePropertyName(string name)
		{
			for (;;)
			{
				base.WritePropertyName(name);
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8d68b74cee6442019d959192b2974e3d == 0)
				{
					goto IL_0003;
				}
				IL_001B:
				switch (num)
				{
				case 1:
					IL_0003:
					this.string_1 = name;
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2a74c5ebb7d84adcad853e2eda393dc4 != 0)
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

		// Token: 0x060013CE RID: 5070 RVA: 0x0009A83C File Offset: 0x00098A3C
		public override void Close()
		{
			for (;;)
			{
				base.Close();
				int num = 3;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_100d09ce3850492c8356d7fa1e667d54 != 0)
				{
					goto IL_0003;
				}
				IL_003F:
				switch (num)
				{
				case 1:
					return;
				case 2:
					goto IL_000B;
				case 3:
					IL_0003:
					if (base.CloseOutput)
					{
						goto IL_000B;
					}
					return;
				case 4:
					continue;
				}
				break;
				IL_000B:
				BsonBinaryWriter lpIuobxlwm = this.LpIuobxlwm;
				if (lpIuobxlwm == null)
				{
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3a102d6e4dd542a6855b81a93c692545 != 0)
					{
						break;
					}
					goto IL_003F;
				}
				else
				{
					lpIuobxlwm.Close();
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_548c52e5632b45898e377ad9c9a06469 == 0)
					{
						goto IL_003F;
					}
					break;
				}
			}
		}

		// Token: 0x060013CF RID: 5071 RVA: 0x0009A8C4 File Offset: 0x00098AC4
		private void method_13(BsonToken bsonToken_2)
		{
			for (;;)
			{
				this.AddToken(bsonToken_2);
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_92ac2a37edba4e2587eb1b9e8af3f63f == 0)
				{
					goto IL_0003;
				}
				IL_001B:
				switch (num)
				{
				case 1:
					continue;
				case 2:
					return;
				}
				IL_0003:
				this.bsonToken_1 = bsonToken_2;
				num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_1d8dbb531d7349c0bc15bad339f7815c != 0)
				{
					goto IL_001B;
				}
				break;
			}
		}

		// Token: 0x060013D0 RID: 5072 RVA: 0x0009A91C File Offset: 0x00098B1C
		private void method_14()
		{
			for (;;)
			{
				this.bsonToken_1 = this.bsonToken_1.Parent;
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cf58136e49114a5691c4a9d0e9788de1 == 0)
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

		// Token: 0x060013D1 RID: 5073 RVA: 0x0009A960 File Offset: 0x00098B60
		private void method_15(object object_0, BsonType bsonType_0)
		{
			for (;;)
			{
				this.AddToken(new BsonValue(object_0, bsonType_0));
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2a74c5ebb7d84adcad853e2eda393dc4 == 0)
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

		// Token: 0x060013D2 RID: 5074 RVA: 0x0009A9A0 File Offset: 0x00098BA0
		internal void AddToken(BsonToken token)
		{
			for (;;)
			{
				int num;
				if (this.bsonToken_1 != null)
				{
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_aa43e77a676848e0bd70abf647d6a9f1 != 0)
					{
						goto IL_0099;
					}
					goto IL_00BA;
				}
				else if (token.Type == BsonType.Object)
				{
					goto IL_0157;
				}
				IL_00EE:
				if (token.Type == BsonType.Array)
				{
					goto IL_0157;
				}
				num = 5;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_253407eb812c4aefb734fa1e267fe779 != 0)
				{
					continue;
				}
				IL_00BA:
				switch (num)
				{
				case 0:
					goto IL_0099;
				case 1:
					continue;
				case 2:
					goto IL_0072;
				case 3:
					return;
				case 4:
					return;
				case 5:
					goto IL_0122;
				case 6:
					return;
				case 7:
					break;
				case 8:
					goto IL_0032;
				case 9:
					goto IL_015E;
				case 10:
					goto IL_00EE;
				default:
					goto IL_0099;
				}
				IL_0050:
				BsonObject bsonObject;
				bsonObject.Add(this.string_1, token);
				num = 6;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7ae4da5a55de471eb12dd0de8dd4269c == 0)
				{
					goto IL_0032;
				}
				goto IL_00BA;
				IL_0072:
				if (bsonObject != null)
				{
					goto IL_0050;
				}
				((BsonArray)this.bsonToken_1).Add(token);
				num = 6;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c5a086ee5649458eb5e1e6e4f0f1f4d3 == 0)
				{
					goto IL_0099;
				}
				goto IL_00BA;
				IL_0032:
				this.string_1 = null;
				num = 3;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_01137da6c88c4265bdc0297aacf3340f == 0)
				{
					break;
				}
				goto IL_00BA;
				IL_0099:
				bsonObject = this.bsonToken_1 as BsonObject;
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_bc7a9075386042ad9ce36653fcde3fc3 == 0)
				{
					goto IL_0072;
				}
				goto IL_00BA;
			}
			return;
			IL_0122:
			throw JsonWriterException.Create(this, Class15.smethod_17(676686486 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa49bb51056944098afe92e3a80a544b).FormatWith(CultureInfo.InvariantCulture, token.Type), null);
			IL_0157:
			this.bsonToken_1 = token;
			IL_015E:
			this.bsonToken_0 = token;
		}

		// Token: 0x060013D3 RID: 5075 RVA: 0x0009AB14 File Offset: 0x00098D14
		public override void WriteValue(object value)
		{
			BigInteger bigInteger;
			for (;;)
			{
				if (value is BigInteger)
				{
					goto IL_001E;
				}
				base.WriteValue(value);
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3dc45d1ecdeb4859b7f470093f5eeed2 != 0)
				{
					break;
				}
				IL_0051:
				switch (num)
				{
				case 1:
					return;
				case 2:
					goto IL_0038;
				case 3:
					return;
				case 4:
					IL_001E:
					bigInteger = (BigInteger)value;
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cbfb1e54efd84756a9b6d7b21adc0d65 == 0)
					{
						goto IL_0038;
					}
					goto IL_0051;
				case 5:
					continue;
				}
				break;
				IL_0038:
				base.SetWriteState(JsonToken.Integer, null);
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa49bb51056944098afe92e3a80a544b == 0)
				{
					goto IL_0051;
				}
				break;
			}
			this.AddToken(new BsonBinary(bigInteger.ToByteArray(), BsonBinaryType.Binary));
		}

		// Token: 0x060013D4 RID: 5076 RVA: 0x0009ABB8 File Offset: 0x00098DB8
		public override void WriteNull()
		{
			for (;;)
			{
				base.WriteNull();
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a5994720d09542abb897ebf6ad9b5a19 != 0)
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
				this.AddToken(BsonEmpty.Null);
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5dadf4f8cc824060ae20e1ee9bbca82a != 0)
				{
					goto IL_001F;
				}
				break;
			}
		}

		// Token: 0x060013D5 RID: 5077 RVA: 0x0009AC14 File Offset: 0x00098E14
		public override void WriteUndefined()
		{
			for (;;)
			{
				base.WriteUndefined();
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_253407eb812c4aefb734fa1e267fe779 == 0)
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
				this.AddToken(BsonEmpty.Undefined);
				num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5c76a4eb2c1748d1bee3513c8eaff2eb != 0)
				{
					goto IL_001F;
				}
			}
		}

		// Token: 0x060013D6 RID: 5078 RVA: 0x0009AC70 File Offset: 0x00098E70
		public override void WriteValue(string value)
		{
			for (;;)
			{
				IL_003F:
				base.WriteValue(value);
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cbfb1e54efd84756a9b6d7b21adc0d65 != 0)
				{
					break;
				}
				for (;;)
				{
					switch (num)
					{
					case 1:
						this.AddToken((value != null) ? new BsonString(value, true) : BsonEmpty.Null);
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8d68b74cee6442019d959192b2974e3d != 0)
						{
							continue;
						}
						break;
					case 2:
						goto IL_003F;
					}
					return;
				}
			}
		}

		// Token: 0x060013D7 RID: 5079 RVA: 0x0009ACD8 File Offset: 0x00098ED8
		public override void WriteValue(int value)
		{
			for (;;)
			{
				base.WriteValue(value);
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a5994720d09542abb897ebf6ad9b5a19 == 0)
				{
					goto IL_0025;
				}
				do
				{
					IL_0003:
					this.method_15(value, BsonType.Integer);
					num = 2;
				}
				while (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3baf10aa2a73406aa2bb349717d797c7 == 0);
				IL_0025:
				switch (num)
				{
				case 0:
					goto IL_0003;
				case 1:
					break;
				case 2:
					return;
				default:
					goto IL_0003;
				}
			}
		}

		// Token: 0x060013D8 RID: 5080 RVA: 0x0009AD3C File Offset: 0x00098F3C
		[CLSCompliant(false)]
		public override void WriteValue(uint value)
		{
			IL_0059:
			while (value <= 2147483647U)
			{
				for (;;)
				{
					base.WriteValue(value);
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_871a407507f34aa3b5bf52517d4f63a9 == 0)
					{
						goto IL_0003;
					}
					IL_0022:
					switch (num)
					{
					case 1:
						goto IL_0067;
					case 2:
						continue;
					case 3:
						goto IL_0059;
					case 4:
						return;
					}
					IL_0003:
					this.method_15(value, BsonType.Integer);
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e6fac70dd3e841b6925374855ecd7fb1 != 0)
					{
						goto IL_0022;
					}
					break;
				}
				return;
			}
			IL_0067:
			throw JsonWriterException.Create(this, Class15.smethod_17(1603849468 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d5af2cccac2f47ed978e804138a35d1c), null);
		}

		// Token: 0x060013D9 RID: 5081 RVA: 0x0009ADD0 File Offset: 0x00098FD0
		public override void WriteValue(long value)
		{
			for (;;)
			{
				IL_0036:
				base.WriteValue(value);
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e764f065c2fa404a85129e2e957d4f18 == 0)
				{
					break;
				}
				for (;;)
				{
					switch (num)
					{
					case 1:
						this.method_15(value, BsonType.Long);
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b17e63564ae246399767b60cf4b1528a == 0)
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

		// Token: 0x060013DA RID: 5082 RVA: 0x0009AE30 File Offset: 0x00099030
		[CLSCompliant(false)]
		public override void WriteValue(ulong value)
		{
			for (;;)
			{
				int num;
				if (value > 9223372036854775807UL)
				{
					num = 2;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2a74c5ebb7d84adcad853e2eda393dc4 != 0)
					{
						goto IL_001C;
					}
				}
				else
				{
					base.WriteValue(value);
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bca7529ca324c188cfc0e64eb7d1cdf != 0)
					{
						goto IL_001C;
					}
				}
				IL_003B:
				switch (num)
				{
				case 1:
					return;
				case 2:
					goto IL_0079;
				case 3:
					continue;
				}
				IL_001C:
				this.method_15(value, BsonType.Long);
				num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3baf10aa2a73406aa2bb349717d797c7 == 0)
				{
					goto IL_003B;
				}
				break;
			}
			return;
			IL_0079:
			throw JsonWriterException.Create(this, Class15.smethod_17(2071460370 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8db627a8c96145a0afb24deffd2a8808), null);
		}

		// Token: 0x060013DB RID: 5083 RVA: 0x0009AED4 File Offset: 0x000990D4
		public override void WriteValue(float value)
		{
			for (;;)
			{
				base.WriteValue(value);
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_207f975845fc40cdbe6b166fce664cd5 != 0)
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
				this.method_15(value, BsonType.Number);
				num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_207f975845fc40cdbe6b166fce664cd5 != 0)
				{
					goto IL_0021;
				}
				break;
			}
		}

		// Token: 0x060013DC RID: 5084 RVA: 0x0009AF34 File Offset: 0x00099134
		public override void WriteValue(double value)
		{
			for (;;)
			{
				base.WriteValue(value);
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_1d8dbb531d7349c0bc15bad339f7815c == 0)
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
				this.method_15(value, BsonType.Number);
				num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ee35a23edd8f4998990ec1a2b40fc61a == 0)
				{
					goto IL_0021;
				}
				break;
			}
		}

		// Token: 0x060013DD RID: 5085 RVA: 0x0009AF94 File Offset: 0x00099194
		public override void WriteValue(bool value)
		{
			for (;;)
			{
				base.WriteValue(value);
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3a102d6e4dd542a6855b81a93c692545 == 0)
				{
					goto IL_0003;
				}
				IL_0029:
				switch (num)
				{
				case 1:
					IL_0003:
					this.AddToken(value ? BsonBoolean.True : BsonBoolean.False);
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39f35935adc2477fa894750fee078177 != 0)
					{
						goto IL_0029;
					}
					break;
				case 2:
					continue;
				}
				break;
			}
		}

		// Token: 0x060013DE RID: 5086 RVA: 0x0009AFFC File Offset: 0x000991FC
		public override void WriteValue(short value)
		{
			for (;;)
			{
				base.WriteValue(value);
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_550a8fe2e5fe4cc19bdfe1a82a7f12b8 == 0)
				{
					goto IL_0003;
				}
				IL_0022:
				switch (num)
				{
				case 1:
					IL_0003:
					this.method_15(value, BsonType.Integer);
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_57ce3fecb9e64a8f924ea7658e146719 != 0)
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

		// Token: 0x060013DF RID: 5087 RVA: 0x0009B05C File Offset: 0x0009925C
		[CLSCompliant(false)]
		public override void WriteValue(ushort value)
		{
			for (;;)
			{
				base.WriteValue(value);
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c5a086ee5649458eb5e1e6e4f0f1f4d3 == 0)
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
				this.method_15(value, BsonType.Integer);
				num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5e301544981d4903aa4e531970a47849 == 0)
				{
					goto IL_0022;
				}
			}
		}

		// Token: 0x060013E0 RID: 5088 RVA: 0x0009B0BC File Offset: 0x000992BC
		public override void WriteValue(char value)
		{
			for (;;)
			{
				IL_0061:
				base.WriteValue(value);
				int num = 3;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_eaded84ad5b14e1ea8d4d97bfed1bb48 == 0)
				{
					break;
				}
				for (;;)
				{
					string text;
					switch (num)
					{
					case 0:
						goto IL_0018;
					case 1:
						return;
					case 2:
						break;
					case 3:
						text = null;
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_079bd9b874b24353bef46f6c3f5d741d != 0)
						{
							goto IL_0018;
						}
						continue;
					case 4:
						goto IL_0061;
					default:
						goto IL_0018;
					}
					IL_0026:
					this.AddToken(new BsonString(text, true));
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c367d9ce11cc43b595beeb4524149542 != 0)
					{
						continue;
					}
					return;
					IL_0018:
					text = value.ToString(CultureInfo.InvariantCulture);
					goto IL_0026;
				}
			}
		}

		// Token: 0x060013E1 RID: 5089 RVA: 0x0009B148 File Offset: 0x00099348
		public override void WriteValue(byte value)
		{
			for (;;)
			{
				IL_0036:
				base.WriteValue(value);
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_676b866782704933888a7440512fd4ff != 0)
				{
					break;
				}
				for (;;)
				{
					switch (num)
					{
					case 1:
						this.method_15(value, BsonType.Integer);
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0005996a6a494de4880ac2956b2e0112 != 0)
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

		// Token: 0x060013E2 RID: 5090 RVA: 0x0009B1A8 File Offset: 0x000993A8
		[CLSCompliant(false)]
		public override void WriteValue(sbyte value)
		{
			for (;;)
			{
				base.WriteValue(value);
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93ade03426d44b1841bfa7c633f49f3 == 0)
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
				this.method_15(value, BsonType.Integer);
				num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8f48544341da433d9f954b548c7e9212 != 0)
				{
					goto IL_0022;
				}
				break;
			}
		}

		// Token: 0x060013E3 RID: 5091 RVA: 0x0009B208 File Offset: 0x00099408
		public override void WriteValue(decimal value)
		{
			for (;;)
			{
				base.WriteValue(value);
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8432da17e8384a688cea4636964d3693 == 0)
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
				this.method_15(value, BsonType.Number);
				num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_832998aae3714af0a1270bf2bb566909 == 0)
				{
					goto IL_0021;
				}
				break;
			}
		}

		// Token: 0x060013E4 RID: 5092 RVA: 0x0009B268 File Offset: 0x00099468
		public override void WriteValue(DateTime value)
		{
			for (;;)
			{
				base.WriteValue(value);
				int num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_afb77be96d644a2297c7f9466cb06ede == 0)
				{
					goto IL_0003;
				}
				IL_0042:
				switch (num)
				{
				case 1:
					return;
				case 2:
					IL_0003:
					value = DateTimeUtils.EnsureDateTime(value, base.DateTimeZoneHandling);
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c08ab7af63da4f24a4fa3e9c7a732fae != 0)
					{
						goto IL_0042;
					}
					break;
				case 3:
					continue;
				}
				this.method_15(value, BsonType.Date);
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8db627a8c96145a0afb24deffd2a8808 == 0)
				{
					goto IL_0042;
				}
				break;
			}
		}

		// Token: 0x060013E5 RID: 5093 RVA: 0x0009B2EC File Offset: 0x000994EC
		public override void WriteValue(DateTimeOffset value)
		{
			for (;;)
			{
				base.WriteValue(value);
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bd75de9a0b64d6da3a43e57303102f1 == 0)
				{
					goto IL_0003;
				}
				IL_0022:
				switch (num)
				{
				case 1:
					IL_0003:
					this.method_15(value, BsonType.Date);
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d6c400f349964629bcd869033695bff0 != 0)
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

		// Token: 0x060013E6 RID: 5094 RVA: 0x0009B34C File Offset: 0x0009954C
		public override void WriteValue(byte[] value)
		{
			while (value != null)
			{
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_079bd9b874b24353bef46f6c3f5d741d == 0)
				{
					goto IL_0038;
				}
				IL_0053:
				switch (num)
				{
				case 0:
					goto IL_0038;
				case 1:
					continue;
				case 2:
					break;
				case 3:
					return;
				case 4:
					goto IL_007B;
				case 5:
					return;
				default:
					goto IL_0038;
				}
				IL_0017:
				this.AddToken(new BsonBinary(value, BsonBinaryType.Binary));
				num = 5;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_52d717cd31b74287b67c03ee736a6211 != 0)
				{
					return;
				}
				goto IL_0053;
				IL_0038:
				base.WriteValue(value);
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8db627a8c96145a0afb24deffd2a8808 != 0)
				{
					goto IL_0017;
				}
				goto IL_0053;
			}
			IL_007B:
			this.WriteNull();
		}

		// Token: 0x060013E7 RID: 5095 RVA: 0x0009B3DC File Offset: 0x000995DC
		public override void WriteValue(Guid value)
		{
			for (;;)
			{
				base.WriteValue(value);
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d6c400f349964629bcd869033695bff0 == 0)
				{
					goto IL_0003;
				}
				IL_0027:
				switch (num)
				{
				case 1:
					IL_0003:
					this.AddToken(new BsonBinary(value.ToByteArray(), BsonBinaryType.Uuid));
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bd75de9a0b64d6da3a43e57303102f1 != 0)
					{
						goto IL_0027;
					}
					break;
				case 2:
					continue;
				}
				break;
			}
		}

		// Token: 0x060013E8 RID: 5096 RVA: 0x0009B440 File Offset: 0x00099640
		public override void WriteValue(TimeSpan value)
		{
			for (;;)
			{
				base.WriteValue(value);
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e764f065c2fa404a85129e2e957d4f18 == 0)
				{
					goto IL_0003;
				}
				IL_002D:
				switch (num)
				{
				case 1:
					continue;
				case 2:
					return;
				}
				IL_0003:
				this.AddToken(new BsonString(value.ToString(), true));
				num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5be00c24d71649dcae8af3eed7b74ac9 != 0)
				{
					goto IL_002D;
				}
				break;
			}
		}

		// Token: 0x060013E9 RID: 5097 RVA: 0x0009B4AC File Offset: 0x000996AC
		public override void WriteValue(Uri value)
		{
			while (value == null)
			{
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_1d8dbb531d7349c0bc15bad339f7815c == 0)
				{
					goto IL_0015;
				}
				IL_002C:
				switch (num)
				{
				case 0:
					goto IL_0015;
				case 1:
					continue;
				case 2:
					return;
				case 3:
					break;
				case 4:
					IL_005D:
					this.AddToken(new BsonString(value.ToString(), true));
					break;
				default:
					goto IL_0015;
				}
				return;
				IL_0015:
				this.WriteNull();
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3a102d6e4dd542a6855b81a93c692545 != 0)
				{
					goto IL_002C;
				}
				return;
			}
			base.WriteValue(value);
			goto IL_005D;
		}

		// Token: 0x060013EA RID: 5098 RVA: 0x0009B528 File Offset: 0x00099728
		public void WriteObjectId(byte[] value)
		{
			for (;;)
			{
				ValidationUtils.ArgumentNotNull(value, Class15.smethod_17(1042099287 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39a47a907a8a440980940ae96da3f3ad));
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9f9b31fb7a85497499112abf86cccc98 == 0)
				{
					goto IL_001F;
				}
				goto IL_0034;
				IL_0003:
				this.method_15(value, BsonType.Oid);
				num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_871a407507f34aa3b5bf52517d4f63a9 == 0)
				{
					continue;
				}
				goto IL_0034;
				IL_001F:
				if (value.Length != 12)
				{
					break;
				}
				base.SetWriteState(JsonToken.Undefined, null);
				goto IL_0003;
				IL_0034:
				switch (num)
				{
				case 0:
					goto IL_001F;
				case 1:
					break;
				case 2:
					return;
				case 3:
					goto IL_0080;
				case 4:
					goto IL_0003;
				default:
					goto IL_001F;
				}
			}
			IL_0080:
			throw JsonWriterException.Create(this, Class15.smethod_17(486483852 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39d5fbfa4fe34ed9908db538e5340a6c), null);
		}

		// Token: 0x060013EB RID: 5099 RVA: 0x0009B5D4 File Offset: 0x000997D4
		public void WriteRegex(string pattern, string options)
		{
			for (;;)
			{
				IL_0056:
				ValidationUtils.ArgumentNotNull(pattern, Class15.smethod_17(698959080 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7dfc957a76cb4c58b17dc74a084c4e4a));
				for (;;)
				{
					base.SetWriteState(JsonToken.Undefined, null);
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cf58136e49114a5691c4a9d0e9788de1 == 0)
					{
						goto IL_0003;
					}
					IL_0021:
					switch (num)
					{
					case 1:
						return;
					case 2:
						continue;
					case 3:
						goto IL_0056;
					}
					IL_0003:
					this.AddToken(new BsonRegex(pattern, options));
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b2d935deb963472994f6f2321f1a6296 == 0)
					{
						goto IL_0021;
					}
					return;
				}
			}
		}

		// Token: 0x04000894 RID: 2196
		private readonly BsonBinaryWriter LpIuobxlwm;

		// Token: 0x04000895 RID: 2197
		private BsonToken bsonToken_0;

		// Token: 0x04000896 RID: 2198
		private BsonToken bsonToken_1;

		// Token: 0x04000897 RID: 2199
		private string string_1;
	}
}
