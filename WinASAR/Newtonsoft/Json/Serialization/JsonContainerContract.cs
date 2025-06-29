using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x02000100 RID: 256
	[NullableContext(2)]
	[Nullable(0)]
	public class JsonContainerContract : JsonContract
	{
		// Token: 0x17000136 RID: 310
		// (get) Token: 0x060009C5 RID: 2501 RVA: 0x00004ACC File Offset: 0x00002CCC
		// (set) Token: 0x060009C6 RID: 2502 RVA: 0x00058FFC File Offset: 0x000571FC
		internal JsonContract ItemContract
		{
			get
			{
				return this.jsonContract_0;
			}
			set
			{
				for (;;)
				{
					IL_0063:
					this.jsonContract_0 = value;
					int num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_17bdafd603b54a77a2e4a383bd4dcffa != 0)
					{
						break;
					}
					for (;;)
					{
						switch (num)
						{
						case 1:
							if (this.jsonContract_0 == null)
							{
								goto Block_3;
							}
							goto IL_0003;
						case 2:
							goto IL_0063;
						case 3:
							return;
						case 4:
							goto IL_0003;
						case 5:
							goto IL_0080;
						}
						return;
						IL_0003:
						this.jsonContract_1 = (this.jsonContract_0.UnderlyingType.IsSealed() ? this.jsonContract_0 : null);
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_100d09ce3850492c8356d7fa1e667d54 == 0)
						{
							goto Block_2;
						}
					}
				}
				Block_2:
				return;
				Block_3:
				IL_0080:
				this.jsonContract_1 = null;
			}
		}

		// Token: 0x17000137 RID: 311
		// (get) Token: 0x060009C7 RID: 2503 RVA: 0x00004AD4 File Offset: 0x00002CD4
		internal JsonContract FinalItemContract
		{
			get
			{
				return this.jsonContract_1;
			}
		}

		// Token: 0x17000138 RID: 312
		// (get) Token: 0x060009C8 RID: 2504 RVA: 0x00004ADC File Offset: 0x00002CDC
		// (set) Token: 0x060009C9 RID: 2505 RVA: 0x00059090 File Offset: 0x00057290
		public JsonConverter ItemConverter
		{
			[CompilerGenerated]
			get
			{
				return this.jsonConverter_2;
			}
			[CompilerGenerated]
			set
			{
				for (;;)
				{
					this.jsonConverter_2 = value;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d97e64d0f425406b9649f2b4562a5f0e != 0)
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

		// Token: 0x17000139 RID: 313
		// (get) Token: 0x060009CA RID: 2506 RVA: 0x00004AE4 File Offset: 0x00002CE4
		// (set) Token: 0x060009CB RID: 2507 RVA: 0x00004AEC File Offset: 0x00002CEC
		public bool? ItemIsReference { get; set; }

		// Token: 0x1700013A RID: 314
		// (get) Token: 0x060009CC RID: 2508 RVA: 0x00004AF5 File Offset: 0x00002CF5
		// (set) Token: 0x060009CD RID: 2509 RVA: 0x00004AFD File Offset: 0x00002CFD
		public ReferenceLoopHandling? ItemReferenceLoopHandling { get; set; }

		// Token: 0x1700013B RID: 315
		// (get) Token: 0x060009CE RID: 2510 RVA: 0x00004B06 File Offset: 0x00002D06
		// (set) Token: 0x060009CF RID: 2511 RVA: 0x00004B0E File Offset: 0x00002D0E
		public TypeNameHandling? ItemTypeNameHandling { get; set; }

		// Token: 0x060009D0 RID: 2512 RVA: 0x000590C8 File Offset: 0x000572C8
		[NullableContext(1)]
		internal JsonContainerContract(Type underlyingType)
			: base(underlyingType)
		{
			int num = 6;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_871a407507f34aa3b5bf52517d4f63a9 != 0)
			{
				goto IL_001E;
			}
			goto IL_009F;
			IL_0042:
			JsonContainerAttribute cachedAttribute;
			while (cachedAttribute.ItemConverterType != null)
			{
				num = 5;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_67cbcb2ad04040d48847c1ca2f65be32 == 0)
				{
					goto IL_009F;
				}
			}
			goto IL_0051;
			for (;;)
			{
				IL_009F:
				switch (num)
				{
				case 1:
					goto IL_00C8;
				case 2:
					goto IL_0042;
				case 3:
					goto IL_0026;
				case 4:
					goto IL_00D5;
				case 5:
					this.ItemConverter = JsonTypeReflector.CreateJsonConverterInstance(cachedAttribute.ItemConverterType, cachedAttribute.ItemConverterParameters);
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c08ab7af63da4f24a4fa3e9c7a732fae == 0)
					{
						continue;
					}
					break;
				case 6:
					return;
				case 7:
					goto IL_001E;
				}
				break;
			}
			goto IL_0051;
			IL_001E:
			cachedAttribute = JsonTypeReflector.GetCachedAttribute<JsonContainerAttribute>(underlyingType);
			IL_0026:
			if (cachedAttribute != null)
			{
				goto IL_0042;
			}
			return;
			IL_0051:
			this.ItemIsReference = cachedAttribute._itemIsReference;
			num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39a47a907a8a440980940ae96da3f3ad == 0)
			{
				goto IL_009F;
			}
			IL_00C8:
			this.ItemReferenceLoopHandling = cachedAttribute._itemReferenceLoopHandling;
			IL_00D5:
			this.ItemTypeNameHandling = cachedAttribute._itemTypeNameHandling;
		}

		// Token: 0x0400050B RID: 1291
		private JsonContract jsonContract_0;

		// Token: 0x0400050C RID: 1292
		private JsonContract jsonContract_1;

		// Token: 0x0400050D RID: 1293
		[CompilerGenerated]
		private JsonConverter jsonConverter_2;

		// Token: 0x0400050E RID: 1294
		[CompilerGenerated]
		private bool? nullable_1;

		// Token: 0x0400050F RID: 1295
		[CompilerGenerated]
		private ReferenceLoopHandling? nullable_2;

		// Token: 0x04000510 RID: 1296
		[CompilerGenerated]
		private TypeNameHandling? nullable_3;
	}
}
