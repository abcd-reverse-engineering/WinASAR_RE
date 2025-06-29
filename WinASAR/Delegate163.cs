using System;

// Token: 0x020002B3 RID: 691
internal sealed class Delegate163 : MulticastDelegate
{
	// Token: 0x06001A60 RID: 6752
	public extern int Invoke(object object_0);

	// Token: 0x06001A61 RID: 6753 RVA: 0x00009153 File Offset: 0x00007353
	public static int smethod_0(object object_0, Delegate163 delegate163_1)
	{
		return delegate163_1(object_0);
	}

	// Token: 0x06001A62 RID: 6754
	public extern Delegate163(object object_0, IntPtr intptr_0);

	// Token: 0x06001A63 RID: 6755 RVA: 0x0000915E File Offset: 0x0000735E
	static Delegate163()
	{
		Class15.smethod_14(typeof(Delegate163).TypeHandle);
	}

	// Token: 0x04000A83 RID: 2691
	internal static Delegate163 delegate163_0;
}
