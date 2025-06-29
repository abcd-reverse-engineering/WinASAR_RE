using System;

// Token: 0x02000375 RID: 885
internal sealed class Delegate357 : MulticastDelegate
{
	// Token: 0x06001D68 RID: 7528
	public extern double Invoke(object object_0, IFormatProvider iformatProvider_0);

	// Token: 0x06001D69 RID: 7529 RVA: 0x0000A4A7 File Offset: 0x000086A7
	public static double smethod_0(object object_0, IFormatProvider iformatProvider_0, Delegate357 delegate357_1)
	{
		return delegate357_1(object_0, iformatProvider_0);
	}

	// Token: 0x06001D6A RID: 7530
	public extern Delegate357(object object_0, IntPtr intptr_0);

	// Token: 0x06001D6B RID: 7531 RVA: 0x0000A4B4 File Offset: 0x000086B4
	static Delegate357()
	{
		Class15.smethod_14(typeof(Delegate357).TypeHandle);
	}

	// Token: 0x04000B45 RID: 2885
	internal static Delegate357 delegate357_0;
}
