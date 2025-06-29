using System;

// Token: 0x02000627 RID: 1575
internal sealed class Delegate1047 : MulticastDelegate
{
	// Token: 0x06002830 RID: 10288
	public extern Type Invoke(object object_0);

	// Token: 0x06002831 RID: 10289 RVA: 0x0000E966 File Offset: 0x0000CB66
	public static Type smethod_0(object object_0, Delegate1047 delegate1047_1)
	{
		return delegate1047_1(object_0);
	}

	// Token: 0x06002832 RID: 10290
	public extern Delegate1047(object object_0, IntPtr intptr_0);

	// Token: 0x06002833 RID: 10291 RVA: 0x0000E971 File Offset: 0x0000CB71
	static Delegate1047()
	{
		Class15.smethod_14(typeof(Delegate1047).TypeHandle);
	}

	// Token: 0x04000DF7 RID: 3575
	internal static Delegate1047 delegate1047_0;
}
