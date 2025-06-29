using System;

// Token: 0x0200061B RID: 1563
internal sealed class Delegate1035 : MulticastDelegate
{
	// Token: 0x06002800 RID: 10240
	public extern Exception Invoke(object object_0);

	// Token: 0x06002801 RID: 10241 RVA: 0x0000E836 File Offset: 0x0000CA36
	public static Exception smethod_0(object object_0, Delegate1035 delegate1035_1)
	{
		return delegate1035_1(object_0);
	}

	// Token: 0x06002802 RID: 10242
	public extern Delegate1035(object object_0, IntPtr intptr_0);

	// Token: 0x06002803 RID: 10243 RVA: 0x0000E841 File Offset: 0x0000CA41
	static Delegate1035()
	{
		Class15.smethod_14(typeof(Delegate1035).TypeHandle);
	}

	// Token: 0x04000DEB RID: 3563
	internal static Delegate1035 delegate1035_0;
}
