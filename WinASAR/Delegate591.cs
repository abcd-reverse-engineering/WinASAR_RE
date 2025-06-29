using System;
using System.Dynamic;

// Token: 0x0200045F RID: 1119
internal sealed class Delegate591 : MulticastDelegate
{
	// Token: 0x06002110 RID: 8464
	public extern DynamicMetaObject Invoke(object object_0, DynamicMetaObject dynamicMetaObject_0, DynamicMetaObject[] dynamicMetaObject_1);

	// Token: 0x06002111 RID: 8465 RVA: 0x0000BC3F File Offset: 0x00009E3F
	public static DynamicMetaObject smethod_0(object object_0, DynamicMetaObject dynamicMetaObject_0, DynamicMetaObject[] dynamicMetaObject_1, Delegate591 delegate591_1)
	{
		return delegate591_1(object_0, dynamicMetaObject_0, dynamicMetaObject_1);
	}

	// Token: 0x06002112 RID: 8466
	public extern Delegate591(object object_0, IntPtr intptr_0);

	// Token: 0x06002113 RID: 8467 RVA: 0x0000BC4E File Offset: 0x00009E4E
	static Delegate591()
	{
		Class15.smethod_14(typeof(Delegate591).TypeHandle);
	}

	// Token: 0x04000C2F RID: 3119
	internal static Delegate591 delegate591_0;
}
