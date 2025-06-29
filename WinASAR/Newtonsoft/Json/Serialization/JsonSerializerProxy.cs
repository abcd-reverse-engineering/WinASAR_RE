using System;
using System.Collections;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x0200011A RID: 282
	[Nullable(0)]
	[NullableContext(1)]
	internal class JsonSerializerProxy : JsonSerializer
	{
		// Token: 0x14000004 RID: 4
		// (add) Token: 0x06000B3A RID: 2874 RVA: 0x00004FF5 File Offset: 0x000031F5
		// (remove) Token: 0x06000B3B RID: 2875 RVA: 0x00005003 File Offset: 0x00003203
		[Nullable(new byte[] { 2, 1 })]
		public override event EventHandler<ErrorEventArgs> Error
		{
			add
			{
				this._serializer.Error += value;
			}
			remove
			{
				this._serializer.Error -= value;
			}
		}

		// Token: 0x17000182 RID: 386
		// (get) Token: 0x06000B3C RID: 2876 RVA: 0x00005011 File Offset: 0x00003211
		// (set) Token: 0x06000B3D RID: 2877 RVA: 0x00067744 File Offset: 0x00065944
		[Nullable(2)]
		public override GInterface1 ReferenceResolver
		{
			[NullableContext(2)]
			get
			{
				return this._serializer.ReferenceResolver;
			}
			[NullableContext(2)]
			set
			{
				for (;;)
				{
					this._serializer.ReferenceResolver = value;
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

		// Token: 0x17000183 RID: 387
		// (get) Token: 0x06000B3E RID: 2878 RVA: 0x0000501E File Offset: 0x0000321E
		// (set) Token: 0x06000B3F RID: 2879 RVA: 0x00067780 File Offset: 0x00065980
		[Nullable(2)]
		public override ITraceWriter TraceWriter
		{
			[NullableContext(2)]
			get
			{
				return this._serializer.TraceWriter;
			}
			[NullableContext(2)]
			set
			{
				for (;;)
				{
					this._serializer.TraceWriter = value;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fd59e876ac704e7eaa7c7a24a9b3a23f != 0)
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

		// Token: 0x17000184 RID: 388
		// (get) Token: 0x06000B40 RID: 2880 RVA: 0x0000502B File Offset: 0x0000322B
		// (set) Token: 0x06000B41 RID: 2881 RVA: 0x000677BC File Offset: 0x000659BC
		[Nullable(2)]
		public override IEqualityComparer EqualityComparer
		{
			[NullableContext(2)]
			get
			{
				return this._serializer.EqualityComparer;
			}
			[NullableContext(2)]
			set
			{
				for (;;)
				{
					this._serializer.EqualityComparer = value;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8bcabc342a5a44748f3978da7f62051e != 0)
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

		// Token: 0x17000185 RID: 389
		// (get) Token: 0x06000B42 RID: 2882 RVA: 0x00005038 File Offset: 0x00003238
		public override JsonConverterCollection Converters
		{
			get
			{
				return this._serializer.Converters;
			}
		}

		// Token: 0x17000186 RID: 390
		// (get) Token: 0x06000B43 RID: 2883 RVA: 0x00005045 File Offset: 0x00003245
		// (set) Token: 0x06000B44 RID: 2884 RVA: 0x000677F8 File Offset: 0x000659F8
		public override DefaultValueHandling DefaultValueHandling
		{
			get
			{
				return this._serializer.DefaultValueHandling;
			}
			set
			{
				for (;;)
				{
					this._serializer.DefaultValueHandling = value;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_67a271e0ae064fc7a3a74905868add95 != 0)
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

		// Token: 0x17000187 RID: 391
		// (get) Token: 0x06000B45 RID: 2885 RVA: 0x00005052 File Offset: 0x00003252
		// (set) Token: 0x06000B46 RID: 2886 RVA: 0x00067834 File Offset: 0x00065A34
		public override IContractResolver ContractResolver
		{
			get
			{
				return this._serializer.ContractResolver;
			}
			set
			{
				for (;;)
				{
					this._serializer.ContractResolver = value;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_6bf87ae21d2446cfa7edc53669bb8039 != 0)
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

		// Token: 0x17000188 RID: 392
		// (get) Token: 0x06000B47 RID: 2887 RVA: 0x0000505F File Offset: 0x0000325F
		// (set) Token: 0x06000B48 RID: 2888 RVA: 0x00067870 File Offset: 0x00065A70
		public override MissingMemberHandling MissingMemberHandling
		{
			get
			{
				return this._serializer.MissingMemberHandling;
			}
			set
			{
				for (;;)
				{
					this._serializer.MissingMemberHandling = value;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fd59e876ac704e7eaa7c7a24a9b3a23f != 0)
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

		// Token: 0x17000189 RID: 393
		// (get) Token: 0x06000B49 RID: 2889 RVA: 0x0000506C File Offset: 0x0000326C
		// (set) Token: 0x06000B4A RID: 2890 RVA: 0x000678AC File Offset: 0x00065AAC
		public override NullValueHandling NullValueHandling
		{
			get
			{
				return this._serializer.NullValueHandling;
			}
			set
			{
				for (;;)
				{
					this._serializer.NullValueHandling = value;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9bd9937edf9d4ad8bd673dfcb5a5e3cb == 0)
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

		// Token: 0x1700018A RID: 394
		// (get) Token: 0x06000B4B RID: 2891 RVA: 0x00005079 File Offset: 0x00003279
		// (set) Token: 0x06000B4C RID: 2892 RVA: 0x000678E8 File Offset: 0x00065AE8
		public override ObjectCreationHandling ObjectCreationHandling
		{
			get
			{
				return this._serializer.ObjectCreationHandling;
			}
			set
			{
				for (;;)
				{
					this._serializer.ObjectCreationHandling = value;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93ade03426d44b1841bfa7c633f49f3 == 0)
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

		// Token: 0x1700018B RID: 395
		// (get) Token: 0x06000B4D RID: 2893 RVA: 0x00005086 File Offset: 0x00003286
		// (set) Token: 0x06000B4E RID: 2894 RVA: 0x00067924 File Offset: 0x00065B24
		public override ReferenceLoopHandling ReferenceLoopHandling
		{
			get
			{
				return this._serializer.ReferenceLoopHandling;
			}
			set
			{
				for (;;)
				{
					this._serializer.ReferenceLoopHandling = value;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c5a086ee5649458eb5e1e6e4f0f1f4d3 != 0)
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

		// Token: 0x1700018C RID: 396
		// (get) Token: 0x06000B4F RID: 2895 RVA: 0x00005093 File Offset: 0x00003293
		// (set) Token: 0x06000B50 RID: 2896 RVA: 0x00067960 File Offset: 0x00065B60
		public override PreserveReferencesHandling PreserveReferencesHandling
		{
			get
			{
				return this._serializer.PreserveReferencesHandling;
			}
			set
			{
				for (;;)
				{
					this._serializer.PreserveReferencesHandling = value;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c5a086ee5649458eb5e1e6e4f0f1f4d3 != 0)
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

		// Token: 0x1700018D RID: 397
		// (get) Token: 0x06000B51 RID: 2897 RVA: 0x000050A0 File Offset: 0x000032A0
		// (set) Token: 0x06000B52 RID: 2898 RVA: 0x0006799C File Offset: 0x00065B9C
		public override TypeNameHandling TypeNameHandling
		{
			get
			{
				return this._serializer.TypeNameHandling;
			}
			set
			{
				for (;;)
				{
					this._serializer.TypeNameHandling = value;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7dfc957a76cb4c58b17dc74a084c4e4a != 0)
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

		// Token: 0x1700018E RID: 398
		// (get) Token: 0x06000B53 RID: 2899 RVA: 0x000050AD File Offset: 0x000032AD
		// (set) Token: 0x06000B54 RID: 2900 RVA: 0x000679D8 File Offset: 0x00065BD8
		public override MetadataPropertyHandling MetadataPropertyHandling
		{
			get
			{
				return this._serializer.MetadataPropertyHandling;
			}
			set
			{
				for (;;)
				{
					this._serializer.MetadataPropertyHandling = value;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_871a407507f34aa3b5bf52517d4f63a9 != 0)
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

		// Token: 0x1700018F RID: 399
		// (get) Token: 0x06000B55 RID: 2901 RVA: 0x000050BA File Offset: 0x000032BA
		// (set) Token: 0x06000B56 RID: 2902 RVA: 0x00067A14 File Offset: 0x00065C14
		[Obsolete("TypeNameAssemblyFormat is obsolete. Use TypeNameAssemblyFormatHandling instead.")]
		public override FormatterAssemblyStyle TypeNameAssemblyFormat
		{
			get
			{
				return this._serializer.TypeNameAssemblyFormat;
			}
			set
			{
				for (;;)
				{
					this._serializer.TypeNameAssemblyFormat = value;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7dfc957a76cb4c58b17dc74a084c4e4a == 0)
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

		// Token: 0x17000190 RID: 400
		// (get) Token: 0x06000B57 RID: 2903 RVA: 0x000050C7 File Offset: 0x000032C7
		// (set) Token: 0x06000B58 RID: 2904 RVA: 0x00067A50 File Offset: 0x00065C50
		public override TypeNameAssemblyFormatHandling TypeNameAssemblyFormatHandling
		{
			get
			{
				return this._serializer.TypeNameAssemblyFormatHandling;
			}
			set
			{
				for (;;)
				{
					this._serializer.TypeNameAssemblyFormatHandling = value;
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

		// Token: 0x17000191 RID: 401
		// (get) Token: 0x06000B59 RID: 2905 RVA: 0x000050D4 File Offset: 0x000032D4
		// (set) Token: 0x06000B5A RID: 2906 RVA: 0x00067A8C File Offset: 0x00065C8C
		public override ConstructorHandling ConstructorHandling
		{
			get
			{
				return this._serializer.ConstructorHandling;
			}
			set
			{
				for (;;)
				{
					this._serializer.ConstructorHandling = value;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_92ac2a37edba4e2587eb1b9e8af3f63f == 0)
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

		// Token: 0x17000192 RID: 402
		// (get) Token: 0x06000B5B RID: 2907 RVA: 0x000050E1 File Offset: 0x000032E1
		// (set) Token: 0x06000B5C RID: 2908 RVA: 0x00067AC8 File Offset: 0x00065CC8
		[Obsolete("Binder is obsolete. Use SerializationBinder instead.")]
		public override SerializationBinder Binder
		{
			get
			{
				return this._serializer.Binder;
			}
			set
			{
				for (;;)
				{
					this._serializer.Binder = value;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_afb77be96d644a2297c7f9466cb06ede != 0)
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

		// Token: 0x17000193 RID: 403
		// (get) Token: 0x06000B5D RID: 2909 RVA: 0x000050EE File Offset: 0x000032EE
		// (set) Token: 0x06000B5E RID: 2910 RVA: 0x00067B04 File Offset: 0x00065D04
		public override GInterface2 SerializationBinder
		{
			get
			{
				return this._serializer.SerializationBinder;
			}
			set
			{
				for (;;)
				{
					this._serializer.SerializationBinder = value;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5f127c3ec2e04c11ab1bd26a8d965f2b == 0)
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

		// Token: 0x17000194 RID: 404
		// (get) Token: 0x06000B5F RID: 2911 RVA: 0x000050FB File Offset: 0x000032FB
		// (set) Token: 0x06000B60 RID: 2912 RVA: 0x00067B40 File Offset: 0x00065D40
		public override StreamingContext Context
		{
			get
			{
				return this._serializer.Context;
			}
			set
			{
				for (;;)
				{
					this._serializer.Context = value;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c08ab7af63da4f24a4fa3e9c7a732fae != 0)
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

		// Token: 0x17000195 RID: 405
		// (get) Token: 0x06000B61 RID: 2913 RVA: 0x00005108 File Offset: 0x00003308
		// (set) Token: 0x06000B62 RID: 2914 RVA: 0x00067B7C File Offset: 0x00065D7C
		public override Formatting Formatting
		{
			get
			{
				return this._serializer.Formatting;
			}
			set
			{
				for (;;)
				{
					this._serializer.Formatting = value;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_db7740c6ca7a4f3c8e1aa526bdb0a454 != 0)
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

		// Token: 0x17000196 RID: 406
		// (get) Token: 0x06000B63 RID: 2915 RVA: 0x00005115 File Offset: 0x00003315
		// (set) Token: 0x06000B64 RID: 2916 RVA: 0x00067BB8 File Offset: 0x00065DB8
		public override DateFormatHandling DateFormatHandling
		{
			get
			{
				return this._serializer.DateFormatHandling;
			}
			set
			{
				for (;;)
				{
					this._serializer.DateFormatHandling = value;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a5994720d09542abb897ebf6ad9b5a19 == 0)
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

		// Token: 0x17000197 RID: 407
		// (get) Token: 0x06000B65 RID: 2917 RVA: 0x00005122 File Offset: 0x00003322
		// (set) Token: 0x06000B66 RID: 2918 RVA: 0x00067BF4 File Offset: 0x00065DF4
		public override DateTimeZoneHandling DateTimeZoneHandling
		{
			get
			{
				return this._serializer.DateTimeZoneHandling;
			}
			set
			{
				for (;;)
				{
					this._serializer.DateTimeZoneHandling = value;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ee35a23edd8f4998990ec1a2b40fc61a != 0)
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

		// Token: 0x17000198 RID: 408
		// (get) Token: 0x06000B67 RID: 2919 RVA: 0x0000512F File Offset: 0x0000332F
		// (set) Token: 0x06000B68 RID: 2920 RVA: 0x00067C30 File Offset: 0x00065E30
		public override DateParseHandling DateParseHandling
		{
			get
			{
				return this._serializer.DateParseHandling;
			}
			set
			{
				for (;;)
				{
					this._serializer.DateParseHandling = value;
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

		// Token: 0x17000199 RID: 409
		// (get) Token: 0x06000B69 RID: 2921 RVA: 0x0000513C File Offset: 0x0000333C
		// (set) Token: 0x06000B6A RID: 2922 RVA: 0x00067C6C File Offset: 0x00065E6C
		public override FloatFormatHandling FloatFormatHandling
		{
			get
			{
				return this._serializer.FloatFormatHandling;
			}
			set
			{
				for (;;)
				{
					this._serializer.FloatFormatHandling = value;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2a74c5ebb7d84adcad853e2eda393dc4 == 0)
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

		// Token: 0x1700019A RID: 410
		// (get) Token: 0x06000B6B RID: 2923 RVA: 0x00005149 File Offset: 0x00003349
		// (set) Token: 0x06000B6C RID: 2924 RVA: 0x00067CA8 File Offset: 0x00065EA8
		public override FloatParseHandling FloatParseHandling
		{
			get
			{
				return this._serializer.FloatParseHandling;
			}
			set
			{
				for (;;)
				{
					this._serializer.FloatParseHandling = value;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c28a4ed7a58e45aaa9902e336fd60b97 == 0)
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

		// Token: 0x1700019B RID: 411
		// (get) Token: 0x06000B6D RID: 2925 RVA: 0x00005156 File Offset: 0x00003356
		// (set) Token: 0x06000B6E RID: 2926 RVA: 0x00067CE4 File Offset: 0x00065EE4
		public override StringEscapeHandling StringEscapeHandling
		{
			get
			{
				return this._serializer.StringEscapeHandling;
			}
			set
			{
				for (;;)
				{
					this._serializer.StringEscapeHandling = value;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7dfc957a76cb4c58b17dc74a084c4e4a != 0)
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

		// Token: 0x1700019C RID: 412
		// (get) Token: 0x06000B6F RID: 2927 RVA: 0x00005163 File Offset: 0x00003363
		// (set) Token: 0x06000B70 RID: 2928 RVA: 0x00067D20 File Offset: 0x00065F20
		public override string DateFormatString
		{
			get
			{
				return this._serializer.DateFormatString;
			}
			set
			{
				for (;;)
				{
					this._serializer.DateFormatString = value;
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

		// Token: 0x1700019D RID: 413
		// (get) Token: 0x06000B71 RID: 2929 RVA: 0x00005170 File Offset: 0x00003370
		// (set) Token: 0x06000B72 RID: 2930 RVA: 0x00067D5C File Offset: 0x00065F5C
		public override CultureInfo Culture
		{
			get
			{
				return this._serializer.Culture;
			}
			set
			{
				for (;;)
				{
					this._serializer.Culture = value;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_48fe014748e848c88d3254f339047927 != 0)
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

		// Token: 0x1700019E RID: 414
		// (get) Token: 0x06000B73 RID: 2931 RVA: 0x0000517D File Offset: 0x0000337D
		// (set) Token: 0x06000B74 RID: 2932 RVA: 0x0000518A File Offset: 0x0000338A
		public override int? MaxDepth
		{
			get
			{
				return this._serializer.MaxDepth;
			}
			set
			{
				this._serializer.MaxDepth = value;
			}
		}

		// Token: 0x1700019F RID: 415
		// (get) Token: 0x06000B75 RID: 2933 RVA: 0x00005198 File Offset: 0x00003398
		// (set) Token: 0x06000B76 RID: 2934 RVA: 0x00067D98 File Offset: 0x00065F98
		public override bool CheckAdditionalContent
		{
			get
			{
				return this._serializer.CheckAdditionalContent;
			}
			set
			{
				for (;;)
				{
					this._serializer.CheckAdditionalContent = value;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b2d935deb963472994f6f2321f1a6296 != 0)
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

		// Token: 0x06000B77 RID: 2935 RVA: 0x00067DD4 File Offset: 0x00065FD4
		internal JsonSerializerInternalBase GetInternalSerializer()
		{
			while (this.jsonSerializerInternalReader_0 == null)
			{
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2e3be65f7cb2480482903dc73ec42f7c != 0)
				{
					switch (num)
					{
					case 1:
						continue;
					case 2:
						goto IL_003B;
					}
				}
				return this.jsonSerializerInternalWriter_0;
			}
			IL_003B:
			return this.jsonSerializerInternalReader_0;
		}

		// Token: 0x06000B78 RID: 2936 RVA: 0x00067E24 File Offset: 0x00066024
		public JsonSerializerProxy(JsonSerializerInternalReader serializerReader)
		{
			int num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8f48544341da433d9f954b548c7e9212 == 0)
			{
				goto IL_0066;
			}
			do
			{
				IL_0037:
				ValidationUtils.ArgumentNotNull(serializerReader, Class15.smethod_17(543281764 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_43b8cdd768c545d884bf7ff1c8fefe89));
				num = 1;
			}
			while (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_370349efcd7c4959a098549c3d5bf14d == 0);
			for (;;)
			{
				IL_0066:
				switch (num)
				{
				case 1:
					for (;;)
					{
						this.jsonSerializerInternalReader_0 = serializerReader;
						num = 2;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bd75de9a0b64d6da3a43e57303102f1 != 0)
						{
							goto IL_0066;
						}
					}
					break;
				case 2:
					goto IL_007E;
				case 3:
					return;
				}
				break;
			}
			goto IL_0037;
			IL_007E:
			this._serializer = serializerReader.Serializer;
		}

		// Token: 0x06000B79 RID: 2937 RVA: 0x00067EBC File Offset: 0x000660BC
		public JsonSerializerProxy(JsonSerializerInternalWriter serializerWriter)
		{
			int num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0361b8eb39074ea88f5257b13904930a != 0)
			{
				goto IL_0046;
			}
			IL_001A:
			ValidationUtils.ArgumentNotNull(serializerWriter, Class15.smethod_17(635772427 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a41eabd4b99f489fb7d86310d3f95ba2));
			num = 1;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d9581c727fcc4f50accd4f5de0d386f5 != 0)
			{
				goto IL_005F;
			}
			IL_0046:
			switch (num)
			{
			case 0:
				goto IL_001A;
			case 1:
				break;
			case 2:
				goto IL_0066;
			case 3:
				return;
			default:
				goto IL_001A;
			}
			IL_005F:
			this.jsonSerializerInternalWriter_0 = serializerWriter;
			IL_0066:
			this._serializer = serializerWriter.Serializer;
		}

		// Token: 0x06000B7A RID: 2938 RVA: 0x00067F3C File Offset: 0x0006613C
		[NullableContext(2)]
		internal override object DeserializeInternal([Nullable(1)] JsonReader reader, Type objectType)
		{
			while (this.jsonSerializerInternalReader_0 == null)
			{
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7dfc957a76cb4c58b17dc74a084c4e4a == 0)
				{
					break;
				}
				switch (num)
				{
				case 0:
					goto IL_0042;
				case 1:
					return this._serializer.Deserialize(reader, objectType);
				case 2:
					break;
				default:
					goto IL_0042;
				}
			}
			IL_0042:
			return this.jsonSerializerInternalReader_0.Deserialize(reader, objectType, false);
		}

		// Token: 0x06000B7B RID: 2939 RVA: 0x00067F9C File Offset: 0x0006619C
		internal override void PopulateInternal(JsonReader reader, object target)
		{
			IL_004D:
			while (this.jsonSerializerInternalReader_0 != null)
			{
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_eaded84ad5b14e1ea8d4d97bfed1bb48 != 0)
				{
					for (;;)
					{
						switch (num)
						{
						case 1:
							this.jsonSerializerInternalReader_0.Populate(reader, target);
							num = 0;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2e3be65f7cb2480482903dc73ec42f7c != 0)
							{
								continue;
							}
							break;
						case 2:
							goto IL_004D;
						case 3:
							return;
						}
						break;
					}
					return;
				}
				return;
			}
			this._serializer.Populate(reader, target);
		}

		// Token: 0x06000B7C RID: 2940 RVA: 0x00068014 File Offset: 0x00066214
		[NullableContext(2)]
		internal override void SerializeInternal([Nullable(1)] JsonWriter jsonWriter, object value, Type rootType)
		{
			while (this.jsonSerializerInternalWriter_0 == null)
			{
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_370349efcd7c4959a098549c3d5bf14d == 0)
				{
					switch (num)
					{
					case 1:
						continue;
					case 2:
						goto IL_004A;
					case 3:
						return;
					case 4:
						return;
					}
				}
				this._serializer.Serialize(jsonWriter, value);
				return;
			}
			IL_004A:
			this.jsonSerializerInternalWriter_0.Serialize(jsonWriter, value, rootType);
		}

		// Token: 0x040005A5 RID: 1445
		[Nullable(2)]
		private readonly JsonSerializerInternalReader jsonSerializerInternalReader_0;

		// Token: 0x040005A6 RID: 1446
		[Nullable(2)]
		private readonly JsonSerializerInternalWriter jsonSerializerInternalWriter_0;

		// Token: 0x040005A7 RID: 1447
		internal readonly JsonSerializer _serializer;
	}
}
