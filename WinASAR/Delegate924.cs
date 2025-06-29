using System;

// Token: 0x020005AC RID: 1452
internal sealed class Delegate924 : MulticastDelegate
{
	// Token: 0x06002644 RID: 9796
	public extern bool Invoke(object object_0);

	// Token: 0x06002645 RID: 9797 RVA: 0x0000DD1A File Offset: 0x0000BF1A
	public static bool smethod_0(object object_0, Delegate924 delegate924_1)
	{
		return delegate924_1(object_0);
	}

	// Token: 0x06002646 RID: 9798
	public extern Delegate924(object object_0, IntPtr intptr_0);

	// Token: 0x06002647 RID: 9799 RVA: 0x0000DD25 File Offset: 0x0000BF25
	static Delegate924()
	{
		Class15.smethod_14(typeof(Delegate924).TypeHandle);
	}

	// Token: 0x04000D7C RID: 3452
	internal static Delegate924 delegate924_0;
}
