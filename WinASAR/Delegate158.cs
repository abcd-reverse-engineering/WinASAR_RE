using System;

// Token: 0x020002AE RID: 686
internal sealed class Delegate158 : MulticastDelegate
{
	// Token: 0x06001A4C RID: 6732
	public extern bool Invoke(object object_0, string string_0);

	// Token: 0x06001A4D RID: 6733 RVA: 0x000090D3 File Offset: 0x000072D3
	public static bool smethod_0(object object_0, string string_0, Delegate158 delegate158_1)
	{
		return delegate158_1(object_0, string_0);
	}

	// Token: 0x06001A4E RID: 6734
	public extern Delegate158(object object_0, IntPtr intptr_0);

	// Token: 0x06001A4F RID: 6735 RVA: 0x000090E0 File Offset: 0x000072E0
	static Delegate158()
	{
		Class15.smethod_14(typeof(Delegate158).TypeHandle);
	}

	// Token: 0x04000A7E RID: 2686
	internal static Delegate158 delegate158_0;
}
