using System;

// Token: 0x020004E6 RID: 1254
internal sealed class Delegate726 : MulticastDelegate
{
	// Token: 0x0600232C RID: 9004
	public extern AppDomain Invoke();

	// Token: 0x0600232D RID: 9005 RVA: 0x0000C99C File Offset: 0x0000AB9C
	public static AppDomain smethod_0(Delegate726 delegate726_1)
	{
		return delegate726_1();
	}

	// Token: 0x0600232E RID: 9006
	public extern Delegate726(object object_0, IntPtr intptr_0);

	// Token: 0x0600232F RID: 9007 RVA: 0x0000C9A5 File Offset: 0x0000ABA5
	static Delegate726()
	{
		Class15.smethod_14(typeof(Delegate726).TypeHandle);
	}

	// Token: 0x04000CB6 RID: 3254
	internal static Delegate726 delegate726_0;
}
