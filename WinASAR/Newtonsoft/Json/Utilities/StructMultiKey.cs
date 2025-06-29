using System;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x020000DE RID: 222
	[Nullable(0)]
	[NullableContext(1)]
	internal readonly struct StructMultiKey<[Nullable(2)] T1, [Nullable(2)] T2> : IEquatable<StructMultiKey<T1, T2>>
	{
		// Token: 0x060008B2 RID: 2226 RVA: 0x000046FA File Offset: 0x000028FA
		public StructMultiKey(T1 v1, T2 v2)
		{
			this.Value1 = v1;
			this.Value2 = v2;
		}

		// Token: 0x060008B3 RID: 2227 RVA: 0x000525C8 File Offset: 0x000507C8
		public override int GetHashCode()
		{
			T1 value;
			for (;;)
			{
				value = this.Value1;
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa49bb51056944098afe92e3a80a544b == 0)
				{
					goto IL_0003;
				}
				IL_0024:
				switch (num)
				{
				case 1:
					continue;
				case 2:
					goto IL_0064;
				}
				IL_0003:
				if (value != null)
				{
					goto IL_0057;
				}
				num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_57ce3fecb9e64a8f924ea7658e146719 == 0)
				{
					goto IL_0024;
				}
				break;
			}
			goto IL_0064;
			IL_0057:
			int num2 = value.GetHashCode();
			goto IL_0065;
			IL_0064:
			num2 = 0;
			IL_0065:
			T2 value2 = this.Value2;
			return num2 ^ ((value2 != null) ? value2.GetHashCode() : 0);
		}

		// Token: 0x060008B4 RID: 2228 RVA: 0x00052664 File Offset: 0x00050864
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			StructMultiKey<T1, T2> structMultiKey;
			while (!(obj is StructMultiKey<T1, T2>))
			{
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_db7740c6ca7a4f3c8e1aa526bdb0a454 == 0)
				{
					switch (num)
					{
					case 2:
						continue;
					case 3:
						IL_0046:
						return this.Equals(structMultiKey);
					case 4:
						goto IL_003E;
					}
				}
				return false;
			}
			IL_003E:
			structMultiKey = (StructMultiKey<T1, T2>)obj;
			goto IL_0046;
		}

		// Token: 0x060008B5 RID: 2229 RVA: 0x0000470C File Offset: 0x0000290C
		public bool Equals([Nullable(new byte[] { 0, 1, 1 })] StructMultiKey<T1, T2> other)
		{
			return object.Equals(this.Value1, other.Value1) && object.Equals(this.Value2, other.Value2);
		}

		// Token: 0x060008B6 RID: 2230 RVA: 0x00002C18 File Offset: 0x00000E18
		internal static bool smethod_0()
		{
			return true;
		}

		// Token: 0x060008B7 RID: 2231 RVA: 0x00003C0E File Offset: 0x00001E0E
		internal static object smethod_1()
		{
			return null;
		}

		// Token: 0x040004A6 RID: 1190
		public readonly T1 Value1;

		// Token: 0x040004A7 RID: 1191
		public readonly T2 Value2;
	}
}
