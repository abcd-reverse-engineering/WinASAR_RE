using System;

// Token: 0x0200026A RID: 618
internal sealed class Delegate90 : MulticastDelegate
{
	// Token: 0x0600193C RID: 6460
	public extern string Invoke(string string_0, string string_1);

	// Token: 0x0600193D RID: 6461 RVA: 0x00008A2B File Offset: 0x00006C2B
	public static string smethod_0(string string_0, string string_1, Delegate90 delegate90_1)
	{
		return delegate90_1(string_0, string_1);
	}

	// Token: 0x0600193E RID: 6462
	public extern Delegate90(object object_0, IntPtr intptr_0);

	// Token: 0x0600193F RID: 6463 RVA: 0x00008A38 File Offset: 0x00006C38
	static Delegate90()
	{
		Class15.smethod_14(typeof(Delegate90).TypeHandle);
	}

	// Token: 0x04000A3A RID: 2618
	internal static Delegate90 delegate90_0;
}
