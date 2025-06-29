using System;

// Token: 0x020003CD RID: 973
internal sealed class Delegate445 : MulticastDelegate
{
	// Token: 0x06001EC8 RID: 7880
	public extern TypeCode Invoke(object object_0);

	// Token: 0x06001EC9 RID: 7881 RVA: 0x0000AD91 File Offset: 0x00008F91
	public static TypeCode smethod_0(object object_0, Delegate445 delegate445_1)
	{
		return delegate445_1(object_0);
	}

	// Token: 0x06001ECA RID: 7882
	public extern Delegate445(object object_0, IntPtr intptr_0);

	// Token: 0x06001ECB RID: 7883 RVA: 0x0000AD9C File Offset: 0x00008F9C
	static Delegate445()
	{
		Class15.smethod_14(typeof(Delegate445).TypeHandle);
	}

	// Token: 0x04000B9D RID: 2973
	internal static Delegate445 delegate445_0;
}
