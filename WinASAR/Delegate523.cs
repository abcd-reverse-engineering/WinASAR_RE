using System;
using System.Dynamic;

// Token: 0x0200041B RID: 1051
internal sealed class Delegate523 : MulticastDelegate
{
	// Token: 0x06002000 RID: 8192
	public extern DynamicMetaObject Invoke(object object_0, InvokeBinder invokeBinder_0, DynamicMetaObject[] dynamicMetaObject_0);

	// Token: 0x06002001 RID: 8193 RVA: 0x0000B56B File Offset: 0x0000976B
	public static DynamicMetaObject smethod_0(object object_0, InvokeBinder invokeBinder_0, DynamicMetaObject[] dynamicMetaObject_0, Delegate523 delegate523_0)
	{
		return delegate523_0(object_0, invokeBinder_0, dynamicMetaObject_0);
	}

	// Token: 0x06002002 RID: 8194
	public extern Delegate523(object object_0, IntPtr intptr_0);

	// Token: 0x06002003 RID: 8195 RVA: 0x0000B57A File Offset: 0x0000977A
	static Delegate523()
	{
		Class15.smethod_14(typeof(Delegate523).TypeHandle);
	}

	// Token: 0x04000BEB RID: 3051
	internal static Delegate523 xCkmpaWaqP;
}
