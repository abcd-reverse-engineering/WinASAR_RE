using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Bson
{
	// Token: 0x020001B6 RID: 438
	internal class BsonBinaryWriter
	{
		// Token: 0x170002D8 RID: 728
		// (get) Token: 0x0600133F RID: 4927 RVA: 0x00006F87 File Offset: 0x00005187
		// (set) Token: 0x06001340 RID: 4928 RVA: 0x00096D94 File Offset: 0x00094F94
		public DateTimeKind DateTimeKindHandling
		{
			[CompilerGenerated]
			get
			{
				return this.dateTimeKind_0;
			}
			[CompilerGenerated]
			set
			{
				for (;;)
				{
					this.dateTimeKind_0 = value;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_57ce3fecb9e64a8f924ea7658e146719 != 0)
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

		// Token: 0x06001341 RID: 4929 RVA: 0x00096DCC File Offset: 0x00094FCC
		public BsonBinaryWriter(BinaryWriter writer)
		{
			int num = 2;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e764f065c2fa404a85129e2e957d4f18 != 0)
			{
				goto IL_004B;
			}
			IL_001A:
			this.DateTimeKindHandling = DateTimeKind.Utc;
			num = 1;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_6bf87ae21d2446cfa7edc53669bb8039 == 0)
			{
				goto IL_004B;
			}
			IL_0033:
			this.binaryWriter_0 = writer;
			num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_832998aae3714af0a1270bf2bb566909 == 0)
			{
				return;
			}
			IL_004B:
			switch (num)
			{
			case 1:
				goto IL_0033;
			case 2:
				goto IL_001A;
			}
		}

		// Token: 0x06001342 RID: 4930 RVA: 0x00096E3C File Offset: 0x0009503C
		public void Flush()
		{
			for (;;)
			{
				this.binaryWriter_0.Flush();
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8f48544341da433d9f954b548c7e9212 == 0)
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

		// Token: 0x06001343 RID: 4931 RVA: 0x00096E78 File Offset: 0x00095078
		public void Close()
		{
			for (;;)
			{
				this.binaryWriter_0.Close();
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e368897ba1744663a6d0bc59b9b65b5f != 0)
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

		// Token: 0x06001344 RID: 4932 RVA: 0x00096EB4 File Offset: 0x000950B4
		public void WriteToken(BsonToken t)
		{
			for (;;)
			{
				this.method_4(t);
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bca7529ca324c188cfc0e64eb7d1cdf != 0)
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
				this.method_0(t);
				num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_75738dd4edc84122bfe3748a1ea03d43 != 0)
				{
					goto IL_001B;
				}
				break;
			}
		}

		// Token: 0x06001345 RID: 4933 RVA: 0x00096F10 File Offset: 0x00095110
		private void method_0(BsonToken bsonToken_0)
		{
			DateTime dateTime;
			BsonObject bsonObject;
			byte[] array2;
			long num5;
			DateTimeOffset dateTimeOffset;
			for (;;)
			{
				IL_058F:
				BsonType type = bsonToken_0.Type;
				int num = 37;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e5c1d856e0c64e6f8377f7d819e11923 == 0)
				{
					goto Block_18;
				}
				for (;;)
				{
					IL_04C0:
					BsonBinary bsonBinary;
					BsonValue bsonValue;
					BsonValue bsonValue2;
					BsonArray bsonArray;
					byte[] array;
					BsonValue bsonValue3;
					BsonValue bsonValue4;
					switch (num)
					{
					case 1:
						goto IL_0621;
					case 2:
						goto IL_05B1;
					case 3:
						return;
					case 4:
					case 39:
						goto IL_07EA;
					case 5:
						goto IL_033A;
					case 6:
						return;
					case 7:
						this.binaryWriter_0.Write((byte)bsonBinary.BinaryType);
						num = 1;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_48fe014748e848c88d3254f339047927 != 0)
						{
							continue;
						}
						goto IL_05CB;
					case 8:
						goto IL_0408;
					case 9:
						return;
					case 10:
						goto IL_0298;
					case 11:
						goto IL_0467;
					case 12:
						return;
					case 13:
						goto IL_042F;
					case 14:
						return;
					case 15:
						goto IL_03FB;
					case 16:
						goto IL_032C;
					case 17:
						goto IL_0411;
					case 18:
						goto IL_008A;
					case 19:
						goto IL_0081;
					case 20:
						goto IL_02D6;
					case 21:
						goto IL_05DB;
					case 22:
						return;
					case 23:
						goto IL_038A;
					case 24:
					case 46:
						goto IL_07E0;
					case 25:
						goto IL_01F6;
					case 26:
						goto IL_0604;
					case 27:
						goto IL_0697;
					case 28:
						return;
					case 29:
						return;
					case 30:
						goto IL_02CE;
					case 31:
						goto IL_07CF;
					case 32:
						return;
					case 33:
						goto IL_0638;
					case 34:
						goto IL_0076;
					case 35:
						goto IL_0665;
					case 36:
						goto IL_043A;
					case 37:
						for (;;)
						{
							switch (type)
							{
							case BsonType.Number:
								goto IL_0290;
							case BsonType.String:
								goto IL_05D3;
							case BsonType.Object:
								goto IL_02CE;
							case BsonType.Array:
								goto IL_0302;
							case BsonType.Binary:
								goto IL_0324;
							case BsonType.Undefined:
							case BsonType.Null:
								return;
							case BsonType.Oid:
								goto IL_0363;
							case BsonType.Boolean:
								goto IL_03B1;
							case BsonType.Date:
								goto IL_03DE;
							case BsonType.Regex:
								goto IL_0630;
							case BsonType.Integer:
								bsonValue = (BsonValue)bsonToken_0;
								num = 42;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5e301544981d4903aa4e531970a47849 != 0)
								{
									continue;
								}
								goto IL_04C0;
							case BsonType.Long:
								goto IL_045F;
							}
							goto Block_8;
						}
						IL_0290:
						bsonValue2 = (BsonValue)bsonToken_0;
						goto IL_0298;
						IL_0302:
						bsonArray = (BsonArray)bsonToken_0;
						num = 43;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_207f975845fc40cdbe6b166fce664cd5 != 0)
						{
							goto IL_0467;
						}
						continue;
						IL_0324:
						bsonBinary = (BsonBinary)bsonToken_0;
						goto IL_032C;
						IL_0363:
						array = (byte[])((BsonValue)bsonToken_0).Value;
						num = 5;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_55c1fea936c04e47abbfb2b5f778aff7 == 0)
						{
							goto IL_038A;
						}
						continue;
						IL_03B1:
						this.binaryWriter_0.Write(bsonToken_0 == BsonBoolean.True);
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_991c06e999c744809f5b643cb7d9e7b4 == 0)
						{
							break;
						}
						continue;
						IL_03DE:
						bsonValue3 = (BsonValue)bsonToken_0;
						num = 9;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_6bf87ae21d2446cfa7edc53669bb8039 != 0)
						{
							goto IL_03FB;
						}
						continue;
						IL_045F:
						bsonValue4 = (BsonValue)bsonToken_0;
						goto IL_0467;
					case 38:
						goto IL_058F;
					case 40:
						goto IL_06DE;
					case 41:
						if (this.DateTimeKindHandling == DateTimeKind.Utc)
						{
							goto Block_5;
						}
						goto IL_01F6;
					case 42:
						goto IL_01B1;
					case 43:
						this.binaryWriter_0.Write(bsonArray.CalculatedSize);
						num = 4;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5f127c3ec2e04c11ab1bd26a8d965f2b != 0)
						{
							goto IL_0076;
						}
						continue;
					case 44:
						return;
					case 45:
						goto IL_0029;
					case 47:
						goto IL_0006;
					case 48:
						goto IL_07F8;
					}
					goto Block_17;
					IL_0006:
					dateTime = dateTime.ToLocalTime();
					num = 9;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ae8c3d3c66a64b57beca0f5360302062 == 0)
					{
						goto Block_1;
					}
					continue;
					IL_0029:
					this.binaryWriter_0.Write(0);
					num = 26;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_550a8fe2e5fe4cc19bdfe1a82a7f12b8 == 0)
					{
						goto Block_2;
					}
					continue;
					IL_008A:
					IEnumerator<BsonToken> enumerator;
					ulong num3;
					try
					{
						while (enumerator.MoveNext())
						{
							for (;;)
							{
								BsonToken bsonToken = enumerator.Current;
								int num2 = 1;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_aa43e77a676848e0bd70abf647d6a9f1 == 0)
								{
									goto IL_00F5;
								}
								IL_011B:
								switch (num2)
								{
								case 1:
									IL_00F5:
									this.binaryWriter_0.Write((sbyte)bsonToken.Type);
									num2 = 4;
									if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e6fac70dd3e841b6925374855ecd7fb1 != 0)
									{
										goto IL_00BE;
									}
									goto IL_011B;
								case 2:
									goto IL_0166;
								case 3:
									goto IL_0099;
								case 4:
									goto IL_00BE;
								case 5:
									goto IL_0091;
								case 6:
									continue;
								}
								break;
								IL_0099:
								num3 += 1UL;
								num2 = 0;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_550a8fe2e5fe4cc19bdfe1a82a7f12b8 != 0)
								{
									break;
								}
								goto IL_011B;
								IL_0091:
								this.method_0(bsonToken);
								goto IL_0099;
								IL_00BE:
								this.method_1(num3.ToString(CultureInfo.InvariantCulture), MathUtils.IntLength(num3), null);
								num2 = 2;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2a74c5ebb7d84adcad853e2eda393dc4 == 0)
								{
									goto IL_0091;
								}
								goto IL_011B;
							}
						}
						IL_0166:
						goto IL_0029;
					}
					finally
					{
						if (enumerator != null)
						{
							goto IL_0197;
						}
						int num4 = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5e301544981d4903aa4e531970a47849 == 0)
						{
							goto IL_01B0;
						}
						IL_0183:
						switch (num4)
						{
						case 2:
							IL_0197:
							enumerator.Dispose();
							num4 = 0;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5be00c24d71649dcae8af3eed7b74ac9 != 0)
							{
								goto IL_0183;
							}
							break;
						}
						IL_01B0:;
					}
					goto IL_01B1;
					IL_0081:
					enumerator = bsonArray.GetEnumerator();
					goto IL_008A;
					IL_0076:
					num3 = 0UL;
					goto IL_0081;
					IL_01B1:
					this.binaryWriter_0.Write(Convert.ToInt32(bsonValue.Value, CultureInfo.InvariantCulture));
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_afb77be96d644a2297c7f9466cb06ede == 0)
					{
						goto Block_4;
					}
					continue;
					IL_01F6:
					if (this.DateTimeKindHandling != DateTimeKind.Local)
					{
						goto IL_07E0;
					}
					num = 5;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7ae4da5a55de471eb12dd0de8dd4269c == 0)
					{
						goto IL_0006;
					}
					continue;
					IL_0298:
					this.binaryWriter_0.Write(Convert.ToDouble(bsonValue2.Value, CultureInfo.InvariantCulture));
					num = 28;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b3c865ee224546b18f2991d2a8895f6a != 0)
					{
						goto Block_9;
					}
					continue;
					IL_02D6:
					this.binaryWriter_0.Write(bsonObject.CalculatedSize);
					num = 3;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b3c865ee224546b18f2991d2a8895f6a == 0)
					{
						goto Block_10;
					}
					continue;
					IL_02CE:
					bsonObject = (BsonObject)bsonToken_0;
					goto IL_02D6;
					IL_033A:
					this.binaryWriter_0.Write(array2.Length);
					num = 7;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c5a086ee5649458eb5e1e6e4f0f1f4d3 == 0)
					{
						goto Block_12;
					}
					continue;
					IL_032C:
					array2 = (byte[])bsonBinary.Value;
					goto IL_033A;
					IL_038A:
					this.binaryWriter_0.Write(array);
					num = 2;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_eaded84ad5b14e1ea8d4d97bfed1bb48 != 0)
					{
						goto Block_13;
					}
					continue;
					IL_0411:
					object value;
					dateTime = (DateTime)value;
					num = 41;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_550a8fe2e5fe4cc19bdfe1a82a7f12b8 != 0)
					{
						goto IL_042F;
					}
					continue;
					IL_0408:
					if (value is DateTime)
					{
						goto IL_0411;
					}
					goto IL_043A;
					IL_042F:
					value = bsonValue3.Value;
					goto IL_0408;
					IL_03FB:
					num5 = 0L;
					goto IL_042F;
					IL_043A:
					dateTimeOffset = (DateTimeOffset)bsonValue3.Value;
					num = 2;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_725e5f82c8704b39b66ebddcee8df7fa == 0)
					{
						goto Block_15;
					}
					continue;
					IL_0467:
					this.binaryWriter_0.Write(Convert.ToInt64(bsonValue4.Value, CultureInfo.InvariantCulture));
					num = 32;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4152404f503b492c83d9bc2e44bdd0a7 == 0)
					{
						goto Block_16;
					}
				}
			}
			Block_1:
			goto IL_07E0;
			Block_2:
			return;
			Block_4:
			return;
			Block_5:
			goto IL_07CF;
			Block_8:
			goto IL_0697;
			Block_9:
			return;
			Block_10:
			goto IL_0604;
			Block_12:
			return;
			Block_13:
			return;
			Block_15:
			goto IL_0621;
			Block_16:
			return;
			Block_17:
			return;
			Block_18:
			return;
			IL_05B1:
			num5 = DateTimeUtils.ConvertDateTimeToJavaScriptTicks(dateTimeOffset.UtcDateTime, dateTimeOffset.Offset);
			goto IL_07EA;
			IL_05CB:
			goto IL_0621;
			IL_05D3:
			BsonString bsonString = (BsonString)bsonToken_0;
			IL_05DB:
			this.method_1((string)bsonString.Value, bsonString.ByteCount, new int?(bsonString.CalculatedSize - 4));
			return;
			IL_0604:
			IEnumerator<BsonProperty> enumerator2 = bsonObject.GetEnumerator();
			goto IL_06DE;
			IL_0621:
			this.binaryWriter_0.Write(array2);
			return;
			IL_0630:
			BsonRegex bsonRegex = (BsonRegex)bsonToken_0;
			IL_0638:
			this.method_1((string)bsonRegex.Pattern.Value, bsonRegex.Pattern.ByteCount, null);
			IL_0665:
			this.method_1((string)bsonRegex.Options.Value, bsonRegex.Options.ByteCount, null);
			return;
			IL_0697:
			throw new ArgumentOutOfRangeException(Class15.smethod_17(486519522 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39d5fbfa4fe34ed9908db538e5340a6c), Class15.smethod_17(642178844 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa29cbda752f45acbe81e7d5285df2ba).FormatWith(CultureInfo.InvariantCulture, bsonToken_0.Type));
			IL_06DE:
			try
			{
				IL_0782:
				while (enumerator2.MoveNext())
				{
					for (;;)
					{
						IL_0764:
						BsonProperty bsonProperty = enumerator2.Current;
						int num6 = 5;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0361b8eb39074ea88f5257b13904930a != 0)
						{
							for (;;)
							{
								switch (num6)
								{
								default:
									goto IL_0764;
								case 1:
									goto IL_0782;
								case 2:
									goto IL_078B;
								case 3:
									goto IL_06FC;
								case 4:
									break;
								case 5:
									this.binaryWriter_0.Write((sbyte)bsonProperty.Value.Type);
									goto IL_06FC;
								}
								IL_0729:
								this.method_0(bsonProperty.Value);
								num6 = 1;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cb7e1ff8cc1348bebf46c510e64a0134 == 0)
								{
									continue;
								}
								goto IL_0781;
								IL_06FC:
								this.method_1((string)bsonProperty.Name.Value, bsonProperty.Name.ByteCount, null);
								goto IL_0729;
							}
						}
					}
					IL_0781:;
				}
				IL_078B:
				goto IL_07F8;
			}
			finally
			{
				if (enumerator2 != null)
				{
					int num7 = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39d5fbfa4fe34ed9908db538e5340a6c != 0)
					{
						for (;;)
						{
							switch (num7)
							{
							case 1:
								enumerator2.Dispose();
								num7 = 0;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_55c1fea936c04e47abbfb2b5f778aff7 != 0)
								{
									continue;
								}
								break;
							}
							break;
						}
					}
				}
			}
			IL_07CF:
			dateTime = dateTime.ToUniversalTime();
			IL_07E0:
			num5 = DateTimeUtils.ConvertDateTimeToJavaScriptTicks(dateTime, false);
			IL_07EA:
			this.binaryWriter_0.Write(num5);
			return;
			IL_07F8:
			this.binaryWriter_0.Write(0);
		}

		// Token: 0x06001346 RID: 4934 RVA: 0x00006F8F File Offset: 0x0000518F
		private void method_1(string string_0, int int_0, int? nullable_0)
		{
			if (nullable_0 != null)
			{
				this.binaryWriter_0.Write(nullable_0.GetValueOrDefault());
			}
			this.WriteUtf8Bytes(string_0, int_0);
			this.binaryWriter_0.Write(0);
		}

		// Token: 0x06001347 RID: 4935 RVA: 0x00097740 File Offset: 0x00095940
		public void WriteUtf8Bytes(string s, int byteCount)
		{
			IL_00C1:
			while (s != null)
			{
				for (;;)
				{
					IL_00B3:
					byte[] bytes;
					if (byteCount > 256)
					{
						bytes = BsonBinaryWriter.encoding_0.GetBytes(s);
						goto IL_007E;
					}
					int num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b17e63564ae246399767b60cf4b1528a != 0)
					{
						break;
					}
					for (;;)
					{
						IL_004A:
						switch (num)
						{
						case 1:
							if (this.byte_0 == null)
							{
								goto IL_0015;
							}
							break;
						case 2:
							goto IL_007E;
						case 3:
							return;
						case 4:
							goto IL_00B3;
						case 5:
						case 10:
							return;
						case 6:
							goto IL_00C1;
						case 7:
							goto IL_00E8;
						case 9:
							goto IL_0015;
						}
						goto Block_3;
						IL_0015:
						this.byte_0 = new byte[256];
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_11c6824de6514281a8425f6d6ab1a2d5 != 0)
						{
							goto Block_1;
						}
					}
					IL_007E:
					this.binaryWriter_0.Write(bytes);
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_186d640068094cc595a341ef95c9a29a == 0)
					{
						goto Block_4;
					}
					goto IL_004A;
				}
				Block_1:
				Block_3:
				goto IL_00CE;
				Block_4:
				break;
				IL_00CE:
				BsonBinaryWriter.encoding_0.GetBytes(s, 0, s.Length, this.byte_0, 0);
				IL_00E8:
				this.binaryWriter_0.Write(this.byte_0, 0, byteCount);
				return;
			}
		}

		// Token: 0x06001348 RID: 4936 RVA: 0x00006FC0 File Offset: 0x000051C0
		private int method_2(int int_0)
		{
			return int_0 + 1;
		}

		// Token: 0x06001349 RID: 4937 RVA: 0x0009784C File Offset: 0x00095A4C
		private int method_3(int int_0, bool bool_0)
		{
			int num2;
			while (!bool_0)
			{
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c28a4ed7a58e45aaa9902e336fd60b97 != 0)
				{
					switch (num)
					{
					case 1:
						continue;
					}
				}
				num2 = 1;
				IL_002F:
				return num2 + int_0;
			}
			num2 = 5;
			goto IL_002F;
		}

		// Token: 0x0600134A RID: 4938 RVA: 0x0009788C File Offset: 0x00095A8C
		private int method_4(BsonToken bsonToken_0)
		{
			int num2;
			BsonString bsonString;
			BsonArray bsonArray;
			BsonRegex bsonRegex;
			int num6;
			string text;
			for (;;)
			{
				IL_043F:
				BsonType type = bsonToken_0.Type;
				int num = 17;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_370349efcd7c4959a098549c3d5bf14d == 0)
				{
					break;
				}
				for (;;)
				{
					IL_03CC:
					switch (num)
					{
					case 0:
						goto IL_0365;
					case 1:
						return num2;
					case 2:
						goto IL_0164;
					case 3:
						break;
					case 4:
						goto IL_0464;
					case 5:
						goto IL_0140;
					case 6:
						goto IL_04B0;
					case 7:
						goto IL_0532;
					case 8:
						goto IL_0529;
					case 9:
						goto IL_011D;
					case 10:
						goto IL_038A;
					case 11:
						goto IL_04F8;
					case 12:
						goto IL_0392;
					case 13:
						goto IL_0513;
					case 14:
						goto IL_0520;
					case 15:
						goto IL_02A9;
					case 16:
						goto IL_0152;
					case 17:
						switch (type)
						{
						case BsonType.Number:
							return 8;
						case BsonType.String:
							bsonString = (BsonString)bsonToken_0;
							num = 0;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4b8a72ce901241b5b52fe60600cb3607 == 0)
							{
								goto IL_0365;
							}
							continue;
						case BsonType.Object:
							goto IL_038A;
						case BsonType.Array:
							bsonArray = (BsonArray)bsonToken_0;
							goto IL_02CC;
						case BsonType.Binary:
							goto IL_0480;
						case BsonType.Undefined:
						case BsonType.Null:
							return 0;
						case BsonType.Oid:
							return 12;
						case BsonType.Boolean:
							return 1;
						case BsonType.Date:
							return 8;
						case BsonType.Regex:
							bsonRegex = (BsonRegex)bsonToken_0;
							goto IL_013D;
						case BsonType.Integer:
							return 4;
						case BsonType.Long:
							return 8;
						}
						goto Block_7;
					case 18:
						goto IL_043F;
					case 19:
						goto IL_02A3;
					case 20:
						goto IL_000F;
					case 21:
						goto IL_02CF;
					case 22:
						goto IL_02CC;
					case 23:
						try
						{
							for (;;)
							{
								IL_024B:
								IEnumerator<BsonProperty> enumerator;
								if (enumerator.MoveNext())
								{
									goto IL_0229;
								}
								int num3 = 0;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_eaded84ad5b14e1ea8d4d97bfed1bb48 == 0)
								{
									break;
								}
								int num4;
								BsonProperty bsonProperty;
								do
								{
									IL_01EE:
									switch (num3)
									{
									case 1:
										goto IL_0229;
									case 2:
										goto IL_01B2;
									case 3:
										goto IL_01D6;
									case 4:
										goto IL_024B;
									case 5:
										num4 += this.method_4(bsonProperty.Name);
										num3 = 2;
										if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_548c52e5632b45898e377ad9c9a06469 == 0)
										{
											goto IL_01B2;
										}
										continue;
									case 6:
										goto IL_0212;
									}
									goto Block_24;
									IL_01B2:
									num4 += this.method_4(bsonProperty.Value);
									num3 = 0;
									if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9bd9937edf9d4ad8bd673dfcb5a5e3cb != 0)
									{
										continue;
									}
									IL_01D6:
									num2 += num4;
									num3 = 1;
								}
								while (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_bc7a9075386042ad9ce36653fcde3fc3 != 0);
								continue;
								IL_0212:
								num4 = 1;
								num3 = 5;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8f48544341da433d9f954b548c7e9212 != 0)
								{
									break;
								}
								goto IL_01EE;
								IL_0229:
								bsonProperty = enumerator.Current;
								goto IL_0212;
							}
							Block_24:;
						}
						finally
						{
							IEnumerator<BsonProperty> enumerator;
							if (enumerator != null)
							{
								goto IL_0289;
							}
							int num5 = 0;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2a74c5ebb7d84adcad853e2eda393dc4 != 0)
							{
								goto IL_02A2;
							}
							IL_0275:
							switch (num5)
							{
							case 2:
								IL_0289:
								enumerator.Dispose();
								num5 = 1;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_871a407507f34aa3b5bf52517d4f63a9 == 0)
								{
									goto IL_0275;
								}
								break;
							}
							IL_02A2:;
						}
						goto IL_02A3;
					case 24:
						goto IL_013D;
					case 25:
					{
						IEnumerator<BsonToken> enumerator2 = bsonArray.GetEnumerator();
						goto IL_000F;
					}
					default:
						goto IL_0365;
					}
					BsonObject bsonObject;
					for (;;)
					{
						IL_0395:
						IEnumerator<BsonProperty> enumerator = bsonObject.GetEnumerator();
						num = 23;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7dfc957a76cb4c58b17dc74a084c4e4a != 0)
						{
							goto IL_03CC;
						}
					}
					IL_011D:
					num6++;
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ae8c3d3c66a64b57beca0f5360302062 == 0)
					{
						goto Block_2;
					}
					continue;
					IL_000F:
					ulong num8;
					try
					{
						for (;;)
						{
							IEnumerator<BsonToken> enumerator2;
							if (enumerator2.MoveNext())
							{
								goto IL_0095;
							}
							int num7 = 5;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3a102d6e4dd542a6855b81a93c692545 != 0)
							{
								continue;
							}
							goto IL_0071;
							IL_0047:
							num8 += 1UL;
							num7 = 3;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ca6ac77a767741aa91cb31f8080f093b == 0)
							{
								continue;
							}
							goto IL_0071;
							IL_0028:
							BsonToken bsonToken;
							num6 += this.method_4(bsonToken);
							num7 = 0;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cb7e1ff8cc1348bebf46c510e64a0134 == 0)
							{
								goto IL_0047;
							}
							goto IL_0071;
							IL_0016:
							num6 += this.method_2(MathUtils.IntLength(num8));
							goto IL_0028;
							IL_0069:
							num6++;
							goto IL_0016;
							IL_0071:
							switch (num7)
							{
							case 0:
								goto IL_0069;
							case 1:
								goto IL_0047;
							case 2:
								goto IL_0028;
							case 3:
								break;
							case 4:
								goto IL_0016;
							case 5:
								goto IL_00D3;
							case 6:
								IL_0095:
								bsonToken = enumerator2.Current;
								num7 = 0;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7ae4da5a55de471eb12dd0de8dd4269c == 0)
								{
									goto IL_0069;
								}
								goto IL_0071;
							default:
								goto IL_0069;
							}
						}
						IL_00D3:;
					}
					finally
					{
						IEnumerator<BsonToken> enumerator2;
						int num9;
						if (enumerator2 == null)
						{
							num9 = 0;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3baf10aa2a73406aa2bb349717d797c7 == 0)
							{
								goto IL_011C;
							}
							goto IL_00ED;
						}
						do
						{
							IL_0101:
							enumerator2.Dispose();
							num9 = 2;
						}
						while (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ad967bb0ba3f44528134c153f7ab1ef6 == 0);
						IL_00ED:
						switch (num9)
						{
						case 1:
							goto IL_0101;
						}
						IL_011C:;
					}
					goto IL_011D;
					IL_0164:
					int num10;
					bsonRegex.CalculatedSize = num10;
					num = 12;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4b8a72ce901241b5b52fe60600cb3607 == 0)
					{
						goto Block_3;
					}
					continue;
					IL_0152:
					num10 += this.method_4(bsonRegex.Options);
					goto IL_0164;
					IL_0140:
					num10 += this.method_4(bsonRegex.Pattern);
					goto IL_0152;
					IL_013D:
					num10 = 0;
					goto IL_0140;
					IL_02A9:
					bsonObject.CalculatedSize = num2;
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_193800745ad94a529d9e5edc977c4f02 == 0)
					{
						goto Block_5;
					}
					continue;
					IL_02A3:
					num2++;
					goto IL_02A9;
					IL_02CF:
					num8 = 0UL;
					num = 25;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93c7140125045538ae5c40c6f39a5af == 0)
					{
						goto Block_6;
					}
					continue;
					IL_02CC:
					num6 = 4;
					goto IL_02CF;
					IL_0365:
					text = (string)bsonString.Value;
					num = 2;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5f127c3ec2e04c11ab1bd26a8d965f2b != 0)
					{
						goto Block_8;
					}
					continue;
					IL_0392:
					num2 = 4;
					goto IL_0395;
					IL_038A:
					bsonObject = (BsonObject)bsonToken_0;
					goto IL_0392;
				}
			}
			Block_2:
			goto IL_0529;
			Block_3:
			goto IL_0520;
			Block_5:
			return num2;
			Block_6:
			goto IL_04F8;
			Block_7:
			goto IL_04B0;
			Block_8:
			goto IL_0464;
			goto IL_0529;
			IL_0464:
			bsonString.ByteCount = ((text == null) ? 0 : BsonBinaryWriter.encoding_0.GetByteCount(text));
			goto IL_04F8;
			IL_0480:
			BsonBinary bsonBinary = (BsonBinary)bsonToken_0;
			byte[] array = (byte[])bsonBinary.Value;
			bsonBinary.CalculatedSize = 5 + array.Length;
			return bsonBinary.CalculatedSize;
			IL_04B0:
			throw new ArgumentOutOfRangeException(Class15.smethod_17(2048546829 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e764f065c2fa404a85129e2e957d4f18), Class15.smethod_17(89026190 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_db7740c6ca7a4f3c8e1aa526bdb0a454).FormatWith(CultureInfo.InvariantCulture, bsonToken_0.Type));
			IL_04F8:
			bsonString.CalculatedSize = this.method_3(bsonString.ByteCount, bsonString.IncludeLength);
			IL_0513:
			return bsonString.CalculatedSize;
			IL_0520:
			return bsonRegex.CalculatedSize;
			IL_0529:
			bsonArray.CalculatedSize = num6;
			IL_0532:
			return bsonArray.CalculatedSize;
		}

		// Token: 0x0600134B RID: 4939 RVA: 0x00097DF0 File Offset: 0x00095FF0
		static BsonBinaryWriter()
		{
			for (;;)
			{
				IL_004F:
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3436841e08c54f56b10b76e1438d4224 != 0)
				{
					goto IL_0037;
				}
				do
				{
					IL_0022:
					num = 3;
				}
				while (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_43b32b9d66294210a955990bb6fcc511 != 0);
				for (;;)
				{
					IL_0037:
					switch (num)
					{
					case 1:
						goto IL_004F;
					case 2:
						return;
					case 3:
						BsonBinaryWriter.encoding_0 = new UTF8Encoding(false);
						num = 2;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8bcabc342a5a44748f3978da7f62051e == 0)
						{
							return;
						}
						continue;
					}
					break;
				}
				goto IL_0022;
			}
		}

		// Token: 0x0400083F RID: 2111
		private static readonly Encoding encoding_0;

		// Token: 0x04000840 RID: 2112
		private readonly BinaryWriter binaryWriter_0;

		// Token: 0x04000841 RID: 2113
		private byte[] byte_0;

		// Token: 0x04000842 RID: 2114
		[CompilerGenerated]
		private DateTimeKind dateTimeKind_0;
	}
}
