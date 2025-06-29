using System;
using System.Dynamic;

// Token: 0x020005EE RID: 1518
internal sealed class Delegate990 : MulticastDelegate
{
	// Token: 0x0600274C RID: 10060
	public extern DynamicMetaObject Invoke(object object_0, DynamicMetaObject dynamicMetaObject_0, DynamicMetaObject[] dynamicMetaObject_1, DynamicMetaObject dynamicMetaObject_2);

	// Token: 0x0600274D RID: 10061 RVA: 0x0000E3CC File Offset: 0x0000C5CC
	public static DynamicMetaObject smethod_0(object object_0, DynamicMetaObject dynamicMetaObject_0, DynamicMetaObject[] dynamicMetaObject_1, DynamicMetaObject dynamicMetaObject_2, Delegate990 delegate990_1)
	{
		return delegate990_1(object_0, dynamicMetaObject_0, dynamicMetaObject_1, dynamicMetaObject_2);
	}

	// Token: 0x0600274E RID: 10062
	public extern Delegate990(object object_0, IntPtr intptr_0);

	// Token: 0x0600274F RID: 10063 RVA: 0x0000E3DD File Offset: 0x0000C5DD
	static Delegate990()
	{
		Class15.smethod_14(typeof(Delegate990).TypeHandle);
	}

	// Token: 0x04000DBE RID: 3518
	internal static Delegate990 delegate990_0;
}
