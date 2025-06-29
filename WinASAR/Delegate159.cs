using System;

// Token: 0x020002AF RID: 687
internal sealed class Delegate159 : MulticastDelegate
{
	// Token: 0x06001A50 RID: 6736
	public extern bool Invoke(object object_0);

	// Token: 0x06001A51 RID: 6737 RVA: 0x000090ED File Offset: 0x000072ED
	public static bool smethod_0(object object_0, Delegate159 delegate159_1)
	{
		return delegate159_1(object_0);
	}

	// Token: 0x06001A52 RID: 6738
	public extern Delegate159(object object_0, IntPtr intptr_0);

	// Token: 0x06001A53 RID: 6739 RVA: 0x000090F8 File Offset: 0x000072F8
	static Delegate159()
	{
		Class15.smethod_14(typeof(Delegate159).TypeHandle);
	}

	// Token: 0x04000A7F RID: 2687
	internal static Delegate159 delegate159_0;
}
