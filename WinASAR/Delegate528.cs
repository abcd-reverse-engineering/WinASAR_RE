using System;
using System.Dynamic;

// Token: 0x02000420 RID: 1056
internal sealed class Delegate528 : MulticastDelegate
{
	// Token: 0x06002014 RID: 8212
	public extern DynamicMetaObject Invoke(object object_0, DeleteIndexBinder deleteIndexBinder_0, DynamicMetaObject[] dynamicMetaObject_0);

	// Token: 0x06002015 RID: 8213 RVA: 0x0000B5F7 File Offset: 0x000097F7
	public static DynamicMetaObject smethod_0(object object_0, DeleteIndexBinder deleteIndexBinder_0, DynamicMetaObject[] dynamicMetaObject_0, Delegate528 delegate528_1)
	{
		return delegate528_1(object_0, deleteIndexBinder_0, dynamicMetaObject_0);
	}

	// Token: 0x06002016 RID: 8214
	public extern Delegate528(object object_0, IntPtr intptr_0);

	// Token: 0x06002017 RID: 8215 RVA: 0x0000B606 File Offset: 0x00009806
	static Delegate528()
	{
		Class15.smethod_14(typeof(Delegate528).TypeHandle);
	}

	// Token: 0x04000BF0 RID: 3056
	internal static Delegate528 delegate528_0;
}
