using System;

// Token: 0x020005AF RID: 1455
internal sealed class Delegate927 : MulticastDelegate
{
	// Token: 0x06002650 RID: 9808
	public extern void Invoke(object object_0, string string_0);

	// Token: 0x06002651 RID: 9809 RVA: 0x0000DD62 File Offset: 0x0000BF62
	public static void smethod_0(object object_0, string string_0, Delegate927 delegate927_1)
	{
		delegate927_1(object_0, string_0);
	}

	// Token: 0x06002652 RID: 9810
	public extern Delegate927(object object_0, IntPtr intptr_0);

	// Token: 0x06002653 RID: 9811 RVA: 0x0000DD6F File Offset: 0x0000BF6F
	static Delegate927()
	{
		Class15.smethod_14(typeof(Delegate927).TypeHandle);
	}

	// Token: 0x04000D7F RID: 3455
	internal static Delegate927 delegate927_0;
}
