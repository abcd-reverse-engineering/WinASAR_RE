using System;

// Token: 0x020005BF RID: 1471
internal sealed class Delegate943 : MulticastDelegate
{
	// Token: 0x06002690 RID: 9872
	public extern void Invoke(object object_0, string string_0, string string_1);

	// Token: 0x06002691 RID: 9873 RVA: 0x0000DEF0 File Offset: 0x0000C0F0
	public static void smethod_0(object object_0, string string_0, string string_1, Delegate943 delegate943_1)
	{
		delegate943_1(object_0, string_0, string_1);
	}

	// Token: 0x06002692 RID: 9874
	public extern Delegate943(object object_0, IntPtr intptr_0);

	// Token: 0x06002693 RID: 9875 RVA: 0x0000DEFF File Offset: 0x0000C0FF
	static Delegate943()
	{
		Class15.smethod_14(typeof(Delegate943).TypeHandle);
	}

	// Token: 0x04000D8F RID: 3471
	internal static Delegate943 delegate943_0;
}
