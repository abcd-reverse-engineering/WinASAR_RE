using System;

// Token: 0x020003C6 RID: 966
internal sealed class Delegate438 : MulticastDelegate
{
	// Token: 0x06001EAC RID: 7852
	public extern void Invoke(object object_0, int int_0);

	// Token: 0x06001EAD RID: 7853 RVA: 0x0000ACDB File Offset: 0x00008EDB
	public static void smethod_0(object object_0, int int_0, Delegate438 delegate438_1)
	{
		delegate438_1(object_0, int_0);
	}

	// Token: 0x06001EAE RID: 7854
	public extern Delegate438(object object_0, IntPtr intptr_0);

	// Token: 0x06001EAF RID: 7855 RVA: 0x0000ACE8 File Offset: 0x00008EE8
	static Delegate438()
	{
		Class15.smethod_14(typeof(Delegate438).TypeHandle);
	}

	// Token: 0x04000B96 RID: 2966
	internal static Delegate438 delegate438_0;
}
