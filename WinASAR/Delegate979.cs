using System;

// Token: 0x020005E3 RID: 1507
internal sealed class Delegate979 : MulticastDelegate
{
	// Token: 0x06002720 RID: 10016
	public extern string Invoke(object object_0);

	// Token: 0x06002721 RID: 10017 RVA: 0x0000E294 File Offset: 0x0000C494
	public static string smethod_0(object object_0, Delegate979 delegate979_1)
	{
		return delegate979_1(object_0);
	}

	// Token: 0x06002722 RID: 10018
	public extern Delegate979(object object_0, IntPtr intptr_0);

	// Token: 0x06002723 RID: 10019 RVA: 0x0000E29F File Offset: 0x0000C49F
	static Delegate979()
	{
		Class15.smethod_14(typeof(Delegate979).TypeHandle);
	}

	// Token: 0x04000DB3 RID: 3507
	internal static Delegate979 delegate979_0;
}
