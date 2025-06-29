using System;

// Token: 0x02000572 RID: 1394
internal sealed class Delegate866 : MulticastDelegate
{
	// Token: 0x0600255C RID: 9564
	public extern string Invoke(object object_0, string string_0);

	// Token: 0x0600255D RID: 9565 RVA: 0x0000D78E File Offset: 0x0000B98E
	public static string smethod_0(object object_0, string string_0, Delegate866 delegate866_1)
	{
		return delegate866_1(object_0, string_0);
	}

	// Token: 0x0600255E RID: 9566
	public extern Delegate866(object object_0, IntPtr intptr_0);

	// Token: 0x0600255F RID: 9567 RVA: 0x0000D79B File Offset: 0x0000B99B
	static Delegate866()
	{
		Class15.smethod_14(typeof(Delegate866).TypeHandle);
	}

	// Token: 0x04000D42 RID: 3394
	internal static Delegate866 delegate866_0;
}
