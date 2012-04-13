/*
 * Created by SharpDevelop.
 * User: Admin
 * Date: 11.04.2012
 * Time: 19:17
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace EAExplorer
{
	/// <summary>
	/// Description of EAElementCollections.
	/// </summary>
	public class EAElementCollections
	{
		EABrowsableObjectsCollection<EA.Element> embeddedElements;
		EABrowsableObjectsCollection<EA.Attribute> attributes;
		EABrowsableObjectsCollection<EA.Method> methods;
		EABrowsableObjectsCollection<EA.Connector> connectors;
		
		public EAElementCollections(EA.Collection embeddedElements, EA.Collection attributes, EA.Collection methods, EA.Collection connectors)
		{
			this.embeddedElements = new EABrowsableObjectsCollection<EA.Element>(embeddedElements);
			this.attributes = new EABrowsableObjectsCollection<EA.Attribute>(attributes);
			this.methods = new EABrowsableObjectsCollection<EA.Method>(methods);
			this.connectors = new EABrowsableObjectsCollection<EA.Connector>(connectors);
		}
		
		[System.ComponentModel.TypeConverter(typeof(System.ComponentModel.ExpandableObjectConverter))]
		public EABrowsableObjectsCollection<EA.Element> EmbeddedElements
		{
			get
			{
				return embeddedElements;
			}
		}

		[System.ComponentModel.TypeConverter(typeof(System.ComponentModel.ExpandableObjectConverter))]
		public EABrowsableObjectsCollection<EA.Attribute> Attributes
		{
			get
			{
				return attributes;
			}
		}

		[System.ComponentModel.TypeConverter(typeof(System.ComponentModel.ExpandableObjectConverter))]
		public EABrowsableObjectsCollection<EA.Method> Methods
		{
			get
			{
				return methods;
			}
		}
		
		[System.ComponentModel.TypeConverter(typeof(System.ComponentModel.ExpandableObjectConverter))]
		public EABrowsableObjectsCollection<EA.Connector> Connectors
		{
			get
			{
				return connectors;
			}
		}
	}
}
