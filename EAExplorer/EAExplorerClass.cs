using System;
using System.Windows.Forms;

namespace EAExplorer
{
	public class EAExplorerClass : EAAddinFramework.EAAddinBase
    {
        // define menu constants
        const string menuName = "-&EA Explorer";
        const string menuAbout = "&About";
        
        // the control to add to the add-in window
        private EAExplorerControl eaControl;
        
        /// <summary>
        /// constructor where we set the menuheader and menuOptions
        /// </summary>
		public EAExplorerClass():base()
		{
			this.menuHeader = menuName;
			this.menuOptions = new string[]{menuAbout};
		}
		/// <summary>
        /// EA_Connect events enable Add-Ins to identify their type and to respond to Enterprise Architect start up.
        /// This event occurs when Enterprise Architect first loads your Add-In. Enterprise Architect itself is loading at this time so that while a Repository object is supplied, there is limited information that you can extract from it.
        /// The chief uses for EA_Connect are in initializing global Add-In data and for identifying the Add-In as an MDG Add-In.
        /// Also look at EA_Disconnect.
        /// </summary>	
        /// <param name="Repository">An EA.Repository object representing the currently open Enterprise Architect model.
        /// Poll its members to retrieve model data and user interface status information.</param>
        /// <returns>String identifying a specialized type of Add-In: 
        /// - "MDG" : MDG Add-Ins receive MDG Events and extra menu options.
        /// - "" : None-specialized Add-In.</returns>
		public override string EA_Connect(EA.Repository Repository)
		{
			this.eaControl = Repository.AddWindow("Explorer","EAExplorer.EAExplorerControl") as EAExplorerControl;
			return base.EA_Connect(Repository);
		}
        /// <summary>
        /// Called once Menu has been opened to see what menu items should active.
        /// </summary>
        /// <param name="Repository">the repository</param>
        /// <param name="Location">the location of the menu</param>
        /// <param name="MenuName">the name of the menu</param>
        /// <param name="ItemName">the name of the menu item</param>
        /// <param name="IsEnabled">boolean indicating whethe the menu item is enabled</param>
        /// <param name="IsChecked">boolean indicating whether the menu is checked</param>
        public override void EA_GetMenuState(EA.Repository Repository, string Location, string MenuName, string ItemName, ref bool IsEnabled, ref bool IsChecked)
        {
            switch (ItemName)
            {
                // define the state of the hello menu option
                case menuAbout:
                	IsEnabled = true;
                    return;
            }
            if (IsProjectOpen(Repository))
            {
                switch (ItemName)
                {
                    default:
                        IsEnabled = false;
                        break;
                }
            }
        }

        /// <summary>
        /// Called when user makes a selection in the menu.
        /// This is your main exit point to the rest of your Add-in
        /// </summary>
        /// <param name="Repository">the repository</param>
        /// <param name="Location">the location of the menu</param>
        /// <param name="MenuName">the name of the menu</param>
        /// <param name="ItemName">the name of the selected menu item</param>
        public override void EA_MenuClick(EA.Repository Repository, string Location, string MenuName, string ItemName)
        {
            switch (ItemName)
            {
                case menuAbout:
                    this.showAboutDialog();
                    break;

            }
        }
        /// <summary>
        /// Called when EA start model validation. Just shows a message box
        /// </summary>
        /// <param name="Repository">the repository</param>
        /// <param name="Args">the arguments</param>
		public override void EA_OnStartValidation(EA.Repository Repository, object Args)
		{
			MessageBox.Show("Validation started");
		}
		/// <summary>
		/// Called when EA ends model validation. Just shows a message box
		/// </summary>
		/// <param name="Repository">the repository</param>
		/// <param name="Args">the arguments</param>
		public override void EA_OnEndValidation(EA.Repository Repository, object Args)
		{
			MessageBox.Show("Validation ended");
		}
		/// <summary>
		/// called when the selected item changes
		/// This operation will show the guid of the selected element in the eaControl
		/// </summary>
		/// <param name="Repository">the EA.Repository</param>
		/// <param name="GUID">the guid of the selected item</param>
		/// <param name="ot">the object type of the selected item</param>
		public override void EA_OnContextItemChanged(EA.Repository Repository, string GUID, EA.ObjectType ot)
		{
			if (this.eaControl == null)
				this.eaControl = Repository.AddWindow("Explorer","EAExplorer.EAExplorerControl") as EAExplorerControl;
			if (this.eaControl != null)
				this.eaControl.showObjectProperties(Repository,GUID,ot);
		}
        /// <summary>
        /// Say Hello to the world
        /// </summary>
        private void showAboutDialog()
        {
        	DlgAbout dlgAbout = new DlgAbout();
        	dlgAbout.ShowDialog();
        }
    }
}
