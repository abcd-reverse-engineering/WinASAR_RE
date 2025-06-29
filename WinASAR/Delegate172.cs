using System;
using System.Windows.Forms;

// Token: 0x020002BC RID: 700
internal sealed class Delegate172 : MulticastDelegate
{
	// Token: 0x06001A84 RID: 6788
	public extern DialogResult Invoke(object object_0, IWin32Window iwin32Window_0);

	// Token: 0x06001A85 RID: 6789 RVA: 0x00009235 File Offset: 0x00007435
	public static DialogResult smethod_0(object object_0, IWin32Window iwin32Window_0, Delegate172 delegate172_1)
	{
		return delegate172_1(object_0, iwin32Window_0);
	}

	// Token: 0x06001A86 RID: 6790
	public extern Delegate172(object object_0, IntPtr intptr_0);

	// Token: 0x06001A87 RID: 6791 RVA: 0x00009242 File Offset: 0x00007442
	static Delegate172()
	{
		Class15.smethod_14(typeof(Delegate172).TypeHandle);
	}

	// Token: 0x04000A8C RID: 2700
	internal static Delegate172 delegate172_0;
}
