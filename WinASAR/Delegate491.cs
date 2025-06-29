using System;

// Token: 0x020003FB RID: 1019
internal sealed class Delegate491 : MulticastDelegate
{
	// Token: 0x06001F80 RID: 8064
	public extern void Invoke(object object_0, int int_0, char[] char_0, int int_1, int int_2);

	// Token: 0x06001F81 RID: 8065 RVA: 0x0000B235 File Offset: 0x00009435
	public static void smethod_0(object object_0, int int_0, char[] char_0, int int_1, int int_2, Delegate491 delegate491_1)
	{
		delegate491_1(object_0, int_0, char_0, int_1, int_2);
	}

	// Token: 0x06001F82 RID: 8066
	public extern Delegate491(object object_0, IntPtr intptr_0);

	// Token: 0x06001F83 RID: 8067 RVA: 0x0000B248 File Offset: 0x00009448
	static Delegate491()
	{
		Class15.smethod_14(typeof(Delegate491).TypeHandle);
	}

	// Token: 0x04000BCB RID: 3019
	internal static Delegate491 delegate491_0;
}
