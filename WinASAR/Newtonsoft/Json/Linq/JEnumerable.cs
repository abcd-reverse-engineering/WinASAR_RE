using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Linq
{
	// Token: 0x02000152 RID: 338
	[Nullable(0)]
	[NullableContext(1)]
	public readonly struct JEnumerable<[Nullable(0)] T> : IJEnumerable<T>, IEnumerable<T>, IEnumerable, IEquatable<JEnumerable<T>> where T : JToken
	{
		// Token: 0x06000E6B RID: 3691 RVA: 0x00005E80 File Offset: 0x00004080
		public JEnumerable(IEnumerable<T> enumerable)
		{
			ValidationUtils.ArgumentNotNull(enumerable, Class15.smethod_17(1802324537 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_991c06e999c744809f5b643cb7d9e7b4));
			this.ienumerable_0 = enumerable;
		}

		// Token: 0x06000E6C RID: 3692 RVA: 0x00005EA6 File Offset: 0x000040A6
		public IEnumerator<T> GetEnumerator()
		{
			return (this.ienumerable_0 ?? JEnumerable<T>.Empty).GetEnumerator();
		}

		// Token: 0x06000E6D RID: 3693 RVA: 0x00005EC1 File Offset: 0x000040C1
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		// Token: 0x17000221 RID: 545
		public IJEnumerable<JToken> this[object key]
		{
			get
			{
				if (this.ienumerable_0 == null)
				{
					return JEnumerable<JToken>.Empty;
				}
				return new JEnumerable<JToken>(this.ienumerable_0.Values(key));
			}
		}

		// Token: 0x06000E6F RID: 3695 RVA: 0x00005EF4 File Offset: 0x000040F4
		public bool Equals([Nullable(new byte[] { 0, 1 })] JEnumerable<T> other)
		{
			return object.Equals(this.ienumerable_0, other.ienumerable_0);
		}

		// Token: 0x06000E70 RID: 3696 RVA: 0x00077A68 File Offset: 0x00075C68
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			JEnumerable<T> jenumerable;
			for (;;)
			{
				if (obj is JEnumerable<T>)
				{
					goto IL_0003;
				}
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ee35a23edd8f4998990ec1a2b40fc61a != 0)
				{
					break;
				}
				IL_001C:
				switch (num)
				{
				case 1:
					continue;
				case 2:
					goto IL_0057;
				case 3:
					IL_0003:
					jenumerable = (JEnumerable<T>)obj;
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_55c1fea936c04e47abbfb2b5f778aff7 != 0)
					{
						goto IL_001C;
					}
					goto IL_0056;
				}
				break;
			}
			return false;
			IL_0056:
			IL_0057:
			return this.Equals(jenumerable);
		}

		// Token: 0x06000E71 RID: 3697 RVA: 0x00077AD4 File Offset: 0x00075CD4
		public override int GetHashCode()
		{
			while (this.ienumerable_0 == null)
			{
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3a299c01dd4f4a209bdbd1b98e3f1406 != 0)
				{
					switch (num)
					{
					case 1:
						continue;
					}
				}
				return 0;
			}
			return this.ienumerable_0.GetHashCode();
		}

		// Token: 0x06000E72 RID: 3698 RVA: 0x00077B20 File Offset: 0x00075D20
		static JEnumerable()
		{
			for (;;)
			{
				for (;;)
				{
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_11c6824de6514281a8425f6d6ab1a2d5 == 0)
					{
						goto IL_0003;
					}
					IL_0023:
					switch (num)
					{
					case 1:
						return;
					case 2:
						continue;
					case 3:
						continue;
					}
					IL_0003:
					JEnumerable<T>.Empty = new JEnumerable<T>(Enumerable.Empty<T>());
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_67cbcb2ad04040d48847c1ca2f65be32 != 0)
					{
						goto IL_0023;
					}
					return;
				}
			}
		}

		// Token: 0x06000E73 RID: 3699 RVA: 0x00002C18 File Offset: 0x00000E18
		internal static bool smethod_0()
		{
			return true;
		}

		// Token: 0x06000E74 RID: 3700 RVA: 0x00003C0E File Offset: 0x00001E0E
		internal static object smethod_1()
		{
			return null;
		}

		// Token: 0x040006BD RID: 1725
		[Nullable(new byte[] { 0, 1 })]
		public static readonly JEnumerable<T> Empty;

		// Token: 0x040006BE RID: 1726
		private readonly IEnumerable<T> ienumerable_0;
	}
}
