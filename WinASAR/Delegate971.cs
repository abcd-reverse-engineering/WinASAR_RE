using System;

// Token: 0x020005DB RID: 1499
internal sealed class Delegate971 : MulticastDelegate
{
	// Token: 0x06002700 RID: 9984
	public extern int Invoke(object object_0, byte[] byte_0, int int_0, int int_1);

	// Token: 0x06002701 RID: 9985 RVA: 0x0000E1CA File Offset: 0x0000C3CA
	public static int smethod_0(object object_0, byte[] byte_0, int int_0, int int_1, Delegate971 delegate971_1)
	{
		return delegate971_1(object_0, byte_0, int_0, int_1);
	}

	// Token: 0x06002702 RID: 9986
	public extern Delegate971(object object_0, IntPtr intptr_0);

	// Token: 0x06002703 RID: 9987 RVA: 0x0000E1DB File Offset: 0x0000C3DB
	static Delegate971()
	{
		Class15.smethod_14(typeof(Delegate971).TypeHandle);
	}

	// Token: 0x04000DAB RID: 3499
	internal static Delegate971 delegate971_0;
}
