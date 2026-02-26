
/*
===============================================================================
                    EntitySpaces Studio by EntitySpaces, LLC
             Persistence Layer and Business Objects for Microsoft .NET
             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
                          http://www.entityspaces.net
===============================================================================
EntitySpaces Version : 2024.3.0001.1
EntitySpaces Driver  : MySql
Date Generated       : 03.12.2025 14:08:20
===============================================================================
*/

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Linq;
using System.Data;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Runtime.Serialization;

using EntitySpaces.Core;
using EntitySpaces.Interfaces;
using EntitySpaces.DynamicQuery;



namespace BusinessObjects
{
	/// <summary>
	/// Encapsulates the 'defaulttest' table
	/// </summary>

	[Serializable]
	[DataContract]
	[KnownType(typeof(DefaultTest))]	
	[XmlType("DefaultTest")]
	public partial class DefaultTest : esDefaultTest
	{	
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override esEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public esEntity CreateInstance()
		{
			return new DefaultTest();
		}
		
		#region Static Quick Access Methods
		static public void Delete(System.Int32 testId)
		{
			var obj = new DefaultTest();
			obj.TestId = testId;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save();
		}

	    static public void Delete(System.Int32 testId, esSqlAccessType sqlAccessType)
		{
			var obj = new DefaultTest();
			obj.TestId = testId;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save(sqlAccessType);
		}
		#endregion

		
					
		
	
	}



	[Serializable]
	[CollectionDataContract]
	[XmlType("DefaultTestCollection")]
	public partial class DefaultTestCollection : esDefaultTestCollection, IEnumerable<DefaultTest>
	{
		public DefaultTest FindByPrimaryKey(System.Int32 testId)
		{
			return this.SingleOrDefault(e => e.TestId == testId);
		}

		
		
		#region WCF Service Class
		
		[DataContract]
		[KnownType(typeof(DefaultTest))]
		public class DefaultTestCollectionWCFPacket : esCollectionWCFPacket<DefaultTestCollection>
		{
			public static implicit operator DefaultTestCollection(DefaultTestCollectionWCFPacket packet)
			{
				return packet.Collection;
			}

			public static implicit operator DefaultTestCollectionWCFPacket(DefaultTestCollection collection)
			{
				return new DefaultTestCollectionWCFPacket() { Collection = collection };
			}
		}
		
		#endregion
		
				
	}



	[Serializable]	
	public partial class DefaultTestQuery : esDefaultTestQuery
	{
		public DefaultTestQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

		override protected string GetQueryName()
		{
			return "DefaultTestQuery";
		}
		
					
	
		#region Explicit Casts
		
		public static explicit operator string(DefaultTestQuery query)
		{
			return DefaultTestQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator DefaultTestQuery(string query)
		{
			return (DefaultTestQuery)DefaultTestQuery.SerializeHelper.FromXml(query, typeof(DefaultTestQuery));
		}
		
		#endregion		
	}

	[DataContract]
	[Serializable]
	abstract public partial class esDefaultTest : esEntity
	{
		public esDefaultTest()
		{

		}
		
		#region LoadByPrimaryKey
		public virtual bool LoadByPrimaryKey(System.Int32 testId)
		{
			if(this.es.Connection.SqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(testId);
			else
				return LoadByPrimaryKeyStoredProcedure(testId);
		}

		public virtual bool LoadByPrimaryKey(esSqlAccessType sqlAccessType, System.Int32 testId)
		{
			if (sqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(testId);
			else
				return LoadByPrimaryKeyStoredProcedure(testId);
		}

		private bool LoadByPrimaryKeyDynamic(System.Int32 testId)
		{
			DefaultTestQuery query = new DefaultTestQuery();
			query.Where(query.TestId == testId);
			return this.Load(query);
		}

		private bool LoadByPrimaryKeyStoredProcedure(System.Int32 testId)
		{
			esParameters parms = new esParameters();
			parms.Add("TestId", testId);
			return this.Load(esQueryType.StoredProcedure, this.es.spLoadByPrimaryKey, parms);
		}
		#endregion
		
		#region Properties
		
		
		
		/// <summary>
		/// Maps to defaulttest.TestId
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? TestId
		{
			get
			{
				return base.GetSystemInt32(DefaultTestMetadata.ColumnNames.TestId);
			}
			
			set
			{
				if(base.SetSystemInt32(DefaultTestMetadata.ColumnNames.TestId, value))
				{
					OnPropertyChanged(DefaultTestMetadata.PropertyNames.TestId);
				}
			}
		}		
		
		/// <summary>
		/// Maps to defaulttest.DefaultNotNullInt
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? DefaultNotNullInt
		{
			get
			{
				return base.GetSystemInt32(DefaultTestMetadata.ColumnNames.DefaultNotNullInt);
			}
			
			set
			{
				if(base.SetSystemInt32(DefaultTestMetadata.ColumnNames.DefaultNotNullInt, value))
				{
					OnPropertyChanged(DefaultTestMetadata.PropertyNames.DefaultNotNullInt);
				}
			}
		}		
		
		/// <summary>
		/// Maps to defaulttest.DefaultNotNullBool
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.SByte? DefaultNotNullBool
		{
			get
			{
				return base.GetSystemSByte(DefaultTestMetadata.ColumnNames.DefaultNotNullBool);
			}
			
			set
			{
				if(base.SetSystemSByte(DefaultTestMetadata.ColumnNames.DefaultNotNullBool, value))
				{
					OnPropertyChanged(DefaultTestMetadata.PropertyNames.DefaultNotNullBool);
				}
			}
		}		
		
		#endregion
		
		#region Housekeeping methods

		override protected IMetadata Meta
		{
			get
			{
				return DefaultTestMetadata.Meta();
			}
		}

		#endregion		
		
		#region Query Logic

		public DefaultTestQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new DefaultTestQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(DefaultTestQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}
		
		protected void InitQuery(DefaultTestQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntity)this).Connection;
			}			
		}

