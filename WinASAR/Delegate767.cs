using System;

// Token: 0x0200050F RID: 1295
internal sealed class Delegate767 : MulticastDelegate
{
	// Token: 0x060023D0 RID: 9168
	public extern string Invoke(ref Guid guid_0, string string_0);

	// Token: 0x060023D1 RID: 9169 RVA: 0x0000CD9C File Offset: 0x0000AF9C
	public static string smethod_0(ref Guid guid_0, string string_0, Delegate767 delegate767_1)
	{
		return delegate767_1(ref guid_0, string_0);
	}

	// Token: 0x060023D2 RID: 9170
	public extern Delegate767(object object_0, IntPtr intptr_0);

	// Token: 0x060023D3 RID: 9171 RVA: 0x0000CDA9 File Offset: 0x0000AFA9
	static Delegate767()
	{
		Class15.smethod_14(typeof(Delegate767).TypeHandle);
	}

	// Token: 0x04000CDF RID: 3295
	internal static Delegate767 delegate767_0;
}
