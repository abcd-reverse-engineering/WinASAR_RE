using System;

// Token: 0x020005CE RID: 1486
internal sealed class Delegate958 : MulticastDelegate
{
	// Token: 0x060026CC RID: 9932
	public extern void Invoke(object object_0, long long_0);

	// Token: 0x060026CD RID: 9933 RVA: 0x0000E066 File Offset: 0x0000C266
	public static void smethod_0(object object_0, long long_0, Delegate958 delegate958_1)
	{
		delegate958_1(object_0, long_0);
	}

	// Token: 0x060026CE RID: 9934
	public extern Delegate958(object object_0, IntPtr intptr_0);

	// Token: 0x060026CF RID: 9935 RVA: 0x0000E073 File Offset: 0x0000C273
	static Delegate958()
	{
		Class15.smethod_14(typeof(Delegate958).TypeHandle);
	}

	// Token: 0x04000D9E RID: 3486
	internal static Delegate958 delegate958_0;
}
