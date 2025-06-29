using System;

// Token: 0x020002B6 RID: 694
internal sealed class Delegate166 : MulticastDelegate
{
	// Token: 0x06001A6C RID: 6764
	public extern int Invoke(object object_0, int int_0);

	// Token: 0x06001A6D RID: 6765 RVA: 0x0000919D File Offset: 0x0000739D
	public static int smethod_0(object object_0, int int_0, Delegate166 delegate166_1)
	{
		return delegate166_1(object_0, int_0);
	}

	// Token: 0x06001A6E RID: 6766
	public extern Delegate166(object object_0, IntPtr intptr_0);

	// Token: 0x06001A6F RID: 6767 RVA: 0x000091AA File Offset: 0x000073AA
	static Delegate166()
	{
		Class15.smethod_14(typeof(Delegate166).TypeHandle);
	}

	// Token: 0x04000A86 RID: 2694
	internal static Delegate166 delegate166_0;
}
