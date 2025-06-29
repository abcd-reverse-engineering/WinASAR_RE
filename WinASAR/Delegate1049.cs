using System;

// Token: 0x02000629 RID: 1577
internal sealed class Delegate1049 : MulticastDelegate
{
	// Token: 0x06002838 RID: 10296
	public extern object Invoke(object object_0, Type type_0);

	// Token: 0x06002839 RID: 10297 RVA: 0x0000E99A File Offset: 0x0000CB9A
	public static object smethod_0(object object_0, Type type_0, Delegate1049 delegate1049_1)
	{
		return delegate1049_1(object_0, type_0);
	}

	// Token: 0x0600283A RID: 10298
	public extern Delegate1049(object object_0, IntPtr intptr_0);

	// Token: 0x0600283B RID: 10299 RVA: 0x0000E9A7 File Offset: 0x0000CBA7
	static Delegate1049()
	{
		Class15.smethod_14(typeof(Delegate1049).TypeHandle);
	}

	// Token: 0x04000DF9 RID: 3577
	internal static Delegate1049 delegate1049_0;
}
