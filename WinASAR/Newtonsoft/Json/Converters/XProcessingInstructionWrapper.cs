using System;
using System.Runtime.CompilerServices;
using System.Xml.Linq;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020001AF RID: 431
	[NullableContext(2)]
	[Nullable(0)]
	internal class XProcessingInstructionWrapper : XObjectWrapper
	{
		// Token: 0x170002BC RID: 700
		// (get) Token: 0x060012DC RID: 4828 RVA: 0x00006E3D File Offset: 0x0000503D
		[Nullable(1)]
		private XProcessingInstruction XProcessingInstruction_0
		{
			[NullableContext(1)]
			get
			{
				return (XProcessingInstruction)base.WrappedNode;
			}
		}

		// Token: 0x060012DD RID: 4829 RVA: 0x00092578 File Offset: 0x00090778
		[NullableContext(1)]
		public XProcessingInstructionWrapper(XProcessingInstruction processingInstruction)
			: base(processingInstruction)
		{
			int num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_67a271e0ae064fc7a3a74905868add95 != 0)
			{
				switch (num)
				{
				}
			}
		}

		// Token: 0x170002BD RID: 701
		// (get) Token: 0x060012DE RID: 4830 RVA: 0x00006E4A File Offset: 0x0000504A
		public override string LocalName
		{
			get
			{
				return this.XProcessingInstruction_0.Target;
			}
		}

		// Token: 0x170002BE RID: 702
		// (get) Token: 0x060012DF RID: 4831 RVA: 0x00006E57 File Offset: 0x00005057
		// (set) Token: 0x060012E0 RID: 4832 RVA: 0x000925AC File Offset: 0x000907AC
		public override string Value
		{
			get
			{
				return this.XProcessingInstruction_0.Data;
			}
			set
			{
				for (;;)
				{
					XProcessingInstruction xprocessingInstruction_ = this.XProcessingInstruction_0;
					string text = value;
					if (value == null)
					{
						text = string.Empty;
					}
					xprocessingInstruction_.Data = text;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0005996a6a494de4880ac2956b2e0112 == 0)
					{
						switch (num)
						{
						case 1:
							continue;
						}
						break;
					}
					break;
				}
			}
		}
	}
}
