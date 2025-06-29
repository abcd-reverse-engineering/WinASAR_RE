using System;
using System.Drawing;

// Token: 0x020002FB RID: 763
internal sealed class Delegate235 : MulticastDelegate
{
	// Token: 0x06001B80 RID: 7040
	public extern Color Invoke();

	// Token: 0x06001B81 RID: 7041 RVA: 0x00009871 File Offset: 0x00007A71
	public static Color smethod_0(Delegate235 delegate235_1)
	{
		return delegate235_1();
	}

	// Token: 0x06001B82 RID: 7042
	public extern Delegate235(object object_0, IntPtr intptr_0);

	// Token: 0x06001B83 RID: 7043 RVA: 0x0000987A File Offset: 0x00007A7A
	static Delegate235()
	{
		Class15.smethod_14(typeof(Delegate235).TypeHandle);
	}

	// Token: 0x04000ACB RID: 2763
	internal static Delegate235 delegate235_0;
}
