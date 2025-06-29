using System;
using System.Windows.Forms;

// Token: 0x02000304 RID: 772
internal sealed class Delegate244 : MulticastDelegate
{
	// Token: 0x06001BA4 RID: 7076
	public extern void Invoke(object object_0, ContextMenuStrip contextMenuStrip_0);

	// Token: 0x06001BA5 RID: 7077 RVA: 0x00009957 File Offset: 0x00007B57
	public static void smethod_0(object object_0, ContextMenuStrip contextMenuStrip_0, Delegate244 delegate244_1)
	{
		delegate244_1(object_0, contextMenuStrip_0);
	}

	// Token: 0x06001BA6 RID: 7078
	public extern Delegate244(object object_0, IntPtr intptr_0);

	// Token: 0x06001BA7 RID: 7079 RVA: 0x00009964 File Offset: 0x00007B64
	static Delegate244()
	{
		Class15.smethod_14(typeof(Delegate244).TypeHandle);
	}

	// Token: 0x04000AD4 RID: 2772
	internal static Delegate244 delegate244_0;
}
