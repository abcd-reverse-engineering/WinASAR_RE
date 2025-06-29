using System;
using System.Dynamic;

// Token: 0x020005E8 RID: 1512
internal sealed class Delegate984 : MulticastDelegate
{
	// Token: 0x06002734 RID: 10036
	public extern DynamicMetaObject Invoke(object object_0, DynamicMetaObject dynamicMetaObject_0, DynamicMetaObject[] dynamicMetaObject_1, DynamicMetaObject dynamicMetaObject_2, DynamicMetaObject dynamicMetaObject_3);

	// Token: 0x06002735 RID: 10037 RVA: 0x0000E31C File Offset: 0x0000C51C
	public static DynamicMetaObject smethod_0(object object_0, DynamicMetaObject dynamicMetaObject_0, DynamicMetaObject[] dynamicMetaObject_1, DynamicMetaObject dynamicMetaObject_2, DynamicMetaObject dynamicMetaObject_3, Delegate984 delegate984_1)
	{
		return delegate984_1(object_0, dynamicMetaObject_0, dynamicMetaObject_1, dynamicMetaObject_2, dynamicMetaObject_3);
	}

	// Token: 0x06002736 RID: 10038
	public extern Delegate984(object object_0, IntPtr intptr_0);

	// Token: 0x06002737 RID: 10039 RVA: 0x0000E32F File Offset: 0x0000C52F
	static Delegate984()
	{
		Class15.smethod_14(typeof(Delegate984).TypeHandle);
	}

	// Token: 0x04000DB8 RID: 3512
	internal static Delegate984 delegate984_0;
}
