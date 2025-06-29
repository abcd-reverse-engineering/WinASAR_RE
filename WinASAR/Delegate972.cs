using System;

// Token: 0x020005DC RID: 1500
internal sealed class Delegate972 : MulticastDelegate
{
	// Token: 0x06002704 RID: 9988
	public extern int Invoke(object object_0, int int_0);

	// Token: 0x06002705 RID: 9989 RVA: 0x0000E1E8 File Offset: 0x0000C3E8
	public static int smethod_0(object object_0, int int_0, Delegate972 delegate972_1)
	{
		return delegate972_1(object_0, int_0);
	}

	// Token: 0x06002706 RID: 9990
	public extern Delegate972(object object_0, IntPtr intptr_0);

	// Token: 0x06002707 RID: 9991 RVA: 0x0000E1F5 File Offset: 0x0000C3F5
	static Delegate972()
	{
		Class15.smethod_14(typeof(Delegate972).TypeHandle);
	}

	// Token: 0x04000DAC RID: 3500
	internal static Delegate972 delegate972_0;
}
