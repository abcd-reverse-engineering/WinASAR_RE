using System;

// Token: 0x02000347 RID: 839
internal sealed class Delegate311 : MulticastDelegate
{
	// Token: 0x06001CB0 RID: 7344
	public extern void Invoke(object object_0);

	// Token: 0x06001CB1 RID: 7345 RVA: 0x00009FFD File Offset: 0x000081FD
	public static void smethod_0(object object_0, Delegate311 delegate311_1)
	{
		delegate311_1(object_0);
	}

	// Token: 0x06001CB2 RID: 7346
	public extern Delegate311(object object_0, IntPtr intptr_0);

	// Token: 0x06001CB3 RID: 7347 RVA: 0x0000A008 File Offset: 0x00008208
	static Delegate311()
	{
		Class15.smethod_14(typeof(Delegate311).TypeHandle);
	}

	// Token: 0x04000B17 RID: 2839
	internal static Delegate311 delegate311_0;
}
