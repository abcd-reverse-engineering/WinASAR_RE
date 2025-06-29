using System;
using System.Drawing;

// Token: 0x020002FC RID: 764
internal sealed class Delegate236 : MulticastDelegate
{
	// Token: 0x06001B84 RID: 7044
	public extern void Invoke(object object_0, Color color_0);

	// Token: 0x06001B85 RID: 7045 RVA: 0x00009887 File Offset: 0x00007A87
	public static void smethod_0(object object_0, Color color_0, Delegate236 delegate236_1)
	{
		delegate236_1(object_0, color_0);
	}

	// Token: 0x06001B86 RID: 7046
	public extern Delegate236(object object_0, IntPtr intptr_0);

	// Token: 0x06001B87 RID: 7047 RVA: 0x00009894 File Offset: 0x00007A94
	static Delegate236()
	{
		Class15.smethod_14(typeof(Delegate236).TypeHandle);
	}

	// Token: 0x04000ACC RID: 2764
	internal static Delegate236 delegate236_0;
}
