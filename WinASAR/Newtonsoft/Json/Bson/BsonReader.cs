using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Bson
{
	// Token: 0x020001B8 RID: 440
	[Obsolete("BSON reading and writing has been moved to its own package. See https://www.nuget.org/packages/Newtonsoft.Json.Bson for more details.")]
	public class BsonReader : JsonReader
	{
		// Token: 0x170002DA RID: 730
		// (get) Token: 0x06001353 RID: 4947 RVA: 0x00006FCD File Offset: 0x000051CD
		// (set) Token: 0x06001354 RID: 4948 RVA: 0x00097F3C File Offset: 0x0009613C
		[Obsolete("JsonNet35BinaryCompatibility will be removed in a future version of Json.NET.")]
		public bool JsonNet35BinaryCompatibility
		{
			get
			{
				return this.bool_4;
			}
			set
			{
				for (;;)
				{
					this.bool_4 = value;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4152404f503b492c83d9bc2e44bdd0a7 == 0)
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

		// Token: 0x170002DB RID: 731
		// (get) Token: 0x06001355 RID: 4949 RVA: 0x00006FD5 File Offset: 0x000051D5
		// (set) Token: 0x06001356 RID: 4950 RVA: 0x00097F74 File Offset: 0x00096174
		public bool ReadRootValueAsArray
		{
			get
			{
				return this.bool_3;
			}
			set
			{
				for (;;)
				{
					this.bool_3 = value;
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

		// Token: 0x170002DC RID: 732
		// (get) Token: 0x06001357 RID: 4951 RVA: 0x00006FDD File Offset: 0x000051DD
		// (set) Token: 0x06001358 RID: 4952 RVA: 0x00097FAC File Offset: 0x000961AC
		public DateTimeKind DateTimeKindHandling
		{
			get
			{
				return this.dateTimeKind_0;
			}
			set
			{
				for (;;)
				{
					this.dateTimeKind_0 = value;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9bd9937edf9d4ad8bd673dfcb5a5e3cb == 0)
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

		// Token: 0x06001359 RID: 4953 RVA: 0x00097FE4 File Offset: 0x000961E4
		public BsonReader(Stream stream)
			: this(stream, false, DateTimeKind.Local)
		{
			int num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7dfc957a76cb4c58b17dc74a084c4e4a == 0)
			{
				switch (num)
				{
				}
			}
		}

		// Token: 0x0600135A RID: 4954 RVA: 0x0009801C File Offset: 0x0009621C
		public BsonReader(BinaryReader reader)
			: this(reader, false, DateTimeKind.Local)
		{
			int num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bd75de9a0b64d6da3a43e57303102f1 != 0)
			{
				switch (num)
				{
				}
			}
		}

		// Token: 0x0600135B RID: 4955 RVA: 0x00098054 File Offset: 0x00096254
		public BsonReader(Stream stream, bool readRootValueAsArray, DateTimeKind dateTimeKindHandling)
		{
			int num = 1;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3bf07bb1c323490cb457eef2b2e78695 == 0)
			{
				goto IL_003D;
			}
			goto IL_00B1;
			IL_001F:
			this.dateTimeKind_0 = dateTimeKindHandling;
			num = 2;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_17bdafd603b54a77a2e4a383bd4dcffa != 0)
			{
				return;
			}
			goto IL_00B1;
			IL_003D:
			ValidationUtils.ArgumentNotNull(stream, Class15.smethod_17(1807927444 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c5a086ee5649458eb5e1e6e4f0f1f4d3));
			num = 3;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7af5c533f30e4bd1bda86ce6098441d2 != 0)
			{
				goto IL_00B1;
			}
			IL_006A:
			this.binaryReader_0 = new BinaryReader(stream);
			num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ee35a23edd8f4998990ec1a2b40fc61a != 0)
			{
				goto IL_00B1;
			}
			IL_0088:
			this.list_1 = new List<BsonReader.Class13>();
			num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_bc7a9075386042ad9ce36653fcde3fc3 != 0)
			{
				goto IL_00B1;
			}
			IL_00A5:
			this.bool_3 = readRootValueAsArray;
			goto IL_001F;
			IL_00B1:
			switch (num)
			{
			case 0:
				goto IL_0088;
			case 1:
				goto IL_00A5;
			case 2:
				break;
			case 3:
				goto IL_006A;
			case 4:
				goto IL_003D;
			case 5:
				goto IL_001F;
			default:
				goto IL_0088;
			}
		}

		// Token: 0x0600135C RID: 4956 RVA: 0x00098134 File Offset: 0x00096334
		public BsonReader(BinaryReader reader, bool readRootValueAsArray, DateTimeKind dateTimeKindHandling)
		{
			for (;;)
			{
				ValidationUtils.ArgumentNotNull(reader, Class15.smethod_17(613108507 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ad967bb0ba3f44528134c153f7ab1ef6));
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5dadf4f8cc824060ae20e1ee9bbca82a != 0)
				{
					goto IL_0049;
				}
				IL_0052:
				switch (num)
				{
				case 0:
					goto IL_0049;
				case 1:
					goto IL_0027;
				case 2:
					goto IL_002E;
				case 3:
					break;
				case 4:
					continue;
				case 5:
					return;
				default:
					goto IL_0049;
				}
				IL_000A:
				this.list_1 = new List<BsonReader.Class13>();
				num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_207f975845fc40cdbe6b166fce664cd5 != 0)
				{
					goto IL_0027;
				}
				goto IL_0052;
				IL_0049:
				this.binaryReader_0 = reader;
				goto IL_000A;
				IL_002E:
				this.dateTimeKind_0 = dateTimeKindHandling;
				num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_11c6824de6514281a8425f6d6ab1a2d5 == 0)
				{
					break;
				}
				goto IL_0052;
				IL_0027:
				this.bool_3 = readRootValueAsArray;
				goto IL_002E;
			}
		}

		// Token: 0x0600135D RID: 4957 RVA: 0x000981E4 File Offset: 0x000963E4
		private string method_9()
		{
			for (;;)
			{
				this.bsonType_0 = this.method_27();
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9f5329f120e842948536b8235793166c != 0)
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
			return this.method_18();
		}

		// Token: 0x0600135E RID: 4958 RVA: 0x00098228 File Offset: 0x00096428
		public override bool Read()
		{
			bool flag2;
			try
			{
				BsonReader.Enum1 @enum = this.enum1_0;
				for (;;)
				{
					bool flag;
					int num;
					switch (@enum)
					{
					case BsonReader.Enum1.Normal:
						IL_0018:
						flag = this.method_12();
						num = 1;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_afb77be96d644a2297c7f9466cb06ede != 0)
						{
							goto IL_0031;
						}
						goto IL_000E;
					case BsonReader.Enum1.ReferenceStart:
					case BsonReader.Enum1.ReferenceRef:
					case BsonReader.Enum1.ReferenceId:
						IL_00B2:
						flag = this.method_11();
						goto IL_000E;
					case BsonReader.Enum1.CodeWScopeStart:
					case BsonReader.Enum1.CodeWScopeCode:
					case BsonReader.Enum1.CodeWScopeScope:
					case BsonReader.Enum1.CodeWScopeScopeObject:
					case BsonReader.Enum1.const_8:
						IL_00BF:
						flag = this.method_10();
						goto IL_000E;
					}
					goto Block_6;
					IL_0031:
					switch (num)
					{
					case 1:
					case 7:
					case 13:
						goto IL_000E;
					case 2:
					case 14:
						goto IL_0108;
					case 3:
						goto IL_008F;
					case 4:
					case 12:
						goto IL_0103;
					case 5:
						goto IL_00B2;
					case 6:
						goto IL_00BF;
					case 9:
						continue;
					case 10:
						goto IL_0078;
					case 11:
						goto IL_0018;
					}
					break;
					IL_000E:
					if (!flag)
					{
						goto IL_008F;
					}
					num = 4;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8bcabc342a5a44748f3978da7f62051e != 0)
					{
						goto Block_5;
					}
					goto IL_0031;
					IL_0078:
					flag2 = false;
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ee35a23edd8f4998990ec1a2b40fc61a == 0)
					{
						break;
					}
					goto IL_0031;
					IL_008F:
					base.SetToken(JsonToken.None);
					goto IL_0078;
				}
				goto IL_00FE;
				Block_5:
				goto IL_0103;
				Block_6:
				goto IL_0108;
				IL_00FE:
				return flag2;
				IL_0103:
				flag2 = true;
				goto IL_0139;
				IL_0108:
				throw JsonReaderException.Create(this, Class15.smethod_17(299898705 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d97e64d0f425406b9649f2b4562a5f0e).FormatWith(CultureInfo.InvariantCulture, this.enum1_0));
				IL_0139:;
			}
			catch (EndOfStreamException)
			{
				int num2 = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2e3be65f7cb2480482903dc73ec42f7c == 0)
				{
					goto IL_0165;
				}
				goto IL_016E;
				IL_0150:
				flag2 = false;
				num2 = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_1d8dbb531d7349c0bc15bad339f7815c != 0)
				{
					goto IL_016E;
				}
				IL_0165:
				base.SetToken(JsonToken.None);
				goto IL_0150;
				IL_016E:
				switch (num2)
				{
				case 0:
					goto IL_0165;
				case 1:
					break;
				case 2:
					goto IL_0150;
				default:
					goto IL_0165;
				}
			}
			return flag2;
		}

		// Token: 0x0600135F RID: 4959 RVA: 0x000983D8 File Offset: 0x000965D8
		public override void Close()
		{
			for (;;)
			{
				base.Close();
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9bd9937edf9d4ad8bd673dfcb5a5e3cb == 0)
				{
					goto IL_003A;
				}
				IL_0045:
				switch (num)
				{
				case 1:
				case 5:
					return;
				case 2:
					IL_003A:
					if (!base.CloseInput)
					{
						goto Block_4;
					}
					goto IL_0003;
				case 3:
					continue;
				case 4:
					goto IL_0003;
				}
				break;
				IL_0003:
				BinaryReader binaryReader = this.binaryReader_0;
				if (binaryReader == null)
				{
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_186d640068094cc595a341ef95c9a29a == 0)
					{
						break;
					}
					goto IL_0045;
				}
				else
				{
					binaryReader.Close();
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8d68b74cee6442019d959192b2974e3d != 0)
					{
						goto Block_3;
					}
					goto IL_0045;
				}
			}
			return;
			Block_3:
			Block_4:;
		}

		// Token: 0x06001360 RID: 4960 RVA: 0x00098468 File Offset: 0x00096668
		private bool method_10()
		{
			for (;;)
			{
				IL_020C:
				BsonReader.Enum1 @enum = this.enum1_0;
				int num = 8;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_548c52e5632b45898e377ad9c9a06469 != 0)
				{
					goto IL_00E6;
				}
				BsonReader.Class13 @class;
				for (;;)
				{
					IL_01B9:
					switch (num)
					{
					case 1:
						return true;
					case 2:
						goto IL_0091;
					case 3:
						this.enum1_0 = BsonReader.Enum1.CodeWScopeScopeObject;
						num = 6;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0361b8eb39074ea88f5257b13904930a != 0)
						{
							goto IL_00D9;
						}
						continue;
					case 4:
						return true;
					case 5:
						goto IL_023B;
					case 6:
						return true;
					case 7:
						goto IL_022D;
					case 8:
						goto IL_00E6;
					case 9:
						goto IL_020C;
					case 10:
						goto IL_0075;
					case 11:
						goto IL_00D9;
					case 12:
						goto IL_00B8;
					case 13:
						goto IL_0268;
					case 14:
						return true;
					case 15:
						goto IL_003C;
					case 16:
						goto IL_0006;
					case 17:
						return true;
					}
					break;
					IL_003C:
					this.method_14(@class);
					num = 2;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d5af2cccac2f47ed978e804138a35d1c == 0)
					{
						break;
					}
					continue;
					IL_00D9:
					@class = new BsonReader.Class13(BsonType.Object);
					goto IL_003C;
				}
				goto IL_0059;
				IL_0006:
				base.SetToken(JsonToken.PropertyName, Class15.smethod_17(1788653526 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bd75de9a0b64d6da3a43e57303102f1));
				num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_186d640068094cc595a341ef95c9a29a == 0)
				{
					break;
				}
				goto IL_01B9;
				IL_0075:
				this.enum1_0 = BsonReader.Enum1.CodeWScopeCode;
				num = 4;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e368897ba1744663a6d0bc59b9b65b5f == 0)
				{
					goto IL_0091;
				}
				goto IL_01B9;
				IL_0059:
				base.SetToken(JsonToken.PropertyName, Class15.smethod_17(1176485568 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93c7140125045538ae5c40c6f39a5af));
				goto IL_0075;
				IL_00E6:
				switch (@enum)
				{
				case BsonReader.Enum1.CodeWScopeStart:
					goto IL_0059;
				case BsonReader.Enum1.CodeWScopeCode:
					this.method_25();
					num = 7;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_6f87b5b72b9847f7b8ec5b44b0dccfa8 != 0)
					{
						goto IL_0059;
					}
					goto IL_01B9;
				case BsonReader.Enum1.CodeWScopeScope:
					if (base.CurrentState == JsonReader.State.PostValue)
					{
						num = 1;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_550a8fe2e5fe4cc19bdfe1a82a7f12b8 == 0)
						{
							goto IL_0006;
						}
						goto IL_01B9;
					}
					else
					{
						base.SetToken(JsonToken.StartObject);
						num = 3;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_1d8dbb531d7349c0bc15bad339f7815c == 0)
						{
							goto Block_9;
						}
						goto IL_01B9;
					}
					break;
				case BsonReader.Enum1.CodeWScopeScopeObject:
					goto IL_024A;
				case BsonReader.Enum1.const_8:
					base.SetToken(JsonToken.EndObject);
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_67cbcb2ad04040d48847c1ca2f65be32 == 0)
					{
						goto IL_00B8;
					}
					goto IL_01B9;
				default:
					num = 13;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0efaea2f67ca4b0aa2880fbd34fc0fff != 0)
					{
						goto Block_5;
					}
					goto IL_01B9;
				}
				IL_0091:
				@class.int_0 = this.method_25();
				num = 4;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_eaded84ad5b14e1ea8d4d97bfed1bb48 != 0)
				{
					goto Block_2;
				}
				goto IL_01B9;
				IL_00B8:
				this.enum1_0 = BsonReader.Enum1.Normal;
				num = 16;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_aa43e77a676848e0bd70abf647d6a9f1 == 0)
				{
					goto Block_3;
				}
				goto IL_01B9;
			}
			return true;
			Block_2:
			return true;
			Block_3:
			return true;
			Block_5:
			goto IL_0268;
			Block_9:
			return true;
			IL_022D:
			base.SetToken(JsonToken.String, this.method_19());
			IL_023B:
			this.enum1_0 = BsonReader.Enum1.CodeWScopeScope;
			return true;
			IL_024A:
			bool flag = this.method_12();
			if (flag && this.TokenType == JsonToken.EndObject)
			{
				this.enum1_0 = BsonReader.Enum1.const_8;
			}
			return flag;
			IL_0268:
			throw new ArgumentOutOfRangeException();
		}

		// Token: 0x06001361 RID: 4961 RVA: 0x000986EC File Offset: 0x000968EC
		private bool method_11()
		{
			for (;;)
			{
				IL_015F:
				JsonReader.State currentState = base.CurrentState;
				for (;;)
				{
					if (currentState != JsonReader.State.Property)
					{
						goto IL_00A0;
					}
					int num;
					if (this.enum1_0 == BsonReader.Enum1.ReferenceRef)
					{
						num = 4;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_550a8fe2e5fe4cc19bdfe1a82a7f12b8 == 0)
						{
							goto IL_00E2;
						}
					}
					else
					{
						if (this.enum1_0 != BsonReader.Enum1.ReferenceId)
						{
							goto IL_020B;
						}
						num = 1;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b17e63564ae246399767b60cf4b1528a != 0)
						{
							goto Block_4;
						}
					}
					IL_0101:
					switch (num)
					{
					case 1:
						goto IL_016A;
					case 2:
						continue;
					case 3:
						goto IL_015F;
					case 4:
						IL_00E2:
						base.SetToken(JsonToken.String, this.method_19());
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_725e5f82c8704b39b66ebddcee8df7fa == 0)
						{
							goto IL_0101;
						}
						break;
					case 5:
						return true;
					case 6:
						return true;
					case 7:
						goto IL_00C4;
					case 8:
						return true;
					case 9:
						return true;
					case 10:
						goto IL_0066;
					case 11:
						goto IL_0082;
					case 12:
						goto IL_01D0;
					case 13:
						goto IL_0186;
					case 14:
						goto IL_01C8;
					case 15:
						goto IL_00A8;
					case 16:
						IL_00A0:
						if (currentState != JsonReader.State.ObjectStart)
						{
							goto IL_004F;
						}
						goto IL_00A8;
					case 17:
						goto IL_004F;
					}
					goto Block_9;
					IL_0082:
					this.enum1_0 = BsonReader.Enum1.ReferenceId;
					num = 8;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9f9b31fb7a85497499112abf86cccc98 == 0)
					{
						goto Block_6;
					}
					goto IL_0101;
					IL_0066:
					base.SetToken(JsonToken.PropertyName, Class15.smethod_17(2071427524 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8db627a8c96145a0afb24deffd2a8808));
					goto IL_0082;
					IL_004F:
					if (currentState != JsonReader.State.PostValue)
					{
						goto Block_5;
					}
					if (this.enum1_0 == BsonReader.Enum1.ReferenceRef)
					{
						goto IL_0066;
					}
					goto IL_01BF;
					IL_00C4:
					this.enum1_0 = BsonReader.Enum1.ReferenceRef;
					num = 9;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fd59e876ac704e7eaa7c7a24a9b3a23f != 0)
					{
						goto Block_8;
					}
					goto IL_0101;
					IL_00A8:
					base.SetToken(JsonToken.PropertyName, Class15.smethod_17(1793891302 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0361b8eb39074ea88f5257b13904930a));
					goto IL_00C4;
				}
			}
			Block_4:
			goto IL_016A;
			Block_5:
			goto IL_0186;
			Block_6:
			return true;
			Block_8:
			return true;
			Block_9:
			return true;
			IL_016A:
			base.SetToken(JsonToken.Bytes, this.method_29(12));
			return true;
			IL_0186:
			throw JsonReaderException.Create(this, Class15.smethod_17(974395879 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_92ac2a37edba4e2587eb1b9e8af3f63f) + base.CurrentState.ToString());
			IL_01BF:
			if (this.enum1_0 != BsonReader.Enum1.ReferenceId)
			{
				throw JsonReaderException.Create(this, Class15.smethod_17(432097431 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7af5c533f30e4bd1bda86ce6098441d2) + this.enum1_0.ToString());
			}
			IL_01C8:
			base.SetToken(JsonToken.EndObject);
			IL_01D0:
			this.enum1_0 = BsonReader.Enum1.Normal;
			return true;
			IL_020B:
			throw JsonReaderException.Create(this, Class15.smethod_17(564887300 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_1db17fe7bd2442b599c52df89f39e610) + this.enum1_0.ToString());
		}

		// Token: 0x06001362 RID: 4962 RVA: 0x00098938 File Offset: 0x00096B38
		private bool method_12()
		{
			for (;;)
			{
				IL_021E:
				JsonReader.State currentState = base.CurrentState;
				int num = 5;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f77f8ab5a3534e2e914063d52217b4e1 == 0)
				{
					goto IL_0106;
				}
				BsonReader.Class13 @class;
				int num2;
				for (;;)
				{
					IL_018F:
					switch (num)
					{
					case 1:
						goto IL_0074;
					case 2:
						goto IL_00B2;
					case 3:
						goto IL_00B8;
					case 4:
						goto IL_0057;
					case 5:
						goto IL_0292;
					case 6:
						goto IL_0240;
					case 7:
						return true;
					case 8:
						goto IL_02BA;
					case 9:
						return true;
					case 10:
						goto IL_02DB;
					case 11:
						return true;
					case 12:
						goto IL_0247;
					case 13:
						return false;
					case 14:
						goto IL_00D1;
					case 15:
						goto IL_016D;
					case 16:
						if (@class != null)
						{
							goto IL_016D;
						}
						goto IL_0096;
					case 17:
					case 31:
						goto IL_0006;
					case 18:
						goto IL_02C0;
					case 19:
						return true;
					case 20:
						goto IL_02BD;
					case 21:
						goto IL_004D;
					case 22:
						goto IL_02CB;
					case 23:
						goto IL_0106;
					case 24:
						goto IL_021E;
					case 25:
						goto IL_00C6;
					case 26:
						goto IL_00A7;
					case 27:
						goto IL_02AE;
					case 28:
						goto IL_0096;
					case 29:
						goto IL_002B;
					case 30:
						goto IL_02C8;
					case 32:
						goto IL_02E3;
					}
					goto Block_12;
					IL_016D:
					num2 = @class.int_0 - 1;
					num = 5;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_676b866782704933888a7440512fd4ff == 0)
					{
						goto Block_11;
					}
				}
				IL_0096:
				if (base.SupportMultipleContent)
				{
					goto IL_0006;
				}
				return false;
				IL_00B2:
				this.method_13();
				goto IL_00B8;
				IL_00A7:
				if (this.method_15() == 0)
				{
					goto IL_00B2;
				}
				goto IL_0292;
				IL_00C6:
				if (@class.int_1 < num2)
				{
					goto IL_00D1;
				}
				if (@class.int_1 == num2)
				{
					goto IL_00A7;
				}
				goto IL_0276;
				Block_11:
				goto IL_00C6;
				IL_0006:
				if (this.bool_3)
				{
					goto IL_02BD;
				}
				num = 5;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_afb77be96d644a2297c7f9466cb06ede == 0)
				{
					break;
				}
				goto IL_018F;
				IL_002B:
				this.method_28(@class.int_0);
				num = 20;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7ae4da5a55de471eb12dd0de8dd4269c == 0)
				{
					goto IL_004D;
				}
				goto IL_018F;
				IL_00B8:
				if (this.class13_0 != null)
				{
					goto IL_002B;
				}
				goto IL_004D;
				IL_005D:
				JsonToken jsonToken2;
				JsonToken jsonToken = jsonToken2;
				num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_948fa5c193d44e279b41c3a0fab7b5c9 == 0)
				{
					goto IL_0074;
				}
				goto IL_018F;
				IL_004D:
				if (@class.bsonType_0 == BsonType.Object)
				{
					jsonToken2 = JsonToken.EndObject;
					goto IL_005D;
				}
				IL_0057:
				jsonToken2 = JsonToken.EndArray;
				goto IL_005D;
				IL_0074:
				base.SetToken(jsonToken);
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d6c400f349964629bcd869033695bff0 == 0)
				{
					goto Block_3;
				}
				goto IL_018F;
				IL_00D1:
				if (@class.bsonType_0 != BsonType.Array)
				{
					goto IL_0267;
				}
				num = 6;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_afb77be96d644a2297c7f9466cb06ede != 0)
				{
					goto IL_00B8;
				}
				goto IL_018F;
				IL_0106:
				switch (currentState)
				{
				case JsonReader.State.Start:
					goto IL_0006;
				case JsonReader.State.Complete:
				case JsonReader.State.Closed:
					return false;
				case JsonReader.State.Property:
					goto IL_0255;
				case JsonReader.State.ObjectStart:
				case JsonReader.State.ArrayStart:
				case JsonReader.State.PostValue:
					@class = this.class13_0;
					num = 16;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_991c06e999c744809f5b643cb7d9e7b4 == 0)
					{
						goto IL_00D1;
					}
					goto IL_018F;
				case JsonReader.State.ConstructorStart:
				case JsonReader.State.Constructor:
				case JsonReader.State.Error:
				case JsonReader.State.Finished:
					return false;
				}
				goto Block_9;
			}
			goto IL_02BA;
			Block_3:
			return true;
			Block_9:
			goto IL_02AE;
			Block_12:
			return true;
			IL_0240:
			this.method_9();
			IL_0247:
			this.method_16(this.bsonType_0);
			return true;
			IL_0255:
			this.method_16(this.bsonType_0);
			return true;
			IL_0267:
			base.SetToken(JsonToken.PropertyName, this.method_9());
			return true;
			IL_0276:
			throw JsonReaderException.Create(this, Class15.smethod_17(41456033 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_079bd9b874b24353bef46f6c3f5d741d));
			IL_0292:
			throw JsonReaderException.Create(this, Class15.smethod_17(314831093 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_48fe014748e848c88d3254f339047927));
			IL_02AE:
			throw new ArgumentOutOfRangeException();
			IL_02BA:
			JsonToken jsonToken3 = JsonToken.StartObject;
			goto IL_02BE;
			IL_02BD:
			jsonToken3 = JsonToken.StartArray;
			IL_02BE:
			JsonToken jsonToken4 = jsonToken3;
			IL_02C0:
			if (this.bool_3)
			{
				goto IL_02CB;
			}
			IL_02C8:
			BsonType bsonType = BsonType.Object;
			goto IL_02CC;
			IL_02CB:
			bsonType = BsonType.Array;
			IL_02CC:
			base.SetToken(jsonToken4);
			BsonReader.Class13 class2 = new BsonReader.Class13(bsonType);
			IL_02DB:
			this.method_14(class2);
			IL_02E3:
			class2.int_0 = this.method_25();
			return true;
		}

		// Token: 0x06001363 RID: 4963 RVA: 0x00098C38 File Offset: 0x00096E38
		private void method_13()
		{
			for (;;)
			{
				this.list_1.RemoveAt(this.list_1.Count - 1);
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_1d8dbb531d7349c0bc15bad339f7815c != 0)
				{
					goto IL_0003;
				}
				IL_0028:
				switch (num)
				{
				case 1:
					goto IL_0010;
				case 2:
					goto IL_0076;
				case 3:
					IL_0003:
					if (this.list_1.Count == 0)
					{
						goto IL_0010;
					}
					goto IL_0076;
				case 4:
					continue;
				case 5:
					return;
				}
				break;
				IL_0010:
				this.class13_0 = null;
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b2d935deb963472994f6f2321f1a6296 == 0)
				{
					goto IL_0028;
				}
				break;
			}
			return;
			IL_0076:
			this.class13_0 = this.list_1[this.list_1.Count - 1];
		}

		// Token: 0x06001364 RID: 4964 RVA: 0x00098CDC File Offset: 0x00096EDC
		private void method_14(BsonReader.Class13 class13_1)
		{
			for (;;)
			{
				this.list_1.Add(class13_1);
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e368897ba1744663a6d0bc59b9b65b5f == 0)
				{
					goto IL_0003;
				}
				IL_001B:
				switch (num)
				{
				case 1:
					IL_0003:
					this.class13_0 = class13_1;
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_aa43e77a676848e0bd70abf647d6a9f1 != 0)
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

		// Token: 0x06001365 RID: 4965 RVA: 0x00098D3C File Offset: 0x00096F3C
		private byte method_15()
		{
			for (;;)
			{
				this.method_28(1);
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
			return this.binaryReader_0.ReadByte();
		}

		// Token: 0x06001366 RID: 4966 RVA: 0x00098D80 File Offset: 0x00096F80
		private void method_16(BsonType bsonType_1)
		{
			DateTime dateTime;
			string text;
			string text2;
			DateTime dateTime2;
			double num2;
			for (;;)
			{
				IL_02F5:
				int num;
				BsonBinaryType bsonBinaryType;
				byte[] array;
				switch (bsonType_1)
				{
				case BsonType.Number:
					goto IL_0132;
				case BsonType.String:
				case BsonType.Symbol:
					base.SetToken(JsonToken.String, this.method_19());
					num = 16;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ca6ac77a767741aa91cb31f8080f093b == 0)
					{
						goto Block_11;
					}
					goto IL_013C;
				case BsonType.Object:
					goto IL_034B;
				case BsonType.Array:
					goto IL_0357;
				case BsonType.Binary:
					array = this.method_17(out bsonBinaryType);
					goto IL_0120;
				case BsonType.Undefined:
					base.SetToken(JsonToken.Undefined);
					num = 24;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_75738dd4edc84122bfe3748a1ea03d43 != 0)
					{
						goto IL_0132;
					}
					goto IL_013C;
				case BsonType.Oid:
					goto IL_0360;
				case BsonType.Boolean:
					goto IL_036C;
				case BsonType.Date:
					dateTime = DateTimeUtils.ConvertJavaScriptTicksToDateTime(this.method_26());
					goto IL_0103;
				case BsonType.Null:
					goto IL_037E;
				case BsonType.Regex:
					text = this.method_18();
					num = 47;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_11c6824de6514281a8425f6d6ab1a2d5 != 0)
					{
						goto IL_004F;
					}
					goto IL_013C;
				case BsonType.Reference:
					base.SetToken(JsonToken.StartObject);
					goto IL_004F;
				case BsonType.Code:
					base.SetToken(JsonToken.String, this.method_19());
					num = 23;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7af5c533f30e4bd1bda86ce6098441d2 == 0)
					{
						goto Block_12;
					}
					goto IL_013C;
				case BsonType.const_14:
					goto IL_0397;
				case BsonType.Integer:
					base.SetToken(JsonToken.Integer, (long)this.method_25());
					num = 16;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9f9b31fb7a85497499112abf86cccc98 != 0)
					{
						goto Block_10;
					}
					goto IL_013C;
				case BsonType.TimeStamp:
				case BsonType.Long:
					base.SetToken(JsonToken.Integer, this.method_26());
					num = 33;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5be00c24d71649dcae8af3eed7b74ac9 != 0)
					{
						goto Block_1;
					}
					goto IL_013C;
				}
				goto Block_15;
				for (;;)
				{
					IL_013C:
					switch (num)
					{
					case 1:
						return;
					case 2:
					case 32:
					case 35:
						goto IL_04D9;
					case 3:
						goto IL_03B7;
					case 4:
						goto IL_0132;
					case 5:
						return;
					case 6:
						goto IL_03AF;
					case 7:
						return;
					case 8:
						return;
					case 9:
						goto IL_0120;
					case 10:
						goto IL_0428;
					case 11:
						goto IL_0112;
					case 12:
						goto IL_004F;
					case 13:
						goto IL_010B;
					case 14:
						goto IL_0405;
					case 15:
						goto IL_04C2;
					case 16:
						return;
					case 17:
						goto IL_03C5;
					case 18:
						goto IL_03D0;
					case 19:
					case 46:
						goto IL_0070;
					case 20:
						goto IL_0414;
					case 21:
						return;
					case 22:
						goto IL_0103;
					case 23:
						return;
					case 24:
						return;
					case 25:
						goto IL_00F4;
					case 26:
						goto IL_00C0;
					case 27:
						goto IL_044A;
					case 28:
						return;
					case 29:
						goto IL_009C;
					case 30:
						return;
					case 31:
						goto IL_0455;
					case 33:
						return;
					case 34:
						goto IL_0462;
					case 36:
						goto IL_0470;
					case 37:
						goto IL_02F5;
					case 38:
						return;
					case 39:
						return;
					case 40:
						goto IL_04CA;
					case 41:
						goto IL_008E;
					case 42:
						return;
					case 43:
						return;
					case 44:
						return;
					case 45:
						goto IL_04BA;
					case 47:
						text2 = this.method_18();
						num = 18;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_548c52e5632b45898e377ad9c9a06469 != 0)
						{
							goto IL_004F;
						}
						continue;
					}
					goto Block_9;
				}
				IL_004F:
				this.enum1_0 = BsonReader.Enum1.ReferenceStart;
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9f9b31fb7a85497499112abf86cccc98 == 0)
				{
					break;
				}
				goto IL_013C;
				IL_0070:
				dateTime2 = dateTime;
				num = 9;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c27e9fccdfcc44999155a4980faa4e81 != 0)
				{
					goto Block_3;
				}
				goto IL_013C;
				IL_0112:
				DateTimeKind dateTimeKindHandling;
				if (dateTimeKindHandling != DateTimeKind.Local)
				{
					goto IL_0070;
				}
				goto IL_0428;
				IL_010B:
				if (dateTimeKindHandling != DateTimeKind.Unspecified)
				{
					goto IL_0112;
				}
				goto IL_0455;
				IL_0103:
				dateTimeKindHandling = this.DateTimeKindHandling;
				goto IL_010B;
				IL_009C:
				object obj;
				base.SetToken(JsonToken.Bytes, obj);
				num = 7;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_832998aae3714af0a1270bf2bb566909 == 0)
				{
					goto Block_4;
				}
				goto IL_013C;
				IL_009A:
				object obj2;
				obj = obj2;
				goto IL_009C;
				IL_0120:
				if (bsonBinaryType != BsonBinaryType.Uuid)
				{
					obj2 = array;
					goto IL_009A;
				}
				IL_008E:
				obj2 = new Guid(array);
				goto IL_009A;
				IL_00C0:
				base.SetToken(JsonToken.Float, Convert.ToDecimal(num2, CultureInfo.InvariantCulture));
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_186d640068094cc595a341ef95c9a29a == 0)
				{
					goto Block_5;
				}
				goto IL_013C;
				IL_00F4:
				if (this._floatParseHandling == FloatParseHandling.Decimal)
				{
					goto IL_00C0;
				}
				goto IL_0438;
				IL_0132:
				num2 = this.method_24();
				goto IL_00F4;
			}
			Block_1:
			return;
			Block_3:
			goto IL_04D9;
			Block_4:
			return;
			Block_5:
			return;
			Block_9:
			return;
			Block_10:
			return;
			Block_11:
			return;
			Block_12:
			goto IL_0428;
			Block_15:
			goto IL_0470;
			IL_034B:
			base.SetToken(JsonToken.StartObject);
			goto IL_04BA;
			IL_0357:
			base.SetToken(JsonToken.StartArray);
			goto IL_03AF;
			IL_0360:
			byte[] array2 = this.method_29(12);
			goto IL_03C5;
			IL_036C:
			bool flag = Convert.ToBoolean(this.method_15());
			goto IL_0414;
			IL_037E:
			base.SetToken(JsonToken.Null);
			return;
			IL_0397:
			base.SetToken(JsonToken.StartObject);
			goto IL_044A;
			IL_03AF:
			BsonReader.Class13 @class = new BsonReader.Class13(BsonType.Array);
			IL_03B7:
			this.method_14(@class);
			goto IL_0462;
			IL_03C5:
			base.SetToken(JsonToken.Bytes, array2);
			return;
			IL_03D0:
			string text3 = Class15.smethod_17(2057026479 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_eaded84ad5b14e1ea8d4d97bfed1bb48) + text + Class15.smethod_17(1743131478 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a321d34f24314561b0d80437d5d859e8) + text2;
			IL_0405:
			base.SetToken(JsonToken.String, text3);
			return;
			IL_0414:
			base.SetToken(JsonToken.Boolean, flag);
			return;
			IL_0428:
			dateTime2 = dateTime.ToLocalTime();
			goto IL_04D9;
			IL_0438:
			base.SetToken(JsonToken.Float, num2);
			return;
			IL_044A:
			this.enum1_0 = BsonReader.Enum1.CodeWScopeStart;
			return;
			IL_0455:
			dateTime2 = DateTime.SpecifyKind(dateTime, DateTimeKind.Unspecified);
			goto IL_04D9;
			IL_0462:
			@class.int_0 = this.method_25();
			return;
			IL_0470:
			throw new ArgumentOutOfRangeException(Class15.smethod_17(974433339 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_92ac2a37edba4e2587eb1b9e8af3f63f), Class15.smethod_17(564887042 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_1db17fe7bd2442b599c52df89f39e610) + bsonType_1.ToString());
			IL_04BA:
			BsonReader.Class13 class2 = new BsonReader.Class13(BsonType.Object);
			IL_04C2:
			this.method_14(class2);
			IL_04CA:
			class2.int_0 = this.method_25();
			return;
			IL_04D9:
			base.SetToken(JsonToken.Date, dateTime2);
		}

		// Token: 0x06001367 RID: 4967 RVA: 0x00099278 File Offset: 0x00097478
		private byte[] method_17(out BsonBinaryType bsonBinaryType_0)
		{
			int num;
			for (;;)
			{
				num = this.method_25();
				int num2 = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_eaded84ad5b14e1ea8d4d97bfed1bb48 != 0)
				{
					goto IL_0003;
				}
				goto IL_0041;
				IL_0036:
				while (this.bool_4)
				{
					num2 = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bd75de9a0b64d6da3a43e57303102f1 != 0)
					{
						goto IL_0041;
					}
				}
				break;
				IL_0041:
				switch (num2)
				{
				case 0:
					goto IL_0036;
				case 1:
				case 5:
					goto IL_0089;
				case 2:
					break;
				case 3:
					IL_0003:
					bsonBinaryType_0 = (BsonBinaryType)this.method_15();
					break;
				case 4:
					continue;
				case 6:
					goto IL_0081;
				default:
					goto IL_0036;
				}
				if (bsonBinaryType_0 != BsonBinaryType.BinaryOld)
				{
					goto IL_0089;
				}
				num2 = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e368897ba1744663a6d0bc59b9b65b5f == 0)
				{
					goto IL_0036;
				}
				goto IL_0041;
			}
			IL_0081:
			num = this.method_25();
			IL_0089:
			return this.method_29(num);
		}

		// Token: 0x06001368 RID: 4968 RVA: 0x00099318 File Offset: 0x00097518
		private string method_18()
		{
			int num4;
			StringBuilder stringBuilder;
			int chars2;
			for (;;)
			{
				IL_0266:
				this.method_23();
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7af5c533f30e4bd1bda86ce6098441d2 != 0)
				{
					goto IL_01D9;
				}
				int num2;
				int num3;
				int num5;
				for (;;)
				{
					IL_01DE:
					int num6;
					int chars;
					switch (num)
					{
					case 1:
						goto IL_01D9;
					case 2:
						goto IL_0266;
					case 3:
					case 4:
						goto IL_0016;
					case 5:
						goto IL_00EC;
					case 6:
					case 22:
						goto IL_0088;
					case 8:
						goto IL_0286;
					case 9:
					case 21:
						if (num2 < 128)
						{
							goto IL_0286;
						}
						num3 = 0;
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_676b866782704933888a7440512fd4ff == 0)
						{
							continue;
						}
						break;
					case 10:
						goto IL_019F;
					case 11:
						goto IL_0046;
					case 12:
						num4 += num5;
						goto IL_00DF;
					case 13:
						goto IL_000A;
					case 15:
						goto IL_0108;
					case 16:
						goto IL_0290;
					case 17:
						IL_0138:
						chars = Encoding.UTF8.GetChars(this.TmnjOycGdr, 0, num6 + 1, this.OuLjCeRksR, 0);
						num = 30;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_92ac2a37edba4e2587eb1b9e8af3f63f == 0)
						{
							goto Block_7;
						}
						continue;
					case 18:
						goto IL_00AD;
					case 19:
						goto IL_00E8;
					case 20:
					case 26:
						goto IL_0068;
					case 23:
						goto IL_00BE;
					case 24:
						goto IL_019C;
					case 25:
						goto IL_0299;
					case 27:
						Array.Copy(this.TmnjOycGdr, num6 + 1, this.TmnjOycGdr, 0, num3);
						num = 3;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_253407eb812c4aefb734fa1e267fe779 != 0)
						{
							continue;
						}
						break;
					case 28:
						goto IL_0027;
					case 29:
						goto IL_00DF;
					case 30:
						if (stringBuilder == null)
						{
							goto IL_000A;
						}
						goto IL_0016;
					}
					break;
					IL_0027:
					if (num6 < num5 - 1)
					{
						goto IL_0046;
					}
					num = 9;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7af5c533f30e4bd1bda86ce6098441d2 == 0)
					{
						break;
					}
					continue;
					IL_0016:
					stringBuilder.Append(this.OuLjCeRksR, 0, chars);
					goto IL_0027;
					IL_0046:
					num3 = num5 - num6 - 1;
					num = 27;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_67cbcb2ad04040d48847c1ca2f65be32 != 0)
					{
						break;
					}
					continue;
					IL_0108:
					this.method_28(num4 + 1);
					num = 5;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4ac69ea2381b403582a2723337f67fa8 != 0)
					{
						goto Block_6;
					}
					continue;
					IL_00EC:
					chars2 = Encoding.UTF8.GetChars(this.TmnjOycGdr, 0, num5, this.OuLjCeRksR, 0);
					goto IL_0108;
					IL_00E8:
					if (stringBuilder == null)
					{
						goto IL_00EC;
					}
					goto IL_012C;
					IL_00DF:
					if (num2 < 128)
					{
						goto IL_00E8;
					}
					IL_012C:
					num6 = this.method_21(num2 - 1);
					goto IL_0138;
					IL_000A:
					stringBuilder = new StringBuilder(256);
					goto IL_0016;
				}
				goto IL_0064;
				Block_7:
				goto IL_00BE;
				goto IL_0064;
				IL_00BE:
				num5 = num2 - num3;
				num = 12;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a321d34f24314561b0d80437d5d859e8 == 0)
				{
					continue;
				}
				goto IL_01DE;
				IL_0068:
				if (num2 >= 128)
				{
					goto IL_00BE;
				}
				num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e6fac70dd3e841b6925374855ecd7fb1 == 0)
				{
					goto IL_00AD;
				}
				goto IL_01DE;
				IL_0064:
				num2 = num3;
				goto IL_0068;
				IL_00AD:
				byte b;
				if ((b = this.binaryReader_0.ReadByte()) <= 0)
				{
					goto IL_00BE;
				}
				goto IL_0088;
				IL_019F:
				num3 = 0;
				goto IL_0064;
				IL_019C:
				num4 = 0;
				goto IL_019F;
				IL_01D9:
				stringBuilder = null;
				goto IL_019C;
				IL_0088:
				this.TmnjOycGdr[num2++] = b;
				num = 26;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c367d9ce11cc43b595beeb4524149542 != 0)
				{
					goto IL_00AD;
				}
				goto IL_01DE;
			}
			Block_6:
			goto IL_0299;
			IL_0286:
			this.method_28(num4 + 1);
			IL_0290:
			return stringBuilder.ToString();
			IL_0299:
			return new string(this.OuLjCeRksR, 0, chars2);
		}

		// Token: 0x06001369 RID: 4969 RVA: 0x000995CC File Offset: 0x000977CC
		private string method_19()
		{
			int num;
			for (;;)
			{
				num = this.method_25();
				int num2 = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b2d935deb963472994f6f2321f1a6296 != 0)
				{
					goto IL_0003;
				}
				IL_001C:
				switch (num2)
				{
				case 1:
					IL_0003:
					this.method_28(num);
					num2 = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a5994720d09542abb897ebf6ad9b5a19 == 0)
					{
						goto IL_001C;
					}
					break;
				case 2:
					continue;
				}
				break;
			}
			string text = this.method_20(num - 1);
			this.binaryReader_0.ReadByte();
			return text;
		}

		// Token: 0x0600136A RID: 4970 RVA: 0x0009963C File Offset: 0x0009783C
		private string method_20(int int_0)
		{
			StringBuilder stringBuilder;
			int chars;
			for (;;)
			{
				IL_0272:
				int num;
				if (int_0 == 0)
				{
					num = 16;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b17e63564ae246399767b60cf4b1528a == 0)
					{
						goto Block_13;
					}
				}
				else
				{
					this.method_23();
					num = 6;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5e301544981d4903aa4e531970a47849 == 0)
					{
						goto IL_01D1;
					}
				}
				int num2;
				int num3;
				int num4;
				int num5;
				int chars2;
				for (;;)
				{
					IL_01E8:
					switch (num)
					{
					case 1:
						goto IL_02A3;
					case 2:
						goto IL_0070;
					case 3:
						goto IL_0044;
					case 4:
						goto IL_00E0;
					case 5:
					case 12:
						goto IL_002C;
					case 6:
						goto IL_015E;
					case 7:
					case 20:
						goto IL_00B9;
					case 8:
						goto IL_0196;
					case 9:
						goto IL_0029;
					case 10:
						goto IL_00B6;
					case 11:
						goto IL_01D1;
					case 13:
						goto IL_02B2;
					case 14:
						if (num2 == 0)
						{
							goto IL_0281;
						}
						num3 += num2;
						num = 22;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2e3be65f7cb2480482903dc73ec42f7c != 0)
						{
							goto Block_10;
						}
						continue;
					case 15:
						goto IL_0166;
					case 16:
						goto IL_0281;
					case 17:
						if (stringBuilder == null)
						{
							goto IL_015E;
						}
						goto IL_0166;
					case 18:
						goto IL_029C;
					case 19:
						goto IL_0272;
					case 21:
						goto IL_009C;
					case 22:
						num2 += num4;
						num = 7;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d6c400f349964629bcd869033695bff0 == 0)
						{
							goto IL_00DB;
						}
						continue;
					case 23:
						goto IL_00DB;
					case 24:
						goto IL_0076;
					case 25:
						goto IL_0026;
					}
					goto Block_12;
					IL_00E0:
					chars = Encoding.UTF8.GetChars(this.TmnjOycGdr, 0, num2, this.OuLjCeRksR, 0);
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39a47a907a8a440980940ae96da3f3ad != 0)
					{
						goto Block_6;
					}
					continue;
					IL_00DB:
					if (num2 == int_0)
					{
						goto IL_00E0;
					}
					num5 = this.method_21(num2 - 1);
					num = 17;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93ade03426d44b1841bfa7c633f49f3 != 0)
					{
						break;
					}
					continue;
					IL_0166:
					chars2 = Encoding.UTF8.GetChars(this.TmnjOycGdr, 0, num5 + 1, this.OuLjCeRksR, 0);
					num = 3;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_6f87b5b72b9847f7b8ec5b44b0dccfa8 == 0)
					{
						goto IL_0196;
					}
					continue;
					IL_015E:
					stringBuilder = new StringBuilder(int_0);
					goto IL_0166;
				}
				goto IL_0044;
				IL_0029:
				num4 = 0;
				goto IL_002C;
				IL_0026:
				num3 = 0;
				goto IL_0029;
				Block_12:
				goto IL_0093;
				IL_0044:
				int num6;
				num2 = this.binaryReader_0.Read(this.TmnjOycGdr, num4, num6);
				num = 14;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c5a086ee5649458eb5e1e6e4f0f1f4d3 == 0)
				{
					goto IL_0070;
				}
				goto IL_01E8;
				IL_0042:
				int num7;
				num6 = num7;
				goto IL_0044;
				IL_0070:
				num7 = int_0 - num3;
				goto IL_0042;
				IL_002C:
				if (int_0 - num3 > 128 - num4)
				{
					num7 = 128 - num4;
					goto IL_0042;
				}
				goto IL_0070;
				IL_0076:
				if (num5 >= num2 - 1)
				{
					goto IL_00B6;
				}
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_871a407507f34aa3b5bf52517d4f63a9 == 0)
				{
					goto IL_0093;
				}
				goto IL_01E8;
				IL_0196:
				stringBuilder.Append(this.OuLjCeRksR, 0, chars2);
				goto IL_0076;
				IL_00B9:
				if (num3 >= int_0)
				{
					goto IL_02B2;
				}
				num = 4;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_67cbcb2ad04040d48847c1ca2f65be32 == 0)
				{
					goto IL_002C;
				}
				goto IL_01E8;
				IL_00B6:
				num4 = 0;
				goto IL_00B9;
				IL_009C:
				Array.Copy(this.TmnjOycGdr, num5 + 1, this.TmnjOycGdr, 0, num4);
				goto IL_00B9;
				IL_0093:
				num4 = num2 - num5 - 1;
				goto IL_009C;
				IL_01D1:
				stringBuilder = null;
				num = 25;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8d68b74cee6442019d959192b2974e3d != 0)
				{
					goto IL_0196;
				}
				goto IL_01E8;
			}
			Block_6:
			goto IL_02A3;
			Block_10:
			Block_13:
			goto IL_029C;
			IL_0281:
			throw new EndOfStreamException(Class15.smethod_17(1396518992 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4152404f503b492c83d9bc2e44bdd0a7));
			IL_029C:
			return string.Empty;
			IL_02A3:
			return new string(this.OuLjCeRksR, 0, chars);
			IL_02B2:
			return stringBuilder.ToString();
		}

		// Token: 0x0600136B RID: 4971 RVA: 0x00099904 File Offset: 0x00097B04
		private int method_21(int int_0)
		{
			int i;
			int num2;
			for (;;)
			{
				IL_00DE:
				i = int_0;
				int num = 4;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f77f8ab5a3534e2e914063d52217b4e1 == 0)
				{
					goto IL_0088;
				}
				for (;;)
				{
					IL_009F:
					switch (num)
					{
					case 1:
						goto IL_002D;
					case 2:
					case 9:
					case 12:
						goto IL_0047;
					case 3:
						return int_0;
					case 4:
						goto IL_0088;
					case 5:
						goto IL_00DE;
					case 6:
					case 8:
						goto IL_00FB;
					case 7:
						i--;
						num = 3;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ca6ac77a767741aa91cb31f8080f093b == 0)
						{
							goto Block_5;
						}
						continue;
					case 10:
						goto IL_0017;
					case 11:
						goto IL_0006;
					}
					break;
					IL_0047:
					while (i < 0)
					{
						num = 6;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_550a8fe2e5fe4cc19bdfe1a82a7f12b8 == 0)
						{
							goto IL_009F;
						}
					}
					goto IL_0006;
					IL_0017:
					if (num2 != 0)
					{
						break;
					}
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0361b8eb39074ea88f5257b13904930a == 0)
					{
						goto IL_002D;
					}
					continue;
					IL_0006:
					num2 = this.method_22(this.TmnjOycGdr[i]);
					goto IL_0017;
					IL_002D:
					i--;
					goto IL_0047;
				}
				IL_004F:
				if (num2 == 1)
				{
					goto IL_00FB;
				}
				num = 7;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0b405dced5e94c80928a74c5773182d9 != 0)
				{
					break;
				}
				goto IL_009F;
				IL_0088:
				num2 = 0;
				num = 9;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5e301544981d4903aa4e531970a47849 != 0)
				{
					goto IL_004F;
				}
				goto IL_009F;
			}
			return int_0;
			Block_5:
			IL_00FB:
			if (num2 != int_0 - i)
			{
				return i;
			}
			return int_0;
		}

		// Token: 0x0600136C RID: 4972 RVA: 0x00099A18 File Offset: 0x00097C18
		private int method_22(byte byte_4)
		{
			while (byte_4 > BsonReader.byte_0[1])
			{
				if (byte_4 >= BsonReader.byte_1[0])
				{
					goto IL_002D;
				}
				goto IL_00B6;
				IL_004B:
				int num;
				switch (num)
				{
				case 0:
					return 0;
				case 1:
					return 2;
				case 2:
					goto IL_00A9;
				case 3:
					IL_0088:
					if (byte_4 > BsonReader.byte_2[1])
					{
						goto IL_00A9;
					}
					return 3;
				case 4:
					return 1;
				case 5:
					continue;
				case 6:
					return 3;
				case 7:
					break;
				case 8:
					return 4;
				case 9:
					IL_002D:
					if (byte_4 > BsonReader.byte_1[1])
					{
						goto IL_00B6;
					}
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93ade03426d44b1841bfa7c633f49f3 != 0)
					{
						goto IL_004B;
					}
					return 2;
				default:
					return 0;
				}
				IL_007B:
				if (byte_4 > BsonReader.byte_3[1])
				{
					return 0;
				}
				num = 3;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cbfb1e54efd84756a9b6d7b21adc0d65 == 0)
				{
					return 4;
				}
				goto IL_004B;
				IL_00A9:
				if (byte_4 >= BsonReader.byte_3[0])
				{
					goto IL_007B;
				}
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3a299c01dd4f4a209bdbd1b98e3f1406 == 0)
				{
					return 0;
				}
				goto IL_004B;
				IL_00B6:
				if (byte_4 >= BsonReader.byte_2[0])
				{
					goto IL_0088;
				}
				goto IL_00A9;
			}
			return 1;
		}

		// Token: 0x0600136D RID: 4973 RVA: 0x00099B08 File Offset: 0x00097D08
		private void method_23()
		{
			for (;;)
			{
				if (this.TmnjOycGdr != null)
				{
					goto IL_00A5;
				}
				int num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8432da17e8384a688cea4636964d3693 == 0)
				{
					goto IL_001A;
				}
				IL_0084:
				switch (num)
				{
				case 0:
					goto IL_005F;
				case 1:
					break;
				case 2:
					return;
				case 3:
					IL_001A:
					this.TmnjOycGdr = new byte[128];
					num = 5;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4ac69ea2381b403582a2723337f67fa8 != 0)
					{
						goto IL_00A5;
					}
					goto IL_0084;
				case 4:
					continue;
				case 5:
					goto IL_00A5;
				default:
					goto IL_005F;
				}
				IL_003E:
				int maxCharCount;
				this.OuLjCeRksR = new char[maxCharCount];
				num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f77f8ab5a3534e2e914063d52217b4e1 == 0)
				{
					break;
				}
				goto IL_0084;
				IL_005F:
				maxCharCount = Encoding.UTF8.GetMaxCharCount(128);
				num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_253407eb812c4aefb734fa1e267fe779 == 0)
				{
					goto IL_003E;
				}
				goto IL_0084;
				IL_00A5:
				if (this.OuLjCeRksR != null)
				{
					break;
				}
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_079bd9b874b24353bef46f6c3f5d741d == 0)
				{
					goto IL_005F;
				}
				goto IL_0084;
			}
		}

		// Token: 0x0600136E RID: 4974 RVA: 0x00099BEC File Offset: 0x00097DEC
		private double method_24()
		{
			for (;;)
			{
				this.method_28(8);
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ca6ac77a767741aa91cb31f8080f093b != 0)
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
			return this.binaryReader_0.ReadDouble();
		}

		// Token: 0x0600136F RID: 4975 RVA: 0x00099C30 File Offset: 0x00097E30
		private int method_25()
		{
			for (;;)
			{
				this.method_28(4);
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_48fe014748e848c88d3254f339047927 != 0)
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
			return this.binaryReader_0.ReadInt32();
		}

		// Token: 0x06001370 RID: 4976 RVA: 0x00099C74 File Offset: 0x00097E74
		private long method_26()
		{
			for (;;)
			{
				this.method_28(8);
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_100d09ce3850492c8356d7fa1e667d54 != 0)
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
			return this.binaryReader_0.ReadInt64();
		}

		// Token: 0x06001371 RID: 4977 RVA: 0x00099CB8 File Offset: 0x00097EB8
		private BsonType method_27()
		{
			for (;;)
			{
				this.method_28(1);
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_bc7a9075386042ad9ce36653fcde3fc3 != 0)
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
			return (BsonType)this.binaryReader_0.ReadSByte();
		}

		// Token: 0x06001372 RID: 4978 RVA: 0x00099CFC File Offset: 0x00097EFC
		private void method_28(int int_0)
		{
			for (;;)
			{
				this.class13_0.int_1 += int_0;
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b3c865ee224546b18f2991d2a8895f6a == 0)
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

		// Token: 0x06001373 RID: 4979 RVA: 0x00099D40 File Offset: 0x00097F40
		private byte[] method_29(int int_0)
		{
			for (;;)
			{
				this.method_28(int_0);
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4b8a72ce901241b5b52fe60600cb3607 != 0)
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
			return this.binaryReader_0.ReadBytes(int_0);
		}

		// Token: 0x06001374 RID: 4980 RVA: 0x00099D84 File Offset: 0x00097F84
		static BsonReader()
		{
			for (;;)
			{
				for (;;)
				{
					int num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8db627a8c96145a0afb24deffd2a8808 == 0)
					{
						goto IL_0003;
					}
					IL_0024:
					switch (num)
					{
					case 1:
						IL_0003:
						BsonReader.byte_0 = new byte[] { 0, 127 };
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_db7740c6ca7a4f3c8e1aa526bdb0a454 != 0)
						{
							goto IL_0024;
						}
						break;
					case 2:
						goto IL_007C;
					case 3:
						goto IL_0097;
					case 4:
						return;
					case 5:
						continue;
					case 6:
						continue;
					}
					goto Block_1;
				}
			}
			Block_1:
			BsonReader.byte_1 = new byte[] { 194, 223 };
			IL_007C:
			BsonReader.byte_2 = new byte[] { 224, 239 };
			IL_0097:
			BsonReader.byte_3 = new byte[] { 240, 244 };
		}

		// Token: 0x04000846 RID: 2118
		private static readonly byte[] byte_0;

		// Token: 0x04000847 RID: 2119
		private static readonly byte[] byte_1;

		// Token: 0x04000848 RID: 2120
		private static readonly byte[] byte_2;

		// Token: 0x04000849 RID: 2121
		private static readonly byte[] byte_3;

		// Token: 0x0400084A RID: 2122
		private readonly BinaryReader binaryReader_0;

		// Token: 0x0400084B RID: 2123
		private readonly List<BsonReader.Class13> list_1;

		// Token: 0x0400084C RID: 2124
		private byte[] TmnjOycGdr;

		// Token: 0x0400084D RID: 2125
		private char[] OuLjCeRksR;

		// Token: 0x0400084E RID: 2126
		private BsonType bsonType_0;

		// Token: 0x0400084F RID: 2127
		private BsonReader.Enum1 enum1_0;

		// Token: 0x04000850 RID: 2128
		private BsonReader.Class13 class13_0;

		// Token: 0x04000851 RID: 2129
		private bool bool_3;

		// Token: 0x04000852 RID: 2130
		private bool bool_4;

		// Token: 0x04000853 RID: 2131
		private DateTimeKind dateTimeKind_0;

		// Token: 0x020001B9 RID: 441
		private enum Enum1
		{
			// Token: 0x04000856 RID: 2134
			Normal,
			// Token: 0x04000857 RID: 2135
			ReferenceStart,
			// Token: 0x04000858 RID: 2136
			ReferenceRef,
			// Token: 0x04000859 RID: 2137
			ReferenceId,
			// Token: 0x0400085A RID: 2138
			CodeWScopeStart,
			// Token: 0x0400085B RID: 2139
			CodeWScopeCode,
			// Token: 0x0400085C RID: 2140
			CodeWScopeScope,
			// Token: 0x0400085D RID: 2141
			CodeWScopeScopeObject,
			// Token: 0x0400085E RID: 2142
			const_8
		}

		// Token: 0x020001BA RID: 442
		private class Class13
		{
			// Token: 0x06001377 RID: 4983 RVA: 0x00099E44 File Offset: 0x00098044
			public Class13(BsonType bsonType_1)
			{
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3a299c01dd4f4a209bdbd1b98e3f1406 != 0)
				{
					goto IL_0032;
				}
				IL_001A:
				this.bsonType_0 = bsonType_1;
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93c7140125045538ae5c40c6f39a5af == 0)
				{
					return;
				}
				IL_0032:
				switch (num)
				{
				case 1:
					goto IL_001A;
				}
			}

			// Token: 0x0400085F RID: 2143
			public readonly BsonType bsonType_0;

			// Token: 0x04000860 RID: 2144
			public int int_0;

			// Token: 0x04000861 RID: 2145
			public int int_1;
		}
	}
}
