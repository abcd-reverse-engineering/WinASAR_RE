using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Dynamic;
using System.Globalization;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Linq
{
	// Token: 0x0200016D RID: 365
	[Nullable(0)]
	[NullableContext(2)]
	public class JValue : JToken, IEquatable<JValue>, IFormattable, IComparable, IComparable<JValue>, IConvertible
	{
		// Token: 0x06001075 RID: 4213 RVA: 0x000823C4 File Offset: 0x000805C4
		internal JValue(object value, JTokenType type)
		{
			int num = 1;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5e301544981d4903aa4e531970a47849 != 0)
			{
				goto IL_004B;
			}
			IL_001A:
			this.uri_0 = value;
			num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_48fe014748e848c88d3254f339047927 != 0)
			{
				goto IL_004B;
			}
			IL_0033:
			this.khlHotcLxy = type;
			num = 1;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_725e5f82c8704b39b66ebddcee8df7fa != 0)
			{
				return;
			}
			IL_004B:
			switch (num)
			{
			case 0:
				goto IL_0033;
			case 1:
				break;
			case 2:
				goto IL_001A;
			default:
				goto IL_0033;
			}
		}

		// Token: 0x06001076 RID: 4214 RVA: 0x00082434 File Offset: 0x00080634
		[NullableContext(1)]
		internal JValue(JValue other, [Nullable(2)] JsonCloneSettings settings)
			: this(other.Value, other.Type)
		{
			for (;;)
			{
				if (settings == null)
				{
					goto IL_0053;
				}
				bool flag = settings.CopyAnnotations;
				IL_006A:
				if (flag)
				{
					goto IL_001E;
				}
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d5af2cccac2f47ed978e804138a35d1c == 0)
				{
					break;
				}
				IL_0037:
				switch (num)
				{
				case 2:
					IL_0053:
					flag = true;
					goto IL_006A;
				case 3:
					IL_001E:
					base.CopyAnnotations(this, other);
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93c7140125045538ae5c40c6f39a5af != 0)
					{
						goto IL_0037;
					}
					break;
				case 4:
					continue;
				}
				break;
			}
		}

		// Token: 0x06001077 RID: 4215 RVA: 0x000824BC File Offset: 0x000806BC
		[NullableContext(1)]
		public JValue(JValue other)
			: this(other.Value, other.Type)
		{
			int num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3baf10aa2a73406aa2bb349717d797c7 == 0)
			{
				switch (num)
				{
				}
			}
		}

		// Token: 0x06001078 RID: 4216 RVA: 0x000824FC File Offset: 0x000806FC
		public JValue(long value)
			: this(BoxedPrimitives.Get(value), JTokenType.Integer)
		{
			int num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_079bd9b874b24353bef46f6c3f5d741d == 0)
			{
				switch (num)
				{
				}
			}
		}

		// Token: 0x06001079 RID: 4217 RVA: 0x00082538 File Offset: 0x00080738
		public JValue(decimal value)
			: this(BoxedPrimitives.Get(value), JTokenType.Float)
		{
			int num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e764f065c2fa404a85129e2e957d4f18 != 0)
			{
				switch (num)
				{
				}
			}
		}

		// Token: 0x0600107A RID: 4218 RVA: 0x00082574 File Offset: 0x00080774
		public JValue(char value)
			: this(value, JTokenType.String)
		{
			int num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9f5329f120e842948536b8235793166c == 0)
			{
				switch (num)
				{
				}
			}
		}

		// Token: 0x0600107B RID: 4219 RVA: 0x000825B0 File Offset: 0x000807B0
		[CLSCompliant(false)]
		public JValue(ulong value)
			: this(value, JTokenType.Integer)
		{
			int num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a321d34f24314561b0d80437d5d859e8 == 0)
			{
				switch (num)
				{
				}
			}
		}

		// Token: 0x0600107C RID: 4220 RVA: 0x000825EC File Offset: 0x000807EC
		public JValue(double value)
			: this(BoxedPrimitives.Get(value), JTokenType.Float)
		{
			int num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_186d640068094cc595a341ef95c9a29a == 0)
			{
				switch (num)
				{
				}
			}
		}

		// Token: 0x0600107D RID: 4221 RVA: 0x00082628 File Offset: 0x00080828
		public JValue(float value)
			: this(value, JTokenType.Float)
		{
			int num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_186d640068094cc595a341ef95c9a29a != 0)
			{
				switch (num)
				{
				}
			}
		}

		// Token: 0x0600107E RID: 4222 RVA: 0x00082664 File Offset: 0x00080864
		public JValue(DateTime value)
			: this(value, JTokenType.Date)
		{
			int num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_676b866782704933888a7440512fd4ff == 0)
			{
				switch (num)
				{
				}
			}
		}

		// Token: 0x0600107F RID: 4223 RVA: 0x000826A0 File Offset: 0x000808A0
		public JValue(DateTimeOffset value)
			: this(value, JTokenType.Date)
		{
			int num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b17e63564ae246399767b60cf4b1528a != 0)
			{
				switch (num)
				{
				}
			}
		}

		// Token: 0x06001080 RID: 4224 RVA: 0x000826DC File Offset: 0x000808DC
		public JValue(bool value)
			: this(BoxedPrimitives.Get(value), JTokenType.Boolean)
		{
			int num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_eaded84ad5b14e1ea8d4d97bfed1bb48 != 0)
			{
				switch (num)
				{
				}
			}
		}

		// Token: 0x06001081 RID: 4225 RVA: 0x00082718 File Offset: 0x00080918
		public JValue(string value)
			: this(value, JTokenType.String)
		{
			int num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bd75de9a0b64d6da3a43e57303102f1 != 0)
			{
				switch (num)
				{
				}
			}
		}

		// Token: 0x06001082 RID: 4226 RVA: 0x0008274C File Offset: 0x0008094C
		public JValue(Guid value)
			: this(value, JTokenType.Guid)
		{
			int num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93c7140125045538ae5c40c6f39a5af == 0)
			{
				switch (num)
				{
				}
			}
		}

		// Token: 0x06001083 RID: 4227 RVA: 0x00082788 File Offset: 0x00080988
		public JValue(Uri value)
			: this(value, (!(value != null)) ? JTokenType.Null : JTokenType.Uri)
		{
			int num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa29cbda752f45acbe81e7d5285df2ba != 0)
			{
				switch (num)
				{
				}
			}
		}

		// Token: 0x06001084 RID: 4228 RVA: 0x000827CC File Offset: 0x000809CC
		public JValue(TimeSpan value)
			: this(value, JTokenType.TimeSpan)
		{
			int num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d6c400f349964629bcd869033695bff0 == 0)
			{
				switch (num)
				{
				}
			}
		}

		// Token: 0x06001085 RID: 4229 RVA: 0x00082808 File Offset: 0x00080A08
		public JValue(object value)
			: this(value, JValue.smethod_8(null, value))
		{
			int num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39d5fbfa4fe34ed9908db538e5340a6c != 0)
			{
				switch (num)
				{
				}
			}
		}

		// Token: 0x06001086 RID: 4230 RVA: 0x0008284C File Offset: 0x00080A4C
		[NullableContext(1)]
		internal override bool DeepEquals(JToken node)
		{
			JValue jvalue;
			for (;;)
			{
				jvalue = node as JValue;
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9bd9937edf9d4ad8bd673dfcb5a5e3cb == 0)
				{
					goto IL_002F;
				}
				IL_001A:
				while (jvalue != null)
				{
					if (jvalue != this)
					{
						goto IL_0066;
					}
					num = 2;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_193800745ad94a529d9e5edc977c4f02 == 0)
					{
						goto IL_002F;
					}
				}
				num = 3;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7dfc957a76cb4c58b17dc74a084c4e4a == 0)
				{
					break;
				}
				IL_002F:
				switch (num)
				{
				case 0:
					goto IL_001A;
				case 1:
					break;
				case 2:
					return true;
				case 3:
					return false;
				default:
					goto IL_001A;
				}
			}
			return true;
			IL_0066:
			return JValue.smethod_10(this, jvalue);
		}

		// Token: 0x17000261 RID: 609
		// (get) Token: 0x06001087 RID: 4231 RVA: 0x00003453 File Offset: 0x00001653
		public override bool HasValues
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06001088 RID: 4232 RVA: 0x000828CC File Offset: 0x00080ACC
		[NullableContext(1)]
		private static int smethod_5(BigInteger bigInteger_0, object object_1)
		{
			int num;
			double num3;
			double num4;
			for (;;)
			{
				IL_00D6:
				num = bigInteger_0.CompareTo(ConvertUtils.ToBigInteger(object_1));
				int num2 = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93ade03426d44b1841bfa7c633f49f3 == 0)
				{
					goto IL_008D;
				}
				for (;;)
				{
					IL_009A:
					switch (num2)
					{
					case 1:
						goto IL_008D;
					case 2:
						goto IL_00D6;
					case 3:
						goto IL_0011;
					case 4:
						goto IL_002B;
					case 5:
						goto IL_0108;
					case 6:
						num3 = 0.0;
						num2 = 12;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ca6ac77a767741aa91cb31f8080f093b != 0)
						{
							goto Block_5;
						}
						continue;
					case 7:
						goto IL_004A;
					case 8:
						goto IL_0006;
					case 9:
						goto IL_010F;
					case 10:
						return num;
					case 11:
						return num;
					case 12:
						goto IL_0130;
					}
					goto Block_7;
				}
				IL_0011:
				if (object_1 is double)
				{
					goto IL_004A;
				}
				num2 = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_afb77be96d644a2297c7f9466cb06ede == 0)
				{
					goto IL_002B;
				}
				goto IL_009A;
				IL_0006:
				if (!(object_1 is decimal))
				{
					goto IL_0011;
				}
				goto IL_0100;
				IL_008D:
				if (num == 0)
				{
					goto IL_0006;
				}
				return num;
				IL_002B:
				if (!(object_1 is float))
				{
					num2 = 3;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8432da17e8384a688cea4636964d3693 == 0)
					{
						break;
					}
					goto IL_009A;
				}
				IL_004A:
				num4 = Convert.ToDouble(object_1, CultureInfo.InvariantCulture);
				num2 = 6;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_832998aae3714af0a1270bf2bb566909 == 0)
				{
					goto Block_4;
				}
				goto IL_009A;
			}
			return num;
			Block_4:
			goto IL_0100;
			Block_5:
			return num;
			Block_7:
			IL_0100:
			decimal num5 = (decimal)object_1;
			IL_0108:
			decimal num6 = 0m;
			IL_010F:
			return num6.CompareTo(Math.Abs(num5 - Math.Truncate(num5)));
			IL_0130:
			return num3.CompareTo(Math.Abs(num4 - Math.Truncate(num4)));
		}

		// Token: 0x06001089 RID: 4233 RVA: 0x00082A20 File Offset: 0x00080C20
		internal static int Compare(JTokenType valueType, Uri objA, object objB)
		{
			IL_0451:
			while (objA != objB)
			{
				int num;
				if (objB == null)
				{
					num = 6;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ae8c3d3c66a64b57beca0f5360302062 == 0)
					{
						return 1;
					}
				}
				else
				{
					if (objA == null)
					{
						return -1;
					}
					num = 7;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8432da17e8384a688cea4636964d3693 == 0)
					{
						goto IL_0236;
					}
				}
				long num2;
				for (;;)
				{
					IL_033D:
					switch (num)
					{
					case 1:
						goto IL_0112;
					case 2:
						goto IL_063B;
					case 3:
						goto IL_04DC;
					case 4:
						return 0;
					case 5:
						goto IL_0451;
					case 6:
						goto IL_06BB;
					case 7:
						goto IL_0659;
					case 8:
					case 32:
						goto IL_06B0;
					case 9:
					case 19:
						goto IL_05C2;
					case 10:
						goto IL_06A7;
					case 11:
						goto IL_0195;
					case 12:
						goto IL_0059;
					case 13:
						goto IL_0487;
					case 14:
						if (objA is decimal)
						{
							goto Block_30;
						}
						goto IL_01BA;
					case 15:
						goto IL_0460;
					case 16:
						goto IL_0509;
					case 17:
						goto IL_0280;
					case 18:
						return 1;
					case 20:
					case 49:
						goto IL_0577;
					case 21:
						goto IL_0236;
					case 22:
						goto IL_00F2;
					case 23:
						goto IL_0633;
					case 24:
						goto IL_04F7;
					case 25:
						goto IL_004E;
					case 26:
						if (!(objA is ulong))
						{
							goto IL_0175;
						}
						goto IL_0577;
					case 27:
						goto IL_0501;
					case 28:
						goto IL_0511;
					case 29:
						goto IL_069F;
					case 30:
						goto IL_01DF;
					case 31:
						goto IL_01BA;
					case 33:
						goto IL_0175;
					case 34:
						goto IL_053A;
					case 35:
						goto IL_0555;
					case 36:
						goto IL_05D0;
					case 37:
					case 59:
					case 64:
						goto IL_06CE;
					case 38:
						goto IL_0620;
					case 39:
						goto IL_006F;
					case 40:
						goto IL_0609;
					case 41:
						goto IL_00A1;
					case 42:
						goto IL_0142;
					case 43:
						goto IL_0597;
					case 44:
						goto IL_0567;
					case 45:
						goto IL_05B0;
					case 46:
						return -1;
					case 47:
					case 48:
						goto IL_0613;
					case 50:
						goto IL_0584;
					case 51:
						goto IL_0064;
					case 52:
						goto IL_0164;
					case 53:
						goto IL_05A4;
					case 54:
						goto IL_0137;
					case 55:
						goto IL_05CC;
					case 56:
						goto IL_05F9;
					case 57:
						goto IL_0601;
					case 58:
						goto IL_00E7;
					case 60:
						goto IL_00C8;
					case 61:
						goto IL_0645;
					case 62:
						goto IL_064E;
					case 63:
						goto IL_0096;
					case 65:
						goto IL_0043;
					}
					goto Block_31;
					IL_006F:
					num2 = Convert.ToInt64(objA, CultureInfo.InvariantCulture);
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_948fa5c193d44e279b41c3a0fab7b5c9 == 0)
					{
						break;
					}
					continue;
					IL_0064:
					if (!(objB is double))
					{
						goto IL_006F;
					}
					goto IL_06CE;
					IL_0059:
					if (!(objA is double))
					{
						goto IL_0064;
					}
					goto IL_06CE;
					IL_004E:
					if (!(objB is float))
					{
						goto IL_0059;
					}
					goto IL_06CE;
					IL_0043:
					if (!(objA is float))
					{
						goto IL_004E;
					}
					goto IL_06CE;
					IL_0175:
					if (objB is ulong)
					{
						goto IL_0577;
					}
					num = 5;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_550a8fe2e5fe4cc19bdfe1a82a7f12b8 == 0)
					{
						goto IL_0195;
					}
					continue;
					IL_01BA:
					if (objB is decimal)
					{
						goto IL_0613;
					}
					num = 13;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cf58136e49114a5691c4a9d0e9788de1 == 0)
					{
						goto IL_0043;
					}
				}
				goto IL_06BB;
				Block_30:
				goto IL_0613;
				Block_31:
				goto IL_051C;
				IL_0460:
				Uri uri;
				Uri uri2;
				return Comparer<string>.Default.Compare(uri.ToString(), uri2.ToString());
				IL_05CC:
				byte[] array;
				if (array != null)
				{
					return MiscellaneousUtils.ByteArrayCompare(objA as byte[], array);
				}
				IL_05D0:
				throw new ArgumentException(Class15.smethod_17(1985323732 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f19acd91a8c44846a95d09d7dc3da2ba));
				IL_06CE:
				return JValue.smethod_6(objA, objB);
				IL_0112:
				if (objB is ulong)
				{
					goto IL_0613;
				}
				num = 14;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2a74c5ebb7d84adcad853e2eda393dc4 != 0)
				{
					continue;
				}
				goto IL_033D;
				IL_00F2:
				if (objA is ulong)
				{
					goto IL_0613;
				}
				num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_eaded84ad5b14e1ea8d4d97bfed1bb48 == 0)
				{
					goto IL_0112;
				}
				goto IL_033D;
				IL_00E7:
				if (!(objB is BigInteger))
				{
					goto IL_00F2;
				}
				goto IL_0633;
				IL_0164:
				if (!(objA is BigInteger))
				{
					goto IL_00E7;
				}
				goto IL_0597;
				IL_0236:
				bool flag;
				DateTimeOffset dateTimeOffset;
				switch (valueType)
				{
				case JTokenType.Comment:
				case JTokenType.String:
				case JTokenType.Raw:
				{
					string text = Convert.ToString(objA, CultureInfo.InvariantCulture);
					string text2 = Convert.ToString(objB, CultureInfo.InvariantCulture);
					return string.CompareOrdinal(text, text2);
				}
				case JTokenType.Integer:
					goto IL_0164;
				case JTokenType.Float:
					if (objA is BigInteger)
					{
						goto IL_0280;
					}
					if (objB is BigInteger)
					{
						goto IL_0487;
					}
					num = 26;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_1d8dbb531d7349c0bc15bad339f7815c == 0)
					{
						goto IL_06BB;
					}
					goto IL_033D;
				case JTokenType.Boolean:
					flag = Convert.ToBoolean(objA, CultureInfo.InvariantCulture);
					goto IL_0555;
				case JTokenType.Null:
				case JTokenType.Undefined:
					goto IL_0659;
				case JTokenType.Date:
					if (objA is DateTime)
					{
						goto IL_00C8;
					}
					dateTimeOffset = (DateTimeOffset)objA;
					num = 53;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_01137da6c88c4265bdc0297aacf3340f != 0)
					{
						goto IL_0137;
					}
					goto IL_033D;
				case JTokenType.Bytes:
					array = objB as byte[];
					num = 55;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d97e64d0f425406b9649f2b4562a5f0e == 0)
					{
						goto IL_0501;
					}
					goto IL_033D;
				case JTokenType.Guid:
					if (objB is Guid)
					{
						goto IL_0501;
					}
					goto IL_053A;
				case JTokenType.Uri:
					uri2 = objB as Uri;
					num = 5;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e6fac70dd3e841b6925374855ecd7fb1 == 0)
					{
						goto IL_01DF;
					}
					goto IL_033D;
				case JTokenType.TimeSpan:
					if (!(objB is TimeSpan))
					{
						goto IL_04DC;
					}
					goto IL_05F9;
				default:
					goto IL_0659;
				}
				IL_00A1:
				DateTime dateTime = Convert.ToDateTime(objB, CultureInfo.InvariantCulture);
				num = 8;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_57ce3fecb9e64a8f924ea7658e146719 == 0)
				{
					goto IL_0659;
				}
				goto IL_033D;
				IL_0096:
				if (!(objB is DateTimeOffset))
				{
					goto IL_00A1;
				}
				goto IL_069F;
				IL_00C8:
				DateTime dateTime2 = (DateTime)objA;
				num = 39;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_1db17fe7bd2442b599c52df89f39e610 != 0)
				{
					goto IL_0096;
				}
				goto IL_033D;
				IL_0142:
				DateTimeOffset dateTimeOffset2 = (DateTimeOffset)objB;
				num = 7;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f19acd91a8c44846a95d09d7dc3da2ba != 0)
				{
					goto IL_05C2;
				}
				goto IL_033D;
				IL_0137:
				if (objB is DateTimeOffset)
				{
					goto IL_0142;
				}
				goto IL_05B0;
				IL_0195:
				if (!(objA is decimal))
				{
					goto IL_0567;
				}
				num = 5;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d6c400f349964629bcd869033695bff0 == 0)
				{
					goto IL_0577;
				}
				goto IL_033D;
				IL_01DF:
				if (uri2 == null)
				{
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cb7e1ff8cc1348bebf46c510e64a0134 != 0)
					{
						goto IL_051C;
					}
					goto IL_033D;
				}
				else
				{
					uri = (Uri)objA;
					num = 15;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_676b866782704933888a7440512fd4ff != 0)
					{
						goto IL_0195;
					}
					goto IL_033D;
				}
				IL_0280:
				BigInteger bigInteger = (BigInteger)objA;
				num = 41;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2e3be65f7cb2480482903dc73ec42f7c == 0)
				{
					goto IL_05A4;
				}
				goto IL_033D;
				IL_0487:
				BigInteger bigInteger2 = (BigInteger)objB;
				goto IL_04F7;
				IL_04DC:
				throw new ArgumentException(Class15.smethod_17(2021159918 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4ac69ea2381b403582a2723337f67fa8));
				IL_04F7:
				return -JValue.smethod_5(bigInteger2, objA);
				IL_0501:
				Guid guid = (Guid)objA;
				IL_0509:
				Guid guid2 = (Guid)objB;
				IL_0511:
				return guid.CompareTo(guid2);
				IL_051C:
				throw new ArgumentException(Class15.smethod_17(89018112 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_db7740c6ca7a4f3c8e1aa526bdb0a454));
				IL_053A:
				throw new ArgumentException(Class15.smethod_17(1396513868 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4152404f503b492c83d9bc2e44bdd0a7));
				IL_0555:
				bool flag2 = Convert.ToBoolean(objB, CultureInfo.InvariantCulture);
				goto IL_064E;
				IL_0567:
				if (!(objB is decimal))
				{
					return JValue.smethod_6(objA, objB);
				}
				IL_0577:
				decimal num3 = Convert.ToDecimal(objA, CultureInfo.InvariantCulture);
				IL_0584:
				return num3.CompareTo(Convert.ToDecimal(objB, CultureInfo.InvariantCulture));
				IL_0597:
				BigInteger bigInteger3 = (BigInteger)objA;
				goto IL_0645;
				IL_05A4:
				return JValue.smethod_5(bigInteger, objB);
				IL_05B0:
				dateTimeOffset2 = new DateTimeOffset(Convert.ToDateTime(objB, CultureInfo.InvariantCulture));
				IL_05C2:
				return dateTimeOffset.CompareTo(dateTimeOffset2);
				IL_05F9:
				TimeSpan timeSpan = (TimeSpan)objA;
				IL_0601:
				TimeSpan timeSpan2 = (TimeSpan)objB;
				IL_0609:
				return timeSpan.CompareTo(timeSpan2);
				IL_0613:
				num3 = Convert.ToDecimal(objA, CultureInfo.InvariantCulture);
				IL_0620:
				return num3.CompareTo(Convert.ToDecimal(objB, CultureInfo.InvariantCulture));
				IL_0633:
				BigInteger bigInteger4 = (BigInteger)objB;
				IL_063B:
				return -JValue.smethod_5(bigInteger4, objA);
				IL_0645:
				return JValue.smethod_5(bigInteger3, objB);
				IL_064E:
				return flag.CompareTo(flag2);
				IL_0659:
				throw MiscellaneousUtils.CreateArgumentOutOfRangeException(Class15.smethod_17(197534499 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c27e9fccdfcc44999155a4980faa4e81), valueType, Class15.smethod_17(635791303 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a41eabd4b99f489fb7d86310d3f95ba2).FormatWith(CultureInfo.InvariantCulture, valueType));
				IL_069F:
				DateTimeOffset dateTimeOffset3 = (DateTimeOffset)objB;
				IL_06A7:
				dateTime = dateTimeOffset3.DateTime;
				IL_06B0:
				return dateTime2.CompareTo(dateTime);
				IL_06BB:
				return num2.CompareTo(Convert.ToInt64(objB, CultureInfo.InvariantCulture));
			}
			return 0;
		}

		// Token: 0x0600108A RID: 4234 RVA: 0x00083104 File Offset: 0x00081304
		[NullableContext(1)]
		private static int smethod_6(object object_1, object object_2)
		{
			double num;
			double num3;
			for (;;)
			{
				num = Convert.ToDouble(object_1, CultureInfo.InvariantCulture);
				int num2 = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa29cbda752f45acbe81e7d5285df2ba == 0)
				{
					goto IL_0020;
				}
				IL_002F:
				switch (num2)
				{
				case 0:
					goto IL_0020;
				case 1:
					continue;
				case 2:
					goto IL_006C;
				case 3:
					return 0;
				case 4:
					break;
				default:
					goto IL_0020;
				}
				IL_0003:
				if (MathUtils.ApproxEquals(num, num3))
				{
					return 0;
				}
				num2 = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0b405dced5e94c80928a74c5773182d9 == 0)
				{
					goto IL_002F;
				}
				IL_0020:
				num3 = Convert.ToDouble(object_2, CultureInfo.InvariantCulture);
				goto IL_0003;
			}
			IL_006C:
			return num.CompareTo(num3);
		}

		// Token: 0x0600108B RID: 4235 RVA: 0x00083188 File Offset: 0x00081388
		private static bool smethod_7(ExpressionType expressionType_0, object object_1, object object_2, out object object_3)
		{
			long num2;
			long num3;
			decimal num4;
			decimal num5;
			BigInteger bigInteger;
			BigInteger bigInteger2;
			double num6;
			double num7;
			for (;;)
			{
				IL_08EF:
				if (object_1 is string)
				{
					goto IL_08DB;
				}
				goto IL_08E1;
				int num;
				for (;;)
				{
					IL_0025:
					switch (num)
					{
					case 1:
					case 11:
					case 12:
					case 18:
					case 27:
					case 51:
					case 54:
					case 61:
					case 66:
					case 80:
					case 83:
					case 104:
					case 115:
					case 118:
					case 123:
					case 130:
					case 140:
						goto IL_0A8D;
					case 2:
						goto IL_05E1;
					case 3:
						return true;
					case 4:
						return true;
					case 5:
						IL_0356:
						if (object_2 is BigInteger)
						{
							goto IL_0502;
						}
						if (!(object_1 is ulong))
						{
							goto IL_0369;
						}
						goto IL_03DB;
					case 6:
						goto IL_02BA;
					case 7:
						return true;
					case 8:
						goto IL_05C4;
					case 9:
					case 68:
						goto IL_08DB;
					case 10:
						goto IL_0A68;
					case 13:
						goto IL_07EC;
					case 14:
						return true;
					case 15:
					case 58:
					case 142:
						goto IL_0616;
					case 16:
						return true;
					case 17:
					case 90:
						goto IL_06A9;
					case 19:
					case 29:
					case 45:
					case 75:
					case 129:
					case 146:
					case 148:
						goto IL_0284;
					case 20:
						goto IL_042B;
					case 21:
					case 59:
						goto IL_091C;
					case 22:
						goto IL_0783;
					case 23:
						goto IL_05A9;
					case 24:
						goto IL_0475;
					case 25:
						return true;
					case 26:
						goto IL_09A3;
					case 28:
						goto IL_088D;
					case 30:
						goto IL_0766;
					case 31:
						num2 = Convert.ToInt64(object_1, CultureInfo.InvariantCulture);
						goto IL_074C;
					case 32:
						goto IL_06FD;
					case 33:
						goto IL_0390;
					case 34:
						goto IL_075E;
					case 35:
						return true;
					case 36:
						goto IL_028A;
					case 37:
					case 65:
						goto IL_0A82;
					case 38:
						goto IL_07A5;
					case 39:
						return true;
					case 40:
						goto IL_04C3;
					case 41:
					case 50:
						goto IL_094F;
					case 42:
						goto IL_08FC;
					case 43:
					case 98:
						goto IL_04E5;
					case 44:
						goto IL_09F4;
					case 46:
						return false;
					case 47:
						goto IL_02F4;
					case 48:
						goto IL_0622;
					case 49:
						goto IL_07AA;
					case 52:
					case 101:
						goto IL_0A4E;
					case 53:
						goto IL_05B1;
					case 55:
						goto IL_0499;
					case 56:
						goto IL_0502;
					case 57:
						goto IL_0533;
					case 60:
						goto IL_0369;
					case 62:
						goto IL_0430;
					case 63:
						return true;
					case 64:
						return true;
					case 67:
						return true;
					case 69:
						goto IL_08EF;
					case 70:
						goto IL_050E;
					case 71:
						goto IL_06E0;
					case 72:
						goto IL_02EC;
					case 73:
						goto IL_064C;
					case 74:
						goto IL_03AE;
					case 76:
						return true;
					case 77:
						if (!(object_1 is int))
						{
							goto IL_088D;
						}
						goto IL_0284;
					case 78:
						return true;
					case 79:
						goto IL_0627;
					case 81:
						goto IL_0388;
					case 82:
						goto IL_09E3;
					case 84:
						goto IL_090B;
					case 85:
						goto IL_056D;
					case 86:
						goto IL_047A;
					case 87:
						return true;
					case 88:
						return true;
					case 89:
						return true;
					case 91:
						goto IL_0582;
					case 92:
						goto IL_03B9;
					case 93:
						goto IL_0944;
					case 94:
						goto IL_0759;
					case 95:
						goto IL_0409;
					case 96:
						goto IL_0647;
					case 97:
						goto IL_0508;
					case 99:
						goto IL_0453;
					case 100:
						goto IL_03FC;
					case 102:
						goto IL_0819;
					case 103:
						goto IL_080E;
					case 105:
						return true;
					case 106:
						goto IL_0860;
					case 107:
						goto IL_03E1;
					case 108:
						goto IL_09DE;
					case 109:
						return true;
					case 110:
						goto IL_083B;
					case 111:
					case 147:
						goto IL_0A59;
					case 112:
						goto IL_07CC;
					case 113:
						goto IL_074C;
					case 114:
						goto IL_052B;
					case 116:
						goto IL_0741;
					case 117:
						goto IL_044A;
					case 119:
					case 139:
						goto IL_03DB;
					case 120:
						goto IL_05BC;
					case 121:
						return true;
					case 122:
						goto IL_095D;
					case 124:
						goto IL_071F;
					case 125:
						goto IL_02B2;
					case 126:
						goto IL_055A;
					case 127:
						goto IL_08E1;
					case 128:
						goto IL_097C;
					case 131:
						goto IL_02DC;
					case 132:
						return true;
					case 133:
						goto IL_02E4;
					case 134:
						goto IL_03A3;
					case 135:
						goto IL_057A;
					case 136:
						goto IL_098A;
					case 137:
						goto IL_058A;
					case 138:
						return true;
					case 141:
						goto IL_053B;
					case 143:
						goto IL_0A3C;
					case 144:
						goto IL_0316;
					case 145:
						goto IL_02AA;
					}
					goto Block_2;
					IL_028A:
					if (object_2 == null)
					{
						goto IL_0A82;
					}
					num = 31;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_548c52e5632b45898e377ad9c9a06469 != 0)
					{
						goto Block_4;
					}
					continue;
					IL_02BA:
					if (!(object_2 is long))
					{
						goto IL_02DC;
					}
					num = 129;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bca7529ca324c188cfc0e64eb7d1cdf == 0)
					{
						goto Block_6;
					}
					continue;
					IL_02B2:
					if (!(object_2 is uint))
					{
						goto IL_02BA;
					}
					goto IL_0284;
					IL_02AA:
					if (!(object_2 is int))
					{
						goto IL_02B2;
					}
					goto IL_0284;
					IL_083B:
					if (!(object_1 is byte))
					{
						goto IL_02AA;
					}
					num = 15;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39f35935adc2477fa894750fee078177 != 0)
					{
						goto IL_0284;
					}
					continue;
					IL_0819:
					if (!(object_1 is sbyte))
					{
						goto IL_083B;
					}
					num = 148;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_832998aae3714af0a1270bf2bb566909 == 0)
					{
						goto IL_0284;
					}
					continue;
					IL_080E:
					if (!(object_1 is ushort))
					{
						goto IL_0819;
					}
					goto IL_0284;
					IL_07EC:
					if (!(object_1 is short))
					{
						goto IL_080E;
					}
					num = 45;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_676b866782704933888a7440512fd4ff != 0)
					{
						goto Block_59;
					}
					continue;
					IL_02F4:
					if (object_2 is byte)
					{
						goto IL_0284;
					}
					num = 22;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7af5c533f30e4bd1bda86ce6098441d2 != 0)
					{
						goto Block_8;
					}
					continue;
					IL_02EC:
					if (!(object_2 is sbyte))
					{
						goto IL_02F4;
					}
					goto IL_0284;
					IL_02E4:
					if (!(object_2 is ushort))
					{
						goto IL_02EC;
					}
					goto IL_0284;
					IL_02DC:
					if (!(object_2 is short))
					{
						goto IL_02E4;
					}
					goto IL_0284;
					IL_0316:
					if (expressionType_0 == ExpressionType.Multiply)
					{
						goto IL_0335;
					}
					num = 136;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_92ac2a37edba4e2587eb1b9e8af3f63f == 0)
					{
						goto Block_10;
					}
					continue;
					IL_075E:
					if (expressionType_0 <= ExpressionType.Divide)
					{
						goto IL_0766;
					}
					goto IL_0316;
					IL_0759:
					if (expressionType_0 <= ExpressionType.Subtract)
					{
						goto IL_075E;
					}
					goto IL_07A5;
					IL_074C:
					num3 = Convert.ToInt64(object_2, CultureInfo.InvariantCulture);
					goto IL_0759;
					IL_0335:
					object_3 = num2 * num3;
					num = 7;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ee35a23edd8f4998990ec1a2b40fc61a == 0)
					{
						goto IL_0356;
					}
					continue;
					IL_07AA:
					if (expressionType_0 == ExpressionType.MultiplyAssign)
					{
						goto IL_0335;
					}
					num = 62;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f77f8ab5a3534e2e914063d52217b4e1 == 0)
					{
						goto Block_56;
					}
					continue;
					IL_07A5:
					if (expressionType_0 > ExpressionType.DivideAssign)
					{
						goto IL_07AA;
					}
					goto IL_0741;
					IL_0369:
					if (!(object_2 is ulong))
					{
						goto IL_0388;
					}
					num = 80;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_43b8cdd768c545d884bf7ff1c8fefe89 != 0)
					{
						goto IL_03DB;
					}
					continue;
					IL_03B9:
					if (object_2 is double)
					{
						break;
					}
					num = 77;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ca6ac77a767741aa91cb31f8080f093b != 0)
					{
						goto IL_0430;
					}
					continue;
					IL_03AE:
					if (!(object_1 is double))
					{
						goto IL_03B9;
					}
					break;
					IL_03A3:
					if (!(object_2 is float))
					{
						goto IL_03AE;
					}
					break;
					IL_0390:
					if (object_2 is decimal)
					{
						goto IL_03DB;
					}
					if (!(object_1 is float))
					{
						goto IL_03A3;
					}
					break;
					IL_0388:
					if (!(object_1 is decimal))
					{
						goto IL_0390;
					}
					goto IL_03DB;
					IL_03E1:
					if (object_2 == null)
					{
						goto IL_04E5;
					}
					num = 11;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_48fe014748e848c88d3254f339047927 != 0)
					{
						goto IL_03FC;
					}
					continue;
					IL_03DB:
					if (object_1 != null)
					{
						goto IL_03E1;
					}
					goto IL_04E5;
					IL_0409:
					num4 = Convert.ToDecimal(object_2, CultureInfo.InvariantCulture);
					num = 4;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ee35a23edd8f4998990ec1a2b40fc61a != 0)
					{
						goto IL_042B;
					}
					continue;
					IL_03FC:
					num5 = Convert.ToDecimal(object_1, CultureInfo.InvariantCulture);
					goto IL_0409;
					IL_0430:
					if (expressionType_0 > ExpressionType.Divide)
					{
						goto IL_0453;
					}
					num = 79;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9f5329f120e842948536b8235793166c == 0)
					{
						goto IL_044A;
					}
					continue;
					IL_042B:
					if (expressionType_0 <= ExpressionType.Subtract)
					{
						goto IL_0430;
					}
					goto IL_0475;
					IL_0453:
					if (expressionType_0 == ExpressionType.Multiply)
					{
						goto IL_09C9;
					}
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0361b8eb39074ea88f5257b13904930a == 0)
					{
						goto Block_21;
					}
					continue;
					IL_047A:
					if (expressionType_0 == ExpressionType.AddAssign)
					{
						goto IL_0499;
					}
					num = 122;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8f48544341da433d9f954b548c7e9212 != 0)
					{
						goto IL_0284;
					}
					continue;
					IL_0475:
					if (expressionType_0 <= ExpressionType.DivideAssign)
					{
						goto IL_047A;
					}
					goto IL_04C3;
					IL_0499:
					object_3 = num5 + num4;
					num = 105;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_52d717cd31b74287b67c03ee736a6211 == 0)
					{
						goto Block_24;
					}
					continue;
					IL_044A:
					if (expressionType_0 != ExpressionType.Add)
					{
						goto Block_19;
					}
					goto IL_0499;
					IL_04C3:
					if (expressionType_0 == ExpressionType.MultiplyAssign)
					{
						goto IL_09C9;
					}
					num = 84;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b17e63564ae246399767b60cf4b1528a != 0)
					{
						break;
					}
					continue;
					IL_04E5:
					object_3 = null;
					num = 37;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cbfb1e54efd84756a9b6d7b21adc0d65 == 0)
					{
						goto Block_27;
					}
					continue;
					IL_071F:
					if (expressionType_0 == ExpressionType.DivideAssign)
					{
						goto IL_096E;
					}
					num = 11;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_48fe014748e848c88d3254f339047927 == 0)
					{
						goto Block_49;
					}
					continue;
					IL_0741:
					if (expressionType_0 != ExpressionType.AddAssign)
					{
						goto IL_071F;
					}
					goto IL_094F;
					IL_0766:
					if (expressionType_0 == ExpressionType.Add)
					{
						num = 50;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3bf07bb1c323490cb457eef2b2e78695 != 0)
						{
							goto Block_52;
						}
						continue;
					}
					IL_0783:
					if (expressionType_0 == ExpressionType.Divide)
					{
						goto IL_096E;
					}
					num = 54;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3a299c01dd4f4a209bdbd1b98e3f1406 == 0)
					{
						goto Block_54;
					}
					continue;
					IL_07CC:
					if (object_1 is long)
					{
						goto IL_0284;
					}
					num = 5;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5f127c3ec2e04c11ab1bd26a8d965f2b != 0)
					{
						goto IL_07EC;
					}
					continue;
					IL_088D:
					if (!(object_1 is uint))
					{
						num = 86;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a5994720d09542abb897ebf6ad9b5a19 == 0)
						{
							goto IL_07CC;
						}
						continue;
					}
					IL_0284:
					if (object_1 != null)
					{
						goto IL_028A;
					}
					goto IL_0A82;
				}
				goto IL_0616;
				Block_10:
				goto IL_0582;
				Block_54:
				goto IL_05C4;
				Block_59:
				goto IL_06A9;
				IL_0006:
				if (object_1 is BigInteger)
				{
					goto IL_0502;
				}
				num = 5;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_548c52e5632b45898e377ad9c9a06469 == 0)
				{
					goto IL_0025;
				}
				break;
				IL_0860:
				if (expressionType_0 != ExpressionType.AddAssign)
				{
					goto IL_0006;
				}
				num = 17;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_52d717cd31b74287b67c03ee736a6211 == 0)
				{
					goto Block_65;
				}
				goto IL_0025;
				IL_050E:
				bigInteger = ConvertUtils.ToBigInteger(object_1);
				num = 15;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2a74c5ebb7d84adcad853e2eda393dc4 == 0)
				{
					goto IL_052B;
				}
				goto IL_0025;
				IL_0508:
				if (object_2 != null)
				{
					goto IL_050E;
				}
				goto IL_0A4E;
				IL_0502:
				if (object_1 != null)
				{
					goto IL_0508;
				}
				goto IL_0A4E;
				IL_053B:
				if (expressionType_0 > ExpressionType.Divide)
				{
					goto IL_05A9;
				}
				num = 42;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_01137da6c88c4265bdc0297aacf3340f == 0)
				{
					goto IL_0616;
				}
				goto IL_0025;
				IL_0533:
				if (expressionType_0 <= ExpressionType.Subtract)
				{
					goto IL_053B;
				}
				goto IL_05BC;
				IL_052B:
				bigInteger2 = ConvertUtils.ToBigInteger(object_2);
				goto IL_0533;
				IL_058A:
				if (expressionType_0 == ExpressionType.MultiplyAssign)
				{
					goto IL_066E;
				}
				num = 128;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8d68b74cee6442019d959192b2974e3d != 0)
				{
					goto IL_052B;
				}
				goto IL_0025;
				IL_0582:
				if (expressionType_0 > ExpressionType.DivideAssign)
				{
					goto IL_058A;
				}
				goto IL_09DE;
				IL_057A:
				if (expressionType_0 > ExpressionType.Subtract)
				{
					goto IL_0582;
				}
				goto IL_0622;
				IL_056D:
				num6 = Convert.ToDouble(object_2, CultureInfo.InvariantCulture);
				goto IL_057A;
				IL_055A:
				if (object_2 != null)
				{
					num7 = Convert.ToDouble(object_1, CultureInfo.InvariantCulture);
					goto IL_056D;
				}
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2e3be65f7cb2480482903dc73ec42f7c == 0)
				{
					goto IL_06A9;
				}
				goto IL_0025;
				IL_0616:
				if (object_1 == null)
				{
					goto IL_06A9;
				}
				goto IL_055A;
				IL_05C4:
				if (expressionType_0 == ExpressionType.MultiplyAssign)
				{
					goto IL_0A27;
				}
				num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cf58136e49114a5691c4a9d0e9788de1 != 0)
				{
					goto IL_05E1;
				}
				goto IL_0025;
				IL_05BC:
				if (expressionType_0 > ExpressionType.DivideAssign)
				{
					goto IL_05C4;
				}
				goto IL_06E0;
				IL_05E1:
				if (expressionType_0 != ExpressionType.SubtractAssign)
				{
					num = 3;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_1d8dbb531d7349c0bc15bad339f7815c != 0)
					{
						goto Block_44;
					}
					goto IL_0025;
				}
				IL_05EC:
				object_3 = bigInteger - bigInteger2;
				num = 88;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4152404f503b492c83d9bc2e44bdd0a7 == 0)
				{
					goto IL_050E;
				}
				goto IL_0025;
				IL_05B1:
				if (expressionType_0 != ExpressionType.Subtract)
				{
					goto Block_33;
				}
				goto IL_05EC;
				IL_05A9:
				if (expressionType_0 != ExpressionType.Multiply)
				{
					goto IL_05B1;
				}
				goto IL_0A27;
				IL_0627:
				if (expressionType_0 != ExpressionType.Add)
				{
					goto IL_09F4;
				}
				num = 147;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93c7140125045538ae5c40c6f39a5af == 0)
				{
					goto Block_39;
				}
				goto IL_0025;
				IL_0622:
				if (expressionType_0 <= ExpressionType.Divide)
				{
					goto IL_0627;
				}
				goto IL_0647;
				IL_064C:
				if (expressionType_0 == ExpressionType.Subtract)
				{
					goto IL_0A10;
				}
				num = 118;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3baf10aa2a73406aa2bb349717d797c7 == 0)
				{
					goto Block_41;
				}
				goto IL_0025;
				IL_0647:
				if (expressionType_0 != ExpressionType.Multiply)
				{
					goto IL_064C;
				}
				IL_066E:
				object_3 = num7 * num6;
				num = 83;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5e301544981d4903aa4e531970a47849 == 0)
				{
					goto Block_42;
				}
				goto IL_0025;
				IL_06A9:
				object_3 = null;
				num = 37;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3cf8a2073cc248c2915ebb05bcd2a099 == 0)
				{
					goto Block_43;
				}
				goto IL_0025;
				IL_06E0:
				if (expressionType_0 == ExpressionType.AddAssign)
				{
					goto IL_0A3C;
				}
				num = 11;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cbfb1e54efd84756a9b6d7b21adc0d65 != 0)
				{
					goto IL_0025;
				}
				IL_06FD:
				if (expressionType_0 == ExpressionType.DivideAssign)
				{
					goto IL_0A70;
				}
				num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bca7529ca324c188cfc0e64eb7d1cdf == 0)
				{
					break;
				}
				goto IL_0025;
				IL_08E1:
				if (!(object_2 is string))
				{
					goto IL_0006;
				}
				IL_08DB:
				if (expressionType_0 != ExpressionType.Add)
				{
					goto IL_0860;
				}
				num = 52;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3cf8a2073cc248c2915ebb05bcd2a099 == 0)
				{
					goto Block_68;
				}
				goto IL_0025;
			}
			Block_2:
			goto IL_0A88;
			Block_4:
			goto IL_0A68;
			Block_6:
			Block_8:
			goto IL_0A8D;
			Block_19:
			goto IL_09A3;
			Block_21:
			goto IL_0A88;
			Block_24:
			return true;
			Block_27:
			return true;
			Block_33:
			Block_39:
			goto IL_0A8D;
			Block_41:
			return true;
			Block_42:
			return true;
			Block_43:
			return true;
			Block_44:
			goto IL_0A8D;
			goto IL_0A88;
			Block_49:
			goto IL_0A8D;
			Block_52:
			return true;
			Block_56:
			goto IL_0944;
			Block_65:
			Block_68:
			goto IL_091C;
			IL_08FC:
			if (expressionType_0 != ExpressionType.Add)
			{
				goto IL_0A68;
			}
			goto IL_0A3C;
			IL_090B:
			if (expressionType_0 != ExpressionType.SubtractAssign)
			{
				goto IL_0A8D;
			}
			goto IL_0A92;
			IL_091C:
			object_3 = ((object_1 == null) ? null : object_1.ToString()) + ((object_2 != null) ? object_2.ToString() : null);
			return true;
			IL_0944:
			if (expressionType_0 != ExpressionType.SubtractAssign)
			{
				goto IL_0A8D;
			}
			goto IL_0995;
			IL_094F:
			object_3 = num2 + num3;
			return true;
			IL_095D:
			if (expressionType_0 != ExpressionType.DivideAssign)
			{
				goto IL_0A8D;
			}
			goto IL_09AE;
			IL_096E:
			object_3 = num2 / num3;
			return true;
			IL_097C:
			if (expressionType_0 != ExpressionType.SubtractAssign)
			{
				goto IL_0A8D;
			}
			goto IL_0A10;
			IL_098A:
			if (expressionType_0 != ExpressionType.Subtract)
			{
				goto IL_0A8D;
			}
			IL_0995:
			object_3 = num2 - num3;
			return true;
			IL_09A3:
			if (expressionType_0 != ExpressionType.Divide)
			{
				goto IL_0A8D;
			}
			IL_09AE:
			object_3 = num5 / num4;
			return true;
			IL_09C9:
			object_3 = num5 * num4;
			return true;
			IL_09DE:
			if (expressionType_0 == ExpressionType.AddAssign)
			{
				goto IL_0A59;
			}
			IL_09E3:
			if (expressionType_0 != ExpressionType.DivideAssign)
			{
				goto IL_0A8D;
			}
			goto IL_09FF;
			IL_09F4:
			if (expressionType_0 != ExpressionType.Divide)
			{
				goto IL_0A8D;
			}
			IL_09FF:
			object_3 = num7 / num6;
			return true;
			IL_0A10:
			object_3 = num7 - num6;
			return true;
			IL_0A27:
			object_3 = bigInteger * bigInteger2;
			return true;
			IL_0A3C:
			object_3 = bigInteger + bigInteger2;
			return true;
			IL_0A4E:
			object_3 = null;
			return true;
			IL_0A59:
			object_3 = num7 + num6;
			return true;
			IL_0A68:
			if (expressionType_0 != ExpressionType.Divide)
			{
				goto IL_0A8D;
			}
			IL_0A70:
			object_3 = bigInteger / bigInteger2;
			return true;
			IL_0A82:
			object_3 = null;
			return true;
			IL_0A88:
			if (expressionType_0 == ExpressionType.Subtract)
			{
				goto IL_0A92;
			}
			IL_0A8D:
			object_3 = null;
			return false;
			IL_0A92:
			object_3 = num5 - num4;
			return true;
		}

		// Token: 0x0600108C RID: 4236 RVA: 0x00006681 File Offset: 0x00004881
		[NullableContext(1)]
		internal override JToken CloneToken([Nullable(2)] JsonCloneSettings settings)
		{
			return new JValue(this, settings);
		}

		// Token: 0x0600108D RID: 4237 RVA: 0x0000668A File Offset: 0x0000488A
		[NullableContext(1)]
		public static JValue CreateComment([Nullable(2)] string value)
		{
			return new JValue(value, JTokenType.Comment);
		}

		// Token: 0x0600108E RID: 4238 RVA: 0x00006693 File Offset: 0x00004893
		[NullableContext(1)]
		public static JValue CreateString([Nullable(2)] string value)
		{
			return new JValue(value, JTokenType.String);
		}

		// Token: 0x0600108F RID: 4239 RVA: 0x0000669C File Offset: 0x0000489C
		[NullableContext(1)]
		public static JValue CreateNull()
		{
			return new JValue(null, JTokenType.Null);
		}

		// Token: 0x06001090 RID: 4240 RVA: 0x000066A6 File Offset: 0x000048A6
		[NullableContext(1)]
		public static JValue CreateUndefined()
		{
			return new JValue(null, JTokenType.Undefined);
		}

		// Token: 0x06001091 RID: 4241 RVA: 0x00083C38 File Offset: 0x00081E38
		private static JTokenType smethod_8(JTokenType? nullable_0, object object_1)
		{
			if (object_1 == null)
			{
				return JTokenType.Null;
			}
			if (object_1 == DBNull.Value)
			{
				return JTokenType.Null;
			}
			if (object_1 is string)
			{
				return JValue.smethod_9(nullable_0);
			}
			if (object_1 is long || object_1 is int || object_1 is short || object_1 is sbyte || object_1 is ulong || object_1 is uint || object_1 is ushort || object_1 is byte)
			{
				return JTokenType.Integer;
			}
			if (object_1 is Enum)
			{
				return JTokenType.Integer;
			}
			if (object_1 is BigInteger)
			{
				return JTokenType.Integer;
			}
			if (object_1 is double || object_1 is float || object_1 is decimal)
			{
				return JTokenType.Float;
			}
			if (object_1 is DateTime)
			{
				return JTokenType.Date;
			}
			if (object_1 is DateTimeOffset)
			{
				return JTokenType.Date;
			}
			if (object_1 is byte[])
			{
				return JTokenType.Bytes;
			}
			if (object_1 is bool)
			{
				return JTokenType.Boolean;
			}
			if (object_1 is Guid)
			{
				return JTokenType.Guid;
			}
			if (object_1 is Uri)
			{
				return JTokenType.Uri;
			}
			if (!(object_1 is TimeSpan))
			{
				throw new ArgumentException(Class15.smethod_17(299903837 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d97e64d0f425406b9649f2b4562a5f0e).FormatWith(CultureInfo.InvariantCulture, object_1.GetType()));
			}
			return JTokenType.TimeSpan;
		}

		// Token: 0x06001092 RID: 4242 RVA: 0x00083D6C File Offset: 0x00081F6C
		private static JTokenType smethod_9(JTokenType? nullable_0)
		{
			if (nullable_0 == null)
			{
				return JTokenType.String;
			}
			JTokenType valueOrDefault = nullable_0.GetValueOrDefault();
			if (valueOrDefault != JTokenType.Comment && valueOrDefault != JTokenType.String)
			{
				if (valueOrDefault != JTokenType.Raw)
				{
					return JTokenType.String;
				}
			}
			return nullable_0.GetValueOrDefault();
		}

		// Token: 0x17000262 RID: 610
		// (get) Token: 0x06001093 RID: 4243 RVA: 0x000066B0 File Offset: 0x000048B0
		public override JTokenType Type
		{
			get
			{
				return this.khlHotcLxy;
			}
		}

		// Token: 0x17000263 RID: 611
		// (get) Token: 0x06001094 RID: 4244 RVA: 0x000066B8 File Offset: 0x000048B8
		// (set) Token: 0x06001095 RID: 4245 RVA: 0x00083DA8 File Offset: 0x00081FA8
		public new object Value
		{
			get
			{
				return this.uri_0;
			}
			set
			{
				for (;;)
				{
					Uri uri = this.uri_0;
					if (uri == null)
					{
						goto IL_008B;
					}
					Type type = uri.GetType();
					IL_0012:
					Type type2 = ((value == null) ? null : value.GetType());
					if (type != type2)
					{
						goto IL_0072;
					}
					int num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9f9b31fb7a85497499112abf86cccc98 == 0)
					{
						break;
					}
					IL_0037:
					switch (num)
					{
					case 1:
					case 3:
						goto IL_0057;
					case 2:
						IL_0072:
						this.khlHotcLxy = JValue.smethod_8(new JTokenType?(this.khlHotcLxy), value);
						goto IL_0057;
					case 4:
						IL_008B:
						type = null;
						goto IL_0012;
					case 5:
						continue;
					}
					break;
					IL_0057:
					this.uri_0 = value;
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3436841e08c54f56b10b76e1438d4224 != 0)
					{
						break;
					}
					goto IL_0037;
				}
			}
		}

		// Token: 0x06001096 RID: 4246 RVA: 0x00083E50 File Offset: 0x00082050
		[NullableContext(1)]
		public override void WriteTo(JsonWriter writer, params JsonConverter[] converters)
		{
			object obj;
			JsonConverter matchingConverter;
			decimal num2;
			int num5;
			BigInteger bigInteger;
			for (;;)
			{
				IL_04D8:
				if (converters != null)
				{
					goto IL_0239;
				}
				goto IL_04CE;
				int num;
				for (;;)
				{
					IL_034B:
					float num3;
					switch (num)
					{
					case 1:
					case 21:
						goto IL_04CE;
					case 2:
						return;
					case 3:
						return;
					case 4:
						return;
					case 5:
						return;
					case 6:
						goto IL_0533;
					case 7:
						return;
					case 8:
						return;
					case 9:
						goto IL_0227;
					case 10:
						return;
					case 11:
						return;
					case 12:
						goto IL_0255;
					case 13:
						goto IL_02B8;
					case 14:
						if (obj is int)
						{
							goto IL_01B4;
						}
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bca7529ca324c188cfc0e64eb7d1cdf != 0)
						{
							goto IL_01D7;
						}
						continue;
					case 15:
						if (obj is float)
						{
							num = 58;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5be00c24d71649dcae8af3eed7b74ac9 != 0)
							{
								goto Block_25;
							}
							continue;
						}
						else
						{
							writer.WriteValue(Convert.ToDouble(this.uri_0, CultureInfo.InvariantCulture));
							num = 24;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9f5329f120e842948536b8235793166c != 0)
							{
								goto Block_26;
							}
							continue;
						}
						break;
					case 16:
						goto IL_058F;
					case 17:
						goto IL_01DF;
					case 18:
						return;
					case 19:
						goto IL_0550;
					case 20:
						goto IL_0260;
					case 22:
						return;
					case 23:
						goto IL_056E;
					case 24:
						return;
					case 25:
						goto IL_00E1;
					case 26:
						goto IL_028D;
					case 27:
						return;
					case 28:
						return;
					case 29:
						goto IL_0211;
					case 30:
						goto IL_01F3;
					case 31:
						goto IL_0239;
					case 32:
						goto IL_04D8;
					case 33:
						goto IL_01D7;
					case 34:
						goto IL_01B4;
					case 35:
						return;
					case 36:
						goto IL_048D;
					case 37:
						goto IL_0178;
					case 38:
						return;
					case 39:
						return;
					case 40:
						goto IL_0155;
					case 41:
						if (matchingConverter != null)
						{
							goto IL_0103;
						}
						goto IL_04CE;
					case 42:
						return;
					case 43:
						return;
					case 44:
						goto IL_0071;
					case 45:
						return;
					case 46:
						goto IL_0129;
					case 47:
						goto IL_05A3;
					case 48:
						return;
					case 49:
						goto IL_0103;
					case 50:
						return;
					case 51:
						goto IL_00D8;
					case 52:
						goto IL_05B9;
					case 53:
						return;
					case 54:
						goto IL_00B6;
					case 55:
						num2 = (decimal)obj;
						num = 11;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3baf10aa2a73406aa2bb349717d797c7 != 0)
						{
							goto Block_4;
						}
						continue;
					case 56:
						goto IL_05F9;
					case 57:
						goto IL_0602;
					case 58:
						num3 = (float)obj;
						goto IL_0071;
					case 59:
						goto IL_0028;
					case 60:
						goto IL_060F;
					}
					break;
					IL_0071:
					writer.WriteValue(num3);
					num = 16;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e5c1d856e0c64e6f8377f7d819e11923 != 0)
					{
						goto Block_3;
					}
					continue;
					IL_00E1:
					long num4;
					writer.WriteValue(num4);
					num = 4;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c367d9ce11cc43b595beeb4524149542 != 0)
					{
						goto Block_6;
					}
					continue;
					IL_00D8:
					num4 = (long)obj;
					goto IL_00E1;
					IL_01DF:
					if (!(obj is long))
					{
						goto Block_15;
					}
					goto IL_00D8;
					IL_01D7:
					obj = this.uri_0;
					goto IL_01DF;
					IL_0103:
					if (matchingConverter.CanWrite)
					{
						goto IL_05A3;
					}
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4b8a72ce901241b5b52fe60600cb3607 == 0)
					{
						goto Block_8;
					}
					continue;
					IL_01B4:
					num5 = (int)obj;
					num = 55;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_6bf87ae21d2446cfa7edc53669bb8039 != 0)
					{
						goto Block_14;
					}
				}
				goto IL_0046;
				Block_15:
				obj = this.uri_0;
				goto IL_01F3;
				Block_8:
				goto IL_04CE;
				IL_048D:
				JTokenType jtokenType;
				switch (jtokenType)
				{
				case JTokenType.Comment:
					goto IL_0550;
				case JTokenType.Integer:
					obj = this.uri_0;
					num = 14;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_52d717cd31b74287b67c03ee736a6211 != 0)
					{
						goto Block_30;
					}
					goto IL_034B;
				case JTokenType.Float:
					obj = this.uri_0;
					goto IL_028D;
				case JTokenType.String:
					goto IL_04ED;
				case JTokenType.Boolean:
					goto IL_0507;
				case JTokenType.Null:
					goto IL_051F;
				case JTokenType.Undefined:
					goto IL_052A;
				case JTokenType.Date:
					obj = this.uri_0;
					num = 37;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3436841e08c54f56b10b76e1438d4224 != 0)
					{
						goto IL_0178;
					}
					goto IL_034B;
				case JTokenType.Raw:
					goto IL_0618;
				case JTokenType.Bytes:
					goto IL_0631;
				case JTokenType.Guid:
					goto IL_0643;
				case JTokenType.Uri:
					goto IL_0669;
				case JTokenType.TimeSpan:
					goto IL_067B;
				default:
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4b8a72ce901241b5b52fe60600cb3607 == 0)
					{
						goto Block_31;
					}
					goto IL_034B;
				}
				IL_0028:
				double num6 = (double)obj;
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ca6ac77a767741aa91cb31f8080f093b == 0)
				{
					goto IL_0046;
				}
				goto IL_034B;
				IL_02B8:
				if (obj is double)
				{
					goto IL_0028;
				}
				num = 41;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cb7e1ff8cc1348bebf46c510e64a0134 == 0)
				{
					goto IL_0129;
				}
				goto IL_034B;
				IL_028D:
				if (!(obj is decimal))
				{
					obj = this.uri_0;
					goto IL_02B8;
				}
				num = 55;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_92ac2a37edba4e2587eb1b9e8af3f63f == 0)
				{
					goto IL_01F3;
				}
				goto IL_034B;
				IL_0046:
				writer.WriteValue(num6);
				num = 11;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_079bd9b874b24353bef46f6c3f5d741d == 0)
				{
					break;
				}
				goto IL_034B;
				IL_00B6:
				ulong num7;
				writer.WriteValue(num7);
				num = 7;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d97e64d0f425406b9649f2b4562a5f0e == 0)
				{
					goto Block_5;
				}
				goto IL_034B;
				IL_0211:
				num7 = (ulong)obj;
				goto IL_00B6;
				IL_0129:
				obj = this.uri_0;
				num = 15;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93ade03426d44b1841bfa7c633f49f3 != 0)
				{
					break;
				}
				goto IL_034B;
				IL_0155:
				bigInteger = (BigInteger)obj;
				num = 6;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b2d935deb963472994f6f2321f1a6296 == 0)
				{
					goto Block_11;
				}
				goto IL_034B;
				IL_0227:
				if (!(obj is BigInteger))
				{
					goto Block_17;
				}
				goto IL_0155;
				IL_01F3:
				if (!(obj is ulong))
				{
					obj = this.uri_0;
					goto IL_0227;
				}
				num = 17;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93ade03426d44b1841bfa7c633f49f3 == 0)
				{
					goto IL_0211;
				}
				goto IL_034B;
				IL_0178:
				if (obj is DateTimeOffset)
				{
					goto IL_058F;
				}
				writer.WriteValue(Convert.ToDateTime(this.uri_0, CultureInfo.InvariantCulture));
				num = 3;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a41eabd4b99f489fb7d86310d3f95ba2 == 0)
				{
					goto Block_13;
				}
				goto IL_034B;
				IL_0239:
				if (converters.Length == 0)
				{
					goto IL_04CE;
				}
				num = 8;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9f5329f120e842948536b8235793166c == 0)
				{
					goto IL_0255;
				}
				goto IL_034B;
				IL_0260:
				matchingConverter = JsonSerializer.GetMatchingConverter(converters, this.uri_0.GetType());
				num = 41;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c28a4ed7a58e45aaa9902e336fd60b97 != 0)
				{
					goto Block_19;
				}
				goto IL_034B;
				IL_0255:
				if (this.uri_0 != null)
				{
					goto IL_0260;
				}
				IL_04CE:
				jtokenType = this.khlHotcLxy;
				goto IL_048D;
			}
			return;
			Block_3:
			return;
			Block_4:
			goto IL_0602;
			Block_5:
			return;
			Block_6:
			return;
			Block_11:
			Block_13:
			return;
			Block_14:
			goto IL_060F;
			Block_17:
			goto IL_056E;
			Block_19:
			return;
			Block_25:
			return;
			Block_26:
			return;
			Block_30:
			return;
			Block_31:
			goto IL_05B9;
			IL_04ED:
			Uri uri = this.uri_0;
			writer.WriteValue((uri == null) ? null : uri.ToString());
			return;
			IL_0507:
			writer.WriteValue(Convert.ToBoolean(this.uri_0, CultureInfo.InvariantCulture));
			return;
			IL_051F:
			writer.WriteNull();
			return;
			IL_052A:
			writer.WriteUndefined();
			return;
			IL_0533:
			writer.WriteValue(bigInteger);
			return;
			IL_0550:
			Uri uri2 = this.uri_0;
			writer.WriteComment((uri2 != null) ? uri2.ToString() : null);
			return;
			IL_056E:
			writer.WriteValue(Convert.ToInt64(this.uri_0, CultureInfo.InvariantCulture));
			return;
			IL_058F:
			DateTimeOffset dateTimeOffset = (DateTimeOffset)obj;
			goto IL_05F9;
			IL_05A3:
			matchingConverter.WriteJson(writer, this.uri_0, JsonSerializer.CreateDefault());
			return;
			IL_05B9:
			throw MiscellaneousUtils.CreateArgumentOutOfRangeException(Class15.smethod_17(594374522 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5f127c3ec2e04c11ab1bd26a8d965f2b), this.khlHotcLxy, Class15.smethod_17(1042105105 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39a47a907a8a440980940ae96da3f3ad));
			IL_05F9:
			writer.WriteValue(dateTimeOffset);
			return;
			IL_0602:
			writer.WriteValue(num2);
			return;
			IL_060F:
			writer.WriteValue(num5);
			return;
			IL_0618:
			Uri uri3 = this.uri_0;
			writer.WriteRawValue((uri3 != null) ? uri3.ToString() : null);
			return;
			IL_0631:
			writer.WriteValue((byte[])this.uri_0);
			return;
			IL_0643:
			writer.WriteValue((this.uri_0 == null) ? null : ((Guid?)this.uri_0));
			return;
			IL_0669:
			writer.WriteValue((Uri)this.uri_0);
			return;
			IL_067B:
			writer.WriteValue((this.uri_0 != null) ? ((TimeSpan?)this.uri_0) : null);
		}

		// Token: 0x06001097 RID: 4247 RVA: 0x00084500 File Offset: 0x00082700
		internal override int GetDeepHashCode()
		{
			int num3;
			int num4;
			for (;;)
			{
				IL_0069:
				int num;
				if (this.uri_0 != null)
				{
					num = this.uri_0.GetHashCode();
					goto IL_003F;
				}
				int num2 = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b2d935deb963472994f6f2321f1a6296 != 0)
				{
					goto IL_003E;
				}
				for (;;)
				{
					IL_0029:
					switch (num2)
					{
					default:
						goto IL_003E;
					case 1:
						goto IL_0069;
					case 2:
						num3 = (int)this.khlHotcLxy;
						num2 = 3;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c367d9ce11cc43b595beeb4524149542 == 0)
						{
							goto IL_0074;
						}
						break;
					case 3:
						goto IL_0075;
					}
				}
				IL_003F:
				num4 = num;
				num2 = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39f35935adc2477fa894750fee078177 == 0)
				{
					continue;
				}
				goto IL_0029;
				IL_003E:
				num = 0;
				goto IL_003F;
			}
			IL_0074:
			IL_0075:
			return num3.GetHashCode() ^ num4;
		}

		// Token: 0x06001098 RID: 4248 RVA: 0x0008458C File Offset: 0x0008278C
		[NullableContext(1)]
		private static bool smethod_10(Uri uri_1, Uri uri_2)
		{
			while (uri_1 != uri_2)
			{
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_11c6824de6514281a8425f6d6ab1a2d5 == 0)
				{
					goto IL_0015;
				}
				IL_0034:
				switch (num)
				{
				case 1:
					continue;
				case 2:
					goto IL_0054;
				}
				IL_0015:
				if (uri_1.khlHotcLxy != uri_2.khlHotcLxy)
				{
					return false;
				}
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5be00c24d71649dcae8af3eed7b74ac9 != 0)
				{
					goto IL_0034;
				}
				IL_0054:
				return JValue.Compare(uri_1.khlHotcLxy, uri_1.uri_0, uri_2.uri_0) == 0;
			}
			return true;
		}

		// Token: 0x06001099 RID: 4249 RVA: 0x0008460C File Offset: 0x0008280C
		public bool Equals(JValue other)
		{
			while (other != null)
			{
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_43b32b9d66294210a955990bb6fcc511 != 0)
				{
					switch (num)
					{
					case 0:
						return false;
					case 1:
						break;
					case 2:
						continue;
					default:
						return false;
					}
				}
				return JValue.smethod_10(this, other);
			}
			return false;
		}

		// Token: 0x0600109A RID: 4250 RVA: 0x00084654 File Offset: 0x00082854
		public override bool Equals(object obj)
		{
			JValue jvalue;
			for (;;)
			{
				jvalue = obj as JValue;
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7ae4da5a55de471eb12dd0de8dd4269c == 0)
				{
					goto IL_0003;
				}
				IL_0018:
				switch (num)
				{
				case 1:
					IL_0003:
					if (jvalue == null)
					{
						return false;
					}
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d9581c727fcc4f50accd4f5de0d386f5 == 0)
					{
						goto IL_0018;
					}
					break;
				case 2:
					continue;
				}
				break;
			}
			return this.Equals(jvalue);
		}

		// Token: 0x0600109B RID: 4251 RVA: 0x000846B4 File Offset: 0x000828B4
		public override int GetHashCode()
		{
			while (this.uri_0 == null)
			{
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_548c52e5632b45898e377ad9c9a06469 != 0)
				{
					switch (num)
					{
					case 1:
						continue;
					}
				}
				return 0;
			}
			return this.uri_0.GetHashCode();
		}

		// Token: 0x0600109C RID: 4252 RVA: 0x00084700 File Offset: 0x00082900
		[NullableContext(1)]
		public override string ToString()
		{
			while (this.uri_0 != null)
			{
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39d5fbfa4fe34ed9908db538e5340a6c != 0)
				{
					switch (num)
					{
					case 1:
						continue;
					case 2:
						goto IL_0040;
					}
				}
				return this.uri_0.ToString();
			}
			IL_0040:
			return string.Empty;
		}

		// Token: 0x0600109D RID: 4253 RVA: 0x000066C0 File Offset: 0x000048C0
		[NullableContext(1)]
		public string ToString(string format)
		{
			return this.ToString(format, CultureInfo.CurrentCulture);
		}

		// Token: 0x0600109E RID: 4254 RVA: 0x000066CE File Offset: 0x000048CE
		[NullableContext(1)]
		public string ToString([Nullable(2)] IFormatProvider formatProvider)
		{
			return this.ToString(null, formatProvider);
		}

		// Token: 0x0600109F RID: 4255 RVA: 0x00084754 File Offset: 0x00082954
		[return: Nullable(1)]
		public string ToString(string format, IFormatProvider formatProvider)
		{
			while (this.uri_0 != null)
			{
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8d68b74cee6442019d959192b2974e3d == 0)
				{
					goto IL_002F;
				}
				goto IL_003E;
				IL_0017:
				IFormattable formattable;
				if (formattable != null)
				{
					goto IL_0076;
				}
				num = 3;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39f35935adc2477fa894750fee078177 == 0)
				{
					continue;
				}
				goto IL_003E;
				IL_002F:
				formattable = this.uri_0 as IFormattable;
				goto IL_0017;
				IL_003E:
				switch (num)
				{
				case 0:
					goto IL_002F;
				case 1:
					continue;
				case 2:
					goto IL_0080;
				case 3:
					return this.uri_0.ToString();
				case 4:
					break;
				case 5:
					goto IL_0017;
				default:
					goto IL_002F;
				}
				IL_0076:
				return formattable.ToString(format, formatProvider);
			}
			IL_0080:
			return string.Empty;
		}

		// Token: 0x060010A0 RID: 4256 RVA: 0x000066D8 File Offset: 0x000048D8
		[NullableContext(1)]
		protected override DynamicMetaObject GetMetaObject(Expression parameter)
		{
			return new DynamicProxyMetaObject<JValue>(parameter, this, new JValue.Class4());
		}

		// Token: 0x060010A1 RID: 4257 RVA: 0x000847E8 File Offset: 0x000829E8
		int IComparable.CompareTo(object obj)
		{
			while (obj != null)
			{
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a5994720d09542abb897ebf6ad9b5a19 == 0)
				{
					goto IL_00AD;
				}
				IL_00D1:
				JValue jvalue;
				switch (num)
				{
				case 0:
					goto IL_00C7;
				case 1:
					IL_00AD:
					jvalue = obj as JValue;
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4ac69ea2381b403582a2723337f67fa8 == 0)
					{
						goto IL_00C7;
					}
					goto IL_00D1;
				case 2:
					continue;
				case 3:
				case 7:
					goto IL_011E;
				case 4:
					goto IL_0116;
				case 5:
					goto IL_005E;
				case 6:
					goto IL_00A1;
				case 8:
					goto IL_0086;
				case 9:
					goto IL_003D;
				case 10:
					return 1;
				case 11:
					break;
				default:
					goto IL_00C7;
				}
				IL_0020:
				object obj2 = obj;
				num = 3;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cbfb1e54efd84756a9b6d7b21adc0d65 == 0)
				{
					goto IL_0116;
				}
				goto IL_00D1;
				IL_00C7:
				if (jvalue != null)
				{
					goto IL_0086;
				}
				goto IL_0020;
				IL_003D:
				JTokenType jtokenType;
				if (this.khlHotcLxy != jvalue.khlHotcLxy)
				{
					jtokenType = jvalue.khlHotcLxy;
					goto IL_006D;
				}
				num = 3;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa29cbda752f45acbe81e7d5285df2ba != 0)
				{
					goto IL_005E;
				}
				goto IL_00D1;
				IL_00A1:
				if (this.khlHotcLxy == JTokenType.String)
				{
					goto IL_003D;
				}
				goto IL_005E;
				IL_006D:
				JTokenType jtokenType2 = jtokenType;
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a5994720d09542abb897ebf6ad9b5a19 == 0)
				{
					goto IL_011E;
				}
				goto IL_00D1;
				IL_005E:
				jtokenType = this.khlHotcLxy;
				goto IL_006D;
				IL_0086:
				obj2 = jvalue.Value;
				num = 5;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_370349efcd7c4959a098549c3d5bf14d != 0)
				{
					goto IL_00A1;
				}
				goto IL_00D1;
				IL_0116:
				jtokenType2 = this.khlHotcLxy;
				IL_011E:
				return JValue.Compare(jtokenType2, this.uri_0, obj2);
			}
			return 1;
		}

		// Token: 0x060010A2 RID: 4258 RVA: 0x00084924 File Offset: 0x00082B24
		public int CompareTo(JValue obj)
		{
			while (obj != null)
			{
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_db7740c6ca7a4f3c8e1aa526bdb0a454 != 0)
				{
					goto IL_0039;
				}
				IL_0045:
				switch (num)
				{
				case 0:
					goto IL_0068;
				case 1:
					IL_0039:
					if (this.khlHotcLxy != JTokenType.String)
					{
						goto IL_0068;
					}
					break;
				case 2:
					continue;
				case 3:
					return 1;
				case 4:
					break;
				default:
					goto IL_0068;
				}
				JTokenType jtokenType;
				if (this.khlHotcLxy != obj.khlHotcLxy)
				{
					jtokenType = obj.khlHotcLxy;
					goto IL_0076;
				}
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d6c400f349964629bcd869033695bff0 == 0)
				{
					goto IL_0045;
				}
				IL_0068:
				jtokenType = this.khlHotcLxy;
				IL_0076:
				return JValue.Compare(jtokenType, this.uri_0, obj.uri_0);
			}
			return 1;
		}

		// Token: 0x060010A3 RID: 4259 RVA: 0x000849BC File Offset: 0x00082BBC
		TypeCode IConvertible.GetTypeCode()
		{
			while (this.uri_0 != null)
			{
				IConvertible convertible = this.uri_0 as IConvertible;
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3baf10aa2a73406aa2bb349717d797c7 != 0)
				{
					goto IL_0022;
				}
				IL_0037:
				switch (num)
				{
				case 1:
					IL_0022:
					if (convertible == null)
					{
						return TypeCode.Object;
					}
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c367d9ce11cc43b595beeb4524149542 == 0)
					{
						goto IL_0037;
					}
					break;
				case 2:
					return TypeCode.Empty;
				case 3:
					continue;
				}
				return convertible.GetTypeCode();
			}
			return TypeCode.Empty;
		}

		// Token: 0x060010A4 RID: 4260 RVA: 0x000066E6 File Offset: 0x000048E6
		bool IConvertible.ToBoolean(IFormatProvider provider)
		{
			return (bool)this;
		}

		// Token: 0x060010A5 RID: 4261 RVA: 0x000066EE File Offset: 0x000048EE
		char IConvertible.ToChar(IFormatProvider provider)
		{
			return (char)this;
		}

		// Token: 0x060010A6 RID: 4262 RVA: 0x000066F6 File Offset: 0x000048F6
		sbyte IConvertible.ToSByte(IFormatProvider provider)
		{
			return (sbyte)this;
		}

		// Token: 0x060010A7 RID: 4263 RVA: 0x000066FE File Offset: 0x000048FE
		byte IConvertible.ToByte(IFormatProvider provider)
		{
			return (byte)this;
		}

		// Token: 0x060010A8 RID: 4264 RVA: 0x00006706 File Offset: 0x00004906
		short IConvertible.ToInt16(IFormatProvider provider)
		{
			return (short)this;
		}

		// Token: 0x060010A9 RID: 4265 RVA: 0x0000670E File Offset: 0x0000490E
		ushort IConvertible.ToUInt16(IFormatProvider provider)
		{
			return (ushort)this;
		}

		// Token: 0x060010AA RID: 4266 RVA: 0x00006716 File Offset: 0x00004916
		int IConvertible.ToInt32(IFormatProvider provider)
		{
			return (int)this;
		}

		// Token: 0x060010AB RID: 4267 RVA: 0x0000671E File Offset: 0x0000491E
		uint IConvertible.ToUInt32(IFormatProvider provider)
		{
			return (uint)this;
		}

		// Token: 0x060010AC RID: 4268 RVA: 0x00006726 File Offset: 0x00004926
		long IConvertible.ToInt64(IFormatProvider provider)
		{
			return (long)this;
		}

		// Token: 0x060010AD RID: 4269 RVA: 0x0000672E File Offset: 0x0000492E
		ulong IConvertible.ToUInt64(IFormatProvider provider)
		{
			return (ulong)this;
		}

		// Token: 0x060010AE RID: 4270 RVA: 0x00006736 File Offset: 0x00004936
		float IConvertible.ToSingle(IFormatProvider provider)
		{
			return (float)this;
		}

		// Token: 0x060010AF RID: 4271 RVA: 0x0000673F File Offset: 0x0000493F
		double IConvertible.ToDouble(IFormatProvider provider)
		{
			return (double)this;
		}

		// Token: 0x060010B0 RID: 4272 RVA: 0x00006748 File Offset: 0x00004948
		decimal IConvertible.ToDecimal(IFormatProvider provider)
		{
			return (decimal)this;
		}

		// Token: 0x060010B1 RID: 4273 RVA: 0x00006750 File Offset: 0x00004950
		DateTime IConvertible.ToDateTime(IFormatProvider provider)
		{
			return (DateTime)this;
		}

		// Token: 0x060010B2 RID: 4274 RVA: 0x00006758 File Offset: 0x00004958
		[NullableContext(1)]
		object IConvertible.ToType(Type conversionType, [Nullable(2)] IFormatProvider provider)
		{
			return base.ToObject(conversionType);
		}

		// Token: 0x0400073F RID: 1855
		private JTokenType khlHotcLxy;

		// Token: 0x04000740 RID: 1856
		private Uri uri_0;

		// Token: 0x0200016E RID: 366
		[Nullable(new byte[] { 0, 1 })]
		[NullableContext(1)]
		private class Class4 : DynamicProxy<JValue>
		{
			// Token: 0x060010B6 RID: 4278 RVA: 0x00084A30 File Offset: 0x00082C30
			public override bool TryConvert(JValue instance, ConvertBinder binder, [NotNullWhen(true)] [Nullable(2)] out object result)
			{
				IL_009B:
				while (!(binder.Type == typeof(JValue)))
				{
					while (!(binder.Type == typeof(JToken)))
					{
						object value = instance.Value;
						int num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0361b8eb39074ea88f5257b13904930a == 0)
						{
							goto IL_004B;
						}
						goto IL_0052;
						for (;;)
						{
							IL_0022:
							result = null;
							num = 4;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_725e5f82c8704b39b66ebddcee8df7fa != 0)
							{
								goto IL_0052;
							}
						}
						IL_004B:
						while (value != null)
						{
							num = 1;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f77f8ab5a3534e2e914063d52217b4e1 == 0)
							{
								goto IL_0052;
							}
						}
						goto IL_0022;
						IL_0052:
						switch (num)
						{
						case 0:
							goto IL_004B;
						case 1:
							result = ConvertUtils.Convert(value, CultureInfo.InvariantCulture, binder.Type);
							break;
						case 2:
							return true;
						case 3:
							goto IL_0022;
						case 4:
							return ReflectionUtils.IsNullable(binder.Type);
						case 5:
							goto IL_00D9;
						case 6:
							break;
						case 7:
							continue;
						case 8:
							goto IL_009B;
						default:
							goto IL_004B;
						}
						return true;
					}
					break;
				}
				IL_00D9:
				result = instance;
				return true;
			}

			// Token: 0x060010B7 RID: 4279 RVA: 0x00084B1C File Offset: 0x00082D1C
			public override bool TryBinaryOperation(JValue instance, BinaryOperationBinder binder, object arg, [Nullable(2)] [NotNullWhen(true)] out object result)
			{
				object obj2;
				for (;;)
				{
					IL_02BE:
					JValue jvalue = arg as JValue;
					int num = 21;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_948fa5c193d44e279b41c3a0fab7b5c9 != 0)
					{
						goto Block_22;
					}
					for (;;)
					{
						ExpressionType operation;
						object obj;
						switch (num)
						{
						case 0:
							goto IL_0108;
						case 1:
							goto IL_00E4;
						case 2:
							goto IL_0376;
						case 3:
							goto IL_002D;
						case 4:
							if (operation > ExpressionType.NotEqual)
							{
								goto IL_01CC;
							}
							num = 30;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_550a8fe2e5fe4cc19bdfe1a82a7f12b8 == 0)
							{
								continue;
							}
							goto IL_02E0;
						case 5:
							return true;
						case 6:
							return true;
						case 7:
							goto IL_00ED;
						case 8:
							return false;
						case 9:
							goto IL_01E4;
						case 10:
							break;
						case 11:
							goto IL_01ED;
						case 12:
							goto IL_0114;
						case 13:
							goto IL_020D;
						case 14:
							goto IL_01A9;
						case 15:
						case 20:
						case 23:
						case 28:
							goto IL_012E;
						case 16:
							goto IL_01CC;
						case 17:
							goto IL_01AC;
						case 18:
							return true;
						case 19:
							goto IL_02EA;
						case 21:
							if (jvalue == null)
							{
								goto IL_01A9;
							}
							num = 25;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8d68b74cee6442019d959192b2974e3d != 0)
							{
								goto IL_016C;
							}
							continue;
						case 22:
							goto IL_02BE;
						case 24:
							goto IL_016C;
						case 25:
							obj = jvalue.Value;
							goto IL_0153;
						case 26:
							return true;
						case 27:
							return true;
						case 29:
							return true;
						case 30:
							if (operation > ExpressionType.LessThanOrEqual)
							{
								goto IL_00ED;
							}
							break;
						case 31:
							return true;
						default:
							goto IL_0108;
						}
						if (operation == ExpressionType.Add)
						{
							num = 12;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_75738dd4edc84122bfe3748a1ea03d43 != 0)
							{
								goto Block_2;
							}
							continue;
						}
						IL_002D:
						switch (operation)
						{
						case ExpressionType.Divide:
							IL_0114:
							if (!JValue.smethod_7(binder.Operation, instance.Value, obj2, out result))
							{
								goto IL_012E;
							}
							goto IL_0376;
						case ExpressionType.Equal:
							goto IL_02EA;
						case ExpressionType.ExclusiveOr:
						case ExpressionType.Invoke:
						case ExpressionType.Lambda:
						case ExpressionType.LeftShift:
							goto IL_012E;
						case ExpressionType.GreaterThan:
							result = JValue.Compare(instance.Type, instance.Value, obj2) > 0;
							num = 18;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c08ab7af63da4f24a4fa3e9c7a732fae == 0)
							{
								goto Block_5;
							}
							continue;
						case ExpressionType.GreaterThanOrEqual:
							goto IL_030D;
						case ExpressionType.LessThan:
							result = JValue.Compare(instance.Type, instance.Value, obj2) < 0;
							num = 5;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_57ce3fecb9e64a8f924ea7658e146719 == 0)
							{
								goto IL_00E4;
							}
							continue;
						case ExpressionType.LessThanOrEqual:
							goto IL_0330;
						default:
							num = 2;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c367d9ce11cc43b595beeb4524149542 == 0)
							{
								goto IL_012E;
							}
							continue;
						}
						IL_00ED:
						if (operation == ExpressionType.Multiply)
						{
							goto IL_0114;
						}
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_67a271e0ae064fc7a3a74905868add95 == 0)
						{
							goto IL_0108;
						}
						continue;
						IL_012E:
						result = null;
						num = 8;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d5af2cccac2f47ed978e804138a35d1c == 0)
						{
							goto Block_9;
						}
						continue;
						IL_00E4:
						if (operation != ExpressionType.SubtractAssign)
						{
							goto IL_012E;
						}
						goto IL_0114;
						IL_0108:
						if (operation != ExpressionType.NotEqual)
						{
							goto IL_012E;
						}
						goto IL_0353;
						IL_0153:
						obj2 = obj;
						num = 24;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4152404f503b492c83d9bc2e44bdd0a7 == 0)
						{
							goto IL_0114;
						}
						continue;
						IL_01A9:
						obj = arg;
						goto IL_0153;
						IL_016C:
						operation = binder.Operation;
						num = 4;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39f35935adc2477fa894750fee078177 == 0)
						{
							goto IL_00E4;
						}
						continue;
						IL_01CC:
						if (operation > ExpressionType.AddAssign)
						{
							goto IL_020D;
						}
						num = 9;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_01137da6c88c4265bdc0297aacf3340f != 0)
						{
							goto IL_01E4;
						}
						continue;
						IL_01AC:
						if (operation == ExpressionType.MultiplyAssign)
						{
							goto IL_0114;
						}
						num = 1;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_6bf87ae21d2446cfa7edc53669bb8039 == 0)
						{
							goto IL_0108;
						}
						continue;
						IL_01E4:
						if (operation == ExpressionType.Subtract)
						{
							goto IL_0114;
						}
						IL_01ED:
						if (operation == ExpressionType.AddAssign)
						{
							goto IL_0114;
						}
						num = 9;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_01137da6c88c4265bdc0297aacf3340f != 0)
						{
							goto IL_012E;
						}
						continue;
						IL_020D:
						if (operation != ExpressionType.DivideAssign)
						{
							goto IL_01AC;
						}
						goto IL_0114;
					}
				}
				Block_2:
				return true;
				Block_5:
				goto IL_0376;
				Block_9:
				return false;
				Block_22:
				goto IL_0376;
				IL_02E0:
				return true;
				IL_02EA:
				result = JValue.Compare(instance.Type, instance.Value, obj2) == 0;
				return true;
				IL_030D:
				result = JValue.Compare(instance.Type, instance.Value, obj2) >= 0;
				return true;
				IL_0330:
				result = JValue.Compare(instance.Type, instance.Value, obj2) <= 0;
				return true;
				IL_0353:
				result = JValue.Compare(instance.Type, instance.Value, obj2) != 0;
				return true;
				IL_0376:
				result = new JValue(result);
				return true;
			}

			// Token: 0x060010B8 RID: 4280 RVA: 0x00084EB0 File Offset: 0x000830B0
			public Class4()
			{
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3baf10aa2a73406aa2bb349717d797c7 != 0)
				{
					switch (num)
					{
					}
				}
			}
		}
	}
}