		#endregion
		
        [IgnoreDataMember]
		private DefaultTestQuery query;		
	}



	[Serializable]
	abstract public partial class esDefaultTestCollection : esEntityCollection<DefaultTest>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return DefaultTestMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "DefaultTestCollection";
		}

		#endregion		
		
		#region Query Logic

	#if (!WindowsCE)
		[BrowsableAttribute(false)]
	#endif
		public DefaultTestQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new DefaultTestQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(DefaultTestQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new DefaultTestQuery();
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(DefaultTestQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntityCollection)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((DefaultTestQuery)query);
		}

		#endregion
		
		private DefaultTestQuery query;
	}



	[Serializable]
	abstract public partial class esDefaultTestQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return DefaultTestMetadata.Meta();
			}
		}	
		
		#region QueryItemFromName
		
        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
				case "TestId": return this.TestId;
				case "DefaultNotNullInt": return this.DefaultNotNullInt;
				case "DefaultNotNullBool": return this.DefaultNotNullBool;

                default: return null;
            }
        }		
		
		#endregion
		
		#region esQueryItems

		public esQueryItem TestId
		{
			get { return new esQueryItem(this, DefaultTestMetadata.ColumnNames.TestId, esSystemType.Int32); }
		} 
		
		public esQueryItem DefaultNotNullInt
		{
			get { return new esQueryItem(this, DefaultTestMetadata.ColumnNames.DefaultNotNullInt, esSystemType.Int32); }
		} 
		
		public esQueryItem DefaultNotNullBool
		{
			get { return new esQueryItem(this, DefaultTestMetadata.ColumnNames.DefaultNotNullBool, esSystemType.SByte); }
		} 
		
		#endregion
		
	}


	
	public partial class DefaultTest : esDefaultTest
	{

		
		
	}
	



	[Serializable]
	public partial class DefaultTestMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected DefaultTestMetadata()
		{
			m_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(DefaultTestMetadata.ColumnNames.TestId, 0, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = DefaultTestMetadata.PropertyNames.TestId;
			c.IsInPrimaryKey = true;
			c.IsAutoIncrement = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(DefaultTestMetadata.ColumnNames.DefaultNotNullInt, 1, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = DefaultTestMetadata.PropertyNames.DefaultNotNullInt;
			c.HasDefault = true;
			c.Default = @"0";
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(DefaultTestMetadata.ColumnNames.DefaultNotNullBool, 2, typeof(System.SByte), esSystemType.SByte);
			c.PropertyName = DefaultTestMetadata.PropertyNames.DefaultNotNullBool;
			c.HasDefault = true;
			c.Default = @"0";
			c.IsNullable = true;
			m_columns.Add(c);
				
		}
		#endregion	
	
		static public DefaultTestMetadata Meta()
		{
			return meta;
		}	
		
		public Guid DataID
		{
			get { return base.m_dataID; }
		}	
		
		public bool MultiProviderMode
		{
			get { return false; }
		}		

		public esColumnMetadataCollection Columns
		{
			get	{ return base.m_columns; }
		}
		
		#region ColumnNames
		public class ColumnNames
		{ 
			 public const string TestId = "TestId";
			 public const string DefaultNotNullInt = "DefaultNotNullInt";
			 public const string DefaultNotNullBool = "DefaultNotNullBool";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string TestId = "TestId";
			 public const string DefaultNotNullInt = "DefaultNotNullInt";
			 public const string DefaultNotNullBool = "DefaultNotNullBool";
		}
		#endregion	

		public esProviderSpecificMetadata GetProviderMetadata(string mapName)
		{
			MapToMeta mapMethod = mapDelegates[mapName];

			if (mapMethod != null)
				return mapMethod(mapName);
			else
				return null;
		}
		
		#region MAP esDefault
		
		static private int RegisterDelegateesDefault()
		{
			// This is only executed once per the life of the application
			lock (typeof(DefaultTestMetadata))
			{
				if(DefaultTestMetadata.mapDelegates == null)
				{
					DefaultTestMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (DefaultTestMetadata.meta == null)
				{
					DefaultTestMetadata.meta = new DefaultTestMetadata();
				}
				
				MapToMeta mapMethod = new MapToMeta(meta.esDefault);
				mapDelegates.Add("esDefault", mapMethod);
				mapMethod("esDefault");
			}
			return 0;
		}			

		private esProviderSpecificMetadata esDefault(string mapName)
		{
			if(!m_providerMetadataMaps.ContainsKey(mapName))
			{
				esProviderSpecificMetadata meta = new esProviderSpecificMetadata();			


				meta.AddTypeMap("TestId", new esTypeMap("INT", "System.Int32"));
				meta.AddTypeMap("DefaultNotNullInt", new esTypeMap("INT", "System.Int32"));
				meta.AddTypeMap("DefaultNotNullBool", new esTypeMap("TINYINT", "System.SByte"));			
				
				
				
				meta.Source = "defaulttest";
				meta.Destination = "defaulttest";
				
				meta.spInsert = "proc_defaulttestInsert";				
				meta.spUpdate = "proc_defaulttestUpdate";		
				meta.spDelete = "proc_defaulttestDelete";
				meta.spLoadAll = "proc_defaulttestLoadAll";
				meta.spLoadByPrimaryKey = "proc_defaulttestLoadByPrimaryKey";
				
				this.m_providerMetadataMaps["esDefault"] = meta;
			}
			
			return this.m_providerMetadataMaps["esDefault"];
		}

		#endregion

		static private DefaultTestMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
