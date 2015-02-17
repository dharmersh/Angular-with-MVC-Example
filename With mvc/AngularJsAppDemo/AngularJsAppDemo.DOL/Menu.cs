//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AngularJsAppDemo.DOL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Menu
    {
        public Menu()
        {
            this.RoleMenuMaps = new HashSet<RoleMenuMap>();
        }
    
        public int ID { get; set; }
        public int ParentID { get; set; }
        public string DisplayName { get; set; }
        public int DisplayOrder { get; set; }
        public bool IsAccess { get; set; }
        public bool IsActive { get; set; }
        public bool IsExtraAccess { get; set; }
        public string ExtraAccessFunction { get; set; }
        public int ControllerNameID { get; set; }
        public int ActionID { get; set; }
    
        public virtual ControllerName ControllerName { get; set; }
        public virtual Action Action { get; set; }
        public virtual ICollection<RoleMenuMap> RoleMenuMaps { get; set; }
    }
}