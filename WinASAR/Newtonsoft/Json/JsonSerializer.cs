using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters;
using System.Threading;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json
{
	// Token: 0x02000065 RID: 101
	[NullableContext(1)]
	[Nullable(0)]
	public class JsonSerializer
	{
		// Token: 0x14000002 RID: 2
		// (add) Token: 0x0600036D RID: 877 RVA: 0x0002BFC4 File Offset: 0x0002A1C4
		// (remove) Token: 0x0600036E RID: 878 RVA: 0x0002BFFC File Offset: 0x0002A1FC
		[Nullable(new byte[] { 2, 1 })]
		public virtual event EventHandler<Newtonsoft.Json.Serialization.ErrorEventArgs> Error
		{
			[CompilerGenerated]
			add
			{
				EventHandler<Newtonsoft.Json.Serialization.ErrorEventArgs> eventHandler = this.eventHandler_0;
				EventHandler<Newtonsoft.Json.Serialization.ErrorEventArgs> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<Newtonsoft.Json.Serialization.ErrorEventArgs> eventHandler3 = (EventHandler<Newtonsoft.Json.Serialization.ErrorEventArgs>)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<Newtonsoft.Json.Serialization.ErrorEventArgs>>(ref this.eventHandler_0, eventHandler3, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			[CompilerGenerated]
			remove
			{
				EventHandler<Newtonsoft.Json.Serialization.ErrorEventArgs> eventHandler = this.eventHandler_0;
				EventHandler<Newtonsoft.Json.Serialization.ErrorEventArgs> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<Newtonsoft.Json.Serialization.ErrorEventArgs> eventHandler3 = (EventHandler<Newtonsoft.Json.Serialization.ErrorEventArgs>)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<Newtonsoft.Json.Serialization.ErrorEventArgs>>(ref this.eventHandler_0, eventHandler3, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x0600036F RID: 879 RVA: 0x00002E34 File Offset: 0x00001034
		// (set) Token: 0x06000370 RID: 880 RVA: 0x0002C034 File Offset: 0x0002A234
		[Nullable(2)]
		public virtual GInterface1 ReferenceResolver
		{
			[NullableContext(2)]
			get
			{
				return this.GetReferenceResolver();
			}
			[NullableContext(2)]
			set
			{
				for (;;)
				{
					int num;
					if (value == null)
					{
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_01137da6c88c4265bdc0297aacf3340f != 0)
						{
							break;
						}
					}
					else
					{
						this.ginterface1_0 = value;
						num = 2;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5be00c24d71649dcae8af3eed7b74ac9 == 0)
						{
							return;
						}
					}
					switch (num)
					{
					case 1:
						continue;
					case 2:
						return;
					}
					break;
				}
				throw new ArgumentNullException(Class15.smethod_17(2021163256 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4ac69ea2381b403582a2723337f67fa8), Class15.smethod_17(1243264124 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_67a271e0ae064fc7a3a74905868add95));
			}
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x06000371 RID: 881 RVA: 0x0002C0BC File Offset: 0x0002A2BC
		// (set) Token: 0x06000372 RID: 882 RVA: 0x0002C160 File Offset: 0x0002A360
		[Obsolete("Binder is obsolete. Use SerializationBinder instead.")]
		public virtual SerializationBinder Binder
		{
			get
			{
				SerializationBinderAdapter serializationBinderAdapter;
				for (;;)
				{
					IL_004B:
					SerializationBinder serializationBinder = this._serializationBinder as SerializationBinder;
					int num = 2;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9a2e459a49464219810a951679aea12e != 0)
					{
						break;
					}
					for (;;)
					{
						switch (num)
						{
						case 1:
							return serializationBinder;
						case 2:
							if (serializationBinder == null)
							{
								goto IL_0003;
							}
							return serializationBinder;
						case 3:
							goto IL_004B;
						case 4:
							goto IL_0003;
						case 5:
							goto IL_008F;
						}
						goto Block_3;
						IL_0003:
						serializationBinderAdapter = this._serializationBinder as SerializationBinderAdapter;
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_550a8fe2e5fe4cc19bdfe1a82a7f12b8 != 0)
						{
							goto Block_1;
						}
					}
				}
				Block_1:
				Block_3:
				if (serializationBinderAdapter == null)
				{
					throw new InvalidOperationException(Class15.smethod_17(1793860074 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0361b8eb39074ea88f5257b13904930a));
				}
				IL_008F:
				return serializationBinderAdapter.SerializationBinder;
			}
			set
			{
				while (value != null)
				{
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ae8c3d3c66a64b57beca0f5360302062 == 0)
					{
						switch (num)
						{
						case 1:
							continue;
						case 2:
							goto IL_004B;
						case 3:
							return;
						}
					}
					this._serializationBinder = (value as GInterface2) ?? new SerializationBinderAdapter(value);
					return;
				}
				IL_004B:
				throw new ArgumentNullException(Class15.smethod_17(2048529605 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e764f065c2fa404a85129e2e957d4f18), Class15.smethod_17(1387477268 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e5c1d856e0c64e6f8377f7d819e11923));
			}
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x06000373 RID: 883 RVA: 0x00002E3C File Offset: 0x0000103C
		// (set) Token: 0x06000374 RID: 884 RVA: 0x0002C1E8 File Offset: 0x0002A3E8
		public virtual GInterface2 SerializationBinder
		{
			get
			{
				return this._serializationBinder;
			}
			set
			{
				for (;;)
				{
					int num;
					if (value == null)
					{
						num = 1;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8db627a8c96145a0afb24deffd2a8808 == 0)
						{
							break;
						}
					}
					else
					{
						this._serializationBinder = value;
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3a299c01dd4f4a209bdbd1b98e3f1406 != 0)
						{
							break;
						}
					}
					switch (num)
					{
					case 1:
						goto IL_004C;
					case 2:
						continue;
					}
					break;
				}
				return;
				IL_004C:
				throw new ArgumentNullException(Class15.smethod_17(635802687 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a41eabd4b99f489fb7d86310d3f95ba2), Class15.smethod_17(2048524331 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e764f065c2fa404a85129e2e957d4f18));
			}
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x06000375 RID: 885 RVA: 0x00002E44 File Offset: 0x00001044
		// (set) Token: 0x06000376 RID: 886 RVA: 0x0002C274 File Offset: 0x0002A474
		[Nullable(2)]
		public virtual ITraceWriter TraceWriter
		{
			[NullableContext(2)]
			get
			{
				return this._traceWriter;
			}
			[NullableContext(2)]
			set
			{
				for (;;)
				{
					this._traceWriter = value;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0efaea2f67ca4b0aa2880fbd34fc0fff != 0)
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

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x06000377 RID: 887 RVA: 0x00002E4C File Offset: 0x0000104C
		// (set) Token: 0x06000378 RID: 888 RVA: 0x0002C2AC File Offset: 0x0002A4AC
		[Nullable(2)]
		public virtual IEqualityComparer EqualityComparer
		{
			[NullableContext(2)]
			get
			{
				return this._equalityComparer;
			}
			[NullableContext(2)]
			set
			{
				for (;;)
				{
					this._equalityComparer = value;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0efaea2f67ca4b0aa2880fbd34fc0fff != 0)
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

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x06000379 RID: 889 RVA: 0x00002E54 File Offset: 0x00001054
		// (set) Token: 0x0600037A RID: 890 RVA: 0x0002C2E4 File Offset: 0x0002A4E4
		public virtual TypeNameHandling TypeNameHandling
		{
			get
			{
				return this._typeNameHandling;
			}
			set
			{
				IL_0034:
				while (value >= TypeNameHandling.None)
				{
					while (value > TypeNameHandling.Auto)
					{
						int num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_aa43e77a676848e0bd70abf647d6a9f1 == 0)
						{
							goto IL_003C;
						}
						switch (num)
						{
						case 1:
						case 2:
							goto IL_003C;
						case 3:
							goto IL_0034;
						case 4:
							return;
						}
					}
					goto IL_0057;
					IL_003C:
					throw new ArgumentOutOfRangeException(Class15.smethod_17(1570990619 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3a299c01dd4f4a209bdbd1b98e3f1406));
					IL_0057:
					this._typeNameHandling = value;
					return;
				}
				goto IL_003C;
			}
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x0600037B RID: 891 RVA: 0x00002E5C File Offset: 0x0000105C
		// (set) Token: 0x0600037C RID: 892 RVA: 0x0002C350 File Offset: 0x0002A550
		[Obsolete("TypeNameAssemblyFormat is obsolete. Use TypeNameAssemblyFormatHandling instead.")]
		public virtual FormatterAssemblyStyle TypeNameAssemblyFormat
		{
			get
			{
				return (FormatterAssemblyStyle)this._typeNameAssemblyFormatHandling;
			}
			set
			{
				IL_0052:
				while (value >= FormatterAssemblyStyle.Simple)
				{
					for (;;)
					{
						int num;
						if (value > FormatterAssemblyStyle.Full)
						{
							num = 0;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_1db17fe7bd2442b599c52df89f39e610 == 0)
							{
								break;
							}
						}
						else
						{
							this._typeNameAssemblyFormatHandling = (TypeNameAssemblyFormatHandling)value;
							num = 2;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_832998aae3714af0a1270bf2bb566909 == 0)
							{
								break;
							}
						}
						switch (num)
						{
						case 1:
							continue;
						case 2:
							return;
						case 4:
							goto IL_0052;
						}
						break;
					}
					IL_005D:
					throw new ArgumentOutOfRangeException(Class15.smethod_17(926368931 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b2d935deb963472994f6f2321f1a6296));
				}
				goto IL_005D;
			}
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x0600037D RID: 893 RVA: 0x00002E5C File Offset: 0x0000105C
		// (set) Token: 0x0600037E RID: 894 RVA: 0x0002C3D8 File Offset: 0x0002A5D8
		public virtual TypeNameAssemblyFormatHandling TypeNameAssemblyFormatHandling
		{
			get
			{
				return this._typeNameAssemblyFormatHandling;
			}
			set
			{
				IL_0054:
				while (value >= TypeNameAssemblyFormatHandling.Simple)
				{
					while (value <= TypeNameAssemblyFormatHandling.Full)
					{
						int num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cf58136e49114a5691c4a9d0e9788de1 == 0)
						{
							goto IL_0015;
						}
						IL_002D:
						switch (num)
						{
						case 1:
							IL_0015:
							this._typeNameAssemblyFormatHandling = value;
							num = 0;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_11c6824de6514281a8425f6d6ab1a2d5 != 0)
							{
								goto IL_002D;
							}
							break;
						case 2:
							continue;
						case 3:
						case 5:
							goto IL_005E;
						case 4:
							goto IL_0054;
						}
						return;
					}
					IL_005E:
					throw new ArgumentOutOfRangeException(Class15.smethod_17(2008559467 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5c76a4eb2c1748d1bee3513c8eaff2eb));
				}
				goto IL_005E;
			}
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x0600037F RID: 895 RVA: 0x00002E64 File Offset: 0x00001064
		// (set) Token: 0x06000380 RID: 896 RVA: 0x0002C460 File Offset: 0x0002A660
		public virtual PreserveReferencesHandling PreserveReferencesHandling
		{
			get
			{
				return this._preserveReferencesHandling;
			}
			set
			{
				for (;;)
				{
					if (value >= PreserveReferencesHandling.None)
					{
						goto IL_0034;
					}
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2a74c5ebb7d84adcad853e2eda393dc4 == 0)
					{
						break;
					}
					IL_001B:
					switch (num)
					{
					default:
						IL_0034:
						if (value > PreserveReferencesHandling.All)
						{
							goto Block_1;
						}
						this._preserveReferencesHandling = value;
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8db627a8c96145a0afb24deffd2a8808 == 0)
						{
							goto IL_001B;
						}
						return;
					case 1:
					case 4:
						goto IL_0057;
					case 2:
						break;
					case 3:
						return;
					}
				}
				Block_1:
				IL_0057:
				throw new ArgumentOutOfRangeException(Class15.smethod_17(1603801634 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d5af2cccac2f47ed978e804138a35d1c));
			}
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x06000381 RID: 897 RVA: 0x00002E6C File Offset: 0x0000106C
		// (set) Token: 0x06000382 RID: 898 RVA: 0x0002C4E0 File Offset: 0x0002A6E0
		public virtual ReferenceLoopHandling ReferenceLoopHandling
		{
			get
			{
				return this._referenceLoopHandling;
			}
			set
			{
				for (;;)
				{
					if (value >= ReferenceLoopHandling.Error)
					{
						goto IL_003B;
					}
					int num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_193800745ad94a529d9e5edc977c4f02 != 0)
					{
						break;
					}
					IL_001B:
					switch (num)
					{
					case 1:
					case 5:
						goto IL_0063;
					case 2:
						continue;
					case 3:
						goto IL_0003;
					case 4:
						IL_003B:
						if (value <= ReferenceLoopHandling.Serialize)
						{
							goto IL_0003;
						}
						goto IL_0063;
					}
					break;
					IL_0003:
					this._referenceLoopHandling = value;
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b3c865ee224546b18f2991d2a8895f6a != 0)
					{
						goto IL_001B;
					}
					break;
				}
				return;
				IL_0063:
				throw new ArgumentOutOfRangeException(Class15.smethod_17(676705590 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa49bb51056944098afe92e3a80a544b));
			}
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x06000383 RID: 899 RVA: 0x00002E74 File Offset: 0x00001074
		// (set) Token: 0x06000384 RID: 900 RVA: 0x0002C56C File Offset: 0x0002A76C
		public virtual MissingMemberHandling MissingMemberHandling
		{
			get
			{
				return this._missingMemberHandling;
			}
			set
			{
				IL_004E:
				while (value >= MissingMemberHandling.Ignore)
				{
					for (;;)
					{
						int num;
						if (value > MissingMemberHandling.Error)
						{
							num = 1;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c5a086ee5649458eb5e1e6e4f0f1f4d3 == 0)
							{
								goto Block_2;
							}
						}
						else
						{
							this._missingMemberHandling = value;
							num = 0;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8db627a8c96145a0afb24deffd2a8808 == 0)
							{
								break;
							}
						}
						switch (num)
						{
						case 1:
							goto IL_005B;
						case 2:
							continue;
						case 3:
							goto IL_004E;
						}
						break;
					}
					return;
					Block_2:
					break;
				}
				IL_005B:
				throw new ArgumentOutOfRangeException(Class15.smethod_17(1985303068 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f19acd91a8c44846a95d09d7dc3da2ba));
			}
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x06000385 RID: 901 RVA: 0x00002E7C File Offset: 0x0000107C
		// (set) Token: 0x06000386 RID: 902 RVA: 0x0002C5F0 File Offset: 0x0002A7F0
		public virtual NullValueHandling NullValueHandling
		{
			get
			{
				return this._nullValueHandling;
			}
			set
			{
				while (value >= NullValueHandling.Include)
				{
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e5c1d856e0c64e6f8377f7d819e11923 == 0)
					{
						goto IL_0015;
					}
					IL_002A:
					switch (num)
					{
					case 1:
						continue;
					case 2:
						goto IL_0055;
					case 3:
						return;
					}
					IL_0015:
					if (value > NullValueHandling.Ignore)
					{
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_1db17fe7bd2442b599c52df89f39e610 == 0)
						{
							goto IL_002A;
						}
						break;
					}
					else
					{
						this._nullValueHandling = value;
					}
					return;
				}
				IL_0055:
				throw new ArgumentOutOfRangeException(Class15.smethod_17(2128217000 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_871a407507f34aa3b5bf52517d4f63a9));
			}
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x06000387 RID: 903 RVA: 0x00002E84 File Offset: 0x00001084
		// (set) Token: 0x06000388 RID: 904 RVA: 0x0002C670 File Offset: 0x0002A870
		public virtual DefaultValueHandling DefaultValueHandling
		{
			get
			{
				return this._defaultValueHandling;
			}
			set
			{
				IL_0050:
				while (value >= DefaultValueHandling.Include)
				{
					for (;;)
					{
						int num;
						if (value > DefaultValueHandling.IgnoreAndPopulate)
						{
							num = 2;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3cf8a2073cc248c2915ebb05bcd2a099 != 0)
							{
								continue;
							}
						}
						else
						{
							this._defaultValueHandling = value;
							num = 0;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5c76a4eb2c1748d1bee3513c8eaff2eb != 0)
							{
								break;
							}
						}
						switch (num)
						{
						case 1:
							continue;
						case 2:
						case 3:
							goto IL_0054;
						case 4:
							goto IL_0050;
						}
						break;
					}
					return;
				}
				IL_0054:
				throw new ArgumentOutOfRangeException(Class15.smethod_17(1243259362 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_67a271e0ae064fc7a3a74905868add95));
			}
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x06000389 RID: 905 RVA: 0x00002E8C File Offset: 0x0000108C
		// (set) Token: 0x0600038A RID: 906 RVA: 0x0002C6F0 File Offset: 0x0002A8F0
		public virtual ObjectCreationHandling ObjectCreationHandling
		{
			get
			{
				return this._objectCreationHandling;
			}
			set
			{
				for (;;)
				{
					if (value >= ObjectCreationHandling.Auto)
					{
						goto IL_0034;
					}
					int num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8db627a8c96145a0afb24deffd2a8808 != 0)
					{
						goto Block_3;
					}
					IL_0014:
					switch (num)
					{
					case 1:
					case 5:
						goto IL_0063;
					case 2:
						continue;
					case 3:
						return;
					case 4:
						IL_0034:
						if (value > ObjectCreationHandling.Replace)
						{
							goto IL_0063;
						}
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3dc45d1ecdeb4859b7f470093f5eeed2 != 0)
						{
							goto IL_0014;
						}
						break;
					}
					break;
				}
				goto IL_005A;
				Block_3:
				goto IL_0063;
				IL_005A:
				this._objectCreationHandling = value;
				return;
				IL_0063:
				throw new ArgumentOutOfRangeException(Class15.smethod_17(1793865148 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0361b8eb39074ea88f5257b13904930a));
			}
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x0600038B RID: 907 RVA: 0x00002E94 File Offset: 0x00001094
		// (set) Token: 0x0600038C RID: 908 RVA: 0x0002C77C File Offset: 0x0002A97C
		public virtual ConstructorHandling ConstructorHandling
		{
			get
			{
				return this._constructorHandling;
			}
			set
			{
				while (value >= ConstructorHandling.Default)
				{
					int num = 2;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7dfc957a76cb4c58b17dc74a084c4e4a != 0)
					{
						goto IL_0015;
					}
					IL_0043:
					switch (num)
					{
					case 1:
						return;
					case 2:
						goto IL_0069;
					case 3:
						IL_0015:
						if (value > ConstructorHandling.AllowNonPublicDefaultConstructor)
						{
							goto IL_0069;
						}
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_afb77be96d644a2297c7f9466cb06ede == 0)
						{
							goto IL_0043;
						}
						break;
					case 4:
						continue;
					}
					this._constructorHandling = value;
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_67a271e0ae064fc7a3a74905868add95 != 0)
					{
						goto IL_0043;
					}
					return;
				}
				IL_0069:
				throw new ArgumentOutOfRangeException(Class15.smethod_17(974439475 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_92ac2a37edba4e2587eb1b9e8af3f63f));
			}
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x0600038D RID: 909 RVA: 0x00002E9C File Offset: 0x0000109C
		// (set) Token: 0x0600038E RID: 910 RVA: 0x0002C810 File Offset: 0x0002AA10
		public virtual MetadataPropertyHandling MetadataPropertyHandling
		{
			get
			{
				return this._metadataPropertyHandling;
			}
			set
			{
				for (;;)
				{
					if (value >= MetadataPropertyHandling.Default)
					{
						goto IL_004D;
					}
					int num = 4;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_550a8fe2e5fe4cc19bdfe1a82a7f12b8 != 0)
					{
						goto IL_004D;
					}
					IL_002D:
					switch (num)
					{
					case 1:
						return;
					case 2:
						goto IL_0015;
					case 3:
						IL_004D:
						if (value <= MetadataPropertyHandling.Ignore)
						{
							num = 2;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5c76a4eb2c1748d1bee3513c8eaff2eb != 0)
							{
								goto IL_0015;
							}
							goto IL_002D;
						}
						break;
					case 5:
						continue;
					}
					break;
					IL_0015:
					this._metadataPropertyHandling = value;
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0efaea2f67ca4b0aa2880fbd34fc0fff == 0)
					{
						goto IL_002D;
					}
					goto IL_006F;
				}
				goto IL_0072;
				IL_006F:
				return;
				IL_0072:
				throw new ArgumentOutOfRangeException(Class15.smethod_17(1270975900 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0005996a6a494de4880ac2956b2e0112));
			}
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x0600038F RID: 911 RVA: 0x0002C8AC File Offset: 0x0002AAAC
		public virtual JsonConverterCollection Converters
		{
			get
			{
				while (this._converters != null)
				{
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9a2e459a49464219810a951679aea12e != 0)
					{
						switch (num)
						{
						case 1:
							continue;
						case 2:
							goto IL_003A;
						}
					}
					IL_0045:
					return this._converters;
				}
				IL_003A:
				this._converters = new JsonConverterCollection();
				goto IL_0045;
			}
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x06000390 RID: 912 RVA: 0x00002EA4 File Offset: 0x000010A4
		// (set) Token: 0x06000391 RID: 913 RVA: 0x0002C904 File Offset: 0x0002AB04
		public virtual IContractResolver ContractResolver
		{
			get
			{
				return this._contractResolver;
			}
			set
			{
				for (;;)
				{
					this._contractResolver = value ?? DefaultContractResolver.Instance;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c27e9fccdfcc44999155a4980faa4e81 == 0)
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

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x06000392 RID: 914 RVA: 0x00002EAC File Offset: 0x000010AC
		// (set) Token: 0x06000393 RID: 915 RVA: 0x0002C944 File Offset: 0x0002AB44
		public virtual StreamingContext Context
		{
			get
			{
				return this._context;
			}
			set
			{
				for (;;)
				{
					this._context = value;
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

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x06000394 RID: 916 RVA: 0x00002EB4 File Offset: 0x000010B4
		// (set) Token: 0x06000395 RID: 917 RVA: 0x0002C97C File Offset: 0x0002AB7C
		public virtual Formatting Formatting
		{
			get
			{
				return this.nullable_0.GetValueOrDefault();
			}
			set
			{
				for (;;)
				{
					this.nullable_0 = new Formatting?(value);
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0efaea2f67ca4b0aa2880fbd34fc0fff != 0)
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

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x06000396 RID: 918 RVA: 0x00002EC1 File Offset: 0x000010C1
		// (set) Token: 0x06000397 RID: 919 RVA: 0x0002C9B8 File Offset: 0x0002ABB8
		public virtual DateFormatHandling DateFormatHandling
		{
			get
			{
				return this.nullable_1.GetValueOrDefault();
			}
			set
			{
				for (;;)
				{
					this.nullable_1 = new DateFormatHandling?(value);
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_bc7a9075386042ad9ce36653fcde3fc3 != 0)
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

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x06000398 RID: 920 RVA: 0x0002C9F4 File Offset: 0x0002ABF4
		// (set) Token: 0x06000399 RID: 921 RVA: 0x0002CA60 File Offset: 0x0002AC60
		public virtual DateTimeZoneHandling DateTimeZoneHandling
		{
			get
			{
				DateTimeZoneHandling? dateTimeZoneHandling;
				for (;;)
				{
					dateTimeZoneHandling = this.nullable_2;
					int num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39a47a907a8a440980940ae96da3f3ad == 0)
					{
						goto IL_0003;
					}
					IL_001D:
					switch (num)
					{
					case 1:
						IL_0003:
						if (dateTimeZoneHandling != null)
						{
							num = 1;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ee35a23edd8f4998990ec1a2b40fc61a == 0)
							{
								goto IL_001D;
							}
							goto IL_0051;
						}
						break;
					case 2:
						continue;
					case 3:
						goto IL_0056;
					}
					break;
				}
				return DateTimeZoneHandling.RoundtripKind;
				IL_0051:
				IL_0056:
				return dateTimeZoneHandling.GetValueOrDefault();
			}
			set
			{
				for (;;)
				{
					this.nullable_2 = new DateTimeZoneHandling?(value);
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_75738dd4edc84122bfe3748a1ea03d43 == 0)
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

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x0600039A RID: 922 RVA: 0x0002CA9C File Offset: 0x0002AC9C
		// (set) Token: 0x0600039B RID: 923 RVA: 0x0002CB04 File Offset: 0x0002AD04
		public virtual DateParseHandling DateParseHandling
		{
			get
			{
				DateParseHandling? dateParseHandling;
				for (;;)
				{
					dateParseHandling = this.nullable_3;
					int num = 2;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39a47a907a8a440980940ae96da3f3ad != 0)
					{
						goto IL_0003;
					}
					IL_001D:
					switch (num)
					{
					case 1:
						goto IL_0052;
					case 2:
						IL_0003:
						if (dateParseHandling != null)
						{
							num = 0;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_550a8fe2e5fe4cc19bdfe1a82a7f12b8 != 0)
							{
								goto IL_001D;
							}
							goto IL_0051;
						}
						break;
					case 3:
						continue;
					}
					break;
				}
				return DateParseHandling.DateTime;
				IL_0051:
				IL_0052:
				return dateParseHandling.GetValueOrDefault();
			}
			set
			{
				for (;;)
				{
					this.nullable_3 = new DateParseHandling?(value);
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_193800745ad94a529d9e5edc977c4f02 == 0)
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

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x0600039C RID: 924 RVA: 0x00002ECE File Offset: 0x000010CE
		// (set) Token: 0x0600039D RID: 925 RVA: 0x0002CB40 File Offset: 0x0002AD40
		public virtual FloatParseHandling FloatParseHandling
		{
			get
			{
				return this.nullable_5.GetValueOrDefault();
			}
			set
			{
				for (;;)
				{
					this.nullable_5 = new FloatParseHandling?(value);
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

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x0600039E RID: 926 RVA: 0x00002EDB File Offset: 0x000010DB
		// (set) Token: 0x0600039F RID: 927 RVA: 0x0002CB7C File Offset: 0x0002AD7C
		public virtual FloatFormatHandling FloatFormatHandling
		{
			get
			{
				return this.nullable_4.GetValueOrDefault();
			}
			set
			{
				for (;;)
				{
					this.nullable_4 = new FloatFormatHandling?(value);
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

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x060003A0 RID: 928 RVA: 0x00002EE8 File Offset: 0x000010E8
		// (set) Token: 0x060003A1 RID: 929 RVA: 0x0002CBB8 File Offset: 0x0002ADB8
		public virtual StringEscapeHandling StringEscapeHandling
		{
			get
			{
				return this.nullable_6.GetValueOrDefault();
			}
			set
			{
				for (;;)
				{
					this.nullable_6 = new StringEscapeHandling?(value);
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7ae4da5a55de471eb12dd0de8dd4269c != 0)
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

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x060003A2 RID: 930 RVA: 0x0002CBF4 File Offset: 0x0002ADF4
		// (set) Token: 0x060003A3 RID: 931 RVA: 0x0002CC44 File Offset: 0x0002AE44
		public virtual string DateFormatString
		{
			get
			{
				string text;
				while ((text = this.string_0) == null)
				{
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e764f065c2fa404a85129e2e957d4f18 != 0)
					{
						switch (num)
						{
						case 1:
							continue;
						}
					}
					text = Class15.smethod_17(486533768 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39d5fbfa4fe34ed9908db538e5340a6c);
					break;
				}
				return text;
			}
			set
			{
				for (;;)
				{
					this.string_0 = value;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c5a086ee5649458eb5e1e6e4f0f1f4d3 == 0)
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
					this.bool_1 = true;
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_bc7a9075386042ad9ce36653fcde3fc3 != 0)
					{
						goto IL_001B;
					}
					break;
				}
			}
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x060003A4 RID: 932 RVA: 0x0002CC9C File Offset: 0x0002AE9C
		// (set) Token: 0x060003A5 RID: 933 RVA: 0x0002CCDC File Offset: 0x0002AEDC
		public virtual CultureInfo Culture
		{
			get
			{
				CultureInfo defaultCulture;
				while ((defaultCulture = this.cultureInfo_0) == null)
				{
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4152404f503b492c83d9bc2e44bdd0a7 != 0)
					{
						switch (num)
						{
						case 1:
							continue;
						}
					}
					defaultCulture = JsonSerializerSettings.DefaultCulture;
					break;
				}
				return defaultCulture;
			}
			set
			{
				for (;;)
				{
					this.cultureInfo_0 = value;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ae8c3d3c66a64b57beca0f5360302062 != 0)
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

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x060003A6 RID: 934 RVA: 0x00002EF5 File Offset: 0x000010F5
		// (set) Token: 0x060003A7 RID: 935 RVA: 0x0002CD14 File Offset: 0x0002AF14
		public virtual int? MaxDepth
		{
			get
			{
				return this.nullable_7;
			}
			set
			{
				int? num = value;
				if ((num.GetValueOrDefault() <= 0) & (num != null))
				{
					throw new ArgumentException(Class15.smethod_17(1396564410 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4152404f503b492c83d9bc2e44bdd0a7), Class15.smethod_17(1985303068 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f19acd91a8c44846a95d09d7dc3da2ba));
				}
				this.nullable_7 = value;
				this.bool_0 = true;
			}
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x060003A8 RID: 936 RVA: 0x00002EFD File Offset: 0x000010FD
		// (set) Token: 0x060003A9 RID: 937 RVA: 0x0002CD78 File Offset: 0x0002AF78
		public virtual bool CheckAdditionalContent
		{
			get
			{
				return this.nullable_8.GetValueOrDefault();
			}
			set
			{
				for (;;)
				{
					this.nullable_8 = new bool?(value);
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_186d640068094cc595a341ef95c9a29a != 0)
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

		// Token: 0x060003AA RID: 938 RVA: 0x00002F0A File Offset: 0x0000110A
		internal bool IsCheckAdditionalContentSet()
		{
			return this.nullable_8 != null;
		}

		// Token: 0x060003AB RID: 939 RVA: 0x0002CDB4 File Offset: 0x0002AFB4
		public JsonSerializer()
		{
			int num = 7;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_100d09ce3850492c8356d7fa1e667d54 == 0)
			{
				goto IL_00F0;
			}
			for (;;)
			{
				IL_0127:
				switch (num)
				{
				case 1:
					goto IL_008B;
				case 2:
					return;
				case 3:
					goto IL_00F0;
				case 4:
					goto IL_0029;
				case 5:
					goto IL_0092;
				case 6:
					goto IL_0034;
				case 7:
					this._referenceLoopHandling = ReferenceLoopHandling.Error;
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_aa43e77a676848e0bd70abf647d6a9f1 == 0)
					{
						goto IL_00B7;
					}
					continue;
				case 8:
					goto IL_0099;
				case 9:
					goto IL_00B7;
				case 10:
					goto IL_003F;
				case 11:
					this._nullValueHandling = NullValueHandling.Include;
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8bcabc342a5a44748f3978da7f62051e != 0)
					{
						goto IL_008B;
					}
					continue;
				case 12:
					goto IL_004A;
				case 13:
					goto IL_0022;
				}
				goto Block_7;
				IL_0099:
				this._preserveReferencesHandling = PreserveReferencesHandling.None;
				num = 3;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bd75de9a0b64d6da3a43e57303102f1 == 0)
				{
					break;
				}
				continue;
				IL_0092:
				this._objectCreationHandling = ObjectCreationHandling.Auto;
				goto IL_0099;
				IL_008B:
				this._defaultValueHandling = DefaultValueHandling.Include;
				goto IL_0092;
				IL_00B7:
				this._missingMemberHandling = MissingMemberHandling.Ignore;
				num = 11;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a41eabd4b99f489fb7d86310d3f95ba2 == 0)
				{
					goto Block_4;
				}
			}
			return;
			Block_4:
			goto IL_0034;
			Block_7:
			goto IL_0109;
			IL_0022:
			this._metadataPropertyHandling = MetadataPropertyHandling.Default;
			IL_0029:
			this._context = JsonSerializerSettings.DefaultContext;
			IL_0034:
			this._serializationBinder = DefaultSerializationBinder.Instance;
			IL_003F:
			this.cultureInfo_0 = JsonSerializerSettings.DefaultCulture;
			IL_004A:
			this._contractResolver = DefaultContractResolver.Instance;
			num = 2;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_11c6824de6514281a8425f6d6ab1a2d5 != 0)
			{
				return;
			}
			goto IL_0127;
			IL_00F0:
			this._constructorHandling = ConstructorHandling.Default;
			num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d97e64d0f425406b9649f2b4562a5f0e != 0)
			{
				goto IL_0127;
			}
			IL_0109:
			this._typeNameHandling = TypeNameHandling.None;
			num = 10;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b17e63564ae246399767b60cf4b1528a == 0)
			{
				goto IL_0022;
			}
			goto IL_0127;
		}

		// Token: 0x060003AC RID: 940 RVA: 0x00002F17 File Offset: 0x00001117
		public static JsonSerializer Create()
		{
			return new JsonSerializer();
		}

		// Token: 0x060003AD RID: 941 RVA: 0x0002CF2C File Offset: 0x0002B12C
		public static JsonSerializer Create([Nullable(2)] JsonSerializerSettings settings)
		{
			JsonSerializer jsonSerializer;
			for (;;)
			{
				IL_003B:
				jsonSerializer = new JsonSerializer();
				int num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_1db17fe7bd2442b599c52df89f39e610 == 0)
				{
					break;
				}
				for (;;)
				{
					switch (num)
					{
					case 1:
					case 4:
						return jsonSerializer;
					case 2:
						if (settings == null)
						{
							return jsonSerializer;
						}
						break;
					case 3:
						goto IL_003B;
					}
					JsonSerializer.smethod_0(jsonSerializer, settings);
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9f5329f120e842948536b8235793166c == 0)
					{
						return jsonSerializer;
					}
				}
			}
			return jsonSerializer;
		}

		// Token: 0x060003AE RID: 942 RVA: 0x0002CF94 File Offset: 0x0002B194
		public static JsonSerializer CreateDefault()
		{
			Func<JsonSerializerSettings> defaultSettings;
			for (;;)
			{
				defaultSettings = JsonConvert.DefaultSettings;
				if (defaultSettings != null)
				{
					goto IL_002F;
				}
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0efaea2f67ca4b0aa2880fbd34fc0fff == 0)
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
			JsonSerializerSettings jsonSerializerSettings = null;
			goto IL_0034;
			IL_002F:
			jsonSerializerSettings = defaultSettings();
			IL_0034:
			return JsonSerializer.Create(jsonSerializerSettings);
		}

		// Token: 0x060003AF RID: 943 RVA: 0x0002CFDC File Offset: 0x0002B1DC
		public static JsonSerializer CreateDefault([Nullable(2)] JsonSerializerSettings settings)
		{
			JsonSerializer jsonSerializer;
			for (;;)
			{
				IL_0041:
				jsonSerializer = JsonSerializer.CreateDefault();
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0361b8eb39074ea88f5257b13904930a == 0)
				{
					break;
				}
				for (;;)
				{
					switch (num)
					{
					case 1:
						if (settings != null)
						{
							goto IL_0003;
						}
						break;
					case 2:
						goto IL_0041;
					case 3:
						goto IL_0003;
					}
					return jsonSerializer;
					IL_0003:
					JsonSerializer.smethod_0(jsonSerializer, settings);
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e5c1d856e0c64e6f8377f7d819e11923 != 0)
					{
						return jsonSerializer;
					}
				}
			}
			return jsonSerializer;
		}

		// Token: 0x060003B0 RID: 944 RVA: 0x0002D048 File Offset: 0x0002B248
		private static void smethod_0(JsonSerializer jsonSerializer_0, object object_0)
		{
			for (;;)
			{
				IL_06AB:
				if (!CollectionUtils.IsNullOrEmpty<JsonConverter>(object_0.Converters))
				{
					goto IL_04B4;
				}
				goto IL_069B;
				int num;
				for (;;)
				{
					IL_04D6:
					switch (num)
					{
					case 1:
					case 3:
						goto IL_029C;
					case 2:
					case 35:
						goto IL_0645;
					case 4:
						goto IL_02EF;
					case 5:
						goto IL_06BE;
					case 6:
						goto IL_0408;
					case 7:
					case 28:
						goto IL_017A;
					case 8:
						goto IL_03C3;
					case 9:
						goto IL_04BC;
					case 10:
						goto IL_01D0;
					case 11:
						goto IL_0331;
					case 12:
						goto IL_0226;
					case 13:
					case 16:
						return;
					case 14:
						goto IL_0246;
					case 15:
						goto IL_0006;
					case 17:
						goto IL_02BA;
					case 18:
						goto IL_0113;
					case 19:
						goto IL_068B;
					case 20:
						goto IL_0666;
					case 21:
					case 47:
						goto IL_0167;
					case 22:
						goto IL_0190;
					case 23:
					case 36:
						goto IL_03EF;
					case 24:
						goto IL_04B4;
					case 25:
						goto IL_06AB;
					case 26:
						goto IL_02FB;
					case 27:
						goto IL_00E3;
					case 30:
						goto IL_015B;
					case 31:
					case 68:
						goto IL_0273;
					case 32:
						goto IL_006A;
					case 33:
						goto IL_0106;
					case 34:
						goto IL_011F;
					case 37:
					case 43:
						goto IL_025F;
					case 38:
						goto IL_02B2;
					case 39:
						goto IL_0418;
					case 40:
					case 66:
						goto IL_02E2;
					case 41:
						goto IL_01B4;
					case 42:
					case 54:
						goto IL_01C0;
					case 44:
					case 62:
						goto IL_0461;
					case 45:
						goto IL_0494;
					case 46:
					case 80:
						goto IL_0040;
					case 48:
						goto IL_014B;
					case 49:
						goto IL_030B;
					case 50:
						goto IL_03FC;
					case 51:
						goto IL_0232;
					case 52:
					case 61:
						goto IL_03A9;
					case 53:
						goto IL_00C2;
					case 55:
						goto IL_012A;
					case 56:
						goto IL_023A;
					case 57:
						goto IL_00B1;
					case 58:
					case 78:
						goto IL_0397;
					case 59:
						jsonSerializer_0.TypeNameAssemblyFormatHandling = object_0.TypeNameAssemblyFormatHandling;
						num = 6;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_11c6824de6514281a8425f6d6ab1a2d5 == 0)
						{
							goto Block_24;
						}
						continue;
					case 60:
					case 67:
						goto IL_02C6;
					case 63:
						goto IL_024E;
					case 64:
						jsonSerializer_0.nullable_8 = object_0._checkAdditionalContent;
						num = 8;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f77f8ab5a3534e2e914063d52217b4e1 == 0)
						{
							goto Block_22;
						}
						continue;
					case 65:
					case 76:
						goto IL_0016;
					case 69:
						goto IL_02D6;
					case 70:
						goto IL_06CA;
					case 71:
						goto IL_027B;
					case 72:
						goto IL_03E3;
					case 73:
						goto IL_008B;
					case 74:
						goto IL_0267;
					case 75:
						goto IL_0658;
					case 77:
						goto IL_069B;
					case 79:
						goto IL_0206;
					}
					goto Block_26;
				}
				Block_24:
				goto IL_0006;
				Block_26:
				goto IL_0352;
				Block_22:
				goto IL_01D0;
				IL_0016:
				if (object_0._referenceLoopHandling != null)
				{
					goto IL_04BC;
				}
				num = 24;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4b8a72ce901241b5b52fe60600cb3607 == 0)
				{
					goto IL_0461;
				}
				goto IL_04D6;
				IL_0006:
				if (object_0._preserveReferencesHandling == null)
				{
					goto IL_0016;
				}
				goto IL_0494;
				IL_0040:
				if (object_0._dateParseHandling != null)
				{
					goto IL_0331;
				}
				num = 29;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8bcabc342a5a44748f3978da7f62051e == 0)
				{
					goto IL_0352;
				}
				goto IL_04D6;
				IL_02FB:
				if (object_0._dateTimeZoneHandling != null)
				{
					goto IL_030B;
				}
				goto IL_0040;
				IL_02EF:
				jsonSerializer_0.nullable_1 = object_0._dateFormatHandling;
				goto IL_02FB;
				IL_02E2:
				if (object_0._dateFormatHandling != null)
				{
					goto IL_02EF;
				}
				goto IL_02FB;
				IL_02D6:
				jsonSerializer_0.nullable_0 = object_0._formatting;
				goto IL_02E2;
				IL_02C6:
				if (object_0._formatting != null)
				{
					goto IL_02D6;
				}
				num = 40;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e764f065c2fa404a85129e2e957d4f18 == 0)
				{
					goto IL_0645;
				}
				goto IL_04D6;
				IL_02BA:
				jsonSerializer_0.SerializationBinder = object_0.SerializationBinder;
				goto IL_02C6;
				IL_02B2:
				if (object_0.SerializationBinder != null)
				{
					goto IL_02BA;
				}
				goto IL_02C6;
				IL_0273:
				if (object_0.EqualityComparer != null)
				{
					goto IL_027B;
				}
				goto IL_02B2;
				IL_0267:
				jsonSerializer_0.TraceWriter = object_0.TraceWriter;
				goto IL_0273;
				IL_025F:
				if (object_0.TraceWriter != null)
				{
					goto IL_0267;
				}
				goto IL_0273;
				IL_0246:
				if (object_0.ReferenceResolverProvider != null)
				{
					goto IL_024E;
				}
				goto IL_025F;
				IL_0232:
				if (object_0.ContractResolver != null)
				{
					goto IL_023A;
				}
				goto IL_0246;
				IL_01D0:
				if (object_0.Error == null)
				{
					goto IL_0232;
				}
				num = 4;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_17bdafd603b54a77a2e4a383bd4dcffa == 0)
				{
					goto IL_0226;
				}
				goto IL_04D6;
				IL_01C0:
				if (object_0._checkAdditionalContent == null)
				{
					goto IL_01D0;
				}
				num = 64;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3baf10aa2a73406aa2bb349717d797c7 == 0)
				{
					goto IL_0645;
				}
				goto IL_04D6;
				IL_006A:
				jsonSerializer_0.string_0 = object_0._dateFormatString;
				num = 41;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_550a8fe2e5fe4cc19bdfe1a82a7f12b8 == 0)
				{
					goto IL_008B;
				}
				goto IL_04D6;
				IL_0352:
				if (!object_0._dateFormatStringSet)
				{
					goto IL_029C;
				}
				goto IL_006A;
				IL_008B:
				jsonSerializer_0.bool_1 = object_0._dateFormatStringSet;
				num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ca6ac77a767741aa91cb31f8080f093b != 0)
				{
					goto IL_029C;
				}
				goto IL_04D6;
				IL_00C2:
				jsonSerializer_0.nullable_5 = object_0._floatParseHandling;
				num = 33;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8bcabc342a5a44748f3978da7f62051e == 0)
				{
					goto IL_00E3;
				}
				goto IL_04D6;
				IL_017A:
				if (object_0._floatParseHandling == null)
				{
					goto IL_0106;
				}
				goto IL_00C2;
				IL_029C:
				if (object_0._floatFormatHandling == null)
				{
					goto IL_017A;
				}
				IL_00B1:
				jsonSerializer_0.nullable_4 = object_0._floatFormatHandling;
				goto IL_017A;
				IL_00E3:
				jsonSerializer_0.ConstructorHandling = object_0.ConstructorHandling;
				num = 22;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_991c06e999c744809f5b643cb7d9e7b4 == 0)
				{
					goto IL_017A;
				}
				goto IL_04D6;
				IL_0167:
				if (object_0._constructorHandling == null)
				{
					goto IL_0190;
				}
				goto IL_00E3;
				IL_015B:
				jsonSerializer_0.DefaultValueHandling = object_0.DefaultValueHandling;
				goto IL_0167;
				IL_014B:
				if (object_0._defaultValueHandling != null)
				{
					goto IL_015B;
				}
				num = 47;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3a299c01dd4f4a209bdbd1b98e3f1406 == 0)
				{
					goto IL_025F;
				}
				goto IL_04D6;
				IL_0408:
				if (object_0._nullValueHandling != null)
				{
					goto IL_0418;
				}
				goto IL_014B;
				IL_03FC:
				jsonSerializer_0.ObjectCreationHandling = object_0.ObjectCreationHandling;
				goto IL_0408;
				IL_03EF:
				if (object_0._objectCreationHandling != null)
				{
					goto IL_03FC;
				}
				goto IL_0408;
				IL_0461:
				if (object_0._missingMemberHandling != null)
				{
					goto IL_03E3;
				}
				goto IL_03EF;
				IL_04BC:
				jsonSerializer_0.ReferenceLoopHandling = object_0.ReferenceLoopHandling;
				goto IL_0461;
				IL_03E3:
				jsonSerializer_0.MissingMemberHandling = object_0.MissingMemberHandling;
				goto IL_03EF;
				IL_012A:
				jsonSerializer_0.cultureInfo_0 = object_0._culture;
				num = 79;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5dadf4f8cc824060ae20e1ee9bbca82a != 0)
				{
					goto IL_014B;
				}
				goto IL_04D6;
				IL_011F:
				if (object_0._culture != null)
				{
					goto IL_012A;
				}
				goto IL_0206;
				IL_0113:
				jsonSerializer_0.nullable_6 = object_0._stringEscapeHandling;
				goto IL_011F;
				IL_0106:
				if (object_0._stringEscapeHandling != null)
				{
					goto IL_0113;
				}
				goto IL_011F;
				IL_0190:
				if (object_0._context != null)
				{
					goto IL_01B4;
				}
				num = 4;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ae8c3d3c66a64b57beca0f5360302062 == 0)
				{
					goto IL_01C0;
				}
				goto IL_04D6;
				IL_0206:
				if (object_0._maxDepthSet)
				{
					break;
				}
				num = 13;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e764f065c2fa404a85129e2e957d4f18 == 0)
				{
					goto IL_0226;
				}
				goto IL_04D6;
				IL_027B:
				jsonSerializer_0.EqualityComparer = object_0.EqualityComparer;
				num = 38;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0efaea2f67ca4b0aa2880fbd34fc0fff == 0)
				{
					goto IL_029C;
				}
				goto IL_04D6;
				IL_030B:
				jsonSerializer_0.nullable_2 = object_0._dateTimeZoneHandling;
				num = 71;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f19acd91a8c44846a95d09d7dc3da2ba != 0)
				{
					goto IL_0040;
				}
				goto IL_04D6;
				IL_0331:
				jsonSerializer_0.nullable_3 = object_0._dateParseHandling;
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9bd9937edf9d4ad8bd673dfcb5a5e3cb != 0)
				{
					goto IL_0352;
				}
				goto IL_04D6;
				IL_03C3:
				int num2;
				num2++;
				num = 58;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_832998aae3714af0a1270bf2bb566909 == 0)
				{
					goto IL_00C2;
				}
				goto IL_04D6;
				IL_03A9:
				jsonSerializer_0.Converters.Insert(num2, object_0.Converters[num2]);
				goto IL_03C3;
				IL_0397:
				if (num2 < object_0.Converters.Count)
				{
					goto IL_03A9;
				}
				goto IL_069B;
				IL_04B4:
				num2 = 0;
				goto IL_0397;
				IL_0418:
				jsonSerializer_0.NullValueHandling = object_0.NullValueHandling;
				num = 27;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_67a271e0ae064fc7a3a74905868add95 != 0)
				{
					goto IL_014B;
				}
				goto IL_04D6;
				IL_0494:
				jsonSerializer_0.PreserveReferencesHandling = object_0.PreserveReferencesHandling;
				num = 70;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5c76a4eb2c1748d1bee3513c8eaff2eb != 0)
				{
					goto IL_0016;
				}
				goto IL_04D6;
				IL_068B:
				if (object_0._metadataPropertyHandling != null)
				{
					goto IL_0658;
				}
				num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_550a8fe2e5fe4cc19bdfe1a82a7f12b8 == 0)
				{
					goto IL_0645;
				}
				goto IL_04D6;
				IL_069B:
				if (object_0._typeNameHandling == null)
				{
					goto IL_068B;
				}
				IL_0666:
				jsonSerializer_0.TypeNameHandling = object_0.TypeNameHandling;
				goto IL_068B;
				IL_0645:
				if (object_0._typeNameAssemblyFormatHandling == null)
				{
					goto IL_0006;
				}
				num = 59;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fd59e876ac704e7eaa7c7a24a9b3a23f != 0)
				{
					goto IL_02E2;
				}
				goto IL_04D6;
				IL_0658:
				jsonSerializer_0.MetadataPropertyHandling = object_0.MetadataPropertyHandling;
				goto IL_0645;
				IL_024E:
				jsonSerializer_0.ReferenceResolver = object_0.ReferenceResolverProvider();
				goto IL_025F;
				IL_023A:
				jsonSerializer_0.ContractResolver = object_0.ContractResolver;
				goto IL_0246;
				IL_0226:
				jsonSerializer_0.Error += object_0.Error;
				goto IL_0232;
				IL_01B4:
				jsonSerializer_0.Context = object_0.Context;
				goto IL_01C0;
			}
			IL_06BE:
			jsonSerializer_0.nullable_7 = object_0._maxDepth;
			IL_06CA:
			jsonSerializer_0.bool_0 = object_0._maxDepthSet;
		}

		// Token: 0x060003B1 RID: 945 RVA: 0x0002D72C File Offset: 0x0002B92C
		public void Populate(TextReader reader, object target)
		{
			for (;;)
			{
				this.Populate(new JsonTextReader(reader), target);
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_193800745ad94a529d9e5edc977c4f02 != 0)
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

		// Token: 0x060003B2 RID: 946 RVA: 0x0002D76C File Offset: 0x0002B96C
		public void Populate(JsonReader reader, object target)
		{
			for (;;)
			{
				this.PopulateInternal(reader, target);
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c367d9ce11cc43b595beeb4524149542 == 0)
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

		// Token: 0x060003B3 RID: 947 RVA: 0x0002D7A4 File Offset: 0x0002B9A4
		internal virtual void PopulateInternal(JsonReader reader, object target)
		{
			for (;;)
			{
				IL_013D:
				ValidationUtils.ArgumentNotNull(reader, Class15.smethod_17(89041758 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_db7740c6ca7a4f3c8e1aa526bdb0a454));
				for (;;)
				{
					IL_0120:
					ValidationUtils.ArgumentNotNull(target, Class15.smethod_17(613108491 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ad967bb0ba3f44528134c153f7ab1ef6));
					for (;;)
					{
						IL_010B:
						CultureInfo cultureInfo;
						DateTimeZoneHandling? dateTimeZoneHandling;
						DateParseHandling? dateParseHandling;
						FloatParseHandling? floatParseHandling;
						int? num;
						string text;
						this.SetupReader(reader, out cultureInfo, out dateTimeZoneHandling, out dateParseHandling, out floatParseHandling, out num, out text);
						for (;;)
						{
							IL_0100:
							if (this.TraceWriter == null)
							{
								goto IL_00EB;
							}
							int num2 = 8;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_48fe014748e848c88d3254f339047927 == 0)
							{
								continue;
							}
							TraceJsonReader traceJsonReader;
							for (;;)
							{
								IL_0099:
								switch (num2)
								{
								case 1:
									return;
								case 2:
									goto IL_0081;
								case 3:
									new JsonSerializerInternalReader(this).Populate(traceJsonReader ?? reader, target);
									goto IL_0081;
								case 4:
									goto IL_0100;
								case 5:
									goto IL_0058;
								case 6:
									goto IL_0120;
								case 7:
									goto IL_013D;
								case 8:
									if (this.TraceWriter.LevelFilter >= TraceLevel.Verbose)
									{
										goto IL_00CD;
									}
									num2 = 0;
									if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9a2e459a49464219810a951679aea12e == 0)
									{
										continue;
									}
									break;
								case 9:
									goto IL_010B;
								case 10:
									goto IL_0006;
								}
								break;
								IL_0006:
								this.method_0(reader, cultureInfo, dateTimeZoneHandling, dateParseHandling, floatParseHandling, num, text);
								num2 = 0;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_207f975845fc40cdbe6b166fce664cd5 == 0)
								{
									return;
								}
								continue;
								IL_0058:
								this.TraceWriter.Trace(TraceLevel.Verbose, traceJsonReader.GetDeserializedJsonMessage(), null);
								goto IL_0006;
								IL_0081:
								if (traceJsonReader == null)
								{
									goto IL_0006;
								}
								num2 = 3;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fd59e876ac704e7eaa7c7a24a9b3a23f == 0)
								{
									goto IL_0058;
								}
							}
							goto IL_00EB;
							IL_00CD:
							TraceJsonReader traceJsonReader2 = this.method_1(reader);
							IL_00D4:
							traceJsonReader = traceJsonReader2;
							num2 = 3;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_48fe014748e848c88d3254f339047927 == 0)
							{
								return;
							}
							goto IL_0099;
							IL_00EB:
							traceJsonReader2 = null;
							goto IL_00D4;
						}
					}
				}
			}
		}

		// Token: 0x060003B4 RID: 948 RVA: 0x00002F1E File Offset: 0x0000111E
		[return: Nullable(2)]
		public object Deserialize(JsonReader reader)
		{
			return this.Deserialize(reader, null);
		}

		// Token: 0x060003B5 RID: 949 RVA: 0x00002F28 File Offset: 0x00001128
		[return: Nullable(2)]
		public object Deserialize(TextReader reader, Type objectType)
		{
			return this.Deserialize(new JsonTextReader(reader), objectType);
		}

		// Token: 0x060003B6 RID: 950 RVA: 0x00002F37 File Offset: 0x00001137
		[NullableContext(2)]
		public T Deserialize<T>([Nullable(1)] JsonReader reader)
		{
			return (T)((object)this.Deserialize(reader, typeof(T)));
		}

		// Token: 0x060003B7 RID: 951 RVA: 0x00002F4F File Offset: 0x0000114F
		[NullableContext(2)]
		public object Deserialize([Nullable(1)] JsonReader reader, Type objectType)
		{
			return this.DeserializeInternal(reader, objectType);
		}

		// Token: 0x060003B8 RID: 952 RVA: 0x0002D910 File Offset: 0x0002BB10
		[NullableContext(2)]
		internal virtual object DeserializeInternal([Nullable(1)] JsonReader reader, Type objectType)
		{
			CultureInfo cultureInfo;
			DateTimeZoneHandling? dateTimeZoneHandling;
			DateParseHandling? dateParseHandling;
			FloatParseHandling? floatParseHandling;
			int? num2;
			string text;
			for (;;)
			{
				ValidationUtils.ArgumentNotNull(reader, Class15.smethod_17(314784339 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_48fe014748e848c88d3254f339047927));
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8bcabc342a5a44748f3978da7f62051e != 0)
				{
					goto IL_002E;
				}
				IL_006F:
				switch (num)
				{
				case 0:
					goto IL_0053;
				case 1:
					IL_002E:
					this.SetupReader(reader, out cultureInfo, out dateTimeZoneHandling, out dateParseHandling, out floatParseHandling, out num2, out text);
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5c76a4eb2c1748d1bee3513c8eaff2eb == 0)
					{
						goto IL_0053;
					}
					goto IL_006F;
				case 2:
					continue;
				case 3:
					break;
				case 4:
					goto IL_00CD;
				case 5:
					goto IL_00D0;
				default:
					goto IL_0053;
				}
				IL_0006:
				if (this.TraceWriter.LevelFilter >= TraceLevel.Verbose)
				{
					goto IL_00C4;
				}
				num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5be00c24d71649dcae8af3eed7b74ac9 == 0)
				{
					break;
				}
				goto IL_006F;
				IL_0053:
				if (this.TraceWriter == null)
				{
					break;
				}
				num = 3;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0361b8eb39074ea88f5257b13904930a != 0)
				{
					goto IL_0006;
				}
				goto IL_006F;
			}
			goto IL_00CD;
			IL_00C4:
			TraceJsonReader traceJsonReader = this.method_1(reader);
			goto IL_00CE;
			IL_00CD:
			traceJsonReader = null;
			IL_00CE:
			TraceJsonReader traceJsonReader2 = traceJsonReader;
			IL_00D0:
			object obj = new JsonSerializerInternalReader(this).Deserialize(traceJsonReader2 ?? reader, objectType, this.CheckAdditionalContent);
			if (traceJsonReader2 != null)
			{
				this.TraceWriter.Trace(TraceLevel.Verbose, traceJsonReader2.GetDeserializedJsonMessage(), null);
			}
			this.method_0(reader, cultureInfo, dateTimeZoneHandling, dateParseHandling, floatParseHandling, num2, text);
			return obj;
		}

		// Token: 0x060003B9 RID: 953 RVA: 0x0002DA34 File Offset: 0x0002BC34
		[NullableContext(2)]
		internal void SetupReader([Nullable(1)] JsonReader reader, out CultureInfo previousCulture, out DateTimeZoneHandling? previousDateTimeZoneHandling, out DateParseHandling? previousDateParseHandling, out FloatParseHandling? previousFloatParseHandling, out int? previousMaxDepth, out string previousDateFormatString)
		{
			for (;;)
			{
				IL_046C:
				if (this.cultureInfo_0 == null)
				{
					goto IL_044D;
				}
				goto IL_0453;
				int num;
				int? maxDepth;
				for (;;)
				{
					IL_0340:
					int? num2;
					switch (num)
					{
					case 1:
					case 31:
					case 48:
						return;
					case 2:
						num2 = this.nullable_7;
						goto IL_02C6;
					case 3:
					case 13:
						goto IL_022A;
					case 4:
						goto IL_02EC;
					case 5:
					case 7:
						goto IL_0030;
					case 6:
					case 19:
						goto IL_00CA;
					case 8:
						goto IL_02FB;
					case 9:
						goto IL_0418;
					case 10:
						goto IL_006C;
					case 11:
					case 42:
						goto IL_0214;
					case 12:
						goto IL_0038;
					case 14:
					case 45:
						goto IL_0254;
					case 15:
					case 38:
						goto IL_01AC;
					case 16:
						goto IL_0265;
					case 17:
						goto IL_01D4;
					case 18:
						goto IL_02C6;
					case 20:
					case 33:
						goto IL_044D;
					case 21:
						goto IL_02B0;
					case 22:
						goto IL_028F;
					case 23:
					case 27:
						goto IL_0439;
					case 24:
					case 32:
						goto IL_025D;
					case 25:
						goto IL_02A2;
					case 26:
						goto IL_0174;
					case 28:
					case 44:
						goto IL_01B7;
					case 29:
						goto IL_0073;
					case 30:
						goto IL_027E;
					case 34:
						goto IL_046C;
					case 35:
						goto IL_0139;
					case 36:
						goto IL_00EC;
					case 37:
						goto IL_01F1;
					case 39:
						goto IL_010D;
					case 40:
						goto IL_003F;
					case 41:
						goto IL_0186;
					case 43:
					case 46:
						goto IL_00BD;
					case 47:
						goto IL_0024;
					case 49:
						goto IL_005F;
					case 50:
						goto IL_009B;
					case 51:
						goto IL_0006;
					}
					goto Block_16;
					IL_0006:
					previousDateFormatString = reader.DateFormatString;
					num = 4;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d97e64d0f425406b9649f2b4562a5f0e != 0)
					{
						goto IL_0024;
					}
					continue;
					IL_0265:
					if (!(reader.DateFormatString != this.string_0))
					{
						goto IL_0254;
					}
					goto IL_0006;
					IL_025D:
					if (this.bool_1)
					{
						goto IL_0265;
					}
					goto IL_0254;
					IL_02A2:
					reader.MaxDepth = this.nullable_7;
					goto IL_025D;
					IL_02EC:
					previousMaxDepth = reader.MaxDepth;
					goto IL_02A2;
					IL_02C6:
					if (!((maxDepth.GetValueOrDefault() == num2.GetValueOrDefault()) & (maxDepth != null == (num2 != null))))
					{
						goto IL_02EC;
					}
					goto IL_01B7;
					IL_003F:
					JsonTextReader jsonTextReader;
					if (jsonTextReader.PropertyNameTable == null)
					{
						goto IL_005F;
					}
					num = 48;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_52d717cd31b74287b67c03ee736a6211 != 0)
					{
						goto IL_0073;
					}
					continue;
					IL_0038:
					if (jsonTextReader != null)
					{
						goto IL_003F;
					}
					return;
					IL_0030:
					jsonTextReader = reader as JsonTextReader;
					goto IL_0038;
					IL_0254:
					previousDateFormatString = null;
					goto IL_0030;
					IL_0024:
					reader.DateFormatString = this.string_0;
					goto IL_0030;
					IL_0073:
					DefaultContractResolver defaultContractResolver;
					jsonTextReader.PropertyNameTable = defaultContractResolver.GetNameTable();
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2e3be65f7cb2480482903dc73ec42f7c == 0)
					{
						return;
					}
					continue;
					IL_006C:
					if (defaultContractResolver != null)
					{
						goto IL_0073;
					}
					return;
					IL_005F:
					defaultContractResolver = this._contractResolver as DefaultContractResolver;
					goto IL_006C;
				}
				IL_02B0:
				reader.DateParseHandling = this.nullable_3.GetValueOrDefault();
				goto IL_0214;
				Block_16:
				goto IL_0453;
				IL_009B:
				maxDepth = reader.MaxDepth;
				num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8d68b74cee6442019d959192b2974e3d != 0)
				{
					goto IL_0453;
				}
				goto IL_0340;
				IL_01AC:
				if (!this.bool_0)
				{
					goto IL_01B7;
				}
				goto IL_009B;
				IL_00CA:
				previousFloatParseHandling = null;
				num = 38;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fd59e876ac704e7eaa7c7a24a9b3a23f != 0)
				{
					goto IL_022A;
				}
				goto IL_0340;
				IL_0214:
				if (this.nullable_5 != null)
				{
					goto IL_0139;
				}
				goto IL_00CA;
				IL_00BD:
				previousDateParseHandling = null;
				goto IL_0214;
				IL_00EC:
				DateParseHandling dateParseHandling = reader.DateParseHandling;
				DateParseHandling? dateParseHandling2 = this.nullable_3;
				if (!((dateParseHandling == dateParseHandling2.GetValueOrDefault()) & (dateParseHandling2 != null)))
				{
					goto IL_010D;
				}
				goto IL_00BD;
				IL_022A:
				if (this.nullable_3 != null)
				{
					goto IL_00EC;
				}
				num = 43;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7dfc957a76cb4c58b17dc74a084c4e4a == 0)
				{
					goto IL_044D;
				}
				goto IL_0340;
				IL_028F:
				reader.DateTimeZoneHandling = this.nullable_2.GetValueOrDefault();
				goto IL_022A;
				IL_027E:
				previousDateTimeZoneHandling = new DateTimeZoneHandling?(reader.DateTimeZoneHandling);
				goto IL_028F;
				IL_010D:
				previousDateParseHandling = new DateParseHandling?(reader.DateParseHandling);
				num = 21;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a5994720d09542abb897ebf6ad9b5a19 != 0)
				{
					goto IL_0214;
				}
				goto IL_0340;
				IL_0139:
				FloatParseHandling floatParseHandling = reader.FloatParseHandling;
				FloatParseHandling? floatParseHandling2 = this.nullable_5;
				if (!((floatParseHandling == floatParseHandling2.GetValueOrDefault()) & (floatParseHandling2 != null)))
				{
					goto IL_0174;
				}
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4ac69ea2381b403582a2723337f67fa8 != 0)
				{
					goto IL_00CA;
				}
				goto IL_0340;
				IL_0186:
				reader.FloatParseHandling = this.nullable_5.GetValueOrDefault();
				num = 10;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_11c6824de6514281a8425f6d6ab1a2d5 == 0)
				{
					goto IL_01AC;
				}
				goto IL_0340;
				IL_0174:
				previousFloatParseHandling = new FloatParseHandling?(reader.FloatParseHandling);
				goto IL_0186;
				IL_01B7:
				previousMaxDepth = null;
				num = 24;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f77f8ab5a3534e2e914063d52217b4e1 == 0)
				{
					goto IL_0340;
				}
				IL_01D4:
				previousCulture = reader.Culture;
				num = 7;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2e3be65f7cb2480482903dc73ec42f7c == 0)
				{
					goto IL_01F1;
				}
				goto IL_0340;
				IL_0453:
				if (!this.cultureInfo_0.Equals(reader.Culture))
				{
					goto IL_01D4;
				}
				goto IL_044D;
				IL_01F1:
				reader.Culture = this.cultureInfo_0;
				num = 23;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9a2e459a49464219810a951679aea12e != 0)
				{
					goto IL_022A;
				}
				goto IL_0340;
				IL_02FB:
				DateTimeZoneHandling dateTimeZoneHandling = reader.DateTimeZoneHandling;
				DateTimeZoneHandling? dateTimeZoneHandling2 = this.nullable_2;
				if ((dateTimeZoneHandling == dateTimeZoneHandling2.GetValueOrDefault()) & (dateTimeZoneHandling2 != null))
				{
					goto IL_0418;
				}
				num = 19;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_aa43e77a676848e0bd70abf647d6a9f1 == 0)
				{
					goto IL_027E;
				}
				goto IL_0340;
				IL_0439:
				if (this.nullable_2 != null)
				{
					goto IL_02FB;
				}
				goto IL_0418;
				IL_044D:
				previousCulture = null;
				goto IL_0439;
				IL_0418:
				previousDateTimeZoneHandling = null;
				num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_aa43e77a676848e0bd70abf647d6a9f1 == 0)
				{
					goto IL_022A;
				}
				goto IL_0340;
			}
		}

		// Token: 0x060003BA RID: 954 RVA: 0x0002DEBC File Offset: 0x0002C0BC
		[NullableContext(2)]
		private void method_0([Nullable(1)] JsonReader reader, CultureInfo cultureInfo_1, DateTimeZoneHandling? nullable_9, DateParseHandling? nullable_10, FloatParseHandling? nullable_11, int? nullable_12, string string_1)
		{
			if (cultureInfo_1 != null)
			{
				reader.Culture = cultureInfo_1;
			}
			if (nullable_9 != null)
			{
				reader.DateTimeZoneHandling = nullable_9.GetValueOrDefault();
			}
			if (nullable_10 != null)
			{
				reader.DateParseHandling = nullable_10.GetValueOrDefault();
			}
			if (nullable_11 != null)
			{
				reader.FloatParseHandling = nullable_11.GetValueOrDefault();
			}
			if (this.bool_0)
			{
				reader.MaxDepth = nullable_12;
			}
			if (this.bool_1)
			{
				reader.DateFormatString = string_1;
			}
			JsonTextReader jsonTextReader = reader as JsonTextReader;
			if (jsonTextReader != null && jsonTextReader.PropertyNameTable != null)
			{
				DefaultContractResolver defaultContractResolver = this._contractResolver as DefaultContractResolver;
				if (defaultContractResolver != null && jsonTextReader.PropertyNameTable == defaultContractResolver.GetNameTable())
				{
					jsonTextReader.PropertyNameTable = null;
				}
			}
		}

		// Token: 0x060003BB RID: 955 RVA: 0x0002DF6C File Offset: 0x0002C16C
		public void Serialize(TextWriter textWriter, [Nullable(2)] object value)
		{
			for (;;)
			{
				this.Serialize(new JsonTextWriter(textWriter), value);
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_832998aae3714af0a1270bf2bb566909 != 0)
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

		// Token: 0x060003BC RID: 956 RVA: 0x0002DFAC File Offset: 0x0002C1AC
		[NullableContext(2)]
		public void Serialize([Nullable(1)] JsonWriter jsonWriter, object value, Type objectType)
		{
			for (;;)
			{
				this.SerializeInternal(jsonWriter, value, objectType);
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_17bdafd603b54a77a2e4a383bd4dcffa == 0)
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

		// Token: 0x060003BD RID: 957 RVA: 0x0002DFE8 File Offset: 0x0002C1E8
		public void Serialize(TextWriter textWriter, [Nullable(2)] object value, Type objectType)
		{
			for (;;)
			{
				this.Serialize(new JsonTextWriter(textWriter), value, objectType);
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e764f065c2fa404a85129e2e957d4f18 != 0)
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

		// Token: 0x060003BE RID: 958 RVA: 0x0002E028 File Offset: 0x0002C228
		public void Serialize(JsonWriter jsonWriter, [Nullable(2)] object value)
		{
			for (;;)
			{
				this.SerializeInternal(jsonWriter, value, null);
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5e301544981d4903aa4e531970a47849 == 0)
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

		// Token: 0x060003BF RID: 959 RVA: 0x0002E064 File Offset: 0x0002C264
		private TraceJsonReader method_1(JsonReader jsonReader_0)
		{
			TraceJsonReader traceJsonReader;
			for (;;)
			{
				traceJsonReader = new TraceJsonReader(jsonReader_0);
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_548c52e5632b45898e377ad9c9a06469 == 0)
				{
					goto IL_001E;
				}
				goto IL_003A;
				IL_0003:
				traceJsonReader.WriteCurrentToken();
				num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d9581c727fcc4f50accd4f5de0d386f5 != 0)
				{
					continue;
				}
				goto IL_003A;
				IL_001E:
				if (jsonReader_0.TokenType == JsonToken.None)
				{
					break;
				}
				num = 3;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0361b8eb39074ea88f5257b13904930a != 0)
				{
					goto IL_0003;
				}
				IL_003A:
				switch (num)
				{
				case 0:
					goto IL_001E;
				case 1:
					break;
				case 2:
					return traceJsonReader;
				case 3:
					goto IL_0003;
				default:
					goto IL_001E;
				}
			}
			return traceJsonReader;
		}

		// Token: 0x060003C0 RID: 960 RVA: 0x0002E0E4 File Offset: 0x0002C2E4
		[NullableContext(2)]
		internal virtual void SerializeInternal([Nullable(1)] JsonWriter jsonWriter, object value, Type objectType)
		{
			CultureInfo cultureInfo;
			StringEscapeHandling? stringEscapeHandling;
			string text;
			for (;;)
			{
				IL_0559:
				ValidationUtils.ArgumentNotNull(jsonWriter, Class15.smethod_17(1829609685 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c08ab7af63da4f24a4fa3e9c7a732fae));
				for (;;)
				{
					IL_054F:
					Formatting? formatting = null;
					for (;;)
					{
						IL_053F:
						if (this.nullable_0 != null)
						{
							goto IL_0518;
						}
						for (;;)
						{
							IL_050E:
							DateFormatHandling? dateFormatHandling = null;
							for (;;)
							{
								IL_04FB:
								if (this.nullable_1 != null)
								{
									goto IL_0317;
								}
								goto IL_04F1;
								int num;
								for (;;)
								{
									IL_0375:
									switch (num)
									{
									case 1:
										goto IL_023C;
									case 2:
									case 11:
										goto IL_0592;
									case 3:
									case 6:
										goto IL_05A2;
									case 4:
										goto IL_054F;
									case 5:
										goto IL_0559;
									case 7:
									case 10:
										goto IL_0175;
									case 8:
									case 53:
										goto IL_057C;
									case 9:
									case 18:
										goto IL_015F;
									case 12:
										goto IL_005E;
									case 13:
										goto IL_0031;
									case 14:
										goto IL_0168;
									case 15:
									case 19:
									case 34:
										goto IL_0284;
									case 16:
										jsonWriter.FloatFormatHandling = this.nullable_4.GetValueOrDefault();
										goto IL_0227;
									case 17:
										return;
									case 20:
										goto IL_022F;
									case 21:
										goto IL_013C;
									case 22:
										goto IL_0352;
									case 23:
										goto IL_0317;
									case 24:
										goto IL_059A;
									case 25:
										goto IL_04BF;
									case 26:
										goto IL_02C7;
									case 27:
										goto IL_01FC;
									case 29:
									case 30:
										goto IL_00C3;
									case 31:
										goto IL_01A3;
									case 32:
										if (this.nullable_4 != null)
										{
											goto IL_028C;
										}
										goto IL_0227;
									case 33:
										jsonWriter.StringEscapeHandling = this.nullable_6.GetValueOrDefault();
										goto IL_0284;
									case 35:
									case 41:
									case 60:
										goto IL_050E;
									case 36:
										goto IL_0152;
									case 37:
										goto IL_0099;
									case 38:
										goto IL_04E0;
									case 39:
										goto IL_0181;
									case 40:
										goto IL_053F;
									case 42:
										goto IL_0518;
									case 43:
										goto IL_007E;
									case 44:
										goto IL_00AD;
									case 45:
										goto IL_0149;
									case 46:
										goto IL_00C6;
									case 47:
										goto IL_0091;
									case 48:
									case 69:
										goto IL_049D;
									case 49:
										goto IL_00F5;
									case 50:
										goto IL_01EF;
									case 51:
										goto IL_00DA;
									case 52:
										goto IL_04FB;
									case 54:
										goto IL_04D3;
									case 55:
										goto IL_0585;
									case 56:
									case 66:
										goto IL_0227;
									case 57:
									case 64:
										goto IL_00A5;
									case 58:
										goto IL_0013;
									case 59:
										goto IL_05A6;
									case 61:
										goto IL_025D;
									case 62:
										goto IL_028C;
									case 63:
										goto IL_0076;
									case 65:
										goto IL_0006;
									case 67:
										goto IL_01B4;
									case 68:
										goto IL_04F1;
									case 70:
										goto IL_0029;
									}
									break;
									IL_0031:
									if (this.cultureInfo_0.Equals(jsonWriter.Culture))
									{
										goto IL_005E;
									}
									num = 22;
									if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bca7529ca324c188cfc0e64eb7d1cdf == 0)
									{
										goto Block_2;
									}
									continue;
									IL_0029:
									if (this.cultureInfo_0 != null)
									{
										goto IL_0031;
									}
									goto IL_005E;
									IL_0284:
									cultureInfo = null;
									goto IL_0029;
									IL_022F:
									if (this.nullable_6 != null)
									{
										goto IL_023C;
									}
									goto IL_0284;
									IL_0227:
									stringEscapeHandling = null;
									goto IL_022F;
									IL_025D:
									stringEscapeHandling = new StringEscapeHandling?(jsonWriter.StringEscapeHandling);
									num = 33;
									if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3a299c01dd4f4a209bdbd1b98e3f1406 == 0)
									{
										goto Block_11;
									}
									continue;
									IL_028C:
									FloatFormatHandling floatFormatHandling = jsonWriter.FloatFormatHandling;
									FloatFormatHandling? floatFormatHandling2 = this.nullable_4;
									if (!((floatFormatHandling == floatFormatHandling2.GetValueOrDefault()) & (floatFormatHandling2 != null)))
									{
										goto IL_02C7;
									}
									num = 2;
									if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_55c1fea936c04e47abbfb2b5f778aff7 == 0)
									{
										goto IL_0227;
									}
									continue;
									IL_023C:
									StringEscapeHandling stringEscapeHandling2 = jsonWriter.StringEscapeHandling;
									StringEscapeHandling? stringEscapeHandling3 = this.nullable_6;
									if (!((stringEscapeHandling2 == stringEscapeHandling3.GetValueOrDefault()) & (stringEscapeHandling3 != null)))
									{
										goto IL_025D;
									}
									goto IL_0284;
								}
								goto IL_011E;
								Block_11:
								goto IL_0175;
								IL_0352:
								cultureInfo = jsonWriter.Culture;
								goto IL_01A3;
								IL_005E:
								text = null;
								num = 60;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8f48544341da433d9f954b548c7e9212 == 0)
								{
									goto IL_0076;
								}
								goto IL_0375;
								IL_00DA:
								TraceJsonWriter traceJsonWriter;
								if (traceJsonWriter != null)
								{
									goto IL_00F5;
								}
								num = 9;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_948fa5c193d44e279b41c3a0fab7b5c9 == 0)
								{
									goto IL_011E;
								}
								goto IL_0375;
								IL_00C6:
								new JsonSerializerInternalWriter(this).Serialize(traceJsonWriter ?? jsonWriter, value, objectType);
								goto IL_00DA;
								IL_00C4:
								TraceJsonWriter traceJsonWriter2;
								traceJsonWriter = traceJsonWriter2;
								goto IL_00C6;
								IL_00C3:
								traceJsonWriter2 = null;
								goto IL_00C4;
								IL_00AD:
								if (this.TraceWriter.LevelFilter >= TraceLevel.Verbose)
								{
									traceJsonWriter2 = new TraceJsonWriter(jsonWriter);
									goto IL_00C4;
								}
								goto IL_00C3;
								IL_00A5:
								if (this.TraceWriter != null)
								{
									goto IL_00AD;
								}
								goto IL_00C3;
								IL_007E:
								if (jsonWriter.DateFormatString != this.string_0)
								{
									goto IL_0091;
								}
								goto IL_00A5;
								IL_0076:
								if (this.bool_1)
								{
									goto IL_007E;
								}
								goto IL_00A5;
								IL_00F5:
								this.TraceWriter.Trace(TraceLevel.Verbose, traceJsonWriter.GetSerializedJsonMessage(), null);
								num = 0;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3bf07bb1c323490cb457eef2b2e78695 != 0)
								{
									goto IL_0375;
								}
								IL_011E:
								if (formatting == null)
								{
									goto IL_0149;
								}
								num = 2;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5c76a4eb2c1748d1bee3513c8eaff2eb != 0)
								{
									goto IL_013C;
								}
								goto IL_0375;
								IL_0181:
								FloatFormatHandling? floatFormatHandling3;
								jsonWriter.FloatFormatHandling = floatFormatHandling3.GetValueOrDefault();
								num = 53;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_1d8dbb531d7349c0bc15bad339f7815c == 0)
								{
									goto IL_01A3;
								}
								goto IL_0375;
								IL_0175:
								if (floatFormatHandling3 != null)
								{
									goto IL_0181;
								}
								goto IL_057C;
								IL_0168:
								DateTimeZoneHandling? dateTimeZoneHandling;
								jsonWriter.DateTimeZoneHandling = dateTimeZoneHandling.GetValueOrDefault();
								goto IL_0175;
								IL_015F:
								if (dateTimeZoneHandling != null)
								{
									goto IL_0168;
								}
								goto IL_0175;
								IL_0152:
								jsonWriter.DateFormatHandling = dateFormatHandling.GetValueOrDefault();
								goto IL_015F;
								IL_0149:
								if (dateFormatHandling != null)
								{
									goto IL_0152;
								}
								goto IL_015F;
								IL_013C:
								jsonWriter.Formatting = formatting.GetValueOrDefault();
								goto IL_0149;
								IL_01B4:
								DateTimeZoneHandling dateTimeZoneHandling2 = jsonWriter.DateTimeZoneHandling;
								DateTimeZoneHandling? dateTimeZoneHandling3 = this.nullable_2;
								if (!((dateTimeZoneHandling2 == dateTimeZoneHandling3.GetValueOrDefault()) & (dateTimeZoneHandling3 != null)))
								{
									goto IL_01EF;
								}
								num = 48;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5e301544981d4903aa4e531970a47849 != 0)
								{
									goto IL_0091;
								}
								goto IL_0375;
								IL_04BF:
								if (this.nullable_2 != null)
								{
									goto IL_01B4;
								}
								goto IL_049D;
								IL_04F1:
								dateTimeZoneHandling = null;
								goto IL_04BF;
								IL_04E0:
								jsonWriter.DateFormatHandling = this.nullable_1.GetValueOrDefault();
								goto IL_04F1;
								IL_04D3:
								dateFormatHandling = new DateFormatHandling?(jsonWriter.DateFormatHandling);
								goto IL_04E0;
								IL_0317:
								DateFormatHandling dateFormatHandling2 = jsonWriter.DateFormatHandling;
								DateFormatHandling? dateFormatHandling3 = this.nullable_1;
								if ((dateFormatHandling2 == dateFormatHandling3.GetValueOrDefault()) & (dateFormatHandling3 != null))
								{
									goto IL_04F1;
								}
								num = 41;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_6f87b5b72b9847f7b8ec5b44b0dccfa8 == 0)
								{
									goto IL_04D3;
								}
								goto IL_0375;
								IL_01FC:
								jsonWriter.DateTimeZoneHandling = this.nullable_2.GetValueOrDefault();
								num = 40;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_57ce3fecb9e64a8f924ea7658e146719 != 0)
								{
									goto IL_049D;
								}
								goto IL_0375;
								IL_01EF:
								dateTimeZoneHandling = new DateTimeZoneHandling?(jsonWriter.DateTimeZoneHandling);
								goto IL_01FC;
								IL_02C7:
								floatFormatHandling3 = new FloatFormatHandling?(jsonWriter.FloatFormatHandling);
								num = 16;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7af5c533f30e4bd1bda86ce6098441d2 == 0)
								{
									goto Block_14;
								}
								goto IL_0375;
								IL_049D:
								floatFormatHandling3 = null;
								num = 32;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ad967bb0ba3f44528134c153f7ab1ef6 == 0)
								{
									goto IL_02C7;
								}
								goto IL_0375;
								IL_01A3:
								jsonWriter.Culture = this.cultureInfo_0;
								goto IL_005E;
								IL_0099:
								jsonWriter.DateFormatString = this.string_0;
								goto IL_00A5;
								IL_0091:
								text = jsonWriter.DateFormatString;
								goto IL_0099;
							}
						}
						IL_0518:
						Formatting formatting2 = jsonWriter.Formatting;
						Formatting? formatting3 = this.nullable_0;
						if ((formatting2 == formatting3.GetValueOrDefault()) & (formatting3 != null))
						{
							goto IL_050E;
						}
						goto IL_0006;
						IL_0013:
						jsonWriter.Formatting = this.nullable_0.GetValueOrDefault();
						goto IL_050E;
						IL_0006:
						formatting = new Formatting?(jsonWriter.Formatting);
						goto IL_0013;
					}
				}
			}
			Block_2:
			goto IL_0592;
			Block_14:
			goto IL_05A2;
			IL_057C:
			if (stringEscapeHandling == null)
			{
				goto IL_0592;
			}
			IL_0585:
			jsonWriter.StringEscapeHandling = stringEscapeHandling.GetValueOrDefault();
			IL_0592:
			if (!this.bool_1)
			{
				goto IL_05A2;
			}
			IL_059A:
			jsonWriter.DateFormatString = text;
			IL_05A2:
			if (cultureInfo == null)
			{
				return;
			}
			IL_05A6:
			jsonWriter.Culture = cultureInfo;
		}

		// Token: 0x060003C1 RID: 961 RVA: 0x0002E6A0 File Offset: 0x0002C8A0
		internal GInterface1 GetReferenceResolver()
		{
			IL_0037:
			while (this.ginterface1_0 == null)
			{
				for (;;)
				{
					this.ginterface1_0 = new DefaultReferenceResolver();
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5f127c3ec2e04c11ab1bd26a8d965f2b != 0)
					{
						switch (num)
						{
						case 1:
							continue;
						case 3:
							goto IL_0037;
						}
						break;
					}
					break;
				}
				IL_0043:
				return this.ginterface1_0;
			}
			goto IL_0043;
		}

		// Token: 0x060003C2 RID: 962 RVA: 0x00002F59 File Offset: 0x00001159
		[return: Nullable(2)]
		internal JsonConverter GetMatchingConverter(Type type)
		{
			return JsonSerializer.GetMatchingConverter(this._converters, type);
		}

		// Token: 0x060003C3 RID: 963 RVA: 0x0002E6F8 File Offset: 0x0002C8F8
		[return: Nullable(2)]
		internal static JsonConverter GetMatchingConverter([Nullable(new byte[] { 2, 1 })] IList<JsonConverter> converters, Type objectType)
		{
			if (converters != null)
			{
				for (int i = 0; i < converters.Count; i++)
				{
					JsonConverter jsonConverter = converters[i];
					if (jsonConverter.CanConvert(objectType))
					{
						return jsonConverter;
					}
				}
			}
			return null;
		}

		// Token: 0x060003C4 RID: 964 RVA: 0x0002E730 File Offset: 0x0002C930
		internal void OnError(Newtonsoft.Json.Serialization.ErrorEventArgs e)
		{
			for (;;)
			{
				EventHandler<Newtonsoft.Json.Serialization.ErrorEventArgs> eventHandler = this.eventHandler_0;
				int num;
				if (eventHandler == null)
				{
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa49bb51056944098afe92e3a80a544b == 0)
					{
						goto IL_004B;
					}
				}
				else
				{
					eventHandler(this, e);
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a321d34f24314561b0d80437d5d859e8 == 0)
					{
						break;
					}
				}
				switch (num)
				{
				case 1:
					return;
				case 2:
					continue;
				}
				break;
			}
			return;
			IL_004B:;
		}

		// Token: 0x0400023D RID: 573
		internal TypeNameHandling _typeNameHandling;

		// Token: 0x0400023E RID: 574
		internal TypeNameAssemblyFormatHandling _typeNameAssemblyFormatHandling;

		// Token: 0x0400023F RID: 575
		internal PreserveReferencesHandling _preserveReferencesHandling;

		// Token: 0x04000240 RID: 576
		internal ReferenceLoopHandling _referenceLoopHandling;

		// Token: 0x04000241 RID: 577
		internal MissingMemberHandling _missingMemberHandling;

		// Token: 0x04000242 RID: 578
		internal ObjectCreationHandling _objectCreationHandling;

		// Token: 0x04000243 RID: 579
		internal NullValueHandling _nullValueHandling;

		// Token: 0x04000244 RID: 580
		internal DefaultValueHandling _defaultValueHandling;

		// Token: 0x04000245 RID: 581
		internal ConstructorHandling _constructorHandling;

		// Token: 0x04000246 RID: 582
		internal MetadataPropertyHandling _metadataPropertyHandling;

		// Token: 0x04000247 RID: 583
		[Nullable(2)]
		internal JsonConverterCollection _converters;

		// Token: 0x04000248 RID: 584
		internal IContractResolver _contractResolver;

		// Token: 0x04000249 RID: 585
		[Nullable(2)]
		internal ITraceWriter _traceWriter;

		// Token: 0x0400024A RID: 586
		[Nullable(2)]
		internal IEqualityComparer _equalityComparer;

		// Token: 0x0400024B RID: 587
		internal GInterface2 _serializationBinder;

		// Token: 0x0400024C RID: 588
		internal StreamingContext _context;

		// Token: 0x0400024D RID: 589
		[Nullable(2)]
		private GInterface1 ginterface1_0;

		// Token: 0x0400024E RID: 590
		private Formatting? nullable_0;

		// Token: 0x0400024F RID: 591
		private DateFormatHandling? nullable_1;

		// Token: 0x04000250 RID: 592
		private DateTimeZoneHandling? nullable_2;

		// Token: 0x04000251 RID: 593
		private DateParseHandling? nullable_3;

		// Token: 0x04000252 RID: 594
		private FloatFormatHandling? nullable_4;

		// Token: 0x04000253 RID: 595
		private FloatParseHandling? nullable_5;

		// Token: 0x04000254 RID: 596
		private StringEscapeHandling? nullable_6;

		// Token: 0x04000255 RID: 597
		private CultureInfo cultureInfo_0;

		// Token: 0x04000256 RID: 598
		private int? nullable_7;

		// Token: 0x04000257 RID: 599
		private bool bool_0;

		// Token: 0x04000258 RID: 600
		private bool? nullable_8;

		// Token: 0x04000259 RID: 601
		[Nullable(2)]
		private string string_0;

		// Token: 0x0400025A RID: 602
		private bool bool_1;

		// Token: 0x0400025B RID: 603
		[CompilerGenerated]
		[Nullable(new byte[] { 2, 1 })]
		private EventHandler<Newtonsoft.Json.Serialization.ErrorEventArgs> eventHandler_0;
	}
}
