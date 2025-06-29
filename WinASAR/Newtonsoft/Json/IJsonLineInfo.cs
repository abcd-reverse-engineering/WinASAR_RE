using System;

namespace Newtonsoft.Json
{
	// Token: 0x0200004E RID: 78
	public interface IJsonLineInfo
	{
		// Token: 0x06000219 RID: 537
		bool HasLineInfo();

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x0600021A RID: 538
		int LineNumber { get; }

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x0600021B RID: 539
		int LinePosition { get; }
	}
}
