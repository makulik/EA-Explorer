/*
 * Created by SharpDevelop.
 * User: Admin
 * Date: 10.04.2012
 * Time: 21:12
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing.Text;

namespace EAExplorer
{
	
	/// <summary>
	/// Description of Elements
	/// </summary>
	public class EABrowsableObjectsCollection<T>
	: System.Collections.CollectionBase
	, System.ComponentModel.ICustomTypeDescriptor
	{
		EA.Collection eaCollection;
		
		public EABrowsableObjectsCollection(EA.Collection eaCollection)
		{
			this.eaCollection = eaCollection;
		}

		// Collection methods
    	public void Add(T browsableObject)
	    {
	    }

    	public void Remove(T browsableObject)
	    { 
	    } 

    	public T this[ int index ]
	    { 
	        get
	        {
	        	return (T)eaCollection.GetAt((short)index);
	        }
	    }
    	
		// Implementation of ICustomTypeDescriptor: 
	    public String GetClassName()
	    {
	        return System.ComponentModel.TypeDescriptor.GetClassName(this,true);
	    }
	
	    public System.ComponentModel.AttributeCollection GetAttributes()
	    {
	        return System.ComponentModel.TypeDescriptor.GetAttributes(this,true);
	    }
	
	    public String GetComponentName()
	    {
	        return System.ComponentModel.TypeDescriptor.GetComponentName(this, true);
	    }
	
	    public System.ComponentModel.TypeConverter GetConverter()
	    {
	        return System.ComponentModel.TypeDescriptor.GetConverter(this, true);
	    }
	
	    public System.ComponentModel.EventDescriptor GetDefaultEvent() 
	    {
	        return System.ComponentModel.TypeDescriptor.GetDefaultEvent(this, true);
	    }
	
	    public System.ComponentModel.PropertyDescriptor GetDefaultProperty() 
	    {
	        return System.ComponentModel.TypeDescriptor.GetDefaultProperty(this, true);
	    }
	
	    public object GetEditor(Type editorBaseType) 
	    {
	        return System.ComponentModel.TypeDescriptor.GetEditor(this, editorBaseType, true);
	    }
	
	    public System.ComponentModel.EventDescriptorCollection GetEvents(Attribute[] attributes) 
	    {
	        return System.ComponentModel.TypeDescriptor.GetEvents(this, attributes, true);
	    }
	
	    public System.ComponentModel.EventDescriptorCollection GetEvents()
	    {
	        return System.ComponentModel.TypeDescriptor.GetEvents(this, true);
	    }
	
	    public object GetPropertyOwner(System.ComponentModel.PropertyDescriptor pd) 
	    {
	        return this;
	    }
	    
	    public System.ComponentModel.PropertyDescriptorCollection GetProperties(Attribute[] attributes)
	    {
	        return GetProperties();
	    }

	    public System.ComponentModel.PropertyDescriptorCollection GetProperties() 
	    {
	        // Create a new collection object PropertyDescriptorCollection
	        System.ComponentModel.PropertyDescriptorCollection pds = new System.ComponentModel.PropertyDescriptorCollection(null);
	
	        // Iterate the list of employees
	        for( short i=0; i < eaCollection.Count; ++i )
	        {
	            // For each Element create a property descriptor 
	            // and add it to the PropertyDescriptorCollection instance
	            BrowsableCollectionPropertyDescriptor<T> pd =
	            	new BrowsableCollectionPropertyDescriptor<T>(this,i);
	            pds.Add(pd);
	        }
	        return pds;
	    }	    
	}

	public class BrowsableCollectionPropertyDescriptor<T>
	: System.ComponentModel.PropertyDescriptor
	{
	    private EABrowsableObjectsCollection<T> collection = null;
	    private int index = -1;
	    private System.ComponentModel.ExpandableObjectConverter converter = null;
	
	    public BrowsableCollectionPropertyDescriptor(EABrowsableObjectsCollection<T> coll, int idx) 
	    : base( "#"+idx.ToString(), null )
	    {
	        this.collection = coll;
	        this.index = idx;
	        this.converter = new EABrowsableObjectConverter<T>();
	    } 
	
	    public override System.ComponentModel.AttributeCollection Attributes
	    {
	        get 
	        { 
	            return new System.ComponentModel.AttributeCollection(null);
	        }
	    }
	
	    public override bool CanResetValue(object component)
	    {
	        return true;
	    }
	
	    public override Type ComponentType
	    {
	        get 
	        { 
	            return collection.GetType();
	        }
	    }
	    
		public override System.ComponentModel.TypeConverter Converter 
		{
			get 
			{ 
				return converter;
			}
		}
	
//	    public override string DisplayName
//	    {
//	        get 
//	        {
//	            T browsableObject = collection[index];
//	            return browsableObject.Name;
//	        }
//	    }
//	
//	    public override string Description
//	    {
//	        get
//	        {
//	            T browsableObject = collection[index];
//	            return browsableObject.Notes;
//	        }
//	    }
	
	    public override object GetValue(object component)
	    {
	    	return collection[index];
	    }
	
	    public override bool IsReadOnly
	    {
	        get { return true;  }
	    }
	
	    public override string Name
	    {
	        get { return "#"+index.ToString(); }
	    }
	
	    public override Type PropertyType
	    {
	    	get { return collection[index].GetType(); }
	    }
	
	    public override void ResetValue(object component) 
	    {
	    }
	
	    public override bool ShouldSerializeValue(object component)
	    {
	        return true;
	    }
	
	    public override void SetValue(object component, object value)
	    {
	        // this.collection[index] = value;
	    }
	}
	
	public class EABrowsableObjectConverter<T>
	: System.ComponentModel.ExpandableObjectConverter
	{
		public override object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, Type destinationType)
		{
			T browsableObject = (T)value;
			return base.ConvertTo(context,culture,browsableObject,browsableObject.GetType());
		}
	}
}