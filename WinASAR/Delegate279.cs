using System;

// Token: 0x02000327 RID: 807
internal sealed class Delegate279 : MulticastDelegate
{
	// Token: 0x06001C30 RID: 7216
	public extern void Invoke(object object_0, bool bool_0);

	// Token: 0x06001C31 RID: 7217 RVA: 0x00009CC3 File Offset: 0x00007EC3
	public static void smethod_0(object object_0, bool bool_0, Delegate279 delegate279_1)
	{
		delegate279_1(object_0, bool_0);
	}

	// Token: 0x06001C32 RID: 7218
	public extern Delegate279(object object_0, IntPtr intptr_0);

	// Token: 0x06001C33 RID: 7219 RVA: 0x00009CD0 File Offset: 0x00007ED0
	static Delegate279()
	{
		Class15.smethod_14(typeof(Delegate279).TypeHandle);
	}

	// Token: 0x04000AF7 RID: 2807
	internal static Delegate279 delegate279_0;
}
