using System;

// Token: 0x0200036E RID: 878
internal sealed class Delegate350 : MulticastDelegate
{
	// Token: 0x06001D4C RID: 7500
	public extern int Invoke(object object_0, IFormatProvider iformatProvider_0);

	// Token: 0x06001D4D RID: 7501 RVA: 0x0000A3F1 File Offset: 0x000085F1
	public static int smethod_0(object object_0, IFormatProvider iformatProvider_0, Delegate350 delegate350_1)
	{
		return delegate350_1(object_0, iformatProvider_0);
	}

	// Token: 0x06001D4E RID: 7502
	public extern Delegate350(object object_0, IntPtr intptr_0);

	// Token: 0x06001D4F RID: 7503 RVA: 0x0000A3FE File Offset: 0x000085FE
	static Delegate350()
	{
		Class15.smethod_14(typeof(Delegate350).TypeHandle);
	}

	// Token: 0x04000B3E RID: 2878
	internal static Delegate350 delegate350_0;
}
