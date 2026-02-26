
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

using EntitySpaces.Core;
using EntitySpaces.DynamicQuery;
using EntitySpaces.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;



namespace BusinessObjects
{
	/// <summary>
	/// Encapsulates the 'constructortest' table
	/// </summary>

	[Serializable]
	[DataContract]
	[KnownType(typeof(ConstructorTest))]	
	[XmlType("ConstructorTest")]
	public partial class ConstructorTest : esConstructorTest
	{	
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override esEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public esEntity CreateInstance()
		{
			return new ConstructorTest();
		}
		
		#region Static Quick Access Methods
		static public void Delete(System.Int64 constructorTestId)
		{
			var obj = new ConstructorTest();
			obj.ConstructorTestId = constructorTestId;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save();
		}

	    static public void Delete(System.Int64 constructorTestId, esSqlAccessType sqlAccessType)
		{
			var obj = new ConstructorTest();
			obj.ConstructorTestId = constructorTestId;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save(sqlAccessType);
		}
		#endregion

		
					
		
	
	}



	[Serializable]
	[CollectionDataContract]
	[XmlType("ConstructorTestCollection")]
	public partial class ConstructorTestCollection : esConstructorTestCollection, IEnumerable<ConstructorTest>
	{
		public ConstructorTest FindByPrimaryKey(System.Int64 constructorTestId)
		{
			return this.SingleOrDefault(e => e.ConstructorTestId == constructorTestId);
		}

		
		
		#region WCF Service Class
		
		[DataContract]
		[KnownType(typeof(ConstructorTest))]
		public class ConstructorTestCollectionWCFPacket : esCollectionWCFPacket<ConstructorTestCollection>
		{
			public static implicit operator ConstructorTestCollection(ConstructorTestCollectionWCFPacket packet)
			{
				return packet.Collection;
			}

			public static implicit operator ConstructorTestCollectionWCFPacket(ConstructorTestCollection collection)
			{
				return new ConstructorTestCollectionWCFPacket() { Collection = collection };
			}
		}
		
		#endregion
		
				
	}



	[Serializable]	
	public partial class ConstructorTestQuery : esConstructorTestQuery
	{
		public ConstructorTestQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

		override protected string GetQueryName()
		{
			return "ConstructorTestQuery";
		}
		
					
	
		#region Explicit Casts
		
		public static explicit operator string(ConstructorTestQuery query)
		{
			return ConstructorTestQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator ConstructorTestQuery(string query)
		{
			return (ConstructorTestQuery)ConstructorTestQuery.SerializeHelper.FromXml(query, typeof(ConstructorTestQuery));
		}
		
		#endregion		
	}

	[DataContract]
	[Serializable]
	abstract public partial class esConstructorTest : esEntity
	{
		public esConstructorTest()
		{

		}
		
