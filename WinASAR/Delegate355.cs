using System;

// Token: 0x02000373 RID: 883
internal sealed class Delegate355 : MulticastDelegate
{
	// Token: 0x06001D60 RID: 7520
	public extern byte Invoke(object object_0, IFormatProvider iformatProvider_0);

	// Token: 0x06001D61 RID: 7521 RVA: 0x0000A475 File Offset: 0x00008675
	public static byte smethod_0(object object_0, IFormatProvider iformatProvider_0, Delegate355 delegate355_1)
	{
		return delegate355_1(object_0, iformatProvider_0);
	}

	// Token: 0x06001D62 RID: 7522
	public extern Delegate355(object object_0, IntPtr intptr_0);

	// Token: 0x06001D63 RID: 7523 RVA: 0x0000A482 File Offset: 0x00008682
	static Delegate355()
	{
		Class15.smethod_14(typeof(Delegate355).TypeHandle);
	}

	// Token: 0x04000B43 RID: 2883
	internal static Delegate355 delegate355_0;
}
