﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34003
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LINQ_Project__minegen_
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="LinqToSqlBb")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertAuthor(Author instance);
    partial void UpdateAuthor(Author instance);
    partial void DeleteAuthor(Author instance);
    partial void InsertBook(Book instance);
    partial void UpdateBook(Book instance);
    partial void DeleteBook(Book instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::LINQ_Project__minegen_.Properties.Settings.Default.LinqToSqlBbConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Author> Authors
		{
			get
			{
				return this.GetTable<Author>();
			}
		}
		
		public System.Data.Linq.Table<Book> Books
		{
			get
			{
				return this.GetTable<Book>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Author")]
	public partial class Author : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Author_ID;
		
		private string _Author_Name;
		
		private System.Nullable<int> _Age;
		
		private string _Born_In;
		
		private string _Genre;
		
		private string _Startyear;
		
		private EntitySet<Book> _Books;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnAuthor_IDChanging(int value);
    partial void OnAuthor_IDChanged();
    partial void OnAuthor_NameChanging(string value);
    partial void OnAuthor_NameChanged();
    partial void OnAgeChanging(System.Nullable<int> value);
    partial void OnAgeChanged();
    partial void OnBorn_InChanging(string value);
    partial void OnBorn_InChanged();
    partial void OnGenreChanging(string value);
    partial void OnGenreChanged();
    partial void OnStartyearChanging(string value);
    partial void OnStartyearChanged();
    #endregion
		
		public Author()
		{
			this._Books = new EntitySet<Book>(new Action<Book>(this.attach_Books), new Action<Book>(this.detach_Books));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Author_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Author_ID
		{
			get
			{
				return this._Author_ID;
			}
			set
			{
				if ((this._Author_ID != value))
				{
					this.OnAuthor_IDChanging(value);
					this.SendPropertyChanging();
					this._Author_ID = value;
					this.SendPropertyChanged("Author_ID");
					this.OnAuthor_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Author_Name", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
		public string Author_Name
		{
			get
			{
				return this._Author_Name;
			}
			set
			{
				if ((this._Author_Name != value))
				{
					this.OnAuthor_NameChanging(value);
					this.SendPropertyChanging();
					this._Author_Name = value;
					this.SendPropertyChanged("Author_Name");
					this.OnAuthor_NameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Age", DbType="Int")]
		public System.Nullable<int> Age
		{
			get
			{
				return this._Age;
			}
			set
			{
				if ((this._Age != value))
				{
					this.OnAgeChanging(value);
					this.SendPropertyChanging();
					this._Age = value;
					this.SendPropertyChanged("Age");
					this.OnAgeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Born_In", DbType="VarChar(255)")]
		public string Born_In
		{
			get
			{
				return this._Born_In;
			}
			set
			{
				if ((this._Born_In != value))
				{
					this.OnBorn_InChanging(value);
					this.SendPropertyChanging();
					this._Born_In = value;
					this.SendPropertyChanged("Born_In");
					this.OnBorn_InChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Genre", DbType="VarChar(255)")]
		public string Genre
		{
			get
			{
				return this._Genre;
			}
			set
			{
				if ((this._Genre != value))
				{
					this.OnGenreChanging(value);
					this.SendPropertyChanging();
					this._Genre = value;
					this.SendPropertyChanged("Genre");
					this.OnGenreChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Startyear", DbType="VarChar(255)")]
		public string Startyear
		{
			get
			{
				return this._Startyear;
			}
			set
			{
				if ((this._Startyear != value))
				{
					this.OnStartyearChanging(value);
					this.SendPropertyChanging();
					this._Startyear = value;
					this.SendPropertyChanged("Startyear");
					this.OnStartyearChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Author_Book", Storage="_Books", ThisKey="Author_ID", OtherKey="Author")]
		public EntitySet<Book> Books
		{
			get
			{
				return this._Books;
			}
			set
			{
				this._Books.Assign(value);
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
		
		private void attach_Books(Book entity)
		{
			this.SendPropertyChanging();
			entity.Author1 = this;
		}
		
		private void detach_Books(Book entity)
		{
			this.SendPropertyChanging();
			entity.Author1 = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Book")]
	public partial class Book : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Book_ID;
		
		private System.Nullable<int> _Author;
		
		private string _Book_Name;
		
		private string _ReleaseYear;
		
		private string _BookLanguage;
		
		private EntityRef<Author> _Author1;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnBook_IDChanging(int value);
    partial void OnBook_IDChanged();
    partial void OnAuthorChanging(System.Nullable<int> value);
    partial void OnAuthorChanged();
    partial void OnBook_NameChanging(string value);
    partial void OnBook_NameChanged();
    partial void OnReleaseYearChanging(string value);
    partial void OnReleaseYearChanged();
    partial void OnBookLanguageChanging(string value);
    partial void OnBookLanguageChanged();
    #endregion
		
		public Book()
		{
			this._Author1 = default(EntityRef<Author>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Book_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Book_ID
		{
			get
			{
				return this._Book_ID;
			}
			set
			{
				if ((this._Book_ID != value))
				{
					this.OnBook_IDChanging(value);
					this.SendPropertyChanging();
					this._Book_ID = value;
					this.SendPropertyChanged("Book_ID");
					this.OnBook_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Author", DbType="Int")]
		public System.Nullable<int> Author
		{
			get
			{
				return this._Author;
			}
			set
			{
				if ((this._Author != value))
				{
					if (this._Author1.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnAuthorChanging(value);
					this.SendPropertyChanging();
					this._Author = value;
					this.SendPropertyChanged("Author");
					this.OnAuthorChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Book_Name", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
		public string Book_Name
		{
			get
			{
				return this._Book_Name;
			}
			set
			{
				if ((this._Book_Name != value))
				{
					this.OnBook_NameChanging(value);
					this.SendPropertyChanging();
					this._Book_Name = value;
					this.SendPropertyChanged("Book_Name");
					this.OnBook_NameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ReleaseYear", DbType="VarChar(4)")]
		public string ReleaseYear
		{
			get
			{
				return this._ReleaseYear;
			}
			set
			{
				if ((this._ReleaseYear != value))
				{
					this.OnReleaseYearChanging(value);
					this.SendPropertyChanging();
					this._ReleaseYear = value;
					this.SendPropertyChanged("ReleaseYear");
					this.OnReleaseYearChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BookLanguage", DbType="VarChar(255)")]
		public string BookLanguage
		{
			get
			{
				return this._BookLanguage;
			}
			set
			{
				if ((this._BookLanguage != value))
				{
					this.OnBookLanguageChanging(value);
					this.SendPropertyChanging();
					this._BookLanguage = value;
					this.SendPropertyChanged("BookLanguage");
					this.OnBookLanguageChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Author_Book", Storage="_Author1", ThisKey="Author", OtherKey="Author_ID", IsForeignKey=true)]
		public Author Author1
		{
			get
			{
				return this._Author1.Entity;
			}
			set
			{
				Author previousValue = this._Author1.Entity;
				if (((previousValue != value) 
							|| (this._Author1.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Author1.Entity = null;
						previousValue.Books.Remove(this);
					}
					this._Author1.Entity = value;
					if ((value != null))
					{
						value.Books.Add(this);
						this._Author = value.Author_ID;
					}
					else
					{
						this._Author = default(Nullable<int>);
					}
					this.SendPropertyChanged("Author1");
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
