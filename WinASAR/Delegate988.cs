using System;
using System.Dynamic;

// Token: 0x020005EC RID: 1516
internal sealed class Delegate988 : MulticastDelegate
{
	// Token: 0x06002744 RID: 10052
	public extern DynamicMetaObject Invoke(object object_0, DynamicMetaObject dynamicMetaObject_0, DynamicMetaObject dynamicMetaObject_1);

	// Token: 0x06002745 RID: 10053 RVA: 0x0000E394 File Offset: 0x0000C594
	public static DynamicMetaObject smethod_0(object object_0, DynamicMetaObject dynamicMetaObject_0, DynamicMetaObject dynamicMetaObject_1, Delegate988 delegate988_1)
	{
		return delegate988_1(object_0, dynamicMetaObject_0, dynamicMetaObject_1);
	}

	// Token: 0x06002746 RID: 10054
	public extern Delegate988(object object_0, IntPtr intptr_0);

	// Token: 0x06002747 RID: 10055 RVA: 0x0000E3A3 File Offset: 0x0000C5A3
	static Delegate988()
	{
		Class15.smethod_14(typeof(Delegate988).TypeHandle);
	}

	// Token: 0x04000DBC RID: 3516
	internal static Delegate988 delegate988_0;
}
