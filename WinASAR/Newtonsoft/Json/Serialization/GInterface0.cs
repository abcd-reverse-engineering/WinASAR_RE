using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x020000F9 RID: 249
	[NullableContext(1)]
	public interface GInterface0
	{
		// Token: 0x060009A5 RID: 2469
		IList<Attribute> GetAttributes(bool inherit);

		// Token: 0x060009A6 RID: 2470
		IList<Attribute> GetAttributes(Type attributeType, bool inherit);
	}
}
