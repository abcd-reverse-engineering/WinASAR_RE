using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Linq.JsonPath
{
	// Token: 0x02000182 RID: 386
	[NullableContext(1)]
	[Nullable(0)]
	internal class BooleanQueryExpression : QueryExpression
	{
		// Token: 0x0600114C RID: 4428 RVA: 0x0008A054 File Offset: 0x00088254
		public BooleanQueryExpression(QueryOperator @operator, object left, [Nullable(2)] object right)
			: base(@operator)
		{
			for (;;)
			{
				this.Left = left;
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_1db17fe7bd2442b599c52df89f39e610 != 0)
				{
					goto IL_000B;
				}
				IL_0023:
				switch (num)
				{
				case 1:
					IL_000B:
					this.Right = right;
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e764f065c2fa404a85129e2e957d4f18 == 0)
					{
						goto IL_0023;
					}
					break;
				case 2:
					continue;
				}
				break;
			}
		}

		// Token: 0x0600114D RID: 4429 RVA: 0x0008A0B4 File Offset: 0x000882B4
		private IEnumerable<JToken> method_0(JToken jtoken_0, JToken jtoken_1, [Nullable(2)] object o)
		{
			JToken jtoken = o as JToken;
			if (jtoken != null)
			{
				return new JToken[] { jtoken };
			}
			List<PathFilter> list = o as List<PathFilter>;
			if (list != null)
			{
				return JPath.Evaluate(list, jtoken_0, jtoken_1, null);
			}
			return CollectionUtils.ArrayEmpty<JToken>();
		}

		// Token: 0x0600114E RID: 4430 RVA: 0x0008A0F0 File Offset: 0x000882F0
		public override bool IsMatch(JToken root, JToken t, [Nullable(2)] JsonSelectSettings settings)
		{
			while (this.Operator != QueryOperator.Exists)
			{
				IEnumerator<JToken> enumerator = this.method_0(root, t, this.Left).GetEnumerator();
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4b8a72ce901241b5b52fe60600cb3607 == 0)
				{
					switch (num)
					{
					case 1:
						return false;
					case 2:
						goto IL_004A;
					case 3:
						continue;
					}
				}
				try
				{
					if (enumerator.MoveNext())
					{
						for (;;)
						{
							IEnumerable<JToken> enumerable = this.method_0(root, t, this.Right);
							int num2 = 0;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8d68b74cee6442019d959192b2974e3d == 0)
							{
								goto IL_0185;
							}
							IL_01AA:
							ICollection<JToken> collection;
							switch (num2)
							{
							case 0:
								goto IL_0176;
							case 1:
								goto IL_00A2;
							case 2:
								IL_0185:
								if ((collection = enumerable as ICollection<JToken>) != null)
								{
									goto IL_0079;
								}
								num2 = 7;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_193800745ad94a529d9e5edc977c4f02 == 0)
								{
									goto IL_0072;
								}
								goto IL_01AA;
							case 3:
								break;
							case 4:
							case 6:
								goto IL_01FA;
							case 5:
								goto IL_007B;
							case 7:
								continue;
							case 8:
								goto IL_0072;
							default:
								goto IL_0176;
							}
							IL_0084:
							ICollection<JToken> collection2;
							IEnumerator<JToken> enumerator2 = collection2.GetEnumerator();
							num2 = 0;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8f48544341da433d9f954b548c7e9212 == 0)
							{
								goto IL_00A2;
							}
							goto IL_01AA;
							IL_007B:
							JToken jtoken = enumerator.Current;
							goto IL_0084;
							IL_0079:
							collection2 = collection;
							goto IL_007B;
							IL_0072:
							collection = enumerable.ToList<JToken>();
							goto IL_0079;
							IL_0176:
							if (!enumerator.MoveNext())
							{
								break;
							}
							goto IL_007B;
							IL_00A2:
							try
							{
								while (enumerator2.MoveNext())
								{
									bool flag;
									for (;;)
									{
										JToken jtoken2 = enumerator2.Current;
										int num3 = 2;
										if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_57ce3fecb9e64a8f924ea7658e146719 != 0)
										{
											goto IL_00BD;
										}
										IL_00DB:
										switch (num3)
										{
										case 2:
											continue;
										case 3:
											IL_00BD:
											if (this.method_1(jtoken, jtoken2, settings))
											{
												goto IL_00A6;
											}
											num3 = 0;
											if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e368897ba1744663a6d0bc59b9b65b5f != 0)
											{
												goto IL_00DB;
											}
											break;
										case 4:
											goto IL_0129;
										case 5:
											goto IL_00A6;
										case 6:
											goto IL_012B;
										}
										break;
										IL_00A6:
										flag = true;
										num3 = 6;
										if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93c7140125045538ae5c40c6f39a5af == 0)
										{
											break;
										}
										goto IL_00DB;
									}
									continue;
									IL_012B:
									return flag;
								}
								IL_0129:;
							}
							finally
							{
								if (enumerator2 != null)
								{
									goto IL_015C;
								}
								int num4 = 0;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c5a086ee5649458eb5e1e6e4f0f1f4d3 == 0)
								{
									goto IL_0175;
								}
								IL_0148:
								switch (num4)
								{
								case 1:
									IL_015C:
									enumerator2.Dispose();
									num4 = 1;
									if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cf58136e49114a5691c4a9d0e9788de1 != 0)
									{
										goto IL_0148;
									}
									break;
								}
								IL_0175:;
							}
							goto IL_0176;
						}
					}
					IL_01FA:;
				}
				finally
				{
					if (enumerator != null)
					{
						goto IL_0228;
					}
					int num5 = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3dc45d1ecdeb4859b7f470093f5eeed2 != 0)
					{
						goto IL_0241;
					}
					IL_0214:
					switch (num5)
					{
					case 2:
						IL_0228:
						enumerator.Dispose();
						num5 = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8db627a8c96145a0afb24deffd2a8808 != 0)
						{
							goto IL_0214;
						}
						break;
					}
					IL_0241:;
				}
				return false;
			}
			IL_004A:
			return this.method_0(root, t, this.Left).Any<JToken>();
		}

		// Token: 0x0600114F RID: 4431 RVA: 0x0008A378 File Offset: 0x00088578
		private bool method_1(JToken jtoken_0, JToken jtoken_1, [Nullable(2)] JsonSelectSettings settings)
		{
			JValue jvalue;
			JValue jvalue2;
			QueryOperator queryOperator;
			for (;;)
			{
				IL_01C5:
				jvalue = jtoken_0 as JValue;
				for (;;)
				{
					if (jvalue != null)
					{
						goto IL_019D;
					}
					int num = 24;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_92ac2a37edba4e2587eb1b9e8af3f63f != 0)
					{
						goto Block_13;
					}
					IL_0028:
					switch (num)
					{
					case 1:
						return true;
					case 2:
						return true;
					case 3:
						IL_019D:
						jvalue2 = jtoken_1 as JValue;
						goto IL_0193;
					case 4:
						return true;
					case 5:
						return true;
					case 6:
					case 7:
					case 13:
					case 17:
					case 18:
					case 20:
					case 26:
					case 27:
					case 28:
						return false;
					case 8:
					case 24:
						goto IL_0225;
					case 9:
						return true;
					case 10:
						return true;
					case 11:
						goto IL_0189;
					case 12:
						goto IL_022D;
					case 14:
						goto IL_0193;
					case 15:
						continue;
					case 16:
						goto IL_01C5;
					case 19:
						goto IL_0217;
					case 21:
						goto IL_014A;
					case 22:
						return true;
					case 23:
						return true;
					case 25:
						return true;
					}
					goto Block_2;
					IL_014A:
					switch (queryOperator)
					{
					case QueryOperator.Equals:
						goto IL_01D2;
					case QueryOperator.NotEquals:
						goto IL_01E0;
					case QueryOperator.Exists:
						return true;
					case QueryOperator.LessThan:
						goto IL_01F0;
					case QueryOperator.LessThanOrEquals:
						if (jvalue.CompareTo(jvalue2) <= 0)
						{
							return true;
						}
						num = 7;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e5c1d856e0c64e6f8377f7d819e11923 == 0)
						{
							goto Block_10;
						}
						goto IL_0028;
					case QueryOperator.GreaterThan:
						if (jvalue.CompareTo(jvalue2) > 0)
						{
							num = 0;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8bcabc342a5a44748f3978da7f62051e != 0)
							{
								goto Block_8;
							}
							goto IL_0028;
						}
						break;
					case QueryOperator.GreaterThanOrEquals:
						if (jvalue.CompareTo(jvalue2) >= 0)
						{
							num = 2;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93ade03426d44b1841bfa7c633f49f3 != 0)
							{
								goto Block_6;
							}
							goto IL_0028;
						}
						break;
					case QueryOperator.RegexEquals:
						goto IL_0217;
					case QueryOperator.StrictEquals:
						if (BooleanQueryExpression.EqualsWithStrictMatch(jvalue, jvalue2))
						{
							return true;
						}
						num = 27;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_11c6824de6514281a8425f6d6ab1a2d5 != 0)
						{
							goto Block_4;
						}
						goto IL_0028;
					case QueryOperator.StrictNotEquals:
						if (!BooleanQueryExpression.EqualsWithStrictMatch(jvalue, jvalue2))
						{
							return true;
						}
						num = 20;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5f127c3ec2e04c11ab1bd26a8d965f2b != 0)
						{
							goto IL_0028;
						}
						break;
					}
					goto Block_11;
					IL_0189:
					queryOperator = this.Operator;
					goto IL_014A;
					IL_0193:
					if (jvalue2 == null)
					{
						goto Block_12;
					}
					goto IL_0189;
				}
			}
			Block_2:
			return true;
			Block_4:
			goto IL_0225;
			Block_6:
			Block_8:
			return true;
			Block_10:
			return true;
			Block_11:
			return false;
			Block_12:
			Block_13:
			goto IL_0225;
			IL_01D2:
			if (!BooleanQueryExpression.EqualsWithStringCoercion(jvalue, jvalue2))
			{
				return false;
			}
			return true;
			IL_01E0:
			if (BooleanQueryExpression.EqualsWithStringCoercion(jvalue, jvalue2))
			{
				return false;
			}
			return true;
			IL_01F0:
			if (jvalue.CompareTo(jvalue2) >= 0)
			{
				return false;
			}
			return true;
			IL_0217:
			if (!BooleanQueryExpression.smethod_0(jvalue, jvalue2, settings))
			{
				return false;
			}
			return true;
			IL_0225:
			queryOperator = this.Operator;
			IL_022D:
			if (queryOperator - QueryOperator.NotEquals > 1)
			{
				return false;
			}
			return true;
		}

		// Token: 0x06001150 RID: 4432 RVA: 0x0008A5C4 File Offset: 0x000887C4
		private static bool smethod_0(object object_0, object object_1, [Nullable(2)] JsonSelectSettings settings)
		{
			while (object_0.Type == JTokenType.String)
			{
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_92ac2a37edba4e2587eb1b9e8af3f63f != 0)
				{
					goto IL_0018;
				}
				IL_0073:
				string text2;
				string text3;
				switch (num)
				{
				case 1:
					IL_0018:
					if (object_1.Type != JTokenType.String)
					{
						num = 3;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_43b32b9d66294210a955990bb6fcc511 == 0)
						{
							goto IL_0073;
						}
					}
					else
					{
						string text = (string)object_1.Value;
						int num2 = text.LastIndexOf('/');
						text2 = text.Substring(1, num2 - 1);
						text3 = text.Substring(num2 + 1);
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d6c400f349964629bcd869033695bff0 != 0)
						{
							goto IL_0073;
						}
					}
					break;
				case 2:
					continue;
				case 3:
					return false;
				}
				return Regex.IsMatch((string)object_0.Value, text2, MiscellaneousUtils.GetRegexOptions(text3));
			}
			return false;
		}

		// Token: 0x06001151 RID: 4433 RVA: 0x0008A68C File Offset: 0x0008888C
		internal static bool EqualsWithStringCoercion(JValue value, JValue queryValue)
		{
			IL_015C:
			while (!value.Equals(queryValue))
			{
				string text;
				StringWriter stringWriter;
				for (;;)
				{
					IL_0150:
					if (value.Type == JTokenType.Integer)
					{
						goto IL_011B;
					}
					for (;;)
					{
						IL_0144:
						if (value.Type != JTokenType.Float)
						{
							goto IL_0109;
						}
						int num = 2;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93ade03426d44b1841bfa7c633f49f3 != 0)
						{
							goto IL_0095;
						}
						for (;;)
						{
							IL_00B1:
							switch (num)
							{
							case 1:
								goto IL_0172;
							case 2:
								if (queryValue.Type != JTokenType.Integer)
								{
									goto IL_0109;
								}
								num = 9;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3dc45d1ecdeb4859b7f470093f5eeed2 == 0)
								{
									goto Block_5;
								}
								continue;
							case 3:
							case 10:
								return false;
							case 4:
								return true;
							case 5:
								goto IL_004A;
							case 6:
								goto IL_002A;
							case 7:
								goto IL_0144;
							case 8:
							case 12:
							case 15:
								goto IL_02BB;
							case 9:
								goto IL_0267;
							case 11:
								goto IL_011B;
							case 13:
								goto IL_027D;
							case 14:
								return false;
							case 16:
								goto IL_029A;
							case 17:
								goto IL_0150;
							case 18:
								goto IL_015C;
							case 19:
								goto IL_02A9;
							}
							break;
						}
						goto IL_0095;
						IL_0109:
						if (queryValue.Type != JTokenType.String)
						{
							goto Block_8;
						}
						text = (string)queryValue.Value;
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e764f065c2fa404a85129e2e957d4f18 == 0)
						{
							goto IL_0095;
						}
						goto IL_00B1;
						IL_002A:
						stringWriter = StringUtils.CreateStringWriter(64);
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5c76a4eb2c1748d1bee3513c8eaff2eb != 0)
						{
							goto Block_2;
						}
						goto IL_00B1;
						IL_004A:
						JTokenType type;
						switch (type)
						{
						case JTokenType.Date:
							goto IL_002A;
						case JTokenType.Bytes:
							goto IL_0267;
						case JTokenType.Guid:
						case JTokenType.TimeSpan:
							goto IL_029A;
						case JTokenType.Uri:
							goto IL_02A9;
						}
						goto Block_3;
						IL_0095:
						type = value.Type;
						num = 2;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ae8c3d3c66a64b57beca0f5360302062 == 0)
						{
							goto IL_004A;
						}
						goto IL_00B1;
					}
					IL_011B:
					if (queryValue.Type != JTokenType.Float)
					{
						goto IL_0144;
					}
					goto IL_027D;
				}
				Block_2:
				goto IL_0172;
				Block_3:
				return false;
				Block_5:
				goto IL_027D;
				Block_8:
				return false;
				IL_0172:
				string text2;
				try
				{
					object value2 = value.Value;
					int num2 = 6;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_832998aae3714af0a1270bf2bb566909 == 0)
					{
						goto IL_01ED;
					}
					IL_018D:
					if (value2 is DateTimeOffset)
					{
						goto IL_01C3;
					}
					IL_0196:
					DateTimeUtils.WriteDateTimeString(stringWriter, (DateTime)value.Value, DateFormatHandling.IsoDateFormat, null, CultureInfo.InvariantCulture);
					num2 = 5;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_67cbcb2ad04040d48847c1ca2f65be32 != 0)
					{
						goto IL_0219;
					}
					goto IL_01ED;
					IL_01C3:
					DateTimeOffset dateTimeOffset = (DateTimeOffset)value2;
					IL_01CC:
					DateTimeUtils.WriteDateTimeOffsetString(stringWriter, dateTimeOffset, DateFormatHandling.IsoDateFormat, null, CultureInfo.InvariantCulture);
					num2 = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a41eabd4b99f489fb7d86310d3f95ba2 != 0)
					{
						goto IL_0219;
					}
					IL_01ED:
					switch (num2)
					{
					case 1:
					case 2:
						goto IL_0196;
					case 3:
						goto IL_01CC;
					case 4:
						goto IL_0222;
					case 6:
						goto IL_01C3;
					case 7:
						goto IL_018D;
					}
					IL_0219:
					text2 = stringWriter.ToString();
					IL_0222:
					goto IL_02BB;
				}
				finally
				{
					if (stringWriter != null)
					{
						int num3 = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_725e5f82c8704b39b66ebddcee8df7fa != 0)
						{
							goto IL_0255;
						}
						IL_023D:
						((IDisposable)stringWriter).Dispose();
						num3 = 1;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fd59e876ac704e7eaa7c7a24a9b3a23f != 0)
						{
							goto IL_0266;
						}
						IL_0255:
						switch (num3)
						{
						case 0:
							goto IL_023D;
						case 1:
							break;
						default:
							goto IL_023D;
						}
					}
					IL_0266:;
				}
				IL_0267:
				text2 = Convert.ToBase64String((byte[])value.Value);
				goto IL_02BB;
				IL_027D:
				return JValue.Compare(value.Type, value.Value, queryValue.Value) == 0;
				IL_029A:
				text2 = value.Value.ToString();
				goto IL_02BB;
				IL_02A9:
				text2 = ((Uri)value.Value).OriginalString;
				IL_02BB:
				return string.Equals(text2, text, StringComparison.Ordinal);
			}
			return true;
		}

		// Token: 0x06001152 RID: 4434 RVA: 0x0008A970 File Offset: 0x00088B70
		internal static bool EqualsWithStrictMatch(JValue value, JValue queryValue)
		{
			for (;;)
			{
				if (value.Type != JTokenType.Integer)
				{
					goto IL_008C;
				}
				IL_004C:
				int num;
				while (queryValue.Type != JTokenType.Float)
				{
					num = 4;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_17bdafd603b54a77a2e4a383bd4dcffa == 0)
					{
						goto IL_0058;
					}
				}
				goto IL_00A8;
				IL_0058:
				switch (num)
				{
				case 1:
					goto IL_00A8;
				case 2:
					goto IL_004C;
				case 3:
					continue;
				case 4:
					IL_008C:
					if (value.Type == JTokenType.Float)
					{
						goto IL_001D;
					}
					goto IL_0078;
				case 5:
					goto IL_001D;
				}
				break;
				IL_001D:
				if (queryValue.Type == JTokenType.Integer)
				{
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a5994720d09542abb897ebf6ad9b5a19 == 0)
					{
						goto Block_3;
					}
					goto IL_0058;
				}
				IL_0078:
				if (value.Type == queryValue.Type)
				{
					goto IL_00C3;
				}
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_db7740c6ca7a4f3c8e1aa526bdb0a454 != 0)
				{
					break;
				}
				goto IL_0058;
			}
			return false;
			Block_3:
			IL_00A8:
			return JValue.Compare(value.Type, value.Value, queryValue.Value) == 0;
			IL_00C3:
			return value.Equals(queryValue);
		}

		// Token: 0x040007B1 RID: 1969
		public readonly object Left;

		// Token: 0x040007B2 RID: 1970
		[Nullable(2)]
		public readonly object Right;
	}
}
