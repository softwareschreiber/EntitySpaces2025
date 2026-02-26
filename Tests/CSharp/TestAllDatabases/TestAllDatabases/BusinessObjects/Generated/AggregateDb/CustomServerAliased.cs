
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
	/// Encapsulates the 'customserveraliased' table
	/// </summary>

	[Serializable]
	[DataContract]
	[KnownType(typeof(CustomServerAliased))]	
	[XmlType("CustomServerAliased")]
	public partial class CustomServerAliased : esCustomServerAliased
	{	
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override esEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public esEntity CreateInstance()
		{
			return new CustomServerAliased();
		}
		
		#region Static Quick Access Methods
		static public void Delete(System.Int32 autoKey)
		{
			var obj = new CustomServerAliased();
			obj.AutoKey = autoKey;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save();
		}

	    static public void Delete(System.Int32 autoKey, esSqlAccessType sqlAccessType)
		{
			var obj = new CustomServerAliased();
			obj.AutoKey = autoKey;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save(sqlAccessType);
		}
		#endregion

		
					
		
	
	}



	[Serializable]
	[CollectionDataContract]
	[XmlType("CustomServerAliasedCollection")]
	public partial class CustomServerAliasedCollection : esCustomServerAliasedCollection, IEnumerable<CustomServerAliased>
	{
		public CustomServerAliased FindByPrimaryKey(System.Int32 autoKey)
		{
			return this.SingleOrDefault(e => e.AutoKey == autoKey);
		}

		
		
		#region WCF Service Class
		
		[DataContract]
		[KnownType(typeof(CustomServerAliased))]
		public class CustomServerAliasedCollectionWCFPacket : esCollectionWCFPacket<CustomServerAliasedCollection>
		{
			public static implicit operator CustomServerAliasedCollection(CustomServerAliasedCollectionWCFPacket packet)
			{
				return packet.Collection;
			}

			public static implicit operator CustomServerAliasedCollectionWCFPacket(CustomServerAliasedCollection collection)
			{
				return new CustomServerAliasedCollectionWCFPacket() { Collection = collection };
			}
		}
		
		#endregion
		
				
	}



	[Serializable]	
	public partial class CustomServerAliasedQuery : esCustomServerAliasedQuery
	{
		public CustomServerAliasedQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

		override protected string GetQueryName()
		{
			return "CustomServerAliasedQuery";
		}
		
					
	
		#region Explicit Casts
		
		public static explicit operator string(CustomServerAliasedQuery query)
		{
			return CustomServerAliasedQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator CustomServerAliasedQuery(string query)
		{
			return (CustomServerAliasedQuery)CustomServerAliasedQuery.SerializeHelper.FromXml(query, typeof(CustomServerAliasedQuery));
		}
		
		#endregion		
	}

	[DataContract]
	[Serializable]
	abstract public partial class esCustomServerAliased : esEntity
	{
		public esCustomServerAliased()
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
			CustomServerAliasedQuery query = new CustomServerAliasedQuery();
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
		/// Maps to customserveraliased.AutoKey
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? AutoKey
		{
			get
			{
				return base.GetSystemInt32(CustomServerAliasedMetadata.ColumnNames.AutoKey);
			}
			
			set
			{
				if(base.SetSystemInt32(CustomServerAliasedMetadata.ColumnNames.AutoKey, value))
				{
					OnPropertyChanged(CustomServerAliasedMetadata.PropertyNames.AutoKey);
				}
			}
		}		
		
		/// <summary>
		/// Maps to customserveraliased.FirstName
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String FirstName
		{
			get
			{
				return base.GetSystemString(CustomServerAliasedMetadata.ColumnNames.FirstName);
			}
			
			set
			{
				if(base.SetSystemString(CustomServerAliasedMetadata.ColumnNames.FirstName, value))
				{
					OnPropertyChanged(CustomServerAliasedMetadata.PropertyNames.FirstName);
				}
			}
		}		
		
		/// <summary>
		/// Maps to customserveraliased.LastName
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String LastName
		{
			get
			{
				return base.GetSystemString(CustomServerAliasedMetadata.ColumnNames.LastName);
			}
			
			set
			{
				if(base.SetSystemString(CustomServerAliasedMetadata.ColumnNames.LastName, value))
				{
					OnPropertyChanged(CustomServerAliasedMetadata.PropertyNames.LastName);
				}
			}
		}		
		
		/// <summary>
		/// Maps to customserveraliased.Age
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? Age
		{
			get
			{
				return base.GetSystemInt32(CustomServerAliasedMetadata.ColumnNames.Age);
			}
			
			set
			{
				if(base.SetSystemInt32(CustomServerAliasedMetadata.ColumnNames.Age, value))
				{
					OnPropertyChanged(CustomServerAliasedMetadata.PropertyNames.Age);
				}
			}
		}		
		
		/// <summary>
		/// Maps to customserveraliased.DateAdded
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.DateTime? DateAdded
		{
			get
			{
				return base.GetSystemDateTime(CustomServerAliasedMetadata.ColumnNames.DateAdded);
			}
			
			set
			{
				if(base.SetSystemDateTime(CustomServerAliasedMetadata.ColumnNames.DateAdded, value))
				{
					OnPropertyChanged(CustomServerAliasedMetadata.PropertyNames.DateAdded);
				}
			}
		}		
		
		/// <summary>
		/// Maps to customserveraliased.DateModifiedAlias
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.DateTime? DateModifiedAlias
		{
			get
			{
				return base.GetSystemDateTime(CustomServerAliasedMetadata.ColumnNames.DateModifiedAlias);
			}
			
			set
			{
				if(base.SetSystemDateTime(CustomServerAliasedMetadata.ColumnNames.DateModifiedAlias, value))
				{
					OnPropertyChanged(CustomServerAliasedMetadata.PropertyNames.DateModifiedAlias);
				}
			}
		}		
		
		/// <summary>
		/// Maps to customserveraliased.AddedByAlias
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String AddedByAlias
		{
			get
			{
				return base.GetSystemString(CustomServerAliasedMetadata.ColumnNames.AddedByAlias);
			}
			
			set
			{
				if(base.SetSystemString(CustomServerAliasedMetadata.ColumnNames.AddedByAlias, value))
				{
					OnPropertyChanged(CustomServerAliasedMetadata.PropertyNames.AddedByAlias);
				}
			}
		}		
		
		/// <summary>
		/// Maps to customserveraliased.ModifiedBy
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String ModifiedBy
		{
			get
			{
				return base.GetSystemString(CustomServerAliasedMetadata.ColumnNames.ModifiedBy);
			}
			
			set
			{
				if(base.SetSystemString(CustomServerAliasedMetadata.ColumnNames.ModifiedBy, value))
				{
					OnPropertyChanged(CustomServerAliasedMetadata.PropertyNames.ModifiedBy);
				}
			}
		}		
		
		/// <summary>
		/// Maps to customserveraliased.EsVersion
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? EsVersion
		{
			get
			{
				return base.GetSystemInt32(CustomServerAliasedMetadata.ColumnNames.EsVersion);
			}
			
			set
			{
				if(base.SetSystemInt32(CustomServerAliasedMetadata.ColumnNames.EsVersion, value))
				{
					OnPropertyChanged(CustomServerAliasedMetadata.PropertyNames.EsVersion);
				}
			}
		}		
		
		#endregion
		
		#region Housekeeping methods

		override protected IMetadata Meta
		{
			get
			{
				return CustomServerAliasedMetadata.Meta();
			}
		}

		#endregion		
		
		#region Query Logic

		public CustomServerAliasedQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new CustomServerAliasedQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(CustomServerAliasedQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}
		
		protected void InitQuery(CustomServerAliasedQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntity)this).Connection;
			}			
		}

		#endregion
		
        [IgnoreDataMember]
		private CustomServerAliasedQuery query;		
	}



	[Serializable]
	abstract public partial class esCustomServerAliasedCollection : esEntityCollection<CustomServerAliased>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return CustomServerAliasedMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "CustomServerAliasedCollection";
		}

		#endregion		
		
		#region Query Logic

	#if (!WindowsCE)
		[BrowsableAttribute(false)]
	#endif
		public CustomServerAliasedQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new CustomServerAliasedQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(CustomServerAliasedQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new CustomServerAliasedQuery();
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(CustomServerAliasedQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntityCollection)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((CustomServerAliasedQuery)query);
		}

		#endregion
		
		private CustomServerAliasedQuery query;
	}



	[Serializable]
	abstract public partial class esCustomServerAliasedQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return CustomServerAliasedMetadata.Meta();
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
				case "DateAdded": return this.DateAdded;
				case "DateModifiedAlias": return this.DateModifiedAlias;
				case "AddedByAlias": return this.AddedByAlias;
				case "ModifiedBy": return this.ModifiedBy;
				case "EsVersion": return this.EsVersion;

                default: return null;
            }
        }		
		
		#endregion
		
		#region esQueryItems

		public esQueryItem AutoKey
		{
			get { return new esQueryItem(this, CustomServerAliasedMetadata.ColumnNames.AutoKey, esSystemType.Int32); }
		} 
		
		public esQueryItem FirstName
		{
			get { return new esQueryItem(this, CustomServerAliasedMetadata.ColumnNames.FirstName, esSystemType.String); }
		} 
		
		public esQueryItem LastName
		{
			get { return new esQueryItem(this, CustomServerAliasedMetadata.ColumnNames.LastName, esSystemType.String); }
		} 
		
		public esQueryItem Age
		{
			get { return new esQueryItem(this, CustomServerAliasedMetadata.ColumnNames.Age, esSystemType.Int32); }
		} 
		
		public esQueryItem DateAdded
		{
			get { return new esQueryItem(this, CustomServerAliasedMetadata.ColumnNames.DateAdded, esSystemType.DateTime); }
		} 
		
		public esQueryItem DateModifiedAlias
		{
			get { return new esQueryItem(this, CustomServerAliasedMetadata.ColumnNames.DateModifiedAlias, esSystemType.DateTime); }
		} 
		
		public esQueryItem AddedByAlias
		{
			get { return new esQueryItem(this, CustomServerAliasedMetadata.ColumnNames.AddedByAlias, esSystemType.String); }
		} 
		
		public esQueryItem ModifiedBy
		{
			get { return new esQueryItem(this, CustomServerAliasedMetadata.ColumnNames.ModifiedBy, esSystemType.String); }
		} 
		
		public esQueryItem EsVersion
		{
			get { return new esQueryItem(this, CustomServerAliasedMetadata.ColumnNames.EsVersion, esSystemType.Int32); }
		} 
		
		#endregion
		
	}


	
	public partial class CustomServerAliased : esCustomServerAliased
	{

		
		
	}
	



	[Serializable]
	public partial class CustomServerAliasedMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected CustomServerAliasedMetadata()
		{
			m_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(CustomServerAliasedMetadata.ColumnNames.AutoKey, 0, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = CustomServerAliasedMetadata.PropertyNames.AutoKey;
			c.IsInPrimaryKey = true;
			c.IsAutoIncrement = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(CustomServerAliasedMetadata.ColumnNames.FirstName, 1, typeof(System.String), esSystemType.String);
			c.PropertyName = CustomServerAliasedMetadata.PropertyNames.FirstName;
			c.CharacterMaxLength = 50;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(CustomServerAliasedMetadata.ColumnNames.LastName, 2, typeof(System.String), esSystemType.String);
			c.PropertyName = CustomServerAliasedMetadata.PropertyNames.LastName;
			c.CharacterMaxLength = 50;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(CustomServerAliasedMetadata.ColumnNames.Age, 3, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = CustomServerAliasedMetadata.PropertyNames.Age;
			c.HasDefault = true;
			c.Default = @"30";
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(CustomServerAliasedMetadata.ColumnNames.DateAdded, 4, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = CustomServerAliasedMetadata.PropertyNames.DateAdded;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(CustomServerAliasedMetadata.ColumnNames.DateModifiedAlias, 5, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = CustomServerAliasedMetadata.PropertyNames.DateModifiedAlias;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(CustomServerAliasedMetadata.ColumnNames.AddedByAlias, 6, typeof(System.String), esSystemType.String);
			c.PropertyName = CustomServerAliasedMetadata.PropertyNames.AddedByAlias;
			c.CharacterMaxLength = 50;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(CustomServerAliasedMetadata.ColumnNames.ModifiedBy, 7, typeof(System.String), esSystemType.String);
			c.PropertyName = CustomServerAliasedMetadata.PropertyNames.ModifiedBy;
			c.CharacterMaxLength = 50;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(CustomServerAliasedMetadata.ColumnNames.EsVersion, 8, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = CustomServerAliasedMetadata.PropertyNames.EsVersion;
			c.IsNullable = true;
			m_columns.Add(c);
				
		}
		#endregion	
	
		static public CustomServerAliasedMetadata Meta()
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
			 public const string DateAdded = "DateAdded";
			 public const string DateModifiedAlias = "DateModifiedAlias";
			 public const string AddedByAlias = "AddedByAlias";
			 public const string ModifiedBy = "ModifiedBy";
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
			 public const string DateAdded = "DateAdded";
			 public const string DateModifiedAlias = "DateModifiedAlias";
			 public const string AddedByAlias = "AddedByAlias";
			 public const string ModifiedBy = "ModifiedBy";
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
			lock (typeof(CustomServerAliasedMetadata))
			{
				if(CustomServerAliasedMetadata.mapDelegates == null)
				{
					CustomServerAliasedMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (CustomServerAliasedMetadata.meta == null)
				{
					CustomServerAliasedMetadata.meta = new CustomServerAliasedMetadata();
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
				meta.AddTypeMap("DateAdded", new esTypeMap("DATETIME", "System.DateTime"));
				meta.AddTypeMap("DateModifiedAlias", new esTypeMap("DATETIME", "System.DateTime"));
				meta.AddTypeMap("AddedByAlias", new esTypeMap("VARCHAR", "System.String"));
				meta.AddTypeMap("ModifiedBy", new esTypeMap("VARCHAR", "System.String"));
				meta.AddTypeMap("EsVersion", new esTypeMap("INT", "System.Int32"));			
				
				
				
				meta.Source = "customserveraliased";
				meta.Destination = "customserveraliased";
				
				meta.spInsert = "proc_customserveraliasedInsert";				
				meta.spUpdate = "proc_customserveraliasedUpdate";		
				meta.spDelete = "proc_customserveraliasedDelete";
				meta.spLoadAll = "proc_customserveraliasedLoadAll";
				meta.spLoadByPrimaryKey = "proc_customserveraliasedLoadByPrimaryKey";
				
				this.m_providerMetadataMaps["esDefault"] = meta;
			}
			
			return this.m_providerMetadataMaps["esDefault"];
		}

		#endregion

		static private CustomServerAliasedMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
