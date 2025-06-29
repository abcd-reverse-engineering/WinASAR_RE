using System;

// Token: 0x020002ED RID: 749
internal sealed class Delegate221 : MulticastDelegate
{
	// Token: 0x06001B48 RID: 6984
	public extern void Invoke(object object_0, string string_0);

	// Token: 0x06001B49 RID: 6985 RVA: 0x00009709 File Offset: 0x00007909
	public static void smethod_0(object object_0, string string_0, Delegate221 delegate221_1)
	{
		delegate221_1(object_0, string_0);
	}

	// Token: 0x06001B4A RID: 6986
	public extern Delegate221(object object_0, IntPtr intptr_0);

	// Token: 0x06001B4B RID: 6987 RVA: 0x00009716 File Offset: 0x00007916
	static Delegate221()
	{
		Class15.smethod_14(typeof(Delegate221).TypeHandle);
	}

	// Token: 0x04000ABD RID: 2749
	internal static Delegate221 delegate221_0;
}
