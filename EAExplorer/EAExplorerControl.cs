using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace EAExplorer
{
	[Guid("AA1EC283-9C34-4AE4-9D39-6811EE545DDC")]
	[ComVisible(true)]
	/// <summary>
	/// Description of EAExplorerControl.
	/// </summary>
	public partial class EAExplorerControl : UserControl
	{
		object currentEaObject;
		object currentEaObjectCollections;
		
		public EAExplorerControl()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			showEmbeddedObjects.CheckedChanged += OnShowEmbeddedObjectsChanged;
		}
		
		public void showObjectProperties(EA.Repository Repository, string GUID, EA.ObjectType ot)
		{			
			eaObjectType.Text = ot.ToString();
			eaObjectName.Text = "?";
			showEmbeddedObjects.Checked = false;
			switch(ot)
			{
				case EA.ObjectType.otAttribute:
					EA.Attribute attribute = Repository.GetAttributeByGuid(GUID);
					currentEaObject = attribute;
					eaObjectName.Text = attribute.Name;
					propertyGrid.SelectedObject = attribute;
					showEmbeddedObjects.Enabled = false;
					break;
				case EA.ObjectType.otElement:
					EA.Element element = Repository.GetElementByGuid(GUID);
					currentEaObject = element;
					currentEaObjectCollections = GetElementCollections(element);
					eaObjectName.Text = element.Name;
					showEmbeddedObjects.Enabled = true;
					break;
				case EA.ObjectType.otMethod:
					EA.Method method = Repository.GetMethodByGuid(GUID);
					currentEaObject = method;
					eaObjectName.Text = method.Name;
					propertyGrid.SelectedObject = method;
					showEmbeddedObjects.Enabled = false;
					break;
				case EA.ObjectType.otPackage:
					EA.Package package = Repository.GetPackageByGuid(GUID);
					currentEaObject = package;
					eaObjectName.Text = package.Name;
					showEmbeddedObjects.Enabled = true;
					propertyGrid.SelectedObject = package;
					break;
				case EA.ObjectType.otConnector:
					EA.Connector connector = Repository.GetConnectorByGuid(GUID);
					currentEaObject = connector;
					showEmbeddedObjects.Enabled = false;
					break;
				default:
					currentEaObject = null;
					currentEaObjectCollections = null;
					propertyGrid.SelectedObject = null;
					showEmbeddedObjects.Enabled = false;
					break;
			}
			SynchPropertyGridSelection();
		}
		
		void OnShowEmbeddedObjectsChanged(object sender, EventArgs eventArgs)
		{
			SynchPropertyGridSelection();
		} 
		
		object GetElementCollections(EA.Element element)
		{
			EAElementCollections eaElementCollections = 
				new EAElementCollections(element.EmbeddedElements,element.Attributes,element.Methods,element.Connectors);
			return eaElementCollections;
		}

		object GetPackageCollections(EA.Package package)
		{
			System.Collections.Generic.Dictionary<string,EA.Collection> packageCollections = new System.Collections.Generic.Dictionary<string,EA.Collection>();
			packageCollections["Embedded Elements"] = package.Elements;
			packageCollections["Embedded Packages"] = package.Packages;
			return packageCollections;
		}

		void SynchPropertyGridSelection()
		{
			if(showEmbeddedObjects.Checked)
			{
				propertyGrid.SelectedObject = currentEaObjectCollections;
			}
			else
			{
				propertyGrid.SelectedObject = currentEaObject;
			}
		}
	}
}
