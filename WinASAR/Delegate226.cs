using System;
using System.Drawing;

// Token: 0x020002F2 RID: 754
internal sealed class Delegate226 : MulticastDelegate
{
	// Token: 0x06001B5C RID: 7004
	public extern void Invoke(object object_0, Color color_0);

	// Token: 0x06001B5D RID: 7005 RVA: 0x00009787 File Offset: 0x00007987
	public static void smethod_0(object object_0, Color color_0, Delegate226 delegate226_1)
	{
		delegate226_1(object_0, color_0);
	}

	// Token: 0x06001B5E RID: 7006
	public extern Delegate226(object object_0, IntPtr intptr_0);

	// Token: 0x06001B5F RID: 7007 RVA: 0x00009794 File Offset: 0x00007994
	static Delegate226()
	{
		Class15.smethod_14(typeof(Delegate226).TypeHandle);
	}

	// Token: 0x04000AC2 RID: 2754
	internal static Delegate226 delegate226_0;
}
