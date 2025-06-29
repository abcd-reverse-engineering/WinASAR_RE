using System;

// Token: 0x020004F4 RID: 1268
internal sealed class Delegate740 : MulticastDelegate
{
	// Token: 0x06002364 RID: 9060
	public extern object Invoke(Type type_0);

	// Token: 0x06002365 RID: 9061 RVA: 0x0000CAF4 File Offset: 0x0000ACF4
	public static object smethod_0(Type type_0, Delegate740 delegate740_1)
	{
		return delegate740_1(type_0);
	}

	// Token: 0x06002366 RID: 9062
	public extern Delegate740(object object_0, IntPtr intptr_0);

	// Token: 0x06002367 RID: 9063 RVA: 0x0000CAFF File Offset: 0x0000ACFF
	static Delegate740()
	{
		Class15.smethod_14(typeof(Delegate740).TypeHandle);
	}

	// Token: 0x04000CC4 RID: 3268
	internal static Delegate740 delegate740_0;
}
