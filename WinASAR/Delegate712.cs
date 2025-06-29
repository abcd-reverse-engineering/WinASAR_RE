using System;

// Token: 0x020004D8 RID: 1240
internal sealed class Delegate712 : MulticastDelegate
{
	// Token: 0x060022F4 RID: 8948
	public extern bool Invoke(object object_0);

	// Token: 0x060022F5 RID: 8949 RVA: 0x0000C840 File Offset: 0x0000AA40
	public static bool smethod_0(object object_0, Delegate712 delegate712_1)
	{
		return delegate712_1(object_0);
	}

	// Token: 0x060022F6 RID: 8950
	public extern Delegate712(object object_0, IntPtr intptr_0);

	// Token: 0x060022F7 RID: 8951 RVA: 0x0000C84B File Offset: 0x0000AA4B
	static Delegate712()
	{
		Class15.smethod_14(typeof(Delegate712).TypeHandle);
	}

	// Token: 0x04000CA8 RID: 3240
	internal static Delegate712 delegate712_0;
}
