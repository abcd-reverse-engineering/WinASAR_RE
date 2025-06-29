using System;

// Token: 0x020002E4 RID: 740
internal sealed class Delegate212 : MulticastDelegate
{
	// Token: 0x06001B24 RID: 6948
	public extern void Invoke(string string_0, bool bool_0);

	// Token: 0x06001B25 RID: 6949 RVA: 0x00009627 File Offset: 0x00007827
	public static void smethod_0(string string_0, bool bool_0, Delegate212 delegate212_1)
	{
		delegate212_1(string_0, bool_0);
	}

	// Token: 0x06001B26 RID: 6950
	public extern Delegate212(object object_0, IntPtr intptr_0);

	// Token: 0x06001B27 RID: 6951 RVA: 0x00009634 File Offset: 0x00007834
	static Delegate212()
	{
		Class15.smethod_14(typeof(Delegate212).TypeHandle);
	}

	// Token: 0x04000AB4 RID: 2740
	internal static Delegate212 delegate212_0;
}
