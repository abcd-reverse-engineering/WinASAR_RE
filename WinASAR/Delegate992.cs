using System;
using System.Dynamic;

// Token: 0x020005F0 RID: 1520
internal sealed class Delegate992 : MulticastDelegate
{
	// Token: 0x06002754 RID: 10068
	public extern DynamicMetaObject Invoke(object object_0, DynamicMetaObject dynamicMetaObject_0, DynamicMetaObject[] dynamicMetaObject_1, DynamicMetaObject dynamicMetaObject_2);

	// Token: 0x06002755 RID: 10069 RVA: 0x0000E408 File Offset: 0x0000C608
	public static DynamicMetaObject smethod_0(object object_0, DynamicMetaObject dynamicMetaObject_0, DynamicMetaObject[] dynamicMetaObject_1, DynamicMetaObject dynamicMetaObject_2, Delegate992 delegate992_1)
	{
		return delegate992_1(object_0, dynamicMetaObject_0, dynamicMetaObject_1, dynamicMetaObject_2);
	}

	// Token: 0x06002756 RID: 10070
	public extern Delegate992(object object_0, IntPtr intptr_0);

	// Token: 0x06002757 RID: 10071 RVA: 0x0000E419 File Offset: 0x0000C619
	static Delegate992()
	{
		Class15.smethod_14(typeof(Delegate992).TypeHandle);
	}

	// Token: 0x04000DC0 RID: 3520
	internal static Delegate992 delegate992_0;
}
