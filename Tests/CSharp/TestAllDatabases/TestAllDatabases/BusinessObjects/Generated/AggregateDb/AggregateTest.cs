
/*
===============================================================================
                    EntitySpaces Studio by EntitySpaces, LLC
             Persistence Layer and Business Objects for Microsoft .NET
             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
                          http://www.entityspaces.net
===============================================================================
EntitySpaces Version : 2024.3.0001.1
EntitySpaces Driver  : MySql
Date Generated       : 04.12.2025 12:35:55
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
	/// Encapsulates the 'aggregatetest' table
	/// </summary>

	[Serializable]
	[DataContract]
	[KnownType(typeof(Aggregatetest))]	
	[XmlType("Aggregatetest")]
	public partial class Aggregatetest : esAggregatetest
	{	
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override esEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public esEntity CreateInstance()
		{
			return new Aggregatetest();
		}
		
		#region Static Quick Access Methods
		static public void Delete(System.Int32 id)
		{
			var obj = new Aggregatetest();
			obj.Id = id;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save();
		}

	    static public void Delete(System.Int32 id, esSqlAccessType sqlAccessType)
		{
			var obj = new Aggregatetest();
			obj.Id = id;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save(sqlAccessType);
		}
		#endregion

		
					
		
	
	}



	[Serializable]
	[CollectionDataContract]
	[XmlType("AggregatetestCollection")]
	public partial class AggregatetestCollection : esAggregatetestCollection, IEnumerable<Aggregatetest>
	{
		public Aggregatetest FindByPrimaryKey(System.Int32 id)
		{
			return this.SingleOrDefault(e => e.Id == id);
		}

		
		
		#region WCF Service Class
		
		[DataContract]
		[KnownType(typeof(Aggregatetest))]
		public class AggregatetestCollectionWCFPacket : esCollectionWCFPacket<AggregatetestCollection>
		{
			public static implicit operator AggregatetestCollection(AggregatetestCollectionWCFPacket packet)
			{
				return packet.Collection;
			}

			public static implicit operator AggregatetestCollectionWCFPacket(AggregatetestCollection collection)
			{
				return new AggregatetestCollectionWCFPacket() { Collection = collection };
			}
		}
		
		#endregion
		
				
	}



	[Serializable]	
	public partial class AggregatetestQuery : esAggregatetestQuery
	{
		public AggregatetestQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

		override protected string GetQueryName()
		{
			return "AggregatetestQuery";
		}
		
					
	
		#region Explicit Casts
		
		public static explicit operator string(AggregatetestQuery query)
		{
			return AggregatetestQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator AggregatetestQuery(string query)
		{
			return (AggregatetestQuery)AggregatetestQuery.SerializeHelper.FromXml(query, typeof(AggregatetestQuery));
		}
		
		#endregion		
	}

	[DataContract]
	[Serializable]
	abstract public partial class esAggregatetest : esEntity
	{
		public esAggregatetest()
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
			AggregatetestQuery query = new AggregatetestQuery();
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
		/// Maps to aggregatetest.Id
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? Id
		{
			get
			{
				return base.GetSystemInt32(AggregatetestMetadata.ColumnNames.Id);
			}
			
			set
			{
				if(base.SetSystemInt32(AggregatetestMetadata.ColumnNames.Id, value))
				{
					OnPropertyChanged(AggregatetestMetadata.PropertyNames.Id);
				}
			}
		}		
		
		/// <summary>
		/// Maps to aggregatetest.DepartmentID
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? DepartmentID
		{
			get
			{
				return base.GetSystemInt32(AggregatetestMetadata.ColumnNames.DepartmentID);
			}
			
			set
			{
				if(base.SetSystemInt32(AggregatetestMetadata.ColumnNames.DepartmentID, value))
				{
					OnPropertyChanged(AggregatetestMetadata.PropertyNames.DepartmentID);
				}
			}
		}		
		
		/// <summary>
		/// Maps to aggregatetest.FirstName
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String FirstName
		{
			get
			{
				return base.GetSystemString(AggregatetestMetadata.ColumnNames.FirstName);
			}
			
			set
			{
				if(base.SetSystemString(AggregatetestMetadata.ColumnNames.FirstName, value))
				{
					OnPropertyChanged(AggregatetestMetadata.PropertyNames.FirstName);
				}
			}
		}		
		
		/// <summary>
		/// Maps to aggregatetest.LastName
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String LastName
		{
			get
			{
				return base.GetSystemString(AggregatetestMetadata.ColumnNames.LastName);
			}
			
			set
			{
				if(base.SetSystemString(AggregatetestMetadata.ColumnNames.LastName, value))
				{
					OnPropertyChanged(AggregatetestMetadata.PropertyNames.LastName);
				}
			}
		}		
		
		/// <summary>
		/// Maps to aggregatetest.Age
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? Age
		{
			get
			{
				return base.GetSystemInt32(AggregatetestMetadata.ColumnNames.Age);
			}
			
			set
			{
				if(base.SetSystemInt32(AggregatetestMetadata.ColumnNames.Age, value))
				{
					OnPropertyChanged(AggregatetestMetadata.PropertyNames.Age);
				}
			}
		}		
		
		/// <summary>
		/// Maps to aggregatetest.HireDate
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.DateTime? HireDate
		{
			get
			{
				return base.GetSystemDateTime(AggregatetestMetadata.ColumnNames.HireDate);
			}
			
			set
			{
				if(base.SetSystemDateTime(AggregatetestMetadata.ColumnNames.HireDate, value))
				{
					OnPropertyChanged(AggregatetestMetadata.PropertyNames.HireDate);
				}
			}
		}		
		
		/// <summary>
		/// Maps to aggregatetest.Salary
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Decimal? Salary
		{
			get
			{
				return base.GetSystemDecimal(AggregatetestMetadata.ColumnNames.Salary);
			}
			
			set
			{
				if(base.SetSystemDecimal(AggregatetestMetadata.ColumnNames.Salary, value))
				{
					OnPropertyChanged(AggregatetestMetadata.PropertyNames.Salary);
				}
			}
		}		
		
		/// <summary>
		/// Maps to aggregatetest.IsActive
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.SByte? IsActive
		{
			get
			{
				return base.GetSystemSByte(AggregatetestMetadata.ColumnNames.IsActive);
			}
			
			set
			{
				if(base.SetSystemSByte(AggregatetestMetadata.ColumnNames.IsActive, value))
				{
					OnPropertyChanged(AggregatetestMetadata.PropertyNames.IsActive);
				}
			}
		}		
		
		#endregion	

		#region .str() Properties
		
		public override void SetProperties(IDictionary values)
		{
			foreach (string propertyName in values.Keys)
			{
				this.SetProperty(propertyName, values[propertyName]);
			}
		}
		
		public override void SetProperty(string name, object value)
		{
			esColumnMetadata col = this.Meta.Columns.FindByPropertyName(name);
			if (col != null)
			{
				if(value == null || value is System.String)
				{				
					// Use the strongly typed property
					switch (name)
					{							
						case "Id": this.str().Id = (string)value; break;							
						case "DepartmentID": this.str().DepartmentID = (string)value; break;							
						case "FirstName": this.str().FirstName = (string)value; break;							
						case "LastName": this.str().LastName = (string)value; break;							
						case "Age": this.str().Age = (string)value; break;							
						case "HireDate": this.str().HireDate = (string)value; break;							
						case "Salary": this.str().Salary = (string)value; break;							
						case "IsActive": this.str().IsActive = (string)value; break;
					}
				}
				else
				{
					switch (name)
					{	
						case "Id":
						
							if (value == null || value is System.Int32)
								this.Id = (System.Int32?)value;
								OnPropertyChanged(AggregatetestMetadata.PropertyNames.Id);
							break;
						
						case "DepartmentID":
						
							if (value == null || value is System.Int32)
								this.DepartmentID = (System.Int32?)value;
								OnPropertyChanged(AggregatetestMetadata.PropertyNames.DepartmentID);
							break;
						
						case "Age":
						
							if (value == null || value is System.Int32)
								this.Age = (System.Int32?)value;
								OnPropertyChanged(AggregatetestMetadata.PropertyNames.Age);
							break;
						
						case "HireDate":
						
							if (value == null || value is System.DateTime)
								this.HireDate = (System.DateTime?)value;
								OnPropertyChanged(AggregatetestMetadata.PropertyNames.HireDate);
							break;
						
						case "Salary":
						
							if (value == null || value is System.Decimal)
								this.Salary = (System.Decimal?)value;
								OnPropertyChanged(AggregatetestMetadata.PropertyNames.Salary);
							break;
						
						case "IsActive":
						
							if (value == null || value is System.SByte)
								this.IsActive = (System.SByte?)value;
								OnPropertyChanged(AggregatetestMetadata.PropertyNames.IsActive);
							break;
					

						default:
							break;
					}
				}
			}
            else if (this.ContainsColumn(name))
            {
                this.SetColumn(name, value);
            }
			else
			{
				throw new Exception("SetProperty Error: '" + name + "' not found");
			}
		}		

		public esStrings str()
		{
			if (esstrings == null)
			{
				esstrings = new esStrings(this);
			}
			return esstrings;
		}

		sealed public class esStrings
		{
			public esStrings(esAggregatetest entity)
			{
				this.entity = entity;
			}
			
	
			public System.String Id
			{
				get
				{
					System.Int32? data = entity.Id;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Id = null;
					else entity.Id = Convert.ToInt32(value);
				}
			}
				
			public System.String DepartmentID
			{
				get
				{
					System.Int32? data = entity.DepartmentID;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.DepartmentID = null;
					else entity.DepartmentID = Convert.ToInt32(value);
				}
			}
				
			public System.String FirstName
			{
				get
				{
					System.String data = entity.FirstName;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.FirstName = null;
					else entity.FirstName = Convert.ToString(value);
				}
			}
				
			public System.String LastName
			{
				get
				{
					System.String data = entity.LastName;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.LastName = null;
					else entity.LastName = Convert.ToString(value);
				}
			}
				
			public System.String Age
			{
				get
				{
					System.Int32? data = entity.Age;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Age = null;
					else entity.Age = Convert.ToInt32(value);
				}
			}
				
			public System.String HireDate
			{
				get
				{
					System.DateTime? data = entity.HireDate;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.HireDate = null;
					else entity.HireDate = Convert.ToDateTime(value);
				}
			}
				
			public System.String Salary
			{
				get
				{
					System.Decimal? data = entity.Salary;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Salary = null;
					else entity.Salary = Convert.ToDecimal(value);
				}
			}
				
			public System.String IsActive
			{
				get
				{
					System.SByte? data = entity.IsActive;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.IsActive = null;
					else entity.IsActive = Convert.ToSByte(value);
				}
			}
			

			private esAggregatetest entity;
		}
		
		[NonSerialized]
		private esStrings esstrings;		
		
		#endregion
		
		#region Housekeeping methods

		override protected IMetadata Meta
		{
			get
			{
				return AggregatetestMetadata.Meta();
			}
		}

		#endregion		
		
		#region Query Logic

		public AggregatetestQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new AggregatetestQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(AggregatetestQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}
		
		protected void InitQuery(AggregatetestQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntity)this).Connection;
			}			
		}

		#endregion
		
        [IgnoreDataMember]
		private AggregatetestQuery query;		
	}



	[Serializable]
	abstract public partial class esAggregatetestCollection : esEntityCollection<Aggregatetest>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return AggregatetestMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "AggregatetestCollection";
		}

		#endregion		
		
		#region Query Logic

	#if (!WindowsCE)
		[BrowsableAttribute(false)]
	#endif
		public AggregatetestQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new AggregatetestQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(AggregatetestQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new AggregatetestQuery();
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(AggregatetestQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntityCollection)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((AggregatetestQuery)query);
		}

		#endregion
		
		private AggregatetestQuery query;
	}



	[Serializable]
	abstract public partial class esAggregatetestQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return AggregatetestMetadata.Meta();
			}
		}	
		
		#region QueryItemFromName
		
        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
				case "Id": return this.Id;
				case "DepartmentID": return this.DepartmentID;
				case "FirstName": return this.FirstName;
				case "LastName": return this.LastName;
				case "Age": return this.Age;
				case "HireDate": return this.HireDate;
				case "Salary": return this.Salary;
				case "IsActive": return this.IsActive;

                default: return null;
            }
        }		
		
		#endregion
		
		#region esQueryItems

		public esQueryItem Id
		{
			get { return new esQueryItem(this, AggregatetestMetadata.ColumnNames.Id, esSystemType.Int32); }
		} 
		
		public esQueryItem DepartmentID
		{
			get { return new esQueryItem(this, AggregatetestMetadata.ColumnNames.DepartmentID, esSystemType.Int32); }
		} 
		
		public esQueryItem FirstName
		{
			get { return new esQueryItem(this, AggregatetestMetadata.ColumnNames.FirstName, esSystemType.String); }
		} 
		
		public esQueryItem LastName
		{
			get { return new esQueryItem(this, AggregatetestMetadata.ColumnNames.LastName, esSystemType.String); }
		} 
		
		public esQueryItem Age
		{
			get { return new esQueryItem(this, AggregatetestMetadata.ColumnNames.Age, esSystemType.Int32); }
		} 
		
		public esQueryItem HireDate
		{
			get { return new esQueryItem(this, AggregatetestMetadata.ColumnNames.HireDate, esSystemType.DateTime); }
		} 
		
		public esQueryItem Salary
		{
			get { return new esQueryItem(this, AggregatetestMetadata.ColumnNames.Salary, esSystemType.Decimal); }
		} 
		
		public esQueryItem IsActive
		{
			get { return new esQueryItem(this, AggregatetestMetadata.ColumnNames.IsActive, esSystemType.SByte); }
		} 
		
		#endregion
		
	}


	
	public partial class Aggregatetest : esAggregatetest
	{

		
		
	}
	



	[Serializable]
	public partial class AggregatetestMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected AggregatetestMetadata()
		{
			m_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(AggregatetestMetadata.ColumnNames.Id, 0, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = AggregatetestMetadata.PropertyNames.Id;
			c.IsInPrimaryKey = true;
			c.IsAutoIncrement = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(AggregatetestMetadata.ColumnNames.DepartmentID, 1, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = AggregatetestMetadata.PropertyNames.DepartmentID;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(AggregatetestMetadata.ColumnNames.FirstName, 2, typeof(System.String), esSystemType.String);
			c.PropertyName = AggregatetestMetadata.PropertyNames.FirstName;
			c.CharacterMaxLength = 45;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(AggregatetestMetadata.ColumnNames.LastName, 3, typeof(System.String), esSystemType.String);
			c.PropertyName = AggregatetestMetadata.PropertyNames.LastName;
			c.CharacterMaxLength = 45;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(AggregatetestMetadata.ColumnNames.Age, 4, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = AggregatetestMetadata.PropertyNames.Age;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(AggregatetestMetadata.ColumnNames.HireDate, 5, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = AggregatetestMetadata.PropertyNames.HireDate;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(AggregatetestMetadata.ColumnNames.Salary, 6, typeof(System.Decimal), esSystemType.Decimal);
			c.PropertyName = AggregatetestMetadata.PropertyNames.Salary;
			c.NumericPrecision = 18;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(AggregatetestMetadata.ColumnNames.IsActive, 7, typeof(System.SByte), esSystemType.SByte);
			c.PropertyName = AggregatetestMetadata.PropertyNames.IsActive;
			c.NumericPrecision = 1;
			c.IsNullable = true;
			m_columns.Add(c);
				
		}
		#endregion	
	
		static public AggregatetestMetadata Meta()
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
			 public const string DepartmentID = "DepartmentID";
			 public const string FirstName = "FirstName";
			 public const string LastName = "LastName";
			 public const string Age = "Age";
			 public const string HireDate = "HireDate";
			 public const string Salary = "Salary";
			 public const string IsActive = "IsActive";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string Id = "Id";
			 public const string DepartmentID = "DepartmentID";
			 public const string FirstName = "FirstName";
			 public const string LastName = "LastName";
			 public const string Age = "Age";
			 public const string HireDate = "HireDate";
			 public const string Salary = "Salary";
			 public const string IsActive = "IsActive";
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
			lock (typeof(AggregatetestMetadata))
			{
				if(AggregatetestMetadata.mapDelegates == null)
				{
					AggregatetestMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (AggregatetestMetadata.meta == null)
				{
					AggregatetestMetadata.meta = new AggregatetestMetadata();
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
				meta.AddTypeMap("DepartmentID", new esTypeMap("INT", "System.Int32"));
				meta.AddTypeMap("FirstName", new esTypeMap("VARCHAR", "System.String"));
				meta.AddTypeMap("LastName", new esTypeMap("VARCHAR", "System.String"));
				meta.AddTypeMap("Age", new esTypeMap("INT", "System.Int32"));
				meta.AddTypeMap("HireDate", new esTypeMap("DATETIME", "System.DateTime"));
				meta.AddTypeMap("Salary", new esTypeMap("DECIMAL", "System.Decimal"));
				meta.AddTypeMap("IsActive", new esTypeMap("TINYINT", "System.SByte"));			
				
				
				
				meta.Source = "aggregatetest";
				meta.Destination = "aggregatetest";
				
				meta.spInsert = "proc_aggregatetestInsert";				
				meta.spUpdate = "proc_aggregatetestUpdate";		
				meta.spDelete = "proc_aggregatetestDelete";
				meta.spLoadAll = "proc_aggregatetestLoadAll";
				meta.spLoadByPrimaryKey = "proc_aggregatetestLoadByPrimaryKey";
				
				this.m_providerMetadataMaps["esDefault"] = meta;
			}
			
			return this.m_providerMetadataMaps["esDefault"];
		}

		#endregion

		static private AggregatetestMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