		#region LoadByPrimaryKey
		public virtual bool LoadByPrimaryKey(System.Int64 constructorTestId)
		{
			if(this.es.Connection.SqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(constructorTestId);
			else
				return LoadByPrimaryKeyStoredProcedure(constructorTestId);
		}

		public virtual bool LoadByPrimaryKey(esSqlAccessType sqlAccessType, System.Int64 constructorTestId)
		{
			if (sqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(constructorTestId);
			else
				return LoadByPrimaryKeyStoredProcedure(constructorTestId);
		}

		private bool LoadByPrimaryKeyDynamic(System.Int64 constructorTestId)
		{
			ConstructorTestQuery query = new ConstructorTestQuery();
			query.Where(query.ConstructorTestId == constructorTestId);
			return this.Load(query);
		}

		private bool LoadByPrimaryKeyStoredProcedure(System.Int64 constructorTestId)
		{
			esParameters parms = new esParameters();
			parms.Add("ConstructorTestId", constructorTestId);
			return this.Load(esQueryType.StoredProcedure, this.es.spLoadByPrimaryKey, parms);
		}
		#endregion
		
		#region Properties
		
		
		
		/// <summary>
		/// Maps to constructortest.ConstructorTestId
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int64? ConstructorTestId
		{
			get
			{
				return base.GetSystemInt64(ConstructorTestMetadata.ColumnNames.ConstructorTestId);
			}
			
			set
			{
				if(base.SetSystemInt64(ConstructorTestMetadata.ColumnNames.ConstructorTestId, value))
				{
					OnPropertyChanged(ConstructorTestMetadata.PropertyNames.ConstructorTestId);
				}
			}
		}		
		
		/// <summary>
		/// Maps to constructortest.DefaultInt
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? DefaultInt
		{
			get
			{
				return base.GetSystemInt32(ConstructorTestMetadata.ColumnNames.DefaultInt);
			}
			
			set
			{
				if(base.SetSystemInt32(ConstructorTestMetadata.ColumnNames.DefaultInt, value))
				{
					OnPropertyChanged(ConstructorTestMetadata.PropertyNames.DefaultInt);
				}
			}
		}		
		
		/// <summary>
		/// Maps to constructortest.DefaultBool
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.SByte? DefaultBool
		{
			get
			{
				return base.GetSystemSByte(ConstructorTestMetadata.ColumnNames.DefaultBool);
			}
			
			set
			{
				if(base.SetSystemSByte(ConstructorTestMetadata.ColumnNames.DefaultBool, value))
				{
					OnPropertyChanged(ConstructorTestMetadata.PropertyNames.DefaultBool);
				}
			}
		}		
		
		/// <summary>
		/// Maps to constructortest.DefaultDateTime
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.DateTime? DefaultDateTime
		{
			get
			{
				return base.GetSystemDateTime(ConstructorTestMetadata.ColumnNames.DefaultDateTime);
			}
			
			set
			{
				if(base.SetSystemDateTime(ConstructorTestMetadata.ColumnNames.DefaultDateTime, value))
				{
					OnPropertyChanged(ConstructorTestMetadata.PropertyNames.DefaultDateTime);
				}
			}
		}		
		
		/// <summary>
		/// Maps to constructortest.DefaultString
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String DefaultString
		{
			get
			{
				return base.GetSystemString(ConstructorTestMetadata.ColumnNames.DefaultString);
			}
			
			set
			{
				if(base.SetSystemString(ConstructorTestMetadata.ColumnNames.DefaultString, value))
				{
					OnPropertyChanged(ConstructorTestMetadata.PropertyNames.DefaultString);
				}
			}
		}		
		
		#endregion
		
		#region Housekeeping methods

		override protected IMetadata Meta
		{
			get
			{
				return ConstructorTestMetadata.Meta();
			}
		}

		#endregion		
		
		#region Query Logic

		public ConstructorTestQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new ConstructorTestQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(ConstructorTestQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}
		
		protected void InitQuery(ConstructorTestQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntity)this).Connection;
			}			
		}

		#endregion
		
        [IgnoreDataMember]
		private ConstructorTestQuery query;		
	}



