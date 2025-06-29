using System;
using System.Dynamic;

// Token: 0x02000419 RID: 1049
internal sealed class Delegate521 : MulticastDelegate
{
	// Token: 0x06001FF8 RID: 8184
	public extern DynamicMetaObject Invoke(object object_0, InvokeMemberBinder invokeMemberBinder_0, DynamicMetaObject[] dynamicMetaObject_0);

	// Token: 0x06001FF9 RID: 8185 RVA: 0x0000B533 File Offset: 0x00009733
	public static DynamicMetaObject smethod_0(object object_0, InvokeMemberBinder invokeMemberBinder_0, DynamicMetaObject[] dynamicMetaObject_0, Delegate521 delegate521_1)
	{
		return delegate521_1(object_0, invokeMemberBinder_0, dynamicMetaObject_0);
	}

	// Token: 0x06001FFA RID: 8186
	public extern Delegate521(object object_0, IntPtr intptr_0);

	// Token: 0x06001FFB RID: 8187 RVA: 0x0000B542 File Offset: 0x00009742
	static Delegate521()
	{
		Class15.smethod_14(typeof(Delegate521).TypeHandle);
	}

	// Token: 0x04000BE9 RID: 3049
	internal static Delegate521 delegate521_0;
}
