using System;
using System.Windows.Forms;

// Token: 0x0200030B RID: 779
internal sealed class Delegate251 : MulticastDelegate
{
	// Token: 0x06001BC0 RID: 7104
	public extern void Invoke(object object_0, MenuStrip menuStrip_0);

	// Token: 0x06001BC1 RID: 7105 RVA: 0x00009A0D File Offset: 0x00007C0D
	public static void smethod_0(object object_0, MenuStrip menuStrip_0, Delegate251 delegate251_1)
	{
		delegate251_1(object_0, menuStrip_0);
	}

	// Token: 0x06001BC2 RID: 7106
	public extern Delegate251(object object_0, IntPtr intptr_0);

	// Token: 0x06001BC3 RID: 7107 RVA: 0x00009A1A File Offset: 0x00007C1A
	static Delegate251()
	{
		Class15.smethod_14(typeof(Delegate251).TypeHandle);
	}

	// Token: 0x04000ADB RID: 2779
	internal static Delegate251 delegate251_0;
}
