using System;
using System.Dynamic;

// Token: 0x0200041E RID: 1054
internal sealed class Delegate526 : MulticastDelegate
{
	// Token: 0x0600200C RID: 8204
	public extern DynamicMetaObject Invoke(object object_0, GetIndexBinder getIndexBinder_0, DynamicMetaObject[] dynamicMetaObject_0);

	// Token: 0x0600200D RID: 8205 RVA: 0x0000B5BD File Offset: 0x000097BD
	public static DynamicMetaObject smethod_0(object object_0, GetIndexBinder getIndexBinder_0, DynamicMetaObject[] dynamicMetaObject_0, Delegate526 delegate526_1)
	{
		return delegate526_1(object_0, getIndexBinder_0, dynamicMetaObject_0);
	}

	// Token: 0x0600200E RID: 8206
	public extern Delegate526(object object_0, IntPtr intptr_0);

	// Token: 0x0600200F RID: 8207 RVA: 0x0000B5CC File Offset: 0x000097CC
	static Delegate526()
	{
		Class15.smethod_14(typeof(Delegate526).TypeHandle);
	}

	// Token: 0x04000BEE RID: 3054
	internal static Delegate526 delegate526_0;
}
