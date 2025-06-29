using System;
using System.Dynamic;

// Token: 0x0200041F RID: 1055
internal sealed class Delegate527 : MulticastDelegate
{
	// Token: 0x06002010 RID: 8208
	public extern DynamicMetaObject Invoke(object object_0, SetIndexBinder setIndexBinder_0, DynamicMetaObject[] dynamicMetaObject_0, DynamicMetaObject dynamicMetaObject_1);

	// Token: 0x06002011 RID: 8209 RVA: 0x0000B5D9 File Offset: 0x000097D9
	public static DynamicMetaObject smethod_0(object object_0, SetIndexBinder setIndexBinder_0, DynamicMetaObject[] dynamicMetaObject_0, DynamicMetaObject dynamicMetaObject_1, Delegate527 delegate527_1)
	{
		return delegate527_1(object_0, setIndexBinder_0, dynamicMetaObject_0, dynamicMetaObject_1);
	}

	// Token: 0x06002012 RID: 8210
	public extern Delegate527(object object_0, IntPtr intptr_0);

	// Token: 0x06002013 RID: 8211 RVA: 0x0000B5EA File Offset: 0x000097EA
	static Delegate527()
	{
		Class15.smethod_14(typeof(Delegate527).TypeHandle);
	}

	// Token: 0x04000BEF RID: 3055
	internal static Delegate527 delegate527_0;
}
