using System;
using System.Dynamic;

// Token: 0x020005E9 RID: 1513
internal sealed class Delegate985 : MulticastDelegate
{
	// Token: 0x06002738 RID: 10040
	public extern DynamicMetaObject Invoke(object object_0, DynamicMetaObject dynamicMetaObject_0, DynamicMetaObject[] dynamicMetaObject_1, DynamicMetaObject dynamicMetaObject_2);

	// Token: 0x06002739 RID: 10041 RVA: 0x0000E33C File Offset: 0x0000C53C
	public static DynamicMetaObject smethod_0(object object_0, DynamicMetaObject dynamicMetaObject_0, DynamicMetaObject[] dynamicMetaObject_1, DynamicMetaObject dynamicMetaObject_2, Delegate985 delegate985_1)
	{
		return delegate985_1(object_0, dynamicMetaObject_0, dynamicMetaObject_1, dynamicMetaObject_2);
	}

	// Token: 0x0600273A RID: 10042
	public extern Delegate985(object object_0, IntPtr intptr_0);

	// Token: 0x0600273B RID: 10043 RVA: 0x0000E34D File Offset: 0x0000C54D
	static Delegate985()
	{
		Class15.smethod_14(typeof(Delegate985).TypeHandle);
	}

	// Token: 0x04000DB9 RID: 3513
	internal static Delegate985 delegate985_0;
}
