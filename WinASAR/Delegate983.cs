using System;
using System.Dynamic;

// Token: 0x020005E7 RID: 1511
internal sealed class Delegate983 : MulticastDelegate
{
	// Token: 0x06002730 RID: 10032
	public extern DynamicMetaObject Invoke(object object_0, DynamicMetaObject dynamicMetaObject_0, DynamicMetaObject[] dynamicMetaObject_1, DynamicMetaObject dynamicMetaObject_2);

	// Token: 0x06002731 RID: 10033 RVA: 0x0000E2FE File Offset: 0x0000C4FE
	public static DynamicMetaObject smethod_0(object object_0, DynamicMetaObject dynamicMetaObject_0, DynamicMetaObject[] dynamicMetaObject_1, DynamicMetaObject dynamicMetaObject_2, Delegate983 delegate983_1)
	{
		return delegate983_1(object_0, dynamicMetaObject_0, dynamicMetaObject_1, dynamicMetaObject_2);
	}

	// Token: 0x06002732 RID: 10034
	public extern Delegate983(object object_0, IntPtr intptr_0);

	// Token: 0x06002733 RID: 10035 RVA: 0x0000E30F File Offset: 0x0000C50F
	static Delegate983()
	{
		Class15.smethod_14(typeof(Delegate983).TypeHandle);
	}

	// Token: 0x04000DB7 RID: 3511
	internal static Delegate983 delegate983_0;
}