	[Serializable]
	abstract public partial class esConstructorTestCollection : esEntityCollection<ConstructorTest>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return ConstructorTestMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "ConstructorTestCollection";
		}

		#endregion		
		
		#region Query Logic

	#if (!WindowsCE)
		[BrowsableAttribute(false)]
	#endif
		public ConstructorTestQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new ConstructorTestQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(ConstructorTestQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new ConstructorTestQuery();
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(ConstructorTestQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntityCollection)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((ConstructorTestQuery)query);
		}

		#endregion
		
		private ConstructorTestQuery query;
	}



	[Serializable]
	abstract public partial class esConstructorTestQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return ConstructorTestMetadata.Meta();
			}
		}	
		
		#region QueryItemFromName
		
        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
				case "ConstructorTestId": return this.ConstructorTestId;
				case "DefaultInt": return this.DefaultInt;
				case "DefaultBool": return this.DefaultBool;
				case "DefaultDateTime": return this.DefaultDateTime;
				case "DefaultString": return this.DefaultString;

                default: return null;
            }
        }		
		
		#endregion
		
		#region esQueryItems

		public esQueryItem ConstructorTestId
		{
			get { return new esQueryItem(this, ConstructorTestMetadata.ColumnNames.ConstructorTestId, esSystemType.Int64); }
		} 
		
		public esQueryItem DefaultInt
		{
			get { return new esQueryItem(this, ConstructorTestMetadata.ColumnNames.DefaultInt, esSystemType.Int32); }
		} 
		
		public esQueryItem DefaultBool
		{
			get { return new esQueryItem(this, ConstructorTestMetadata.ColumnNames.DefaultBool, esSystemType.SByte); }
		} 
		
		public esQueryItem DefaultDateTime
		{
			get { return new esQueryItem(this, ConstructorTestMetadata.ColumnNames.DefaultDateTime, esSystemType.DateTime); }
		} 
		
		public esQueryItem DefaultString
		{
			get { return new esQueryItem(this, ConstructorTestMetadata.ColumnNames.DefaultString, esSystemType.String); }
		} 
		
		#endregion
		
	}


	
	public partial class ConstructorTest : esConstructorTest
	{

		
		
	}
	



	[Serializable]
	public partial class ConstructorTestMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected ConstructorTestMetadata()
		{
			m_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(ConstructorTestMetadata.ColumnNames.ConstructorTestId, 0, typeof(System.Int64), esSystemType.Int64);
			c.PropertyName = ConstructorTestMetadata.PropertyNames.ConstructorTestId;
			c.IsInPrimaryKey = true;
			c.IsAutoIncrement = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ConstructorTestMetadata.ColumnNames.DefaultInt, 1, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = ConstructorTestMetadata.PropertyNames.DefaultInt;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ConstructorTestMetadata.ColumnNames.DefaultBool, 2, typeof(System.SByte), esSystemType.SByte);
			c.PropertyName = ConstructorTestMetadata.PropertyNames.DefaultBool;
			c.HasDefault = true;
			c.Default = @"0";
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ConstructorTestMetadata.ColumnNames.DefaultDateTime, 3, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = ConstructorTestMetadata.PropertyNames.DefaultDateTime;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ConstructorTestMetadata.ColumnNames.DefaultString, 4, typeof(System.String), esSystemType.String);
			c.PropertyName = ConstructorTestMetadata.PropertyNames.DefaultString;
			c.CharacterMaxLength = 10;
			c.HasDefault = true;
			c.Default = @"('[new]')";
			c.IsNullable = true;
			m_columns.Add(c);
				
		}
		#endregion	
	
		static public ConstructorTestMetadata Meta()
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
			 public const string ConstructorTestId = "ConstructorTestId";
			 public const string DefaultInt = "DefaultInt";
			 public const string DefaultBool = "DefaultBool";
			 public const string DefaultDateTime = "DefaultDateTime";
			 public const string DefaultString = "DefaultString";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string ConstructorTestId = "ConstructorTestId";
			 public const string DefaultInt = "DefaultInt";
			 public const string DefaultBool = "DefaultBool";
			 public const string DefaultDateTime = "DefaultDateTime";
			 public const string DefaultString = "DefaultString";
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
			lock (typeof(ConstructorTestMetadata))
			{
				if(ConstructorTestMetadata.mapDelegates == null)
				{
					ConstructorTestMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (ConstructorTestMetadata.meta == null)
				{
					ConstructorTestMetadata.meta = new ConstructorTestMetadata();
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


				meta.AddTypeMap("ConstructorTestId", new esTypeMap("BIGINT", "System.Int64"));
				meta.AddTypeMap("DefaultInt", new esTypeMap("INT", "System.Int32"));
				meta.AddTypeMap("DefaultBool", new esTypeMap("TINYINT", "System.SByte"));
				meta.AddTypeMap("DefaultDateTime", new esTypeMap("DATETIME", "System.DateTime"));
				meta.AddTypeMap("DefaultString", new esTypeMap("VARCHAR", "System.String"));			
				
				
				
				meta.Source = "constructortest";
				meta.Destination = "constructortest";
				
				meta.spInsert = "proc_constructortestInsert";				
				meta.spUpdate = "proc_constructortestUpdate";		
				meta.spDelete = "proc_constructortestDelete";
				meta.spLoadAll = "proc_constructortestLoadAll";
				meta.spLoadByPrimaryKey = "proc_constructortestLoadByPrimaryKey";
				
				this.m_providerMetadataMaps["esDefault"] = meta;
			}
			
			return this.m_providerMetadataMaps["esDefault"];
		}

		#endregion

		static private ConstructorTestMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
