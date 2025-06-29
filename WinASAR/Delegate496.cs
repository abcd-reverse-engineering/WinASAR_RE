using System;

// Token: 0x02000400 RID: 1024
internal sealed class Delegate496 : MulticastDelegate
{
	// Token: 0x06001F94 RID: 8084
	public extern int Invoke(ref DateTime dateTime_0);

	// Token: 0x06001F95 RID: 8085 RVA: 0x0000B2C1 File Offset: 0x000094C1
	public static int smethod_0(ref DateTime dateTime_0, Delegate496 delegate496_1)
	{
		return delegate496_1(ref dateTime_0);
	}

	// Token: 0x06001F96 RID: 8086
	public extern Delegate496(object object_0, IntPtr intptr_0);

	// Token: 0x06001F97 RID: 8087 RVA: 0x0000B2CC File Offset: 0x000094CC
	static Delegate496()
	{
		Class15.smethod_14(typeof(Delegate496).TypeHandle);
	}

	// Token: 0x04000BD0 RID: 3024
	internal static Delegate496 delegate496_0;
}
