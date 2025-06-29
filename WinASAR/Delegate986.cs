using System;
using System.Dynamic;

// Token: 0x020005EA RID: 1514
internal sealed class Delegate986 : MulticastDelegate
{
	// Token: 0x0600273C RID: 10044
	public extern DynamicMetaObject Invoke(object object_0, DynamicMetaObject dynamicMetaObject_0, DynamicMetaObject dynamicMetaObject_1);

	// Token: 0x0600273D RID: 10045 RVA: 0x0000E35A File Offset: 0x0000C55A
	public static DynamicMetaObject smethod_0(object object_0, DynamicMetaObject dynamicMetaObject_0, DynamicMetaObject dynamicMetaObject_1, Delegate986 delegate986_1)
	{
		return delegate986_1(object_0, dynamicMetaObject_0, dynamicMetaObject_1);
	}

	// Token: 0x0600273E RID: 10046
	public extern Delegate986(object object_0, IntPtr intptr_0);

	// Token: 0x0600273F RID: 10047 RVA: 0x0000E369 File Offset: 0x0000C569
	static Delegate986()
	{
		Class15.smethod_14(typeof(Delegate986).TypeHandle);
	}

	// Token: 0x04000DBA RID: 3514
	internal static Delegate986 delegate986_0;
}
