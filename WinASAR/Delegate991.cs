using System;
using System.Dynamic;

// Token: 0x020005EF RID: 1519
internal sealed class Delegate991 : MulticastDelegate
{
	// Token: 0x06002750 RID: 10064
	public extern DynamicMetaObject Invoke(object object_0, DynamicMetaObject dynamicMetaObject_0, DynamicMetaObject[] dynamicMetaObject_1, DynamicMetaObject dynamicMetaObject_2);

	// Token: 0x06002751 RID: 10065 RVA: 0x0000E3EA File Offset: 0x0000C5EA
	public static DynamicMetaObject smethod_0(object object_0, DynamicMetaObject dynamicMetaObject_0, DynamicMetaObject[] dynamicMetaObject_1, DynamicMetaObject dynamicMetaObject_2, Delegate991 delegate991_1)
	{
		return delegate991_1(object_0, dynamicMetaObject_0, dynamicMetaObject_1, dynamicMetaObject_2);
	}

	// Token: 0x06002752 RID: 10066
	public extern Delegate991(object object_0, IntPtr intptr_0);

	// Token: 0x06002753 RID: 10067 RVA: 0x0000E3FB File Offset: 0x0000C5FB
	static Delegate991()
	{
		Class15.smethod_14(typeof(Delegate991).TypeHandle);
	}

	// Token: 0x04000DBF RID: 3519
	internal static Delegate991 delegate991_0;
}
