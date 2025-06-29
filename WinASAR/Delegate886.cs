using System;

// Token: 0x02000586 RID: 1414
internal sealed class Delegate886 : MulticastDelegate
{
	// Token: 0x060025AC RID: 9644
	public extern bool Invoke(object object_0);

	// Token: 0x060025AD RID: 9645 RVA: 0x0000D974 File Offset: 0x0000BB74
	public static bool smethod_0(object object_0, Delegate886 delegate886_1)
	{
		return delegate886_1(object_0);
	}

	// Token: 0x060025AE RID: 9646
	public extern Delegate886(object object_0, IntPtr intptr_0);

	// Token: 0x060025AF RID: 9647 RVA: 0x0000D97F File Offset: 0x0000BB7F
	static Delegate886()
	{
		Class15.smethod_14(typeof(Delegate886).TypeHandle);
	}

	// Token: 0x04000D56 RID: 3414
	internal static Delegate886 delegate886_0;
}
