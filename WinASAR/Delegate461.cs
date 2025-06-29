using System;

// Token: 0x020003DD RID: 989
internal sealed class Delegate461 : MulticastDelegate
{
	// Token: 0x06001F08 RID: 7944
	public extern bool Invoke(string string_0, ref Version version_0);

	// Token: 0x06001F09 RID: 7945 RVA: 0x0000AF37 File Offset: 0x00009137
	public static bool smethod_0(string string_0, ref Version version_0, Delegate461 delegate461_1)
	{
		return delegate461_1(string_0, ref version_0);
	}

	// Token: 0x06001F0A RID: 7946
	public extern Delegate461(object object_0, IntPtr intptr_0);

	// Token: 0x06001F0B RID: 7947 RVA: 0x0000AF44 File Offset: 0x00009144
	static Delegate461()
	{
		Class15.smethod_14(typeof(Delegate461).TypeHandle);
	}

	// Token: 0x04000BAD RID: 2989
	internal static Delegate461 delegate461_0;
}
