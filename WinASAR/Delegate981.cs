using System;
using System.Dynamic;

// Token: 0x020005E5 RID: 1509
internal sealed class Delegate981 : MulticastDelegate
{
	// Token: 0x06002728 RID: 10024
	public extern DynamicMetaObject Invoke(object object_0, DynamicMetaObject dynamicMetaObject_0, DynamicMetaObject dynamicMetaObject_1, DynamicMetaObject dynamicMetaObject_2);

	// Token: 0x06002729 RID: 10025 RVA: 0x0000E2C4 File Offset: 0x0000C4C4
	public static DynamicMetaObject smethod_0(object object_0, DynamicMetaObject dynamicMetaObject_0, DynamicMetaObject dynamicMetaObject_1, DynamicMetaObject dynamicMetaObject_2, Delegate981 delegate981_1)
	{
		return delegate981_1(object_0, dynamicMetaObject_0, dynamicMetaObject_1, dynamicMetaObject_2);
	}

	// Token: 0x0600272A RID: 10026
	public extern Delegate981(object object_0, IntPtr intptr_0);

	// Token: 0x0600272B RID: 10027 RVA: 0x0000E2D5 File Offset: 0x0000C4D5
	static Delegate981()
	{
		Class15.smethod_14(typeof(Delegate981).TypeHandle);
	}

	// Token: 0x04000DB5 RID: 3509
	internal static Delegate981 delegate981_0;
}
