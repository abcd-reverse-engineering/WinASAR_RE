using System;
using System.Windows.Forms;

// Token: 0x0200032C RID: 812
internal sealed class Delegate284 : MulticastDelegate
{
	// Token: 0x06001C44 RID: 7236
	public extern DialogResult Invoke(object object_0, IWin32Window iwin32Window_0);

	// Token: 0x06001C45 RID: 7237 RVA: 0x00009D43 File Offset: 0x00007F43
	public static DialogResult smethod_0(object object_0, IWin32Window iwin32Window_0, Delegate284 delegate284_1)
	{
		return delegate284_1(object_0, iwin32Window_0);
	}

	// Token: 0x06001C46 RID: 7238
	public extern Delegate284(object object_0, IntPtr intptr_0);

	// Token: 0x06001C47 RID: 7239 RVA: 0x00009D50 File Offset: 0x00007F50
	static Delegate284()
	{
		Class15.smethod_14(typeof(Delegate284).TypeHandle);
	}

	// Token: 0x04000AFC RID: 2812
	internal static Delegate284 delegate284_0;
}
