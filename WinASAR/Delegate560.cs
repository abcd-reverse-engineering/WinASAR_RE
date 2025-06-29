using System;
using System.Reflection;

// Token: 0x02000440 RID: 1088
internal sealed class Delegate560 : MulticastDelegate
{
	// Token: 0x06002094 RID: 8340
	public extern ConstructorInfo Invoke(object object_0, Type[] type_0);

	// Token: 0x06002095 RID: 8341 RVA: 0x0000B925 File Offset: 0x00009B25
	public static ConstructorInfo smethod_0(object object_0, Type[] type_0, Delegate560 delegate560_1)
	{
		return delegate560_1(object_0, type_0);
	}

	// Token: 0x06002096 RID: 8342
	public extern Delegate560(object object_0, IntPtr intptr_0);

	// Token: 0x06002097 RID: 8343 RVA: 0x0000B932 File Offset: 0x00009B32
	static Delegate560()
	{
		Class15.smethod_14(typeof(Delegate560).TypeHandle);
	}

	// Token: 0x04000C10 RID: 3088
	internal static Delegate560 delegate560_0;
}
