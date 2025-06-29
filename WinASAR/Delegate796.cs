using System;

// Token: 0x0200052C RID: 1324
internal sealed class Delegate796 : MulticastDelegate
{
	// Token: 0x06002444 RID: 9284
	public extern bool Invoke(object object_0, object object_1);

	// Token: 0x06002445 RID: 9285 RVA: 0x0000D076 File Offset: 0x0000B276
	public static bool smethod_0(object object_0, object object_1, Delegate796 delegate796_1)
	{
		return delegate796_1(object_0, object_1);
	}

	// Token: 0x06002446 RID: 9286
	public extern Delegate796(object object_0, IntPtr intptr_0);

	// Token: 0x06002447 RID: 9287 RVA: 0x0000D083 File Offset: 0x0000B283
	static Delegate796()
	{
		Class15.smethod_14(typeof(Delegate796).TypeHandle);
	}

	// Token: 0x04000CFC RID: 3324
	internal static Delegate796 delegate796_0;
}
