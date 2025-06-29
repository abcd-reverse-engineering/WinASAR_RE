using System;

// Token: 0x020002DF RID: 735
internal sealed class Delegate207 : MulticastDelegate
{
	// Token: 0x06001B10 RID: 6928
	public extern int Invoke(object object_0);

	// Token: 0x06001B11 RID: 6929 RVA: 0x000095AB File Offset: 0x000077AB
	public static int smethod_0(object object_0, Delegate207 delegate207_1)
	{
		return delegate207_1(object_0);
	}

	// Token: 0x06001B12 RID: 6930
	public extern Delegate207(object object_0, IntPtr intptr_0);

	// Token: 0x06001B13 RID: 6931 RVA: 0x000095B6 File Offset: 0x000077B6
	static Delegate207()
	{
		Class15.smethod_14(typeof(Delegate207).TypeHandle);
	}

	// Token: 0x04000AAF RID: 2735
	internal static Delegate207 delegate207_0;
}
