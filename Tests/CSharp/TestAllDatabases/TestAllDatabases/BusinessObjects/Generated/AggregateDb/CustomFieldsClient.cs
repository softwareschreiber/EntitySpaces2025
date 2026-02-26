
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
	/// Encapsulates the 'customfieldsclient' table
	/// </summary>

	[Serializable]
	[DataContract]
	[KnownType(typeof(CustomFieldsClient))]	
	[XmlType("CustomFieldsClient")]
	public partial class CustomFieldsClient : esCustomFieldsClient
	{	
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override esEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public esEntity CreateInstance()
		{
			return new CustomFieldsClient();
		}
		
		#region Static Quick Access Methods
		static public void Delete(System.Int32 autoKey)
		{
			var obj = new CustomFieldsClient();
			obj.AutoKey = autoKey;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save();
		}

	    static public void Delete(System.Int32 autoKey, esSqlAccessType sqlAccessType)
		{
			var obj = new CustomFieldsClient();
			obj.AutoKey = autoKey;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save(sqlAccessType);
		}
		#endregion

		
					
		
	
	}



	[Serializable]
	[CollectionDataContract]
	[XmlType("CustomFieldsClientCollection")]
	public partial class CustomFieldsClientCollection : esCustomFieldsClientCollection, IEnumerable<CustomFieldsClient>
	{
		public CustomFieldsClient FindByPrimaryKey(System.Int32 autoKey)
		{
			return this.SingleOrDefault(e => e.AutoKey == autoKey);
		}

		
		
		#region WCF Service Class
		
		[DataContract]
		[KnownType(typeof(CustomFieldsClient))]
		public class CustomFieldsClientCollectionWCFPacket : esCollectionWCFPacket<CustomFieldsClientCollection>
		{
			public static implicit operator CustomFieldsClientCollection(CustomFieldsClientCollectionWCFPacket packet)
			{
				return packet.Collection;
			}

			public static implicit operator CustomFieldsClientCollectionWCFPacket(CustomFieldsClientCollection collection)
			{
				return new CustomFieldsClientCollectionWCFPacket() { Collection = collection };
			}
		}
		
		#endregion
		
				
	}



	[Serializable]	
	public partial class CustomFieldsClientQuery : esCustomFieldsClientQuery
	{
		public CustomFieldsClientQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

		override protected string GetQueryName()
		{
			return "CustomFieldsClientQuery";
		}
		
					
	
		#region Explicit Casts
		
		public static explicit operator string(CustomFieldsClientQuery query)
		{
			return CustomFieldsClientQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator CustomFieldsClientQuery(string query)
		{
			return (CustomFieldsClientQuery)CustomFieldsClientQuery.SerializeHelper.FromXml(query, typeof(CustomFieldsClientQuery));
		}
		
		#endregion		
	}

	[DataContract]
	[Serializable]
	abstract public partial class esCustomFieldsClient : esEntity
	{
		public esCustomFieldsClient()
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
			CustomFieldsClientQuery query = new CustomFieldsClientQuery();
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
		/// Maps to customfieldsclient.AutoKey
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? AutoKey
		{
			get
			{
				return base.GetSystemInt32(CustomFieldsClientMetadata.ColumnNames.AutoKey);
			}
			
			set
			{
				if(base.SetSystemInt32(CustomFieldsClientMetadata.ColumnNames.AutoKey, value))
				{
					OnPropertyChanged(CustomFieldsClientMetadata.PropertyNames.AutoKey);
				}
			}
		}		
		
		/// <summary>
		/// Maps to customfieldsclient.FirstName
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String FirstName
		{
			get
			{
				return base.GetSystemString(CustomFieldsClientMetadata.ColumnNames.FirstName);
			}
			
			set
			{
				if(base.SetSystemString(CustomFieldsClientMetadata.ColumnNames.FirstName, value))
				{
					OnPropertyChanged(CustomFieldsClientMetadata.PropertyNames.FirstName);
				}
			}
		}		
		
		/// <summary>
		/// Maps to customfieldsclient.LastName
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String LastName
		{
			get
			{
				return base.GetSystemString(CustomFieldsClientMetadata.ColumnNames.LastName);
			}
			
			set
			{
				if(base.SetSystemString(CustomFieldsClientMetadata.ColumnNames.LastName, value))
				{
					OnPropertyChanged(CustomFieldsClientMetadata.PropertyNames.LastName);
				}
			}
		}		
		
		/// <summary>
		/// Maps to customfieldsclient.Age
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? Age
		{
			get
			{
				return base.GetSystemInt32(CustomFieldsClientMetadata.ColumnNames.Age);
			}
			
			set
			{
				if(base.SetSystemInt32(CustomFieldsClientMetadata.ColumnNames.Age, value))
				{
					OnPropertyChanged(CustomFieldsClientMetadata.PropertyNames.Age);
				}
			}
		}		
		
		/// <summary>
		/// Maps to customfieldsclient.DateAdded
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.DateTime? DateAdded
		{
			get
			{
				return base.GetSystemDateTime(CustomFieldsClientMetadata.ColumnNames.DateAdded);
			}
			
			set
			{
				if(base.SetSystemDateTime(CustomFieldsClientMetadata.ColumnNames.DateAdded, value))
				{
					OnPropertyChanged(CustomFieldsClientMetadata.PropertyNames.DateAdded);
				}
			}
		}		
		
		/// <summary>
		/// Maps to customfieldsclient.DateModified
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.DateTime? DateModified
		{
			get
			{
				return base.GetSystemDateTime(CustomFieldsClientMetadata.ColumnNames.DateModified);
			}
			
			set
			{
				if(base.SetSystemDateTime(CustomFieldsClientMetadata.ColumnNames.DateModified, value))
				{
					OnPropertyChanged(CustomFieldsClientMetadata.PropertyNames.DateModified);
				}
			}
		}		
		
		/// <summary>
		/// Maps to customfieldsclient.AddedBy
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String AddedBy
		{
			get
			{
				return base.GetSystemString(CustomFieldsClientMetadata.ColumnNames.AddedBy);
			}
			
			set
			{
				if(base.SetSystemString(CustomFieldsClientMetadata.ColumnNames.AddedBy, value))
				{
					OnPropertyChanged(CustomFieldsClientMetadata.PropertyNames.AddedBy);
				}
			}
		}		
		
		/// <summary>
		/// Maps to customfieldsclient.ModifiedBy
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String ModifiedBy
		{
			get
			{
				return base.GetSystemString(CustomFieldsClientMetadata.ColumnNames.ModifiedBy);
			}
			
			set
			{
				if(base.SetSystemString(CustomFieldsClientMetadata.ColumnNames.ModifiedBy, value))
				{
					OnPropertyChanged(CustomFieldsClientMetadata.PropertyNames.ModifiedBy);
				}
			}
		}		
		
		/// <summary>
		/// Maps to customfieldsclient.EsVersion
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? EsVersion
		{
			get
			{
				return base.GetSystemInt32(CustomFieldsClientMetadata.ColumnNames.EsVersion);
			}
			
			set
			{
				if(base.SetSystemInt32(CustomFieldsClientMetadata.ColumnNames.EsVersion, value))
				{
					OnPropertyChanged(CustomFieldsClientMetadata.PropertyNames.EsVersion);
				}
			}
		}		
		
		#endregion
		
		#region Housekeeping methods

		override protected IMetadata Meta
		{
			get
			{
				return CustomFieldsClientMetadata.Meta();
			}
		}

		#endregion		
		
		#region Query Logic

		public CustomFieldsClientQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new CustomFieldsClientQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(CustomFieldsClientQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}
		
		protected void InitQuery(CustomFieldsClientQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntity)this).Connection;
			}			
		}

		#endregion
		
        [IgnoreDataMember]
		private CustomFieldsClientQuery query;		
	}



	[Serializable]
	abstract public partial class esCustomFieldsClientCollection : esEntityCollection<CustomFieldsClient>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return CustomFieldsClientMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "CustomFieldsClientCollection";
		}

		#endregion		
		
		#region Query Logic

	#if (!WindowsCE)
		[BrowsableAttribute(false)]
	#endif
		public CustomFieldsClientQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new CustomFieldsClientQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(CustomFieldsClientQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new CustomFieldsClientQuery();
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(CustomFieldsClientQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntityCollection)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((CustomFieldsClientQuery)query);
		}

		#endregion
		
		private CustomFieldsClientQuery query;
	}



	[Serializable]
	abstract public partial class esCustomFieldsClientQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return CustomFieldsClientMetadata.Meta();
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
				case "DateModified": return this.DateModified;
				case "AddedBy": return this.AddedBy;
				case "ModifiedBy": return this.ModifiedBy;
				case "EsVersion": return this.EsVersion;

                default: return null;
            }
        }		
		
		#endregion
		
		#region esQueryItems

		public esQueryItem AutoKey
		{
			get { return new esQueryItem(this, CustomFieldsClientMetadata.ColumnNames.AutoKey, esSystemType.Int32); }
		} 
		
		public esQueryItem FirstName
		{
			get { return new esQueryItem(this, CustomFieldsClientMetadata.ColumnNames.FirstName, esSystemType.String); }
		} 
		
		public esQueryItem LastName
		{
			get { return new esQueryItem(this, CustomFieldsClientMetadata.ColumnNames.LastName, esSystemType.String); }
		} 
		
		public esQueryItem Age
		{
			get { return new esQueryItem(this, CustomFieldsClientMetadata.ColumnNames.Age, esSystemType.Int32); }
		} 
		
		public esQueryItem DateAdded
		{
			get { return new esQueryItem(this, CustomFieldsClientMetadata.ColumnNames.DateAdded, esSystemType.DateTime); }
		} 
		
		public esQueryItem DateModified
		{
			get { return new esQueryItem(this, CustomFieldsClientMetadata.ColumnNames.DateModified, esSystemType.DateTime); }
		} 
		
		public esQueryItem AddedBy
		{
			get { return new esQueryItem(this, CustomFieldsClientMetadata.ColumnNames.AddedBy, esSystemType.String); }
		} 
		
		public esQueryItem ModifiedBy
		{
			get { return new esQueryItem(this, CustomFieldsClientMetadata.ColumnNames.ModifiedBy, esSystemType.String); }
		} 
		
		public esQueryItem EsVersion
		{
			get { return new esQueryItem(this, CustomFieldsClientMetadata.ColumnNames.EsVersion, esSystemType.Int32); }
		} 
		
		#endregion
		
	}


	
	public partial class CustomFieldsClient : esCustomFieldsClient
	{

		
		
	}
	



	[Serializable]
	public partial class CustomFieldsClientMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected CustomFieldsClientMetadata()
		{
			m_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(CustomFieldsClientMetadata.ColumnNames.AutoKey, 0, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = CustomFieldsClientMetadata.PropertyNames.AutoKey;
			c.IsInPrimaryKey = true;
			c.IsAutoIncrement = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(CustomFieldsClientMetadata.ColumnNames.FirstName, 1, typeof(System.String), esSystemType.String);
			c.PropertyName = CustomFieldsClientMetadata.PropertyNames.FirstName;
			c.CharacterMaxLength = 50;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(CustomFieldsClientMetadata.ColumnNames.LastName, 2, typeof(System.String), esSystemType.String);
			c.PropertyName = CustomFieldsClientMetadata.PropertyNames.LastName;
			c.CharacterMaxLength = 50;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(CustomFieldsClientMetadata.ColumnNames.Age, 3, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = CustomFieldsClientMetadata.PropertyNames.Age;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(CustomFieldsClientMetadata.ColumnNames.DateAdded, 4, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = CustomFieldsClientMetadata.PropertyNames.DateAdded;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(CustomFieldsClientMetadata.ColumnNames.DateModified, 5, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = CustomFieldsClientMetadata.PropertyNames.DateModified;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(CustomFieldsClientMetadata.ColumnNames.AddedBy, 6, typeof(System.String), esSystemType.String);
			c.PropertyName = CustomFieldsClientMetadata.PropertyNames.AddedBy;
			c.CharacterMaxLength = 50;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(CustomFieldsClientMetadata.ColumnNames.ModifiedBy, 7, typeof(System.String), esSystemType.String);
			c.PropertyName = CustomFieldsClientMetadata.PropertyNames.ModifiedBy;
			c.CharacterMaxLength = 50;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(CustomFieldsClientMetadata.ColumnNames.EsVersion, 8, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = CustomFieldsClientMetadata.PropertyNames.EsVersion;
			c.IsNullable = true;
			m_columns.Add(c);
				
		}
		#endregion	
	
		static public CustomFieldsClientMetadata Meta()
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
			 public const string DateModified = "DateModified";
			 public const string AddedBy = "AddedBy";
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
			 public const string DateModified = "DateModified";
			 public const string AddedBy = "AddedBy";
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
			lock (typeof(CustomFieldsClientMetadata))
			{
				if(CustomFieldsClientMetadata.mapDelegates == null)
				{
					CustomFieldsClientMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (CustomFieldsClientMetadata.meta == null)
				{
					CustomFieldsClientMetadata.meta = new CustomFieldsClientMetadata();
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
				meta.AddTypeMap("DateModified", new esTypeMap("DATETIME", "System.DateTime"));
				meta.AddTypeMap("AddedBy", new esTypeMap("VARCHAR", "System.String"));
				meta.AddTypeMap("ModifiedBy", new esTypeMap("VARCHAR", "System.String"));
				meta.AddTypeMap("EsVersion", new esTypeMap("INT", "System.Int32"));			
				
				
				
				meta.Source = "customfieldsclient";
				meta.Destination = "customfieldsclient";
				
				meta.spInsert = "proc_customfieldsclientInsert";				
				meta.spUpdate = "proc_customfieldsclientUpdate";		
				meta.spDelete = "proc_customfieldsclientDelete";
				meta.spLoadAll = "proc_customfieldsclientLoadAll";
				meta.spLoadByPrimaryKey = "proc_customfieldsclientLoadByPrimaryKey";
				
				this.m_providerMetadataMaps["esDefault"] = meta;
			}
			
			return this.m_providerMetadataMaps["esDefault"];
		}

		#endregion

		static private CustomFieldsClientMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
