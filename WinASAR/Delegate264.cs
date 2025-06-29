using System;

// Token: 0x02000318 RID: 792
internal sealed class Delegate264 : MulticastDelegate
{
	// Token: 0x06001BF4 RID: 7156
	public extern string Invoke(object object_0);

	// Token: 0x06001BF5 RID: 7157 RVA: 0x00009B43 File Offset: 0x00007D43
	public static string smethod_0(object object_0, Delegate264 delegate264_1)
	{
		return delegate264_1(object_0);
	}

	// Token: 0x06001BF6 RID: 7158
	public extern Delegate264(object object_0, IntPtr intptr_0);

	// Token: 0x06001BF7 RID: 7159 RVA: 0x00009B4E File Offset: 0x00007D4E
	static Delegate264()
	{
		Class15.smethod_14(typeof(Delegate264).TypeHandle);
	}

	// Token: 0x04000AE8 RID: 2792
	internal static Delegate264 delegate264_0;
}
