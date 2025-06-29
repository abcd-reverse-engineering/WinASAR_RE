using System;

// Token: 0x020004D7 RID: 1239
internal sealed class Delegate711 : MulticastDelegate
{
	// Token: 0x060022F0 RID: 8944
	public extern bool Invoke(object object_0);

	// Token: 0x060022F1 RID: 8945 RVA: 0x0000C828 File Offset: 0x0000AA28
	public static bool smethod_0(object object_0, Delegate711 delegate711_1)
	{
		return delegate711_1(object_0);
	}

	// Token: 0x060022F2 RID: 8946
	public extern Delegate711(object object_0, IntPtr intptr_0);

	// Token: 0x060022F3 RID: 8947 RVA: 0x0000C833 File Offset: 0x0000AA33
	static Delegate711()
	{
		Class15.smethod_14(typeof(Delegate711).TypeHandle);
	}

	// Token: 0x04000CA7 RID: 3239
	internal static Delegate711 delegate711_0;
}
