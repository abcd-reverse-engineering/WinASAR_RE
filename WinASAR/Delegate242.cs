using System;
using System.Drawing;

// Token: 0x02000302 RID: 770
internal sealed class Delegate242 : MulticastDelegate
{
	// Token: 0x06001B9C RID: 7068
	public extern void Invoke(object object_0, Color color_0);

	// Token: 0x06001B9D RID: 7069 RVA: 0x00009923 File Offset: 0x00007B23
	public static void smethod_0(object object_0, Color color_0, Delegate242 delegate242_1)
	{
		delegate242_1(object_0, color_0);
	}

	// Token: 0x06001B9E RID: 7070
	public extern Delegate242(object object_0, IntPtr intptr_0);

	// Token: 0x06001B9F RID: 7071 RVA: 0x00009930 File Offset: 0x00007B30
	static Delegate242()
	{
		Class15.smethod_14(typeof(Delegate242).TypeHandle);
	}

	// Token: 0x04000AD2 RID: 2770
	internal static Delegate242 delegate242_0;
}
