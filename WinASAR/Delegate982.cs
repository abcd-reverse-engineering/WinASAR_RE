using System;
using System.Dynamic;

// Token: 0x020005E6 RID: 1510
internal sealed class Delegate982 : MulticastDelegate
{
	// Token: 0x0600272C RID: 10028
	public extern DynamicMetaObject Invoke(object object_0, DynamicMetaObject dynamicMetaObject_0, DynamicMetaObject dynamicMetaObject_1);

	// Token: 0x0600272D RID: 10029 RVA: 0x0000E2E2 File Offset: 0x0000C4E2
	public static DynamicMetaObject smethod_0(object object_0, DynamicMetaObject dynamicMetaObject_0, DynamicMetaObject dynamicMetaObject_1, Delegate982 delegate982_1)
	{
		return delegate982_1(object_0, dynamicMetaObject_0, dynamicMetaObject_1);
	}

	// Token: 0x0600272E RID: 10030
	public extern Delegate982(object object_0, IntPtr intptr_0);

	// Token: 0x0600272F RID: 10031 RVA: 0x0000E2F1 File Offset: 0x0000C4F1
	static Delegate982()
	{
		Class15.smethod_14(typeof(Delegate982).TypeHandle);
	}

	// Token: 0x04000DB6 RID: 3510
	internal static Delegate982 delegate982_0;
}
