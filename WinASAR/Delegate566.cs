using System;

// Token: 0x02000446 RID: 1094
internal sealed class Delegate566 : MulticastDelegate
{
	// Token: 0x060020AC RID: 8364
	public extern bool Invoke(object object_0);

	// Token: 0x060020AD RID: 8365 RVA: 0x0000B9BF File Offset: 0x00009BBF
	public static bool smethod_0(object object_0, Delegate566 delegate566_1)
	{
		return delegate566_1(object_0);
	}

	// Token: 0x060020AE RID: 8366
	public extern Delegate566(object object_0, IntPtr intptr_0);

	// Token: 0x060020AF RID: 8367 RVA: 0x0000B9CA File Offset: 0x00009BCA
	static Delegate566()
	{
		Class15.smethod_14(typeof(Delegate566).TypeHandle);
	}

	// Token: 0x04000C16 RID: 3094
	internal static Delegate566 delegate566_0;
}
