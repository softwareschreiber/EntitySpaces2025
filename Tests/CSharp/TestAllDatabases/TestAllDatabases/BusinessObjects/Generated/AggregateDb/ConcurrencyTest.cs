
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
	/// Encapsulates the 'concurrencytest' table
	/// </summary>

	[Serializable]
	[DataContract]
	[KnownType(typeof(ConcurrencyTest))]	
	[XmlType("ConcurrencyTest")]
	public partial class ConcurrencyTest : esConcurrencyTest
	{	
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override esEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public esEntity CreateInstance()
		{
			return new ConcurrencyTest();
		}
		
		#region Static Quick Access Methods
		static public void Delete(System.String id)
		{
			var obj = new ConcurrencyTest();
			obj.Id = id;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save();
		}

	    static public void Delete(System.String id, esSqlAccessType sqlAccessType)
		{
			var obj = new ConcurrencyTest();
			obj.Id = id;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save(sqlAccessType);
		}
		#endregion

		
					
		
	
	}



	[Serializable]
	[CollectionDataContract]
	[XmlType("ConcurrencyTestCollection")]
	public partial class ConcurrencyTestCollection : esConcurrencyTestCollection, IEnumerable<ConcurrencyTest>
	{
		public ConcurrencyTest FindByPrimaryKey(System.String id)
		{
			return this.SingleOrDefault(e => e.Id == id);
		}

		
		
		#region WCF Service Class
		
		[DataContract]
		[KnownType(typeof(ConcurrencyTest))]
		public class ConcurrencyTestCollectionWCFPacket : esCollectionWCFPacket<ConcurrencyTestCollection>
		{
			public static implicit operator ConcurrencyTestCollection(ConcurrencyTestCollectionWCFPacket packet)
			{
				return packet.Collection;
			}

			public static implicit operator ConcurrencyTestCollectionWCFPacket(ConcurrencyTestCollection collection)
			{
				return new ConcurrencyTestCollectionWCFPacket() { Collection = collection };
			}
		}
		
		#endregion
		
				
	}



	[Serializable]	
	public partial class ConcurrencyTestQuery : esConcurrencyTestQuery
	{
		public ConcurrencyTestQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

		override protected string GetQueryName()
		{
			return "ConcurrencyTestQuery";
		}
		
					
	
		#region Explicit Casts
		
		public static explicit operator string(ConcurrencyTestQuery query)
		{
			return ConcurrencyTestQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator ConcurrencyTestQuery(string query)
		{
			return (ConcurrencyTestQuery)ConcurrencyTestQuery.SerializeHelper.FromXml(query, typeof(ConcurrencyTestQuery));
		}
		
		#endregion		
	}

	[DataContract]
	[Serializable]
	abstract public partial class esConcurrencyTest : esEntity
	{
		public esConcurrencyTest()
		{

		}
		
		#region LoadByPrimaryKey
		public virtual bool LoadByPrimaryKey(System.String id)
		{
			if(this.es.Connection.SqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(id);
			else
				return LoadByPrimaryKeyStoredProcedure(id);
		}

		public virtual bool LoadByPrimaryKey(esSqlAccessType sqlAccessType, System.String id)
		{
			if (sqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(id);
			else
				return LoadByPrimaryKeyStoredProcedure(id);
		}

		private bool LoadByPrimaryKeyDynamic(System.String id)
		{
			ConcurrencyTestQuery query = new ConcurrencyTestQuery();
			query.Where(query.Id == id);
			return this.Load(query);
		}

		private bool LoadByPrimaryKeyStoredProcedure(System.String id)
		{
			esParameters parms = new esParameters();
			parms.Add("Id", id);
			return this.Load(esQueryType.StoredProcedure, this.es.spLoadByPrimaryKey, parms);
		}
		#endregion
		
		#region Properties
		
		
		
		/// <summary>
		/// Maps to concurrencytest.Id
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Id
		{
			get
			{
				return base.GetSystemString(ConcurrencyTestMetadata.ColumnNames.Id);
			}
			
			set
			{
				if(base.SetSystemString(ConcurrencyTestMetadata.ColumnNames.Id, value))
				{
					OnPropertyChanged(ConcurrencyTestMetadata.PropertyNames.Id);
				}
			}
		}		
		
		/// <summary>
		/// Maps to concurrencytest.Name
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Name
		{
			get
			{
				return base.GetSystemString(ConcurrencyTestMetadata.ColumnNames.Name);
			}
			
			set
			{
				if(base.SetSystemString(ConcurrencyTestMetadata.ColumnNames.Name, value))
				{
					OnPropertyChanged(ConcurrencyTestMetadata.PropertyNames.Name);
				}
			}
		}		
		
		/// <summary>
		/// Maps to concurrencytest.ConcurrencyCheck
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int64? ConcurrencyCheck
		{
			get
			{
				return base.GetSystemInt64(ConcurrencyTestMetadata.ColumnNames.ConcurrencyCheck);
			}
			
			set
			{
				if(base.SetSystemInt64(ConcurrencyTestMetadata.ColumnNames.ConcurrencyCheck, value))
				{
					OnPropertyChanged(ConcurrencyTestMetadata.PropertyNames.ConcurrencyCheck);
				}
			}
		}		
		
		#endregion
		
		#region Housekeeping methods

		override protected IMetadata Meta
		{
			get
			{
				return ConcurrencyTestMetadata.Meta();
			}
		}

		#endregion		
		
		#region Query Logic

		public ConcurrencyTestQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new ConcurrencyTestQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(ConcurrencyTestQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}
		
		protected void InitQuery(ConcurrencyTestQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntity)this).Connection;
			}			
		}

		#endregion
		
        [IgnoreDataMember]
		private ConcurrencyTestQuery query;		
	}



	[Serializable]
	abstract public partial class esConcurrencyTestCollection : esEntityCollection<ConcurrencyTest>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return ConcurrencyTestMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "ConcurrencyTestCollection";
		}

		#endregion		
		
		#region Query Logic

	#if (!WindowsCE)
		[BrowsableAttribute(false)]
	#endif
		public ConcurrencyTestQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new ConcurrencyTestQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(ConcurrencyTestQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new ConcurrencyTestQuery();
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(ConcurrencyTestQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntityCollection)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((ConcurrencyTestQuery)query);
		}

		#endregion
		
		private ConcurrencyTestQuery query;
	}



	[Serializable]
	abstract public partial class esConcurrencyTestQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return ConcurrencyTestMetadata.Meta();
			}
		}	
		
		#region QueryItemFromName
		
        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
				case "Id": return this.Id;
				case "Name": return this.Name;
				case "ConcurrencyCheck": return this.ConcurrencyCheck;

                default: return null;
            }
        }		
		
		#endregion
		
		#region esQueryItems

		public esQueryItem Id
		{
			get { return new esQueryItem(this, ConcurrencyTestMetadata.ColumnNames.Id, esSystemType.String); }
		} 
		
		public esQueryItem Name
		{
			get { return new esQueryItem(this, ConcurrencyTestMetadata.ColumnNames.Name, esSystemType.String); }
		} 
		
		public esQueryItem ConcurrencyCheck
		{
			get { return new esQueryItem(this, ConcurrencyTestMetadata.ColumnNames.ConcurrencyCheck, esSystemType.Int64); }
		} 
		
		#endregion
		
	}


	
	public partial class ConcurrencyTest : esConcurrencyTest
	{

		
		
	}
	



	[Serializable]
	public partial class ConcurrencyTestMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected ConcurrencyTestMetadata()
		{
			m_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(ConcurrencyTestMetadata.ColumnNames.Id, 0, typeof(System.String), esSystemType.String);
			c.PropertyName = ConcurrencyTestMetadata.PropertyNames.Id;
			c.IsInPrimaryKey = true;
			c.CharacterMaxLength = 3;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ConcurrencyTestMetadata.ColumnNames.Name, 1, typeof(System.String), esSystemType.String);
			c.PropertyName = ConcurrencyTestMetadata.PropertyNames.Name;
			c.CharacterMaxLength = 20;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ConcurrencyTestMetadata.ColumnNames.ConcurrencyCheck, 2, typeof(System.Int64), esSystemType.Int64);
			c.PropertyName = ConcurrencyTestMetadata.PropertyNames.ConcurrencyCheck;
			c.IsNullable = true;
			m_columns.Add(c);
				
		}
		#endregion	
	
		static public ConcurrencyTestMetadata Meta()
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
			 public const string Id = "Id";
			 public const string Name = "Name";
			 public const string ConcurrencyCheck = "ConcurrencyCheck";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string Id = "Id";
			 public const string Name = "Name";
			 public const string ConcurrencyCheck = "ConcurrencyCheck";
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
			lock (typeof(ConcurrencyTestMetadata))
			{
				if(ConcurrencyTestMetadata.mapDelegates == null)
				{
					ConcurrencyTestMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (ConcurrencyTestMetadata.meta == null)
				{
					ConcurrencyTestMetadata.meta = new ConcurrencyTestMetadata();
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


				meta.AddTypeMap("Id", new esTypeMap("CHAR", "System.String"));
				meta.AddTypeMap("Name", new esTypeMap("VARCHAR", "System.String"));
				meta.AddTypeMap("ConcurrencyCheck", new esTypeMap("BIGINT", "System.Int64"));			
				
				
				
				meta.Source = "concurrencytest";
				meta.Destination = "concurrencytest";
				
				meta.spInsert = "proc_concurrencytestInsert";				
				meta.spUpdate = "proc_concurrencytestUpdate";		
				meta.spDelete = "proc_concurrencytestDelete";
				meta.spLoadAll = "proc_concurrencytestLoadAll";
				meta.spLoadByPrimaryKey = "proc_concurrencytestLoadByPrimaryKey";
				
				this.m_providerMetadataMaps["esDefault"] = meta;
			}
			
			return this.m_providerMetadataMaps["esDefault"];
		}

		#endregion

		static private ConcurrencyTestMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
