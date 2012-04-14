/*
 * Created by SharpDevelop.
 * User: Admin
 * Date: 11.04.2012
 * Time: 19:17
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Runtime.Remoting.Messaging;

namespace EAExplorer
{
	/// <summary>
	/// Description of EAPackageCollections.
	/// </summary>
	public class EAPackageCollections
	{
		EABrowsableObjectsCollection<EA.Connector> connectors;
		EABrowsableObjectsCollection<EA.Element> elements;
		EABrowsableObjectsCollection<EA.Package> packages;
		EA.Element element;
		
		public EAPackageCollections(EA.Package package)
		{
			this.connectors = new EABrowsableObjectsCollection<EA.Connector>(package.Connectors);
			this.element = package.Element;
			this.elements = new EABrowsableObjectsCollection<EA.Element>(package.Elements);
			this.packages = new EABrowsableObjectsCollection<EA.Package>(package.Packages);
		}
		
		[System.ComponentModel.TypeConverter(typeof(System.ComponentModel.ExpandableObjectConverter))]
		public EABrowsableObjectsCollection<EA.Connector> Connectors
		{
			get { return connectors; } 
		}
		[System.ComponentModel.TypeConverter(typeof(System.ComponentModel.ExpandableObjectConverter))]
		public EA.Element Element
		{
			get { return element; }
		}
		[System.ComponentModel.TypeConverter(typeof(System.ComponentModel.ExpandableObjectConverter))]
		public EABrowsableObjectsCollection<EA.Element> Elements
		{
			get { return elements; }
		}
		[System.ComponentModel.TypeConverter(typeof(System.ComponentModel.ExpandableObjectConverter))]
		public EABrowsableObjectsCollection<EA.Package> Packages
		{
			get { return packages; }
		}
	}
}
