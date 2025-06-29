using System;
using System.Text;

// Token: 0x0200046D RID: 1133
internal sealed class Delegate605 : MulticastDelegate
{
	// Token: 0x06002148 RID: 8520
	public extern StringBuilder Invoke(object object_0, int int_0, string string_0);

	// Token: 0x06002149 RID: 8521 RVA: 0x0000BDA1 File Offset: 0x00009FA1
	public static StringBuilder smethod_0(object object_0, int int_0, string string_0, Delegate605 delegate605_1)
	{
		return delegate605_1(object_0, int_0, string_0);
	}

	// Token: 0x0600214A RID: 8522
	public extern Delegate605(object object_0, IntPtr intptr_0);

	// Token: 0x0600214B RID: 8523 RVA: 0x0000BDB0 File Offset: 0x00009FB0
	static Delegate605()
	{
		Class15.smethod_14(typeof(Delegate605).TypeHandle);
	}

	// Token: 0x04000C3D RID: 3133
	internal static Delegate605 delegate605_0;
}
