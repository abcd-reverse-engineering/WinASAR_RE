using System;

// Token: 0x020003D7 RID: 983
internal sealed class Delegate455 : MulticastDelegate
{
	// Token: 0x06001EF0 RID: 7920
	public extern Type Invoke(string string_0, bool bool_0);

	// Token: 0x06001EF1 RID: 7921 RVA: 0x0000AE93 File Offset: 0x00009093
	public static Type smethod_0(string string_0, bool bool_0, Delegate455 delegate455_1)
	{
		return delegate455_1(string_0, bool_0);
	}

	// Token: 0x06001EF2 RID: 7922
	public extern Delegate455(object object_0, IntPtr intptr_0);

	// Token: 0x06001EF3 RID: 7923 RVA: 0x0000AEA0 File Offset: 0x000090A0
	static Delegate455()
	{
		Class15.smethod_14(typeof(Delegate455).TypeHandle);
	}

	// Token: 0x04000BA7 RID: 2983
	internal static Delegate455 delegate455_0;
}
