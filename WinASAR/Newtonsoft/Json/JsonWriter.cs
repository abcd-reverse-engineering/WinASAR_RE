using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json
{
	// Token: 0x02000070 RID: 112
	[Nullable(0)]
	[NullableContext(1)]
	public abstract class JsonWriter : IDisposable
	{
		// Token: 0x06000502 RID: 1282 RVA: 0x0003AF24 File Offset: 0x00039124
		internal static JsonWriter.State[][] BuildStateArray()
		{
			List<JsonWriter.State[]> list;
			for (;;)
			{
				IL_013C:
				list = JsonWriter.StateArrayTemplate.ToList<JsonWriter.State[]>();
				for (;;)
				{
					IL_0131:
					JsonWriter.State[] array = JsonWriter.StateArrayTemplate[0];
					for (;;)
					{
						IL_0126:
						JsonWriter.State[] array2 = JsonWriter.StateArrayTemplate[7];
						for (;;)
						{
							IL_010E:
							ulong[] values = EnumUtils.GetEnumValuesAndNames(typeof(JsonToken)).Values;
							for (;;)
							{
								IL_00F4:
								int num = 0;
								int num2 = 2;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5f127c3ec2e04c11ab1bd26a8d965f2b != 0)
								{
									goto IL_0011;
								}
								ulong num3;
								JsonToken jsonToken;
								for (;;)
								{
									IL_00A5:
									switch (num2)
									{
									case 1:
										goto IL_001C;
									case 2:
										goto IL_0053;
									case 3:
									case 5:
										goto IL_0011;
									case 6:
										goto IL_0126;
									case 7:
										goto IL_008D;
									case 8:
										goto IL_0097;
									case 9:
										jsonToken = (JsonToken)num3;
										num2 = 6;
										if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_57ce3fecb9e64a8f924ea7658e146719 != 0)
										{
											goto IL_008D;
										}
										continue;
									case 10:
										goto IL_010E;
									case 11:
										goto IL_0131;
									case 12:
										goto IL_013C;
									case 13:
										goto IL_00F4;
									case 14:
										goto IL_0035;
									case 15:
										goto IL_014A;
									case 16:
										goto IL_0006;
									}
									goto Block_3;
								}
								IL_0006:
								list.Add(array2);
								goto IL_006E;
								IL_008D:
								if (jsonToken - JsonToken.Integer <= 5)
								{
									goto IL_0006;
								}
								IL_0097:
								if (jsonToken - JsonToken.Date <= 1)
								{
									goto IL_0006;
								}
								goto IL_0053;
								Block_3:
								goto IL_006E;
								IL_001C:
								num3 = values[num];
								num2 = 6;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8f48544341da433d9f954b548c7e9212 == 0)
								{
									goto IL_0035;
								}
								goto IL_00A5;
								IL_0011:
								if (num < values.Length)
								{
									goto IL_001C;
								}
								goto IL_014A;
								IL_006E:
								num++;
								goto IL_0011;
								IL_0053:
								list.Add(array);
								num2 = 0;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_bc7a9075386042ad9ce36653fcde3fc3 != 0)
								{
									goto IL_006E;
								}
								goto IL_00A5;
								IL_0035:
								if (list.Count > (int)num3)
								{
									goto IL_006E;
								}
								num2 = 9;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39a47a907a8a440980940ae96da3f3ad == 0)
								{
									goto IL_0053;
								}
								goto IL_00A5;
							}
						}
					}
				}
			}
			IL_014A:
			return list.ToArray();
		}

		// Token: 0x06000503 RID: 1283 RVA: 0x0003B084 File Offset: 0x00039284
		static JsonWriter()
		{
			for (;;)
			{
				for (;;)
				{
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_afb77be96d644a2297c7f9466cb06ede != 0)
					{
						goto IL_0006;
					}
					IL_01D3:
					switch (num)
					{
					case 1:
						goto IL_020E;
					case 2:
						return;
					case 3:
						continue;
					case 4:
						continue;
					}
					IL_0006:
					JsonWriter.StateArrayTemplate = new JsonWriter.State[][]
					{
						new JsonWriter.State[]
						{
							JsonWriter.State.Error,
							JsonWriter.State.Error,
							JsonWriter.State.Error,
							JsonWriter.State.Error,
							JsonWriter.State.Error,
							JsonWriter.State.Error,
							JsonWriter.State.Error,
							JsonWriter.State.Error,
							JsonWriter.State.Error,
							JsonWriter.State.Error
						},
						new JsonWriter.State[]
						{
							JsonWriter.State.ObjectStart,
							JsonWriter.State.ObjectStart,
							JsonWriter.State.Error,
							JsonWriter.State.Error,
							JsonWriter.State.ObjectStart,
							JsonWriter.State.ObjectStart,
							JsonWriter.State.ObjectStart,
							JsonWriter.State.ObjectStart,
							JsonWriter.State.Error,
							JsonWriter.State.Error
						},
						new JsonWriter.State[]
						{
							JsonWriter.State.ArrayStart,
							JsonWriter.State.ArrayStart,
							JsonWriter.State.Error,
							JsonWriter.State.Error,
							JsonWriter.State.ArrayStart,
							JsonWriter.State.ArrayStart,
							JsonWriter.State.ArrayStart,
							JsonWriter.State.ArrayStart,
							JsonWriter.State.Error,
							JsonWriter.State.Error
						},
						new JsonWriter.State[]
						{
							JsonWriter.State.ConstructorStart,
							JsonWriter.State.ConstructorStart,
							JsonWriter.State.Error,
							JsonWriter.State.Error,
							JsonWriter.State.ConstructorStart,
							JsonWriter.State.ConstructorStart,
							JsonWriter.State.ConstructorStart,
							JsonWriter.State.ConstructorStart,
							JsonWriter.State.Error,
							JsonWriter.State.Error
						},
						new JsonWriter.State[]
						{
							JsonWriter.State.Property,
							JsonWriter.State.Error,
							JsonWriter.State.Property,
							JsonWriter.State.Property,
							JsonWriter.State.Error,
							JsonWriter.State.Error,
							JsonWriter.State.Error,
							JsonWriter.State.Error,
							JsonWriter.State.Error,
							JsonWriter.State.Error
						},
						new JsonWriter.State[]
						{
							JsonWriter.State.Start,
							JsonWriter.State.Property,
							JsonWriter.State.ObjectStart,
							JsonWriter.State.Object,
							JsonWriter.State.ArrayStart,
							JsonWriter.State.Array,
							JsonWriter.State.Constructor,
							JsonWriter.State.Constructor,
							JsonWriter.State.Error,
							JsonWriter.State.Error
						},
						new JsonWriter.State[]
						{
							JsonWriter.State.Start,
							JsonWriter.State.Property,
							JsonWriter.State.ObjectStart,
							JsonWriter.State.Object,
							JsonWriter.State.ArrayStart,
							JsonWriter.State.Array,
							JsonWriter.State.Constructor,
							JsonWriter.State.Constructor,
							JsonWriter.State.Error,
							JsonWriter.State.Error
						},
						new JsonWriter.State[]
						{
							JsonWriter.State.Start,
							JsonWriter.State.Object,
							JsonWriter.State.Error,
							JsonWriter.State.Error,
							JsonWriter.State.Array,
							JsonWriter.State.Array,
							JsonWriter.State.Constructor,
							JsonWriter.State.Constructor,
							JsonWriter.State.Error,
							JsonWriter.State.Error
						}
					};
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_43b8cdd768c545d884bf7ff1c8fefe89 == 0)
					{
						goto IL_01D3;
					}
					goto IL_020D;
				}
			}
			IL_020D:
			IL_020E:
			JsonWriter.state_0 = JsonWriter.BuildStateArray();
		}

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x06000504 RID: 1284 RVA: 0x0000349B File Offset: 0x0000169B
		// (set) Token: 0x06000505 RID: 1285 RVA: 0x0003B2AC File Offset: 0x000394AC
		public bool CloseOutput
		{
			[CompilerGenerated]
			get
			{
				return this.bool_0;
			}
			[CompilerGenerated]
			set
			{
				for (;;)
				{
					this.bool_0 = value;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_370349efcd7c4959a098549c3d5bf14d == 0)
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

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x06000506 RID: 1286 RVA: 0x000034A3 File Offset: 0x000016A3
		// (set) Token: 0x06000507 RID: 1287 RVA: 0x0003B2E4 File Offset: 0x000394E4
		public bool AutoCompleteOnClose
		{
			[CompilerGenerated]
			get
			{
				return this.bool_1;
			}
			[CompilerGenerated]
			set
			{
				for (;;)
				{
					this.bool_1 = value;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4ac69ea2381b403582a2723337f67fa8 != 0)
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

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x06000508 RID: 1288 RVA: 0x0003B31C File Offset: 0x0003951C
		protected internal int Top
		{
			get
			{
				int num3;
				for (;;)
				{
					List<JsonPosition> list = this.list_0;
					int num;
					if (list != null)
					{
						num = list.Count;
						goto IL_003A;
					}
					int num2 = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_db7740c6ca7a4f3c8e1aa526bdb0a454 == 0)
					{
						goto IL_004E;
					}
					IL_0059:
					switch (num2)
					{
					case 0:
						goto IL_004E;
					case 1:
						num = 0;
						goto IL_003A;
					case 2:
						continue;
					case 3:
						break;
					case 4:
					case 5:
						return num3;
					default:
						goto IL_004E;
					}
					IL_001F:
					num3++;
					num2 = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d97e64d0f425406b9649f2b4562a5f0e != 0)
					{
						break;
					}
					goto IL_0059;
					IL_004E:
					if (this.method_2() == JsonContainerType.None)
					{
						break;
					}
					goto IL_001F;
					IL_003A:
					num3 = num;
					num2 = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8f48544341da433d9f954b548c7e9212 != 0)
					{
						goto IL_004E;
					}
					goto IL_0059;
				}
				return num3;
			}
		}

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x06000509 RID: 1289 RVA: 0x0003B3AC File Offset: 0x000395AC
		public WriteState WriteState
		{
			get
			{
				for (;;)
				{
					JsonWriter.State state = this.state_1;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9f9b31fb7a85497499112abf86cccc98 == 0)
					{
						goto IL_0003;
					}
					IL_0043:
					switch (num)
					{
					case 1:
						continue;
					case 2:
						goto IL_0086;
					case 3:
						return WriteState.Error;
					}
					IL_0003:
					switch (state)
					{
					case JsonWriter.State.Start:
						return WriteState.Start;
					case JsonWriter.State.Property:
						return WriteState.Property;
					case JsonWriter.State.ObjectStart:
					case JsonWriter.State.Object:
						return WriteState.Object;
					case JsonWriter.State.ArrayStart:
					case JsonWriter.State.Array:
						return WriteState.Array;
					case JsonWriter.State.ConstructorStart:
					case JsonWriter.State.Constructor:
						return WriteState.Constructor;
					case JsonWriter.State.Closed:
						return WriteState.Closed;
					case JsonWriter.State.Error:
						return WriteState.Error;
					default:
						num = 2;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f19acd91a8c44846a95d09d7dc3da2ba != 0)
						{
							goto IL_0043;
						}
						goto IL_0077;
					}
				}
				IL_0077:
				IL_0086:
				throw JsonWriterException.Create(this, Class15.smethod_17(698988566 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7dfc957a76cb4c58b17dc74a084c4e4a) + this.state_1.ToString(), null);
			}
		}

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x0600050A RID: 1290 RVA: 0x0003B474 File Offset: 0x00039674
		internal string ContainerPath
		{
			get
			{
				for (;;)
				{
					if (this.jsonPosition_0.Type != JsonContainerType.None)
					{
						goto IL_002C;
					}
					int num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fd59e876ac704e7eaa7c7a24a9b3a23f == 0)
					{
						break;
					}
					IL_0014:
					switch (num)
					{
					case 1:
						IL_002C:
						if (this.list_0 != null)
						{
							goto IL_0065;
						}
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c08ab7af63da4f24a4fa3e9c7a732fae == 0)
						{
							goto IL_0014;
						}
						break;
					case 3:
						continue;
					}
					break;
				}
				return string.Empty;
				IL_0065:
				return JsonPosition.BuildPath(this.list_0, null);
			}
		}

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x0600050B RID: 1291 RVA: 0x0003B4FC File Offset: 0x000396FC
		public string Path
		{
			get
			{
				while (this.jsonPosition_0.Type != JsonContainerType.None)
				{
					if (this.state_1 != JsonWriter.State.ArrayStart)
					{
						goto IL_0078;
					}
					goto IL_00AE;
					IL_00A6:
					bool flag;
					JsonPosition? jsonPosition;
					if (flag)
					{
						jsonPosition = new JsonPosition?(this.jsonPosition_0);
						goto IL_0062;
					}
					int num = 2;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c367d9ce11cc43b595beeb4524149542 == 0)
					{
						goto IL_0022;
					}
					IL_003B:
					JsonPosition? jsonPosition2;
					switch (num)
					{
					case 0:
						goto IL_00C5;
					case 1:
						goto IL_0060;
					case 2:
						IL_0022:
						jsonPosition2 = null;
						num = 1;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c28a4ed7a58e45aaa9902e336fd60b97 == 0)
						{
							goto IL_003B;
						}
						goto IL_0060;
					case 3:
						IL_00D3:
						return string.Empty;
					case 4:
						continue;
					case 5:
						IL_0078:
						if (this.state_1 != JsonWriter.State.ConstructorStart)
						{
							goto IL_0081;
						}
						goto IL_00AE;
					case 6:
						goto IL_0081;
					default:
						goto IL_00C5;
					}
					IL_0062:
					JsonPosition? jsonPosition3 = jsonPosition;
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_75738dd4edc84122bfe3748a1ea03d43 != 0)
					{
						goto IL_00C5;
					}
					goto IL_003B;
					IL_0060:
					jsonPosition = jsonPosition2;
					goto IL_0062;
					IL_00C5:
					return JsonPosition.BuildPath(this.list_0, jsonPosition3);
					IL_00AE:
					flag = false;
					goto IL_00A6;
					IL_0081:
					flag = this.state_1 != JsonWriter.State.ObjectStart;
					goto IL_00A6;
				}
				goto IL_00D3;
			}
		}

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x0600050C RID: 1292 RVA: 0x000034AB File Offset: 0x000016AB
		// (set) Token: 0x0600050D RID: 1293 RVA: 0x0003B5E4 File Offset: 0x000397E4
		public Formatting Formatting
		{
			get
			{
				return this.formatting_0;
			}
			set
			{
				while (value >= Formatting.None)
				{
					int num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_67cbcb2ad04040d48847c1ca2f65be32 == 0)
					{
						goto IL_0032;
					}
					IL_0039:
					switch (num)
					{
					case 0:
						return;
					case 1:
						goto IL_005F;
					case 2:
						IL_0032:
						if (value > Formatting.Indented)
						{
							goto IL_005F;
						}
						break;
					case 3:
						continue;
					case 4:
						break;
					default:
						return;
					}
					this.formatting_0 = value;
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_948fa5c193d44e279b41c3a0fab7b5c9 != 0)
					{
						goto IL_0039;
					}
					return;
				}
				IL_005F:
				throw new ArgumentOutOfRangeException(Class15.smethod_17(1270975900 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0005996a6a494de4880ac2956b2e0112));
			}
		}

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x0600050E RID: 1294 RVA: 0x000034B3 File Offset: 0x000016B3
		// (set) Token: 0x0600050F RID: 1295 RVA: 0x0003B66C File Offset: 0x0003986C
		public DateFormatHandling DateFormatHandling
		{
			get
			{
				return this.dateFormatHandling_0;
			}
			set
			{
				while (value >= DateFormatHandling.IsoDateFormat)
				{
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e368897ba1744663a6d0bc59b9b65b5f != 0)
					{
						goto IL_0015;
					}
					IL_0045:
					switch (num)
					{
					case 0:
						goto IL_006A;
					case 1:
						break;
					case 2:
						IL_0015:
						if (value > DateFormatHandling.MicrosoftDateFormat)
						{
							num = 0;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5be00c24d71649dcae8af3eed7b74ac9 == 0)
							{
								goto IL_006A;
							}
							goto IL_0045;
						}
						else
						{
							this.dateFormatHandling_0 = value;
							num = 1;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c28a4ed7a58e45aaa9902e336fd60b97 == 0)
							{
								goto IL_0045;
							}
						}
						break;
					case 3:
						continue;
					default:
						goto IL_006A;
					}
					return;
				}
				IL_006A:
				throw new ArgumentOutOfRangeException(Class15.smethod_17(2008559467 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5c76a4eb2c1748d1bee3513c8eaff2eb));
			}
		}

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x06000510 RID: 1296 RVA: 0x000034BB File Offset: 0x000016BB
		// (set) Token: 0x06000511 RID: 1297 RVA: 0x0003B700 File Offset: 0x00039900
		public DateTimeZoneHandling DateTimeZoneHandling
		{
			get
			{
				return this.dateTimeZoneHandling_0;
			}
			set
			{
				while (value >= DateTimeZoneHandling.Local)
				{
					int num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_991c06e999c744809f5b643cb7d9e7b4 != 0)
					{
						goto IL_0015;
					}
					IL_0043:
					switch (num)
					{
					case 1:
						return;
					case 2:
						IL_0015:
						if (value > DateTimeZoneHandling.RoundtripKind)
						{
							goto IL_0069;
						}
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4152404f503b492c83d9bc2e44bdd0a7 != 0)
						{
							goto IL_0043;
						}
						break;
					case 3:
						continue;
					case 4:
						goto IL_0069;
					}
					this.dateTimeZoneHandling_0 = value;
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3cf8a2073cc248c2915ebb05bcd2a099 != 0)
					{
						goto IL_0043;
					}
					return;
				}
				IL_0069:
				throw new ArgumentOutOfRangeException(Class15.smethod_17(926368931 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b2d935deb963472994f6f2321f1a6296));
			}
		}

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x06000512 RID: 1298 RVA: 0x000034C3 File Offset: 0x000016C3
		// (set) Token: 0x06000513 RID: 1299 RVA: 0x0003B794 File Offset: 0x00039994
		public StringEscapeHandling StringEscapeHandling
		{
			get
			{
				return this.stringEscapeHandling_0;
			}
			set
			{
				while (value >= StringEscapeHandling.Default)
				{
					int num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_67a271e0ae064fc7a3a74905868add95 == 0)
					{
						goto IL_004A;
					}
					IL_0062:
					switch (num)
					{
					case 0:
						return;
					case 1:
						IL_004A:
						if (value > StringEscapeHandling.EscapeHtml)
						{
							goto IL_008F;
						}
						num = 5;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93ade03426d44b1841bfa7c633f49f3 == 0)
						{
							goto IL_0062;
						}
						break;
					case 2:
						continue;
					case 3:
						goto IL_0030;
					case 4:
						goto IL_008F;
					case 5:
						break;
					default:
						return;
					}
					this.stringEscapeHandling_0 = value;
					num = 2;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ad967bb0ba3f44528134c153f7ab1ef6 == 0)
					{
						goto IL_0062;
					}
					IL_0030:
					this.OnStringEscapeHandlingChanged();
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_01137da6c88c4265bdc0297aacf3340f == 0)
					{
						goto IL_0062;
					}
					return;
				}
				IL_008F:
				throw new ArgumentOutOfRangeException(Class15.smethod_17(486538794 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39d5fbfa4fe34ed9908db538e5340a6c));
			}
		}

		// Token: 0x06000514 RID: 1300 RVA: 0x00002420 File Offset: 0x00000620
		internal virtual void OnStringEscapeHandlingChanged()
		{
		}

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x06000515 RID: 1301 RVA: 0x000034CB File Offset: 0x000016CB
		// (set) Token: 0x06000516 RID: 1302 RVA: 0x0003B84C File Offset: 0x00039A4C
		public FloatFormatHandling FloatFormatHandling
		{
			get
			{
				return this.floatFormatHandling_0;
			}
			set
			{
				while (value >= FloatFormatHandling.String)
				{
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93ade03426d44b1841bfa7c633f49f3 == 0)
					{
						goto IL_0046;
					}
					IL_004D:
					switch (num)
					{
					case 0:
						goto IL_0046;
					case 1:
						continue;
					case 2:
						break;
					case 3:
						return;
					case 4:
						goto IL_006D;
					default:
						goto IL_0046;
					}
					IL_0017:
					this.floatFormatHandling_0 = value;
					num = 3;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7af5c533f30e4bd1bda86ce6098441d2 != 0)
					{
						goto IL_004D;
					}
					IL_0046:
					if (value > FloatFormatHandling.DefaultValue)
					{
						break;
					}
					num = 2;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_550a8fe2e5fe4cc19bdfe1a82a7f12b8 != 0)
					{
						goto IL_0017;
					}
					goto IL_004D;
				}
				IL_006D:
				throw new ArgumentOutOfRangeException(Class15.smethod_17(543250556 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_43b8cdd768c545d884bf7ff1c8fefe89));
			}
		}

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x06000517 RID: 1303 RVA: 0x000034D3 File Offset: 0x000016D3
		// (set) Token: 0x06000518 RID: 1304 RVA: 0x0003B8E4 File Offset: 0x00039AE4
		[Nullable(2)]
		public string DateFormatString
		{
			[NullableContext(2)]
			get
			{
				return this.string_0;
			}
			[NullableContext(2)]
			set
			{
				for (;;)
				{
					this.string_0 = value;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_eaded84ad5b14e1ea8d4d97bfed1bb48 == 0)
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

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x06000519 RID: 1305 RVA: 0x0003B91C File Offset: 0x00039B1C
		// (set) Token: 0x0600051A RID: 1306 RVA: 0x0003B95C File Offset: 0x00039B5C
		public CultureInfo Culture
		{
			get
			{
				CultureInfo invariantCulture;
				while ((invariantCulture = this.cultureInfo_0) == null)
				{
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3baf10aa2a73406aa2bb349717d797c7 == 0)
					{
						switch (num)
						{
						case 1:
							continue;
						}
					}
					invariantCulture = CultureInfo.InvariantCulture;
					break;
				}
				return invariantCulture;
			}
			set
			{
				for (;;)
				{
					this.cultureInfo_0 = value;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_370349efcd7c4959a098549c3d5bf14d != 0)
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

		// Token: 0x0600051B RID: 1307 RVA: 0x0003B994 File Offset: 0x00039B94
		protected JsonWriter()
		{
			int num = 1;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_193800745ad94a529d9e5edc977c4f02 == 0)
			{
				for (;;)
				{
					switch (num)
					{
					case 1:
						this.state_1 = JsonWriter.State.Start;
						goto IL_001C;
					case 2:
						goto IL_0055;
					case 3:
						goto IL_004E;
					case 4:
						goto IL_0035;
					case 5:
						goto IL_001C;
					}
					break;
					IL_001C:
					this.formatting_0 = Formatting.None;
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0b405dced5e94c80928a74c5773182d9 != 0)
					{
						continue;
					}
					IL_0035:
					this.dateTimeZoneHandling_0 = DateTimeZoneHandling.RoundtripKind;
					num = 3;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7ae4da5a55de471eb12dd0de8dd4269c == 0)
					{
						goto IL_004E;
					}
					continue;
					IL_0055:
					this.AutoCompleteOnClose = true;
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_afb77be96d644a2297c7f9466cb06ede != 0)
					{
						break;
					}
					continue;
					IL_004E:
					this.CloseOutput = true;
					goto IL_0055;
				}
			}
		}

		// Token: 0x0600051C RID: 1308 RVA: 0x0003BA3C File Offset: 0x00039C3C
		internal void UpdateScopeWithFinishedValue()
		{
			for (;;)
			{
				if (this.jsonPosition_0.HasIndex)
				{
					goto IL_0003;
				}
				int num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5e301544981d4903aa4e531970a47849 == 0)
				{
					break;
				}
				IL_0024:
				switch (num)
				{
				case 1:
				case 2:
					return;
				case 3:
					continue;
				}
				IL_0003:
				this.jsonPosition_0.Position = this.jsonPosition_0.Position + 1;
				num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2e3be65f7cb2480482903dc73ec42f7c == 0)
				{
					goto IL_0024;
				}
				break;
			}
		}

		// Token: 0x0600051D RID: 1309 RVA: 0x0003BAB0 File Offset: 0x00039CB0
		private void method_0(JsonContainerType jsonContainerType_0)
		{
			for (;;)
			{
				if (this.jsonPosition_0.Type == JsonContainerType.None)
				{
					goto IL_0079;
				}
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_370349efcd7c4959a098549c3d5bf14d == 0)
				{
					goto IL_004A;
				}
				IL_0055:
				switch (num)
				{
				case 0:
					goto IL_004A;
				case 1:
					continue;
				case 2:
					return;
				case 3:
					goto IL_003D;
				case 4:
				case 5:
					break;
				case 6:
					IL_0079:
					this.jsonPosition_0 = new JsonPosition(jsonContainerType_0);
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f19acd91a8c44846a95d09d7dc3da2ba != 0)
					{
						return;
					}
					goto IL_0055;
				default:
					goto IL_004A;
				}
				IL_0006:
				this.list_0.Add(this.jsonPosition_0);
				num = 6;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8db627a8c96145a0afb24deffd2a8808 == 0)
				{
					goto IL_004A;
				}
				goto IL_0055;
				IL_003D:
				this.list_0 = new List<JsonPosition>();
				goto IL_0006;
				IL_004A:
				if (this.list_0 == null)
				{
					goto IL_003D;
				}
				num = 5;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9f5329f120e842948536b8235793166c != 0)
				{
					goto IL_003D;
				}
				goto IL_0055;
			}
		}

		// Token: 0x0600051E RID: 1310 RVA: 0x0003BB7C File Offset: 0x00039D7C
		private JsonContainerType method_1()
		{
			ref JsonPosition ptr = this.jsonPosition_0;
			if (this.list_0 != null && this.list_0.Count > 0)
			{
				this.jsonPosition_0 = this.list_0[this.list_0.Count - 1];
				this.list_0.RemoveAt(this.list_0.Count - 1);
			}
			else
			{
				this.jsonPosition_0 = default(JsonPosition);
			}
			return ptr.Type;
		}

		// Token: 0x0600051F RID: 1311 RVA: 0x000034DB File Offset: 0x000016DB
		private JsonContainerType method_2()
		{
			return this.jsonPosition_0.Type;
		}

		// Token: 0x06000520 RID: 1312
		public abstract void Flush();

		// Token: 0x06000521 RID: 1313 RVA: 0x0003BBF0 File Offset: 0x00039DF0
		public virtual void Close()
		{
			while (this.AutoCompleteOnClose)
			{
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_871a407507f34aa3b5bf52517d4f63a9 != 0)
				{
					goto IL_0015;
				}
				IL_002C:
				switch (num)
				{
				case 0:
					return;
				case 1:
					IL_0015:
					this.method_8();
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_75738dd4edc84122bfe3748a1ea03d43 == 0)
					{
						goto IL_002C;
					}
					return;
				case 2:
					break;
				default:
					return;
				}
			}
		}

		// Token: 0x06000522 RID: 1314 RVA: 0x0003BC4C File Offset: 0x00039E4C
		public virtual void WriteStartObject()
		{
			for (;;)
			{
				this.InternalWriteStart(JsonToken.StartObject, JsonContainerType.Object);
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5e301544981d4903aa4e531970a47849 != 0)
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

		// Token: 0x06000523 RID: 1315 RVA: 0x0003BC84 File Offset: 0x00039E84
		public virtual void WriteEndObject()
		{
			for (;;)
			{
				this.InternalWriteEnd(JsonContainerType.Object);
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e5c1d856e0c64e6f8377f7d819e11923 != 0)
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

		// Token: 0x06000524 RID: 1316 RVA: 0x0003BCBC File Offset: 0x00039EBC
		public virtual void WriteStartArray()
		{
			for (;;)
			{
				this.InternalWriteStart(JsonToken.StartArray, JsonContainerType.Array);
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d97e64d0f425406b9649f2b4562a5f0e != 0)
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

		// Token: 0x06000525 RID: 1317 RVA: 0x0003BCF4 File Offset: 0x00039EF4
		public virtual void WriteEndArray()
		{
			for (;;)
			{
				this.InternalWriteEnd(JsonContainerType.Array);
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bca7529ca324c188cfc0e64eb7d1cdf == 0)
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

		// Token: 0x06000526 RID: 1318 RVA: 0x0003BD2C File Offset: 0x00039F2C
		public virtual void WriteStartConstructor(string name)
		{
			for (;;)
			{
				this.InternalWriteStart(JsonToken.StartConstructor, JsonContainerType.Constructor);
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c5a086ee5649458eb5e1e6e4f0f1f4d3 == 0)
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

		// Token: 0x06000527 RID: 1319 RVA: 0x0003BD64 File Offset: 0x00039F64
		public virtual void WriteEndConstructor()
		{
			for (;;)
			{
				this.InternalWriteEnd(JsonContainerType.Constructor);
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e368897ba1744663a6d0bc59b9b65b5f == 0)
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

		// Token: 0x06000528 RID: 1320 RVA: 0x0003BD9C File Offset: 0x00039F9C
		public virtual void WritePropertyName(string name)
		{
			for (;;)
			{
				this.InternalWritePropertyName(name);
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93c7140125045538ae5c40c6f39a5af != 0)
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

		// Token: 0x06000529 RID: 1321 RVA: 0x0003BDD4 File Offset: 0x00039FD4
		public virtual void WritePropertyName(string name, bool escape)
		{
			for (;;)
			{
				this.WritePropertyName(name);
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39d5fbfa4fe34ed9908db538e5340a6c != 0)
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

		// Token: 0x0600052A RID: 1322 RVA: 0x0003BE0C File Offset: 0x0003A00C
		public virtual void WriteEnd()
		{
			for (;;)
			{
				this.method_7(this.method_2());
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ae8c3d3c66a64b57beca0f5360302062 != 0)
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

		// Token: 0x0600052B RID: 1323 RVA: 0x0003BE48 File Offset: 0x0003A048
		public void WriteToken(JsonReader reader)
		{
			for (;;)
			{
				this.WriteToken(reader, true);
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa29cbda752f45acbe81e7d5285df2ba != 0)
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

		// Token: 0x0600052C RID: 1324 RVA: 0x0003BE80 File Offset: 0x0003A080
		public void WriteToken(JsonReader reader, bool writeChildren)
		{
			for (;;)
			{
				ValidationUtils.ArgumentNotNull(reader, Class15.smethod_17(1270979214 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0005996a6a494de4880ac2956b2e0112));
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b17e63564ae246399767b60cf4b1528a == 0)
				{
					goto IL_0003;
				}
				IL_001E:
				switch (num)
				{
				case 1:
					continue;
				case 2:
					return;
				}
				IL_0003:
				this.WriteToken(reader, writeChildren, true, true);
				num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_6f87b5b72b9847f7b8ec5b44b0dccfa8 == 0)
				{
					goto IL_001E;
				}
			}
		}

		// Token: 0x0600052D RID: 1325 RVA: 0x0003BEF0 File Offset: 0x0003A0F0
		[NullableContext(2)]
		public void WriteToken(JsonToken token, object value)
		{
			BigInteger bigInteger;
			for (;;)
			{
				IL_03FB:
				int num;
				switch (token)
				{
				case JsonToken.None:
					return;
				case JsonToken.StartObject:
					goto IL_04E7;
				case JsonToken.StartArray:
					this.WriteStartArray();
					num = 33;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_75738dd4edc84122bfe3748a1ea03d43 != 0)
					{
						goto Block_18;
					}
					break;
				case JsonToken.StartConstructor:
					ValidationUtils.ArgumentNotNull(value, Class15.smethod_17(1953690807 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e368897ba1744663a6d0bc59b9b65b5f));
					goto IL_00DE;
				case JsonToken.PropertyName:
					ValidationUtils.ArgumentNotNull(value, Class15.smethod_17(432117059 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7af5c533f30e4bd1bda86ce6098441d2));
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_948fa5c193d44e279b41c3a0fab7b5c9 == 0)
					{
						goto Block_17;
					}
					break;
				case JsonToken.Comment:
					goto IL_045C;
				case JsonToken.Raw:
					this.WriteRawValue((value == null) ? null : value.ToString());
					num = 35;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_871a407507f34aa3b5bf52517d4f63a9 == 0)
					{
						goto Block_16;
					}
					break;
				case JsonToken.Integer:
					ValidationUtils.ArgumentNotNull(value, Class15.smethod_17(613112841 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ad967bb0ba3f44528134c153f7ab1ef6));
					goto IL_0104;
				case JsonToken.Float:
					ValidationUtils.ArgumentNotNull(value, Class15.smethod_17(1788745105 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_1d8dbb531d7349c0bc15bad339f7815c));
					num = 18;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_db7740c6ca7a4f3c8e1aa526bdb0a454 != 0)
					{
						goto Block_14;
					}
					break;
				case JsonToken.String:
					goto IL_047F;
				case JsonToken.Boolean:
					ValidationUtils.ArgumentNotNull(value, Class15.smethod_17(1953690807 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e368897ba1744663a6d0bc59b9b65b5f));
					goto IL_0063;
				case JsonToken.Null:
					this.WriteNull();
					num = 25;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3baf10aa2a73406aa2bb349717d797c7 != 0)
					{
						goto Block_13;
					}
					break;
				case JsonToken.Undefined:
					goto IL_0496;
				case JsonToken.EndObject:
					this.WriteEndObject();
					num = 9;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_100d09ce3850492c8356d7fa1e667d54 != 0)
					{
						goto Block_12;
					}
					break;
				case JsonToken.EndArray:
					this.WriteEndArray();
					num = 10;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3dc45d1ecdeb4859b7f470093f5eeed2 != 0)
					{
						goto Block_11;
					}
					break;
				case JsonToken.EndConstructor:
					goto IL_04A4;
				case JsonToken.Date:
					ValidationUtils.ArgumentNotNull(value, Class15.smethod_17(1570990619 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3a299c01dd4f4a209bdbd1b98e3f1406));
					goto IL_00B9;
				case JsonToken.Bytes:
					ValidationUtils.ArgumentNotNull(value, Class15.smethod_17(41438665 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_079bd9b874b24353bef46f6c3f5d741d));
					goto IL_0021;
				default:
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_186d640068094cc595a341ef95c9a29a == 0)
					{
						goto Block_19;
					}
					break;
				}
				for (;;)
				{
					IL_0180:
					Guid guid;
					switch (num)
					{
					case 1:
						goto IL_03FB;
					case 2:
						guid = (Guid)value;
						goto IL_0046;
					case 3:
						goto IL_0063;
					case 4:
						goto IL_0578;
					case 5:
						goto IL_0581;
					case 6:
						return;
					case 7:
						return;
					case 8:
						return;
					case 9:
						return;
					case 10:
						return;
					case 11:
						goto IL_04E7;
					case 12:
						goto IL_010C;
					case 13:
						goto IL_055E;
					case 14:
						goto IL_0589;
					case 15:
						goto IL_0545;
					case 16:
						return;
					case 17:
						return;
					case 18:
						return;
					case 19:
						goto IL_053D;
					case 20:
						goto IL_0104;
					case 21:
						return;
					case 22:
						return;
					case 23:
						goto IL_00DE;
					case 24:
						goto IL_054D;
					case 25:
						return;
					case 26:
						goto IL_0021;
					case 27:
						return;
					case 28:
						return;
					case 29:
						return;
					case 30:
						return;
					case 31:
						goto IL_0519;
					case 32:
						return;
					case 33:
						return;
					case 34:
						goto IL_0511;
					case 35:
						return;
					case 36:
						return;
					case 37:
						goto IL_0500;
					case 38:
						goto IL_0570;
					case 39:
						return;
					case 40:
						return;
					case 41:
						goto IL_00B9;
					case 42:
						this.WriteValue(Convert.ToDateTime(value, CultureInfo.InvariantCulture));
						num = 6;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0b405dced5e94c80928a74c5773182d9 == 0)
						{
							goto Block_4;
						}
						continue;
					case 43:
						return;
					case 44:
						return;
					case 45:
						goto IL_0525;
					case 46:
						goto IL_0046;
					case 47:
						goto IL_0535;
					}
					goto Block_10;
					IL_0046:
					this.WriteValue(guid);
					num = 6;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3a299c01dd4f4a209bdbd1b98e3f1406 == 0)
					{
						goto IL_0063;
					}
				}
				IL_0021:
				if (value is Guid)
				{
					num = 2;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9f9b31fb7a85497499112abf86cccc98 != 0)
					{
						goto IL_0180;
					}
					continue;
				}
				else
				{
					this.WriteValue((byte[])value);
					num = 7;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_186d640068094cc595a341ef95c9a29a != 0)
					{
						goto IL_0180;
					}
					goto IL_04AC;
				}
				IL_0063:
				this.WriteValue(Convert.ToBoolean(value, CultureInfo.InvariantCulture));
				num = 27;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_6f87b5b72b9847f7b8ec5b44b0dccfa8 != 0)
				{
					break;
				}
				goto IL_0180;
				IL_00B9:
				if (value is DateTimeOffset)
				{
					goto IL_0511;
				}
				num = 42;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_67cbcb2ad04040d48847c1ca2f65be32 != 0)
				{
					goto Block_6;
				}
				goto IL_0180;
				IL_00DE:
				this.WriteStartConstructor(value.ToString());
				num = 20;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a5994720d09542abb897ebf6ad9b5a19 == 0)
				{
					goto Block_7;
				}
				goto IL_0180;
				IL_010C:
				bigInteger = (BigInteger)value;
				num = 5;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_67a271e0ae064fc7a3a74905868add95 != 0)
				{
					goto Block_8;
				}
				goto IL_0180;
				IL_0104:
				if (value is BigInteger)
				{
					goto IL_010C;
				}
				this.WriteValue(Convert.ToInt64(value, CultureInfo.InvariantCulture));
				num = 12;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3baf10aa2a73406aa2bb349717d797c7 != 0)
				{
					goto Block_9;
				}
				goto IL_0180;
			}
			return;
			Block_4:
			return;
			Block_6:
			return;
			Block_7:
			return;
			Block_8:
			goto IL_0525;
			Block_9:
			return;
			Block_10:
			goto IL_04AF;
			Block_11:
			return;
			Block_12:
			return;
			Block_13:
			return;
			Block_14:
			goto IL_0535;
			Block_16:
			goto IL_0519;
			Block_17:
			goto IL_0500;
			Block_18:
			goto IL_0581;
			Block_19:
			goto IL_04AF;
			IL_045C:
			this.WriteComment((value == null) ? null : value.ToString());
			return;
			IL_047F:
			this.WriteValue((value == null) ? null : value.ToString());
			return;
			IL_0496:
			this.WriteUndefined();
			return;
			IL_04A4:
			this.WriteEndConstructor();
			return;
			IL_04AC:
			return;
			IL_04AF:
			throw MiscellaneousUtils.CreateArgumentOutOfRangeException(Class15.smethod_17(2071415840 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8db627a8c96145a0afb24deffd2a8808), token, Class15.smethod_17(1042105105 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39a47a907a8a440980940ae96da3f3ad));
			IL_04E7:
			this.WriteStartObject();
			return;
			IL_0500:
			this.WritePropertyName(value.ToString());
			return;
			IL_0511:
			DateTimeOffset dateTimeOffset = (DateTimeOffset)value;
			IL_0519:
			this.WriteValue(dateTimeOffset);
			return;
			IL_0525:
			this.WriteValue(bigInteger);
			return;
			IL_0535:
			if (value is decimal)
			{
				goto IL_0581;
			}
			IL_053D:
			if (!(value is double))
			{
				if (!(value is float))
				{
					goto IL_055E;
				}
				goto IL_0570;
			}
			IL_0545:
			double num2 = (double)value;
			IL_054D:
			this.WriteValue(num2);
			return;
			IL_055E:
			this.WriteValue(Convert.ToDouble(value, CultureInfo.InvariantCulture));
			return;
			IL_0570:
			float num3 = (float)value;
			IL_0578:
			this.WriteValue(num3);
			return;
			IL_0581:
			decimal num4 = (decimal)value;
			IL_0589:
			this.WriteValue(num4);
		}

		// Token: 0x0600052E RID: 1326 RVA: 0x0003C490 File Offset: 0x0003A690
		public void WriteToken(JsonToken token)
		{
			for (;;)
			{
				this.WriteToken(token, null);
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
		}

		// Token: 0x0600052F RID: 1327 RVA: 0x0003C4C8 File Offset: 0x0003A6C8
		internal virtual void WriteToken(JsonReader reader, bool writeChildren, bool writeDateConstructorAsDate, bool writeComments)
		{
			int num;
			for (;;)
			{
				IL_0168:
				num = this.method_4(reader);
				for (;;)
				{
					if (!writeDateConstructorAsDate)
					{
						goto IL_0131;
					}
					goto IL_0155;
					IL_003D:
					if (!reader.Read())
					{
						goto IL_0173;
					}
					int num2 = 10;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8db627a8c96145a0afb24deffd2a8808 != 0)
					{
						continue;
					}
					goto IL_00CB;
					IL_0018:
					if (num - 1 < reader.Depth - (JsonTokenUtils.IsEndToken(reader.TokenType) ? 1 : 0) && writeChildren)
					{
						goto IL_003D;
					}
					goto IL_0173;
					IL_0006:
					this.WriteToken(reader.TokenType, reader.Value);
					goto IL_0018;
					IL_00CB:
					switch (num2)
					{
					case 0:
					case 5:
					case 7:
						goto IL_0131;
					case 1:
						goto IL_0094;
					case 2:
						goto IL_017F;
					case 3:
						IL_00B9:
						this.method_6(reader);
						goto IL_0018;
					case 4:
						goto IL_00A7;
					case 6:
					case 9:
						goto IL_0018;
					case 8:
						goto IL_005F;
					case 10:
						goto IL_0006;
					case 11:
						IL_0155:
						if (reader.TokenType != JsonToken.StartConstructor)
						{
							goto IL_0131;
						}
						num2 = 1;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e6fac70dd3e841b6925374855ecd7fb1 == 0)
						{
							goto IL_0094;
						}
						goto IL_00CB;
					case 12:
						goto IL_003D;
					case 13:
					case 14:
						continue;
					case 15:
						goto IL_0168;
					case 16:
						goto IL_0173;
					default:
						goto IL_0131;
					}
					IL_0060:
					string text;
					if (string.Equals(text, Class15.smethod_17(432142933 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7af5c533f30e4bd1bda86ce6098441d2), StringComparison.Ordinal))
					{
						goto IL_00B9;
					}
					num2 = 5;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_676b866782704933888a7440512fd4ff == 0)
					{
						goto IL_0131;
					}
					goto IL_00CB;
					IL_005F:
					text = null;
					goto IL_0060;
					IL_0094:
					object value = reader.Value;
					if (value == null)
					{
						goto IL_005F;
					}
					text = value.ToString();
					goto IL_0060;
					IL_00A7:
					if (reader.TokenType != JsonToken.Comment)
					{
						goto IL_0006;
					}
					goto IL_0018;
					IL_0131:
					if (writeComments)
					{
						goto IL_0006;
					}
					num2 = 2;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0005996a6a494de4880ac2956b2e0112 != 0)
					{
						goto IL_00A7;
					}
					goto IL_00CB;
				}
			}
			IL_0173:
			if (!this.method_3(reader, writeChildren, num))
			{
				return;
			}
			IL_017F:
			throw JsonWriterException.Create(this, Class15.smethod_17(635829045 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a41eabd4b99f489fb7d86310d3f95ba2), null);
		}

		// Token: 0x06000530 RID: 1328 RVA: 0x0003C674 File Offset: 0x0003A874
		private bool method_3(JsonReader jsonReader_0, bool bool_2, int int_0)
		{
			for (;;)
			{
				IL_0062:
				int num = this.method_5(jsonReader_0);
				IL_005A:
				while (int_0 >= num)
				{
					for (;;)
					{
						if (bool_2)
						{
							goto IL_0038;
						}
						int num2 = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d9581c727fcc4f50accd4f5de0d386f5 == 0)
						{
							goto Block_3;
						}
						IL_0014:
						switch (num2)
						{
						case 1:
							return false;
						case 2:
							IL_0038:
							if (int_0 != num)
							{
								return false;
							}
							num2 = 0;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3cf8a2073cc248c2915ebb05bcd2a099 != 0)
							{
								goto IL_0014;
							}
							break;
						case 3:
							return true;
						case 4:
							continue;
						case 5:
							goto IL_005A;
						case 6:
							goto IL_0062;
						}
						goto Block_1;
					}
				}
				return true;
			}
			Block_1:
			goto IL_0073;
			Block_3:
			return false;
			IL_0073:
			return JsonTokenUtils.IsStartToken(jsonReader_0.TokenType);
		}

		// Token: 0x06000531 RID: 1329 RVA: 0x0003C704 File Offset: 0x0003A904
		private int method_4(JsonReader jsonReader_0)
		{
			for (;;)
			{
				JsonToken tokenType = jsonReader_0.TokenType;
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cbfb1e54efd84756a9b6d7b21adc0d65 != 0)
				{
					goto IL_0020;
				}
				IL_0027:
				switch (num)
				{
				case 1:
					IL_0020:
					if (tokenType != JsonToken.None)
					{
						goto IL_0003;
					}
					return -1;
				case 2:
					continue;
				case 3:
					goto IL_0003;
				case 4:
					return -1;
				}
				break;
				IL_0003:
				if (JsonTokenUtils.IsStartToken(tokenType))
				{
					goto IL_0069;
				}
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_550a8fe2e5fe4cc19bdfe1a82a7f12b8 != 0)
				{
					break;
				}
				goto IL_0027;
			}
			return jsonReader_0.Depth + 1;
			IL_0069:
			return jsonReader_0.Depth;
		}

		// Token: 0x06000532 RID: 1330 RVA: 0x0003C784 File Offset: 0x0003A984
		private int method_5(JsonReader jsonReader_0)
		{
			for (;;)
			{
				IL_0052:
				JsonToken tokenType = jsonReader_0.TokenType;
				while (tokenType != JsonToken.None)
				{
					int num = 2;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39f35935adc2477fa894750fee078177 != 0)
					{
						goto IL_0015;
					}
					IL_002F:
					switch (num)
					{
					case 1:
						return -1;
					case 2:
						IL_0015:
						if (JsonTokenUtils.IsEndToken(tokenType))
						{
							goto IL_0064;
						}
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3436841e08c54f56b10b76e1438d4224 != 0)
						{
							goto IL_002F;
						}
						break;
					case 3:
						continue;
					case 4:
						goto IL_0052;
					}
					goto Block_2;
				}
				return -1;
			}
			Block_2:
			return jsonReader_0.Depth;
			IL_0064:
			return jsonReader_0.Depth - 1;
		}

		// Token: 0x06000533 RID: 1331 RVA: 0x0003C800 File Offset: 0x0003AA00
		private void method_6(JsonReader jsonReader_0)
		{
			string text;
			for (;;)
			{
				DateTime dateTime;
				int num;
				if (!JavaScriptUtils.TryGetDateFromConstructorJson(jsonReader_0, out dateTime, out text))
				{
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fd59e876ac704e7eaa7c7a24a9b3a23f == 0)
					{
						break;
					}
				}
				else
				{
					this.WriteValue(dateTime);
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c28a4ed7a58e45aaa9902e336fd60b97 == 0)
					{
						return;
					}
				}
				switch (num)
				{
				case 1:
					continue;
				case 2:
					return;
				}
				break;
			}
			throw JsonWriterException.Create(this, text, null);
		}

		// Token: 0x06000534 RID: 1332 RVA: 0x0003C86C File Offset: 0x0003AA6C
		private void method_7(JsonContainerType jsonContainerType_0)
		{
			for (;;)
			{
				int num;
				switch (jsonContainerType_0)
				{
				case JsonContainerType.Object:
					goto IL_008B;
				case JsonContainerType.Array:
					this.WriteEndArray();
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0efaea2f67ca4b0aa2880fbd34fc0fff != 0)
					{
						goto Block_2;
					}
					break;
				case JsonContainerType.Constructor:
					this.WriteEndConstructor();
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ee35a23edd8f4998990ec1a2b40fc61a == 0)
					{
						return;
					}
					break;
				default:
					num = 3;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4b8a72ce901241b5b52fe60600cb3607 != 0)
					{
						goto Block_3;
					}
					break;
				}
				switch (num)
				{
				case 1:
					goto IL_008B;
				case 2:
					return;
				case 3:
					goto IL_0092;
				case 4:
					continue;
				case 5:
					return;
				}
				break;
			}
			return;
			Block_2:
			return;
			Block_3:
			IL_008B:
			this.WriteEndObject();
			return;
			IL_0092:
			throw JsonWriterException.Create(this, Class15.smethod_17(1760327115 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_6bf87ae21d2446cfa7edc53669bb8039) + jsonContainerType_0.ToString(), null);
		}

		// Token: 0x06000535 RID: 1333 RVA: 0x0003C93C File Offset: 0x0003AB3C
		private void method_8()
		{
			for (;;)
			{
				if (this.Top > 0)
				{
					goto IL_0003;
				}
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_57ce3fecb9e64a8f924ea7658e146719 != 0)
				{
					break;
				}
				IL_001A:
				switch (num)
				{
				case 1:
				case 3:
					continue;
				case 2:
					IL_0003:
					this.WriteEnd();
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5c76a4eb2c1748d1bee3513c8eaff2eb != 0)
					{
						goto IL_001A;
					}
					continue;
				}
				break;
			}
		}

		// Token: 0x06000536 RID: 1334 RVA: 0x0003C9A0 File Offset: 0x0003ABA0
		private JsonToken method_9(JsonContainerType jsonContainerType_0)
		{
			for (;;)
			{
				switch (jsonContainerType_0)
				{
				case JsonContainerType.Object:
					return JsonToken.EndObject;
				case JsonContainerType.Array:
					return JsonToken.EndArray;
				case JsonContainerType.Constructor:
					return JsonToken.EndConstructor;
				default:
				{
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_57ce3fecb9e64a8f924ea7658e146719 != 0)
					{
						switch (num)
						{
						case 1:
							continue;
						case 2:
							return JsonToken.EndObject;
						}
						goto Block_2;
					}
					goto IL_003F;
				}
				}
			}
			Block_2:
			IL_003F:
			throw JsonWriterException.Create(this, Class15.smethod_17(552192814 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_01137da6c88c4265bdc0297aacf3340f) + jsonContainerType_0.ToString(), null);
		}

		// Token: 0x06000537 RID: 1335 RVA: 0x0003CA24 File Offset: 0x0003AC24
		private void method_10(JsonContainerType jsonContainerType_0)
		{
			for (;;)
			{
				IL_0129:
				int num = this.method_11(jsonContainerType_0);
				for (;;)
				{
					IL_0124:
					int i = 0;
					IL_011A:
					while (i < num)
					{
						for (;;)
						{
							JsonToken jsonToken = this.method_9(this.method_1());
							int num2 = 0;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c27e9fccdfcc44999155a4980faa4e81 != 0)
							{
								goto IL_003E;
							}
							IL_00A3:
							switch (num2)
							{
							case 0:
								goto IL_003E;
							case 1:
								goto IL_004A;
							case 2:
								goto IL_0053;
							case 3:
							case 9:
								continue;
							case 4:
								goto IL_0073;
							case 5:
								break;
							case 6:
								goto IL_0124;
							case 7:
								goto IL_0129;
							case 8:
								return;
							case 10:
								goto IL_0114;
							case 11:
								if (this.state_1 == JsonWriter.State.ArrayStart)
								{
									goto IL_0073;
								}
								break;
							case 12:
							case 13:
								goto IL_011A;
							case 14:
								goto IL_0026;
							case 15:
								goto IL_0006;
							default:
								goto IL_003E;
							}
							this.WriteIndent();
							goto IL_0073;
							IL_0006:
							this.method_12();
							num2 = 4;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5be00c24d71649dcae8af3eed7b74ac9 == 0)
							{
								break;
							}
							goto IL_00A3;
							IL_0026:
							this.WriteNull();
							num2 = 1;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39f35935adc2477fa894750fee078177 != 0)
							{
								goto IL_00A3;
							}
							IL_003E:
							if (this.state_1 == JsonWriter.State.Property)
							{
								goto IL_0026;
							}
							goto IL_004A;
							IL_0053:
							if (this.state_1 == JsonWriter.State.ObjectStart)
							{
								goto IL_0073;
							}
							num2 = 11;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5dadf4f8cc824060ae20e1ee9bbca82a != 0)
							{
								goto Block_4;
							}
							goto IL_00A3;
							IL_004A:
							if (this.formatting_0 == Formatting.Indented)
							{
								goto IL_0053;
							}
							IL_0073:
							this.WriteEnd(jsonToken);
							num2 = 15;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8bcabc342a5a44748f3978da7f62051e == 0)
							{
								goto IL_0006;
							}
							goto IL_00A3;
						}
						IL_0114:
						i++;
						continue;
						goto IL_0114;
						Block_4:
						goto IL_0124;
					}
					return;
				}
			}
		}

		// Token: 0x06000538 RID: 1336 RVA: 0x0003CB68 File Offset: 0x0003AD68
		private int method_11(JsonContainerType jsonContainerType_0)
		{
			for (;;)
			{
				IL_0100:
				int num = 0;
				for (;;)
				{
					if (this.jsonPosition_0.Type == jsonContainerType_0)
					{
						goto IL_007A;
					}
					goto IL_00CB;
					IL_0087:
					int num2;
					int num3;
					int num4;
					switch (num2)
					{
					case 1:
					case 6:
					case 12:
						goto IL_0056;
					case 2:
						IL_00CB:
						num3 = this.Top - 2;
						num2 = 13;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2e3be65f7cb2480482903dc73ec42f7c != 0)
						{
							goto IL_000D;
						}
						goto IL_0087;
					case 3:
					case 14:
						goto IL_002B;
					case 4:
						num = num4 + 2;
						goto IL_0056;
					case 5:
						goto IL_000D;
					case 7:
						goto IL_0006;
					case 8:
						IL_007A:
						num = 1;
						goto IL_0056;
					case 9:
						continue;
					case 10:
						goto IL_0100;
					case 11:
						goto IL_0025;
					case 13:
						num4 = num3;
						goto IL_002B;
					}
					goto Block_6;
					IL_000D:
					int num5;
					if (this.list_0[num5].Type != jsonContainerType_0)
					{
						goto IL_0025;
					}
					num2 = 4;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_75738dd4edc84122bfe3748a1ea03d43 != 0)
					{
						goto IL_0056;
					}
					goto IL_0087;
					IL_0006:
					num5 = num3 - num4;
					goto IL_000D;
					IL_002B:
					if (num4 >= 0)
					{
						goto IL_0006;
					}
					num2 = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_48fe014748e848c88d3254f339047927 != 0)
					{
						goto IL_0056;
					}
					goto IL_0087;
					IL_0025:
					num4--;
					goto IL_002B;
					IL_0056:
					if (num != 0)
					{
						return num;
					}
					num2 = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_11c6824de6514281a8425f6d6ab1a2d5 == 0)
					{
						goto Block_5;
					}
					goto IL_0087;
				}
			}
			Block_5:
			Block_6:
			throw JsonWriterException.Create(this, Class15.smethod_17(314786561 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_48fe014748e848c88d3254f339047927), null);
		}

		// Token: 0x06000539 RID: 1337 RVA: 0x0003CC9C File Offset: 0x0003AE9C
		private void method_12()
		{
			JsonContainerType jsonContainerType;
			for (;;)
			{
				jsonContainerType = this.method_2();
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d9581c727fcc4f50accd4f5de0d386f5 == 0)
				{
					goto IL_0003;
				}
				IL_0046:
				switch (num)
				{
				case 1:
					continue;
				case 2:
					goto IL_00A5;
				case 3:
					return;
				case 4:
					return;
				case 5:
					goto IL_00D6;
				case 6:
					return;
				case 7:
					return;
				}
				IL_0003:
				switch (jsonContainerType)
				{
				case JsonContainerType.None:
					goto IL_0090;
				case JsonContainerType.Object:
					goto IL_00D6;
				case JsonContainerType.Array:
					this.state_1 = JsonWriter.State.Array;
					num = 3;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ad967bb0ba3f44528134c153f7ab1ef6 == 0)
					{
						goto IL_0046;
					}
					goto IL_0099;
				case JsonContainerType.Constructor:
					goto IL_009C;
				default:
					num = 2;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_afb77be96d644a2297c7f9466cb06ede == 0)
					{
						goto Block_2;
					}
					goto IL_0046;
				}
			}
			Block_2:
			goto IL_00A5;
			IL_0090:
			this.state_1 = JsonWriter.State.Start;
			return;
			IL_0099:
			return;
			IL_009C:
			this.state_1 = JsonWriter.State.Array;
			return;
			IL_00A5:
			throw JsonWriterException.Create(this, Class15.smethod_17(2008564083 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5c76a4eb2c1748d1bee3513c8eaff2eb) + jsonContainerType.ToString(), null);
			IL_00D6:
			this.state_1 = JsonWriter.State.Object;
		}

		// Token: 0x0600053A RID: 1338 RVA: 0x00002420 File Offset: 0x00000620
		protected virtual void WriteEnd(JsonToken token)
		{
		}

		// Token: 0x0600053B RID: 1339 RVA: 0x00002420 File Offset: 0x00000620
		protected virtual void WriteIndent()
		{
		}

		// Token: 0x0600053C RID: 1340 RVA: 0x00002420 File Offset: 0x00000620
		protected virtual void WriteValueDelimiter()
		{
		}

		// Token: 0x0600053D RID: 1341 RVA: 0x00002420 File Offset: 0x00000620
		protected virtual void WriteIndentSpace()
		{
		}

		// Token: 0x0600053E RID: 1342 RVA: 0x0003CD88 File Offset: 0x0003AF88
		internal void AutoComplete(JsonToken tokenBeingWritten)
		{
			JsonWriter.State state;
			for (;;)
			{
				IL_01A2:
				state = JsonWriter.state_0[(int)tokenBeingWritten][(int)this.state_1];
				for (;;)
				{
					IL_0196:
					int num;
					if (state == JsonWriter.State.Error)
					{
						num = 2;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ca6ac77a767741aa91cb31f8080f093b == 0)
						{
							goto Block_14;
						}
					}
					else
					{
						if (this.state_1 == JsonWriter.State.Object)
						{
							goto IL_0026;
						}
						num = 1;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c367d9ce11cc43b595beeb4524149542 == 0)
						{
							goto IL_007D;
						}
					}
					for (;;)
					{
						IL_0127:
						switch (num)
						{
						case 1:
							goto IL_007D;
						case 2:
							goto IL_00DD;
						case 3:
							return;
						case 4:
							goto IL_01B8;
						case 5:
							goto IL_00BE;
						case 6:
							goto IL_0196;
						case 7:
							goto IL_01A2;
						case 8:
							goto IL_0026;
						case 9:
							goto IL_005C;
						case 10:
							goto IL_0030;
						case 11:
							goto IL_01FD;
						case 12:
						case 15:
							goto IL_0203;
						case 13:
							goto IL_00D6;
						case 14:
							goto IL_00CA;
						case 16:
							if (this.state_1 != JsonWriter.State.ArrayStart)
							{
								goto IL_00BE;
							}
							goto IL_01FD;
						case 17:
							goto IL_0086;
						case 18:
							if (this.state_1 == JsonWriter.State.Property)
							{
								goto IL_0056;
							}
							goto IL_005C;
						case 19:
							goto IL_0056;
						}
						goto Block_13;
						IL_005C:
						if (this.state_1 == JsonWriter.State.Array)
						{
							goto IL_01FD;
						}
						num = 16;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d5af2cccac2f47ed978e804138a35d1c == 0)
						{
							goto IL_007D;
						}
						continue;
						IL_0056:
						this.WriteIndentSpace();
						goto IL_005C;
						IL_00DD:
						if (this.state_1 != JsonWriter.State.Start)
						{
							goto IL_01FD;
						}
						num = 15;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3436841e08c54f56b10b76e1438d4224 != 0)
						{
							break;
						}
						continue;
						IL_00D6:
						if (tokenBeingWritten == JsonToken.PropertyName)
						{
							goto IL_00DD;
						}
						goto IL_0203;
						IL_00CA:
						if (this.state_1 != JsonWriter.State.ConstructorStart)
						{
							goto IL_00D6;
						}
						goto IL_01FD;
						IL_00BE:
						if (this.state_1 != JsonWriter.State.Constructor)
						{
							goto IL_00CA;
						}
						goto IL_01FD;
					}
					goto IL_0026;
					Block_13:
					goto IL_00FC;
					IL_0026:
					if (tokenBeingWritten == JsonToken.Comment)
					{
						goto IL_0030;
					}
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_aa43e77a676848e0bd70abf647d6a9f1 == 0)
					{
						goto IL_00FC;
					}
					goto IL_0127;
					IL_007D:
					if (this.state_1 != JsonWriter.State.Array)
					{
						goto IL_0086;
					}
					goto IL_0026;
					IL_0030:
					if (this.formatting_0 != Formatting.Indented)
					{
						goto IL_0203;
					}
					num = 18;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5c76a4eb2c1748d1bee3513c8eaff2eb == 0)
					{
						goto Block_5;
					}
					goto IL_0127;
					IL_00FC:
					this.WriteValueDelimiter();
					goto IL_0030;
					IL_0086:
					if (this.state_1 != JsonWriter.State.Constructor)
					{
						goto IL_0030;
					}
					num = 4;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_676b866782704933888a7440512fd4ff == 0)
					{
						goto IL_0026;
					}
					goto IL_0127;
				}
			}
			Block_5:
			Block_14:
			IL_01B8:
			throw JsonWriterException.Create(this, Class15.smethod_17(82288026 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_832998aae3714af0a1270bf2bb566909).FormatWith(CultureInfo.InvariantCulture, tokenBeingWritten.ToString(), this.state_1.ToString()), null);
			IL_01FD:
			this.WriteIndent();
			IL_0203:
			this.state_1 = state;
		}

		// Token: 0x0600053F RID: 1343 RVA: 0x0003CFA0 File Offset: 0x0003B1A0
		public virtual void WriteNull()
		{
			for (;;)
			{
				this.InternalWriteValue(JsonToken.Null);
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8bcabc342a5a44748f3978da7f62051e != 0)
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

		// Token: 0x06000540 RID: 1344 RVA: 0x0003CFD8 File Offset: 0x0003B1D8
		public virtual void WriteUndefined()
		{
			for (;;)
			{
				this.InternalWriteValue(JsonToken.Undefined);
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_253407eb812c4aefb734fa1e267fe779 != 0)
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

		// Token: 0x06000541 RID: 1345 RVA: 0x000034E8 File Offset: 0x000016E8
		[NullableContext(2)]
		public virtual void WriteRaw(string json)
		{
			this.InternalWriteRaw();
		}

		// Token: 0x06000542 RID: 1346 RVA: 0x0003D010 File Offset: 0x0003B210
		[NullableContext(2)]
		public virtual void WriteRawValue(string json)
		{
			for (;;)
			{
				IL_004F:
				this.UpdateScopeWithFinishedValue();
				for (;;)
				{
					this.AutoComplete(JsonToken.Undefined);
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e764f065c2fa404a85129e2e957d4f18 == 0)
					{
						goto IL_0003;
					}
					IL_001B:
					switch (num)
					{
					case 1:
						return;
					case 2:
						continue;
					case 3:
						goto IL_004F;
					}
					IL_0003:
					this.WriteRaw(json);
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_6bf87ae21d2446cfa7edc53669bb8039 != 0)
					{
						goto IL_001B;
					}
					return;
				}
			}
		}

		// Token: 0x06000543 RID: 1347 RVA: 0x0003D078 File Offset: 0x0003B278
		[NullableContext(2)]
		public virtual void WriteValue(string value)
		{
			for (;;)
			{
				this.InternalWriteValue(JsonToken.String);
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_6bf87ae21d2446cfa7edc53669bb8039 != 0)
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

		// Token: 0x06000544 RID: 1348 RVA: 0x0003D0B0 File Offset: 0x0003B2B0
		public virtual void WriteValue(int value)
		{
			for (;;)
			{
				this.InternalWriteValue(JsonToken.Integer);
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_676b866782704933888a7440512fd4ff != 0)
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

		// Token: 0x06000545 RID: 1349 RVA: 0x0003D0E8 File Offset: 0x0003B2E8
		[CLSCompliant(false)]
		public virtual void WriteValue(uint value)
		{
			for (;;)
			{
				this.InternalWriteValue(JsonToken.Integer);
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bca7529ca324c188cfc0e64eb7d1cdf == 0)
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

		// Token: 0x06000546 RID: 1350 RVA: 0x0003D120 File Offset: 0x0003B320
		public virtual void WriteValue(long value)
		{
			for (;;)
			{
				this.InternalWriteValue(JsonToken.Integer);
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_11c6824de6514281a8425f6d6ab1a2d5 == 0)
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

		// Token: 0x06000547 RID: 1351 RVA: 0x0003D158 File Offset: 0x0003B358
		[CLSCompliant(false)]
		public virtual void WriteValue(ulong value)
		{
			for (;;)
			{
				this.InternalWriteValue(JsonToken.Integer);
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3a299c01dd4f4a209bdbd1b98e3f1406 != 0)
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

		// Token: 0x06000548 RID: 1352 RVA: 0x0003D190 File Offset: 0x0003B390
		public virtual void WriteValue(float value)
		{
			for (;;)
			{
				this.InternalWriteValue(JsonToken.Float);
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

		// Token: 0x06000549 RID: 1353 RVA: 0x0003D1C8 File Offset: 0x0003B3C8
		public virtual void WriteValue(double value)
		{
			for (;;)
			{
				this.InternalWriteValue(JsonToken.Float);
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7dfc957a76cb4c58b17dc74a084c4e4a == 0)
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

		// Token: 0x0600054A RID: 1354 RVA: 0x0003D200 File Offset: 0x0003B400
		public virtual void WriteValue(bool value)
		{
			for (;;)
			{
				this.InternalWriteValue(JsonToken.Boolean);
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_253407eb812c4aefb734fa1e267fe779 == 0)
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

		// Token: 0x0600054B RID: 1355 RVA: 0x0003D238 File Offset: 0x0003B438
		public virtual void WriteValue(short value)
		{
			for (;;)
			{
				this.InternalWriteValue(JsonToken.Integer);
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5dadf4f8cc824060ae20e1ee9bbca82a == 0)
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

		// Token: 0x0600054C RID: 1356 RVA: 0x0003D270 File Offset: 0x0003B470
		[CLSCompliant(false)]
		public virtual void WriteValue(ushort value)
		{
			for (;;)
			{
				this.InternalWriteValue(JsonToken.Integer);
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

		// Token: 0x0600054D RID: 1357 RVA: 0x0003D2A8 File Offset: 0x0003B4A8
		public virtual void WriteValue(char value)
		{
			for (;;)
			{
				this.InternalWriteValue(JsonToken.String);
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7ae4da5a55de471eb12dd0de8dd4269c != 0)
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

		// Token: 0x0600054E RID: 1358 RVA: 0x0003D2E0 File Offset: 0x0003B4E0
		public virtual void WriteValue(byte value)
		{
			for (;;)
			{
				this.InternalWriteValue(JsonToken.Integer);
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3dc45d1ecdeb4859b7f470093f5eeed2 != 0)
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

		// Token: 0x0600054F RID: 1359 RVA: 0x0003D318 File Offset: 0x0003B518
		[CLSCompliant(false)]
		public virtual void WriteValue(sbyte value)
		{
			for (;;)
			{
				this.InternalWriteValue(JsonToken.Integer);
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

		// Token: 0x06000550 RID: 1360 RVA: 0x0003D350 File Offset: 0x0003B550
		public virtual void WriteValue(decimal value)
		{
			for (;;)
			{
				this.InternalWriteValue(JsonToken.Float);
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_193800745ad94a529d9e5edc977c4f02 == 0)
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

		// Token: 0x06000551 RID: 1361 RVA: 0x0003D388 File Offset: 0x0003B588
		public virtual void WriteValue(DateTime value)
		{
			for (;;)
			{
				this.InternalWriteValue(JsonToken.Date);
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_548c52e5632b45898e377ad9c9a06469 != 0)
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

		// Token: 0x06000552 RID: 1362 RVA: 0x0003D3C0 File Offset: 0x0003B5C0
		public virtual void WriteValue(DateTimeOffset value)
		{
			for (;;)
			{
				this.InternalWriteValue(JsonToken.Date);
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fd59e876ac704e7eaa7c7a24a9b3a23f != 0)
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

		// Token: 0x06000553 RID: 1363 RVA: 0x0003D3F8 File Offset: 0x0003B5F8
		public virtual void WriteValue(Guid value)
		{
			for (;;)
			{
				this.InternalWriteValue(JsonToken.String);
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_afb77be96d644a2297c7f9466cb06ede != 0)
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

		// Token: 0x06000554 RID: 1364 RVA: 0x0003D430 File Offset: 0x0003B630
		public virtual void WriteValue(TimeSpan value)
		{
			for (;;)
			{
				this.InternalWriteValue(JsonToken.String);
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c28a4ed7a58e45aaa9902e336fd60b97 == 0)
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

		// Token: 0x06000555 RID: 1365 RVA: 0x000034F0 File Offset: 0x000016F0
		public virtual void WriteValue(int? value)
		{
			if (value == null)
			{
				this.WriteNull();
				return;
			}
			this.WriteValue(value.GetValueOrDefault());
		}

		// Token: 0x06000556 RID: 1366 RVA: 0x0000350F File Offset: 0x0000170F
		[CLSCompliant(false)]
		public virtual void WriteValue(uint? value)
		{
			if (value == null)
			{
				this.WriteNull();
				return;
			}
			this.WriteValue(value.GetValueOrDefault());
		}

		// Token: 0x06000557 RID: 1367 RVA: 0x0000352E File Offset: 0x0000172E
		public virtual void WriteValue(long? value)
		{
			if (value == null)
			{
				this.WriteNull();
				return;
			}
			this.WriteValue(value.GetValueOrDefault());
		}

		// Token: 0x06000558 RID: 1368 RVA: 0x0000354D File Offset: 0x0000174D
		[CLSCompliant(false)]
		public virtual void WriteValue(ulong? value)
		{
			if (value == null)
			{
				this.WriteNull();
				return;
			}
			this.WriteValue(value.GetValueOrDefault());
		}

		// Token: 0x06000559 RID: 1369 RVA: 0x0000356C File Offset: 0x0000176C
		public virtual void WriteValue(float? value)
		{
			if (value == null)
			{
				this.WriteNull();
				return;
			}
			this.WriteValue(value.GetValueOrDefault());
		}

		// Token: 0x0600055A RID: 1370 RVA: 0x0000358B File Offset: 0x0000178B
		public virtual void WriteValue(double? value)
		{
			if (value == null)
			{
				this.WriteNull();
				return;
			}
			this.WriteValue(value.GetValueOrDefault());
		}

		// Token: 0x0600055B RID: 1371 RVA: 0x000035AA File Offset: 0x000017AA
		public virtual void WriteValue(bool? value)
		{
			if (value == null)
			{
				this.WriteNull();
				return;
			}
			this.WriteValue(value.GetValueOrDefault());
		}

		// Token: 0x0600055C RID: 1372 RVA: 0x000035C9 File Offset: 0x000017C9
		public virtual void WriteValue(short? value)
		{
			if (value == null)
			{
				this.WriteNull();
				return;
			}
			this.WriteValue(value.GetValueOrDefault());
		}

		// Token: 0x0600055D RID: 1373 RVA: 0x000035E8 File Offset: 0x000017E8
		[CLSCompliant(false)]
		public virtual void WriteValue(ushort? value)
		{
			if (value == null)
			{
				this.WriteNull();
				return;
			}
			this.WriteValue(value.GetValueOrDefault());
		}

		// Token: 0x0600055E RID: 1374 RVA: 0x00003607 File Offset: 0x00001807
		public virtual void WriteValue(char? value)
		{
			if (value == null)
			{
				this.WriteNull();
				return;
			}
			this.WriteValue(value.GetValueOrDefault());
		}

		// Token: 0x0600055F RID: 1375 RVA: 0x00003626 File Offset: 0x00001826
		public virtual void WriteValue(byte? value)
		{
			if (value == null)
			{
				this.WriteNull();
				return;
			}
			this.WriteValue(value.GetValueOrDefault());
		}

		// Token: 0x06000560 RID: 1376 RVA: 0x00003645 File Offset: 0x00001845
		[CLSCompliant(false)]
		public virtual void WriteValue(sbyte? value)
		{
			if (value == null)
			{
				this.WriteNull();
				return;
			}
			this.WriteValue(value.GetValueOrDefault());
		}

		// Token: 0x06000561 RID: 1377 RVA: 0x00003664 File Offset: 0x00001864
		public virtual void WriteValue(decimal? value)
		{
			if (value == null)
			{
				this.WriteNull();
				return;
			}
			this.WriteValue(value.GetValueOrDefault());
		}

		// Token: 0x06000562 RID: 1378 RVA: 0x00003683 File Offset: 0x00001883
		public virtual void WriteValue(DateTime? value)
		{
			if (value == null)
			{
				this.WriteNull();
				return;
			}
			this.WriteValue(value.GetValueOrDefault());
		}

		// Token: 0x06000563 RID: 1379 RVA: 0x000036A2 File Offset: 0x000018A2
		public virtual void WriteValue(DateTimeOffset? value)
		{
			if (value == null)
			{
				this.WriteNull();
				return;
			}
			this.WriteValue(value.GetValueOrDefault());
		}

		// Token: 0x06000564 RID: 1380 RVA: 0x000036C1 File Offset: 0x000018C1
		public virtual void WriteValue(Guid? value)
		{
			if (value == null)
			{
				this.WriteNull();
				return;
			}
			this.WriteValue(value.GetValueOrDefault());
		}

		// Token: 0x06000565 RID: 1381 RVA: 0x000036E0 File Offset: 0x000018E0
		public virtual void WriteValue(TimeSpan? value)
		{
			if (value == null)
			{
				this.WriteNull();
				return;
			}
			this.WriteValue(value.GetValueOrDefault());
		}

		// Token: 0x06000566 RID: 1382 RVA: 0x0003D468 File Offset: 0x0003B668
		[NullableContext(2)]
		public virtual void WriteValue(byte[] value)
		{
			for (;;)
			{
				int num;
				if (value == null)
				{
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa49bb51056944098afe92e3a80a544b == 0)
					{
						goto IL_001F;
					}
				}
				else
				{
					this.InternalWriteValue(JsonToken.Bytes);
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4b8a72ce901241b5b52fe60600cb3607 == 0)
					{
						break;
					}
				}
				IL_0036:
				switch (num)
				{
				case 1:
					IL_001F:
					this.WriteNull();
					num = 3;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d5af2cccac2f47ed978e804138a35d1c != 0)
					{
						goto IL_0036;
					}
					return;
				case 2:
					continue;
				case 3:
					return;
				}
				break;
			}
		}

		// Token: 0x06000567 RID: 1383 RVA: 0x0003D4E0 File Offset: 0x0003B6E0
		[NullableContext(2)]
		public virtual void WriteValue(Uri value)
		{
			while (value == null)
			{
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_48fe014748e848c88d3254f339047927 != 0)
				{
					goto IL_0015;
				}
				IL_002C:
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
				this.WriteNull();
				num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7af5c533f30e4bd1bda86ce6098441d2 == 0)
				{
					goto IL_002C;
				}
				return;
			}
			this.InternalWriteValue(JsonToken.String);
		}

		// Token: 0x06000568 RID: 1384 RVA: 0x0003D548 File Offset: 0x0003B748
		[NullableContext(2)]
		public virtual void WriteValue(object value)
		{
			for (;;)
			{
				int num;
				if (value == null)
				{
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3a299c01dd4f4a209bdbd1b98e3f1406 != 0)
					{
						break;
					}
				}
				else
				{
					if (value is BigInteger)
					{
						goto IL_0073;
					}
					num = 2;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_bc7a9075386042ad9ce36653fcde3fc3 == 0)
					{
						goto IL_005E;
					}
				}
				switch (num)
				{
				case 1:
					continue;
				case 2:
					goto IL_0073;
				case 3:
					return;
				case 4:
					goto IL_005F;
				case 5:
					return;
				}
				break;
			}
			this.WriteNull();
			return;
			IL_005E:
			IL_005F:
			JsonWriter.WriteValue(this, ConvertUtils.GetTypeCode(value.GetType()), value);
			return;
			IL_0073:
			throw JsonWriter.smethod_1(this, value);
		}

		// Token: 0x06000569 RID: 1385 RVA: 0x000036FF File Offset: 0x000018FF
		[NullableContext(2)]
		public virtual void WriteComment(string text)
		{
			this.InternalWriteComment();
		}

		// Token: 0x0600056A RID: 1386 RVA: 0x0003D5D0 File Offset: 0x0003B7D0
		public virtual void WriteWhitespace(string ws)
		{
			for (;;)
			{
				this.InternalWriteWhitespace(ws);
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5be00c24d71649dcae8af3eed7b74ac9 != 0)
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

		// Token: 0x0600056B RID: 1387 RVA: 0x0003D608 File Offset: 0x0003B808
		void IDisposable.Dispose()
		{
			for (;;)
			{
				this.Dispose(true);
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d5af2cccac2f47ed978e804138a35d1c == 0)
				{
					goto IL_0003;
				}
				IL_001A:
				switch (num)
				{
				case 1:
					IL_0003:
					GC.SuppressFinalize(this);
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_186d640068094cc595a341ef95c9a29a != 0)
					{
						goto IL_001A;
					}
					break;
				case 2:
					continue;
				}
				break;
			}
		}

		// Token: 0x0600056C RID: 1388 RVA: 0x0003D660 File Offset: 0x0003B860
		protected virtual void Dispose(bool disposing)
		{
			for (;;)
			{
				if (this.state_1 != JsonWriter.State.Closed && disposing)
				{
					goto IL_0003;
				}
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0efaea2f67ca4b0aa2880fbd34fc0fff != 0)
				{
					break;
				}
				IL_001A:
				switch (num)
				{
				case 1:
				case 2:
					return;
				case 3:
					continue;
				}
				IL_0003:
				this.Close();
				num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3436841e08c54f56b10b76e1438d4224 == 0)
				{
					goto IL_001A;
				}
				break;
			}
		}

		// Token: 0x0600056D RID: 1389 RVA: 0x0003D6CC File Offset: 0x0003B8CC
		internal static void WriteValue(JsonWriter writer, PrimitiveTypeCode typeCode, object value)
		{
			for (;;)
			{
				int num;
				switch (typeCode)
				{
				case PrimitiveTypeCode.Char:
					goto IL_075C;
				case PrimitiveTypeCode.CharNullable:
					goto IL_04DE;
				case PrimitiveTypeCode.Boolean:
					goto IL_0503;
				case PrimitiveTypeCode.BooleanNullable:
					goto IL_0514;
				case PrimitiveTypeCode.SByte:
					goto IL_0539;
				case PrimitiveTypeCode.SByteNullable:
					writer.WriteValue((value == null) ? null : new sbyte?((sbyte)value));
					num = 47;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39a47a907a8a440980940ae96da3f3ad == 0)
					{
						goto Block_29;
					}
					break;
				case PrimitiveTypeCode.Int16:
					goto IL_0550;
				case PrimitiveTypeCode.Int16Nullable:
					goto IL_0561;
				case PrimitiveTypeCode.UInt16:
					goto IL_0586;
				case PrimitiveTypeCode.UInt16Nullable:
					writer.WriteValue((value != null) ? new ushort?((ushort)value) : null);
					num = 13;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_186d640068094cc595a341ef95c9a29a != 0)
					{
						goto Block_27;
					}
					break;
				case PrimitiveTypeCode.Int32:
					goto IL_059D;
				case PrimitiveTypeCode.Int32Nullable:
					goto IL_05AE;
				case PrimitiveTypeCode.Byte:
					goto IL_05D3;
				case PrimitiveTypeCode.ByteNullable:
					goto IL_05E4;
				case PrimitiveTypeCode.UInt32:
					goto IL_0609;
				case PrimitiveTypeCode.UInt32Nullable:
					goto IL_061A;
				case PrimitiveTypeCode.Int64:
					writer.WriteValue((long)value);
					num = 2;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e6fac70dd3e841b6925374855ecd7fb1 == 0)
					{
						goto Block_25;
					}
					break;
				case PrimitiveTypeCode.Int64Nullable:
					goto IL_0645;
				case PrimitiveTypeCode.UInt64:
					writer.WriteValue((ulong)value);
					num = 22;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c367d9ce11cc43b595beeb4524149542 != 0)
					{
						goto Block_24;
					}
					break;
				case PrimitiveTypeCode.UInt64Nullable:
					goto IL_0670;
				case PrimitiveTypeCode.Single:
					writer.WriteValue((float)value);
					num = 21;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_832998aae3714af0a1270bf2bb566909 == 0)
					{
						goto Block_23;
					}
					break;
				case PrimitiveTypeCode.SingleNullable:
					writer.WriteValue((value != null) ? new float?((float)value) : null);
					num = 36;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8d68b74cee6442019d959192b2974e3d != 0)
					{
						goto Block_22;
					}
					break;
				case PrimitiveTypeCode.Double:
					writer.WriteValue((double)value);
					num = 4;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c08ab7af63da4f24a4fa3e9c7a732fae != 0)
					{
						goto Block_20;
					}
					break;
				case PrimitiveTypeCode.DoubleNullable:
					writer.WriteValue((value == null) ? null : new double?((double)value));
					num = 11;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_bc7a9075386042ad9ce36653fcde3fc3 == 0)
					{
						goto Block_19;
					}
					break;
				case PrimitiveTypeCode.DateTime:
					goto IL_06AD;
				case PrimitiveTypeCode.DateTimeNullable:
					writer.WriteValue((value != null) ? new DateTime?((DateTime)value) : null);
					num = 6;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9bd9937edf9d4ad8bd673dfcb5a5e3cb == 0)
					{
						goto Block_17;
					}
					break;
				case PrimitiveTypeCode.DateTimeOffset:
					goto IL_06C4;
				case PrimitiveTypeCode.DateTimeOffsetNullable:
					writer.WriteValue((value == null) ? null : new DateTimeOffset?((DateTimeOffset)value));
					num = 14;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b2d935deb963472994f6f2321f1a6296 != 0)
					{
						goto Block_15;
					}
					break;
				case PrimitiveTypeCode.Decimal:
					goto IL_06DB;
				case PrimitiveTypeCode.DecimalNullable:
					goto IL_06EC;
				case PrimitiveTypeCode.Guid:
					writer.WriteValue((Guid)value);
					num = 23;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8432da17e8384a688cea4636964d3693 == 0)
					{
						goto Block_13;
					}
					break;
				case PrimitiveTypeCode.GuidNullable:
					writer.WriteValue((value != null) ? new Guid?((Guid)value) : null);
					num = 39;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5be00c24d71649dcae8af3eed7b74ac9 != 0)
					{
						goto Block_12;
					}
					break;
				case PrimitiveTypeCode.TimeSpan:
					goto IL_0714;
				case PrimitiveTypeCode.TimeSpanNullable:
					writer.WriteValue((value != null) ? new TimeSpan?((TimeSpan)value) : null);
					num = 38;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bd75de9a0b64d6da3a43e57303102f1 == 0)
					{
						goto Block_10;
					}
					break;
				case PrimitiveTypeCode.BigInteger:
					goto IL_0725;
				case PrimitiveTypeCode.BigIntegerNullable:
					writer.WriteValue((value == null) ? null : new BigInteger?((BigInteger)value));
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7ae4da5a55de471eb12dd0de8dd4269c == 0)
					{
						goto Block_8;
					}
					break;
				case PrimitiveTypeCode.Uri:
					goto IL_073B;
				case PrimitiveTypeCode.String:
					writer.WriteValue((string)value);
					num = 5;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_eaded84ad5b14e1ea8d4d97bfed1bb48 == 0)
					{
						goto Block_6;
					}
					break;
				case PrimitiveTypeCode.Bytes:
					writer.WriteValue((byte[])value);
					num = 27;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e5c1d856e0c64e6f8377f7d819e11923 == 0)
					{
						goto Block_1;
					}
					break;
				case PrimitiveTypeCode.DBNull:
					goto IL_0794;
				default:
					goto IL_0050;
				}
				IL_005A:
				IConvertible convertible;
				switch (num)
				{
				case 1:
					goto IL_0777;
				case 2:
					return;
				case 3:
					return;
				case 4:
					return;
				case 5:
					return;
				case 6:
					return;
				case 7:
					return;
				case 8:
					return;
				case 9:
					return;
				case 10:
					IL_0050:
					convertible = value as IConvertible;
					goto IL_0046;
				case 11:
				case 33:
					continue;
				case 12:
					return;
				case 13:
					return;
				case 14:
					return;
				case 15:
					return;
				case 16:
					return;
				case 17:
				case 34:
					goto IL_0029;
				case 18:
					goto IL_075C;
				case 19:
					goto IL_0046;
				case 20:
					return;
				case 21:
					return;
				case 22:
					return;
				case 23:
					return;
				case 24:
					return;
				case 25:
					return;
				case 26:
					return;
				case 27:
					return;
				case 28:
					return;
				case 29:
					return;
				case 30:
					return;
				case 31:
					return;
				case 32:
					return;
				case 35:
					return;
				case 36:
					return;
				case 37:
					return;
				case 38:
					return;
				case 39:
					return;
				case 40:
					goto IL_012D;
				case 41:
					return;
				case 42:
					return;
				case 43:
					return;
				case 44:
					return;
				case 45:
					return;
				case 46:
					return;
				case 47:
					return;
				case 48:
					return;
				case 49:
					return;
				}
				goto Block_5;
				IL_012D:
				JsonWriter.smethod_0(convertible, out typeCode, out value);
				continue;
				IL_0046:
				if (convertible != null)
				{
					goto IL_012D;
				}
				IL_0029:
				if (value != null)
				{
					goto IL_077E;
				}
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b2d935deb963472994f6f2321f1a6296 != 0)
				{
					goto Block_3;
				}
				goto IL_005A;
			}
			Block_1:
			return;
			Block_3:
			goto IL_0777;
			Block_5:
			return;
			Block_6:
			goto IL_0777;
			Block_8:
			Block_10:
			return;
			Block_12:
			return;
			Block_13:
			return;
			Block_15:
			return;
			Block_17:
			return;
			Block_19:
			return;
			Block_20:
			return;
			Block_22:
			return;
			Block_23:
			return;
			Block_24:
			Block_25:
			return;
			Block_27:
			return;
			Block_29:
			return;
			IL_04DE:
			writer.WriteValue((value == null) ? null : new char?((char)value));
			return;
			IL_0503:
			writer.WriteValue((bool)value);
			return;
			IL_0514:
			writer.WriteValue((value != null) ? new bool?((bool)value) : null);
			return;
			IL_0539:
			writer.WriteValue((sbyte)value);
			return;
			IL_0550:
			writer.WriteValue((short)value);
			return;
			IL_0561:
			writer.WriteValue((value != null) ? new short?((short)value) : null);
			return;
			IL_0586:
			writer.WriteValue((ushort)value);
			return;
			IL_059D:
			writer.WriteValue((int)value);
			return;
			IL_05AE:
			writer.WriteValue((value == null) ? null : new int?((int)value));
			return;
			IL_05D3:
			writer.WriteValue((byte)value);
			return;
			IL_05E4:
			writer.WriteValue((value == null) ? null : new byte?((byte)value));
			return;
			IL_0609:
			writer.WriteValue((uint)value);
			return;
			IL_061A:
			writer.WriteValue((value != null) ? new uint?((uint)value) : null);
			return;
			IL_0645:
			writer.WriteValue((value == null) ? null : new long?((long)value));
			return;
			IL_0670:
			writer.WriteValue((value != null) ? new ulong?((ulong)value) : null);
			return;
			IL_06AD:
			writer.WriteValue((DateTime)value);
			return;
			IL_06C4:
			writer.WriteValue((DateTimeOffset)value);
			return;
			IL_06DB:
			writer.WriteValue((decimal)value);
			return;
			IL_06EC:
			writer.WriteValue((value == null) ? null : new decimal?((decimal)value));
			return;
			IL_0714:
			writer.WriteValue((TimeSpan)value);
			return;
			IL_0725:
			writer.WriteValue((BigInteger)value);
			return;
			IL_073B:
			writer.WriteValue((Uri)value);
			return;
			IL_075C:
			writer.WriteValue((char)value);
			return;
			IL_0777:
			writer.WriteNull();
			return;
			IL_077E:
			throw JsonWriter.smethod_1(writer, value);
			IL_0794:
			writer.WriteNull();
		}

		// Token: 0x0600056E RID: 1390 RVA: 0x0003DE74 File Offset: 0x0003C074
		private static void smethod_0(IConvertible iconvertible_0, out PrimitiveTypeCode primitiveTypeCode_0, out object object_0)
		{
			for (;;)
			{
				IL_00B2:
				TypeInformation typeInformation = ConvertUtils.GetTypeInformation(iconvertible_0);
				for (;;)
				{
					IL_0006:
					primitiveTypeCode_0 = ((typeInformation.TypeCode == PrimitiveTypeCode.Object) ? PrimitiveTypeCode.String : typeInformation.TypeCode);
					for (;;)
					{
						IL_0096:
						Type type;
						if (typeInformation.TypeCode == PrimitiveTypeCode.Object)
						{
							type = typeof(string);
							goto IL_006C;
						}
						int num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0b405dced5e94c80928a74c5773182d9 == 0)
						{
							goto IL_0065;
						}
						Type type2;
						for (;;)
						{
							IL_0048:
							switch (num)
							{
							default:
								goto IL_0065;
							case 1:
								return;
							case 2:
								goto IL_0006;
							case 3:
								goto IL_00B2;
							case 4:
								goto IL_0096;
							case 5:
								object_0 = iconvertible_0.ToType(type2, CultureInfo.InvariantCulture);
								num = 1;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b17e63564ae246399767b60cf4b1528a == 0)
								{
									return;
								}
								break;
							}
						}
						IL_006C:
						type2 = type;
						num = 5;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c5a086ee5649458eb5e1e6e4f0f1f4d3 != 0)
						{
							goto IL_0048;
						}
						IL_0065:
						type = typeInformation.Type;
						goto IL_006C;
					}
				}
			}
		}

		// Token: 0x0600056F RID: 1391 RVA: 0x00003707 File Offset: 0x00001907
		private static JsonWriterException smethod_1(JsonWriter jsonWriter_0, object object_0)
		{
			return JsonWriterException.Create(jsonWriter_0, Class15.smethod_17(2128216660 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_871a407507f34aa3b5bf52517d4f63a9).FormatWith(CultureInfo.InvariantCulture, object_0.GetType()), null);
		}

		// Token: 0x06000570 RID: 1392 RVA: 0x0003DF44 File Offset: 0x0003C144
		protected void SetWriteState(JsonToken token, object value)
		{
			for (;;)
			{
				int num;
				string text;
				switch (token)
				{
				case JsonToken.StartObject:
					goto IL_0191;
				case JsonToken.StartArray:
					goto IL_0156;
				case JsonToken.StartConstructor:
					this.InternalWriteStart(token, JsonContainerType.Constructor);
					num = 15;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c27e9fccdfcc44999155a4980faa4e81 == 0)
					{
						goto Block_5;
					}
					break;
				case JsonToken.PropertyName:
					text = value as string;
					goto IL_0024;
				case JsonToken.Comment:
					this.InternalWriteComment();
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4ac69ea2381b403582a2723337f67fa8 != 0)
					{
						goto Block_4;
					}
					break;
				case JsonToken.Raw:
					goto IL_0166;
				case JsonToken.Integer:
				case JsonToken.Float:
				case JsonToken.String:
				case JsonToken.Boolean:
				case JsonToken.Null:
				case JsonToken.Undefined:
				case JsonToken.Date:
				case JsonToken.Bytes:
					goto IL_01DC;
				case JsonToken.EndObject:
					this.InternalWriteEnd(JsonContainerType.Object);
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8f48544341da433d9f954b548c7e9212 != 0)
					{
						goto Block_1;
					}
					break;
				case JsonToken.EndArray:
					goto IL_01CC;
				case JsonToken.EndConstructor:
					goto IL_01D4;
				default:
					num = 6;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_6bf87ae21d2446cfa7edc53669bb8039 != 0)
					{
						goto Block_6;
					}
					break;
				}
				IL_0059:
				switch (num)
				{
				case 1:
					return;
				case 2:
					goto IL_003D;
				case 3:
					return;
				case 4:
					return;
				case 5:
					goto IL_0191;
				case 6:
					return;
				case 7:
					return;
				case 8:
					goto IL_019A;
				case 9:
					return;
				case 10:
					return;
				case 11:
					goto IL_0175;
				case 12:
					continue;
				case 13:
					IL_0024:
					if (text == null)
					{
						goto IL_019A;
					}
					num = 2;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_75738dd4edc84122bfe3748a1ea03d43 == 0)
					{
						goto IL_003D;
					}
					goto IL_0059;
				case 14:
					return;
				case 15:
					return;
				}
				goto Block_3;
				IL_003D:
				this.InternalWritePropertyName(text);
				num = 14;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3a102d6e4dd542a6855b81a93c692545 == 0)
				{
					goto IL_0059;
				}
				goto IL_0190;
			}
			Block_1:
			return;
			Block_3:
			Block_4:
			return;
			Block_5:
			goto IL_019A;
			Block_6:
			goto IL_0175;
			IL_0156:
			this.InternalWriteStart(token, JsonContainerType.Array);
			return;
			IL_0166:
			this.InternalWriteRaw();
			return;
			IL_0175:
			throw new ArgumentOutOfRangeException(Class15.smethod_17(552192964 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_01137da6c88c4265bdc0297aacf3340f));
			IL_0190:
			IL_0191:
			this.InternalWriteStart(token, JsonContainerType.Object);
			return;
			IL_019A:
			throw new ArgumentException(Class15.smethod_17(642147182 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa29cbda752f45acbe81e7d5285df2ba), Class15.smethod_17(277633428 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9f9b31fb7a85497499112abf86cccc98));
			IL_01CC:
			this.InternalWriteEnd(JsonContainerType.Array);
			return;
			IL_01D4:
			this.InternalWriteEnd(JsonContainerType.Constructor);
			return;
			IL_01DC:
			this.InternalWriteValue(token);
		}

		// Token: 0x06000571 RID: 1393 RVA: 0x0003E134 File Offset: 0x0003C334
		internal void InternalWriteEnd(JsonContainerType container)
		{
			for (;;)
			{
				this.method_10(container);
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_6f87b5b72b9847f7b8ec5b44b0dccfa8 == 0)
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

		// Token: 0x06000572 RID: 1394 RVA: 0x0003E16C File Offset: 0x0003C36C
		internal void InternalWritePropertyName(string name)
		{
			for (;;)
			{
				IL_002F:
				this.jsonPosition_0.PropertyName = name;
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c5a086ee5649458eb5e1e6e4f0f1f4d3 == 0)
				{
					break;
				}
				for (;;)
				{
					switch (num)
					{
					case 1:
						this.AutoComplete(JsonToken.PropertyName);
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c08ab7af63da4f24a4fa3e9c7a732fae != 0)
						{
							continue;
						}
						break;
					case 2:
						goto IL_002F;
					}
					return;
				}
			}
		}

		// Token: 0x06000573 RID: 1395 RVA: 0x00002420 File Offset: 0x00000620
		internal void InternalWriteRaw()
		{
		}

		// Token: 0x06000574 RID: 1396 RVA: 0x0003E1CC File Offset: 0x0003C3CC
		internal void InternalWriteStart(JsonToken token, JsonContainerType container)
		{
			for (;;)
			{
				this.UpdateScopeWithFinishedValue();
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d6c400f349964629bcd869033695bff0 != 0)
				{
					goto IL_001E;
				}
				IL_0039:
				switch (num)
				{
				case 1:
					IL_001E:
					this.AutoComplete(token);
					num = 3;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0005996a6a494de4880ac2956b2e0112 != 0)
					{
						goto IL_0003;
					}
					goto IL_0039;
				case 2:
					continue;
				case 3:
					goto IL_0003;
				}
				break;
				IL_0003:
				this.method_0(container);
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_43b32b9d66294210a955990bb6fcc511 == 0)
				{
					break;
				}
				goto IL_0039;
			}
		}

		// Token: 0x06000575 RID: 1397 RVA: 0x0003E248 File Offset: 0x0003C448
		internal void InternalWriteValue(JsonToken token)
		{
			for (;;)
			{
				this.UpdateScopeWithFinishedValue();
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_1db17fe7bd2442b599c52df89f39e610 != 0)
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
				this.AutoComplete(token);
				num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39d5fbfa4fe34ed9908db538e5340a6c == 0)
				{
					goto IL_001B;
				}
				break;
			}
		}

		// Token: 0x06000576 RID: 1398 RVA: 0x0003E2A0 File Offset: 0x0003C4A0
		internal void InternalWriteWhitespace(string ws)
		{
			while (ws != null)
			{
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c27e9fccdfcc44999155a4980faa4e81 == 0)
				{
					goto IL_0015;
				}
				IL_002E:
				switch (num)
				{
				case 0:
					return;
				case 1:
					IL_0015:
					if (StringUtils.IsWhiteSpace(ws))
					{
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a41eabd4b99f489fb7d86310d3f95ba2 == 0)
						{
							goto IL_002E;
						}
						return;
					}
					break;
				case 2:
					continue;
				case 3:
					break;
				default:
					return;
				}
				throw JsonWriterException.Create(this, Class15.smethod_17(635829563 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a41eabd4b99f489fb7d86310d3f95ba2), null);
			}
		}

		// Token: 0x06000577 RID: 1399 RVA: 0x0003E31C File Offset: 0x0003C51C
		internal void InternalWriteComment()
		{
			for (;;)
			{
				this.AutoComplete(JsonToken.Comment);
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8bcabc342a5a44748f3978da7f62051e == 0)
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

		// Token: 0x040002EA RID: 746
		private static readonly JsonWriter.State[][] state_0;

		// Token: 0x040002EB RID: 747
		internal static readonly JsonWriter.State[][] StateArrayTemplate;

		// Token: 0x040002EC RID: 748
		[Nullable(2)]
		private List<JsonPosition> list_0;

		// Token: 0x040002ED RID: 749
		private JsonPosition jsonPosition_0;

		// Token: 0x040002EE RID: 750
		private JsonWriter.State state_1;

		// Token: 0x040002EF RID: 751
		private Formatting formatting_0;

		// Token: 0x040002F0 RID: 752
		[CompilerGenerated]
		private bool bool_0;

		// Token: 0x040002F1 RID: 753
		[CompilerGenerated]
		private bool bool_1;

		// Token: 0x040002F2 RID: 754
		private DateFormatHandling dateFormatHandling_0;

		// Token: 0x040002F3 RID: 755
		private DateTimeZoneHandling dateTimeZoneHandling_0;

		// Token: 0x040002F4 RID: 756
		private StringEscapeHandling stringEscapeHandling_0;

		// Token: 0x040002F5 RID: 757
		private FloatFormatHandling floatFormatHandling_0;

		// Token: 0x040002F6 RID: 758
		[Nullable(2)]
		private string string_0;

		// Token: 0x040002F7 RID: 759
		[Nullable(2)]
		private CultureInfo cultureInfo_0;

		// Token: 0x02000071 RID: 113
		[NullableContext(0)]
		internal enum State
		{
			// Token: 0x040002FA RID: 762
			Start,
			// Token: 0x040002FB RID: 763
			Property,
			// Token: 0x040002FC RID: 764
			ObjectStart,
			// Token: 0x040002FD RID: 765
			Object,
			// Token: 0x040002FE RID: 766
			ArrayStart,
			// Token: 0x040002FF RID: 767
			Array,
			// Token: 0x04000300 RID: 768
			ConstructorStart,
			// Token: 0x04000301 RID: 769
			Constructor,
			// Token: 0x04000302 RID: 770
			Closed,
			// Token: 0x04000303 RID: 771
			Error
		}
	}
}
