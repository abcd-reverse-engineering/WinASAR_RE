using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters;
using Newtonsoft.Json.Serialization;

namespace Newtonsoft.Json
{
	// Token: 0x02000066 RID: 102
	[Nullable(0)]
	[NullableContext(2)]
	public class JsonSerializerSettings
	{
		// Token: 0x1700009C RID: 156
		// (get) Token: 0x060003C8 RID: 968 RVA: 0x00002F67 File Offset: 0x00001167
		// (set) Token: 0x060003C9 RID: 969 RVA: 0x0002E78C File Offset: 0x0002C98C
		public ReferenceLoopHandling ReferenceLoopHandling
		{
			get
			{
				return this._referenceLoopHandling.GetValueOrDefault();
			}
			set
			{
				for (;;)
				{
					this._referenceLoopHandling = new ReferenceLoopHandling?(value);
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa49bb51056944098afe92e3a80a544b == 0)
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

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x060003CA RID: 970 RVA: 0x00002F74 File Offset: 0x00001174
		// (set) Token: 0x060003CB RID: 971 RVA: 0x0002E7C8 File Offset: 0x0002C9C8
		public MissingMemberHandling MissingMemberHandling
		{
			get
			{
				return this._missingMemberHandling.GetValueOrDefault();
			}
			set
			{
				for (;;)
				{
					this._missingMemberHandling = new MissingMemberHandling?(value);
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9a2e459a49464219810a951679aea12e != 0)
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

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x060003CC RID: 972 RVA: 0x00002F81 File Offset: 0x00001181
		// (set) Token: 0x060003CD RID: 973 RVA: 0x0002E804 File Offset: 0x0002CA04
		public ObjectCreationHandling ObjectCreationHandling
		{
			get
			{
				return this._objectCreationHandling.GetValueOrDefault();
			}
			set
			{
				for (;;)
				{
					this._objectCreationHandling = new ObjectCreationHandling?(value);
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7ae4da5a55de471eb12dd0de8dd4269c == 0)
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

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x060003CE RID: 974 RVA: 0x00002F8E File Offset: 0x0000118E
		// (set) Token: 0x060003CF RID: 975 RVA: 0x0002E840 File Offset: 0x0002CA40
		public NullValueHandling NullValueHandling
		{
			get
			{
				return this._nullValueHandling.GetValueOrDefault();
			}
			set
			{
				for (;;)
				{
					this._nullValueHandling = new NullValueHandling?(value);
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b17e63564ae246399767b60cf4b1528a == 0)
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

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x060003D0 RID: 976 RVA: 0x00002F9B File Offset: 0x0000119B
		// (set) Token: 0x060003D1 RID: 977 RVA: 0x0002E87C File Offset: 0x0002CA7C
		public DefaultValueHandling DefaultValueHandling
		{
			get
			{
				return this._defaultValueHandling.GetValueOrDefault();
			}
			set
			{
				for (;;)
				{
					this._defaultValueHandling = new DefaultValueHandling?(value);
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b17e63564ae246399767b60cf4b1528a == 0)
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

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x060003D2 RID: 978 RVA: 0x00002FA8 File Offset: 0x000011A8
		// (set) Token: 0x060003D3 RID: 979 RVA: 0x00002FB0 File Offset: 0x000011B0
		[Nullable(1)]
		public IList<JsonConverter> Converters
		{
			[NullableContext(1)]
			get;
			[NullableContext(1)]
			set;
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x060003D4 RID: 980 RVA: 0x00002FB9 File Offset: 0x000011B9
		// (set) Token: 0x060003D5 RID: 981 RVA: 0x0002E8B8 File Offset: 0x0002CAB8
		public PreserveReferencesHandling PreserveReferencesHandling
		{
			get
			{
				return this._preserveReferencesHandling.GetValueOrDefault();
			}
			set
			{
				for (;;)
				{
					this._preserveReferencesHandling = new PreserveReferencesHandling?(value);
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_01137da6c88c4265bdc0297aacf3340f != 0)
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

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x060003D6 RID: 982 RVA: 0x00002FC6 File Offset: 0x000011C6
		// (set) Token: 0x060003D7 RID: 983 RVA: 0x0002E8F4 File Offset: 0x0002CAF4
		public TypeNameHandling TypeNameHandling
		{
			get
			{
				return this._typeNameHandling.GetValueOrDefault();
			}
			set
			{
				for (;;)
				{
					this._typeNameHandling = new TypeNameHandling?(value);
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_92ac2a37edba4e2587eb1b9e8af3f63f != 0)
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

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x060003D8 RID: 984 RVA: 0x00002FD3 File Offset: 0x000011D3
		// (set) Token: 0x060003D9 RID: 985 RVA: 0x0002E930 File Offset: 0x0002CB30
		public MetadataPropertyHandling MetadataPropertyHandling
		{
			get
			{
				return this._metadataPropertyHandling.GetValueOrDefault();
			}
			set
			{
				for (;;)
				{
					this._metadataPropertyHandling = new MetadataPropertyHandling?(value);
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3a102d6e4dd542a6855b81a93c692545 == 0)
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

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x060003DA RID: 986 RVA: 0x00002FE0 File Offset: 0x000011E0
		// (set) Token: 0x060003DB RID: 987 RVA: 0x0002E96C File Offset: 0x0002CB6C
		[Obsolete("TypeNameAssemblyFormat is obsolete. Use TypeNameAssemblyFormatHandling instead.")]
		public FormatterAssemblyStyle TypeNameAssemblyFormat
		{
			get
			{
				return (FormatterAssemblyStyle)this.TypeNameAssemblyFormatHandling;
			}
			set
			{
				for (;;)
				{
					this.TypeNameAssemblyFormatHandling = (TypeNameAssemblyFormatHandling)value;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9bd9937edf9d4ad8bd673dfcb5a5e3cb != 0)
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

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x060003DC RID: 988 RVA: 0x00002FE8 File Offset: 0x000011E8
		// (set) Token: 0x060003DD RID: 989 RVA: 0x0002E9A4 File Offset: 0x0002CBA4
		public TypeNameAssemblyFormatHandling TypeNameAssemblyFormatHandling
		{
			get
			{
				return this._typeNameAssemblyFormatHandling.GetValueOrDefault();
			}
			set
			{
				for (;;)
				{
					this._typeNameAssemblyFormatHandling = new TypeNameAssemblyFormatHandling?(value);
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_1db17fe7bd2442b599c52df89f39e610 != 0)
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

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x060003DE RID: 990 RVA: 0x00002FF5 File Offset: 0x000011F5
		// (set) Token: 0x060003DF RID: 991 RVA: 0x0002E9E0 File Offset: 0x0002CBE0
		public ConstructorHandling ConstructorHandling
		{
			get
			{
				return this._constructorHandling.GetValueOrDefault();
			}
			set
			{
				for (;;)
				{
					this._constructorHandling = new ConstructorHandling?(value);
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_92ac2a37edba4e2587eb1b9e8af3f63f != 0)
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

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x060003E0 RID: 992 RVA: 0x00003002 File Offset: 0x00001202
		// (set) Token: 0x060003E1 RID: 993 RVA: 0x0002EA1C File Offset: 0x0002CC1C
		public IContractResolver ContractResolver
		{
			[CompilerGenerated]
			get
			{
				return this.icontractResolver_0;
			}
			[CompilerGenerated]
			set
			{
				for (;;)
				{
					this.icontractResolver_0 = value;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4ac69ea2381b403582a2723337f67fa8 != 0)
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

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x060003E2 RID: 994 RVA: 0x0000300A File Offset: 0x0000120A
		// (set) Token: 0x060003E3 RID: 995 RVA: 0x0002EA54 File Offset: 0x0002CC54
		public IEqualityComparer EqualityComparer
		{
			[CompilerGenerated]
			get
			{
				return this.iequalityComparer_0;
			}
			[CompilerGenerated]
			set
			{
				for (;;)
				{
					this.iequalityComparer_0 = value;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_55c1fea936c04e47abbfb2b5f778aff7 != 0)
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

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x060003E4 RID: 996 RVA: 0x0002EA8C File Offset: 0x0002CC8C
		// (set) Token: 0x060003E5 RID: 997 RVA: 0x0002EAD0 File Offset: 0x0002CCD0
		[Obsolete("ReferenceResolver property is obsolete. Use the ReferenceResolverProvider property to set the IReferenceResolver: settings.ReferenceResolverProvider = () => resolver")]
		public GInterface1 ReferenceResolver
		{
			get
			{
				Func<GInterface1> referenceResolverProvider;
				for (;;)
				{
					referenceResolverProvider = this.ReferenceResolverProvider;
					if (referenceResolverProvider != null)
					{
						goto IL_002F;
					}
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_eaded84ad5b14e1ea8d4d97bfed1bb48 != 0)
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
				return null;
				IL_002F:
				return referenceResolverProvider();
			}
			set
			{
				for (;;)
				{
					JsonSerializerSettings.<>c__DisplayClass93_0 CS$<>8__locals1 = new JsonSerializerSettings.<>c__DisplayClass93_0();
					int num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bca7529ca324c188cfc0e64eb7d1cdf == 0)
					{
						goto IL_0003;
					}
					IL_0050:
					switch (num)
					{
					case 0:
						goto IL_001D;
					case 1:
						break;
					case 2:
						continue;
					case 3:
						return;
					default:
						goto IL_001D;
					}
					IL_0003:
					CS$<>8__locals1.ginterface1_0 = value;
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9a2e459a49464219810a951679aea12e != 0)
					{
						goto IL_0050;
					}
					IL_001D:
					this.ReferenceResolverProvider = ((CS$<>8__locals1.ginterface1_0 != null) ? new Func<GInterface1>(CS$<>8__locals1.method_0) : null);
					num = 3;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_871a407507f34aa3b5bf52517d4f63a9 == 0)
					{
						goto IL_0003;
					}
					goto IL_0050;
				}
			}
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x060003E6 RID: 998 RVA: 0x00003012 File Offset: 0x00001212
		// (set) Token: 0x060003E7 RID: 999 RVA: 0x0000301A File Offset: 0x0000121A
		public Func<GInterface1> ReferenceResolverProvider { get; set; }

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x060003E8 RID: 1000 RVA: 0x00003023 File Offset: 0x00001223
		// (set) Token: 0x060003E9 RID: 1001 RVA: 0x0002EB60 File Offset: 0x0002CD60
		public ITraceWriter TraceWriter
		{
			[CompilerGenerated]
			get
			{
				return this.itraceWriter_0;
			}
			[CompilerGenerated]
			set
			{
				for (;;)
				{
					this.itraceWriter_0 = value;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_100d09ce3850492c8356d7fa1e667d54 == 0)
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

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x060003EA RID: 1002 RVA: 0x0002EB98 File Offset: 0x0002CD98
		// (set) Token: 0x060003EB RID: 1003 RVA: 0x0002EC40 File Offset: 0x0002CE40
		[Obsolete("Binder is obsolete. Use SerializationBinder instead.")]
		public SerializationBinder Binder
		{
			get
			{
				SerializationBinderAdapter serializationBinderAdapter;
				for (;;)
				{
					IL_0065:
					int num;
					if (this.SerializationBinder == null)
					{
						num = 1;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4152404f503b492c83d9bc2e44bdd0a7 != 0)
						{
							goto Block_4;
						}
					}
					else
					{
						serializationBinderAdapter = this.SerializationBinder as SerializationBinderAdapter;
						num = 1;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9f9b31fb7a85497499112abf86cccc98 == 0)
						{
							break;
						}
					}
					for (;;)
					{
						switch (num)
						{
						case 1:
							if (serializationBinderAdapter == null)
							{
								goto IL_007F;
							}
							num = 0;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4ac69ea2381b403582a2723337f67fa8 == 0)
							{
								continue;
							}
							break;
						case 2:
							goto IL_009A;
						case 3:
							goto IL_0065;
						}
						goto Block_3;
					}
				}
				Block_3:
				goto IL_0077;
				Block_4:
				goto IL_009A;
				IL_0077:
				return serializationBinderAdapter.SerializationBinder;
				IL_007F:
				throw new InvalidOperationException(Class15.smethod_17(432111893 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7af5c533f30e4bd1bda86ce6098441d2));
				IL_009A:
				return null;
			}
			set
			{
				for (;;)
				{
					this.SerializationBinder = ((value == null) ? null : new SerializationBinderAdapter(value));
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_48fe014748e848c88d3254f339047927 == 0)
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

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x060003EC RID: 1004 RVA: 0x0000302B File Offset: 0x0000122B
		// (set) Token: 0x060003ED RID: 1005 RVA: 0x0002EC84 File Offset: 0x0002CE84
		public GInterface2 SerializationBinder
		{
			[CompilerGenerated]
			get
			{
				return this.ginterface2_0;
			}
			[CompilerGenerated]
			set
			{
				for (;;)
				{
					this.ginterface2_0 = value;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_548c52e5632b45898e377ad9c9a06469 == 0)
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

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x060003EE RID: 1006 RVA: 0x00003033 File Offset: 0x00001233
		// (set) Token: 0x060003EF RID: 1007 RVA: 0x0000303B File Offset: 0x0000123B
		[Nullable(new byte[] { 2, 1 })]
		public EventHandler<ErrorEventArgs> Error
		{
			[return: Nullable(new byte[] { 2, 1 })]
			get;
			[param: Nullable(new byte[] { 2, 1 })]
			set;
		}

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x060003F0 RID: 1008 RVA: 0x0002ECBC File Offset: 0x0002CEBC
		// (set) Token: 0x060003F1 RID: 1009 RVA: 0x0002ED24 File Offset: 0x0002CF24
		public StreamingContext Context
		{
			get
			{
				StreamingContext? context;
				for (;;)
				{
					context = this._context;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_55c1fea936c04e47abbfb2b5f778aff7 == 0)
					{
						goto IL_0003;
					}
					IL_001D:
					switch (num)
					{
					case 1:
						continue;
					case 2:
						goto IL_0056;
					}
					IL_0003:
					if (context != null)
					{
						break;
					}
					num = 2;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e5c1d856e0c64e6f8377f7d819e11923 != 0)
					{
						goto IL_001D;
					}
				}
				return context.GetValueOrDefault();
				IL_0056:
				return JsonSerializerSettings.DefaultContext;
			}
			set
			{
				for (;;)
				{
					this._context = new StreamingContext?(value);
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d97e64d0f425406b9649f2b4562a5f0e == 0)
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

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x060003F2 RID: 1010 RVA: 0x0002ED60 File Offset: 0x0002CF60
		// (set) Token: 0x060003F3 RID: 1011 RVA: 0x0002EDB0 File Offset: 0x0002CFB0
		[Nullable(1)]
		public string DateFormatString
		{
			[NullableContext(1)]
			get
			{
				string text;
				while ((text = this._dateFormatString) == null)
				{
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d9581c727fcc4f50accd4f5de0d386f5 != 0)
					{
						switch (num)
						{
						case 1:
							continue;
						}
					}
					text = Class15.smethod_17(1985300158 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f19acd91a8c44846a95d09d7dc3da2ba);
					break;
				}
				return text;
			}
			[NullableContext(1)]
			set
			{
				for (;;)
				{
					this._dateFormatString = value;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_afb77be96d644a2297c7f9466cb06ede != 0)
					{
						goto IL_0003;
					}
					IL_001B:
					switch (num)
					{
					case 1:
						continue;
					case 2:
						return;
					}
					IL_0003:
					this._dateFormatStringSet = true;
					num = 2;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3cf8a2073cc248c2915ebb05bcd2a099 != 0)
					{
						goto IL_001B;
					}
					break;
				}
			}
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x060003F4 RID: 1012 RVA: 0x00003044 File Offset: 0x00001244
		// (set) Token: 0x060003F5 RID: 1013 RVA: 0x0002EE08 File Offset: 0x0002D008
		public int? MaxDepth
		{
			get
			{
				if (!this._maxDepthSet)
				{
					return new int?(64);
				}
				return this._maxDepth;
			}
			set
			{
				int? num = value;
				if ((num.GetValueOrDefault() <= 0) & (num != null))
				{
					throw new ArgumentException(Class15.smethod_17(1270972642 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0005996a6a494de4880ac2956b2e0112), Class15.smethod_17(926368931 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b2d935deb963472994f6f2321f1a6296));
				}
				this._maxDepth = value;
				this._maxDepthSet = true;
			}
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x060003F6 RID: 1014 RVA: 0x0000305C File Offset: 0x0000125C
		// (set) Token: 0x060003F7 RID: 1015 RVA: 0x0002EE6C File Offset: 0x0002D06C
		public Formatting Formatting
		{
			get
			{
				return this._formatting.GetValueOrDefault();
			}
			set
			{
				for (;;)
				{
					this._formatting = new Formatting?(value);
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3436841e08c54f56b10b76e1438d4224 == 0)
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

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x060003F8 RID: 1016 RVA: 0x00003069 File Offset: 0x00001269
		// (set) Token: 0x060003F9 RID: 1017 RVA: 0x0002EEA8 File Offset: 0x0002D0A8
		public DateFormatHandling DateFormatHandling
		{
			get
			{
				return this._dateFormatHandling.GetValueOrDefault();
			}
			set
			{
				for (;;)
				{
					this._dateFormatHandling = new DateFormatHandling?(value);
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_92ac2a37edba4e2587eb1b9e8af3f63f != 0)
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

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x060003FA RID: 1018 RVA: 0x0002EEE4 File Offset: 0x0002D0E4
		// (set) Token: 0x060003FB RID: 1019 RVA: 0x0002EF40 File Offset: 0x0002D140
		public DateTimeZoneHandling DateTimeZoneHandling
		{
			get
			{
				DateTimeZoneHandling? dateTimeZoneHandling;
				for (;;)
				{
					IL_0038:
					dateTimeZoneHandling = this._dateTimeZoneHandling;
					while (dateTimeZoneHandling != null)
					{
						int num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_676b866782704933888a7440512fd4ff != 0)
						{
							switch (num)
							{
							case 1:
								goto IL_0043;
							case 2:
								continue;
							case 3:
								goto IL_0038;
							}
							break;
						}
						goto IL_0042;
					}
					break;
				}
				return DateTimeZoneHandling.RoundtripKind;
				IL_0042:
				IL_0043:
				return dateTimeZoneHandling.GetValueOrDefault();
			}
			set
			{
				for (;;)
				{
					this._dateTimeZoneHandling = new DateTimeZoneHandling?(value);
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c08ab7af63da4f24a4fa3e9c7a732fae == 0)
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

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x060003FC RID: 1020 RVA: 0x0002EF7C File Offset: 0x0002D17C
		// (set) Token: 0x060003FD RID: 1021 RVA: 0x0002EFE4 File Offset: 0x0002D1E4
		public DateParseHandling DateParseHandling
		{
			get
			{
				DateParseHandling? dateParseHandling;
				for (;;)
				{
					dateParseHandling = this._dateParseHandling;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa29cbda752f45acbe81e7d5285df2ba != 0)
					{
						goto IL_0003;
					}
					IL_001D:
					switch (num)
					{
					case 1:
						continue;
					case 2:
						return DateParseHandling.DateTime;
					}
					IL_0003:
					if (dateParseHandling != null)
					{
						goto IL_0050;
					}
					num = 2;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8432da17e8384a688cea4636964d3693 == 0)
					{
						goto IL_001D;
					}
					break;
				}
				return DateParseHandling.DateTime;
				IL_0050:
				return dateParseHandling.GetValueOrDefault();
			}
			set
			{
				for (;;)
				{
					this._dateParseHandling = new DateParseHandling?(value);
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_43b8cdd768c545d884bf7ff1c8fefe89 != 0)
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

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x060003FE RID: 1022 RVA: 0x00003076 File Offset: 0x00001276
		// (set) Token: 0x060003FF RID: 1023 RVA: 0x0002F020 File Offset: 0x0002D220
		public FloatFormatHandling FloatFormatHandling
		{
			get
			{
				return this._floatFormatHandling.GetValueOrDefault();
			}
			set
			{
				for (;;)
				{
					this._floatFormatHandling = new FloatFormatHandling?(value);
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_550a8fe2e5fe4cc19bdfe1a82a7f12b8 != 0)
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

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x06000400 RID: 1024 RVA: 0x00003083 File Offset: 0x00001283
		// (set) Token: 0x06000401 RID: 1025 RVA: 0x0002F05C File Offset: 0x0002D25C
		public FloatParseHandling FloatParseHandling
		{
			get
			{
				return this._floatParseHandling.GetValueOrDefault();
			}
			set
			{
				for (;;)
				{
					this._floatParseHandling = new FloatParseHandling?(value);
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0005996a6a494de4880ac2956b2e0112 != 0)
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

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x06000402 RID: 1026 RVA: 0x00003090 File Offset: 0x00001290
		// (set) Token: 0x06000403 RID: 1027 RVA: 0x0002F098 File Offset: 0x0002D298
		public StringEscapeHandling StringEscapeHandling
		{
			get
			{
				return this._stringEscapeHandling.GetValueOrDefault();
			}
			set
			{
				for (;;)
				{
					this._stringEscapeHandling = new StringEscapeHandling?(value);
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_6f87b5b72b9847f7b8ec5b44b0dccfa8 == 0)
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

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x06000404 RID: 1028 RVA: 0x0002F0D4 File Offset: 0x0002D2D4
		// (set) Token: 0x06000405 RID: 1029 RVA: 0x0002F114 File Offset: 0x0002D314
		[Nullable(1)]
		public CultureInfo Culture
		{
			[NullableContext(1)]
			get
			{
				CultureInfo cultureInfo;
				while ((cultureInfo = this._culture) == null)
				{
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ca6ac77a767741aa91cb31f8080f093b == 0)
					{
						switch (num)
						{
						case 1:
							continue;
						}
					}
					cultureInfo = JsonSerializerSettings.DefaultCulture;
					break;
				}
				return cultureInfo;
			}
			[NullableContext(1)]
			set
			{
				for (;;)
				{
					this._culture = value;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e6fac70dd3e841b6925374855ecd7fb1 != 0)
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

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x06000406 RID: 1030 RVA: 0x0000309D File Offset: 0x0000129D
		// (set) Token: 0x06000407 RID: 1031 RVA: 0x0002F14C File Offset: 0x0002D34C
		public bool CheckAdditionalContent
		{
			get
			{
				return this._checkAdditionalContent.GetValueOrDefault();
			}
			set
			{
				for (;;)
				{
					this._checkAdditionalContent = new bool?(value);
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bd75de9a0b64d6da3a43e57303102f1 != 0)
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

		// Token: 0x06000408 RID: 1032 RVA: 0x0002F188 File Offset: 0x0002D388
		static JsonSerializerSettings()
		{
			for (;;)
			{
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c28a4ed7a58e45aaa9902e336fd60b97 == 0)
				{
					goto IL_003E;
				}
				IL_0053:
				switch (num)
				{
				case 0:
					goto IL_0020;
				case 1:
					return;
				case 2:
					IL_003E:
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_afb77be96d644a2297c7f9466cb06ede != 0)
					{
						goto IL_0053;
					}
					break;
				case 3:
					continue;
				case 4:
					break;
				default:
					goto IL_0020;
				}
				JsonSerializerSettings.DefaultContext = default(StreamingContext);
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cbfb1e54efd84756a9b6d7b21adc0d65 != 0)
				{
					goto IL_0053;
				}
				IL_0020:
				JsonSerializerSettings.DefaultCulture = CultureInfo.InvariantCulture;
				num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93c7140125045538ae5c40c6f39a5af != 0)
				{
					break;
				}
				goto IL_0053;
			}
		}

		// Token: 0x06000409 RID: 1033 RVA: 0x0002F21C File Offset: 0x0002D41C
		public JsonSerializerSettings()
		{
			int num = 1;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39d5fbfa4fe34ed9908db538e5340a6c != 0)
			{
				for (;;)
				{
					switch (num)
					{
					case 1:
						this.Converters = new List<JsonConverter>();
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_bc7a9075386042ad9ce36653fcde3fc3 != 0)
						{
							continue;
						}
						break;
					}
					break;
				}
			}
		}

		// Token: 0x0600040A RID: 1034 RVA: 0x0002F274 File Offset: 0x0002D474
		[NullableContext(1)]
		public JsonSerializerSettings(JsonSerializerSettings original)
		{
			for (;;)
			{
				IL_0308:
				this._floatParseHandling = original._floatParseHandling;
				for (;;)
				{
					IL_02E2:
					this._floatFormatHandling = original._floatFormatHandling;
					int num = 9;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_079bd9b874b24353bef46f6c3f5d741d != 0)
					{
						goto IL_01E5;
					}
					for (;;)
					{
						IL_0256:
						switch (num)
						{
						case 1:
							this._checkAdditionalContent = original._checkAdditionalContent;
							num = 20;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_991c06e999c744809f5b643cb7d9e7b4 != 0)
							{
								continue;
							}
							break;
						case 2:
							goto IL_00EC;
						case 3:
							goto IL_004F;
						case 4:
							goto IL_00F8;
						case 5:
							this._maxDepthSet = original._maxDepthSet;
							num = 8;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ae8c3d3c66a64b57beca0f5360302062 == 0)
							{
								goto Block_5;
							}
							continue;
						case 6:
							goto IL_0121;
						case 7:
							goto IL_01C2;
						case 8:
							goto IL_02E2;
						case 9:
							goto IL_0202;
						case 10:
							goto IL_0104;
						case 11:
							goto IL_016A;
						case 12:
							goto IL_01F6;
						case 13:
							goto IL_01E5;
						case 14:
							goto IL_008D;
						case 15:
							this._formatting = original._formatting;
							goto IL_01C2;
						case 16:
							goto IL_0184;
						case 17:
							goto IL_00CB;
						case 18:
							goto IL_006C;
						case 19:
							goto IL_00BF;
						case 20:
							goto IL_0316;
						case 21:
							goto IL_0190;
						case 22:
							this._objectCreationHandling = original._objectCreationHandling;
							goto IL_0184;
						case 23:
							goto IL_015E;
						case 24:
							goto IL_0308;
						case 25:
							goto IL_005B;
						case 26:
							goto IL_013B;
						case 27:
							goto IL_012F;
						case 28:
							goto IL_0115;
						case 29:
							goto IL_00B3;
						case 30:
							goto IL_000D;
						case 31:
							return;
						}
						goto Block_7;
						IL_0190:
						this._referenceLoopHandling = original._referenceLoopHandling;
						num = 1;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_725e5f82c8704b39b66ebddcee8df7fa == 0)
						{
							goto Block_3;
						}
						continue;
						IL_0184:
						this._missingMemberHandling = original._missingMemberHandling;
						goto IL_0190;
						IL_01C2:
						this._maxDepth = original._maxDepth;
						num = 5;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8bcabc342a5a44748f3978da7f62051e == 0)
						{
							goto Block_4;
						}
					}
					IL_0115:
					this.SerializationBinder = original.SerializationBinder;
					goto IL_0121;
					IL_016A:
					this.Error = original.Error;
					goto IL_0115;
					IL_015E:
					this._context = original._context;
					goto IL_016A;
					IL_0202:
					this._dateFormatStringSet = original._dateFormatStringSet;
					goto IL_015E;
					IL_01F6:
					this._dateFormatString = original._dateFormatString;
					goto IL_0202;
					Block_5:
					goto IL_01F6;
					Block_3:
					Block_7:
					goto IL_002E;
					Block_4:
					goto IL_00EC;
					IL_008D:
					this._nullValueHandling = original._nullValueHandling;
					num = 22;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_bc7a9075386042ad9ce36653fcde3fc3 != 0)
					{
						continue;
					}
					goto IL_0256;
					IL_006C:
					this._defaultValueHandling = original._defaultValueHandling;
					num = 11;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_6bf87ae21d2446cfa7edc53669bb8039 != 0)
					{
						goto IL_008D;
					}
					goto IL_0256;
					IL_005B:
					this.Converters = original.Converters.ToList<JsonConverter>();
					goto IL_006C;
					IL_004F:
					this._preserveReferencesHandling = original._preserveReferencesHandling;
					goto IL_005B;
					IL_002E:
					this._typeNameHandling = original._typeNameHandling;
					num = 3;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e368897ba1744663a6d0bc59b9b65b5f != 0)
					{
						goto IL_004F;
					}
					goto IL_0256;
					IL_000D:
					this._metadataPropertyHandling = original._metadataPropertyHandling;
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39f35935adc2477fa894750fee078177 == 0)
					{
						goto IL_002E;
					}
					goto IL_0256;
					IL_0104:
					this._typeNameAssemblyFormatHandling = original._typeNameAssemblyFormatHandling;
					goto IL_000D;
					IL_00F8:
					this._constructorHandling = original._constructorHandling;
					goto IL_0104;
					IL_00EC:
					this.ContractResolver = original.ContractResolver;
					goto IL_00F8;
					IL_00CB:
					this.EqualityComparer = original.EqualityComparer;
					num = 2;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d5af2cccac2f47ed978e804138a35d1c == 0)
					{
						goto IL_00EC;
					}
					goto IL_0256;
					IL_00BF:
					this.ReferenceResolverProvider = original.ReferenceResolverProvider;
					goto IL_00CB;
					IL_00B3:
					this._culture = original._culture;
					goto IL_00BF;
					IL_0121:
					this.TraceWriter = original.TraceWriter;
					goto IL_00B3;
					IL_013B:
					this._dateFormatHandling = original._dateFormatHandling;
					num = 15;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2e3be65f7cb2480482903dc73ec42f7c != 0)
					{
						goto IL_0121;
					}
					goto IL_0256;
					IL_012F:
					this._dateTimeZoneHandling = original._dateTimeZoneHandling;
					goto IL_013B;
					IL_01E5:
					this._dateParseHandling = original._dateParseHandling;
					goto IL_012F;
				}
			}
			IL_0316:
			this._stringEscapeHandling = original._stringEscapeHandling;
		}

		// Token: 0x0400025D RID: 605
		internal const ReferenceLoopHandling DefaultReferenceLoopHandling = ReferenceLoopHandling.Error;

		// Token: 0x0400025E RID: 606
		internal const MissingMemberHandling DefaultMissingMemberHandling = MissingMemberHandling.Ignore;

		// Token: 0x0400025F RID: 607
		internal const NullValueHandling DefaultNullValueHandling = NullValueHandling.Include;

		// Token: 0x04000260 RID: 608
		internal const DefaultValueHandling DefaultDefaultValueHandling = DefaultValueHandling.Include;

		// Token: 0x04000261 RID: 609
		internal const ObjectCreationHandling DefaultObjectCreationHandling = ObjectCreationHandling.Auto;

		// Token: 0x04000262 RID: 610
		internal const PreserveReferencesHandling DefaultPreserveReferencesHandling = PreserveReferencesHandling.None;

		// Token: 0x04000263 RID: 611
		internal const ConstructorHandling DefaultConstructorHandling = ConstructorHandling.Default;

		// Token: 0x04000264 RID: 612
		internal const TypeNameHandling DefaultTypeNameHandling = TypeNameHandling.None;

		// Token: 0x04000265 RID: 613
		internal const MetadataPropertyHandling DefaultMetadataPropertyHandling = MetadataPropertyHandling.Default;

		// Token: 0x04000266 RID: 614
		internal static readonly StreamingContext DefaultContext;

		// Token: 0x04000267 RID: 615
		internal const Formatting DefaultFormatting = Formatting.None;

		// Token: 0x04000268 RID: 616
		internal const DateFormatHandling DefaultDateFormatHandling = DateFormatHandling.IsoDateFormat;

		// Token: 0x04000269 RID: 617
		internal const DateTimeZoneHandling DefaultDateTimeZoneHandling = DateTimeZoneHandling.RoundtripKind;

		// Token: 0x0400026A RID: 618
		internal const DateParseHandling DefaultDateParseHandling = DateParseHandling.DateTime;

		// Token: 0x0400026B RID: 619
		internal const FloatParseHandling DefaultFloatParseHandling = FloatParseHandling.Double;

		// Token: 0x0400026C RID: 620
		internal const FloatFormatHandling DefaultFloatFormatHandling = FloatFormatHandling.String;

		// Token: 0x0400026D RID: 621
		internal const StringEscapeHandling DefaultStringEscapeHandling = StringEscapeHandling.Default;

		// Token: 0x0400026E RID: 622
		internal const TypeNameAssemblyFormatHandling DefaultTypeNameAssemblyFormatHandling = TypeNameAssemblyFormatHandling.Simple;

		// Token: 0x0400026F RID: 623
		[Nullable(1)]
		internal static readonly CultureInfo DefaultCulture;

		// Token: 0x04000270 RID: 624
		internal const bool DefaultCheckAdditionalContent = false;

		// Token: 0x04000271 RID: 625
		[Nullable(1)]
		internal const string DefaultDateFormatString = "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK";

		// Token: 0x04000272 RID: 626
		internal const int DefaultMaxDepth = 64;

		// Token: 0x04000273 RID: 627
		internal Formatting? _formatting;

		// Token: 0x04000274 RID: 628
		internal DateFormatHandling? _dateFormatHandling;

		// Token: 0x04000275 RID: 629
		internal DateTimeZoneHandling? _dateTimeZoneHandling;

		// Token: 0x04000276 RID: 630
		internal DateParseHandling? _dateParseHandling;

		// Token: 0x04000277 RID: 631
		internal FloatFormatHandling? _floatFormatHandling;

		// Token: 0x04000278 RID: 632
		internal FloatParseHandling? _floatParseHandling;

		// Token: 0x04000279 RID: 633
		internal StringEscapeHandling? _stringEscapeHandling;

		// Token: 0x0400027A RID: 634
		internal CultureInfo _culture;

		// Token: 0x0400027B RID: 635
		internal bool? _checkAdditionalContent;

		// Token: 0x0400027C RID: 636
		internal int? _maxDepth;

		// Token: 0x0400027D RID: 637
		internal bool _maxDepthSet;

		// Token: 0x0400027E RID: 638
		internal string _dateFormatString;

		// Token: 0x0400027F RID: 639
		internal bool _dateFormatStringSet;

		// Token: 0x04000280 RID: 640
		internal TypeNameAssemblyFormatHandling? _typeNameAssemblyFormatHandling;

		// Token: 0x04000281 RID: 641
		internal DefaultValueHandling? _defaultValueHandling;

		// Token: 0x04000282 RID: 642
		internal PreserveReferencesHandling? _preserveReferencesHandling;

		// Token: 0x04000283 RID: 643
		internal NullValueHandling? _nullValueHandling;

		// Token: 0x04000284 RID: 644
		internal ObjectCreationHandling? _objectCreationHandling;

		// Token: 0x04000285 RID: 645
		internal MissingMemberHandling? _missingMemberHandling;

		// Token: 0x04000286 RID: 646
		internal ReferenceLoopHandling? _referenceLoopHandling;

		// Token: 0x04000287 RID: 647
		internal StreamingContext? _context;

		// Token: 0x04000288 RID: 648
		internal ConstructorHandling? _constructorHandling;

		// Token: 0x04000289 RID: 649
		internal TypeNameHandling? _typeNameHandling;

		// Token: 0x0400028A RID: 650
		internal MetadataPropertyHandling? _metadataPropertyHandling;

		// Token: 0x0400028B RID: 651
		[CompilerGenerated]
		[Nullable(1)]
		private IList<JsonConverter> ilist_0;

		// Token: 0x0400028C RID: 652
		[CompilerGenerated]
		private IContractResolver icontractResolver_0;

		// Token: 0x0400028D RID: 653
		[CompilerGenerated]
		private IEqualityComparer iequalityComparer_0;

		// Token: 0x0400028E RID: 654
		[CompilerGenerated]
		private Func<GInterface1> func_0;

		// Token: 0x0400028F RID: 655
		[CompilerGenerated]
		private ITraceWriter itraceWriter_0;

		// Token: 0x04000290 RID: 656
		[CompilerGenerated]
		private GInterface2 ginterface2_0;

		// Token: 0x04000291 RID: 657
		[Nullable(new byte[] { 2, 1 })]
		[CompilerGenerated]
		private EventHandler<ErrorEventArgs> eventHandler_0;
	}
}
