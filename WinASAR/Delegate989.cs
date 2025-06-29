using System;
using System.Dynamic;

// Token: 0x020005ED RID: 1517
internal sealed class Delegate989 : MulticastDelegate
{
	// Token: 0x06002748 RID: 10056
	public extern DynamicMetaObject Invoke(object object_0, DynamicMetaObject dynamicMetaObject_0, DynamicMetaObject dynamicMetaObject_1);

	// Token: 0x06002749 RID: 10057 RVA: 0x0000E3B0 File Offset: 0x0000C5B0
	public static DynamicMetaObject smethod_0(object object_0, DynamicMetaObject dynamicMetaObject_0, DynamicMetaObject dynamicMetaObject_1, Delegate989 delegate989_1)
	{
		return delegate989_1(object_0, dynamicMetaObject_0, dynamicMetaObject_1);
	}

	// Token: 0x0600274A RID: 10058
	public extern Delegate989(object object_0, IntPtr intptr_0);

	// Token: 0x0600274B RID: 10059 RVA: 0x0000E3BF File Offset: 0x0000C5BF
	static Delegate989()
	{
		Class15.smethod_14(typeof(Delegate989).TypeHandle);
	}

	// Token: 0x04000DBD RID: 3517
	internal static Delegate989 delegate989_0;
}
