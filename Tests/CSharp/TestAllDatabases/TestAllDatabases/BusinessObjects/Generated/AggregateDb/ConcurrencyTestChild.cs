
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
	/// Encapsulates the 'concurrencytestchild' table
	/// </summary>

	[Serializable]
	[DataContract]
	[KnownType(typeof(ConcurrencyTestChild))]	
	[XmlType("ConcurrencyTestChild")]
	public partial class ConcurrencyTestChild : esConcurrencyTestChild
	{	
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override esEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public esEntity CreateInstance()
		{
			return new ConcurrencyTestChild();
		}
		
		#region Static Quick Access Methods
		static public void Delete(System.Int64 id)
		{
			var obj = new ConcurrencyTestChild();
			obj.Id = id;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save();
		}

	    static public void Delete(System.Int64 id, esSqlAccessType sqlAccessType)
		{
			var obj = new ConcurrencyTestChild();
			obj.Id = id;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save(sqlAccessType);
		}
		#endregion

		
					
		
	
	}



	[Serializable]
	[CollectionDataContract]
	[XmlType("ConcurrencyTestChildCollection")]
	public partial class ConcurrencyTestChildCollection : esConcurrencyTestChildCollection, IEnumerable<ConcurrencyTestChild>
	{
		public ConcurrencyTestChild FindByPrimaryKey(System.Int64 id)
		{
			return this.SingleOrDefault(e => e.Id == id);
		}

		
		
		#region WCF Service Class
		
		[DataContract]
		[KnownType(typeof(ConcurrencyTestChild))]
		public class ConcurrencyTestChildCollectionWCFPacket : esCollectionWCFPacket<ConcurrencyTestChildCollection>
		{
			public static implicit operator ConcurrencyTestChildCollection(ConcurrencyTestChildCollectionWCFPacket packet)
			{
				return packet.Collection;
			}

			public static implicit operator ConcurrencyTestChildCollectionWCFPacket(ConcurrencyTestChildCollection collection)
			{
				return new ConcurrencyTestChildCollectionWCFPacket() { Collection = collection };
			}
		}
		
		#endregion
		
				
	}



	[Serializable]	
	public partial class ConcurrencyTestChildQuery : esConcurrencyTestChildQuery
	{
		public ConcurrencyTestChildQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

		override protected string GetQueryName()
		{
			return "ConcurrencyTestChildQuery";
		}
		
					
	
		#region Explicit Casts
		
		public static explicit operator string(ConcurrencyTestChildQuery query)
		{
			return ConcurrencyTestChildQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator ConcurrencyTestChildQuery(string query)
		{
			return (ConcurrencyTestChildQuery)ConcurrencyTestChildQuery.SerializeHelper.FromXml(query, typeof(ConcurrencyTestChildQuery));
		}
		
		#endregion		
	}

	[DataContract]
	[Serializable]
	abstract public partial class esConcurrencyTestChild : esEntity
	{
		public esConcurrencyTestChild()
		{

		}
		
		#region LoadByPrimaryKey
		public virtual bool LoadByPrimaryKey(System.Int64 id)
		{
			if(this.es.Connection.SqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(id);
			else
				return LoadByPrimaryKeyStoredProcedure(id);
		}

		public virtual bool LoadByPrimaryKey(esSqlAccessType sqlAccessType, System.Int64 id)
		{
			if (sqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(id);
			else
				return LoadByPrimaryKeyStoredProcedure(id);
		}

		private bool LoadByPrimaryKeyDynamic(System.Int64 id)
		{
			ConcurrencyTestChildQuery query = new ConcurrencyTestChildQuery();
			query.Where(query.Id == id);
			return this.Load(query);
		}

		private bool LoadByPrimaryKeyStoredProcedure(System.Int64 id)
		{
			esParameters parms = new esParameters();
			parms.Add("Id", id);
			return this.Load(esQueryType.StoredProcedure, this.es.spLoadByPrimaryKey, parms);
		}
		#endregion
		
		#region Properties
		
		
		
		/// <summary>
		/// Maps to concurrencytestchild.Id
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int64? Id
		{
			get
			{
				return base.GetSystemInt64(ConcurrencyTestChildMetadata.ColumnNames.Id);
			}
			
			set
			{
				if(base.SetSystemInt64(ConcurrencyTestChildMetadata.ColumnNames.Id, value))
				{
					OnPropertyChanged(ConcurrencyTestChildMetadata.PropertyNames.Id);
				}
			}
		}		
		
		/// <summary>
		/// Maps to concurrencytestchild.Name
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Name
		{
			get
			{
				return base.GetSystemString(ConcurrencyTestChildMetadata.ColumnNames.Name);
			}
			
			set
			{
				if(base.SetSystemString(ConcurrencyTestChildMetadata.ColumnNames.Name, value))
				{
					OnPropertyChanged(ConcurrencyTestChildMetadata.PropertyNames.Name);
				}
			}
		}		
		
		/// <summary>
		/// Maps to concurrencytestchild.Parent
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int64? Parent
		{
			get
			{
				return base.GetSystemInt64(ConcurrencyTestChildMetadata.ColumnNames.Parent);
			}
			
			set
			{
				if(base.SetSystemInt64(ConcurrencyTestChildMetadata.ColumnNames.Parent, value))
				{
					OnPropertyChanged(ConcurrencyTestChildMetadata.PropertyNames.Parent);
				}
			}
		}		
		
		/// <summary>
		/// Maps to concurrencytestchild.ConcurrencyCheck
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int64? ConcurrencyCheck
		{
			get
			{
				return base.GetSystemInt64(ConcurrencyTestChildMetadata.ColumnNames.ConcurrencyCheck);
			}
			
			set
			{
				if(base.SetSystemInt64(ConcurrencyTestChildMetadata.ColumnNames.ConcurrencyCheck, value))
				{
					OnPropertyChanged(ConcurrencyTestChildMetadata.PropertyNames.ConcurrencyCheck);
				}
			}
		}		
		
		/// <summary>
		/// Maps to concurrencytestchild.DefaultTest
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.DateTime? DefaultTest
		{
			get
			{
				return base.GetSystemDateTime(ConcurrencyTestChildMetadata.ColumnNames.DefaultTest);
			}
			
			set
			{
				if(base.SetSystemDateTime(ConcurrencyTestChildMetadata.ColumnNames.DefaultTest, value))
				{
					OnPropertyChanged(ConcurrencyTestChildMetadata.PropertyNames.DefaultTest);
				}
			}
		}		
		
		/// <summary>
		/// Maps to concurrencytestchild.ColumnA
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? ColumnA
		{
			get
			{
				return base.GetSystemInt32(ConcurrencyTestChildMetadata.ColumnNames.ColumnA);
			}
			
			set
			{
				if(base.SetSystemInt32(ConcurrencyTestChildMetadata.ColumnNames.ColumnA, value))
				{
					OnPropertyChanged(ConcurrencyTestChildMetadata.PropertyNames.ColumnA);
				}
			}
		}		
		
		/// <summary>
		/// Maps to concurrencytestchild.ColumnB
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? ColumnB
		{
			get
			{
				return base.GetSystemInt32(ConcurrencyTestChildMetadata.ColumnNames.ColumnB);
			}
			
			set
			{
				if(base.SetSystemInt32(ConcurrencyTestChildMetadata.ColumnNames.ColumnB, value))
				{
					OnPropertyChanged(ConcurrencyTestChildMetadata.PropertyNames.ColumnB);
				}
			}
		}		
		
		/// <summary>
		/// Maps to concurrencytestchild.ComputedAB
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? ComputedAB
		{
			get
			{
				return base.GetSystemInt32(ConcurrencyTestChildMetadata.ColumnNames.ComputedAB);
			}
			
			set
			{
				if(base.SetSystemInt32(ConcurrencyTestChildMetadata.ColumnNames.ComputedAB, value))
				{
					OnPropertyChanged(ConcurrencyTestChildMetadata.PropertyNames.ComputedAB);
				}
			}
		}		
		
		#endregion
		
		#region Housekeeping methods

		override protected IMetadata Meta
		{
			get
			{
				return ConcurrencyTestChildMetadata.Meta();
			}
		}

		#endregion		
		
		#region Query Logic

		public ConcurrencyTestChildQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new ConcurrencyTestChildQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(ConcurrencyTestChildQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}
		
		protected void InitQuery(ConcurrencyTestChildQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntity)this).Connection;
			}			
		}

		#endregion
		
        [IgnoreDataMember]
		private ConcurrencyTestChildQuery query;		
	}



	[Serializable]
	abstract public partial class esConcurrencyTestChildCollection : esEntityCollection<ConcurrencyTestChild>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return ConcurrencyTestChildMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "ConcurrencyTestChildCollection";
		}

		#endregion		
		
		#region Query Logic

	#if (!WindowsCE)
		[BrowsableAttribute(false)]
	#endif
		public ConcurrencyTestChildQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new ConcurrencyTestChildQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(ConcurrencyTestChildQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new ConcurrencyTestChildQuery();
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(ConcurrencyTestChildQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntityCollection)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((ConcurrencyTestChildQuery)query);
		}

		#endregion
		
		private ConcurrencyTestChildQuery query;
	}



	[Serializable]
	abstract public partial class esConcurrencyTestChildQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return ConcurrencyTestChildMetadata.Meta();
			}
		}	
		
		#region QueryItemFromName
		
        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
				case "Id": return this.Id;
				case "Name": return this.Name;
				case "Parent": return this.Parent;
				case "ConcurrencyCheck": return this.ConcurrencyCheck;
				case "DefaultTest": return this.DefaultTest;
				case "ColumnA": return this.ColumnA;
				case "ColumnB": return this.ColumnB;
				case "ComputedAB": return this.ComputedAB;

                default: return null;
            }
        }		
		
		#endregion
		
		#region esQueryItems

		public esQueryItem Id
		{
			get { return new esQueryItem(this, ConcurrencyTestChildMetadata.ColumnNames.Id, esSystemType.Int64); }
		} 
		
		public esQueryItem Name
		{
			get { return new esQueryItem(this, ConcurrencyTestChildMetadata.ColumnNames.Name, esSystemType.String); }
		} 
		
		public esQueryItem Parent
		{
			get { return new esQueryItem(this, ConcurrencyTestChildMetadata.ColumnNames.Parent, esSystemType.Int64); }
		} 
		
		public esQueryItem ConcurrencyCheck
		{
			get { return new esQueryItem(this, ConcurrencyTestChildMetadata.ColumnNames.ConcurrencyCheck, esSystemType.Int64); }
		} 
		
		public esQueryItem DefaultTest
		{
			get { return new esQueryItem(this, ConcurrencyTestChildMetadata.ColumnNames.DefaultTest, esSystemType.DateTime); }
		} 
		
		public esQueryItem ColumnA
		{
			get { return new esQueryItem(this, ConcurrencyTestChildMetadata.ColumnNames.ColumnA, esSystemType.Int32); }
		} 
		
		public esQueryItem ColumnB
		{
			get { return new esQueryItem(this, ConcurrencyTestChildMetadata.ColumnNames.ColumnB, esSystemType.Int32); }
		} 
		
		public esQueryItem ComputedAB
		{
			get { return new esQueryItem(this, ConcurrencyTestChildMetadata.ColumnNames.ComputedAB, esSystemType.Int32); }
		} 
		
		#endregion
		
	}


	
	public partial class ConcurrencyTestChild : esConcurrencyTestChild
	{

		
		
	}
	



	[Serializable]
	public partial class ConcurrencyTestChildMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected ConcurrencyTestChildMetadata()
		{
			m_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(ConcurrencyTestChildMetadata.ColumnNames.Id, 0, typeof(System.Int64), esSystemType.Int64);
			c.PropertyName = ConcurrencyTestChildMetadata.PropertyNames.Id;
			c.IsInPrimaryKey = true;
			c.IsAutoIncrement = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ConcurrencyTestChildMetadata.ColumnNames.Name, 1, typeof(System.String), esSystemType.String);
			c.PropertyName = ConcurrencyTestChildMetadata.PropertyNames.Name;
			c.CharacterMaxLength = 50;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ConcurrencyTestChildMetadata.ColumnNames.Parent, 2, typeof(System.Int64), esSystemType.Int64);
			c.PropertyName = ConcurrencyTestChildMetadata.PropertyNames.Parent;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ConcurrencyTestChildMetadata.ColumnNames.ConcurrencyCheck, 3, typeof(System.Int64), esSystemType.Int64);
			c.PropertyName = ConcurrencyTestChildMetadata.PropertyNames.ConcurrencyCheck;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ConcurrencyTestChildMetadata.ColumnNames.DefaultTest, 4, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = ConcurrencyTestChildMetadata.PropertyNames.DefaultTest;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ConcurrencyTestChildMetadata.ColumnNames.ColumnA, 5, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = ConcurrencyTestChildMetadata.PropertyNames.ColumnA;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ConcurrencyTestChildMetadata.ColumnNames.ColumnB, 6, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = ConcurrencyTestChildMetadata.PropertyNames.ColumnB;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ConcurrencyTestChildMetadata.ColumnNames.ComputedAB, 7, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = ConcurrencyTestChildMetadata.PropertyNames.ComputedAB;
			c.IsNullable = true;
			m_columns.Add(c);
				
		}
		#endregion	
	
		static public ConcurrencyTestChildMetadata Meta()
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
			 public const string Parent = "Parent";
			 public const string ConcurrencyCheck = "ConcurrencyCheck";
			 public const string DefaultTest = "DefaultTest";
			 public const string ColumnA = "ColumnA";
			 public const string ColumnB = "ColumnB";
			 public const string ComputedAB = "ComputedAB";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string Id = "Id";
			 public const string Name = "Name";
			 public const string Parent = "Parent";
			 public const string ConcurrencyCheck = "ConcurrencyCheck";
			 public const string DefaultTest = "DefaultTest";
			 public const string ColumnA = "ColumnA";
			 public const string ColumnB = "ColumnB";
			 public const string ComputedAB = "ComputedAB";
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
			lock (typeof(ConcurrencyTestChildMetadata))
			{
				if(ConcurrencyTestChildMetadata.mapDelegates == null)
				{
					ConcurrencyTestChildMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (ConcurrencyTestChildMetadata.meta == null)
				{
					ConcurrencyTestChildMetadata.meta = new ConcurrencyTestChildMetadata();
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


				meta.AddTypeMap("Id", new esTypeMap("BIGINT", "System.Int64"));
				meta.AddTypeMap("Name", new esTypeMap("VARCHAR", "System.String"));
				meta.AddTypeMap("Parent", new esTypeMap("BIGINT", "System.Int64"));
				meta.AddTypeMap("ConcurrencyCheck", new esTypeMap("BIGINT", "System.Int64"));
				meta.AddTypeMap("DefaultTest", new esTypeMap("DATETIME", "System.DateTime"));
				meta.AddTypeMap("ColumnA", new esTypeMap("INT", "System.Int32"));
				meta.AddTypeMap("ColumnB", new esTypeMap("INT", "System.Int32"));
				meta.AddTypeMap("ComputedAB", new esTypeMap("INT", "System.Int32"));			
				
				
				
				meta.Source = "concurrencytestchild";
				meta.Destination = "concurrencytestchild";
				
				meta.spInsert = "proc_concurrencytestchildInsert";				
				meta.spUpdate = "proc_concurrencytestchildUpdate";		
				meta.spDelete = "proc_concurrencytestchildDelete";
				meta.spLoadAll = "proc_concurrencytestchildLoadAll";
				meta.spLoadByPrimaryKey = "proc_concurrencytestchildLoadByPrimaryKey";
				
				this.m_providerMetadataMaps["esDefault"] = meta;
			}
			
			return this.m_providerMetadataMaps["esDefault"];
		}

		#endregion

		static private ConcurrencyTestChildMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
