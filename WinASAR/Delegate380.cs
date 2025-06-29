using System;

// Token: 0x0200038C RID: 908
internal sealed class Delegate380 : MulticastDelegate
{
	// Token: 0x06001DC4 RID: 7620
	public extern bool Invoke(char char_0);

	// Token: 0x06001DC5 RID: 7621 RVA: 0x0000A70D File Offset: 0x0000890D
	public static bool smethod_0(char char_0, Delegate380 delegate380_1)
	{
		return delegate380_1(char_0);
	}

	// Token: 0x06001DC6 RID: 7622
	public extern Delegate380(object object_0, IntPtr intptr_0);

	// Token: 0x06001DC7 RID: 7623 RVA: 0x0000A718 File Offset: 0x00008918
	static Delegate380()
	{
		Class15.smethod_14(typeof(Delegate380).TypeHandle);
	}

	// Token: 0x04000B5C RID: 2908
	internal static Delegate380 delegate380_0;
}
