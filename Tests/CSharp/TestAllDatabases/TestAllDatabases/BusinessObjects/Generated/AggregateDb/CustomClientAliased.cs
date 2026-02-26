
/*
===============================================================================
                    EntitySpaces Studio by EntitySpaces, LLC
             Persistence Layer and Business Objects for Microsoft .NET
             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
                          http://www.entityspaces.net
===============================================================================
EntitySpaces Version : 2024.3.0001.1
EntitySpaces Driver  : MySql
Date Generated       : 03.12.2025 14:29:33
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
	/// Encapsulates the 'customclientaliased' table
	/// </summary>

	[Serializable]
	[DataContract]
	[KnownType(typeof(CustomClientAliased))]	
	[XmlType("CustomClientAliased")]
	public partial class CustomClientAliased : esCustomClientAliased
	{	
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override esEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public esEntity CreateInstance()
		{
			return new CustomClientAliased();
		}
		
		#region Static Quick Access Methods
		static public void Delete(System.Int32 autoKey)
		{
			var obj = new CustomClientAliased();
			obj.AutoKey = autoKey;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save();
		}

	    static public void Delete(System.Int32 autoKey, esSqlAccessType sqlAccessType)
		{
			var obj = new CustomClientAliased();
			obj.AutoKey = autoKey;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save(sqlAccessType);
		}
		#endregion

		
					
		
	
	}



	[Serializable]
	[CollectionDataContract]
	[XmlType("CustomClientAliasedCollection")]
	public partial class CustomClientAliasedCollection : esCustomClientAliasedCollection, IEnumerable<CustomClientAliased>
	{
		public CustomClientAliased FindByPrimaryKey(System.Int32 autoKey)
		{
			return this.SingleOrDefault(e => e.AutoKey == autoKey);
		}

		
		
		#region WCF Service Class
		
		[DataContract]
		[KnownType(typeof(CustomClientAliased))]
		public class CustomClientAliasedCollectionWCFPacket : esCollectionWCFPacket<CustomClientAliasedCollection>
		{
			public static implicit operator CustomClientAliasedCollection(CustomClientAliasedCollectionWCFPacket packet)
			{
				return packet.Collection;
			}

			public static implicit operator CustomClientAliasedCollectionWCFPacket(CustomClientAliasedCollection collection)
			{
				return new CustomClientAliasedCollectionWCFPacket() { Collection = collection };
			}
		}
		
		#endregion
		
				
	}



	[Serializable]	
	public partial class CustomClientAliasedQuery : esCustomClientAliasedQuery
	{
		public CustomClientAliasedQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

		override protected string GetQueryName()
		{
			return "CustomClientAliasedQuery";
		}
		
					
	
		#region Explicit Casts
		
		public static explicit operator string(CustomClientAliasedQuery query)
		{
			return CustomClientAliasedQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator CustomClientAliasedQuery(string query)
		{
			return (CustomClientAliasedQuery)CustomClientAliasedQuery.SerializeHelper.FromXml(query, typeof(CustomClientAliasedQuery));
		}
		
		#endregion		
	}

	[DataContract]
	[Serializable]
	abstract public partial class esCustomClientAliased : esEntity
	{
		public esCustomClientAliased()
		{

		}
		
		#region LoadByPrimaryKey
		public virtual bool LoadByPrimaryKey(System.Int32 autoKey)
		{
			if(this.es.Connection.SqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(autoKey);
			else
				return LoadByPrimaryKeyStoredProcedure(autoKey);
		}

		public virtual bool LoadByPrimaryKey(esSqlAccessType sqlAccessType, System.Int32 autoKey)
		{
			if (sqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(autoKey);
			else
				return LoadByPrimaryKeyStoredProcedure(autoKey);
		}

		private bool LoadByPrimaryKeyDynamic(System.Int32 autoKey)
		{
			CustomClientAliasedQuery query = new CustomClientAliasedQuery();
			query.Where(query.AutoKey == autoKey);
			return this.Load(query);
		}

		private bool LoadByPrimaryKeyStoredProcedure(System.Int32 autoKey)
		{
			esParameters parms = new esParameters();
			parms.Add("AutoKey", autoKey);
			return this.Load(esQueryType.StoredProcedure, this.es.spLoadByPrimaryKey, parms);
		}
		#endregion
		
		#region Properties
		
		
		
		/// <summary>
		/// Maps to customclientaliased.AutoKey
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? AutoKey
		{
			get
			{
				return base.GetSystemInt32(CustomClientAliasedMetadata.ColumnNames.AutoKey);
			}
			
			set
			{
				if(base.SetSystemInt32(CustomClientAliasedMetadata.ColumnNames.AutoKey, value))
				{
					OnPropertyChanged(CustomClientAliasedMetadata.PropertyNames.AutoKey);
				}
			}
		}		
		
		/// <summary>
		/// Maps to customclientaliased.FirstName
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String FirstName
		{
			get
			{
				return base.GetSystemString(CustomClientAliasedMetadata.ColumnNames.FirstName);
			}
			
			set
			{
				if(base.SetSystemString(CustomClientAliasedMetadata.ColumnNames.FirstName, value))
				{
					OnPropertyChanged(CustomClientAliasedMetadata.PropertyNames.FirstName);
				}
			}
		}		
		
		/// <summary>
		/// Maps to customclientaliased.LastName
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String LastName
		{
			get
			{
				return base.GetSystemString(CustomClientAliasedMetadata.ColumnNames.LastName);
			}
			
			set
			{
				if(base.SetSystemString(CustomClientAliasedMetadata.ColumnNames.LastName, value))
				{
					OnPropertyChanged(CustomClientAliasedMetadata.PropertyNames.LastName);
				}
			}
		}		
		
		/// <summary>
		/// Maps to customclientaliased.Age
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? Age
		{
			get
			{
				return base.GetSystemInt32(CustomClientAliasedMetadata.ColumnNames.Age);
			}
			
			set
			{
				if(base.SetSystemInt32(CustomClientAliasedMetadata.ColumnNames.Age, value))
				{
					OnPropertyChanged(CustomClientAliasedMetadata.PropertyNames.Age);
				}
			}
		}		
		
		/// <summary>
		/// Maps to customclientaliased.DateAddedAlias
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.DateTime? DateAddedAlias
		{
			get
			{
				return base.GetSystemDateTime(CustomClientAliasedMetadata.ColumnNames.DateAddedAlias);
			}
			
			set
			{
				if(base.SetSystemDateTime(CustomClientAliasedMetadata.ColumnNames.DateAddedAlias, value))
				{
					OnPropertyChanged(CustomClientAliasedMetadata.PropertyNames.DateAddedAlias);
				}
			}
		}		
		
		/// <summary>
		/// Maps to customclientaliased.DateModified
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.DateTime? DateModified
		{
			get
			{
				return base.GetSystemDateTime(CustomClientAliasedMetadata.ColumnNames.DateModified);
			}
			
			set
			{
				if(base.SetSystemDateTime(CustomClientAliasedMetadata.ColumnNames.DateModified, value))
				{
					OnPropertyChanged(CustomClientAliasedMetadata.PropertyNames.DateModified);
				}
			}
		}		
		
		/// <summary>
		/// Maps to customclientaliased.AddedBy
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String AddedBy
		{
			get
			{
				return base.GetSystemString(CustomClientAliasedMetadata.ColumnNames.AddedBy);
			}
			
			set
			{
				if(base.SetSystemString(CustomClientAliasedMetadata.ColumnNames.AddedBy, value))
				{
					OnPropertyChanged(CustomClientAliasedMetadata.PropertyNames.AddedBy);
				}
			}
		}		
		
		/// <summary>
		/// Maps to customclientaliased.ModifiedByAlias
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String ModifiedByAlias
		{
			get
			{
				return base.GetSystemString(CustomClientAliasedMetadata.ColumnNames.ModifiedByAlias);
			}
			
			set
			{
				if(base.SetSystemString(CustomClientAliasedMetadata.ColumnNames.ModifiedByAlias, value))
				{
					OnPropertyChanged(CustomClientAliasedMetadata.PropertyNames.ModifiedByAlias);
				}
			}
		}		
		
		/// <summary>
		/// Maps to customclientaliased.EsVersion
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? EsVersion
		{
			get
			{
				return base.GetSystemInt32(CustomClientAliasedMetadata.ColumnNames.EsVersion);
			}
			
			set
			{
				if(base.SetSystemInt32(CustomClientAliasedMetadata.ColumnNames.EsVersion, value))
				{
					OnPropertyChanged(CustomClientAliasedMetadata.PropertyNames.EsVersion);
				}
			}
		}		
		
		#endregion
		
		#region Housekeeping methods

		override protected IMetadata Meta
		{
			get
			{
				return CustomClientAliasedMetadata.Meta();
			}
		}

		#endregion		
		
		#region Query Logic

		public CustomClientAliasedQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new CustomClientAliasedQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(CustomClientAliasedQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}
		
		protected void InitQuery(CustomClientAliasedQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntity)this).Connection;
			}			
		}

		#endregion
		
        [IgnoreDataMember]
		private CustomClientAliasedQuery query;		
	}



	[Serializable]
	abstract public partial class esCustomClientAliasedCollection : esEntityCollection<CustomClientAliased>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return CustomClientAliasedMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "CustomClientAliasedCollection";
		}

		#endregion		
		
		#region Query Logic

	#if (!WindowsCE)
		[BrowsableAttribute(false)]
	#endif
		public CustomClientAliasedQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new CustomClientAliasedQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(CustomClientAliasedQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new CustomClientAliasedQuery();
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(CustomClientAliasedQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntityCollection)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((CustomClientAliasedQuery)query);
		}

		#endregion
		
		private CustomClientAliasedQuery query;
	}



	[Serializable]
	abstract public partial class esCustomClientAliasedQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return CustomClientAliasedMetadata.Meta();
			}
		}	
		
		#region QueryItemFromName
		
        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
				case "AutoKey": return this.AutoKey;
				case "FirstName": return this.FirstName;
				case "LastName": return this.LastName;
				case "Age": return this.Age;
				case "DateAddedAlias": return this.DateAddedAlias;
				case "DateModified": return this.DateModified;
				case "AddedBy": return this.AddedBy;
				case "ModifiedByAlias": return this.ModifiedByAlias;
				case "EsVersion": return this.EsVersion;

                default: return null;
            }
        }		
		
		#endregion
		
		#region esQueryItems

		public esQueryItem AutoKey
		{
			get { return new esQueryItem(this, CustomClientAliasedMetadata.ColumnNames.AutoKey, esSystemType.Int32); }
		} 
		
		public esQueryItem FirstName
		{
			get { return new esQueryItem(this, CustomClientAliasedMetadata.ColumnNames.FirstName, esSystemType.String); }
		} 
		
		public esQueryItem LastName
		{
			get { return new esQueryItem(this, CustomClientAliasedMetadata.ColumnNames.LastName, esSystemType.String); }
		} 
		
		public esQueryItem Age
		{
			get { return new esQueryItem(this, CustomClientAliasedMetadata.ColumnNames.Age, esSystemType.Int32); }
		} 
		
		public esQueryItem DateAddedAlias
		{
			get { return new esQueryItem(this, CustomClientAliasedMetadata.ColumnNames.DateAddedAlias, esSystemType.DateTime); }
		} 
		
		public esQueryItem DateModified
		{
			get { return new esQueryItem(this, CustomClientAliasedMetadata.ColumnNames.DateModified, esSystemType.DateTime); }
		} 
		
		public esQueryItem AddedBy
		{
			get { return new esQueryItem(this, CustomClientAliasedMetadata.ColumnNames.AddedBy, esSystemType.String); }
		} 
		
		public esQueryItem ModifiedByAlias
		{
			get { return new esQueryItem(this, CustomClientAliasedMetadata.ColumnNames.ModifiedByAlias, esSystemType.String); }
		} 
		
		public esQueryItem EsVersion
		{
			get { return new esQueryItem(this, CustomClientAliasedMetadata.ColumnNames.EsVersion, esSystemType.Int32); }
		} 
		
		#endregion
		
	}


	
	public partial class CustomClientAliased : esCustomClientAliased
	{

		
		
	}
	



	[Serializable]
	public partial class CustomClientAliasedMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected CustomClientAliasedMetadata()
		{
			m_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(CustomClientAliasedMetadata.ColumnNames.AutoKey, 0, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = CustomClientAliasedMetadata.PropertyNames.AutoKey;
			c.IsInPrimaryKey = true;
			c.IsAutoIncrement = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(CustomClientAliasedMetadata.ColumnNames.FirstName, 1, typeof(System.String), esSystemType.String);
			c.PropertyName = CustomClientAliasedMetadata.PropertyNames.FirstName;
			c.CharacterMaxLength = 50;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(CustomClientAliasedMetadata.ColumnNames.LastName, 2, typeof(System.String), esSystemType.String);
			c.PropertyName = CustomClientAliasedMetadata.PropertyNames.LastName;
			c.CharacterMaxLength = 50;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(CustomClientAliasedMetadata.ColumnNames.Age, 3, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = CustomClientAliasedMetadata.PropertyNames.Age;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(CustomClientAliasedMetadata.ColumnNames.DateAddedAlias, 4, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = CustomClientAliasedMetadata.PropertyNames.DateAddedAlias;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(CustomClientAliasedMetadata.ColumnNames.DateModified, 5, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = CustomClientAliasedMetadata.PropertyNames.DateModified;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(CustomClientAliasedMetadata.ColumnNames.AddedBy, 6, typeof(System.String), esSystemType.String);
			c.PropertyName = CustomClientAliasedMetadata.PropertyNames.AddedBy;
			c.CharacterMaxLength = 50;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(CustomClientAliasedMetadata.ColumnNames.ModifiedByAlias, 7, typeof(System.String), esSystemType.String);
			c.PropertyName = CustomClientAliasedMetadata.PropertyNames.ModifiedByAlias;
			c.CharacterMaxLength = 50;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(CustomClientAliasedMetadata.ColumnNames.EsVersion, 8, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = CustomClientAliasedMetadata.PropertyNames.EsVersion;
			c.IsNullable = true;
			m_columns.Add(c);
				
		}
		#endregion	
	
		static public CustomClientAliasedMetadata Meta()
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
			 public const string AutoKey = "AutoKey";
			 public const string FirstName = "FirstName";
			 public const string LastName = "LastName";
			 public const string Age = "Age";
			 public const string DateAddedAlias = "DateAddedAlias";
			 public const string DateModified = "DateModified";
			 public const string AddedBy = "AddedBy";
			 public const string ModifiedByAlias = "ModifiedByAlias";
			 public const string EsVersion = "EsVersion";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string AutoKey = "AutoKey";
			 public const string FirstName = "FirstName";
			 public const string LastName = "LastName";
			 public const string Age = "Age";
			 public const string DateAddedAlias = "DateAddedAlias";
			 public const string DateModified = "DateModified";
			 public const string AddedBy = "AddedBy";
			 public const string ModifiedByAlias = "ModifiedByAlias";
			 public const string EsVersion = "EsVersion";
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
			lock (typeof(CustomClientAliasedMetadata))
			{
				if(CustomClientAliasedMetadata.mapDelegates == null)
				{
					CustomClientAliasedMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (CustomClientAliasedMetadata.meta == null)
				{
					CustomClientAliasedMetadata.meta = new CustomClientAliasedMetadata();
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


				meta.AddTypeMap("AutoKey", new esTypeMap("INT", "System.Int32"));
				meta.AddTypeMap("FirstName", new esTypeMap("VARCHAR", "System.String"));
				meta.AddTypeMap("LastName", new esTypeMap("VARCHAR", "System.String"));
				meta.AddTypeMap("Age", new esTypeMap("INT", "System.Int32"));
				meta.AddTypeMap("DateAddedAlias", new esTypeMap("DATETIME", "System.DateTime"));
				meta.AddTypeMap("DateModified", new esTypeMap("DATETIME", "System.DateTime"));
				meta.AddTypeMap("AddedBy", new esTypeMap("VARCHAR", "System.String"));
				meta.AddTypeMap("ModifiedByAlias", new esTypeMap("VARCHAR", "System.String"));
				meta.AddTypeMap("EsVersion", new esTypeMap("INT", "System.Int32"));			
				
				
				
				meta.Source = "customclientaliased";
				meta.Destination = "customclientaliased";
				
				meta.spInsert = "proc_customclientaliasedInsert";				
				meta.spUpdate = "proc_customclientaliasedUpdate";		
				meta.spDelete = "proc_customclientaliasedDelete";
				meta.spLoadAll = "proc_customclientaliasedLoadAll";
				meta.spLoadByPrimaryKey = "proc_customclientaliasedLoadByPrimaryKey";
				
				this.m_providerMetadataMaps["esDefault"] = meta;
			}
			
			return this.m_providerMetadataMaps["esDefault"];
		}

		#endregion

		static private CustomClientAliasedMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
