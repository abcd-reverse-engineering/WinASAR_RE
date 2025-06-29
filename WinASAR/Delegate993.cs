using System;
using System.Dynamic;

// Token: 0x020005F1 RID: 1521
internal sealed class Delegate993 : MulticastDelegate
{
	// Token: 0x06002758 RID: 10072
	public extern DynamicMetaObject Invoke(object object_0, DynamicMetaObject dynamicMetaObject_0, DynamicMetaObject[] dynamicMetaObject_1, DynamicMetaObject dynamicMetaObject_2);

	// Token: 0x06002759 RID: 10073 RVA: 0x0000E426 File Offset: 0x0000C626
	public static DynamicMetaObject smethod_0(object object_0, DynamicMetaObject dynamicMetaObject_0, DynamicMetaObject[] dynamicMetaObject_1, DynamicMetaObject dynamicMetaObject_2, Delegate993 delegate993_1)
	{
		return delegate993_1(object_0, dynamicMetaObject_0, dynamicMetaObject_1, dynamicMetaObject_2);
	}

	// Token: 0x0600275A RID: 10074
	public extern Delegate993(object object_0, IntPtr intptr_0);

	// Token: 0x0600275B RID: 10075 RVA: 0x0000E437 File Offset: 0x0000C637
	static Delegate993()
	{
		Class15.smethod_14(typeof(Delegate993).TypeHandle);
	}

	// Token: 0x04000DC1 RID: 3521
	internal static Delegate993 delegate993_0;
}
