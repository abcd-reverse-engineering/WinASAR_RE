using System;

// Token: 0x0200037D RID: 893
internal sealed class Delegate365 : MulticastDelegate
{
	// Token: 0x06001D88 RID: 7560
	public extern char[] Invoke(object object_0);

	// Token: 0x06001D89 RID: 7561 RVA: 0x0000A57D File Offset: 0x0000877D
	public static char[] smethod_0(object object_0, Delegate365 delegate365_1)
	{
		return delegate365_1(object_0);
	}

	// Token: 0x06001D8A RID: 7562
	public extern Delegate365(object object_0, IntPtr intptr_0);

	// Token: 0x06001D8B RID: 7563 RVA: 0x0000A588 File Offset: 0x00008788
	static Delegate365()
	{
		Class15.smethod_14(typeof(Delegate365).TypeHandle);
	}

	// Token: 0x04000B4D RID: 2893
	internal static Delegate365 delegate365_0;
}
