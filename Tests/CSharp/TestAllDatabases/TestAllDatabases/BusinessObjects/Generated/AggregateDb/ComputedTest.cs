
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
	/// Encapsulates the 'computedtest' table
	/// </summary>

	[Serializable]
	[DataContract]
	[KnownType(typeof(ComputedTest))]	
	[XmlType("ComputedTest")]
	public partial class ComputedTest : esComputedTest
	{	
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override esEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public esEntity CreateInstance()
		{
			return new ComputedTest();
		}
		
		#region Static Quick Access Methods
		static public void Delete(System.Int32 id)
		{
			var obj = new ComputedTest();
			obj.Id = id;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save();
		}

	    static public void Delete(System.Int32 id, esSqlAccessType sqlAccessType)
		{
			var obj = new ComputedTest();
			obj.Id = id;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save(sqlAccessType);
		}
		#endregion

		
					
		
	
	}



	[Serializable]
	[CollectionDataContract]
	[XmlType("ComputedTestCollection")]
	public partial class ComputedTestCollection : esComputedTestCollection, IEnumerable<ComputedTest>
	{
		public ComputedTest FindByPrimaryKey(System.Int32 id)
		{
			return this.SingleOrDefault(e => e.Id == id);
		}

		
		
		#region WCF Service Class
		
		[DataContract]
		[KnownType(typeof(ComputedTest))]
		public class ComputedTestCollectionWCFPacket : esCollectionWCFPacket<ComputedTestCollection>
		{
			public static implicit operator ComputedTestCollection(ComputedTestCollectionWCFPacket packet)
			{
				return packet.Collection;
			}

			public static implicit operator ComputedTestCollectionWCFPacket(ComputedTestCollection collection)
			{
				return new ComputedTestCollectionWCFPacket() { Collection = collection };
			}
		}
		
		#endregion
		
				
	}



	[Serializable]	
	public partial class ComputedTestQuery : esComputedTestQuery
	{
		public ComputedTestQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

		override protected string GetQueryName()
		{
			return "ComputedTestQuery";
		}
		
					
	
		#region Explicit Casts
		
		public static explicit operator string(ComputedTestQuery query)
		{
			return ComputedTestQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator ComputedTestQuery(string query)
		{
			return (ComputedTestQuery)ComputedTestQuery.SerializeHelper.FromXml(query, typeof(ComputedTestQuery));
		}
		
		#endregion		
	}

	[DataContract]
	[Serializable]
	abstract public partial class esComputedTest : esEntity
	{
		public esComputedTest()
		{

		}
		
		#region LoadByPrimaryKey
		public virtual bool LoadByPrimaryKey(System.Int32 id)
		{
			if(this.es.Connection.SqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(id);
			else
				return LoadByPrimaryKeyStoredProcedure(id);
		}

		public virtual bool LoadByPrimaryKey(esSqlAccessType sqlAccessType, System.Int32 id)
		{
			if (sqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(id);
			else
				return LoadByPrimaryKeyStoredProcedure(id);
		}

		private bool LoadByPrimaryKeyDynamic(System.Int32 id)
		{
			ComputedTestQuery query = new ComputedTestQuery();
			query.Where(query.Id == id);
			return this.Load(query);
		}

		private bool LoadByPrimaryKeyStoredProcedure(System.Int32 id)
		{
			esParameters parms = new esParameters();
			parms.Add("Id", id);
			return this.Load(esQueryType.StoredProcedure, this.es.spLoadByPrimaryKey, parms);
		}
		#endregion
		
		#region Properties
		
		
		
		/// <summary>
		/// Maps to computedtest.Id
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? Id
		{
			get
			{
				return base.GetSystemInt32(ComputedTestMetadata.ColumnNames.Id);
			}
			
			set
			{
				if(base.SetSystemInt32(ComputedTestMetadata.ColumnNames.Id, value))
				{
					OnPropertyChanged(ComputedTestMetadata.PropertyNames.Id);
				}
			}
		}		
		
		/// <summary>
		/// Maps to computedtest.ConcurrencyCheck
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.DateTime? ConcurrencyCheck
		{
			get
			{
				return base.GetSystemDateTime(ComputedTestMetadata.ColumnNames.ConcurrencyCheck);
			}
			
			set
			{
				if(base.SetSystemDateTime(ComputedTestMetadata.ColumnNames.ConcurrencyCheck, value))
				{
					OnPropertyChanged(ComputedTestMetadata.PropertyNames.ConcurrencyCheck);
				}
			}
		}		
		
		/// <summary>
		/// Maps to computedtest.DateLastUpdated
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.DateTime? DateLastUpdated
		{
			get
			{
				return base.GetSystemDateTime(ComputedTestMetadata.ColumnNames.DateLastUpdated);
			}
			
			set
			{
				if(base.SetSystemDateTime(ComputedTestMetadata.ColumnNames.DateLastUpdated, value))
				{
					OnPropertyChanged(ComputedTestMetadata.PropertyNames.DateLastUpdated);
				}
			}
		}		
		
		/// <summary>
		/// Maps to computedtest.DateAdded
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.DateTime? DateAdded
		{
			get
			{
				return base.GetSystemDateTime(ComputedTestMetadata.ColumnNames.DateAdded);
			}
			
			set
			{
				if(base.SetSystemDateTime(ComputedTestMetadata.ColumnNames.DateAdded, value))
				{
					OnPropertyChanged(ComputedTestMetadata.PropertyNames.DateAdded);
				}
			}
		}		
		
		/// <summary>
		/// Maps to computedtest.ComputedField
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? ComputedField
		{
			get
			{
				return base.GetSystemInt32(ComputedTestMetadata.ColumnNames.ComputedField);
			}
			
			set
			{
				if(base.SetSystemInt32(ComputedTestMetadata.ColumnNames.ComputedField, value))
				{
					OnPropertyChanged(ComputedTestMetadata.PropertyNames.ComputedField);
				}
			}
		}		
		
		/// <summary>
		/// Maps to computedtest.SomeDate
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.DateTime? SomeDate
		{
			get
			{
				return base.GetSystemDateTime(ComputedTestMetadata.ColumnNames.SomeDate);
			}
			
			set
			{
				if(base.SetSystemDateTime(ComputedTestMetadata.ColumnNames.SomeDate, value))
				{
					OnPropertyChanged(ComputedTestMetadata.PropertyNames.SomeDate);
				}
			}
		}		
		
		#endregion
		
		#region Housekeeping methods

		override protected IMetadata Meta
		{
			get
			{
				return ComputedTestMetadata.Meta();
			}
		}

		#endregion		
		
		#region Query Logic

		public ComputedTestQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new ComputedTestQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(ComputedTestQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}
		
		protected void InitQuery(ComputedTestQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntity)this).Connection;
			}			
		}

		#endregion
		
        [IgnoreDataMember]
		private ComputedTestQuery query;		
	}



	[Serializable]
	abstract public partial class esComputedTestCollection : esEntityCollection<ComputedTest>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return ComputedTestMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "ComputedTestCollection";
		}

		#endregion		
		
		#region Query Logic

	#if (!WindowsCE)
		[BrowsableAttribute(false)]
	#endif
		public ComputedTestQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new ComputedTestQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(ComputedTestQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new ComputedTestQuery();
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(ComputedTestQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntityCollection)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((ComputedTestQuery)query);
		}

		#endregion
		
		private ComputedTestQuery query;
	}



	[Serializable]
	abstract public partial class esComputedTestQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return ComputedTestMetadata.Meta();
			}
		}	
		
		#region QueryItemFromName
		
        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
				case "Id": return this.Id;
				case "ConcurrencyCheck": return this.ConcurrencyCheck;
				case "DateLastUpdated": return this.DateLastUpdated;
				case "DateAdded": return this.DateAdded;
				case "ComputedField": return this.ComputedField;
				case "SomeDate": return this.SomeDate;

                default: return null;
            }
        }		
		
		#endregion
		
		#region esQueryItems

		public esQueryItem Id
		{
			get { return new esQueryItem(this, ComputedTestMetadata.ColumnNames.Id, esSystemType.Int32); }
		} 
		
		public esQueryItem ConcurrencyCheck
		{
			get { return new esQueryItem(this, ComputedTestMetadata.ColumnNames.ConcurrencyCheck, esSystemType.DateTime); }
		} 
		
		public esQueryItem DateLastUpdated
		{
			get { return new esQueryItem(this, ComputedTestMetadata.ColumnNames.DateLastUpdated, esSystemType.DateTime); }
		} 
		
		public esQueryItem DateAdded
		{
			get { return new esQueryItem(this, ComputedTestMetadata.ColumnNames.DateAdded, esSystemType.DateTime); }
		} 
		
		public esQueryItem ComputedField
		{
			get { return new esQueryItem(this, ComputedTestMetadata.ColumnNames.ComputedField, esSystemType.Int32); }
		} 
		
		public esQueryItem SomeDate
		{
			get { return new esQueryItem(this, ComputedTestMetadata.ColumnNames.SomeDate, esSystemType.DateTime); }
		} 
		
		#endregion
		
	}


	
	public partial class ComputedTest : esComputedTest
	{

		
		
	}
	



	[Serializable]
	public partial class ComputedTestMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected ComputedTestMetadata()
		{
			m_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(ComputedTestMetadata.ColumnNames.Id, 0, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = ComputedTestMetadata.PropertyNames.Id;
			c.IsInPrimaryKey = true;
			c.IsAutoIncrement = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ComputedTestMetadata.ColumnNames.ConcurrencyCheck, 1, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = ComputedTestMetadata.PropertyNames.ConcurrencyCheck;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ComputedTestMetadata.ColumnNames.DateLastUpdated, 2, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = ComputedTestMetadata.PropertyNames.DateLastUpdated;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ComputedTestMetadata.ColumnNames.DateAdded, 3, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = ComputedTestMetadata.PropertyNames.DateAdded;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ComputedTestMetadata.ColumnNames.ComputedField, 4, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = ComputedTestMetadata.PropertyNames.ComputedField;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ComputedTestMetadata.ColumnNames.SomeDate, 5, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = ComputedTestMetadata.PropertyNames.SomeDate;
			c.IsNullable = true;
			m_columns.Add(c);
				
		}
		#endregion	
	
		static public ComputedTestMetadata Meta()
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
			 public const string ConcurrencyCheck = "ConcurrencyCheck";
			 public const string DateLastUpdated = "DateLastUpdated";
			 public const string DateAdded = "DateAdded";
			 public const string ComputedField = "ComputedField";
			 public const string SomeDate = "SomeDate";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string Id = "Id";
			 public const string ConcurrencyCheck = "ConcurrencyCheck";
			 public const string DateLastUpdated = "DateLastUpdated";
			 public const string DateAdded = "DateAdded";
			 public const string ComputedField = "ComputedField";
			 public const string SomeDate = "SomeDate";
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
			lock (typeof(ComputedTestMetadata))
			{
				if(ComputedTestMetadata.mapDelegates == null)
				{
					ComputedTestMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (ComputedTestMetadata.meta == null)
				{
					ComputedTestMetadata.meta = new ComputedTestMetadata();
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


				meta.AddTypeMap("Id", new esTypeMap("INT", "System.Int32"));
				meta.AddTypeMap("ConcurrencyCheck", new esTypeMap("TIMESTAMP", "System.DateTime"));
				meta.AddTypeMap("DateLastUpdated", new esTypeMap("DATETIME", "System.DateTime"));
				meta.AddTypeMap("DateAdded", new esTypeMap("DATETIME", "System.DateTime"));
				meta.AddTypeMap("ComputedField", new esTypeMap("INT", "System.Int32"));
				meta.AddTypeMap("SomeDate", new esTypeMap("DATETIME", "System.DateTime"));			
				
				
				
				meta.Source = "computedtest";
				meta.Destination = "computedtest";
				
				meta.spInsert = "proc_computedtestInsert";				
				meta.spUpdate = "proc_computedtestUpdate";		
				meta.spDelete = "proc_computedtestDelete";
				meta.spLoadAll = "proc_computedtestLoadAll";
				meta.spLoadByPrimaryKey = "proc_computedtestLoadByPrimaryKey";
				
				this.m_providerMetadataMaps["esDefault"] = meta;
			}
			
			return this.m_providerMetadataMaps["esDefault"];
		}

		#endregion

		static private ComputedTestMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
