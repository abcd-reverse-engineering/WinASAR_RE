using System;

// Token: 0x020002C9 RID: 713
internal sealed class Delegate185 : MulticastDelegate
{
	// Token: 0x06001AB8 RID: 6840
	public extern string Invoke(object object_0);

	// Token: 0x06001AB9 RID: 6841 RVA: 0x0000937D File Offset: 0x0000757D
	public static string smethod_0(object object_0, Delegate185 delegate185_1)
	{
		return delegate185_1(object_0);
	}

	// Token: 0x06001ABA RID: 6842
	public extern Delegate185(object object_0, IntPtr intptr_0);

	// Token: 0x06001ABB RID: 6843 RVA: 0x00009388 File Offset: 0x00007588
	static Delegate185()
	{
		Class15.smethod_14(typeof(Delegate185).TypeHandle);
	}

	// Token: 0x04000A99 RID: 2713
	internal static Delegate185 delegate185_0;
}
