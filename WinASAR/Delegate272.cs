using System;

// Token: 0x02000320 RID: 800
internal sealed class Delegate272 : MulticastDelegate
{
	// Token: 0x06001C14 RID: 7188
	public extern int Invoke(object object_0, byte[] byte_0, int int_0, int int_1);

	// Token: 0x06001C15 RID: 7189 RVA: 0x00009C0F File Offset: 0x00007E0F
	public static int smethod_0(object object_0, byte[] byte_0, int int_0, int int_1, Delegate272 delegate272_1)
	{
		return delegate272_1(object_0, byte_0, int_0, int_1);
	}

	// Token: 0x06001C16 RID: 7190
	public extern Delegate272(object object_0, IntPtr intptr_0);

	// Token: 0x06001C17 RID: 7191 RVA: 0x00009C20 File Offset: 0x00007E20
	static Delegate272()
	{
		Class15.smethod_14(typeof(Delegate272).TypeHandle);
	}

	// Token: 0x04000AF0 RID: 2800
	internal static Delegate272 delegate272_0;
}
