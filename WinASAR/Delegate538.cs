using System;
using System.Dynamic;

// Token: 0x0200042A RID: 1066
internal sealed class Delegate538 : MulticastDelegate
{
	// Token: 0x0600203C RID: 8252
	public extern BindingRestrictions Invoke(object object_0);

	// Token: 0x0600203D RID: 8253 RVA: 0x0000B6F5 File Offset: 0x000098F5
	public static BindingRestrictions smethod_0(object object_0, Delegate538 delegate538_1)
	{
		return delegate538_1(object_0);
	}

	// Token: 0x0600203E RID: 8254
	public extern Delegate538(object object_0, IntPtr intptr_0);

	// Token: 0x0600203F RID: 8255 RVA: 0x0000B700 File Offset: 0x00009900
	static Delegate538()
	{
		Class15.smethod_14(typeof(Delegate538).TypeHandle);
	}

	// Token: 0x04000BFA RID: 3066
	internal static Delegate538 delegate538_0;
}
