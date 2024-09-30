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

namespace Proiect
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="ProiectBD")]
	public partial class DataClassesDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertProduse(Produse instance);
    partial void UpdateProduse(Produse instance);
    partial void DeleteProduse(Produse instance);
    partial void InsertParteneri(Parteneri instance);
    partial void UpdateParteneri(Parteneri instance);
    partial void DeleteParteneri(Parteneri instance);
    partial void InsertIntrari(Intrari instance);
    partial void UpdateIntrari(Intrari instance);
    partial void DeleteIntrari(Intrari instance);
    partial void InsertGestiuni(Gestiuni instance);
    partial void UpdateGestiuni(Gestiuni instance);
    partial void DeleteGestiuni(Gestiuni instance);
    partial void InsertIntrari_detaliu(Intrari_detaliu instance);
    partial void UpdateIntrari_detaliu(Intrari_detaliu instance);
    partial void DeleteIntrari_detaliu(Intrari_detaliu instance);
    partial void InsertIesiri(Iesiri instance);
    partial void UpdateIesiri(Iesiri instance);
    partial void DeleteIesiri(Iesiri instance);
    partial void InsertIesiri_detaliu(Iesiri_detaliu instance);
    partial void UpdateIesiri_detaliu(Iesiri_detaliu instance);
    partial void DeleteIesiri_detaliu(Iesiri_detaliu instance);
    #endregion
		
		public DataClassesDataContext() : 
				base(global::Proiect.Properties.Settings.Default.ProiectBDConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Produse> Produses
		{
			get
			{
				return this.GetTable<Produse>();
			}
		}
		
		public System.Data.Linq.Table<Parteneri> Parteneris
		{
			get
			{
				return this.GetTable<Parteneri>();
			}
		}
		
		public System.Data.Linq.Table<Intrari> Intraris
		{
			get
			{
				return this.GetTable<Intrari>();
			}
		}
		
		public System.Data.Linq.Table<Gestiuni> Gestiunis
		{
			get
			{
				return this.GetTable<Gestiuni>();
			}
		}
		
		public System.Data.Linq.Table<Intrari_detaliu> Intrari_detalius
		{
			get
			{
				return this.GetTable<Intrari_detaliu>();
			}
		}
		
		public System.Data.Linq.Table<Iesiri> Iesiris
		{
			get
			{
				return this.GetTable<Iesiri>();
			}
		}
		
		public System.Data.Linq.Table<Iesiri_detaliu> Iesiri_detalius
		{
			get
			{
				return this.GetTable<Iesiri_detaliu>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Produse")]
	public partial class Produse : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private decimal _ID;
		
		private System.Nullable<int> _Cod;
		
		private string _Nume;
		
		private System.Nullable<decimal> _Pret;
		
		private EntitySet<Intrari_detaliu> _Intrari_detalius;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(decimal value);
    partial void OnIDChanged();
    partial void OnCodChanging(System.Nullable<int> value);
    partial void OnCodChanged();
    partial void OnNumeChanging(string value);
    partial void OnNumeChanged();
    partial void OnPretChanging(System.Nullable<decimal> value);
    partial void OnPretChanged();
    #endregion
		
		public Produse()
		{
			this._Intrari_detalius = new EntitySet<Intrari_detaliu>(new Action<Intrari_detaliu>(this.attach_Intrari_detalius), new Action<Intrari_detaliu>(this.detach_Intrari_detalius));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Decimal(18,0) NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public decimal ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Cod", DbType="Int")]
		public System.Nullable<int> Cod
		{
			get
			{
				return this._Cod;
			}
			set
			{
				if ((this._Cod != value))
				{
					this.OnCodChanging(value);
					this.SendPropertyChanging();
					this._Cod = value;
					this.SendPropertyChanged("Cod");
					this.OnCodChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nume", DbType="Text", UpdateCheck=UpdateCheck.Never)]
		public string Nume
		{
			get
			{
				return this._Nume;
			}
			set
			{
				if ((this._Nume != value))
				{
					this.OnNumeChanging(value);
					this.SendPropertyChanging();
					this._Nume = value;
					this.SendPropertyChanged("Nume");
					this.OnNumeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Pret", DbType="Decimal(18,2)")]
		public System.Nullable<decimal> Pret
		{
			get
			{
				return this._Pret;
			}
			set
			{
				if ((this._Pret != value))
				{
					this.OnPretChanging(value);
					this.SendPropertyChanging();
					this._Pret = value;
					this.SendPropertyChanged("Pret");
					this.OnPretChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Produse_Intrari_detaliu", Storage="_Intrari_detalius", ThisKey="ID", OtherKey="Produs")]
		public EntitySet<Intrari_detaliu> Intrari_detalius
		{
			get
			{
				return this._Intrari_detalius;
			}
			set
			{
				this._Intrari_detalius.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Intrari_detalius(Intrari_detaliu entity)
		{
			this.SendPropertyChanging();
			entity.Produse = this;
		}
		
		private void detach_Intrari_detalius(Intrari_detaliu entity)
		{
			this.SendPropertyChanging();
			entity.Produse = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Parteneri")]
	public partial class Parteneri : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private decimal _ID;
		
		private System.Nullable<int> _Cod;
		
		private string _Nume;
		
		private string _Tip;
		
		private string _Cui;
		
		private string _Adresa;
		
		private EntitySet<Intrari> _Intraris;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(decimal value);
    partial void OnIDChanged();
    partial void OnCodChanging(System.Nullable<int> value);
    partial void OnCodChanged();
    partial void OnNumeChanging(string value);
    partial void OnNumeChanged();
    partial void OnTipChanging(string value);
    partial void OnTipChanged();
    partial void OnCuiChanging(string value);
    partial void OnCuiChanged();
    partial void OnAdresaChanging(string value);
    partial void OnAdresaChanged();
    #endregion
		
		public Parteneri()
		{
			this._Intraris = new EntitySet<Intrari>(new Action<Intrari>(this.attach_Intraris), new Action<Intrari>(this.detach_Intraris));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Decimal(18,0) NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public decimal ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Cod", DbType="Int")]
		public System.Nullable<int> Cod
		{
			get
			{
				return this._Cod;
			}
			set
			{
				if ((this._Cod != value))
				{
					this.OnCodChanging(value);
					this.SendPropertyChanging();
					this._Cod = value;
					this.SendPropertyChanged("Cod");
					this.OnCodChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nume", DbType="Text", UpdateCheck=UpdateCheck.Never)]
		public string Nume
		{
			get
			{
				return this._Nume;
			}
			set
			{
				if ((this._Nume != value))
				{
					this.OnNumeChanging(value);
					this.SendPropertyChanging();
					this._Nume = value;
					this.SendPropertyChanged("Nume");
					this.OnNumeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Tip", DbType="NChar(20)")]
		public string Tip
		{
			get
			{
				return this._Tip;
			}
			set
			{
				if ((this._Tip != value))
				{
					this.OnTipChanging(value);
					this.SendPropertyChanging();
					this._Tip = value;
					this.SendPropertyChanged("Tip");
					this.OnTipChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Cui", DbType="Text", UpdateCheck=UpdateCheck.Never)]
		public string Cui
		{
			get
			{
				return this._Cui;
			}
			set
			{
				if ((this._Cui != value))
				{
					this.OnCuiChanging(value);
					this.SendPropertyChanging();
					this._Cui = value;
					this.SendPropertyChanged("Cui");
					this.OnCuiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Adresa", DbType="Text", UpdateCheck=UpdateCheck.Never)]
		public string Adresa
		{
			get
			{
				return this._Adresa;
			}
			set
			{
				if ((this._Adresa != value))
				{
					this.OnAdresaChanging(value);
					this.SendPropertyChanging();
					this._Adresa = value;
					this.SendPropertyChanged("Adresa");
					this.OnAdresaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Parteneri_Intrari", Storage="_Intraris", ThisKey="ID", OtherKey="Partener")]
		public EntitySet<Intrari> Intraris
		{
			get
			{
				return this._Intraris;
			}
			set
			{
				this._Intraris.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Intraris(Intrari entity)
		{
			this.SendPropertyChanging();
			entity.Parteneri = this;
		}
		
		private void detach_Intraris(Intrari entity)
		{
			this.SendPropertyChanging();
			entity.Parteneri = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Intrari")]
	public partial class Intrari : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private decimal _ID;
		
		private decimal _Numar;
		
		private System.Nullable<System.DateTime> _Data;
		
		private System.Nullable<decimal> _Partener;
		
		private System.Nullable<decimal> _Gestiune;
		
		private EntitySet<Intrari_detaliu> _Intrari_detalius;
		
		private EntityRef<Parteneri> _Parteneri;
		
		private EntityRef<Gestiuni> _Gestiuni;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(decimal value);
    partial void OnIDChanged();
    partial void OnNumarChanging(decimal value);
    partial void OnNumarChanged();
    partial void OnDataChanging(System.Nullable<System.DateTime> value);
    partial void OnDataChanged();
    partial void OnPartenerChanging(System.Nullable<decimal> value);
    partial void OnPartenerChanged();
    partial void OnGestiuneChanging(System.Nullable<decimal> value);
    partial void OnGestiuneChanged();
    #endregion
		
		public Intrari()
		{
			this._Intrari_detalius = new EntitySet<Intrari_detaliu>(new Action<Intrari_detaliu>(this.attach_Intrari_detalius), new Action<Intrari_detaliu>(this.detach_Intrari_detalius));
			this._Parteneri = default(EntityRef<Parteneri>);
			this._Gestiuni = default(EntityRef<Gestiuni>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Decimal(18,0) NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public decimal ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Numar", DbType="Decimal(18,0) NOT NULL")]
		public decimal Numar
		{
			get
			{
				return this._Numar;
			}
			set
			{
				if ((this._Numar != value))
				{
					this.OnNumarChanging(value);
					this.SendPropertyChanging();
					this._Numar = value;
					this.SendPropertyChanged("Numar");
					this.OnNumarChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Data", DbType="DateTime")]
		public System.Nullable<System.DateTime> Data
		{
			get
			{
				return this._Data;
			}
			set
			{
				if ((this._Data != value))
				{
					this.OnDataChanging(value);
					this.SendPropertyChanging();
					this._Data = value;
					this.SendPropertyChanged("Data");
					this.OnDataChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Partener", DbType="Decimal(18,0)")]
		public System.Nullable<decimal> Partener
		{
			get
			{
				return this._Partener;
			}
			set
			{
				if ((this._Partener != value))
				{
					if (this._Parteneri.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnPartenerChanging(value);
					this.SendPropertyChanging();
					this._Partener = value;
					this.SendPropertyChanged("Partener");
					this.OnPartenerChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Gestiune", DbType="Decimal(18,0)")]
		public System.Nullable<decimal> Gestiune
		{
			get
			{
				return this._Gestiune;
			}
			set
			{
				if ((this._Gestiune != value))
				{
					if (this._Gestiuni.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnGestiuneChanging(value);
					this.SendPropertyChanging();
					this._Gestiune = value;
					this.SendPropertyChanged("Gestiune");
					this.OnGestiuneChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Intrari_Intrari_detaliu", Storage="_Intrari_detalius", ThisKey="ID", OtherKey="ID_Intrari")]
		public EntitySet<Intrari_detaliu> Intrari_detalius
		{
			get
			{
				return this._Intrari_detalius;
			}
			set
			{
				this._Intrari_detalius.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Parteneri_Intrari", Storage="_Parteneri", ThisKey="Partener", OtherKey="ID", IsForeignKey=true)]
		public Parteneri Parteneri
		{
			get
			{
				return this._Parteneri.Entity;
			}
			set
			{
				Parteneri previousValue = this._Parteneri.Entity;
				if (((previousValue != value) 
							|| (this._Parteneri.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Parteneri.Entity = null;
						previousValue.Intraris.Remove(this);
					}
					this._Parteneri.Entity = value;
					if ((value != null))
					{
						value.Intraris.Add(this);
						this._Partener = value.ID;
					}
					else
					{
						this._Partener = default(Nullable<decimal>);
					}
					this.SendPropertyChanged("Parteneri");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Gestiuni_Intrari", Storage="_Gestiuni", ThisKey="Gestiune", OtherKey="ID", IsForeignKey=true)]
		public Gestiuni Gestiuni
		{
			get
			{
				return this._Gestiuni.Entity;
			}
			set
			{
				Gestiuni previousValue = this._Gestiuni.Entity;
				if (((previousValue != value) 
							|| (this._Gestiuni.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Gestiuni.Entity = null;
						previousValue.Intraris.Remove(this);
					}
					this._Gestiuni.Entity = value;
					if ((value != null))
					{
						value.Intraris.Add(this);
						this._Gestiune = value.ID;
					}
					else
					{
						this._Gestiune = default(Nullable<decimal>);
					}
					this.SendPropertyChanged("Gestiuni");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Intrari_detalius(Intrari_detaliu entity)
		{
			this.SendPropertyChanging();
			entity.Intrari = this;
		}
		
		private void detach_Intrari_detalius(Intrari_detaliu entity)
		{
			this.SendPropertyChanging();
			entity.Intrari = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Gestiuni")]
	public partial class Gestiuni : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private decimal _ID;
		
		private System.Nullable<int> _Cod;
		
		private string _Nume;
		
		private EntitySet<Intrari> _Intraris;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(decimal value);
    partial void OnIDChanged();
    partial void OnCodChanging(System.Nullable<int> value);
    partial void OnCodChanged();
    partial void OnNumeChanging(string value);
    partial void OnNumeChanged();
    #endregion
		
		public Gestiuni()
		{
			this._Intraris = new EntitySet<Intrari>(new Action<Intrari>(this.attach_Intraris), new Action<Intrari>(this.detach_Intraris));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Decimal(18,0) NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public decimal ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Cod", DbType="Int")]
		public System.Nullable<int> Cod
		{
			get
			{
				return this._Cod;
			}
			set
			{
				if ((this._Cod != value))
				{
					this.OnCodChanging(value);
					this.SendPropertyChanging();
					this._Cod = value;
					this.SendPropertyChanged("Cod");
					this.OnCodChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nume", DbType="Text", UpdateCheck=UpdateCheck.Never)]
		public string Nume
		{
			get
			{
				return this._Nume;
			}
			set
			{
				if ((this._Nume != value))
				{
					this.OnNumeChanging(value);
					this.SendPropertyChanging();
					this._Nume = value;
					this.SendPropertyChanged("Nume");
					this.OnNumeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Gestiuni_Intrari", Storage="_Intraris", ThisKey="ID", OtherKey="Gestiune")]
		public EntitySet<Intrari> Intraris
		{
			get
			{
				return this._Intraris;
			}
			set
			{
				this._Intraris.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Intraris(Intrari entity)
		{
			this.SendPropertyChanging();
			entity.Gestiuni = this;
		}
		
		private void detach_Intraris(Intrari entity)
		{
			this.SendPropertyChanging();
			entity.Gestiuni = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Intrari_detaliu")]
	public partial class Intrari_detaliu : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private decimal _ID;
		
		private System.Nullable<decimal> _ID_Intrari;
		
		private System.Nullable<decimal> _Produs;
		
		private System.Nullable<decimal> _Cantitate;
		
		private System.Nullable<decimal> _Valoare;
		
		private EntityRef<Intrari> _Intrari;
		
		private EntityRef<Produse> _Produse;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(decimal value);
    partial void OnIDChanged();
    partial void OnID_IntrariChanging(System.Nullable<decimal> value);
    partial void OnID_IntrariChanged();
    partial void OnProdusChanging(System.Nullable<decimal> value);
    partial void OnProdusChanged();
    partial void OnCantitateChanging(System.Nullable<decimal> value);
    partial void OnCantitateChanged();
    partial void OnValoareChanging(System.Nullable<decimal> value);
    partial void OnValoareChanged();
    #endregion
		
		public Intrari_detaliu()
		{
			this._Intrari = default(EntityRef<Intrari>);
			this._Produse = default(EntityRef<Produse>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Decimal(18,0) NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public decimal ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID_Intrari", DbType="Decimal(18,0)")]
		public System.Nullable<decimal> ID_Intrari
		{
			get
			{
				return this._ID_Intrari;
			}
			set
			{
				if ((this._ID_Intrari != value))
				{
					if (this._Intrari.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnID_IntrariChanging(value);
					this.SendPropertyChanging();
					this._ID_Intrari = value;
					this.SendPropertyChanged("ID_Intrari");
					this.OnID_IntrariChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Produs", DbType="Decimal(18,0)")]
		public System.Nullable<decimal> Produs
		{
			get
			{
				return this._Produs;
			}
			set
			{
				if ((this._Produs != value))
				{
					if (this._Produse.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnProdusChanging(value);
					this.SendPropertyChanging();
					this._Produs = value;
					this.SendPropertyChanged("Produs");
					this.OnProdusChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Cantitate", DbType="Decimal(18,2)")]
		public System.Nullable<decimal> Cantitate
		{
			get
			{
				return this._Cantitate;
			}
			set
			{
				if ((this._Cantitate != value))
				{
					this.OnCantitateChanging(value);
					this.SendPropertyChanging();
					this._Cantitate = value;
					this.SendPropertyChanged("Cantitate");
					this.OnCantitateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Valoare", DbType="Decimal(18,2)")]
		public System.Nullable<decimal> Valoare
		{
			get
			{
				return this._Valoare;
			}
			set
			{
				if ((this._Valoare != value))
				{
					this.OnValoareChanging(value);
					this.SendPropertyChanging();
					this._Valoare = value;
					this.SendPropertyChanged("Valoare");
					this.OnValoareChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Intrari_Intrari_detaliu", Storage="_Intrari", ThisKey="ID_Intrari", OtherKey="ID", IsForeignKey=true)]
		public Intrari Intrari
		{
			get
			{
				return this._Intrari.Entity;
			}
			set
			{
				Intrari previousValue = this._Intrari.Entity;
				if (((previousValue != value) 
							|| (this._Intrari.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Intrari.Entity = null;
						previousValue.Intrari_detalius.Remove(this);
					}
					this._Intrari.Entity = value;
					if ((value != null))
					{
						value.Intrari_detalius.Add(this);
						this._ID_Intrari = value.ID;
					}
					else
					{
						this._ID_Intrari = default(Nullable<decimal>);
					}
					this.SendPropertyChanged("Intrari");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Produse_Intrari_detaliu", Storage="_Produse", ThisKey="Produs", OtherKey="ID", IsForeignKey=true)]
		public Produse Produse
		{
			get
			{
				return this._Produse.Entity;
			}
			set
			{
				Produse previousValue = this._Produse.Entity;
				if (((previousValue != value) 
							|| (this._Produse.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Produse.Entity = null;
						previousValue.Intrari_detalius.Remove(this);
					}
					this._Produse.Entity = value;
					if ((value != null))
					{
						value.Intrari_detalius.Add(this);
						this._Produs = value.ID;
					}
					else
					{
						this._Produs = default(Nullable<decimal>);
					}
					this.SendPropertyChanged("Produse");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Iesiri")]
	public partial class Iesiri : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private decimal _ID;
		
		private System.Nullable<decimal> _Numar;
		
		private System.Nullable<System.DateTime> _Data;
		
		private System.Nullable<decimal> _Gestiune;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(decimal value);
    partial void OnIDChanged();
    partial void OnNumarChanging(System.Nullable<decimal> value);
    partial void OnNumarChanged();
    partial void OnDataChanging(System.Nullable<System.DateTime> value);
    partial void OnDataChanged();
    partial void OnGestiuneChanging(System.Nullable<decimal> value);
    partial void OnGestiuneChanged();
    #endregion
		
		public Iesiri()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Decimal(18,0) NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public decimal ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Numar", DbType="Decimal(18,0)")]
		public System.Nullable<decimal> Numar
		{
			get
			{
				return this._Numar;
			}
			set
			{
				if ((this._Numar != value))
				{
					this.OnNumarChanging(value);
					this.SendPropertyChanging();
					this._Numar = value;
					this.SendPropertyChanged("Numar");
					this.OnNumarChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Data", DbType="DateTime")]
		public System.Nullable<System.DateTime> Data
		{
			get
			{
				return this._Data;
			}
			set
			{
				if ((this._Data != value))
				{
					this.OnDataChanging(value);
					this.SendPropertyChanging();
					this._Data = value;
					this.SendPropertyChanged("Data");
					this.OnDataChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Gestiune", DbType="Decimal(18,0)")]
		public System.Nullable<decimal> Gestiune
		{
			get
			{
				return this._Gestiune;
			}
			set
			{
				if ((this._Gestiune != value))
				{
					this.OnGestiuneChanging(value);
					this.SendPropertyChanging();
					this._Gestiune = value;
					this.SendPropertyChanged("Gestiune");
					this.OnGestiuneChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Iesiri_detaliu")]
	public partial class Iesiri_detaliu : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private decimal _ID;
		
		private System.Nullable<decimal> _ID_Iesiri;
		
		private System.Nullable<decimal> _Produs;
		
		private System.Nullable<decimal> _Cantitate;
		
		private System.Nullable<decimal> _Valoare;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(decimal value);
    partial void OnIDChanged();
    partial void OnID_IesiriChanging(System.Nullable<decimal> value);
    partial void OnID_IesiriChanged();
    partial void OnProdusChanging(System.Nullable<decimal> value);
    partial void OnProdusChanged();
    partial void OnCantitateChanging(System.Nullable<decimal> value);
    partial void OnCantitateChanged();
    partial void OnValoareChanging(System.Nullable<decimal> value);
    partial void OnValoareChanged();
    #endregion
		
		public Iesiri_detaliu()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Decimal(18,0) NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public decimal ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID_Iesiri", DbType="Decimal(18,0)")]
		public System.Nullable<decimal> ID_Iesiri
		{
			get
			{
				return this._ID_Iesiri;
			}
			set
			{
				if ((this._ID_Iesiri != value))
				{
					this.OnID_IesiriChanging(value);
					this.SendPropertyChanging();
					this._ID_Iesiri = value;
					this.SendPropertyChanged("ID_Iesiri");
					this.OnID_IesiriChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Produs", DbType="Decimal(18,0)")]
		public System.Nullable<decimal> Produs
		{
			get
			{
				return this._Produs;
			}
			set
			{
				if ((this._Produs != value))
				{
					this.OnProdusChanging(value);
					this.SendPropertyChanging();
					this._Produs = value;
					this.SendPropertyChanged("Produs");
					this.OnProdusChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Cantitate", DbType="Decimal(18,0)")]
		public System.Nullable<decimal> Cantitate
		{
			get
			{
				return this._Cantitate;
			}
			set
			{
				if ((this._Cantitate != value))
				{
					this.OnCantitateChanging(value);
					this.SendPropertyChanging();
					this._Cantitate = value;
					this.SendPropertyChanged("Cantitate");
					this.OnCantitateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Valoare", DbType="Decimal(18,0)")]
		public System.Nullable<decimal> Valoare
		{
			get
			{
				return this._Valoare;
			}
			set
			{
				if ((this._Valoare != value))
				{
					this.OnValoareChanging(value);
					this.SendPropertyChanging();
					this._Valoare = value;
					this.SendPropertyChanged("Valoare");
					this.OnValoareChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591
