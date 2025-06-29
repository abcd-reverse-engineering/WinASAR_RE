using System;

// Token: 0x02000379 RID: 889
internal sealed class Delegate361 : MulticastDelegate
{
	// Token: 0x06001D78 RID: 7544
	public extern bool Invoke(string string_0, ref bool bool_0);

	// Token: 0x06001D79 RID: 7545 RVA: 0x0000A513 File Offset: 0x00008713
	public static bool smethod_0(string string_0, ref bool bool_0, Delegate361 delegate361_1)
	{
		return delegate361_1(string_0, ref bool_0);
	}

	// Token: 0x06001D7A RID: 7546
	public extern Delegate361(object object_0, IntPtr intptr_0);

	// Token: 0x06001D7B RID: 7547 RVA: 0x0000A520 File Offset: 0x00008720
	static Delegate361()
	{
		Class15.smethod_14(typeof(Delegate361).TypeHandle);
	}

	// Token: 0x04000B49 RID: 2889
	internal static Delegate361 delegate361_0;
}
