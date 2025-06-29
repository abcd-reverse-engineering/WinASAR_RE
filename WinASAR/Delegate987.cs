using System;
using System.Dynamic;

// Token: 0x020005EB RID: 1515
internal sealed class Delegate987 : MulticastDelegate
{
	// Token: 0x06002740 RID: 10048
	public extern DynamicMetaObject Invoke(object object_0, DynamicMetaObject dynamicMetaObject_0, DynamicMetaObject dynamicMetaObject_1, DynamicMetaObject dynamicMetaObject_2);

	// Token: 0x06002741 RID: 10049 RVA: 0x0000E376 File Offset: 0x0000C576
	public static DynamicMetaObject smethod_0(object object_0, DynamicMetaObject dynamicMetaObject_0, DynamicMetaObject dynamicMetaObject_1, DynamicMetaObject dynamicMetaObject_2, Delegate987 delegate987_1)
	{
		return delegate987_1(object_0, dynamicMetaObject_0, dynamicMetaObject_1, dynamicMetaObject_2);
	}

	// Token: 0x06002742 RID: 10050
	public extern Delegate987(object object_0, IntPtr intptr_0);

	// Token: 0x06002743 RID: 10051 RVA: 0x0000E387 File Offset: 0x0000C587
	static Delegate987()
	{
		Class15.smethod_14(typeof(Delegate987).TypeHandle);
	}

	// Token: 0x04000DBB RID: 3515
	internal static Delegate987 delegate987_0;
}
