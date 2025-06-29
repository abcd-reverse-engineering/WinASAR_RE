using System;

// Token: 0x020002A2 RID: 674
internal sealed class Delegate146 : MulticastDelegate
{
	// Token: 0x06001A1C RID: 6684
	public extern string Invoke(object object_0);

	// Token: 0x06001A1D RID: 6685 RVA: 0x00008FA3 File Offset: 0x000071A3
	public static string smethod_0(object object_0, Delegate146 delegate146_1)
	{
		return delegate146_1(object_0);
	}

	// Token: 0x06001A1E RID: 6686
	public extern Delegate146(object object_0, IntPtr intptr_0);

	// Token: 0x06001A1F RID: 6687 RVA: 0x00008FAE File Offset: 0x000071AE
	static Delegate146()
	{
		Class15.smethod_14(typeof(Delegate146).TypeHandle);
	}

	// Token: 0x04000A72 RID: 2674
	internal static Delegate146 delegate146_0;
}
