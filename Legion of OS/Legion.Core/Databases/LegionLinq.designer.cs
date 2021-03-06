﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Legion.Core.Databases
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Legion")]
	public partial class LegionLinqDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    #endregion
		
		public LegionLinqDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LegionLinqDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LegionLinqDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LegionLinqDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.xspCheckPermission")]
		public ISingleResult<xspCheckPermissionResult> xspCheckPermission([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> applicationid, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(50)")] string servicekey, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(50)")] string methodkey, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Bit")] ref System.Nullable<bool> tfHasPermission)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), applicationid, servicekey, methodkey, tfHasPermission);
			tfHasPermission = ((System.Nullable<bool>)(result.GetParameterValue(3)));
			return ((ISingleResult<xspCheckPermissionResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.xspGetSettingById")]
		public int xspGetSettingById([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> id, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(1000)")] ref string value)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), id, value);
			value = ((string)(result.GetParameterValue(1)));
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.xspGetSettingByKey")]
		public int xspGetSettingByKey([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(50)")] string key, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(1000)")] ref string value)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), key, value);
			value = ((string)(result.GetParameterValue(1)));
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.xspSetSettingById")]
		public ISingleResult<xspSetSettingByIdResult> xspSetSettingById([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> id, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(50)")] string key, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(1000)")] string value)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), id, key, value);
			return ((ISingleResult<xspSetSettingByIdResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.xspSetSettingByKey")]
		public ISingleResult<xspSetSettingByKeyResult> xspSetSettingByKey([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(50)")] string key, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(1000)")] string value)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), key, value);
			return ((ISingleResult<xspSetSettingByKeyResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.xspGetCacheStatus")]
		public int xspGetCacheStatus([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(15)")] string ipaddress, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Bit")] ref System.Nullable<bool> isRefreshRequired)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), ipaddress, isRefreshRequired);
			isRefreshRequired = ((System.Nullable<bool>)(result.GetParameterValue(1)));
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.xspGetAssemblyStatus")]
		public int xspGetAssemblyStatus([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(15)")] string ipaddress, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(50)")] string hostname, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Bit")] ref System.Nullable<bool> isRefreshRequired)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), ipaddress, hostname, isRefreshRequired);
			isRefreshRequired = ((System.Nullable<bool>)(result.GetParameterValue(2)));
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.xspGetKeyRevocationList")]
		public ISingleResult<xspGetKeyRevocationListResult> xspGetKeyRevocationList()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<xspGetKeyRevocationListResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.xspLogMethodCall")]
		public int xspLogMethodCall([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> methodid, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Float")] System.Nullable<double> executionDuration, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="DateTime")] System.Nullable<System.DateTime> dtCall, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> applicationid, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(15)")] string handledbyipaddress, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(15)")] string hostipaddress, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(15)")] string useripaddress, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Bit")] System.Nullable<bool> permanentLog)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), methodid, executionDuration, dtCall, applicationid, handledbyipaddress, hostipaddress, useripaddress, permanentLog);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.xspUpdateMethodMissingFlag")]
		public int xspUpdateMethodMissingFlag([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> methodid, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Bit")] System.Nullable<bool> isMissing, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(10)")] ref string resultcode)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), methodid, isMissing, resultcode);
			resultcode = ((string)(result.GetParameterValue(2)));
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.xspGetServices")]
		public ISingleResult<xspGetServicesResult> xspGetServices()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<xspGetServicesResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.xspGetCachedResult")]
		public ISingleResult<xspGetCachedResultResult> xspGetCachedResult([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> methodid, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Binary(32)")] System.Data.Linq.Binary cachekey)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), methodid, cachekey);
			return ((ISingleResult<xspGetCachedResultResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.xspInsertCachedResult")]
		public int xspInsertCachedResult([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> methodid, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Xml")] System.Xml.Linq.XElement parameterset, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Xml")] System.Xml.Linq.XElement result, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Binary(32)")] System.Data.Linq.Binary cachekey, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="DateTime")] ref System.Nullable<System.DateTime> expireson)
		{
			IExecuteResult result1 = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), methodid, parameterset, result, cachekey, expireson);
			expireson = ((System.Nullable<System.DateTime>)(result1.GetParameterValue(4)));
			return ((int)(result1.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.xspGetApplication")]
		public int xspGetApplication([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Char(36)")] string apikey, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] ref System.Nullable<int> id, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(50)")] ref string name, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(31)")] ref string consumeriprange, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(1000)")] ref string description, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] ref System.Nullable<int> ratelimittypeid, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(50)")] ref string ratelimittype, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] ref System.Nullable<int> ratelimit, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] ref System.Nullable<int> ratelimitinterval, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Bit")] ref System.Nullable<bool> ispublic, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Bit")] ref System.Nullable<bool> islogged)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), apikey, id, name, consumeriprange, description, ratelimittypeid, ratelimittype, ratelimit, ratelimitinterval, ispublic, islogged);
			id = ((System.Nullable<int>)(result.GetParameterValue(1)));
			name = ((string)(result.GetParameterValue(2)));
			consumeriprange = ((string)(result.GetParameterValue(3)));
			description = ((string)(result.GetParameterValue(4)));
			ratelimittypeid = ((System.Nullable<int>)(result.GetParameterValue(5)));
			ratelimittype = ((string)(result.GetParameterValue(6)));
			ratelimit = ((System.Nullable<int>)(result.GetParameterValue(7)));
			ratelimitinterval = ((System.Nullable<int>)(result.GetParameterValue(8)));
			ispublic = ((System.Nullable<bool>)(result.GetParameterValue(9)));
			islogged = ((System.Nullable<bool>)(result.GetParameterValue(10)));
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.xspGetExpiredCachedResults")]
		public ISingleResult<xspGetExpiredCachedResultsResult> xspGetExpiredCachedResults([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> timespan)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), timespan);
			return ((ISingleResult<xspGetExpiredCachedResultsResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.xspGetMethods")]
		public ISingleResult<xspGetMethodsResult> xspGetMethods()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<xspGetMethodsResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.xspLogReplyException")]
		public int xspLogReplyException([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> eventid, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> methodid, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Xml")] System.Xml.Linq.XElement parameters, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(1000)")] string exceptionname, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(1000)")] string exceptionmessage, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Text")] string exceptionstacktrace)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), eventid, methodid, parameters, exceptionname, exceptionmessage, exceptionstacktrace);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.xspGetServiceSettings")]
		public ISingleResult<xspGetServiceSettingsResult> xspGetServiceSettings([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Char(36)")] string servicekey, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> serviceid, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(10)")] ref string resultcode)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), servicekey, serviceid, resultcode);
			resultcode = ((string)(result.GetParameterValue(2)));
			return ((ISingleResult<xspGetServiceSettingsResult>)(result.ReturnValue));
		}
	}
	
	public partial class xspCheckPermissionResult
	{
		
		private System.Nullable<int> _Column1;
		
		public xspCheckPermissionResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="", Storage="_Column1", DbType="Int")]
		public System.Nullable<int> Column1
		{
			get
			{
				return this._Column1;
			}
			set
			{
				if ((this._Column1 != value))
				{
					this._Column1 = value;
				}
			}
		}
	}
	
	public partial class xspSetSettingByIdResult
	{
		
		private int _id;
		
		public xspSetSettingByIdResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", DbType="Int NOT NULL")]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this._id = value;
				}
			}
		}
	}
	
	public partial class xspSetSettingByKeyResult
	{
		
		private int _id;
		
		public xspSetSettingByKeyResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", DbType="Int NOT NULL")]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this._id = value;
				}
			}
		}
	}
	
	public partial class xspGetKeyRevocationListResult
	{
		
		private string _Key;
		
		public xspGetKeyRevocationListResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Key]", Storage="_Key", DbType="Char(36) NOT NULL", CanBeNull=false)]
		public string Key
		{
			get
			{
				return this._Key;
			}
			set
			{
				if ((this._Key != value))
				{
					this._Key = value;
				}
			}
		}
	}
	
	public partial class xspGetServicesResult
	{
		
		private int _ServiceId;
		
		private string _ServiceKey;
		
		private string _AssemblyName;
		
		private string _ClassName;
		
		private string _ConsumerIPRange;
		
		private bool _IsRestricted;
		
		private bool _IsPublic;
		
		private bool _IsLogged;
		
		private string _Description;
		
		public xspGetServicesResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ServiceId", DbType="Int NOT NULL")]
		public int ServiceId
		{
			get
			{
				return this._ServiceId;
			}
			set
			{
				if ((this._ServiceId != value))
				{
					this._ServiceId = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ServiceKey", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string ServiceKey
		{
			get
			{
				return this._ServiceKey;
			}
			set
			{
				if ((this._ServiceKey != value))
				{
					this._ServiceKey = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AssemblyName", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string AssemblyName
		{
			get
			{
				return this._AssemblyName;
			}
			set
			{
				if ((this._AssemblyName != value))
				{
					this._AssemblyName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ClassName", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string ClassName
		{
			get
			{
				return this._ClassName;
			}
			set
			{
				if ((this._ClassName != value))
				{
					this._ClassName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ConsumerIPRange", DbType="VarChar(31)")]
		public string ConsumerIPRange
		{
			get
			{
				return this._ConsumerIPRange;
			}
			set
			{
				if ((this._ConsumerIPRange != value))
				{
					this._ConsumerIPRange = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IsRestricted", DbType="Bit NOT NULL")]
		public bool IsRestricted
		{
			get
			{
				return this._IsRestricted;
			}
			set
			{
				if ((this._IsRestricted != value))
				{
					this._IsRestricted = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IsPublic", DbType="Bit NOT NULL")]
		public bool IsPublic
		{
			get
			{
				return this._IsPublic;
			}
			set
			{
				if ((this._IsPublic != value))
				{
					this._IsPublic = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IsLogged", DbType="Bit NOT NULL")]
		public bool IsLogged
		{
			get
			{
				return this._IsLogged;
			}
			set
			{
				if ((this._IsLogged != value))
				{
					this._IsLogged = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Description", DbType="VarChar(1000)")]
		public string Description
		{
			get
			{
				return this._Description;
			}
			set
			{
				if ((this._Description != value))
				{
					this._Description = value;
				}
			}
		}
	}
	
	public partial class xspGetCachedResultResult
	{
		
		private System.Xml.Linq.XElement _Result;
		
		private System.DateTime _UpdatedOn;
		
		private System.DateTime _ExpiresOn;
		
		public xspGetCachedResultResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Result", DbType="Xml NOT NULL", CanBeNull=false)]
		public System.Xml.Linq.XElement Result
		{
			get
			{
				return this._Result;
			}
			set
			{
				if ((this._Result != value))
				{
					this._Result = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UpdatedOn", DbType="DateTime NOT NULL")]
		public System.DateTime UpdatedOn
		{
			get
			{
				return this._UpdatedOn;
			}
			set
			{
				if ((this._UpdatedOn != value))
				{
					this._UpdatedOn = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ExpiresOn", DbType="DateTime NOT NULL")]
		public System.DateTime ExpiresOn
		{
			get
			{
				return this._ExpiresOn;
			}
			set
			{
				if ((this._ExpiresOn != value))
				{
					this._ExpiresOn = value;
				}
			}
		}
	}
	
	public partial class xspGetExpiredCachedResultsResult
	{
		
		private int _MethodId;
		
		private System.Data.Linq.Binary _CacheKey;
		
		public xspGetExpiredCachedResultsResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MethodId", DbType="Int NOT NULL")]
		public int MethodId
		{
			get
			{
				return this._MethodId;
			}
			set
			{
				if ((this._MethodId != value))
				{
					this._MethodId = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CacheKey", DbType="Binary(32) NOT NULL", CanBeNull=false)]
		public System.Data.Linq.Binary CacheKey
		{
			get
			{
				return this._CacheKey;
			}
			set
			{
				if ((this._CacheKey != value))
				{
					this._CacheKey = value;
				}
			}
		}
	}
	
	public partial class xspGetMethodsResult
	{
		
		private int _MethodId;
		
		private int _ServiceId;
		
		private string _MethodKey;
		
		private string _ServiceKey;
		
		private string _MethodName;
		
		private System.Nullable<int> _CachedResultLifetime;
		
		private bool _IsResultCacheable;
		
		private bool _IsLogReplayDetailsOnException;
		
		private bool _IsMissing;
		
		private System.Nullable<bool> _IsRestricted;
		
		private bool _IsPublic;
		
		private bool _IsLogged;
		
		public xspGetMethodsResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MethodId", DbType="Int NOT NULL")]
		public int MethodId
		{
			get
			{
				return this._MethodId;
			}
			set
			{
				if ((this._MethodId != value))
				{
					this._MethodId = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ServiceId", DbType="Int NOT NULL")]
		public int ServiceId
		{
			get
			{
				return this._ServiceId;
			}
			set
			{
				if ((this._ServiceId != value))
				{
					this._ServiceId = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MethodKey", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string MethodKey
		{
			get
			{
				return this._MethodKey;
			}
			set
			{
				if ((this._MethodKey != value))
				{
					this._MethodKey = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ServiceKey", DbType="VarChar(50)")]
		public string ServiceKey
		{
			get
			{
				return this._ServiceKey;
			}
			set
			{
				if ((this._ServiceKey != value))
				{
					this._ServiceKey = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MethodName", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string MethodName
		{
			get
			{
				return this._MethodName;
			}
			set
			{
				if ((this._MethodName != value))
				{
					this._MethodName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CachedResultLifetime", DbType="Int")]
		public System.Nullable<int> CachedResultLifetime
		{
			get
			{
				return this._CachedResultLifetime;
			}
			set
			{
				if ((this._CachedResultLifetime != value))
				{
					this._CachedResultLifetime = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IsResultCacheable", DbType="Bit NOT NULL")]
		public bool IsResultCacheable
		{
			get
			{
				return this._IsResultCacheable;
			}
			set
			{
				if ((this._IsResultCacheable != value))
				{
					this._IsResultCacheable = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IsLogReplayDetailsOnException", DbType="Bit NOT NULL")]
		public bool IsLogReplayDetailsOnException
		{
			get
			{
				return this._IsLogReplayDetailsOnException;
			}
			set
			{
				if ((this._IsLogReplayDetailsOnException != value))
				{
					this._IsLogReplayDetailsOnException = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IsMissing", DbType="Bit NOT NULL")]
		public bool IsMissing
		{
			get
			{
				return this._IsMissing;
			}
			set
			{
				if ((this._IsMissing != value))
				{
					this._IsMissing = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IsRestricted", DbType="Bit")]
		public System.Nullable<bool> IsRestricted
		{
			get
			{
				return this._IsRestricted;
			}
			set
			{
				if ((this._IsRestricted != value))
				{
					this._IsRestricted = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IsPublic", DbType="Bit NOT NULL")]
		public bool IsPublic
		{
			get
			{
				return this._IsPublic;
			}
			set
			{
				if ((this._IsPublic != value))
				{
					this._IsPublic = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IsLogged", DbType="Bit NOT NULL")]
		public bool IsLogged
		{
			get
			{
				return this._IsLogged;
			}
			set
			{
				if ((this._IsLogged != value))
				{
					this._IsLogged = value;
				}
			}
		}
	}
	
	public partial class xspGetServiceSettingsResult
	{
		
		private int _Id;
		
		private string _Name;
		
		private string _IV;
		
		private string _Value;
		
		private bool _IsEncrypted;
		
		public xspGetServiceSettingsResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="Int NOT NULL")]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this._Id = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this._Name = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IV", DbType="VarChar(64)")]
		public string IV
		{
			get
			{
				return this._IV;
			}
			set
			{
				if ((this._IV != value))
				{
					this._IV = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Value", DbType="VarChar(8000) NOT NULL", CanBeNull=false)]
		public string Value
		{
			get
			{
				return this._Value;
			}
			set
			{
				if ((this._Value != value))
				{
					this._Value = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IsEncrypted", DbType="Bit NOT NULL")]
		public bool IsEncrypted
		{
			get
			{
				return this._IsEncrypted;
			}
			set
			{
				if ((this._IsEncrypted != value))
				{
					this._IsEncrypted = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
