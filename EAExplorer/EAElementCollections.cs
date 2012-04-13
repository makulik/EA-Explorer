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
	/// Description of EAElementCollections.
	/// </summary>
	public class EAElementCollections
	{
		EABrowsableObjectsCollection<EA.Attribute> attributes;
		EABrowsableObjectsCollection<EA.Attribute> attributesEx;
		EABrowsableObjectsCollection<EA.Element> baseClasses;
		EABrowsableObjectsCollection<EA.Connector> connectors;
		EABrowsableObjectsCollection<EA.Constraint> constraints;
		EABrowsableObjectsCollection<EA.Constraint> constraintsEx;
		EABrowsableObjectsCollection<EA.Element> elements;
		EABrowsableObjectsCollection<EA.Element> embeddedElements;
		EABrowsableObjectsCollection<EA.Effort> efforts;
		EABrowsableObjectsCollection<EA.File> files;
		EABrowsableObjectsCollection<EA.Method> methods;
		EABrowsableObjectsCollection<EA.Method> methodsEx;
		EABrowsableObjectsCollection<EA.Requirement> requirements;
		EABrowsableObjectsCollection<EA.Requirement> requirementsEx;
		EABrowsableObjectsCollection<EA.Resource> resources;
		EABrowsableObjectsCollection<EA.Risk> risks;
		EABrowsableObjectsCollection<EA.Scenario> scenarios;
		EABrowsableObjectsCollection<EA.TaggedValue> taggedValues;
		EABrowsableObjectsCollection<EA.TaggedValue> taggedValuesEx;
		EABrowsableObjectsCollection<EA.Test> tests;
		
		public EAElementCollections(EA.Element element)
		{
			this.attributes = new EABrowsableObjectsCollection<EA.Attribute>(element.Attributes);
			this.attributesEx = new EABrowsableObjectsCollection<EA.Attribute>(element.AttributesEx);
			this.baseClasses = new EABrowsableObjectsCollection<EA.Element>(element.BaseClasses);
			this.connectors = new EABrowsableObjectsCollection<EA.Connector>(element.Connectors);
			this.constraints = new EABrowsableObjectsCollection<EA.Constraint>(element.Constraints);
			this.constraintsEx = new EABrowsableObjectsCollection<EA.Constraint>(element.ConstraintsEx);
			this.elements = new EABrowsableObjectsCollection<EA.Element>(element.Elements);
			this.embeddedElements = new EABrowsableObjectsCollection<EA.Element>(element.EmbeddedElements);
			this.efforts = new EABrowsableObjectsCollection<EA.Effort>(element.Efforts);
			this.files = new EABrowsableObjectsCollection<EA.File>(element.Files);
			this.methods = new EABrowsableObjectsCollection<EA.Method>(element.Methods);
			this.methodsEx = new EABrowsableObjectsCollection<EA.Method>(element.MethodsEx);
			this.requirements = new EABrowsableObjectsCollection<EA.Requirement>(element.Requirements);
			this.requirementsEx = new EABrowsableObjectsCollection<EA.Requirement>(element.RequirementsEx);
			this.resources = new EABrowsableObjectsCollection<EA.Resource>(element.Resources);
			this.risks = new EABrowsableObjectsCollection<EA.Risk>(element.Risks);
			this.scenarios = new EABrowsableObjectsCollection<EA.Scenario>(element.Scenarios);
			this.taggedValues = new EABrowsableObjectsCollection<EA.TaggedValue>(element.TaggedValues);
			this.taggedValuesEx = new EABrowsableObjectsCollection<EA.TaggedValue>(element.TaggedValuesEx);
			this.tests = new EABrowsableObjectsCollection<EA.Test>(element.Tests);
		}
		
		[System.ComponentModel.TypeConverter(typeof(System.ComponentModel.ExpandableObjectConverter))]
		public EABrowsableObjectsCollection<EA.Attribute> Attributes
		{
			get { return attributes; }
		}
		[System.ComponentModel.TypeConverter(typeof(System.ComponentModel.ExpandableObjectConverter))]
		public EABrowsableObjectsCollection<EA.Attribute> AttributesEx
		{
			get { return attributesEx; }
		}
		[System.ComponentModel.TypeConverter(typeof(System.ComponentModel.ExpandableObjectConverter))]
		public EABrowsableObjectsCollection<EA.Element> BaseClasses
		{
			get { return baseClasses; }
		}
		[System.ComponentModel.TypeConverter(typeof(System.ComponentModel.ExpandableObjectConverter))]
		public EABrowsableObjectsCollection<EA.Connector> Connectors
		{
			get { return connectors; } 
		}
		[System.ComponentModel.TypeConverter(typeof(System.ComponentModel.ExpandableObjectConverter))]
		public EABrowsableObjectsCollection<EA.Constraint> Constraints
		{
			get { return constraints; }
		}
		[System.ComponentModel.TypeConverter(typeof(System.ComponentModel.ExpandableObjectConverter))]
		public EABrowsableObjectsCollection<EA.Constraint> ConstraintsEx
		{
			get { return constraintsEx; }
		}
		[System.ComponentModel.TypeConverter(typeof(System.ComponentModel.ExpandableObjectConverter))]
		public EABrowsableObjectsCollection<EA.Element> Elements
		{
			get { return elements; }
		}
		[System.ComponentModel.TypeConverter(typeof(System.ComponentModel.ExpandableObjectConverter))]
		public EABrowsableObjectsCollection<EA.Element> EmbeddedElements
		{
			get { return embeddedElements; }
		}
		[System.ComponentModel.TypeConverter(typeof(System.ComponentModel.ExpandableObjectConverter))]
		public EABrowsableObjectsCollection<EA.Effort> Efforts
		{
			get { return efforts; }
		}
		[System.ComponentModel.TypeConverter(typeof(System.ComponentModel.ExpandableObjectConverter))]
		public EABrowsableObjectsCollection<EA.File> Files
		{
			get { return files; }
		}
		[System.ComponentModel.TypeConverter(typeof(System.ComponentModel.ExpandableObjectConverter))]
		public EABrowsableObjectsCollection<EA.Method> Methods
		{
			get { return methods; }
		}
		[System.ComponentModel.TypeConverter(typeof(System.ComponentModel.ExpandableObjectConverter))]
		public EABrowsableObjectsCollection<EA.Method> MethodsEx
		{
			get { return methodsEx; }
		}
		[System.ComponentModel.TypeConverter(typeof(System.ComponentModel.ExpandableObjectConverter))]
		public EABrowsableObjectsCollection<EA.Requirement> Requirements
		{
			get { return requirements; }
		}
		[System.ComponentModel.TypeConverter(typeof(System.ComponentModel.ExpandableObjectConverter))]
		public EABrowsableObjectsCollection<EA.Requirement> RequirementsEx
		{
			get { return requirementsEx; }
		}
		[System.ComponentModel.TypeConverter(typeof(System.ComponentModel.ExpandableObjectConverter))]
		public EABrowsableObjectsCollection<EA.Resource> Resources
		{
			get { return resources; }
		}
		[System.ComponentModel.TypeConverter(typeof(System.ComponentModel.ExpandableObjectConverter))]
		public EABrowsableObjectsCollection<EA.Risk> Risks
		{
			get { return risks; }
		}
		[System.ComponentModel.TypeConverter(typeof(System.ComponentModel.ExpandableObjectConverter))]
		public EABrowsableObjectsCollection<EA.Scenario> Scenarios
		{
			get { return scenarios; }
		}
		[System.ComponentModel.TypeConverter(typeof(System.ComponentModel.ExpandableObjectConverter))]
		public EABrowsableObjectsCollection<EA.TaggedValue> TaggedValues
		{
			get { return taggedValues; }
		}
		[System.ComponentModel.TypeConverter(typeof(System.ComponentModel.ExpandableObjectConverter))]
		public EABrowsableObjectsCollection<EA.TaggedValue> TaggedValuesEx
		{
			get { return taggedValuesEx; }
		}
		[System.ComponentModel.TypeConverter(typeof(System.ComponentModel.ExpandableObjectConverter))]
		public EABrowsableObjectsCollection<EA.Test> Tests
		{
			get { return tests; }
		}
	}
}
