using System;
using System.Dynamic;

// Token: 0x0200041A RID: 1050
internal sealed class Delegate522 : MulticastDelegate
{
	// Token: 0x06001FFC RID: 8188
	public extern DynamicMetaObject Invoke(object object_0, CreateInstanceBinder createInstanceBinder_0, DynamicMetaObject[] dynamicMetaObject_0);

	// Token: 0x06001FFD RID: 8189 RVA: 0x0000B54F File Offset: 0x0000974F
	public static DynamicMetaObject smethod_0(object object_0, CreateInstanceBinder createInstanceBinder_0, DynamicMetaObject[] dynamicMetaObject_0, Delegate522 delegate522_1)
	{
		return delegate522_1(object_0, createInstanceBinder_0, dynamicMetaObject_0);
	}

	// Token: 0x06001FFE RID: 8190
	public extern Delegate522(object object_0, IntPtr intptr_0);

	// Token: 0x06001FFF RID: 8191 RVA: 0x0000B55E File Offset: 0x0000975E
	static Delegate522()
	{
		Class15.smethod_14(typeof(Delegate522).TypeHandle);
	}

	// Token: 0x04000BEA RID: 3050
	internal static Delegate522 delegate522_0;
}
